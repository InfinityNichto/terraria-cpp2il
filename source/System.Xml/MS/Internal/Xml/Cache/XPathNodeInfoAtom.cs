using System;
using System.Xml.XPath;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace MS.Internal.Xml.Cache
{
	// Token: 0x0200013C RID: 316
	[global::Cpp2ILInjected.Token(Token = "0x2000175")]
	internal sealed class XPathNodeInfoAtom
	{
		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06000C27 RID: 3111 RVA: 0x000051E3 File Offset: 0x000033E3
		[global::Cpp2ILInjected.Token(Token = "0x17000365")]
		public XPathNodePageInfo PageInfo
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000CCD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DF0C78", Offset = "0x1DF0C78", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06000C28 RID: 3112 RVA: 0x000051E6 File Offset: 0x000033E6
		[global::Cpp2ILInjected.Token(Token = "0x17000366")]
		public string LocalName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000CCE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DF0C80", Offset = "0x1DF0C80", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06000C29 RID: 3113 RVA: 0x000051E9 File Offset: 0x000033E9
		[global::Cpp2ILInjected.Token(Token = "0x17000367")]
		public string NamespaceUri
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000CCF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DF0C88", Offset = "0x1DF0C88", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06000C2A RID: 3114 RVA: 0x000051EC File Offset: 0x000033EC
		[global::Cpp2ILInjected.Token(Token = "0x17000368")]
		public string Prefix
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000CD0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DF0C90", Offset = "0x1DF0C90", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06000C2B RID: 3115 RVA: 0x000051EF File Offset: 0x000033EF
		[global::Cpp2ILInjected.Token(Token = "0x17000369")]
		public XPathNode[] SiblingPage
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000CD1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DF0C98", Offset = "0x1DF0C98", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06000C2C RID: 3116 RVA: 0x000051F2 File Offset: 0x000033F2
		[global::Cpp2ILInjected.Token(Token = "0x1700036A")]
		public XPathNode[] ParentPage
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000CD2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DF0CA0", Offset = "0x1DF0CA0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06000C2D RID: 3117 RVA: 0x000051F5 File Offset: 0x000033F5
		[global::Cpp2ILInjected.Token(Token = "0x1700036B")]
		public XPathDocument Document
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000CD3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DF0CA8", Offset = "0x1DF0CA8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x040004DA RID: 1242
		[global::Cpp2ILInjected.Token(Token = "0x4000696")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string _localName;

		// Token: 0x040004DB RID: 1243
		[global::Cpp2ILInjected.Token(Token = "0x4000697")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string _namespaceUri;

		// Token: 0x040004DC RID: 1244
		[global::Cpp2ILInjected.Token(Token = "0x4000698")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string _prefix;

		// Token: 0x040004DD RID: 1245
		[global::Cpp2ILInjected.Token(Token = "0x4000699")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private XPathNode[] _pageParent;

		// Token: 0x040004DE RID: 1246
		[global::Cpp2ILInjected.Token(Token = "0x400069A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private XPathNode[] _pageSibling;

		// Token: 0x040004DF RID: 1247
		[global::Cpp2ILInjected.Token(Token = "0x400069B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private XPathDocument _doc;

		// Token: 0x040004E0 RID: 1248
		[global::Cpp2ILInjected.Token(Token = "0x400069C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private XPathNodePageInfo _pageInfo;
	}
}
