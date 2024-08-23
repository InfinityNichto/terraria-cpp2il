using System;
using System.Collections;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x0200005A RID: 90
	[DefaultMember("Item")]
	[DebuggerDisplay("{debuggerDisplayProxy}")]
	[global::Cpp2ILInjected.Token(Token = "0x2000079")]
	public abstract class XmlNode : ICloneable, IEnumerable
	{
		// Token: 0x06000540 RID: 1344 RVA: 0x00003E8D File Offset: 0x0000208D
		[global::Cpp2ILInjected.Token(Token = "0x60005C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D90EFC", Offset = "0x1D90EFC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDocument), Member = ".ctor", MemberParameters = new object[] { typeof(XmlImplementation) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal XmlNode()
		{
			throw null;
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x00003E90 File Offset: 0x00002090
		[global::Cpp2ILInjected.Token(Token = "0x60005C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D92698", Offset = "0x1D92698", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAttribute), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(XmlName),
			typeof(XmlDocument)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDocumentType), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(XmlDocument)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlElement), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(XmlName),
			typeof(bool),
			typeof(XmlDocument)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEntity), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(XmlDocument)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEntityReference), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XmlDocument)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLinkedNode), Member = ".ctor", MemberParameters = new object[] { typeof(XmlDocument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "LoadNodeDirect", ReturnType = typeof(XmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNotation), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(XmlDocument)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlProcessingInstruction), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(XmlDocument)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal XmlNode(XmlDocument doc)
		{
			throw null;
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06000542 RID: 1346
		[global::Cpp2ILInjected.Token(Token = "0x17000175")]
		public abstract string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005C4")]
			get;
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000543 RID: 1347 RVA: 0x00003E93 File Offset: 0x00002093
		// (set) Token: 0x06000544 RID: 1348 RVA: 0x00003E96 File Offset: 0x00002096
		[global::Cpp2ILInjected.Token(Token = "0x17000176")]
		public virtual string Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005C5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D98A04", Offset = "0x1D98A04", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60005C6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D98A0C", Offset = "0x1D98A0C", Length = "0xCC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
			{
				typeof(IFormatProvider),
				typeof(string),
				typeof(object)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000545 RID: 1349
		[global::Cpp2ILInjected.Token(Token = "0x17000177")]
		public abstract XmlNodeType NodeType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005C7")]
			get;
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000546 RID: 1350 RVA: 0x00003E99 File Offset: 0x00002099
		[global::Cpp2ILInjected.Token(Token = "0x17000178")]
		public virtual XmlNode ParentNode
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005C8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D98AD8", Offset = "0x1D98AD8", Length = "0xDC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlSignificantWhitespace), Member = "get_ParentNode", ReturnType = typeof(XmlNode))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWhitespace), Member = "get_ParentNode", ReturnType = typeof(XmlNode))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000547 RID: 1351 RVA: 0x00003E9C File Offset: 0x0000209C
		[global::Cpp2ILInjected.Token(Token = "0x17000179")]
		public virtual XmlNodeList ChildNodes
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005C9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D98BB4", Offset = "0x1D98BB4", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlChildNodes), Member = ".ctor", MemberParameters = new object[] { typeof(XmlNode) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000548 RID: 1352 RVA: 0x00003E9F File Offset: 0x0000209F
		[global::Cpp2ILInjected.Token(Token = "0x1700017A")]
		public virtual XmlNode PreviousSibling
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005CA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D98C10", Offset = "0x1D98C10", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000549 RID: 1353 RVA: 0x00003EA2 File Offset: 0x000020A2
		[global::Cpp2ILInjected.Token(Token = "0x1700017B")]
		public virtual XmlNode NextSibling
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005CB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D98C18", Offset = "0x1D98C18", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x0600054A RID: 1354 RVA: 0x00003EA5 File Offset: 0x000020A5
		[global::Cpp2ILInjected.Token(Token = "0x1700017C")]
		public virtual XmlAttributeCollection Attributes
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005CC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D98C20", Offset = "0x1D98C20", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x0600054B RID: 1355 RVA: 0x00003EA8 File Offset: 0x000020A8
		[global::Cpp2ILInjected.Token(Token = "0x1700017D")]
		public virtual XmlDocument OwnerDocument
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005CD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D98C28", Offset = "0x1D98C28", Length = "0xAC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x0600054C RID: 1356 RVA: 0x00003EAB File Offset: 0x000020AB
		[global::Cpp2ILInjected.Token(Token = "0x1700017E")]
		public virtual XmlNode FirstChild
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005CE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D98CD4", Offset = "0x1D98CD4", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x0600054D RID: 1357 RVA: 0x00003EAE File Offset: 0x000020AE
		[global::Cpp2ILInjected.Token(Token = "0x1700017F")]
		public virtual XmlNode LastChild
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005CF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D98CF8", Offset = "0x1D98CF8", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x0600054E RID: 1358 RVA: 0x00003EB1 File Offset: 0x000020B1
		[global::Cpp2ILInjected.Token(Token = "0x17000180")]
		internal virtual bool IsContainer
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005D0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D98D08", Offset = "0x1D98D08", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x0600054F RID: 1359 RVA: 0x00003EB4 File Offset: 0x000020B4
		// (set) Token: 0x06000550 RID: 1360 RVA: 0x00003EB7 File Offset: 0x000020B7
		[global::Cpp2ILInjected.Token(Token = "0x17000181")]
		internal virtual XmlLinkedNode LastNode
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005D1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D98D10", Offset = "0x1D98D10", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60005D2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D98D18", Offset = "0x1D98D18", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x00003EBA File Offset: 0x000020BA
		[global::Cpp2ILInjected.Token(Token = "0x60005D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D98D1C", Offset = "0x1D98D1C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNode), Member = "AppendChild", MemberParameters = new object[] { typeof(XmlNode) }, ReturnType = typeof(XmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		internal bool AncestorNode(XmlNode node)
		{
			throw null;
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x00003EBD File Offset: 0x000020BD
		[global::Cpp2ILInjected.Token(Token = "0x60005D4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D98D74", Offset = "0x1D98D74", Length = "0x358")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAttribute), Member = "RemoveChild", MemberParameters = new object[] { typeof(XmlNode) }, ReturnType = typeof(XmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public virtual XmlNode RemoveChild(XmlNode oldChild)
		{
			throw null;
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x00003EC0 File Offset: 0x000020C0
		[global::Cpp2ILInjected.Token(Token = "0x60005D5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D990F0", Offset = "0x1D990F0", Length = "0x49C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAttribute), Member = "AppendChild", MemberParameters = new object[] { typeof(XmlNode) }, ReturnType = typeof(XmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNode), Member = "AncestorNode", MemberParameters = new object[] { typeof(XmlNode) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public virtual XmlNode AppendChild(XmlNode newChild)
		{
			throw null;
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x00003EC3 File Offset: 0x000020C3
		[global::Cpp2ILInjected.Token(Token = "0x60005D6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9958C", Offset = "0x1D9958C", Length = "0x18C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlDocument), Member = "GetInsertEventArgsForLoad", MemberParameters = new object[]
		{
			typeof(XmlNode),
			typeof(XmlNode)
		}, ReturnType = typeof(XmlNodeChangedEventArgs))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal virtual XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc)
		{
			throw null;
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x00003EC6 File Offset: 0x000020C6
		[global::Cpp2ILInjected.Token(Token = "0x60005D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D99718", Offset = "0x1D99718", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal virtual bool IsValidChildType(XmlNodeType type)
		{
			throw null;
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x00003EC9 File Offset: 0x000020C9
		[global::Cpp2ILInjected.Token(Token = "0x60005D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D99720", Offset = "0x1D99720", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal virtual bool CanInsertAfter(XmlNode newChild, XmlNode refChild)
		{
			throw null;
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000557 RID: 1367 RVA: 0x00003ECC File Offset: 0x000020CC
		[global::Cpp2ILInjected.Token(Token = "0x17000182")]
		public virtual bool HasChildNodes
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005D9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D99728", Offset = "0x1D99728", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000558 RID: 1368
		[global::Cpp2ILInjected.Token(Token = "0x60005DA")]
		public abstract XmlNode CloneNode(bool deep);

		// Token: 0x06000559 RID: 1369 RVA: 0x00003ECF File Offset: 0x000020CF
		[global::Cpp2ILInjected.Token(Token = "0x60005DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9974C", Offset = "0x1D9974C", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal virtual void CopyChildren(XmlDocument doc, XmlNode container, bool deep)
		{
			throw null;
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x0600055A RID: 1370 RVA: 0x00003ED2 File Offset: 0x000020D2
		[global::Cpp2ILInjected.Token(Token = "0x17000183")]
		public virtual string NamespaceURI
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005DC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D997E4", Offset = "0x1D997E4", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x0600055B RID: 1371 RVA: 0x00003ED5 File Offset: 0x000020D5
		[global::Cpp2ILInjected.Token(Token = "0x17000184")]
		public virtual string Prefix
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005DD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D9982C", Offset = "0x1D9982C", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x0600055C RID: 1372
		[global::Cpp2ILInjected.Token(Token = "0x17000185")]
		public abstract string LocalName
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005DE")]
			get;
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x0600055D RID: 1373 RVA: 0x00003ED8 File Offset: 0x000020D8
		[global::Cpp2ILInjected.Token(Token = "0x17000186")]
		public virtual bool IsReadOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005DF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D99874", Offset = "0x1D99874", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x00003EDB File Offset: 0x000020DB
		[global::Cpp2ILInjected.Token(Token = "0x60005E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D99898", Offset = "0x1D99898", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static bool HasReadOnlyParent(XmlNode n)
		{
			throw null;
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x00003EDE File Offset: 0x000020DE
		[global::Cpp2ILInjected.Token(Token = "0x60005E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D99964", Offset = "0x1D99964", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private object System.ICloneable.Clone()
		{
			throw null;
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x00003EE1 File Offset: 0x000020E1
		[global::Cpp2ILInjected.Token(Token = "0x60005E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D99978", Offset = "0x1D99978", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlChildEnumerator), Member = ".ctor", MemberParameters = new object[] { typeof(XmlNode) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw null;
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x00003EE4 File Offset: 0x000020E4
		[global::Cpp2ILInjected.Token(Token = "0x60005E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D999D4", Offset = "0x1D999D4", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNode), Member = "AppendChildText", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNode), Member = "get_InnerText", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNode), Member = "AppendChildText", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		private void AppendChildText(StringBuilder builder)
		{
			throw null;
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000562 RID: 1378 RVA: 0x00003EE7 File Offset: 0x000020E7
		// (set) Token: 0x06000563 RID: 1379 RVA: 0x00003EEA File Offset: 0x000020EA
		[global::Cpp2ILInjected.Token(Token = "0x17000187")]
		public virtual string InnerText
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005E4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D92430", Offset = "0x1D92430", Length = "0x100")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAttribute), Member = "set_InnerText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEntity), Member = "get_InnerText", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNode), Member = "AppendChildText", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60005E5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D99AD0", Offset = "0x1D99AD0", Length = "0xC8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAttribute), Member = "set_InnerText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000164 RID: 356
		// (set) Token: 0x06000564 RID: 1380 RVA: 0x00003EED File Offset: 0x000020ED
		[global::Cpp2ILInjected.Token(Token = "0x17000188")]
		public virtual string InnerXml
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005E6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D99B98", Offset = "0x1D99B98", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000565 RID: 1381 RVA: 0x00003EF0 File Offset: 0x000020F0
		[global::Cpp2ILInjected.Token(Token = "0x17000189")]
		public virtual string BaseURI
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005E7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D99BF0", Offset = "0x1D99BF0", Length = "0x124")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEntityReference), Member = "get_ChildBaseURI", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x00003EF3 File Offset: 0x000020F3
		[global::Cpp2ILInjected.Token(Token = "0x60005E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D922E8", Offset = "0x1D922E8", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlElement), Member = "CloneNode", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(XmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlElement), Member = "set_IsEmpty", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlElement), Member = "RemoveAll", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlElement), Member = "RemoveAllChildren", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlElement), Member = "set_InnerXml", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlElement), Member = "set_InnerText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "LoadNode", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(XmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "LoadNodeDirect", ReturnType = typeof(XmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		public virtual void RemoveAll()
		{
			throw null;
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000567 RID: 1383 RVA: 0x00003EF6 File Offset: 0x000020F6
		[global::Cpp2ILInjected.Token(Token = "0x1700018A")]
		internal XmlDocument Document
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005E9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D99D14", Offset = "0x1D99D14", Length = "0xAC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNode), Member = "GetPrefixOfNamespaceStrict", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x00003EF9 File Offset: 0x000020F9
		[global::Cpp2ILInjected.Token(Token = "0x60005EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D99DC0", Offset = "0x1D99DC0", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNode), Member = "GetPrefixOfNamespaceStrict", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual string GetPrefixOfNamespace(string namespaceURI)
		{
			throw null;
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x00003EFC File Offset: 0x000020FC
		[global::Cpp2ILInjected.Token(Token = "0x60005EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D99E20", Offset = "0x1D99E20", Length = "0x338")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNode), Member = "GetPrefixOfNamespace", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNode), Member = "get_Document", ReturnType = typeof(XmlDocument))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlDocument), Member = "get_NameTable", ReturnType = typeof(XmlNameTable))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAttributeCollection), Member = "get_ItemOf", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(XmlAttribute))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal string GetPrefixOfNamespaceStrict(string namespaceURI)
		{
			throw null;
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x00003EFF File Offset: 0x000020FF
		[global::Cpp2ILInjected.Token(Token = "0x60005EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D92BC0", Offset = "0x1D92BC0", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal virtual void SetParent(XmlNode node)
		{
			throw null;
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x00003F02 File Offset: 0x00002102
		[global::Cpp2ILInjected.Token(Token = "0x60005ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9A158", Offset = "0x1D9A158", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal virtual void SetParentForLoad(XmlNode node)
		{
			throw null;
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x00003F05 File Offset: 0x00002105
		[global::Cpp2ILInjected.Token(Token = "0x60005EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9A160", Offset = "0x1D9A160", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDocument), Member = "CreateAttribute", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(XmlAttribute))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDocument), Member = "CreateElement", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(XmlElement))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDocument), Member = "CreateAttribute", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(XmlAttribute))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDocument), Member = "CreateElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(XmlElement))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal static void SplitName(string name, out string prefix, out string localName)
		{
			throw null;
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x00003F08 File Offset: 0x00002108
		[global::Cpp2ILInjected.Token(Token = "0x60005EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9A224", Offset = "0x1D9A224", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal virtual XmlNode FindChild(XmlNodeType type)
		{
			throw null;
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x00003F0B File Offset: 0x0000210B
		[global::Cpp2ILInjected.Token(Token = "0x60005F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9A288", Offset = "0x1D9A288", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal virtual XmlNodeChangedEventArgs GetEventArgs(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action)
		{
			throw null;
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x00003F0E File Offset: 0x0000210E
		[global::Cpp2ILInjected.Token(Token = "0x60005F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9A3AC", Offset = "0x1D9A3AC", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal virtual void BeforeEvent(XmlNodeChangedEventArgs args)
		{
			throw null;
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x00003F11 File Offset: 0x00002111
		[global::Cpp2ILInjected.Token(Token = "0x60005F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9A3E4", Offset = "0x1D9A3E4", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal virtual void AfterEvent(XmlNodeChangedEventArgs args)
		{
			throw null;
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000571 RID: 1393 RVA: 0x00003F14 File Offset: 0x00002114
		[global::Cpp2ILInjected.Token(Token = "0x1700018B")]
		internal virtual bool IsText
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005F3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D9A41C", Offset = "0x1D9A41C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x00003F17 File Offset: 0x00002117
		[global::Cpp2ILInjected.Token(Token = "0x60005F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D91FEC", Offset = "0x1D91FEC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAttribute), Member = "AppendChildForLoad", MemberParameters = new object[]
		{
			typeof(XmlNode),
			typeof(XmlDocument)
		}, ReturnType = typeof(XmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		internal static void NestTextNodes(XmlNode prevNode, XmlNode nextNode)
		{
			throw null;
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x00003F1A File Offset: 0x0000211A
		[global::Cpp2ILInjected.Token(Token = "0x60005F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D990CC", Offset = "0x1D990CC", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal static void UnnestTextNodes(XmlNode prevNode, XmlNode nextNode)
		{
			throw null;
		}

		// Token: 0x040001F5 RID: 501
		[global::Cpp2ILInjected.Token(Token = "0x40002F2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal XmlNode parentNode;
	}
}
