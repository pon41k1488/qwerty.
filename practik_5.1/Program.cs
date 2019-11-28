using System;

namespace practik_5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string stroka = Console.ReadLine();

            string z = "";

            int n = int.Parse(Console.ReadLine());

            for (int e = 1; e <= n; e++)
            {
                z += '*';
            }

            for (int i = 0; i <= stroka.Length; i++)
            {
                Console.Write(stroka[i] + z);
            }
        }
    }
}
