using ScreenshotTaker.BL.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows;

namespace ScreenshotTaker.BL.Services
{
    public class ScreenshotTaker : IScreenshotTaker
    {
        public Bitmap TakeScreenshot()
        {
            Bitmap bitmap = new Bitmap(1920, 1080);
            using (Graphics graphics = Graphics.FromImage(bitmap as System.Drawing.Image))
                {
                    graphics.CopyFromScreen(0, 0, 0, 0, bitmap.Size);
                }
            return bitmap;
        }
    }
}
