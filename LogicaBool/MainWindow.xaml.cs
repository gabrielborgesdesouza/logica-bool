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

namespace LogicaBool
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

        private void not(object sender, RoutedEventArgs e)
        {
            int var1 = Convert.ToInt16(Var1.Text);
            int var2 = Convert.ToInt16(Var2.Text);

            bool var1bool = Convert.ToBoolean(var1);
            bool var2bool = Convert.ToBoolean(var2);
         
          bool BoolResult = var1bool ^! var2bool;
         string textResult = BoolResult.ToString();

           MessageBox.Show(textResult);     
        }

        private void and(object sender, RoutedEventArgs e)
        {
 int var1 = Convert.ToInt16(Var1.Text);
            int var2 = Convert.ToInt16(Var2.Text);

            bool var1bool = Convert.ToBoolean(var1);
            bool var2bool = Convert.ToBoolean(var2);

            bool BoolResult = var1bool && var2bool;
            string textResult = BoolResult.ToString();

            MessageBox.Show(textResult); 
        }

        private void or(object sender, RoutedEventArgs e)
        {
            int var1 = Convert.ToInt16(Var1.Text);
            int var2 = Convert.ToInt16(Var2.Text);

            bool var1bool = Convert.ToBoolean(var1);
            bool var2bool = Convert.ToBoolean(var2);

            bool BoolResult = var1bool || var2bool;
            string textResult = BoolResult.ToString();

            MessageBox.Show(textResult);
        }

        private void xor(object sender, RoutedEventArgs e)
        {
            int var1 = Convert.ToInt16(Var1.Text);
            int var2 = Convert.ToInt16(Var2.Text);

            bool var1bool = Convert.ToBoolean(var1);
            bool var2bool = Convert.ToBoolean(var2);

            bool BoolResult = var1bool ^ var2bool;
           string textResult = BoolResult.ToString();

           MessageBox.Show(textResult); 
        }
    }
}
