using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridMaster.Games
{
    internal class Bullet
    {
        public Bullet(int x, int y)
        {
            X = x;
            Y = y;
            

        }
        public bool Terminated { get; set; } = false;
        public List<string> Clear()
        {

            return Empty;
        }
        public int X { get; set; }
        public int Y { get; set; }
        public List<string> Shape { get; set; } = new List<string>() { "G" };
        public List<string> Empty { get; set; } = new List<string>() { " " };



    }
}
