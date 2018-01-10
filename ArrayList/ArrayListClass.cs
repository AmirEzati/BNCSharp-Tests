using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BNCSharp_Tests.ArrayList
{
  public  class ArrayListClass
    {
        /// <summary>
        /// we can pass the ArrayList(of different types) as an argument to the Example() method
        /// </summary>
        public ArrayListClass()
        {
            CompareArrayAndArrayList();
        }

        private void CompareArrayAndArrayList()
        {
            //a single-dimensional array
            int[] array1 = new int[5] { 15,16,18,78,79}; //must be inititlized with with the same count of items mentioned in definition otherwise, ERROR
            string[] stringArray = new string[6];

            int[] array2 = new int[] { 1, 3, 5, 7, 9 };//possible to initialize an array upon declaration
            string[] weekDays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

            int[] array3;
            array3 = new int[] { 1, 3, 5, 7, 9 };   // OK
                                                    //array3 = {1, 3, 5, 7, 9};   // Error

            System.Collections.ArrayList list= new System.Collections.ArrayList();
            list.Add("One");
            list.Add("Two");
            list.Add("Three");
            list.Add(1000);
            list.Add(true);
            list.Add(10.5);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            const int t = 10;//constants can't be reassigned
          //Error  t = 50;//the left-hand side of an assignment mustbe a variable, indexer or property

        }
    }
}
