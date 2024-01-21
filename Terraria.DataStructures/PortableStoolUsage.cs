using Cpp2IlInjected;

namespace Terraria.DataStructures;

[Cpp2IlInjected.Token(Token = "0x2000451")]
public struct PortableStoolUsage
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4006403")]
	public bool HasAStool;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4006404")]
	public bool IsInUse;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4006405")]
	public int HeightBoost;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006406")]
	public int VisualYOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006407")]
	public int MapYOffset;

	[Cpp2IlInjected.Token(Token = "0x6003207")]
	[Cpp2IlInjected.Address(RVA = "0x39DA6C", Offset = "0x39DA6C", VA = "0x39DA6C")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003208")]
	[Cpp2IlInjected.Address(RVA = "0x39DA84", Offset = "0x39DA84", VA = "0x39DA84")]
	public void SetStats(int heightBoost, int visualYOffset, int mapYOffset)
	{
	}
}
