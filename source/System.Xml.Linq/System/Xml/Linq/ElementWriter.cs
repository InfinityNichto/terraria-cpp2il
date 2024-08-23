using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Linq
{
	// Token: 0x0200000C RID: 12
	[global::Cpp2ILInjected.Token(Token = "0x2000011")]
	internal struct ElementWriter
	{
		// Token: 0x06000066 RID: 102 RVA: 0x0000217F File Offset: 0x0000037F
		[global::Cpp2ILInjected.Token(Token = "0x600007E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6CCD0", Offset = "0x1D6CCD0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public ElementWriter(XmlWriter writer)
		{
			throw null;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002182 File Offset: 0x00000382
		[global::Cpp2ILInjected.Token(Token = "0x600007F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6CCDC", Offset = "0x1D6CCDC", Length = "0x1C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XElement), Member = "WriteTo", MemberParameters = new object[] { typeof(XmlWriter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ElementWriter), Member = "PushAncestors", MemberParameters = new object[] { typeof(XElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NamespaceResolver), Member = "PopScope", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ElementWriter), Member = "WriteStartElement", MemberParameters = new object[] { typeof(XElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void WriteElement(XElement e)
		{
			throw null;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002185 File Offset: 0x00000385
		[global::Cpp2ILInjected.Token(Token = "0x6000080")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6D770", Offset = "0x1D6D770", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ElementWriter), Member = "WriteStartElement", MemberParameters = new object[] { typeof(XElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NamespaceResolver), Member = "GetPrefixOfNamespace", MemberParameters = new object[]
		{
			typeof(XNamespace),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private string GetPrefixOfNamespace(XNamespace ns, bool allowDefaultNamespace)
		{
			throw null;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002188 File Offset: 0x00000388
		[global::Cpp2ILInjected.Token(Token = "0x6000081")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6D4EC", Offset = "0x1D6D4EC", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ElementWriter), Member = "WriteElement", MemberParameters = new object[] { typeof(XElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XAttribute), Member = "get_IsNamespaceDeclaration", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNamespace), Member = "Get", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(XNamespace))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NamespaceResolver), Member = "AddFirst", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XNamespace)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void PushAncestors(XElement e)
		{
			throw null;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0000218B File Offset: 0x0000038B
		[global::Cpp2ILInjected.Token(Token = "0x6000082")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6DA14", Offset = "0x1D6DA14", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ElementWriter), Member = "WriteStartElement", MemberParameters = new object[] { typeof(XElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XAttribute), Member = "get_IsNamespaceDeclaration", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNamespace), Member = "Get", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(XNamespace))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NamespaceResolver), Member = "Add", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XNamespace)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void PushElement(XElement e)
		{
			throw null;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x0000218E File Offset: 0x0000038E
		[global::Cpp2ILInjected.Token(Token = "0x6000083")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6D728", Offset = "0x1D6D728", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NamespaceResolver), Member = "PopScope", ReturnType = typeof(void))]
		private void WriteEndElement()
		{
			throw null;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00002191 File Offset: 0x00000391
		[global::Cpp2ILInjected.Token(Token = "0x6000084")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6D74C", Offset = "0x1D6D74C", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NamespaceResolver), Member = "PopScope", ReturnType = typeof(void))]
		private void WriteFullEndElement()
		{
			throw null;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002194 File Offset: 0x00000394
		[global::Cpp2ILInjected.Token(Token = "0x6000085")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6D5F8", Offset = "0x1D6D5F8", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ElementWriter), Member = "WriteElement", MemberParameters = new object[] { typeof(XElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ElementWriter), Member = "PushElement", MemberParameters = new object[] { typeof(XElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ElementWriter), Member = "GetPrefixOfNamespace", MemberParameters = new object[]
		{
			typeof(XNamespace),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWriter), Member = "WriteAttributeString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void WriteStartElement(XElement e)
		{
			throw null;
		}

		// Token: 0x04000011 RID: 17
		[global::Cpp2ILInjected.Token(Token = "0x4000024")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private XmlWriter _writer;

		// Token: 0x04000012 RID: 18
		[global::Cpp2ILInjected.Token(Token = "0x4000025")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private NamespaceResolver _resolver;
	}
}
