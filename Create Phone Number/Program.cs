using System;
using System.Collections.Generic;

namespace Create_Phone_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            string phoneNum = MyMethod(arr);

            foreach (var n in phoneNum)
            {
                Console.Write(n);
            }
        }
        static string MyMethod(int[] num)
        {
            var list = new List<string> { "(", };

            for (int i = 0; i < num.Length; i++)
            {
                list.Add(num[i].ToString());

                if (i == 2)
                    list.Add(") ");
                else if (i == 5)
                    list.Add("-");
            }
            string result = "";
            foreach (var n in list)
            {
                result += n;
            }
            return result;
        }
        //more clever solution
        public static string CreatePhoneNumber(int[] numbers)
        {
            return long.Parse(string.Concat(numbers)).ToString("(000) 000-0000");
        }
    }
}
