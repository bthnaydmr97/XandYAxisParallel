using System;
using System.Collections.Generic;

namespace XandYAxisParallel
{
    class Program
    {
        static void Parallel(int[,] numbers)
        {

            int count = numbers.Length / 2;
            List<string> listY = new List<string>();
            List<string> listX = new List<string>();
            for (int i = 0; i < count; i++)
            {
                int number = numbers[i, 0];
                int number2 = numbers[i, 1];

                if (listY.Contains(number + "," + number2.ToString()))
                    continue;

                if (listX.Contains(number + "," + number2.ToString()))
                    continue;

                for (int j = i + 1; j < count; j++)
                {
                    if (number == numbers[j, 0])
                    {
                        if (!(listY.Contains(number + "," + number2.ToString())))
                            listY.Add(number + "," + number2.ToString());

                        listY.Add(numbers[j, 0].ToString() + "," + numbers[j, 1].ToString());
                    }
                    else if (number2 == numbers[j, 1])
                    {
                        if (!(listX.Contains(number + "," + number2.ToString())))
                            listX.Add(number + "," + number2.ToString());

                        listX.Add(numbers[j, 0].ToString() + "," + numbers[j, 1].ToString());
                    }
                }
            }
            Console.WriteLine("Bu sayılar Y ekseninee paraleldir");
            foreach (var item in listY)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("Bu sayılar X ekseninee paraleldir");
            foreach (var item in listX)
            {
                Console.WriteLine(item.ToString());
            }
        }
        
        public static void Main()
        {
            var numbers = new int[,]
            {
            {1, 2},
            {3, 7},
            {0, 6},
            {1, 1},
            {1, 5},
            {3, -5},
            {-5, 2},
            };

            Parallel(numbers);

        }
        
    }


}





