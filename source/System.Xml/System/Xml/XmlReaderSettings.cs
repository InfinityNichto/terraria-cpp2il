using System;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x02000037 RID: 55
	[global::Cpp2ILInjected.Token(Token = "0x200003A")]
	public sealed class XmlReaderSettings
	{
		// Token: 0x0600020D RID: 525 RVA: 0x0000353C File Offset: 0x0000173C
		[global::Cpp2ILInjected.Token(Token = "0x600021A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D68008", Offset = "0x1D68008", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlSchemaSet), Member = ".ctor", MemberParameters = new object[] { typeof(XmlNameTable) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlReaderSettings), Member = "Initialize", MemberParameters = new object[] { typeof(XmlResolver) }, ReturnType = typeof(void))]
		public XmlReaderSettings()
		{
			throw null;
		}

		// Token: 0x17000058 RID: 88
		// (set) Token: 0x0600020E RID: 526 RVA: 0x0000353F File Offset: 0x0000173F
		[global::Cpp2ILInjected.Token(Token = "0x1700005D")]
		public XmlNameTable NameTable
		{
			[global::Cpp2ILInjected.Token(Token = "0x600021B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D68030", Offset = "0x1D68030", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlSchemaSet), Member = ".ctor", MemberParameters = new object[] { typeof(XmlNameTable) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlReaderSettings), Member = "CheckReadOnly", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000059 RID: 89
		// (set) Token: 0x0600020F RID: 527 RVA: 0x00003542 File Offset: 0x00001742
		[global::Cpp2ILInjected.Token(Token = "0x1700005E")]
		internal bool IsXmlResolverSet
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600021C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D68134", Offset = "0x1D68134", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700005A RID: 90
		// (set) Token: 0x06000210 RID: 528 RVA: 0x00003545 File Offset: 0x00001745
		[global::Cpp2ILInjected.Token(Token = "0x1700005F")]
		public XmlResolver XmlResolver
		{
			[global::Cpp2ILInjected.Token(Token = "0x600021D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D68140", Offset = "0x1D68140", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlSchemaSet), Member = ".ctor", MemberParameters = new object[] { typeof(XmlNameTable) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlReaderSettings), Member = "CheckReadOnly", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00003548 File Offset: 0x00001748
		[global::Cpp2ILInjected.Token(Token = "0x600021E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D681A4", Offset = "0x1D681A4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal XmlResolver GetXmlResolver()
		{
			throw null;
		}

		// Token: 0x1700005B RID: 91
		// (set) Token: 0x06000212 RID: 530 RVA: 0x0000354B File Offset: 0x0000174B
		[global::Cpp2ILInjected.Token(Token = "0x17000060")]
		public int LineNumberOffset
		{
			[global::Cpp2ILInjected.Token(Token = "0x600021F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D681AC", Offset = "0x1D681AC", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlReaderSettings), Member = "CheckReadOnly", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700005C RID: 92
		// (set) Token: 0x06000213 RID: 531 RVA: 0x0000354E File Offset: 0x0000174E
		[global::Cpp2ILInjected.Token(Token = "0x17000061")]
		public int LinePositionOffset
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000220")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D68208", Offset = "0x1D68208", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlReaderSettings), Member = "CheckReadOnly", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700005D RID: 93
		// (set) Token: 0x06000214 RID: 532 RVA: 0x00003551 File Offset: 0x00001751
		[global::Cpp2ILInjected.Token(Token = "0x17000062")]
		public ConformanceLevel ConformanceLevel
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000221")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D68264", Offset = "0x1D68264", Length = "0xAC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlReaderSettings), Member = "CheckReadOnly", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700005E RID: 94
		// (set) Token: 0x06000215 RID: 533 RVA: 0x00003554 File Offset: 0x00001754
		[global::Cpp2ILInjected.Token(Token = "0x17000063")]
		public bool CheckCharacters
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000222")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D68310", Offset = "0x1D68310", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlReaderSettings), Member = "CheckReadOnly", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700005F RID: 95
		// (set) Token: 0x06000216 RID: 534 RVA: 0x00003557 File Offset: 0x00001757
		[global::Cpp2ILInjected.Token(Token = "0x17000064")]
		public long MaxCharactersInDocument
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000223")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D6836C", Offset = "0x1D6836C", Length = "0xA8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlReaderSettings), Member = "CheckReadOnly", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000060 RID: 96
		// (set) Token: 0x06000217 RID: 535 RVA: 0x0000355A File Offset: 0x0000175A
		[global::Cpp2ILInjected.Token(Token = "0x17000065")]
		public long MaxCharactersFromEntities
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000224")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D68414", Offset = "0x1D68414", Length = "0xA8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlReaderSettings), Member = "CheckReadOnly", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000061 RID: 97
		// (set) Token: 0x06000218 RID: 536 RVA: 0x0000355D File Offset: 0x0000175D
		[global::Cpp2ILInjected.Token(Token = "0x17000066")]
		public bool IgnoreWhitespace
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000225")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D684BC", Offset = "0x1D684BC", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlReaderSettings), Member = "CheckReadOnly", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000062 RID: 98
		// (set) Token: 0x06000219 RID: 537 RVA: 0x00003560 File Offset: 0x00001760
		[global::Cpp2ILInjected.Token(Token = "0x17000067")]
		public bool IgnoreProcessingInstructions
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000226")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D68518", Offset = "0x1D68518", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlReaderSettings), Member = "CheckReadOnly", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000063 RID: 99
		// (set) Token: 0x0600021A RID: 538 RVA: 0x00003563 File Offset: 0x00001763
		[global::Cpp2ILInjected.Token(Token = "0x17000068")]
		public bool IgnoreComments
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000227")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D68574", Offset = "0x1D68574", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlReaderSettings), Member = "CheckReadOnly", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000064 RID: 100
		// (set) Token: 0x0600021B RID: 539 RVA: 0x00003566 File Offset: 0x00001766
		[global::Cpp2ILInjected.Token(Token = "0x17000069")]
		public DtdProcessing DtdProcessing
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000228")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D685D0", Offset = "0x1D685D0", Length = "0xAC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlSchemaSet), Member = ".ctor", MemberParameters = new object[] { typeof(XmlNameTable) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlReaderSettings), Member = "CheckReadOnly", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600021C RID: 540 RVA: 0x00003569 File Offset: 0x00001769
		[global::Cpp2ILInjected.Token(Token = "0x1700006A")]
		public ValidationType ValidationType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000229")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D6867C", Offset = "0x1D6867C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600021D RID: 541 RVA: 0x0000356C File Offset: 0x0000176C
		[global::Cpp2ILInjected.Token(Token = "0x1700006B")]
		public XmlSchemaSet Schemas
		{
			[global::Cpp2ILInjected.Token(Token = "0x600022A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D68684", Offset = "0x1D68684", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "Load", MemberParameters = new object[]
			{
				typeof(XmlDocument),
				typeof(XmlReader),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaSet), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000067 RID: 103
		// (set) Token: 0x0600021E RID: 542 RVA: 0x0000356F File Offset: 0x0000176F
		[global::Cpp2ILInjected.Token(Token = "0x1700006C")]
		internal bool ReadOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x600022B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D686E8", Offset = "0x1D686E8", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00003572 File Offset: 0x00001772
		[global::Cpp2ILInjected.Token(Token = "0x600022C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6808C", Offset = "0x1D6808C", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlReaderSettings), Member = "set_NameTable", MemberParameters = new object[] { typeof(XmlNameTable) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlReaderSettings), Member = "set_XmlResolver", MemberParameters = new object[] { typeof(XmlResolver) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlReaderSettings), Member = "set_LineNumberOffset", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlReaderSettings), Member = "set_LinePositionOffset", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlReaderSettings), Member = "set_ConformanceLevel", MemberParameters = new object[] { typeof(ConformanceLevel) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlReaderSettings), Member = "set_CheckCharacters", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlReaderSettings), Member = "set_MaxCharactersInDocument", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlReaderSettings), Member = "set_MaxCharactersFromEntities", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlReaderSettings), Member = "set_IgnoreWhitespace", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlReaderSettings), Member = "set_IgnoreProcessingInstructions", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlReaderSettings), Member = "set_IgnoreComments", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlReaderSettings), Member = "set_DtdProcessing", MemberParameters = new object[] { typeof(DtdProcessing) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
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

		// Token: 0x06000220 RID: 544 RVA: 0x00003575 File Offset: 0x00001775
		[global::Cpp2ILInjected.Token(Token = "0x600022D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D68028", Offset = "0x1D68028", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlReaderSettings), Member = "Initialize", MemberParameters = new object[] { typeof(XmlResolver) }, ReturnType = typeof(void))]
		private void Initialize()
		{
			throw null;
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00003578 File Offset: 0x00001778
		[global::Cpp2ILInjected.Token(Token = "0x600022E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D686F4", Offset = "0x1D686F4", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlReaderSettings), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlReaderSettings), Member = "Initialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlReaderSettings), Member = "CreateDefaultResolver", ReturnType = typeof(XmlResolver))]
		private void Initialize(XmlResolver resolver)
		{
			throw null;
		}

		// Token: 0x06000222 RID: 546 RVA: 0x0000357B File Offset: 0x0000177B
		[global::Cpp2ILInjected.Token(Token = "0x600022F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D68758", Offset = "0x1D68758", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlReaderSettings), Member = "Initialize", MemberParameters = new object[] { typeof(XmlResolver) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUrlResolver), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static XmlResolver CreateDefaultResolver()
		{
			throw null;
		}

		// Token: 0x06000223 RID: 547 RVA: 0x0000357E File Offset: 0x0000177E
		[global::Cpp2ILInjected.Token(Token = "0x6000230")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D687AC", Offset = "0x1D687AC", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new object[] { typeof(XmlNameTable) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Nullable<>), Member = "get_Value", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryCompatibility), Member = "get_TargetsAtLeast_Desktop_V4_5_2", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Nullable<>), Member = ".ctor", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal static bool EnableLegacyXmlSettings()
		{
			throw null;
		}

		// Token: 0x040000C2 RID: 194
		[global::Cpp2ILInjected.Token(Token = "0x40000E2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private bool useAsync;

		// Token: 0x040000C3 RID: 195
		[global::Cpp2ILInjected.Token(Token = "0x40000E3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private XmlNameTable nameTable;

		// Token: 0x040000C4 RID: 196
		[global::Cpp2ILInjected.Token(Token = "0x40000E4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private XmlResolver xmlResolver;

		// Token: 0x040000C5 RID: 197
		[global::Cpp2ILInjected.Token(Token = "0x40000E5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private int lineNumberOffset;

		// Token: 0x040000C6 RID: 198
		[global::Cpp2ILInjected.Token(Token = "0x40000E6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		private int linePositionOffset;

		// Token: 0x040000C7 RID: 199
		[global::Cpp2ILInjected.Token(Token = "0x40000E7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private ConformanceLevel conformanceLevel;

		// Token: 0x040000C8 RID: 200
		[global::Cpp2ILInjected.Token(Token = "0x40000E8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		private bool checkCharacters;

		// Token: 0x040000C9 RID: 201
		[global::Cpp2ILInjected.Token(Token = "0x40000E9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private long maxCharactersInDocument;

		// Token: 0x040000CA RID: 202
		[global::Cpp2ILInjected.Token(Token = "0x40000EA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private long maxCharactersFromEntities;

		// Token: 0x040000CB RID: 203
		[global::Cpp2ILInjected.Token(Token = "0x40000EB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private bool ignoreWhitespace;

		// Token: 0x040000CC RID: 204
		[global::Cpp2ILInjected.Token(Token = "0x40000EC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x49")]
		private bool ignorePIs;

		// Token: 0x040000CD RID: 205
		[global::Cpp2ILInjected.Token(Token = "0x40000ED")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4A")]
		private bool ignoreComments;

		// Token: 0x040000CE RID: 206
		[global::Cpp2ILInjected.Token(Token = "0x40000EE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
		private DtdProcessing dtdProcessing;

		// Token: 0x040000CF RID: 207
		[global::Cpp2ILInjected.Token(Token = "0x40000EF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private ValidationType validationType;

		// Token: 0x040000D0 RID: 208
		[global::Cpp2ILInjected.Token(Token = "0x40000F0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
		private XmlSchemaValidationFlags validationFlags;

		// Token: 0x040000D1 RID: 209
		[global::Cpp2ILInjected.Token(Token = "0x40000F1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private XmlSchemaSet schemas;

		// Token: 0x040000D2 RID: 210
		[global::Cpp2ILInjected.Token(Token = "0x40000F2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private bool closeInput;

		// Token: 0x040000D3 RID: 211
		[global::Cpp2ILInjected.Token(Token = "0x40000F3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x61")]
		private bool isReadOnly;

		// Token: 0x040000D4 RID: 212
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40000F4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x62")]
		private bool <IsXmlResolverSet>k__BackingField;

		// Token: 0x040000D5 RID: 213
		[global::Cpp2ILInjected.Token(Token = "0x40000F5")]
		private static bool? s_enableLegacyXmlSettings;
	}
}
