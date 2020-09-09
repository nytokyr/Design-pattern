using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_Pattern
{
    public class ConstructionEngineer
    {
        HouseBuilder _houseBuilder;

        public ConstructionEngineer(HouseBuilder houseBuilder)
        {
            _houseBuilder = houseBuilder;
        }

        public void BuildHouse()
        {
            _houseBuilder.SetShape();
            _houseBuilder.SetRooms();
            _houseBuilder.SetDoors();
            _houseBuilder.SetWindow();
            _houseBuilder.SetGarage();
        }

    }
}
