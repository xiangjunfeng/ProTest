using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LM.Delegate.ConsoleApp.Hander
{
    //类
    public class Test1
    {
        public int Add(int a, int b) => a + b;

    }

    public class TestSub:Test1 
    {
        public int Add(int a ,int b) => a* b;
    }



   /// <summary>
   /// 抽象
   /// </summary>
    public abstract class Test2 
    {
        public abstract int Add(int a, int b);

        public abstract int Sub(int a, int b);
    }


    public class Test2Sub : Test2 
    {
        public int ID;

        public string Name { get; set; }

        public override int Add(int a, int b)
        {
            throw new NotImplementedException();
        }

        public override int Sub(int a, int b)
        {
            throw new NotImplementedException();
        }
    }

    
}
