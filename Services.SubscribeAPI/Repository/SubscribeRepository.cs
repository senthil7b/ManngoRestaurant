using Google.Cloud.PubSub.V1;
using Services.SubscribeAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Services.SubscribeAPI.Repository
{
    public class SubscribeRepository : ISubscribeRepository
    {
        private static Google.Cloud.PubSub.V1.TopicName topicName = new Google.Cloud.PubSub.V1.TopicName(Constants.ProjectId, Constants.TopicId);

        private const string keyPath = @"C:\Users\senth\Microservices\ManngoRestaurant\Key\crack-braid-352522-4801d9726e39.json";
        public async Task<List<string>> PullMessage()
        {
            var messageList = new List<string>();

            try
            {
                Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", keyPath);

                SubscriptionName subscriptionName = SubscriptionName.FromProjectSubscription(Constants.ProjectId, Constants.SubscriptionId);

                SubscriberClient subscriber = await SubscriberClient.CreateAsync(subscriptionName);

                int messageCount = 0;

                Task startTask = subscriber.StartAsync((PubsubMessage message,
                    CancellationToken cancellationToken) =>
                {
                    string text = System.Text.Encoding.UTF8.GetString(message.Data.ToArray());
                    messageList.Add(message.MessageId + " - " + text);
                    Interlocked.Increment(ref messageCount);
                    return Task.FromResult(true ? SubscriberClient.Reply.Ack : SubscriberClient.Reply.Nack);
                });

                //var subscriptionName = new SubscriptionName(Constants.ProjectId, Constants.SubscriptionId);

                //var subscription = await SubscriberClient.CreateAsync(subscriptionName);

                //subscription.StartAsync
                //await Task.Delay(5000);
                await subscriber.StopAsync(CancellationToken.None);

                await startTask;
                

            }
            catch(Exception ex)
            {

            }
            return messageList;
        }
    }
}
