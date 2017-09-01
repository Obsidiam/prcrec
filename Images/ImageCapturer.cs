﻿using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System;

namespace ProcessRecorder.Images
{
    internal class ImageCapturer
    {
        public static string USER_NAME  = System.Security.Principal.WindowsIdentity.GetCurrent().Name;   
        public static string TMP_DIR = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)+"\\Local\\PrcRecTmp";

        public ImageCapturer() {
            if (!Directory.Exists(TMP_DIR)) {
                Directory.CreateDirectory(TMP_DIR);
            }
        }

        public void CaptureTheScreenImage(int x, int y) {
            using (Bitmap bmpScreenCapture = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height))
            {
                using (Graphics g = Graphics.FromImage(bmpScreenCapture))
                {
                    g.CopyFromScreen(Screen.PrimaryScreen.Bounds.X,
                                     Screen.PrimaryScreen.Bounds.Y,
                                     0, 0,
                                     bmpScreenCapture.Size,
                                     CopyPixelOperation.SourceCopy);
                }
                Rectangle section = new Rectangle(new Point(x, y), new Size(250, 150));
                CropImage(bmpScreenCapture,section).Save(TMP_DIR);
                GC.Collect();
            }

        }

        protected Bitmap CropImage(Bitmap source, Rectangle section)
        {
            Bitmap bmp = new Bitmap(section.Width, section.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.DrawImage(source, 0, 0, section, GraphicsUnit.Pixel);
            return bmp;
        }

        public string getImageDir() {
            return TMP_DIR;
        }
    }
}
