﻿namespace comparitron.ui
{
    partial class FormMain
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
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.engageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.tableLayoutLeft = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxViewMode = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTrackLeftFar = new System.Windows.Forms.Button();
            this.btnTrackLeft = new System.Windows.Forms.Button();
            this.btnJumpFrame = new System.Windows.Forms.Button();
            this.btnTrackRight = new System.Windows.Forms.Button();
            this.btnTrackRightFar = new System.Windows.Forms.Button();
            this.trackbarFrame = new System.Windows.Forms.TrackBar();
            this.trackBarFade = new System.Windows.Forms.TrackBar();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddCompare = new System.Windows.Forms.Button();
            this.btnAddText = new System.Windows.Forms.Button();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.btnAddVideo = new System.Windows.Forms.Button();
            this.btnAddDivide = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnGoto = new System.Windows.Forms.Button();
            this.btnSetFrame = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.openProjectBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.reloadFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comparitronCoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.comparisonViewer = new comparitron.ui.ComparisonViewer();
            this.menuStripMain.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.tableLayoutLeft.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackbarFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFade)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comparitronCoreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comparisonViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.projectToolStripMenuItem,
            this.engageToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStripMain.Size = new System.Drawing.Size(1362, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.reloadFolderToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.projectToolStripMenuItem.Text = "Project";
            this.projectToolStripMenuItem.Click += new System.EventHandler(this.projectToolStripMenuItem_Click);
            // 
            // engageToolStripMenuItem
            // 
            this.engageToolStripMenuItem.Name = "engageToolStripMenuItem";
            this.engageToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.engageToolStripMenuItem.Text = "Engage!";
            this.engageToolStripMenuItem.Click += new System.EventHandler(this.engageToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.AllowMerge = false;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel1,
            this.statusLabel2,
            this.statusLabel3,
            this.statusLabel4});
            this.statusStrip1.Location = new System.Drawing.Point(0, 719);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(1362, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // statusLabel1
            // 
            this.statusLabel1.Name = "statusLabel1";
            this.statusLabel1.Size = new System.Drawing.Size(118, 17);
            this.statusLabel1.Text = "toolStripStatusLabel1";
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 24);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.tableLayoutLeft);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainerMain.Size = new System.Drawing.Size(1362, 695);
            this.splitContainerMain.SplitterDistance = 817;
            this.splitContainerMain.TabIndex = 2;
            // 
            // tableLayoutLeft
            // 
            this.tableLayoutLeft.AutoSize = true;
            this.tableLayoutLeft.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutLeft.ColumnCount = 2;
            this.tableLayoutLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutLeft.Controls.Add(this.comparisonViewer, 0, 1);
            this.tableLayoutLeft.Controls.Add(this.comboBoxViewMode, 0, 0);
            this.tableLayoutLeft.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.tableLayoutLeft.Controls.Add(this.trackbarFrame, 0, 3);
            this.tableLayoutLeft.Controls.Add(this.trackBarFade, 1, 0);
            this.tableLayoutLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutLeft.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutLeft.Name = "tableLayoutLeft";
            this.tableLayoutLeft.RowCount = 4;
            this.tableLayoutLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutLeft.Size = new System.Drawing.Size(815, 693);
            this.tableLayoutLeft.TabIndex = 0;
            // 
            // comboBoxViewMode
            // 
            this.comboBoxViewMode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxViewMode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxViewMode.FormattingEnabled = true;
            this.comboBoxViewMode.Location = new System.Drawing.Point(3, 4);
            this.comboBoxViewMode.Name = "comboBoxViewMode";
            this.comboBoxViewMode.Size = new System.Drawing.Size(121, 21);
            this.comboBoxViewMode.TabIndex = 1;
            this.comboBoxViewMode.SelectedIndexChanged += new System.EventHandler(this.comboBoxViewMode_SelectedIndexChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutLeft.SetColumnSpan(this.flowLayoutPanel1, 2);
            this.flowLayoutPanel1.Controls.Add(this.btnTrackLeftFar);
            this.flowLayoutPanel1.Controls.Add(this.btnTrackLeft);
            this.flowLayoutPanel1.Controls.Add(this.btnJumpFrame);
            this.flowLayoutPanel1.Controls.Add(this.btnTrackRight);
            this.flowLayoutPanel1.Controls.Add(this.btnTrackRightFar);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(205, 634);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(405, 29);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // btnTrackLeftFar
            // 
            this.btnTrackLeftFar.Image = global::comparitron.ui.Properties.Resources.btnSkipBack;
            this.btnTrackLeftFar.Location = new System.Drawing.Point(3, 3);
            this.btnTrackLeftFar.Name = "btnTrackLeftFar";
            this.btnTrackLeftFar.Size = new System.Drawing.Size(75, 23);
            this.btnTrackLeftFar.TabIndex = 0;
            this.btnTrackLeftFar.UseVisualStyleBackColor = true;
            // 
            // btnTrackLeft
            // 
            this.btnTrackLeft.Image = global::comparitron.ui.Properties.Resources.btnBack;
            this.btnTrackLeft.Location = new System.Drawing.Point(84, 3);
            this.btnTrackLeft.Name = "btnTrackLeft";
            this.btnTrackLeft.Size = new System.Drawing.Size(75, 23);
            this.btnTrackLeft.TabIndex = 1;
            this.btnTrackLeft.UseVisualStyleBackColor = true;
            this.btnTrackLeft.Click += new System.EventHandler(this.btnTrackLeft_Click);
            // 
            // btnJumpFrame
            // 
            this.btnJumpFrame.Location = new System.Drawing.Point(165, 3);
            this.btnJumpFrame.Name = "btnJumpFrame";
            this.btnJumpFrame.Size = new System.Drawing.Size(75, 23);
            this.btnJumpFrame.TabIndex = 2;
            this.btnJumpFrame.Text = "Frame";
            this.btnJumpFrame.UseVisualStyleBackColor = true;
            // 
            // btnTrackRight
            // 
            this.btnTrackRight.Image = global::comparitron.ui.Properties.Resources.btnNext;
            this.btnTrackRight.Location = new System.Drawing.Point(246, 3);
            this.btnTrackRight.Name = "btnTrackRight";
            this.btnTrackRight.Size = new System.Drawing.Size(75, 23);
            this.btnTrackRight.TabIndex = 3;
            this.btnTrackRight.UseVisualStyleBackColor = true;
            this.btnTrackRight.Click += new System.EventHandler(this.btnTrackRight_Click);
            // 
            // btnTrackRightFar
            // 
            this.btnTrackRightFar.Image = global::comparitron.ui.Properties.Resources.btnSkipNext;
            this.btnTrackRightFar.Location = new System.Drawing.Point(327, 3);
            this.btnTrackRightFar.Name = "btnTrackRightFar";
            this.btnTrackRightFar.Size = new System.Drawing.Size(75, 23);
            this.btnTrackRightFar.TabIndex = 4;
            this.btnTrackRightFar.UseVisualStyleBackColor = true;
            // 
            // trackbarFrame
            // 
            this.tableLayoutLeft.SetColumnSpan(this.trackbarFrame, 2);
            this.trackbarFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackbarFrame.Location = new System.Drawing.Point(3, 666);
            this.trackbarFrame.Name = "trackbarFrame";
            this.trackbarFrame.Size = new System.Drawing.Size(809, 24);
            this.trackbarFrame.TabIndex = 4;
            this.trackbarFrame.TickFrequency = 1000;
            this.trackbarFrame.Scroll += new System.EventHandler(this.trackbarFrame_Scroll);
            // 
            // trackBarFade
            // 
            this.trackBarFade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarFade.Location = new System.Drawing.Point(131, 3);
            this.trackBarFade.Maximum = 100;
            this.trackBarFade.Name = "trackBarFade";
            this.trackBarFade.Size = new System.Drawing.Size(681, 24);
            this.trackBarFade.TabIndex = 5;
            this.trackBarFade.TickFrequency = 10;
            this.trackBarFade.Value = 50;
            this.trackBarFade.Scroll += new System.EventHandler(this.trackBarFade_Scroll);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxInput, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(539, 693);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.btnAddCompare);
            this.flowLayoutPanel2.Controls.Add(this.btnAddText);
            this.flowLayoutPanel2.Controls.Add(this.btnAddImage);
            this.flowLayoutPanel2.Controls.Add(this.btnAddVideo);
            this.flowLayoutPanel2.Controls.Add(this.btnAddDivide);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(67, 635);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(405, 29);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // btnAddCompare
            // 
            this.btnAddCompare.Location = new System.Drawing.Point(3, 3);
            this.btnAddCompare.Name = "btnAddCompare";
            this.btnAddCompare.Size = new System.Drawing.Size(75, 23);
            this.btnAddCompare.TabIndex = 0;
            this.btnAddCompare.Text = "Add Frame";
            this.btnAddCompare.UseVisualStyleBackColor = true;
            this.btnAddCompare.Click += new System.EventHandler(this.btnAddCompare_Click);
            // 
            // btnAddText
            // 
            this.btnAddText.Location = new System.Drawing.Point(84, 3);
            this.btnAddText.Name = "btnAddText";
            this.btnAddText.Size = new System.Drawing.Size(75, 23);
            this.btnAddText.TabIndex = 1;
            this.btnAddText.Text = "Add Text";
            this.btnAddText.UseVisualStyleBackColor = true;
            this.btnAddText.Click += new System.EventHandler(this.btnAddText_Click);
            // 
            // btnAddImage
            // 
            this.btnAddImage.Location = new System.Drawing.Point(165, 3);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(75, 23);
            this.btnAddImage.TabIndex = 2;
            this.btnAddImage.Text = "Add Image";
            this.btnAddImage.UseVisualStyleBackColor = true;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // btnAddVideo
            // 
            this.btnAddVideo.Location = new System.Drawing.Point(246, 3);
            this.btnAddVideo.Name = "btnAddVideo";
            this.btnAddVideo.Size = new System.Drawing.Size(75, 23);
            this.btnAddVideo.TabIndex = 4;
            this.btnAddVideo.Text = "Add Video";
            this.btnAddVideo.UseVisualStyleBackColor = true;
            this.btnAddVideo.Click += new System.EventHandler(this.btnAddVideo_Click);
            // 
            // btnAddDivide
            // 
            this.btnAddDivide.Location = new System.Drawing.Point(327, 3);
            this.btnAddDivide.Name = "btnAddDivide";
            this.btnAddDivide.Size = new System.Drawing.Size(75, 23);
            this.btnAddDivide.TabIndex = 3;
            this.btnAddDivide.Text = "Add Split";
            this.btnAddDivide.UseVisualStyleBackColor = true;
            this.btnAddDivide.Click += new System.EventHandler(this.btnAddDivide_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel3.Controls.Add(this.btnMoveUp);
            this.flowLayoutPanel3.Controls.Add(this.btnMoveDown);
            this.flowLayoutPanel3.Controls.Add(this.btnDelete);
            this.flowLayoutPanel3.Controls.Add(this.btnGoto);
            this.flowLayoutPanel3.Controls.Add(this.btnSetFrame);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(67, 664);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(405, 29);
            this.flowLayoutPanel3.TabIndex = 2;
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Location = new System.Drawing.Point(3, 3);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(75, 23);
            this.btnMoveUp.TabIndex = 0;
            this.btnMoveUp.Text = "Move Up";
            this.btnMoveUp.UseVisualStyleBackColor = true;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Location = new System.Drawing.Point(84, 3);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(75, 23);
            this.btnMoveDown.TabIndex = 1;
            this.btnMoveDown.Text = "Move Down";
            this.btnMoveDown.UseVisualStyleBackColor = true;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(165, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnGoto
            // 
            this.btnGoto.Location = new System.Drawing.Point(246, 3);
            this.btnGoto.Name = "btnGoto";
            this.btnGoto.Size = new System.Drawing.Size(75, 23);
            this.btnGoto.TabIndex = 3;
            this.btnGoto.Text = "Goto Frame";
            this.btnGoto.UseVisualStyleBackColor = true;
            this.btnGoto.Click += new System.EventHandler(this.btnGoto_Click);
            // 
            // btnSetFrame
            // 
            this.btnSetFrame.Location = new System.Drawing.Point(327, 3);
            this.btnSetFrame.Name = "btnSetFrame";
            this.btnSetFrame.Size = new System.Drawing.Size(75, 23);
            this.btnSetFrame.TabIndex = 4;
            this.btnSetFrame.Text = "Set Frame";
            this.btnSetFrame.UseVisualStyleBackColor = true;
            this.btnSetFrame.Click += new System.EventHandler(this.btnSetFrame_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(3, 3);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(533, 603);
            this.dataGridView.TabIndex = 3;
            // 
            // textBoxInput
            // 
            this.textBoxInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxInput.Location = new System.Drawing.Point(3, 612);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(533, 20);
            this.textBoxInput.TabIndex = 4;
            // 
            // reloadFolderToolStripMenuItem
            // 
            this.reloadFolderToolStripMenuItem.Name = "reloadFolderToolStripMenuItem";
            this.reloadFolderToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.reloadFolderToolStripMenuItem.Text = "Reload Folder";
            this.reloadFolderToolStripMenuItem.Click += new System.EventHandler(this.reloadFolderToolStripMenuItem_Click);
            // 
            // comparitronCoreBindingSource
            // 
            this.comparitronCoreBindingSource.DataSource = typeof(comparitron.ComparitronCore);
            // 
            // statusLabel2
            // 
            this.statusLabel2.Name = "statusLabel2";
            this.statusLabel2.Size = new System.Drawing.Size(118, 17);
            this.statusLabel2.Text = "toolStripStatusLabel1";
            // 
            // statusLabel3
            // 
            this.statusLabel3.Name = "statusLabel3";
            this.statusLabel3.Size = new System.Drawing.Size(118, 17);
            this.statusLabel3.Text = "toolStripStatusLabel2";
            // 
            // statusLabel4
            // 
            this.statusLabel4.Name = "statusLabel4";
            this.statusLabel4.Size = new System.Drawing.Size(72, 17);
            this.statusLabel4.Text = "statusLabel4";
            // 
            // comparisonViewer
            // 
            this.comparisonViewer.BasePath = "";
            this.comparisonViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutLeft.SetColumnSpan(this.comparisonViewer, 2);
            this.comparisonViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comparisonViewer.Frame = 1;
            this.comparisonViewer.Location = new System.Drawing.Point(3, 33);
            this.comparisonViewer.Name = "comparisonViewer";
            this.comparisonViewer.pathBD = "NEW/BD-000001.jpg";
            this.comparisonViewer.pathMX = null;
            this.comparisonViewer.pathTV = "OLD/TV-000001.jpg";
            this.comparisonViewer.settings = null;
            this.comparisonViewer.Size = new System.Drawing.Size(809, 598);
            this.comparisonViewer.Slave = false;
            this.comparisonViewer.TabIndex = 0;
            this.comparisonViewer.TabStop = false;
            this.comparisonViewer.Transition = 50F;
            this.comparisonViewer.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.comparisonViewer_MouseDoubleClick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStripMain);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStripMain;
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "FormMain";
            this.Text = "Comparitron 3000";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel1.PerformLayout();
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.tableLayoutLeft.ResumeLayout(false);
            this.tableLayoutLeft.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackbarFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFade)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comparitronCoreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comparisonViewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutLeft;
        private ComparisonViewer comparisonViewer;
        private System.Windows.Forms.ComboBox comboBoxViewMode;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TrackBar trackbarFrame;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnTrackLeftFar;
        private System.Windows.Forms.Button btnTrackLeft;
        private System.Windows.Forms.Button btnJumpFrame;
        private System.Windows.Forms.Button btnTrackRight;
        private System.Windows.Forms.Button btnTrackRightFar;
        private System.Windows.Forms.ToolStripMenuItem engageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.BindingSource comparitronCoreBindingSource;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnAddCompare;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnAddText;
        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.Button btnAddDivide;
        private System.Windows.Forms.TrackBar trackBarFade;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button btnAddVideo;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnGoto;
        private System.Windows.Forms.Button btnSetFrame;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel1;
        private System.Windows.Forms.FolderBrowserDialog openProjectBrowserDialog;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel4;
    }
}

