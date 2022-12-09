using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LM.NetCore6.Common
{
    public class RabbitMqHelper
    {
        /// <summary>
        /// 获取rabbitmq连接
        /// </summary>
        /// <returns></returns>
        public static IConnection GetConnect() 
        {
            var factory = new ConnectionFactory
            {
                HostName = "127.0.0.1",
                Port = 5672,
                UserName = "admin",
                Password = "admin",
                VirtualHost = "/"
            };
            return factory.CreateConnection();
        }
    }
}
