using SadConsole;
using SadConsole.Configuration;
using Roguelike.Client;

Settings.WindowTitle = "Roguelike";

Builder config = new Builder()
    .SetWindowSizeInCells(100, 70)
    .SetStartingScreen<RootScreen>()
    .IsStartingScreenFocused(true)
    .SetDefaultFontSize(IFont.Sizes.Half);


Game.Create(config);
Game.Instance.Run();
Game.Instance.Dispose();
