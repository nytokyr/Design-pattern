namespace Builder_Pattern
{
    public class House
    {
        public int Window { get; set; }
        public int Door { get; set; }
        public int Room { get; set; }
        public RanchShape? Shape { get; set; }
        public int Garage { get; set; }
    }

    public enum RanchShape
    {
        Rectangular,
        L,
        U
    }
}
