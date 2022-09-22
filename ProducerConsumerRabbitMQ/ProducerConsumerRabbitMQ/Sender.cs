using RabbitMQ.Client;
using System;
using System.Text;

namespace Producer
{
    class Sender
    {
        static void Main()
        {
            // Entrypoint to the RabbitMQ client
            ConnectionFactory factory = new() { HostName = "localhost" };

            // Creates a connection with default configuration (hostname and port)
            using (IConnection connection = factory.CreateConnection())
            
            // Opens a new channel
            using (IModel channel = connection.CreateModel())
            {
                // Declares a new queue with name BasicTest
                channel.QueueDeclare("BasicTest", false, false, false, null);

                // The message to send
                string message = "Trying RabbitMQ";

                // Encodes the string message to an byte array
                byte[]? body = Encoding.UTF8.GetBytes(message);

                // Sends message to the BasicTest queue witout an specified exchange
                channel.BasicPublish("", "BasicTest", null, body);

                // Print out that the message have been sent
                Console.WriteLine($"Sent message: {message}");
            }

            Console.ReadKey();

        }
    }
}