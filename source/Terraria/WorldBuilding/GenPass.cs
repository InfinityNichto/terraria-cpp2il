using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.GameContent.Biomes;
using Terraria.GameContent.Generation;
using Terraria.IO;

namespace Terraria.WorldBuilding
{
	// Token: 0x0200035D RID: 861
	[global::Cpp2ILInjected.Token(Token = "0x20004CD")]
	public abstract class GenPass : GenBase
	{
		// Token: 0x06002C40 RID: 11328 RVA: 0x00029EF1 File Offset: 0x000280F1
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

		// Token: 0x06002C41 RID: 11329
		[global::Cpp2ILInjected.Token(Token = "0x6003025")]
		protected abstract void ApplyPass(GenerationProgress progress, GameConfiguration configuration);

		// Token: 0x06002C42 RID: 11330 RVA: 0x00029EF4 File Offset: 0x000280F4
		[global::Cpp2ILInjected.Token(Token = "0x6003026")]
		[global::Cpp2ILInjected.Address(RVA = "0x12F9058", Offset = "0x12F9058", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Apply(GenerationProgress progress, GameConfiguration configuration)
		{
			throw null;
		}

		// Token: 0x040030CA RID: 12490
		[global::Cpp2ILInjected.Token(Token = "0x40039CA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public string Name;

		// Token: 0x040030CB RID: 12491
		[global::Cpp2ILInjected.Token(Token = "0x40039CB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public double Weight;
	}
}
