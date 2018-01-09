using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class FolderItemPanel : UserControl
    {
        public FolderItemPanel(string folderName, int totalFile)
        {
            InitializeComponent();
            this.folderNameTxt.Text = folderName;
            this.totalFileLabel.Text = totalFile.ToString();
            this.BackColor = Color.Silver;
            this.folderNameTxt.BackColor = Color.Silver;
        }

        public void updateTotals(int totalFiles,  int currentTotalFiles)
        {
            this.totalFileLabel.Text = totalFiles.ToString();
            this.currentTotalLabel.Text = currentTotalFiles.ToString();
        }

        public void changeProgressbarState(bool isShow)
        {
            this.progressBar1.Visible = isShow;
        }

        public void updateBackground(Color color)
        {
            this.BackColor = color;
            this.folderNameTxt.BackColor = color;
        }

    }
}
