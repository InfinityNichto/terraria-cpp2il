using System;
using System.Text;
using System.Xml;
using System.Xml.XPath;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace MS.Internal.Xml.Cache
{
	[global::Cpp2ILInjected.Token(Token = "0x2000170")]
	internal sealed class XPathDocumentNavigator : XPathNavigator
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000CA4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF0290", Offset = "0x1DF0290", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XPathDocumentNavigator), Member = "Clone", ReturnType = typeof(XPathNavigator))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XPathNavigator), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public XPathDocumentNavigator(XPathNode[] pageCurrent, int idxCurrent, XPathNode[] pageParent, int idxParent)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700034D")]
		public override string Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000CA5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DF0314", Offset = "0x1DF0314", Length = "0x1AC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XPathNodeHelper), Member = "GetTextFollowing", MemberParameters = new object[]
			{
				typeof(ref XPathNode[]),
				typeof(ref int),
				typeof(XPathNode[]),
				typeof(int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000CA6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF0634", Offset = "0x1DF0634", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XPathDocumentNavigator), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(XPathNode[]),
			typeof(int),
			typeof(XPathNode[]),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override XPathNavigator Clone()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700034E")]
		public override XPathNodeType NodeType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000CA7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DF06A8", Offset = "0x1DF06A8", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700034F")]
		public override string LocalName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000CA8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DF06CC", Offset = "0x1DF06CC", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000350")]
		public override string NamespaceURI
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000CA9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DF06F0", Offset = "0x1DF06F0", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000351")]
		public override string Prefix
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000CAA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DF0714", Offset = "0x1DF0714", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000352")]
		public override XmlNameTable NameTable
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000CAB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DF0738", Offset = "0x1DF0738", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000CAC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF0760", Offset = "0x1DF0760", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XPathNodeHelper), Member = "GetLocalNamespaces", MemberParameters = new object[]
		{
			typeof(XPathNode[]),
			typeof(int),
			typeof(ref XPathNode[])
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XPathNodeHelper), Member = "GetInScopeNamespaces", MemberParameters = new object[]
		{
			typeof(XPathNode[]),
			typeof(int),
			typeof(ref XPathNode[])
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XPathNode), Member = "get_IsXmlNamespaceNode", ReturnType = typeof(bool))]
		public override bool MoveToFirstNamespace(XPathNamespaceScope namespaceScope)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000CAD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF096C", Offset = "0x1DF096C", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XPathNode), Member = "get_IsXmlNamespaceNode", ReturnType = typeof(bool))]
		public override bool MoveToNextNamespace(XPathNamespaceScope scope)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000CAE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF0A38", Offset = "0x1DF0A38", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override bool MoveToParent()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000CAF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF0AB8", Offset = "0x1DF0AB8", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool IsSamePosition(XPathNavigator other)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000353")]
		public override object UnderlyingObject
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000CB0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DF0B5C", Offset = "0x1DF0B5C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000CB1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF0B6C", Offset = "0x1DF0B6C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XPathNavigatorKeyComparer), Member = "System.Collections.IEqualityComparer.GetHashCode", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public int GetPositionHashCode()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000686")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private XPathNode[] _pageCurrent;

		[global::Cpp2ILInjected.Token(Token = "0x4000687")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private XPathNode[] _pageParent;

		[global::Cpp2ILInjected.Token(Token = "0x4000688")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int _idxCurrent;

		[global::Cpp2ILInjected.Token(Token = "0x4000689")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private int _idxParent;
	}
}
