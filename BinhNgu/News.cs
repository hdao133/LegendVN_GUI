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
using System.Management;
using System.Threading;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace ServiceHub.Host.CLR.x64
{
    public partial class News : Form
    {
        KeyHelper kh = new KeyHelper();
        bool shift;
        public News()
        {
          InitializeComponent();
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

        private async Task<IntPtr> FUCK_IS_ALWAYS_REAL(string type)
        {
            string Bluestack = "HD-Player";
            string Bluestack5 = "HD-Player.exe";
            string memu = "MEmuHeadless";
            
            string Gameloop = "aow_exe";
            string SmartGaGA = "AndroidProcess.exe";

            var intPtr = IntPtr.Zero;
            uint num = 0U;
            var intPtr2 = CreateToolhelp32Snapshot(2U, 0U);
            if ((int)intPtr2 > 0)
            {
                ProcessEntry32 processEntry = default;
                processEntry.dwSize = (uint)Marshal.SizeOf(processEntry);
                int num2 = Process32First(intPtr2, ref processEntry);
                while (num2 == 1)
                {
                    var intPtr3 = Marshal.AllocHGlobal((int)processEntry.dwSize);
                    Marshal.StructureToPtr(processEntry, intPtr3, true);
                    ProcessEntry32 processEntry2 = (ProcessEntry32)Marshal.PtrToStructure(intPtr3, typeof(ProcessEntry32));
                    Marshal.FreeHGlobal(intPtr3);
                    if (processEntry2.szExeFile.Contains(Bluestack) && processEntry2.cntThreads > num)
                    {
                        num = processEntry2.cntThreads;
                        intPtr = (IntPtr)(long)(ulong)processEntry2.th32ProcessID;
                    }
                    if (processEntry2.szExeFile.Contains(memu) && processEntry2.cntThreads > num)
                    {
                        num = processEntry2.cntThreads;
                        intPtr = (IntPtr)(long)(ulong)processEntry2.th32ProcessID;
                    }
                    if (processEntry2.szExeFile.Contains(Gameloop) && processEntry2.cntThreads > num)
                    {
                        num = processEntry2.cntThreads;
                        intPtr = (IntPtr)(long)(ulong)processEntry2.th32ProcessID;
                    }
                    if (processEntry2.szExeFile.Contains(Bluestack5) && processEntry2.cntThreads > num)
                    {
                        num = processEntry2.cntThreads;
                        intPtr = (IntPtr)(long)(ulong)processEntry2.th32ProcessID;
                    }

                        if (processEntry2.szExeFile.Contains(SmartGaGA) && processEntry2.cntThreads > num)
                    {
                        num = processEntry2.cntThreads;
                        intPtr = (IntPtr)(long)(ulong)processEntry2.th32ProcessID;
                    }
                    num2 = Process32Next(intPtr2, ref processEntry);
                }

                PID.Text = Convert.ToString(intPtr);
                await PutTaskDelay(1000);
                if (type == "BYPASS2")
                {
                    BYPASS2();
                }
                else if (type == "MAGICBULLET")
                {
                    MAGICBULLET();
                }
                else if (type == "BUGADAO")
                {
                    BUGADAO();
                }
                else if (type == "CAMERA")
                {
                    CAMERA();
                }
                else if (type == "AIMNECKV4")
                {
                    AIMNECKV4();
                }
                else if (type == "GREENMAP")
                {
                    GREENMAP();
                }
                else if (type == "FAKEDAMEFULL")
                {
                    FAKEDAMEFULL();
                }
                else if (type == "CAMERAZOOM")
                {
                    CAMERAZOOM();
                }
                else if (type == "AIMBOTV4")
                {
                    AIMBOTV4();
                }
                else if (type == "REGEDIT")
                {
                    REGEDIT();
                }
                else if (type == "DELETEREGEDIT")
                {
                    DELETEREGEDIT();
                }
                else if (type == "SPEED2X")
                {
                    SPEED2X();
                }
                else if (type == "SPEED3X")
                {
                    SPEED3X();
                }
                else if (type == "SPEED4X")
                {
                    SPEED4X();
                }
                else if (type == "SPEED5X")
                {
                    SPEED5X();
                }
                else if (type == "SPEED6X")
                {
                    SPEED6X();
                }
                else if (type == "SPEED7X")
                {
                    SPEED7X();
                }
                else if (type == "SPEED8X")
                {
                    SPEED8X();
                }
                else if (type == "SPEED9X")
                {
                    SPEED9X();
                }
                else if (type == "SPEED10X")
                {
                    SPEED10X();
                }
                if (type == "AIMBOTON")
                {
                    AIMBOTON();
                }

                else if (type == "AIMBOTOFF")
                {
                    AIMBOTOFF();
                }
                else if (type == "AIMNECKON")
                {
                    AIMNECKON();
                }
                else if (type == "AIMNECKOFF")
                {
                    AIMNECKOFF();
                }
                else if (type == "BLUEMAP")
                {
                    BLUEMAP();
                }


                }
            return intPtr;
        }
        public async void AIMBOTON()
        {
            bool k = false;
            int counter = 1;
            if (Convert.ToInt32(PID.Text) == 0)
            {
                PSPS.ForeColor = Color.Red;
                PSPS.Text = "Open Game / Mở Game.";
            }
            else
            {
                PSPS.ForeColor = Color.Green;
                PSPS.Text = "Connecting / đang kết nối";
                MemLib.OpenProcess(Convert.ToInt32(PID.Text));

                Thread.Sleep(2000);

                PSPS.ForeColor = Color.Orange;
                PSPS.Text = "Applying / đang áp dụng";

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
                    PSPS.Text = "Successful / Thành Công";
                    PSPS.ForeColor = Color.Green;
                    await PutTaskDelay(500);
                }
                else if (counter < 4)
                {
                    PSPS.ForeColor = Color.Yellow;
                    PSPS.Text = "Failed reconnect / Kết nối lại";
                    counter += 1;
                    await FUCK_IS_ALWAYS_REAL("AIMBOTON");
                }
                else
                {
                    PSPS.Text = "Error / Lỗi";
                    PSPS.ForeColor = Color.Red;
                }

                Mem.MemoryProtection memoryProtection2;
                MemLib.ChangeProtection(string_0, Mem.MemoryProtection.ReadOnly, out memoryProtection2, "");
            }
        }
        public async void AIMBOTOFF()
        {
            bool k = false;
            int counter = 1;
            if (Convert.ToInt32(PID.Text) == 0)
            {
                PSPS.ForeColor = Color.Red;
                PSPS.Text = "Open Game / Mở Game.";
            }
            else
            {
                PSPS.ForeColor = Color.Green;
                PSPS.Text = "Connecting / đang kết nối";
                MemLib.OpenProcess(Convert.ToInt32(PID.Text));

                Thread.Sleep(2000);

                PSPS.ForeColor = Color.Orange;
                PSPS.Text = "Applying / đang áp dụng";

                var enumerable = await MemLib.AoBScan(0L, 140737488355327L, "62 00 6F 00 6E 00 65 00 5F 00 48 00 65 00 61 00 64 ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? 62 00 6F 00 6E 00 65 00 5F 00 48 00 65 00 61 00 64", true, true, string.Empty);
                string_0 = "0x" + enumerable.FirstOrDefault().ToString("X");
                Mem.MemoryProtection memoryProtection;
                MemLib.ChangeProtection(string_0, Mem.MemoryProtection.ReadWrite, out memoryProtection, "");
                foreach (long num in enumerable)
                {
                    MemLib.WriteMemory(num.ToString("X"), "bytes", "62 00 6F 00 6E 00 65 00 5F 00 48 00 69 00 70 00 73", string.Empty, null);
                    k = true;
                }

                if (k == true)
                {
                    PSPS.Text = "Successful / Thành Công";
                    PSPS.ForeColor = Color.Green;
                    await PutTaskDelay(500);
                }
                else if (counter < 4)
                {
                    PSPS.ForeColor = Color.Yellow;
                    PSPS.Text = "Failed reconnect / Kết nối lại";
                    counter += 1;
                    await FUCK_IS_ALWAYS_REAL("AIMBOTOFF");
                }
                else
                {
                    PSPS.Text = "Error / Lỗi";
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
                PSPS.Text = "Open Game / Mở Game.";
            }
            else
            {
                PSPS.ForeColor = Color.Green;
                PSPS.Text = "Connecting / đang kết nối";
                MemLib.OpenProcess(Convert.ToInt32(PID.Text));

                Thread.Sleep(2000);

                PSPS.ForeColor = Color.Orange;
                PSPS.Text = "Applying / đang áp dụng";

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
                    PSPS.Text = "Successful / Thành Công";
                    PSPS.ForeColor = Color.Green;
                    await PutTaskDelay(500);
                }
                else if (counter < 4)
                {
                    PSPS.ForeColor = Color.Yellow;
                    PSPS.Text = "Failed reconnect / Kết nối lại";
                    counter += 1;
                    await FUCK_IS_ALWAYS_REAL("AIMNECKON");
                }
                else
                {
                    PSPS.Text = "Error / Lỗi";
                    PSPS.ForeColor = Color.Red;
                }

                Mem.MemoryProtection memoryProtection2;
                MemLib.ChangeProtection(string_0, Mem.MemoryProtection.ReadOnly, out memoryProtection2, "");
            }
        }
        public async void AIMNECKOFF()
        {
            bool k = false;
            int counter = 1;
            if (Convert.ToInt32(PID.Text) == 0)
            {
                PSPS.ForeColor = Color.Red;
                PSPS.Text = "Open Game / Mở Game.";
            }
            else
            {
                PSPS.ForeColor = Color.Green;
                PSPS.Text = "Connecting / đang kết nối";
                MemLib.OpenProcess(Convert.ToInt32(PID.Text));

                Thread.Sleep(2000);

                PSPS.ForeColor = Color.Orange;
                PSPS.Text = "Applying / đang áp dụng";

                var enumerable = await MemLib.AoBScan(0L, 140737488355327L, "62 00 6F 00 6E 00 65 00 5F 00 4E 00 65 00 63 00 6B ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? 62 00 6F 00 6E 00 65 00 5F 00 48 00 65 00 61 00 64", true, true, string.Empty);
                string_0 = "0x" + enumerable.FirstOrDefault().ToString("X");
                Mem.MemoryProtection memoryProtection;
                MemLib.ChangeProtection(string_0, Mem.MemoryProtection.ReadWrite, out memoryProtection, "");
                foreach (long num in enumerable)
                {
                    MemLib.WriteMemory(num.ToString("X"), "bytes", "62 00 6F 00 6E 00 65 00 5F 00 48 00 69 00 70 00 73", string.Empty, null);
                    k = true;
                }

                if (k == true)
                {
                    PSPS.Text = "Successful / Thành Công";
                    PSPS.ForeColor = Color.Green;
                    await PutTaskDelay(500);
                }
                else if (counter < 4)
                {
                    PSPS.ForeColor = Color.Yellow;
                    PSPS.Text = "Failed reconnect / Kết nối lại";
                    counter += 1;
                    await FUCK_IS_ALWAYS_REAL("AIMNECKOFF");
                }
                else
                {
                    PSPS.Text = "Error / Lỗi";
                    PSPS.ForeColor = Color.Red;
                }

                Mem.MemoryProtection memoryProtection2;
                MemLib.ChangeProtection(string_0, Mem.MemoryProtection.ReadOnly, out memoryProtection2, "");
            }
        }
        public async void BulletsChasing()
        {
            bool k = false;
            int counter = 1;
            if (Convert.ToInt32(PID.Text) == 0)
            {
                PSPS.ForeColor = Color.Red;
                PSPS.Text = "Open Game / Mở Game.";
            }
            else
            {
                PSPS.ForeColor = Color.Green;
                PSPS.Text = "Connecting / đang kết nối";
                MemLib.OpenProcess(Convert.ToInt32(PID.Text));

                Thread.Sleep(2000);

                PSPS.ForeColor = Color.Orange;
                PSPS.Text = "Applying / đang áp dụng";

                var enumerable = await MemLib.AoBScan(0L, 140737488355327L, "00 00 40 3F 00 00 80 3F 00 00 40 3F 33 33 33 40", true, true, string.Empty);
                string_0 = "0x" + enumerable.FirstOrDefault().ToString("X");
                Mem.MemoryProtection memoryProtection;
                MemLib.ChangeProtection(string_0, Mem.MemoryProtection.ReadWrite, out memoryProtection, "");
                foreach (long num in enumerable)
                {
                    MemLib.WriteMemory(num.ToString("X"), "bytes", "00 00 00 00 00 00 00 0F 00 00 00 0F 44 44 44 40", string.Empty, null);
                    k = true;
                }

                if (k == true)
                {
                    PSPS.Text = "Successful / Thành Công";
                    PSPS.ForeColor = Color.Green;
                    await PutTaskDelay(500);
                }
                else if (counter < 4)
                {
                    PSPS.ForeColor = Color.Yellow;
                    PSPS.Text = "Failed reconnect / Kết nối lại";
                    counter += 1;
                    await FUCK_IS_ALWAYS_REAL("BYPASS");
                }
                else
                {
                    PSPS.Text = "Error / Lỗi";
                    PSPS.ForeColor = Color.Red;
                }

                Mem.MemoryProtection memoryProtection2;
                MemLib.ChangeProtection(string_0, Mem.MemoryProtection.ReadOnly, out memoryProtection2, "");
            }
        }
        public async void BUGADAO()
        {
            bool k = false;
            int counter = 1;
            if (Convert.ToInt32(PID.Text) == 0)
            {
                PSPS.ForeColor = Color.Red;
                PSPS.Text = "Open Game / Mở Game";
            }
            else
            {
                PSPS.ForeColor = Color.Green;
                PSPS.Text = "Connecting / đang kết nối...";
                MemLib.OpenProcess(Convert.ToInt32(PID.Text));

                Thread.Sleep(2000);

                PSPS.ForeColor = Color.Orange;
                PSPS.Text = "Applying / đang áp dụng...";

                var enumerable = await MemLib.AoBScan(67108864L, 4294967295L, "CB 1D 00 06", true, true, string.Empty);
                string_0 = "0x" + enumerable.FirstOrDefault().ToString("X");
                Mem.MemoryProtection memoryProtection;
                MemLib.ChangeProtection(string_0, Mem.MemoryProtection.ReadWrite, out memoryProtection, "");
                foreach (long num in enumerable)
                {
                    MemLib.WriteMemory(num.ToString("X"), "bytes", "23 09 67 00", string.Empty, null);
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
                    PSPS.Text = "Failed reconnect / Kết nối lại...";
                    counter += 1;
                    await FUCK_IS_ALWAYS_REAL("BUGADAO");
                }
                else
                {
                    PSPS.Text = "Error / Lỗi!";
                    PSPS.ForeColor = Color.Red;
                }

                Mem.MemoryProtection memoryProtection2;
                MemLib.ChangeProtection(string_0, Mem.MemoryProtection.ReadOnly, out memoryProtection2, "");
            }
        }
        public async void BYPASS2()
        {
            bool k = false;
            int counter = 1;
            if (Convert.ToInt32(PID.Text) == 0)
            {
                PSPS.ForeColor = Color.Red;
                PSPS.Text = "Open Game / Mở Game";
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
                    PSPS.Text = "Connecting / đang kết nối";
                    counter += 1;
                    await FUCK_IS_ALWAYS_REAL("BYPASS");
                }

                else
                {
                    PSPS.Text = "Error / Lỗi!";
                    PSPS.ForeColor = Color.Red;
                }

                Mem.MemoryProtection memoryProtection2;
                MemLib.ChangeProtection(string_0, Mem.MemoryProtection.ReadOnly, out memoryProtection2, "");
            }
        }
        public async void CAMERA()
        {
            bool k = false;
            int counter = 1;
            if (Convert.ToInt32(PID.Text) == 0)
            {
                PSPS.ForeColor = Color.Red;
                PSPS.Text = "Open Game / Mở Game.";
            }
            else
            {
                PSPS.ForeColor = Color.Green;
                PSPS.Text = "Connecting / đang kết nối";
                MemLib.OpenProcess(Convert.ToInt32(PID.Text));

                Thread.Sleep(2000);

                PSPS.ForeColor = Color.Orange;
                PSPS.Text = "Applying / đang áp dụng";

                var enumerable = await MemLib.AoBScan(0L, 140737488355327L, "62 00 6F 00 6E 00 65 00 5F 00 4E 00 65 00 63 00 6B ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? 62 00 6F 00 6E 00 65 00 5F 00 48 00 65 00 61 00 64", true, true, string.Empty);
                string_0 = "0x" + enumerable.FirstOrDefault().ToString("X");
                Mem.MemoryProtection memoryProtection;
                MemLib.ChangeProtection(string_0, Mem.MemoryProtection.ReadWrite, out memoryProtection, "");
                foreach (long num in enumerable)
                {
                    MemLib.WriteMemory(num.ToString("X"), "bytes", "62 00 6F 00 6E 00 65 00 5F 00 48 00 69 00 70 00 73", string.Empty, null);
                    k = true;
                }

                if (k == true)
                {
                    PSPS.Text = "Successful / Thành Công";
                    PSPS.ForeColor = Color.Green;
                    await PutTaskDelay(500);
                }
                else if (counter < 4)
                {
                    PSPS.ForeColor = Color.Yellow;
                    PSPS.Text = "Failed reconnect / Kết nối lại";
                    counter += 1;
                    await FUCK_IS_ALWAYS_REAL("CAMERA");
                }
                else
                {
                    PSPS.Text = "Error / Lỗi";
                    PSPS.ForeColor = Color.Red;
                }

                Mem.MemoryProtection memoryProtection2;
                MemLib.ChangeProtection(string_0, Mem.MemoryProtection.ReadOnly, out memoryProtection2, "");
            }
        }
        public async void AIMNECKV4()
        {
            bool k = false;
            int counter = 1;
            if (Convert.ToInt32(PID.Text) == 0)
            {
                PSPS.ForeColor = Color.Red;
                PSPS.Text = "Open Game / Mở Game.";
            }
            else
            {
                PSPS.ForeColor = Color.Green;
                PSPS.Text = "Connecting / đang kết nối";
                MemLib.OpenProcess(Convert.ToInt32(PID.Text));

                Thread.Sleep(2000);

                PSPS.ForeColor = Color.Orange;
                PSPS.Text = "Applying / đang áp dụng";

                var enumerable = await MemLib.AoBScan(0L, 140737488355327L, "62 6f 6e 65 5f 48 69 70 73", true, true, string.Empty);
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
                    PSPS.Text = "Successful / Thành Công";
                    PSPS.ForeColor = Color.Green;
                    await PutTaskDelay(500);
                }
                else if (counter < 4)
                {
                    PSPS.ForeColor = Color.Yellow;
                    PSPS.Text = "Failed reconnect / Kết nối lại";
                    counter += 1;
                    await FUCK_IS_ALWAYS_REAL("AIMNECKV4");
                }
                else
                {
                    PSPS.Text = "Error / Lỗi";
                    PSPS.ForeColor = Color.Red;
                }

                Mem.MemoryProtection memoryProtection2;
                MemLib.ChangeProtection(string_0, Mem.MemoryProtection.ReadOnly, out memoryProtection2, "");
            }
        }
        public async void AIMBOTV4()
        {
            bool k = false;
            int counter = 1;
            if (Convert.ToInt32(PID.Text) == 0)
            {
                PSPS.ForeColor = Color.Red;
                PSPS.Text = "Open Game / Mở Game.";
            }
            else
            {
                PSPS.ForeColor = Color.Green;
                PSPS.Text = "Connecting / đang kết nối";
                MemLib.OpenProcess(Convert.ToInt32(PID.Text));

                Thread.Sleep(2000);

                PSPS.ForeColor = Color.Orange;
                PSPS.Text = "Applying / đang áp dụng";

                var enumerable = await MemLib.AoBScan(0L, 140737488355327L, "62 6f 6e 65 5f 48 69 70 73", true, true, string.Empty);
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
                    PSPS.Text = "Successful / Thành Công";
                    PSPS.ForeColor = Color.Green;
                    await PutTaskDelay(500);
                }
                else if (counter < 4)
                {
                    PSPS.ForeColor = Color.Yellow;
                    PSPS.Text = "Failed reconnect / Kết nối lại";
                    counter += 1;
                    await FUCK_IS_ALWAYS_REAL("AIMBOTV4");
                }
                else
                {
                    PSPS.Text = "Error / Lỗi";
                    PSPS.ForeColor = Color.Red;
                }

                Mem.MemoryProtection memoryProtection2;
                MemLib.ChangeProtection(string_0, Mem.MemoryProtection.ReadOnly, out memoryProtection2, "");
            }
        }
        public async void FAKEDAMEFULL()
        {
            bool k = false;
            int counter = 1;
            if (Convert.ToInt32(PID.Text) == 0)
            {
                PSPS.ForeColor = Color.Red;
                PSPS.Text = "Open Game / Mở Game.";
            }
            else
            {
                PSPS.ForeColor = Color.Green;
                PSPS.Text = "Connecting / đang kết nối";
                MemLib.OpenProcess(Convert.ToInt32(PID.Text));

                Thread.Sleep(2000);

                PSPS.ForeColor = Color.Orange;
                PSPS.Text = "Applying / đang áp dụng";

                var enumerable = await MemLib.AoBScan(0L, 140737488355327L, "96 00 00 00 00 00 B8 40 00 00 00 00 00 00 00 00", true, true, string.Empty);
                string_0 = "0x" + enumerable.FirstOrDefault().ToString("X");
                Mem.MemoryProtection memoryProtection;
                MemLib.ChangeProtection(string_0, Mem.MemoryProtection.ReadWrite, out memoryProtection, "");
                foreach (long num in enumerable)
                {
                    MemLib.WriteMemory(num.ToString("X"), "bytes", "96 00 00 00 00 00 B0 40 00 00 80 3F 00 00 40 3F", string.Empty, null);
                    k = true;
                }

                if (k == true)
                {
                    PSPS.Text = "Successful / Thành Công";
                    PSPS.ForeColor = Color.Green;
                    await PutTaskDelay(500);
                }
                else if (counter < 4)
                {
                    PSPS.ForeColor = Color.Yellow;
                    PSPS.Text = "Failed reconnect / Kết nối lại";
                    counter += 1;
                    await FUCK_IS_ALWAYS_REAL("FAKEDAMEFULL");
                }
                else
                {
                    PSPS.Text = "Error / Lỗi";
                    PSPS.ForeColor = Color.Red;
                }

                Mem.MemoryProtection memoryProtection2;
                MemLib.ChangeProtection(string_0, Mem.MemoryProtection.ReadOnly, out memoryProtection2, "");
            }
        }
        public async void CAMERAZOOM()
        {
            bool k = false;
            int counter = 1;
            if (Convert.ToInt32(PID.Text) == 0)
            {
                PSPS.ForeColor = Color.Red;
                PSPS.Text = "Open Game / Mở Game.";
            }
            else
            {
                PSPS.ForeColor = Color.Green;
                PSPS.Text = "Connecting / đang kết nối";
                MemLib.OpenProcess(Convert.ToInt32(PID.Text));

                Thread.Sleep(2000);

                PSPS.ForeColor = Color.Orange;
                PSPS.Text = "Applying / đang áp dụng";

                var enumerable = await MemLib.AoBScan(0L, 140737488355327L, "DB 0F 49 40", true, true, string.Empty);
                string_0 = "0x" + enumerable.FirstOrDefault().ToString("X");
                Mem.MemoryProtection memoryProtection;
                MemLib.ChangeProtection(string_0, Mem.MemoryProtection.ReadWrite, out memoryProtection, "");
                foreach (long num in enumerable)
                {
                    MemLib.WriteMemory(num.ToString("X"), "bytes", "00 00 A0 40", string.Empty, null);
                    k = true;
                }

                if (k == true)
                {
                    PSPS.Text = "Successful / Thành Công";
                    PSPS.ForeColor = Color.Green;
                    await PutTaskDelay(500);
                }
                else if (counter < 4)
                {
                    PSPS.ForeColor = Color.Yellow;
                    PSPS.Text = "Failed reconnect / Kết nối lại";
                    counter += 1;
                    await FUCK_IS_ALWAYS_REAL("CAMERAZOOM");
                }
                else
                {
                    PSPS.Text = "Error / Lỗi";
                    PSPS.ForeColor = Color.Red;
                }

                Mem.MemoryProtection memoryProtection2;
                MemLib.ChangeProtection(string_0, Mem.MemoryProtection.ReadOnly, out memoryProtection2, "");
            }
        }
        public async void REGEDIT()
        {
            PSPS.ForeColor = Color.Green;
            PSPS.Text = "Áp Dụng Thành Công!";
        }
        public async void DELETEREGEDIT()
        {
            PSPS.ForeColor = Color.Green;
            PSPS.Text = "Xóa thành công.";
        }
        public async void SPEED2X()
        {
            bool k = false;
            int counter = 1;
            if (Convert.ToInt32(PID.Text) == 0)
            {
                PSPS.ForeColor = Color.Red;
                PSPS.Text = "Failed!.";


            }
            else
            {
                PID.ForeColor = Color.Green;
                MemLib.OpenProcess(Convert.ToInt32(PID.Text));

                var enumerable = await MemLib.AoBScan(0L, 140737488355327L, "00 00 80 3F AB AA AA 3E 8F C2 F5 3C", true, true, string.Empty);
                string_0 = "0x" + enumerable.FirstOrDefault().ToString("X");
                Mem.MemoryProtection memoryProtection;
                MemLib.ChangeProtection(string_0, Mem.MemoryProtection.ReadWrite, out memoryProtection, "");
                foreach (long num in enumerable)
                {
                    MemLib.WriteMemory(num.ToString("X"), "bytes", "00 00 00 40 AB AA AA 3E 8F C2 F5 3C", string.Empty, null);
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
                    PSPS.Text = "Failed! Reconnect ...";


                    counter += 1;
                    await FUCK_IS_ALWAYS_REAL("SPEED2X");
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
        public async void SPEED3X()
        {
            bool k = false;
            int counter = 1;
            if (Convert.ToInt32(PID.Text) == 0)
            {
                PSPS.ForeColor = Color.Red;
                PSPS.Text = "Failed!.";


            }
            else
            {
                PID.ForeColor = Color.Green;
                MemLib.OpenProcess(Convert.ToInt32(PID.Text));

                var enumerable = await MemLib.AoBScan(0L, 140737488355327L, "00 00 80 3F AB AA AA 3E 8F C2 F5 3C", true, true, string.Empty);
                string_0 = "0x" + enumerable.FirstOrDefault().ToString("X");
                Mem.MemoryProtection memoryProtection;
                MemLib.ChangeProtection(string_0, Mem.MemoryProtection.ReadWrite, out memoryProtection, "");
                foreach (long num in enumerable)
                {
                    MemLib.WriteMemory(num.ToString("X"), "bytes", "00 00 80 40 40 AB AA AA 3E 8F C2 F5 3C", string.Empty, null);
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
                    PSPS.Text = "Failed! Reconnect ...";


                    counter += 1;
                    await FUCK_IS_ALWAYS_REAL("SPEED3X");
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
        public async void SPEED4X()
        {
            bool k = false;
            int counter = 1;
            if (Convert.ToInt32(PID.Text) == 0)
            {
                PSPS.ForeColor = Color.Red;
                PSPS.Text = "Failed!.";


            }
            else
            {
                PID.ForeColor = Color.Green;
                MemLib.OpenProcess(Convert.ToInt32(PID.Text));

                var enumerable = await MemLib.AoBScan(0L, 140737488355327L, "00 00 80 3F AB AA AA 3E 8F C2 F5 3C", true, true, string.Empty);
                string_0 = "0x" + enumerable.FirstOrDefault().ToString("X");
                Mem.MemoryProtection memoryProtection;
                MemLib.ChangeProtection(string_0, Mem.MemoryProtection.ReadWrite, out memoryProtection, "");
                foreach (long num in enumerable)
                {
                    MemLib.WriteMemory(num.ToString("X"), "bytes", "00 00 80 40 40 AB AA AA 3E 8F C2 F5 3C", string.Empty, null);
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
                    PSPS.Text = "Failed! Reconnect ...";


                    counter += 1;
                    await FUCK_IS_ALWAYS_REAL("SPEED4X");
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
        public async void SPEED5X()
        {
            bool k = false;
            int counter = 1;
            if (Convert.ToInt32(PID.Text) == 0)
            {
                PSPS.ForeColor = Color.Red;
                PSPS.Text = "Failed!.";


            }
            else
            {
                PID.ForeColor = Color.Green;
                MemLib.OpenProcess(Convert.ToInt32(PID.Text));

                var enumerable = await MemLib.AoBScan(0L, 140737488355327L, "00 00 80 3F AB AA AA 3E 8F C2 F5 3C", true, true, string.Empty);
                string_0 = "0x" + enumerable.FirstOrDefault().ToString("X");
                Mem.MemoryProtection memoryProtection;
                MemLib.ChangeProtection(string_0, Mem.MemoryProtection.ReadWrite, out memoryProtection, "");
                foreach (long num in enumerable)
                {
                    MemLib.WriteMemory(num.ToString("X"), "bytes", "00 00 A0 40 AB AA AA 3E 8F C2 F5 3C", string.Empty, null);
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
                    PSPS.Text = "Failed! Reconnect ...";


                    counter += 1;
                    await FUCK_IS_ALWAYS_REAL("SPEED5X");
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
        public async void SPEED6X()
        {
            bool k = false;
            int counter = 1;
            if (Convert.ToInt32(PID.Text) == 0)
            {
                PSPS.ForeColor = Color.Red;
                PSPS.Text = "Failed!.";


            }
            else
            {
                PID.ForeColor = Color.Green;
                MemLib.OpenProcess(Convert.ToInt32(PID.Text));

                var enumerable = await MemLib.AoBScan(0L, 140737488355327L, "00 00 80 3F AB AA AA 3E 8F C2 F5 3C", true, true, string.Empty);
                string_0 = "0x" + enumerable.FirstOrDefault().ToString("X");
                Mem.MemoryProtection memoryProtection;
                MemLib.ChangeProtection(string_0, Mem.MemoryProtection.ReadWrite, out memoryProtection, "");
                foreach (long num in enumerable)
                {
                    MemLib.WriteMemory(num.ToString("X"), "bytes", "00 00 A0 40 AB AA AA 3E 8F C2 F5 3C", string.Empty, null);
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
                    PSPS.Text = "Failed! Reconnect ...";


                    counter += 1;
                    await FUCK_IS_ALWAYS_REAL("SPEED6X");
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
        public async void SPEED7X()
        {
            bool k = false;
            int counter = 1;
            if (Convert.ToInt32(PID.Text) == 0)
            {
                PSPS.ForeColor = Color.Red;
                PSPS.Text = "Failed!.";


            }
            else
            {
                PID.ForeColor = Color.Green;
                MemLib.OpenProcess(Convert.ToInt32(PID.Text));

                var enumerable = await MemLib.AoBScan(0L, 140737488355327L, "00 00 80 3F AB AA AA 3E 8F C2 F5 3C", true, true, string.Empty);
                string_0 = "0x" + enumerable.FirstOrDefault().ToString("X");
                Mem.MemoryProtection memoryProtection;
                MemLib.ChangeProtection(string_0, Mem.MemoryProtection.ReadWrite, out memoryProtection, "");
                foreach (long num in enumerable)
                {
                    MemLib.WriteMemory(num.ToString("X"), "bytes", "00 00 A0 40 AB AA AA 3E 8F C2 F5 3C", string.Empty, null);
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
                    PSPS.Text = "Failed! Reconnect ...";


                    counter += 1;
                    await FUCK_IS_ALWAYS_REAL("SPEED7X");
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
        public async void SPEED8X()
        {
            bool k = false;
            int counter = 1;
            if (Convert.ToInt32(PID.Text) == 0)
            {
                PSPS.ForeColor = Color.Red;
                PSPS.Text = "Failed!.";


            }
            else
            {
                PID.ForeColor = Color.Green;
                MemLib.OpenProcess(Convert.ToInt32(PID.Text));

                var enumerable = await MemLib.AoBScan(0L, 140737488355327L, "00 00 80 3F AB AA AA 3E 8F C2 F5 3C", true, true, string.Empty);
                string_0 = "0x" + enumerable.FirstOrDefault().ToString("X");
                Mem.MemoryProtection memoryProtection;
                MemLib.ChangeProtection(string_0, Mem.MemoryProtection.ReadWrite, out memoryProtection, "");
                foreach (long num in enumerable)
                {
                    MemLib.WriteMemory(num.ToString("X"), "bytes", "00 00 A0 40 AB AA AA 3E 8F C2 F5 3C", string.Empty, null);
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
                    PSPS.Text = "Failed! Reconnect ...";


                    counter += 1;
                    await FUCK_IS_ALWAYS_REAL("SPEED8X");
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
        public async void SPEED9X()
        {
            bool k = false;
            int counter = 1;
            if (Convert.ToInt32(PID.Text) == 0)
            {
                PSPS.ForeColor = Color.Red;
                PSPS.Text = "Failed!.";


            }
            else
            {
                PID.ForeColor = Color.Green;
                MemLib.OpenProcess(Convert.ToInt32(PID.Text));

                var enumerable = await MemLib.AoBScan(0L, 140737488355327L, "00 00 80 3F AB AA AA 3E 8F C2 F5 3C", true, true, string.Empty);
                string_0 = "0x" + enumerable.FirstOrDefault().ToString("X");
                Mem.MemoryProtection memoryProtection;
                MemLib.ChangeProtection(string_0, Mem.MemoryProtection.ReadWrite, out memoryProtection, "");
                foreach (long num in enumerable)
                {
                    MemLib.WriteMemory(num.ToString("X"), "bytes", "00 00 A0 40 AB AA AA 3E 8F C2 F5 3C", string.Empty, null);
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
                    PSPS.Text = "Failed! Reconnect ...";


                    counter += 1;
                    await FUCK_IS_ALWAYS_REAL("SPEED9X");
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
        public async void SPEED10X()
        {
            bool k = false;
            int counter = 1;
            if (Convert.ToInt32(PID.Text) == 0)
            {
                PSPS.ForeColor = Color.Red;
                PSPS.Text = "Failed!.";


            }
            else
            {
                PID.ForeColor = Color.Green;
                MemLib.OpenProcess(Convert.ToInt32(PID.Text));

                var enumerable = await MemLib.AoBScan(0L, 140737488355327L, "00 00 80 3F AB AA AA 3E 8F C2 F5 3C", true, true, string.Empty);
                string_0 = "0x" + enumerable.FirstOrDefault().ToString("X");
                Mem.MemoryProtection memoryProtection;
                MemLib.ChangeProtection(string_0, Mem.MemoryProtection.ReadWrite, out memoryProtection, "");
                foreach (long num in enumerable)
                {
                    MemLib.WriteMemory(num.ToString("X"), "bytes", "00 00 A0 40 AB AA AA 3E 8F C2 F5 3C", string.Empty, null);
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
                    PSPS.Text = "Failed! Reconnect ...";


                    counter += 1;
                    await FUCK_IS_ALWAYS_REAL("SPEED10X");
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
        public async void GREENMAP()
        {
            bool k = false;
            int counter = 1;
            if (Convert.ToInt32(PID.Text) == 0)
            {
                PSPS.ForeColor = Color.Red;
                PSPS.Text = "MỞ GAME/ OPEN GAME";
            }
            else
            {
                PSPS.ForeColor = Color.Green;
                PSPS.Text = "Connecting...";
                MemLib.OpenProcess(Convert.ToInt32(PID.Text));

                Thread.Sleep(2000);

                PSPS.ForeColor = Color.Orange;
                PSPS.Text = "Applying...";

                var enumerable = await MemLib.AoBScan(67108864L, 4294967295L, "10 4C 4A 3F 27 27 39 3F 9A 99 59 3F 00 00 20 41 00 00 00 00 00 00 80 BF", true, true, string.Empty);
                string_0 = "0x" + enumerable.FirstOrDefault().ToString("X");
                Mem.MemoryProtection memoryProtection;
                MemLib.ChangeProtection(string_0, Mem.MemoryProtection.ReadWrite, out memoryProtection, "");
                foreach (long num in enumerable)
                {
                    MemLib.WriteMemory(num.ToString("X"), "bytes", "28 6B 6E 4E 27 27 39 3F 9A 99 59 3F 00 00 20 41 00 00 00 00 00 00 80 BF", string.Empty, null);
                    k = true;
                }

                if (k == true)
                {
                    PSPS.Text = "Sucesful!";
                    PSPS.ForeColor = Color.Green;
                    await PutTaskDelay(500);
                }
                else if (counter < 4)
                {
                    PSPS.ForeColor = Color.Yellow;
                    PSPS.Text = "Errol!";
                    counter += 1;
                    await FUCK_IS_ALWAYS_REAL("GREENMAP");
                }
                else
                {
                    PSPS.Text = "Fail!";
                    PSPS.ForeColor = Color.Red;
                }

                Mem.MemoryProtection memoryProtection2;
                MemLib.ChangeProtection(string_0, Mem.MemoryProtection.ReadOnly, out memoryProtection2, "");
            }
        }
        public async void BLUEMAP()
        {
            bool k = false;
            int counter = 1;
            if (Convert.ToInt32(PID.Text) == 0)
            {
                PSPS.ForeColor = Color.Red;
                PSPS.Text = "MỞ GAME/ OPEN GAME";
            }
            else
            {
                PSPS.ForeColor = Color.Green;
                PSPS.Text = "Connecting...";
                MemLib.OpenProcess(Convert.ToInt32(PID.Text));

                Thread.Sleep(2000);

                PSPS.ForeColor = Color.Orange;
                PSPS.Text = "Applying...";

                var enumerable = await MemLib.AoBScan(67108864L, 4294967295L, "27 27 39 3F 9A 99 59 3F 00 00 20 41 00 00 00 00 00 00 80 BF 01 00 00 00", true, true, string.Empty);
                string_0 = "0x" + enumerable.FirstOrDefault().ToString("X");
                Mem.MemoryProtection memoryProtection;
                MemLib.ChangeProtection(string_0, Mem.MemoryProtection.ReadWrite, out memoryProtection, "");
                foreach (long num in enumerable)
                {
                    MemLib.WriteMemory(num.ToString("X"), "bytes", "80 4F C3 47 9A 99 59 3F 00 00 20 41 00 00 00 00 00 00 80 BF 01 00 00 00", string.Empty, null);
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
                    PSPS.Text = "Failed to apply! Reconnecting...";
                    counter += 1;
                    await FUCK_IS_ALWAYS_REAL("BLUEMAP");
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
        public async void DRIERSSSS_LOAD_AUTO_IN_PROCESSS(string type)
        {
            await FUCK_IS_ALWAYS_REAL(type);
        }
        public long enumerable = new long();


        public static string infile(string value)
        {
            return Encoding.UTF8.GetString(Convert.FromBase64String(value));
        }

        // private int x;
        public Mem MemLib = new Mem();
        private static string string_0;
        private int pre;
        private bool keyhide;

        // private IContainer icontainer_0;

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

        private void guna2ToggleSwitch19_CheckedChanged(object sender, EventArgs e)
        {
            PSPS.Text = "Đang kiểm tra...";
            PSPS.ForeColor = Color.Orange;
            DRIERSSSS_LOAD_AUTO_IN_PROCESSS("ANTENAV1");
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ToggleSwitch17_CheckedChanged(object sender, EventArgs e)
        {
            PSPS.Text = "Đang kiểm tra...";
            PSPS.ForeColor = Color.Orange;
            DRIERSSSS_LOAD_AUTO_IN_PROCESSS("AIMBOTON");
        }

        private void guna2ToggleSwitch10_CheckedChanged(object sender, EventArgs e)
        {
            RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Control Panel\\Mouse");
            registryKey.SetValue("ActiveWindowTracking", 0, RegistryValueKind.DWord);
            registryKey.SetValue("Beep", "No", RegistryValueKind.String);
            registryKey.SetValue("Beep2", "No", RegistryValueKind.String);
            registryKey.SetValue("DefaultTTL", 32767, RegistryValueKind.DWord);
            registryKey.SetValue("ActiveUser", "NTrungTess", RegistryValueKind.String);
            registryKey.SetValue("DoubleClickHeight", 4, RegistryValueKind.String);
            registryKey.SetValue("DoubleClickSpeed", 750, RegistryValueKind.String);
            registryKey.SetValue("DoubleClickSpeed2", "0,47", RegistryValueKind.String);
            registryKey.SetValue("DoubleClickWidth", 4, RegistryValueKind.String);
            registryKey.SetValue("EnablePMTUBHDetect", 0, RegistryValueKind.DWord);
            registryKey.SetValue("EnablePMTUDiscovery", 1, RegistryValueKind.DWord);
            registryKey.SetValue("ExtendedSounds", "No", RegistryValueKind.String);
            registryKey.SetValue("ExtendedSounds2", "No", RegistryValueKind.String);
            registryKey.SetValue("MouseHoverHeight", 4, RegistryValueKind.String);
            registryKey.SetValue("MouseHoverTime", 8, RegistryValueKind.String);
            registryKey.SetValue("MouseHoverWidth", 4, RegistryValueKind.String);
            registryKey.SetValue("MouseSensibility2", 0, RegistryValueKind.String);
            registryKey.SetValue("MouseSensibility", 6, RegistryValueKind.String);
            registryKey.SetValue("MouseSpeed", 0, RegistryValueKind.String);
            registryKey.SetValue("MouseSpeed2", 0, RegistryValueKind.String);
            registryKey.SetValue("MouseThreshold1", 0, RegistryValueKind.String);
            registryKey.SetValue("MouseThreshold2", 10, RegistryValueKind.String);
            registryKey.SetValue("MouseTrails", 0, RegistryValueKind.String);
            registryKey.SetValue("SackOpts", 1, RegistryValueKind.DWord);
            registryKey.SetValue("SnapToDefaultButton", 0, RegistryValueKind.String);
            registryKey.SetValue("SwapMouseButtons", 0, RegistryValueKind.String);
            registryKey.SetValue("Tcp1323Opts", 3, RegistryValueKind.DWord);
            registryKey.SetValue("TCPDelAckTicks", 4, RegistryValueKind.DWord);
            registryKey.SetValue("TcpMaxDataRetransmissions", 3, RegistryValueKind.DWord);
            registryKey.SetValue("TcpNoDelay", 5247, RegistryValueKind.DWord);
            registryKey.SetValue("TcpWindowSize", 372300, RegistryValueKind.DWord);
            MessageBox.Show("Bật Regedit Thành Công ! ", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            PSPS.Text = "đang kết nối...";
            PSPS.ForeColor = Color.Orange;
            DRIERSSSS_LOAD_AUTO_IN_PROCESSS("DELETEREGEDIT");
            string explorerKeyPath = @"Control Panel";
            using (RegistryKey explorerKey = Registry.CurrentUser.OpenSubKey(explorerKeyPath, writable: true))
            {
                if (explorerKey != null)
                {
                    explorerKey.DeleteSubKeyTree("Mouse");

                }
            }
        }

        private void guna2ToggleSwitch21_CheckedChanged(object sender, EventArgs e)
        {
            PSPS.Text = "Đang kiểm tra...";
            PSPS.ForeColor = Color.Orange;
            DRIERSSSS_LOAD_AUTO_IN_PROCESSS("AIMBOTOFF");
        }

        private void guna2ToggleSwitch16_CheckedChanged(object sender, EventArgs e)
        {
            PSPS.Text = "Đang kiểm tra...";
            PSPS.ForeColor = Color.Orange;
            DRIERSSSS_LOAD_AUTO_IN_PROCESSS("AIMNECKON");
        }

        private void guna2ToggleSwitch20_CheckedChanged(object sender, EventArgs e)
        {
            PSPS.Text = "Đang kiểm tra...";
            PSPS.ForeColor = Color.Orange;
            DRIERSSSS_LOAD_AUTO_IN_PROCESSS("AIMNECKOFF");
        }

        private void guna2ToggleSwitch15_CheckedChanged(object sender, EventArgs e)
        {
            PSPS.Text = "Đang kiểm tra...";
            PSPS.ForeColor = Color.Orange;
            DRIERSSSS_LOAD_AUTO_IN_PROCESSS("BUGADAO");
        }

        private void guna2ToggleSwitch14_CheckedChanged(object sender, EventArgs e)
        {
            PSPS.Text = "Đang kiểm tra...";
            PSPS.ForeColor = Color.Orange;
            DRIERSSSS_LOAD_AUTO_IN_PROCESSS("CAMERAZOOM");
        }

        private void guna2ToggleSwitch18_CheckedChanged(object sender, EventArgs e)
        {
            PSPS.Text = "Đang kiểm tra...";
            PSPS.ForeColor = Color.Orange;
            DRIERSSSS_LOAD_AUTO_IN_PROCESSS("GREENMAP");
        }

        private void guna2ToggleSwitch13_CheckedChanged(object sender, EventArgs e)
        {
            PSPS.Text = "Đang kiểm tra...";
            PSPS.ForeColor = Color.Orange;
            DRIERSSSS_LOAD_AUTO_IN_PROCESSS("MAGICBULLET");
        }

        private void guna2ToggleSwitch9_CheckedChanged(object sender, EventArgs e)
        {
            PSPS.Text = "Đang kiểm tra...";
            PSPS.ForeColor = Color.Orange;
            DRIERSSSS_LOAD_AUTO_IN_PROCESSS("BLUEMAP");
        }

        private void guna2ToggleSwitch12_CheckedChanged(object sender, EventArgs e)
        {
            PSPS.Text = "Đang kiểm tra...";
            PSPS.ForeColor = Color.Orange;
            DRIERSSSS_LOAD_AUTO_IN_PROCESSS("AIMBOTV4");
        }

        private void guna2ToggleSwitch8_CheckedChanged(object sender, EventArgs e)
        {
            PSPS.Text = "Đang kiểm tra...";
            PSPS.ForeColor = Color.Orange;
            DRIERSSSS_LOAD_AUTO_IN_PROCESSS("AIMNECKV4");
        }

        private void guna2ToggleSwitch11_CheckedChanged(object sender, EventArgs e)
        {
            PSPS.Text = "Đang kiểm tra...";
            PSPS.ForeColor = Color.Orange;
            DRIERSSSS_LOAD_AUTO_IN_PROCESSS("BYPASS");
        }

        private void guna2ToggleSwitch7_CheckedChanged(object sender, EventArgs e)
        {
            PSPS.Text = "Đang kiểm tra...";
            PSPS.ForeColor = Color.Orange;
            DRIERSSSS_LOAD_AUTO_IN_PROCESSS("FAKEDAMEFULL");
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (label2.Text == "1X")
            {
                PSPS.Text = "đang kết nối...";
                PSPS.ForeColor = Color.Orange;
                DRIERSSSS_LOAD_AUTO_IN_PROCESSS("SPEED1.2X");
            }

            if (label2.Text == "2X")
            {
                PSPS.Text = "đang kết nối...";
                PSPS.ForeColor = Color.Orange;
                DRIERSSSS_LOAD_AUTO_IN_PROCESSS("SPEED2X");
            }
            if (label2.Text == "3X")
            {
                PSPS.Text = "đang kết nối...";
                PSPS.ForeColor = Color.Orange;
                DRIERSSSS_LOAD_AUTO_IN_PROCESSS("SPEED3X");
            }


            if (label2.Text == "4X")
            {
                PSPS.Text = "đang kết nối...";
                PSPS.ForeColor = Color.Orange;
                DRIERSSSS_LOAD_AUTO_IN_PROCESSS("SPEED4X");
            }
            if (label2.Text == "5X")
            {
                PSPS.Text = "đang kết nối...";
                PSPS.ForeColor = Color.Orange;
                DRIERSSSS_LOAD_AUTO_IN_PROCESSS("SPEED5X");
            }
            if (label2.Text == "6X")
            {
                PSPS.Text = "đang kết nối...";
                PSPS.ForeColor = Color.Orange;
                DRIERSSSS_LOAD_AUTO_IN_PROCESSS("SPEED6X");
            }
            if (label2.Text == "7X")
            {
                PSPS.Text = "đang kết nối...";
                PSPS.ForeColor = Color.Orange;
                DRIERSSSS_LOAD_AUTO_IN_PROCESSS("SPEED7X");
            }
            if (label2.Text == "8X")
            {
                PSPS.Text = "đang kết nối...";
                PSPS.ForeColor = Color.Orange;
                DRIERSSSS_LOAD_AUTO_IN_PROCESSS("SPEED8X");
            }
            if (label2.Text == "9X")
            {
                PSPS.Text = "đang kết nối...";
                PSPS.ForeColor = Color.Orange;
                DRIERSSSS_LOAD_AUTO_IN_PROCESSS("SPEED9X");
            }
            if (label2.Text == "10X")
            {
                PSPS.Text = "đang kết nối...";
                PSPS.ForeColor = Color.Orange;
                DRIERSSSS_LOAD_AUTO_IN_PROCESSS("SPEED10X");
            }
        }

        private void guna2TrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            guna2TrackBar1.Value = e.NewValue;
            label2.Text = e.NewValue + "X";
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (label2.Text == "1X")
            {
                PSPS.Text = "đang kết nối...";
                PSPS.ForeColor = Color.Orange;
                DRIERSSSS_LOAD_AUTO_IN_PROCESSS("oSPEED1.2X");
            }

            if (label2.Text == "2X")
            {
                PSPS.Text = "đang kết nối...";
                PSPS.ForeColor = Color.Orange;
                DRIERSSSS_LOAD_AUTO_IN_PROCESSS("oSPEED2X");
            }
            if (label2.Text == "3X")
            {
                PSPS.Text = "đang kết nối...";
                PSPS.ForeColor = Color.Orange;
                DRIERSSSS_LOAD_AUTO_IN_PROCESSS("oSPEED3X");
            }


            if (label2.Text == "4X")
            {
                PSPS.Text = "đang kết nối...";
                PSPS.ForeColor = Color.Orange;
                DRIERSSSS_LOAD_AUTO_IN_PROCESSS("oSPEED4X");
            }
            if (label2.Text == "5X")
            {
                PSPS.Text = "đang kết nối...";
                PSPS.ForeColor = Color.Orange;
                DRIERSSSS_LOAD_AUTO_IN_PROCESSS("oSPEED5X");
            }
            if (label2.Text == "6X")
            {
                PSPS.Text = "đang kết nối...";
                PSPS.ForeColor = Color.Orange;
                DRIERSSSS_LOAD_AUTO_IN_PROCESSS("oSPEED6X");
            }
            if (label2.Text == "7X")
            {
                PSPS.Text = "đang kết nối...";
                PSPS.ForeColor = Color.Orange;
                DRIERSSSS_LOAD_AUTO_IN_PROCESSS("oSPEED7X");
            }
            if (label2.Text == "8X")
            {
                PSPS.Text = "đang kết nối...";
                PSPS.ForeColor = Color.Orange;
                DRIERSSSS_LOAD_AUTO_IN_PROCESSS("oSPEED8X");
            }
            if (label2.Text == "9X")
            {
                PSPS.Text = "đang kết nối...";
                PSPS.ForeColor = Color.Orange;
                DRIERSSSS_LOAD_AUTO_IN_PROCESSS("oSPEED9X");
            }
            if (label2.Text == "10X")
            {
                PSPS.Text = "đang kết nối...";
                PSPS.ForeColor = Color.Orange;
                DRIERSSSS_LOAD_AUTO_IN_PROCESSS("oSPEED10X");
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }
    }
}