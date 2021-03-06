﻿using System;
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
            try
            {
                this.totalFileLabel.Text = totalFiles.ToString();
                this.currentTotalLabel.Text = currentTotalFiles.ToString();
            }
            catch(Exception e) {
                Console.WriteLine("updateTotals has exception:" + e.Message);
            }
        }

        public void changeProgressbarState(bool isShow)
        {
            try
            {
                this.progressBar1.Visible = isShow;
            }
            catch (Exception e)
            {
                Console.WriteLine("changeProgressbarState has exception:"+e.Message);
            }
        }

        public void updateBackground(Color color)
        {
            
            try
            {
                this.BackColor = color;
                this.folderNameTxt.BackColor = color;
            }
            catch (Exception e)
            {
                Console.WriteLine("updateBackground has exception:" + e.Message);
            }
        }

    }
}
