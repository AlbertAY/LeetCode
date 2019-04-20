using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] datas =  { 1,12,2,6,9,12};

            int[] result = 两数之和.TwoSum(datas,3);
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
            

            Console.ReadKey();

        }


        

    }
}
