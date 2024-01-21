using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace Terraria.GameContent.ItemDropRules;

[Cpp2IlInjected.Token(Token = "0x20005C5")]
public struct DropRateInfo
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4006B8E")]
	public int itemId;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4006B8F")]
	public int stackMin;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006B90")]
	public int stackMax;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006B91")]
	public float dropRate;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006B92")]
	public List<IItemDropRuleCondition> conditions;

	[Cpp2IlInjected.Token(Token = "0x6003CA3")]
	[Cpp2IlInjected.Address(RVA = "0x39A274", Offset = "0x39A274", VA = "0x39A274")]
	public DropRateInfo(int itemId, int stackMin, int stackMax, float dropRate, [Optional] List<IItemDropRuleCondition> conditions)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003CA4")]
	[Cpp2IlInjected.Address(RVA = "0x39A2A0", Offset = "0x39A2A0", VA = "0x39A2A0")]
	public void AddCondition(IItemDropRuleCondition condition)
	{
	}
}
