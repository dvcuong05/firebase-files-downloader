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
            this.GroupLogin = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.updateStyle = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.stopBtn = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.settingBtn = new System.Windows.Forms.Button();
            this.folderTxt = new System.Windows.Forms.TextBox();
            this.resetBtn = new System.Windows.Forms.Button();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelTop.SuspendLayout();
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
            this.splitContainer.SplitterDistance = 425;
            this.splitContainer.TabIndex = 0;
            // 
            // listItemFlow
            // 
            this.listItemFlow.AutoScroll = true;
            this.listItemFlow.AutoSize = true;
            this.listItemFlow.BackColor = System.Drawing.Color.DimGray;
            this.listItemFlow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.listItemFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listItemFlow.Location = new System.Drawing.Point(0, 109);
            this.listItemFlow.Name = "listItemFlow";
            this.listItemFlow.Size = new System.Drawing.Size(423, 502);
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
            this.panel3.Size = new System.Drawing.Size(423, 120);
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
            this.panelTop.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelTop.Controls.Add(this.GroupLogin);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(423, 109);
            this.panelTop.TabIndex = 13;
            // 
            // GroupLogin
            // 
            this.GroupLogin.BackColor = System.Drawing.Color.Transparent;
            this.GroupLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GroupLogin.Controls.Add(this.label2);
            this.GroupLogin.Controls.Add(this.updateStyle);
            this.GroupLogin.Controls.Add(this.startBtn);
            this.GroupLogin.Controls.Add(this.label1);
            this.GroupLogin.Controls.Add(this.stopBtn);
            this.GroupLogin.Controls.Add(this.label12);
            this.GroupLogin.Controls.Add(this.settingBtn);
            this.GroupLogin.Controls.Add(this.folderTxt);
            this.GroupLogin.Controls.Add(this.resetBtn);
            this.GroupLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GroupLogin.Location = new System.Drawing.Point(4, -1);
            this.GroupLogin.Name = "GroupLogin";
            this.GroupLogin.Size = new System.Drawing.Size(395, 92);
            this.GroupLogin.TabIndex = 10;
            this.GroupLogin.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 29;
            this.label2.Text = "Actions:";
            // 
            // updateStyle
            // 
            this.updateStyle.BackColor = System.Drawing.Color.White;
            this.updateStyle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateStyle.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.updateStyle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateStyle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateStyle.Location = new System.Drawing.Point(322, 41);
            this.updateStyle.Name = "updateStyle";
            this.updateStyle.Size = new System.Drawing.Size(52, 43);
            this.updateStyle.TabIndex = 19;
            this.updateStyle.Text = "Update";
            this.updateStyle.UseVisualStyleBackColor = false;
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.White;
            this.startBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startBtn.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.startBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.startBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.startBtn.Image = ((System.Drawing.Image)(resources.GetObject("startBtn.Image")));
            this.startBtn.Location = new System.Drawing.Point(86, 42);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(52, 42);
            this.startBtn.TabIndex = 0;
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 28;
            this.label1.Text = "Storage Url:";
            // 
            // stopBtn
            // 
            this.stopBtn.BackColor = System.Drawing.Color.White;
            this.stopBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stopBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.stopBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.stopBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.stopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.stopBtn.Image = ((System.Drawing.Image)(resources.GetObject("stopBtn.Image")));
            this.stopBtn.Location = new System.Drawing.Point(263, 42);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(52, 42);
            this.stopBtn.TabIndex = 3;
            this.stopBtn.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(73, 13);
            this.label12.Margin = new System.Windows.Forms.Padding(0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(12, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "*";
            // 
            // settingBtn
            // 
            this.settingBtn.BackColor = System.Drawing.Color.White;
            this.settingBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.settingBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.settingBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.settingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.settingBtn.Image = ((System.Drawing.Image)(resources.GetObject("settingBtn.Image")));
            this.settingBtn.Location = new System.Drawing.Point(204, 42);
            this.settingBtn.Name = "settingBtn";
            this.settingBtn.Size = new System.Drawing.Size(52, 42);
            this.settingBtn.TabIndex = 2;
            this.settingBtn.UseVisualStyleBackColor = false;
            this.settingBtn.Click += new System.EventHandler(this.settingBtn_Click);
            // 
            // folderTxt
            // 
            this.folderTxt.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folderTxt.Location = new System.Drawing.Point(86, 14);
            this.folderTxt.Name = "folderTxt";
            this.folderTxt.Size = new System.Drawing.Size(305, 21);
            this.folderTxt.TabIndex = 0;
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.Color.White;
            this.resetBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.resetBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.resetBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.resetBtn.Image = ((System.Drawing.Image)(resources.GetObject("resetBtn.Image")));
            this.resetBtn.Location = new System.Drawing.Point(145, 42);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(52, 42);
            this.resetBtn.TabIndex = 1;
            this.resetBtn.UseVisualStyleBackColor = false;
            // 
            // folderBrowser
            // 
            this.folderBrowser.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.splitContainer);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Firebase file downloader";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.GroupLogin.ResumeLayout(false);
            this.GroupLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.GroupBox GroupLogin;
        private System.Windows.Forms.TextBox folderTxt;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel listItemFlow;
        private System.Windows.Forms.RichTextBox log;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label totalItemLabel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label totalRemainLabel;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label totalUploadedLabel;
        private System.Windows.Forms.Label label17;
        private Button updateStyle;

        private Button settingBtn;
        private CheckBox shutdownCheckbox;
        private Label label18;
        private CheckBox lockBrowserChecbox;
        private Button copyLogBtn;
        private Label label1;
        private Label label2;
    }
}

