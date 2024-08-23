using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x02000030 RID: 48
	[global::Cpp2ILInjected.Token(Token = "0x2000031")]
	internal class XmlAutoDetectWriter : XmlRawWriter
	{
		// Token: 0x06000129 RID: 297 RVA: 0x000032CC File Offset: 0x000014CC
		[global::Cpp2ILInjected.Token(Token = "0x600012B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D636C8", Offset = "0x1D636C8", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAutoDetectWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(TextWriter),
			typeof(XmlWriterSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAutoDetectWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(XmlWriterSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWriter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWriterSettings), Member = "Clone", ReturnType = typeof(XmlWriterSettings))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private XmlAutoDetectWriter(XmlWriterSettings writerSettings)
		{
			throw null;
		}

		// Token: 0x0600012A RID: 298 RVA: 0x000032CF File Offset: 0x000014CF
		[global::Cpp2ILInjected.Token(Token = "0x600012C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D637A8", Offset = "0x1D637A8", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWriterSettings), Member = "CreateWriter", MemberParameters = new object[] { typeof(TextWriter) }, ReturnType = typeof(XmlWriter))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAutoDetectWriter), Member = ".ctor", MemberParameters = new object[] { typeof(XmlWriterSettings) }, ReturnType = typeof(void))]
		public XmlAutoDetectWriter(TextWriter textWriter, XmlWriterSettings writerSettings)
		{
			throw null;
		}

		// Token: 0x0600012B RID: 299 RVA: 0x000032D2 File Offset: 0x000014D2
		[global::Cpp2ILInjected.Token(Token = "0x600012D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D637D0", Offset = "0x1D637D0", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWriterSettings), Member = "CreateWriter", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(XmlWriter))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAutoDetectWriter), Member = ".ctor", MemberParameters = new object[] { typeof(XmlWriterSettings) }, ReturnType = typeof(void))]
		public XmlAutoDetectWriter(Stream strm, XmlWriterSettings writerSettings)
		{
			throw null;
		}

		// Token: 0x0600012C RID: 300 RVA: 0x000032D5 File Offset: 0x000014D5
		[global::Cpp2ILInjected.Token(Token = "0x600012E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D637F8", Offset = "0x1D637F8", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAutoDetectWriter), Member = "CreateWrappedWriter", MemberParameters = new object[] { typeof(XmlOutputMethod) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WriteDocType(string name, string pubid, string sysid, string subset)
		{
			throw null;
		}

		// Token: 0x0600012D RID: 301 RVA: 0x000032D8 File Offset: 0x000014D8
		[global::Cpp2ILInjected.Token(Token = "0x600012F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D63868", Offset = "0x1D63868", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAutoDetectWriter), Member = "IsHtmlTag", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAutoDetectWriter), Member = "CreateWrappedWriter", MemberParameters = new object[] { typeof(XmlOutputMethod) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WriteStartElement(string prefix, string localName, string ns)
		{
			throw null;
		}

		// Token: 0x0600012E RID: 302 RVA: 0x000032DB File Offset: 0x000014DB
		[global::Cpp2ILInjected.Token(Token = "0x6000130")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D63B24", Offset = "0x1D63B24", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAutoDetectWriter), Member = "CreateWrappedWriter", MemberParameters = new object[] { typeof(XmlOutputMethod) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WriteStartAttribute(string prefix, string localName, string ns)
		{
			throw null;
		}

		// Token: 0x0600012F RID: 303 RVA: 0x000032DE File Offset: 0x000014DE
		[global::Cpp2ILInjected.Token(Token = "0x6000131")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D63B7C", Offset = "0x1D63B7C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WriteEndAttribute()
		{
			throw null;
		}

		// Token: 0x06000130 RID: 304 RVA: 0x000032E1 File Offset: 0x000014E1
		[global::Cpp2ILInjected.Token(Token = "0x6000132")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D63B90", Offset = "0x1D63B90", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAutoDetectWriter), Member = "TextBlockCreatesWriter", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WriteCData(string text)
		{
			throw null;
		}

		// Token: 0x06000131 RID: 305 RVA: 0x000032E4 File Offset: 0x000014E4
		[global::Cpp2ILInjected.Token(Token = "0x6000133")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D63C30", Offset = "0x1D63C30", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WriteComment(string text)
		{
			throw null;
		}

		// Token: 0x06000132 RID: 306 RVA: 0x000032E7 File Offset: 0x000014E7
		[global::Cpp2ILInjected.Token(Token = "0x6000134")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D63C50", Offset = "0x1D63C50", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WriteProcessingInstruction(string name, string text)
		{
			throw null;
		}

		// Token: 0x06000133 RID: 307 RVA: 0x000032EA File Offset: 0x000014EA
		[global::Cpp2ILInjected.Token(Token = "0x6000135")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D63C70", Offset = "0x1D63C70", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WriteWhitespace(string ws)
		{
			throw null;
		}

		// Token: 0x06000134 RID: 308 RVA: 0x000032ED File Offset: 0x000014ED
		[global::Cpp2ILInjected.Token(Token = "0x6000136")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D63C90", Offset = "0x1D63C90", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAutoDetectWriter), Member = "TextBlockCreatesWriter", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WriteString(string text)
		{
			throw null;
		}

		// Token: 0x06000135 RID: 309 RVA: 0x000032F0 File Offset: 0x000014F0
		[global::Cpp2ILInjected.Token(Token = "0x6000137")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D63CD0", Offset = "0x1D63CD0", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WriteChars(char[] buffer, int index, int count)
		{
			throw null;
		}

		// Token: 0x06000136 RID: 310 RVA: 0x000032F3 File Offset: 0x000014F3
		[global::Cpp2ILInjected.Token(Token = "0x6000138")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D63D00", Offset = "0x1D63D00", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WriteRaw(char[] buffer, int index, int count)
		{
			throw null;
		}

		// Token: 0x06000137 RID: 311 RVA: 0x000032F6 File Offset: 0x000014F6
		[global::Cpp2ILInjected.Token(Token = "0x6000139")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D63D30", Offset = "0x1D63D30", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAutoDetectWriter), Member = "TextBlockCreatesWriter", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WriteRaw(string data)
		{
			throw null;
		}

		// Token: 0x06000138 RID: 312 RVA: 0x000032F9 File Offset: 0x000014F9
		[global::Cpp2ILInjected.Token(Token = "0x600013A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D63D70", Offset = "0x1D63D70", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAutoDetectWriter), Member = "CreateWrappedWriter", MemberParameters = new object[] { typeof(XmlOutputMethod) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WriteEntityRef(string name)
		{
			throw null;
		}

		// Token: 0x06000139 RID: 313 RVA: 0x000032FC File Offset: 0x000014FC
		[global::Cpp2ILInjected.Token(Token = "0x600013B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D63DB4", Offset = "0x1D63DB4", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAutoDetectWriter), Member = "CreateWrappedWriter", MemberParameters = new object[] { typeof(XmlOutputMethod) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WriteCharEntity(char ch)
		{
			throw null;
		}

		// Token: 0x0600013A RID: 314 RVA: 0x000032FF File Offset: 0x000014FF
		[global::Cpp2ILInjected.Token(Token = "0x600013C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D63DF8", Offset = "0x1D63DF8", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAutoDetectWriter), Member = "CreateWrappedWriter", MemberParameters = new object[] { typeof(XmlOutputMethod) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WriteSurrogateCharEntity(char lowChar, char highChar)
		{
			throw null;
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00003302 File Offset: 0x00001502
		[global::Cpp2ILInjected.Token(Token = "0x600013D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D63E44", Offset = "0x1D63E44", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAutoDetectWriter), Member = "CreateWrappedWriter", MemberParameters = new object[] { typeof(XmlOutputMethod) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WriteBase64(byte[] buffer, int index, int count)
		{
			throw null;
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00003305 File Offset: 0x00001505
		[global::Cpp2ILInjected.Token(Token = "0x600013E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D63EA0", Offset = "0x1D63EA0", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAutoDetectWriter), Member = "CreateWrappedWriter", MemberParameters = new object[] { typeof(XmlOutputMethod) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WriteBinHex(byte[] buffer, int index, int count)
		{
			throw null;
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00003308 File Offset: 0x00001508
		[global::Cpp2ILInjected.Token(Token = "0x600013F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D63EFC", Offset = "0x1D63EFC", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAutoDetectWriter), Member = "CreateWrappedWriter", MemberParameters = new object[] { typeof(XmlOutputMethod) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600013E RID: 318 RVA: 0x0000330B File Offset: 0x0000150B
		[global::Cpp2ILInjected.Token(Token = "0x6000140")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D63F30", Offset = "0x1D63F30", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAutoDetectWriter), Member = "CreateWrappedWriter", MemberParameters = new object[] { typeof(XmlOutputMethod) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void Flush()
		{
			throw null;
		}

		// Token: 0x0600013F RID: 319 RVA: 0x0000330E File Offset: 0x0000150E
		[global::Cpp2ILInjected.Token(Token = "0x6000141")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D63F64", Offset = "0x1D63F64", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAutoDetectWriter), Member = "CreateWrappedWriter", MemberParameters = new object[] { typeof(XmlOutputMethod) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WriteValue(string value)
		{
			throw null;
		}

		// Token: 0x17000038 RID: 56
		// (set) Token: 0x06000140 RID: 320 RVA: 0x00003311 File Offset: 0x00001511
		[global::Cpp2ILInjected.Token(Token = "0x17000038")]
		internal override IXmlNamespaceResolver NamespaceResolver
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000142")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D63FA8", Offset = "0x1D63FA8", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00003314 File Offset: 0x00001514
		[global::Cpp2ILInjected.Token(Token = "0x6000143")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D63FCC", Offset = "0x1D63FCC", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAutoDetectWriter), Member = "CreateWrappedWriter", MemberParameters = new object[] { typeof(XmlOutputMethod) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal override void WriteXmlDeclaration(XmlStandalone standalone)
		{
			throw null;
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00003317 File Offset: 0x00001517
		[global::Cpp2ILInjected.Token(Token = "0x6000144")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D64010", Offset = "0x1D64010", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAutoDetectWriter), Member = "CreateWrappedWriter", MemberParameters = new object[] { typeof(XmlOutputMethod) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal override void WriteXmlDeclaration(string xmldecl)
		{
			throw null;
		}

		// Token: 0x06000143 RID: 323 RVA: 0x0000331A File Offset: 0x0000151A
		[global::Cpp2ILInjected.Token(Token = "0x6000145")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D64054", Offset = "0x1D64054", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal override void StartElementContent()
		{
			throw null;
		}

		// Token: 0x06000144 RID: 324 RVA: 0x0000331D File Offset: 0x0000151D
		[global::Cpp2ILInjected.Token(Token = "0x6000146")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D64068", Offset = "0x1D64068", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal override void WriteEndElement(string prefix, string localName, string ns)
		{
			throw null;
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00003320 File Offset: 0x00001520
		[global::Cpp2ILInjected.Token(Token = "0x6000147")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6407C", Offset = "0x1D6407C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal override void WriteFullEndElement(string prefix, string localName, string ns)
		{
			throw null;
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00003323 File Offset: 0x00001523
		[global::Cpp2ILInjected.Token(Token = "0x6000148")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D64090", Offset = "0x1D64090", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAutoDetectWriter), Member = "CreateWrappedWriter", MemberParameters = new object[] { typeof(XmlOutputMethod) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal override void WriteNamespaceDeclaration(string prefix, string ns)
		{
			throw null;
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000147 RID: 327 RVA: 0x00003326 File Offset: 0x00001526
		[global::Cpp2ILInjected.Token(Token = "0x17000039")]
		internal override bool SupportsNamespaceDeclarationInChunks
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000149")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D640DC", Offset = "0x1D640DC", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00003329 File Offset: 0x00001529
		[global::Cpp2ILInjected.Token(Token = "0x600014A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D640F0", Offset = "0x1D640F0", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAutoDetectWriter), Member = "CreateWrappedWriter", MemberParameters = new object[] { typeof(XmlOutputMethod) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal override void WriteStartNamespaceDeclaration(string prefix)
		{
			throw null;
		}

		// Token: 0x06000149 RID: 329 RVA: 0x0000332C File Offset: 0x0000152C
		[global::Cpp2ILInjected.Token(Token = "0x600014B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D64134", Offset = "0x1D64134", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal override void WriteEndNamespaceDeclaration()
		{
			throw null;
		}

		// Token: 0x0600014A RID: 330 RVA: 0x0000332F File Offset: 0x0000152F
		[global::Cpp2ILInjected.Token(Token = "0x600014C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D638DC", Offset = "0x1D638DC", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAutoDetectWriter), Member = "WriteStartElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		private static bool IsHtmlTag(string tagName)
		{
			throw null;
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00003332 File Offset: 0x00001532
		[global::Cpp2ILInjected.Token(Token = "0x600014D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D63858", Offset = "0x1D63858", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAutoDetectWriter), Member = "CreateWrappedWriter", MemberParameters = new object[] { typeof(XmlOutputMethod) }, ReturnType = typeof(void))]
		private void EnsureWrappedWriter(XmlOutputMethod outMethod)
		{
			throw null;
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00003335 File Offset: 0x00001535
		[global::Cpp2ILInjected.Token(Token = "0x600014E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D63BD0", Offset = "0x1D63BD0", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAutoDetectWriter), Member = "WriteCData", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAutoDetectWriter), Member = "WriteString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAutoDetectWriter), Member = "WriteRaw", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "get_Instance", ReturnType = typeof(XmlCharType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "IsOnlyWhitespace", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAutoDetectWriter), Member = "CreateWrappedWriter", MemberParameters = new object[] { typeof(XmlOutputMethod) }, ReturnType = typeof(void))]
		private bool TextBlockCreatesWriter(string textBlock)
		{
			throw null;
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00003338 File Offset: 0x00001538
		[global::Cpp2ILInjected.Token(Token = "0x600014F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D639E4", Offset = "0x1D639E4", Length = "0x140")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAutoDetectWriter), Member = "WriteDocType", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAutoDetectWriter), Member = "WriteStartElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAutoDetectWriter), Member = "WriteStartAttribute", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAutoDetectWriter), Member = "WriteEntityRef", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAutoDetectWriter), Member = "WriteCharEntity", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAutoDetectWriter), Member = "WriteSurrogateCharEntity", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAutoDetectWriter), Member = "WriteBase64", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAutoDetectWriter), Member = "WriteBinHex", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAutoDetectWriter), Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAutoDetectWriter), Member = "Flush", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAutoDetectWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAutoDetectWriter), Member = "WriteXmlDeclaration", MemberParameters = new object[] { typeof(XmlStandalone) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAutoDetectWriter), Member = "WriteXmlDeclaration", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAutoDetectWriter), Member = "WriteNamespaceDeclaration", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAutoDetectWriter), Member = "WriteStartNamespaceDeclaration", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAutoDetectWriter), Member = "EnsureWrappedWriter", MemberParameters = new object[] { typeof(XmlOutputMethod) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAutoDetectWriter), Member = "TextBlockCreatesWriter", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 17)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWriterSettings), Member = "set_Indent", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWriter), Member = "Create", MemberParameters = new object[]
		{
			typeof(TextWriter),
			typeof(XmlWriterSettings)
		}, ReturnType = typeof(XmlWriter))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWriter), Member = "Create", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(XmlWriterSettings)
		}, ReturnType = typeof(XmlWriter))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEventCache), Member = "EventsToWriter", MemberParameters = new object[] { typeof(XmlWriter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void CreateWrappedWriter(XmlOutputMethod outMethod)
		{
			throw null;
		}

		// Token: 0x04000081 RID: 129
		[global::Cpp2ILInjected.Token(Token = "0x4000081")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private XmlRawWriter wrapped;

		// Token: 0x04000082 RID: 130
		[global::Cpp2ILInjected.Token(Token = "0x4000082")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private OnRemoveWriter onRemove;

		// Token: 0x04000083 RID: 131
		[global::Cpp2ILInjected.Token(Token = "0x4000083")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private XmlWriterSettings writerSettings;

		// Token: 0x04000084 RID: 132
		[global::Cpp2ILInjected.Token(Token = "0x4000084")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private XmlEventCache eventCache;

		// Token: 0x04000085 RID: 133
		[global::Cpp2ILInjected.Token(Token = "0x4000085")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private TextWriter textWriter;

		// Token: 0x04000086 RID: 134
		[global::Cpp2ILInjected.Token(Token = "0x4000086")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private Stream strm;
	}
}
