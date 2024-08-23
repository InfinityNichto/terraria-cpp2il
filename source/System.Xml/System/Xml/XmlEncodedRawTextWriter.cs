using System;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x02000031 RID: 49
	[global::Cpp2ILInjected.Token(Token = "0x2000032")]
	internal class XmlEncodedRawTextWriter : XmlRawWriter
	{
		// Token: 0x0600014E RID: 334 RVA: 0x0000333B File Offset: 0x0000153B
		[global::Cpp2ILInjected.Token(Token = "0x6000150")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D647F0", Offset = "0x1D647F0", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(TextWriter),
			typeof(XmlWriterSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(XmlWriterSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "get_Instance", ReturnType = typeof(XmlCharType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWriter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected XmlEncodedRawTextWriter(XmlWriterSettings settings)
		{
			throw null;
		}

		// Token: 0x0600014F RID: 335 RVA: 0x0000333E File Offset: 0x0000153E
		[global::Cpp2ILInjected.Token(Token = "0x6000151")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D5DD0C", Offset = "0x1D5DD0C", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HtmlEncodedRawTextWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(TextWriter),
			typeof(XmlWriterSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HtmlEncodedRawTextWriterIndent), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(TextWriter),
			typeof(XmlWriterSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextEncodedRawTextWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(TextWriter),
			typeof(XmlWriterSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEncodedRawTextWriterIndent), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(TextWriter),
			typeof(XmlWriterSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWriterSettings), Member = "CreateWriter", MemberParameters = new object[] { typeof(TextWriter) }, ReturnType = typeof(XmlWriter))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = ".ctor", MemberParameters = new object[] { typeof(XmlWriterSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public XmlEncodedRawTextWriter(TextWriter writer, XmlWriterSettings settings)
		{
			throw null;
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00003341 File Offset: 0x00001541
		[global::Cpp2ILInjected.Token(Token = "0x6000152")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D5DF68", Offset = "0x1D5DF68", Length = "0x254")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HtmlEncodedRawTextWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(XmlWriterSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HtmlEncodedRawTextWriterIndent), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(XmlWriterSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextEncodedRawTextWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(XmlWriterSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEncodedRawTextWriterIndent), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(XmlWriterSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWriterSettings), Member = "CreateWriter", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(XmlWriter))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = ".ctor", MemberParameters = new object[] { typeof(XmlWriterSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EncoderFallback), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "set_EncoderFallback", MemberParameters = new object[] { typeof(EncoderFallback) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public XmlEncodedRawTextWriter(Stream stream, XmlWriterSettings settings)
		{
			throw null;
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00003344 File Offset: 0x00001544
		[global::Cpp2ILInjected.Token(Token = "0x6000153")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D64BC8", Offset = "0x1D64BC8", Length = "0x174")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "ChangeTextContentMark", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "RawText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal override void WriteXmlDeclaration(XmlStandalone standalone)
		{
			throw null;
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00003347 File Offset: 0x00001547
		[global::Cpp2ILInjected.Token(Token = "0x6000154")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D64D3C", Offset = "0x1D64D3C", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal override void WriteXmlDeclaration(string xmldecl)
		{
			throw null;
		}

		// Token: 0x06000153 RID: 339 RVA: 0x0000334A File Offset: 0x0000154A
		[global::Cpp2ILInjected.Token(Token = "0x6000155")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D64DB4", Offset = "0x1D64DB4", Length = "0x19C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEncodedRawTextWriterIndent), Member = "WriteDocType", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "ChangeTextContentMark", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "RawText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void WriteDocType(string name, string pubid, string sysid, string subset)
		{
			throw null;
		}

		// Token: 0x06000154 RID: 340 RVA: 0x0000334D File Offset: 0x0000154D
		[global::Cpp2ILInjected.Token(Token = "0x6000156")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D5E614", Offset = "0x1D5E614", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HtmlEncodedRawTextWriter), Member = "WriteStartElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEncodedRawTextWriterIndent), Member = "WriteStartElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "ChangeTextContentMark", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "RawText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public override void WriteStartElement(string prefix, string localName, string ns)
		{
			throw null;
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00003350 File Offset: 0x00001550
		[global::Cpp2ILInjected.Token(Token = "0x6000157")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D64F50", Offset = "0x1D64F50", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal override void StartElementContent()
		{
			throw null;
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00003353 File Offset: 0x00001553
		[global::Cpp2ILInjected.Token(Token = "0x6000158")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D5E8B8", Offset = "0x1D5E8B8", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HtmlEncodedRawTextWriter), Member = "WriteEndElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEncodedRawTextWriterIndent), Member = "WriteEndElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "ChangeTextContentMark", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "RawText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		internal override void WriteEndElement(string prefix, string localName, string ns)
		{
			throw null;
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00003356 File Offset: 0x00001556
		[global::Cpp2ILInjected.Token(Token = "0x6000159")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D5EA84", Offset = "0x1D5EA84", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HtmlEncodedRawTextWriter), Member = "WriteFullEndElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEncodedRawTextWriterIndent), Member = "WriteFullEndElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "ChangeTextContentMark", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "RawText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		internal override void WriteFullEndElement(string prefix, string localName, string ns)
		{
			throw null;
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00003359 File Offset: 0x00001559
		[global::Cpp2ILInjected.Token(Token = "0x600015A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D5EC74", Offset = "0x1D5EC74", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HtmlEncodedRawTextWriter), Member = "WriteStartAttribute", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEncodedRawTextWriterIndent), Member = "WriteStartAttribute", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "ChangeTextContentMark", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "RawText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public override void WriteStartAttribute(string prefix, string localName, string ns)
		{
			throw null;
		}

		// Token: 0x06000159 RID: 345 RVA: 0x0000335C File Offset: 0x0000155C
		[global::Cpp2ILInjected.Token(Token = "0x600015B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D64F74", Offset = "0x1D64F74", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "ChangeTextContentMark", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		public override void WriteEndAttribute()
		{
			throw null;
		}

		// Token: 0x0600015A RID: 346 RVA: 0x0000335F File Offset: 0x0000155F
		[global::Cpp2ILInjected.Token(Token = "0x600015C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D64FC4", Offset = "0x1D64FC4", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal override void WriteNamespaceDeclaration(string prefix, string namespaceName)
		{
			throw null;
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600015B RID: 347 RVA: 0x00003362 File Offset: 0x00001562
		[global::Cpp2ILInjected.Token(Token = "0x1700003A")]
		internal override bool SupportsNamespaceDeclarationInChunks
		{
			[global::Cpp2ILInjected.Token(Token = "0x600015D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D65018", Offset = "0x1D65018", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00003365 File Offset: 0x00001565
		[global::Cpp2ILInjected.Token(Token = "0x600015E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D65020", Offset = "0x1D65020", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "ChangeTextContentMark", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "RawText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal override void WriteStartNamespaceDeclaration(string prefix)
		{
			throw null;
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00003368 File Offset: 0x00001568
		[global::Cpp2ILInjected.Token(Token = "0x600015F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D65118", Offset = "0x1D65118", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "ChangeTextContentMark", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		internal override void WriteEndNamespaceDeclaration()
		{
			throw null;
		}

		// Token: 0x0600015E RID: 350 RVA: 0x0000336B File Offset: 0x0000156B
		[global::Cpp2ILInjected.Token(Token = "0x6000160")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D65168", Offset = "0x1D65168", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEncodedRawTextWriterIndent), Member = "WriteCData", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "ChangeTextContentMark", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteCDataSection", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public override void WriteCData(string text)
		{
			throw null;
		}

		// Token: 0x0600015F RID: 351 RVA: 0x0000336E File Offset: 0x0000156E
		[global::Cpp2ILInjected.Token(Token = "0x6000161")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6556C", Offset = "0x1D6556C", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEncodedRawTextWriterIndent), Member = "WriteComment", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "ChangeTextContentMark", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteCommentOrPi", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		public override void WriteComment(string text)
		{
			throw null;
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00003371 File Offset: 0x00001571
		[global::Cpp2ILInjected.Token(Token = "0x6000162")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6561C", Offset = "0x1D6561C", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEncodedRawTextWriterIndent), Member = "WriteProcessingInstruction", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "ChangeTextContentMark", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "RawText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteCommentOrPi", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		public override void WriteProcessingInstruction(string name, string text)
		{
			throw null;
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00003374 File Offset: 0x00001574
		[global::Cpp2ILInjected.Token(Token = "0x6000163")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D656F0", Offset = "0x1D656F0", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEncodedRawTextWriterIndent), Member = "WriteEntityRef", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "ChangeTextContentMark", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "RawText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public override void WriteEntityRef(string name)
		{
			throw null;
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00003377 File Offset: 0x00001577
		[global::Cpp2ILInjected.Token(Token = "0x6000164")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D65794", Offset = "0x1D65794", Length = "0x174")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEncodedRawTextWriterIndent), Member = "WriteCharEntity", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "IsCharData", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "ChangeTextContentMark", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "RawText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "CreateInvalidCharException", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override void WriteCharEntity(char ch)
		{
			throw null;
		}

		// Token: 0x06000163 RID: 355 RVA: 0x0000337A File Offset: 0x0000157A
		[global::Cpp2ILInjected.Token(Token = "0x6000165")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D65908", Offset = "0x1D65908", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEncodedRawTextWriterIndent), Member = "WriteWhitespace", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "ChangeTextContentMark", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteAttributeTextBlock", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteElementTextBlock", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*)
		}, ReturnType = typeof(void))]
		public unsafe override void WriteWhitespace(string ws)
		{
			throw null;
		}

		// Token: 0x06000164 RID: 356 RVA: 0x0000337D File Offset: 0x0000157D
		[global::Cpp2ILInjected.Token(Token = "0x6000166")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D65978", Offset = "0x1D65978", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEncodedRawTextWriterIndent), Member = "WriteString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "ChangeTextContentMark", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteAttributeTextBlock", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteElementTextBlock", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*)
		}, ReturnType = typeof(void))]
		public unsafe override void WriteString(string text)
		{
			throw null;
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00003380 File Offset: 0x00001580
		[global::Cpp2ILInjected.Token(Token = "0x6000167")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D659EC", Offset = "0x1D659EC", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEncodedRawTextWriterIndent), Member = "WriteSurrogateCharEntity", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "ChangeTextContentMark", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "CombineSurrogateChar", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "RawText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WriteSurrogateCharEntity(char lowChar, char highChar)
		{
			throw null;
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00003383 File Offset: 0x00001583
		[global::Cpp2ILInjected.Token(Token = "0x6000168")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D65AEC", Offset = "0x1D65AEC", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEncodedRawTextWriterIndent), Member = "WriteChars", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "ChangeTextContentMark", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteAttributeTextBlock", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteElementTextBlock", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*)
		}, ReturnType = typeof(void))]
		public unsafe override void WriteChars(char[] buffer, int index, int count)
		{
			throw null;
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00003386 File Offset: 0x00001586
		[global::Cpp2ILInjected.Token(Token = "0x6000169")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D62ED8", Offset = "0x1D62ED8", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextEncodedRawTextWriter), Member = "WriteRaw", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEncodedRawTextWriterIndent), Member = "WriteRaw", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "ChangeTextContentMark", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteRawWithCharChecking", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*)
		}, ReturnType = typeof(void))]
		public unsafe override void WriteRaw(char[] buffer, int index, int count)
		{
			throw null;
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00003389 File Offset: 0x00001589
		[global::Cpp2ILInjected.Token(Token = "0x600016A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D62E2C", Offset = "0x1D62E2C", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextEncodedRawTextWriter), Member = "WriteWhitespace", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextEncodedRawTextWriter), Member = "WriteString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextEncodedRawTextWriter), Member = "WriteRaw", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEncodedRawTextWriterIndent), Member = "WriteRaw", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "ChangeTextContentMark", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteRawWithCharChecking", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*)
		}, ReturnType = typeof(void))]
		public unsafe override void WriteRaw(string data)
		{
			throw null;
		}

		// Token: 0x06000169 RID: 361 RVA: 0x0000338C File Offset: 0x0000158C
		[global::Cpp2ILInjected.Token(Token = "0x600016B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D65D68", Offset = "0x1D65D68", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "FlushEncoder", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600016A RID: 362 RVA: 0x0000338F File Offset: 0x0000158F
		[global::Cpp2ILInjected.Token(Token = "0x600016C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D65E6C", Offset = "0x1D65E6C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "FlushEncoder", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void Flush()
		{
			throw null;
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00003392 File Offset: 0x00001592
		[global::Cpp2ILInjected.Token(Token = "0x600016D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6072C", Offset = "0x1D6072C", Length = "0x1F8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "EncodeChars", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		protected virtual void FlushBuffer()
		{
			throw null;
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00003395 File Offset: 0x00001595
		[global::Cpp2ILInjected.Token(Token = "0x600016E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D65EC4", Offset = "0x1D65EC4", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "FlushBuffer", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		private void EncodeChars(int startOffset, int endOffset, bool writeAllToStream)
		{
			throw null;
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00003398 File Offset: 0x00001598
		[global::Cpp2ILInjected.Token(Token = "0x600016F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D65DE4", Offset = "0x1D65DE4", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "Flush", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		private void FlushEncoder()
		{
			throw null;
		}

		// Token: 0x0600016E RID: 366 RVA: 0x0000339B File Offset: 0x0000159B
		[global::Cpp2ILInjected.Token(Token = "0x6000170")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D5F454", Offset = "0x1D5F454", Length = "0x2DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HtmlEncodedRawTextWriter), Member = "WriteHtmlAttributeTextBlock", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteWhitespace", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteChars", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "IsSurrogate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "EncodeSurrogate", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*),
			typeof(char*)
		}, ReturnType = typeof(char*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "InvalidXmlChar", MemberParameters = new object[]
		{
			typeof(int),
			typeof(char*),
			typeof(bool)
		}, ReturnType = typeof(char*))]
		protected unsafe void WriteAttributeTextBlock(char* pSrc, char* pSrcEnd)
		{
			throw null;
		}

		// Token: 0x0600016F RID: 367 RVA: 0x0000339E File Offset: 0x0000159E
		[global::Cpp2ILInjected.Token(Token = "0x6000171")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D5F730", Offset = "0x1D5F730", Length = "0x298")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HtmlEncodedRawTextWriter), Member = "WriteChars", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HtmlEncodedRawTextWriter), Member = "WriteHtmlElementTextBlock", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteWhitespace", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteChars", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "IsSurrogate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "EncodeSurrogate", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*),
			typeof(char*)
		}, ReturnType = typeof(char*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteNewLine", MemberParameters = new object[] { typeof(char*) }, ReturnType = typeof(char*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "InvalidXmlChar", MemberParameters = new object[]
		{
			typeof(int),
			typeof(char*),
			typeof(bool)
		}, ReturnType = typeof(char*))]
		protected unsafe void WriteElementTextBlock(char* pSrc, char* pSrcEnd)
		{
			throw null;
		}

		// Token: 0x06000170 RID: 368 RVA: 0x000033A1 File Offset: 0x000015A1
		[global::Cpp2ILInjected.Token(Token = "0x6000172")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D5E3F0", Offset = "0x1D5E3F0", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 56)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "RawText", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*)
		}, ReturnType = typeof(void))]
		protected unsafe void RawText(string s)
		{
			throw null;
		}

		// Token: 0x06000171 RID: 369 RVA: 0x000033A4 File Offset: 0x000015A4
		[global::Cpp2ILInjected.Token(Token = "0x6000173")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D5F9F0", Offset = "0x1D5F9F0", Length = "0x174")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HtmlEncodedRawTextWriter), Member = "WriteHtmlElementTextBlock", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "RawText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "IsSurrogate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "EncodeSurrogate", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*),
			typeof(char*)
		}, ReturnType = typeof(char*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "InvalidXmlChar", MemberParameters = new object[]
		{
			typeof(int),
			typeof(char*),
			typeof(bool)
		}, ReturnType = typeof(char*))]
		protected unsafe void RawText(char* pSrcBegin, char* pSrcEnd)
		{
			throw null;
		}

		// Token: 0x06000172 RID: 370 RVA: 0x000033A7 File Offset: 0x000015A7
		[global::Cpp2ILInjected.Token(Token = "0x6000174")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D65B5C", Offset = "0x1D65B5C", Length = "0x20C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteRaw", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteRaw", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "IsSurrogate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "EncodeSurrogate", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*),
			typeof(char*)
		}, ReturnType = typeof(char*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "InvalidXmlChar", MemberParameters = new object[]
		{
			typeof(int),
			typeof(char*),
			typeof(bool)
		}, ReturnType = typeof(char*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteNewLine", MemberParameters = new object[] { typeof(char*) }, ReturnType = typeof(char*))]
		protected unsafe void WriteRawWithCharChecking(char* pSrcBegin, char* pSrcEnd)
		{
			throw null;
		}

		// Token: 0x06000173 RID: 371 RVA: 0x000033AA File Offset: 0x000015AA
		[global::Cpp2ILInjected.Token(Token = "0x6000175")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D5EF20", Offset = "0x1D5EF20", Length = "0x2F8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HtmlEncodedRawTextWriter), Member = "WriteProcessingInstruction", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteComment", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteProcessingInstruction", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "IsSurrogate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "EncodeSurrogate", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*),
			typeof(char*)
		}, ReturnType = typeof(char*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "InvalidXmlChar", MemberParameters = new object[]
		{
			typeof(int),
			typeof(char*),
			typeof(bool)
		}, ReturnType = typeof(char*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteNewLine", MemberParameters = new object[] { typeof(char*) }, ReturnType = typeof(char*))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected unsafe void WriteCommentOrPi(string text, int stopChar)
		{
			throw null;
		}

		// Token: 0x06000174 RID: 372 RVA: 0x000033AD File Offset: 0x000015AD
		[global::Cpp2ILInjected.Token(Token = "0x6000176")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D65278", Offset = "0x1D65278", Length = "0x2F4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteCData", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "IsSurrogate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "EncodeSurrogate", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*),
			typeof(char*)
		}, ReturnType = typeof(char*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "InvalidXmlChar", MemberParameters = new object[]
		{
			typeof(int),
			typeof(char*),
			typeof(bool)
		}, ReturnType = typeof(char*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteNewLine", MemberParameters = new object[] { typeof(char*) }, ReturnType = typeof(char*))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected unsafe void WriteCDataSection(string text)
		{
			throw null;
		}

		// Token: 0x06000175 RID: 373 RVA: 0x000033B0 File Offset: 0x000015B0
		[global::Cpp2ILInjected.Token(Token = "0x6000177")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6602C", Offset = "0x1D6602C", Length = "0x158")]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "CreateInvalidSurrogatePairException", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "CreateInvalidHighSurrogateCharException", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private unsafe static char* EncodeSurrogate(char* pSrc, char* pSrcEnd, char* pDst)
		{
			throw null;
		}

		// Token: 0x06000176 RID: 374 RVA: 0x000033B3 File Offset: 0x000015B3
		[global::Cpp2ILInjected.Token(Token = "0x6000178")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D66184", Offset = "0x1D66184", Length = "0x6C")]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "CharEntity", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char)
		}, ReturnType = typeof(char*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "CreateInvalidCharException", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private unsafe char* InvalidXmlChar(int ch, char* pDst, bool entitize)
		{
			throw null;
		}

		// Token: 0x06000177 RID: 375 RVA: 0x000033B6 File Offset: 0x000015B6
		[global::Cpp2ILInjected.Token(Token = "0x6000179")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6029C", Offset = "0x1D6029C", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HtmlEncodedRawTextWriter), Member = "WriteHtmlAttributeText", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "IsSurrogate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "EncodeSurrogate", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*),
			typeof(char*)
		}, ReturnType = typeof(char*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "InvalidXmlChar", MemberParameters = new object[]
		{
			typeof(int),
			typeof(char*),
			typeof(bool)
		}, ReturnType = typeof(char*))]
		internal unsafe void EncodeChar(ref char* pSrc, char* pSrcEnd, ref char* pDst)
		{
			throw null;
		}

		// Token: 0x06000178 RID: 376 RVA: 0x000033B9 File Offset: 0x000015B9
		[global::Cpp2ILInjected.Token(Token = "0x600017A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D5E39C", Offset = "0x1D5E39C", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 31)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "GrowTextContentMarks", ReturnType = typeof(void))]
		protected void ChangeTextContentMark(bool value)
		{
			throw null;
		}

		// Token: 0x06000179 RID: 377 RVA: 0x000033BC File Offset: 0x000015BC
		[global::Cpp2ILInjected.Token(Token = "0x600017B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D66354", Offset = "0x1D66354", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "ChangeTextContentMark", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void GrowTextContentMarks()
		{
			throw null;
		}

		// Token: 0x0600017A RID: 378 RVA: 0x000033BF File Offset: 0x000015BF
		[global::Cpp2ILInjected.Token(Token = "0x600017C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D661F0", Offset = "0x1D661F0", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteElementTextBlock", MemberParameters = new object[]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "RawText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		protected unsafe char* WriteNewLine(char* pDst)
		{
			throw null;
		}

		// Token: 0x0600017B RID: 379 RVA: 0x000033C2 File Offset: 0x000015C2
		[global::Cpp2ILInjected.Token(Token = "0x600017D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D65FD4", Offset = "0x1D65FD4", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected unsafe static char* LtEntity(char* pDst)
		{
			throw null;
		}

		// Token: 0x0600017C RID: 380 RVA: 0x000033C5 File Offset: 0x000015C5
		[global::Cpp2ILInjected.Token(Token = "0x600017E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D65FEC", Offset = "0x1D65FEC", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected unsafe static char* GtEntity(char* pDst)
		{
			throw null;
		}

		// Token: 0x0600017D RID: 381 RVA: 0x000033C8 File Offset: 0x000015C8
		[global::Cpp2ILInjected.Token(Token = "0x600017F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D601F8", Offset = "0x1D601F8", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected unsafe static char* AmpEntity(char* pDst)
		{
			throw null;
		}

		// Token: 0x0600017E RID: 382 RVA: 0x000033CB File Offset: 0x000015CB
		[global::Cpp2ILInjected.Token(Token = "0x6000180")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D60220", Offset = "0x1D60220", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected unsafe static char* QuoteEntity(char* pDst)
		{
			throw null;
		}

		// Token: 0x0600017F RID: 383 RVA: 0x000033CE File Offset: 0x000015CE
		[global::Cpp2ILInjected.Token(Token = "0x6000181")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D66004", Offset = "0x1D66004", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected unsafe static char* TabEntity(char* pDst)
		{
			throw null;
		}

		// Token: 0x06000180 RID: 384 RVA: 0x000033D1 File Offset: 0x000015D1
		[global::Cpp2ILInjected.Token(Token = "0x6000182")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D60274", Offset = "0x1D60274", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected unsafe static char* LineFeedEntity(char* pDst)
		{
			throw null;
		}

		// Token: 0x06000181 RID: 385 RVA: 0x000033D4 File Offset: 0x000015D4
		[global::Cpp2ILInjected.Token(Token = "0x6000183")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6024C", Offset = "0x1D6024C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected unsafe static char* CarriageReturnEntity(char* pDst)
		{
			throw null;
		}

		// Token: 0x06000182 RID: 386 RVA: 0x000033D7 File Offset: 0x000015D7
		[global::Cpp2ILInjected.Token(Token = "0x6000184")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D662A4", Offset = "0x1D662A4", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "InvalidXmlChar", MemberParameters = new object[]
		{
			typeof(int),
			typeof(char*),
			typeof(bool)
		}, ReturnType = typeof(char*))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private unsafe static char* CharEntity(char* pDst, char ch)
		{
			throw null;
		}

		// Token: 0x06000183 RID: 387 RVA: 0x000033DA File Offset: 0x000015DA
		[global::Cpp2ILInjected.Token(Token = "0x6000185")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6626C", Offset = "0x1D6626C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected unsafe static char* RawStartCData(char* pDst)
		{
			throw null;
		}

		// Token: 0x06000184 RID: 388 RVA: 0x000033DD File Offset: 0x000015DD
		[global::Cpp2ILInjected.Token(Token = "0x6000186")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6624C", Offset = "0x1D6624C", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected unsafe static char* RawEndCData(char* pDst)
		{
			throw null;
		}

		// Token: 0x06000185 RID: 389 RVA: 0x000033E0 File Offset: 0x000015E0
		[global::Cpp2ILInjected.Token(Token = "0x6000187")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D648C4", Offset = "0x1D648C4", Length = "0x304")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEncodedRawTextWriterIndent), Member = "Init", MemberParameters = new object[] { typeof(XmlWriterSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "IsOnlyWhitespace", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "IsTextChar", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "IsHighSurrogate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "IsLowSurrogate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(uint), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		protected void ValidateContentChars(string chars, string propertyName, bool allowOnlyWhitespace)
		{
			throw null;
		}

		// Token: 0x04000087 RID: 135
		[global::Cpp2ILInjected.Token(Token = "0x4000087")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly bool useAsync;

		// Token: 0x04000088 RID: 136
		[global::Cpp2ILInjected.Token(Token = "0x4000088")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		protected byte[] bufBytes;

		// Token: 0x04000089 RID: 137
		[global::Cpp2ILInjected.Token(Token = "0x4000089")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		protected Stream stream;

		// Token: 0x0400008A RID: 138
		[global::Cpp2ILInjected.Token(Token = "0x400008A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		protected Encoding encoding;

		// Token: 0x0400008B RID: 139
		[global::Cpp2ILInjected.Token(Token = "0x400008B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		protected XmlCharType xmlCharType;

		// Token: 0x0400008C RID: 140
		[global::Cpp2ILInjected.Token(Token = "0x400008C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		protected int bufPos;

		// Token: 0x0400008D RID: 141
		[global::Cpp2ILInjected.Token(Token = "0x400008D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
		protected int textPos;

		// Token: 0x0400008E RID: 142
		[global::Cpp2ILInjected.Token(Token = "0x400008E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		protected int contentPos;

		// Token: 0x0400008F RID: 143
		[global::Cpp2ILInjected.Token(Token = "0x400008F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
		protected int cdataPos;

		// Token: 0x04000090 RID: 144
		[global::Cpp2ILInjected.Token(Token = "0x4000090")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		protected int attrEndPos;

		// Token: 0x04000091 RID: 145
		[global::Cpp2ILInjected.Token(Token = "0x4000091")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
		protected int bufLen;

		// Token: 0x04000092 RID: 146
		[global::Cpp2ILInjected.Token(Token = "0x4000092")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		protected bool writeToNull;

		// Token: 0x04000093 RID: 147
		[global::Cpp2ILInjected.Token(Token = "0x4000093")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x61")]
		protected bool hadDoubleBracket;

		// Token: 0x04000094 RID: 148
		[global::Cpp2ILInjected.Token(Token = "0x4000094")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x62")]
		protected bool inAttributeValue;

		// Token: 0x04000095 RID: 149
		[global::Cpp2ILInjected.Token(Token = "0x4000095")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x64")]
		protected int bufBytesUsed;

		// Token: 0x04000096 RID: 150
		[global::Cpp2ILInjected.Token(Token = "0x4000096")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		protected char[] bufChars;

		// Token: 0x04000097 RID: 151
		[global::Cpp2ILInjected.Token(Token = "0x4000097")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		protected Encoder encoder;

		// Token: 0x04000098 RID: 152
		[global::Cpp2ILInjected.Token(Token = "0x4000098")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		protected TextWriter writer;

		// Token: 0x04000099 RID: 153
		[global::Cpp2ILInjected.Token(Token = "0x4000099")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		protected bool trackTextContent;

		// Token: 0x0400009A RID: 154
		[global::Cpp2ILInjected.Token(Token = "0x400009A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x81")]
		protected bool inTextContent;

		// Token: 0x0400009B RID: 155
		[global::Cpp2ILInjected.Token(Token = "0x400009B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x84")]
		private int lastMarkPos;

		// Token: 0x0400009C RID: 156
		[global::Cpp2ILInjected.Token(Token = "0x400009C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private int[] textContentMarks;

		// Token: 0x0400009D RID: 157
		[global::Cpp2ILInjected.Token(Token = "0x400009D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private CharEntityEncoderFallback charEntityFallback;

		// Token: 0x0400009E RID: 158
		[global::Cpp2ILInjected.Token(Token = "0x400009E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		protected NewLineHandling newLineHandling;

		// Token: 0x0400009F RID: 159
		[global::Cpp2ILInjected.Token(Token = "0x400009F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x9C")]
		protected bool closeOutput;

		// Token: 0x040000A0 RID: 160
		[global::Cpp2ILInjected.Token(Token = "0x40000A0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x9D")]
		protected bool omitXmlDeclaration;

		// Token: 0x040000A1 RID: 161
		[global::Cpp2ILInjected.Token(Token = "0x40000A1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		protected string newLineChars;

		// Token: 0x040000A2 RID: 162
		[global::Cpp2ILInjected.Token(Token = "0x40000A2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		protected bool checkCharacters;

		// Token: 0x040000A3 RID: 163
		[global::Cpp2ILInjected.Token(Token = "0x40000A3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xAC")]
		protected XmlStandalone standalone;

		// Token: 0x040000A4 RID: 164
		[global::Cpp2ILInjected.Token(Token = "0x40000A4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		protected XmlOutputMethod outputMethod;

		// Token: 0x040000A5 RID: 165
		[global::Cpp2ILInjected.Token(Token = "0x40000A5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB4")]
		protected bool autoXmlDeclaration;

		// Token: 0x040000A6 RID: 166
		[global::Cpp2ILInjected.Token(Token = "0x40000A6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB5")]
		protected bool mergeCDataSections;
	}
}
