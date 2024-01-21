using Cpp2IlInjected;

namespace Terraria.DataStructures;

[Cpp2IlInjected.Token(Token = "0x2000478")]
public class SoundPlaySet
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006431")]
	public int IntendedCooldown;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006432")]
	public int SoundType;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006433")]
	public int SoundStyle;

	[Cpp2IlInjected.Token(Token = "0x600324E")]
	[Cpp2IlInjected.Address(RVA = "0x122F1FC", Offset = "0x122F1FC", VA = "0x122F1FC")]
	public SoundPlaySet()
	{
	}
}
