using Cpp2IlInjected;

namespace Terraria;

[Cpp2IlInjected.Token(Token = "0x200034C")]
public struct TileColorCache
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4002F73")]
	public byte Color;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4002F74")]
	public bool FullBright;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4002F75")]
	public bool Invisible;

	[Cpp2IlInjected.Token(Token = "0x6002835")]
	[Cpp2IlInjected.Address(RVA = "0x3A0588", Offset = "0x3A0588", VA = "0x3A0588")]
	public void ApplyToBlock(Tile tile)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002836")]
	[Cpp2IlInjected.Address(RVA = "0x3A0590", Offset = "0x3A0590", VA = "0x3A0590")]
	public void ApplyToWall(Tile tile)
	{
	}
}
