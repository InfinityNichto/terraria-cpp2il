using System;
using System.Text;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x0200006C RID: 108
	[global::Cpp2ILInjected.Token(Token = "0x2000091")]
	internal struct XmlCharType
	{
		// Token: 0x17000193 RID: 403
		// (get) Token: 0x06000633 RID: 1587 RVA: 0x00004148 File Offset: 0x00002348
		[global::Cpp2ILInjected.Token(Token = "0x170001B7")]
		private static object StaticLock
		{
			[global::Cpp2ILInjected.Token(Token = "0x60006B8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DA62C8", Offset = "0x1DA62C8", Length = "0x94")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlCharType), Member = "InitInstance", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x0000414B File Offset: 0x0000234B
		[global::Cpp2ILInjected.Token(Token = "0x60006B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA635C", Offset = "0x1DA635C", Length = "0x260")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlCharType), Member = "get_Instance", ReturnType = typeof(XmlCharType))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "get_StaticLock", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "SetProperties", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(string),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "MemoryBarrier", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		private static void InitInstance()
		{
			throw null;
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x0000414E File Offset: 0x0000234E
		[global::Cpp2ILInjected.Token(Token = "0x60006BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA65BC", Offset = "0x1DA65BC", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlCharType), Member = "InitInstance", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		private static void SetProperties(byte[] chProps, string ranges, byte value)
		{
			throw null;
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x00004151 File Offset: 0x00002351
		[global::Cpp2ILInjected.Token(Token = "0x60006BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA6660", Offset = "0x1DA6660", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private XmlCharType(byte[] charProperties)
		{
			throw null;
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x06000637 RID: 1591 RVA: 0x00004154 File Offset: 0x00002354
		[global::Cpp2ILInjected.Token(Token = "0x170001B8")]
		public unsafe static XmlCharType Instance
		{
			[global::Cpp2ILInjected.Token(Token = "0x60006BC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DA5FC4", Offset = "0x1DA5FC4", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BinHexDecoder), Member = "Decode", MemberParameters = new object[]
			{
				typeof(char*),
				typeof(char*),
				typeof(byte*),
				typeof(byte*),
				typeof(ref bool),
				typeof(ref byte),
				typeof(ref int),
				typeof(ref int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAutoDetectWriter), Member = "TextBlockCreatesWriter", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = ".ctor", MemberParameters = new object[] { typeof(XmlWriterSettings) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new object[] { typeof(XmlNameTable) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUtf8RawTextWriter), Member = ".ctor", MemberParameters = new object[] { typeof(XmlWriterSettings) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlWellFormedWriter.AttributeValueCache", Member = "Trim", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWellFormedWriter), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(XmlWriter),
				typeof(XmlWriterSettings)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWellFormedWriter), Member = "WriteWhitespace", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlCharacterData), Member = "CheckOnData", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ValidateNames), Member = "ThrowInvalidName", MemberParameters = new object[]
			{
				typeof(string),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ValidateNames), Member = ".cctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlComplianceUtil), Member = "NonCDataNormalize", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlConvert), Member = ".cctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "InitInstance", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x00004157 File Offset: 0x00002357
		[global::Cpp2ILInjected.Token(Token = "0x60006BD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA6668", Offset = "0x1DA6668", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseEndElement", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseText", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDoctypeDecl", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "IncrementalRead", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueChunk", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlWellFormedWriter.AttributeValueCache", Member = "Trim", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new object[] { typeof(bool) }, ReturnType = "System.Xml.DtdParser.Token")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		public bool IsWhiteSpace(char ch)
		{
			throw null;
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x0000415A File Offset: 0x0000235A
		[global::Cpp2ILInjected.Token(Token = "0x60006BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA5FB0", Offset = "0x1DA5FB0", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseUnexpectedToken", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseUnexpectedToken", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		public bool IsNCNameSingleChar(char ch)
		{
			throw null;
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x0000415D File Offset: 0x0000235D
		[global::Cpp2ILInjected.Token(Token = "0x60006BF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA602C", Offset = "0x1DA602C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool IsStartNCNameSingleChar(char ch)
		{
			throw null;
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x00004160 File Offset: 0x00002360
		[global::Cpp2ILInjected.Token(Token = "0x60006C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA667C", Offset = "0x1DA667C", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseXmlDeclaration", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanCondSection1", ReturnType = "System.Xml.DtdParser.Token")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		public bool IsNameSingleChar(char ch)
		{
			throw null;
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x00004163 File Offset: 0x00002363
		[global::Cpp2ILInjected.Token(Token = "0x60006C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA66A0", Offset = "0x1DA66A0", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteCharEntity", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseRootLevelWhitespace", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseNumericCharRefInline", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool),
			typeof(StringBuilder),
			typeof(ref int),
			typeof(ref XmlTextReaderImpl.EntityType)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteCharEntity", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		public bool IsCharData(char ch)
		{
			throw null;
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x00004166 File Offset: 0x00002366
		[global::Cpp2ILInjected.Token(Token = "0x60006C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA66B4", Offset = "0x1DA66B4", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlCharType), Member = "IsPublicId", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public bool IsPubidChar(char ch)
		{
			throw null;
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x00004169 File Offset: 0x00002369
		[global::Cpp2ILInjected.Token(Token = "0x60006C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA6730", Offset = "0x1DA6730", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "ValidateContentChars", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUtf8RawTextWriter), Member = "ValidateContentChars", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		internal bool IsTextChar(char ch)
		{
			throw null;
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x0000416C File Offset: 0x0000236C
		[global::Cpp2ILInjected.Token(Token = "0x60006C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA6744", Offset = "0x1DA6744", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool IsLetter(char ch)
		{
			throw null;
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x0000416F File Offset: 0x0000236F
		[global::Cpp2ILInjected.Token(Token = "0x60006C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA6758", Offset = "0x1DA6758", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool IsNCNameCharXml4e(char ch)
		{
			throw null;
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x00004172 File Offset: 0x00002372
		[global::Cpp2ILInjected.Token(Token = "0x60006C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA676C", Offset = "0x1DA676C", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool IsStartNCNameCharXml4e(char ch)
		{
			throw null;
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x00004175 File Offset: 0x00002375
		[global::Cpp2ILInjected.Token(Token = "0x60006C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA6790", Offset = "0x1DA6790", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool IsNameCharXml4e(char ch)
		{
			throw null;
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x00004178 File Offset: 0x00002378
		[global::Cpp2ILInjected.Token(Token = "0x60006C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA67B4", Offset = "0x1DA67B4", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool IsDigit(char ch)
		{
			throw null;
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x0000417B File Offset: 0x0000237B
		[global::Cpp2ILInjected.Token(Token = "0x60006C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA67DC", Offset = "0x1DA67DC", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "ValidateContentChars", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueSlow", MemberParameters = new object[]
		{
			typeof(int),
			typeof(char),
			"System.Xml.XmlTextReaderImpl.NodeData"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseText", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParsePIValue", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseCDataOrComment", MemberParameters = new object[]
		{
			typeof(XmlNodeType),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "SkipUntil", MemberParameters = new object[]
		{
			typeof(char),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseNumericCharRefInline", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool),
			typeof(StringBuilder),
			typeof(ref int),
			typeof(ref XmlTextReaderImpl.EntityType)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueChunk", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUtf8RawTextWriter), Member = "ValidateContentChars", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanLiteral", MemberParameters = new object[] { "System.Xml.DtdParser.LiteralType" }, ReturnType = "System.Xml.DtdParser.Token")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanCondSection3", ReturnType = "System.Xml.DtdParser.Token")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		internal static bool IsHighSurrogate(int ch)
		{
			throw null;
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x0000417E File Offset: 0x0000237E
		[global::Cpp2ILInjected.Token(Token = "0x60006CA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA67EC", Offset = "0x1DA67EC", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "ValidateContentChars", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueSlow", MemberParameters = new object[]
		{
			typeof(int),
			typeof(char),
			"System.Xml.XmlTextReaderImpl.NodeData"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseText", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParsePIValue", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseCDataOrComment", MemberParameters = new object[]
		{
			typeof(XmlNodeType),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "SkipUntil", MemberParameters = new object[]
		{
			typeof(char),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseNumericCharRefInline", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool),
			typeof(StringBuilder),
			typeof(ref int),
			typeof(ref XmlTextReaderImpl.EntityType)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueChunk", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUtf8RawTextWriter), Member = "ValidateContentChars", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanLiteral", MemberParameters = new object[] { "System.Xml.DtdParser.LiteralType" }, ReturnType = "System.Xml.DtdParser.Token")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanCondSection3", ReturnType = "System.Xml.DtdParser.Token")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		internal static bool IsLowSurrogate(int ch)
		{
			throw null;
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x00004181 File Offset: 0x00002381
		[global::Cpp2ILInjected.Token(Token = "0x60006CB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA67FC", Offset = "0x1DA67FC", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteAttributeTextBlock", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteElementTextBlock", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "RawText", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteRawWithCharChecking", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteCommentOrPi", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteCDataSection", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "EncodeChar", MemberParameters = new object[]
		{
			typeof(ref char*),
			typeof(char*),
			typeof(ref char*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteAttributeTextBlock", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteElementTextBlock", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUtf8RawTextWriter), Member = "RawText", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteRawWithCharChecking", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteCommentOrPi", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteCDataSection", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUtf8RawTextWriter), Member = "EncodeChar", MemberParameters = new object[]
		{
			typeof(ref char*),
			typeof(char*),
			typeof(ref byte*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUtf8RawTextWriter), Member = "CharToUTF8", MemberParameters = new object[]
		{
			typeof(ref char*),
			typeof(char*),
			typeof(ref byte*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 15)]
		internal unsafe static bool IsSurrogate(int ch)
		{
			throw null;
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x00004184 File Offset: 0x00002384
		[global::Cpp2ILInjected.Token(Token = "0x60006CC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA680C", Offset = "0x1DA680C", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CharEntityEncoderFallbackBuffer), Member = "Fallback", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CharEntityEncoderFallbackBuffer), Member = "SurrogateCharToUtf32", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteSurrogateCharEntity", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteSurrogateCharEntity", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUtf8RawTextWriter), Member = "EncodeSurrogate", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*),
			typeof(byte*)
		}, ReturnType = typeof(byte*))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		internal unsafe static int CombineSurrogateChar(int lowChar, int highChar)
		{
			throw null;
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x00004187 File Offset: 0x00002387
		[global::Cpp2ILInjected.Token(Token = "0x60006CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA6824", Offset = "0x1DA6824", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseNumericCharRefInline", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool),
			typeof(StringBuilder),
			typeof(ref int),
			typeof(ref XmlTextReaderImpl.EntityType)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		internal static void SplitSurrogateChar(int combinedChar, out char lowChar, out char highChar)
		{
			throw null;
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x0000418A File Offset: 0x0000238A
		[global::Cpp2ILInjected.Token(Token = "0x60006CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA685C", Offset = "0x1DA685C", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAutoDetectWriter), Member = "TextBlockCreatesWriter", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "ValidateContentChars", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUtf8RawTextWriter), Member = "ValidateContentChars", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWellFormedWriter), Member = "WriteWhitespace", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlCharacterData), Member = "CheckOnData", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "IsOnlyWhitespaceWithPos", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		internal bool IsOnlyWhitespace(string str)
		{
			throw null;
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x0000418D File Offset: 0x0000238D
		[global::Cpp2ILInjected.Token(Token = "0x60006CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA6874", Offset = "0x1DA6874", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlCharType), Member = "IsOnlyWhitespace", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		internal int IsOnlyWhitespaceWithPos(string str)
		{
			throw null;
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x00004190 File Offset: 0x00002390
		[global::Cpp2ILInjected.Token(Token = "0x60006D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA68E4", Offset = "0x1DA68E4", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWellFormedWriter), Member = "WriteDocType", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "InitializeFreeFloatingDtd", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(IDtdParserAdapter)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		internal int IsOnlyCharData(string str)
		{
			throw null;
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x00004193 File Offset: 0x00002393
		[global::Cpp2ILInjected.Token(Token = "0x60006D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA69A4", Offset = "0x1DA69A4", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDeclaration), Member = "IsValidXmlVersion", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		internal static bool IsOnlyDigits(string str, int startPos, int len)
		{
			throw null;
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x00004196 File Offset: 0x00002396
		[global::Cpp2ILInjected.Token(Token = "0x60006D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA6A08", Offset = "0x1DA6A08", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWellFormedWriter), Member = "WriteDocType", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "InitializeFreeFloatingDtd", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(IDtdParserAdapter)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseExternalId", MemberParameters = new object[]
		{
			"System.Xml.DtdParser.Token",
			"System.Xml.DtdParser.Token",
			typeof(ref string),
			typeof(ref string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "IsPubidChar", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		internal int IsPublicId(string str)
		{
			throw null;
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x00004199 File Offset: 0x00002399
		[global::Cpp2ILInjected.Token(Token = "0x60006D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA67C8", Offset = "0x1DA67C8", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static bool InRange(int value, int start, int end)
		{
			throw null;
		}

		// Token: 0x04000238 RID: 568
		[global::Cpp2ILInjected.Token(Token = "0x4000396")]
		private static object s_Lock;

		// Token: 0x04000239 RID: 569
		[global::Cpp2ILInjected.Token(Token = "0x4000397")]
		private static byte[] s_CharProperties;

		// Token: 0x0400023A RID: 570
		[global::Cpp2ILInjected.Token(Token = "0x4000398")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		internal byte[] charProperties;
	}
}
