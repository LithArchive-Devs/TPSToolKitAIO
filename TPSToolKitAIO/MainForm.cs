using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
using System.Threading;

namespace TPSToolKitAIO
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnBasic_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists("ModTools\\BasicTools"))
            {
                Directory.CreateDirectory("ModTools\\BasicTools");
            }

            string zip = Path.Combine(Path.GetFullPath("ModTools\\BasicTools"), "BasicTools.zip");
            File.WriteAllBytes(zip, TPSToolKitAIO.Properties.Resources.BasicTools);
            ZipFile.ExtractToDirectory("ModTools\\BasicTools\\BasicTools.zip", "ModTools\\BasicTools");
            Thread.Sleep(500);
            File.Delete("ModTools\\BasicTools\\BasicTools.zip");
        }

        private void btnAllTools_Click(object sender, EventArgs e)
        {
            if(!Directory.Exists("ModTools\\AllTools"))
            {
                Directory.CreateDirectory("ModTools\\AllTools");
            }

            string zip = Path.Combine(Path.GetFullPath("ModTools\\AllTools"), "FullTools.zip");
            File.WriteAllBytes(zip, TPSToolKitAIO.Properties.Resources.FullTools);
            ZipFile.ExtractToDirectory("ModTools\\AllTools\\FullTools.zip", "ModTools\\AllTools");
            Thread.Sleep(500);
            File.Delete("ModTools\\AllTools\\FullTools.zip");
        }

        static void gotoSite(string url)
        {
            System.Diagnostics.Process.Start(url);
        }

        private void lnkMPGH_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            gotoSite("http://mpgh.net");
        }
    }
}
