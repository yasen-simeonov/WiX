using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;

namespace ReplaceXMLcSharpNet
{
    public partial class Form1 : Form
    {
        string sSelectedFile;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowseXMLfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog chooseFileDialog = new OpenFileDialog();
            chooseFileDialog.Filter = "Config files (*.config)|*.config";
            chooseFileDialog.FilterIndex = 1;
            chooseFileDialog.Multiselect = false;

            if (chooseFileDialog.ShowDialog() == DialogResult.OK)
            {
                sSelectedFile = chooseFileDialog.FileName;
            }
            else
            {
                sSelectedFile = string.Empty;
            }

            tbXMLfilePath.Text = sSelectedFile;
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            string oldText = System.IO.File.ReadAllText(tbXMLfilePath.Text.ToString());
            string newText1 = oldText.Replace("http://domaincloud.cloudapp.net:80/Xadd", "http://kvotonapisha.lala.po:802/XaddService");
            string newText2 = newText1.Replace("net.tcp://dController.yas.brill.com:8002/Xadd", "Deebamaikamudeeba");
            File.WriteAllText(tbXMLfilePath.Text.ToString(), newText2, Encoding.UTF8);

        }
    }
}
