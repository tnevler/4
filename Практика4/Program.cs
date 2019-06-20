using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика4
{
    public class Program
    {
        static public void Show(int[] mas)
        {
            foreach (int d in mas)
            {
                Console.Write(d);
            }
            Console.WriteLine();
        }

        static public int[] MultOfMas(int[] mas1, int[] mas2)
        {
            int temp = 0;
            int[] sum1 = new int[mas1.Length];
            int[] sum2 = new int[mas1.Length + 1];
            for (int i = 0; i < mas2.Length; i++)
            {
                for (int x = 0; x < mas1.Length; x++)
                {
                    sum1[mas1.Length - 1 - x] = ((mas1[mas1.Length - 1 - x] * (mas2[i] % 10)) % 10 + temp) % 10;
                    temp = ((mas1[mas1.Length - 1 - x] * (mas2[i] % 10)) + temp) / 10;
                }
                temp = 0;
                for (int x = 0; x < mas1.Length; x++)
                {
                    sum2[sum2.Length - 2 - x] = ((mas1[mas1.Length - 1 - x] * (mas2[i] / 10)) % 10 + temp) % 10;
                    temp = ((mas1[mas1.Length - 1 - x] * (mas2[i] / 10)) + temp) / 10;
                }
                temp = 0;
                for (int x = 0; x < sum1.Length; x++)
                {
                    mas1[mas1.Length - 1 - x] = ((sum1[sum1.Length - 1 - x] + sum2[sum2.Length - 1 - x]) % 10 + temp) % 10;
                    temp = ((sum1[sum1.Length - 1 - x] + sum2[sum2.Length - 1 - x]) + temp) / 10;
                }
            }
            return mas1;
        }

        static public int[] SumOfMas(int[] d1, int[] d2)
        {
            int[] result = new int[d1.Length];
            int temp = 0;
            for (int y = 0; y < d1.Length; y++)
            {
                result[result.Length - 1 - y] = ((d1[d1.Length - 1 - y] + d2[d2.Length - 1 - y]) % 10 + temp) % 10;
                temp = ((d1[d1.Length - 1 - y] + d2[d2.Length - 1 - y]) + temp) / 10;
            }
            return result;
        }

        static public int[] MinusMas(int[] d1, int[] d2)
        {
            int[] result = new int[d1.Length];
            for (int i = 0; i < d2.Length; i++)
            {
                if (d1[d1.Length - 1 - i] >= d2[d2.Length - 1 - i]) result[result.Length - 1 - i] = d1[d1.Length - 1 - i] - d2[d2.Length - 1 - i];
                else
                {
                    d1[d1.Length - 1 - i] = d1[d1.Length - 1 - i] + 10;
                    d1[d1.Length - 2 - i] = d1[d1.Length - 2 - i] - 1;
                    result[result.Length - 1 - i] = d1[d1.Length - 1 - i] - d2[d2.Length - 1 - i];
                }
            }
            return result;
        }


        static void Main(string[] args)
        {
            // 100!
            int[] digits1 = new int[158];//результат 
            int[] mas100 = new int[100];//для умножения

            int n = 1;
            for (int i = 0; i < 100; i++)
            {
                mas100[i] = n;
                n++;
            }
            digits1[157] = 1;   
            digits1 = MultOfMas(digits1, mas100);
            //Show(digits1);    

            //2 ^ 100
            int[] digits2 = new int[158]; // результат 2^100 
            mas100 = new int[100];
            digits2[157] = 1;      
            for (int i = 0; i < 100; i++)
            {
                mas100[i] = 2;
            }
            
            digits2 = MultOfMas(digits2, mas100);
            //Show(digits2);
            // 100! + 2^100
            int[] result = SumOfMas(digits1, digits2);
            Console.WriteLine("100! + 2^100: ");
            Show(result);

            // 100! - 2^100
            result = MinusMas(digits1, digits2);
            Console.WriteLine("100! - 2^100: ");
            Show(result);
            Console.ReadKey();
        }
    }
}
