using SadConsole;
using SadConsole.Configuration;

Settings.WindowTitle = "Roguelike";

Builder config = new Builder()
    .SetWindowSizeInCells(80, 40)
    .UseDefaultConsole()
    .OnStart(Startup);

Game.Create(config);
Game.Instance.Run();
Game.Instance.Dispose();

static void Startup(object? sender, GameHost host)
{
    var console = Game.Instance.StartingConsole!;
    console.Print(10, 10, "It worked!");
}

