using Cpp2IlInjected;

namespace Terraria.GameContent.UI.ResourceSets;

[Cpp2IlInjected.Token(Token = "0x20006B2")]
public struct PlayerStatsSnapshot
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4006F66")]
	public int Life;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4006F67")]
	public int LifeMax;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006F68")]
	public int LifeFruitCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006F69")]
	public float LifePerSegment;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006F6A")]
	public int Mana;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4006F6B")]
	public int ManaMax;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4006F6C")]
	public float ManaPerSegment;

	[Cpp2IlInjected.Token(Token = "0x60043B3")]
	[Cpp2IlInjected.Address(RVA = "0x39BC38", Offset = "0x39BC38", VA = "0x39BC38")]
	public PlayerStatsSnapshot(Player player)
	{
	}
}
