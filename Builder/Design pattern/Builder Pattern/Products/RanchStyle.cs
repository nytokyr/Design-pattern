namespace Builder_Pattern
{
    //default ranch is rectangular and has 1 garage
    public class RanchStyle : House
    {
        public RanchShape Shape { get; set; } = RanchShape.Rectangular;
        public int Garage { get; set; } = 1;
    }

    public enum RanchShape
    {
        Rectangular,
        L,
        U
    }
}
