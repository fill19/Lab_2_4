using System;
using System.Linq;

namespace ConsoleApplication11
{
    public class Program
    {
        public static int Sum (int[] array)
        {
            int sum = 0;

            for (int i = array.Length - 1; i > 0; i--)
            {
                if (array[i] > 0)
                {
                    for (int j = 0; j < i; j++)
                    {
                        sum += array[j];
                    }

                    break;
                }
            }

            return sum;
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Ввести кількість чисел n = ");
                int n = Convert.ToInt32(Console.ReadLine());

                int[] mas = new int[n];
                Random rand = new Random((int)DateTime.Now.Ticks);

                for (int i = 0; i < mas.Length; i++)
                {
                    mas[i] = rand.Next(-100, 101);
                    Console.Write("{0} ", mas[i]);
                }

                Console.WriteLine();
                Console.WriteLine("Сума = {0}", Sum(mas));
            }
        }
    }
}

               
           