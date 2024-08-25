using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	[global::Cpp2ILInjected.Token(Token = "0x2000132")]
	internal sealed class SchemaEntity : IDtdEntityInfo
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000A61")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCB44C", Offset = "0x1DCB44C", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "HandleGeneralEntityReference", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(bool),
			typeof(int)
		}, ReturnType = "System.Xml.XmlTextReaderImpl.EntityType")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseEntityDecl", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal SchemaEntity(XmlQualifiedName qname, bool isParameter)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002DC")]
		private string System.Xml.IDtdEntityInfo.Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A62")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCB4D0", Offset = "0x1DCB4D0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002DD")]
		private bool System.Xml.IDtdEntityInfo.IsExternal
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A63")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCB4DC", Offset = "0x1DCB4DC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002DE")]
		private bool System.Xml.IDtdEntityInfo.IsDeclaredInExternal
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A64")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCB4E4", Offset = "0x1DCB4E4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002DF")]
		private bool System.Xml.IDtdEntityInfo.IsUnparsedEntity
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A65")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCB4EC", Offset = "0x1DCB4EC", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlQualifiedName), Member = "get_IsEmpty", ReturnType = typeof(bool))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002E0")]
		private bool System.Xml.IDtdEntityInfo.IsParameterEntity
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A66")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCB50C", Offset = "0x1DCB50C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002E1")]
		private string System.Xml.IDtdEntityInfo.BaseUriString
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A67")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCB514", Offset = "0x1DCB514", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002E2")]
		private string System.Xml.IDtdEntityInfo.DeclaredUriString
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A68")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCB5BC", Offset = "0x1DCB5BC", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002E3")]
		private string System.Xml.IDtdEntityInfo.SystemId
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A69")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCB664", Offset = "0x1DCB664", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002E4")]
		private string System.Xml.IDtdEntityInfo.PublicId
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A6A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCB66C", Offset = "0x1DCB66C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002E5")]
		private string System.Xml.IDtdEntityInfo.Text
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A6B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCB674", Offset = "0x1DCB674", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002E6")]
		private int System.Xml.IDtdEntityInfo.LineNumber
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A6C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCB67C", Offset = "0x1DCB67C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002E7")]
		private int System.Xml.IDtdEntityInfo.LinePosition
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A6D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCB684", Offset = "0x1DCB684", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002E8")]
		internal XmlQualifiedName Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A6E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCB68C", Offset = "0x1DCB68C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002E9")]
		internal string Url
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A6F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCB694", Offset = "0x1DCB694", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000A70")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCB69C", Offset = "0x1DCB69C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseEntityDecl", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002EA")]
		internal string Pubid
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A71")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCB6AC", Offset = "0x1DCB6AC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000A72")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCB6B4", Offset = "0x1DCB6B4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002EB")]
		internal bool IsExternal
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A73")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCB6BC", Offset = "0x1DCB6BC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000A74")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCB6C4", Offset = "0x1DCB6C4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002EC")]
		internal bool DeclaredInExternal
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A75")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCB6D0", Offset = "0x1DCB6D0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000A76")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCB6D8", Offset = "0x1DCB6D8", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002ED")]
		internal XmlQualifiedName NData
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A77")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCB6E4", Offset = "0x1DCB6E4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000A78")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCB6EC", Offset = "0x1DCB6EC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002EE")]
		internal string Text
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A79")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCB6F4", Offset = "0x1DCB6F4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000A7A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCB6FC", Offset = "0x1DCB6FC", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "HandleGeneralEntityReference", MemberParameters = new object[]
			{
				typeof(string),
				typeof(bool),
				typeof(bool),
				typeof(int)
			}, ReturnType = "System.Xml.XmlTextReaderImpl.EntityType")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseEntityDecl", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002EF")]
		internal int Line
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A7B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCB708", Offset = "0x1DCB708", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000A7C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCB710", Offset = "0x1DCB710", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002F0")]
		internal int Pos
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A7D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCB718", Offset = "0x1DCB718", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000A7E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCB720", Offset = "0x1DCB720", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002F1")]
		internal string BaseURI
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A7F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCB568", Offset = "0x1DCB568", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000A80")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCB728", Offset = "0x1DCB728", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002F2")]
		internal bool ParsingInProgress
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A81")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCB730", Offset = "0x1DCB730", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000A82")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCB738", Offset = "0x1DCB738", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002F3")]
		internal string DeclaredURI
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A83")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCB610", Offset = "0x1DCB610", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "LoadDocumentType", MemberParameters = new object[]
			{
				typeof(IDtdInfo),
				typeof(XmlDocumentType)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000A84")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCB744", Offset = "0x1DCB744", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x400053F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private XmlQualifiedName qname;

		[global::Cpp2ILInjected.Token(Token = "0x4000540")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string url;

		[global::Cpp2ILInjected.Token(Token = "0x4000541")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string pubid;

		[global::Cpp2ILInjected.Token(Token = "0x4000542")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private string text;

		[global::Cpp2ILInjected.Token(Token = "0x4000543")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private XmlQualifiedName ndata;

		[global::Cpp2ILInjected.Token(Token = "0x4000544")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private int lineNumber;

		[global::Cpp2ILInjected.Token(Token = "0x4000545")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		private int linePosition;

		[global::Cpp2ILInjected.Token(Token = "0x4000546")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private bool isParameter;

		[global::Cpp2ILInjected.Token(Token = "0x4000547")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x41")]
		private bool isExternal;

		[global::Cpp2ILInjected.Token(Token = "0x4000548")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x42")]
		private bool parsingInProgress;

		[global::Cpp2ILInjected.Token(Token = "0x4000549")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x43")]
		private bool isDeclaredInExternal;

		[global::Cpp2ILInjected.Token(Token = "0x400054A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private string baseURI;

		[global::Cpp2ILInjected.Token(Token = "0x400054B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private string declaredURI;
	}
}
