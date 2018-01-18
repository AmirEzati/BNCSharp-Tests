namespace BNCSharp_Tests.DOM.Test1
{
    public class NumericInput : TextInput
    {

        public override void Add(char c)
        {
            if (System.Char.IsDigit(c))
            {
                base.Add(c);
            }
        }
    }
}
