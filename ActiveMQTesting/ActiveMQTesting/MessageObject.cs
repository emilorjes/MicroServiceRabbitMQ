using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apache.NMS;


namespace ActiveMQTesting
{
    public class MessageObject : IMessage
    {
        public IPrimitiveMap Properties => throw new NotImplementedException();

        public string NMSCorrelationID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IDestination NMSDestination { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public TimeSpan NMSTimeToLive { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string NMSMessageId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public MsgDeliveryMode NMSDeliveryMode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public MsgPriority NMSPriority { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool NMSRedelivered { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IDestination NMSReplyTo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime NMSTimestamp { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string NMSType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime NMSDeliveryTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Acknowledge()
        {
            throw new NotImplementedException();
        }

        public Task AcknowledgeAsync()
        {
            throw new NotImplementedException();
        }

        public T Body<T>()
        {
            throw new NotImplementedException();
        }

        public void ClearBody()
        {
            throw new NotImplementedException();
        }

        public void ClearProperties()
        {
            throw new NotImplementedException();
        }

        public bool IsBodyAssignableTo(Type type)
        {
            throw new NotImplementedException();
        }
    }
}
