using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;

namespace Terraria;

[Cpp2IlInjected.Token(Token = "0x200034E")]
public struct TileObject
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4002F94")]
	public int xCoord;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4002F95")]
	public int yCoord;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4002F96")]
	public int type;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4002F97")]
	public int style;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4002F98")]
	public int alternate;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4002F99")]
	public int random;

	[Cpp2IlInjected.Token(Token = "0x4002F9A")]
	public static TileObject Empty;

	[Cpp2IlInjected.Token(Token = "0x1700058E")]
	public static TileObjectPreviewData objectPreview
	{
		[Cpp2IlInjected.Token(Token = "0x6002864")]
		[Cpp2IlInjected.Address(RVA = "0x14AC108", Offset = "0x14AC108", VA = "0x14AC108")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6002865")]
	[Cpp2IlInjected.Address(RVA = "0x14AC184", Offset = "0x14AC184", VA = "0x14AC184")]
	public static bool Place(TileObject toBePlaced)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002866")]
	[Cpp2IlInjected.Address(RVA = "0x14ACDEC", Offset = "0x14ACDEC", VA = "0x14ACDEC")]
	public static bool CanPlace(int x, int y, int type, int style, int dir, out TileObject objectData, bool onlyCheck = false, [Optional] int? forcedRandom)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002867")]
	[Cpp2IlInjected.Address(RVA = "0x14AFFD4", Offset = "0x14AFFD4", VA = "0x14AFFD4")]
	public static void DrawPreview(SpriteBatch sb, TileObjectPreviewData op, Vector2 position)
	{
	}
}
