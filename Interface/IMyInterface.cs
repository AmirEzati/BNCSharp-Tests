using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BNCSharp_Tests.Interface
{
    //the second way we use interfaces is ...provide an actual interface for the class outwards
    interface IMyInterface //default internal AM// Naming convention
    {
        //Code Block only contains signature
        //just methods, properties, indexers, eveents
        //No body or implementation
        //No Access Modifiers for members
        //Default and always public AM for members

        void Relevat();
    }

    // this abstraction have 2 benefits:    access to only relevant members of that class
    // a more flexible class . implement a class any where we want


    class MyClass2 : IMyInterface
    {
        public void Relevat()
        {
            throw new NotImplementedException();
        }
    }
}
