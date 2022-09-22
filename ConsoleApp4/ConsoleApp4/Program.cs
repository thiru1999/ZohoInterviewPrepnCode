/*using System;
using System.Collections.Generic;
public class Problem_1
{
    public static void Main()
    {
        string strFirst;
        var alpha_count = new Dictionary<char, int>();
        char charCout;
        int Count = 0;
        strFirst = Console.ReadLine();
        for(int i = 0; i < strFirst.Length; i++)
        {
            for(int j=0; j< strFirst.Length; j++)
            {
                if (strFirst[i] == strFirst[j])
                {
                    alpha_count[strFirst[i]]=++Count;

                }

            }
            Count = 0;
        }
        {
        }
        foreach(var keyvalpair in alpha_count)
        {
            Console.WriteLine("{0}:{1}",keyvalpair.Key,keyvalpair.Value);
        }
    }
}*/


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
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


        }
        public void submit_button(object sender, RoutedEventArgs e)
        {

            student s1 = new student();
            s1.Id = Id.Text;
            s1.Name = Name.Text;
            s1.Phno = Phno.Text;
            private List<student> list1 = new List<student>();
        public List<student> list2
        {
            get { return list1; }
            set { list1 = value; }
        }
    }



    private void Load_button(object sender, RoutedEventArgs e)
    {
        foreach (student op in list1)
        {
            MessageBox.Show($"{op.Name} {op.Id}  {op.sex} {op.Class}");



        }
    }
}
}