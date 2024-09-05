using AprendendoRabbitMq.Models;
using RabbitMQ.Client;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AprendendoRabbitMq
{
    public class Send
    {
        public static void Main(string _exchange, string _routingKey, Tarefa tarefa)
        {
            var factory = new ConnectionFactory()
            {
                HostName = "localhost",
                UserName = "admin",  // Usuário padrão criada por mim
                Password = "admin"   // Senha padrão criada por mim
            };

            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                //string message = "Hello World!";
                //var body = Encoding.UTF8.GetBytes(message);
                
                string message = JsonSerializer.Serialize(tarefa);
                var body = Encoding.UTF8.GetBytes(message);
                channel.BasicPublish(exchange: _exchange,
                                     routingKey: _routingKey,
                                     basicProperties: null,
                                     body: body);
            }
        }
    }
}
