using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lm.NetCore6.ConsoleApp.TaskCom
{
    public class TaskTest2
    {
        /// <summary>
        /// async表示异步方法，配合wait使用
        /// </summary>
        async static void AsyncFunction()
        {
            await Task.Delay(1); //延迟后续动作执行时间，同时会跳转到调用方法 Run() 中，在这延迟的1毫秒时间内，会先执行主方法 run()中的后续东西
            Console.WriteLine("使用System.Threading.Tasks.Task执行异步操作.");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(string.Format("AsyncFunction:i={0}", i));
            }
        }

        public static void Run()
        {
            Console.WriteLine("主线程执行业务处理.");
            AsyncFunction();
            Console.WriteLine("主线程执行其他处理");
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(string.Format("Main:i={0}", i));
            }
            Console.ReadLine();
        }
    }
}
