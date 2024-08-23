using System;
using System.Xml.Schema;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x02000044 RID: 68
	[global::Cpp2ILInjected.Token(Token = "0x2000061")]
	internal class DomNameTable
	{
		// Token: 0x060003E7 RID: 999 RVA: 0x00003A82 File Offset: 0x00001C82
		[global::Cpp2ILInjected.Token(Token = "0x600045F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8ADE0", Offset = "0x1D8ADE0", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDocument), Member = ".ctor", MemberParameters = new object[] { typeof(XmlImplementation) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public DomNameTable(XmlDocument document)
		{
			throw null;
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00003A85 File Offset: 0x00001C85
		[global::Cpp2ILInjected.Token(Token = "0x6000460")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8AE6C", Offset = "0x1D8AE6C", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDocument), Member = "GetXmlName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(IXmlSchemaInfo)
		}, ReturnType = typeof(XmlName))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDocument), Member = "GetIDInfoByElement_", MemberParameters = new object[] { typeof(XmlName) }, ReturnType = typeof(XmlName))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlName), Member = "GetHashCode", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public XmlName GetName(string prefix, string localName, string ns, IXmlSchemaInfo schemaInfo)
		{
			throw null;
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x00003A88 File Offset: 0x00001C88
		[global::Cpp2ILInjected.Token(Token = "0x6000461")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8AFA4", Offset = "0x1D8AFA4", Length = "0x20C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDocument), Member = "AddXmlName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(IXmlSchemaInfo)
		}, ReturnType = typeof(XmlName))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDocument), Member = "AddAttrXmlName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(IXmlSchemaInfo)
		}, ReturnType = typeof(XmlName))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDocument), Member = "CreateElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(XmlElement))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlName), Member = "GetHashCode", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlName), Member = "Create", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(XmlDocument),
			typeof(XmlName),
			typeof(IXmlSchemaInfo)
		}, ReturnType = typeof(XmlName))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DomNameTable), Member = "Grow", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public XmlName AddName(string prefix, string localName, string ns, IXmlSchemaInfo schemaInfo)
		{
			throw null;
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x00003A8B File Offset: 0x00001C8B
		[global::Cpp2ILInjected.Token(Token = "0x6000462")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8B1B0", Offset = "0x1D8B1B0", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DomNameTable), Member = "AddName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(IXmlSchemaInfo)
		}, ReturnType = typeof(XmlName))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void Grow()
		{
			throw null;
		}

		// Token: 0x0400018E RID: 398
		[global::Cpp2ILInjected.Token(Token = "0x4000288")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private XmlName[] entries;

		// Token: 0x0400018F RID: 399
		[global::Cpp2ILInjected.Token(Token = "0x4000289")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int count;

		// Token: 0x04000190 RID: 400
		[global::Cpp2ILInjected.Token(Token = "0x400028A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private int mask;

		// Token: 0x04000191 RID: 401
		[global::Cpp2ILInjected.Token(Token = "0x400028B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private XmlDocument ownerDocument;

		// Token: 0x04000192 RID: 402
		[global::Cpp2ILInjected.Token(Token = "0x400028C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private XmlNameTable nameTable;
	}
}
