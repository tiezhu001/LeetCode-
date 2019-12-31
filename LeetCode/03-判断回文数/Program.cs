using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_判断回文数
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine(IsHuiWenNum(201));
            Console.ReadKey();
        }

        public static bool IsHuiWenNum(int x)
        {
            if (x < 0) return false;
            if (x == 0) return true;

            int orignX = x;
            int afterX = 0;
            while (x != 0)
            {
                afterX = afterX * 10 + x % 10;
                x = x / 10;
            }


            return orignX ==afterX;
        }
    }


}
