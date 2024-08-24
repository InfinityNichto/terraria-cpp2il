using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.GameContent.Personalities
{
	// Token: 0x0200059D RID: 1437
	[global::Cpp2ILInjected.Token(Token = "0x200083B")]
	public class CorruptionBiome : AShoppingBiome
	{
		// Token: 0x06003BE3 RID: 15331 RVA: 0x0002CB3D File Offset: 0x0002AD3D
		[global::Cpp2ILInjected.Token(Token = "0x6004306")]
		[global::Cpp2ILInjected.Address(RVA = "0x79D310", Offset = "0x79D310", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ShopHelper), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public CorruptionBiome()
		{
			throw null;
		}

		// Token: 0x06003BE4 RID: 15332 RVA: 0x0002CB40 File Offset: 0x0002AD40
		[global::Cpp2ILInjected.Token(Token = "0x6004307")]
		[global::Cpp2ILInjected.Address(RVA = "0x79D364", Offset = "0x79D364", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ZoneCorrupt", ReturnType = typeof(bool))]
		public override bool IsInBiome(Player player)
		{
			throw null;
		}
	}
}
