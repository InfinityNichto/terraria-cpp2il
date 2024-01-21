using System;
using Cpp2IlInjected;

namespace Terraria.Utilities;

[Serializable]
[Cpp2IlInjected.Token(Token = "0x200037D")]
public class UnifiedRandom
{
	[Cpp2IlInjected.Token(Token = "0x4003198")]
	private const int MBIG = int.MaxValue;

	[Cpp2IlInjected.Token(Token = "0x4003199")]
	private const int MSEED = 161803398;

	[Cpp2IlInjected.Token(Token = "0x400319A")]
	private const int MZ = 0;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400319B")]
	private int inext;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400319C")]
	private int inextp;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400319D")]
	private int[] SeedArray;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400319E")]
	public bool debug;

	[Cpp2IlInjected.Token(Token = "0x6002D1E")]
	[Cpp2IlInjected.Address(RVA = "0x10DE284", Offset = "0x10DE284", VA = "0x10DE284")]
	public UnifiedRandom()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002D1F")]
	[Cpp2IlInjected.Address(RVA = "0x10DE2A8", Offset = "0x10DE2A8", VA = "0x10DE2A8")]
	public UnifiedRandom(int Seed)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002D20")]
	[Cpp2IlInjected.Address(RVA = "0x10DE324", Offset = "0x10DE324", VA = "0x10DE324")]
	public void SetSeed(int Seed)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002D21")]
	[Cpp2IlInjected.Address(RVA = "0x10DE4E0", Offset = "0x10DE4E0", VA = "0x10DE4E0")]
	protected double Sample()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6002D22")]
	[Cpp2IlInjected.Address(RVA = "0x10DE510", Offset = "0x10DE510", VA = "0x10DE510")]
	private int InternalSample()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002D23")]
	[Cpp2IlInjected.Address(RVA = "0x10DE57C", Offset = "0x10DE57C", VA = "0x10DE57C")]
	public int Next()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002D24")]
	[Cpp2IlInjected.Address(RVA = "0x10DE580", Offset = "0x10DE580", VA = "0x10DE580")]
	private double GetSampleForLargeRange()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6002D25")]
	[Cpp2IlInjected.Address(RVA = "0x10DE5D8", Offset = "0x10DE5D8", VA = "0x10DE5D8")]
	public int Next(int minValue, int maxValue)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002D26")]
	[Cpp2IlInjected.Address(RVA = "0x10DE670", Offset = "0x10DE670", VA = "0x10DE670")]
	public int Next(int maxValue)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002D27")]
	[Cpp2IlInjected.Address(RVA = "0x10DE6B0", Offset = "0x10DE6B0", VA = "0x10DE6B0")]
	public double NextDouble()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6002D28")]
	[Cpp2IlInjected.Address(RVA = "0x10DE6E0", Offset = "0x10DE6E0", VA = "0x10DE6E0")]
	public void NextBytes(byte[] buffer)
	{
	}
}
