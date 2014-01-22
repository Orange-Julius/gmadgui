using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GMAD.EXE_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            textBox1.Text = folderBrowserDialog1.SelectedPath;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            textBox2.Text = saveFileDialog1.FileName;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo(Application.StartupPath + "/gmad.exe");
            startInfo.Arguments = @"create -folder """ + textBox1.Text + @"""" + @" -out """ + textBox2.Text + @"""";
            //MessageBox.Show(@"create -folder """ + textBox1.Text + @"""" + @" -out """ + textBox2.Text + @"""");
            try
            {
                Process.Start(startInfo);
            }
            catch (Exception ex)
            {

            }
        }
    }
}
