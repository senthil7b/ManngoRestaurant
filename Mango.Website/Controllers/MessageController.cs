using Mango.Website.Models;
using Mango.Website.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mango.Website.Controllers
{
    public class MessageController : Controller
    {
        private MessageRequest _message;
        private IMessageService _messageService;
        public MessageController(IMessageService messageService)
        {
            this._messageService = messageService;
            this._message = new MessageRequest();
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
                return View(_message);
            }
            return View();
        }

    }
}
