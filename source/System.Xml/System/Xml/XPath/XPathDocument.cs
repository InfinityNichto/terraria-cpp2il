using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using MS.Internal.Xml.Cache;

namespace System.Xml.XPath
{
	// Token: 0x0200008A RID: 138
	[global::Cpp2ILInjected.Token(Token = "0x20000B4")]
	public class XPathDocument
	{
		// Token: 0x170001AF RID: 431
		// (get) Token: 0x06000736 RID: 1846 RVA: 0x00004442 File Offset: 0x00002642
		[global::Cpp2ILInjected.Token(Token = "0x170001D3")]
		internal XmlNameTable NameTable
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007C4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DB1938", Offset = "0x1DB1938", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x00004445 File Offset: 0x00002645
		[global::Cpp2ILInjected.Token(Token = "0x60007C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB1940", Offset = "0x1DB1940", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XPathNodeHelper), Member = "GetInScopeNamespaces", MemberParameters = new object[]
		{
			typeof(XPathNode[]),
			typeof(int),
			typeof(ref XPathNode[])
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		internal int GetXmlNamespaceNode(out XPathNode[] pageXmlNmsp)
		{
			throw null;
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x00004448 File Offset: 0x00002648
		[global::Cpp2ILInjected.Token(Token = "0x60007C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB1950", Offset = "0x1DB1950", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XPathNodeHelper), Member = "GetLocalNamespaces", MemberParameters = new object[]
		{
			typeof(XPathNode[]),
			typeof(int),
			typeof(ref XPathNode[])
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XPathNodeHelper), Member = "GetInScopeNamespaces", MemberParameters = new object[]
		{
			typeof(XPathNode[]),
			typeof(int),
			typeof(ref XPathNode[])
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XPathNodeRef), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(XPathNode[]),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<XPathNodeRef, XPathNodeRef>), Member = "ContainsKey", MemberParameters = new object[] { typeof(XPathNodeRef) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<XPathNodeRef, XPathNodeRef>), Member = "get_Item", MemberParameters = new object[] { typeof(XPathNodeRef) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal int LookupNamespaces(XPathNode[] pageElem, int idxElem, out XPathNode[] pageNmsp)
		{
			throw null;
		}

		// Token: 0x0400027E RID: 638
		[global::Cpp2ILInjected.Token(Token = "0x40003F0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private XPathNode[] pageXmlNmsp;

		// Token: 0x0400027F RID: 639
		[global::Cpp2ILInjected.Token(Token = "0x40003F1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int idxXmlNmsp;

		// Token: 0x04000280 RID: 640
		[global::Cpp2ILInjected.Token(Token = "0x40003F2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private XmlNameTable nameTable;

		// Token: 0x04000281 RID: 641
		[global::Cpp2ILInjected.Token(Token = "0x40003F3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private Dictionary<XPathNodeRef, XPathNodeRef> mapNmsp;
	}
}
