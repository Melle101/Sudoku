using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows;
using System.Threading.Tasks;
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

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        public class Algorithm
        {
            public string AlgorithmID { get; set; }
        }

        private async void SelectAlgorithm_Click(object sender, RoutedEventArgs e)
        {
            if (AlgorithmListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an algorithm first.");
            }
            if (AlgorithmListBox.SelectedIndex == 0)
            {

                await Task.Run(() => RandomBoard());
            }
        }
    }
}
