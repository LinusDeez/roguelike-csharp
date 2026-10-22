using RogueSharp;

namespace Roguelike.Core;

public class MapGenerator(int width, int height)
{
    public DungeonMap CreateMap()
    {
        DungeonMap map = new DungeonMap();
        map.Initialize(width, height);

        foreach (ICell cell in map.GetAllCells())
        {
            map.SetCellProperties(cell.X, cell.Y, isTransparent: true, isWalkable: true, isExplored: true);
        }

        foreach (ICell cell in map.GetCellsInRows(0, height - 1))
        {
            map.SetCellProperties(cell.X, cell.Y, isTransparent: false, isWalkable: false, isExplored: true);
        }

        foreach (ICell cell in map.GetCellsInColumns(0, width - 1))
        {
            map.SetCellProperties(cell.X, cell.Y, isTransparent: false, isWalkable: false, isExplored: true);
        }

        return map;
    }
}