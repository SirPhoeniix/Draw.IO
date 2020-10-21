namespace Drawboard
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTop = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelSize = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBoxSize = new System.Windows.Forms.ToolStripComboBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripLeft = new System.Windows.Forms.ToolStrip();
            this.pictureBoxDrawboard = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panelDrawboardHolder = new System.Windows.Forms.Panel();
            this.panelResizeWidth = new System.Windows.Forms.Panel();
            this.panelResize = new System.Windows.Forms.Panel();
            this.panelResizeHeight = new System.Windows.Forms.Panel();
            this.toolStripStatusLabelSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelMouseLocation = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelSplit = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelFile = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControlDrawboards = new System.Windows.Forms.TabControl();
            this.tabPageNew = new System.Windows.Forms.TabPage();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.toolStripTop.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDrawboard)).BeginInit();
            this.flowLayoutPanel.SuspendLayout();
            this.panelDrawboardHolder.SuspendLayout();
            this.tabControlDrawboards.SuspendLayout();
            this.tabPageNew.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1046, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(145, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.saveAsToolStripMenuItem.Text = "Save as";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(145, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.UndoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.RedoToolStripMenuItem_Click);
            // 
            // toolStripTop
            // 
            this.toolStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelSize,
            this.toolStripComboBoxSize});
            this.toolStripTop.Location = new System.Drawing.Point(0, 24);
            this.toolStripTop.Name = "toolStripTop";
            this.toolStripTop.Size = new System.Drawing.Size(1046, 25);
            this.toolStripTop.TabIndex = 2;
            this.toolStripTop.Text = "toolStripTop";
            // 
            // toolStripLabelSize
            // 
            this.toolStripLabelSize.Name = "toolStripLabelSize";
            this.toolStripLabelSize.Size = new System.Drawing.Size(27, 22);
            this.toolStripLabelSize.Text = "Size";
            // 
            // toolStripComboBoxSize
            // 
            this.toolStripComboBoxSize.AutoSize = false;
            this.toolStripComboBoxSize.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.toolStripComboBoxSize.Name = "toolStripComboBoxSize";
            this.toolStripComboBoxSize.Size = new System.Drawing.Size(40, 23);
            this.toolStripComboBoxSize.TextChanged += new System.EventHandler(this.ToolStripComboBoxSize_TextChanged);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripStatusLabelFile,
            this.toolStripStatusLabelSplit,
            this.toolStripStatusLabelSize,
            this.toolStripStatusLabelMouseLocation});
            this.statusStrip.Location = new System.Drawing.Point(0, 546);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1046, 22);
            this.statusStrip.TabIndex = 4;
            this.statusStrip.Text = "statusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripLeft
            // 
            this.toolStripLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStripLeft.Location = new System.Drawing.Point(0, 49);
            this.toolStripLeft.Name = "toolStripLeft";
            this.toolStripLeft.Size = new System.Drawing.Size(26, 497);
            this.toolStripLeft.TabIndex = 5;
            this.toolStripLeft.Text = "toolStripLeft";
            // 
            // pictureBoxDrawboard
            // 
            this.pictureBoxDrawboard.BackColor = System.Drawing.Color.White;
            this.pictureBoxDrawboard.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxDrawboard.Name = "pictureBoxDrawboard";
            this.pictureBoxDrawboard.Size = new System.Drawing.Size(800, 400);
            this.pictureBoxDrawboard.TabIndex = 0;
            this.pictureBoxDrawboard.TabStop = false;
            this.pictureBoxDrawboard.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBoxDrawboard_Paint);
            this.pictureBoxDrawboard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBoxDrawboard_MouseDown);
            this.pictureBoxDrawboard.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBoxDrawboard_MouseMove);
            this.pictureBoxDrawboard.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBoxDrawboard_MouseUp);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Controls.Add(this.panelDrawboardHolder);
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(1006, 464);
            this.flowLayoutPanel.TabIndex = 9;
            // 
            // panelDrawboardHolder
            // 
            this.panelDrawboardHolder.BackColor = System.Drawing.SystemColors.Control;
            this.panelDrawboardHolder.Controls.Add(this.panelResizeHeight);
            this.panelDrawboardHolder.Controls.Add(this.panelResize);
            this.panelDrawboardHolder.Controls.Add(this.panelResizeWidth);
            this.panelDrawboardHolder.Controls.Add(this.pictureBoxDrawboard);
            this.panelDrawboardHolder.Location = new System.Drawing.Point(3, 3);
            this.panelDrawboardHolder.Name = "panelDrawboardHolder";
            this.panelDrawboardHolder.Size = new System.Drawing.Size(820, 420);
            this.panelDrawboardHolder.TabIndex = 1;
            // 
            // panelResizeWidth
            // 
            this.panelResizeWidth.BackColor = System.Drawing.Color.White;
            this.panelResizeWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelResizeWidth.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.panelResizeWidth.Location = new System.Drawing.Point(803, 200);
            this.panelResizeWidth.Name = "panelResizeWidth";
            this.panelResizeWidth.Size = new System.Drawing.Size(7, 7);
            this.panelResizeWidth.TabIndex = 1;
            this.panelResizeWidth.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelResize_MouseDown);
            this.panelResizeWidth.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelResizeWidth_MouseMove);
            this.panelResizeWidth.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelResize_MouseUp);
            // 
            // panelResize
            // 
            this.panelResize.BackColor = System.Drawing.Color.White;
            this.panelResize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelResize.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.panelResize.Location = new System.Drawing.Point(803, 403);
            this.panelResize.Name = "panelResize";
            this.panelResize.Size = new System.Drawing.Size(7, 7);
            this.panelResize.TabIndex = 2;
            this.panelResize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelResize_MouseDown);
            this.panelResize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelResize_MouseMove);
            this.panelResize.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelResize_MouseUp);
            // 
            // panelResizeHeight
            // 
            this.panelResizeHeight.BackColor = System.Drawing.Color.White;
            this.panelResizeHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelResizeHeight.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.panelResizeHeight.Location = new System.Drawing.Point(400, 403);
            this.panelResizeHeight.Name = "panelResizeHeight";
            this.panelResizeHeight.Size = new System.Drawing.Size(7, 7);
            this.panelResizeHeight.TabIndex = 3;
            this.panelResizeHeight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelResize_MouseDown);
            this.panelResizeHeight.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelResizeHeight_MouseMove);
            this.panelResizeHeight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelResize_MouseUp);
            // 
            // toolStripStatusLabelSize
            // 
            this.toolStripStatusLabelSize.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.toolStripStatusLabelSize.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.toolStripStatusLabelSize.Name = "toolStripStatusLabelSize";
            this.toolStripStatusLabelSize.Size = new System.Drawing.Size(4, 17);
            // 
            // toolStripStatusLabelMouseLocation
            // 
            this.toolStripStatusLabelMouseLocation.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.toolStripStatusLabelMouseLocation.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.toolStripStatusLabelMouseLocation.Name = "toolStripStatusLabelMouseLocation";
            this.toolStripStatusLabelMouseLocation.Size = new System.Drawing.Size(4, 17);
            // 
            // toolStripStatusLabelSplit
            // 
            this.toolStripStatusLabelSplit.Name = "toolStripStatusLabelSplit";
            this.toolStripStatusLabelSplit.Size = new System.Drawing.Size(1019, 17);
            this.toolStripStatusLabelSplit.Spring = true;
            // 
            // toolStripStatusLabelFile
            // 
            this.toolStripStatusLabelFile.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.toolStripStatusLabelFile.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.toolStripStatusLabelFile.Name = "toolStripStatusLabelFile";
            this.toolStripStatusLabelFile.Size = new System.Drawing.Size(4, 17);
            // 
            // tabControlDrawboards
            // 
            this.tabControlDrawboards.Controls.Add(this.tabPageNew);
            this.tabControlDrawboards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlDrawboards.ImageList = this.imageList;
            this.tabControlDrawboards.Location = new System.Drawing.Point(26, 49);
            this.tabControlDrawboards.Name = "tabControlDrawboards";
            this.tabControlDrawboards.SelectedIndex = 0;
            this.tabControlDrawboards.Size = new System.Drawing.Size(1020, 497);
            this.tabControlDrawboards.TabIndex = 2;
            // 
            // tabPageNew
            // 
            this.tabPageNew.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageNew.Controls.Add(this.flowLayoutPanel);
            this.tabPageNew.ImageIndex = 0;
            this.tabPageNew.Location = new System.Drawing.Point(4, 23);
            this.tabPageNew.Name = "tabPageNew";
            this.tabPageNew.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNew.Size = new System.Drawing.Size(1012, 470);
            this.tabPageNew.TabIndex = 0;
            this.tabPageNew.Text = "New";
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "pen-48.png");
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 568);
            this.Controls.Add(this.tabControlDrawboards);
            this.Controls.Add(this.toolStripLeft);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStripTop);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Drawboard";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStripTop.ResumeLayout(false);
            this.toolStripTop.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDrawboard)).EndInit();
            this.flowLayoutPanel.ResumeLayout(false);
            this.panelDrawboardHolder.ResumeLayout(false);
            this.tabControlDrawboards.ResumeLayout(false);
            this.tabPageNew.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStripTop;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStrip toolStripLeft;
        private System.Windows.Forms.PictureBox pictureBoxDrawboard;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.ToolStripLabel toolStripLabelSize;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxSize;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.Panel panelDrawboardHolder;
        private System.Windows.Forms.Panel panelResizeHeight;
        private System.Windows.Forms.Panel panelResize;
        private System.Windows.Forms.Panel panelResizeWidth;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelSize;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMouseLocation;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelSplit;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelFile;
        private System.Windows.Forms.TabControl tabControlDrawboards;
        private System.Windows.Forms.TabPage tabPageNew;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
    }
}

