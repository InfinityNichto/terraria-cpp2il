using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.DataStructures;

[Cpp2IlInjected.Token(Token = "0x200043C")]
public struct ItemSyncPersistentStats
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4006301")]
	private Color color;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4006302")]
	private int type;

	[Cpp2IlInjected.Token(Token = "0x6003149")]
	[Cpp2IlInjected.Address(RVA = "0x39B094", Offset = "0x39B094", VA = "0x39B094")]
	public void CopyFrom(Item item)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600314A")]
	[Cpp2IlInjected.Address(RVA = "0x39B0A8", Offset = "0x39B0A8", VA = "0x39B0A8")]
	public void PasteInto(Item item)
	{
	}
}
