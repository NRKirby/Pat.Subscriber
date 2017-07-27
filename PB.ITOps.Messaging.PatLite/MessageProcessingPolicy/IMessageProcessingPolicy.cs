using System;
using System.Threading.Tasks;
using Microsoft.ServiceBus.Messaging;

namespace PB.ITOps.Messaging.PatLite.MessageProcessingPolicy
{
    public interface IMessageProcessingPolicy
    {
        IMessageProcessingPolicy NextPolicy { get; }
        Task OnMessageHandlerCompleted(BrokeredMessage message, string body);
        Task OnMessageHandlerFailed(BrokeredMessage message, string body, Exception ex);
        IMessageProcessingPolicy AppendPolicy(IMessageProcessingPolicy nextPolicy);
    }
}