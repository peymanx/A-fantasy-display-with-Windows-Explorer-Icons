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
            Text = "ترسیم نقاشی روی آیکون ها";
            this.Height = Generator.NumberOfRows * pixel_size + pixel_size;
            this.Width = Generator.NumberOfCols * pixel_size + pixel_size;

            for (int i = 0; i < Generator.NumberOfRows; i++)
            {

                for (int j = 0; j < Generator.NumberOfCols; j++)
                {
                    var pixel = " ";
                  

                        pixel = Generator.Screen[i][j].ToString();
                    var btn = new Button
                    {
                        Text = i * Generator.NumberOfCols + j + 1 + "",
                        BackColor = Color.White,
                        Width = pixel_size,
                        Height = pixel_size,
                        Tag = new Grid(i, j),
                        Margin = new Padding(0),
                        BackgroundImageLayout = ImageLayout.Zoom


                    };
                    btn.BackgroundImage = null;

                    if (pixel == " " || pixel == "@")
                        btn.BackColor = Color.White;
                    else if (pixel.ToUpper() == "R")
                        btn.BackColor = Color.Red;
                    else if (pixel.ToUpper() == "G")
                        btn.BackColor = Color.Green;
                    else if (pixel.ToUpper() == "B")
                        btn.BackColor = Color.Blue;

                    else
                    {
                        btn.BackColor = Color.Black;
                        btn.BackgroundImage = Image.FromFile(Generator.IconSource);

                    
                    }



                    btn.MouseUp += Btn_Click;




                    flowLayoutPanel1.Controls.Add(btn);

                }
            }

        }



        private void Btn_Click(object? sender, EventArgs e)
        {
            var btn = (Button)sender;
            var grid = (Grid)btn.Tag;
            var click = (MouseEventArgs)e;

            if (click.Button == MouseButtons.Left)
            {
                btn.BackgroundImage = null; ;
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Black;
                    btn.BackgroundImage = Image.FromFile(Generator.IconSource);
                    Generator.Screen[grid.Y] = Generator.Screen[grid.Y].Remove(grid.X, 1).Insert(grid.X, "X");
                }
                else
                {
                    btn.BackColor = Color.White;
                    Generator.Screen[grid.Y] = Generator.Screen[grid.Y].Remove(grid.X, 1).Insert(grid.X, " ");
                }

            }
            if (click.Button == MouseButtons.Right)
            {

                btn.BackColor = Color.Red;
                Generator.Screen[grid.Y] = Generator.Screen[grid.Y].Remove(grid.X, 1).Insert(grid.X, "R");

            }
            if (click.Button == MouseButtons.Middle)
            {

                btn.BackColor = Color.Green;
                Generator.Screen[grid.Y] = Generator.Screen[grid.Y].Remove(grid.X, 1).Insert(grid.X, "G");

            }


            Generator.Icons(Path);

        }
    }
}
