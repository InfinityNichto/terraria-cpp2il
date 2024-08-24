using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.GameContent.Personalities
{
	// Token: 0x0200059A RID: 1434
	[global::Cpp2ILInjected.Token(Token = "0x2000838")]
	public class HallowBiome : AShoppingBiome
	{
		// Token: 0x06003BDD RID: 15325 RVA: 0x0002CB2B File Offset: 0x0002AD2B
		[global::Cpp2ILInjected.Token(Token = "0x6004300")]
		[global::Cpp2ILInjected.Address(RVA = "0x79D188", Offset = "0x79D188", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PersonalityDatabasePopulator), Member = "Populate_BiomePreferences", MemberParameters = new object[] { typeof(PersonalityDatabase) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public HallowBiome()
		{
			throw null;
		}

		// Token: 0x06003BDE RID: 15326 RVA: 0x0002CB2E File Offset: 0x0002AD2E
		[global::Cpp2ILInjected.Token(Token = "0x6004301")]
		[global::Cpp2ILInjected.Address(RVA = "0x79D298", Offset = "0x79D298", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ZoneHallow", ReturnType = typeof(bool))]
		public override bool IsInBiome(Player player)
		{
			throw null;
		}
	}
}
