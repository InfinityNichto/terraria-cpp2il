using System;
using System.Collections.Generic;
using System.Xml.Linq;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000D4 RID: 212
	[global::Cpp2ILInjected.Token(Token = "0x200011B")]
	internal class XAttributeWrapper : XObjectWrapper
	{
		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x060009C5 RID: 2501 RVA: 0x00003CCE File Offset: 0x00001ECE
		[global::Cpp2ILInjected.Token(Token = "0x1700021E")]
		private XAttribute Attribute
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B01")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D2E39C", Offset = "0x1D2E39C", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XAttributeWrapper), Member = "get_Value", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XAttributeWrapper), Member = "set_Value", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XAttributeWrapper), Member = "get_LocalName", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XAttributeWrapper), Member = "get_NamespaceUri", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XAttributeWrapper), Member = "get_ParentNode", ReturnType = typeof(IXmlNode))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x00003CD1 File Offset: 0x00001ED1
		[global::Cpp2ILInjected.Token(Token = "0x6000B02")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D2D674", Offset = "0x1D2D674", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XDocumentWrapper), Member = "CreateAttribute", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(IXmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XDocumentWrapper), Member = "CreateAttribute", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(IXmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XContainerWrapper), Member = "WrapNode", MemberParameters = new object[] { typeof(XObject) }, ReturnType = typeof(IXmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XElementWrapper), Member = "get_Attributes", ReturnType = typeof(List<IXmlNode>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public XAttributeWrapper(XAttribute attribute)
		{
			throw null;
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x060009C7 RID: 2503 RVA: 0x00003CD4 File Offset: 0x00001ED4
		// (set) Token: 0x060009C8 RID: 2504 RVA: 0x00003CD7 File Offset: 0x00001ED7
		[global::Cpp2ILInjected.Token(Token = "0x1700021F")]
		public override string Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B03")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D2E414", Offset = "0x1D2E414", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XAttributeWrapper), Member = "get_Attribute", ReturnType = typeof(XAttribute))]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000B04")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D2E428", Offset = "0x1D2E428", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XAttributeWrapper), Member = "get_Attribute", ReturnType = typeof(XAttribute))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XAttribute), Member = "set_Value", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x060009C9 RID: 2505 RVA: 0x00003CDA File Offset: 0x00001EDA
		[global::Cpp2ILInjected.Token(Token = "0x17000220")]
		public override string LocalName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B05")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D2E444", Offset = "0x1D2E444", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XAttributeWrapper), Member = "get_Attribute", ReturnType = typeof(XAttribute))]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x060009CA RID: 2506 RVA: 0x00003CDD File Offset: 0x00001EDD
		[global::Cpp2ILInjected.Token(Token = "0x17000221")]
		public override string NamespaceUri
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B06")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D2E45C", Offset = "0x1D2E45C", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XAttributeWrapper), Member = "get_Attribute", ReturnType = typeof(XAttribute))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XName), Member = "get_NamespaceName", ReturnType = typeof(string))]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x060009CB RID: 2507 RVA: 0x00003CE0 File Offset: 0x00001EE0
		[global::Cpp2ILInjected.Token(Token = "0x17000222")]
		public override IXmlNode ParentNode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B07")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D2E474", Offset = "0x1D2E474", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XAttributeWrapper), Member = "get_Attribute", ReturnType = typeof(XAttribute))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XObject), Member = "get_Parent", ReturnType = typeof(XElement))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XContainerWrapper), Member = "WrapNode", MemberParameters = new object[] { typeof(XObject) }, ReturnType = typeof(IXmlNode))]
			get
			{
				throw null;
			}
		}
	}
}
