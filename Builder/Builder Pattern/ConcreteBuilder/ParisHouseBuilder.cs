namespace Builder_Pattern.ConcreteBuilder
{
    public class ParisHouseBuilder : HouseBuilder
    {
        House _house = new House();
        internal override void SetRooms()
        {
            _house.Room = 2;
        }

        internal override void SetWindow()
        {
            _house.Window = 2;
        }

        internal override void SetDoors()
        {
            _house.Door = 1;
        }

        public House Build()
        {
            return _house;
        }

    }
}
