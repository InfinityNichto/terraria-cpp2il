using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using ReLogic.Utilities;
using Terraria.Utilities;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Biomes;

[Cpp2IlInjected.Token(Token = "0x20005FA")]
public class HiveBiome : MicroBiome
{
	[Cpp2IlInjected.Token(Token = "0x6003DCD")]
	[Cpp2IlInjected.Address(RVA = "0x1462E80", Offset = "0x1462E80", VA = "0x1462E80", Slot = "4")]
	public override bool Place(Point origin, StructureMap structures)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003DCE")]
	[Cpp2IlInjected.Address(RVA = "0x1464968", Offset = "0x1464968", VA = "0x1464968")]
	private static void FrameOutAllHiveContents(Point origin, int squareHalfWidth)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003DCF")]
	[Cpp2IlInjected.Address(RVA = "0x1463CD0", Offset = "0x1463CD0", VA = "0x1463CD0")]
	private static Vector2D CreateHiveTunnel(int i, int j, UnifiedRandom random)
	{
		return default(Vector2D);
	}

	[Cpp2IlInjected.Token(Token = "0x6003DD0")]
	[Cpp2IlInjected.Address(RVA = "0x14639EC", Offset = "0x14639EC", VA = "0x14639EC")]
	private static bool TooCloseToImportantLocations(Point origin)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003DD1")]
	[Cpp2IlInjected.Address(RVA = "0x14650E8", Offset = "0x14650E8", VA = "0x14650E8")]
	private static void CreateDentForHoneyFall(int x, int y, int dir)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003DD2")]
	[Cpp2IlInjected.Address(RVA = "0x1464F08", Offset = "0x1464F08", VA = "0x1464F08")]
	private static void CreateBlockedHoneyCube(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003DD3")]
	[Cpp2IlInjected.Address(RVA = "0x1464D6C", Offset = "0x1464D6C", VA = "0x1464D6C")]
	private static bool SpotActuallyNotInHive(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003DD4")]
	[Cpp2IlInjected.Address(RVA = "0x1464BAC", Offset = "0x1464BAC", VA = "0x1464BAC")]
	private static bool BadSpotForHoneyFall(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003DD5")]
	[Cpp2IlInjected.Address(RVA = "0x1465314", Offset = "0x1465314", VA = "0x1465314")]
	public static void CreateStandForLarva(Vector2D position)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003DD6")]
	[Cpp2IlInjected.Address(RVA = "0x14656F8", Offset = "0x14656F8", VA = "0x14656F8")]
	public HiveBiome()
	{
	}
}
