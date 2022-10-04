using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Net;
using Memory;
using System.Diagnostics;
using System.Management;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.Devices;
using static Guna.UI2.WinForms.Suite.Descriptions;

namespace ServiceHub.Host.CLR.x64
{
    public partial class Support : Form
    {
        public Support()
        {
            InitializeComponent();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
       

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/lengendvn");
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/mvb18032006");
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {


        }
    }
}
