using System;
using System.Reflection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Configuration.Provider
{
	[DefaultMember("Item")]
	[global::Cpp2ILInjected.Token(Token = "0x200000C")]
	public class ProviderCollection
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000019")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3C0C4", Offset = "0x1D3C0C4", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual void Add(ProviderBase provider)
		{
			throw null;
		}
	}
}
