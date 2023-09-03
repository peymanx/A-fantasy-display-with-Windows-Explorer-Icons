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
    
    public partial class HandDrawing : Form
    {


        public string Path = @".\Video";
        public Generator Generator = new Generator();
        private bool mouseDown;
    private Point lastLocation;
        public HandDrawing()
        {
            InitializeComponent();
        }

        private void HandDrawing_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void HandDrawing_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void HandDrawing_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void HandDrawing_Load(object sender, EventArgs e)
        {
            txtPath.Text = Path;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        bool clock_enabled = false;

        private void txtText_KeyUp(object sender, KeyEventArgs e)
        {
            clock_enabled = false;
            timer1.Enabled = false;

            txtPreview.Text = Generator.Preview(txtText.Text);
            btnPause_Click(sender, e);
            if (e.KeyCode == Keys.Enter)
            {
                Generator.Frame = 0;
                Generator.UpdateScreen(txtText.Text);

                if (Generator.Screen[0].Length < Generator.NumberOfCols)
                    Generator.Screen = Generator.Word(txtText.Text + Generator.ExtraSpace);

                txtPreview.Text = Generator.PreviewFrame();
                Generator.Icons(Path);



            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
          //  btnPause.BackColor = Color.Khaki;
           // btnClock.BackColor = btnPlay.BackColor = btnNext.BackColor;
            clock_enabled = false;
        }

        private void apply(object sender, EventArgs e)
        {
            Directory.GetFiles(Path).ToList().ForEach(File.Delete);
            Generator.Icons(Path);
            txtPreview.Text = Generator.PreviewFrame();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            btnPause_Click(null, null);

            new DesignerFRM(Generator, Path).ShowDialog();
            this.Show();

            apply(sender, e);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Directory.GetFiles(Path).ToList().ForEach(File.Delete);
            Generator.Icons(Path);
            txtPreview.Text = Generator.PreviewFrame();
        }

        private void btnClock_Click(object sender, EventArgs e)
        {
            Generator.Frame = 0;
            clock_enabled = !clock_enabled;
            timer1.Enabled = clock_enabled;


            if (clock_enabled)
            {

                timer1.Interval = 500;
               // btnClock.BackColor = Color.Cyan;
                timer1_Tick(null, null);
            }
            else
            {
                timer1.Interval = 2000;
                btnPause_Click(null, null);
            }
        }
        int flasher = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {

            flasher++;
            if (clock_enabled)
            {
                var time = DateTime.Now.ToString("hh:mm");
                if (flasher % 2 == 0)
                    time = DateTime.Now.ToString("hh mm");


                Generator.Screen = Generator.Word(time);
                txtText.Text = $"@Time({time})";
                txtPreview.Text = Generator.PreviewFrame();
                Generator.Icons(Path);
            }
            else
            {

                //if (flasher % 2 == 0)
                //    btnPlay.BackColor = Color.Khaki;
                //else
                //    btnPlay.BackColor = Color.Red;

               // btnPause.BackColor = btnNext.BackColor;

                btnNext_Click(null, null);
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Generator.Next(Directions.LEFT2RIGHT);
            txtPreview.Text = Generator.PreviewFrame();
            Generator.Icons(Path);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            var open = new FolderBrowserDialog()
            {
                ShowNewFolderButton = true

            };
            if (open.ShowDialog() == DialogResult.OK)
            {
                Path = open.SelectedPath;
                if (MessageBox.Show("If you continue it will delete all the files in the folder; Do you want to continue?", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    Directory.GetFiles(Path).ToList().ForEach(File.Delete);
            }

            txtPath.Text = Path;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", Path);
        }

        private void numCols_ValueChanged(object sender, EventArgs e)
        {
            Generator.NumberOfCols = (int)numCols.Value;
            Generator.UpdateScreen(txtText.Text);
        }

        private void numRows_ValueChanged(object sender, EventArgs e)
        {
            Generator.NumberOfRows = (int)numRows.Value;
            Generator.UpdateScreen(txtText.Text);
        }

        private void textBox3_KeyUp(object sender, KeyEventArgs e)
        {
            //radioCBlack_CheckedChanged(sender, e);
            if (e.KeyCode == Keys.Enter)
                apply(sender, e);
        }
    }
}
