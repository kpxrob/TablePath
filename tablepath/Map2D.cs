using System;
using System.Collections.Generic;
using System.Text;

namespace tablepath
{
    public class Map2D
    {
        /// <summary>
        /// Contains map information. Valid positions should have value 1.
        /// </summary>
        int[,] _positions;
        public MovingObject Object;
        int _width;
        int _height;

        public Map2D(int Width, int Height, int[,] Positions)
        {
            _width = Width;
            _height = Height;
            _positions = Positions;
        }
        public void SetStartPosition(int x, int y)
        {
            Object = new MovingObject(x, y);
            if (!IsObjectInBounds())
            {
                throw new ArgumentOutOfRangeException("Object [X,Y]", "Object start position should not be outside bounds.");
            }
        }
        
        /// <summary>
        /// Process object commands
        /// </summary>
        /// <param name="cmd"></param>
        /// <returns>Returns false if object went out of bounds, true otherwise. </returns>
        public bool HandleCommand(Command cmd)
        {
            switch (cmd)
            {
                case Command.FORWARD:
                    Object.MoveForward();
                    return IsObjectInBounds();
                case Command.BACKWARD:
                    Object.MoveBackward();
                    return IsObjectInBounds();
                case Command.ROTATE_CLOCKWISE:
                    Object.RotateClockwise90();
                    break;
                case Command.ROTATE_COUNTERCLOCK:
                    Object.RotateCounterClockwise90();
                    break;
                default:
                    throw new NotImplementedException();
            }
            return true;

        }
        public bool IsObjectInBounds()
        {
            //if object is out of bounds, set obj position to -1,-1
            if (Object.X < 0 || Object.X > (_width -1)
                || Object.Y < 0 || Object.Y > (_height -1)
                || _positions[Object.X, Object.Y] != 1)
            {
                Object.X = Object.Y = -1;
                return false;
            }
            return true;
        }
    }
}
