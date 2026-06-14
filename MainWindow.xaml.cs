using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace vsproject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int a;
        int b;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string result = txtname.Text.TrimStart('*');
            string result1 = txtname.Text.TrimEnd('*');
            string result2 = txtname.Text.Trim('*');



            int i = 10;
            string k = "Hii";
            bool b = true;
            char c = 'a';
            object value = 10;
            value = "sathiya";
            value = k;
            
            if (value is string)
            {
                string output = Convert.ToString(value);
            }
            else if(value is int)
            {
                int numb = Convert.ToInt32(value);
            }

            dynamic value1 = 1;
            value1 = k;
            value1 = true;
            value1 = 4;

            if(value1 is int)
            {

                int outk = value1;
            }
            if(value1 is bool)
            {
                bool isit = value1;
            }

        }
    }
}