using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Threading;

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



            /*Cells = Methods.FillArray();

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
            if (AlgorithmListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an algorithm first.");
            }
            if (AlgorithmListBox.SelectedIndex == 0)
            {
                MainWindow obj = new MainWindow();

                Thread thr = new Thread(new ThreadStart(obj.RandomBoard));
                thr.Start();
                
            }
            if (AlgorithmListBox.SelectedIndex == 1)
            {
                FillCell(1, 1, 9);
            }
        }
    }
}
