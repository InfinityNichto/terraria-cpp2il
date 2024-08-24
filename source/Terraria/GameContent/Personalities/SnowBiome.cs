using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.GameContent.Personalities
{
	// Token: 0x02000596 RID: 1430
	[global::Cpp2ILInjected.Token(Token = "0x2000834")]
	public class SnowBiome : AShoppingBiome
	{
		// Token: 0x06003BD5 RID: 15317 RVA: 0x0002CB13 File Offset: 0x0002AD13
		[global::Cpp2ILInjected.Token(Token = "0x60042F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x79D038", Offset = "0x79D038", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PersonalityDatabasePopulator), Member = "Populate_BiomePreferences", MemberParameters = new object[] { typeof(PersonalityDatabase) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public SnowBiome()
		{
			throw null;
		}

		// Token: 0x06003BD6 RID: 15318 RVA: 0x0002CB16 File Offset: 0x0002AD16
		[global::Cpp2ILInjected.Token(Token = "0x60042F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x79D268", Offset = "0x79D268", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ZoneSnow", ReturnType = typeof(bool))]
		public override bool IsInBiome(Player player)
		{
			throw null;
		}
	}
}
