using System;
using NUnit.Framework;
using OperationMicrosoft.Algorithms.ShapeRotater;
using OperationMicrosoft.DataStructures.Objects.Shapes;

namespace OperationMicrosoft.Tests
{
    public class ShapeTester
    {
        [Test]
        public void Method_Scenario_Result()
        {
            //Arrange
            var lShape = new LShape();
            var shapeRotater = new ShapeRotater();

            //Act
            Console.WriteLine(lShape);

            shapeRotater.RotateRight(lShape);
            Console.WriteLine(lShape);

            shapeRotater.RotateRight(lShape);
            Console.WriteLine(lShape);

            shapeRotater.RotateRight(lShape);
            Console.WriteLine(lShape);

            shapeRotater.RotateRight(lShape);
            Console.WriteLine(lShape);

            shapeRotater.RotateLeft(lShape);
            Console.WriteLine(lShape);

            //Assert...
        }
    }
}