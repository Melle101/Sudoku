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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        

        public MainWindow()
            {
            InitializeComponent();

            int[,] Cells = new int[9, 9];


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

    }


}
