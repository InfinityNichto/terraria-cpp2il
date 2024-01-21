using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria.IO;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Biomes;

[Cpp2IlInjected.Token(Token = "0x20005FC")]
public class JunglePass : GenPass
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4006C00")]
	private double _worldScale;

	[Cpp2IlInjected.Token(Token = "0x6003DD9")]
	[Cpp2IlInjected.Address(RVA = "0x14660D0", Offset = "0x14660D0", VA = "0x14660D0")]
	public JunglePass()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003DDA")]
	[Cpp2IlInjected.Address(RVA = "0x1466150", Offset = "0x1466150", VA = "0x1466150", Slot = "4")]
	protected override void ApplyPass(GenerationProgress progress, GameConfiguration configuration)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003DDB")]
	[Cpp2IlInjected.Address(RVA = "0x1466AB8", Offset = "0x1466AB8", VA = "0x1466AB8")]
	private void PlaceGemsAt(int x, int y, ushort baseGem, int gemVariants)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003DDC")]
	[Cpp2IlInjected.Address(RVA = "0x1466928", Offset = "0x1466928", VA = "0x1466928")]
	private void PlaceFirstPassMud(int x, int y, int xSpeedScale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003DDD")]
	[Cpp2IlInjected.Address(RVA = "0x14666A4", Offset = "0x14666A4", VA = "0x14666A4")]
	private Point CreateStartPoint()
	{
		return default(Point);
	}

	[Cpp2IlInjected.Token(Token = "0x6003DDE")]
	[Cpp2IlInjected.Address(RVA = "0x1466794", Offset = "0x1466794", VA = "0x1466794")]
	private void ApplyRandomMovement(ref int x, ref int y, int xRange, int yRange)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003DDF")]
	[Cpp2IlInjected.Address(RVA = "0x1466CA8", Offset = "0x1466CA8", VA = "0x1466CA8")]
	private void GenerateTunnelToSurface(int i, int j)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003DE0")]
	[Cpp2IlInjected.Address(RVA = "0x1467AF4", Offset = "0x1467AF4", VA = "0x1467AF4")]
	private void GenerateHolesInMudWalls()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003DE1")]
	[Cpp2IlInjected.Address(RVA = "0x1467D48", Offset = "0x1467D48", VA = "0x1467D48")]
	private void GenerateFinishingTouches(GenerationProgress progress, int oldX, int oldY)
	{
	}
}
