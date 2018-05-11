using System;

namespace Tutorials
{
    public class ArrayAlgorithms
    {
        public ArrayAlgorithms() { }

        public void Chunk(int[] arr, int n)
        {
            int[,] newArr;
            int row = 0;
            int col = 0;
            
            if (arr.Length % n == 0)
            {
                newArr = new int[arr.Length / n, n];
            }
            else
            {
                newArr = new int[arr.Length / n + 1, n];
            }

            foreach (int val in arr)
            {
                newArr[row, col] = val;
                if (col == n - 1)
                {
                    row++;
                    col = 0;
                }
                else
                {
                    col++;
                }
            }

            Console.WriteLine("The height of the array is:\t {0}", newArr.GetLength(0));
            Console.WriteLine("The width of the array is:\t {0}\n", newArr.GetLength(1));

            foreach (int val in arr)
            {
                for (int x = 0; x < newArr.GetLength(0); x++)
                {
                    for (int y = 0; y < newArr.GetLength(1); y++)
                    {
                        if (newArr[x,y] == val)
                        {
                            Console.WriteLine("{0}:\t[{1},{2}]", val, x, y);
                        }
                    }
                }
            }

            Console.ReadKey();
        }
    }
}