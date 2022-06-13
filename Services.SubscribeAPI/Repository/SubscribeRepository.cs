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

        private const string keyPath = @"C:\Users\senth\Microservices\ManngoRestaurant\Key\microservicesproject-352921-fd48f639629a.json";
        public async Task<List<string>> PullMessage()
        {
            var messageList = new List<string>();
            var messageByteArray = new List<byte>();
            try
            {
                Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", keyPath);

                SubscriptionName subscriptionName = SubscriptionName.FromProjectSubscription(Constants.ProjectId, Constants.SubscriptionId);


                /* Async Subscriber Logic - Start */

                //SubscriberClient subscriber = await SubscriberClient.CreateAsync(subscriptionName);

                //int messageCount = 0;

                //Task startTask = subscriber.StartAsync((PubsubMessage message,
                //    CancellationToken cancellationToken) =>
                //{
                //    string text = System.Text.Encoding.UTF8.GetString(message.Data.ToArray());
                //    messageList.Add(message.MessageId + " - " + text);
                //    Interlocked.Increment(ref messageCount);
                //    return Task.FromResult(true ? SubscriberClient.Reply.Ack : SubscriberClient.Reply.Nack);
                //});

                //await Task.Delay(5000);
                //await subscriber.StopAsync(CancellationToken.None);

                //await startTask;

                /* Async Subscriber Logic - End */


                /* Sync Subscriber Logic - Start */

                //SubscriberServiceApiClient syncSubscriber = SubscriberServiceApiClient.Create();

                //PullResponse responseMessage = syncSubscriber.Pull(subscriptionName, maxMessages: 20);

                //foreach(var msg in responseMessage.ReceivedMessages)
                //{
                //    string message = System.Text.Encoding.UTF8.GetString(msg.Message.Data.ToArray());

                //    messageList.Add("Message ID - '" + msg.Message.MessageId + "'. Text - '" + message + "'");

                //}
                /* Sync Subscriber Logic - End */

                /* Async Subscribe using SubscriberServiceApiClient - Start */
                SubscriberServiceApiClient subscriberService = await SubscriberServiceApiClient.CreateAsync();

                SubscriberClient subscriber = await SubscriberClient.CreateAsync(subscriptionName);
                List<PubsubMessage> receivedMessages = new List<PubsubMessage>();

                await subscriber.StartAsync((msg, CancellationToken) => 
                {
                    receivedMessages.Add(msg);
                    subscriber.StopAsync(TimeSpan.FromSeconds(20));
                    return Task.FromResult(SubscriberClient.Reply.Ack);
                 });

                foreach (var msg in receivedMessages)
                {
                        string message = System.Text.Encoding.UTF8.GetString(msg.Data.ToArray());

                        messageList.Add("Message ID - '" + msg.MessageId + "'. Text - '" + message + "'");
                }

                /* Async Subscribe using SubscriberServiceApiClient - ENd */
            }
            catch (Exception ex)
            {

            }
            return messageList;
        }
    }
}
