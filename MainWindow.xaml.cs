using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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

namespace TriangleTest
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

        private void Button_ClickCheck(object sender, RoutedEventArgs e)
        {
            try
            {
                int sideTriA = Convert.ToInt32(sideA.Text);
                int sideTriB = Convert.ToInt32(sideB.Text);
                int sideTriC = Convert.ToInt32(sideC.Text);

                if(sideTriA <= 0 || sideTriB <= 0 ||sideTriC <= 0)
                {
                    tbAnswer.Text = "Ошибка. Стороны не могут быть отрицательными или 0";
                }
                else if(sideTriA >= sideTriB + sideTriC || sideTriB >= sideTriA + sideTriC || sideTriC >= sideTriB + sideTriA)
                {
                    tbAnswer.Text = "Ошибка. Одна сторона больше суммы других сторон или равна";
                }
                else if (sideTriA == sideTriB && sideTriB == sideTriC && sideTriA == sideTriC)
                {
                    tbAnswer.Text = "Равносторонний";
                }
                else if (sideTriA == sideTriB || sideTriA == sideTriC || sideTriB == sideTriC)
                {
                    tbAnswer.Text = "Равнобедренный";
                }
                else
                {
                    tbAnswer.Text = "Разносторонний";
                }
            }
            catch { tbAnswer.Text = "Ошибка! Это не треугольник"; }


            inputGrid.Visibility = Visibility.Hidden;
            answerGrid.Visibility = Visibility.Visible;

        }

        private void Button_ClickBack(object sender, RoutedEventArgs e)
        {
            answerGrid.Visibility = Visibility.Hidden;
            inputGrid.Visibility = Visibility.Visible;
        }
    }
}
