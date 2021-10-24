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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        int?[,] UserBoard = new int?[9, 9];

        int?[,] SolvedBoard = new int?[9, 9];
        public MainWindow()
            {
            InitializeComponent();
            int?[,] Cells = new int?[9, 9];
            List<Algorithm> AlgorithmList = new List<Algorithm>();
            AlgorithmListBox.ItemsSource = AlgorithmList;
            AlgorithmList.Add(new Algorithm() { AlgorithmID = "RandomInOrder"});
            AlgorithmList.Add(new Algorithm() { AlgorithmID = "InnerBoxesFirst" });


            Cells = Methods.FillArray();

            /*Cell00.Text = Cells[0, 0].ToString();
            Cell01.Text = Cells[0, 1].ToString();
            Cell02.Text = Cells[0, 2].ToString();
            Cell03.Text = Cells[0, 3].ToString();
            Cell04.Text = Cells[0, 4].ToString();
            Cell05.Text = Cells[0, 5].ToString();
            Cell06.Text = Cells[0, 6].ToString();
            Cell07.Text = Cells[0, 7].ToString();
            Cell08.Text = Cells[0, 8].ToString();
            
            Cell05.Text = Cells[0, 5].ToString();
            Cell15.Text = Cells[1, 5].ToString();
            Cell25.Text = Cells[2, 5].ToString();
            Cell35.Text = Cells[3, 5].ToString();
            Cell45.Text = Cells[4, 5].ToString();
            Cell55.Text = Cells[5, 5].ToString();
            Cell65.Text = Cells[6, 5].ToString();
            Cell75.Text = Cells[7, 5].ToString();
            Cell85.Text = Cells[8, 5].ToString();*/

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        public class Algorithm
        {
            public string AlgorithmID { get; set; }
        }

        private void SelectAlgorithm_Click(object sender, RoutedEventArgs e)
        {
            if (AlgorithmListBox.SelectedIndex== -1)
            {
                MessageBox.Show("Please select an algorithm first.");
            }
            if (AlgorithmListBox.SelectedIndex== 0)
            {
                
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        int?[] NumbersToTest = new int?[9];
                        
                        for (int k = 0; k < 9; k++)
                        {
                            NumbersToTest[k] = new Random().Next(1, 9);
                        }
                        bool NumberFound = false;
                        int l = 0;
                        while (NumberFound == false)
                        {
                            SolvedBoard[i, j] = NumbersToTest[l];
                            if (i == 0 && j == 0) Cell00.Text = SolvedBoard[0, 0].ToString();
                            if (i == 0 && j == 1) Cell01.Text = SolvedBoard[0, 2].ToString();
                            if (i == 0 && j == 2) Cell02.Text = SolvedBoard[0, 3].ToString();
                            if (i == 0 && j == 3) Cell03.Text = SolvedBoard[0, 4].ToString();
                            if (i == 0 && j == 4) Cell04.Text = SolvedBoard[0, 5].ToString();
                            if (i == 0 && j == 5) Cell05.Text = SolvedBoard[0, 5].ToString();
                            if (i == 0 && j == 6) Cell06.Text = SolvedBoard[0, 6].ToString();
                            if (i == 0 && j == 7) Cell07.Text = SolvedBoard[0, 7].ToString();
                            if (i == 0 && j == 8) Cell08.Text = SolvedBoard[0, 8].ToString();

                            if (NumbersToTest[l] != SolvedBoard[i, 0] || NumbersToTest[l] != SolvedBoard[i, 1] || NumbersToTest[l] != SolvedBoard[i, 2] || NumbersToTest[l] != SolvedBoard[i, 3] || NumbersToTest[l] != SolvedBoard[i, 4] || NumbersToTest[l] != SolvedBoard[i, 5] || NumbersToTest[l] != SolvedBoard[i, 6] || NumbersToTest[l] != SolvedBoard[i, 7] || NumbersToTest[l] != SolvedBoard[i, 8])
                            {
                                if (NumbersToTest[l] != SolvedBoard[0, j] || NumbersToTest[l] != SolvedBoard[1, j] || NumbersToTest[l] != SolvedBoard[2, j] || NumbersToTest[l] != SolvedBoard[3, j] || NumbersToTest[l] != SolvedBoard[4, j] || NumbersToTest[l] != SolvedBoard[5, j] || NumbersToTest[l] != SolvedBoard[6, j] || NumbersToTest[l] != SolvedBoard[7, j] || NumbersToTest[l] != SolvedBoard[8, j])
                                {
                                    if (i <= 2 && j <= 2)
                                    {
                                        if (NumbersToTest[l] != SolvedBoard[0, 0] || NumbersToTest[l] != SolvedBoard[0, 0] || NumbersToTest[l] != SolvedBoard[0, 0] || NumbersToTest[l] != SolvedBoard[0, 0] || NumbersToTest[l] != SolvedBoard[0, 0] || NumbersToTest[l] != SolvedBoard[0, 0] || NumbersToTest[l] != SolvedBoard[0, 0] || NumbersToTest[l] != SolvedBoard[0, 0] || NumbersToTest[l] != SolvedBoard[0, 0])
                                        {
                                            NumberFound = true;
                                        }
                                    }
                                    if (i <= 2 && j <= 5)
                                    {
                                        if (NumbersToTest[l] != SolvedBoard[0, 0] || NumbersToTest[l] != SolvedBoard[0, 0] || NumbersToTest[l] != SolvedBoard[0, 0] || NumbersToTest[l] != SolvedBoard[0, 0] || NumbersToTest[l] != SolvedBoard[0, 0] || NumbersToTest[l] != SolvedBoard[0, 0] || NumbersToTest[l] != SolvedBoard[0, 0] || NumbersToTest[l] != SolvedBoard[0, 0] || NumbersToTest[l] != SolvedBoard[0, 0])
                                        {
                                            NumberFound = true;
                                        }
                                    }
                                    if (i <= 2 && j <= 8)
                                    {
                                        if (NumbersToTest[l] != SolvedBoard[0, 0] || NumbersToTest[l] != SolvedBoard[0, 0] || NumbersToTest[l] != SolvedBoard[0, 0] || NumbersToTest[l] != SolvedBoard[0, 0] || NumbersToTest[l] != SolvedBoard[0, 0] || NumbersToTest[l] != SolvedBoard[0, 0] || NumbersToTest[l] != SolvedBoard[0, 0] || NumbersToTest[l] != SolvedBoard[0, 0] || NumbersToTest[l] != SolvedBoard[0, 0])
                                        {
                                            NumberFound = true;
                                        }
                                    }
                                    if (i <= 5 && j <= 2)
                                    {
                                        if (NumbersToTest[l] != SolvedBoard[0, 0] || NumbersToTest[l] != SolvedBoard[0, 0] || NumbersToTest[l] != SolvedBoard[0, 0] || NumbersToTest[l] != SolvedBoard[0, 0] || NumbersToTest[l] != SolvedBoard[0, 0] || NumbersToTest[l] != SolvedBoard[0, 0] || NumbersToTest[l] != SolvedBoard[0, 0] || NumbersToTest[l] != SolvedBoard[0, 0] || NumbersToTest[l] != SolvedBoard[0, 0])
                                        {
                                            NumberFound = true;
                                        }
                                    }
                                    if (i <= 5 && j <= 5)
                                    {
                                        if (NumbersToTest[l] != SolvedBoard[0, 0] || NumbersToTest[l] != SolvedBoard[0, 0] || NumbersToTest[l] != SolvedBoard[0, 0] || NumbersToTest[l] != SolvedBoard[0, 0] || NumbersToTest[l] != SolvedBoard[0, 0] || NumbersToTest[l] != SolvedBoard[0, 0] || NumbersToTest[l] != SolvedBoard[0, 0] || NumbersToTest[l] != SolvedBoard[0, 0] || NumbersToTest[l] != SolvedBoard[0, 0])
                                        {
                                            NumberFound = true;
                                        }
                                    }
                                    if (i <= 5 && j <= 8)
                                    {
                                        if (NumbersToTest[l] != SolvedBoard[0, 0] || NumbersToTest[l] != SolvedBoard[0, 0] || NumbersToTest[l] != SolvedBoard[0, 0] || NumbersToTest[l] != SolvedBoard[0, 0] || NumbersToTest[l] != SolvedBoard[0, 0] || NumbersToTest[l] != SolvedBoard[0, 0] || NumbersToTest[l] != SolvedBoard[0, 0] || NumbersToTest[l] != SolvedBoard[0, 0] || NumbersToTest[l] != SolvedBoard[0, 0])
                                        {
                                            NumberFound = true;
                                        }
                                    }
                                    if (i <= 8 && j <= 2)
                                    {
                                        if (NumbersToTest[l] != SolvedBoard[0, 0] || NumbersToTest[l] != SolvedBoard[0, 0] || NumbersToTest[l] != SolvedBoard[0, 0] || NumbersToTest[l] != SolvedBoard[0, 0] || NumbersToTest[l] != SolvedBoard[0, 0] || NumbersToTest[l] != SolvedBoard[0, 0] || NumbersToTest[l] != SolvedBoard[0, 0] || NumbersToTest[l] != SolvedBoard[0, 0] || NumbersToTest[l] != SolvedBoard[0, 0])
                                        {
                                            NumberFound = true;
                                        }
                                    }
                                    if (i <= 8 && j <= 5)
                                    {
                                        if (NumbersToTest[l] != SolvedBoard[0, 0] || NumbersToTest[l] != SolvedBoard[0, 0] || NumbersToTest[l] != SolvedBoard[0, 0] || NumbersToTest[l] != SolvedBoard[0, 0] || NumbersToTest[l] != SolvedBoard[0, 0] || NumbersToTest[l] != SolvedBoard[0, 0] || NumbersToTest[l] != SolvedBoard[0, 0] || NumbersToTest[l] != SolvedBoard[0, 0] || NumbersToTest[l] != SolvedBoard[0, 0])
                                        {
                                            NumberFound = true;
                                        }
                                    }
                                    if (i <= 8 && j <= 8)
                                    {
                                        if (NumbersToTest[l] != SolvedBoard[0, 0] || NumbersToTest[l] != SolvedBoard[0, 0] || NumbersToTest[l] != SolvedBoard[0, 0] || NumbersToTest[l] != SolvedBoard[0, 0] || NumbersToTest[l] != SolvedBoard[0, 0] || NumbersToTest[l] != SolvedBoard[0, 0] || NumbersToTest[l] != SolvedBoard[0, 0] || NumbersToTest[l] != SolvedBoard[0, 0] || NumbersToTest[l] != SolvedBoard[0, 0])
                                        {

                                        }
                                    }


                                }

                            }
                            Thread.Sleep(100);
                            l++;
                        }
                    }
                }
            }
        }
    }
}
