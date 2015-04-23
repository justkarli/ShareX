﻿namespace XLibrary.UI.Panels
{
    partial class NamespacePanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SubnodesView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NavButtons = new XLibrary.UI.DetailsNav();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SummaryLabel = new System.Windows.Forms.Label();
            this.DetailsLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SubnodesView
            // 
            this.SubnodesView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SubnodesView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.SubnodesView.FullRowSelect = true;
            this.SubnodesView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.SubnodesView.HideSelection = false;
            this.SubnodesView.Location = new System.Drawing.Point(3, 30);
            this.SubnodesView.MultiSelect = false;
            this.SubnodesView.Name = "SubnodesView";
            this.SubnodesView.Size = new System.Drawing.Size(527, 234);
            this.SubnodesView.TabIndex = 29;
            this.SubnodesView.UseCompatibleStateImageBehavior = false;
            this.SubnodesView.View = System.Windows.Forms.View.Details;
            this.SubnodesView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.SubnodesView_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Child";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Type";
            this.columnHeader2.Width = 82;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Time";
            this.columnHeader3.Width = 174;
            // 
            // NavButtons
            // 
            this.NavButtons.Location = new System.Drawing.Point(4, 8);
            this.NavButtons.Name = "NavButtons";
            this.NavButtons.Size = new System.Drawing.Size(56, 16);
            this.NavButtons.TabIndex = 30;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.SummaryLabel);
            this.flowLayoutPanel1.Controls.Add(this.DetailsLabel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(66, 8);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(464, 16);
            this.flowLayoutPanel1.TabIndex = 31;
            // 
            // SummaryLabel
            // 
            this.SummaryLabel.AutoSize = true;
            this.SummaryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SummaryLabel.Location = new System.Drawing.Point(3, 0);
            this.SummaryLabel.Name = "SummaryLabel";
            this.SummaryLabel.Size = new System.Drawing.Size(73, 13);
            this.SummaryLabel.TabIndex = 11;
            this.SummaryLabel.Text = "Namespace";
            // 
            // DetailsLabel
            // 
            this.DetailsLabel.AutoSize = true;
            this.DetailsLabel.Location = new System.Drawing.Point(82, 0);
            this.DetailsLabel.Name = "DetailsLabel";
            this.DetailsLabel.Size = new System.Drawing.Size(37, 13);
            this.DetailsLabel.TabIndex = 12;
            this.DetailsLabel.Text = "details";
            // 
            // NamespacePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.NavButtons);
            this.Controls.Add(this.SubnodesView);
            this.Name = "NamespacePanel";
            this.Size = new System.Drawing.Size(533, 267);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView SubnodesView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private DetailsNav NavButtons;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label SummaryLabel;
        private System.Windows.Forms.Label DetailsLabel;
    }
}
