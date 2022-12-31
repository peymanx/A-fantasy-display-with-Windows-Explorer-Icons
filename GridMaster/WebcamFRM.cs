using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GridMaster
{
    public partial class WebcamFRM : Form
    {
        public WebcamFRM()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var open = new OpenFileDialog
            {
                Filter = "Image file|*.jpg;*.png;*.gif"
            };

            if (open.ShowDialog() == DialogResult.OK)
            {

            }
        }
        int b = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            b++;
            var os = @"D:\GridMaster\GridMaster\GridMaster\bin\Debug\net6.0-windows\Video";
            var bk = @"D:\GridMaster\GridMaster\GridMaster\bin\Debug\net6.0-windows\bk";
            Directory.GetFiles(os).ToList().ForEach(File.Delete);

            Thread.Sleep(new Random().Next(100, 700));
            foreach (var srcPath in Directory.GetFiles(bk))
            {

                File.Copy(srcPath, srcPath.Replace(bk, os), true);
            }
            if (b % 2 == 0)
                button2.BackColor = Color.Gold;
            else
                button2.BackColor = button1.BackColor;



        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1500;
            timer1.Enabled = !timer1.Enabled;

            if (timer1.Enabled == false)
            {
                button2.BackColor = button1.BackColor;
                Cursor = Cursors.Default;
                toolStripStatusLabel1.Text = "stopped";
            }
            else
            {
                button2.BackColor = Color.Gold;
                Cursor = Cursors.WaitCursor;
                toolStripStatusLabel1.Text = "streaming...";

            }


        }

        private void WebcamFRM_Load(object sender, EventArgs e)
        {

        }
    }
}
