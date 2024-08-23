using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.GameContent.Personalities
{
	// Token: 0x02000594 RID: 1428
	[global::Cpp2ILInjected.Token(Token = "0x2000832")]
	public class OceanBiome : AShoppingBiome
	{
		// Token: 0x06003BD1 RID: 15313 RVA: 0x0002CB07 File Offset: 0x0002AD07
		[global::Cpp2ILInjected.Token(Token = "0x60042F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x79CF90", Offset = "0x79CF90", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PersonalityDatabasePopulator), Member = "Populate_BiomePreferences", MemberParameters = new object[] { typeof(PersonalityDatabase) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public OceanBiome()
		{
			throw null;
		}

		// Token: 0x06003BD2 RID: 15314 RVA: 0x0002CB0A File Offset: 0x0002AD0A
		[global::Cpp2ILInjected.Token(Token = "0x60042F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x79D250", Offset = "0x79D250", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ZoneBeach", ReturnType = typeof(bool))]
		public override bool IsInBiome(Player player)
		{
			throw null;
		}
	}
}
