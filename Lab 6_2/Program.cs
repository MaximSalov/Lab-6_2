using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string strLow = str.ToLower().Replace(" ","");
            string reverseStr = "";
            for (int i = strLow.Length - 1; i >= 0; i--)
            {
                reverseStr += strLow[i];
            }
            if (strLow == reverseStr)
                Console.WriteLine("Введенная строка является палиндромом.");
            else
                Console.WriteLine("Введенная строка не является палиндромом.");
            Console.ReadKey();
        }
    }
}
