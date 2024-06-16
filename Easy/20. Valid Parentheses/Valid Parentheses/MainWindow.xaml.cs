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

namespace Valid_Parentheses
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            textBox_answer.Text = null;
            
            List<char> bracketsList = new List<char>();
            Dictionary<char, char> mapping = new Dictionary<char, char>
            {
                {'(', ')'},
                {'[', ']'},
                {'{', '}'},
            };

            if (textBox.Text.Length % 2 != 0)
            {
                textBox_answer.Text = "false";
                return;
            }

            foreach (char brackets in textBox.Text)
            {
                bracketsList.Add(brackets);
            }

            for (int i = 0; i < bracketsList.Count; i++)
            {
                if (i == 0)
                {
                    if (bracketsList[i] == ')' ||
                       bracketsList[i] == ']' ||
                       bracketsList[i] == '}')
                    {
                        textBox_answer.Text = "false";
                        return;
                    }

                    continue;
                }

                if (bracketsList[i] == '(' ||
                    bracketsList[i] == '[' ||
                    bracketsList[i] == '{')
                {
                    continue;
                }


                char characters = bracketsList[i - 1];
                if (mapping[characters] != bracketsList[i])
                {
                    textBox_answer.Text = "false";
                    return;
                }
                else
                {
                    bracketsList.RemoveAt(i);
                    bracketsList.RemoveAt(i - 1);
                    i -= 2;
                }
            }

            if (bracketsList.Count != 0)
                textBox_answer.Text = "false";
            else
                textBox_answer.Text = "true";
        }
    }
}
