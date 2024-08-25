using System;
using System.Xml.XPath;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace MS.Internal.Xml.Cache
{
	[global::Cpp2ILInjected.Token(Token = "0x2000172")]
	internal struct XPathNodeRef
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x6000CC3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF0C30", Offset = "0x1DF0C30", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override int GetHashCode()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000691")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private XPathNode[] _page;

		[global::Cpp2ILInjected.Token(Token = "0x4000692")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private int _idx;
	}
}
