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
            txtPreview.Text = Generator.Preview(txtText.Text);
            btnPause_Click(sender, e);
            if (e.KeyCode == Keys.Enter)
            {
                Generator.Frame = 0;
                Generator.UpdateScreen(txtText.Text);

                if (Generator.Screen[0].Length < Generator.NumberOfCols)
                    Generator.Screen = Generator.Word(txtText.Text + Generator.ExtraSpace);

                txtPreview.Text=  Generator.Icons(Path);



            }
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", Path);

        }

        private void MainFRM_Load(object sender, EventArgs e)
        {
            txtPath.Text = Path;
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
            txtPreview.Text =  Generator.Icons(Path);
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            Generator.Next(Directions.RIGHT2LEFT);
            txtPreview.Text = Generator.Icons(Path);

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            btnPause.BackColor = Color.Khaki;
            btnPlay.BackColor = btnNext.BackColor;

        }
        int flasher = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            flasher++;
            if(flasher%2==0)
                btnPlay.BackColor = Color.Khaki;
            else
                btnPlay.BackColor = Color.Beige;

            btnPause.BackColor = btnNext.BackColor;

            btnNext_Click(null, null);

        }

        private void MainFRM_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                btnPause_Click(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var open= new FolderBrowserDialog();
            if (open.ShowDialog() == DialogResult.OK)
                Path = open.SelectedPath;

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
                apply( sender,  e);

        }

        private void apply(object sender, EventArgs e)
        {
            Generator.Icons(Path);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Generator.WhiteIconExt = "txt";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Generator.WhiteIconExt = txtWhiteExt.Text;
        }

        private void txtWhiteExt_KeyUp(object sender, KeyEventArgs e)
        {
            radioButton2_CheckedChanged(sender, e);
            if (e.KeyCode == Keys.Enter)
                apply(sender, e);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            radioCBlack.Checked = true;
        }

        private void txtWhiteExt_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }
    }
}