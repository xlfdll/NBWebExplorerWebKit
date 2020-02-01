namespace NBWebExplorerWebKit
{
    partial class DownloadsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DownloadsForm));
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.downloadListView = new System.Windows.Forms.ListView();
            this.fileNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.progressColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.downloadedFileContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openInFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadDetailTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.downloadDestinationTextBox = new System.Windows.Forms.TextBox();
            this.downloadSourceLabel = new System.Windows.Forms.Label();
            this.downloadDestinationLabel = new System.Windows.Forms.Label();
            this.downloadProgressLabel = new System.Windows.Forms.Label();
            this.downloadSourceTextBox = new System.Windows.Forms.TextBox();
            this.downloadProgressBar = new System.Windows.Forms.ProgressBar();
            this.downloadToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            this.downloadedFileContextMenuStrip.SuspendLayout();
            this.downloadDetailTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainSplitContainer
            // 
            resources.ApplyResources(this.mainSplitContainer, "mainSplitContainer");
            this.mainSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.downloadListView);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.downloadDetailTableLayoutPanel);
            // 
            // downloadListView
            // 
            this.downloadListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fileNameColumnHeader,
            this.progressColumnHeader});
            this.downloadListView.ContextMenuStrip = this.downloadedFileContextMenuStrip;
            resources.ApplyResources(this.downloadListView, "downloadListView");
            this.downloadListView.FullRowSelect = true;
            this.downloadListView.GridLines = true;
            this.downloadListView.HideSelection = false;
            this.downloadListView.MultiSelect = false;
            this.downloadListView.Name = "downloadListView";
            this.downloadListView.UseCompatibleStateImageBehavior = false;
            this.downloadListView.View = System.Windows.Forms.View.Details;
            this.downloadListView.SelectedIndexChanged += new System.EventHandler(this.downloadListView_SelectedIndexChanged);
            // 
            // fileNameColumnHeader
            // 
            resources.ApplyResources(this.fileNameColumnHeader, "fileNameColumnHeader");
            // 
            // progressColumnHeader
            // 
            resources.ApplyResources(this.progressColumnHeader, "progressColumnHeader");
            // 
            // downloadedFileContextMenuStrip
            // 
            this.downloadedFileContextMenuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.downloadedFileContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.openInFolderToolStripMenuItem,
            this.downloadToolStripSeparator,
            this.cancelToolStripMenuItem});
            this.downloadedFileContextMenuStrip.Name = "downloadedFileContextMenuStrip";
            this.downloadedFileContextMenuStrip.ShowImageMargin = false;
            resources.ApplyResources(this.downloadedFileContextMenuStrip, "downloadedFileContextMenuStrip");
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            resources.ApplyResources(this.openToolStripMenuItem, "openToolStripMenuItem");
            // 
            // openInFolderToolStripMenuItem
            // 
            this.openInFolderToolStripMenuItem.Name = "openInFolderToolStripMenuItem";
            resources.ApplyResources(this.openInFolderToolStripMenuItem, "openInFolderToolStripMenuItem");
            // 
            // downloadDetailTableLayoutPanel
            // 
            resources.ApplyResources(this.downloadDetailTableLayoutPanel, "downloadDetailTableLayoutPanel");
            this.downloadDetailTableLayoutPanel.Controls.Add(this.downloadDestinationTextBox, 1, 1);
            this.downloadDetailTableLayoutPanel.Controls.Add(this.downloadSourceLabel, 0, 0);
            this.downloadDetailTableLayoutPanel.Controls.Add(this.downloadDestinationLabel, 0, 1);
            this.downloadDetailTableLayoutPanel.Controls.Add(this.downloadProgressLabel, 0, 2);
            this.downloadDetailTableLayoutPanel.Controls.Add(this.downloadSourceTextBox, 1, 0);
            this.downloadDetailTableLayoutPanel.Controls.Add(this.downloadProgressBar, 1, 2);
            this.downloadDetailTableLayoutPanel.Name = "downloadDetailTableLayoutPanel";
            // 
            // downloadDestinationTextBox
            // 
            resources.ApplyResources(this.downloadDestinationTextBox, "downloadDestinationTextBox");
            this.downloadDestinationTextBox.Name = "downloadDestinationTextBox";
            this.downloadDestinationTextBox.ReadOnly = true;
            // 
            // downloadSourceLabel
            // 
            resources.ApplyResources(this.downloadSourceLabel, "downloadSourceLabel");
            this.downloadSourceLabel.Name = "downloadSourceLabel";
            // 
            // downloadDestinationLabel
            // 
            resources.ApplyResources(this.downloadDestinationLabel, "downloadDestinationLabel");
            this.downloadDestinationLabel.Name = "downloadDestinationLabel";
            // 
            // downloadProgressLabel
            // 
            resources.ApplyResources(this.downloadProgressLabel, "downloadProgressLabel");
            this.downloadProgressLabel.Name = "downloadProgressLabel";
            // 
            // downloadSourceTextBox
            // 
            resources.ApplyResources(this.downloadSourceTextBox, "downloadSourceTextBox");
            this.downloadSourceTextBox.Name = "downloadSourceTextBox";
            this.downloadSourceTextBox.ReadOnly = true;
            // 
            // downloadProgressBar
            // 
            resources.ApplyResources(this.downloadProgressBar, "downloadProgressBar");
            this.downloadProgressBar.Name = "downloadProgressBar";
            // 
            // downloadToolStripSeparator
            // 
            this.downloadToolStripSeparator.Name = "downloadToolStripSeparator";
            resources.ApplyResources(this.downloadToolStripSeparator, "downloadToolStripSeparator");
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            resources.ApplyResources(this.cancelToolStripMenuItem, "cancelToolStripMenuItem");
            // 
            // DownloadsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainSplitContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DownloadsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            this.mainSplitContainer.ResumeLayout(false);
            this.downloadedFileContextMenuStrip.ResumeLayout(false);
            this.downloadDetailTableLayoutPanel.ResumeLayout(false);
            this.downloadDetailTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.ListView downloadListView;
        private System.Windows.Forms.ColumnHeader fileNameColumnHeader;
        private System.Windows.Forms.ColumnHeader progressColumnHeader;
        private System.Windows.Forms.TableLayoutPanel downloadDetailTableLayoutPanel;
        private System.Windows.Forms.TextBox downloadDestinationTextBox;
        private System.Windows.Forms.Label downloadSourceLabel;
        private System.Windows.Forms.Label downloadDestinationLabel;
        private System.Windows.Forms.Label downloadProgressLabel;
        private System.Windows.Forms.TextBox downloadSourceTextBox;
        private System.Windows.Forms.ProgressBar downloadProgressBar;
        private System.Windows.Forms.ContextMenuStrip downloadedFileContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openInFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator downloadToolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
    }
}