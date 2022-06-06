using Mango.Website.Models;
using Mango.Website.Services.IServices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Mango.Website.Services
{
    public class BaseService : IBaseService
    {
        public IHttpClientFactory _httpClient { get; set; }
        private ResponseDTO _responseDTO { get; set; }

        public BaseService(IHttpClientFactory httpClient)
        {
            this._httpClient = httpClient;
            this._responseDTO = new ResponseDTO();

        }
        public void Dispose()
        {
            
        }

        public async Task<T> SendAsync<T>(APIRequest aPIRequest)
        {
            try
            {
                var client = _httpClient.CreateClient("MangoAPI");
                HttpRequestMessage requestMessage = new HttpRequestMessage();
                requestMessage.Headers.Add("Accept", "application/json");
                requestMessage.RequestUri = new Uri(aPIRequest.URL);
                client.DefaultRequestHeaders.Clear();

                if(aPIRequest.Data != null)
                {
                    requestMessage.Content = new StringContent(JsonConvert.SerializeObject(aPIRequest.Data), Encoding.UTF8, "application/json");
                }

                HttpResponseMessage apiResponseMessage = null;

                switch(aPIRequest.aPIType)
                {
                    case Constants.APIType.POST:
                        requestMessage.Method = HttpMethod.Post;
                        break;
                    case Constants.APIType.PUT:
                        requestMessage.Method = HttpMethod.Put;
                        break;
                    case Constants.APIType.DELETE:
                        requestMessage.Method = HttpMethod.Delete;
                        break;
                    default:
                        requestMessage.Method = HttpMethod.Get;
                        break;
                }
                apiResponseMessage = await client.SendAsync(requestMessage);

                var apiContent = await apiResponseMessage.Content.ReadAsStringAsync();

                var apiResponseDTO = JsonConvert.DeserializeObject<T>(apiContent);

                return apiResponseDTO;
            }
            catch(Exception ex)
            {
                var dto = new ResponseDTO
                {
                    ErrorMessages = new List<string>
                    {
                        Convert.ToString(ex.Message)
                    },
                    DisplayMessage = "Error",
                    IsSuccess = false
                };

                var res = JsonConvert.SerializeObject(dto);
                var apiResponseDTO = JsonConvert.DeserializeObject<T>(res);

                return apiResponseDTO;
            }
        }
    }
}
