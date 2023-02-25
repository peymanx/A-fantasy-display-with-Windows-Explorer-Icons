using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridMaster.Games
{
    internal class Tank
    {
       public  List<Bullet> Bullets = new List<Bullet>();
        public Tank(int x, int y)
        {
            X = x;
            Y = y;
            Shape = Right;

        }

        public int X { get; set; }
        public int Y { get; set; }
        public List<string> Shape { get; set; }

        public void TurnRight() {

            this.Shape = Right;
            X++;        
        }


        public void TurnUp()
        {

            this.Shape = Up;
            Y--;
        }

        public void Turndown()
        {

            this.Shape = Down;
            Y++;
        }




        public void TurnLeft()
        {

            this.Shape = Left;
            X--;
        }


        public List<string> Clear()
        {

            return Empty;
        }

        private List<string> Up = new List<string>
        {
            " X ",
            "XXX",
            "X X",
        };

        private List<string> Down = new List<string>
        {
            "X X",
            "XXX",
            " X "

        };


        private List<string> Right  = new List<string>
        {
            "XX ",
            " XX",
            "XX ",
        };
        private List<string> Left = new List<string>
        {
            " XX",
            "XX ",
            " XX",
        };


        private List<string> Empty = new List<string>
        {
            "   ",
            "   ",
            "   ",
        };



    }
}
