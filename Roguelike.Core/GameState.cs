namespace Roguelike.Core;

public class GameState(DungeonMap map)
{
    public DungeonMap Map { get; } = map;
}