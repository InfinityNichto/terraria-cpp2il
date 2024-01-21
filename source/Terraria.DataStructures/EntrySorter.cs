using System.Collections.Generic;
using Cpp2IlInjected;

namespace Terraria.DataStructures;

[Cpp2IlInjected.Token(Token = "0x2000431")]
public class EntrySorter<TEntryType, TStepType> : IComparer<TEntryType> where TEntryType : new() where TStepType : IEntrySortStep<TEntryType>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40062E5")]
	public List<TStepType> Steps;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40062E6")]
	private int _prioritizedStep;

	[Cpp2IlInjected.Token(Token = "0x600311E")]
	[Cpp2IlInjected.Address(RVA = "0x163E33C", Offset = "0x163E33C", VA = "0x163E33C")]
	public void AddSortSteps(List<TStepType> sortSteps)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600311F")]
	[Cpp2IlInjected.Address(RVA = "0x163E354", Offset = "0x163E354", VA = "0x163E354", Slot = "4")]
	public int Compare(TEntryType x, TEntryType y)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6003120")]
	[Cpp2IlInjected.Address(RVA = "0x163E54C", Offset = "0x163E54C", VA = "0x163E54C")]
	public void SetPrioritizedStepIndex(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003121")]
	[Cpp2IlInjected.Address(RVA = "0x163E554", Offset = "0x163E554", VA = "0x163E554")]
	public string GetDisplayName()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003122")]
	[Cpp2IlInjected.Address(RVA = "0x163E61C", Offset = "0x163E61C", VA = "0x163E61C")]
	public EntrySorter()
	{
	}
}
