using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LM.Delegate.ConsoleApp.Hander
{
    /// <summary>
    /// 委托嵌套
    /// </summary>
    [LogBefore1]
    [LogBefore2]
    [LogAfter1]
    [LogAfter2]
    public class User
    {
        public string name;

        public void Say()
        {
            Console.WriteLine("hello word!");

        }
    }


    public abstract class AbstractAttribute : Attribute
    {
        public abstract Action Do(Action action);
    }


    public class LogBefore1Attribute : AbstractAttribute
    {
        public override Action Do(Action action)
        {
            Action _action = () =>
            {

                Console.WriteLine("-----------LogBefore1Attribute-------------");
                action.Invoke();
            };
            return _action;
        }
    }



    public class LogBefore2Attribute : AbstractAttribute
    {
        public override Action Do(Action action)
        {
            Action _action = () =>
            {

                Console.WriteLine("-----------LogBefore2Attribute-------------");
                action.Invoke();
            };
            return _action;
        }
    }


    public class LogAfter1Attribute : AbstractAttribute
    {
        public override Action Do(Action action)
        {
            Action _action = () =>
            {

                action.Invoke();
                Console.WriteLine("-----------LogAfter1Attribute-------------");
            };
            return _action;
        }
    }



    public class LogAfter2Attribute : AbstractAttribute
    {
        public override Action Do(Action action)
        {
            Action _action = () =>
            {

                action.Invoke();
                Console.WriteLine("-----------LogAfter2Attribute-------------");
            };
            return _action;
        }
    }
}
