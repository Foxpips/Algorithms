using System;
using OperationMicrosoft.DataStructures.Objects.Shapes;

namespace OperationMicrosoft.Algorithms.ShapeRotater
{
    public class ShapeRotater
    {
        private readonly bool[,] _rotated = new bool[4, 4];
        private readonly Action<IShape> _updateDimensions;

        public ShapeRotater()
        {
            _updateDimensions = shape => shape.Dimensions = _rotated.Clone() as bool[,];
        }

        public void RotateRight(IShape shape)
        {
            IterateShape((i, j) => _rotated[j, 3 - i] = shape.Dimensions[i, j]);
            _updateDimensions(shape);
        }

        public void RotateLeft(IShape shape)
        {
            IterateShape((i, j) => _rotated[i, j] = shape.Dimensions[j, 3 - i]);
            _updateDimensions(shape);
        }

        private static void IterateShape(Action<int, int> work)
        {
            for (var i = 0; i < 4; i++)
            {
                for (var j = 0; j < 4; j++)
                {
                    work(i, j);
                }
            }
        }
    }
}