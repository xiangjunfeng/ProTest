using LM.NetCore6.Common;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace LM.NetCore6.Consumer.Normal
{
    public class Receive
    {
        public static void ReceiveMessage() 
        {
            string queueName = "normal";
            var connection = RabbitMqHelper.GetConnect();
            {
                //创建信道
                var channel = connection.CreateModel();
                {
                    //创建队列
                    channel.QueueDeclare(queueName, false, false, false, null);
                    var consumer = new EventingBasicConsumer(channel);
                    consumer.Received += (model, ea) => {
                        var message = Encoding.UTF8.GetString(ea.Body.ToArray());
                        Console.WriteLine("Normal Received > {0}",message);
                    };
                    channel.BasicConsume(queueName, true, consumer);

                    Console.WriteLine(" Press [enter] to exit.");
                    Console.ReadLine();
                }

            }
        }
    }
}
