using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Launchpad
{
    public partial class Form1 : Form
    {
        string programFilesX86 = Environment.ExpandEnvironmentVariables("%ProgramFiles(x86)%");
        string programFiles = Environment.ExpandEnvironmentVariables("%ProgramW6432%");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(programFilesX86 + @"\Google\Chrome\Application\chrome.exe");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(programFiles + @"\paint.net\paintdotnet.exe");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(programFiles + @"\Oracle\VirtualBox\VirtualBox.exe");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(programFilesX86 + @"\Webex\Webex\Applications\ptoneclk.exe");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(programFilesX86 + @"\Notepad++\notepad++.exe");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(programFilesX86 + @"\Steam\Steam.exe");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
