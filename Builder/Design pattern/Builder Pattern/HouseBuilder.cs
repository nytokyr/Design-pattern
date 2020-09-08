namespace Builder_Pattern
{
    class HouseBuilder : IHousebuilder
    {
        House _house;

        public HouseBuilder()
        {
            Reset();
        }

        private void Reset()
        {
            _house = new House();
        }

        public void SetDoor(int number)
        {
            _house.Door = number;
        }

        public void SetRoom(int number)
        {
            _house.Room = number;
        }

        public void SetWindow(int number)
        {
            _house.Window = number;
        }

        public House Build()
        {
            var finalProduct = _house;
            Reset();
            return finalProduct;
        }
    }
}
