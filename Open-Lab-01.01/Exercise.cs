using System;

namespace Open_Lab_01._01
{
    public class Exercise
    {
        public bool IsLessThan10(string input)
        {
            int.TryParse(input, out int number);

            if (number < 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
