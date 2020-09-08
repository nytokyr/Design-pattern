using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_Pattern
{
    interface IHousebuilder
    {
        void SetWindow(int number);
        void SetDoor(int number);
        void SetRoom(int number);
        House Build();
    }
}
