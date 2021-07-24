using System;

namespace Docloop_task_4
{
    class Program
    {
        /*
        For a given array of integers in C# find the element of array that is the closest to the middle value of all elements. 
        If there are two elements satisfying this criteria, choose the smaller one. Take into account complexity of your solution.

        Example: arr=[1,3,4,-7,9,11]. Middle value is (1+3+4-7+9+11) /6 = 3.5. 
        Elements 3 and 4 are equally distant to 3.5, but smaller of them is 3 so 3 is the result.
         */

        static void Main(string[] args)
        {
            int[] numbers = { 1, 3, 4, -7, 9, 11 };
            decimal average = Sum_of_array(numbers) / Convert.ToDecimal(numbers.Length);
            int avg_min = numbers[0];
            decimal avg_dev = Math.Abs(avg_min - average);

            for (int i = 1; i < numbers.Length; i++)
            {
                if (avg_dev > Math.Abs(numbers[i] - average))
                {
                    avg_dev = Math.Abs(numbers[i] - average);
                    avg_min = numbers[i];
                }
                else if (avg_dev == Math.Abs(numbers[i] - average) && avg_min > numbers[i])
                    avg_min = numbers[i];
            }

            Console.WriteLine(avg_min);
        }

        private static int Sum_of_array(int[] my_array)
        {
            int sum = 0;
            for (int i = 0; i < my_array.Length; i++)
                sum += my_array[i];

            return sum;
        }
    }
}
