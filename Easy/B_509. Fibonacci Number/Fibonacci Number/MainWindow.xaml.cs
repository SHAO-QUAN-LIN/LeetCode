using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace Fibonacci_Number
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public MainWindow()
        {
            InitializeComponent();

            UserControlNotified += NotifiedMessageOnStatusBar;
            DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            textBox_answer.Text = null;

            bool IsNumber = int.TryParse(textBox.Text, out int number);
            if(!IsNumber)
            {
                OnUserControlNotified(UserControlNotifiedEventArgs.MsgType.Error, "Input is not number！");
                return;
            }

            int n = Convert.ToInt32(textBox.Text);
            bool DPSelect_IsCheck = Convert.ToBoolean(checkBox_DPSelect.IsChecked);
            int ans = 0;

            if(DPSelect_IsCheck)
            {
                ans = DP_Fibonacii(n);
                textBox_answer.Text = ans.ToString();
            }
            else
            {
                ans = Fibonacii(n);
                textBox_answer.Text = ans.ToString();
            }

            OnUserControlNotified(UserControlNotifiedEventArgs.MsgType.Inform, "Calculate completed！");
        }

        public int Fibonacii(int n)
        {
            if (n == 0 || n == 1) return n;

            return Fibonacii(n - 1) + Fibonacii(n - 2);
        }

        public int DP_Fibonacii(int n)
        {
            int[] dp = new int[n + 1];

            if (dp[n] == 0 || n == 0) //dp[n]的值是否為0(0代表沒被算過)
            {
                if (n == 0 || n == 1) dp[n] = n;
                else dp[n] = DP_Fibonacii(n - 1) + DP_Fibonacii(n - 2);
            }

            return dp[n];
        }
    }

    //Message Binding
    public partial class MainWindow
    {
        private string _NotifiedMessage;
        public string NotifiedMessage
        {
            get { return _NotifiedMessage; }
            set { Set(ref _NotifiedMessage, value); }
        }

        private SolidColorBrush _NotifiedColor;
        public SolidColorBrush NotifiedColor
        {
            get { return _NotifiedColor; }
            set { Set(ref _NotifiedColor, value); }
        }
    }

    //Message Event
    public partial class MainWindow
    {
        public static event EventHandler<UserControlNotifiedEventArgs> UserControlNotified;
        protected void OnUserControlNotified(UserControlNotifiedEventArgs.MsgType type, string message)
        {
            UserControlNotified?.Invoke(this, new UserControlNotifiedEventArgs { NotifiedType = type, NotifiedMessage = message });
        }

        private void NotifiedMessageOnStatusBar(object sender, UserControlNotifiedEventArgs e)
        {
            NotifiedMessage = e.NotifiedMessage;
            NotifiedColor = e.NotifiedColor;
        }
    }

    //OnPropertyChanged
    public partial class MainWindow
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected void Set<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (Equals(storage, value))
            {
                return;
            }

            storage = value;

            OnPropertyChanged(propertyName);
        }
    }
}
