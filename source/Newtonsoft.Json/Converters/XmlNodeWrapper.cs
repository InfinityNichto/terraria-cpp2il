using System;
using System.Collections.Generic;
using System.Xml;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000C6 RID: 198
	[global::Cpp2ILInjected.Token(Token = "0x200010D")]
	internal class XmlNodeWrapper : IXmlNode
	{
		// Token: 0x06000955 RID: 2389 RVA: 0x00003BE7 File Offset: 0x00001DE7
		[global::Cpp2ILInjected.Token(Token = "0x6000A91")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D2B398", Offset = "0x1D2B398", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public XmlNodeWrapper(XmlNode node)
		{
			throw null;
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000956 RID: 2390 RVA: 0x00003BEA File Offset: 0x00001DEA
		[global::Cpp2ILInjected.Token(Token = "0x170001E4")]
		public object WrappedNode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A92")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D2BD64", Offset = "0x1D2BD64", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000957 RID: 2391 RVA: 0x00003BED File Offset: 0x00001DED
		[global::Cpp2ILInjected.Token(Token = "0x170001E5")]
		public XmlNodeType NodeType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A93")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D2BD6C", Offset = "0x1D2BD6C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06000958 RID: 2392 RVA: 0x00003BF0 File Offset: 0x00001DF0
		[global::Cpp2ILInjected.Token(Token = "0x170001E6")]
		public virtual string LocalName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A94")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D2BD7C", Offset = "0x1D2BD7C", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06000959 RID: 2393 RVA: 0x00003BF3 File Offset: 0x00001DF3
		[global::Cpp2ILInjected.Token(Token = "0x170001E7")]
		public List<IXmlNode> ChildNodes
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A95")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D2BD90", Offset = "0x1D2BD90", Length = "0x3A4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNodeWrapper), Member = "WrapNode", MemberParameters = new object[] { typeof(XmlNode) }, ReturnType = typeof(IXmlNode))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x00003BF6 File Offset: 0x00001DF6
		[global::Cpp2ILInjected.Token(Token = "0x6000A96")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D2C134", Offset = "0x1D2C134", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNodeWrapper), Member = "get_ChildNodes", ReturnType = typeof(List<IXmlNode>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNodeWrapper), Member = "get_Attributes", ReturnType = typeof(List<IXmlNode>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNodeWrapper), Member = "get_ParentNode", ReturnType = typeof(IXmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNodeConverter), Member = "WrapXml", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(IXmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		internal static IXmlNode WrapNode(XmlNode node)
		{
			throw null;
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x0600095B RID: 2395 RVA: 0x00003BF9 File Offset: 0x00001DF9
		[global::Cpp2ILInjected.Token(Token = "0x170001E8")]
		public List<IXmlNode> Attributes
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A97")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D2C298", Offset = "0x1D2C298", Length = "0x3E8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNodeWrapper), Member = "WrapNode", MemberParameters = new object[] { typeof(XmlNode) }, ReturnType = typeof(IXmlNode))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x0600095C RID: 2396 RVA: 0x00003BFC File Offset: 0x00001DFC
		[global::Cpp2ILInjected.Token(Token = "0x170001E9")]
		public IXmlNode ParentNode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A98")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D2C680", Offset = "0x1D2C680", Length = "0x98")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNodeWrapper), Member = "WrapNode", MemberParameters = new object[] { typeof(XmlNode) }, ReturnType = typeof(IXmlNode))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x0600095D RID: 2397 RVA: 0x00003BFF File Offset: 0x00001DFF
		// (set) Token: 0x0600095E RID: 2398 RVA: 0x00003C02 File Offset: 0x00001E02
		[global::Cpp2ILInjected.Token(Token = "0x170001EA")]
		public string Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A99")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D2C718", Offset = "0x1D2C718", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000A9A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D2BA70", Offset = "0x1D2BA70", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600095F RID: 2399 RVA: 0x00003C05 File Offset: 0x00001E05
		[global::Cpp2ILInjected.Token(Token = "0x6000A9B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D2C728", Offset = "0x1D2C728", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public IXmlNode AppendChild(IXmlNode newChild)
		{
			throw null;
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06000960 RID: 2400 RVA: 0x00003C08 File Offset: 0x00001E08
		[global::Cpp2ILInjected.Token(Token = "0x170001EB")]
		public string NamespaceUri
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A9C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D2C7C4", Offset = "0x1D2C7C4", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x040002F7 RID: 759
		[global::Cpp2ILInjected.Token(Token = "0x4000411")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly XmlNode _node;

		// Token: 0x040002F8 RID: 760
		[global::Cpp2ILInjected.Token(Token = "0x4000412")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private List<IXmlNode> _childNodes;

		// Token: 0x040002F9 RID: 761
		[global::Cpp2ILInjected.Token(Token = "0x4000413")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private List<IXmlNode> _attributes;
	}
}
