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
    public partial class GameChooseFRM : Form
    {
        Generator Generator;
        string Path;
        public GameChooseFRM(Generator generator, string path)
        {
            InitializeComponent();
            Generator = generator;
            Generator.Boom = true;
            Path = path;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new GameControlFRM(Generator, Path).ShowDialog();
            this.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }
    }
}
