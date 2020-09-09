namespace Builder_Pattern.ConcreteBuilder
{
    public class CampagneHouseBuilder : HouseBuilder
    {
        House _house = new House();
        internal override void SetRooms()
        {
            _house.Room = 6;
        }

        internal override void SetWindow()
        {
            _house.Window = 12;
        }

        internal override void SetDoors()
        {
            _house.Door = 3;
        }

        public House Build()
        {
            return _house;
        }
    }
}
