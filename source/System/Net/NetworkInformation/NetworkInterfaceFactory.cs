using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net.NetworkInformation
{
	[global::Cpp2ILInjected.Token(Token = "0x20002C0")]
	internal abstract class NetworkInterfaceFactory
	{
		[global::Cpp2ILInjected.Token(Token = "0x60012BE")]
		public abstract NetworkInterface[] GetAllNetworkInterfaces();

		[global::Cpp2ILInjected.Token(Token = "0x60012BF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E20454", Offset = "0x1E20454", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static NetworkInterfaceFactory Create()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60012C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E204A0", Offset = "0x1E204A0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected NetworkInterfaceFactory()
		{
			throw null;
		}
	}
}
