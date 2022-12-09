using LM.NetCore6.Common;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LM.NetCore6.Provider.Normal
{
    public class Send
    {
        //发送消息
        public static void SendMessage() 
        {
            string queueName = "normal";
            using (var connection = RabbitMqHelper.GetConnect()) 
            {
                //创建信道
                using (var channel = connection.CreateModel()) 
                {
                    //创建队列
                    channel.QueueDeclare(queueName, false, false, false, null);
                    for(int i =0; i < 100;i++)
                    {
                        string message = $"hello rabbitmq message {i}";
                        var body = Encoding.UTF8.GetBytes(message);
                        //var properties = channel.CreateBasicProperties();
                        //properties.DeliveryMode = 2;
                        //channel.BasicPublish("", queueName, properties, body);
                        channel.BasicPublish("", queueName, null, body);
                        Thread.Sleep(1000);
                        Console.WriteLine($"send normal message {i} ");

                    }
                }
            }
        }
    }
}
