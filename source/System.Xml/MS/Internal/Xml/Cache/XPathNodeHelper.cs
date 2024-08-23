using System;
using System.Xml.XPath;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace MS.Internal.Xml.Cache
{
	// Token: 0x0200013A RID: 314
	[global::Cpp2ILInjected.Token(Token = "0x2000173")]
	internal abstract class XPathNodeHelper
	{
		// Token: 0x06000C1E RID: 3102 RVA: 0x000051C8 File Offset: 0x000033C8
		[global::Cpp2ILInjected.Token(Token = "0x6000CC4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF0828", Offset = "0x1DF0828", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XPathDocumentNavigator), Member = "MoveToFirstNamespace", MemberParameters = new object[] { typeof(XPathNamespaceScope) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XPathDocument), Member = "LookupNamespaces", MemberParameters = new object[]
		{
			typeof(XPathNode[]),
			typeof(int),
			typeof(ref XPathNode[])
		}, ReturnType = typeof(int))]
		public static int GetLocalNamespaces(XPathNode[] pageElem, int idxElem, out XPathNode[] pageNmsp)
		{
			throw null;
		}

		// Token: 0x06000C1F RID: 3103 RVA: 0x000051CB File Offset: 0x000033CB
		[global::Cpp2ILInjected.Token(Token = "0x6000CC5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF0864", Offset = "0x1DF0864", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XPathDocumentNavigator), Member = "MoveToFirstNamespace", MemberParameters = new object[] { typeof(XPathNamespaceScope) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XPathDocument), Member = "LookupNamespaces", MemberParameters = new object[]
		{
			typeof(XPathNode[]),
			typeof(int),
			typeof(ref XPathNode[])
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XPathDocument), Member = "GetXmlNamespaceNode", MemberParameters = new object[] { typeof(ref XPathNode[]) }, ReturnType = typeof(int))]
		public static int GetInScopeNamespaces(XPathNode[] pageElem, int idxElem, out XPathNode[] pageNmsp)
		{
			throw null;
		}

		// Token: 0x06000C20 RID: 3104 RVA: 0x000051CE File Offset: 0x000033CE
		[global::Cpp2ILInjected.Token(Token = "0x6000CC6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF0A84", Offset = "0x1DF0A84", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool GetParent(ref XPathNode[] pageNode, ref int idxNode)
		{
			throw null;
		}

		// Token: 0x06000C21 RID: 3105 RVA: 0x000051D1 File Offset: 0x000033D1
		[global::Cpp2ILInjected.Token(Token = "0x6000CC7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF0C4C", Offset = "0x1DF0C4C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static int GetLocation(XPathNode[] pageNode, int idxNode)
		{
			throw null;
		}

		// Token: 0x06000C22 RID: 3106 RVA: 0x000051D4 File Offset: 0x000033D4
		[global::Cpp2ILInjected.Token(Token = "0x6000CC8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF0514", Offset = "0x1DF0514", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XPathDocumentNavigator), Member = "get_Value", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XPathNode), Member = "get_IsText", ReturnType = typeof(bool))]
		public static bool GetTextFollowing(ref XPathNode[] pageCurrent, ref int idxCurrent, XPathNode[] pageEnd, int idxEnd)
		{
			throw null;
		}

		// Token: 0x06000C23 RID: 3107 RVA: 0x000051D7 File Offset: 0x000033D7
		[global::Cpp2ILInjected.Token(Token = "0x6000CC9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF04C0", Offset = "0x1DF04C0", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool GetNonDescendant(ref XPathNode[] pageNode, ref int idxNode)
		{
			throw null;
		}
	}
}
