using BNCSharp_Tests.Reflection;
using System;
using System.Windows.Forms;

namespace BNCSharp_Tests
{
    class Program
    {


        static void Main(string[] args)
        {

            Console.WriteLine("Enter a key to go to each section: ");
            Console.WriteLine("1)Delegates 2)Events 3)... ");

            switch (Console.ReadKey().KeyChar)
            {
                case '1':
                    new DelegateClass();
                    break;

                case '2':
                    new EventClass();
                    break;

                case '3'://Test Reflection
                    new TutPoint();
                    break;

                case 'C'://Test Reflection
                   var c= new Constructor.B();
                    
                    break;
                default:
                    break;
            }

            Console.ReadKey();

        }






    }


}
