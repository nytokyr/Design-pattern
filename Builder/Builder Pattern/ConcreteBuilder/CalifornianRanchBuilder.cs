namespace Builder_Pattern.ConcreteBuilder
{
    public class CalifornianRanchBuilder : HouseBuilder
    {
        House _house = new House();
        internal override void SetRooms()
        {
            _house.Room = 6;
        }

        internal override void SetGarage()
        {
            _house.Garage = 1;
        }

        internal override void SetWindow()
        {
            _house.Window = 12;
        }

        internal override void SetDoors()
        {
            _house.Door = 3;
        }

        internal override void SetShape()
        {
            _house.Shape = RanchShape.Rectangular;
        }

        public House Build()
        {
            return _house;
        }
    }
}
