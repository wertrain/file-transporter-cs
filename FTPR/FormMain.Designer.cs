namespace FTPR
{
    partial class FormMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.expTree1 = new ExpTreeLib.ExpTree();
            this.listViewFiles = new System.Windows.Forms.ListView();
            this.columnHeaderFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTransferState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTransferProgress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTool = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMainButton = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemTransfer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCancel = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            this.menuStripMainButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 48);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.expTree1);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.listViewFiles);
            this.splitContainerMain.Size = new System.Drawing.Size(800, 402);
            this.splitContainerMain.SplitterDistance = 266;
            this.splitContainerMain.TabIndex = 0;
            // 
            // expTree1
            // 
            this.expTree1.AllowFolderRename = false;
            this.expTree1.Cursor = System.Windows.Forms.Cursors.Default;
            this.expTree1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expTree1.Location = new System.Drawing.Point(0, 0);
            this.expTree1.Name = "expTree1";
            this.expTree1.ShowRootLines = false;
            this.expTree1.Size = new System.Drawing.Size(266, 402);
            this.expTree1.StartUpDirectory = ExpTreeLib.ExpTree.StartDir.Desktop;
            this.expTree1.TabIndex = 0;
            // 
            // listViewFiles
            // 
            this.listViewFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderFileName,
            this.columnHeaderTransferState,
            this.columnHeaderTransferProgress});
            this.listViewFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewFiles.FullRowSelect = true;
            this.listViewFiles.GridLines = true;
            this.listViewFiles.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewFiles.HideSelection = false;
            this.listViewFiles.Location = new System.Drawing.Point(0, 0);
            this.listViewFiles.Name = "listViewFiles";
            this.listViewFiles.Size = new System.Drawing.Size(530, 402);
            this.listViewFiles.TabIndex = 0;
            this.listViewFiles.UseCompatibleStateImageBehavior = false;
            this.listViewFiles.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderFileName
            // 
            this.columnHeaderFileName.Text = "File name";
            this.columnHeaderFileName.Width = 255;
            // 
            // columnHeaderTransferState
            // 
            this.columnHeaderTransferState.Text = "State";
            // 
            // columnHeaderTransferProgress
            // 
            this.columnHeaderTransferProgress.Text = "Progress";
            this.columnHeaderTransferProgress.Width = 75;
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFile,
            this.toolStripMenuItemEdit,
            this.toolStripMenuItemTool,
            this.toolStripMenuItemHelp});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(800, 24);
            this.menuStripMain.TabIndex = 1;
            this.menuStripMain.Text = "menuStripMain";
            // 
            // toolStripMenuItemFile
            // 
            this.toolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFileExit});
            this.toolStripMenuItemFile.Name = "toolStripMenuItemFile";
            this.toolStripMenuItemFile.Size = new System.Drawing.Size(45, 20);
            this.toolStripMenuItemFile.Text = "(&F)ile";
            // 
            // toolStripMenuItemFileExit
            // 
            this.toolStripMenuItemFileExit.Name = "toolStripMenuItemFileExit";
            this.toolStripMenuItemFileExit.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemFileExit.Text = "Exit(&X)";
            this.toolStripMenuItemFileExit.Click += new System.EventHandler(this.toolStripMenuItemFileExit_Click);
            // 
            // toolStripMenuItemEdit
            // 
            this.toolStripMenuItemEdit.Name = "toolStripMenuItemEdit";
            this.toolStripMenuItemEdit.Size = new System.Drawing.Size(47, 20);
            this.toolStripMenuItemEdit.Text = "(&E)dit";
            // 
            // toolStripMenuItemTool
            // 
            this.toolStripMenuItemTool.Name = "toolStripMenuItemTool";
            this.toolStripMenuItemTool.Size = new System.Drawing.Size(50, 20);
            this.toolStripMenuItemTool.Text = "(&T)ool";
            // 
            // toolStripMenuItemHelp
            // 
            this.toolStripMenuItemHelp.Name = "toolStripMenuItemHelp";
            this.toolStripMenuItemHelp.Size = new System.Drawing.Size(52, 20);
            this.toolStripMenuItemHelp.Text = "(&H)elp";
            // 
            // menuStripMainButton
            // 
            this.menuStripMainButton.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStripMainButton.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemTransfer,
            this.toolStripMenuItemCancel});
            this.menuStripMainButton.Location = new System.Drawing.Point(0, 24);
            this.menuStripMainButton.Name = "menuStripMainButton";
            this.menuStripMainButton.Size = new System.Drawing.Size(800, 24);
            this.menuStripMainButton.TabIndex = 2;
            this.menuStripMainButton.Text = "menuStripMainButton";
            // 
            // toolStripMenuItemTransfer
            // 
            this.toolStripMenuItemTransfer.Image = global::FTPR.Properties.Resources.transfer;
            this.toolStripMenuItemTransfer.Name = "toolStripMenuItemTransfer";
            this.toolStripMenuItemTransfer.Size = new System.Drawing.Size(76, 20);
            this.toolStripMenuItemTransfer.Text = "Transfer";
            // 
            // toolStripMenuItemCancel
            // 
            this.toolStripMenuItemCancel.Image = global::FTPR.Properties.Resources.cancel;
            this.toolStripMenuItemCancel.Name = "toolStripMenuItemCancel";
            this.toolStripMenuItemCancel.Size = new System.Drawing.Size(70, 20);
            this.toolStripMenuItemCancel.Text = "Cancel";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.menuStripMainButton);
            this.Controls.Add(this.menuStripMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "FormMain";
            this.Text = "FTPR";
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.menuStripMainButton.ResumeLayout(false);
            this.menuStripMainButton.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.MenuStrip menuStripMainButton;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTransfer;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCancel;
        private ExpTreeLib.ExpTree expTree1;
        private System.Windows.Forms.ListView listViewFiles;
        private System.Windows.Forms.ColumnHeader columnHeaderFileName;
        private System.Windows.Forms.ColumnHeader columnHeaderTransferState;
        private System.Windows.Forms.ColumnHeader columnHeaderTransferProgress;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTool;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFileExit;
    }
}

