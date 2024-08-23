using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net.NetworkInformation
{
	// Token: 0x020001DD RID: 477
	[global::Cpp2ILInjected.Token(Token = "0x20002BF")]
	internal static class SystemNetworkInterface
	{
		// Token: 0x060010C3 RID: 4291 RVA: 0x00005E4C File Offset: 0x0000404C
		[global::Cpp2ILInjected.Token(Token = "0x60012BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E1C980", Offset = "0x1E1C980", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public static NetworkInterface[] GetNetworkInterfaces()
		{
			throw null;
		}

		// Token: 0x060010C4 RID: 4292 RVA: 0x00005E4F File Offset: 0x0000404F
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60012BD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E20408", Offset = "0x1E20408", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkInterfaceFactoryPal), Member = "Create", ReturnType = typeof(NetworkInterfaceFactory))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static SystemNetworkInterface()
		{
			throw null;
		}

		// Token: 0x04000B38 RID: 2872
		[global::Cpp2ILInjected.Token(Token = "0x4000F09")]
		private static readonly NetworkInterfaceFactory nif;
	}
}
