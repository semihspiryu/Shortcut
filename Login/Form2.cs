using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void OpenShortcut(string shortcut)
        {
            var shell = new IWshRuntimeLibrary.WshShell();
            var kisayol = (IWshRuntimeLibrary.IWshShortcut)shell.CreateShortcut(shortcut);
            string Target_Shortcut = kisayol.TargetPath;

            System.Diagnostics.Process.Start(Target_Shortcut);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Shortcut = @"C:\Users\hp\OneDrive - klu.edu.tr\Masaüstü\masaüstü\oyunlar\osu!.lnk";
            OpenShortcut(Shortcut);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Shortcut = @"C:\Users\hp\OneDrive - klu.edu.tr\Masaüstü\masaüstü\oyunlar\League of Legends.lnk";
            OpenShortcut(Shortcut);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Shortcut = @"C:\Users\hp\OneDrive - klu.edu.tr\Masaüstü\masaüstü\oyunlar\diger\TLauncher.lnk";
            OpenShortcut(Shortcut);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string Shortcut = @"C:\Users\hp\OneDrive - klu.edu.tr\Masaüstü\Spotify.lnk";
            OpenShortcut(Shortcut);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string Shortcut = @"C:\Users\hp\OneDrive - klu.edu.tr\Masaüstü\Discord.lnk";
            OpenShortcut(Shortcut);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string Shortcut = @"C:\Program Files\BraveSoftware\Brave-Browser\Application\brave.exe";
            string URL = "https://www.youtube.com";
            DialogResult result = MessageBox.Show("Youtube'yi Açmak İster Misiniz?", "Onay", MessageBoxButtons.YesNo);


            if (result == DialogResult.Yes)
                System.Diagnostics.Process.Start(Shortcut, URL);
            else if (result == DialogResult.No)
                System.Diagnostics.Process.Start(Shortcut);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string Shortcut = @"C:\Users\hp\OneDrive - klu.edu.tr\Masaüstü\masaüstü\oyunlar\steam\Steam.lnk";
            OpenShortcut(Shortcut);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string Shortcut = @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Visual Studio 2022.lnk";
            OpenShortcut(Shortcut);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string Shortcut = @"C:\Users\hp\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Visual Studio Code\Visual Studio Code.lnk";
            OpenShortcut(Shortcut);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string Shortcut = @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\JetBrains\PyCharm Community Edition 2023.2.4.lnk";
            OpenShortcut(Shortcut);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bilgisayarı Kapatmak İster Misiniz?");

            if (result == DialogResult.OK)
                System.Diagnostics.Process.Start("shutdown", "/s /t 0");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bilgisayarı Yeniden Başlatmak İstediğinize Emin Misiniz?");

            if (result == DialogResult.OK)
                System.Diagnostics.Process.Start("shutdown", "/r /t 0");
        }

        
    }
}
