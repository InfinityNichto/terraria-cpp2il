using System.Collections.Generic;
using Cpp2IlInjected;

namespace Terraria.GameContent.LootSimulation;

[Cpp2IlInjected.Token(Token = "0x20005B7")]
public class LootSimulator
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006B5B")]
	private List<ISimulationConditionSetter> _neededTestConditions;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006B5C")]
	private int[] _excludedItemIds;

	[Cpp2IlInjected.Token(Token = "0x6003C60")]
	[Cpp2IlInjected.Address(RVA = "0x10554D8", Offset = "0x10554D8", VA = "0x10554D8")]
	public LootSimulator()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003C61")]
	[Cpp2IlInjected.Address(RVA = "0x105572C", Offset = "0x105572C", VA = "0x105572C")]
	private void FillItemExclusions()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003C62")]
	[Cpp2IlInjected.Address(RVA = "0x1055588", Offset = "0x1055588", VA = "0x1055588")]
	private void FillDesiredTestConditions()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003C63")]
	[Cpp2IlInjected.Address(RVA = "0x1055D38", Offset = "0x1055D38", VA = "0x1055D38")]
	public void Run()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003C64")]
	[Cpp2IlInjected.Address(RVA = "0x1055E94", Offset = "0x1055E94", VA = "0x1055E94")]
	private void SetCleanSlateWorldConditions()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003C65")]
	[Cpp2IlInjected.Address(RVA = "0x1055FB8", Offset = "0x1055FB8", VA = "0x1055FB8")]
	private bool TryGettingLootFor(int npcNetId, int timesMultiplier, out string outputText)
	{
		return default(bool);
	}
}
