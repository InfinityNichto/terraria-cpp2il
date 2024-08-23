using System;
using System.Collections.Generic;
using System.Xml.Linq;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000D2 RID: 210
	[global::Cpp2ILInjected.Token(Token = "0x2000119")]
	internal class XContainerWrapper : XObjectWrapper
	{
		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x060009B3 RID: 2483 RVA: 0x00003C98 File Offset: 0x00001E98
		[global::Cpp2ILInjected.Token(Token = "0x17000213")]
		private XContainer Container
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AEF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D2E158", Offset = "0x1D2E158", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XContainerWrapper), Member = "get_ChildNodes", ReturnType = typeof(List<IXmlNode>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XContainerWrapper), Member = "get_ParentNode", ReturnType = typeof(IXmlNode))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XContainerWrapper), Member = "AppendChild", MemberParameters = new object[] { typeof(IXmlNode) }, ReturnType = typeof(IXmlNode))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060009B4 RID: 2484 RVA: 0x00003C9B File Offset: 0x00001E9B
		[global::Cpp2ILInjected.Token(Token = "0x6000AF0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D2CA18", Offset = "0x1D2CA18", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XDocumentWrapper), Member = "CreateElement", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(IXmlElement))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XDocumentWrapper), Member = "CreateElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(IXmlElement))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XDocumentWrapper), Member = "get_DocumentElement", ReturnType = typeof(IXmlElement))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XContainerWrapper), Member = "WrapNode", MemberParameters = new object[] { typeof(XObject) }, ReturnType = typeof(IXmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XElementWrapper), Member = ".ctor", MemberParameters = new object[] { typeof(XElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNodeConverter), Member = "ReadJson", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(object),
			typeof(JsonSerializer)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public XContainerWrapper(XContainer container)
		{
			throw null;
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x060009B5 RID: 2485 RVA: 0x00003C9E File Offset: 0x00001E9E
		[global::Cpp2ILInjected.Token(Token = "0x17000214")]
		public override List<IXmlNode> ChildNodes
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AF1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D2CBD0", Offset = "0x1D2CBD0", Length = "0x388")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XDocumentWrapper), Member = "get_ChildNodes", ReturnType = typeof(List<IXmlNode>))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XContainerWrapper), Member = "get_Container", ReturnType = typeof(XContainer))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XContainer), Member = "Nodes", ReturnType = typeof(IEnumerable<XNode>))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XContainerWrapper), Member = "WrapNode", MemberParameters = new object[] { typeof(XObject) }, ReturnType = typeof(IXmlNode))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x060009B6 RID: 2486 RVA: 0x00003CA1 File Offset: 0x00001EA1
		[global::Cpp2ILInjected.Token(Token = "0x17000215")]
		public override IXmlNode ParentNode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AF2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D2E1D0", Offset = "0x1D2E1D0", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XContainerWrapper), Member = "get_Container", ReturnType = typeof(XContainer))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XObject), Member = "get_Parent", ReturnType = typeof(XElement))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XContainerWrapper), Member = "WrapNode", MemberParameters = new object[] { typeof(XObject) }, ReturnType = typeof(IXmlNode))]
			get
			{
				throw null;
			}
		}

		// Token: 0x060009B7 RID: 2487 RVA: 0x00003CA4 File Offset: 0x00001EA4
		[global::Cpp2ILInjected.Token(Token = "0x6000AF3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D2DAE0", Offset = "0x1D2DAE0", Length = "0x470")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XCommentWrapper), Member = "get_ParentNode", ReturnType = typeof(IXmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XContainerWrapper), Member = "get_ChildNodes", ReturnType = typeof(List<IXmlNode>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XContainerWrapper), Member = "get_ParentNode", ReturnType = typeof(IXmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XAttributeWrapper), Member = "get_ParentNode", ReturnType = typeof(IXmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNodeConverter), Member = "WrapXml", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(IXmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XContainerWrapper), Member = ".ctor", MemberParameters = new object[] { typeof(XContainer) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XProcessingInstructionWrapper), Member = ".ctor", MemberParameters = new object[] { typeof(XProcessingInstruction) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XTextWrapper), Member = ".ctor", MemberParameters = new object[] { typeof(XText) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XCommentWrapper), Member = ".ctor", MemberParameters = new object[] { typeof(XComment) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XAttributeWrapper), Member = ".ctor", MemberParameters = new object[] { typeof(XAttribute) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XDocumentTypeWrapper), Member = ".ctor", MemberParameters = new object[] { typeof(XDocumentType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		internal static IXmlNode WrapNode(XObject node)
		{
			throw null;
		}

		// Token: 0x060009B8 RID: 2488 RVA: 0x00003CA7 File Offset: 0x00001EA7
		[global::Cpp2ILInjected.Token(Token = "0x6000AF4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D2D8C8", Offset = "0x1D2D8C8", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XDocumentWrapper), Member = "AppendChild", MemberParameters = new object[] { typeof(IXmlNode) }, ReturnType = typeof(IXmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XElementWrapper), Member = "AppendChild", MemberParameters = new object[] { typeof(IXmlNode) }, ReturnType = typeof(IXmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XContainerWrapper), Member = "get_Container", ReturnType = typeof(XContainer))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XContainer), Member = "Add", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override IXmlNode AppendChild(IXmlNode newChild)
		{
			throw null;
		}

		// Token: 0x040002FC RID: 764
		[global::Cpp2ILInjected.Token(Token = "0x4000416")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private List<IXmlNode> _childNodes;
	}
}
