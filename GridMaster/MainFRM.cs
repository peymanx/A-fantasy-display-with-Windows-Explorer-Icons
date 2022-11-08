namespace GridMaster
{
    public partial class MainFRM : Form
    {
        public string Path = @".\Video";
        public Generator Generator = new Generator();





        public MainFRM()
        {
            InitializeComponent();
        }

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
        public void DeleteAllFiles()
        {
            Directory.GetFiles(Path).ToList().ForEach(File.Delete);
        }
        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", Path);

        }

        private void MainFRM_Load(object sender, EventArgs e)
        {
            txtPath.Text = Path;
            DeleteAllFiles();


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

        private void btnNext_Click(object sender, EventArgs e)
        {
            Generator.Next(Directions.LEFT2RIGHT);
            txtPreview.Text = Generator.PreviewFrame();
            Generator.Icons(Path);
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            Generator.Next(Directions.RIGHT2LEFT);
            txtPreview.Text = Generator.PreviewFrame();
            Generator.Icons(Path);

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1_Tick(sender, e);
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            btnPause.BackColor = Color.Khaki;
            btnClock.BackColor = btnPlay.BackColor = btnNext.BackColor;
            clock_enabled = false;


        }
        int flasher = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {

            flasher++;
            if (clock_enabled)
            {
                var time = DateTime.Now.ToString("hh:mm");
                if (flasher % 4 == 0)
                    time = DateTime.Now.ToString("hh mm");


                Generator.Screen = Generator.Word(time);
                txtText.Text = $"@Time({time})";
                txtPreview.Text = Generator.PreviewFrame();
                Generator.Icons(Path);
            }
            else
            {

                if (flasher % 2 == 0)
                    btnPlay.BackColor = Color.Khaki;
                else
                    btnPlay.BackColor = Color.Red;

                btnPause.BackColor = btnNext.BackColor;

                btnNext_Click(null, null);
            }

        }

        private void MainFRM_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                btnPause_Click(null, null);

            if (e.KeyCode == Keys.F2)

                btnNext_Click(null, null);

            if (e.KeyCode == Keys.F3)
                btnPre_Click(null, null);



        }

        private void button1_Click(object sender, EventArgs e)
        {
            var open = new FolderBrowserDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                Path = open.SelectedPath;
                if (MessageBox.Show("If you continue it will delete all the files in the folder; Do you want to continue?", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    Directory.GetFiles(Path).ToList().ForEach(File.Delete);
            }

            txtPath.Text = Path;
        }

        private void radioBlack_CheckedChanged(object sender, EventArgs e)
        {
            Generator.BlackIconExt = "jpg";
        }

        private void radioCBlack_CheckedChanged(object sender, EventArgs e)
        {
            Generator.BlackIconExt = textBox1.Text;
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            radioCBlack_CheckedChanged(sender, e);
            if (e.KeyCode == Keys.Enter)
                apply(sender, e);

        }

        private void apply(object sender, EventArgs e)
        {
            Directory.GetFiles(Path).ToList().ForEach(File.Delete);
            Generator.Icons(Path);
            txtPreview.Text = Generator.PreviewFrame();
        }



        private void txtWhiteExt_KeyUp(object sender, KeyEventArgs e)
        {
            Generator.WhiteIconExt = txtWhiteExt.Text;
            if (e.KeyCode == Keys.Enter)
                apply(sender, e);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            //  radioCBlack.Checked = true;
        }

        private void txtWhiteExt_Click(object sender, EventArgs e)
        {
            //radioButton1.Checked = true;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.Width = 500;
            this.Height = 140;
            txtText.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            btnPause_Click(null, null);

            new DesignerFRM(Generator, Path).ShowDialog();
            this.Show();

            apply(sender, e);


        }
        bool clock_enabled = false;
        private void button3_Click(object sender, EventArgs e)
        {
            Generator.Frame = 0;
            clock_enabled = !clock_enabled;
            timer1.Enabled = clock_enabled;


            if (clock_enabled)
            {
                DeleteAllFiles();
                btnClock.BackColor = Color.Cyan;
                timer1_Tick(null, null);
            }
            else
                btnPause_Click(null, null);

        }

        private void txtText_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRed_KeyUp(object sender, KeyEventArgs e)
        {
            Generator.RedIconExt = txtRed.Text;
            if (e.KeyCode == Keys.Enter)
                apply(sender, e);
        }

        private void txtGreen_KeyUp(object sender, KeyEventArgs e)
        {
            Generator.GreenIconExt = txtGreen.Text;
            if (e.KeyCode == Keys.Enter)
                apply(sender, e);
        }

        private void txtBlue_KeyUp(object sender, KeyEventArgs e)
        {
            Generator.BlueIconExt = txtBlue.Text;
            if (e.KeyCode == Keys.Enter)
                apply(sender, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
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
                toolLog.Text = $"Data saved to the file ({save.FileName})";

            }
        }
       

        private void button4_Click(object sender, EventArgs e)
        {
            var open = new OpenFileDialog
            {
                Filter = "text file|*.txt"
            };

            if (open.ShowDialog() == DialogResult.OK)
            {
                var file = File.ReadAllText(open.FileName);
                var lines = file.Split(Environment.NewLine).ToList();
                var max = lines.Max().Length;
                if (max < Generator.NumberOfCols)
                    max = Generator.NumberOfCols;
                var result = new List<string>();
                foreach (var line in lines)
                {
                    var item= line;
                    if (line.Length < max)
                        item += Generator.Space(max - line.Length);

                    result.Add(item);

                }


                if(result.Count< Generator.NumberOfRows)
                {
          
                    for (int i = 0; i <= Generator.NumberOfRows- result.Count; i++)
                    {
                        result.Add(Generator.Space(max));
                    }
                    
                }


                Generator.Screen = result;
                Generator.Frame = 0;

                apply(sender, e);
                txtText.Text = "@" + open.FileName;
                toolLog.Text = "File opened successfully";
            }
        }

        private void groupBox10_Enter(object sender, EventArgs e)
        {

        }
    }
}