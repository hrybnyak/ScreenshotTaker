using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Ink;

namespace ScreenshotTaker.BL.Interface
{
    public interface IImageOpener
    {
        public StrokeCollection Open();
    }
}
