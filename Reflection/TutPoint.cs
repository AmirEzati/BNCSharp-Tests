using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BNCSharp_Tests.Reflection
{
  public  class TutPoint
    {
        public TutPoint()
        {
            System.Reflection.MemberInfo info = typeof(MyClass);

            object[] attributes = info.GetCustomAttributes(true);

            for (int i = 0; i < attributes.Length; i++)
            {
                System.Console.WriteLine(attributes[i]);
            }
            Console.ReadKey();
        }
    }

    [AttributeUsage(AttributeTargets.All)]
    public class HelpAttribute : System.Attribute
    {
        public readonly string Url;

        public string Topic   // Topic is a named parameter
        {
            get
            {
                return topic;
            }
            set
            {
                topic = value;
            }
        }
        public HelpAttribute(string url)   // url is a positional parameter
        {
            this.Url = url;
        }
        private string topic;
    }

    [HelpAttribute("Information on the class MyClass",Topic ="topic 1")]
    class MyClass
    {

    }
}
