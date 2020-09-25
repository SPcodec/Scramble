using System;
using System.Linq;

namespace Scramble
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string word = Console.ReadLine();
                string capitalisedword = word.ToUpper();
                char[] wordArray = capitalisedword.ToCharArray();
                Random rnd = new Random();
                char[] MyRandomArray = wordArray.OrderBy(x => rnd.Next()).ToArray();
                Console.WriteLine(MyRandomArray);
            }
        }
    }
}
