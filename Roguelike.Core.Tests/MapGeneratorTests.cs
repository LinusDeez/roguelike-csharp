using Roguelike.Core;

namespace Roguelike.Core.Tests;

public class MapGeneratorTests
{
    [Fact]
    public void CreateMap_HasCorrectSize()
    {
        var generator = new MapGenerator(80, 48);

        var map = generator.CreateMap();

        Assert.Equal(80, map.Width);
        Assert.Equal(48, map.Height);
    }

    [Fact]
    public void CreateMap_CornerIsWall()
    {
        var generator = new MapGenerator(80, 48);

        var map = generator.CreateMap();

        Assert.False(map.IsWalkable(0, 0));
    }

    [Fact]
    public void CreateMap_CenterIsWalkable()
    {
        var generator = new MapGenerator(80, 48);

        var map = generator.CreateMap();

        Assert.True(map.IsWalkable(40, 24));
    }
}
