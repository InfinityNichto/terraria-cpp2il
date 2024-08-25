using System;
using System.Xml.XPath;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace MS.Internal.Xml.Cache
{
	[global::Cpp2ILInjected.Token(Token = "0x2000171")]
	internal struct XPathNode
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000354")]
		public XPathNodeType NodeType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000CB2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DF06C0", Offset = "0x1DF06C0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000355")]
		public string Prefix
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000CB3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DF072C", Offset = "0x1DF072C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000356")]
		public string LocalName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000CB4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DF06E4", Offset = "0x1DF06E4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000357")]
		public string NamespaceUri
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000CB5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DF0708", Offset = "0x1DF0708", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000358")]
		public XPathDocument Document
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000CB6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DF0754", Offset = "0x1DF0754", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000359")]
		public XPathNodePageInfo PageInfo
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000CB7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DF0B78", Offset = "0x1DF0B78", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000CB8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF0A24", Offset = "0x1DF0A24", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public int GetParent(out XPathNode[] pageNode)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000CB9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF0958", Offset = "0x1DF0958", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public int GetSibling(out XPathNode[] pageNode)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700035A")]
		public bool IsXmlNamespaceNode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000CBA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DF08DC", Offset = "0x1DF08DC", Length = "0x7C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XPathDocumentNavigator), Member = "MoveToFirstNamespace", MemberParameters = new object[] { typeof(XPathNamespaceScope) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XPathDocumentNavigator), Member = "MoveToNextNamespace", MemberParameters = new object[] { typeof(XPathNamespaceScope) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700035B")]
		public bool HasSibling
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000CBB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DF0B84", Offset = "0x1DF0B84", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700035C")]
		public bool HasCollapsedText
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000CBC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DF0B94", Offset = "0x1DF0B94", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700035D")]
		public bool IsText
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000CBD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DF0BA0", Offset = "0x1DF0BA0", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XPathNodeHelper), Member = "GetTextFollowing", MemberParameters = new object[]
			{
				typeof(ref XPathNode[]),
				typeof(ref int),
				typeof(XPathNode[]),
				typeof(int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XPathNavigator), Member = "IsText", MemberParameters = new object[] { typeof(XPathNodeType) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700035E")]
		public bool HasNamespaceDecls
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000CBE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DF0C00", Offset = "0x1DF0C00", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700035F")]
		public string Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000CBF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DF0C0C", Offset = "0x1DF0C0C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x400068A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private XPathNodeInfoAtom _info;

		[global::Cpp2ILInjected.Token(Token = "0x400068B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private ushort _idxSibling;

		[global::Cpp2ILInjected.Token(Token = "0x400068C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA")]
		private ushort _idxParent;

		[global::Cpp2ILInjected.Token(Token = "0x400068D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		private ushort _idxSimilar;

		[global::Cpp2ILInjected.Token(Token = "0x400068E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE")]
		private ushort _posOffset;

		[global::Cpp2ILInjected.Token(Token = "0x400068F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private uint _props;

		[global::Cpp2ILInjected.Token(Token = "0x4000690")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string _value;
	}
}
