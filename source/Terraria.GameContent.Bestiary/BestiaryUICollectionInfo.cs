using Cpp2IlInjected;

namespace Terraria.GameContent.Bestiary;

[Cpp2IlInjected.Token(Token = "0x2000628")]
public struct BestiaryUICollectionInfo
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4006C5B")]
	public BestiaryEntry OwnerEntry;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4006C5C")]
	public BestiaryEntryUnlockState UnlockState;
}
