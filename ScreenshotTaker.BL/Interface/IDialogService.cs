using System;
using System.Collections.Generic;
using System.Text;

namespace ScreenshotTaker.BL.Interface
{
    public interface IDialogService
    {
        string FilePath { get; set; }
        bool OpenFileDialog();
        bool SaveFileDialog();
    }
}
