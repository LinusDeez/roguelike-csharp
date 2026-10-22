using SadConsole;
using SadRogue.Primitives;

namespace Roguelike.Client;

public class RootScreen : ScreenObject
{
    public RootScreen()
    {
        var inventoryConsole = new SadConsole.Console(80, 11);
        inventoryConsole.Position = new Point(0, 0);
        inventoryConsole.Fill(background: Swatch.DbWood);
        inventoryConsole.Print(1, 1, "Inventory", Colors.TextHeading);
        Children.Add(inventoryConsole);

        var mapConsole = new SadConsole.Console(80, 48);
        mapConsole.Position = new Point(0, 11);
        mapConsole.Fill(background: Colors.FloorBackground);
        mapConsole.Print(1, 1, "Map", Colors.TextHeading);
        Children.Add(mapConsole);

        var messageConsole = new SadConsole.Console(80, 11);
        messageConsole.Position = new Point(0, 59);
        messageConsole.Fill(background: Swatch.DbDeepWater);
        messageConsole.Print(1, 1, "Messages", Colors.TextHeading);
        Children.Add(messageConsole);

        var statsConsole = new SadConsole.Console(20, 70);
        statsConsole.Position = new Point(80, 0);
        statsConsole.Fill(background: Swatch.DbOldStone);
        statsConsole.Print(1, 1, "Stats", Colors.TextHeading);
        Children.Add(statsConsole);
    }
}