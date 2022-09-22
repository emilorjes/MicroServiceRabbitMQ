using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Text;

namespace Consumer
{
    class Receiver
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

                // Sets up a new consumer
                EventingBasicConsumer consumer = new(channel);

                //
                consumer.Received += (model, eventArgs) =>
                {
                    // ToArray can also be used insteed of Span. Span is more memory effectively  
                    ReadOnlySpan<byte> body = eventArgs.Body.Span;

                    // Encodes the messagage from byte to a string
                    string message = Encoding.UTF8.GetString(body);

                    // Print out the recived message
                    Console.WriteLine($"Received message: {message}");
                };

                //
                channel.BasicConsume("BasicTest", true, consumer);
                Console.ReadKey();
            }

            

        }
    }
}
