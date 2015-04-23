﻿namespace XLibrary.Panels
{
    partial class ViewPanel
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
            this.label1 = new System.Windows.Forms.Label();
            this.LayoutTreeMapButton = new System.Windows.Forms.RadioButton();
            this.LayoutCallGraphButton = new System.Windows.Forms.RadioButton();
            this.SizeLinesButton = new System.Windows.Forms.RadioButton();
            this.SizeConstantButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.SizeCallsButton = new System.Windows.Forms.RadioButton();
            this.SizeTimeInMethodButton = new System.Windows.Forms.RadioButton();
            this.SizeTimePerCallButton = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.IncludeOutsideZoomButton = new System.Windows.Forms.CheckBox();
            this.IncludeNotXRayedButton = new System.Windows.Forms.CheckBox();
            this.ShowNotHitButton = new System.Windows.Forms.RadioButton();
            this.ShowHitButton = new System.Windows.Forms.RadioButton();
            this.ShowAllButton = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.ShowInstancesButton = new System.Windows.Forms.RadioButton();
            this.CallsRealTimeButton = new System.Windows.Forms.CheckBox();
            this.CallsAllButton = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LayoutLayerGraphButton = new System.Windows.Forms.RadioButton();
            this.LayoutTimelineButton = new System.Windows.Forms.RadioButton();
            this.LayoutInitGraphButton = new System.Windows.Forms.RadioButton();
            this.ShowAllDependenciesCheckBox = new System.Windows.Forms.CheckBox();
            this.GraphIntermediateDependencies = new System.Windows.Forms.RadioButton();
            this.GraphDependencies = new System.Windows.Forms.RadioButton();
            this.MapDependencies = new System.Windows.Forms.RadioButton();
            this.LayoutClassCallsButton = new System.Windows.Forms.RadioButton();
            this.LayoutInOrder = new System.Windows.Forms.CheckBox();
            this.ResetHitLink = new System.Windows.Forms.LinkLabel();
            this.ShowCodeButton = new System.Windows.Forms.CheckBox();
            this.IncludeAnon = new System.Windows.Forms.CheckBox();
            this.IncludeMethods = new System.Windows.Forms.CheckBox();
            this.IncludeFields = new System.Windows.Forms.CheckBox();
            this.ResetProfilingLink = new System.Windows.Forms.LinkLabel();
            this.PauseLink = new System.Windows.Forms.LinkLabel();
            this.RenderGdiButton = new System.Windows.Forms.RadioButton();
            this.RenderOpenGLButton = new System.Windows.Forms.RadioButton();
            this.RenderGibsonButton = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Layout";
            // 
            // LayoutTreeMapButton
            // 
            this.LayoutTreeMapButton.AutoSize = true;
            this.LayoutTreeMapButton.Location = new System.Drawing.Point(3, 3);
            this.LayoutTreeMapButton.Name = "LayoutTreeMapButton";
            this.LayoutTreeMapButton.Size = new System.Drawing.Size(71, 17);
            this.LayoutTreeMapButton.TabIndex = 1;
            this.LayoutTreeMapButton.TabStop = true;
            this.LayoutTreeMapButton.Text = "Tree Map";
            this.LayoutTreeMapButton.UseVisualStyleBackColor = true;
            this.LayoutTreeMapButton.CheckedChanged += new System.EventHandler(this.LayoutTreeMapButton_CheckedChanged);
            // 
            // LayoutCallGraphButton
            // 
            this.LayoutCallGraphButton.AutoSize = true;
            this.LayoutCallGraphButton.Location = new System.Drawing.Point(3, 118);
            this.LayoutCallGraphButton.Name = "LayoutCallGraphButton";
            this.LayoutCallGraphButton.Size = new System.Drawing.Size(93, 17);
            this.LayoutCallGraphButton.TabIndex = 2;
            this.LayoutCallGraphButton.TabStop = true;
            this.LayoutCallGraphButton.Text = "Method Graph";
            this.LayoutCallGraphButton.UseVisualStyleBackColor = true;
            this.LayoutCallGraphButton.CheckedChanged += new System.EventHandler(this.LayoutCallGraphButton_CheckedChanged);
            // 
            // SizeLinesButton
            // 
            this.SizeLinesButton.AutoSize = true;
            this.SizeLinesButton.Location = new System.Drawing.Point(3, 26);
            this.SizeLinesButton.Name = "SizeLinesButton";
            this.SizeLinesButton.Size = new System.Drawing.Size(50, 17);
            this.SizeLinesButton.TabIndex = 5;
            this.SizeLinesButton.TabStop = true;
            this.SizeLinesButton.Text = "Lines";
            this.SizeLinesButton.UseVisualStyleBackColor = true;
            this.SizeLinesButton.CheckedChanged += new System.EventHandler(this.SizeLinesButton_CheckedChanged);
            // 
            // SizeConstantButton
            // 
            this.SizeConstantButton.AutoSize = true;
            this.SizeConstantButton.Location = new System.Drawing.Point(3, 3);
            this.SizeConstantButton.Name = "SizeConstantButton";
            this.SizeConstantButton.Size = new System.Drawing.Size(67, 17);
            this.SizeConstantButton.TabIndex = 4;
            this.SizeConstantButton.TabStop = true;
            this.SizeConstantButton.Text = "Constant";
            this.SizeConstantButton.UseVisualStyleBackColor = true;
            this.SizeConstantButton.CheckedChanged += new System.EventHandler(this.SizeConstantButton_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(557, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Size by";
            // 
            // SizeCallsButton
            // 
            this.SizeCallsButton.AutoSize = true;
            this.SizeCallsButton.Location = new System.Drawing.Point(3, 49);
            this.SizeCallsButton.Name = "SizeCallsButton";
            this.SizeCallsButton.Size = new System.Drawing.Size(47, 17);
            this.SizeCallsButton.TabIndex = 7;
            this.SizeCallsButton.TabStop = true;
            this.SizeCallsButton.Text = "Calls";
            this.SizeCallsButton.UseVisualStyleBackColor = true;
            this.SizeCallsButton.CheckedChanged += new System.EventHandler(this.SizeCallsButton_CheckedChanged);
            // 
            // SizeTimeInMethodButton
            // 
            this.SizeTimeInMethodButton.AutoSize = true;
            this.SizeTimeInMethodButton.Location = new System.Drawing.Point(3, 95);
            this.SizeTimeInMethodButton.Name = "SizeTimeInMethodButton";
            this.SizeTimeInMethodButton.Size = new System.Drawing.Size(98, 17);
            this.SizeTimeInMethodButton.TabIndex = 6;
            this.SizeTimeInMethodButton.TabStop = true;
            this.SizeTimeInMethodButton.Text = "Time in Method";
            this.SizeTimeInMethodButton.UseVisualStyleBackColor = true;
            this.SizeTimeInMethodButton.CheckedChanged += new System.EventHandler(this.SizeTimeInMethodButton_CheckedChanged);
            // 
            // SizeTimePerCallButton
            // 
            this.SizeTimePerCallButton.AutoSize = true;
            this.SizeTimePerCallButton.Location = new System.Drawing.Point(3, 72);
            this.SizeTimePerCallButton.Name = "SizeTimePerCallButton";
            this.SizeTimePerCallButton.Size = new System.Drawing.Size(86, 17);
            this.SizeTimePerCallButton.TabIndex = 8;
            this.SizeTimePerCallButton.TabStop = true;
            this.SizeTimePerCallButton.Text = "Time per Call";
            this.SizeTimePerCallButton.UseVisualStyleBackColor = true;
            this.SizeTimePerCallButton.CheckedChanged += new System.EventHandler(this.SizeTimePerCallButton_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(456, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Include";
            // 
            // IncludeOutsideZoomButton
            // 
            this.IncludeOutsideZoomButton.AutoSize = true;
            this.IncludeOutsideZoomButton.Location = new System.Drawing.Point(3, 3);
            this.IncludeOutsideZoomButton.Name = "IncludeOutsideZoomButton";
            this.IncludeOutsideZoomButton.Size = new System.Drawing.Size(92, 17);
            this.IncludeOutsideZoomButton.TabIndex = 10;
            this.IncludeOutsideZoomButton.Text = "Outside Zoom";
            this.IncludeOutsideZoomButton.UseVisualStyleBackColor = true;
            this.IncludeOutsideZoomButton.CheckedChanged += new System.EventHandler(this.IncludeOutsideZoomButton_CheckedChanged);
            // 
            // IncludeNotXRayedButton
            // 
            this.IncludeNotXRayedButton.AutoSize = true;
            this.IncludeNotXRayedButton.Location = new System.Drawing.Point(3, 26);
            this.IncludeNotXRayedButton.Name = "IncludeNotXRayedButton";
            this.IncludeNotXRayedButton.Size = new System.Drawing.Size(84, 17);
            this.IncludeNotXRayedButton.TabIndex = 11;
            this.IncludeNotXRayedButton.Text = "Not XRayed";
            this.IncludeNotXRayedButton.UseVisualStyleBackColor = true;
            this.IncludeNotXRayedButton.CheckedChanged += new System.EventHandler(this.IncludeNotXRayedButton_CheckedChanged);
            // 
            // ShowNotHitButton
            // 
            this.ShowNotHitButton.AutoSize = true;
            this.ShowNotHitButton.Location = new System.Drawing.Point(3, 49);
            this.ShowNotHitButton.Name = "ShowNotHitButton";
            this.ShowNotHitButton.Size = new System.Drawing.Size(75, 17);
            this.ShowNotHitButton.TabIndex = 15;
            this.ShowNotHitButton.TabStop = true;
            this.ShowNotHitButton.Text = "Not Execd";
            this.ShowNotHitButton.UseVisualStyleBackColor = true;
            this.ShowNotHitButton.CheckedChanged += new System.EventHandler(this.ShowNotHitButton_CheckedChanged);
            // 
            // ShowHitButton
            // 
            this.ShowHitButton.AutoSize = true;
            this.ShowHitButton.Location = new System.Drawing.Point(3, 26);
            this.ShowHitButton.Name = "ShowHitButton";
            this.ShowHitButton.Size = new System.Drawing.Size(70, 17);
            this.ShowHitButton.TabIndex = 14;
            this.ShowHitButton.TabStop = true;
            this.ShowHitButton.Text = "Executed";
            this.ShowHitButton.UseVisualStyleBackColor = true;
            this.ShowHitButton.CheckedChanged += new System.EventHandler(this.ShowHitButton_CheckedChanged);
            // 
            // ShowAllButton
            // 
            this.ShowAllButton.AutoSize = true;
            this.ShowAllButton.Location = new System.Drawing.Point(3, 3);
            this.ShowAllButton.Name = "ShowAllButton";
            this.ShowAllButton.Size = new System.Drawing.Size(36, 17);
            this.ShowAllButton.TabIndex = 13;
            this.ShowAllButton.TabStop = true;
            this.ShowAllButton.Text = "All";
            this.ShowAllButton.UseVisualStyleBackColor = true;
            this.ShowAllButton.CheckedChanged += new System.EventHandler(this.ShowAllButton_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(290, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Elements";
            // 
            // ShowInstancesButton
            // 
            this.ShowInstancesButton.AutoSize = true;
            this.ShowInstancesButton.Location = new System.Drawing.Point(3, 72);
            this.ShowInstancesButton.Name = "ShowInstancesButton";
            this.ShowInstancesButton.Size = new System.Drawing.Size(45, 17);
            this.ShowInstancesButton.TabIndex = 16;
            this.ShowInstancesButton.TabStop = true;
            this.ShowInstancesButton.Text = "Initd";
            this.ShowInstancesButton.UseVisualStyleBackColor = true;
            this.ShowInstancesButton.CheckedChanged += new System.EventHandler(this.ShowInstancesButton_CheckedChanged);
            // 
            // CallsRealTimeButton
            // 
            this.CallsRealTimeButton.AutoSize = true;
            this.CallsRealTimeButton.Location = new System.Drawing.Point(3, 26);
            this.CallsRealTimeButton.Name = "CallsRealTimeButton";
            this.CallsRealTimeButton.Size = new System.Drawing.Size(70, 17);
            this.CallsRealTimeButton.TabIndex = 20;
            this.CallsRealTimeButton.Text = "Real-time";
            this.CallsRealTimeButton.UseVisualStyleBackColor = true;
            this.CallsRealTimeButton.CheckedChanged += new System.EventHandler(this.CallsRealTimeButton_CheckedChanged);
            // 
            // CallsAllButton
            // 
            this.CallsAllButton.AutoSize = true;
            this.CallsAllButton.Location = new System.Drawing.Point(3, 3);
            this.CallsAllButton.Name = "CallsAllButton";
            this.CallsAllButton.Size = new System.Drawing.Size(48, 17);
            this.CallsAllButton.TabIndex = 19;
            this.CallsAllButton.Text = "Calls";
            this.CallsAllButton.UseVisualStyleBackColor = true;
            this.CallsAllButton.CheckedChanged += new System.EventHandler(this.CallsAllButton_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(377, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Show";
            // 
            // LayoutLayerGraphButton
            // 
            this.LayoutLayerGraphButton.AutoSize = true;
            this.LayoutLayerGraphButton.Location = new System.Drawing.Point(3, 26);
            this.LayoutLayerGraphButton.Name = "LayoutLayerGraphButton";
            this.LayoutLayerGraphButton.Size = new System.Drawing.Size(83, 17);
            this.LayoutLayerGraphButton.TabIndex = 35;
            this.LayoutLayerGraphButton.TabStop = true;
            this.LayoutLayerGraphButton.Text = "Layer Graph";
            this.LayoutLayerGraphButton.UseVisualStyleBackColor = true;
            this.LayoutLayerGraphButton.CheckedChanged += new System.EventHandler(this.LayoutLayerGraphButton_CheckedChanged);
            // 
            // LayoutTimelineButton
            // 
            this.LayoutTimelineButton.AutoSize = true;
            this.LayoutTimelineButton.Location = new System.Drawing.Point(3, 49);
            this.LayoutTimelineButton.Name = "LayoutTimelineButton";
            this.LayoutTimelineButton.Size = new System.Drawing.Size(80, 17);
            this.LayoutTimelineButton.TabIndex = 34;
            this.LayoutTimelineButton.TabStop = true;
            this.LayoutTimelineButton.Text = "Threadlines";
            this.LayoutTimelineButton.UseVisualStyleBackColor = true;
            this.LayoutTimelineButton.CheckedChanged += new System.EventHandler(this.TimelineButton_CheckedChanged);
            // 
            // LayoutInitGraphButton
            // 
            this.LayoutInitGraphButton.AutoSize = true;
            this.LayoutInitGraphButton.Location = new System.Drawing.Point(3, 72);
            this.LayoutInitGraphButton.Name = "LayoutInitGraphButton";
            this.LayoutInitGraphButton.Size = new System.Drawing.Size(79, 17);
            this.LayoutInitGraphButton.TabIndex = 33;
            this.LayoutInitGraphButton.TabStop = true;
            this.LayoutInitGraphButton.Text = "Initialization";
            this.LayoutInitGraphButton.UseVisualStyleBackColor = true;
            this.LayoutInitGraphButton.CheckedChanged += new System.EventHandler(this.LayoutInitGraphButton_CheckedChanged);
            // 
            // ShowAllDependenciesCheckBox
            // 
            this.ShowAllDependenciesCheckBox.AutoSize = true;
            this.ShowAllDependenciesCheckBox.Location = new System.Drawing.Point(102, 49);
            this.ShowAllDependenciesCheckBox.Name = "ShowAllDependenciesCheckBox";
            this.ShowAllDependenciesCheckBox.Size = new System.Drawing.Size(89, 17);
            this.ShowAllDependenciesCheckBox.TabIndex = 32;
            this.ShowAllDependenciesCheckBox.Text = "Sub-depends";
            this.ShowAllDependenciesCheckBox.UseVisualStyleBackColor = true;
            this.ShowAllDependenciesCheckBox.CheckedChanged += new System.EventHandler(this.ShowAllDependenciesCheckBox_CheckedChanged);
            // 
            // GraphIntermediateDependencies
            // 
            this.GraphIntermediateDependencies.AutoSize = true;
            this.GraphIntermediateDependencies.Location = new System.Drawing.Point(102, 72);
            this.GraphIntermediateDependencies.Name = "GraphIntermediateDependencies";
            this.GraphIntermediateDependencies.Size = new System.Drawing.Size(90, 17);
            this.GraphIntermediateDependencies.TabIndex = 30;
            this.GraphIntermediateDependencies.TabStop = true;
            this.GraphIntermediateDependencies.Text = "Inter-depends";
            this.GraphIntermediateDependencies.UseVisualStyleBackColor = true;
            this.GraphIntermediateDependencies.CheckedChanged += new System.EventHandler(this.GraphIntermediateDependencies_CheckedChanged);
            // 
            // GraphDependencies
            // 
            this.GraphDependencies.AutoSize = true;
            this.GraphDependencies.Location = new System.Drawing.Point(102, 26);
            this.GraphDependencies.Name = "GraphDependencies";
            this.GraphDependencies.Size = new System.Drawing.Size(100, 17);
            this.GraphDependencies.TabIndex = 25;
            this.GraphDependencies.TabStop = true;
            this.GraphDependencies.Text = "Depends Graph";
            this.GraphDependencies.UseVisualStyleBackColor = true;
            this.GraphDependencies.CheckedChanged += new System.EventHandler(this.GraphAllDependencies_CheckedChanged);
            // 
            // MapDependencies
            // 
            this.MapDependencies.AutoSize = true;
            this.MapDependencies.Location = new System.Drawing.Point(102, 3);
            this.MapDependencies.Name = "MapDependencies";
            this.MapDependencies.Size = new System.Drawing.Size(92, 17);
            this.MapDependencies.TabIndex = 24;
            this.MapDependencies.TabStop = true;
            this.MapDependencies.Text = "Depends Map";
            this.MapDependencies.UseVisualStyleBackColor = true;
            this.MapDependencies.CheckedChanged += new System.EventHandler(this.MapAllDependencies_CheckedChanged);
            // 
            // LayoutClassCallsButton
            // 
            this.LayoutClassCallsButton.AutoSize = true;
            this.LayoutClassCallsButton.Location = new System.Drawing.Point(3, 95);
            this.LayoutClassCallsButton.Name = "LayoutClassCallsButton";
            this.LayoutClassCallsButton.Size = new System.Drawing.Size(82, 17);
            this.LayoutClassCallsButton.TabIndex = 3;
            this.LayoutClassCallsButton.TabStop = true;
            this.LayoutClassCallsButton.Text = "Class Graph";
            this.LayoutClassCallsButton.UseVisualStyleBackColor = true;
            this.LayoutClassCallsButton.CheckedChanged += new System.EventHandler(this.LayoutClassCallsButton_CheckedChanged);
            // 
            // LayoutInOrder
            // 
            this.LayoutInOrder.AutoSize = true;
            this.LayoutInOrder.Location = new System.Drawing.Point(3, 49);
            this.LayoutInOrder.Name = "LayoutInOrder";
            this.LayoutInOrder.Size = new System.Drawing.Size(64, 17);
            this.LayoutInOrder.TabIndex = 21;
            this.LayoutInOrder.Text = "In Order";
            this.LayoutInOrder.UseVisualStyleBackColor = true;
            this.LayoutInOrder.CheckedChanged += new System.EventHandler(this.LayoutInOrder_CheckedChanged);
            // 
            // ResetHitLink
            // 
            this.ResetHitLink.AutoSize = true;
            this.ResetHitLink.Location = new System.Drawing.Point(3, 92);
            this.ResetHitLink.Name = "ResetHitLink";
            this.ResetHitLink.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.ResetHitLink.Size = new System.Drawing.Size(51, 17);
            this.ResetHitLink.TabIndex = 10;
            this.ResetHitLink.TabStop = true;
            this.ResetHitLink.Text = "Reset Hit";
            this.ResetHitLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ResetHitLink_LinkClicked);
            // 
            // ShowCodeButton
            // 
            this.ShowCodeButton.AutoSize = true;
            this.ShowCodeButton.Location = new System.Drawing.Point(3, 72);
            this.ShowCodeButton.Name = "ShowCodeButton";
            this.ShowCodeButton.Size = new System.Drawing.Size(51, 17);
            this.ShowCodeButton.TabIndex = 22;
            this.ShowCodeButton.Text = "Code";
            this.ShowCodeButton.UseVisualStyleBackColor = true;
            this.ShowCodeButton.CheckedChanged += new System.EventHandler(this.ShowCodeButton_CheckedChanged);
            // 
            // IncludeAnon
            // 
            this.IncludeAnon.AutoSize = true;
            this.IncludeAnon.Location = new System.Drawing.Point(3, 95);
            this.IncludeAnon.Name = "IncludeAnon";
            this.IncludeAnon.Size = new System.Drawing.Size(51, 17);
            this.IncludeAnon.TabIndex = 14;
            this.IncludeAnon.Text = "Anon";
            this.IncludeAnon.UseVisualStyleBackColor = true;
            this.IncludeAnon.CheckedChanged += new System.EventHandler(this.IncludeAnon_CheckedChanged);
            // 
            // IncludeMethods
            // 
            this.IncludeMethods.AutoSize = true;
            this.IncludeMethods.Location = new System.Drawing.Point(3, 49);
            this.IncludeMethods.Name = "IncludeMethods";
            this.IncludeMethods.Size = new System.Drawing.Size(67, 17);
            this.IncludeMethods.TabIndex = 13;
            this.IncludeMethods.Text = "Methods";
            this.IncludeMethods.UseVisualStyleBackColor = true;
            this.IncludeMethods.CheckedChanged += new System.EventHandler(this.IncludeMethods_CheckedChanged);
            // 
            // IncludeFields
            // 
            this.IncludeFields.AutoSize = true;
            this.IncludeFields.Location = new System.Drawing.Point(3, 72);
            this.IncludeFields.Name = "IncludeFields";
            this.IncludeFields.Size = new System.Drawing.Size(53, 17);
            this.IncludeFields.TabIndex = 12;
            this.IncludeFields.Text = "Fields";
            this.IncludeFields.UseVisualStyleBackColor = true;
            this.IncludeFields.CheckedChanged += new System.EventHandler(this.IncludeFields_CheckedChanged);
            // 
            // ResetProfilingLink
            // 
            this.ResetProfilingLink.AutoSize = true;
            this.ResetProfilingLink.Location = new System.Drawing.Point(3, 115);
            this.ResetProfilingLink.Name = "ResetProfilingLink";
            this.ResetProfilingLink.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.ResetProfilingLink.Size = new System.Drawing.Size(75, 17);
            this.ResetProfilingLink.TabIndex = 9;
            this.ResetProfilingLink.TabStop = true;
            this.ResetProfilingLink.Text = "Reset Profiling";
            this.ResetProfilingLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ResetProfilingLink_LinkClicked);
            // 
            // PauseLink
            // 
            this.PauseLink.AutoSize = true;
            this.PauseLink.LinkColor = System.Drawing.Color.DarkRed;
            this.PauseLink.Location = new System.Drawing.Point(3, 69);
            this.PauseLink.Name = "PauseLink";
            this.PauseLink.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.PauseLink.Size = new System.Drawing.Size(37, 17);
            this.PauseLink.TabIndex = 17;
            this.PauseLink.TabStop = true;
            this.PauseLink.Text = "Pause";
            this.PauseLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.PauseLink_LinkClicked);
            // 
            // RenderGdiButton
            // 
            this.RenderGdiButton.AutoSize = true;
            this.RenderGdiButton.Location = new System.Drawing.Point(3, 3);
            this.RenderGdiButton.Name = "RenderGdiButton";
            this.RenderGdiButton.Size = new System.Drawing.Size(44, 17);
            this.RenderGdiButton.TabIndex = 17;
            this.RenderGdiButton.TabStop = true;
            this.RenderGdiButton.Text = "GDI";
            this.RenderGdiButton.UseVisualStyleBackColor = true;
            this.RenderGdiButton.CheckedChanged += new System.EventHandler(this.RenderGdiButton_CheckedChanged);
            // 
            // RenderOpenGLButton
            // 
            this.RenderOpenGLButton.AutoSize = true;
            this.RenderOpenGLButton.Location = new System.Drawing.Point(3, 26);
            this.RenderOpenGLButton.Name = "RenderOpenGLButton";
            this.RenderOpenGLButton.Size = new System.Drawing.Size(65, 17);
            this.RenderOpenGLButton.TabIndex = 18;
            this.RenderOpenGLButton.TabStop = true;
            this.RenderOpenGLButton.Text = "OpenGL";
            this.RenderOpenGLButton.UseVisualStyleBackColor = true;
            this.RenderOpenGLButton.CheckedChanged += new System.EventHandler(this.RenderOpenGLButton_CheckedChanged);
            // 
            // RenderGibsonButton
            // 
            this.RenderGibsonButton.AutoSize = true;
            this.RenderGibsonButton.Location = new System.Drawing.Point(3, 49);
            this.RenderGibsonButton.Name = "RenderGibsonButton";
            this.RenderGibsonButton.Size = new System.Drawing.Size(58, 17);
            this.RenderGibsonButton.TabIndex = 19;
            this.RenderGibsonButton.TabStop = true;
            this.RenderGibsonButton.Text = "Gibson";
            this.RenderGibsonButton.UseVisualStyleBackColor = true;
            this.RenderGibsonButton.CheckedChanged += new System.EventHandler(this.RenderFpsButton_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(213, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Rendering";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.LayoutTreeMapButton);
            this.flowLayoutPanel1.Controls.Add(this.LayoutLayerGraphButton);
            this.flowLayoutPanel1.Controls.Add(this.LayoutTimelineButton);
            this.flowLayoutPanel1.Controls.Add(this.LayoutInitGraphButton);
            this.flowLayoutPanel1.Controls.Add(this.LayoutClassCallsButton);
            this.flowLayoutPanel1.Controls.Add(this.LayoutCallGraphButton);
            this.flowLayoutPanel1.Controls.Add(this.MapDependencies);
            this.flowLayoutPanel1.Controls.Add(this.GraphDependencies);
            this.flowLayoutPanel1.Controls.Add(this.ShowAllDependenciesCheckBox);
            this.flowLayoutPanel1.Controls.Add(this.GraphIntermediateDependencies);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 20);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(204, 146);
            this.flowLayoutPanel1.TabIndex = 32;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.RenderGdiButton);
            this.flowLayoutPanel3.Controls.Add(this.RenderOpenGLButton);
            this.flowLayoutPanel3.Controls.Add(this.RenderGibsonButton);
            this.flowLayoutPanel3.Controls.Add(this.PauseLink);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(216, 20);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(71, 146);
            this.flowLayoutPanel3.TabIndex = 34;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.ShowAllButton);
            this.flowLayoutPanel4.Controls.Add(this.ShowHitButton);
            this.flowLayoutPanel4.Controls.Add(this.ShowNotHitButton);
            this.flowLayoutPanel4.Controls.Add(this.ShowInstancesButton);
            this.flowLayoutPanel4.Controls.Add(this.ResetHitLink);
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(293, 20);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(81, 146);
            this.flowLayoutPanel4.TabIndex = 35;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.CallsAllButton);
            this.flowLayoutPanel5.Controls.Add(this.CallsRealTimeButton);
            this.flowLayoutPanel5.Controls.Add(this.LayoutInOrder);
            this.flowLayoutPanel5.Controls.Add(this.ShowCodeButton);
            this.flowLayoutPanel5.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(380, 20);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(72, 146);
            this.flowLayoutPanel5.TabIndex = 36;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.IncludeOutsideZoomButton);
            this.flowLayoutPanel6.Controls.Add(this.IncludeNotXRayedButton);
            this.flowLayoutPanel6.Controls.Add(this.IncludeMethods);
            this.flowLayoutPanel6.Controls.Add(this.IncludeFields);
            this.flowLayoutPanel6.Controls.Add(this.IncludeAnon);
            this.flowLayoutPanel6.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel6.Location = new System.Drawing.Point(459, 20);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(91, 146);
            this.flowLayoutPanel6.TabIndex = 37;
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.Controls.Add(this.SizeConstantButton);
            this.flowLayoutPanel7.Controls.Add(this.SizeLinesButton);
            this.flowLayoutPanel7.Controls.Add(this.SizeCallsButton);
            this.flowLayoutPanel7.Controls.Add(this.SizeTimePerCallButton);
            this.flowLayoutPanel7.Controls.Add(this.SizeTimeInMethodButton);
            this.flowLayoutPanel7.Controls.Add(this.ResetProfilingLink);
            this.flowLayoutPanel7.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel7.Location = new System.Drawing.Point(560, 20);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(111, 146);
            this.flowLayoutPanel7.TabIndex = 38;
            // 
            // ViewPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.flowLayoutPanel7);
            this.Controls.Add(this.flowLayoutPanel6);
            this.Controls.Add(this.flowLayoutPanel5);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "ViewPanel";
            this.Size = new System.Drawing.Size(778, 170);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.RadioButton LayoutTreeMapButton;
        public System.Windows.Forms.RadioButton LayoutCallGraphButton;
        public System.Windows.Forms.RadioButton SizeLinesButton;
        public System.Windows.Forms.RadioButton SizeConstantButton;
        public System.Windows.Forms.RadioButton SizeCallsButton;
        public System.Windows.Forms.RadioButton SizeTimeInMethodButton;
        public System.Windows.Forms.RadioButton SizeTimePerCallButton;
        public System.Windows.Forms.CheckBox IncludeOutsideZoomButton;
        public System.Windows.Forms.CheckBox IncludeNotXRayedButton;
        public System.Windows.Forms.RadioButton ShowNotHitButton;
        public System.Windows.Forms.RadioButton ShowHitButton;
        public System.Windows.Forms.RadioButton ShowAllButton;
        public System.Windows.Forms.RadioButton ShowInstancesButton;
        public System.Windows.Forms.CheckBox CallsRealTimeButton;
        public System.Windows.Forms.CheckBox CallsAllButton;
        public System.Windows.Forms.RadioButton LayoutClassCallsButton;
        public System.Windows.Forms.CheckBox LayoutInOrder;
        public System.Windows.Forms.CheckBox IncludeFields;
        public System.Windows.Forms.RadioButton GraphDependencies;
        public System.Windows.Forms.RadioButton MapDependencies;
        private System.Windows.Forms.LinkLabel ResetHitLink;
        private System.Windows.Forms.LinkLabel ResetProfilingLink;
        public System.Windows.Forms.RadioButton GraphIntermediateDependencies;
        public System.Windows.Forms.CheckBox IncludeMethods;
        public System.Windows.Forms.CheckBox IncludeAnon;
        private System.Windows.Forms.CheckBox ShowAllDependenciesCheckBox;
        public System.Windows.Forms.RadioButton LayoutInitGraphButton;
        public System.Windows.Forms.RadioButton LayoutTimelineButton;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.RadioButton RenderGdiButton;
        public System.Windows.Forms.RadioButton RenderOpenGLButton;
        public System.Windows.Forms.RadioButton RenderGibsonButton;
        private System.Windows.Forms.LinkLabel PauseLink;
        public System.Windows.Forms.RadioButton LayoutLayerGraphButton;
        public System.Windows.Forms.CheckBox ShowCodeButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
    }
}
