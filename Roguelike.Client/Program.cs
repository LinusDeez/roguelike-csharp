using SadConsole;
using SadConsole.Configuration;
using Roguelike.Client;
using Roguelike.Core;

Settings.WindowTitle = "Roguelike";

var generator = new MapGenerator(80, 48);
var gameState = new GameState(generator.CreateMap());

Builder config = new Builder()
    .SetWindowSizeInCells(100, 70)
    .SetStartingScreen(host => new RootScreen(gameState))
    .IsStartingScreenFocused(true)
    .SetDefaultFontSize(IFont.Sizes.Half);


Game.Create(config);
Game.Instance.Run();
Game.Instance.Dispose();
