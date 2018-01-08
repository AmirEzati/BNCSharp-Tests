using System;
using System.Windows.Forms;

namespace BNCSharp_Tests
{
    class Program
    {
        delegate void DelSimplePrint(string input);

        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1) Simple Delegates  2) ");
            switch (Console.ReadKey().KeyChar)
            {
                case '1':
                    SimpleDelegate();
                    break;
                case '2':
                    AnonymousMethods();// simplifies delegates instantiation since it doesn't require a separate method in order to implement the delegate functinality
                    break;
                case '3':
                    MultiCastDelegate();// possible for delegate objects to refer to more than one object > addition assignment or substraction assignment operators to add or remove
                    break;

                case '4':
                    MultiCastDelegateWithReturnValues();// only the final returened value will be assigned.
                    break;

                case '5':
                    MultiCastDelegateWithOutParamerte();// p addition assignment or substraction assignment operators to add or remove
                    break;

                case '6':
                    DelegateWithDerivedType();
                    break;

                case '7':
                    DelegatesPassedAsMethodParameters();//to separate the implementation of data storage from the implementation of data processing.
                    // the storage class only handles the storage and has no knowledge of processing.
                    //Benefit: allows the storage class to be written in a more general way than if the class has toimplement all the processing operations.

                    // the client can simply plug in its own processing code into the existing storage class.

                    break;
                default:
                    break;
            }
            Console.ReadKey();
        }

        private static void DelegatesPassedAsMethodParameters()
        {
            var person = new PersonDB();
            person.Process(ProcessListItem);

            person.Process(ProcessListItemAndAddInverse);
        }

        delegate Car FixDelegate(SportsCar spCar);
        private static void DelegateWithDerivedType()
        {
            FixDelegate MyFixMethod;
            MyFixMethod = new FixDelegate(Fix);
            MyFixMethod += Fix2;
        }

        delegate void MyOutDelegate(out string str);
        private static void MultiCastDelegateWithOutParamerte()
        {
            MyOutDelegate MyOutMethods;
            MyOutMethods = new MyOutDelegate(OutString1);
            MyOutMethods += OutString2;
            string str = "initial value";
            MyOutMethods(out str);
            Console.WriteLine("***OUT is: " + str);
        }

        delegate int Add(int i);
        private static void MultiCastDelegateWithReturnValues()
        {
            Add myAddMethods = new Add(AddByFive);
            myAddMethods += AddByOne;
            var res = myAddMethods(5);//only the value of the last invoke method will bereturned!
            Console.WriteLine("the result is:  " + res);
        }

        private static void MultiCastDelegate()
        {
            DelSimplePrint MyPrintMethods;
            MyPrintMethods = new DelSimplePrint(DisplayInConsole);
            MyPrintMethods += DisplayInDialog;
            MyPrintMethods("Amir from MultiCast Delegates");
        }
        private static void AnonymousMethods()
        {
            DelSimplePrint myPrintDel = delegate (string str)
             {
                 System.Console.WriteLine("from an anonymous method");
                 System.Console.WriteLine(str);
             };

            myPrintDel("*Amir from an anonymous delegate*");
        }

        private static void SimpleDelegate()
        {
            string input = "Amir from simple Delegates";
            DelSimplePrint myPrintMehod;
            myPrintMehod = DisplayInConsole; //Simplified syntax

            DelSimplePrint myPrintMehod2 = new DelSimplePrint(DisplayInConsole); // the backwards compatible way. Pre c# 2.0 syntax

            myPrintMehod(input);
        }



        #region Iterator
        public static void ProcessListItem(string item)
        {
            Console.WriteLine(item.ToUpper());
        }

        public static void ProcessListItemAndAddInverse(string item)
        {
            Console.WriteLine(item.ToUpper() + "-" + item.PadLeft(2));
        }
        #endregion

        #region Car
        public static Car Fix(SportsCar car)
        {
            return new Car() { };
        }

        public static SportsCar Fix2(Car car)
        {
            return new SportsCar() { };
        }
        #endregion

        #region OutMethods
        public static void OutString1(out string str)
        {
            str = "change to another value 1";
        }

        public static void OutString2(out string str)
        {
            str = "change to another value 2";
        }
        #endregion

        #region Add Methods
        public static int AddByFive(int i)
        {
            return i + 5;
        }

        public static int AddByOne(int i)
        {
            return i + 1;
        }
        #endregion

        #region Print Methods
        public static void DisplayInConsole(string str)
        {
            Console.WriteLine("***" + str + "***");
        }

        public static void DisplayInDialog(string str)
        {
            MessageBox.Show("***" + str + "***");
        }
        #endregion
    }

    #region DelegatePassed As Parameter
    /// <summary>
    /// A Data Storage Class
    /// </summary>
    public class PersonDB
    {
        string[] listOfUsers = { "amir", "ali", "hasan" };
        public delegate void DelDoOnList(string listItem);

        public void Process(DelDoOnList delDoOnList)
        {
            foreach (var item in listOfUsers)
            {
                // Console.WriteLine(item);
                delDoOnList(item);

            }
        }
    }

    #endregion

    public class Car
    {

    }


    public class SportsCar : Car
    {

    }
}
