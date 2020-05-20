using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Search_for_letters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Change("a   **&  cZ"));
            Console.ReadKey();
        }
        public static string Change(string input)
        {
            // ...            
            var cadena = input.ToUpper().ToList().OrderBy(x => x).Distinct();


            int posidicon = 65;

            StringBuilder output = new StringBuilder();

            foreach (var item in cadena)
            {
                if (item >= 65 && item <= 90)
                {
                    while (item > posidicon)
                    {
                        output.Append("0");
                        posidicon++;
                    }
                    output.Append("1");
                    posidicon++;
                }
            }

            return output.ToString();
        }
    }
}
