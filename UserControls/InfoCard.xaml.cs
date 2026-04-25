using System.Windows;
using System.Windows.Controls;


namespace WPF_Based_DataMonitoringUI.UserControls
{
    /// <summary>
    /// InfoCard.xaml 的交互逻辑
    /// </summary>
    public partial class InfoCard : UserControl
    {
        public InfoCard()
        {
            InitializeComponent();
        }

        public string Title
        {
            get { return (string)GetValue(TitleProerty); }
            set { SetValue(TitleProerty, value); }
        }
        public static readonly DependencyProperty TitleProerty = DependencyProperty.Register("Title", typeof(string), typeof(InfoCard));


        public string Desc
        {
            get { return (string)GetValue(DescProerty); }
            set { SetValue(DescProerty, value); }
        }
        public static readonly DependencyProperty DescProerty = DependencyProperty.Register("Desc", typeof(string), typeof(InfoCard));

        public string Percentage
        {
            get { return (string)GetValue(PercentageProerty); }
            set { SetValue(PercentageProerty, value); }
        }
        public static readonly DependencyProperty PercentageProerty = DependencyProperty.Register("Percentage", typeof(string), typeof(InfoCard));

        public string BottomText
        {
            get { return (string)GetValue(BottomTextProerty); }
            set { SetValue(BottomTextProerty, value); }
        }
        public static readonly DependencyProperty BottomTextProerty = DependencyProperty.Register("BottomText", typeof(string), typeof(InfoCard));

        public string Days
        {
            get { return (string)GetValue(DaysProerty); }
            set { SetValue(DaysProerty, value); }
        }
        public static readonly DependencyProperty DaysProerty = DependencyProperty.Register("Days", typeof(string), typeof(InfoCard));

        public int Value
        {
            get { return (int)GetValue(ValueProerty); }
            set { SetValue(ValueProerty, value); }
        }
        public static readonly DependencyProperty ValueProerty = DependencyProperty.Register("Value", typeof(int), typeof(InfoCard));

        public bool IsActive
        {
            get { return (bool)GetValue(IsActiveProerty); }
            set { SetValue(IsActiveProerty, value); }
        }
        public static readonly DependencyProperty IsActiveProerty = DependencyProperty.Register("IsActive", typeof(bool), typeof(InfoCard));

        public MahApps.Metro.IconPacks.PackIconMaterialKind Icon
        {
            get { return (MahApps.Metro.IconPacks.PackIconMaterialKind)GetValue(IconProerty); }
            set { SetValue(IconProerty, value); }
        }
        public static readonly DependencyProperty IconProerty = DependencyProperty.Register("Icon", typeof(MahApps.Metro.IconPacks.PackIconMaterialKind), typeof(InfoCard));

    }
}
