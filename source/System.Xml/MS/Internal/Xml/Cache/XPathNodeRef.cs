using System;
using System.Xml.XPath;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace MS.Internal.Xml.Cache
{
	// Token: 0x02000139 RID: 313
	[global::Cpp2ILInjected.Token(Token = "0x2000172")]
	internal struct XPathNodeRef
	{
		// Token: 0x06000C1A RID: 3098 RVA: 0x000051BC File Offset: 0x000033BC
		[global::Cpp2ILInjected.Token(Token = "0x6000CC0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF0C14", Offset = "0x1DF0C14", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XPathDocument), Member = "LookupNamespaces", MemberParameters = new object[]
		{
			typeof(XPathNode[]),
			typeof(int),
			typeof(ref XPathNode[])
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public XPathNodeRef(XPathNode[] page, int idx)
		{
			throw null;
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06000C1B RID: 3099 RVA: 0x000051BF File Offset: 0x000033BF
		[global::Cpp2ILInjected.Token(Token = "0x17000360")]
		public XPathNode[] Page
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000CC1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DF0C20", Offset = "0x1DF0C20", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06000C1C RID: 3100 RVA: 0x000051C2 File Offset: 0x000033C2
		[global::Cpp2ILInjected.Token(Token = "0x17000361")]
		public int Index
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000CC2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DF0C28", Offset = "0x1DF0C28", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000C1D RID: 3101 RVA: 0x000051C5 File Offset: 0x000033C5
		[global::Cpp2ILInjected.Token(Token = "0x6000CC3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF0C30", Offset = "0x1DF0C30", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x040004D5 RID: 1237
		[global::Cpp2ILInjected.Token(Token = "0x4000691")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private XPathNode[] _page;

		// Token: 0x040004D6 RID: 1238
		[global::Cpp2ILInjected.Token(Token = "0x4000692")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private int _idx;
	}
}
