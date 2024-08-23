using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x02000043 RID: 67
	[global::Cpp2ILInjected.Token(Token = "0x2000060")]
	public sealed class XmlWriterSettings
	{
		// Token: 0x060003C3 RID: 963 RVA: 0x00003A16 File Offset: 0x00001C16
		[global::Cpp2ILInjected.Token(Token = "0x600043B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D89FFC", Offset = "0x1D89FFC", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWriter), Member = "Create", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(XmlWriterSettings)
		}, ReturnType = typeof(XmlWriter))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWriter), Member = "Create", MemberParameters = new object[]
		{
			typeof(TextWriter),
			typeof(XmlWriterSettings)
		}, ReturnType = typeof(XmlWriter))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Linq.XAttribute", Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Linq.XNode", Member = "GetXmlString", MemberParameters = new object[] { "System.Xml.Linq.SaveOptions" }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWriterSettings), Member = "Initialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public XmlWriterSettings()
		{
			throw null;
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060003C4 RID: 964 RVA: 0x00003A19 File Offset: 0x00001C19
		[global::Cpp2ILInjected.Token(Token = "0x170000C9")]
		public bool Async
		{
			[global::Cpp2ILInjected.Token(Token = "0x600043C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8A928", Offset = "0x1D8A928", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060003C5 RID: 965 RVA: 0x00003A1C File Offset: 0x00001C1C
		[global::Cpp2ILInjected.Token(Token = "0x170000CA")]
		public Encoding Encoding
		{
			[global::Cpp2ILInjected.Token(Token = "0x600043D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8A930", Offset = "0x1D8A930", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060003C6 RID: 966 RVA: 0x00003A1F File Offset: 0x00001C1F
		// (set) Token: 0x060003C7 RID: 967 RVA: 0x00003A22 File Offset: 0x00001C22
		[global::Cpp2ILInjected.Token(Token = "0x170000CB")]
		public bool OmitXmlDeclaration
		{
			[global::Cpp2ILInjected.Token(Token = "0x600043E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8A938", Offset = "0x1D8A938", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600043F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8A940", Offset = "0x1D8A940", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Linq.XNode", Member = "GetXmlString", MemberParameters = new object[] { "System.Xml.Linq.SaveOptions" }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWriterSettings), Member = "CheckReadOnly", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060003C8 RID: 968 RVA: 0x00003A25 File Offset: 0x00001C25
		[global::Cpp2ILInjected.Token(Token = "0x170000CC")]
		public NewLineHandling NewLineHandling
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000440")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8AA44", Offset = "0x1D8AA44", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060003C9 RID: 969 RVA: 0x00003A28 File Offset: 0x00001C28
		[global::Cpp2ILInjected.Token(Token = "0x170000CD")]
		public string NewLineChars
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000441")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8AA4C", Offset = "0x1D8AA4C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060003CA RID: 970 RVA: 0x00003A2B File Offset: 0x00001C2B
		// (set) Token: 0x060003CB RID: 971 RVA: 0x00003A2E File Offset: 0x00001C2E
		[global::Cpp2ILInjected.Token(Token = "0x170000CE")]
		public bool Indent
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000442")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8AA54", Offset = "0x1D8AA54", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000443")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8AA64", Offset = "0x1D8AA64", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAutoDetectWriter), Member = "CreateWrappedWriter", MemberParameters = new object[] { typeof(XmlOutputMethod) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Linq.XNode", Member = "GetXmlString", MemberParameters = new object[] { "System.Xml.Linq.SaveOptions" }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWriterSettings), Member = "CheckReadOnly", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060003CC RID: 972 RVA: 0x00003A31 File Offset: 0x00001C31
		[global::Cpp2ILInjected.Token(Token = "0x170000CF")]
		public string IndentChars
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000444")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8AAC4", Offset = "0x1D8AAC4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060003CD RID: 973 RVA: 0x00003A34 File Offset: 0x00001C34
		[global::Cpp2ILInjected.Token(Token = "0x170000D0")]
		public bool NewLineOnAttributes
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000445")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8AACC", Offset = "0x1D8AACC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060003CE RID: 974 RVA: 0x00003A37 File Offset: 0x00001C37
		[global::Cpp2ILInjected.Token(Token = "0x170000D1")]
		public bool CloseOutput
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000446")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8AAD4", Offset = "0x1D8AAD4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060003CF RID: 975 RVA: 0x00003A3A File Offset: 0x00001C3A
		// (set) Token: 0x060003D0 RID: 976 RVA: 0x00003A3D File Offset: 0x00001C3D
		[global::Cpp2ILInjected.Token(Token = "0x170000D2")]
		public ConformanceLevel ConformanceLevel
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000447")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8AADC", Offset = "0x1D8AADC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000448")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8AAE4", Offset = "0x1D8AAE4", Length = "0xAC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Linq.XAttribute", Member = "ToString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Linq.XNode", Member = "GetXmlString", MemberParameters = new object[] { "System.Xml.Linq.SaveOptions" }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWriterSettings), Member = "CheckReadOnly", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060003D1 RID: 977 RVA: 0x00003A40 File Offset: 0x00001C40
		[global::Cpp2ILInjected.Token(Token = "0x170000D3")]
		public bool CheckCharacters
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000449")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8AB90", Offset = "0x1D8AB90", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060003D2 RID: 978 RVA: 0x00003A43 File Offset: 0x00001C43
		// (set) Token: 0x060003D3 RID: 979 RVA: 0x00003A46 File Offset: 0x00001C46
		[global::Cpp2ILInjected.Token(Token = "0x170000D4")]
		public NamespaceHandling NamespaceHandling
		{
			[global::Cpp2ILInjected.Token(Token = "0x600044A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8AB98", Offset = "0x1D8AB98", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600044B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8ABA0", Offset = "0x1D8ABA0", Length = "0xAC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Linq.XNode", Member = "GetXmlString", MemberParameters = new object[] { "System.Xml.Linq.SaveOptions" }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWriterSettings), Member = "CheckReadOnly", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060003D4 RID: 980 RVA: 0x00003A49 File Offset: 0x00001C49
		[global::Cpp2ILInjected.Token(Token = "0x170000D5")]
		public bool WriteEndDocumentOnClose
		{
			[global::Cpp2ILInjected.Token(Token = "0x600044C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8AC4C", Offset = "0x1D8AC4C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060003D5 RID: 981 RVA: 0x00003A4C File Offset: 0x00001C4C
		// (set) Token: 0x060003D6 RID: 982 RVA: 0x00003A4F File Offset: 0x00001C4F
		[global::Cpp2ILInjected.Token(Token = "0x170000D6")]
		public XmlOutputMethod OutputMethod
		{
			[global::Cpp2ILInjected.Token(Token = "0x600044D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8AC54", Offset = "0x1D8AC54", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600044E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8AC5C", Offset = "0x1D8AC5C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal set
			{
				throw null;
			}
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x00003A52 File Offset: 0x00001C52
		[global::Cpp2ILInjected.Token(Token = "0x600044F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8AC64", Offset = "0x1D8AC64", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAutoDetectWriter), Member = ".ctor", MemberParameters = new object[] { typeof(XmlWriterSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "MemberwiseClone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public XmlWriterSettings Clone()
		{
			throw null;
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060003D8 RID: 984 RVA: 0x00003A55 File Offset: 0x00001C55
		[global::Cpp2ILInjected.Token(Token = "0x170000D7")]
		internal List<XmlQualifiedName> CDataSectionElements
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000450")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8AD24", Offset = "0x1D8AD24", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060003D9 RID: 985 RVA: 0x00003A58 File Offset: 0x00001C58
		[global::Cpp2ILInjected.Token(Token = "0x170000D8")]
		public bool DoNotEscapeUriAttributes
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000451")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8AD2C", Offset = "0x1D8AD2C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060003DA RID: 986 RVA: 0x00003A5B File Offset: 0x00001C5B
		[global::Cpp2ILInjected.Token(Token = "0x170000D9")]
		internal bool MergeCDataSections
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000452")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8AD34", Offset = "0x1D8AD34", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060003DB RID: 987 RVA: 0x00003A5E File Offset: 0x00001C5E
		[global::Cpp2ILInjected.Token(Token = "0x170000DA")]
		internal string MediaType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000453")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8AD3C", Offset = "0x1D8AD3C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060003DC RID: 988 RVA: 0x00003A61 File Offset: 0x00001C61
		[global::Cpp2ILInjected.Token(Token = "0x170000DB")]
		internal string DocTypeSystem
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000454")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8AD44", Offset = "0x1D8AD44", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060003DD RID: 989 RVA: 0x00003A64 File Offset: 0x00001C64
		[global::Cpp2ILInjected.Token(Token = "0x170000DC")]
		internal string DocTypePublic
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000455")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8AD4C", Offset = "0x1D8AD4C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060003DE RID: 990 RVA: 0x00003A67 File Offset: 0x00001C67
		[global::Cpp2ILInjected.Token(Token = "0x170000DD")]
		internal XmlStandalone Standalone
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000456")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8AD54", Offset = "0x1D8AD54", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060003DF RID: 991 RVA: 0x00003A6A File Offset: 0x00001C6A
		[global::Cpp2ILInjected.Token(Token = "0x170000DE")]
		internal bool AutoXmlDeclaration
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000457")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8AD5C", Offset = "0x1D8AD5C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060003E0 RID: 992 RVA: 0x00003A6D File Offset: 0x00001C6D
		[global::Cpp2ILInjected.Token(Token = "0x170000DF")]
		internal TriState IndentInternal
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000458")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8AD64", Offset = "0x1D8AD64", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060003E1 RID: 993 RVA: 0x00003A70 File Offset: 0x00001C70
		[global::Cpp2ILInjected.Token(Token = "0x170000E0")]
		internal bool IsQuerySpecific
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000459")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8AD6C", Offset = "0x1D8AD6C", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWriterSettings), Member = "CreateWriter", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(XmlWriter))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWriterSettings), Member = "CreateWriter", MemberParameters = new object[] { typeof(TextWriter) }, ReturnType = typeof(XmlWriter))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x00003A73 File Offset: 0x00001C73
		[global::Cpp2ILInjected.Token(Token = "0x600045A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8A080", Offset = "0x1D8A080", Length = "0x478")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsInvalidInstructions]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWriter), Member = "Create", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(XmlWriterSettings)
		}, ReturnType = typeof(XmlWriter))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(XmlWriterSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriterIndent), Member = "Init", MemberParameters = new object[] { typeof(XmlWriterSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriterIndent), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(XmlWriterSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAutoDetectWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(XmlWriterSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextUtf8RawTextWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(XmlWriterSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HtmlEncodedRawTextWriterIndent), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(XmlWriterSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextEncodedRawTextWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(XmlWriterSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HtmlUtf8RawTextWriterIndent), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(XmlWriterSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HtmlEncodedRawTextWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(XmlWriterSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(XmlWriterSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HtmlUtf8RawTextWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(XmlWriterSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWriterSettings), Member = "get_IsQuerySpecific", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(QueryOutputWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(XmlRawWriter),
			typeof(XmlWriterSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(XmlWriter),
			typeof(XmlWriterSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAsyncCheckWriter), Member = ".ctor", MemberParameters = new object[] { typeof(XmlWriter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 38)]
		internal XmlWriter CreateWriter(Stream output)
		{
			throw null;
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x00003A76 File Offset: 0x00001C76
		[global::Cpp2ILInjected.Token(Token = "0x600045B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8A558", Offset = "0x1D8A558", Length = "0x2F8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriterIndent), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(TextWriter),
			typeof(XmlWriterSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextEncodedRawTextWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(TextWriter),
			typeof(XmlWriterSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAutoDetectWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(TextWriter),
			typeof(XmlWriterSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HtmlEncodedRawTextWriterIndent), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(TextWriter),
			typeof(XmlWriterSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(TextWriter),
			typeof(XmlWriterSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HtmlEncodedRawTextWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(TextWriter),
			typeof(XmlWriterSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWriterSettings), Member = "get_IsQuerySpecific", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(QueryOutputWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(XmlRawWriter),
			typeof(XmlWriterSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(XmlWriter),
			typeof(XmlWriterSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAsyncCheckWriter), Member = ".ctor", MemberParameters = new object[] { typeof(XmlWriter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 26)]
		internal XmlWriter CreateWriter(TextWriter output)
		{
			throw null;
		}

		// Token: 0x170000C0 RID: 192
		// (set) Token: 0x060003E4 RID: 996 RVA: 0x00003A79 File Offset: 0x00001C79
		[global::Cpp2ILInjected.Token(Token = "0x170000E1")]
		internal bool ReadOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x600045C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8ADD4", Offset = "0x1D8ADD4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x00003A7C File Offset: 0x00001C7C
		[global::Cpp2ILInjected.Token(Token = "0x600045D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8A99C", Offset = "0x1D8A99C", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWriterSettings), Member = "set_OmitXmlDeclaration", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWriterSettings), Member = "set_Indent", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWriterSettings), Member = "set_ConformanceLevel", MemberParameters = new object[] { typeof(ConformanceLevel) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWriterSettings), Member = "set_NamespaceHandling", MemberParameters = new object[] { typeof(NamespaceHandling) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void CheckReadOnly(string propertyName)
		{
			throw null;
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x00003A7F File Offset: 0x00001C7F
		[global::Cpp2ILInjected.Token(Token = "0x600045E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8A850", Offset = "0x1D8A850", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWriterSettings), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "get_NewLine", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void Initialize()
		{
			throw null;
		}

		// Token: 0x04000177 RID: 375
		[global::Cpp2ILInjected.Token(Token = "0x4000271")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private bool useAsync;

		// Token: 0x04000178 RID: 376
		[global::Cpp2ILInjected.Token(Token = "0x4000272")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private Encoding encoding;

		// Token: 0x04000179 RID: 377
		[global::Cpp2ILInjected.Token(Token = "0x4000273")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private bool omitXmlDecl;

		// Token: 0x0400017A RID: 378
		[global::Cpp2ILInjected.Token(Token = "0x4000274")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private NewLineHandling newLineHandling;

		// Token: 0x0400017B RID: 379
		[global::Cpp2ILInjected.Token(Token = "0x4000275")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private string newLineChars;

		// Token: 0x0400017C RID: 380
		[global::Cpp2ILInjected.Token(Token = "0x4000276")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private TriState indent;

		// Token: 0x0400017D RID: 381
		[global::Cpp2ILInjected.Token(Token = "0x4000277")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private string indentChars;

		// Token: 0x0400017E RID: 382
		[global::Cpp2ILInjected.Token(Token = "0x4000278")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private bool newLineOnAttributes;

		// Token: 0x0400017F RID: 383
		[global::Cpp2ILInjected.Token(Token = "0x4000279")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x41")]
		private bool closeOutput;

		// Token: 0x04000180 RID: 384
		[global::Cpp2ILInjected.Token(Token = "0x400027A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		private NamespaceHandling namespaceHandling;

		// Token: 0x04000181 RID: 385
		[global::Cpp2ILInjected.Token(Token = "0x400027B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private ConformanceLevel conformanceLevel;

		// Token: 0x04000182 RID: 386
		[global::Cpp2ILInjected.Token(Token = "0x400027C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
		private bool checkCharacters;

		// Token: 0x04000183 RID: 387
		[global::Cpp2ILInjected.Token(Token = "0x400027D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4D")]
		private bool writeEndDocumentOnClose;

		// Token: 0x04000184 RID: 388
		[global::Cpp2ILInjected.Token(Token = "0x400027E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private XmlOutputMethod outputMethod;

		// Token: 0x04000185 RID: 389
		[global::Cpp2ILInjected.Token(Token = "0x400027F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private List<XmlQualifiedName> cdataSections;

		// Token: 0x04000186 RID: 390
		[global::Cpp2ILInjected.Token(Token = "0x4000280")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private bool doNotEscapeUriAttributes;

		// Token: 0x04000187 RID: 391
		[global::Cpp2ILInjected.Token(Token = "0x4000281")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x61")]
		private bool mergeCDataSections;

		// Token: 0x04000188 RID: 392
		[global::Cpp2ILInjected.Token(Token = "0x4000282")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private string mediaType;

		// Token: 0x04000189 RID: 393
		[global::Cpp2ILInjected.Token(Token = "0x4000283")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private string docTypeSystem;

		// Token: 0x0400018A RID: 394
		[global::Cpp2ILInjected.Token(Token = "0x4000284")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private string docTypePublic;

		// Token: 0x0400018B RID: 395
		[global::Cpp2ILInjected.Token(Token = "0x4000285")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private XmlStandalone standalone;

		// Token: 0x0400018C RID: 396
		[global::Cpp2ILInjected.Token(Token = "0x4000286")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x84")]
		private bool autoXmlDecl;

		// Token: 0x0400018D RID: 397
		[global::Cpp2ILInjected.Token(Token = "0x4000287")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x85")]
		private bool isReadOnly;
	}
}
