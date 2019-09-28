using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace swfplayer
{
    public partial class Form1 : Form
    {
        string strpath = Application.StartupPath;
        string message = "軟體的設定檔案錯誤，是否關閉？";
        string caption = "Axialflow Error Report";
        
        
        public Form1()
        {
            InitializeComponent();

            try
            {
                StreamReader file = new StreamReader("afset\\@\\swfplayer.file.set");
                StreamReader fuscr = new StreamReader("afset\\@\\swfplayer.fullscreen.set");
                StreamReader title = new StreamReader("afset\\@\\swfplayer.title.set");
                StreamReader height = new StreamReader("afset\\@\\swfplayer.area.height.set");
                StreamReader width = new StreamReader("afset\\@\\swfplayer.area.width.set");
                StreamReader ico = new StreamReader("afset\\@\\swfplayer.icon.set");
                Icon icofile = Icon.ExtractAssociatedIcon("afres\\" + ico.ReadToEnd());

                Text = title.ReadToEnd();
                Height = Int32.Parse(height.ReadToEnd());
                Width = Int32.Parse(width.ReadToEnd());
                Icon = icofile;

                if (fuscr.ReadToEnd() == "1")
                {
                    FormBorderStyle = FormBorderStyle.None;
                    WindowState = FormWindowState.Maximized;
                    axShockwaveFlash1.Movie = strpath + "\\afres\\" + file.ReadToEnd();
                    axShockwaveFlash1.Playing = true;
                }
                else
                {
                    axShockwaveFlash1.Movie = strpath + "\\afres\\" + file.ReadToEnd();
                    axShockwaveFlash1.Playing = true;
                }
            }

            catch
            {
                var dr = MessageBox.Show(this, message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                if (dr == DialogResult.No)
                {
                    
                }
                if (dr == DialogResult.Yes)
                {
                    Close();
                }
            }
        }

        public Form1(string parameter)
        {
            InitializeComponent();

            try
            {
                if (parameter == "")
                {
                    StreamReader file = new StreamReader("afset\\@\\swfplayer.file.set");
                    StreamReader fuscr = new StreamReader("afset\\@\\swfplayer.fullscreen.set");
                    StreamReader title = new StreamReader("afset\\@\\swfplayer.title.set");
                    StreamReader height = new StreamReader("afset\\@\\swfplayer.area.height.set");
                    StreamReader width = new StreamReader("afset\\@\\swfplayer.area.width.set");
                    StreamReader ico = new StreamReader("afset\\@\\swfplayer.icon.set");
                    Icon icofile = Icon.ExtractAssociatedIcon("afres\\" + ico.ReadToEnd());

                    Icon = icofile;
                    Height = Int32.Parse(height.ReadToEnd());
                    Width = Int32.Parse(width.ReadToEnd());
                    Text = title.ReadToEnd();

                    if (fuscr.ReadToEnd() == "1")
                    {
                        FormBorderStyle = FormBorderStyle.None;
                        WindowState = FormWindowState.Maximized;
                        axShockwaveFlash1.Movie = strpath + "\\afres\\" + file.ReadToEnd();
                        axShockwaveFlash1.Playing = true;
                    }
                    else
                    {
                        axShockwaveFlash1.Movie = strpath + "\\afres\\" + file.ReadToEnd();
                        axShockwaveFlash1.Playing = true;
                    }
                }
                else
                {
                    StreamReader file = new StreamReader("afset\\" + parameter + "\\swfplayer.file.set");
                    StreamReader fuscr = new StreamReader("afset\\" + parameter + "\\swfplayer.fullscreen.set");
                    StreamReader title = new StreamReader("afset\\" + parameter + "\\swfplayer.title.set");
                    StreamReader height = new StreamReader("afset\\" + parameter + "\\swfplayer.area.height.set");
                    StreamReader width = new StreamReader("afset\\" + parameter + "\\swfplayer.area.width.set");
                    StreamReader ico = new StreamReader("afset\\" + parameter + "\\swfplayer.icon.set");
                    Icon icofile = Icon.ExtractAssociatedIcon("afres\\" + ico.ReadToEnd());

                    Icon = icofile;
                    Height = Int32.Parse(height.ReadToEnd());
                    Width = Int32.Parse(width.ReadToEnd());
                    Text = title.ReadToEnd();

                    if (fuscr.ReadToEnd() == "1")
                    {
                        FormBorderStyle = FormBorderStyle.None;
                        WindowState = FormWindowState.Maximized;
                        axShockwaveFlash1.Movie = strpath + "\\afres\\" + file.ReadToEnd();
                        axShockwaveFlash1.Playing = true;
                    }
                    else
                    {
                        axShockwaveFlash1.Movie = strpath + "\\afres\\" + file.ReadToEnd();
                        axShockwaveFlash1.Playing = true;
                    }
                }
            
            }

            catch
            {
                var dr = MessageBox.Show(this, message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                if (dr == DialogResult.No)
                {

                }
                if (dr == DialogResult.Yes)
                {
                    Close();
                }
            }
        }

    }
}
