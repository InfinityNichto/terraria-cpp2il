using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.GameContent.Personalities
{
	// Token: 0x0200059E RID: 1438
	[global::Cpp2ILInjected.Token(Token = "0x200083C")]
	public class CrimsonBiome : AShoppingBiome
	{
		// Token: 0x06003BE5 RID: 15333 RVA: 0x0002CB43 File Offset: 0x0002AD43
		[global::Cpp2ILInjected.Token(Token = "0x6004308")]
		[global::Cpp2ILInjected.Address(RVA = "0x79D370", Offset = "0x79D370", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ShopHelper), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public CrimsonBiome()
		{
			throw null;
		}

		// Token: 0x06003BE6 RID: 15334 RVA: 0x0002CB46 File Offset: 0x0002AD46
		[global::Cpp2ILInjected.Token(Token = "0x6004309")]
		[global::Cpp2ILInjected.Address(RVA = "0x79D3C4", Offset = "0x79D3C4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ZoneCrimson", ReturnType = typeof(bool))]
		public override bool IsInBiome(Player player)
		{
			throw null;
		}
	}
}
