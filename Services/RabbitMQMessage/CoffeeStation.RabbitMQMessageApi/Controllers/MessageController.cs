using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace CoffeeStation.RabbitMQMessageApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MessageController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateMessage()
        {
            var connectionFactory = new ConnectionFactory() { HostName = "localhost" };

            var connection = connectionFactory.CreateConnection();

            var channel = connection.CreateModel();

            channel.QueueDeclare("Queue1", false, false, false, arguments: null);

            var messageContent = "Hello, this is a RabbitMQ queue message";

            //Gönderilecek mesaj değişkenin içeriğinin türü byte olmalıdır
            var byteMessageContent = Encoding.UTF8.GetBytes(messageContent);

            //Mesaj gönderme
            channel.BasicPublish(
                exchange: "",
                routingKey: "Queue1",
                basicProperties: null,
                body: byteMessageContent
            );

            return Ok("Your message has been queued");
        }

        private static string message;

        [HttpGet]
        public IActionResult ReadMessage()
        {
            var factory = new ConnectionFactory();
            factory.HostName = "localhost";
            var connection = factory.CreateConnection();
            var channel = connection.CreateModel();
            var consumer = new EventingBasicConsumer(channel);
            consumer.Received += (model, x) =>
            {
                var byteMessage = x.Body.ToArray();
                message = Encoding.UTF8.GetString(byteMessage);
            };
            channel.BasicConsume(queue: "Queue1", autoAck: false, consumer: consumer);
            if (string.IsNullOrEmpty(message))
            {
                return NoContent();
            }
            else
            {
                return Ok(message);
            }
        }
    }
}
