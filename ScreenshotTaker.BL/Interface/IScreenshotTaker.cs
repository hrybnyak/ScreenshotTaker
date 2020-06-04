using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows;

namespace ScreenshotTaker.BL.Interface
{
    public interface IScreenshotTaker
    {
        public Bitmap TakeScreenshot();
    }
}
