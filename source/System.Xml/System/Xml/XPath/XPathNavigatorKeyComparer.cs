using System;
using System.Collections;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using MS.Internal.Xml.Cache;

namespace System.Xml.XPath
{
	[global::Cpp2ILInjected.Token(Token = "0x20000B8")]
	internal class XPathNavigatorKeyComparer : IEqualityComparer
	{
		[global::Cpp2ILInjected.Token(Token = "0x60007F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB375C", Offset = "0x1DB375C", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private bool System.Collections.IEqualityComparer.Equals(object obj1, object obj2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60007F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB3838", Offset = "0x1DB3838", Length = "0x1A4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XPathDocumentNavigator), Member = "GetPositionHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private int System.Collections.IEqualityComparer.GetHashCode(object obj)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60007F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB3754", Offset = "0x1DB3754", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public XPathNavigatorKeyComparer()
		{
			throw null;
		}
	}
}
