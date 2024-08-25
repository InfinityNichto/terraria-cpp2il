using System;
using System.Configuration;
using System.Xml;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Diagnostics
{
	[Obsolete("This class has been deprecated.  http://go.microsoft.com/fwlink/?linkid=14202")]
	[global::Cpp2ILInjected.Token(Token = "0x2000485")]
	public class DiagnosticsConfigurationHandler : IConfigurationSectionHandler
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001F7B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E9BB28", Offset = "0x1E9BB28", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public DiagnosticsConfigurationHandler()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001F7C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E9BB60", Offset = "0x1E9BB60", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual object Create(object parent, object configContext, XmlNode section)
		{
			throw null;
		}
	}
}
