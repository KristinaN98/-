using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "", S = "";
            Console.WriteLine("Введите строку: ");
            S = Convert.ToString(Console.ReadLine());
            char[] c = Shifr(S);
            for (int i = 0; i < c.Length; i++)
            {
                str = str + c[i].ToString();
            }
            Console.WriteLine("Зашифрованная строка: {0}", str);
            for (int i = 0; i < c.Length; i = i + 2)
            {
                try
                {
                    char a1 = c[i];
                    c[i] = c[i + 1];
                    c[i + 1] = a1;
                }
                catch (Exception)
                {
                    break;
                }

            }
            string str1 = "";
            for (int i = 0; i < c.Length; i++)
            {
                str1 = str1 + c[i].ToString();
            }
            Console.WriteLine("Разшифрованная строка: {0}", str1);
            Console.ReadLine();
        }

        private static char[] Shifr(string S)
        {
            char[] c = S.ToCharArray();


            for (int i = 0; i < c.Length; i = i + 2)
            {
                try
                {
                    char a1 = c[i];
                    c[i] = c[i + 1];
                    c[i + 1] = a1;
                }
                catch (Exception)
                {
                    break;
                }

            }

            return c;
        }
    }
}
