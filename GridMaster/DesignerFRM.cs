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
    public class Grid
    {
        public Grid(int i, int j)
        {
            Y = i;
            X = j;
 

        }
        public int X { get; set; }
        public int Y { get; set; }

    }
    public partial class DesignerFRM : Form
    {
        Generator Generator;
        string Path;

        const int pixel_size = 40;
        public DesignerFRM(Generator generator, string path)
        {
            InitializeComponent();
            Generator = generator;
            Generator.Boom = true;
            Path = path;
        }

        private void DesignerFRM_Load(object sender, EventArgs e)
        {
            this.Height = Generator.NumberOfRows * pixel_size;
            this.Width = Generator.NumberOfCols * pixel_size + pixel_size;

            for (int i = 0; i < Generator.NumberOfRows; i++)
            {

                for (int j = 0; j < Generator.NumberOfCols; j++)
                {
                    try
                    {

                        var pixel = Generator.Screen[i][j].ToString();
                        var btn = new Button
                        {
                            Text = i + "," + j,
                            BackColor = Color.White,
                            Width = pixel_size,
                            Height = pixel_size,
                            Tag = new Grid(i, j),
                            Margin = new Padding(0),


                        };
                        if (pixel != " " && pixel != "@")
                            btn.BackColor = Color.Black;
                        btn.Click += Btn_Click;


                        flowLayoutPanel1.Controls.Add(btn);
                    }
                    catch 
                    {
                        // :( DONT TELL ANY ONE- NO WAY OUT

                    }
                }
            }

        }

        private void Btn_Click(object? sender, EventArgs e)
        {
            var btn = (Button)sender;
            var grid = (Grid)btn.Tag;

            if (btn.BackColor ==  Color.White)
            {
                btn.BackColor = Color.Black;
                Generator.Screen[grid.Y] = Generator.Screen[grid.Y].Remove(grid.X, 1).Insert(grid.X, "X");
            }
            else
            {
                btn.BackColor = Color.White;
                Generator.Screen[grid.Y]=  Generator.Screen[grid.Y].Remove(grid.X, 1).Insert(grid.X, " ");
            }

            Generator.Icons(Path);

        }
    }
}
