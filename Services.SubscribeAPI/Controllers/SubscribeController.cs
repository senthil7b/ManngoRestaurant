using Microsoft.AspNetCore.Mvc;
using Services.SubscribeAPI.Models;
using Services.SubscribeAPI.Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.SubscribeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribeController : ControllerBase
    {
        protected SubscribeMessageResponse _response;
        private ISubscribeRepository _subscribeRepository;
        public SubscribeController(ISubscribeRepository subscribeRepository)
        {
            this._subscribeRepository = subscribeRepository;
            _response = new SubscribeMessageResponse();
        }

        [HttpGet]
        public async Task<object> Get()
        {
            try
            {
                List<string> subscribedMessages = await _subscribeRepository.PullMessage();
                if (subscribedMessages?.Count == 0)
                {
                    _response.IsSuccess = false;
                    _response.Result = string.Empty;
                    _response.DisplayMessage = "Failed";
                }
                else
                {
                    _response.IsSuccess = true;
                    _response.Result = subscribedMessages;
                    _response.DisplayMessage = "Success";
                }
            }
            catch(Exception ex)
            {
                _response.IsSuccess = false;
                _response.Result = string.Empty;
                _response.ErrorMessages = new List<string>()
                {
                    ex.ToString()
                };
            }
            return _response;
        }
    }
}
