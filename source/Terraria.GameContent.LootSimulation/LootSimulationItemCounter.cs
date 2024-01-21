using Cpp2IlInjected;

namespace Terraria.GameContent.LootSimulation;

[Cpp2IlInjected.Token(Token = "0x20005B9")]
public class LootSimulationItemCounter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006B64")]
	private long[] _itemCountsObtained;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006B65")]
	private long[] _itemCountsObtainedExpert;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006B66")]
	private long _totalTimesAttempted;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4006B67")]
	private long _totalTimesAttemptedExpert;

	[Cpp2IlInjected.Token(Token = "0x6003C6A")]
	[Cpp2IlInjected.Address(RVA = "0x1054D68", Offset = "0x1054D68", VA = "0x1054D68")]
	public LootSimulationItemCounter()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003C6B")]
	[Cpp2IlInjected.Address(RVA = "0x1054DE4", Offset = "0x1054DE4", VA = "0x1054DE4")]
	public void AddItem(int itemId, int amount, bool expert)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003C6C")]
	[Cpp2IlInjected.Address(RVA = "0x1054E14", Offset = "0x1054E14", VA = "0x1054E14")]
	public void Exclude(params int[] itemIds)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003C6D")]
	[Cpp2IlInjected.Address(RVA = "0x1054E6C", Offset = "0x1054E6C", VA = "0x1054E6C")]
	public void IncreaseTimesAttempted(int amount, bool expert)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003C6E")]
	[Cpp2IlInjected.Address(RVA = "0x1054E94", Offset = "0x1054E94", VA = "0x1054E94")]
	public string PrintCollectedItems(bool expert)
	{
		return null;
	}
}
