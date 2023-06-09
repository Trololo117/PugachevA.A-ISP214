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

namespace lab3._2
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

        private void SetColorWhite(object sender, RoutedEventArgs e)
        {
            canvas_brush.Color = Color.FromRgb(255, 255, 255);
        }
        private void SetColorRed(object sender, RoutedEventArgs e)
        {
            canvas_brush.Color = Color.FromRgb(255, 0, 0);
        }
        private void SetColorCrimson(object sender, RoutedEventArgs e)
        {
            canvas_brush.Color = Color.FromRgb(0x9B, 0x2D, 0x30);
        }

        private void IncreaseScale(object sender, RoutedEventArgs e)
        {
            canvas_brush.Width += 10;
            canvas_brush.Height += 10;
        }

        private void DecreaseScale(object sender, RoutedEventArgs e)
        {
            canvas_brush.Width -= 10;
            canvas_brush.Height -= 10;
        }

        private void ClearInkCanvas(object sender, RoutedEventArgs e)
        {
            ink_canvas.Strokes.Clear();
        }
    }
}
