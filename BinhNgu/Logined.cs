using ServiceHub.Host.CLR.x64;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KeyAuth;
using System.Diagnostics;
using System.Threading;
using System.Net;

namespace ServiceHub.Host.CLR.x64
{
    public partial class Logined : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        public static api KeyAuthApp = new api(
            name: "TPER 1407",
            ownerid: "UeZalCYDRx",
            secret: "ec7fb533e8828687788fbcd1d4ddf079b5fea7ea07d1540bd9ff5728a25329eb",
            version: "1.0"
            );
        public Logined()
        {
            InitializeComponent();

        }
        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void panelTop_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {

            KeyAuthApp.login(txbusername.Text, txbpassword.Text);
            if (KeyAuthApp.response.success)
            {
                Max main = new Max();
                main.Show();
                this.Hide();
            }
                
        }

        private void Logined_Load(object sender, EventArgs e)
        {
            KeyAuthApp.init();

            if (KeyAuthApp.response.message == "invalidver")
            {
                if (!string.IsNullOrEmpty(KeyAuthApp.app_data.downloadLink))
                {
                    DialogResult dialogResult = MessageBox.Show("Yes to open file in browser\nNo to download file automatically", "Auto update", MessageBoxButtons.YesNo);
                    switch (dialogResult)
                    {
                        case DialogResult.Yes:
                            Process.Start(KeyAuthApp.app_data.downloadLink);
                            Environment.Exit(0);
                            break;
                        case DialogResult.No:
                            WebClient webClient = new WebClient();
                            string destFile = Application.ExecutablePath;

                            string bolt = Noone();

                            destFile = destFile.Replace(".exe", $"-{bolt}.exe");
                            webClient.DownloadFile(KeyAuthApp.app_data.downloadLink, destFile);

                            Process.Start(destFile);
                            Process.Start(new ProcessStartInfo()
                            {
                                Arguments = "/C choice /C Y /N /D Y /T 3 & Del \"" + Application.ExecutablePath + "\"",
                                WindowStyle = ProcessWindowStyle.Hidden,
                                CreateNoWindow = true,
                                FileName = "cmd.exe"
                            });
                            Environment.Exit(0);

                            break;
                        default:
                            MessageBox.Show("Invalid option");
                            Environment.Exit(0);
                            break;
                    }
                }
                MessageBox.Show("Version of this program does not match the one online. Furthermore, the download link online isn't set. You will need to manually obtain the download link from the developer");
                Thread.Sleep(2500);
                Environment.Exit(0);
            }
            if (!KeyAuthApp.response.success)
            {
                MessageBox.Show(KeyAuthApp.response.message);
                Environment.Exit(0);
            }
            // if(KeyAuthApp.checkblack())
            // {
            //     MessageBox.Show("user is blacklisted");
            // }
            // else
            // {
            //     MessageBox.Show("user is not blacklisted");
            // }
            KeyAuthApp.check();
        }
        static string Noone()
        {
            string str = null;

            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                str += Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65))).ToString();
            }
            return str;

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/mvb18032006");
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/lengendvn");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
        KeyAuthApp.login(txbusername.Text, txbpassword.Text);
            if (KeyAuthApp.response.success)
            {
                Max main = new Max();
                main.Show();
                this.Hide();
            }
        }

        private void txbusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbpassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
