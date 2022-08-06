using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.State
{
    class DirectionLeft : DirectionState, IDirection
    {
        public direction Trend => direction.Left;
        public DirectionLeft(Bitmap image)
        {
            this.image = image;
        }

        public IDirection ChangeTrend(string command)
        {
            direction newtrend = Trends[command];
            switch (newtrend)
            {
                case direction.Up:
                    image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    return new DirectionUp(image);
                case direction.Right:
                    image.RotateFlip(RotateFlipType.Rotate180FlipNone);
                    return new DirectionRight(image);
                case direction.Down:
                    image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    return new DirectionDown(image);
                default: return new DirectionLeft(image);
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
