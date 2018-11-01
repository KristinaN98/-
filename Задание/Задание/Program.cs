using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание
{
    public class Program
    {
       public static void Main(string[] args)
        {

            Console.WriteLine("Введите строку: ");//1
            string S  = Convert.ToString(Console.ReadLine());

            string zashifr = new string(Shifr(S.ToCharArray()));
            Console.WriteLine("Зашифрованная строка: {0}", zashifr);//9

          
            string rasshifr = new string(Shifr(zashifr.ToCharArray()));
            Console.WriteLine("Расшифрованная строка: {0}", rasshifr);//15

            Console.ReadLine();//16
        }           

        public static char[] Shifr(char[] c)
        {           
            for (int i = 0; i < (c.Length/2)*2; i = i + 2) //1
            {            
                    char a1 = c[i];//3
                    c[i] = c[i + 1];//4
                    c[i + 1] = a1;//5
            }//10
            return c;
        }           
     }
 }

