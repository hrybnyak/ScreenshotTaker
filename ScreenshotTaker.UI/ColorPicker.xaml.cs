using ScreenshotTaker.BL.Models;
using ScreenshotTaker.BL.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ScreenshotTaker.UI
{
    /// <summary>
    /// Interaction logic for ColorPicker.xaml
    /// </summary>
    public partial class ColorPicker : Window
    {
        private RGB Current { get; set; }
        public ColorPicker()
        {
            InitializeComponent();
            var currentColor = MainWindow.SelfReflection.inkCanvas.DefaultDrawingAttributes.Color;
            Current = new RGB { Red = currentColor.R, Blue = currentColor.B, Green = currentColor.G };
            redColorSlider.Value = currentColor.R;
            blueColorSlider.Value = currentColor.B;
            greenColorSlider.Value = currentColor.G;
            label.Background = new SolidColorBrush(currentColor);
        }
        private void ColorValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var picked = ColorSliderPicker.FromRGBToColor(ColorSliderPicker.RGBFromSlider(sender as Slider, Current));
            label.Background = new SolidColorBrush(picked);
            MainWindow.SelfReflection.inkCanvas.DefaultDrawingAttributes.Color = picked;
        }

        private void ThicknessSliderValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            MainWindow.SelfReflection.inkCanvas.DefaultDrawingAttributes.Width = thicknessSlider.Value;
            MainWindow.SelfReflection.inkCanvas.DefaultDrawingAttributes.Height = thicknessSlider.Value;
        }
    }
}
