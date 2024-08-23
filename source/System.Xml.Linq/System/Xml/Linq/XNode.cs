using System;
using System.Globalization;
using System.IO;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Linq
{
	// Token: 0x02000012 RID: 18
	[global::Cpp2ILInjected.Token(Token = "0x2000018")]
	public abstract class XNode : XObject
	{
		// Token: 0x06000093 RID: 147 RVA: 0x00002206 File Offset: 0x00000406
		[global::Cpp2ILInjected.Token(Token = "0x60000AC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D69C48", Offset = "0x1D69C48", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal XNode()
		{
			throw null;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00002209 File Offset: 0x00000409
		[global::Cpp2ILInjected.Token(Token = "0x60000AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6E6E0", Offset = "0x1D6E6E0", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.XmlNodeConverter", Member = "ReadJson", MemberParameters = new object[]
		{
			"Newtonsoft.Json.JsonReader",
			typeof(Type),
			typeof(object),
			"Newtonsoft.Json.JsonSerializer"
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XContainer), Member = "RemoveNode", MemberParameters = new object[] { typeof(XNode) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void Remove()
		{
			throw null;
		}

		// Token: 0x06000095 RID: 149 RVA: 0x0000220C File Offset: 0x0000040C
		[global::Cpp2ILInjected.Token(Token = "0x60000AE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6E740", Offset = "0x1D6E740", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XObject), Member = "GetSaveOptionsFromAnnotations", ReturnType = typeof(SaveOptions))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNode), Member = "GetXmlString", MemberParameters = new object[] { typeof(SaveOptions) }, ReturnType = typeof(string))]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06000096 RID: 150
		[global::Cpp2ILInjected.Token(Token = "0x60000AF")]
		public abstract void WriteTo(XmlWriter writer);

		// Token: 0x06000097 RID: 151 RVA: 0x0000220F File Offset: 0x0000040F
		[global::Cpp2ILInjected.Token(Token = "0x60000B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6ECA4", Offset = "0x1D6ECA4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal virtual void AppendText(StringBuilder sb)
		{
			throw null;
		}

		// Token: 0x06000098 RID: 152
		[global::Cpp2ILInjected.Token(Token = "0x60000B1")]
		internal abstract XNode CloneNode();

		// Token: 0x06000099 RID: 153 RVA: 0x00002212 File Offset: 0x00000412
		[global::Cpp2ILInjected.Token(Token = "0x60000B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6E83C", Offset = "0x1D6E83C", Length = "0x468")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNode), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringWriter), Member = ".ctor", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWriterSettings), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWriterSettings), Member = "set_OmitXmlDeclaration", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWriterSettings), Member = "set_Indent", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWriterSettings), Member = "set_NamespaceHandling", MemberParameters = new object[] { typeof(NamespaceHandling) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWriterSettings), Member = "set_ConformanceLevel", MemberParameters = new object[] { typeof(ConformanceLevel) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWriter), Member = "Create", MemberParameters = new object[]
		{
			typeof(TextWriter),
			typeof(XmlWriterSettings)
		}, ReturnType = typeof(XmlWriter))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XContainer), Member = "WriteContentTo", MemberParameters = new object[] { typeof(XmlWriter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		private string GetXmlString(SaveOptions o)
		{
			throw null;
		}

		// Token: 0x04000029 RID: 41
		[global::Cpp2ILInjected.Token(Token = "0x4000040")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal XNode next;
	}
}
