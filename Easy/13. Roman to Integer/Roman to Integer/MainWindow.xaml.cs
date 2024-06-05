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

namespace Roman_to_Integer
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
            int answer = 0;
            List<int> RomanNumList = new List<int>();

            //define Roman means
            Dictionary<string, int> rule = new Dictionary<string, int>
            {
                {"I", 1},
                {"V", 5},
                {"X", 10},
                {"L", 50},
                {"C", 100},
                {"D", 500},
                {"M", 1000},
            };

            if (string.IsNullOrEmpty(textBox_input.Text))
            {
                return;
            }

            foreach (char str in textBox_input.Text)
            {
                if (!rule.ContainsKey(str.ToString()))
                {
                    return;
                }
            }

            //record roman numerals
            foreach (char letter in textBox_input.Text)
            {
                int pairNUm = rule[letter.ToString()];
                //KeyValuePair<string, int> pair = rule.FirstOrDefault(o => o.Key == letter.ToString());
                RomanNumList.Add(pairNUm);
            }

            //count answer
            for (int i = 0; i < RomanNumList.Count; i++)
            {
                if (answer == 0)
                {
                    answer = RomanNumList[i];
                }
                else if (RomanNumList[i] > RomanNumList[i - 1])
                {
                    int temp = RomanNumList[i] - RomanNumList[i - 1];

                    answer -= RomanNumList[i - 1];
                    answer += temp;
                }
                else
                {
                    answer += RomanNumList[i];
                }
            }

            textBox_output.Text = answer.ToString();
        }
    }
}
