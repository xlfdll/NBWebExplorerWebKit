namespace NBWebExplorerWebKit
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.historyListToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.navigateToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.controlToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.urlToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.urlToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.mainToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.tabControlContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeTabsOnTheLeftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeTabsOnTheRightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeOtherTabsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeTabsToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.refreshAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.repeatTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTabPage = new System.Windows.Forms.TabPage();
            this.errorToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.forwardToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.refreshToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.homeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.favoritesToolStripSpiltButton = new System.Windows.Forms.ToolStripSplitButton();
            this.addToFavoritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organizeFavoritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organizeFavoritesToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.pageSwitchToolStripSpiltButton = new System.Windows.Forms.ToolStripSplitButton();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openInNewTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pageToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processPageToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pageSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPageToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.viewSourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.downloadsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadsToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainToolStrip.SuspendLayout();
            this.mainStatusStrip.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.tabControlContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.AllowDrop = true;
            this.mainToolStrip.CanOverflow = false;
            this.mainToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.mainToolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripButton,
            this.forwardToolStripButton,
            this.historyListToolStripDropDownButton,
            this.navigateToolStripSeparator,
            this.refreshToolStripButton,
            this.homeToolStripButton,
            this.controlToolStripSeparator,
            this.favoritesToolStripSpiltButton,
            this.urlToolStripComboBox,
            this.pageSwitchToolStripSpiltButton,
            this.urlToolStripSeparator,
            this.pageToolStripDropDownButton,
            this.toolsToolStripDropDownButton});
            resources.ApplyResources(this.mainToolStrip, "mainToolStrip");
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mainToolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mainToolStrip_ItemClicked);
            this.mainToolStrip.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.mainToolStrip.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            // 
            // historyListToolStripDropDownButton
            // 
            this.historyListToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.historyListToolStripDropDownButton, "historyListToolStripDropDownButton");
            this.historyListToolStripDropDownButton.Name = "historyListToolStripDropDownButton";
            this.historyListToolStripDropDownButton.DropDownOpening += new System.EventHandler(this.historyListToolStripDropDownButton_DropDownOpening);
            this.historyListToolStripDropDownButton.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.historyListToolStripDropDownButton_DropDownItemClicked);
            // 
            // navigateToolStripSeparator
            // 
            this.navigateToolStripSeparator.Name = "navigateToolStripSeparator";
            resources.ApplyResources(this.navigateToolStripSeparator, "navigateToolStripSeparator");
            // 
            // controlToolStripSeparator
            // 
            this.controlToolStripSeparator.Name = "controlToolStripSeparator";
            resources.ApplyResources(this.controlToolStripSeparator, "controlToolStripSeparator");
            // 
            // urlToolStripComboBox
            // 
            this.urlToolStripComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            resources.ApplyResources(this.urlToolStripComboBox, "urlToolStripComboBox");
            this.urlToolStripComboBox.Name = "urlToolStripComboBox";
            this.urlToolStripComboBox.DropDown += new System.EventHandler(this.urlToolStripComboBox_DropDown);
            this.urlToolStripComboBox.Enter += new System.EventHandler(this.urlToolStripComboBox_Enter);
            this.urlToolStripComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.urlToolStripComboBox_KeyPress);
            this.urlToolStripComboBox.TextChanged += new System.EventHandler(this.urlToolStripComboBox_TextChanged);
            // 
            // urlToolStripSeparator
            // 
            this.urlToolStripSeparator.Name = "urlToolStripSeparator";
            resources.ApplyResources(this.urlToolStripSeparator, "urlToolStripSeparator");
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripStatusLabel});
            resources.ApplyResources(this.mainStatusStrip, "mainStatusStrip");
            this.mainStatusStrip.Name = "mainStatusStrip";
            // 
            // mainToolStripStatusLabel
            // 
            this.mainToolStripStatusLabel.Name = "mainToolStripStatusLabel";
            resources.ApplyResources(this.mainToolStripStatusLabel, "mainToolStripStatusLabel");
            this.mainToolStripStatusLabel.Spring = true;
            // 
            // mainTabControl
            // 
            this.mainTabControl.ContextMenuStrip = this.tabControlContextMenuStrip;
            this.mainTabControl.Controls.Add(this.newTabPage);
            resources.ApplyResources(this.mainTabControl, "mainTabControl");
            this.mainTabControl.HotTrack = true;
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.SelectedIndexChanged += new System.EventHandler(this.mainTabControl_SelectedIndexChanged);
            this.mainTabControl.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.mainTabControl_Selecting);
            this.mainTabControl.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.mainTabControl_MouseDoubleClick);
            // 
            // tabControlContextMenuStrip
            // 
            this.tabControlContextMenuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tabControlContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.closeTabsOnTheLeftToolStripMenuItem,
            this.closeTabsOnTheRightToolStripMenuItem,
            this.closeOtherTabsToolStripMenuItem,
            this.closeTabsToolStripSeparator,
            this.refreshToolStripMenuItem,
            this.refreshAllToolStripMenuItem,
            this.refreshToolStripSeparator,
            this.newTabToolStripMenuItem,
            this.repeatTabToolStripMenuItem});
            this.tabControlContextMenuStrip.Name = "tabControlContextMenuStrip";
            resources.ApplyResources(this.tabControlContextMenuStrip, "tabControlContextMenuStrip");
            this.tabControlContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.tabControlContextMenuStrip_Opening);
            this.tabControlContextMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tabControlContextMenuStrip_ItemClicked);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            resources.ApplyResources(this.closeToolStripMenuItem, "closeToolStripMenuItem");
            // 
            // closeTabsOnTheLeftToolStripMenuItem
            // 
            this.closeTabsOnTheLeftToolStripMenuItem.Name = "closeTabsOnTheLeftToolStripMenuItem";
            resources.ApplyResources(this.closeTabsOnTheLeftToolStripMenuItem, "closeTabsOnTheLeftToolStripMenuItem");
            // 
            // closeTabsOnTheRightToolStripMenuItem
            // 
            this.closeTabsOnTheRightToolStripMenuItem.Name = "closeTabsOnTheRightToolStripMenuItem";
            resources.ApplyResources(this.closeTabsOnTheRightToolStripMenuItem, "closeTabsOnTheRightToolStripMenuItem");
            // 
            // closeOtherTabsToolStripMenuItem
            // 
            this.closeOtherTabsToolStripMenuItem.Name = "closeOtherTabsToolStripMenuItem";
            resources.ApplyResources(this.closeOtherTabsToolStripMenuItem, "closeOtherTabsToolStripMenuItem");
            // 
            // closeTabsToolStripSeparator
            // 
            this.closeTabsToolStripSeparator.Name = "closeTabsToolStripSeparator";
            resources.ApplyResources(this.closeTabsToolStripSeparator, "closeTabsToolStripSeparator");
            // 
            // refreshAllToolStripMenuItem
            // 
            this.refreshAllToolStripMenuItem.Name = "refreshAllToolStripMenuItem";
            resources.ApplyResources(this.refreshAllToolStripMenuItem, "refreshAllToolStripMenuItem");
            // 
            // refreshToolStripSeparator
            // 
            this.refreshToolStripSeparator.Name = "refreshToolStripSeparator";
            resources.ApplyResources(this.refreshToolStripSeparator, "refreshToolStripSeparator");
            // 
            // repeatTabToolStripMenuItem
            // 
            this.repeatTabToolStripMenuItem.Name = "repeatTabToolStripMenuItem";
            resources.ApplyResources(this.repeatTabToolStripMenuItem, "repeatTabToolStripMenuItem");
            // 
            // newTabPage
            // 
            resources.ApplyResources(this.newTabPage, "newTabPage");
            this.newTabPage.Name = "newTabPage";
            this.newTabPage.UseVisualStyleBackColor = true;
            // 
            // errorToolTip
            // 
            this.errorToolTip.IsBalloon = true;
            this.errorToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            this.errorToolTip.ToolTipTitle = "Current page contains errors";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Image = global::NBWebExplorerWebKit.Properties.Resources.Refresh_Small;
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            resources.ApplyResources(this.refreshToolStripMenuItem, "refreshToolStripMenuItem");
            // 
            // newTabToolStripMenuItem
            // 
            this.newTabToolStripMenuItem.Image = global::NBWebExplorerWebKit.Properties.Resources.New_Small;
            this.newTabToolStripMenuItem.Name = "newTabToolStripMenuItem";
            resources.ApplyResources(this.newTabToolStripMenuItem, "newTabToolStripMenuItem");
            // 
            // backToolStripButton
            // 
            this.backToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.backToolStripButton, "backToolStripButton");
            this.backToolStripButton.Image = global::NBWebExplorerWebKit.Properties.Resources.Back;
            this.backToolStripButton.Name = "backToolStripButton";
            this.backToolStripButton.Tag = "Back to {0}";
            // 
            // forwardToolStripButton
            // 
            this.forwardToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.forwardToolStripButton, "forwardToolStripButton");
            this.forwardToolStripButton.Image = global::NBWebExplorerWebKit.Properties.Resources.Forward;
            this.forwardToolStripButton.Name = "forwardToolStripButton";
            this.forwardToolStripButton.Tag = "Forward to {0}";
            // 
            // refreshToolStripButton
            // 
            this.refreshToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.refreshToolStripButton.Image = global::NBWebExplorerWebKit.Properties.Resources.Refresh;
            resources.ApplyResources(this.refreshToolStripButton, "refreshToolStripButton");
            this.refreshToolStripButton.Name = "refreshToolStripButton";
            // 
            // homeToolStripButton
            // 
            this.homeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.homeToolStripButton.Image = global::NBWebExplorerWebKit.Properties.Resources.Home;
            resources.ApplyResources(this.homeToolStripButton, "homeToolStripButton");
            this.homeToolStripButton.Name = "homeToolStripButton";
            // 
            // favoritesToolStripSpiltButton
            // 
            this.favoritesToolStripSpiltButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.favoritesToolStripSpiltButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToFavoritesToolStripMenuItem,
            this.organizeFavoritesToolStripMenuItem,
            this.organizeFavoritesToolStripSeparator});
            this.favoritesToolStripSpiltButton.Image = global::NBWebExplorerWebKit.Properties.Resources.Favorites;
            resources.ApplyResources(this.favoritesToolStripSpiltButton, "favoritesToolStripSpiltButton");
            this.favoritesToolStripSpiltButton.Name = "favoritesToolStripSpiltButton";
            this.favoritesToolStripSpiltButton.ButtonClick += new System.EventHandler(this.mainToolStrip_ButtonClick);
            this.favoritesToolStripSpiltButton.DropDownOpening += new System.EventHandler(this.favoritesToolStripSpiltButton_DropDownOpening);
            this.favoritesToolStripSpiltButton.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.favoritesToolStripSpiltButton_DropDownItemClicked);
            // 
            // addToFavoritesToolStripMenuItem
            // 
            this.addToFavoritesToolStripMenuItem.Image = global::NBWebExplorerWebKit.Properties.Resources.Favorites_Small;
            resources.ApplyResources(this.addToFavoritesToolStripMenuItem, "addToFavoritesToolStripMenuItem");
            this.addToFavoritesToolStripMenuItem.Name = "addToFavoritesToolStripMenuItem";
            // 
            // organizeFavoritesToolStripMenuItem
            // 
            resources.ApplyResources(this.organizeFavoritesToolStripMenuItem, "organizeFavoritesToolStripMenuItem");
            this.organizeFavoritesToolStripMenuItem.Name = "organizeFavoritesToolStripMenuItem";
            // 
            // organizeFavoritesToolStripSeparator
            // 
            this.organizeFavoritesToolStripSeparator.Name = "organizeFavoritesToolStripSeparator";
            resources.ApplyResources(this.organizeFavoritesToolStripSeparator, "organizeFavoritesToolStripSeparator");
            // 
            // pageSwitchToolStripSpiltButton
            // 
            this.pageSwitchToolStripSpiltButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pageSwitchToolStripSpiltButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.openInNewTabToolStripMenuItem,
            this.searchToolStripSeparator,
            this.stopToolStripMenuItem});
            this.pageSwitchToolStripSpiltButton.Image = global::NBWebExplorerWebKit.Properties.Resources.Forward;
            resources.ApplyResources(this.pageSwitchToolStripSpiltButton, "pageSwitchToolStripSpiltButton");
            this.pageSwitchToolStripSpiltButton.Name = "pageSwitchToolStripSpiltButton";
            this.pageSwitchToolStripSpiltButton.Tag = "";
            this.pageSwitchToolStripSpiltButton.ButtonClick += new System.EventHandler(this.mainToolStrip_ButtonClick);
            this.pageSwitchToolStripSpiltButton.DropDownOpening += new System.EventHandler(this.pageSwitchToolStripSpiltButton_DropDownOpening);
            this.pageSwitchToolStripSpiltButton.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.pageSwitchToolStripSpiltButton_DropDownItemClicked);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::NBWebExplorerWebKit.Properties.Resources.Forward_Small;
            resources.ApplyResources(this.openToolStripMenuItem, "openToolStripMenuItem");
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Tag = "Go to {0}";
            // 
            // openInNewTabToolStripMenuItem
            // 
            resources.ApplyResources(this.openInNewTabToolStripMenuItem, "openInNewTabToolStripMenuItem");
            this.openInNewTabToolStripMenuItem.Name = "openInNewTabToolStripMenuItem";
            // 
            // searchToolStripSeparator
            // 
            this.searchToolStripSeparator.Name = "searchToolStripSeparator";
            resources.ApplyResources(this.searchToolStripSeparator, "searchToolStripSeparator");
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Image = global::NBWebExplorerWebKit.Properties.Resources.Stop_Small;
            resources.ApplyResources(this.stopToolStripMenuItem, "stopToolStripMenuItem");
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            // 
            // pageToolStripDropDownButton
            // 
            this.pageToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pageToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsToolStripMenuItem,
            this.processPageToolStripSeparator,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.pageSetupToolStripMenuItem,
            this.printPageToolStripSeparator,
            this.viewSourceToolStripMenuItem});
            this.pageToolStripDropDownButton.Image = global::NBWebExplorerWebKit.Properties.Resources.Page;
            resources.ApplyResources(this.pageToolStripDropDownButton, "pageToolStripDropDownButton");
            this.pageToolStripDropDownButton.Name = "pageToolStripDropDownButton";
            this.pageToolStripDropDownButton.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.pageToolStripDropDownButton_DropDownItemClicked);
            // 
            // saveAsToolStripMenuItem
            // 
            resources.ApplyResources(this.saveAsToolStripMenuItem, "saveAsToolStripMenuItem");
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            // 
            // processPageToolStripSeparator
            // 
            this.processPageToolStripSeparator.Name = "processPageToolStripSeparator";
            resources.ApplyResources(this.processPageToolStripSeparator, "processPageToolStripSeparator");
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = global::NBWebExplorerWebKit.Properties.Resources.Print_Small;
            resources.ApplyResources(this.printToolStripMenuItem, "printToolStripMenuItem");
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            // 
            // printPreviewToolStripMenuItem
            // 
            resources.ApplyResources(this.printPreviewToolStripMenuItem, "printPreviewToolStripMenuItem");
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            // 
            // pageSetupToolStripMenuItem
            // 
            resources.ApplyResources(this.pageSetupToolStripMenuItem, "pageSetupToolStripMenuItem");
            this.pageSetupToolStripMenuItem.Name = "pageSetupToolStripMenuItem";
            // 
            // printPageToolStripSeparator
            // 
            this.printPageToolStripSeparator.Name = "printPageToolStripSeparator";
            resources.ApplyResources(this.printPageToolStripSeparator, "printPageToolStripSeparator");
            // 
            // viewSourceToolStripMenuItem
            // 
            this.viewSourceToolStripMenuItem.Image = global::NBWebExplorerWebKit.Properties.Resources.Source_Small;
            resources.ApplyResources(this.viewSourceToolStripMenuItem, "viewSourceToolStripMenuItem");
            this.viewSourceToolStripMenuItem.Name = "viewSourceToolStripMenuItem";
            // 
            // toolsToolStripDropDownButton
            // 
            this.toolsToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolsToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.downloadsToolStripMenuItem,
            this.downloadsToolStripSeparator,
            this.optionsToolStripMenuItem,
            this.optionsToolStripSeparator,
            this.aboutToolStripMenuItem});
            this.toolsToolStripDropDownButton.Image = global::NBWebExplorerWebKit.Properties.Resources.Tools;
            resources.ApplyResources(this.toolsToolStripDropDownButton, "toolsToolStripDropDownButton");
            this.toolsToolStripDropDownButton.Name = "toolsToolStripDropDownButton";
            this.toolsToolStripDropDownButton.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolsToolStripDropDownButton_DropDownItemClicked);
            // 
            // downloadsToolStripMenuItem
            // 
            this.downloadsToolStripMenuItem.Image = global::NBWebExplorerWebKit.Properties.Resources.Download;
            resources.ApplyResources(this.downloadsToolStripMenuItem, "downloadsToolStripMenuItem");
            this.downloadsToolStripMenuItem.Name = "downloadsToolStripMenuItem";
            // 
            // downloadsToolStripSeparator
            // 
            this.downloadsToolStripSeparator.Name = "downloadsToolStripSeparator";
            resources.ApplyResources(this.downloadsToolStripSeparator, "downloadsToolStripSeparator");
            // 
            // optionsToolStripMenuItem
            // 
            resources.ApplyResources(this.optionsToolStripMenuItem, "optionsToolStripMenuItem");
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            // 
            // optionsToolStripSeparator
            // 
            this.optionsToolStripSeparator.Name = "optionsToolStripSeparator";
            resources.ApplyResources(this.optionsToolStripSeparator, "optionsToolStripSeparator");
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::NBWebExplorerWebKit.Properties.Resources.About_Small;
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.mainStatusStrip);
            this.Controls.Add(this.mainToolStrip);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.DoubleClick += new System.EventHandler(this.MainForm_DoubleClick);
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.mainStatusStrip.ResumeLayout(false);
            this.mainStatusStrip.PerformLayout();
            this.mainTabControl.ResumeLayout(false);
            this.tabControlContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip mainToolStrip;
        private System.Windows.Forms.ToolStripButton backToolStripButton;
        private System.Windows.Forms.ToolStripSeparator navigateToolStripSeparator;
        private System.Windows.Forms.ToolStripButton refreshToolStripButton;
        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.ToolStripButton homeToolStripButton;
        private System.Windows.Forms.ToolStripDropDownButton pageToolStripDropDownButton;
        private System.Windows.Forms.ToolStripDropDownButton toolsToolStripDropDownButton;
        private System.Windows.Forms.ToolStripStatusLabel mainToolStripStatusLabel;
        private System.Windows.Forms.ToolStripComboBox urlToolStripComboBox;
        private System.Windows.Forms.ToolStripSeparator urlToolStripSeparator;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.ToolStripSplitButton pageSwitchToolStripSpiltButton;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openInNewTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator controlToolStripSeparator;
        private System.Windows.Forms.TabPage newTabPage;
        private System.Windows.Forms.ContextMenuStrip tabControlContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeOtherTabsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeTabsOnTheLeftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeTabsOnTheRightToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator closeTabsToolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator refreshToolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem newTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repeatTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton favoritesToolStripSpiltButton;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewSourceToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator processPageToolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pageSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator printPageToolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator optionsToolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem organizeFavoritesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator organizeFavoritesToolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton forwardToolStripButton;
        private System.Windows.Forms.ToolStripDropDownButton historyListToolStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem addToFavoritesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator searchToolStripSeparator;
        private System.Windows.Forms.ToolTip errorToolTip;
        private System.Windows.Forms.ToolStripSeparator downloadsToolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem downloadsToolStripMenuItem;
    }
}