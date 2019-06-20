using System;

namespace RhtCodeAssesement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string myString;

            Console.Write("Please Enter a String : ");
            myString = Console.ReadLine();

            var hello = ReverseString(myString);          
            

            Console.WriteLine(hello);
            Console.ReadLine();
        }

        public static string ReverseString(string rString)
        {
            string[] words = rString.Split(' ');
            Array.Reverse(words);

            var jointWord = string.Join(" ", words);

            return jointWord;
        }
    }
}
