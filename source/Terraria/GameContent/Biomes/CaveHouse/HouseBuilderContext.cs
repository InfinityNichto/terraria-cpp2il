using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.GameContent.Biomes.CaveHouse
{
	[global::Cpp2ILInjected.Token(Token = "0x200090F")]
	public class HouseBuilderContext
	{
		[global::Cpp2ILInjected.Token(Token = "0x60046C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x7E1774", Offset = "0x7E1774", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CaveHouseBiome), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public HouseBuilderContext()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40082AA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public int SharpenerCount;

		[global::Cpp2ILInjected.Token(Token = "0x40082AB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public int ExtractinatorCount;
	}
}
