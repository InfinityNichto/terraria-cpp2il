using System;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Linq
{
	// Token: 0x02000018 RID: 24
	[global::Cpp2ILInjected.Token(Token = "0x200001E")]
	public class XText : XNode
	{
		// Token: 0x060000AE RID: 174 RVA: 0x0000224E File Offset: 0x0000044E
		[global::Cpp2ILInjected.Token(Token = "0x60000C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D69A14", Offset = "0x1D69A14", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.XDocumentWrapper", Member = "CreateTextNode", MemberParameters = new object[] { typeof(string) }, ReturnType = "Newtonsoft.Json.Converters.IXmlNode")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.XDocumentWrapper", Member = "CreateWhitespace", MemberParameters = new object[] { typeof(string) }, ReturnType = "Newtonsoft.Json.Converters.IXmlNode")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.XDocumentWrapper", Member = "CreateSignificantWhitespace", MemberParameters = new object[] { typeof(string) }, ReturnType = "Newtonsoft.Json.Converters.IXmlNode")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XContainer), Member = "get_LastNode", ReturnType = typeof(XNode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XContainer), Member = "AddString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XContainer), Member = "AddStringSkipNotify", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XContainer), Member = "ConvertTextToNode", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public XText(string value)
		{
			throw null;
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00002251 File Offset: 0x00000451
		[global::Cpp2ILInjected.Token(Token = "0x60000C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D69A8C", Offset = "0x1D69A8C", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XCData), Member = "CloneNode", ReturnType = typeof(XNode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XText), Member = "CloneNode", ReturnType = typeof(XNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public XText(XText other)
		{
			throw null;
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x00002254 File Offset: 0x00000454
		[global::Cpp2ILInjected.Token(Token = "0x17000028")]
		public override XmlNodeType NodeType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000C9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D6F314", Offset = "0x1D6F314", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x00002257 File Offset: 0x00000457
		// (set) Token: 0x060000B2 RID: 178 RVA: 0x0000225A File Offset: 0x0000045A
		[global::Cpp2ILInjected.Token(Token = "0x17000029")]
		public string Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000CA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D6F31C", Offset = "0x1D6F31C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60000CB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D6B628", Offset = "0x1D6B628", Length = "0xF0")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.XTextWrapper", Member = "set_Value", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XContainer), Member = "AddString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XObject), Member = "NotifyChanging", MemberParameters = new object[]
			{
				typeof(object),
				typeof(XObjectChangeEventArgs)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XObject), Member = "NotifyChanged", MemberParameters = new object[]
			{
				typeof(object),
				typeof(XObjectChangeEventArgs)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x0000225D File Offset: 0x0000045D
		[global::Cpp2ILInjected.Token(Token = "0x60000CC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6F324", Offset = "0x1D6F324", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override void WriteTo(XmlWriter writer)
		{
			throw null;
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00002260 File Offset: 0x00000460
		[global::Cpp2ILInjected.Token(Token = "0x60000CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6F414", Offset = "0x1D6F414", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		internal override void AppendText(StringBuilder sb)
		{
			throw null;
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00002263 File Offset: 0x00000463
		[global::Cpp2ILInjected.Token(Token = "0x60000CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6F428", Offset = "0x1D6F428", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XText), Member = ".ctor", MemberParameters = new object[] { typeof(XText) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal override XNode CloneNode()
		{
			throw null;
		}

		// Token: 0x04000037 RID: 55
		[global::Cpp2ILInjected.Token(Token = "0x400004E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal string text;
	}
}
