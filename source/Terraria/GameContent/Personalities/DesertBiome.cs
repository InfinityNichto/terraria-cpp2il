using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.GameContent.Personalities
{
	// Token: 0x02000597 RID: 1431
	[global::Cpp2ILInjected.Token(Token = "0x2000835")]
	public class DesertBiome : AShoppingBiome
	{
		// Token: 0x06003BD7 RID: 15319 RVA: 0x0002CB19 File Offset: 0x0002AD19
		[global::Cpp2ILInjected.Token(Token = "0x60042FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x79D08C", Offset = "0x79D08C", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PersonalityDatabasePopulator), Member = "Populate_BiomePreferences", MemberParameters = new object[] { typeof(PersonalityDatabase) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public DesertBiome()
		{
			throw null;
		}

		// Token: 0x06003BD8 RID: 15320 RVA: 0x0002CB1C File Offset: 0x0002AD1C
		[global::Cpp2ILInjected.Token(Token = "0x60042FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x79D274", Offset = "0x79D274", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ZoneDesert", ReturnType = typeof(bool))]
		public override bool IsInBiome(Player player)
		{
			throw null;
		}
	}
}
