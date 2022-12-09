using LM.Delegate.ConsoleApp.Hander;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LM.Delegate.ConsoleApp.TestClass
{
    public class MyGeneric<T>
    {
        private T t;

        public MyGeneric(T t)
        {
            this.t = t;
        }



        //public MyGeneric()
        //{

        //}
    }




    public class TestMyGetnric 
    {
        public void TestFun1() 
        {
            MyGeneric<Body> myGeneric = new MyGeneric<Body>(new Body());
        }

        public string Show<T>(T t, int a) where T:new() 
        {
            return t.ToString() + a;
        }


        public void ShowVoid<T>(T t) where T : new()
        {
            Console.WriteLine("ShowVoid");
        }

        public void ShowVoid1()
        {
            Console.WriteLine("ShowVoid");
        }

        public void TestFun2() 
        {
            var mo = ShowVoid<User>;
            //PrintHandler<User> printHandler = ShowVoid1;

        }
    }

    public enum EnumType 
    {
        A,
        B
    }

    public delegate void PrintHandler<T>() where T:new();
}
