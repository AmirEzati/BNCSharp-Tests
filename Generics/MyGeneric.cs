using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BNCSharp_Tests.Generics
{
    public class MyGeneric//usage of type parameters--Design code templates to work with differe data types
    {//Generic methods, classes, interfaces/delegates/events

        public MyGeneric()
        {
            Console.WriteLine("S)SimpleSwap");

            switch (Console.ReadKey().KeyChar)
            {
                case 'S':
                    SimpleSwap();
                    break;
                case 'G':
                    GenericSwap();
                    break;
                case 'M':
                    MultiTypeGenericMethod();
                    break;
                case 'D':
                    DefaultValueForGenericMethod();
                    break;
                default:
                    break;
            }
        }

        public  void DefaultValueForGenericMethod()
        {

        }
        #region Generic method

        public static void GenericDefaultValues<T>(ref T a)
        {
           // a = T; //
            a =  default(T); //this value depends on the type
        }
        public static void SwapGeneric<T>(ref T a, ref T b)//T here is a type parameter-close between angle brackets
                                                           //The naming convention for type parameters- a capital T- this T canbe replaced by ayother type inside the method
        {
            T temp;
            temp = a;
            a = b;
            b = temp;
        }

        public static void Dummy<T, U>(T a, U b){
            Console.WriteLine("T passed type is: "+ a.GetType().FullName);
            Console.WriteLine("U passed type is: "+ b.GetType().FullName);
        }

        public static void Dummy<T, U, S>(T a,U b, S c) //Overloaded version of generic classes
        {
            Console.WriteLine("T passed type is: " + a.GetType().FullName);
            Console.WriteLine("U passed type is: " + b.GetType().FullName);
            Console.WriteLine("S passed type is: " + c.GetType().FullName);
        }
        #endregion

        public static void Swap(ref int a, ref int b)//swaps just two int arguments
        {//change this method to work with any type
            int temp = 0;
            temp = a;
            a = b;
            b = temp;
        }

        public static void Swap(ref string a, ref string b)//swaps just two int arguments
        {//change this method to work with any type
            string temp;
            temp = a;
            a = b;
            b = temp;
        }

        public void SimpleSwap()
        {
            int a = 5, b = 10;
            Console.WriteLine("a: " + a + " b: " + b);
            Swap(ref a, ref b);
            Console.WriteLine("a: " + a + " b: " + b);

            string first = "first";
            string second = "second";
            Console.WriteLine("first: " + first + " second: " + second);
            Swap(ref first, ref second);
            Console.WriteLine("first: " + first + " second: " + second);

        }

        public void GenericSwap()
        {
            int a = 0, b =1;
            Console.WriteLine("a: " + a + " b: " + b);
           // SwapGeneric(ref a, ref b); // compiler automatically recognizes the type by looking at the type of arguments--better explicitly define otherwise we don't want default type recognition by thecompiler
            SwapGeneric<int>(ref a, ref b);//Caling for the first time with int type==> instantiate and call
            SwapGeneric<int>(ref a, ref b);//next type just calls-no instantiating
            SwapGeneric<int>(ref a, ref b);//next type just calls-no instantiating

            Console.WriteLine("a: " + a + " b: " + b);

            long aa = 10000, bb = 11111;
            Console.WriteLine("aa: " + aa + " bb: " +bb);
            SwapGeneric<long>(ref aa, ref bb);//Caling for the first time with long type==> instantiate and call
            Console.WriteLine("aa: " + aa + " bb: " + bb);


            string first = "first", second = "second";
            Console.WriteLine("first: " + first + " second: " + second);
            SwapGeneric<string>(ref first, ref second);//Caling for the first time with string type==> instantiate and call
            Console.WriteLine("first: " + first + " second: " + second);
        }

        public void MultiTypeGenericMethod()
        {
            Dummy(450,true); //simplified
            Dummy<int, bool>(450,true);//Explicit

            Dummy(450,true,"amirali");
            Dummy<int, bool,string>(450,true,"amirali");
        }
    }
}
