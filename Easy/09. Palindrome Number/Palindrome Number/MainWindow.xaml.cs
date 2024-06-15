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

namespace Palindrome_Number
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string Txt_input = textBox_input.Text;
            List<char> IntputChar_List = new List<char>();

            foreach(char character in Txt_input)
            {
                IntputChar_List.Add(character);
            }

            if (Convert.ToInt32(Txt_input) < 0)
            {
                textBox_output.Text = "false";
                return;
            }

            int input_Length = IntputChar_List.Count;
            for (int i = 0; i < (input_Length / 2); i++)
            {
                //event number
                if (input_Length % 2 == 0)
                {
                    if (IntputChar_List[i] != IntputChar_List[input_Length - (i + 1)])
                    {
                        textBox_output.Text = "false";
                        return;
                    }
                }
                //odd number
                else
                {
                    if (IntputChar_List[i] != IntputChar_List[input_Length - (i + 1)])
                    {
                        textBox_output.Text = "false";
                        return;
                    }
                }
            }

            textBox_output.Text = "true";
        }
    }
}
