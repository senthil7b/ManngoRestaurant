using Microsoft.Azure.ServiceBus;
using Microsoft.Azure.ServiceBus.Core;
using Newtonsoft.Json;
using System;
using System.Text;
using System.Threading.Tasks;

namespace Mango.MessageBus
{
    public class AzureMessageBus : IMessageBus
    {
        
        private string messagBusConnectionString = "Endpoint=sb://microserviceservicebus.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=rEAtTiEKaComssNpdVk81VsboeDKMspeYAfJl3Gwv1k=";
        public async Task PublishMessage(BaseMessage baseMessage, string topic)
        {
            ISenderClient senderClient = new TopicClient(messagBusConnectionString, topic);

            var jsonMessage = JsonConvert.SerializeObject(baseMessage);
            var finalMessage = new Message(Encoding.UTF8.GetBytes(jsonMessage))
            {
                CorrelationId = Guid.NewGuid().ToString()
            };

            await senderClient.SendAsync(finalMessage);

            await senderClient.CloseAsync();

        }
    }
}
