using Builder_Pattern;
using Builder_Pattern.ConcreteBuilder;
using FluentAssertions;
using System;
using Xunit;

namespace BuilderPattern.Test
{
    public class Should
    {
        [Fact]
        public void House_paris_ok()
        {
            var houseBuilder = new HouseBuilder();
            var director = new ConstructionEngineer(houseBuilder);
            director.BuildHouseParisien();
            var actual = houseBuilder.Build();
            var expected = new House { Room = 2, Door = 1, Window = 2 };
            actual.Should().BeEquivalentTo(expected);

        }

        [Fact]
        public void House_campagnard_ok()
        {
            var houseBuilder = new HouseBuilder();
            var director = new ConstructionEngineer(houseBuilder);
            director.BuildHouseCampagnard();
            var actual = houseBuilder.Build();
            var expected = new House { Room = 6, Door = 3, Window = 12 };
            actual.Should().BeEquivalentTo(expected);

        }

        [Fact]
        public void Ranch_california_ok()
        {
            var ranchBuilder = new RanchBuilder();
            var director = new ConstructionEngineer(ranchBuilder);
            director.BuildRanchCalifornia();
            var actual = ranchBuilder.Build();
            var expected = new RanchStyle { Room = 6, Door = 3, Window = 12, Garage = 1, Shape = RanchShape.Rectangular };
            actual.Should().BeEquivalentTo(expected);

        }

        [Fact]
        public void Ranch_australia_ok()
        {
            var ranchBuilder = new RanchBuilder();
            var director = new ConstructionEngineer(ranchBuilder);
            director.BuildRanchAustralia();
            var actual = ranchBuilder.Build();
            var expected = new RanchStyle { Room = 4, Door = 2, Window = 5, Garage = 3, Shape = RanchShape.U };
            actual.Should().BeEquivalentTo(expected);

        }
    }
}
