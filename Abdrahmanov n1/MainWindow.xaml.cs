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

namespace Abdrahmanov_n1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, RountedEventArgs e)
{ 
       int n = int.Parse(TbNumberA.Text);
                int b;
                while (n > 0)
                {
                    b = n % 10;
                    n /= 10;
                    MessageBox.Show($" b ={b}", "ответ");
         }
            }

        }

    }

}
 }
