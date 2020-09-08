namespace Builder_Pattern.ConcreteBuilder
{
    public class RanchBuilder : IHousebuilder
    {
        RanchStyle _house;

        public RanchBuilder()
        {
            Reset();
        }
        private void Reset()
        {
            _house = new RanchStyle();
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
            _house.Garage = number;
        }

        public void SetShape(RanchShape shape)
        {
            _house.Shape = shape;
        }
    }
}
