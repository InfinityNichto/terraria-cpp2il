using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.GameContent.Personalities
{
	// Token: 0x0200059B RID: 1435
	[global::Cpp2ILInjected.Token(Token = "0x2000839")]
	public class MushroomBiome : AShoppingBiome
	{
		// Token: 0x06003BDF RID: 15327 RVA: 0x0002CB31 File Offset: 0x0002AD31
		[global::Cpp2ILInjected.Token(Token = "0x6004302")]
		[global::Cpp2ILInjected.Address(RVA = "0x79D1DC", Offset = "0x79D1DC", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PersonalityDatabasePopulator), Member = "Populate_BiomePreferences", MemberParameters = new object[] { typeof(PersonalityDatabase) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public MushroomBiome()
		{
			throw null;
		}

		// Token: 0x06003BE0 RID: 15328 RVA: 0x0002CB34 File Offset: 0x0002AD34
		[global::Cpp2ILInjected.Token(Token = "0x6004303")]
		[global::Cpp2ILInjected.Address(RVA = "0x79D2A4", Offset = "0x79D2A4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ZoneGlowshroom", ReturnType = typeof(bool))]
		public override bool IsInBiome(Player player)
		{
			throw null;
		}
	}
}
