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
    public partial class MainWindow
    {


        private void Cell00_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell00.Text, "[^1-9]")) //Cheks so that inputs are only numbers between 1 and 9.
            {
                MessageBox.Show("Please enter only numbers.");
                Cell00.Text = Cell00.Text.Remove(Cell00.Text.Length - 1); //Removes the content of the TextBox
            }

        }
        private void Cell01_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell01.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell01.Text = Cell01.Text.Remove(Cell01.Text.Length - 1);
            }

        }
        private void Cell02_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell02.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell02.Text = Cell02.Text.Remove(Cell02.Text.Length - 1);
            }

        }
        private void Cell10_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell10.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell10.Text = Cell10.Text.Remove(Cell10.Text.Length - 1);
            }

        }
        private void Cell11_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell11.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell11.Text = Cell11.Text.Remove(Cell11.Text.Length - 1);
            }

        }
        private void Cell12_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell12.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell12.Text = Cell12.Text.Remove(Cell12.Text.Length - 1);
            }

        }
        private void Cell20_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell20.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell20.Text = Cell20.Text.Remove(Cell20.Text.Length - 1);
            }

        }
        private void Cell21_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell21.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell21.Text = Cell21.Text.Remove(Cell21.Text.Length - 1);
            }

        }
        private void Cell22_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell22.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell22.Text = Cell22.Text.Remove(Cell22.Text.Length - 1);
            }

        }
        private void Cell03_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell03.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell03.Text = Cell03.Text.Remove(Cell03.Text.Length - 1);
            }

        }
        private void Cell04_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell04.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell04.Text = Cell04.Text.Remove(Cell04.Text.Length - 1);
            }

        }
        private void Cell05_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell05.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell05.Text = Cell05.Text.Remove(Cell05.Text.Length - 1);
            }

        }
        private void Cell13_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell13.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell13.Text = Cell13.Text.Remove(Cell13.Text.Length - 1);
            }

        }
        private void Cell14_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell14.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell14.Text = Cell14.Text.Remove(Cell14.Text.Length - 1);
            }

        }
        private void Cell15_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell15.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell15.Text = Cell15.Text.Remove(Cell15.Text.Length - 1);
            }

        }
        private void Cell23_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell23.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell23.Text = Cell23.Text.Remove(Cell23.Text.Length - 1);
            }

        }
        private void Cell24_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell24.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell24.Text = Cell24.Text.Remove(Cell24.Text.Length - 1);
            }

        }
        private void Cell25_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell25.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell25.Text = Cell25.Text.Remove(Cell25.Text.Length - 1);
            }

        }
        private void Cell06_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell06.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell06.Text = Cell06.Text.Remove(Cell06.Text.Length - 1);
            }

        }
        private void Cell07_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell07.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell07.Text = Cell07.Text.Remove(Cell07.Text.Length - 1);
            }

        }
        private void Cell08_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell08.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell08.Text = Cell08.Text.Remove(Cell08.Text.Length - 1);
            }

        }
        private void Cell16_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell16.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell16.Text = Cell16.Text.Remove(Cell16.Text.Length - 1);
            }

        }
        private void Cell17_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell17.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell17.Text = Cell17.Text.Remove(Cell17.Text.Length - 1);
            }

        }
        private void Cell18_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell18.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell18.Text = Cell18.Text.Remove(Cell18.Text.Length - 1);
            }

        }
        private void Cell26_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell26.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell26.Text = Cell26.Text.Remove(Cell26.Text.Length - 1);
            }

        }
        private void Cell27_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell27.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell27.Text = Cell27.Text.Remove(Cell27.Text.Length - 1);
            }

        }
        private void Cell28_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell28.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell28.Text = Cell28.Text.Remove(Cell28.Text.Length - 1);
            }

        }
        private void Cell30_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell30.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell30.Text = Cell30.Text.Remove(Cell30.Text.Length - 1);
            }

        }
        private void Cell31_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell31.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell31.Text = Cell31.Text.Remove(Cell31.Text.Length - 1);
            }

        }
        private void Cell32_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell32.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell32.Text = Cell32.Text.Remove(Cell32.Text.Length - 1);
            }

        }
        private void Cell40_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell40.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell40.Text = Cell40.Text.Remove(Cell40.Text.Length - 1);
            }

        }
        private void Cell41_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell41.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell41.Text = Cell41.Text.Remove(Cell41.Text.Length - 1);
            }

        }
        private void Cell42_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell42.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell42.Text = Cell42.Text.Remove(Cell42.Text.Length - 1);
            }

        }
        private void Cell50_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell50.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell50.Text = Cell50.Text.Remove(Cell50.Text.Length - 1);
            }

        }
        private void Cell51_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell51.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell51.Text = Cell51.Text.Remove(Cell51.Text.Length - 1);
            }

        }
        private void Cell52_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell52.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell52.Text = Cell52.Text.Remove(Cell52.Text.Length - 1);
            }

        }
        private void Cell33_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell33.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell33.Text = Cell33.Text.Remove(Cell33.Text.Length - 1);
            }

        }
        private void Cell34_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell34.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell34.Text = Cell34.Text.Remove(Cell34.Text.Length - 1);
            }

        }
        private void Cell35_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell35.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell35.Text = Cell35.Text.Remove(Cell35.Text.Length - 1);
            }

        }
        private void Cell43_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell43.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell43.Text = Cell43.Text.Remove(Cell43.Text.Length - 1);
            }

        }
        private void Cell44_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell44.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell44.Text = Cell44.Text.Remove(Cell44.Text.Length - 1);
            }

        }
        private void Cell45_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell45.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell45.Text = Cell45.Text.Remove(Cell45.Text.Length - 1);
            }

        }
        private void Cell53_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell53.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell53.Text = Cell53.Text.Remove(Cell53.Text.Length - 1);
            }

        }
        private void Cell54_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell54.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell54.Text = Cell54.Text.Remove(Cell54.Text.Length - 1);
            }

        }
        private void Cell55_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell55.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell55.Text = Cell55.Text.Remove(Cell55.Text.Length - 1);
            }

        }
        private void Cell36_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell36.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell36.Text = Cell36.Text.Remove(Cell36.Text.Length - 1);
            }

        }
        private void Cell37_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell37.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell37.Text = Cell37.Text.Remove(Cell37.Text.Length - 1);
            }

        }
        private void Cell38_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell38.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell38.Text = Cell38.Text.Remove(Cell38.Text.Length - 1);
            }

        }
        private void Cell46_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell46.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell46.Text = Cell46.Text.Remove(Cell46.Text.Length - 1);
            }

        }
        private void Cell47_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell47.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell47.Text = Cell47.Text.Remove(Cell47.Text.Length - 1);
            }

        }
        private void Cell48_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell48.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell48.Text = Cell48.Text.Remove(Cell48.Text.Length - 1);
            }

        }
        private void Cell56_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell56.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell56.Text = Cell56.Text.Remove(Cell56.Text.Length - 1);
            }

        }
        private void Cell57_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell57.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell57.Text = Cell57.Text.Remove(Cell57.Text.Length - 1);
            }

        }
        private void Cell58_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell58.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell58.Text = Cell58.Text.Remove(Cell58.Text.Length - 1);
            }

        }
        private void Cell60_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell60.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell60.Text = Cell60.Text.Remove(Cell60.Text.Length - 1);
            }

        }
        private void Cell61_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell61.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell61.Text = Cell61.Text.Remove(Cell61.Text.Length - 1);
            }

        }
        private void Cell62_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell62.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell62.Text = Cell62.Text.Remove(Cell62.Text.Length - 1);
            }

        }
        private void Cell70_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell70.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell70.Text = Cell70.Text.Remove(Cell70.Text.Length - 1);
            }

        }
        private void Cell71_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell71.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell71.Text = Cell71.Text.Remove(Cell71.Text.Length - 1);
            }

        }
        private void Cell72_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell72.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell72.Text = Cell72.Text.Remove(Cell72.Text.Length - 1);
            }

        }
        private void Cell80_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell80.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell80.Text = Cell80.Text.Remove(Cell80.Text.Length - 1);
            }

        }
        private void Cell81_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell81.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell81.Text = Cell81.Text.Remove(Cell81.Text.Length - 1);
            }

        }
        private void Cell82_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell82.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell82.Text = Cell82.Text.Remove(Cell82.Text.Length - 1);
            }

        }
        private void Cell63_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell63.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell63.Text = Cell63.Text.Remove(Cell63.Text.Length - 1);
            }

        }
        private void Cell64_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell64.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell64.Text = Cell64.Text.Remove(Cell64.Text.Length - 1);
            }

        }
        private void Cell65_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell65.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell65.Text = Cell65.Text.Remove(Cell65.Text.Length - 1);
            }

        }
        private void Cell73_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell73.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell73.Text = Cell73.Text.Remove(Cell73.Text.Length - 1);
            }

        }
        private void Cell74_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell74.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell74.Text = Cell74.Text.Remove(Cell74.Text.Length - 1);
            }

        }
        private void Cell75_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell75.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell75.Text = Cell75.Text.Remove(Cell75.Text.Length - 1);
            }

        }
        private void Cell83_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell83.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell83.Text = Cell83.Text.Remove(Cell83.Text.Length - 1);
            }

        }
        private void Cell84_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell84.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell84.Text = Cell84.Text.Remove(Cell84.Text.Length - 1);
            }

        }
        private void Cell85_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell85.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell85.Text = Cell85.Text.Remove(Cell85.Text.Length - 1);
            }

        }
        private void Cell66_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell66.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell66.Text = Cell66.Text.Remove(Cell66.Text.Length - 1);
            }

        }
        private void Cell67_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell67.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell67.Text = Cell67.Text.Remove(Cell67.Text.Length - 1);
            }

        }
        private void Cell68_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell68.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell68.Text = Cell68.Text.Remove(Cell68.Text.Length - 1);
            }

        }
        private void Cell76_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell76.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell76.Text = Cell76.Text.Remove(Cell76.Text.Length - 1);
            }

        }
        private void Cell77_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell77.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell77.Text = Cell77.Text.Remove(Cell77.Text.Length - 1);
            }

        }
        private void Cell78_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell78.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell78.Text = Cell78.Text.Remove(Cell78.Text.Length - 1);
            }

        }
        private void Cell86_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell86.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell86.Text = Cell86.Text.Remove(Cell86.Text.Length - 1);
            }

        }
        private void Cell87_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell87.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell87.Text = Cell87.Text.Remove(Cell87.Text.Length - 1);
            }

        }
        private void Cell88_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cell88.Text, "[^1-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cell88.Text = Cell88.Text.Remove(Cell88.Text.Length - 1);
            }

        }
    }
}
