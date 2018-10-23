using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите строку: ");//1
            string S = "";//2
            S = Convert.ToString(Console.ReadLine());
            char[] c = shifr(S);
            string str = vivod(c);
            Console.WriteLine("Зашифрованная строка: {0}", str);//9
            rashfr(c);
            string str1 = vivod(c);
            Console.WriteLine("Расшифрованная строка: {0}", str1);//15
            Console.ReadLine();//16
        }

        private static void rashfr(char[] c)
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

        public static char[] shifr(string S)
        {
            char[] c = S.ToCharArray(); //3
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

            return c;
        }

        private static string vivod(char[] c)
        {
            string str = "";//5
            for (int i = 0; i < c.Length; i++)//6
            {
                str = str + c[i].ToString();//7
            }//8

            return str;
        }

       
        }
    }
