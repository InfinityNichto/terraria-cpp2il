using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net.NetworkInformation
{
	[global::Cpp2ILInjected.Token(Token = "0x200029E")]
	public abstract class IPAddressInformation
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000442")]
		public abstract IPAddress Address
		{
			[global::Cpp2ILInjected.Token(Token = "0x600127D")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600127E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E1C858", Offset = "0x1E1C858", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected IPAddressInformation()
		{
			throw null;
		}
	}
}
