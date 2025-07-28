using System.Windows.Forms;

namespace eXCute
{
    partial class WMP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playlistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearComboBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxToPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cBPlaylist_tbSaveAs = new System.Windows.Forms.ToolStripTextBox();
            this.listBoxToPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tT_savelistBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.textfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOADListBoxFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quickstartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideWMPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hidePlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuply_open = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuply_prev = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuply_stop = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuply_play = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuply_next = new System.Windows.Forms.ToolStripMenuItem();
            this.cBPlaylist = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.chkLooping = new System.Windows.Forms.CheckBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.sel_List = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.löschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TrackBar1 = new System.Windows.Forms.TrackBar();
            this.lblfileName = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.sel_List.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe Script", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.quickstartToolStripMenuItem,
            this.mnuply_open,
            this.mnuply_prev,
            this.mnuply_stop,
            this.mnuply_play,
            this.mnuply_next});
            this.menuStrip1.Location = new System.Drawing.Point(9, 21);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(318, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.playlistToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(45, 23);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.LoadFolderEvent);
            // 
            // playlistToolStripMenuItem
            // 
            this.playlistToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearListToolStripMenuItem,
            this.clearComboBoxToolStripMenuItem,
            this.comboBoxToPlaylistToolStripMenuItem,
            this.listBoxToPlaylistToolStripMenuItem,
            this.lOADListBoxFromFileToolStripMenuItem});
            this.playlistToolStripMenuItem.Name = "playlistToolStripMenuItem";
            this.playlistToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.playlistToolStripMenuItem.Text = "Playlist";
            // 
            // clearListToolStripMenuItem
            // 
            this.clearListToolStripMenuItem.Name = "clearListToolStripMenuItem";
            this.clearListToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.clearListToolStripMenuItem.Text = "Clear ListBox";
            this.clearListToolStripMenuItem.Click += new System.EventHandler(this.clearListToolStripMenuItem_Click);
            // 
            // clearComboBoxToolStripMenuItem
            // 
            this.clearComboBoxToolStripMenuItem.Name = "clearComboBoxToolStripMenuItem";
            this.clearComboBoxToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.clearComboBoxToolStripMenuItem.Text = "Clear ComboBox";
            this.clearComboBoxToolStripMenuItem.Click += new System.EventHandler(this.clearComboBoxToolStripMenuItem_Click);
            // 
            // comboBoxToPlaylistToolStripMenuItem
            // 
            this.comboBoxToPlaylistToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsToolStripMenuItem});
            this.comboBoxToPlaylistToolStripMenuItem.Name = "comboBoxToPlaylistToolStripMenuItem";
            this.comboBoxToPlaylistToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.comboBoxToPlaylistToolStripMenuItem.Text = "ComboBox to Playlist";
            this.comboBoxToPlaylistToolStripMenuItem.Click += new System.EventHandler(this.comboBoxToPlaylistToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cBPlaylist_tbSaveAs});
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.saveAsToolStripMenuItem.Text = "Save as";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // cBPlaylist_tbSaveAs
            // 
            this.cBPlaylist_tbSaveAs.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cBPlaylist_tbSaveAs.Name = "cBPlaylist_tbSaveAs";
            this.cBPlaylist_tbSaveAs.Size = new System.Drawing.Size(100, 23);
            // 
            // listBoxToPlaylistToolStripMenuItem
            // 
            this.listBoxToPlaylistToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsToolStripMenuItem2});
            this.listBoxToPlaylistToolStripMenuItem.Name = "listBoxToPlaylistToolStripMenuItem";
            this.listBoxToPlaylistToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.listBoxToPlaylistToolStripMenuItem.Text = "List Box to Playlist";
            this.listBoxToPlaylistToolStripMenuItem.Click += new System.EventHandler(this.listBoxToPlaylistToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem2
            // 
            this.saveAsToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tT_savelistBox1,
            this.textfileToolStripMenuItem});
            this.saveAsToolStripMenuItem2.Name = "saveAsToolStripMenuItem2";
            this.saveAsToolStripMenuItem2.Size = new System.Drawing.Size(180, 24);
            this.saveAsToolStripMenuItem2.Text = "save as";
            this.saveAsToolStripMenuItem2.Click += new System.EventHandler(this.saveAsToolStripMenuItem2_Click);
            // 
            // tT_savelistBox1
            // 
            this.tT_savelistBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tT_savelistBox1.Name = "tT_savelistBox1";
            this.tT_savelistBox1.Size = new System.Drawing.Size(100, 23);
            // 
            // textfileToolStripMenuItem
            // 
            this.textfileToolStripMenuItem.Name = "textfileToolStripMenuItem";
            this.textfileToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.textfileToolStripMenuItem.Text = "Textfile";
            this.textfileToolStripMenuItem.Click += new System.EventHandler(this.textfileToolStripMenuItem_Click_1);
            // 
            // lOADListBoxFromFileToolStripMenuItem
            // 
            this.lOADListBoxFromFileToolStripMenuItem.Name = "lOADListBoxFromFileToolStripMenuItem";
            this.lOADListBoxFromFileToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.lOADListBoxFromFileToolStripMenuItem.Text = "LOAD ListBox from File";
            this.lOADListBoxFromFileToolStripMenuItem.Click += new System.EventHandler(this.lOADListBoxFromFileToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // quickstartToolStripMenuItem
            // 
            this.quickstartToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hideListToolStripMenuItem,
            this.hideWMPToolStripMenuItem,
            this.hidePlayerToolStripMenuItem,
            this.loopToolStripMenuItem});
            this.quickstartToolStripMenuItem.Name = "quickstartToolStripMenuItem";
            this.quickstartToolStripMenuItem.Size = new System.Drawing.Size(52, 23);
            this.quickstartToolStripMenuItem.Text = "&Style";
            // 
            // hideListToolStripMenuItem
            // 
            this.hideListToolStripMenuItem.Name = "hideListToolStripMenuItem";
            this.hideListToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.hideListToolStripMenuItem.Text = "Hide List";
            this.hideListToolStripMenuItem.Click += new System.EventHandler(this.hideListToolStripMenuItem_Click);
            // 
            // hideWMPToolStripMenuItem
            // 
            this.hideWMPToolStripMenuItem.Name = "hideWMPToolStripMenuItem";
            this.hideWMPToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.hideWMPToolStripMenuItem.Text = "Hide WMP";
            this.hideWMPToolStripMenuItem.Click += new System.EventHandler(this.hideWMPToolStripMenuItem_Click);
            // 
            // hidePlayerToolStripMenuItem
            // 
            this.hidePlayerToolStripMenuItem.Name = "hidePlayerToolStripMenuItem";
            this.hidePlayerToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.hidePlayerToolStripMenuItem.Text = "Hide Player";
            this.hidePlayerToolStripMenuItem.Click += new System.EventHandler(this.hidePlayerToolStripMenuItem_Click);
            // 
            // loopToolStripMenuItem
            // 
            this.loopToolStripMenuItem.Name = "loopToolStripMenuItem";
            this.loopToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.loopToolStripMenuItem.Text = "loop";
            this.loopToolStripMenuItem.Click += new System.EventHandler(this.loopToolStripMenuItem_Click);
            // 
            // mnuply_open
            // 
            this.mnuply_open.Name = "mnuply_open";
            this.mnuply_open.Size = new System.Drawing.Size(54, 23);
            this.mnuply_open.Text = "&Open";
            this.mnuply_open.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // mnuply_prev
            // 
            this.mnuply_prev.Name = "mnuply_prev";
            this.mnuply_prev.Size = new System.Drawing.Size(41, 23);
            this.mnuply_prev.Text = "<-<";
            this.mnuply_prev.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // mnuply_stop
            // 
            this.mnuply_stop.Name = "mnuply_stop";
            this.mnuply_stop.Size = new System.Drawing.Size(47, 23);
            this.mnuply_stop.Text = "Stop";
            this.mnuply_stop.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // mnuply_play
            // 
            this.mnuply_play.Name = "mnuply_play";
            this.mnuply_play.Size = new System.Drawing.Size(28, 23);
            this.mnuply_play.Text = ">";
            this.mnuply_play.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // mnuply_next
            // 
            this.mnuply_next.Name = "mnuply_next";
            this.mnuply_next.Size = new System.Drawing.Size(43, 23);
            this.mnuply_next.Text = ">->";
            this.mnuply_next.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // cBPlaylist
            // 
            this.cBPlaylist.Dock = System.Windows.Forms.DockStyle.Top;
            this.cBPlaylist.FormattingEnabled = true;
            this.cBPlaylist.Location = new System.Drawing.Point(0, 0);
            this.cBPlaylist.Name = "cBPlaylist";
            this.cBPlaylist.Size = new System.Drawing.Size(705, 21);
            this.cBPlaylist.TabIndex = 5;
            this.cBPlaylist.SelectedIndexChanged += new System.EventHandler(this.cBPlaylist_SelectedIndexChanged);
            this.cBPlaylist.MouseDown += new System.Windows.Forms.MouseEventHandler(this.combList_RightClick);
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBox1.CausesValidation = false;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(-6, 96);
            this.listBox1.Name = "listBox1";
            this.listBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(705, 160);
            this.listBox1.TabIndex = 6;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            this.listBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.List_RightClick);
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox1_DragDrop);
            this.listBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox1_DragEnter);
            this.listBox1.DragLeave += new System.EventHandler(this.listBox1_DragLeave);
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_itemDblClick);
            this.listBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.List_RightClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // chkLooping
            // 
            this.chkLooping.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkLooping.AutoSize = true;
            this.chkLooping.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.chkLooping.Location = new System.Drawing.Point(433, 21);
            this.chkLooping.Name = "chkLooping";
            this.chkLooping.Size = new System.Drawing.Size(50, 17);
            this.chkLooping.TabIndex = 11;
            this.chkLooping.Text = "Loop";
            this.chkLooping.UseVisualStyleBackColor = false;
            this.chkLooping.CheckedChanged += new System.EventHandler(this.chkLooping_CheckedChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(0, 262);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(699, 23);
            this.progressBar1.TabIndex = 15;
            this.progressBar1.Visible = false;
            // 
            // sel_List
            // 
            this.sel_List.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.löschenToolStripMenuItem,
            this.upToolStripMenuItem,
            this.downToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.sel_List.Name = "boxMenu";
            this.sel_List.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.sel_List.ShowCheckMargin = true;
            this.sel_List.Size = new System.Drawing.Size(130, 114);
            this.sel_List.Text = "Box Menu";
            this.sel_List.UseWaitCursor = true;
            this.sel_List.Opening += new System.ComponentModel.CancelEventHandler(this.sel_List_Opening);
            // 
            // löschenToolStripMenuItem
            // 
            this.löschenToolStripMenuItem.Name = "löschenToolStripMenuItem";
            this.löschenToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.löschenToolStripMenuItem.Text = "Insert";
            this.löschenToolStripMenuItem.Click += new System.EventHandler(this.löschenToolStripMenuItem_Click);
            // 
            // upToolStripMenuItem
            // 
            this.upToolStripMenuItem.Name = "upToolStripMenuItem";
            this.upToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.upToolStripMenuItem.Text = "Up";
            this.upToolStripMenuItem.Click += new System.EventHandler(this.upToolStripMenuItem_Click);
            // 
            // downToolStripMenuItem
            // 
            this.downToolStripMenuItem.Name = "downToolStripMenuItem";
            this.downToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.downToolStripMenuItem.Text = "Down";
            this.downToolStripMenuItem.Click += new System.EventHandler(this.downToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsToolStripMenuItem1});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem1
            // 
            this.saveAsToolStripMenuItem1.Name = "saveAsToolStripMenuItem1";
            this.saveAsToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.saveAsToolStripMenuItem1.Text = "Save as";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.ErrorImage = global::eXCute.Properties.Resources.arielle_backsmaragd;
            this.pictureBox1.Location = new System.Drawing.Point(0, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(705, 404);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // TrackBar1
            // 
            this.TrackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TrackBar1.AutoSize = false;
            this.TrackBar1.Location = new System.Drawing.Point(551, 21);
            this.TrackBar1.Name = "TrackBar1";
            this.TrackBar1.Size = new System.Drawing.Size(148, 20);
            this.TrackBar1.TabIndex = 16;
            this.TrackBar1.Scroll += new System.EventHandler(this.TrackBar1_Scroll);
            // 
            // lblfileName
            // 
            this.lblfileName.AutoSize = true;
            this.lblfileName.Location = new System.Drawing.Point(430, 53);
            this.lblfileName.Name = "lblfileName";
            this.lblfileName.Size = new System.Drawing.Size(23, 13);
            this.lblfileName.TabIndex = 17;
            this.lblfileName.Text = "File";
            this.lblfileName.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.TimerEvent);
            // 
            // WMP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 425);
            this.Controls.Add(this.lblfileName);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.TrackBar1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.chkLooping);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cBPlaylist);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WMP";
            this.Text = "WMP 2.0";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.sel_List.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quickstartToolStripMenuItem;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1 ;
        private System.Windows.Forms.ComboBox cBPlaylist;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem hideListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loopToolStripMenuItem;
        private System.Windows.Forms.CheckBox chkLooping;
        private System.Windows.Forms.ToolStripMenuItem hideWMPToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem playlistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hidePlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuply_open;
        private System.Windows.Forms.ToolStripMenuItem mnuply_prev;
        private System.Windows.Forms.ToolStripMenuItem mnuply_stop;
        private System.Windows.Forms.ToolStripMenuItem mnuply_play;
        private System.Windows.Forms.ToolStripMenuItem mnuply_next;
        private System.Windows.Forms.ToolStripMenuItem clearListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comboBoxToPlaylistToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem clearComboBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox cBPlaylist_tbSaveAs;
        private System.Windows.Forms.ContextMenuStrip sel_List;
        private System.Windows.Forms.ToolStripMenuItem löschenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem upToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem1;
        private System.Windows.Forms.TrackBar TrackBar1;
        private ToolStripMenuItem listBoxToPlaylistToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem2;
        private ToolStripTextBox tT_savelistBox1;
        private Label lblfileName;
        private Timer timer1;
        private ToolStripMenuItem lOADListBoxFromFileToolStripMenuItem;
        private ToolStripMenuItem textfileToolStripMenuItem;
    }
}