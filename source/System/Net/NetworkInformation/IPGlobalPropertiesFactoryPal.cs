using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net.NetworkInformation
{
	// Token: 0x020001CD RID: 461
	[global::Cpp2ILInjected.Token(Token = "0x20002AF")]
	internal static class IPGlobalPropertiesFactoryPal
	{
		// Token: 0x060010AF RID: 4271 RVA: 0x00005E10 File Offset: 0x00004010
		[global::Cpp2ILInjected.Token(Token = "0x60012A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E1C864", Offset = "0x1E1C864", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IPGlobalProperties), Member = "InternalGetIPGlobalProperties", ReturnType = typeof(IPGlobalProperties))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnixIPGlobalPropertiesFactoryPal), Member = "Create", ReturnType = typeof(IPGlobalProperties))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static IPGlobalProperties Create()
		{
			throw null;
		}
	}
}
