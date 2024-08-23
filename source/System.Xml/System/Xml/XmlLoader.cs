using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Xml.Schema;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x02000056 RID: 86
	[global::Cpp2ILInjected.Token(Token = "0x2000073")]
	internal class XmlLoader
	{
		// Token: 0x060004FD RID: 1277 RVA: 0x00003DC4 File Offset: 0x00001FC4
		[global::Cpp2ILInjected.Token(Token = "0x6000575")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D91050", Offset = "0x1D91050", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAttribute), Member = "set_InnerXml", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDocument), Member = "Load", MemberParameters = new object[] { typeof(XmlReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public XmlLoader()
		{
			throw null;
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x00003DC7 File Offset: 0x00001FC7
		[global::Cpp2ILInjected.Token(Token = "0x6000576")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D935B8", Offset = "0x1D935B8", Length = "0x230")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDocument), Member = "Load", MemberParameters = new object[] { typeof(XmlReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlReaderSettings), Member = "get_Schemas", ReturnType = typeof(XmlSchemaSet))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		internal void Load(XmlDocument doc, XmlReader reader, bool preserveWhitespace)
		{
			throw null;
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x00003DCA File Offset: 0x00001FCA
		[global::Cpp2ILInjected.Token(Token = "0x6000577")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D937E8", Offset = "0x1D937E8", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlLoader), Member = "LoadNode", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(XmlNode))]
		private void LoadDocSequence(XmlDocument parentDoc)
		{
			throw null;
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x00003DCD File Offset: 0x00001FCD
		[global::Cpp2ILInjected.Token(Token = "0x6000578")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D93848", Offset = "0x1D93848", Length = "0x550")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsInvalidInstructions]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "LoadDocSequence", MemberParameters = new object[] { typeof(XmlDocument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "LoadEntityReferenceNode", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(XmlEntityReference))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "ParsePartialContent", MemberParameters = new object[]
		{
			typeof(XmlNode),
			typeof(string),
			typeof(XmlNodeType)
		}, ReturnType = typeof(XmlNamespaceManager))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNode), Member = "RemoveAll", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlDocument), Member = "AddXmlName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(IXmlSchemaInfo)
		}, ReturnType = typeof(XmlName))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlLoader), Member = "LoadDeclarationNode", ReturnType = typeof(XmlDeclaration))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlLoader), Member = "LoadEntityReferenceNode", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(XmlEntityReference))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlLoader), Member = "LoadAttributeNode", ReturnType = typeof(XmlAttribute))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlLoader), Member = "LoadDocumentTypeNode", ReturnType = typeof(XmlDocumentType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAttributeCollection), Member = "Append", MemberParameters = new object[] { typeof(XmlAttribute) }, ReturnType = typeof(XmlAttribute))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlLoader), Member = "UnexpectedNodeType", MemberParameters = new object[] { typeof(XmlNodeType) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private XmlNode LoadNode(bool skipOverWhitespace)
		{
			throw null;
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x00003DD0 File Offset: 0x00001FD0
		[global::Cpp2ILInjected.Token(Token = "0x6000579")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D93D98", Offset = "0x1D93D98", Length = "0x2FC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "LoadNode", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(XmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlLoader), Member = "LoadDefaultAttribute", ReturnType = typeof(XmlAttribute))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlDocument), Member = "AddAttrXmlName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(IXmlSchemaInfo)
		}, ReturnType = typeof(XmlName))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlLoader), Member = "LoadAttributeValue", MemberParameters = new object[]
		{
			typeof(XmlNode),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlLoader), Member = "UnexpectedNodeType", MemberParameters = new object[] { typeof(XmlNodeType) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private XmlAttribute LoadAttributeNode()
		{
			throw null;
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x00003DD3 File Offset: 0x00001FD3
		[global::Cpp2ILInjected.Token(Token = "0x600057A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D94694", Offset = "0x1D94694", Length = "0x17C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "LoadAttributeNode", ReturnType = typeof(XmlAttribute))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlDocument), Member = "AddAttrXmlName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(IXmlSchemaInfo)
		}, ReturnType = typeof(XmlName))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlLoader), Member = "LoadAttributeValue", MemberParameters = new object[]
		{
			typeof(XmlNode),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private XmlAttribute LoadDefaultAttribute()
		{
			throw null;
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x00003DD6 File Offset: 0x00001FD6
		[global::Cpp2ILInjected.Token(Token = "0x600057B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D94810", Offset = "0x1D94810", Length = "0x2D8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "LoadAttributeNode", ReturnType = typeof(XmlAttribute))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "LoadDefaultAttribute", ReturnType = typeof(XmlAttribute))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "LoadAttributeValue", MemberParameters = new object[]
		{
			typeof(XmlNode),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "LoadAttributeNodeDirect", ReturnType = typeof(XmlAttribute))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharacterData), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XmlDocument)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEntityReference), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XmlDocument)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlLoader), Member = "LoadAttributeValue", MemberParameters = new object[]
		{
			typeof(XmlNode),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlLoader), Member = "UnexpectedNodeType", MemberParameters = new object[] { typeof(XmlNodeType) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private void LoadAttributeValue(XmlNode parent, bool direct)
		{
			throw null;
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x00003DD9 File Offset: 0x00001FD9
		[global::Cpp2ILInjected.Token(Token = "0x600057C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D94094", Offset = "0x1D94094", Length = "0x1BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "LoadNode", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(XmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "LoadNodeDirect", ReturnType = typeof(XmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEntityReference), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XmlDocument)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlLoader), Member = "LoadNodeDirect", ReturnType = typeof(XmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlLoader), Member = "LoadNode", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(XmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private XmlEntityReference LoadEntityReferenceNode(bool direct)
		{
			throw null;
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x00003DDC File Offset: 0x00001FDC
		[global::Cpp2ILInjected.Token(Token = "0x600057D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D94250", Offset = "0x1D94250", Length = "0x1AC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "LoadNode", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(XmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlLoader), Member = "ParseXmlDeclarationValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref string),
			typeof(ref string),
			typeof(ref string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private XmlDeclaration LoadDeclarationNode()
		{
			throw null;
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x00003DDF File Offset: 0x00001FDF
		[global::Cpp2ILInjected.Token(Token = "0x600057E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D943FC", Offset = "0x1D943FC", Length = "0x188")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "LoadNode", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(XmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlLoader), Member = "LoadDocumentType", MemberParameters = new object[]
		{
			typeof(IDtdInfo),
			typeof(XmlDocumentType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlLoader), Member = "ParseDocumentType", MemberParameters = new object[] { typeof(XmlDocumentType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private XmlDocumentType LoadDocumentTypeNode()
		{
			throw null;
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x00003DE2 File Offset: 0x00001FE2
		[global::Cpp2ILInjected.Token(Token = "0x600057F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D94AFC", Offset = "0x1D94AFC", Length = "0x4CC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsInvalidInstructions]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "LoadEntityReferenceNode", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(XmlEntityReference))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "ParsePartialContent", MemberParameters = new object[]
		{
			typeof(XmlNode),
			typeof(string),
			typeof(XmlNodeType)
		}, ReturnType = typeof(XmlNamespaceManager))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlDocument), Member = "AddXmlName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(IXmlSchemaInfo)
		}, ReturnType = typeof(XmlName))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlElement), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(XmlName),
			typeof(bool),
			typeof(XmlDocument)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNode), Member = "RemoveAll", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSignificantWhitespace), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XmlDocument)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlComment), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XmlDocument)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlLoader), Member = "LoadAttributeNodeDirect", ReturnType = typeof(XmlAttribute))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharacterData), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XmlDocument)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCDataSection), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XmlDocument)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlLoader), Member = "LoadEntityReferenceNode", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(XmlEntityReference))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNode), Member = ".ctor", MemberParameters = new object[] { typeof(XmlDocument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWhitespace), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XmlDocument)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAttributeCollection), Member = "Append", MemberParameters = new object[] { typeof(XmlAttribute) }, ReturnType = typeof(XmlAttribute))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlLoader), Member = "UnexpectedNodeType", MemberParameters = new object[] { typeof(XmlNodeType) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		private XmlNode LoadNodeDirect()
		{
			throw null;
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x00003DE5 File Offset: 0x00001FE5
		[global::Cpp2ILInjected.Token(Token = "0x6000580")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D95BEC", Offset = "0x1D95BEC", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "LoadNodeDirect", ReturnType = typeof(XmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAttribute), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(XmlDocument)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlLoader), Member = "LoadAttributeValue", MemberParameters = new object[]
		{
			typeof(XmlNode),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private XmlAttribute LoadAttributeNodeDirect()
		{
			throw null;
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x00003DE8 File Offset: 0x00001FE8
		[global::Cpp2ILInjected.Token(Token = "0x6000581")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D91438", Offset = "0x1D91438", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDocumentType), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(XmlDocument)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "LoadDocumentTypeNode", ReturnType = typeof(XmlDocumentType))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlLoader), Member = "ParseDocumentType", MemberParameters = new object[]
		{
			typeof(XmlDocumentType),
			typeof(bool),
			typeof(XmlResolver)
		}, ReturnType = typeof(void))]
		internal void ParseDocumentType(XmlDocumentType dtNode)
		{
			throw null;
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x00003DEB File Offset: 0x00001FEB
		[global::Cpp2ILInjected.Token(Token = "0x6000582")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D95E84", Offset = "0x1D95E84", Length = "0x2A8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "ParseDocumentType", MemberParameters = new object[] { typeof(XmlDocumentType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlDocument), Member = "get_NameTable", ReturnType = typeof(XmlNameTable))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNamespaceManager), Member = ".ctor", MemberParameters = new object[] { typeof(XmlNameTable) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlParserContext), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(XmlNameTable),
			typeof(XmlNamespaceManager),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(XmlSpace)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XmlNodeType),
			typeof(XmlParserContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "set_Namespaces", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "set_XmlResolver", MemberParameters = new object[] { typeof(XmlResolver) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "Create", ReturnType = typeof(IDtdParser))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.DtdParserProxy), Member = ".ctor", MemberParameters = new object[] { typeof(XmlTextReaderImpl) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlLoader), Member = "LoadDocumentType", MemberParameters = new object[]
		{
			typeof(IDtdInfo),
			typeof(XmlDocumentType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private void ParseDocumentType(XmlDocumentType dtNode, bool bUseResolver, XmlResolver resolver)
		{
			throw null;
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x00003DEE File Offset: 0x00001FEE
		[global::Cpp2ILInjected.Token(Token = "0x6000583")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D951C8", Offset = "0x1D951C8", Length = "0xA24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "LoadDocumentTypeNode", ReturnType = typeof(XmlDocumentType))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "ParseDocumentType", MemberParameters = new object[]
		{
			typeof(XmlDocumentType),
			typeof(bool),
			typeof(XmlResolver)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SchemaInfo), Member = "get_Notations", ReturnType = typeof(Dictionary<string, SchemaNotation>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Values", ReturnType = "ValueCollection<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.ValueCollection), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.ValueCollection.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlDocumentType), Member = "get_Notations", ReturnType = typeof(XmlNamedNodeMap))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNotation), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(XmlDocument)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.ValueCollection.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SchemaInfo), Member = "get_GeneralEntities", ReturnType = typeof(Dictionary<XmlQualifiedName, SchemaEntity>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlQualifiedName), Member = "get_IsEmpty", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEntity), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(XmlDocument)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SchemaEntity), Member = "get_DeclaredURI", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlDocumentType), Member = "get_Entities", ReturnType = typeof(XmlNamedNodeMap))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SchemaInfo), Member = "get_ParameterEntities", ReturnType = typeof(Dictionary<XmlQualifiedName, SchemaEntity>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SchemaDeclBase), Member = "get_Prefix", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlDocument), Member = "AddXmlName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(IXmlSchemaInfo)
		}, ReturnType = typeof(XmlName))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlDocument), Member = "AddAttrXmlName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(IXmlSchemaInfo)
		}, ReturnType = typeof(XmlName))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlDocument), Member = "AddIdInfo", MemberParameters = new object[]
		{
			typeof(XmlName),
			typeof(XmlName)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 52)]
		private void LoadDocumentType(IDtdInfo dtdInfo, XmlDocumentType dtNode)
		{
			throw null;
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x00003DF1 File Offset: 0x00001FF1
		[global::Cpp2ILInjected.Token(Token = "0x6000584")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D961D8", Offset = "0x1D961D8", Length = "0x8A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "ParsePartialContent", MemberParameters = new object[]
		{
			typeof(XmlNode),
			typeof(string),
			typeof(XmlNodeType)
		}, ReturnType = typeof(XmlNamespaceManager))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlDocument), Member = "get_NameTable", ReturnType = typeof(XmlNameTable))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNamespaceManager), Member = ".ctor", MemberParameters = new object[] { typeof(XmlNameTable) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlParserContext), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(XmlNameTable),
			typeof(XmlNamespaceManager),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(XmlSpace)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
		private XmlParserContext GetContext(XmlNode node)
		{
			throw null;
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x00003DF4 File Offset: 0x00001FF4
		[global::Cpp2ILInjected.Token(Token = "0x6000585")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D91058", Offset = "0x1D91058", Length = "0x1B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDocumentFragment), Member = "set_InnerXml", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "LoadInnerXmlElement", MemberParameters = new object[]
		{
			typeof(XmlElement),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "LoadInnerXmlAttribute", MemberParameters = new object[]
		{
			typeof(XmlAttribute),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "ExpandEntity", MemberParameters = new object[] { typeof(XmlEntity) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "ExpandEntityReference", MemberParameters = new object[] { typeof(XmlEntityReference) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlLoader), Member = "GetContext", MemberParameters = new object[] { typeof(XmlNode) }, ReturnType = typeof(XmlParserContext))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlLoader), Member = "CreateInnerXmlReader", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XmlNodeType),
			typeof(XmlParserContext),
			typeof(XmlDocument)
		}, ReturnType = typeof(XmlReader))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlLoader), Member = "LoadNodeDirect", ReturnType = typeof(XmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlLoader), Member = "LoadNode", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(XmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal XmlNamespaceManager ParsePartialContent(XmlNode parentNode, string innerxmltext, XmlNodeType nt)
		{
			throw null;
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x00003DF7 File Offset: 0x00001FF7
		[global::Cpp2ILInjected.Token(Token = "0x6000586")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D923C4", Offset = "0x1D923C4", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlLoader), Member = "ParsePartialContent", MemberParameters = new object[]
		{
			typeof(XmlNode),
			typeof(string),
			typeof(XmlNodeType)
		}, ReturnType = typeof(XmlNamespaceManager))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlLoader), Member = "RemoveDuplicateNamespace", MemberParameters = new object[]
		{
			typeof(XmlElement),
			typeof(XmlNamespaceManager),
			typeof(bool)
		}, ReturnType = typeof(void))]
		internal void LoadInnerXmlElement(XmlElement node, string innerxmltext)
		{
			throw null;
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x00003DFA File Offset: 0x00001FFA
		[global::Cpp2ILInjected.Token(Token = "0x6000587")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D96F4C", Offset = "0x1D96F4C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAttribute), Member = "set_InnerXml", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlLoader), Member = "ParsePartialContent", MemberParameters = new object[]
		{
			typeof(XmlNode),
			typeof(string),
			typeof(XmlNodeType)
		}, ReturnType = typeof(XmlNamespaceManager))]
		internal void LoadInnerXmlAttribute(XmlAttribute node, string innerxmltext)
		{
			throw null;
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x00003DFD File Offset: 0x00001FFD
		[global::Cpp2ILInjected.Token(Token = "0x6000588")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D96CE0", Offset = "0x1D96CE0", Length = "0x26C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "LoadInnerXmlElement", MemberParameters = new object[]
		{
			typeof(XmlElement),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "RemoveDuplicateNamespace", MemberParameters = new object[]
		{
			typeof(XmlElement),
			typeof(XmlNamespaceManager),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAttributeCollection), Member = "get_ItemOf", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(XmlAttribute))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlLoader), Member = "RemoveDuplicateNamespace", MemberParameters = new object[]
		{
			typeof(XmlElement),
			typeof(XmlNamespaceManager),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void RemoveDuplicateNamespace(XmlElement elem, XmlNamespaceManager mgr, bool fCheckElemAttrs)
		{
			throw null;
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x00003E00 File Offset: 0x00002000
		[global::Cpp2ILInjected.Token(Token = "0x6000589")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D96F54", Offset = "0x1D96F54", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "ExpandEntity", MemberParameters = new object[] { typeof(XmlEntity) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "ExpandEntityReference", MemberParameters = new object[] { typeof(XmlEntityReference) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private string EntitizeName(string name)
		{
			throw null;
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x00003E03 File Offset: 0x00002003
		[global::Cpp2ILInjected.Token(Token = "0x600058A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9286C", Offset = "0x1D9286C", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEntity), Member = "get_LastNode", ReturnType = typeof(XmlLinkedNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlLoader), Member = "EntitizeName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlLoader), Member = "ParsePartialContent", MemberParameters = new object[]
		{
			typeof(XmlNode),
			typeof(string),
			typeof(XmlNodeType)
		}, ReturnType = typeof(XmlNamespaceManager))]
		internal void ExpandEntity(XmlEntity ent)
		{
			throw null;
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x00003E06 File Offset: 0x00002006
		[global::Cpp2ILInjected.Token(Token = "0x600058B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D92BF0", Offset = "0x1D92BF0", Length = "0x5B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEntityReference), Member = "SetParent", MemberParameters = new object[] { typeof(XmlNode) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlDocument), Member = "get_Entities", ReturnType = typeof(XmlNamedNodeMap))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlLoader), Member = "EntitizeName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlLoader), Member = "ParsePartialContent", MemberParameters = new object[]
		{
			typeof(XmlNode),
			typeof(string),
			typeof(XmlNodeType)
		}, ReturnType = typeof(XmlNamespaceManager))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 32)]
		internal void ExpandEntityReference(XmlEntityReference eref)
		{
			throw null;
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x00003E09 File Offset: 0x00002009
		[global::Cpp2ILInjected.Token(Token = "0x600058C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D96A78", Offset = "0x1D96A78", Length = "0x268")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "ParsePartialContent", MemberParameters = new object[]
		{
			typeof(XmlNode),
			typeof(string),
			typeof(XmlNodeType)
		}, ReturnType = typeof(XmlNamespaceManager))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XmlNodeType),
			typeof(XmlParserContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "set_XmlValidatingReaderCompatibilityMode", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "set_XmlResolver", MemberParameters = new object[] { typeof(XmlResolver) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "set_Namespaces", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "Create", ReturnType = typeof(IDtdParser))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.DtdParserProxy), Member = ".ctor", MemberParameters = new object[] { typeof(XmlTextReaderImpl) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "SetDtdInfo", MemberParameters = new object[] { typeof(IDtdInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private XmlReader CreateInnerXmlReader(string xmlFragment, XmlNodeType nt, XmlParserContext context, XmlDocument doc)
		{
			throw null;
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x00003E0C File Offset: 0x0000200C
		[global::Cpp2ILInjected.Token(Token = "0x600058D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D94FC8", Offset = "0x1D94FC8", Length = "0x200")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDeclaration), Member = "set_InnerText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "LoadDeclarationNode", ReturnType = typeof(XmlDeclaration))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XmlParserContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		internal static void ParseXmlDeclarationValue(string strValue, out string version, out string encoding, out string standalone)
		{
			throw null;
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x00003E0F File Offset: 0x0000200F
		[global::Cpp2ILInjected.Token(Token = "0x600058E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D94584", Offset = "0x1D94584", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "LoadNode", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(XmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "LoadAttributeNode", ReturnType = typeof(XmlAttribute))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "LoadAttributeValue", MemberParameters = new object[]
		{
			typeof(XmlNode),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "LoadNodeDirect", ReturnType = typeof(XmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(IFormatProvider),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal static Exception UnexpectedNodeType(XmlNodeType nodetype)
		{
			throw null;
		}

		// Token: 0x040001E5 RID: 485
		[global::Cpp2ILInjected.Token(Token = "0x40002DF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private XmlDocument doc;

		// Token: 0x040001E6 RID: 486
		[global::Cpp2ILInjected.Token(Token = "0x40002E0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private XmlReader reader;

		// Token: 0x040001E7 RID: 487
		[global::Cpp2ILInjected.Token(Token = "0x40002E1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private bool preserveWhitespace;
	}
}
