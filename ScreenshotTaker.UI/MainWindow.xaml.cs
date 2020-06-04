using ScreenshotTaker.BL.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ScreenshotTaker.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SelfReflection = this;
        }

        public static MainWindow SelfReflection    // link on this private components to other classes
        {
            get; set;
        }

        private void AboutOpenEnter(object sender, RoutedEventArgs e)
        {
            ToolTip tOpen = new ToolTip();
            ItemOpen.ToolTip = tOpen;
            tOpen.Content = "Open file and load to InkCanvas.";
        }

        private void AboutSaveEnter(object sender, RoutedEventArgs e)
        {
            ToolTip tSave = new ToolTip();
            ItemSave.ToolTip = tSave;
            tSave.Content = "Save file to initial directory without bitmap coding for further opening in InkCanvas.";
        }

        private void AboutExportEnter(object sender, RoutedEventArgs e)
        {
            ToolTip tExport = new ToolTip();
            ItemExport.ToolTip = tExport;
            tExport.Content = "Export file to open in Windows. This will not be avaliable to open in InkCanvas.";
        }

        private void ClearClick(object sender, RoutedEventArgs e)
        {
            inkCanvas.Strokes.Clear();
        }

        private void ItemExitClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ColorPickerClick(object sender, RoutedEventArgs e)
        {
            ColorPicker picker = new ColorPicker();
            picker.Show();
        }

        private void CaptureClick(object sender, RoutedEventArgs e)
        {
            Hide();
            var screenshotTaker = new BL.Services.ScreenshotTaker();
            using (Bitmap bitmap = screenshotTaker.TakeScreenshot())
            {
                inkCanvas.Background = new ImageBrush(BitmapImageConverter.ConvertToBitmapSource(bitmap));
            }
            Show();
        }

        private void ItemOpenClick(object sender, RoutedEventArgs e)
        {
            ImageOpenerSaver imageOpenerSaver = new ImageOpenerSaver();
            inkCanvas.Strokes = imageOpenerSaver.Open();
        }

        private void ItemSaveClick(object sender, RoutedEventArgs e)
        {
            ImageOpenerSaver imageOpenerSaver = new ImageOpenerSaver();
            imageOpenerSaver.Save(inkCanvas.Strokes);
        }

        private void ItemExportClick(object sender, RoutedEventArgs e)
        {
            ImageOpenerSaver imageOpenerSaver = new ImageOpenerSaver();
            RenderTargetBitmap rtb = new RenderTargetBitmap((int)inkCanvas.ActualWidth, (int)inkCanvas.ActualHeight, 96d, 96d, PixelFormats.Default);
            rtb.Render(inkCanvas);
            imageOpenerSaver.Export(rtb);
        }
    }
}
