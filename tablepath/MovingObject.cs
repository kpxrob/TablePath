using System;
using System.Collections.Generic;
using System.Text;

namespace tablepath
{
    public class MovingObject
    {
        public int X { get; set; }
        public int Y { get; set; }
        /// <summary>
        /// 0 = North, 1 = East, 2 = South, 3 = West.
        /// Default = 0
        /// </summary>        
        public int Orientation = 0; 
        public MovingObject(int x, int y)
        {
            X = x;
            Y = y;
        }
        public void RotateClockwise90()
        {
            if (Orientation == 3)
                Orientation = 0;
            else
                Orientation++;
        }
        public void RotateCounterClockwise90()
        {
            if (Orientation == 0)
                Orientation = 3;
            else
                Orientation--;
        }
        public void MoveForward()
        {
            Move(1);
        }
        public void MoveBackward()
        {
            Move(-1);
        }
        private void Move(int Direction)
        {
            switch (Orientation)
            {
                case 0:
                    Y-=1*Direction;
                    break;
                case 1:
                    X+=1*Direction;
                    break;
                case 2:
                    Y+=1*Direction;
                    break;
                case 3:
                    X-=1*Direction;
                    break;
            }                
        }
        

    }
}
