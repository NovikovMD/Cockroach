﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.State
{
    class DirectionRight : DirectionState, IDirection
    {
        public direction Trend => direction.Right;
        public DirectionRight(Bitmap image)
        {
            this.image = image;
        }

        public IDirection ChangeTrend(string command)
        {
            direction newtrend = Trends[command];
            switch (newtrend)
            {
                case direction.Down:
                    image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    return new DirectionDown(image);
                case direction.Left:
                    image.RotateFlip(RotateFlipType.Rotate180FlipNone);
                    return new DirectionLeft(image);
                case direction.Up:
                    image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    return new DirectionUp(image);
                default: return new DirectionRight(image);
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
