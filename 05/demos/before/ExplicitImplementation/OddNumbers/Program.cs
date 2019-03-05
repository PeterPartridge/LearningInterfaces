using System;

namespace OddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine ("Odd Numbers:");
            OddGenerator generator = new OddGenerator();
            foreach (var odd in generator)
            {
                if (odd>50)
                {
                    break;
                }
                Console.WriteLine(odd);
            }

            Console.Read();
        }
    }
}
