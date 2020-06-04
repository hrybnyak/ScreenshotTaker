using ScreenshotTaker.BL.Interface;
using ScreenshotTaker.BL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media;

namespace ScreenshotTaker.BL.Services
{
    public static class ColorSliderPicker
    {
        public static RGB RGBFromSlider(Slider slider, RGB picked)
        {
            string sliderName = slider.Name;
            double sliderValue = slider.Value;
            switch (sliderName)
            {
                case "redColorSlider":
                    picked.Red = Convert.ToByte(sliderValue);
                    break;
                case "greenColorSlider":
                    picked.Green = Convert.ToByte(sliderValue);
                    break;
                case "blueColorSlider":
                    picked.Blue = Convert.ToByte(sliderValue);
                    break;
            }
            return picked;
        }

        public static Color FromRGBToColor(RGB rgb)
        {
            return Color.FromRgb(rgb.Red, rgb.Green, rgb.Blue);
        }
    }
}
