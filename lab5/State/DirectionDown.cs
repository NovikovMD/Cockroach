using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.State
{
    class DirectionDown : DirectionState, IDirection
    {
        public direction Trend => direction.Down;
        public DirectionDown(Bitmap image)
        {
            this.image = image;
        }

        public IDirection ChangeTrend(string command)
        {
            direction newtrend = Trends[command];
            switch (newtrend)
            {
                case direction.Left:                    
                    image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    return new DirectionLeft(image);
                case direction.Up:                    
                    image.RotateFlip(RotateFlipType.Rotate180FlipNone);
                    return new DirectionUp(image);
                case direction.Right:
                    image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    return new DirectionRight(image);
                default: return new DirectionDown(image);
            }

            throw new NotImplementedException();
        }

        public void Step(ref int X, ref int Y)
        {
            switch (Trend)
            {
                case direction.Right:
                    {
                        X += step;
                        break;
                    }
                case direction.Left:
                    {
                        X -= step;
                        break;
                    }
                case direction.Up:
                    {
                        Y -= step;
                        break;
                    }
                case direction.Down:
                    {
                        Y += step;
                        break;
                    }
            }
        }


    }
}
