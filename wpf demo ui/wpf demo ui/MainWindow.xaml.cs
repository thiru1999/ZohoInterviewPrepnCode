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

namespace wpf_demo_ui
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public class student
    {
        public string Id
        {           //user define data type creation -data
            get; set;
        }
        public string Name
        {
            get; set;
        }
        public string Phno
        {
            get; set;
        }
        public string sex
        {           //user define data type creation -data
            get; set;
        }
        public string Class
        {
            get; set;
        }

    }

    public partial class MainWindow : Window
    {

        public List<student> l1 { get; set; } = new List<student>();
        public MainWindow()
        {
            InitializeComponent();
            


        }
        public void submit_button(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
     /*       MessageBox.Show("Hii"+Id.Text);*/
            student s1 = new student();
            s1.Id = Id.Text;
            s1.Name = Name.Text;
            s1.Phno = Phno.Text;
            s1.sex = Sex.Text;
            s1.Class = Class.Text;
            mw.l1.Add(s1);
            foreach (student op in l1)
            {
                MessageBox.Show($"{op.Name} {op.Id}  {op.sex} {op.Class}");
                MessageBox.Show("hii");

            }

        }

        public void Load_button(object sender, RoutedEventArgs e)
        {
            
            foreach (student op in l1)
            {
                MessageBox.Show($"{op.Name} {op.Id}  {op.sex} {op.Class}");
                MessageBox.Show("hii");



            }

        }

    
    }
}


    


