using System;
using System.Xml;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Configuration
{
	[global::Cpp2ILInjected.Token(Token = "0x20004AE")]
	public class SingleTagSectionHandler : IConfigurationSectionHandler
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002028")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E9DC94", Offset = "0x1E9DC94", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public SingleTagSectionHandler()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002029")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E9DCCC", Offset = "0x1E9DCCC", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual object Create(object parent, object context, XmlNode section)
		{
			throw null;
		}
	}
}
