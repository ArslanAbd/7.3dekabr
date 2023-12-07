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
            int D = int.Parse(TbNumberA.Text);
            int M = int.Parse(TbNumberB.Text);
            string H = "";
            switch (D)
            {
                case 6: H = "шестерка"; break;
                case 7: H = "семерка"; break;
                case 8: H = "восьмерка"; break;
                case 9: H = "девятка"; break;
                case 10: H = "десятка"; break;
                case 11: H = "валет"; break;
                case 12: H = "дама"; break;
                case 13: H = "король"; break;
                case 14: H = "туз"; break;
            }
            switch (M)
            {
                case 1: H += "пик"; break;
                case 2: H += "трефы"; break;
                case 3: H += "бубны"; break;
                case 4: H += "червы"; break;
            }
            TextBlockAnswer.Text = $"Ответ: {H}";
        }
    }
}
