using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace Terraria.Utilities;

[Cpp2IlInjected.Token(Token = "0x200037E")]
public class WeightedRandom<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400319F")]
	public readonly List<Tuple<T, double>> elements;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40031A0")]
	public readonly UnifiedRandom random;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40031A1")]
	public bool needsRefresh;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40031A2")]
	private double _totalWeight;

	[Cpp2IlInjected.Token(Token = "0x6002D29")]
	[Cpp2IlInjected.Address(RVA = "0x203F5F8", Offset = "0x203F5F8", VA = "0x203F5F8")]
	public WeightedRandom()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002D2A")]
	[Cpp2IlInjected.Address(RVA = "0x203F6C0", Offset = "0x203F6C0", VA = "0x203F6C0")]
	public WeightedRandom(int seed)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002D2B")]
	[Cpp2IlInjected.Address(RVA = "0x203F790", Offset = "0x203F790", VA = "0x203F790")]
	public WeightedRandom(UnifiedRandom random)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002D2C")]
	[Cpp2IlInjected.Address(RVA = "0x203F808", Offset = "0x203F808", VA = "0x203F808")]
	public WeightedRandom(params Tuple<T, double>[] theElements)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002D2D")]
	[Cpp2IlInjected.Address(RVA = "0x203F8F0", Offset = "0x203F8F0", VA = "0x203F8F0")]
	public WeightedRandom(int seed, params Tuple<T, double>[] theElements)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002D2E")]
	[Cpp2IlInjected.Address(RVA = "0x203F9E0", Offset = "0x203F9E0", VA = "0x203F9E0")]
	public WeightedRandom(UnifiedRandom random, params Tuple<T, double>[] theElements)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002D2F")]
	[Cpp2IlInjected.Address(RVA = "0x203FA78", Offset = "0x203FA78", VA = "0x203FA78")]
	public void Add(T element, double weight = 1.0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002D30")]
	[Cpp2IlInjected.Address(RVA = "0x203FB20", Offset = "0x203FB20", VA = "0x203FB20")]
	public T Get()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002D31")]
	[Cpp2IlInjected.Address(RVA = "0x203FDCC", Offset = "0x203FDCC", VA = "0x203FDCC")]
	public void CalculateTotalWeight()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002D32")]
	[Cpp2IlInjected.Address(RVA = "0x203FFA8", Offset = "0x203FFA8", VA = "0x203FFA8")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002D33")]
	[Cpp2IlInjected.Address(RVA = "0x203FFC0", Offset = "0x203FFC0", VA = "0x203FFC0")]
	public static implicit operator T(WeightedRandom<T> weightedRandom)
	{
		return (T)null;
	}
}
