using GridMaster.Games;
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
        Tank tank;
        string Path;
        public GameControlFRM(Generator generator, string path)
        {
            StartPosition = FormStartPosition.Manual;
            Location = new Point(1400, 650);
            InitializeComponent();
            Generator = generator;
            Generator.Boom = true;
            Path = path;

            tank = new Tank(3, 3);
            Generator.Copy(tank.Shape, tank.X, tank.Y);


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            

           
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
         
           
        }

        private void GameControlFRM_KeyUp(object sender, KeyEventArgs e)
        {
         
            if(e.KeyCode == Keys.Right)
            {
                Generator.Copy(tank.Clear(), tank.X, tank.Y);
                tank.TurnRight();
                Generator.Copy(tank.Shape, tank.X, tank.Y);
            }


            if (e.KeyCode == Keys.Left)
            {
                Generator.Copy(tank.Clear(), tank.X, tank.Y);
                tank.TurnLeft();
                Generator.Copy(tank.Shape, tank.X, tank.Y);
            }


            if (e.KeyCode == Keys.Space)
            {
                tank.Bullets.Add(new Bullet(tank.X + 1, tank.Y + 1));

               
            }



            if (e.KeyCode == Keys.Up)
            {
                Generator.Copy(tank.Clear(), tank.X, tank.Y);
                tank.TurnUp();
                Generator.Copy(tank.Shape, tank.X, tank.Y);
            }



            if (e.KeyCode == Keys.Down)
            {
                Generator.Copy(tank.Clear(), tank.X, tank.Y);
                tank.Turndown();
                Generator.Copy(tank.Shape, tank.X, tank.Y);
            }





            Generator.Icons(Path);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            foreach (var bullet in tank.Bullets)
            {
                Generator.Copy(bullet.Clear(), bullet.X, bullet.Y);

                bullet.X++;
                if (bullet.X > Generator.NumberOfCols)
                    bullet.Terminated = true;
                else
                {
                    Generator.Copy(bullet.Shape, bullet.X, bullet.Y);
                   
                }

            }
            var bc = tank.Bullets.Count-1;
            for (int i = bc; i > 0; i--)
            {
                if (tank.Bullets[i].Terminated)
                    tank.Bullets.RemoveAt(i);
            }
            Generator.Copy(tank.Shape, tank.X, tank.Y);

            Generator.Icons(Path);

        }
    }
}
