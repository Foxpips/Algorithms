namespace OperationMicrosoft.DataStructures.Objects.Shapes
{
    public interface IShape
    {
        bool[,] Dimensions { get; set; }
        string Draw();
    }
}