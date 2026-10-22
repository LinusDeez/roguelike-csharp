using SadConsole;
using SadRogue.Primitives;
using Roguelike.Core;

namespace Roguelike.Client;

public class RootScreen : ScreenObject
{
    public RootScreen(GameState state)
    {
        var inventoryConsole = new SadConsole.Console(80, 11);
        inventoryConsole.Position = new Point(0, 0);
        inventoryConsole.Fill(background: Swatch.DbWood);
        inventoryConsole.Print(1, 1, "Inventory", Colors.TextHeading);
        Children.Add(inventoryConsole);

        var mapConsole = new SadConsole.Console(state.Map.Width, state.Map.Height);
        mapConsole.Position = new Point(0, 11);
        MapRenderer.Draw(state.Map, mapConsole);
        Children.Add(mapConsole);

        var messageConsole = new SadConsole.Console(80, 11);
        messageConsole.Position = new Point(0, mapConsole.Position.Y + mapConsole.Height);
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