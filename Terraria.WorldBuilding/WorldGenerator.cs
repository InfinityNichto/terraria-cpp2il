using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace Terraria.WorldBuilding;

[Cpp2IlInjected.Token(Token = "0x2000370")]
public class WorldGenerator
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400317D")]
	private readonly List<GenPass> _passes;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400317E")]
	private double _totalLoadWeight;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400317F")]
	private readonly int _seed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4003180")]
	private readonly WorldGenConfiguration _configuration;

	[Cpp2IlInjected.Token(Token = "0x4003181")]
	public static GenerationProgress CurrentGenerationProgress;

	[Cpp2IlInjected.Token(Token = "0x4003182")]
	public static bool TerminateWorldGen;

	[Cpp2IlInjected.Token(Token = "0x6002CB7")]
	[Cpp2IlInjected.Address(RVA = "0xA11B68", Offset = "0xA11B68", VA = "0xA11B68")]
	public WorldGenerator(int seed, WorldGenConfiguration configuration)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002CB8")]
	[Cpp2IlInjected.Address(RVA = "0xA11BF8", Offset = "0xA11BF8", VA = "0xA11BF8")]
	public void Append(GenPass pass)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002CB9")]
	[Cpp2IlInjected.Address(RVA = "0xA11C6C", Offset = "0xA11C6C", VA = "0xA11C6C")]
	public static void LogGenSeedAtPoint(string tag)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002CBA")]
	[Cpp2IlInjected.Address(RVA = "0xA11C70", Offset = "0xA11C70", VA = "0xA11C70")]
	public static void SaveWorldAtPoint(string tag)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002CBB")]
	[Cpp2IlInjected.Address(RVA = "0xA11C74", Offset = "0xA11C74", VA = "0xA11C74")]
	public void GenerateWorld([Optional] GenerationProgress progress)
	{
	}
}
