using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.GameContent.Biomes.CaveHouse
{
	// Token: 0x0200060A RID: 1546
	[global::Cpp2ILInjected.Token(Token = "0x200090F")]
	public class HouseBuilderContext
	{
		// Token: 0x06003E1A RID: 15898 RVA: 0x0002D182 File Offset: 0x0002B382
		[global::Cpp2ILInjected.Token(Token = "0x60046C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x7E1774", Offset = "0x7E1774", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CaveHouseBiome), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public HouseBuilderContext()
		{
			throw null;
		}

		// Token: 0x04006C29 RID: 27689
		[global::Cpp2ILInjected.Token(Token = "0x40082AA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public int SharpenerCount;

		// Token: 0x04006C2A RID: 27690
		[global::Cpp2ILInjected.Token(Token = "0x40082AB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public int ExtractinatorCount;
	}
}
