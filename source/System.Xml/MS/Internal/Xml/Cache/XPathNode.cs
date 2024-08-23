using System;
using System.Xml.XPath;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace MS.Internal.Xml.Cache
{
	// Token: 0x02000138 RID: 312
	[global::Cpp2ILInjected.Token(Token = "0x2000171")]
	internal struct XPathNode
	{
		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06000C0C RID: 3084 RVA: 0x00005192 File Offset: 0x00003392
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

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06000C0D RID: 3085 RVA: 0x00005195 File Offset: 0x00003395
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

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06000C0E RID: 3086 RVA: 0x00005198 File Offset: 0x00003398
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

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06000C0F RID: 3087 RVA: 0x0000519B File Offset: 0x0000339B
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

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06000C10 RID: 3088 RVA: 0x0000519E File Offset: 0x0000339E
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

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06000C11 RID: 3089 RVA: 0x000051A1 File Offset: 0x000033A1
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

		// Token: 0x06000C12 RID: 3090 RVA: 0x000051A4 File Offset: 0x000033A4
		[global::Cpp2ILInjected.Token(Token = "0x6000CB8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF0A24", Offset = "0x1DF0A24", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public int GetParent(out XPathNode[] pageNode)
		{
			throw null;
		}

		// Token: 0x06000C13 RID: 3091 RVA: 0x000051A7 File Offset: 0x000033A7
		[global::Cpp2ILInjected.Token(Token = "0x6000CB9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF0958", Offset = "0x1DF0958", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public int GetSibling(out XPathNode[] pageNode)
		{
			throw null;
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06000C14 RID: 3092 RVA: 0x000051AA File Offset: 0x000033AA
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

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06000C15 RID: 3093 RVA: 0x000051AD File Offset: 0x000033AD
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

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06000C16 RID: 3094 RVA: 0x000051B0 File Offset: 0x000033B0
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

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06000C17 RID: 3095 RVA: 0x000051B3 File Offset: 0x000033B3
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

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06000C18 RID: 3096 RVA: 0x000051B6 File Offset: 0x000033B6
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

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06000C19 RID: 3097 RVA: 0x000051B9 File Offset: 0x000033B9
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

		// Token: 0x040004CE RID: 1230
		[global::Cpp2ILInjected.Token(Token = "0x400068A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private XPathNodeInfoAtom _info;

		// Token: 0x040004CF RID: 1231
		[global::Cpp2ILInjected.Token(Token = "0x400068B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private ushort _idxSibling;

		// Token: 0x040004D0 RID: 1232
		[global::Cpp2ILInjected.Token(Token = "0x400068C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA")]
		private ushort _idxParent;

		// Token: 0x040004D1 RID: 1233
		[global::Cpp2ILInjected.Token(Token = "0x400068D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		private ushort _idxSimilar;

		// Token: 0x040004D2 RID: 1234
		[global::Cpp2ILInjected.Token(Token = "0x400068E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE")]
		private ushort _posOffset;

		// Token: 0x040004D3 RID: 1235
		[global::Cpp2ILInjected.Token(Token = "0x400068F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private uint _props;

		// Token: 0x040004D4 RID: 1236
		[global::Cpp2ILInjected.Token(Token = "0x4000690")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string _value;
	}
}
