using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lm.NetCore6.ConsoleApp.TaskCom
{
    /// <summary>
    /// 非UI线程中执行
    /// 该演示是在控制台应用程序中完成的，我们可以看到，主线程的ID为10，第一个await和紧接着之后的代码的线程ID为6和11，第二个await和紧接着之后的代码的线程ID为6，在非UI的线程中执行async异步方法，await等待的异步操作和之后接着要执行的代码，都是从线程池中获取了一个线程来执行代码，并且从线程池中获取的也不一定是同一个线程。
    ///————————————————
    ///版权声明：本文为CSDN博主「LG_985938339」的原创文章，遵循CC 4.0 BY-SA版权协议，转载请附上原文出处链接及本声明。
    ///原文链接：https://blog.csdn.net/weixin_44228698/article/details/108744762
    /// </summary>
    public class TaskTest3
    {
        public static void Run()
        {
            Console.WriteLine("当前主线程ID为：" + Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("是否为线程池线程：" + Thread.CurrentThread.IsThreadPoolThread);
            Console.WriteLine("-------1-------");
            MethodAsync1();

            Console.WriteLine("当前主线程ID为：" + Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("是否为线程池线程：" + Thread.CurrentThread.IsThreadPoolThread);
            Console.WriteLine("-------1.1-------");
            Console.Read();
        }
        static async void MethodAsync1()
        {
            Console.WriteLine("当前主线程ID为：" + Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("是否为线程池线程：" + Thread.CurrentThread.IsThreadPoolThread);
            Console.WriteLine("--------2------");

            await Task.Run(() => {
                Console.WriteLine("第一个await当前线程ID为：" + Thread.CurrentThread.ManagedThreadId);
                Console.WriteLine("是否为线程池线程：" + Thread.CurrentThread.IsThreadPoolThread);
                Console.WriteLine("-------3-------");
            });
            Console.WriteLine("第一个await结束后当前线程ID为：" + Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("是否为线程池线程：" + Thread.CurrentThread.IsThreadPoolThread);
            Console.WriteLine("--------4------");

            await Task.Run(() => {
                Console.WriteLine("第二个await当前线程ID为：" + Thread.CurrentThread.ManagedThreadId);
                Console.WriteLine("是否为线程池线程：" + Thread.CurrentThread.IsThreadPoolThread);
                Console.WriteLine("------5--------");
            });
            Console.WriteLine("第二个await结束后当前线程ID为：" + Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("是否为线程池线程：" + Thread.CurrentThread.IsThreadPoolThread);
        }



        #region 
        /// <summary>
        /// 获取异步方法的返回值：
        /// </summary>
        /// <param name="args"></param>
        public static void Run2()
        {
            var a = MethodAsync2();
            Console.WriteLine(a.Result);
            Console.Read();
        }
        static async Task<int> MethodAsync2()
        {
            return await Task.Run(() =>
            {
                Thread.Sleep(1000);
                return 1;
            });
        }
        #endregion 
    }
}
