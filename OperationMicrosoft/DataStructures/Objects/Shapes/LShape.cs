namespace OperationMicrosoft.DataStructures.Objects.Shapes
{
    internal class LShape : BaseShape
    {
        public LShape()
        {
            Dimensions = new[,]
            {
                {false, true, false, false},
                {false, true, false, false},
                {false, true, true, false},
                {false, false, false, false}
            };
        }
    }
}