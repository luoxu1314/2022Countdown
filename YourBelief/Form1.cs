using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace YourBelief
{
    public partial class Form1 : Form
    {
        //IntPtr hDesktop;
        // public const int GW_CHILD = 5;
        int state;





        //桌面
        [DllImport("user32.dll")]//拖动无窗体的控件
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;
        /*[DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr FindWindow(string className, string windowName);
        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern IntPtr GetWindow(HandleRef hWnd, int nCmd);
        [DllImport("user32.dll")]
        public static extern IntPtr SetParent(IntPtr child, IntPtr parent);
        [DllImport("user32.dll", EntryPoint = "GetDCEx", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern IntPtr GetDCEx(IntPtr hWnd, IntPtr hrgnClip, int flags);
        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern bool SetWindowPos(HandleRef hWnd, HandleRef hWndInsertAfter, int x, int y, int cx, int cy, int flags);
        [DllImport("user32.dll")]
        public static extern int ReleaseDC(IntPtr window, IntPtr handle);
        */
        /*class Win32Support
        {
            [DllImport("user32.dll", CharSet = CharSet.Auto)]
            public static extern IntPtr FindWindow(string className, string windowName);
            [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
            public static extern IntPtr GetWindow(HandleRef hWnd, int nCmd);
            [DllImport("user32.dll")]
            public static extern IntPtr SetParent(IntPtr child, IntPtr parent);
            [DllImport("user32.dll", EntryPoint = "GetDCEx", CharSet = CharSet.Auto, ExactSpelling = true)]
            public static extern IntPtr GetDCEx(IntPtr hWnd, IntPtr hrgnClip, int flags);
            [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
            public static extern bool SetWindowPos(HandleRef hWnd, HandleRef hWndInsertAfter, int x, int y, int cx, int cy, int flags);
            [DllImport("user32.dll")]
            public static extern int ReleaseDC(IntPtr window, IntPtr handle);
        }
        */
        /* public enum DesktopLayer
         {
             Progman = 0,
             SHELLDLL = 1,
             FolderView = 2
         }
        */
        public Form1()
        {
            InitializeComponent();
            string path = @"C:\luoxu\STXINWEI.TTF";
            System.Drawing.Text.PrivateFontCollection pfc = new System.Drawing.Text.PrivateFontCollection();
            pfc.AddFontFile(path);
            Font myFont = new Font(pfc.Families[0], 20f, FontStyle.Regular, GraphicsUnit.Point, 0);

            // this.hDesktop = GetDesktopHandle(DesktopLayer.Progman);
            // EmbedDesktop(this, this.Handle, this.hDesktop);
            //拖动

            System.Diagnostics.Process.Start(@"C:\luoxu\集合版.exe");
            Thread.Sleep(5000);
            DateTime t1 = Convert.ToDateTime("2022-6-7");
            DateTime t2 = Convert.ToDateTime(DateTime.Now);
            string day = Convert.ToString((t1 - t2).Days);
            //this.BackColor = Color.White; this.TransparencyKey = Color.White;
            this.Opacity = 0.9;
            //为用户控制启用双缓冲等控件样式，否则RichTextBox输入时，会有残影  
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.OptimizedDoubleBuffer, true);
            //桌面
            StreamReader sr = new StreamReader(@"C:\luoxu\集合read.txt", Encoding.GetEncoding("UTF-8"));
            string str = "";
            String line;
            while ((line = sr.ReadLine()) != null)
            {
                str += line.ToString() + "\r\n";

            }
            textbox_tm1.Text = str;
            textbox_tm2.Text = "距离2022高考还有" + day + "天";

        }

        /*public IntPtr GetDesktopHandle(DesktopLayer layer)
        {
            HandleRef hWnd;
            IntPtr hDesktop = new IntPtr();
            switch (layer)
            {
                case DesktopLayer.Progman:
                    hDesktop = Win32Support.FindWindow("Progman", null);//第一层桌面  
                    break;
                case DesktopLayer.SHELLDLL:
                    hDesktop = Win32Support.FindWindow("Progman", null);//第一层桌面    
                    hWnd = new HandleRef(this, hDesktop);
                    hDesktop = Win32Support.GetWindow(hWnd, GW_CHILD);//第2层桌面     
                    break;
                case DesktopLayer.FolderView:
                    hDesktop = Win32Support.FindWindow("Progman", null);//第一层桌面    
                    hWnd = new HandleRef(this, hDesktop);
                    hDesktop = Win32Support.GetWindow(hWnd, GW_CHILD);//第2层桌面      
                    hWnd = new HandleRef(this, hDesktop);
                    hDesktop = Win32Support.GetWindow(hWnd, GW_CHILD);//第3层桌面    
                    break;
            }
            return hDesktop;
        
        }*/
        /*public void EmbedDesktop(Object embeddedWindow, IntPtr childWindow, IntPtr parentWindow)
        {
            Form window = (Form)embeddedWindow;
            HandleRef HWND_BOTTOM = new HandleRef(embeddedWindow, new IntPtr(1));
            const int SWP_FRAMECHANGED = 0x0020;//发送窗口大小改变消息
            Win32Support.SetParent(childWindow, parentWindow);
            Win32Support.SetWindowPos(new HandleRef(window, childWindow), HWND_BOTTOM, 300, 300, window.Width, window.Height, SWP_FRAMECHANGED);
        }
        */

        /// <summary>
        /// 窗体加载时获取窗体上次结束时的位置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Left = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
            this.Top = 0;
            state = 0;
        }
        /// <summary>
        /// 窗体关闭前记录窗体的当前位置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }


        //Point mouseOff;//鼠标移动位置变量
        //bool leftFlag;//标签是否为左键
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        private void textbox_tm1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void textbox_tm3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* this.Hide(); //先隐藏主窗体

             Form1 form1 = new Form1(); //重新实例化此窗体

             form1.ShowDialog();//已模式窗体的方法重新打开

             this.Close();//原窗体关闭
            */
            Application.Exit();
            Application.Restart();
        }

        private void textbox_tm2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textbox_tm1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
