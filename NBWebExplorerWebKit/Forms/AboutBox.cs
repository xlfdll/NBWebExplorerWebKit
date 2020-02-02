﻿using System;
using System.Windows.Forms;

namespace NBWebExplorerWebKit
{
    public partial class AboutBox : Form
    {
        private AboutBox()
        {
            InitializeComponent();
        }

        public AboutBox(WebBrowserTabPage webBrowserTabPage)
            : this()
        {
            _webBrowserTabPage = webBrowserTabPage;
        }

        private void AboutBox_Load(object sender, EventArgs e)
        {
            productVersionLabel.Text = String.Format(productVersionLabel.Text, Application.ProductVersion);
            ieVersionLabel.Text = String.Format(ieVersionLabel.Text, _webBrowserTabPage.Browser.ProductName, _webBrowserTabPage.Browser.ProductVersion);

            nbPictureBox.Image = nbImageList.Images[nbImageIndex];
        }

        private void nbTimer_Tick(object sender, EventArgs e)
        {
            nbImageIndex = (nbImageIndex != nbImageCount) ? nbImageIndex + 1 : 0;

            nbPictureBox.Image = nbImageList.Images[nbImageIndex];
        }

        private void nbPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            nbTimer.Enabled = !nbTimer.Enabled;
        }

        private void nbPictureBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            nbImageCount = (nbImageCount == 3) ? 4 : 3;

            nbImageIndex = 0;
        }

        private WebBrowserTabPage _webBrowserTabPage;

        private Int32 nbImageIndex = 0;
        private Int32 nbImageCount = 3;
    }
}