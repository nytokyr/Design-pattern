namespace Builder_Pattern
{
    public interface IHousebuilder
    {
        void SetDoor(int number);
        void SetRoom(int number);
        void SetWindow(int number);
        void SetGarage(int number);
        void SetShape(RanchShape shape);
    }
}
