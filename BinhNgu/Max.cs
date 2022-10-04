using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;
using Helper;
using System.Runtime.InteropServices;
using System.Threading;
using System.Management;
using Microsoft.VisualBasic.Devices;
using System.Diagnostics;
using DiscordRPC;
using Runtime.Broker;
using KeyAuth;
using DiscordRPC;
using DiscordRPC.Logging;
using System.Net;
using ServiceHub.Host.CLR.x64;

namespace ServiceHub.Host.CLR.x64
{
    public partial class Max : Form
    {
        KeyHelper kh = new KeyHelper();
        bool shift;
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        public static api KeyAuthApp = new api(
            name: "TPER 1407",
            ownerid: "UeZalCYDRx",
            secret: "ec7fb533e8828687788fbcd1d4ddf079b5fea7ea07d1540bd9ff5728a25329eb",
            version: "1.0"
            );
        public Max()
        {
            InitializeComponent();
            kh.KeyDown += Kh_KeyDown;
            kh.KeyUp += Kh_KeyUp;
        }
        public bool keyhide = true;
        public static bool IsAlreadyRunning = false;
        private WebClient webClient = new WebClient();
        private void Kh_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.LShiftKey || e.KeyCode == Keys.RShiftKey) shift = false;

        }

        private void Kh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.End)
            {
                Environment.Exit(0);
            }
            if (e.KeyCode == Keys.Home)
            {
                if (keyhide == false)
                {
                    this.Hide();
                    keyhide = true;
                }
                else
                {
                    this.Show();
                    keyhide = false;
                }
            }
            if (e.KeyCode == Keys.LShiftKey || e.KeyCode == Keys.RShiftKey) shift = true;
            if (shift == true && e.KeyCode == Keys.Delete)
            {
                Environment.Exit(0);
            }
            if (shift == true && e.KeyCode == Keys.PageDown)

            {

                this.Hide();


            }
            if (shift == true && e.KeyCode == Keys.PageUp)
            {

                this.Show();

                if (shift == true && e.KeyCode == Keys.F1)
                {
                    PSPS.Text = "đang kết nối...";
                    PSPS.ForeColor = Color.Orange;
                    DRIERSSSS_LOAD_AUTO_IN_PROCESSS("NORECOIL");
                }
                if (shift == true && e.KeyCode == Keys.F2)
                {
                    PSPS.Text = "đang kết nối...";
                    PSPS.ForeColor = Color.Orange;
                    DRIERSSSS_LOAD_AUTO_IN_PROCESSS("AIMLOCKV2");
                }
                if (shift == true && e.KeyCode == Keys.F3)
                {
                    PSPS.Text = "đang kết nối...";
                    PSPS.ForeColor = Color.Orange;
                    DRIERSSSS_LOAD_AUTO_IN_PROCESSS("AIMFOV");
                }
                if (shift == true && e.KeyCode == Keys.F4)
                {
                    PSPS.Text = "đang kết nối...";
                    PSPS.ForeColor = Color.Orange;
                    DRIERSSSS_LOAD_AUTO_IN_PROCESSS("BYPASS");
                }
                if (shift == true && e.KeyCode == Keys.F5)
                {
                    PSPS.Text = "đang kết nối...";
                    PSPS.ForeColor = Color.Orange;
                    DRIERSSSS_LOAD_AUTO_IN_PROCESSS("AIMBOT");
                }
                if (shift == true && e.KeyCode == Keys.F6)
                {
                    PSPS.Text = "đang kết nối...";
                    PSPS.ForeColor = Color.Orange;
                    DRIERSSSS_LOAD_AUTO_IN_PROCESSS("AIMNECKV2");
                }
                if (shift == true && e.KeyCode == Keys.F7)
                {
                    PSPS.Text = "đang kết nối...";
                    PSPS.ForeColor = Color.Orange;
                    DRIERSSSS_LOAD_AUTO_IN_PROCESSS("AIMLOCK");
                }
                if (shift == true && e.KeyCode == Keys.F8)
                {
                    PSPS.Text = "đang kết nối...";
                    PSPS.ForeColor = Color.Orange;
                    DRIERSSSS_LOAD_AUTO_IN_PROCESSS("EXACTLY");
                }
                if (shift == true && e.KeyCode == Keys.F9)
                {
                    PSPS.Text = "đang kết nối...";
                    PSPS.ForeColor = Color.Orange;
                    DRIERSSSS_LOAD_AUTO_IN_PROCESSS("MAGICBULLET");
                }
                if (shift == true && e.KeyCode == Keys.F10)
                {
                    PSPS.Text = "đang kết nối...";
                    PSPS.ForeColor = Color.Orange;
                    DRIERSSSS_LOAD_AUTO_IN_PROCESSS("SENSI");
                }
                if (shift == true && e.KeyCode == Keys.P)
                {
                    PSPS.Text = "đang kết nối...";
                    PSPS.ForeColor = Color.Orange;
                    DRIERSSSS_LOAD_AUTO_IN_PROCESSS("SPEED1");
                }
                if (shift == true && e.KeyCode == Keys.J)
                {
                    PSPS.Text = "đang kết nối...";
                    PSPS.ForeColor = Color.Orange;
                    DRIERSSSS_LOAD_AUTO_IN_PROCESSS("AIMFOVLEFT");
                }
                if (shift == true && e.KeyCode == Keys.K)
                {
                    PSPS.Text = "đang kết nối...";
                    PSPS.ForeColor = Color.Orange;
                    DRIERSSSS_LOAD_AUTO_IN_PROCESSS("AIMFOVRIGHT");
                }
                if (shift == true && e.KeyCode == Keys.L)
                {
                    PSPS.Text = "đang kết nối...";
                    PSPS.ForeColor = Color.Orange;
                    DRIERSSSS_LOAD_AUTO_IN_PROCESSS("AIMFOVUP");
                }


            }
        }

        [DllImport("KERNEL32.DLL")]
        public static extern IntPtr CreateToolhelp32Snapshot(uint flags, uint processid);
        [DllImport("KERNEL32.DLL")]
        public static extern int Process32First(IntPtr handle, ref ProcessEntry32 pe);
        [DllImport("KERNEL32.DLL")]
        public static extern int Process32Next(IntPtr handle, ref ProcessEntry32 pe);

        private async Task PutTaskDelay(int Time)
        {
            await Task.Delay(Time);
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
        private async Task<IntPtr> FUCK_IS_ALWAYS_REAL(string type)
        {
            string Bluestacks = "HD-Player";
            string Bluestack2 = "HD-Player.exe";
            string memu = "MEmuHeadless";
            string Gameloop = "aow_exe";
            string SmartGaGA = "AndroidProcess.exe";
            string ld = "LdVBoxHeadless.exe";
            IntPtr intPtr = IntPtr.Zero;
            uint num = 0u;
            IntPtr intPtr2 = CreateToolhelp32Snapshot(2u, 0u);
            if ((int)intPtr2 > 0)
            {
                ProcessEntry32 processEntry = default(ProcessEntry32);
                processEntry.dwSize = (uint)Marshal.SizeOf(processEntry);
                for (int num2 = Process32First(intPtr2, ref processEntry); num2 == 1; num2 = Process32Next(intPtr2, ref processEntry))
                {
                    IntPtr intPtr3 = Marshal.AllocHGlobal((int)processEntry.dwSize);
                    Marshal.StructureToPtr(processEntry, intPtr3, fDeleteOld: true);
                    ProcessEntry32 processEntry2 = (ProcessEntry32)Marshal.PtrToStructure(intPtr3, typeof(ProcessEntry32));
                    Marshal.FreeHGlobal(intPtr3);
                    if (processEntry2.szExeFile.Contains(Bluestacks) && processEntry2.cntThreads > num)
                    {
                        num = processEntry2.cntThreads;
                        intPtr = (IntPtr)processEntry2.th32ProcessID;
                    }
                    if (processEntry2.szExeFile.Contains(memu) && processEntry2.cntThreads > num)
                    {
                        num = processEntry2.cntThreads;
                        intPtr = (IntPtr)processEntry2.th32ProcessID;
                    }
                    if (processEntry2.szExeFile.Contains(Gameloop) && processEntry2.cntThreads > num)
                    {
                        num = processEntry2.cntThreads;
                        intPtr = (IntPtr)processEntry2.th32ProcessID;
                    }
                    if (processEntry2.szExeFile.Contains(Bluestack2) && processEntry2.cntThreads > num)
                    {
                        num = processEntry2.cntThreads;
                        intPtr = (IntPtr)processEntry2.th32ProcessID;
                    }
                    if (processEntry2.szExeFile.Contains(SmartGaGA) && processEntry2.cntThreads > num)
                    {
                        num = processEntry2.cntThreads;
                        intPtr = (IntPtr)processEntry2.th32ProcessID;
                    }
                    if (processEntry2.szExeFile.Contains(ld) && processEntry2.cntThreads > num)
                    {
                        num = processEntry2.cntThreads;
                        intPtr = (IntPtr)processEntry2.th32ProcessID;
                    }
                }
                PID.Text = Convert.ToString(intPtr);
                await PutTaskDelay(1000);
                if (type == "BYPASS")
                {
                    {
                        changeMEMORY("MEEgMDAgQTAgRTMgRUYgNDkgRUQgRUIgMDAgNTAgQTAgRTEgOTAgMDAgOUYgRTU=", "MDAgRjAgMjAgRTM=");
                    }
                }
                else if (type == "ONLYRED")
                {
                    ONLYRED();
                }
                else if (type == "AIMFOV")
                {
                    AIMFOV();
                }
                else if (type == "ANTENAV1")
                {
                    ANTENAV1();
                }
                else if (type == "BYPASS2")
                {
                    BYPASS2();
                }
                else if (type == "antiban2")
                {
                    antiban2();
                }
                else if (type == "AIMBOT")
                {
                    AIMBOT();
                }
                else if (type == "AIMBOTON")
                {
                    AIMBOTON();
                }
                else if (type == "AIMNECKON")
                {
                    AIMNECKON();
                }
                else if (type == "NECK")
                {
                    NECK();
                }
                else if (type == "EX1")
                {
                    EX1();
                }
                else if (type == "EX2")
                {
                    EX2();
                }
                else if (type == "MAGICBULLET")
                {
                    MAGICBULLET();
                }
                switch (type)
                {
                    case "aimbotV2":
                        ApplyAOB("62 00 6F 00 6E 00 65 00 5F 00 48 00 69 00 70 00 73 00 00 00 ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? 00 00 00 00 09 00 00 00 62 00 6F 00 6E 00 65 00 5F 00 ?? 00 65 00 ?? 00 ?? 00 00 00 ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? 00 79 00 74 00 65 00 73 00 ?? 00 6E 00 6B 00 6E 00 6F 00 77 00 6E", "62 00 6F 00 6E 00 65 00 5F 00 48 00 65 00 61 00 64");
                        break;
                    case "aimbotscope":
                        ApplyAOB("A0 42 00 00 C0 3F 33 33 13 40 00 00 C0 3F 00 00 80 3F", "A0 42 00 00 C0 3F E0 B1 FF FF 00 00 C0 3F 00 00 80 3F");
                        break;
                    case "aimfov":                     //SCAN                                                                         //REPLACE
                        ApplyAOB("AE 47 01 3F", "80 7B E1 FF FF FF FF FF");
                        break;
                    case "bypassfull":
                        ApplyAOB("05 02 C9 03 C9 03", "54 01");
                        break;
                    case "bypassantiban":
                        ApplyAOB("00 04 00 04 00 04 00 04 00 04 00 04 00 04 00 04 00 04 00 04 00 04 00 04 00 04 00 04 00 04 00 04", "00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00");
                        break;
                    case "bypassranked":
                        ApplyAOB("01 03 00 04 01 03 00 04 01 03 00 04 01 03 00 04 01 03 00 04 01 03 00 04 01 03 00 04 01 03 00 04 01 03 00 04", "01 01 00 00 01 01 00 00 01 01 00 00 01 01 00 00 01 01 00 00 01 01 00 00 01 01 00 00 01 01 00 00 01 01 00 00");
                        break;
                    case "aimlock":
                        ApplyAOB("7F 45 4C 46 01 01 01 00", "70 4C 2D E9 10 B0 8D E1");
                        break;
                    case "aimlockV2":
                        ApplyAOB("30 19 8F 05", "D0 64 C1 00");
                        break;
                    case "aimlockV3":
                        ApplyAOB("7F 45 4C 46 01 01 01 00", "70 4C 2D E9 10 B0 8D E1");
                        break;
                    case "sensymax":
                        ApplyAOB("00 00 96 43", "00 00 48 42");
                        break;
                    case "sensymin":
                        ApplyAOB("00 00 96 43", "00 00 C6 42");
                        break;
                    case "onlyred":
                        ApplyAOB("96 00 00 00 00 00 B8 40 00 00 00 00 00 00 00 00", "96 00 00 00 00 00 B0 40 00 00 80 3F 00 00 40 3F");
                        break;
                    case "norecoil":
                        ApplyAOB("00 0A 81 EE 10 0A 10 EE 10 8C BD E8 00 00 7A 44 F0 48 2D E9 10 B0 8D E2 02 8B 2D ED", "00 0A 81 EE 10 0A 10 EE 10 8C BD E8 00 00 00 00 F0 48 2D E9 10 B0 8D E2 02 8B 2D ED");
                        break;
                    case "sensypro":
                        ApplyAOB("DB 0F 49 40 DB 0F 49 40", "00 00 A0 40 00 00 A0 40");
                        break;
                    case "fakedame":
                        ApplyAOB("00 00 B0 40 00 00 80 3F 00 00 40 3F", "CD CC 47 42 CD CC 47 42 CD CC 47 42");
                        break;
                    case "exactly":
                        ApplyAOB("00 00 70 41 00 00 0C 42 00 00 20 41 00 00 A0 41", "00 00 71 41 00 00 0F 38 00 00 72 41 00 00 47 45");
                        break;
                    case "aimneck":
                        ApplyAOB("53 41 42 4C 45 5F 53 68 61 64 6F 77 49 6E 74 65 6E 73 69 79 62 6F 6E 65 5F 48 69 70 73", "53 41 42 4C 45 5F 53 68 61 64 6F 77 49 6E 74 65 6E 73 69 79 62 6f 6e 65 5f 4e 65 63 6b");
                        break;
                    case "crosshairhd":
                        ApplyAOB("00 00 00 00 00 00 80 3F 00 00 80 3F 00 00 80 3F 00 00 00 3F 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 3F", "00 00 00 00 00 00 80 3F 00 00 80 3F 00 00 80 3F 00 00 20 41 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 20 41");
                        break;
                    case "antenafemale":
                        ApplyAOB("CD 1F F4 BC 00 00 80 3F", "CD 1F F4 BC CD AC EE 44");
                        break;
                    case "antenamale":
                        ApplyAOB("0E 34 B9 3D 00 00 80 3F", "0E 34 B9 3D CD AC EE 44");
                        break;
                    case "esp":                     //SCAN                                                                         //REPLACE
                        ApplyAOB("69 00 6E 00 67 00 61 00 6D 00 65 00 2F 00 63 00 61 00 70 00 73 00 75 00 6C 00 65 00 68 00 75 00 6D 00 61 00 6E 00 73 00 6E 00 69 00 70 00 65 00 72 00 63 00 6F 00 6C 00 6C 00 69 00 64 00 65 00 72 00", "65 00 66 00 66 00 65 00 63 00 74 00 73 00 2F 00 62 00 72 00 5F 00 61 00 69 00 72 00 64 00 72 00 6F 00 70 00 6C 00 69 00 67 00 68 00 74 00 6C 00 65 00 76 00 65 00 6C 00 31 00 00 00 00 00 00 00 00 00");
                        break;
                    case "antiban":
                        ApplyAOB("0A 00 A0 E3 3B E3 FF EB 00 00 94 E5 9C E0 FF EB", "00 F0 20 E3");
                        break;
                    case "fly":
                        ApplyAOB("0A D7 A3 3D 9A 99 99 3E", "00 00 A0 40 00 00 A0 40");
                        break;
                    case "magicbullet":
                        ApplyAOB("18 D0 8D E2 70 80 BD E8 B8 19 8B 00 AC C5 27 37 30 48 2D E9 01 40 A0 E1", "18 D0 8D E2 70 80 BD E8 B8 19 8B 00 00 00 80 3F 30 48 2D E9 01 40 A0 E1");
                        break;
                    case "godview":
                        ApplyAOB("1F 85 AB 3F 00 00 80 3F 00 00 80 3F CD CC CC 3F 8F C2", "00 00 00 41 00 00 80 3F 00 00 80 3F CD CC CC 3F 8F C2");
                        break;
                    case "increasedvision":
                        ApplyAOB("DB 0F 49 40 10 2A 00 EE 00 10 80 E5 10 3A 01 EE", "00 00 A0 40 10 2A 00 EE 00 10 80 E5 10 3A 01 EE");
                        break;
                    case "medkitrun":
                        ApplyAOB("8C 4C B3 02 70 4A B3 02 F0 4D 2D E9 18 B0 8D E2 10 D0 4D E2", "8C 4C B3 02 70 4A B3 02 00 00 A0 E3 1E FF 2F E1 10 D0 4D E2");
                        ApplyAOB("36 FE FF EA 30 48 2D E9 08 B0 8D E2 00 40 A0 E1 95 01 01 E3 00 10 A0 E3", "36 FE FF EA 00 00 A0 E3 1E FF 2F E1 00 40 A0 E1 95 01 01 E3 00 10 A0 E3");
                        break;
                    case "fastfire":
                        ApplyAOB("CD CC 4C 3E", "00 00 80 BF");
                        break;
                    case "climbwall":
                        ApplyAOB("9A 99 99 3E 00 00 00 00 00 00 00 00 00 00 00 00 00 01 00 01 00 00 00 00", "00 3C 1C 46 00 00 00 00 00 00 00 00 00 00 00 00 00 01 00 01 00 00 00 00");
                        break;
                    case "blacksky":
                        ApplyAOB("A4 70 7D 3F 3A CD 13 3F 0A D7 23 3C BD 37 86 35 00 00 51 E3 04 10 91 15", "A4 70 7D 3F 3A CD 13 3F 0A D7 23 3C 00 00 80 BF 00 00 51 E3 04 10 91 15");
                        break;
                    case "eagleeye":
                        ApplyAOB("1F 85 AB 3F 00 00 80 3F 00 00 80 3F CD CC CC 3F 8F C2", "00 00 00 41 00 00 80 3F 00 00 80 3F CD CC CC 3F 8F C2");
                        break;
                    case "speed2x":
                        ApplyAOB("00 00 80 3F AB AA AA 3E 8F C2 F5 3C", "00 00 00 40 AB AA AA 3E 8F C2 F5 3C");
                        break;
                    case "speed3x":
                        ApplyAOB("00 00 80 3F AB AA AA 3E 8F C2 F5 3C", "00 00 40 40 AB AA AA 3E 8F C2 F5 3C");
                        break;
                    case "speed4x":
                        ApplyAOB("00 00 80 3F AB AA AA 3E 8F C2 F5 3C", "00 00 80 40 AB AA AA 3E 8F C2 F5 3C");
                        break;
                    case "speed5x":
                        ApplyAOB("00 00 80 3F AB AA AA 3E 8F C2 F5 3C", "00 00 A0 40 AB AA AA 3E 8F C2 F5 3C");
                        break;
                    case "medikitfast":
                        ApplyAOB("4B 00 00 00 00 00 A0 40 00 00 80 40", "4B 00 00 00 00 00 A0 40 00 00 40 40");
                        break;
                    case "camera4x":
                        ApplyAOB("00 00 80 3F AB AA AA 3E 8F C2 F5 3C", "00 00 80 40 AB AA AA 3E 8F C2 F5 3C");
                        break;
                    case "oaimbotV2":
                        ApplyAOB("62 00 6F 00 6E 00 65 00 5F 00 48 00 65 00 61 00 64", "62 00 6F 00 6E 00 65 00 5F 00 48 00 69 00 70 00 73 00 00 00 ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? 00 00 00 00 09 00 00 00 62 00 6F 00 6E 00 65 00 5F 00 ?? 00 65 00 ?? 00 ?? 00 00 00 ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? 00 79 00 74 00 65 00 73 00 ?? 00 6E 00 6B 00 6E 00 6F 00 77 00 6E");
                        break;
                    case "oaimbotscope":
                        ApplyAOB("A0 42 00 00 C0 3F E0 B1 FF FF 00 00 C0 3F 00 00 80 3F", "A0 42 00 00 C0 3F 33 33 13 40 00 00 C0 3F 00 00 80 3F");
                        break;
                    case "oaimfov":                     //SCAN                                                                         //REPLACE
                        ApplyAOB("80 7B E1 FF FF FF FF FF", "AE 47 01 3F");
                        break;
                    case "obypassfull":
                        ApplyAOB("54 01", "05 02 C9 03 C9 03");
                        break;
                    case "obypassantiban":
                        ApplyAOB("00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00", "00 04 00 04 00 04 00 04 00 04 00 04 00 04 00 04 00 04 00 04 00 04 00 04 00 04 00 04 00 04 00 04");
                        break;
                    case "obypassranked":
                        ApplyAOB("01 01 00 00 01 01 00 00 01 01 00 00 01 01 00 00 01 01 00 00 01 01 00 00 01 01 00 00 01 01 00 00 01 01 00 00", "01 03 00 04 01 03 00 04 01 03 00 04 01 03 00 04 01 03 00 04 01 03 00 04 01 03 00 04 01 03 00 04 01 03 00 04");
                        break;
                    case "oaimlock":
                        ApplyAOB("70 4C 2D E9 10 B0 8D E1", "7F 45 4C 46 01 01 01 00");
                        break;
                    case "oaimlockV2":
                        ApplyAOB("D0 64 C1 00", "30 19 8F 05");
                        break;
                    case "oaimlockV3":
                        ApplyAOB("70 4C 2D E9 10 B0 8D E1", "7F 45 4C 46 01 01 01 00");
                        break;
                    case "osensymax":
                        ApplyAOB("00 00 48 42", "00 00 96 43");
                        break;
                    case "osensymin":
                        ApplyAOB("00 00 C6 42", "00 00 96 43");
                        break;
                    case "oonlyred":
                        ApplyAOB("96 00 00 00 00 00 B0 40 00 00 80 3F 00 00 40 3F", "96 00 00 00 00 00 B8 40 00 00 00 00 00 00 00 00");
                        break;
                    case "onorecoil":
                        ApplyAOB("00 0A 81 EE 10 0A 10 EE 10 8C BD E8 00 00 7A 44 F0 48 2D E9 10 B0 8D E2 02 8B 2D ED", "00 0A 81 EE 10 0A 10 EE 10 8C BD E8 00 00 00 00 F0 48 2D E9 10 B0 8D E2 02 8B 2D ED");
                        break;
                    case "osensypro":
                        ApplyAOB("00 00 A0 40 00 00 A0 40", "DB 0F 49 40 DB 0F 49 40");
                        break;
                    case "ofakedam":
                        ApplyAOB("CD CC 47 42 CD CC 47 42 CD CC 47 42", "00 00 B0 40 00 00 80 3F 00 00 40 3F");
                        break;
                    case "oexactly":
                        ApplyAOB("00 00 71 41 00 00 0F 38 00 00 72 41 00 00 47 45", "00 00 70 41 00 00 0C 42 00 00 20 41 00 00 A0 41");
                        break;
                    case "oaimneck":
                        ApplyAOB("53 41 42 4C 45 5F 53 68 61 64 6F 77 49 6E 74 65 6E 73 69 79 62 6f 6e 65 5f 4e 65 63 6b", "53 41 42 4C 45 5F 53 68 61 64 6F 77 49 6E 74 65 6E 73 69 79 62 6F 6E 65 5F 48 69 70 73");
                        break;
                    case "ocrosshairhd":
                        ApplyAOB("00 00 00 00 00 00 80 3F 00 00 80 3F 00 00 80 3F 00 00 20 41 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 20 41", "00 00 00 00 00 00 80 3F 00 00 80 3F 00 00 80 3F 00 00 00 3F 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 00 3F");
                        break;
                    case "oantenafemale":
                        ApplyAOB("CD 1F F4 BC CD AC EE 44", "CD 1F F4 BC 00 00 80 3F");
                        break;
                    case "oantenamale":
                        ApplyAOB("0E 34 B9 3D CD AC EE 44", "0E 34 B9 3D 00 00 80 3F");
                        break;
                    case "oesp":                     //SCAN                                                                         //REPLACE
                        ApplyAOB("65 00 66 00 66 00 65 00 63 00 74 00 73 00 2F 00 62 00 72 00 5F 00 61 00 69 00 72 00 64 00 72 00 6F 00 70 00 6C 00 69 00 67 00 68 00 74 00 6C 00 65 00 76 00 65 00 6C 00 31 00 00 00 00 00 00 00 00 00", "69 00 6E 00 67 00 61 00 6D 00 65 00 2F 00 63 00 61 00 70 00 73 00 75 00 6C 00 65 00 68 00 75 00 6D 00 61 00 6E 00 73 00 6E 00 69 00 70 00 65 00 72 00 63 00 6F 00 6C 00 6C 00 69 00 64 00 65 00 72 00");
                        break;
                    case "ofly":
                        ApplyAOB("00 00 A0 40 00 00 A0 40", "0A D7 A3 3D 9A 99 99 3E");
                        break;
                    case "omagicbullet":
                        ApplyAOB("18 D0 8D E2 70 80 BD E8 B8 19 8B 00 00 00 80 3F 30 48 2D E9 01 40 A0 E1", "18 D0 8D E2 70 80 BD E8 B8 19 8B 00 AC C5 27 37 30 48 2D E9 01 40 A0 E1");
                        break;
                    case "ogodview":
                        ApplyAOB("00 00 00 41 00 00 80 3F 00 00 80 3F CD CC CC 3F 8F C2", "1F 85 AB 3F 00 00 80 3F 00 00 80 3F CD CC CC 3F 8F C2");
                        break;
                    case "oincreasedvision":
                        ApplyAOB("00 00 A0 40 10 2A 00 EE 00 10 80 E5 10 3A 01 EE", "DB 0F 49 40 10 2A 00 EE 00 10 80 E5 10 3A 01 EE");
                        break;
                    case "omedkitrun":
                        ApplyAOB("8C 4C B3 02 70 4A B3 02 00 00 A0 E3 1E FF 2F E1 10 D0 4D E2", "8C 4C B3 02 70 4A B3 02 F0 4D 2D E9 18 B0 8D E2 10 D0 4D E2");
                        ApplyAOB("36 FE FF EA 00 00 A0 E3 1E FF 2F E1 00 40 A0 E1 95 01 01 E3 00 10 A0 E3", "36 FE FF EA 30 48 2D E9 08 B0 8D E2 00 40 A0 E1 95 01 01 E3 00 10 A0 E3");
                        break;
                    case "ofastfire":
                        ApplyAOB("CD CC 4C 3E", "00 00 80 BF");
                        break;
                    case "oclimbwall":
                        ApplyAOB("00 3C 1C 46 00 00 00 00 00 00 00 00 00 00 00 00 00 01 00 01 00 00 00 00", "9A 99 99 3E 00 00 00 00 00 00 00 00 00 00 00 00 00 01 00 01 00 00 00 00");
                        break;
                    case "oblacksky":
                        ApplyAOB("A4 70 7D 3F 3A CD 13 3F 0A D7 23 3C 00 00 80 BF 00 00 51 E3 04 10 91 15", "A4 70 7D 3F 3A CD 13 3F 0A D7 23 3C BD 37 86 35 00 00 51 E3 04 10 91 15");
                        break;
                    case "oeagleeye":
                        ApplyAOB("00 00 00 41 00 00 80 3F 00 00 80 3F CD CC CC 3F 8F C2", "1F 85 AB 3F 00 00 80 3F 00 00 80 3F CD CC CC 3F 8F C2");
                        break;
                    case "ospeed2x":
                        ApplyAOB("00 00 00 40 AB AA AA 3E 8F C2 F5 3C", "00 00 80 3F AB AA AA 3E 8F C2 F5 3C");
                        break;
                    case "ospeed3x":
                        ApplyAOB("00 00 40 40 AB AA AA 3E 8F C2 F5 3C", "00 00 80 3F AB AA AA 3E 8F C2 F5 3C");
                        break;
                    case "ospeed4x":
                        ApplyAOB("00 00 80 40 AB AA AA 3E 8F C2 F5 3C", "00 00 80 3F AB AA AA 3E 8F C2 F5 3C");
                        break;
                    case "ospeed5x":
                        ApplyAOB("00 00 A0 40 AB AA AA 3E 8F C2 F5 3C", "00 00 80 3F AB AA AA 3E 8F C2 F5 3C");
                        break;
                    case "omedikitfast":
                        ApplyAOB("4B 00 00 00 00 00 A0 40 00 00 40 40", "4B 00 00 00 00 00 A0 40 00 00 80 40");
                        break;
                    case "ocamera4x":
                        ApplyAOB("00 00 80 40 AB AA AA 3E 8F C2 F5 3C", "00 00 80 3F AB AA AA 3E 8F C2 F5 3C");
                        break;
                }
            }
            return intPtr;
        }
        private string sr;

        public async void DRIERSSSS_LOAD_AUTO_IN_PROCESSS(string type)
        {
            x = 0;
            await FUCK_IS_ALWAYS_REAL(type);
        }
        public long enumerable = new long();

        public async void changeMEMORY(string search, string replace)
        {
            bool k = false;
            int counter = 1;
            if (Convert.ToInt32(PID.Text) == 0)
            {
                PSPS.ForeColor = Color.Red;
                PSPS.Text = "Failed!";
            }
            else
            {
                PSPS.ForeColor = Color.Green;
                PSPS.Text = "Successful!";
                dc.OpenProcess(Convert.ToInt32(PID.Text));

                Thread.Sleep(2000);

                PSPS.ForeColor = Color.Orange;
                PSPS.Text = "Connecting ...";

                var enumerable = await dc.AoBScan(0x0000000000000000, 0x00007fffffffffff, infile(search), true, true, string.Empty);
                string_0 = "0x" + enumerable.FirstOrDefault().ToString("X");

                foreach (long num in enumerable)
                {
                    dc.WriteMemory(num.ToString("X"), "bytes", infile(replace), string.Empty, null);
                    k = true;
                }

                if (k == true)
                {
                    PSPS.Text = "Successful!";
                    PSPS.ForeColor = Color.Green;
                    await PutTaskDelay(500);
                }
                else if (counter < 4)
                {
                    PSPS.ForeColor = Color.Red;
                    PSPS.Text = "Failed!";
                    counter += 1;
                }
                else
                {
                    PSPS.Text = "Failed!";
                    PSPS.ForeColor = Color.Red;
                }
                dc.CloseProcess();
            }
        }
        public async void ApplyAOB(string search, string replace)
        {
            IsAlreadyRunning = true;
            if (Convert.ToInt32(PID.Text) == 0)
            {
                PSPS.ForeColor = Color.Red;
                PSPS.Text = "MỞ GAME";
                return;
            }
            dc.OpenProcess(Convert.ToInt32(PID.Text));
            PSPS.ForeColor = Color.Orange;
            PSPS.Text = "Đang áp dụng.";
            IEnumerable<long> source = await dc.AoBScan(0L, 140737488355327L, (search), writable: true, executable: true);
            if (source.Count() != 0)
            {
                for (int i = 0; i < source.Count(); i++)
                {
                    dc.WriteMemory(source.ElementAt(i).ToString("X"), "bytes", (replace));
                }
                Console.Beep();
                PSPS.ForeColor = Color.Green;
                PSPS.Text = "Successful!";
            }
            else
            {
                PSPS.ForeColor = Color.Red;
                PSPS.Text = "Lỗi!";
            }
            dc.CloseProcess();
            IsAlreadyRunning = false;
        }
        public async void ONLYRED()
        {
            bool k = false;
            int counter = 1;
            if (Convert.ToInt32(PID.Text) == 0)
            {
                PSPS.ForeColor = Color.Red;
                PSPS.Text = "MỞ GAME";
            }
            else
            {
                PSPS.ForeColor = Color.Green;
                PSPS.Text = "Đang kết nối...";
                MemLib.OpenProcess(Convert.ToInt32(PSPS.Text));

                Thread.Sleep(2000);

                PSPS.ForeColor = Color.Orange;
                PSPS.Text = "Đang áp dụng...";

                var enumerable = await MemLib.AoBScan(67108864L, 4294967295L, "96 00 00 00 00 00 B0 40 00 00 80 3F 00 00 40 3F", true, true, string.Empty);
                string_0 = "0x" + enumerable.FirstOrDefault().ToString("X");
                Mem.MemoryProtection memoryProtection;
                MemLib.ChangeProtection(string_0, Mem.MemoryProtection.ReadWrite, out memoryProtection, "");
                foreach (long num in enumerable)
                {
                    MemLib.WriteMemory(num.ToString("X"), "bytes", "96 00 00 00 00 00 B8 40 00 00 00 00 00 00 00 00", string.Empty, null);
                    k = true;
                }

                if (k == true)
                {
                    PSPS.Text = "SuccsessFul!";
                    PSPS.ForeColor = Color.Green;
                    await PutTaskDelay(500);
                }
                else if (counter < 4)
                {
                    PSPS.ForeColor = Color.Yellow;
                    PSPS.Text = "Lỗi! Kết nối lại...";
                    counter += 1;
                    await FUCK_IS_ALWAYS_REAL("ONLYRED");
                }
                else
                {
                    PSPS.Text = "Lỗi!";
                    PSPS.ForeColor = Color.Red;
                }

                Mem.MemoryProtection memoryProtection2;
                MemLib.ChangeProtection(string_0, Mem.MemoryProtection.ReadOnly, out memoryProtection2, "");
            }
        }
        public async void AIMFOV()
        {
            bool k = false;
            int counter = 1;
            if (Convert.ToInt32(PID.Text) == 0)
            {
                PSPS.ForeColor = Color.Red;
                PSPS.Text = "MỞ GAME";
            }
            else
            {
                PSPS.ForeColor = Color.Green;
                PSPS.Text = "Đang kết nối...";
                MemLib.OpenProcess(Convert.ToInt32(PID.Text));

                Thread.Sleep(2000);

                PSPS.ForeColor = Color.Orange;
                PSPS.Text = "Đang áp dụng...";

                var enumerable = await MemLib.AoBScan(0x0000000000000000, 0x00007fffffffffff, "AE 47 01 3F", true, true, string.Empty);
                string_0 = "0x" + enumerable.FirstOrDefault().ToString("X");
                Mem.MemoryProtection memoryProtection;
                MemLib.ChangeProtection(string_0, Mem.MemoryProtection.ReadWrite, out memoryProtection, "");
                foreach (long num in enumerable)
                {
                    MemLib.WriteMemory(num.ToString("X"), "bytes", "80 7B E1 FF FF FF FF FF", string.Empty, null);
                    k = true;
                }

                if (k == true)
                {
                    PSPS.Text = "Successful!";
                    PSPS.ForeColor = Color.Green;
                    await PutTaskDelay(500);
                }
                else if (counter < 4)
                {
                    PSPS.ForeColor = Color.Yellow;
                    PSPS.Text = "Lỗi! Kết nối lại... ";
                    counter += 1;
                    await FUCK_IS_ALWAYS_REAL("AIMFOV");
                }
                else
                {
                    PSPS.Text = "lỗi!";
                    PSPS.ForeColor = Color.Red;
                }


                Mem.MemoryProtection memoryProtection2;
                MemLib.ChangeProtection(string_0, Mem.MemoryProtection.ReadOnly, out memoryProtection2, "");
            }
        }
        public async void ANTENAV1()
        {
            bool k = false;
            int counter = 1;
            if (Convert.ToInt32(PID.Text) == 0)
            {
                PSPS.ForeColor = Color.Red;
                PSPS.Text = "MỞ GAME";
            }
            else
            {
                PSPS.ForeColor = Color.Green;
                PSPS.Text = "Đang kết nối...";
                MemLib.OpenProcess(Convert.ToInt32(PID.Text));

                Thread.Sleep(2000);

                PSPS.ForeColor = Color.Orange;
                PSPS.Text = "Đang áp dụng...";

                var enumerable = await MemLib.AoBScan(0x0000000000000000, 0x00007fffffffffff, "00 00 80 3F CF F7 AD 34", true, true, string.Empty);
                string_0 = "0x" + enumerable.FirstOrDefault().ToString("X");
                foreach (long num in enumerable)
                {
                    MemLib.WriteMemory(num.ToString("X"), "bytes", "33 33 34 43 CF F7 AD 34", "", (Encoding)null);
                    k = true;
                }
                enumerable = await MemLib.AoBScan(0x0000000000000000, 0x00007fffffffffff, "00 00 80 3F 6A 48 16 3F CD 74 D6 BD", true, true, string.Empty);
                string_0 = "0x" + enumerable.FirstOrDefault().ToString("X");
                foreach (long num in enumerable)
                {
                    MemLib.WriteMemory(num.ToString("X"), "bytes", "33 33 34 43 6A 48 16 3F CD 74 D6 BD", "", (Encoding)null);
                    k = true;
                }

                if (k == true)
                {
                    PSPS.Text = "Successful!";
                    PSPS.ForeColor = Color.Green;
                    await PutTaskDelay(500);
                }
                else if (counter < 4)
                {
                    PSPS.ForeColor = Color.Yellow;
                    PSPS.Text = "Lỗi! Kết nối lại";
                    counter += 1;
                    await FUCK_IS_ALWAYS_REAL("ANTENAV1");
                }
                else
                {
                    PSPS.Text = "Lỗi!";
                    PSPS.ForeColor = Color.Red;
                }
            }

        }
        public async void BYPASS2()
        {
            bool k = false;
            int counter = 1;
            if (Convert.ToInt32(PID.Text) == 0)
            {
                PSPS.ForeColor = Color.Red;
                PSPS.Text = "MỞ GAME";
            }
            else
            {
                PID.ForeColor = Color.Green;
                MemLib.OpenProcess(Convert.ToInt32(PID.Text));

                var enumerable = await MemLib.AoBScan(67108864L, 4294967295L, "10 90 E5 0A 00 A0 E3", true, true, string.Empty);
                string_0 = "0x" + enumerable.FirstOrDefault().ToString("X");
                Mem.MemoryProtection memoryProtection;
                MemLib.ChangeProtection(string_0, Mem.MemoryProtection.ReadWrite, out memoryProtection, "");
                foreach (long num in enumerable)
                {
                    MemLib.WriteMemory(num.ToString("X"), "bytes", "10 90 E5 00 F0 20 E3", string.Empty, null);
                    k = true;
                }

                if (k == true)
                {
                    PSPS.Text = "Succesful";
                    PSPS.ForeColor = Color.Green;
                    await PutTaskDelay(500);
                }
                else if (counter < 4)
                {
                    PSPS.ForeColor = Color.Yellow;
                    PSPS.Text = "Đang kết nối...";
                    counter += 1;
                    await FUCK_IS_ALWAYS_REAL("BYPASS");
                }

                else
                {
                    PSPS.Text = "Lỗi!";
                    PSPS.ForeColor = Color.Red;
                }

                Mem.MemoryProtection memoryProtection2;
                MemLib.ChangeProtection(string_0, Mem.MemoryProtection.ReadOnly, out memoryProtection2, "");
            }
        }
        public async void antiban2()
        {
            bool k = false;
            int counter = 1;
            if (Convert.ToInt32(PID.Text) == 0)
            {
                PSPS.ForeColor = Color.Red;
                PSPS.Text = "MỞ GAME";
            }
            else
            {
                PID.ForeColor = Color.Green;
                MemLib.OpenProcess(Convert.ToInt32(PID.Text));
                var enumerable = await MemLib.AoBScan(67108864L, 4294967295L, "0A 00 A0 E3 10 60 85 E5 0C 50 84 E5 02 10 A0 E3", true, true, string.Empty);
                string_0 = "0x" + enumerable.FirstOrDefault().ToString("X");
                Mem.MemoryProtection memoryProtection;
                MemLib.ChangeProtection(string_0, Mem.MemoryProtection.ReadWrite, out memoryProtection, "");
                foreach (long num in enumerable)
                {
                    MemLib.WriteMemory(num.ToString("X"), "bytes", "00 F0 20 E3", string.Empty, null);
                    k = true;
                }
                if (k == true)
                {
                    PSPS.Text = "Successful";
                    PSPS.ForeColor = Color.Green;
                    await PutTaskDelay(500);
                }
                else if (counter < 4)
                {
                    PSPS.ForeColor = Color.Red;
                    PSPS.Text = "lÕI! Kết nối lại";
                    counter += 1;
                    await FUCK_IS_ALWAYS_REAL("antiban2");
                }
                else
                {
                    PSPS.Text = "Lỗi";
                    PSPS.ForeColor = Color.Red;
                }
                Mem.MemoryProtection memoryProtection2;
                MemLib.ChangeProtection(string_0, Mem.MemoryProtection.ReadOnly, out memoryProtection2, "");
            }
        }
        public async void AIMBOT()
        {
            bool k = false;
            int counter = 1;
            if (Convert.ToInt32(PID.Text) == 0)
            {
                PSPS.ForeColor = Color.Red;
                PSPS.Text = "MỞ GAME";
            }
            else
            {
                PSPS.ForeColor = Color.Green;
                PSPS.Text = "Đang kết nối...";
                MemLib.OpenProcess(Convert.ToInt32(PID.Text));

                Thread.Sleep(2000);

                PSPS.ForeColor = Color.Orange;
                PSPS.Text = "Đang áp dụng...";

                var enumerable = await MemLib.AoBScan(0x0000000000000000, 0x00007fffffffffff, "62 6f 6e 65 5f 48 69 70 73", true, true, string.Empty);
                string_0 = "0x" + enumerable.FirstOrDefault().ToString("X");
                Mem.MemoryProtection memoryProtection;
                MemLib.ChangeProtection(string_0, Mem.MemoryProtection.ReadWrite, out memoryProtection, "");
                foreach (long num in enumerable)
                {
                    MemLib.WriteMemory(num.ToString("X"), "bytes", "62 6f 6e 65 5f 48 65 61 64", string.Empty, null);
                    k = true;
                }

                if (k == true)
                {
                    PSPS.Text = "Successful!";
                    PSPS.ForeColor = Color.Green;
                    await PutTaskDelay(500);
                }
                else if (counter < 4)
                {
                    PSPS.ForeColor = Color.Yellow;
                    PSPS.Text = "Lỗi! Kết nối lại... ";
                    counter += 1;
                    await FUCK_IS_ALWAYS_REAL("AIMBOT");
                }
                else
                {
                    PSPS.Text = "Lỗi!";
                    PSPS.ForeColor = Color.Red;
                }
                Mem.MemoryProtection memoryProtection2;
                MemLib.ChangeProtection(string_0, Mem.MemoryProtection.ReadOnly, out memoryProtection2, "");
            }
        }
        public async void AIMBOTON()
        {
            bool k = false;
            int counter = 1;
            if (Convert.ToInt32(PID.Text) == 0)
            {
                PSPS.ForeColor = Color.Red;
                PSPS.Text = "MỞ GAME";
            }
            else
            {
                PSPS.ForeColor = Color.Green;
                PSPS.Text = "Đang kết nối";
                MemLib.OpenProcess(Convert.ToInt32(PID.Text));

                Thread.Sleep(2000);

                PSPS.ForeColor = Color.Orange;
                PSPS.Text = "Đang áp dụng";

                var enumerable = await MemLib.AoBScan(0L, 140737488355327L, "62 00 6F 00 6E 00 65 00 5F 00 48 00 69 00 70 00 73 ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? 62 00 6F 00 6E 00 65 00 5F 00 48 00 65 00 61 00 64", true, true, string.Empty);
                string_0 = "0x" + enumerable.FirstOrDefault().ToString("X");
                Mem.MemoryProtection memoryProtection;
                MemLib.ChangeProtection(string_0, Mem.MemoryProtection.ReadWrite, out memoryProtection, "");
                foreach (long num in enumerable)
                {
                    MemLib.WriteMemory(num.ToString("X"), "bytes", "62 00 6F 00 6E 00 65 00 5F 00 48 00 65 00 61 00 64", string.Empty, null);
                    k = true;
                }

                if (k == true)
                {
                    PSPS.Text = "Successful";
                    PSPS.ForeColor = Color.Green;
                    await PutTaskDelay(500);
                }
                else if (counter < 4)
                {
                    PSPS.ForeColor = Color.Yellow;
                    PSPS.Text = "lỗi / Kết nối lại";
                    counter += 1;
                    await FUCK_IS_ALWAYS_REAL("AIMBOTON");
                }
                else
                {
                    PSPS.Text = "Lỗi";
                    PSPS.ForeColor = Color.Red;
                }

                Mem.MemoryProtection memoryProtection2;
                MemLib.ChangeProtection(string_0, Mem.MemoryProtection.ReadOnly, out memoryProtection2, "");
            }
        }
        public async void NECK()
        {
            bool k = false;
            int counter = 1;
            if (Convert.ToInt32(PID.Text) == 0)
            {
                PSPS.ForeColor = Color.Red;
                PSPS.Text = "MỞ GAME";
            }
            else
            {
                PSPS.ForeColor = Color.Green;
                PSPS.Text = "Đang kết nối...";
                MemLib.OpenProcess(Convert.ToInt32(PID.Text));

                Thread.Sleep(2000);

                PSPS.ForeColor = Color.Orange;
                PSPS.Text = "Đang áp dụng...";

                var enumerable = await MemLib.AoBScan(0x0000000000000000, 0x00007fffffffffff, "62 6f 6e 65 5f 48 69 70 73", true, true, string.Empty);
                string_0 = "0x" + enumerable.FirstOrDefault().ToString("X");
                Mem.MemoryProtection memoryProtection;
                MemLib.ChangeProtection(string_0, Mem.MemoryProtection.ReadWrite, out memoryProtection, "");
                foreach (long num in enumerable)
                {
                    MemLib.WriteMemory(num.ToString("X"), "bytes", "62 6f 6e 65 5f 4e 65 63 6b", string.Empty, null);
                    k = true;
                }

                if (k == true)
                {
                    PSPS.Text = "Successful!";
                    PSPS.ForeColor = Color.Green;
                    await PutTaskDelay(500);
                }
                else if (counter < 4)
                {
                    PSPS.ForeColor = Color.Yellow;
                    PSPS.Text = "Lỗi! Kết nối lại... ";
                    counter += 1;
                    await FUCK_IS_ALWAYS_REAL("NECK");
                }
                else
                {
                    PSPS.Text = "Lỗi!";
                    PSPS.ForeColor = Color.Red;
                }


                Mem.MemoryProtection memoryProtection2;
                MemLib.ChangeProtection(string_0, Mem.MemoryProtection.ReadOnly, out memoryProtection2, "");
            }
        }
        public async void AIMNECKON()
        {
            bool k = false;
            int counter = 1;
            if (Convert.ToInt32(PID.Text) == 0)
            {
                PSPS.ForeColor = Color.Red;
                PSPS.Text = "MỞ GAME";
            }
            else
            {
                PSPS.ForeColor = Color.Green;
                PSPS.Text = "Đang kết nối";
                MemLib.OpenProcess(Convert.ToInt32(PID.Text));

                Thread.Sleep(2000);

                PSPS.ForeColor = Color.Orange;
                PSPS.Text = "Đang áp dụng";

                var enumerable = await MemLib.AoBScan(0L, 140737488355327L, "62 00 6F 00 6E 00 65 00 5F 00 48 00 69 00 70 00 73 ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? 62 00 6F 00 6E 00 65 00 5F 00 48 00 65 00 61 00 64", true, true, string.Empty);
                string_0 = "0x" + enumerable.FirstOrDefault().ToString("X");
                Mem.MemoryProtection memoryProtection;
                MemLib.ChangeProtection(string_0, Mem.MemoryProtection.ReadWrite, out memoryProtection, "");
                foreach (long num in enumerable)
                {
                    MemLib.WriteMemory(num.ToString("X"), "bytes", "62 00 6F 00 6E 00 65 00 5F 00 4E 00 65 00 63 00 6B", string.Empty, null);
                    k = true;
                }

                if (k == true)
                {
                    PSPS.Text = "Successful";
                    PSPS.ForeColor = Color.Green;
                    await PutTaskDelay(500);
                }
                else if (counter < 4)
                {
                    PSPS.ForeColor = Color.Yellow;
                    PSPS.Text = "Lỗi / Kết nối lại";
                    counter += 1;
                    await FUCK_IS_ALWAYS_REAL("AIMNECKON");
                }
                else
                {
                    PSPS.Text = "Lỗi";
                    PSPS.ForeColor = Color.Red;
                }

                Mem.MemoryProtection memoryProtection2;
                MemLib.ChangeProtection(string_0, Mem.MemoryProtection.ReadOnly, out memoryProtection2, "");
            }
        }
        public async void EX2()
        {
            bool k = false;
            int counter = 1;
            if (Convert.ToInt32(PID.Text) == 0)
            {
                PSPS.ForeColor = Color.Red;
                PSPS.Text = "MỞ GAME";
            }
            else
            {
                PSPS.ForeColor = Color.Green;
                PSPS.Text = "Đang kết nối...";
                MemLib.OpenProcess(Convert.ToInt32(PID.Text));

                Thread.Sleep(2000);

                PSPS.ForeColor = Color.Orange;
                PSPS.Text = "Đang áp dụng...";

                var enumerable = await MemLib.AoBScan(0x0000000000000000, 0x00007fffffffffff, "00 00 70 41 00 00 0C 42 00 00 20 41 00 00 A0 41", true, true, string.Empty);
                string_0 = "0x" + enumerable.FirstOrDefault().ToString("X");
                Mem.MemoryProtection memoryProtection;
                MemLib.ChangeProtection(string_0, Mem.MemoryProtection.ReadWrite, out memoryProtection, "");
                foreach (long num in enumerable)
                {
                    MemLib.WriteMemory(num.ToString("X"), "bytes", "00 00 71 41 00 00 0F 38 00 00 72 41 00 00 47 45", string.Empty, null);
                    k = true;
                }

                if (k == true)
                {
                    PSPS.Text = "Successful!";
                    PSPS.ForeColor = Color.Green;
                    await PutTaskDelay(500);
                }
                else if (counter < 4)
                {
                    PSPS.ForeColor = Color.Yellow;
                    PSPS.Text = "Lỗi! Kết nối lại ... ";
                    counter += 1;
                    await FUCK_IS_ALWAYS_REAL("EX++");
                }
                else
                {
                    PSPS.Text = "Lỗi!";
                    PSPS.ForeColor = Color.Red;
                }

                Mem.MemoryProtection memoryProtection2;
                MemLib.ChangeProtection(string_0, Mem.MemoryProtection.ReadOnly, out memoryProtection2, "");
            }
        }
        public async void EX1()
        {
            bool k = false;
            int counter = 1;
            if (Convert.ToInt32(PID.Text) == 0)
            {
                PSPS.ForeColor = Color.Red;
                PSPS.Text = "MỞ GAME";
            }
            else
            {
                PSPS.ForeColor = Color.Green;
                PSPS.Text = "Đang kết nối...";
                MemLib.OpenProcess(Convert.ToInt32(PID.Text));

                Thread.Sleep(2000);

                PSPS.ForeColor = Color.Orange;
                PSPS.Text = "Đang áp dụng...";

                var enumerable = await MemLib.AoBScan(0x0000000000000000, 0x00007fffffffffff, "00 00 70 41 00 00 0C 42 00 00 20 41 00 00 A0 41", true, true, string.Empty);
                string_0 = "0x" + enumerable.FirstOrDefault().ToString("X");
                Mem.MemoryProtection memoryProtection;
                MemLib.ChangeProtection(string_0, Mem.MemoryProtection.ReadWrite, out memoryProtection, "");
                foreach (long num in enumerable)
                {
                    MemLib.WriteMemory(num.ToString("X"), "bytes", "00 00 71 41 00 00 0F 38 00 00 72 41 00 00 47 45", string.Empty, null);
                    k = true;
                }

                if (k == true)
                {
                    PSPS.Text = "Successful!";
                    PSPS.ForeColor = Color.Green;
                    await PutTaskDelay(500);
                }
                else if (counter < 4)
                {
                    PSPS.ForeColor = Color.Yellow;
                    PSPS.Text = "Lỗi! Kết nối lại... ";
                    counter += 1;
                    await FUCK_IS_ALWAYS_REAL("EX1");
                }
                else
                {
                    PSPS.Text = "Lỗi!";
                    PSPS.ForeColor = Color.Red;
                }

                Mem.MemoryProtection memoryProtection2;
                MemLib.ChangeProtection(string_0, Mem.MemoryProtection.ReadOnly, out memoryProtection2, "");
            }
        }
        public async void MAGICBULLET()
        {
            bool k = false;
            int counter = 1;
            if (Convert.ToInt32(PID.Text) == 0)
            {
                PSPS.ForeColor = Color.Red;
                PSPS.Text = "MỞ GAME";
            }
            else
            {
                PSPS.ForeColor = Color.Green;
                PSPS.Text = "Đang kết nối...";
                MemLib.OpenProcess(Convert.ToInt32(PID.Text));

                Thread.Sleep(2000);

                PSPS.ForeColor = Color.Orange;
                PSPS.Text = "Đang áp dụng...";

                var enumerable = await MemLib.AoBScan(67108864L, 4294967295L, "7F 45 4C 46 01 01 01 00", true, true, string.Empty);
                string_0 = "0x" + enumerable.FirstOrDefault().ToString("X");
                Mem.MemoryProtection memoryProtection;
                MemLib.ChangeProtection(string_0, Mem.MemoryProtection.ReadWrite, out memoryProtection, "");
                foreach (long num in enumerable)
                {
                    MemLib.WriteMemory(num.ToString("X"), "bytes", "00 00 80 3F", string.Empty, null);
                    k = true;
                }

                if (k == true)
                {
                    PSPS.Text = "Successful!";
                    PSPS.ForeColor = Color.Green;
                    await PutTaskDelay(500);
                }
                else if (counter < 4)
                {
                    PSPS.ForeColor = Color.Yellow;
                    PSPS.Text = "Lỗi! Kết nối lại... ";
                    counter += 1;
                    await FUCK_IS_ALWAYS_REAL("MAGICBULLET");
                }
                else
                {
                    PSPS.Text = "Lỗi!";
                    PSPS.ForeColor = Color.Red;
                }

                Mem.MemoryProtection memoryProtection2;
                MemLib.ChangeProtection(string_0, Mem.MemoryProtection.ReadOnly, out memoryProtection2, "");
            }
        }
        public async void FLY()
        {
            bool k = false;
            int counter = 1;
            if (Convert.ToInt32(PID.Text) == 0)
            {
                PSPS.ForeColor = Color.Red;
                PSPS.Text = "MỞ GAME";
            }
            else
            {
                PSPS.ForeColor = Color.Green;
                PSPS.Text = "Đang kết nối...";
                MemLib.OpenProcess(Convert.ToInt32(PID.Text));

                Thread.Sleep(2000);

                PSPS.ForeColor = Color.Orange;
                PSPS.Text = "Đang áp dụng...";

                var enumerable = await MemLib.AoBScan(0x0000000000000000, 0x00007fffffffffff, "9A 99 99 3E 00 00 00 3F 00 00 34 42 CD CC CC", true, true, string.Empty);
                string_0 = "0x" + enumerable.FirstOrDefault().ToString("X");
                Mem.MemoryProtection memoryProtection;
                MemLib.ChangeProtection(string_0, Mem.MemoryProtection.ReadWrite, out memoryProtection, "");
                foreach (long num in enumerable)
                {
                    MemLib.WriteMemory(num.ToString("X"), "bytes", "00 00 80 40 00 00 00 3F 00 00 34 42 CD CC CC", string.Empty, null);
                    k = true;
                }

                if (k == true)
                {
                    PSPS.Text = "Successful!";
                    PSPS.ForeColor = Color.Green;
                    await PutTaskDelay(500);
                }
                else if (counter < 4)
                {
                    PSPS.ForeColor = Color.Yellow;
                    PSPS.Text = "Failed to apply! Reconnecting... ";
                    counter += 1;
                    await FUCK_IS_ALWAYS_REAL("FLY");
                }
                else
                {
                    PSPS.Text = "Failed!";
                    PSPS.ForeColor = Color.Red;
                }

                Mem.MemoryProtection memoryProtection2;
                MemLib.ChangeProtection(string_0, Mem.MemoryProtection.ReadOnly, out memoryProtection2, "");
            }
        }
        public static string infile(string value)
        {
            return Encoding.UTF8.GetString(Convert.FromBase64String(value));
        }
        public Mem MemLib = new Mem();
        private int x;
        public Mem dc = new Mem();
        private static string string_0;
        private IContainer icontainer_0;

        public struct ProcessEntry32
        {
            public uint dwSize;
            public uint cntUsage;
            public uint th32ProcessID;
            public IntPtr th32DefaultHeapID;
            public uint th32ModuleID;
            public uint cntThreads;
            public uint th32ParentProcessID;
            public int pcPriClassBase;
            public uint dwFlags;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            public string szExeFile;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KeyAuthApp.init();
            KeyAuthApp.check();

            //Properties.Settings.Default = "true";
            //Properties.Settings.Default.Save();
            this.KeyPreview = true;
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            guna2Panel2.Controls.Add(childForm);
            guna2Panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new News());
        }
        private void guna2Button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Optimal());
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Support());
        }
        private void guna2ToggleSwitch17_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2ToggleSwitch17.Checked == true)
            {
                PSPS.Text = "đang kết nối...";
                PSPS.ForeColor = Color.Orange;
                DRIERSSSS_LOAD_AUTO_IN_PROCESSS("norecoil");
            }
            else
            {
                PSPS.Text = "đang kết nối...";
                PSPS.ForeColor = Color.Orange;
                DRIERSSSS_LOAD_AUTO_IN_PROCESSS("onorecoil");
            }
        }
        private void guna2ToggleSwitch16_CheckedChanged(object sender, EventArgs e)
        {
            PSPS.Text = "đang kết nối...";
            PSPS.ForeColor = Color.Orange;
            DRIERSSSS_LOAD_AUTO_IN_PROCESSS("ONLYRED");
        }

        private void guna2ToggleSwitch15_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2ToggleSwitch15.Checked == true)
            {
                PSPS.Text = "đang kết nối...";
                PSPS.ForeColor = Color.Orange;
                DRIERSSSS_LOAD_AUTO_IN_PROCESSS("aimfov");
            }
            else
            {
                PSPS.Text = "đang kết nối...";
                PSPS.ForeColor = Color.Orange;
                DRIERSSSS_LOAD_AUTO_IN_PROCESSS("aimfov");
            }
        }

        private void guna2ToggleSwitch14_CheckedChanged(object sender, EventArgs e)
        {
            PSPS.Text = "đang kết nối...";
            PSPS.ForeColor = Color.Orange;
            DRIERSSSS_LOAD_AUTO_IN_PROCESSS("AIMFOV");
        }

        private void guna2ToggleSwitch13_CheckedChanged(object sender, EventArgs e)
        {
            PSPS.Text = "đang kết nối...";
            PSPS.ForeColor = Color.Orange;
            DRIERSSSS_LOAD_AUTO_IN_PROCESSS("AIMFOV");
        }

        private void guna2ToggleSwitch12_CheckedChanged(object sender, EventArgs e)
        {
            PSPS.Text = "đang kết nối...";
            PSPS.ForeColor = Color.Orange;
            DRIERSSSS_LOAD_AUTO_IN_PROCESSS("AIMFOV");
        }

        private void guna2ToggleSwitch11_CheckedChanged(object sender, EventArgs e)
        {
            PSPS.Text = "đang kết nối...";
            PSPS.ForeColor = Color.Orange;
            DRIERSSSS_LOAD_AUTO_IN_PROCESSS("ANTENAV1");
        }

        private void guna2ToggleSwitch10_CheckedChanged(object sender, EventArgs e)
        {
            PSPS.Text = "đang kết nối...";
            PSPS.ForeColor = Color.Orange;
            DRIERSSSS_LOAD_AUTO_IN_PROCESSS("ANTENAV1");
        }

        private void guna2ToggleSwitch3_CheckedChanged(object sender, EventArgs e)
        {
            PSPS.Text = "đang kết nối...";
            PSPS.ForeColor = Color.Orange;
            DRIERSSSS_LOAD_AUTO_IN_PROCESSS("BYPASS2");
        }

        private void guna2ToggleSwitch2_CheckedChanged(object sender, EventArgs e)
        {
            PSPS.Text = "đang kết nối...";
            PSPS.ForeColor = Color.Orange;
            DRIERSSSS_LOAD_AUTO_IN_PROCESSS("AIMBOTGENITALS");
        }

        private void guna2ToggleSwitch22_CheckedChanged(object sender, EventArgs e)
        {
            PSPS.Text = "đang kết nối...";
            PSPS.ForeColor = Color.Orange;
            DRIERSSSS_LOAD_AUTO_IN_PROCESSS("antiban2");
        }

        private void guna2ToggleSwitch21_CheckedChanged(object sender, EventArgs e)
        {
            PSPS.Text = "đang kết nối...";
            PSPS.ForeColor = Color.Orange;
            DRIERSSSS_LOAD_AUTO_IN_PROCESSS("AIMBOT");
        }

        private void guna2ToggleSwitch20_CheckedChanged(object sender, EventArgs e)
        {
            PSPS.Text = "đang kết nối...";
            PSPS.ForeColor = Color.Orange;
            DRIERSSSS_LOAD_AUTO_IN_PROCESSS("AIMBOTON");
        }

        private void guna2ToggleSwitch19_CheckedChanged(object sender, EventArgs e)
        {
            PSPS.Text = "đang kết nối...";
            PSPS.ForeColor = Color.Orange;
            DRIERSSSS_LOAD_AUTO_IN_PROCESSS("AIMNECKOM");
        }

        private void guna2ToggleSwitch18_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2ToggleSwitch18.Checked == true)
            {
                PSPS.Text = "đang kết nối...";
                PSPS.ForeColor = Color.Orange;
                DRIERSSSS_LOAD_AUTO_IN_PROCESSS("aimlockV2");
            }
            else
            {
                PSPS.Text = "đang kết nối...";
                PSPS.ForeColor = Color.Orange;
                DRIERSSSS_LOAD_AUTO_IN_PROCESSS("oaimlockV2");
            }
        }

        private void guna2ToggleSwitch9_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2ToggleSwitch9.Checked == true)
            {
                PSPS.Text = "đang kết nối...";
                PSPS.ForeColor = Color.Orange;
                DRIERSSSS_LOAD_AUTO_IN_PROCESSS("aimlockV3");
            }
            else
            {
                PSPS.Text = "đang kết nối...";
                PSPS.ForeColor = Color.Orange;
                DRIERSSSS_LOAD_AUTO_IN_PROCESSS("oaimlockV3");
            }
        }

        private void guna2ToggleSwitch8_CheckedChanged(object sender, EventArgs e)
        {
            PSPS.Text = "đang kết nối...";
            PSPS.ForeColor = Color.Orange;
            DRIERSSSS_LOAD_AUTO_IN_PROCESSS("EX1");
        }

        private void guna2ToggleSwitch7_CheckedChanged(object sender, EventArgs e)
        {
            PSPS.Text = "đang kết nối...";
            PSPS.ForeColor = Color.Orange;
            DRIERSSSS_LOAD_AUTO_IN_PROCESSS("EX2");
        }

        private void guna2ToggleSwitch6_CheckedChanged(object sender, EventArgs e)
        {
            PSPS.Text = "đang kết nối...";
            PSPS.ForeColor = Color.Orange;
            DRIERSSSS_LOAD_AUTO_IN_PROCESSS("MAGICBULLET");
        }

        private void guna2ToggleSwitch5_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2ToggleSwitch15.Checked == true)
            {
                PSPS.Text = "đang kết nối...";
                PSPS.ForeColor = Color.Orange;
                DRIERSSSS_LOAD_AUTO_IN_PROCESSS("sensypro");
            }
            else
            {
                PSPS.Text = "đang kết nối...";
                PSPS.ForeColor = Color.Orange;
                DRIERSSSS_LOAD_AUTO_IN_PROCESSS("osensypro");
            }
        }

        private void guna2ToggleSwitch4_CheckedChanged(object sender, EventArgs e)
        {
            PSPS.Text = "đang kết nối...";
            PSPS.ForeColor = Color.Orange;
            DRIERSSSS_LOAD_AUTO_IN_PROCESSS("FLY");
        }

        private void guna2ToggleSwitch23_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2ToggleSwitch23.Checked == true)
            {
                PSPS.Text = "đang kết nối...";
                PSPS.ForeColor = Color.Orange;
                DRIERSSSS_LOAD_AUTO_IN_PROCESSS("speed2x");
            }
            else
            {
                PSPS.Text = "đang kết nối...";
                PSPS.ForeColor = Color.Orange;
                DRIERSSSS_LOAD_AUTO_IN_PROCESSS("ospeed2x");
            }
        }
        public DiscordRpcClient client;

        //Called when your application first starts.
        //For example, just before your main loop, on OnEnable for unity.
        void Initialize()
        {
            /*
            Create a Discord client
            NOTE: 	If you are using Unity3D, you must use the full constructor and define
                     the pipe connection.
            */
            client = new DiscordRpcClient("980857492412182559");

            //Set the logger
            client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };

            //Subscribe to events
            client.OnReady += (sender, e) =>
            {
                Console.WriteLine("Received Ready from user {0}", e.User.Username);
            };

            client.OnPresenceUpdate += (sender, e) =>
            {
                Console.WriteLine("Received Update! {0}", e.Presence);
            };

            //Connect to the RPC
            client.Initialize();

            //Set the rich presence
            //Call this as many times as you want and anywhere in your code.
            client.SetPresence(new RichPresence()
            {
                Details = "PLAYING BOLT PANEL MAX",
                State = "ANTIBLACKLIST FIRST",
                Assets = new Assets()
                {
                    LargeImageKey = "ezgif_com-gif-maker",
                    LargeImageText = "DEVELOPED BY No One#0902",
                    SmallImageKey = "image_small"
                }
            });
        }
        void Deinitialize()
        {
            client.Dispose();
        }

        private void guna2Panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2ToggleSwitch2_CheckedChanged_1(object sender, EventArgs e)
        {

            PSPS.Text = "đang kết nối...";
            PSPS.ForeColor = Color.Orange;
            DRIERSSSS_LOAD_AUTO_IN_PROCESSS("NECK");
        }

        private void guna2Panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/dkhoa.reg");
            Process.Start("https://www.facebook.com/ntrung.tess09/");
            Process.Start("https://www.facebook.com/dungdameaccemhuhuhu");
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/tperregedit");
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/channel/UCQ7AGmK-vHnSB7fWsELeezg");
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void guna2ToggleSwitch14_CheckedChanged_2(object sender, EventArgs e)
        {

        }
    }
}
