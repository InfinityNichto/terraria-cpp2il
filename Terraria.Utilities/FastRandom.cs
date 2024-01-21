using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Terraria.Utilities;

[Cpp2IlInjected.Token(Token = "0x2000376")]
public struct FastRandom
{
	[Cpp2IlInjected.Token(Token = "0x4003189")]
	public const ulong RANDOM_MULTIPLIER = 25214903917uL;

	[Cpp2IlInjected.Token(Token = "0x400318A")]
	public const ulong RANDOM_ADD = 11uL;

	[Cpp2IlInjected.Token(Token = "0x400318B")]
	public const ulong RANDOM_MASK = 281474976710655uL;

	[Cpp2IlInjected.Token(Token = "0x170005AA")]
	public ulong Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6002CE6")]
		[Cpp2IlInjected.Address(RVA = "0x39C558", Offset = "0x39C558", VA = "0x39C558")]
		[CompilerGenerated]
		get
		{
			return default(ulong);
		}
		[Cpp2IlInjected.Token(Token = "0x6002CE7")]
		[Cpp2IlInjected.Address(RVA = "0x39C560", Offset = "0x39C560", VA = "0x39C560")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6002CE8")]
	[Cpp2IlInjected.Address(RVA = "0x39C570", Offset = "0x39C570", VA = "0x39C570")]
	public FastRandom(ulong seed)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002CE9")]
	[Cpp2IlInjected.Address(RVA = "0x39C580", Offset = "0x39C580", VA = "0x39C580")]
	public FastRandom(int seed)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002CEA")]
	[Cpp2IlInjected.Address(RVA = "0x39C590", Offset = "0x39C590", VA = "0x39C590")]
	public FastRandom WithModifier(ulong modifier)
	{
		return default(FastRandom);
	}

	[Cpp2IlInjected.Token(Token = "0x6002CEB")]
	[Cpp2IlInjected.Address(RVA = "0x39C5D0", Offset = "0x39C5D0", VA = "0x39C5D0")]
	public FastRandom WithModifier(int x, int y)
	{
		return default(FastRandom);
	}

	[Cpp2IlInjected.Token(Token = "0x6002CEC")]
	[Cpp2IlInjected.Address(RVA = "0x10DA86C", Offset = "0x10DA86C", VA = "0x10DA86C")]
	public static FastRandom CreateWithRandomSeed()
	{
		return default(FastRandom);
	}

	[Cpp2IlInjected.Token(Token = "0x6002CED")]
	[Cpp2IlInjected.Address(RVA = "0x39C648", Offset = "0x39C648", VA = "0x39C648")]
	public void NextSeed()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002CEE")]
	[Cpp2IlInjected.Address(RVA = "0x39C680", Offset = "0x39C680", VA = "0x39C680")]
	private int NextBits(int bits)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002CEF")]
	[Cpp2IlInjected.Address(RVA = "0x39C6DC", Offset = "0x39C6DC", VA = "0x39C6DC")]
	public float NextFloat()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6002CF0")]
	[Cpp2IlInjected.Address(RVA = "0x39C738", Offset = "0x39C738", VA = "0x39C738")]
	public double NextDouble()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6002CF1")]
	[Cpp2IlInjected.Address(RVA = "0x39C798", Offset = "0x39C798", VA = "0x39C798")]
	public int Next(int max)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002CF2")]
	[Cpp2IlInjected.Address(RVA = "0x39C7A0", Offset = "0x39C7A0", VA = "0x39C7A0")]
	public int Next(int min, int max)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002CF3")]
	[Cpp2IlInjected.Address(RVA = "0x10DA7CC", Offset = "0x10DA7CC", VA = "0x10DA7CC")]
	private static ulong NextSeed(ulong seed)
	{
		return default(ulong);
	}
}
