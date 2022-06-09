using Mango.Website.Models;
using Mango.Website.Services.IServices;
using System.Net.Http;
using System.Threading.Tasks;

namespace Mango.Website.Services
{
    public class MessageService : BaseService, IMessageService
    {
        private IHttpClientFactory _httpClientFactory;
        public MessageService(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
            this._httpClient = httpClientFactory;
        }
        public async Task<T> SendMessageToSubscriber<T>(MessageRequest messageRequest)
        {
            return await this.SendAsync<T>(new APIRequest()
            {
                aPIType = Constants.APIType.POST,
                Data = messageRequest,
                URL = Constants.ProductAPIBase + "/api/publish",
                AccessToken = ""
            });
        }
    }
}
