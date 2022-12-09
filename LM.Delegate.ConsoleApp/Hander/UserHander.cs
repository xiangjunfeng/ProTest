using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LM.Delegate.ConsoleApp.Hander
{
    /// <summary>
    /// 委托嵌套
    /// </summary>
    public class userHander
    {


        public void Show()
        {
            User user = new User();
            Action action = () =>
            {
                user.Say();
            };
            Type type = typeof(User);
            if (type.IsDefined(typeof(AbstractAttribute), false))
            {
                object[] attributes = type.GetCustomAttributes(typeof(AbstractAttribute), true);
                foreach (AbstractAttribute attribute in attributes)
                {
                    action = attribute.Do(action);
                }
            }

            action.Invoke();

        }



        public void Study() 
        {
            Action<int,int> action = (a ,b) => {
                int c = a + b;
            };

            Func<int, int, int> fun1 = (a, b) =>
            {
                return a + b;
            };

            Func<string> func2 = () => {
                return "test";
            };

            action.Invoke(1, 2);

            //action.BeginInvoke(2, 3, () => { },1)

            
        }
    }
}
