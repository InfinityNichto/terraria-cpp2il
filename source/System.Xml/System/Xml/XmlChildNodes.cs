using System;
using System.Collections;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x0200004A RID: 74
	[global::Cpp2ILInjected.Token(Token = "0x2000067")]
	internal class XmlChildNodes : XmlNodeList
	{
		// Token: 0x06000432 RID: 1074 RVA: 0x00003B63 File Offset: 0x00001D63
		[global::Cpp2ILInjected.Token(Token = "0x60004AA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8D5C4", Offset = "0x1D8D5C4", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNode), Member = "get_ChildNodes", ReturnType = typeof(XmlNodeList))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNodeList), Member = ".ctor", ReturnType = typeof(void))]
		public XmlChildNodes(XmlNode container)
		{
			throw null;
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000433 RID: 1075 RVA: 0x00003B66 File Offset: 0x00001D66
		[global::Cpp2ILInjected.Token(Token = "0x17000100")]
		public override int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004AB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8D5EC", Offset = "0x1D8D5EC", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x00003B69 File Offset: 0x00001D69
		[global::Cpp2ILInjected.Token(Token = "0x60004AC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8D630", Offset = "0x1D8D630", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override IEnumerator GetEnumerator()
		{
			throw null;
		}

		// Token: 0x04000199 RID: 409
		[global::Cpp2ILInjected.Token(Token = "0x4000293")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private XmlNode container;
	}
}
