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
            this.TopMost = true;
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
            btnPlay.Image = Properties.Resources.btnPlay;
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
                txtText.Text = $"@time:: {time}";
                txtPreview.Text = Generator.PreviewFrame();
                Generator.Icons(Path);
            }
            else
            {

                if (flasher % 2 == 0)
                    btnPlay.Image = Properties.Resources.btnPlay;

                else
                    btnPlay.Image = Properties.Resources.btnPlay_highlight;

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
            Generator.UpdateNewScreenSize();
            Generator.UpdateScreen(txtText.Text);
        }

        private void numRows_ValueChanged(object sender, EventArgs e)
        {
            Generator.NumberOfRows = (int)numRows.Value;
            Generator.UpdateNewScreenSize();

            Generator.UpdateScreen(txtText.Text);
        }

        private void textBox3_KeyUp(object sender, KeyEventArgs e)
        {
            Generator.BlackIconExt = txtBlack.Text;
            if (e.KeyCode == Keys.Enter)
                apply(sender, e);
        }

        private void btnUpdate_MouseHover(object sender, EventArgs e)
        {
            btnUpdate.Image = Properties.Resources.update_highlight1;
        }

        private void HandDrawing_MouseHover(object sender, EventArgs e)
        {
            btnUpdate.Image = Properties.Resources.update_normal;
           

        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
          
        }

        private void txtPath_MouseHover(object sender, EventArgs e)
        {
            btnUpdate.Image = Properties.Resources.update_normal;

        }

        private void btnUpdate_MouseMove(object sender, MouseEventArgs e)
        {
            btnUpdate.Image = Properties.Resources.update_highlight1;

        }

        private void btnUpdate_MouseLeave(object sender, EventArgs e)
        {
            btnUpdate.Image = Properties.Resources.update_normal;

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1_Tick(sender, e);
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            Generator.Next(Directions.RIGHT2LEFT);
            txtPreview.Text = Generator.PreviewFrame();
            Generator.Icons(Path);
        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void پاکسازیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtText.Text = "   ";
            apply(sender, e);
            txtText.SelectAll();
            txtText.Focus();
        }

        private void OpenTXTFile(string path)
        {
            var file = File.ReadAllText(path);
            var lines = file.Split(Environment.NewLine).ToList();
            var max = lines.Max().Length;
            if (max < Generator.NumberOfCols)
                max = Generator.NumberOfCols;
            var result = new List<string>();
            foreach (var line in lines)
            {
                var item = line;
                if (line.Length < max)
                    item += Generator.Space(max - line.Length);

                result.Add(item);

            }


            if (result.Count < Generator.NumberOfRows)
            {

                for (int i = 0; i <= Generator.NumberOfRows - result.Count; i++)
                {
                    result.Add(Generator.Space(max));
                }

            }


            Generator.Screen = result;
            Generator.Frame = 0;
        }
        private void بازکردنفایلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var open = new OpenFileDialog
            {
                Filter = "text file|*.txt"
            };

            if (open.ShowDialog() == DialogResult.OK)
            {
                OpenTXTFile(open.FileName);

                apply(sender, e);
                txtText.Text = $"@File::{open.SafeFileName}";
                //toolLog.Text = "File opened successfully";
            }
        }

        private void اتصالبهوبکمToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.TopMost = false;
            new WebcamFRM().Show();
        }

        private void txtWhiteExt_KeyUp(object sender, KeyEventArgs e)
        {
            Generator.WhiteIconExt = txtWhiteExt.Text;
            if (e.KeyCode == Keys.Enter)
                apply(sender, e);
        }

        private void txtGreen_KeyUp(object sender, KeyEventArgs e)
        {
            Generator.GreenIconExt = txtGreen.Text;
            if (e.KeyCode == Keys.Enter)
                apply(sender, e);
        }

        private void txtRed_KeyUp(object sender, KeyEventArgs e)
        {
            Generator.RedIconExt = txtRed.Text;
            if (e.KeyCode == Keys.Enter)
                apply(sender, e);
        }

        private void txtBlue_KeyUp(object sender, KeyEventArgs e)
        {
            Generator.BlueIconExt = txtBlue.Text;
            if (e.KeyCode == Keys.Enter)
                apply(sender, e);
        }

        private void btnPlay_MouseMove(object sender, MouseEventArgs e)
        {
            btnPlay.Image = Properties.Resources.btnPlay_hover;
        }

        private void btnPlay_MouseLeave(object sender, EventArgs e)
        {
            btnPlay.Image = Properties.Resources.btnPlay;
        }

        private void btnClock_MouseMove(object sender, MouseEventArgs e)
        {
            btnClock.Image = Properties.Resources.btnClock_hover;
        }

        private void btnClock_MouseLeave(object sender, EventArgs e)
        {
            btnClock.Image = Properties.Resources.btnClock;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.Image = Properties.Resources.btnClose_hover;

        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.btnClose;

        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox3.Image = Properties.Resources.btnPaint_hover;

        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.btnPaint;

        }

        private void کوچولوشوToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnMin.Checked = !btnMin.Checked;
            lblNim.Visible = btnMin.Checked;

            if (btnMin.Checked)
            {
                this.BackgroundImage = Properties.Resources.bg_splited2;
                btnNext.Visible= btnPlay.Visible = false;
            }
            else
            {
                this.BackgroundImage = Properties.Resources.bg1;
               btnNext.Visible= btnPlay.Visible = true;


            }
        }

        private void باقیماندنرویصفحهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            باقیماندنرویصفحهToolStripMenuItem.Checked = !باقیماندنرویصفحهToolStripMenuItem.Checked;
            this.TopMost = باقیماندنرویصفحهToolStripMenuItem.Checked;
        }

        private void بازیهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtText.Text = " ";
            apply(sender, e);
            this.Hide();
            new GameControlFRM(Generator, Path).ShowDialog();
            this.Show();
        }

        private void ساعتدیجیتالToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Generator.Frame = 0;
            clock_enabled = !clock_enabled;
            timer1.Enabled = clock_enabled;


            if (clock_enabled)
            {

                timer1.Interval = 500;
                btnClock.BackColor = Color.Cyan;
                timer1_Tick(null, null);
            }
            else
            {
                timer1.Interval = 2000;
                btnPause_Click(null, null);
            }
        }

        private void نسخهمدرنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            new MainFRM().Show();
           
        }

        private void ذخیرهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var file = "";
            foreach (var line in Generator.Screen)
            {
                file += line + Environment.NewLine;
            }
            var save = new SaveFileDialog
            {
                Filter = "text file|*.txt"
            };
            file = file.Replace("@", " ");
            if (save.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(save.FileName, file);
               // toolLog.Text = $"Data saved to the file ({save.FileName})";

            }
        }

        private void btnNext_MouseMove(object sender, MouseEventArgs e)
        {
            btnNext.Image = Properties.Resources.btnNext_hover1;

        }

        private void btnNext_MouseLeave(object sender, EventArgs e)
        {
            btnNext.Image = Properties.Resources.btnNext;

        }

        private void btnNext_MouseDown(object sender, MouseEventArgs e)
        {
            btnNext.Image = Properties.Resources.btnNext;

        }

        private void btnPlay_MouseDown(object sender, MouseEventArgs e)
        {
            btnPlay.Image = Properties.Resources.btnPlay_highlight;

        }

        private void دربارهبرنامهنویسToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PeymanX().ShowDialog();
        }
    }
}
