using SadConsole;
using SadRogue.Primitives;

namespace Roguelike.Client;

public class RootScreen : ScreenObject
{
    public RootScreen()
    {
        var inventoryConsole = new SadConsole.Console(80, 11);
        inventoryConsole.Position = new Point(0, 0);
        inventoryConsole.Fill(background: Color.Cyan);
        inventoryConsole.Print(1, 1, "Inventory");
        Children.Add(inventoryConsole);

        var mapConsole = new SadConsole.Console(80, 48);
        mapConsole.Position = new Point(0, 11);
        mapConsole.Fill(background: Color.Black);
        mapConsole.Print(1, 1, "Map");
        Children.Add(mapConsole);

        var messageConsole = new SadConsole.Console(80, 11);
        messageConsole.Position = new Point(0, 59);
        messageConsole.Fill(background: Color.Gray);
        messageConsole.Print(1, 1, "Messages");
        Children.Add(messageConsole);

        var statsConsole = new SadConsole.Console(20, 70);
        statsConsole.Position = new Point(80, 0);
        statsConsole.Fill(background: Color.Brown);
        statsConsole.Print(1, 1, "Stats");
        Children.Add(statsConsole);
    }
}