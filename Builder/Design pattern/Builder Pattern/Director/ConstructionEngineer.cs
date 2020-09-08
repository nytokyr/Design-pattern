using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_Pattern
{
    public class ConstructionEngineer
    {
        IHousebuilder _houseBuilder;

        public ConstructionEngineer(IHousebuilder houseBuilder)
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


        public void BuildRanchAustralia()
        {
            _houseBuilder.SetRoom(4);
            _houseBuilder.SetDoor(2);
            _houseBuilder.SetWindow(5);
            _houseBuilder.SetGarage(3);
            _houseBuilder.SetShape(RanchShape.U);
        }

        public void BuildRanchCalifornia()
        {
            _houseBuilder.SetRoom(6);
            _houseBuilder.SetDoor(3);
            _houseBuilder.SetWindow(12);
            _houseBuilder.SetGarage(1);
            _houseBuilder.SetShape(RanchShape.Rectangular);
        }

    }
}
