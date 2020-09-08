namespace Builder_Pattern
{
    public class HouseBuilder : IHousebuilder
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

        public House Build()
        {
            var finalProduct = _house;
            Reset();
            return finalProduct;
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

        public void SetGarage(int number)
        {
            throw new System.NotImplementedException();
        }

        public void SetShape(RanchShape shape)
        {
            throw new System.NotImplementedException();
        }
    }
}
