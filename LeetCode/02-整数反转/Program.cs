using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_整数反转
{
    class Program
    {
        static void Main(string[] args)
        {
            int testInt = -1534236469;
            //Console.WriteLine(testInt.ToString());
            int res = Reverse(testInt);
            Console.WriteLine(res);
            
            
            
            Console.ReadKey();
        }

        public static int Reverse(int x)
        {
            string s = x.ToString();
            int result;
            int length = s.Length;        
            string Res=s[0].ToString()=="-"?"-":null;
            if (Res != null)
            {
                length = length - 1;
            }
            Dictionary<int, string> ReverseInt = new Dictionary<int, string>();
            for (int i = 0; i < length; i++)
            {
                ReverseInt.Add(i, s[s.Length-1-i].ToString());
                Res += ReverseInt[i];
            }
            try
            {
                result = Convert.ToInt32(Res);
            }
            catch
            {
                return 0;
            }
            return result;

        }

        //2147483647
        public static int Reverse2(int x)
        {
            int res = 0;
            while (x != 0)
            {
                int lastNum = x % 10;
                x = x / 10;
                if (res > int.MaxValue / 10 || (res == int.MaxValue / 10 && lastNum > 7)) { return 0; }
                if (res < int.MinValue / 10 || (res == int.MinValue / 10 && lastNum < -8)) { return 0; }
                res = res * 10 + lastNum;
            }
            return res;
        }
    }
}
