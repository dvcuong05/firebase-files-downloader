using Main.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class SettingPanel : Form
    {
        private string configStr = "";

        public SettingPanel()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            String filePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\assets\\configs\\config.txt";
            AccountConfig firebaseCfg = new AccountConfig(apiKeyTxt.Text,bucketTxt.Text,emailTxt.Text,passwordTxt.Text,folderTxt.Text);
            configStr = Newtonsoft.Json.JsonConvert.SerializeObject(firebaseCfg);
            File.WriteAllText(filePath, configStr);
            MessageBox.Show("Save config is successfully!!");
        }

        private void SettingPanel_Load(object sender, EventArgs e)
        {
            try
            {
                String filePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\assets\\configs\\config.txt";
                configStr = File.ReadAllText(filePath);
                AccountConfig config = Newtonsoft.Json.JsonConvert.DeserializeObject<AccountConfig>(configStr);
                apiKeyTxt.Text = config.ApiKey;
                bucketTxt.Text = config.Bucket;
                emailTxt.Text = config.AuthEmail;
                passwordTxt.Text = config.AuthPassword;
                folderTxt.Text = config.FirebaseFolder;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Load config is fail:");
            }
        }
    }
}
