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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.splitContainerFilesControl = new System.Windows.Forms.SplitContainer();
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
            this.toolStripMenuItemFileTransfer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCancelTransfer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemUpdateClientList = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainerBase = new System.Windows.Forms.SplitContainer();
            this.listViewClients = new System.Windows.Forms.ListView();
            this.columnHeaderClientName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderClientIP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelConnectionState = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStripMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemTransferFile = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerFilesControl)).BeginInit();
            this.splitContainerFilesControl.Panel1.SuspendLayout();
            this.splitContainerFilesControl.Panel2.SuspendLayout();
            this.splitContainerFilesControl.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            this.menuStripMainButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBase)).BeginInit();
            this.splitContainerBase.Panel1.SuspendLayout();
            this.splitContainerBase.Panel2.SuspendLayout();
            this.splitContainerBase.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.contextMenuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerFilesControl
            // 
            this.splitContainerFilesControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerFilesControl.Location = new System.Drawing.Point(0, 0);
            this.splitContainerFilesControl.Name = "splitContainerFilesControl";
            // 
            // splitContainerFilesControl.Panel1
            // 
            this.splitContainerFilesControl.Panel1.Controls.Add(this.expTree1);
            // 
            // splitContainerFilesControl.Panel2
            // 
            this.splitContainerFilesControl.Panel2.Controls.Add(this.listViewFiles);
            this.splitContainerFilesControl.Size = new System.Drawing.Size(800, 290);
            this.splitContainerFilesControl.SplitterDistance = 266;
            this.splitContainerFilesControl.TabIndex = 0;
            // 
            // expTree1
            // 
            this.expTree1.AllowFolderRename = false;
            this.expTree1.ContextMenuStrip = this.contextMenuStripMain;
            this.expTree1.Cursor = System.Windows.Forms.Cursors.Default;
            this.expTree1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expTree1.Location = new System.Drawing.Point(0, 0);
            this.expTree1.Name = "expTree1";
            this.expTree1.ShowRootLines = true;
            this.expTree1.Size = new System.Drawing.Size(266, 290);
            this.expTree1.StartUpDirectory = ExpTreeLib.ExpTree.StartDir.Desktop;
            this.expTree1.TabIndex = 0;
            this.expTree1.UseWindowsContextMenu = false;
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
            this.listViewFiles.Size = new System.Drawing.Size(530, 290);
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
            this.toolStripMenuItemFileExit.Size = new System.Drawing.Size(108, 22);
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
            this.toolStripMenuItemFileTransfer,
            this.toolStripMenuItemCancelTransfer,
            this.toolStripMenuItemUpdateClientList});
            this.menuStripMainButton.Location = new System.Drawing.Point(0, 24);
            this.menuStripMainButton.Name = "menuStripMainButton";
            this.menuStripMainButton.Size = new System.Drawing.Size(800, 24);
            this.menuStripMainButton.TabIndex = 2;
            this.menuStripMainButton.Text = "menuStripMainButton";
            // 
            // toolStripMenuItemFileTransfer
            // 
            this.toolStripMenuItemFileTransfer.Image = global::FTPR.Properties.Resources.transfer;
            this.toolStripMenuItemFileTransfer.Name = "toolStripMenuItemFileTransfer";
            this.toolStripMenuItemFileTransfer.Size = new System.Drawing.Size(76, 20);
            this.toolStripMenuItemFileTransfer.Text = "Transfer";
            // 
            // toolStripMenuItemCancelTransfer
            // 
            this.toolStripMenuItemCancelTransfer.Image = global::FTPR.Properties.Resources.cancel;
            this.toolStripMenuItemCancelTransfer.Name = "toolStripMenuItemCancelTransfer";
            this.toolStripMenuItemCancelTransfer.Size = new System.Drawing.Size(70, 20);
            this.toolStripMenuItemCancelTransfer.Text = "Cancel";
            // 
            // toolStripMenuItemUpdateClientList
            // 
            this.toolStripMenuItemUpdateClientList.Image = global::FTPR.Properties.Resources.refresh;
            this.toolStripMenuItemUpdateClientList.Name = "toolStripMenuItemUpdateClientList";
            this.toolStripMenuItemUpdateClientList.Size = new System.Drawing.Size(127, 20);
            this.toolStripMenuItemUpdateClientList.Text = "Update Client List";
            this.toolStripMenuItemUpdateClientList.Click += new System.EventHandler(this.toolStripMenuItemUpdateClientList_Click);
            // 
            // splitContainerBase
            // 
            this.splitContainerBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerBase.Location = new System.Drawing.Point(0, 48);
            this.splitContainerBase.Name = "splitContainerBase";
            this.splitContainerBase.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerBase.Panel1
            // 
            this.splitContainerBase.Panel1.Controls.Add(this.listViewClients);
            // 
            // splitContainerBase.Panel2
            // 
            this.splitContainerBase.Panel2.Controls.Add(this.splitContainerFilesControl);
            this.splitContainerBase.Size = new System.Drawing.Size(800, 380);
            this.splitContainerBase.SplitterDistance = 86;
            this.splitContainerBase.TabIndex = 3;
            // 
            // listViewClients
            // 
            this.listViewClients.CheckBoxes = true;
            this.listViewClients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderClientName,
            this.columnHeaderClientIP});
            this.listViewClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewClients.FullRowSelect = true;
            this.listViewClients.GridLines = true;
            this.listViewClients.HideSelection = false;
            this.listViewClients.Location = new System.Drawing.Point(0, 0);
            this.listViewClients.Name = "listViewClients";
            this.listViewClients.Size = new System.Drawing.Size(800, 86);
            this.listViewClients.TabIndex = 0;
            this.listViewClients.UseCompatibleStateImageBehavior = false;
            this.listViewClients.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderClientName
            // 
            this.columnHeaderClientName.Text = "Client name";
            this.columnHeaderClientName.Width = 120;
            // 
            // columnHeaderClientIP
            // 
            this.columnHeaderClientIP.Text = "IP";
            this.columnHeaderClientIP.Width = 114;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelConnectionState});
            this.statusStrip.Location = new System.Drawing.Point(0, 428);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(800, 22);
            this.statusStrip.TabIndex = 4;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabelConnectionState
            // 
            this.toolStripStatusLabelConnectionState.Name = "toolStripStatusLabelConnectionState";
            this.toolStripStatusLabelConnectionState.Size = new System.Drawing.Size(43, 17);
            this.toolStripStatusLabelConnectionState.Text = "未接続";
            // 
            // contextMenuStripMain
            // 
            this.contextMenuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemTransferFile});
            this.contextMenuStripMain.Name = "contextMenuStripMain";
            this.contextMenuStripMain.Size = new System.Drawing.Size(130, 26);
            // 
            // toolStripMenuItemTransferFile
            // 
            this.toolStripMenuItemTransferFile.Name = "toolStripMenuItemTransferFile";
            this.toolStripMenuItemTransferFile.Size = new System.Drawing.Size(129, 22);
            this.toolStripMenuItemTransferFile.Text = "Transfer(&T)";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainerBase);
            this.Controls.Add(this.menuStripMainButton);
            this.Controls.Add(this.menuStripMain);
            this.Controls.Add(this.statusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "FormMain";
            this.Text = "FTPR";
            this.splitContainerFilesControl.Panel1.ResumeLayout(false);
            this.splitContainerFilesControl.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerFilesControl)).EndInit();
            this.splitContainerFilesControl.ResumeLayout(false);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.menuStripMainButton.ResumeLayout(false);
            this.menuStripMainButton.PerformLayout();
            this.splitContainerBase.Panel1.ResumeLayout(false);
            this.splitContainerBase.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBase)).EndInit();
            this.splitContainerBase.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.contextMenuStripMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerFilesControl;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.MenuStrip menuStripMainButton;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFileTransfer;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCancelTransfer;
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
        private System.Windows.Forms.SplitContainer splitContainerBase;
        private System.Windows.Forms.ListView listViewClients;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemUpdateClientList;
        private System.Windows.Forms.ColumnHeader columnHeaderClientName;
        private System.Windows.Forms.ColumnHeader columnHeaderClientIP;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelConnectionState;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTransferFile;
    }
}

