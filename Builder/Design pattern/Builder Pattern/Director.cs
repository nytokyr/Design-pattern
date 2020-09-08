using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_Pattern
{
    class Director
    {
        IHousebuilder _houseBuilder;

        public Director(HouseBuilder houseBuilder)
        {
            _houseBuilder = houseBuilder;
        }

        public void BuildHouseParisien()
        {
            _houseBuilder.SetRoom(2);
            _houseBuilder.SetDoor(1);
            _houseBuilder.SetWindow(2);
        }

        public void BuildHouseCampagnard()
        {
            _houseBuilder.SetRoom(6);
            _houseBuilder.SetDoor(3);
            _houseBuilder.SetWindow(12);
        }
    }
}
