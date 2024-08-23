using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.GameContent.Personalities
{
	// Token: 0x02000599 RID: 1433
	[global::Cpp2ILInjected.Token(Token = "0x2000837")]
	public class UndergroundBiome : AShoppingBiome
	{
		// Token: 0x06003BDB RID: 15323 RVA: 0x0002CB25 File Offset: 0x0002AD25
		[global::Cpp2ILInjected.Token(Token = "0x60042FE")]
		[global::Cpp2ILInjected.Address(RVA = "0x79D134", Offset = "0x79D134", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PersonalityDatabasePopulator), Member = "Populate_BiomePreferences", MemberParameters = new object[] { typeof(PersonalityDatabase) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public UndergroundBiome()
		{
			throw null;
		}

		// Token: 0x06003BDC RID: 15324 RVA: 0x0002CB28 File Offset: 0x0002AD28
		[global::Cpp2ILInjected.Token(Token = "0x60042FF")]
		[global::Cpp2ILInjected.Address(RVA = "0x79D28C", Offset = "0x79D28C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ShoppingZone_BelowSurface", ReturnType = typeof(bool))]
		public override bool IsInBiome(Player player)
		{
			throw null;
		}
	}
}
