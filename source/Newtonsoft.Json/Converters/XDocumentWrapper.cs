using System;
using System.Collections.Generic;
using System.Xml.Linq;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000CE RID: 206
	[global::Cpp2ILInjected.Token(Token = "0x2000115")]
	internal class XDocumentWrapper : XContainerWrapper, IXmlDocument, IXmlNode
	{
		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06000993 RID: 2451 RVA: 0x00003C38 File Offset: 0x00001E38
		[global::Cpp2ILInjected.Token(Token = "0x17000207")]
		private XDocument Document
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000ACF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D2C99C", Offset = "0x1D2C99C", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XDocumentWrapper), Member = "get_ChildNodes", ReturnType = typeof(List<IXmlNode>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XDocumentWrapper), Member = "get_DocumentElement", ReturnType = typeof(IXmlElement))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XDocumentWrapper), Member = "AppendChild", MemberParameters = new object[] { typeof(IXmlNode) }, ReturnType = typeof(IXmlNode))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000994 RID: 2452 RVA: 0x00003C3B File Offset: 0x00001E3B
		[global::Cpp2ILInjected.Token(Token = "0x6000AD0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D2CA14", Offset = "0x1D2CA14", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public XDocumentWrapper(XDocument document)
		{
			throw null;
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x06000995 RID: 2453 RVA: 0x00003C3E File Offset: 0x00001E3E
		[global::Cpp2ILInjected.Token(Token = "0x17000208")]
		public override List<IXmlNode> ChildNodes
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AD1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D2CA84", Offset = "0x1D2CA84", Length = "0x14C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XContainerWrapper), Member = "get_ChildNodes", ReturnType = typeof(List<IXmlNode>))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XDocumentWrapper), Member = "get_Document", ReturnType = typeof(XDocument))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XDeclarationWrapper), Member = ".ctor", MemberParameters = new object[] { typeof(XDeclaration) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Insert", MemberParameters = new object[]
			{
				typeof(int),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000996 RID: 2454 RVA: 0x00003C41 File Offset: 0x00001E41
		[global::Cpp2ILInjected.Token(Token = "0x6000AD2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D2CF58", Offset = "0x1D2CF58", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XComment), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public IXmlNode CreateComment(string text)
		{
			throw null;
		}

		// Token: 0x06000997 RID: 2455 RVA: 0x00003C44 File Offset: 0x00001E44
		[global::Cpp2ILInjected.Token(Token = "0x6000AD3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D2CFE8", Offset = "0x1D2CFE8", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XText), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public IXmlNode CreateTextNode(string text)
		{
			throw null;
		}

		// Token: 0x06000998 RID: 2456 RVA: 0x00003C47 File Offset: 0x00001E47
		[global::Cpp2ILInjected.Token(Token = "0x6000AD4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D2D078", Offset = "0x1D2D078", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XCData), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public IXmlNode CreateCDataSection(string data)
		{
			throw null;
		}

		// Token: 0x06000999 RID: 2457 RVA: 0x00003C4A File Offset: 0x00001E4A
		[global::Cpp2ILInjected.Token(Token = "0x6000AD5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D2D108", Offset = "0x1D2D108", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XText), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public IXmlNode CreateWhitespace(string text)
		{
			throw null;
		}

		// Token: 0x0600099A RID: 2458 RVA: 0x00003C4D File Offset: 0x00001E4D
		[global::Cpp2ILInjected.Token(Token = "0x6000AD6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D2D198", Offset = "0x1D2D198", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XText), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public IXmlNode CreateSignificantWhitespace(string text)
		{
			throw null;
		}

		// Token: 0x0600099B RID: 2459 RVA: 0x00003C50 File Offset: 0x00001E50
		[global::Cpp2ILInjected.Token(Token = "0x6000AD7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D2D228", Offset = "0x1D2D228", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XDeclaration), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XDeclarationWrapper), Member = ".ctor", MemberParameters = new object[] { typeof(XDeclaration) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone)
		{
			throw null;
		}

		// Token: 0x0600099C RID: 2460 RVA: 0x00003C53 File Offset: 0x00001E53
		[global::Cpp2ILInjected.Token(Token = "0x6000AD8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D2D2CC", Offset = "0x1D2D2CC", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XDocumentType), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XDocumentTypeWrapper), Member = ".ctor", MemberParameters = new object[] { typeof(XDocumentType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset)
		{
			throw null;
		}

		// Token: 0x0600099D RID: 2461 RVA: 0x00003C56 File Offset: 0x00001E56
		[global::Cpp2ILInjected.Token(Token = "0x6000AD9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D2D378", Offset = "0x1D2D378", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XProcessingInstruction), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XProcessingInstructionWrapper), Member = ".ctor", MemberParameters = new object[] { typeof(XProcessingInstruction) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public IXmlNode CreateProcessingInstruction(string target, string data)
		{
			throw null;
		}

		// Token: 0x0600099E RID: 2462 RVA: 0x00003C59 File Offset: 0x00001E59
		[global::Cpp2ILInjected.Token(Token = "0x6000ADA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D2D478", Offset = "0x1D2D478", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XName), Member = "op_Implicit", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(XName))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XElement), Member = ".ctor", MemberParameters = new object[] { typeof(XName) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XContainerWrapper), Member = ".ctor", MemberParameters = new object[] { typeof(XContainer) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public IXmlElement CreateElement(string elementName)
		{
			throw null;
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x00003C5C File Offset: 0x00001E5C
		[global::Cpp2ILInjected.Token(Token = "0x6000ADB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D2D51C", Offset = "0x1D2D51C", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MiscellaneousUtils), Member = "GetLocalName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XName), Member = "Get", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(XName))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XElement), Member = ".ctor", MemberParameters = new object[] { typeof(XName) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XContainerWrapper), Member = ".ctor", MemberParameters = new object[] { typeof(XContainer) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public IXmlElement CreateElement(string qualifiedName, string namespaceUri)
		{
			throw null;
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x00003C5F File Offset: 0x00001E5F
		[global::Cpp2ILInjected.Token(Token = "0x6000ADC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D2D5CC", Offset = "0x1D2D5CC", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XName), Member = "op_Implicit", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(XName))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XAttribute), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(XName),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XAttributeWrapper), Member = ".ctor", MemberParameters = new object[] { typeof(XAttribute) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public IXmlNode CreateAttribute(string name, string value)
		{
			throw null;
		}

		// Token: 0x060009A1 RID: 2465 RVA: 0x00003C62 File Offset: 0x00001E62
		[global::Cpp2ILInjected.Token(Token = "0x6000ADD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D2D6E0", Offset = "0x1D2D6E0", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MiscellaneousUtils), Member = "GetLocalName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XName), Member = "Get", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(XName))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XAttribute), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(XName),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XAttributeWrapper), Member = ".ctor", MemberParameters = new object[] { typeof(XAttribute) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value)
		{
			throw null;
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x060009A2 RID: 2466 RVA: 0x00003C65 File Offset: 0x00001E65
		[global::Cpp2ILInjected.Token(Token = "0x17000209")]
		public IXmlElement DocumentElement
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000ADE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D2D7A0", Offset = "0x1D2D7A0", Length = "0x8C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XDocumentWrapper), Member = "get_Document", ReturnType = typeof(XDocument))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XDocument), Member = "get_Root", ReturnType = typeof(XElement))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XContainerWrapper), Member = ".ctor", MemberParameters = new object[] { typeof(XContainer) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060009A3 RID: 2467 RVA: 0x00003C68 File Offset: 0x00001E68
		[global::Cpp2ILInjected.Token(Token = "0x6000ADF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D2D82C", Offset = "0x1D2D82C", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XContainerWrapper), Member = "AppendChild", MemberParameters = new object[] { typeof(IXmlNode) }, ReturnType = typeof(IXmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XDocumentWrapper), Member = "get_Document", ReturnType = typeof(XDocument))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override IXmlNode AppendChild(IXmlNode newChild)
		{
			throw null;
		}
	}
}
