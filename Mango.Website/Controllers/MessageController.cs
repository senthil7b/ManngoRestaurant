using Mango.Website.Models;
using Mango.Website.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mango.Website.Controllers
{
    public class MessageController : Controller
    {
        private MessageRequest _message;
        private SubscriberResponse _subscriberMessage;
        private IMessageService _messageService;
        public MessageController(IMessageService messageService)
        {
            this._messageService = messageService;
            this._message = new MessageRequest();
            this._subscriberMessage = new SubscriberResponse()
            {
                SubscriberMessages = new List<string>()
            };
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(MessageRequest messageRequest)
        {
            if(messageRequest != null)
            {
                var response = await _messageService.SendMessageToSubscriber<ResponseDTO>(messageRequest);
                _message.Message = response.DisplayMessage;
                _message.MessageId = Convert.ToString(response.Result);
                
            }
            return RedirectToAction("PullMessage");
        }

        
        public async Task<IActionResult> PullMessage()
        {
            
            var response = await _messageService.PullMessage<ResponseDTO>();
            if(response?.Result != null)
            {
                string responseString = response.Result.ToString();
                
                if(!string.IsNullOrEmpty(responseString))
                {
                    var responseArray = JsonConvert.DeserializeObject<List<string>>(responseString);
                    if(responseArray?.Count > 0)
                        _subscriberMessage.SubscriberMessages.AddRange(responseArray);
                }
            }
            

            return View("Subscriber", _subscriberMessage);
        }

    }
}
