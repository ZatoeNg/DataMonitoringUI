using System.Windows;
using System.Windows.Controls;


namespace WPF_Based_DataMonitoringUI.UserControls
{
    /// <summary>
    /// TextInfo.xaml 的交互逻辑
    /// </summary>
    public partial class TextInfo : UserControl
    {
        public TextInfo()
        {
            InitializeComponent();
        }

        public string TextTop
        {
            get { return (string)GetValue(TextTopProerty); }
            set { SetValue(TextTopProerty, value); }
        }
        public static readonly DependencyProperty TextTopProerty = DependencyProperty.Register("TextTop", typeof(string), typeof(TextInfo));


        public string TextMiddle
        {
            get { return (string)GetValue(TextMiddleProerty); }
            set { SetValue(TextMiddleProerty, value); }
        }
        public static readonly DependencyProperty TextMiddleProerty = DependencyProperty.Register("TextMiddle", typeof(string), typeof(TextInfo));

        public string TextBottom
        {
            get { return (string)GetValue(TextBottomProerty); }
            set { SetValue(TextBottomProerty, value); }
        }
        public static readonly DependencyProperty TextBottomProerty = DependencyProperty.Register("TextBottom", typeof(string), typeof(TextInfo));


        public bool IsActive
        {
            get { return (bool)GetValue(IsActiveProerty); }
            set { SetValue(IsActiveProerty, value); }
        }
        public static readonly DependencyProperty IsActiveProerty = DependencyProperty.Register("IsActive", typeof(bool), typeof(TextInfo));


    }
}
