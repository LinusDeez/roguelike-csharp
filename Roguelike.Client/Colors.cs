using SadRogue.Primitives;

namespace Roguelike.Client;

public static class Colors
{
    public static Color FloorBackground { get; } = Color.Black;
    public static Color Floor { get; } = Swatch.AlternateDarkest;
    public static Color FloorBackgroundFov { get; } = Swatch.DbDark;
    public static Color FloorFov { get; } = Swatch.Alternate;

    public static Color WallBackground { get; } = Swatch.SecondaryDarkest;
    public static Color Wall { get; } = Swatch.Secondary;
    public static Color WallBackgroundFov { get; } = Swatch.SecondaryDarker;
    public static Color WallFov { get; } = Swatch.SecondaryLighter;

    public static Color TextHeading { get; } = Swatch.DbLight;
}
