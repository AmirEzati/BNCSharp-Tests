using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BNCSharp_Tests.Constructor
{
    public class A // This is the base class.
    {
        public A()
        {

        }
        public A(int value)
        {
            // Executes some code in the constructor.
            Console.WriteLine("Base constructor A()");
        }
    }

    public class B : A // This class derives from the previous class.
    {
        public B()
        {

        }
        public B(int value)
            : base(value)
        {
            // The base constructor is called first.
            // ... Then this code is executed.
            Console.WriteLine("Derived constructor B()");
        }
    }
}
