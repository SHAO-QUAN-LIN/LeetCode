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

namespace Two_Sum
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
            List<int> Ans = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        Ans.Add(i);
                        Ans.Add(j);

                        break;
                    }
                }
            }

            textBox_answer.Text = null;
            foreach (int output in Ans)
            {
                Console.WriteLine(output);
                textBox_answer.Text += $"{output}, ";
            }

            int textBox_answerLength = textBox_answer.Text.Length;
            textBox_answer.Text = textBox_answer.Text.Remove(textBox_answerLength - 2);
        }
    }

    public partial class MainWindow
    {
        int[] nums = { 2, 7, 11, 15 };

        int target = 9;
    }
}
