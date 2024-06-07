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

namespace Longest_Common_Prefix
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            strs[0] = textBox1.Text;
            strs[1] = textBox2.Text;
            strs[2] = textBox3.Text;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<List<char>> temp = new List<List<char>>();
            string answer = "";

            for (int i = 0; i < strs.Length; i++)
            {
                temp.Add(new List<char>());
                foreach (char str in strs[i])
                {
                    temp[i].Add(str);
                }
            }

            int min = temp.Min(o => o.Count);

            for(int i = 0; i < min; i++)
            {
                for(int j = 1; j < temp.Count; j++)
                {
                    if (temp[j][i] != temp[j - 1][i])
                    {
                        textBox_answer.Text = answer;
                        return;
                    }
                }
                answer += temp[0][i];
            }

            textBox_answer.Text = answer;
        }
    }

    public partial class MainWindow
    {
        string[] strs = new string[3];
    }
}
