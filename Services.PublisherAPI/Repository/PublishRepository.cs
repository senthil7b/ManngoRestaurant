using Mango.Website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Services.PublisherAPI.Models;
using System.IO;
using Google.Cloud.PubSub.V1;
using Google.Protobuf;

namespace Services.PublisherAPI.Repository
{
    public class PublishRepository : IPublishRepository
    {
        private static Google.Cloud.PubSub.V1.TopicName topicName = new Google.Cloud.PubSub.V1.TopicName(Constants.ProjectId, Constants.TopicId);

        private const string keyPath = @"C:\Users\senth\Microservices\ManngoRestaurant\Key\crack-braid-352522-4801d9726e39.json";
        public async Task<string> PublishMessage(MessageRequest messageRequest)
        {
            string messageId = string.Empty;
            try
            {
                Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", keyPath);

                PublisherClient publisher = await PublisherClient.CreateAsync(topicName, null, null);

                var publishMessage = new PubsubMessage()
                {
                    Data = ByteString.CopyFromUtf8(messageRequest.Message)
                };

                messageId = await publisher.PublishAsync(publishMessage);
            }
            catch(Exception ex)
            {

            }
            return messageId;
        }
    }
}
