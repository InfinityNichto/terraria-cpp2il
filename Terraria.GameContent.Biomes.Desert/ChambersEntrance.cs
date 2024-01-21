using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using ReLogic.Utilities;

namespace Terraria.GameContent.Biomes.Desert;

[Cpp2IlInjected.Token(Token = "0x2000603")]
public static class ChambersEntrance
{
	[Cpp2IlInjected.Token(Token = "0x20009FF")]
	private struct PathConnection
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4008D0D")]
		public readonly Vector2D Position;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4008D0E")]
		public readonly double Direction;

		[Cpp2IlInjected.Token(Token = "0x6004FA4")]
		[Cpp2IlInjected.Address(RVA = "0x39F1A8", Offset = "0x39F1A8", VA = "0x39F1A8")]
		public PathConnection(Point position, int direction)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6003DF5")]
	[Cpp2IlInjected.Address(RVA = "0x1457A6C", Offset = "0x1457A6C", VA = "0x1457A6C")]
	public static void Place(DesertDescription description)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003DF6")]
	[Cpp2IlInjected.Address(RVA = "0x1457B60", Offset = "0x1457B60", VA = "0x1457B60")]
	private static void PlaceAt(DesertDescription description, Point position)
	{
	}
}
