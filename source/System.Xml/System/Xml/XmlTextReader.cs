using System;
using System.ComponentModel;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x02000039 RID: 57
	[EditorBrowsable(EditorBrowsableState.Never)]
	[global::Cpp2ILInjected.Token(Token = "0x200003C")]
	public class XmlTextReader : XmlReader, IXmlNamespaceResolver
	{
		// Token: 0x06000224 RID: 548 RVA: 0x00003581 File Offset: 0x00001781
		[global::Cpp2ILInjected.Token(Token = "0x6000231")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D7EDE8", Offset = "0x1D7EDE8", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDocument), Member = "LoadXml", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlReader), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(TextReader),
			typeof(XmlNameTable)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public XmlTextReader(TextReader input, XmlNameTable nt)
		{
			throw null;
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000225 RID: 549 RVA: 0x00003584 File Offset: 0x00001784
		[global::Cpp2ILInjected.Token(Token = "0x1700006D")]
		public override XmlNodeType NodeType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000232")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D7EE8C", Offset = "0x1D7EE8C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000226 RID: 550 RVA: 0x00003587 File Offset: 0x00001787
		[global::Cpp2ILInjected.Token(Token = "0x1700006E")]
		public override string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000233")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D7EE9C", Offset = "0x1D7EE9C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000227 RID: 551 RVA: 0x0000358A File Offset: 0x0000178A
		[global::Cpp2ILInjected.Token(Token = "0x1700006F")]
		public override string LocalName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000234")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D7EEAC", Offset = "0x1D7EEAC", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000228 RID: 552 RVA: 0x0000358D File Offset: 0x0000178D
		[global::Cpp2ILInjected.Token(Token = "0x17000070")]
		public override string NamespaceURI
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000235")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D7EEBC", Offset = "0x1D7EEBC", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000229 RID: 553 RVA: 0x00003590 File Offset: 0x00001790
		[global::Cpp2ILInjected.Token(Token = "0x17000071")]
		public override string Prefix
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000236")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D7EECC", Offset = "0x1D7EECC", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600022A RID: 554 RVA: 0x00003593 File Offset: 0x00001793
		[global::Cpp2ILInjected.Token(Token = "0x17000072")]
		public override string Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000237")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D7EEDC", Offset = "0x1D7EEDC", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600022B RID: 555 RVA: 0x00003596 File Offset: 0x00001796
		[global::Cpp2ILInjected.Token(Token = "0x17000073")]
		public override string BaseURI
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000238")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D7EEEC", Offset = "0x1D7EEEC", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x0600022C RID: 556 RVA: 0x00003599 File Offset: 0x00001799
		[global::Cpp2ILInjected.Token(Token = "0x17000074")]
		public override bool IsEmptyElement
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000239")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D7EEFC", Offset = "0x1D7EEFC", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600022D RID: 557 RVA: 0x0000359C File Offset: 0x0000179C
		[global::Cpp2ILInjected.Token(Token = "0x17000075")]
		public override bool IsDefault
		{
			[global::Cpp2ILInjected.Token(Token = "0x600023A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D7EF10", Offset = "0x1D7EF10", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600022E RID: 558 RVA: 0x0000359F File Offset: 0x0000179F
		[global::Cpp2ILInjected.Token(Token = "0x600023B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D7EF24", Offset = "0x1D7EF24", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool MoveToAttribute(string name)
		{
			throw null;
		}

		// Token: 0x0600022F RID: 559 RVA: 0x000035A2 File Offset: 0x000017A2
		[global::Cpp2ILInjected.Token(Token = "0x600023C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D7EF38", Offset = "0x1D7EF38", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool MoveToFirstAttribute()
		{
			throw null;
		}

		// Token: 0x06000230 RID: 560 RVA: 0x000035A5 File Offset: 0x000017A5
		[global::Cpp2ILInjected.Token(Token = "0x600023D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D7EF4C", Offset = "0x1D7EF4C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool MoveToNextAttribute()
		{
			throw null;
		}

		// Token: 0x06000231 RID: 561 RVA: 0x000035A8 File Offset: 0x000017A8
		[global::Cpp2ILInjected.Token(Token = "0x600023E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D7EF60", Offset = "0x1D7EF60", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool MoveToElement()
		{
			throw null;
		}

		// Token: 0x06000232 RID: 562 RVA: 0x000035AB File Offset: 0x000017AB
		[global::Cpp2ILInjected.Token(Token = "0x600023F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D7EF74", Offset = "0x1D7EF74", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool ReadAttributeValue()
		{
			throw null;
		}

		// Token: 0x06000233 RID: 563 RVA: 0x000035AE File Offset: 0x000017AE
		[global::Cpp2ILInjected.Token(Token = "0x6000240")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D7EF88", Offset = "0x1D7EF88", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Read()
		{
			throw null;
		}

		// Token: 0x06000234 RID: 564 RVA: 0x000035B1 File Offset: 0x000017B1
		[global::Cpp2ILInjected.Token(Token = "0x6000241")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D7EF9C", Offset = "0x1D7EF9C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000235 RID: 565 RVA: 0x000035B4 File Offset: 0x000017B4
		[global::Cpp2ILInjected.Token(Token = "0x17000076")]
		public override ReadState ReadState
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000242")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D7EFB0", Offset = "0x1D7EFB0", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000236 RID: 566 RVA: 0x000035B7 File Offset: 0x000017B7
		[global::Cpp2ILInjected.Token(Token = "0x17000077")]
		public override XmlNameTable NameTable
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000243")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D7EFC4", Offset = "0x1D7EFC4", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000237 RID: 567 RVA: 0x000035BA File Offset: 0x000017BA
		[global::Cpp2ILInjected.Token(Token = "0x6000244")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D7EFD8", Offset = "0x1D7EFD8", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override string LookupNamespace(string prefix)
		{
			throw null;
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000238 RID: 568 RVA: 0x000035BD File Offset: 0x000017BD
		[global::Cpp2ILInjected.Token(Token = "0x17000078")]
		public override bool CanResolveEntity
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000245")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D7F008", Offset = "0x1D7F008", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000239 RID: 569 RVA: 0x000035C0 File Offset: 0x000017C0
		[global::Cpp2ILInjected.Token(Token = "0x6000246")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D7F010", Offset = "0x1D7F010", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void ResolveEntity()
		{
			throw null;
		}

		// Token: 0x0600023A RID: 570 RVA: 0x000035C3 File Offset: 0x000017C3
		[global::Cpp2ILInjected.Token(Token = "0x6000247")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D7F024", Offset = "0x1D7F024", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix)
		{
			throw null;
		}

		// Token: 0x0600023B RID: 571 RVA: 0x000035C6 File Offset: 0x000017C6
		[global::Cpp2ILInjected.Token(Token = "0x6000248")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D7F038", Offset = "0x1D7F038", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "LookupPrefix", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName)
		{
			throw null;
		}

		// Token: 0x17000074 RID: 116
		// (set) Token: 0x0600023C RID: 572 RVA: 0x000035C9 File Offset: 0x000017C9
		[global::Cpp2ILInjected.Token(Token = "0x17000079")]
		public EntityHandling EntityHandling
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000249")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D7F044", Offset = "0x1D7F044", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "set_EntityHandling", MemberParameters = new object[] { typeof(EntityHandling) }, ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000075 RID: 117
		// (set) Token: 0x0600023D RID: 573 RVA: 0x000035CC File Offset: 0x000017CC
		[global::Cpp2ILInjected.Token(Token = "0x1700007A")]
		public XmlResolver XmlResolver
		{
			[global::Cpp2ILInjected.Token(Token = "0x600024A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D7F050", Offset = "0x1D7F050", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "set_XmlResolver", MemberParameters = new object[] { typeof(XmlResolver) }, ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x0600023E RID: 574 RVA: 0x000035CF File Offset: 0x000017CF
		[global::Cpp2ILInjected.Token(Token = "0x1700007B")]
		internal XmlTextReaderImpl Impl
		{
			[global::Cpp2ILInjected.Token(Token = "0x600024B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D7F05C", Offset = "0x1D7F05C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000077 RID: 119
		// (set) Token: 0x0600023F RID: 575 RVA: 0x000035D2 File Offset: 0x000017D2
		[global::Cpp2ILInjected.Token(Token = "0x1700007C")]
		internal bool XmlValidatingReaderCompatibilityMode
		{
			[global::Cpp2ILInjected.Token(Token = "0x600024C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D7F064", Offset = "0x1D7F064", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "set_XmlValidatingReaderCompatibilityMode", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000240 RID: 576 RVA: 0x000035D5 File Offset: 0x000017D5
		[global::Cpp2ILInjected.Token(Token = "0x1700007D")]
		internal override IDtdInfo DtdInfo
		{
			[global::Cpp2ILInjected.Token(Token = "0x600024D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D7F074", Offset = "0x1D7F074", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x040000DA RID: 218
		[global::Cpp2ILInjected.Token(Token = "0x40000FA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private XmlTextReaderImpl impl;
	}
}
