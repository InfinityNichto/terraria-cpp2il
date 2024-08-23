using System;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x02000034 RID: 52
	[global::Cpp2ILInjected.Token(Token = "0x2000037")]
	public class XmlParserContext
	{
		// Token: 0x060001C4 RID: 452 RVA: 0x0000349D File Offset: 0x0000169D
		[global::Cpp2ILInjected.Token(Token = "0x60001D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D675F4", Offset = "0x1D675F4", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "ParseDocumentType", MemberParameters = new object[]
		{
			typeof(XmlDocumentType),
			typeof(bool),
			typeof(XmlResolver)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "GetContext", MemberParameters = new object[] { typeof(XmlNode) }, ReturnType = typeof(XmlParserContext))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlParserContext), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(XmlNameTable),
			typeof(XmlNamespaceManager),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(XmlSpace),
			typeof(Encoding)
		}, ReturnType = typeof(void))]
		public XmlParserContext(XmlNameTable nt, XmlNamespaceManager nsMgr, string docTypeName, string pubId, string sysId, string internalSubset, string baseURI, string xmlLang, XmlSpace xmlSpace)
		{
			throw null;
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x000034A0 File Offset: 0x000016A0
		[global::Cpp2ILInjected.Token(Token = "0x60001D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D67620", Offset = "0x1D67620", Length = "0x1B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlParserContext), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(XmlNameTable),
			typeof(XmlNamespaceManager),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(XmlSpace)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public XmlParserContext(XmlNameTable nt, XmlNamespaceManager nsMgr, string docTypeName, string pubId, string sysId, string internalSubset, string baseURI, string xmlLang, XmlSpace xmlSpace, Encoding enc)
		{
			throw null;
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x000034A3 File Offset: 0x000016A3
		[global::Cpp2ILInjected.Token(Token = "0x17000040")]
		public XmlNameTable NameTable
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001D3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D677D8", Offset = "0x1D677D8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060001C7 RID: 455 RVA: 0x000034A6 File Offset: 0x000016A6
		[global::Cpp2ILInjected.Token(Token = "0x17000041")]
		public XmlNamespaceManager NamespaceManager
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001D4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D677E0", Offset = "0x1D677E0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x000034A9 File Offset: 0x000016A9
		[global::Cpp2ILInjected.Token(Token = "0x17000042")]
		public string DocTypeName
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001D5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D677E8", Offset = "0x1D677E8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x000034AC File Offset: 0x000016AC
		[global::Cpp2ILInjected.Token(Token = "0x17000043")]
		public string PublicId
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001D6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D677F0", Offset = "0x1D677F0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060001CA RID: 458 RVA: 0x000034AF File Offset: 0x000016AF
		[global::Cpp2ILInjected.Token(Token = "0x17000044")]
		public string SystemId
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001D7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D677F8", Offset = "0x1D677F8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060001CB RID: 459 RVA: 0x000034B2 File Offset: 0x000016B2
		[global::Cpp2ILInjected.Token(Token = "0x17000045")]
		public string BaseURI
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001D8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D67800", Offset = "0x1D67800", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060001CC RID: 460 RVA: 0x000034B5 File Offset: 0x000016B5
		[global::Cpp2ILInjected.Token(Token = "0x17000046")]
		public string InternalSubset
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001D9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D67808", Offset = "0x1D67808", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060001CD RID: 461 RVA: 0x000034B8 File Offset: 0x000016B8
		[global::Cpp2ILInjected.Token(Token = "0x17000047")]
		public string XmlLang
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001DA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D67810", Offset = "0x1D67810", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060001CE RID: 462 RVA: 0x000034BB File Offset: 0x000016BB
		[global::Cpp2ILInjected.Token(Token = "0x17000048")]
		public XmlSpace XmlSpace
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001DB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D67818", Offset = "0x1D67818", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060001CF RID: 463 RVA: 0x000034BE File Offset: 0x000016BE
		[global::Cpp2ILInjected.Token(Token = "0x17000049")]
		public Encoding Encoding
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001DC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D67820", Offset = "0x1D67820", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060001D0 RID: 464 RVA: 0x000034C1 File Offset: 0x000016C1
		[global::Cpp2ILInjected.Token(Token = "0x1700004A")]
		internal bool HasDtdInfo
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001DD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D67828", Offset = "0x1D67828", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishInitUriString", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishInitStream", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishInitTextReader", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "HandleGeneralEntityReference", MemberParameters = new object[]
			{
				typeof(string),
				typeof(bool),
				typeof(bool),
				typeof(int)
			}, ReturnType = "System.Xml.XmlTextReaderImpl.EntityType")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
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

		// Token: 0x040000B3 RID: 179
		[global::Cpp2ILInjected.Token(Token = "0x40000D3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private XmlNameTable _nt;

		// Token: 0x040000B4 RID: 180
		[global::Cpp2ILInjected.Token(Token = "0x40000D4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private XmlNamespaceManager _nsMgr;

		// Token: 0x040000B5 RID: 181
		[global::Cpp2ILInjected.Token(Token = "0x40000D5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string _docTypeName;

		// Token: 0x040000B6 RID: 182
		[global::Cpp2ILInjected.Token(Token = "0x40000D6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private string _pubId;

		// Token: 0x040000B7 RID: 183
		[global::Cpp2ILInjected.Token(Token = "0x40000D7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private string _sysId;

		// Token: 0x040000B8 RID: 184
		[global::Cpp2ILInjected.Token(Token = "0x40000D8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private string _internalSubset;

		// Token: 0x040000B9 RID: 185
		[global::Cpp2ILInjected.Token(Token = "0x40000D9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private string _xmlLang;

		// Token: 0x040000BA RID: 186
		[global::Cpp2ILInjected.Token(Token = "0x40000DA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private XmlSpace _xmlSpace;

		// Token: 0x040000BB RID: 187
		[global::Cpp2ILInjected.Token(Token = "0x40000DB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private string _baseURI;

		// Token: 0x040000BC RID: 188
		[global::Cpp2ILInjected.Token(Token = "0x40000DC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private Encoding _encoding;
	}
}
