using System.Windows.Forms;
namespace Main
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.listItemFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.copyLogBtn = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.lockBrowserChecbox = new System.Windows.Forms.CheckBox();
            this.shutdownCheckbox = new System.Windows.Forms.CheckBox();
            this.label20 = new System.Windows.Forms.Label();
            this.totalRemainLabel = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.totalUploadedLabel = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.totalItemLabel = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.log = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.actionGroup = new System.Windows.Forms.GroupBox();
            this.updateStyle = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.GroupLogin = new System.Windows.Forms.GroupBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.actionGroup.SuspendLayout();
            this.GroupLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.AutoScroll = true;
            this.splitContainer.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.splitContainer.Panel1.Controls.Add(this.listItemFlow);
            this.splitContainer.Panel1.Controls.Add(this.panel3);
            this.splitContainer.Panel1.Controls.Add(this.panelTop);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.AutoScroll = true;
            this.splitContainer.Panel2.BackColor = System.Drawing.SystemColors.Menu;
            this.splitContainer.Size = new System.Drawing.Size(1354, 733);
            this.splitContainer.SplitterDistance = 546;
            this.splitContainer.TabIndex = 0;
            // 
            // listItemFlow
            // 
            this.listItemFlow.AutoScroll = true;
            this.listItemFlow.AutoSize = true;
            this.listItemFlow.BackColor = System.Drawing.Color.DimGray;
            this.listItemFlow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.listItemFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listItemFlow.Location = new System.Drawing.Point(0, 70);
            this.listItemFlow.Name = "listItemFlow";
            this.listItemFlow.Size = new System.Drawing.Size(544, 541);
            this.listItemFlow.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.copyLogBtn);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.lockBrowserChecbox);
            this.panel3.Controls.Add(this.shutdownCheckbox);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.totalRemainLabel);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.totalUploadedLabel);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.totalItemLabel);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.log);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 611);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(544, 120);
            this.panel3.TabIndex = 15;
            // 
            // copyLogBtn
            // 
            this.copyLogBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyLogBtn.Location = new System.Drawing.Point(58, 1);
            this.copyLogBtn.Name = "copyLogBtn";
            this.copyLogBtn.Size = new System.Drawing.Size(66, 25);
            this.copyLogBtn.TabIndex = 37;
            this.copyLogBtn.Text = "copy log";
            this.copyLogBtn.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(23, 102);
            this.label18.Margin = new System.Windows.Forms.Padding(0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(71, 13);
            this.label18.TabIndex = 36;
            this.label18.Text = "Lock browser";
            // 
            // lockBrowserChecbox
            // 
            this.lockBrowserChecbox.AutoSize = true;
            this.lockBrowserChecbox.Location = new System.Drawing.Point(5, 103);
            this.lockBrowserChecbox.Name = "lockBrowserChecbox";
            this.lockBrowserChecbox.Size = new System.Drawing.Size(15, 14);
            this.lockBrowserChecbox.TabIndex = 35;
            this.lockBrowserChecbox.UseVisualStyleBackColor = true;
            // 
            // shutdownCheckbox
            // 
            this.shutdownCheckbox.AutoSize = true;
            this.shutdownCheckbox.Location = new System.Drawing.Point(5, 85);
            this.shutdownCheckbox.Name = "shutdownCheckbox";
            this.shutdownCheckbox.Size = new System.Drawing.Size(125, 17);
            this.shutdownCheckbox.TabIndex = 9;
            this.shutdownCheckbox.Text = "Shutdown after done";
            this.shutdownCheckbox.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(6, 60);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(83, 13);
            this.label20.TabIndex = 8;
            this.label20.Text = "-------------------";
            // 
            // totalRemainLabel
            // 
            this.totalRemainLabel.AutoSize = true;
            this.totalRemainLabel.BackColor = System.Drawing.Color.Transparent;
            this.totalRemainLabel.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalRemainLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.totalRemainLabel.Location = new System.Drawing.Point(69, 70);
            this.totalRemainLabel.Name = "totalRemainLabel";
            this.totalRemainLabel.Size = new System.Drawing.Size(16, 16);
            this.totalRemainLabel.TabIndex = 7;
            this.totalRemainLabel.Text = "0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(5, 71);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(57, 13);
            this.label19.TabIndex = 6;
            this.label19.Text = "Remaining";
            // 
            // totalUploadedLabel
            // 
            this.totalUploadedLabel.AutoSize = true;
            this.totalUploadedLabel.BackColor = System.Drawing.Color.Transparent;
            this.totalUploadedLabel.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalUploadedLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.totalUploadedLabel.Location = new System.Drawing.Point(69, 48);
            this.totalUploadedLabel.Name = "totalUploadedLabel";
            this.totalUploadedLabel.Size = new System.Drawing.Size(16, 16);
            this.totalUploadedLabel.TabIndex = 5;
            this.totalUploadedLabel.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(5, 48);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 13);
            this.label17.TabIndex = 4;
            this.label17.Text = "Uploaded:";
            // 
            // totalItemLabel
            // 
            this.totalItemLabel.AutoSize = true;
            this.totalItemLabel.BackColor = System.Drawing.Color.Transparent;
            this.totalItemLabel.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalItemLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.totalItemLabel.Location = new System.Drawing.Point(69, 28);
            this.totalItemLabel.Name = "totalItemLabel";
            this.totalItemLabel.Size = new System.Drawing.Size(16, 16);
            this.totalItemLabel.TabIndex = 3;
            this.totalItemLabel.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(5, 30);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Total:";
            // 
            // log
            // 
            this.log.BackColor = System.Drawing.SystemColors.Menu;
            this.log.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.log.Location = new System.Drawing.Point(130, 6);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(408, 111);
            this.log.TabIndex = 1;
            this.log.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "STATUS:";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.Controls.Add(this.actionGroup);
            this.panelTop.Controls.Add(this.GroupLogin);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(544, 70);
            this.panelTop.TabIndex = 13;
            // 
            // actionGroup
            // 
            this.actionGroup.BackColor = System.Drawing.Color.Transparent;
            this.actionGroup.Controls.Add(this.updateStyle);
            this.actionGroup.Controls.Add(this.startBtn);
            this.actionGroup.Controls.Add(this.stopBtn);
            this.actionGroup.Controls.Add(this.saveBtn);
            this.actionGroup.Controls.Add(this.resetBtn);
            this.actionGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.actionGroup.ForeColor = System.Drawing.SystemColors.ControlText;
            this.actionGroup.Location = new System.Drawing.Point(240, 1);
            this.actionGroup.Name = "actionGroup";
            this.actionGroup.Size = new System.Drawing.Size(298, 62);
            this.actionGroup.TabIndex = 12;
            this.actionGroup.TabStop = false;
            // 
            // updateStyle
            // 
            this.updateStyle.BackColor = System.Drawing.Color.LimeGreen;
            this.updateStyle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateStyle.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.updateStyle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateStyle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateStyle.Location = new System.Drawing.Point(241, 12);
            this.updateStyle.Name = "updateStyle";
            this.updateStyle.Size = new System.Drawing.Size(52, 43);
            this.updateStyle.TabIndex = 19;
            this.updateStyle.Text = "Update";
            this.updateStyle.UseVisualStyleBackColor = false;
            // 
            // startBtn
            // 
            this.startBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startBtn.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.startBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.startBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.startBtn.Image = ((System.Drawing.Image)(resources.GetObject("startBtn.Image")));
            this.startBtn.Location = new System.Drawing.Point(5, 13);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(52, 42);
            this.startBtn.TabIndex = 0;
            this.startBtn.UseVisualStyleBackColor = false;
            // 
            // stopBtn
            // 
            this.stopBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stopBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.stopBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.stopBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.stopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.stopBtn.Image = ((System.Drawing.Image)(resources.GetObject("stopBtn.Image")));
            this.stopBtn.Location = new System.Drawing.Point(182, 13);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(52, 42);
            this.stopBtn.TabIndex = 3;
            this.stopBtn.UseVisualStyleBackColor = false;
            // 
            // saveBtn
            // 
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.saveBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.saveBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.saveBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveBtn.Image")));
            this.saveBtn.Location = new System.Drawing.Point(123, 13);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(52, 42);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.UseVisualStyleBackColor = false;
            // 
            // resetBtn
            // 
            this.resetBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.resetBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.resetBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.resetBtn.Image = ((System.Drawing.Image)(resources.GetObject("resetBtn.Image")));
            this.resetBtn.Location = new System.Drawing.Point(64, 13);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(52, 42);
            this.resetBtn.TabIndex = 1;
            this.resetBtn.UseVisualStyleBackColor = false;
            // 
            // GroupLogin
            // 
            this.GroupLogin.BackColor = System.Drawing.Color.Transparent;
            this.GroupLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GroupLogin.Controls.Add(this.buttonLogin);
            this.GroupLogin.Controls.Add(this.logoutBtn);
            this.GroupLogin.Controls.Add(this.button3);
            this.GroupLogin.Controls.Add(this.button1);
            this.GroupLogin.Controls.Add(this.label13);
            this.GroupLogin.Controls.Add(this.label12);
            this.GroupLogin.Controls.Add(this.username);
            this.GroupLogin.Controls.Add(this.password);
            this.GroupLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GroupLogin.Location = new System.Drawing.Point(4, -1);
            this.GroupLogin.Name = "GroupLogin";
            this.GroupLogin.Size = new System.Drawing.Size(231, 64);
            this.GroupLogin.TabIndex = 10;
            this.GroupLogin.TabStop = false;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.Green;
            this.buttonLogin.Location = new System.Drawing.Point(168, 14);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(55, 44);
            this.buttonLogin.TabIndex = 2;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.Silver;
            this.logoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutBtn.FlatAppearance.BorderSize = 0;
            this.logoutBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.Color.DarkOrange;
            this.logoutBtn.Location = new System.Drawing.Point(168, 15);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(56, 42);
            this.logoutBtn.TabIndex = 3;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Visible = false;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(-1, 34);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(26, 23);
            this.button3.TabIndex = 11;
            this.button3.TabStop = false;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(-1, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 23);
            this.button1.TabIndex = 10;
            this.button1.TabStop = false;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(26, 39);
            this.label13.Margin = new System.Windows.Forms.Padding(0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(12, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(26, 14);
            this.label12.Margin = new System.Windows.Forms.Padding(0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(12, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "*";
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(40, 13);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(124, 21);
            this.username.TabIndex = 0;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(40, 36);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(124, 21);
            this.password.TabIndex = 1;
            // 
            // folderBrowser
            // 
            this.folderBrowser.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // timer
            // 
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.splitContainer);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teescape auto uploader";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.actionGroup.ResumeLayout(false);
            this.GroupLogin.ResumeLayout(false);
            this.GroupLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.GroupBox actionGroup;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.GroupBox GroupLogin;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel listItemFlow;
        private System.Windows.Forms.RichTextBox log;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label totalItemLabel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label totalRemainLabel;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label totalUploadedLabel;
        private System.Windows.Forms.Label label17;
        private Button button3;
        private Button button1;
        private Button logoutBtn;
        private Button updateStyle;

        private Button saveBtn;
        private CheckBox shutdownCheckbox;
        private Label label18;
        private CheckBox lockBrowserChecbox;
        private Button copyLogBtn;
        private Timer timer;
    }
}

