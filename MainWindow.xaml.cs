using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows;
using System.Windows.Controls;

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
            AlgorithmList.Add(new Algorithm() { AlgorithmID = "RandomInOrder" });
            AlgorithmList.Add(new Algorithm() { AlgorithmID = "InnerBoxesFirst" });


            Cells = Methods.FillArray();

            Cell00.Text = Cells[0, 0].ToString();
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
            Cell85.Text = Cells[8, 5].ToString();

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
            if (AlgorithmListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an algorithm first.");
            }
            if (AlgorithmListBox.SelectedIndex == 0)
            {
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        int?[] arr = new int?[9];
                        for (int k = 0; i < 9; i++)
                        {
                            while (arr[k] == null)
                            {
                                int l = new Random().Next(1, 10);
                                if ((Array.Exists(arr, element => element == k)) == false)
                                {
                                    arr[k] = l;
                                }
                            }
                        }
                        int?[] Row0Check = Methods.ArrayTo9Arrays(SolvedBoard).Row0;
                        int?[] Row1Check = Methods.ArrayTo9Arrays(SolvedBoard).Row1;
                        int?[] Row2Check = Methods.ArrayTo9Arrays(SolvedBoard).Row2;
                        int?[] Row3Check = Methods.ArrayTo9Arrays(SolvedBoard).Row3;
                        int?[] Row4Check = Methods.ArrayTo9Arrays(SolvedBoard).Row4;
                        int?[] Row5Check = Methods.ArrayTo9Arrays(SolvedBoard).Row5;
                        int?[] Row6Check = Methods.ArrayTo9Arrays(SolvedBoard).Row6;
                        int?[] Row7Check = Methods.ArrayTo9Arrays(SolvedBoard).Row7;
                        int?[] Row8Check = Methods.ArrayTo9Arrays(SolvedBoard).Row8;
                        bool NumberFound = false;
                        for (int m = 0; m < 9; m++)
                        {

                            Cell00.Text = arr[m].ToString();
                            if (i == 0)
                            {
                                if ((Array.Exists(Row0Check, element => element == arr[m])) == false)
                                {
                                    SolvedBoard[i, j] = arr[m];
                                    NumberFound = true;
                                }
                            }
                            

                            if (NumberFound)
                            {
                                break;
                            }
                        }

                    }
                }

            }
        }
    }
}
