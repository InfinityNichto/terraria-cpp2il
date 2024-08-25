using System;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	[global::Cpp2ILInjected.Token(Token = "0x2000037")]
	public class XmlParserContext
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x40000D3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private XmlNameTable _nt;

		[global::Cpp2ILInjected.Token(Token = "0x40000D4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private XmlNamespaceManager _nsMgr;

		[global::Cpp2ILInjected.Token(Token = "0x40000D5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string _docTypeName;

		[global::Cpp2ILInjected.Token(Token = "0x40000D6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private string _pubId;

		[global::Cpp2ILInjected.Token(Token = "0x40000D7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private string _sysId;

		[global::Cpp2ILInjected.Token(Token = "0x40000D8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private string _internalSubset;

		[global::Cpp2ILInjected.Token(Token = "0x40000D9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private string _xmlLang;

		[global::Cpp2ILInjected.Token(Token = "0x40000DA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private XmlSpace _xmlSpace;

		[global::Cpp2ILInjected.Token(Token = "0x40000DB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private string _baseURI;

		[global::Cpp2ILInjected.Token(Token = "0x40000DC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private Encoding _encoding;
	}
}
