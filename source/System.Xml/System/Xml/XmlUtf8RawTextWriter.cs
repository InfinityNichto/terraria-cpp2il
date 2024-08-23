using System;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x0200003B RID: 59
	[global::Cpp2ILInjected.Token(Token = "0x200004C")]
	internal class XmlUtf8RawTextWriter : XmlRawWriter
	{
		// Token: 0x0600031F RID: 799 RVA: 0x00003872 File Offset: 0x00001A72
		[global::Cpp2ILInjected.Token(Token = "0x600037A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D80054", Offset = "0x1D80054", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUtf8RawTextWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(XmlWriterSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "get_Instance", ReturnType = typeof(XmlCharType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlRawWriter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected XmlUtf8RawTextWriter(XmlWriterSettings settings)
		{
			throw null;
		}

		// Token: 0x06000320 RID: 800 RVA: 0x00003875 File Offset: 0x00001A75
		[global::Cpp2ILInjected.Token(Token = "0x600037B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8042C", Offset = "0x1D8042C", Length = "0x12C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HtmlUtf8RawTextWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(XmlWriterSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HtmlUtf8RawTextWriterIndent), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(XmlWriterSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextUtf8RawTextWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(XmlWriterSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUtf8RawTextWriterIndent), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(XmlWriterSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWriterSettings), Member = "CreateWriter", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(XmlWriter))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = ".ctor", MemberParameters = new object[] { typeof(XmlWriterSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public XmlUtf8RawTextWriter(Stream stream, XmlWriterSettings settings)
		{
			throw null;
		}

		// Token: 0x06000321 RID: 801 RVA: 0x00003878 File Offset: 0x00001A78
		[global::Cpp2ILInjected.Token(Token = "0x600037C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D80558", Offset = "0x1D80558", Length = "0x158")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "RawText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal override void WriteXmlDeclaration(XmlStandalone standalone)
		{
			throw null;
		}

		// Token: 0x06000322 RID: 802 RVA: 0x0000387B File Offset: 0x00001A7B
		[global::Cpp2ILInjected.Token(Token = "0x600037D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D806F0", Offset = "0x1D806F0", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal override void WriteXmlDeclaration(string xmldecl)
		{
			throw null;
		}

		// Token: 0x06000323 RID: 803 RVA: 0x0000387E File Offset: 0x00001A7E
		[global::Cpp2ILInjected.Token(Token = "0x600037E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D80768", Offset = "0x1D80768", Length = "0x188")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUtf8RawTextWriterIndent), Member = "WriteDocType", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "RawText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void WriteDocType(string name, string pubid, string sysid, string subset)
		{
			throw null;
		}

		// Token: 0x06000324 RID: 804 RVA: 0x00003881 File Offset: 0x00001A81
		[global::Cpp2ILInjected.Token(Token = "0x600037F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D808F0", Offset = "0x1D808F0", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HtmlUtf8RawTextWriter), Member = "WriteStartElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUtf8RawTextWriterIndent), Member = "WriteStartElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "RawText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public override void WriteStartElement(string prefix, string localName, string ns)
		{
			throw null;
		}

		// Token: 0x06000325 RID: 805 RVA: 0x00003884 File Offset: 0x00001A84
		[global::Cpp2ILInjected.Token(Token = "0x6000380")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8096C", Offset = "0x1D8096C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal override void StartElementContent()
		{
			throw null;
		}

		// Token: 0x06000326 RID: 806 RVA: 0x00003887 File Offset: 0x00001A87
		[global::Cpp2ILInjected.Token(Token = "0x6000381")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D80994", Offset = "0x1D80994", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HtmlUtf8RawTextWriter), Member = "WriteEndElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUtf8RawTextWriterIndent), Member = "WriteEndElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "RawText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		internal override void WriteEndElement(string prefix, string localName, string ns)
		{
			throw null;
		}

		// Token: 0x06000327 RID: 807 RVA: 0x0000388A File Offset: 0x00001A8A
		[global::Cpp2ILInjected.Token(Token = "0x6000382")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D80A84", Offset = "0x1D80A84", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HtmlUtf8RawTextWriter), Member = "WriteFullEndElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUtf8RawTextWriterIndent), Member = "WriteFullEndElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "RawText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		internal override void WriteFullEndElement(string prefix, string localName, string ns)
		{
			throw null;
		}

		// Token: 0x06000328 RID: 808 RVA: 0x0000388D File Offset: 0x00001A8D
		[global::Cpp2ILInjected.Token(Token = "0x6000383")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D80B30", Offset = "0x1D80B30", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HtmlUtf8RawTextWriter), Member = "WriteStartAttribute", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUtf8RawTextWriterIndent), Member = "WriteStartAttribute", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "RawText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public override void WriteStartAttribute(string prefix, string localName, string ns)
		{
			throw null;
		}

		// Token: 0x06000329 RID: 809 RVA: 0x00003890 File Offset: 0x00001A90
		[global::Cpp2ILInjected.Token(Token = "0x6000384")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D80BF4", Offset = "0x1D80BF4", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void WriteEndAttribute()
		{
			throw null;
		}

		// Token: 0x0600032A RID: 810 RVA: 0x00003893 File Offset: 0x00001A93
		[global::Cpp2ILInjected.Token(Token = "0x6000385")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D80C20", Offset = "0x1D80C20", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal override void WriteNamespaceDeclaration(string prefix, string namespaceName)
		{
			throw null;
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600032B RID: 811 RVA: 0x00003896 File Offset: 0x00001A96
		[global::Cpp2ILInjected.Token(Token = "0x170000C1")]
		internal override bool SupportsNamespaceDeclarationInChunks
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000386")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D80C74", Offset = "0x1D80C74", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600032C RID: 812 RVA: 0x00003899 File Offset: 0x00001A99
		[global::Cpp2ILInjected.Token(Token = "0x6000387")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D80C7C", Offset = "0x1D80C7C", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "RawText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal override void WriteStartNamespaceDeclaration(string prefix)
		{
			throw null;
		}

		// Token: 0x0600032D RID: 813 RVA: 0x0000389C File Offset: 0x00001A9C
		[global::Cpp2ILInjected.Token(Token = "0x6000388")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D80D44", Offset = "0x1D80D44", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal override void WriteEndNamespaceDeclaration()
		{
			throw null;
		}

		// Token: 0x0600032E RID: 814 RVA: 0x0000389F File Offset: 0x00001A9F
		[global::Cpp2ILInjected.Token(Token = "0x6000389")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D80D70", Offset = "0x1D80D70", Length = "0x188")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUtf8RawTextWriterIndent), Member = "WriteCData", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteCDataSection", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public override void WriteCData(string text)
		{
			throw null;
		}

		// Token: 0x0600032F RID: 815 RVA: 0x000038A2 File Offset: 0x00001AA2
		[global::Cpp2ILInjected.Token(Token = "0x600038A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D811FC", Offset = "0x1D811FC", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUtf8RawTextWriterIndent), Member = "WriteComment", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteCommentOrPi", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		public override void WriteComment(string text)
		{
			throw null;
		}

		// Token: 0x06000330 RID: 816 RVA: 0x000038A5 File Offset: 0x00001AA5
		[global::Cpp2ILInjected.Token(Token = "0x600038B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D815EC", Offset = "0x1D815EC", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUtf8RawTextWriterIndent), Member = "WriteProcessingInstruction", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "RawText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteCommentOrPi", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		public override void WriteProcessingInstruction(string name, string text)
		{
			throw null;
		}

		// Token: 0x06000331 RID: 817 RVA: 0x000038A8 File Offset: 0x00001AA8
		[global::Cpp2ILInjected.Token(Token = "0x600038C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D816B0", Offset = "0x1D816B0", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUtf8RawTextWriterIndent), Member = "WriteEntityRef", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "RawText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public override void WriteEntityRef(string name)
		{
			throw null;
		}

		// Token: 0x06000332 RID: 818 RVA: 0x000038AB File Offset: 0x00001AAB
		[global::Cpp2ILInjected.Token(Token = "0x600038D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D81728", Offset = "0x1D81728", Length = "0x17C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUtf8RawTextWriterIndent), Member = "WriteCharEntity", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "IsCharData", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "RawText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
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

		// Token: 0x06000333 RID: 819 RVA: 0x000038AE File Offset: 0x00001AAE
		[global::Cpp2ILInjected.Token(Token = "0x600038E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D818A4", Offset = "0x1D818A4", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUtf8RawTextWriterIndent), Member = "WriteWhitespace", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteElementTextBlock", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*)
		}, ReturnType = typeof(void))]
		public unsafe override void WriteWhitespace(string ws)
		{
			throw null;
		}

		// Token: 0x06000334 RID: 820 RVA: 0x000038B1 File Offset: 0x00001AB1
		[global::Cpp2ILInjected.Token(Token = "0x600038F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D81E7C", Offset = "0x1D81E7C", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUtf8RawTextWriterIndent), Member = "WriteString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteAttributeTextBlock", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteElementTextBlock", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*)
		}, ReturnType = typeof(void))]
		public unsafe override void WriteString(string text)
		{
			throw null;
		}

		// Token: 0x06000335 RID: 821 RVA: 0x000038B4 File Offset: 0x00001AB4
		[global::Cpp2ILInjected.Token(Token = "0x6000390")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D81ED0", Offset = "0x1D81ED0", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUtf8RawTextWriterIndent), Member = "WriteSurrogateCharEntity", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "RawText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WriteSurrogateCharEntity(char lowChar, char highChar)
		{
			throw null;
		}

		// Token: 0x06000336 RID: 822 RVA: 0x000038B7 File Offset: 0x00001AB7
		[global::Cpp2ILInjected.Token(Token = "0x6000391")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D81FDC", Offset = "0x1D81FDC", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUtf8RawTextWriterIndent), Member = "WriteChars", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteAttributeTextBlock", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteElementTextBlock", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*)
		}, ReturnType = typeof(void))]
		public unsafe override void WriteChars(char[] buffer, int index, int count)
		{
			throw null;
		}

		// Token: 0x06000337 RID: 823 RVA: 0x000038BA File Offset: 0x00001ABA
		[global::Cpp2ILInjected.Token(Token = "0x6000392")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D81FF8", Offset = "0x1D81FF8", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextUtf8RawTextWriter), Member = "WriteChars", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextUtf8RawTextWriter), Member = "WriteRaw", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteRawWithCharChecking", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*)
		}, ReturnType = typeof(void))]
		public unsafe override void WriteRaw(char[] buffer, int index, int count)
		{
			throw null;
		}

		// Token: 0x06000338 RID: 824 RVA: 0x000038BD File Offset: 0x00001ABD
		[global::Cpp2ILInjected.Token(Token = "0x6000393")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D82254", Offset = "0x1D82254", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextUtf8RawTextWriter), Member = "WriteCData", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextUtf8RawTextWriter), Member = "WriteWhitespace", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextUtf8RawTextWriter), Member = "WriteString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextUtf8RawTextWriter), Member = "WriteRaw", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUtf8RawTextWriterIndent), Member = "WriteRaw", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteRawWithCharChecking", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*)
		}, ReturnType = typeof(void))]
		public unsafe override void WriteRaw(string data)
		{
			throw null;
		}

		// Token: 0x06000339 RID: 825 RVA: 0x000038C0 File Offset: 0x00001AC0
		[global::Cpp2ILInjected.Token(Token = "0x6000394")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D822A0", Offset = "0x1D822A0", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600033A RID: 826 RVA: 0x000038C3 File Offset: 0x00001AC3
		[global::Cpp2ILInjected.Token(Token = "0x6000395")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D82318", Offset = "0x1D82318", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void Flush()
		{
			throw null;
		}

		// Token: 0x0600033B RID: 827 RVA: 0x000038C6 File Offset: 0x00001AC6
		[global::Cpp2ILInjected.Token(Token = "0x6000396")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D82354", Offset = "0x1D82354", Length = "0x170")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HtmlUtf8RawTextWriterIndent), Member = "FlushBuffer", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		protected virtual void FlushBuffer()
		{
			throw null;
		}

		// Token: 0x0600033C RID: 828 RVA: 0x000038C9 File Offset: 0x00001AC9
		[global::Cpp2ILInjected.Token(Token = "0x6000397")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D82314", Offset = "0x1D82314", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void FlushEncoder()
		{
			throw null;
		}

		// Token: 0x0600033D RID: 829 RVA: 0x000038CC File Offset: 0x00001ACC
		[global::Cpp2ILInjected.Token(Token = "0x6000398")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D818F8", Offset = "0x1D818F8", Length = "0x2DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HtmlUtf8RawTextWriter), Member = "WriteChars", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HtmlUtf8RawTextWriter), Member = "WriteHtmlAttributeTextBlock", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteChars", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "IsSurrogate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "EncodeSurrogate", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*),
			typeof(byte*)
		}, ReturnType = typeof(byte*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "InvalidXmlChar", MemberParameters = new object[]
		{
			typeof(int),
			typeof(byte*),
			typeof(bool)
		}, ReturnType = typeof(byte*))]
		protected unsafe void WriteAttributeTextBlock(char* pSrc, char* pSrcEnd)
		{
			throw null;
		}

		// Token: 0x0600033E RID: 830 RVA: 0x000038CF File Offset: 0x00001ACF
		[global::Cpp2ILInjected.Token(Token = "0x6000399")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D81BD4", Offset = "0x1D81BD4", Length = "0x2A8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HtmlUtf8RawTextWriter), Member = "WriteChars", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HtmlUtf8RawTextWriter), Member = "WriteHtmlElementTextBlock", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteWhitespace", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteChars", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "IsSurrogate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "EncodeSurrogate", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*),
			typeof(byte*)
		}, ReturnType = typeof(byte*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteNewLine", MemberParameters = new object[] { typeof(byte*) }, ReturnType = typeof(byte*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "InvalidXmlChar", MemberParameters = new object[]
		{
			typeof(int),
			typeof(byte*),
			typeof(bool)
		}, ReturnType = typeof(byte*))]
		protected unsafe void WriteElementTextBlock(char* pSrc, char* pSrcEnd)
		{
			throw null;
		}

		// Token: 0x0600033F RID: 831 RVA: 0x000038D2 File Offset: 0x00001AD2
		[global::Cpp2ILInjected.Token(Token = "0x600039A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D806B0", Offset = "0x1D806B0", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 55)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "RawText", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*)
		}, ReturnType = typeof(void))]
		protected unsafe void RawText(string s)
		{
			throw null;
		}

		// Token: 0x06000340 RID: 832 RVA: 0x000038D5 File Offset: 0x00001AD5
		[global::Cpp2ILInjected.Token(Token = "0x600039B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8285C", Offset = "0x1D8285C", Length = "0x18C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HtmlUtf8RawTextWriter), Member = "WriteHtmlElementTextBlock", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUtf8RawTextWriter), Member = "RawText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "IsSurrogate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "EncodeSurrogate", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*),
			typeof(byte*)
		}, ReturnType = typeof(byte*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "InvalidXmlChar", MemberParameters = new object[]
		{
			typeof(int),
			typeof(byte*),
			typeof(bool)
		}, ReturnType = typeof(byte*))]
		protected unsafe void RawText(char* pSrcBegin, char* pSrcEnd)
		{
			throw null;
		}

		// Token: 0x06000341 RID: 833 RVA: 0x000038D8 File Offset: 0x00001AD8
		[global::Cpp2ILInjected.Token(Token = "0x600039C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D82020", Offset = "0x1D82020", Length = "0x234")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteRaw", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteRaw", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUtf8RawTextWriterIndent), Member = "WriteRaw", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "IsSurrogate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "EncodeSurrogate", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*),
			typeof(byte*)
		}, ReturnType = typeof(byte*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "InvalidXmlChar", MemberParameters = new object[]
		{
			typeof(int),
			typeof(byte*),
			typeof(bool)
		}, ReturnType = typeof(byte*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteNewLine", MemberParameters = new object[] { typeof(byte*) }, ReturnType = typeof(byte*))]
		protected unsafe void WriteRawWithCharChecking(char* pSrcBegin, char* pSrcEnd)
		{
			throw null;
		}

		// Token: 0x06000342 RID: 834 RVA: 0x000038DB File Offset: 0x00001ADB
		[global::Cpp2ILInjected.Token(Token = "0x600039D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D812D4", Offset = "0x1D812D4", Length = "0x318")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HtmlUtf8RawTextWriter), Member = "WriteProcessingInstruction", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteComment", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteProcessingInstruction", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "IsSurrogate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "EncodeSurrogate", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*),
			typeof(byte*)
		}, ReturnType = typeof(byte*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "InvalidXmlChar", MemberParameters = new object[]
		{
			typeof(int),
			typeof(byte*),
			typeof(bool)
		}, ReturnType = typeof(byte*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteNewLine", MemberParameters = new object[] { typeof(byte*) }, ReturnType = typeof(byte*))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected unsafe void WriteCommentOrPi(string text, int stopChar)
		{
			throw null;
		}

		// Token: 0x06000343 RID: 835 RVA: 0x000038DE File Offset: 0x00001ADE
		[global::Cpp2ILInjected.Token(Token = "0x600039E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D80EF8", Offset = "0x1D80EF8", Length = "0x304")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteCData", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "IsSurrogate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "EncodeSurrogate", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*),
			typeof(byte*)
		}, ReturnType = typeof(byte*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "InvalidXmlChar", MemberParameters = new object[]
		{
			typeof(int),
			typeof(byte*),
			typeof(bool)
		}, ReturnType = typeof(byte*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteNewLine", MemberParameters = new object[] { typeof(byte*) }, ReturnType = typeof(byte*))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected unsafe void WriteCDataSection(string text)
		{
			throw null;
		}

		// Token: 0x06000344 RID: 836 RVA: 0x000038E1 File Offset: 0x00001AE1
		[global::Cpp2ILInjected.Token(Token = "0x600039F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D82A2C", Offset = "0x1D82A2C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static bool IsSurrogateByte(byte b)
		{
			throw null;
		}

		// Token: 0x06000345 RID: 837 RVA: 0x000038E4 File Offset: 0x00001AE4
		[global::Cpp2ILInjected.Token(Token = "0x60003A0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D82584", Offset = "0x1D82584", Length = "0x190")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "CombineSurrogateChar", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "CreateInvalidSurrogatePairException", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "CreateInvalidHighSurrogateCharException", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private unsafe static byte* EncodeSurrogate(char* pSrc, char* pSrcEnd, byte* pDst)
		{
			throw null;
		}

		// Token: 0x06000346 RID: 838 RVA: 0x000038E7 File Offset: 0x00001AE7
		[global::Cpp2ILInjected.Token(Token = "0x60003A1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D82714", Offset = "0x1D82714", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "CharEntity", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(char)
		}, ReturnType = typeof(byte*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "CreateInvalidCharException", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private unsafe byte* InvalidXmlChar(int ch, byte* pDst, bool entitize)
		{
			throw null;
		}

		// Token: 0x06000347 RID: 839 RVA: 0x000038EA File Offset: 0x00001AEA
		[global::Cpp2ILInjected.Token(Token = "0x60003A2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D82AE8", Offset = "0x1D82AE8", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HtmlUtf8RawTextWriter), Member = "WriteHtmlAttributeText", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "IsSurrogate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "EncodeSurrogate", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*),
			typeof(byte*)
		}, ReturnType = typeof(byte*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "InvalidXmlChar", MemberParameters = new object[]
		{
			typeof(int),
			typeof(byte*),
			typeof(bool)
		}, ReturnType = typeof(byte*))]
		internal unsafe void EncodeChar(ref char* pSrc, char* pSrcEnd, ref byte* pDst)
		{
			throw null;
		}

		// Token: 0x06000348 RID: 840 RVA: 0x000038ED File Offset: 0x00001AED
		[global::Cpp2ILInjected.Token(Token = "0x60003A3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D827C8", Offset = "0x1D827C8", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal unsafe static byte* EncodeMultibyteUTF8(int ch, byte* pDst)
		{
			throw null;
		}

		// Token: 0x06000349 RID: 841 RVA: 0x000038F0 File Offset: 0x00001AF0
		[global::Cpp2ILInjected.Token(Token = "0x60003A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D82BC4", Offset = "0x1D82BC4", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HtmlEncodedRawTextWriter), Member = "WriteUriAttributeText", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HtmlUtf8RawTextWriter), Member = "WriteUriAttributeText", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "IsSurrogate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "EncodeSurrogate", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*),
			typeof(byte*)
		}, ReturnType = typeof(byte*))]
		internal unsafe static void CharToUTF8(ref char* pSrc, char* pSrcEnd, ref byte* pDst)
		{
			throw null;
		}

		// Token: 0x0600034A RID: 842 RVA: 0x000038F3 File Offset: 0x00001AF3
		[global::Cpp2ILInjected.Token(Token = "0x60003A5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D82808", Offset = "0x1D82808", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteElementTextBlock", MemberParameters = new object[]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "RawText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		protected unsafe byte* WriteNewLine(byte* pDst)
		{
			throw null;
		}

		// Token: 0x0600034B RID: 843 RVA: 0x000038F6 File Offset: 0x00001AF6
		[global::Cpp2ILInjected.Token(Token = "0x60003A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D824E4", Offset = "0x1D824E4", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected unsafe static byte* LtEntity(byte* pDst)
		{
			throw null;
		}

		// Token: 0x0600034C RID: 844 RVA: 0x000038F9 File Offset: 0x00001AF9
		[global::Cpp2ILInjected.Token(Token = "0x60003A7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D824F4", Offset = "0x1D824F4", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected unsafe static byte* GtEntity(byte* pDst)
		{
			throw null;
		}

		// Token: 0x0600034D RID: 845 RVA: 0x000038FC File Offset: 0x00001AFC
		[global::Cpp2ILInjected.Token(Token = "0x60003A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D824C4", Offset = "0x1D824C4", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HtmlUtf8RawTextWriter), Member = "WriteHtmlAttributeText", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HtmlUtf8RawTextWriter), Member = "WriteUriAttributeText", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		protected unsafe static byte* AmpEntity(byte* pDst)
		{
			throw null;
		}

		// Token: 0x0600034E RID: 846 RVA: 0x000038FF File Offset: 0x00001AFF
		[global::Cpp2ILInjected.Token(Token = "0x60003A9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D82504", Offset = "0x1D82504", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HtmlUtf8RawTextWriter), Member = "WriteHtmlAttributeText", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HtmlUtf8RawTextWriter), Member = "WriteUriAttributeText", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		protected unsafe static byte* QuoteEntity(byte* pDst)
		{
			throw null;
		}

		// Token: 0x0600034F RID: 847 RVA: 0x00003902 File Offset: 0x00001B02
		[global::Cpp2ILInjected.Token(Token = "0x60003AA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D82524", Offset = "0x1D82524", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected unsafe static byte* TabEntity(byte* pDst)
		{
			throw null;
		}

		// Token: 0x06000350 RID: 848 RVA: 0x00003905 File Offset: 0x00001B05
		[global::Cpp2ILInjected.Token(Token = "0x60003AB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D82564", Offset = "0x1D82564", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HtmlUtf8RawTextWriter), Member = "WriteHtmlAttributeText", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HtmlUtf8RawTextWriter), Member = "WriteUriAttributeText", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		protected unsafe static byte* LineFeedEntity(byte* pDst)
		{
			throw null;
		}

		// Token: 0x06000351 RID: 849 RVA: 0x00003908 File Offset: 0x00001B08
		[global::Cpp2ILInjected.Token(Token = "0x60003AC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D82544", Offset = "0x1D82544", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HtmlUtf8RawTextWriter), Member = "WriteHtmlAttributeText", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HtmlUtf8RawTextWriter), Member = "WriteUriAttributeText", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		protected unsafe static byte* CarriageReturnEntity(byte* pDst)
		{
			throw null;
		}

		// Token: 0x06000352 RID: 850 RVA: 0x0000390B File Offset: 0x00001B0B
		[global::Cpp2ILInjected.Token(Token = "0x60003AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D82A3C", Offset = "0x1D82A3C", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUtf8RawTextWriter), Member = "InvalidXmlChar", MemberParameters = new object[]
		{
			typeof(int),
			typeof(byte*),
			typeof(bool)
		}, ReturnType = typeof(byte*))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private unsafe static byte* CharEntity(byte* pDst, char ch)
		{
			throw null;
		}

		// Token: 0x06000353 RID: 851 RVA: 0x0000390E File Offset: 0x00001B0E
		[global::Cpp2ILInjected.Token(Token = "0x60003AE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D82A04", Offset = "0x1D82A04", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected unsafe static byte* RawStartCData(byte* pDst)
		{
			throw null;
		}

		// Token: 0x06000354 RID: 852 RVA: 0x00003911 File Offset: 0x00001B11
		[global::Cpp2ILInjected.Token(Token = "0x60003AF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D829E8", Offset = "0x1D829E8", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected unsafe static byte* RawEndCData(byte* pDst)
		{
			throw null;
		}

		// Token: 0x06000355 RID: 853 RVA: 0x00003914 File Offset: 0x00001B14
		[global::Cpp2ILInjected.Token(Token = "0x60003B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D80128", Offset = "0x1D80128", Length = "0x304")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUtf8RawTextWriterIndent), Member = "Init", MemberParameters = new object[] { typeof(XmlWriterSettings) }, ReturnType = typeof(void))]
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

		// Token: 0x04000127 RID: 295
		[global::Cpp2ILInjected.Token(Token = "0x40001C1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly bool useAsync;

		// Token: 0x04000128 RID: 296
		[global::Cpp2ILInjected.Token(Token = "0x40001C2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		protected byte[] bufBytes;

		// Token: 0x04000129 RID: 297
		[global::Cpp2ILInjected.Token(Token = "0x40001C3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		protected Stream stream;

		// Token: 0x0400012A RID: 298
		[global::Cpp2ILInjected.Token(Token = "0x40001C4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		protected Encoding encoding;

		// Token: 0x0400012B RID: 299
		[global::Cpp2ILInjected.Token(Token = "0x40001C5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		protected XmlCharType xmlCharType;

		// Token: 0x0400012C RID: 300
		[global::Cpp2ILInjected.Token(Token = "0x40001C6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		protected int bufPos;

		// Token: 0x0400012D RID: 301
		[global::Cpp2ILInjected.Token(Token = "0x40001C7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
		protected int textPos;

		// Token: 0x0400012E RID: 302
		[global::Cpp2ILInjected.Token(Token = "0x40001C8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		protected int contentPos;

		// Token: 0x0400012F RID: 303
		[global::Cpp2ILInjected.Token(Token = "0x40001C9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
		protected int cdataPos;

		// Token: 0x04000130 RID: 304
		[global::Cpp2ILInjected.Token(Token = "0x40001CA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		protected int attrEndPos;

		// Token: 0x04000131 RID: 305
		[global::Cpp2ILInjected.Token(Token = "0x40001CB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
		protected int bufLen;

		// Token: 0x04000132 RID: 306
		[global::Cpp2ILInjected.Token(Token = "0x40001CC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		protected bool writeToNull;

		// Token: 0x04000133 RID: 307
		[global::Cpp2ILInjected.Token(Token = "0x40001CD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x61")]
		protected bool hadDoubleBracket;

		// Token: 0x04000134 RID: 308
		[global::Cpp2ILInjected.Token(Token = "0x40001CE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x62")]
		protected bool inAttributeValue;

		// Token: 0x04000135 RID: 309
		[global::Cpp2ILInjected.Token(Token = "0x40001CF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x64")]
		protected NewLineHandling newLineHandling;

		// Token: 0x04000136 RID: 310
		[global::Cpp2ILInjected.Token(Token = "0x40001D0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		protected bool closeOutput;

		// Token: 0x04000137 RID: 311
		[global::Cpp2ILInjected.Token(Token = "0x40001D1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x69")]
		protected bool omitXmlDeclaration;

		// Token: 0x04000138 RID: 312
		[global::Cpp2ILInjected.Token(Token = "0x40001D2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		protected string newLineChars;

		// Token: 0x04000139 RID: 313
		[global::Cpp2ILInjected.Token(Token = "0x40001D3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		protected bool checkCharacters;

		// Token: 0x0400013A RID: 314
		[global::Cpp2ILInjected.Token(Token = "0x40001D4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x7C")]
		protected XmlStandalone standalone;

		// Token: 0x0400013B RID: 315
		[global::Cpp2ILInjected.Token(Token = "0x40001D5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		protected XmlOutputMethod outputMethod;

		// Token: 0x0400013C RID: 316
		[global::Cpp2ILInjected.Token(Token = "0x40001D6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x84")]
		protected bool autoXmlDeclaration;

		// Token: 0x0400013D RID: 317
		[global::Cpp2ILInjected.Token(Token = "0x40001D7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x85")]
		protected bool mergeCDataSections;
	}
}
