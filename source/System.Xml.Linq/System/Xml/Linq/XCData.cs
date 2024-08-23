using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Linq
{
	// Token: 0x02000004 RID: 4
	[global::Cpp2ILInjected.Token(Token = "0x2000004")]
	public class XCData : XText
	{
		// Token: 0x0600000C RID: 12 RVA: 0x00002071 File Offset: 0x00000271
		[global::Cpp2ILInjected.Token(Token = "0x600000C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D69A10", Offset = "0x1D69A10", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.XDocumentWrapper", Member = "CreateCDataSection", MemberParameters = new object[] { typeof(string) }, ReturnType = "Newtonsoft.Json.Converters.IXmlNode")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public XCData(string value)
		{
			throw null;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002074 File Offset: 0x00000274
		[global::Cpp2ILInjected.Token(Token = "0x600000D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D69A88", Offset = "0x1D69A88", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public XCData(XCData other)
		{
			throw null;
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000E RID: 14 RVA: 0x00002077 File Offset: 0x00000277
		[global::Cpp2ILInjected.Token(Token = "0x17000005")]
		public override XmlNodeType NodeType
		{
			[global::Cpp2ILInjected.Token(Token = "0x600000E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D69B04", Offset = "0x1D69B04", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x0000207A File Offset: 0x0000027A
		[global::Cpp2ILInjected.Token(Token = "0x600000F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D69B0C", Offset = "0x1D69B0C", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override void WriteTo(XmlWriter writer)
		{
			throw null;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x0000207D File Offset: 0x0000027D
		[global::Cpp2ILInjected.Token(Token = "0x6000010")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D69B7C", Offset = "0x1D69B7C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XText), Member = ".ctor", MemberParameters = new object[] { typeof(XText) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal override XNode CloneNode()
		{
			throw null;
		}
	}
}
