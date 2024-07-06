using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Fibonacci_Number
{
    public class UserControlNotifiedEventArgs : EventArgs
    {
        public enum MsgType
        {
            Error,
            Warn,
            Inform,
            None,
        }

        private MsgType _NotifiedType;
        public MsgType NotifiedType
        {
            get
            {
                return _NotifiedType;
            }
            set
            {
                _NotifiedType = value;
                switch (value)
                {
                    case MsgType.Error:
                        NotifiedColor = Brushes.OrangeRed;
                        break;
                    case MsgType.Warn:
                        NotifiedColor = Brushes.Yellow;
                        break;
                    case MsgType.Inform:
                        NotifiedColor = Brushes.LimeGreen;
                        break;
                    case MsgType.None:
                        NotifiedColor = Brushes.White;
                        break;
                    default:
                        break;
                }
            }
        }

        public string NotifiedMessage { get; set; }

        public SolidColorBrush NotifiedColor { get; set; }
    }
}
