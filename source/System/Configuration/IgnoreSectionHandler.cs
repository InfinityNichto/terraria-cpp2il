using System;
using System.Xml;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Configuration
{
	[global::Cpp2ILInjected.Token(Token = "0x200049A")]
	public class IgnoreSectionHandler : IConfigurationSectionHandler
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001FE6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E9D184", Offset = "0x1E9D184", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public IgnoreSectionHandler()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001FE7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E9D1BC", Offset = "0x1E9D1BC", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual object Create(object parent, object configContext, XmlNode section)
		{
			throw null;
		}
	}
}
