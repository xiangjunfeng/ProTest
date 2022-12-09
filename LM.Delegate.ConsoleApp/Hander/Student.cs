using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LM.Delegate.ConsoleApp.Hander
{
    /// <summary>
    /// 类继承
    /// </summary>
    public class Student
    {
        private int Id;

        protected string Name;

        protected internal int Age;

        public int Sex;

    }



    public class Body : Student 
    {
        public void Test() 
        {
            this.Age = 1;
            this.Sex = 1;
            //base.Name
        }
    }

}
