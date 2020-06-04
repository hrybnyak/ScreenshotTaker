using Microsoft.Win32;
using ScreenshotTaker.BL.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScreenshotTaker.BL.Services
{
    public class DefaultDialogService : IDialogService
    {
        public string FilePath { get; set; }

        public bool OpenFileDialog()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All files (*.*)|*.*|PNG (*.png)|*.png";
            if (openFileDialog.ShowDialog() == true)
            {
                FilePath = openFileDialog.FileName;
                return true;
            }
            return false;
        }

        public bool SaveFileDialog()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JPEG (*.jpg)|*.jpg|BMP (*.bmp*)|*.bmp|PNG (*.png)|*.png|GIF (*.gif)|*.gif";
            if (saveFileDialog.ShowDialog() == true)
            {
                FilePath = saveFileDialog.FileName;
                return true;
            }
            return false;
        }

    }
}
