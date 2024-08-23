using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net.NetworkInformation
{
	// Token: 0x020001DF RID: 479
	[global::Cpp2ILInjected.Token(Token = "0x20002C1")]
	internal static class NetworkInterfaceFactoryPal
	{
		// Token: 0x060010C8 RID: 4296 RVA: 0x00005E58 File Offset: 0x00004058
		[global::Cpp2ILInjected.Token(Token = "0x60012C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E20458", Offset = "0x1E20458", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SystemNetworkInterface), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnixNetworkInterfaceFactoryPal), Member = "Create", ReturnType = typeof(NetworkInterfaceFactory))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static NetworkInterfaceFactory Create()
		{
			throw null;
		}
	}
}
