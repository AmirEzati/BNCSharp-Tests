using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BNCSharp_Tests.DOM.Test1
{
    public class TextInput
    {
        private StringBuilder concatStr = new StringBuilder();

        public string strResult
        {
            get
            {
                return concatStr.ToString();
            }
        }
        public virtual void Add(char c)
        {
            concatStr.Append(c);
        }

        public virtual string GetValue()
        {
            return concatStr.ToString();
        }
    }
}
