using System;

namespace BuiltInMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numArr = { 143, 20, 35 };
            int[] newNumArr = new int[10];

            //numArr.CopyTo(newNumArr, 2);
            Array.Copy(numArr, 1, newNumArr, 4, 2);
            Array.Clear(newNumArr, 0, 10);


         
            Array.Sort(numArr);
            Array.Reverse(numArr);
            Array.Resize(ref numArr, 4);
            

            for (int i = 0; i < numArr.Length; i++)
            {
                Console.WriteLine(numArr[i]);
            }
            int[] numArr2 = { 143, 20, 35 ,20};

            Console.WriteLine(Array.IndexOf(numArr2, 20));
            Console.WriteLine(Array.LastIndexOf(numArr2,20));

            string text = "  Hello, World! ";

            Console.WriteLine(text.ToLower());
            Console.WriteLine(text.ToUpper());
            Console.WriteLine(text.Trim());
            Console.WriteLine(text.Replace(' ','-'));
            Console.WriteLine(text.Replace('H', 'A'));
            Console.WriteLine(text.Replace("World","PB302"));
            Console.WriteLine(text);
            Console.WriteLine(text.Contains("Worl "));
            Console.WriteLine(text.Trim().ToUpper().StartsWith("HEL"));
            Console.WriteLine(text.EndsWith("d! "));

            string str = "Salam  necesen   ne var ne yox";

            Console.WriteLine(str.IndexOf("nece"));
            Console.WriteLine(str.IndexOf('a'));
            Console.WriteLine(str.LastIndexOf('a'));

            var newStr = str.Substring(1,2);
            Console.WriteLine(newStr);

            var arr = str.Split(' ');

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            var newStr2 = String.Join('-', arr);
            Console.WriteLine(newStr2);

            char letter = 'a';

            Console.WriteLine(char.ToUpper('a'));
            Console.WriteLine(char.IsDigit('a'));
            Console.WriteLine(char.IsUpper('a'));
            Console.WriteLine(char.IsLetter('a'));
            Console.WriteLine(char.IsLetterOrDigit('a'));


        }

    }
}
