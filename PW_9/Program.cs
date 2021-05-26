using System;

namespace PW_9
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
              
                int[,] Array = new int[8, 8];
                int ZeroOne = 1;

                
                for (int i = 0; i < Array.GetLength(0); i++)
                {
                    for (int j = 0; j < Array.GetLength(1); j++)
                    {
                        if (ZeroOne == 0 && i % 2 != 0)
                        {
                            ZeroOne = 1;
                            Array[i, j] = ZeroOne;
                        }
                        else if (ZeroOne == 1 && i % 2 != 0)
                        {
                            ZeroOne = 0;
                            Array[i, j] = ZeroOne;
                        }
                        else if (ZeroOne == 1 && i % 2 == 0)
                        {
                            Array[i, j] = ZeroOne;
                            ZeroOne = 0;
                        }
                        else if (ZeroOne == 0 && i % 2 == 0)
                        {
                            Array[i, j] = ZeroOne;
                            ZeroOne = 1;
                        }
                    }
                }

              
                for (int i = 0; i < Array.GetLength(0); i++)
                {
                    for (int j = 0; j < Array.GetLength(1); j++)
                    {
                        Console.Write(Array[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

                
                int[,] Array2 = new int[10, 10];
                Random random = new Random();

                
                for (int i = 0; i < Array2.GetLength(0); i++)
                {
                    for (int j = 0; j < Array2.GetLength(1); j++)
                    {
                        Array2[i, j] = random.Next(1, 10);
                    }
                }

                
                for (int i = 0; i < Array2.GetLength(0); i++)
                {
                    for (int j = 0; j < Array2.GetLength(1); j++)
                    {
                        Console.Write(Array2[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

               
                for (int i = 0; i < Array2.GetLength(1); i++)
                {
                    ZeroOne = 0;
                    for (int j = 0; j < Array2.GetLength(0); j++)
                    {
                        ZeroOne += Array2[i, j];
                    }
                    Console.WriteLine($"Сумма {i + 1} строки: " + ZeroOne);
                }
                Console.WriteLine();

              
                Console.WriteLine("Простые числа массива: ");
                for (int i = 0; i < Array2.GetLength(0); i++)
                {
                    for (int j = 0; j < Array2.GetLength(1); j++)
                    {
                        if (Array2[i, j] % 1 == 0 && Array2[i, j] >= 1)
                        {
                            Console.Write(Array2[i, j] + "\t");
                        }
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
