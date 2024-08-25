using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net.NetworkInformation
{
	[global::Cpp2ILInjected.Token(Token = "0x20002A0")]
	public abstract class IPInterfaceProperties
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000444")]
		public abstract UnicastIPAddressInformationCollection UnicastAddresses
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001283")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001284")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E1C8B8", Offset = "0x1E1C8B8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected IPInterfaceProperties()
		{
			throw null;
		}
	}
}
