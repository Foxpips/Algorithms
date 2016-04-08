using System;
using System.Text;

namespace OperationMicrosoft.DataStructures.Objects.Shapes
{
    internal abstract class BaseShape : IShape
    {
        private readonly StringBuilder _shapeStringBuilder = new StringBuilder();
        public bool[,] Dimensions { get; set; }

        public string Draw()
        {
            var count = 1;
            foreach (var b in Dimensions)
            {
                _shapeStringBuilder.Append(b ? "X" : "O");
                _shapeStringBuilder.Append(count % 4 == 0 ? Environment.NewLine : string.Empty);
                count++;
            }
            var draw = _shapeStringBuilder.ToString();
            _shapeStringBuilder.Clear();
            return draw;
        }

        public override string ToString()
        {
            return Draw();
        }
    }
}