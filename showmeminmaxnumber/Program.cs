using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace showmeminmaxnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = int.MaxValue;
            int max = int.MinValue;
            int n;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("숫자를 입력해주세요: ");
                n = int.Parse(Console.ReadLine());
                if (n < min)
                    min = n;
                if (n > max)
                    max = n;
            }
            Console.WriteLine("--------------------");
            Console.WriteLine("가장 큰 수: " + max);
            Console.WriteLine("가장 작은 수: " + min);
        }
    }
}
