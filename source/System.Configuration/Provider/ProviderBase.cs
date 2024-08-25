using System;
using System.Collections.Specialized;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Configuration.Provider
{
	[global::Cpp2ILInjected.Token(Token = "0x2000002")]
	public abstract class ProviderBase
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000001")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3BC28", Offset = "0x1D3BC28", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual void Initialize(string name, NameValueCollection config)
		{
			throw null;
		}
	}
}
