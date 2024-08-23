using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x02000102 RID: 258
	[global::Cpp2ILInjected.Token(Token = "0x2000132")]
	internal sealed class SchemaEntity : IDtdEntityInfo
	{
		// Token: 0x060009CA RID: 2506 RVA: 0x00004BA1 File Offset: 0x00002DA1
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

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x060009CB RID: 2507 RVA: 0x00004BA4 File Offset: 0x00002DA4
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

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x060009CC RID: 2508 RVA: 0x00004BA7 File Offset: 0x00002DA7
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

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x060009CD RID: 2509 RVA: 0x00004BAA File Offset: 0x00002DAA
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

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x060009CE RID: 2510 RVA: 0x00004BAD File Offset: 0x00002DAD
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

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x060009CF RID: 2511 RVA: 0x00004BB0 File Offset: 0x00002DB0
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

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x060009D0 RID: 2512 RVA: 0x00004BB3 File Offset: 0x00002DB3
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

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x060009D1 RID: 2513 RVA: 0x00004BB6 File Offset: 0x00002DB6
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

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x060009D2 RID: 2514 RVA: 0x00004BB9 File Offset: 0x00002DB9
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

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x060009D3 RID: 2515 RVA: 0x00004BBC File Offset: 0x00002DBC
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

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x060009D4 RID: 2516 RVA: 0x00004BBF File Offset: 0x00002DBF
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

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x060009D5 RID: 2517 RVA: 0x00004BC2 File Offset: 0x00002DC2
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

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x060009D6 RID: 2518 RVA: 0x00004BC5 File Offset: 0x00002DC5
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

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x060009D7 RID: 2519 RVA: 0x00004BC8 File Offset: 0x00002DC8
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

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x060009D8 RID: 2520 RVA: 0x00004BCB File Offset: 0x00002DCB
		// (set) Token: 0x060009D9 RID: 2521 RVA: 0x00004BCE File Offset: 0x00002DCE
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

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x060009DA RID: 2522 RVA: 0x00004BD1 File Offset: 0x00002DD1
		// (set) Token: 0x060009DB RID: 2523 RVA: 0x00004BD4 File Offset: 0x00002DD4
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

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x060009DC RID: 2524 RVA: 0x00004BD7 File Offset: 0x00002DD7
		// (set) Token: 0x060009DD RID: 2525 RVA: 0x00004BDA File Offset: 0x00002DDA
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

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x060009DE RID: 2526 RVA: 0x00004BDD File Offset: 0x00002DDD
		// (set) Token: 0x060009DF RID: 2527 RVA: 0x00004BE0 File Offset: 0x00002DE0
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

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x060009E0 RID: 2528 RVA: 0x00004BE3 File Offset: 0x00002DE3
		// (set) Token: 0x060009E1 RID: 2529 RVA: 0x00004BE6 File Offset: 0x00002DE6
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

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x060009E2 RID: 2530 RVA: 0x00004BE9 File Offset: 0x00002DE9
		// (set) Token: 0x060009E3 RID: 2531 RVA: 0x00004BEC File Offset: 0x00002DEC
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

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x060009E4 RID: 2532 RVA: 0x00004BEF File Offset: 0x00002DEF
		// (set) Token: 0x060009E5 RID: 2533 RVA: 0x00004BF2 File Offset: 0x00002DF2
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

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x060009E6 RID: 2534 RVA: 0x00004BF5 File Offset: 0x00002DF5
		// (set) Token: 0x060009E7 RID: 2535 RVA: 0x00004BF8 File Offset: 0x00002DF8
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

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x060009E8 RID: 2536 RVA: 0x00004BFB File Offset: 0x00002DFB
		// (set) Token: 0x060009E9 RID: 2537 RVA: 0x00004BFE File Offset: 0x00002DFE
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

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x060009EA RID: 2538 RVA: 0x00004C01 File Offset: 0x00002E01
		// (set) Token: 0x060009EB RID: 2539 RVA: 0x00004C04 File Offset: 0x00002E04
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

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x060009EC RID: 2540 RVA: 0x00004C07 File Offset: 0x00002E07
		// (set) Token: 0x060009ED RID: 2541 RVA: 0x00004C0A File Offset: 0x00002E0A
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

		// Token: 0x040003B7 RID: 951
		[global::Cpp2ILInjected.Token(Token = "0x400053F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private XmlQualifiedName qname;

		// Token: 0x040003B8 RID: 952
		[global::Cpp2ILInjected.Token(Token = "0x4000540")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string url;

		// Token: 0x040003B9 RID: 953
		[global::Cpp2ILInjected.Token(Token = "0x4000541")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string pubid;

		// Token: 0x040003BA RID: 954
		[global::Cpp2ILInjected.Token(Token = "0x4000542")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private string text;

		// Token: 0x040003BB RID: 955
		[global::Cpp2ILInjected.Token(Token = "0x4000543")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private XmlQualifiedName ndata;

		// Token: 0x040003BC RID: 956
		[global::Cpp2ILInjected.Token(Token = "0x4000544")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private int lineNumber;

		// Token: 0x040003BD RID: 957
		[global::Cpp2ILInjected.Token(Token = "0x4000545")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		private int linePosition;

		// Token: 0x040003BE RID: 958
		[global::Cpp2ILInjected.Token(Token = "0x4000546")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private bool isParameter;

		// Token: 0x040003BF RID: 959
		[global::Cpp2ILInjected.Token(Token = "0x4000547")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x41")]
		private bool isExternal;

		// Token: 0x040003C0 RID: 960
		[global::Cpp2ILInjected.Token(Token = "0x4000548")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x42")]
		private bool parsingInProgress;

		// Token: 0x040003C1 RID: 961
		[global::Cpp2ILInjected.Token(Token = "0x4000549")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x43")]
		private bool isDeclaredInExternal;

		// Token: 0x040003C2 RID: 962
		[global::Cpp2ILInjected.Token(Token = "0x400054A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private string baseURI;

		// Token: 0x040003C3 RID: 963
		[global::Cpp2ILInjected.Token(Token = "0x400054B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private string declaredURI;
	}
}
