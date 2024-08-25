using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net.NetworkInformation
{
	[global::Cpp2ILInjected.Token(Token = "0x20002BF")]
	internal static class SystemNetworkInterface
	{
		[global::Cpp2ILInjected.Token(Token = "0x60012BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E1C980", Offset = "0x1E1C980", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public static NetworkInterface[] GetNetworkInterfaces()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x4000F09")]
		private static readonly NetworkInterfaceFactory nif;
	}
}
