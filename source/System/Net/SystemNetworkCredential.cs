using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x200018A")]
	internal class SystemNetworkCredential : NetworkCredential
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000A2C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0B090", Offset = "0x1F0B090", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SystemNetworkCredential), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private SystemNetworkCredential()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000A2D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0B1AC", Offset = "0x1F0B1AC", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SystemNetworkCredential), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static SystemNetworkCredential()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40007BE")]
		internal static readonly SystemNetworkCredential defaultCredential;
	}
}
