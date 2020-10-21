using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawboard
{
    class FileHandler
    {
        public static string Path;

        public static void SaveFile(Bitmap bitmap, bool bSaveAs)
        {
            if (bSaveAs)
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Bitmap|*.bmp";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string szPath = saveFileDialog.FileName;
                        bitmap.Save(szPath);
                        Path = szPath;
                    }
                }
            }
            else
            {
                if (File.Exists(Path))
                {
                    bitmap.Save(Path + ".bmp");
                }
                else
                {
                    SaveFile(bitmap, true);
                }
            }
        }

        public static Bitmap OpenFile()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Bitmap|*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string szPath = openFileDialog.FileName;
                    Bitmap bitmap = new Bitmap(szPath);
                    Path = szPath;
                    return bitmap;
                }
                else
                {
                    return null;
                }
            }
        }

        public static Bitmap OpenFile(string szPath)
        {
            try
            {
                Bitmap bitmap = new Bitmap(szPath);
                Path = szPath;
                return bitmap;
            }
            catch (Exception e)
            {
                MessageBox.Show("Dragged file is not an image", "Import error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
