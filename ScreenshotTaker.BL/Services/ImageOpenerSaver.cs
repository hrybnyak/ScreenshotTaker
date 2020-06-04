using ScreenshotTaker.BL.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Ink;
using System.Windows.Media.Imaging;

namespace ScreenshotTaker.BL.Services
{
    public class ImageOpenerSaver : IImageSaver, IImageOpener
    {
        private DefaultDialogService DefaultDialogService { get; set; }
        private string DefaultDirectory = @"C:\Users\Lisa\Pictures\";
        public ImageOpenerSaver()
        {
            DefaultDialogService = new DefaultDialogService();
        }

        public void Export(RenderTargetBitmap rendered)
        {
            DefaultDialogService.SaveFileDialog();
            using (FileStream fs = new FileStream(DefaultDialogService.FilePath, FileMode.Create))
            {
                PngBitmapEncoder pngEnc = new PngBitmapEncoder();
                pngEnc.Frames.Add(BitmapFrame.Create(rendered));
                pngEnc.Save(fs);
                MessageBox.Show("Picture was successfully exported!");
            }
        }

        public void Save(StrokeCollection strokes)
        {
            using (FileStream fs = new FileStream(DefaultDirectory + DateTime.Now.Day + DateTime.Now.Month + DateTime.Now.Year + DateTime.Now.Hour + DateTime.Now.Minute +
                    DateTime.Now.Second + ".png", FileMode.Create))
            {
                try
                {
                    strokes.Save(fs);
                    MessageBox.Show("Picture was successfully saved!");
                }
                catch
                {
                    MessageBox.Show("Unable to save file. Check the path.");
                }

            }
        }

        public StrokeCollection Open()
        {
            DefaultDialogService.OpenFileDialog();
            using (FileStream fs = new FileStream(DefaultDialogService.FilePath, FileMode.Open))
            {
                return new StrokeCollection(fs);
            }
        }
    }
}
