using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawboard
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitializeBitmap();
        }

        private Bitmap m_bBitmap;
        private BitmapHistory m_BitmapHistory;
        ICollection<IPluginTool> m_iPlugins;
        private IPluginTool m_iActivePlugin;
        private Pen m_pPen;
        private Color m_cPenColor;
        private bool m_bResize;

        private void InitializeBitmap()
        {
            m_BitmapHistory = new BitmapHistory();
            m_bBitmap = new Bitmap(pictureBoxDrawboard.Width, pictureBoxDrawboard.Height);
            UpdateBitmapHistory();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            m_pPen = new Pen(Color.Black, 5);
            m_cPenColor = Color.Black;

            LoadPlugins();
            InitializeGraphics();
            InitializeActivePlugin();
            LoadLeftToolbar();
            UpdateResizeButtonLocation();

            toolStripComboBoxSize.Text = m_pPen.Width.ToString();
            toolStripStatusLabelMouseLocation.Text = string.Format("X: {0}, Y: {1}", 0, 0);
        }

        private void LoadPlugins()
        {
            m_iPlugins = PluginLoader.LoadPlugins("Plugins");
        }

        private void LoadBitmap()
        {
            Bitmap bitmap = FileHandler.OpenFile();
            if (bitmap != null)
            {
                pictureBoxDrawboard.Width = bitmap.Width;
                pictureBoxDrawboard.Height = bitmap.Height;
                m_bBitmap = bitmap;
                pictureBoxDrawboard.Image = m_bBitmap;
                toolStripStatusLabelFile.Text = FileHandler.Path;
            }
            else
            {
                UpdateErrorLabel("Failed to open file.");
            }
        }

        private void LoadColorDialog()
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    m_cPenColor = colorDialog.Color;
                    UpdatePen();
                }
            }
        }

        private void InitializeGraphics()
        {
            Graphics graphics = Graphics.FromImage(m_bBitmap);
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

            foreach (IPluginTool plugin in m_iPlugins)
            {
                plugin.SetGraphics(graphics);
                plugin.Pen = m_pPen;
            }

            pictureBoxDrawboard.Image = m_bBitmap;
        }

        private void InitializeActivePlugin()
        {
            foreach (IPluginTool plugin in m_iPlugins)
            {
                if ("PenTool" == plugin.Name)
                {
                    m_iActivePlugin = plugin;
                    m_iActivePlugin.Pen = m_pPen;
                    break;
                }
            }
        }

        private void ClearBitmap()
        {
            InitializeBitmap();
            pictureBoxDrawboard.Image = default(Image);
        }

        private void UpdateBitmapHistory()
        {
            Bitmap clone = (Bitmap)m_bBitmap.Clone();
            m_BitmapHistory.Add(clone);
        }

        private void UpdateErrorLabel(string szError)
        {
            toolStripStatusLabel.Text = szError;
        }

        private void LoadLeftToolbar()
        {
            foreach(IPluginTool plugin in m_iPlugins)
            {
                ToolStripItem item = toolStripLeft.Items.Add(plugin.Name, plugin.Icon, ToolStripLeft_Click);
                item.DisplayStyle = ToolStripItemDisplayStyle.Image;
                item.ToolTipText = plugin.Name;

                if (m_iActivePlugin.Name == plugin.Name)
                {
                    item.BackColor = ColorTranslator.FromHtml("#C2E0FF");
                }
            }

            ToolStripItem colorItem = toolStripLeft.Items.Add("ColorSelection", Resource.color_palette_48, ToolStripLeftColorSelection_Click);
            colorItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            colorItem.ToolTipText = "ColorSelection";
        }

        private void UpdateResizeButtonLocation()
        {
            panelResize.Location = new Point(pictureBoxDrawboard.Width + 3, pictureBoxDrawboard.Height + 3);
            panelResizeWidth.Location = new Point(pictureBoxDrawboard.Width + 3, pictureBoxDrawboard.Height / 2);
            panelResizeHeight.Location = new Point(pictureBoxDrawboard.Width / 2, pictureBoxDrawboard.Height + 3);

            toolStripStatusLabelSize.Text = string.Format("Width: {0}, Height: {1}", pictureBoxDrawboard.Width, pictureBoxDrawboard.Height);
        }

        private void ToolStripLeftColorSelection_Click(object sender, EventArgs e)
        {
            LoadColorDialog();
        }

        private void ToolStripLeft_Click(object sender, EventArgs e)
        {
            foreach (ToolStripItem oItem in toolStripLeft.Items)
            {
                oItem.BackColor = default(Color);
            }

            ToolStripItem item = sender as ToolStripItem;
            if (item != null)
            {
                foreach(IPluginTool plugin in m_iPlugins)
                {
                    if (item.Text == plugin.Name)
                    {
                        Plugin_Change(plugin);
                        item.BackColor = ColorTranslator.FromHtml("#C2E0FF");
                        break;
                    }
                }
            }
        }

        private void Plugin_Change(IPluginTool plugin)
        {
            m_iActivePlugin = plugin;
            m_iActivePlugin.Pen = m_pPen;
        }

        private void UpdatePen()
        {
            int nWidth;
            Int32.TryParse(toolStripComboBoxSize.Text, out nWidth);
            m_pPen.Width = nWidth;
            m_pPen.Color = m_cPenColor;
            Plugin_Change(m_iActivePlugin);
        }

        private void PictureBoxDrawboard_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = Graphics.FromImage(m_bBitmap);
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

            foreach (IPluginTool plugin in m_iPlugins)
            {
                plugin.SetGraphics(graphics);
                plugin.Pen = m_pPen;
            }

            //pictureBoxDrawboard.Image = m_bBitmap;
        }

        private void PictureBoxDrawboard_MouseDown(object sender, MouseEventArgs e)
        {
            m_iActivePlugin.OnMouseDown(sender, e);
            pictureBoxDrawboard.Image = m_bBitmap;
        }

        private void PictureBoxDrawboard_MouseUp(object sender, MouseEventArgs e)
        {
            m_iActivePlugin.OnMouseUp(sender, e);
            pictureBoxDrawboard.Image = m_bBitmap;

            UpdateBitmapHistory();
        }

        private void PictureBoxDrawboard_MouseMove(object sender, MouseEventArgs e)
        {
            m_iActivePlugin.OnMouseMove(sender, e);
            pictureBoxDrawboard.Image = m_bBitmap;

            toolStripStatusLabelMouseLocation.Text = string.Format("X: {0}, Y: {1}", e.X, e.Y);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            m_iActivePlugin.OnKeyDown(this, keyData);
            pictureBoxDrawboard.Image = m_bBitmap;

            return base.ProcessCmdKey(ref msg, keyData);
        }

        public void OnError(Exception e)
        {
            toolStripStatusLabel.Text = e.Message;
        }

        private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_bBitmap = m_BitmapHistory.GetPrev();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadBitmap();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileHandler.SaveFile(m_bBitmap, false);
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileHandler.SaveFile(m_bBitmap, true);
            toolStripStatusLabelFile.Text = FileHandler.Path;
            tabPageNew.Text = FileHandler.Path;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToolStripComboBoxSize_TextChanged(object sender, EventArgs e)
        {
            UpdatePen();
        }

        private void RedoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_bBitmap = m_BitmapHistory.GetNext();
        }

        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                Bitmap bitmap = FileHandler.OpenFile(file);
                if (bitmap != null)
                {
                    pictureBoxDrawboard.Width = bitmap.Width;
                    pictureBoxDrawboard.Height = bitmap.Height;
                    m_bBitmap = bitmap;
                    pictureBoxDrawboard.Image = m_bBitmap;
                    toolStripStatusLabelFile.Text = FileHandler.Path;
                    string[] filePath = FileHandler.Path.Split('\\');
                    tabPageNew.Text = filePath[filePath.GetLength(0) - 1];
                }
                else
                {
                    UpdateErrorLabel("Failed to open file.");
                }
            }
        }

        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void PanelResize_MouseMove(object sender, MouseEventArgs e)
        {
            if (m_bResize)
            {
                int x = e.X;
                int y = e.Y;

                if ((pictureBoxDrawboard.Width + x) >= 5 && (pictureBoxDrawboard.Height + y) >= 5)
                {
                    pictureBoxDrawboard.Size = new Size(pictureBoxDrawboard.Width + x, pictureBoxDrawboard.Height + y);
                    panelDrawboardHolder.Size = new Size(panelDrawboardHolder.Width + x, panelDrawboardHolder.Height + y);

                    UpdateResizeButtonLocation();
                }
            }
        }

        private void PanelResize_MouseDown(object sender, MouseEventArgs e)
        {
            m_bResize = true;
        }

        private void PanelResize_MouseUp(object sender, MouseEventArgs e)
        {
            m_bResize = false;
        }

        private void PanelResizeWidth_MouseMove(object sender, MouseEventArgs e)
        {
            if (m_bResize)
            {
                int x = e.X;
                int y = e.Y;

                if ((pictureBoxDrawboard.Width + x) >= 5)
                {
                    pictureBoxDrawboard.Size = new Size(pictureBoxDrawboard.Width + x, pictureBoxDrawboard.Height);
                    panelDrawboardHolder.Size = new Size(panelDrawboardHolder.Width + x, panelDrawboardHolder.Height);

                    UpdateResizeButtonLocation();
                }
            }
        }

        private void PanelResizeHeight_MouseMove(object sender, MouseEventArgs e)
        {
            if (m_bResize)
            {
                int x = e.X;
                int y = e.Y;

                if ((pictureBoxDrawboard.Height + y) >= 5)
                {
                    pictureBoxDrawboard.Size = new Size(pictureBoxDrawboard.Width, pictureBoxDrawboard.Height + y);
                    panelDrawboardHolder.Size = new Size(panelDrawboardHolder.Width, panelDrawboardHolder.Height + y);

                    UpdateResizeButtonLocation();
                }
            }
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearBitmap();
        }
    }
}
