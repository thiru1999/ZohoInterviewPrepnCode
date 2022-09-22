using System.Windows;

namespace WPFRoutedEvents
{
  
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            txt1.Text = "Button is Clicked";
        }

        private void StackPanel_Click(object sender, RoutedEventArgs e)
        {
            txt2.Text = "Click event is bubbled to Stack Panel";
        }

        private void Window_Click(object sender, RoutedEventArgs e)
        {
            txt3.Text = "Click event is bubbled to Window";
        }

    }
}