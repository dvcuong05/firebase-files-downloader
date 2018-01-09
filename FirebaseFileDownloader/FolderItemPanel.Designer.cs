namespace Main
{
    partial class FolderItemPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FolderItemPanel));
            this.currentTotalLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.folderNameTxt = new System.Windows.Forms.RichTextBox();
            this.totalFileLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // currentTotalLabel
            // 
            this.currentTotalLabel.AutoSize = true;
            this.currentTotalLabel.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTotalLabel.ForeColor = System.Drawing.Color.Crimson;
            this.currentTotalLabel.Location = new System.Drawing.Point(341, 0);
            this.currentTotalLabel.Name = "currentTotalLabel";
            this.currentTotalLabel.Size = new System.Drawing.Size(32, 32);
            this.currentTotalLabel.TabIndex = 1;
            this.currentTotalLabel.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(77, 74);
            this.panel1.TabIndex = 2;
            // 
            // folderNameTxt
            // 
            this.folderNameTxt.BackColor = System.Drawing.Color.White;
            this.folderNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.folderNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folderNameTxt.Location = new System.Drawing.Point(77, 12);
            this.folderNameTxt.Name = "folderNameTxt";
            this.folderNameTxt.Size = new System.Drawing.Size(251, 51);
            this.folderNameTxt.TabIndex = 3;
            this.folderNameTxt.Text = "This is folder name/2017-201/test folder";
            // 
            // totalFileLabel
            // 
            this.totalFileLabel.AutoSize = true;
            this.totalFileLabel.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalFileLabel.ForeColor = System.Drawing.Color.BlueViolet;
            this.totalFileLabel.Location = new System.Drawing.Point(341, 37);
            this.totalFileLabel.Name = "totalFileLabel";
            this.totalFileLabel.Size = new System.Drawing.Size(32, 32);
            this.totalFileLabel.TabIndex = 4;
            this.totalFileLabel.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(334, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "------";
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.progressBar1.Location = new System.Drawing.Point(0, 75);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(407, 12);
            this.progressBar1.Step = 30;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 6;
            this.progressBar1.Visible = false;
            // 
            // FolderItemPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.currentTotalLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.totalFileLabel);
            this.Controls.Add(this.folderNameTxt);
            this.Controls.Add(this.panel1);
            this.Name = "FolderItemPanel";
            this.Size = new System.Drawing.Size(403, 88);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label currentTotalLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox folderNameTxt;
        private System.Windows.Forms.Label totalFileLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}
