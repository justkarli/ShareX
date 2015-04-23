﻿namespace XBuilder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainTabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BuildPanel = new XBuilder.Panels.BuildFrame();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.monitorPanel1 = new XBuilder.MonitorPanel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ScannerPanel = new XBuilder.ScannerPanel();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.remotePanel1 = new XBuilder.Panels.RemotePanel();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.aboutPanel1 = new XLibrary.UI.Panels.AboutPanel();
            this.MainTabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabs
            // 
            this.MainTabs.Controls.Add(this.tabPage1);
            this.MainTabs.Controls.Add(this.tabPage2);
            this.MainTabs.Controls.Add(this.tabPage3);
            this.MainTabs.Controls.Add(this.tabPage5);
            this.MainTabs.Controls.Add(this.tabPage4);
            this.MainTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabs.Location = new System.Drawing.Point(0, 0);
            this.MainTabs.Name = "MainTabs";
            this.MainTabs.SelectedIndex = 0;
            this.MainTabs.Size = new System.Drawing.Size(385, 393);
            this.MainTabs.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BuildPanel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(377, 367);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Build";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BuildPanel
            // 
            this.BuildPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BuildPanel.Location = new System.Drawing.Point(3, 3);
            this.BuildPanel.Name = "BuildPanel";
            this.BuildPanel.Size = new System.Drawing.Size(371, 361);
            this.BuildPanel.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.monitorPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(377, 367);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Monitor";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // monitorPanel1
            // 
            this.monitorPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monitorPanel1.Location = new System.Drawing.Point(3, 3);
            this.monitorPanel1.Name = "monitorPanel1";
            this.monitorPanel1.Size = new System.Drawing.Size(371, 361);
            this.monitorPanel1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ScannerPanel);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(377, 367);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Scanner";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ScannerPanel
            // 
            this.ScannerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScannerPanel.Location = new System.Drawing.Point(3, 3);
            this.ScannerPanel.Name = "ScannerPanel";
            this.ScannerPanel.Size = new System.Drawing.Size(371, 361);
            this.ScannerPanel.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.remotePanel1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(377, 367);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Remote";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // remotePanel1
            // 
            this.remotePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.remotePanel1.Location = new System.Drawing.Point(0, 0);
            this.remotePanel1.Name = "remotePanel1";
            this.remotePanel1.Size = new System.Drawing.Size(377, 367);
            this.remotePanel1.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.aboutPanel1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(377, 367);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "About";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // aboutPanel1
            // 
            this.aboutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aboutPanel1.Location = new System.Drawing.Point(3, 3);
            this.aboutPanel1.Name = "aboutPanel1";
            this.aboutPanel1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.aboutPanel1.Size = new System.Drawing.Size(371, 361);
            this.aboutPanel1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(385, 393);
            this.Controls.Add(this.MainTabs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Code Perspective";
            this.MainTabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        public MonitorPanel monitorPanel1;
        public ScannerPanel ScannerPanel;
        public System.Windows.Forms.TabControl MainTabs;
        private System.Windows.Forms.TabPage tabPage4;
        private XLibrary.UI.Panels.AboutPanel aboutPanel1;
        private System.Windows.Forms.TabPage tabPage5;
        private Panels.RemotePanel remotePanel1;
        public Panels.BuildFrame BuildPanel;


    }
}

