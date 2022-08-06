using lab5.State;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5
{
    public class Cockroach
    {
        IDirection direction;
        public Bitmap image;
        private const int step = 30;
        public int X;
        public int Y;
        public Cockroach(Bitmap _Image)
        {
            image = _Image; 
            direction = new DirectionRight(image);
        }
        public void Step()
        {
            direction.Step(ref X, ref Y);
        }
        public void ChangeTrend(string command)
        {
            direction = direction.ChangeTrend(command);
        }
    }

}

