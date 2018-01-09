using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BNCSharp_Tests.Interface
{
    interface IComparable  //Specific functionality that classes can share
    {//I allows us to use the members of a class without having to know the exact type of the class
        int Compare(object o);
    }

    class Circle : IComparable //Same Notation as classinheritance
                               // use comma-separated list to define multiple interfaces for inheritance

    {
        int r;// a field to hold the radious of the circle

        public int Compare(object o)// we must now define the method compare
        {// the implemented membermust be public with the same sigature
            return r - (o as Circle).r;
        }
    }

    class MyClass
    {
        public static object Largest(IComparable a, IComparable b)// this method will work with all classes that implement IComparable regardless of their type
        {
            return (a.Compare(b) > 0) ? a : b;
        }
    }

    
}
