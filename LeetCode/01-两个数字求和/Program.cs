using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics;

namespace _01_两个数字求和
{
    public class Program
    {
        /// <summary>
        /// heheh.
        /// </summary>
        /// <param name="args">hahah </param>
        /// 
        public static void Main(string[] args)
        {

            //给定一个整数数组，返回两个数字的索引，使它们相加到特定目标。
            //您可以假设每个输入只有一个解决方案，并且您可能不会两次使用相同的元素。

            //例：
            //给定nums = [2, 7, 11, 15]，target = 9，

            //因为nums[0] + nums[1] = 2 + 7 = 9，
            //返回[0，1]。

            //思路：
            //1.首先计算数组的长度，求出两两组合一共有多少中情况
            //2.遍历数组中元素，每次选择两个元素
            //3.
            int[] array = new int[] { 3, 3 };
            int[] newArray = new int[2];
            //newArray=  GetTwoNumberAddInArrayFirst(array,9);
            try
            {
                newArray = TwoSum2(array, 6);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadKey();
            }
            for (int i = 0; i < newArray.Length; i++)
            {
                Console.WriteLine(newArray[i]);

            }

            Console.ReadKey();

            //求2的n次方
            //Console.WriteLine(Math.Pow(2, array.Length));
            //Console.ReadKey();
        }

        /// <summary>
        ///  xixi.
        /// </summary>
        /// <param name="array">xixi</param>
        /// <param name="target">xixi</param>
        /// <returns>xixi.</returns>
        public static int[] GetTwoNumberAddInArrayFirst(int[] array, int target)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (target == array[i] + array[j])
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return null;
        }

        //第二种方法

        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                dic.Add(nums[i], i);
            }

            for (int i = 0; i < nums.Length; i++)
            {
                int targetNum = target - nums[i];
                if (dic.Keys.Contains(targetNum) && dic[targetNum] != i)
                {
                    return new int[] { dic[targetNum], i };
                }
            }

            throw new ArgumentException("Not two number + = target.");
        }

        public static int[] TwoSum2(int[] nums, int target)
        {
            Dictionary<int, int> intStore = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (intStore.ContainsKey(target - nums[i]))
                {
                    return new int[] {intStore[target - nums[i]], i  };
                }
                else
                {
                    intStore[nums[i]] = i;
                }
            }

            return null;
        }

        public int[] TwoSumadd(int[] nums,int target)
        {
            Dictionary<int, int> intStore = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (intStore.ContainsKey(target - nums[i]))
                {
                    return new int[] { intStore[target - nums[i]], i };
                }
                else
                {
                    intStore[nums[i]] = i;
                }
            }

            return null;
        }
    }
}
