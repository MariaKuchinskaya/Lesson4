using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = new int[300];
            for (int i = 0; i < 300; i++)
            {
                array[i] = 200 + i;
            }

            var x = 0;
            while (x < 299)
            {
                if (array[x] % 17 == 0)
                {
                    Console.WriteLine(array[x]);
                }
                x++;
            }

            // версия без массива
            //var counter = 0;
            //while (counter <300)
            //{
            //    if (200 + counter % 17 == 0)
            //    {
            //        Console.WriteLine(200 + counter);
            //    }
            //    counter++;
            //}







































        

        }
        
        

    }
}
