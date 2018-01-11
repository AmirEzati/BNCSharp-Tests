using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BNCSharp_Tests.Enum
{
    class EnumClass
    {
        public EnumClass()
        {
            TestEnums();
        }

        private void TestEnums()
        {
            State s;
            s = State.Offline;// to assign a value, access it like a static members of a class;
            int i = (int)s; //0
            string t = s.ToString(); //Offline

            switch (s)  //switch statements==> A good example of using ENUMS compared to using ordinary constants
                        //intellicense/limiting constant values/
            {
                case State.Run:
                    //System.Enum.GetValues(); //access other methods of Enum type
                    
                    break;
                case State.Wait:
                    break;
                case State.Stop:
                    break;
                case State.Offline:
                    break;
                default:
                    break;
            }

        }
    }
    public enum State : byte
    //ENUMS: an special type of value type--consisting a list of name constants
    //use enum keyword
    // the default type is : INT
    // you can change it into : BYTE
    //Access levels are the same as classes==> enums: internal by default
    //can be defined within a Namespace ot inside the Class
    //Inside the Class, they are Private by default
    {
        Run //Default value for the first element is : ZERO
            , Wait = 3//can override this default values
            , Stop = 10
            , Halt = 10//no need to be unique
            , Offline = Wait + 5  // Even you can use computed values
    }
}
