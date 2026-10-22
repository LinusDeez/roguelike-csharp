using SadRogue.Primitives;

namespace Roguelike.Client;

public static class Swatch
{
    // Paletton-Tetrade (paletton.com)
    public static Color PrimaryLightest { get; } = new Color(110, 121, 119);
    public static Color PrimaryLighter { get; } = new Color(88, 100, 98);
    public static Color Primary { get; } = new Color(68, 82, 79);
    public static Color PrimaryDarker { get; } = new Color(48, 61, 59);
    public static Color PrimaryDarkest { get; } = new Color(29, 45, 42);

    public static Color SecondaryLightest { get; } = new Color(116, 120, 126);
    public static Color SecondaryLighter { get; } = new Color(93, 97, 105);
    public static Color Secondary { get; } = new Color(72, 77, 85);
    public static Color SecondaryDarker { get; } = new Color(51, 56, 64);
    public static Color SecondaryDarkest { get; } = new Color(31, 38, 47);

    public static Color AlternateLightest { get; } = new Color(190, 184, 174);
    public static Color AlternateLighter { get; } = new Color(158, 151, 138);
    public static Color Alternate { get; } = new Color(129, 121, 107);
    public static Color AlternateDarker { get; } = new Color(97, 89, 75);
    public static Color AlternateDarkest { get; } = new Color(71, 62, 45);

    public static Color ComplimentLightest { get; } = new Color(190, 180, 174);
    public static Color ComplimentLighter { get; } = new Color(158, 147, 138);
    public static Color Compliment { get; } = new Color(129, 116, 107);
    public static Color ComplimentDarker { get; } = new Color(97, 84, 75);
    public static Color ComplimentDarkest { get; } = new Color(71, 56, 45);

    // DawnBringer-16-Palette (pixeljoint.com)
    public static Color DbDark { get; } = new Color(20, 12, 28);
    public static Color DbOldBlood { get; } = new Color(68, 36, 52);
    public static Color DbDeepWater { get; } = new Color(48, 52, 109);
    public static Color DbOldStone { get; } = new Color(78, 74, 78);
    public static Color DbWood { get; } = new Color(133, 76, 48);
    public static Color DbVegetation { get; } = new Color(52, 101, 36);
    public static Color DbBlood { get; } = new Color(208, 70, 72);
    public static Color DbStone { get; } = new Color(117, 113, 97);
    public static Color DbWater { get; } = new Color(89, 125, 206);
    public static Color DbBrightWood { get; } = new Color(210, 125, 44);
    public static Color DbMetal { get; } = new Color(133, 149, 161);
    public static Color DbGrass { get; } = new Color(109, 170, 44);
    public static Color DbSkin { get; } = new Color(210, 170, 153);
    public static Color DbSky { get; } = new Color(109, 194, 202);
    public static Color DbSun { get; } = new Color(218, 212, 94);
    public static Color DbLight { get; } = new Color(222, 238, 214);
}
