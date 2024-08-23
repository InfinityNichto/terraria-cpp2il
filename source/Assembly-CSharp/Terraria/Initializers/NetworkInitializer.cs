using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Net;

namespace Terraria.Initializers
{
	// Token: 0x020003D7 RID: 983
	[global::Cpp2ILInjected.Token(Token = "0x200058D")]
	public static class NetworkInitializer
	{
		// Token: 0x0600301F RID: 12319 RVA: 0x0002A9A7 File Offset: 0x00028BA7
		[global::Cpp2ILInjected.Token(Token = "0x60034B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x137E2EC", Offset = "0x137E2EC", Length = "0x220")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "Initialize_AlmostEverything", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetManager), Member = "Register", MemberTypeParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public static void Load()
		{
			throw null;
		}
	}
}
