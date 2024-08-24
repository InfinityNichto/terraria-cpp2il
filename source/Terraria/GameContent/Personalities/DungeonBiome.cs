using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.GameContent.Personalities
{
	// Token: 0x0200059C RID: 1436
	[global::Cpp2ILInjected.Token(Token = "0x200083A")]
	public class DungeonBiome : AShoppingBiome
	{
		// Token: 0x06003BE1 RID: 15329 RVA: 0x0002CB37 File Offset: 0x0002AD37
		[global::Cpp2ILInjected.Token(Token = "0x6004304")]
		[global::Cpp2ILInjected.Address(RVA = "0x79D2B0", Offset = "0x79D2B0", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ShopHelper), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public DungeonBiome()
		{
			throw null;
		}

		// Token: 0x06003BE2 RID: 15330 RVA: 0x0002CB3A File Offset: 0x0002AD3A
		[global::Cpp2ILInjected.Token(Token = "0x6004305")]
		[global::Cpp2ILInjected.Address(RVA = "0x79D304", Offset = "0x79D304", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ZoneDungeon", ReturnType = typeof(bool))]
		public override bool IsInBiome(Player player)
		{
			throw null;
		}
	}
}
