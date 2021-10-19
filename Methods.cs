using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sodoku
{
    class Methods
    {
        public static int[,] FillArray()
        {
            int[,] arr = new int[9, 9];
            
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    arr[i, j] = j;
                }
            }

            return arr;
        }

        public static void FillBoard(int[,] arr)
        {
            
        }
    }
}
