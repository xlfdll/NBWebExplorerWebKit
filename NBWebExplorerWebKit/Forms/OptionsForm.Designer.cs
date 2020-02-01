namespace NBWebExplorerWebKit
{
    partial class OptionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsForm));
            this.homePageGroupBox = new System.Windows.Forms.GroupBox();
            this.homePageTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.homePageTextBox = new System.Windows.Forms.TextBox();
            this.homePageFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.useBlankPageButton = new System.Windows.Forms.Button();
            this.useCurrentPageButton = new System.Windows.Forms.Button();
            this.sourceViewerGroupBox = new System.Windows.Forms.GroupBox();
            this.sourceViewerTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.sourceViewerTextBox = new System.Windows.Forms.TextBox();
            this.sourceViewerBrowseButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.controlFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.homePageGroupBox.SuspendLayout();
            this.homePageTableLayoutPanel.SuspendLayout();
            this.homePageFlowLayoutPanel.SuspendLayout();
            this.sourceViewerGroupBox.SuspendLayout();
            this.sourceViewerTableLayoutPanel.SuspendLayout();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            this.controlFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // homePageGroupBox
            // 
            resources.ApplyResources(this.homePageGroupBox, "homePageGroupBox");
            this.homePageGroupBox.Controls.Add(this.homePageTableLayoutPanel);
            this.homePageGroupBox.Name = "homePageGroupBox";
            this.homePageGroupBox.TabStop = false;
            // 
            // homePageTableLayoutPanel
            // 
            resources.ApplyResources(this.homePageTableLayoutPanel, "homePageTableLayoutPanel");
            this.homePageTableLayoutPanel.Controls.Add(this.homePageTextBox, 0, 0);
            this.homePageTableLayoutPanel.Controls.Add(this.homePageFlowLayoutPanel, 0, 1);
            this.homePageTableLayoutPanel.Name = "homePageTableLayoutPanel";
            // 
            // homePageTextBox
            // 
            resources.ApplyResources(this.homePageTextBox, "homePageTextBox");
            this.homePageTextBox.Name = "homePageTextBox";
            // 
            // homePageFlowLayoutPanel
            // 
            this.homePageFlowLayoutPanel.Controls.Add(this.useBlankPageButton);
            this.homePageFlowLayoutPanel.Controls.Add(this.useCurrentPageButton);
            resources.ApplyResources(this.homePageFlowLayoutPanel, "homePageFlowLayoutPanel");
            this.homePageFlowLayoutPanel.Name = "homePageFlowLayoutPanel";
            // 
            // useBlankPageButton
            // 
            resources.ApplyResources(this.useBlankPageButton, "useBlankPageButton");
            this.useBlankPageButton.Name = "useBlankPageButton";
            this.useBlankPageButton.UseVisualStyleBackColor = true;
            this.useBlankPageButton.Click += new System.EventHandler(this.useBlankPageButton_Click);
            // 
            // useCurrentPageButton
            // 
            resources.ApplyResources(this.useCurrentPageButton, "useCurrentPageButton");
            this.useCurrentPageButton.Name = "useCurrentPageButton";
            this.useCurrentPageButton.UseVisualStyleBackColor = true;
            this.useCurrentPageButton.Click += new System.EventHandler(this.useCurrentPageButton_Click);
            // 
            // sourceViewerGroupBox
            // 
            resources.ApplyResources(this.sourceViewerGroupBox, "sourceViewerGroupBox");
            this.sourceViewerGroupBox.Controls.Add(this.sourceViewerTableLayoutPanel);
            this.sourceViewerGroupBox.Name = "sourceViewerGroupBox";
            this.sourceViewerGroupBox.TabStop = false;
            // 
            // sourceViewerTableLayoutPanel
            // 
            resources.ApplyResources(this.sourceViewerTableLayoutPanel, "sourceViewerTableLayoutPanel");
            this.sourceViewerTableLayoutPanel.Controls.Add(this.sourceViewerTextBox, 0, 0);
            this.sourceViewerTableLayoutPanel.Controls.Add(this.sourceViewerBrowseButton, 0, 1);
            this.sourceViewerTableLayoutPanel.Name = "sourceViewerTableLayoutPanel";
            // 
            // sourceViewerTextBox
            // 
            resources.ApplyResources(this.sourceViewerTextBox, "sourceViewerTextBox");
            this.sourceViewerTextBox.Name = "sourceViewerTextBox";
            this.sourceViewerTextBox.ReadOnly = true;
            // 
            // sourceViewerBrowseButton
            // 
            resources.ApplyResources(this.sourceViewerBrowseButton, "sourceViewerBrowseButton");
            this.sourceViewerBrowseButton.Name = "sourceViewerBrowseButton";
            this.sourceViewerBrowseButton.UseVisualStyleBackColor = true;
            this.sourceViewerBrowseButton.Click += new System.EventHandler(this.sourceViewerBrowseButton_Click);
            // 
            // cancelButton
            // 
            resources.ApplyResources(this.cancelButton, "cancelButton");
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            resources.ApplyResources(this.okButton, "okButton");
            this.okButton.Name = "okButton";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // mainSplitContainer
            // 
            resources.ApplyResources(this.mainSplitContainer, "mainSplitContainer");
            this.mainSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.homePageGroupBox);
            this.mainSplitContainer.Panel1.Controls.Add(this.sourceViewerGroupBox);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.controlFlowLayoutPanel);
            // 
            // controlFlowLayoutPanel
            // 
            this.controlFlowLayoutPanel.Controls.Add(this.cancelButton);
            this.controlFlowLayoutPanel.Controls.Add(this.okButton);
            resources.ApplyResources(this.controlFlowLayoutPanel, "controlFlowLayoutPanel");
            this.controlFlowLayoutPanel.Name = "controlFlowLayoutPanel";
            // 
            // OptionsForm
            // 
            this.AcceptButton = this.okButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.Controls.Add(this.mainSplitContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.OptionForm_Load);
            this.homePageGroupBox.ResumeLayout(false);
            this.homePageTableLayoutPanel.ResumeLayout(false);
            this.homePageTableLayoutPanel.PerformLayout();
            this.homePageFlowLayoutPanel.ResumeLayout(false);
            this.homePageFlowLayoutPanel.PerformLayout();
            this.sourceViewerGroupBox.ResumeLayout(false);
            this.sourceViewerTableLayoutPanel.ResumeLayout(false);
            this.sourceViewerTableLayoutPanel.PerformLayout();
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            this.mainSplitContainer.ResumeLayout(false);
            this.controlFlowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox homePageGroupBox;
        private System.Windows.Forms.GroupBox sourceViewerGroupBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.FlowLayoutPanel controlFlowLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel homePageTableLayoutPanel;
        private System.Windows.Forms.TextBox homePageTextBox;
        private System.Windows.Forms.FlowLayoutPanel homePageFlowLayoutPanel;
        private System.Windows.Forms.Button useBlankPageButton;
        private System.Windows.Forms.Button useCurrentPageButton;
        private System.Windows.Forms.TableLayoutPanel sourceViewerTableLayoutPanel;
        private System.Windows.Forms.TextBox sourceViewerTextBox;
        private System.Windows.Forms.Button sourceViewerBrowseButton;
    }
}