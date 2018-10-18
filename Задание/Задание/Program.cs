using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Введите строку: ");//1
            string  S = "";//2
            S = Convert.ToString(Console.ReadLine());
            char[] c = S.ToCharArray(); //3
            shifr(c);//4
            string str = "";//5
            for (int i = 0; i < c.Length; i++)//6
            {
                str = str + c[i].ToString();//7
            }//8
            Console.WriteLine("Зашифрованная строка: {0}", str);//9
            shifr(c);//10
            string str1 = "";//11
            for (int i = 0; i < c.Length; i++)//12
            {
                str1 = str1 + c[i].ToString();//13
            }//14
            Console.WriteLine("Разшифрованная строка: {0}", str1);//15
            Console.ReadLine();//16
        }

        private static void shifr(char[] c)
        {
            for (int i = 0; i < c.Length; i = i + 2) //1
            {
                try //2
                {
                    char a1 = c[i];//3
                    c[i] = c[i + 1];//4
                    c[i + 1] = a1;//5
                }//6
                catch (Exception)//7
                {
                    break;//8
                }//9
            }//10
        }
    }
}
