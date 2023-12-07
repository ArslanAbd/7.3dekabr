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
        int b = Convert.ToInt32(TbNumberA.Text);
            switch (b) // переключатель,основанный на выборе пользователя
            {
                case 1:
                    {
                        MessageBox.Show("понедельник"); // выбрал значение 1
                        break;
                    }

                case 2:
                    {
                        MessageBox.Show("Вторник");    // выбрал значение 2
                        break;
                    }

                case 3:
                    {
                        MessageBox.Show("Среда");      // выбрал значение 3
                        break;
                    }

                case 4:
                    {
                        MessageBox.Show("Четверг");      // выбрал значение 4
                        break;
                    }

                case 5:
                    {
                        MessageBox.Show("Пятница");      // выбрал значение 5
                        break;
                    }

                case 6:
                    {
                        MessageBox.Show("Суббота");      // выбрал значение 6
                        break;
                    }

                case 7:
                    {
                        MessageBox.Show("Воскресенье");   // выбрал значение 7
                        break;
                    }
            }
        }

        private void TbNumberA_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
 

 }
