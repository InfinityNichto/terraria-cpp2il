using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.DataStructures;

[Cpp2IlInjected.Token(Token = "0x2000479")]
public struct SpriteFrame
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4006434")]
	public int PaddingX;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4006435")]
	public int PaddingY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006436")]
	private byte _currentColumn;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4006437")]
	private byte _currentRow;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x4006438")]
	public readonly byte ColumnCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
	[Cpp2IlInjected.Token(Token = "0x4006439")]
	public readonly byte RowCount;

	[Cpp2IlInjected.Token(Token = "0x1700062A")]
	public byte CurrentColumn
	{
		[Cpp2IlInjected.Token(Token = "0x600324F")]
		[Cpp2IlInjected.Address(RVA = "0x39DB00", Offset = "0x39DB00", VA = "0x39DB00")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6003250")]
		[Cpp2IlInjected.Address(RVA = "0x39DB08", Offset = "0x39DB08", VA = "0x39DB08")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700062B")]
	public byte CurrentRow
	{
		[Cpp2IlInjected.Token(Token = "0x6003251")]
		[Cpp2IlInjected.Address(RVA = "0x39DB10", Offset = "0x39DB10", VA = "0x39DB10")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6003252")]
		[Cpp2IlInjected.Address(RVA = "0x39DB18", Offset = "0x39DB18", VA = "0x39DB18")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6003253")]
	[Cpp2IlInjected.Address(RVA = "0x39DB20", Offset = "0x39DB20", VA = "0x39DB20")]
	public SpriteFrame(byte columns, byte rows)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003254")]
	[Cpp2IlInjected.Address(RVA = "0x39DB40", Offset = "0x39DB40", VA = "0x39DB40")]
	public SpriteFrame(byte columns, byte rows, byte currentColumn, byte currentRow)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003255")]
	[Cpp2IlInjected.Address(RVA = "0x39DB6C", Offset = "0x39DB6C", VA = "0x39DB6C")]
	public SpriteFrame With(byte columnToUse, byte rowToUse)
	{
		return default(SpriteFrame);
	}

	[Cpp2IlInjected.Token(Token = "0x6003256")]
	[Cpp2IlInjected.Address(RVA = "0x39DB94", Offset = "0x39DB94", VA = "0x39DB94")]
	public Rectangle GetSourceRectangle(Texture2D texture)
	{
		return default(Rectangle);
	}
}
