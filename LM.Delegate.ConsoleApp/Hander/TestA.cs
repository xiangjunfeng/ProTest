using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LM.Delegate.ConsoleApp.Hander
{
    /// <summary>
    /// 扩展方法
    /// </summary>
    public class TestA
    {
        Student2 student = new Student2();
        
        public void Test() 
        {
            student.Study("java");
        }
    }

    public partial class Student2 
    {
        public string A;

        public string name { get; set; }

        
    }



    public static class UserA 
    {
        public static string Study(this Student2 student, string book) 
        {
            return $"test {book}";
        }
    }
}
