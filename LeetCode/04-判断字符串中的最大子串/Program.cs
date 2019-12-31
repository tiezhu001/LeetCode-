using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_判断字符串中的最大子串
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strs = new string[]
            {
                "flower", "flow", "flight"
            };

           //Console.WriteLine(LongestCommonPrefix(strs));
           Console.WriteLine(LongestCommonPrefix2(strs));
           Console.ReadKey();
        }

        public static  string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0)
            {
                return "";
            }

            string answer = strs[0];
            for (int i = 1; i < strs.Length; i++)
            {
                int j = 0;
                for (; j < strs[i].Length && j < answer.Length; j++)
                {
                    if (answer[j] != strs[i][j])
                    {
                        break;
                    }
                }

                answer = answer.Substring(0, j);
                if (answer.Equals(""))
                {
                    return answer;
                }
            }

            return answer;
        }

        /// <summary>
        /// 首先默认第一个字符串为最大的字符串前缀[1]
        /// 然后循环遍历除它之外的其他元素 [2]
        /// 如果其他元素的不包含默认第一个元素，即strs[i].indexof 不等于0[3]
        /// 就把第一个元素从最后一个位置开始减去最后一个char，然后在进行判断 [3]
        /// 直到等于0 [4]
        /// 如果直到第一个元素的第一个字符都不在其他元素的第一个字符，则进行[3] 操作值就等于0，即任意元素.indexof(result)都等于0
        /// 此时result的由于从第一个元素截取到截取0个元素，所以此时返回的结果刚好是空字符串
        /// </summary>
        /// <param name="strS"></param>
        /// <returns></returns>
        public static string LongestCommonPrefix2(string[] strS)
        {
            if (strS.Length == 0)
            {
                return null;
            }

            string result = strS[0];
            for (int i = 1; i <strS.Length ; i++)
            {
                while (strS[i].IndexOf(result) != 0)
                {
                    result = result.Substring(0, result.Length - 1);
                }
            }

            return result;
        }
    }
}