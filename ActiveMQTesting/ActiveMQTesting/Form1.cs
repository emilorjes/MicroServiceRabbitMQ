using Apache.NMS;
using Apache.NMS.ActiveMQ;
using Apache.NMS.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActiveMQTesting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Establishing connection to ActiveMQ using the TCP protocol
        /// </summary>
        //private IConnection ConnectionToActiveMq()
        //{
        //    // IConnectionFactory connectionFactory = new NMSConnectionFactory("tcp://localhost:61616");


        //    return connection;
        //}

        private IConnection connection;
        private ISession session;
        private IMessageProducer producer;
        private static TimeSpan timeSpan = TimeSpan.FromSeconds(5);
        private void btnSendToQueue_Click(object sender, EventArgs e)
        {
            Uri connecturi = new Uri("activemq:tcp://localhost:61616");
            ConnectionFactory connectionFactory = new ConnectionFactory(connecturi);

            // Create a Connection
            this.connection = connectionFactory.CreateConnection();
            connection.RequestTimeout = timeSpan;
            this.connection.Start();

            // Create a Session
            this.session = connection.CreateSession(AcknowledgementMode.AutoAcknowledge);

            // Get the destination (Topic or Queue)
            IDestination destination = this.session.GetQueue("Queue");

            // Create a MessageProducer from the Session to the Topic or Queue
            this.producer = this.session.CreateProducer(destination);
            this.producer.DeliveryMode = MsgDeliveryMode.NonPersistent; 

            //Uri uri = new Uri("activemq:tcp://localhost:61616");
            //IConnectionFactory connectionFactory = new ConnectionFactory(uri);
            //IConnection connection = connectionFactory.CreateConnection();

            //connection.Start();

            //ISession session = connection.CreateSession(AcknowledgementMode.AutoAcknowledge);

            //IDestination destination = SessionUtil.GetDestination(session, "Queue");
            //IMessageProducer producer = session.CreateProducer(destination);

            //ITextMessage msg = producer.CreateTextMessage();
            //msg.Text = txtInput.Text;
            //producer.Send(msg);
            //session.Close();
            //connection.Stop();
        }
    }
}
