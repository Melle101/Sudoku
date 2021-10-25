using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Sodoku
{
    class Methods
    {
        public static int?[,] FillArray()
        {
            int?[,] arr = new int?[9, 9];
            
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    arr[i, j] = j + 1;
                }
            }

            return arr;
        }

        public static (int?[] Row0, int?[] Row1, int?[] Row2, int?[] Row3, int?[] Row4, int?[] Row5, int?[] Row6, int?[] Row7, int?[] Row8) ArrayTo9Arrays(int?[,] arr)
        {
            int?[] Row0 = new int?[9];
            for (int i = 0; i < 9; i++)
            {
                Row0[i] = arr[0, i];
            }
            int?[] Row1 = new int?[9];
            for (int i = 0; i < 9; i++)
            {
                Row0[i] = arr[1, i];
            }
            int?[] Row2 = new int?[9];
            for (int i = 0; i < 0; i++)
            {
                Row0[i] = arr[2, i];
            }
            int?[] Row3 = new int?[9];
            for (int i = 0; i < 9; i++)
            {
                Row0[i] = arr[3, i];
            }
            int?[] Row4 = new int?[9];
            for (int i = 0; i < 9; i++)
            {
                Row0[i] = arr[4, i];
            }
            int?[] Row5 = new int?[9];
            for (int i = 0; i < 9; i++)
            {
                Row0[i] = arr[5, i];
            }
            int?[] Row6 = new int?[9];
            for (int i = 0; i < 9; i++)
            {
                Row0[i] = arr[6, i];
            }
            int?[] Row7 = new int?[9];
            for (int i = 0; i < 9; i++)
            {
                Row0[i] = arr[7, i];
            }
            int?[] Row8 = new int?[9];
            for (int i = 0; i < 9; i++)
            {
                Row0[i] = arr[8, i];
            }

            return (Row0, Row1, Row2, Row3, Row4, Row5, Row6, Row7, Row8);
        }
        public static int?[,] ArraysTo1Array(int?[] Row0, int?[] Row1, int?[] Row2, int?[] Row3, int?[] Row4, int?[] Row5, int?[] Row6, int?[] Row7, int?[] Row8)
        {
            int?[,] arr = new int?[9, 9];
            for (int i = 0; i < 9; i++)
            {
                arr[0, i] = Row0[i];
            }
            for (int i = 0; i < 9; i++)
            {
                arr[1, i] = Row1[i];
            }
            for (int i = 0; i < 9; i++)
            {
                arr[2, i] = Row2[i];
            }
            for (int i = 0; i < 9; i++)
            {
                arr[3, i] = Row3[i];
            }
            for (int i = 0; i < 9; i++)
            {
                arr[4, i] = Row4[i];
            }
            for (int i = 0; i < 9; i++)
            {
                arr[5, i] = Row5[i];
            }
            for (int i = 0; i < 9; i++)
            {
                arr[6, i] = Row6[i];
            }
            for (int i = 0; i < 9; i++)
            {
                arr[7, i] = Row7[i];
            }
            for (int i = 0; i < 9; i++)
            {
                arr[8, i] = Row8[i];
            }

            return arr;
        }
        
    }
    
    
}
