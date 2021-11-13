using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
    public partial class MainWindow
    {
        private void FillCell(int i, int j, int? Value)
        {
            this.Dispatcher.Invoke(() =>
            {
                switch (i)
                {
                    case 0:
                        switch (j)
                        {
                            case 0:
                                Cell00.Text = Value.ToString();
                                break;
                            case 1:
                                Cell01.Text = Value.ToString();
                                break;
                            case 2:
                                Cell02.Text = Value.ToString();
                                break;
                            case 3:
                                Cell03.Text = Value.ToString();
                                break;
                            case 4:
                                Cell04.Text = Value.ToString();
                                break;
                            case 5:
                                Cell05.Text = Value.ToString();
                                break;
                            case 6:
                                Cell06.Text = Value.ToString();
                                break;
                            case 7:
                                Cell07.Text = Value.ToString();
                                break;
                            case 8:
                                Cell08.Text = Value.ToString();
                                break;
                        }
                        break;
                    case 1:
                        switch (j)
                        {
                            case 0:
                                Cell10.Text = Value.ToString();
                                break;
                            case 1:
                                Cell11.Text = Value.ToString();
                                break;
                            case 2:
                                Cell12.Text = Value.ToString();
                                break;
                            case 3:
                                Cell13.Text = Value.ToString();
                                break;
                            case 4:
                                Cell14.Text = Value.ToString();
                                break;
                            case 5:
                                Cell15.Text = Value.ToString();
                                break;
                            case 6:
                                Cell16.Text = Value.ToString();
                                break;
                            case 7:
                                Cell17.Text = Value.ToString();
                                break;
                            case 8:
                                Cell18.Text = Value.ToString();
                                break;
                        }
                        break;

                    case 2:
                        switch (j)
                        {
                            case 0:
                                Cell20.Text = Value.ToString();
                                break;
                            case 1:
                                Cell21.Text = Value.ToString();
                                break;
                            case 2:
                                Cell22.Text = Value.ToString();
                                break;
                            case 3:
                                Cell23.Text = Value.ToString();
                                break;
                            case 4:
                                Cell24.Text = Value.ToString();
                                break;
                            case 5:
                                Cell25.Text = Value.ToString();
                                break;
                            case 6:
                                Cell26.Text = Value.ToString();
                                break;
                            case 7:
                                Cell27.Text = Value.ToString();
                                break;
                            case 8:
                                Cell28.Text = Value.ToString();
                                break;
                        }
                        break;
                    case 3:
                        switch (j)
                        {
                            case 0:
                                Cell30.Text = Value.ToString();
                                break;
                            case 1:
                                Cell31.Text = Value.ToString();
                                break;
                            case 2:
                                Cell32.Text = Value.ToString();
                                break;
                            case 3:
                                Cell33.Text = Value.ToString();
                                break;
                            case 4:
                                Cell34.Text = Value.ToString();
                                break;
                            case 5:
                                Cell35.Text = Value.ToString();
                                break;
                            case 6:
                                Cell36.Text = Value.ToString();
                                break;
                            case 7:
                                Cell37.Text = Value.ToString();
                                break;
                            case 8:
                                Cell38.Text = Value.ToString();
                                break;
                        }
                        break;
                    case 4:
                        switch (j)
                        {
                            case 0:
                                Cell40.Text = Value.ToString();
                                break;
                            case 1:
                                Cell41.Text = Value.ToString();
                                break;
                            case 2:
                                Cell42.Text = Value.ToString();
                                break;
                            case 3:
                                Cell43.Text = Value.ToString();
                                break;
                            case 4:
                                Cell44.Text = Value.ToString();
                                break;
                            case 5:
                                Cell45.Text = Value.ToString();
                                break;
                            case 6:
                                Cell46.Text = Value.ToString();
                                break;
                            case 7:
                                Cell47.Text = Value.ToString();
                                break;
                            case 8:
                                Cell48.Text = Value.ToString();
                                break;
                        }
                        break;
                    case 5:
                        switch (j)
                        {
                            case 0:
                                Cell50.Text = Value.ToString();
                                break;
                            case 1:
                                Cell51.Text = Value.ToString();
                                break;
                            case 2:
                                Cell52.Text = Value.ToString();
                                break;
                            case 3:
                                Cell53.Text = Value.ToString();
                                break;
                            case 4:
                                Cell54.Text = Value.ToString();
                                break;
                            case 5:
                                Cell55.Text = Value.ToString();
                                break;
                            case 6:
                                Cell56.Text = Value.ToString();
                                break;
                            case 7:
                                Cell57.Text = Value.ToString();
                                break;
                            case 8:
                                Cell58.Text = Value.ToString();
                                break;
                        }
                        break;
                    case 6:
                        switch (j)
                        {
                            case 0:
                                Cell60.Text = Value.ToString();
                                break;
                            case 1:
                                Cell61.Text = Value.ToString();
                                break;
                            case 2:
                                Cell62.Text = Value.ToString();
                                break;
                            case 3:
                                Cell63.Text = Value.ToString();
                                break;
                            case 4:
                                Cell64.Text = Value.ToString();
                                break;
                            case 5:
                                Cell65.Text = Value.ToString();
                                break;
                            case 6:
                                Cell66.Text = Value.ToString();
                                break;
                            case 7:
                                Cell67.Text = Value.ToString();
                                break;
                            case 8:
                                Cell68.Text = Value.ToString();
                                break;
                        }
                        break;
                    case 7:
                        switch (j)
                        {
                            case 0:
                                Cell70.Text = Value.ToString();
                                break;
                            case 1:
                                Cell71.Text = Value.ToString();
                                break;
                            case 2:
                                Cell72.Text = Value.ToString();
                                break;
                            case 3:
                                Cell73.Text = Value.ToString();
                                break;
                            case 4:
                                Cell74.Text = Value.ToString();
                                break;
                            case 5:
                                Cell75.Text = Value.ToString();
                                break;
                            case 6:
                                Cell76.Text = Value.ToString();
                                break;
                            case 7:
                                Cell77.Text = Value.ToString();
                                break;
                            case 8:
                                Cell78.Text = Value.ToString();
                                break;
                        }
                        break;
                    case 8:
                        switch (j)
                        {
                            case 0:
                                Cell80.Text = Value.ToString();
                                break;
                            case 1:
                                Cell81.Text = Value.ToString();
                                break;
                            case 2:
                                Cell82.Text = Value.ToString();
                                break;
                            case 3:
                                Cell83.Text = Value.ToString();
                                break;
                            case 4:
                                Cell84.Text = Value.ToString();
                                break;
                            case 5:
                                Cell85.Text = Value.ToString();
                                break;
                            case 6:
                                Cell86.Text = Value.ToString();
                                break;
                            case 7:
                                Cell87.Text = Value.ToString();
                                break;
                            case 8:
                                Cell88.Text = Value.ToString();
                                break;
                        }
                        break;
                }
            });
            
        }
        private void RandomBoard()
        {
            int?[,] SolvedBoard = new int?[9, 9];

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    FillCell(i, j, null);
                }  
            }

            for (int i = 0; i < 9; i++)
            {
                int s = 0;
                for (int j = 0; j < 9; j++)
                {
                    bool NumberFound = false;
                    int m = 0;
                    int r = 0;

                    while (NumberFound == false)
                    {
                        int n = 0; //Row Cleared Counter
                        int o = 0; //Column Cleared Counter
                        int q = 0; //Cell in 3x3 Cleared Counter

                        int?[] RandomArray = new int?[9]; //Creates and array with numbers 1-9 in random order.
                        for (int k = 0; k < 9; k++)
                        {
                            while (RandomArray[k] == null)
                            {
                                int l = new Random().Next(1, 10);
                                if ((Array.Exists(RandomArray, element => element == l)) == false)
                                {
                                    RandomArray[k] = l;

                                }
                            }
                        }
                        FillCell(i, j, RandomArray[m]);
                        for (int l = 0; l < 9; l++) //Check so Row doesn't contain the possible value for the cell
                        {
                            if ((RandomArray[m] == SolvedBoard[i, l]) == false)
                            {
                                n++;
                            }
                        }
                        for (int l = 0; l < 9; l++) //Check so column doesn't contain the possible value for the cell
                        {

                            if ((RandomArray[m] == SolvedBoard[l, j]) == false)
                            {
                                o++;
                            }
                        }
                        int LowerBoundSquareRow = i / 3 * 3; //Find start cell for the 3x3 Box that the cell is in. 
                        int LowerBoundSquareColumn = j / 3 * 3; //Ex Cell 5;0 Row 5 => 5/3 = 1.67 => .Floor = 1 => *3 = 3, same for column gives cell 3;6
                        for (int l = LowerBoundSquareRow; l < (LowerBoundSquareRow + 3); l++) //Check 3x3 Box for the cell, add 3 to find last cell in 3x3
                        {
                            for (int p = LowerBoundSquareColumn; p < (LowerBoundSquareColumn + 3); p++)
                            {
                                if ((RandomArray[m] == SolvedBoard[l, p]) == false)
                                {
                                    q++;
                                }
                            }
                        }
                        if (o == 9 && n == 9 && q == 9)
                        {
                            NumberFound = true;
                            SolvedBoard[i, j] = RandomArray[m];
                            Console.WriteLine(SolvedBoard[i, j]);
                        }
                        if (m == 8)
                        {
                            m = 0;
                            if (r >= 32)
                            {
                                for (int l = 0; l < 9; l++) //If a row paints itself into a corner, remake the row after a few tries.
                                {
                                    SolvedBoard[i, l] = null;
                                    j = 0;
                                }
                                s++;
                            }
                        }
                        else m++; r++;
                        if (s >= 6) //Restart grid generation if it comes to a dead end
                        {
                            for (int k = 0; k < 9; k++)
                            {
                                for (int l = 0; l < 9; l++)
                                {
                                    SolvedBoard[k, l] = null;
                                    i = 0;
                                    j = 0;
                                    s = 0;
                                }
                            }
                        }
                        Thread.Sleep(0);
                    }
                }
            }
        }
    }
}
    
    

