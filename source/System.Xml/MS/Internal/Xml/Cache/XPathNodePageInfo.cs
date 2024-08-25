using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace MS.Internal.Xml.Cache
{
	[global::Cpp2ILInjected.Token(Token = "0x2000174")]
	internal sealed class XPathNodePageInfo
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x4000693")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int _pageNum;

		[global::Cpp2ILInjected.Token(Token = "0x4000694")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private int _nodeCount;

		[global::Cpp2ILInjected.Token(Token = "0x4000695")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private XPathNode[] _pageNext;
	}
}
