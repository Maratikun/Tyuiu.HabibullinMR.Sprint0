﻿namespace Tyuiu.HabibullinMR.Sprint0.Task6.V0.Lib
{
    public class DataService
    {
        public static object AdditionArray(int[] numbers)
        {
            var total = 0;
            for (var i = 0; i < numbers.Length; i++)
            {
                total += numbers[i];
            }
            return total;
        }

        public static object SubstractionArray(int[] numbers)
        {
            var total = 0;
            var index = 0;

            while(index < numbers.Length)
            {
                total -= numbers[index];
                index++;
            }
            return total;
        }
        public static object MultiplicationArray(int[] numbers)
        {
            var total = 1;
            var index = 0;

            do
            {
                total *= numbers[index];
                index++;
            }
            while (index < numbers.Length);
            return total;
        }

    }
}