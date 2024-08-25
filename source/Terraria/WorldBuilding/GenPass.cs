using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.GameContent.Biomes;
using Terraria.GameContent.Generation;
using Terraria.IO;

namespace Terraria.WorldBuilding
{
	[global::Cpp2ILInjected.Token(Token = "0x20004CD")]
	public abstract class GenPass : GenBase
	{
		[global::Cpp2ILInjected.Token(Token = "0x6003024")]
		[global::Cpp2ILInjected.Address(RVA = "0x12F9020", Offset = "0x12F9020", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PassLegacy), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(WorldGenLegacyMethod)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PassLegacy), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(WorldGenLegacyMethod),
			typeof(double)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JunglePass), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TerrainPass), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public GenPass(string name, double loadWeight)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003025")]
		protected abstract void ApplyPass(GenerationProgress progress, GameConfiguration configuration);

		[global::Cpp2ILInjected.Token(Token = "0x6003026")]
		[global::Cpp2ILInjected.Address(RVA = "0x12F9058", Offset = "0x12F9058", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Apply(GenerationProgress progress, GameConfiguration configuration)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40039CA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public string Name;

		[global::Cpp2ILInjected.Token(Token = "0x40039CB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public double Weight;
	}
}
