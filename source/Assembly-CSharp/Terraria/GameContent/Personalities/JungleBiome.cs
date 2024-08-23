using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.GameContent.Personalities
{
	// Token: 0x02000598 RID: 1432
	[global::Cpp2ILInjected.Token(Token = "0x2000836")]
	public class JungleBiome : AShoppingBiome
	{
		// Token: 0x06003BD9 RID: 15321 RVA: 0x0002CB1F File Offset: 0x0002AD1F
		[global::Cpp2ILInjected.Token(Token = "0x60042FC")]
		[global::Cpp2ILInjected.Address(RVA = "0x79D0E0", Offset = "0x79D0E0", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PersonalityDatabasePopulator), Member = "Populate_BiomePreferences", MemberParameters = new object[] { typeof(PersonalityDatabase) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public JungleBiome()
		{
			throw null;
		}

		// Token: 0x06003BDA RID: 15322 RVA: 0x0002CB22 File Offset: 0x0002AD22
		[global::Cpp2ILInjected.Token(Token = "0x60042FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x79D280", Offset = "0x79D280", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ZoneJungle", ReturnType = typeof(bool))]
		public override bool IsInBiome(Player player)
		{
			throw null;
		}
	}
}
