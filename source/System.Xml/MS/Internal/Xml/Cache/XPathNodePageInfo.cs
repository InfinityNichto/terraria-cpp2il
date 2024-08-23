using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace MS.Internal.Xml.Cache
{
	// Token: 0x0200013B RID: 315
	[global::Cpp2ILInjected.Token(Token = "0x2000174")]
	internal sealed class XPathNodePageInfo
	{
		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06000C24 RID: 3108 RVA: 0x000051DA File Offset: 0x000033DA
		[global::Cpp2ILInjected.Token(Token = "0x17000362")]
		public int PageNumber
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000CCA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DF0C60", Offset = "0x1DF0C60", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06000C25 RID: 3109 RVA: 0x000051DD File Offset: 0x000033DD
		[global::Cpp2ILInjected.Token(Token = "0x17000363")]
		public int NodeCount
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000CCB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DF0C68", Offset = "0x1DF0C68", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06000C26 RID: 3110 RVA: 0x000051E0 File Offset: 0x000033E0
		[global::Cpp2ILInjected.Token(Token = "0x17000364")]
		public XPathNode[] NextPage
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000CCC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DF0C70", Offset = "0x1DF0C70", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x040004D7 RID: 1239
		[global::Cpp2ILInjected.Token(Token = "0x4000693")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int _pageNum;

		// Token: 0x040004D8 RID: 1240
		[global::Cpp2ILInjected.Token(Token = "0x4000694")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private int _nodeCount;

		// Token: 0x040004D9 RID: 1241
		[global::Cpp2ILInjected.Token(Token = "0x4000695")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private XPathNode[] _pageNext;
	}
}
