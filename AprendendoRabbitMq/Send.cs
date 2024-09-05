using RabbitMQ.Client;
using System.Text;

namespace AprendendoRabbitMq
{
    public class Send
    {
        public static void Main()
        {
            var factory = new ConnectionFactory()
            {
                HostName = "localhost",
                UserName = "admin",  // Usuário padrão do RabbitMQ
                Password = "admin"   // Senha padrão do RabbitMQ
            };

            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                string message = "Hello World!";
                var body = Encoding.UTF8.GetBytes(message);
                channel.BasicPublish(exchange: "Exchange1",
                                     routingKey: "a",
                                     basicProperties: null,
                                     body: body);
            }
        }
    }
}
