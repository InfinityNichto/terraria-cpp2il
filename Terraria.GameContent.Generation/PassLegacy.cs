using System.Collections.Generic;
using Cpp2IlInjected;
using Terraria.IO;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Generation;

[Cpp2IlInjected.Token(Token = "0x20005EC")]
public class PassLegacy : GenPass
{
	[Cpp2IlInjected.Token(Token = "0x4006BD2")]
	private static readonly Dictionary<string, float> _weightMap_135;

	[Cpp2IlInjected.Token(Token = "0x4006BD3")]
	private static readonly Dictionary<string, float> _weightMap;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4006BD4")]
	private readonly WorldGenLegacyMethod _method;

	[Cpp2IlInjected.Token(Token = "0x6003D69")]
	[Cpp2IlInjected.Address(RVA = "0xE64760", Offset = "0xE64760", VA = "0xE64760")]
	public PassLegacy(string name, WorldGenLegacyMethod method)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003D6A")]
	[Cpp2IlInjected.Address(RVA = "0xE648D4", Offset = "0xE648D4", VA = "0xE648D4")]
	public PassLegacy(string name, WorldGenLegacyMethod method, double weight)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003D6B")]
	[Cpp2IlInjected.Address(RVA = "0xE6480C", Offset = "0xE6480C", VA = "0xE6480C")]
	private static float GetWeight(string name)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6003D6C")]
	[Cpp2IlInjected.Address(RVA = "0xE6490C", Offset = "0xE6490C", VA = "0xE6490C", Slot = "4")]
	protected override void ApplyPass(GenerationProgress progress, GameConfiguration configuration)
	{
	}
}
