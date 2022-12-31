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
    public partial class GameControlFRM : Form
    {
        Generator Generator;
        string Path;
        public GameControlFRM(Generator generator, string path)
        {
            StartPosition = FormStartPosition.Manual;
            Location = new Point(1400, 650);
            InitializeComponent();
            Generator = generator;
            Generator.Boom = true;
            Path = path;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            

            new DesignerFRM(Generator, Path).ShowDialog();
            this.Show();

          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new DesignerFRM(Generator, Path).ShowDialog();
           
        }
    }
}
