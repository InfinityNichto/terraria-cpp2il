using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.WorldBuilding;

[Cpp2IlInjected.Token(Token = "0x200036D")]
public class TileFont
{
	[Cpp2IlInjected.Token(Token = "0x20008C8")]
	public struct DrawMode
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40080AF")]
		public readonly ushort ForegroundTile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x40080B0")]
		public readonly ushort BackgroundTile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40080B1")]
		public readonly bool HasBackground;

		[Cpp2IlInjected.Token(Token = "0x6004BF2")]
		[Cpp2IlInjected.Address(RVA = "0x2AF514", Offset = "0x2AF514", VA = "0x2AF514")]
		public DrawMode(ushort foregroundTile)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004BF3")]
		[Cpp2IlInjected.Address(RVA = "0x2AF528", Offset = "0x2AF528", VA = "0x2AF528")]
		public DrawMode(ushort foregroundTile, ushort backgroundTile)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4003175")]
	private static readonly Dictionary<char, byte[]> MicroFont;

	[Cpp2IlInjected.Token(Token = "0x6002CA4")]
	[Cpp2IlInjected.Address(RVA = "0xA0F870", Offset = "0xA0F870", VA = "0xA0F870")]
	public static void DrawString(Point start, string text, DrawMode mode)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002CA5")]
	[Cpp2IlInjected.Address(RVA = "0xA0F9EC", Offset = "0xA0F9EC", VA = "0xA0F9EC")]
	private static void DrawChar(Point position, byte[] charData, DrawMode mode)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002CA6")]
	[Cpp2IlInjected.Address(RVA = "0xA0FE64", Offset = "0xA0FE64", VA = "0xA0FE64")]
	public static Point MeasureString(string text)
	{
		return default(Point);
	}

	[Cpp2IlInjected.Token(Token = "0x6002CA7")]
	[Cpp2IlInjected.Address(RVA = "0xA10080", Offset = "0xA10080", VA = "0xA10080")]
	public static void HLineLabel(Point start, int width, string text, DrawMode mode, bool rightSideText = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002CA8")]
	[Cpp2IlInjected.Address(RVA = "0xA10288", Offset = "0xA10288", VA = "0xA10288")]
	public static void VLineLabel(Point start, int height, string text, DrawMode mode, bool bottomText = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002CA9")]
	[Cpp2IlInjected.Address(RVA = "0xA10490", Offset = "0xA10490", VA = "0xA10490")]
	public TileFont()
	{
	}
}
