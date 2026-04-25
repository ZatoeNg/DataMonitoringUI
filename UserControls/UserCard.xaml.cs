using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WPF_Based_DataMonitoringUI.UserControls
{
    /// <summary>
    /// UserCard.xaml 的交互逻辑
    /// </summary>
    public partial class UserCard : UserControl
    {
        public UserCard()
        {
            InitializeComponent();
        }
       
        public string FullName
        {
            get { return (string)GetValue(FullNameProerty); }
            set { SetValue(FullNameProerty, value); }
        }
        public static readonly DependencyProperty FullNameProerty = DependencyProperty.Register("FullName", typeof(string), typeof(UserCard));
       
        public string Title
        {
            get { return (string)GetValue(TitleProerty); }
            set { SetValue(TitleProerty, value); }
        }
        public static readonly DependencyProperty TitleProerty = DependencyProperty.Register("Title", typeof(string), typeof(UserCard));

         public string Time
        {
            get { return (string)GetValue(TimeProerty); }
            set { SetValue(TimeProerty, value); }
        }
        public static readonly DependencyProperty TimeProerty = DependencyProperty.Register("Time", typeof(string), typeof(UserCard));

        public ImageSource Image
        {
            get { return (ImageSource)GetValue(ImageProerty); }
            set { SetValue(ImageProerty, value); }
        }
        public static readonly DependencyProperty ImageProerty = DependencyProperty.Register("Image", typeof(ImageSource), typeof(UserCard));

        public bool IsActive
        {
            get { return (bool)GetValue(IsActiveProerty); }
            set { SetValue(IsActiveProerty, value); }
        }
        public static readonly DependencyProperty IsActiveProerty = DependencyProperty.Register("IsActive", typeof(bool), typeof(UserCard));
    }
}
