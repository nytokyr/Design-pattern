namespace Builder_Pattern.ConcreteBuilder
{
    public class AustralianRanchBuilder : HouseBuilder
    {
        House _house = new House();
        internal override void SetRooms()
        {
            _house.Room = 4;
        }

        internal override void SetGarage()
        {
            _house.Garage = 3;
        }

        internal override void SetWindow()
        {
            _house.Window = 5;
        }

        internal override void SetDoors()
        {
            _house.Door = 2;
        }

        internal override void SetShape()
        {
            _house.Shape = RanchShape.U;
        }

        public House Build()
        {
            return _house;
        }
    }
}
