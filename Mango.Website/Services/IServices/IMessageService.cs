using Mango.Website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mango.Website.Services.IServices
{
    public interface IMessageService : IBaseService
    {
        Task<T> SendMessageToSubscriber<T>(MessageRequest messageRequest);

        Task<T> PullMessage<T>();
    }
}
