using Cpp2IlInjected;

namespace Terraria.DataStructures;

[Cpp2IlInjected.Token(Token = "0x200044E")]
public struct PlayerInteractionAnchor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40063EF")]
	public int interactEntityID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40063F0")]
	public int X;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40063F1")]
	public int Y;

	[Cpp2IlInjected.Token(Token = "0x17000625")]
	public bool InUse
	{
		[Cpp2IlInjected.Token(Token = "0x60031F4")]
		[Cpp2IlInjected.Address(RVA = "0x39D800", Offset = "0x39D800", VA = "0x39D800")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60031F3")]
	[Cpp2IlInjected.Address(RVA = "0x39D7F4", Offset = "0x39D7F4", VA = "0x39D7F4")]
	public PlayerInteractionAnchor(int entityID, int x = -1, int y = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60031F5")]
	[Cpp2IlInjected.Address(RVA = "0x39D814", Offset = "0x39D814", VA = "0x39D814")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60031F6")]
	[Cpp2IlInjected.Address(RVA = "0x39D828", Offset = "0x39D828", VA = "0x39D828")]
	public void Set(int entityID, int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60031F7")]
	[Cpp2IlInjected.Address(RVA = "0x39D834", Offset = "0x39D834", VA = "0x39D834")]
	public bool IsInValidUseTileEntity()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60031F8")]
	[Cpp2IlInjected.Address(RVA = "0x39D83C", Offset = "0x39D83C", VA = "0x39D83C")]
	public TileEntity GetTileEntity()
	{
		return null;
	}
}
