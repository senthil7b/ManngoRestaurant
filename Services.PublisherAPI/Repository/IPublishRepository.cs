using Mango.Website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.PublisherAPI.Repository
{
    public interface IPublishRepository
    {
        Task<string> PublishMessage(MessageRequest messageRequest);
    }
}
