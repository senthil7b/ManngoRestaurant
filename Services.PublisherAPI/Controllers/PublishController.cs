using Mango.Website.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.PublisherAPI.Models;
using Services.PublisherAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.PublisherAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublishController : ControllerBase
    {
        protected PublishMessageResponse _response;
        private IPublishRepository _publishRepository;
        public PublishController(IPublishRepository publishRepository)
        {
            this._publishRepository = publishRepository;
            _response = new PublishMessageResponse();
        }

        [HttpPost]
        public async Task<object> Post([FromBody] MessageRequest messageRequest)
        {
            try
            {
                string messageId = await _publishRepository.PublishMessage(messageRequest);
                if (string.IsNullOrEmpty(messageId))
                {
                    _response.IsSuccess = false;
                    _response.Result = string.Empty;
                    _response.DisplayMessage = "Failed";
                }
                else
                {
                    _response.IsSuccess = true;
                    _response.Result = messageId;
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
