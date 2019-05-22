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

namespace PR4
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var btn = (Button)sender;
                switch (btn.Tag)
                {
                    case "first":
                        Rectangle rectangle1 = new Rectangle();
                        rectangle1.MouseLeftButtonDown += new MouseButtonEventHandler(Element_Click);
                        rectangle1.Width = 50;
                        rectangle1.Height = 50;
                        rectangle1.Stroke = Brushes.Black;
                        rectangle1.Fill = Brushes.Blue;
                        MainCanvas.Children.Add(rectangle1);
                        Canvas.SetLeft(rectangle1, double.Parse(x_coord.Text));
                        Canvas.SetTop(rectangle1, double.Parse(y_coord.Text));
                        break;
                    case "second":
                        Rectangle rectangle2 = new Rectangle();
                        rectangle2.MouseLeftButtonDown += new MouseButtonEventHandler(Element_Click);
                        rectangle2.Width = 100;
                        rectangle2.Height = 50;
                        rectangle2.Stroke = Brushes.Black;
                        rectangle2.Fill = Brushes.Red;
                        MainCanvas.Children.Add(rectangle2);
                        Canvas.SetLeft(rectangle2, double.Parse(x_coord.Text));
                        Canvas.SetTop(rectangle2, double.Parse(y_coord.Text));
                        break;
                    case "third":
                        Ellipse ellipse1 = new Ellipse();
                        ellipse1.MouseLeftButtonDown += new MouseButtonEventHandler(Element_Click);
                        ellipse1.Width = 50;
                        ellipse1.Height = 50;
                        ellipse1.Stroke = Brushes.Black;
                        ellipse1.Fill = Brushes.Yellow;
                        MainCanvas.Children.Add(ellipse1);
                        Canvas.SetLeft(ellipse1, double.Parse(x_coord.Text));
                        Canvas.SetTop(ellipse1, double.Parse(y_coord.Text));
                        break;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите нормальное значение");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Введите меньшее значение");
            }
        }
        private void Element_Click(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount > 1)
                MainCanvas.Children.Remove((UIElement)sender);
        }
    }
}
