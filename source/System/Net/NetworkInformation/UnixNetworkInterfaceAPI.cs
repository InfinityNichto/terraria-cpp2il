using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net.NetworkInformation
{
	// Token: 0x020001E6 RID: 486
	[global::Cpp2ILInjected.Token(Token = "0x20002C8")]
	internal abstract class UnixNetworkInterfaceAPI : NetworkInterfaceFactory
	{
		// Token: 0x060010D6 RID: 4310
		[global::Cpp2ILInjected.Token(Token = "0x60012CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E1E620", Offset = "0x1E1E620", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LinuxNetworkInterfaceAPI), Member = "GetAllNetworkInterfaces", ReturnType = typeof(NetworkInterface[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MacOsNetworkInterfaceAPI), Member = "GetAllNetworkInterfaces", ReturnType = typeof(NetworkInterface[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[PreserveSig]
		protected static extern int getifaddrs(out IntPtr ifap);

		// Token: 0x060010D7 RID: 4311
		[global::Cpp2ILInjected.Token(Token = "0x60012D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E1E5A0", Offset = "0x1E1E5A0", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LinuxNetworkInterfaceAPI), Member = "GetAllNetworkInterfaces", ReturnType = typeof(NetworkInterface[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MacOsNetworkInterfaceAPI), Member = "GetAllNetworkInterfaces", ReturnType = typeof(NetworkInterface[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[PreserveSig]
		protected static extern void freeifaddrs(IntPtr ifap);

		// Token: 0x060010D8 RID: 4312 RVA: 0x00005E7F File Offset: 0x0000407F
		[global::Cpp2ILInjected.Token(Token = "0x60012D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E1E324", Offset = "0x1E1E324", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected UnixNetworkInterfaceAPI()
		{
			throw null;
		}
	}
}
