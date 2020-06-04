using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Ink;
using System.Windows.Media.Imaging;

namespace ScreenshotTaker.BL.Interface
{
    public interface IImageSaver
    {
        public void Export(RenderTargetBitmap rendered);
        public void Save(StrokeCollection strokes);
    }
}
