﻿using System;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x02000014 RID: 20
	[global::Cpp2ILInjected.Token(Token = "0x2000014")]
	internal class HtmlUtf8RawTextWriter : XmlUtf8RawTextWriter
	{
		// Token: 0x0600004E RID: 78 RVA: 0x0000310A File Offset: 0x0000130A
		[global::Cpp2ILInjected.Token(Token = "0x600004E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D609F4", Offset = "0x1D609F4", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWriterSettings), Member = "CreateWriter", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(XmlWriter))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(XmlWriterSettings)
		}, ReturnType = typeof(void))]
		public HtmlUtf8RawTextWriter(Stream stream, XmlWriterSettings settings)
		{
			throw null;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x0000310D File Offset: 0x0000130D
		[global::Cpp2ILInjected.Token(Token = "0x600004F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D60B88", Offset = "0x1D60B88", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal override void WriteXmlDeclaration(XmlStandalone standalone)
		{
			throw null;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00003110 File Offset: 0x00001310
		[global::Cpp2ILInjected.Token(Token = "0x6000050")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D60B8C", Offset = "0x1D60B8C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal override void WriteXmlDeclaration(string xmldecl)
		{
			throw null;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00003113 File Offset: 0x00001313
		[global::Cpp2ILInjected.Token(Token = "0x6000051")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D60B90", Offset = "0x1D60B90", Length = "0x1E0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HtmlUtf8RawTextWriterIndent), Member = "WriteDocType", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "RawText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override void WriteDocType(string name, string pubid, string sysid, string subset)
		{
			throw null;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00003116 File Offset: 0x00001316
		[global::Cpp2ILInjected.Token(Token = "0x6000052")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D60D70", Offset = "0x1D60D70", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ByteStack), Member = "Push", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteStartElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TernaryTreeReadOnly), Member = "FindCaseInsensitiveString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "RawText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WriteStartElement(string prefix, string localName, string ns)
		{
			throw null;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00003119 File Offset: 0x00001319
		[global::Cpp2ILInjected.Token(Token = "0x6000053")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D60E54", Offset = "0x1D60E54", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsInvalidInstructions]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal override void StartElementContent()
		{
			throw null;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x0000311C File Offset: 0x0000131C
		[global::Cpp2ILInjected.Token(Token = "0x6000054")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D60F9C", Offset = "0x1D60F9C", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HtmlUtf8RawTextWriterIndent), Member = "WriteEndElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteEndElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "RawText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		internal override void WriteEndElement(string prefix, string localName, string ns)
		{
			throw null;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x0000311F File Offset: 0x0000131F
		[global::Cpp2ILInjected.Token(Token = "0x6000055")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D61060", Offset = "0x1D61060", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteFullEndElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "RawText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		internal override void WriteFullEndElement(string prefix, string localName, string ns)
		{
			throw null;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00003122 File Offset: 0x00001322
		[global::Cpp2ILInjected.Token(Token = "0x6000056")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D61124", Offset = "0x1D61124", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HtmlUtf8RawTextWriterIndent), Member = "WriteStartAttribute", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteStartAttribute", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "RawText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TernaryTreeReadOnly), Member = "FindCaseInsensitiveString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WriteStartAttribute(string prefix, string localName, string ns)
		{
			throw null;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00003125 File Offset: 0x00001325
		[global::Cpp2ILInjected.Token(Token = "0x6000057")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D61254", Offset = "0x1D61254", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HtmlUtf8RawTextWriter), Member = "OutputRestAmps", ReturnType = typeof(void))]
		public override void WriteEndAttribute()
		{
			throw null;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00003128 File Offset: 0x00001328
		[global::Cpp2ILInjected.Token(Token = "0x6000058")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D61328", Offset = "0x1D61328", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "RawText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteCommentOrPi", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WriteProcessingInstruction(string target, string text)
		{
			throw null;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x0000312B File Offset: 0x0000132B
		[global::Cpp2ILInjected.Token(Token = "0x6000059")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D613FC", Offset = "0x1D613FC", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HtmlUtf8RawTextWriter), Member = "WriteHtmlElementTextBlock", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*)
		}, ReturnType = typeof(void))]
		public unsafe override void WriteString(string text)
		{
			throw null;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000312E File Offset: 0x0000132E
		[global::Cpp2ILInjected.Token(Token = "0x600005A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D614AC", Offset = "0x1D614AC", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override void WriteEntityRef(string name)
		{
			throw null;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00003131 File Offset: 0x00001331
		[global::Cpp2ILInjected.Token(Token = "0x600005B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D61504", Offset = "0x1D61504", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override void WriteCharEntity(char ch)
		{
			throw null;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00003134 File Offset: 0x00001334
		[global::Cpp2ILInjected.Token(Token = "0x600005C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6155C", Offset = "0x1D6155C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override void WriteSurrogateCharEntity(char lowChar, char highChar)
		{
			throw null;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00003137 File Offset: 0x00001337
		[global::Cpp2ILInjected.Token(Token = "0x600005D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D615B4", Offset = "0x1D615B4", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
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

		// Token: 0x0600005E RID: 94 RVA: 0x0000313A File Offset: 0x0000133A
		[global::Cpp2ILInjected.Token(Token = "0x600005E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D60A20", Offset = "0x1D60A20", Length = "0x168")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HtmlUtf8RawTextWriterIndent), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(XmlWriterSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ByteStack), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private void Init(XmlWriterSettings settings)
		{
			throw null;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x0000313D File Offset: 0x0000133D
		[global::Cpp2ILInjected.Token(Token = "0x600005F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D60E88", Offset = "0x1D60E88", Length = "0x114")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HtmlUtf8RawTextWriterIndent), Member = "StartElementContent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "RawText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected void WriteMetaElement()
		{
			throw null;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00003140 File Offset: 0x00001340
		[global::Cpp2ILInjected.Token(Token = "0x6000060")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D61494", Offset = "0x1D61494", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HtmlUtf8RawTextWriter), Member = "WriteString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteElementTextBlock", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "RawText", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*)
		}, ReturnType = typeof(void))]
		protected unsafe void WriteHtmlElementTextBlock(char* pSrc, char* pSrcEnd)
		{
			throw null;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00003143 File Offset: 0x00001343
		[global::Cpp2ILInjected.Token(Token = "0x6000061")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D61450", Offset = "0x1D61450", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HtmlUtf8RawTextWriter), Member = "WriteHtmlAttributeText", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteAttributeTextBlock", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HtmlUtf8RawTextWriter), Member = "WriteUriAttributeText", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*)
		}, ReturnType = typeof(void))]
		protected unsafe void WriteHtmlAttributeTextBlock(char* pSrc, char* pSrcEnd)
		{
			throw null;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00003146 File Offset: 0x00001346
		[global::Cpp2ILInjected.Token(Token = "0x6000062")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D61924", Offset = "0x1D61924", Length = "0x26C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HtmlUtf8RawTextWriter), Member = "WriteHtmlAttributeTextBlock", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HtmlUtf8RawTextWriter), Member = "OutputRestAmps", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "LineFeedEntity", MemberParameters = new object[] { typeof(byte*) }, ReturnType = typeof(byte*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "EncodeChar", MemberParameters = new object[]
		{
			typeof(ref char*),
			typeof(char*),
			typeof(ref byte*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "CarriageReturnEntity", MemberParameters = new object[] { typeof(byte*) }, ReturnType = typeof(byte*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "QuoteEntity", MemberParameters = new object[] { typeof(byte*) }, ReturnType = typeof(byte*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "AmpEntity", MemberParameters = new object[] { typeof(byte*) }, ReturnType = typeof(byte*))]
		private unsafe void WriteHtmlAttributeText(char* pSrc, char* pSrcEnd)
		{
			throw null;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00003149 File Offset: 0x00001349
		[global::Cpp2ILInjected.Token(Token = "0x6000063")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D615D4", Offset = "0x1D615D4", Length = "0x350")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HtmlUtf8RawTextWriter), Member = "WriteHtmlAttributeTextBlock", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HtmlUtf8RawTextWriter), Member = "OutputRestAmps", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "LineFeedEntity", MemberParameters = new object[] { typeof(byte*) }, ReturnType = typeof(byte*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "CarriageReturnEntity", MemberParameters = new object[] { typeof(byte*) }, ReturnType = typeof(byte*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "QuoteEntity", MemberParameters = new object[] { typeof(byte*) }, ReturnType = typeof(byte*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "CharToUTF8", MemberParameters = new object[]
		{
			typeof(ref char*),
			typeof(char*),
			typeof(ref byte*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "AmpEntity", MemberParameters = new object[] { typeof(byte*) }, ReturnType = typeof(byte*))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private unsafe void WriteUriAttributeText(char* pSrc, char* pSrcEnd)
		{
			throw null;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x0000314C File Offset: 0x0000134C
		[global::Cpp2ILInjected.Token(Token = "0x6000064")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D612B4", Offset = "0x1D612B4", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HtmlUtf8RawTextWriter), Member = "WriteEndAttribute", ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		private unsafe void OutputRestAmps()
		{
			throw null;
		}

		// Token: 0x0400003D RID: 61
		[global::Cpp2ILInjected.Token(Token = "0x400003D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		protected ByteStack elementScope;

		// Token: 0x0400003E RID: 62
		[global::Cpp2ILInjected.Token(Token = "0x400003E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		protected ElementProperties currentElementProperties;

		// Token: 0x0400003F RID: 63
		[global::Cpp2ILInjected.Token(Token = "0x400003F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x94")]
		private AttributeProperties currentAttributeProperties;

		// Token: 0x04000040 RID: 64
		[global::Cpp2ILInjected.Token(Token = "0x4000040")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private bool endsWithAmpersand;

		// Token: 0x04000041 RID: 65
		[global::Cpp2ILInjected.Token(Token = "0x4000041")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		private byte[] uriEscapingBuffer;

		// Token: 0x04000042 RID: 66
		[global::Cpp2ILInjected.Token(Token = "0x4000042")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		private string mediaType;

		// Token: 0x04000043 RID: 67
		[global::Cpp2ILInjected.Token(Token = "0x4000043")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		private bool doNotEscapeUriAttributes;

		// Token: 0x04000044 RID: 68
		[global::Cpp2ILInjected.Token(Token = "0x4000044")]
		protected static TernaryTreeReadOnly elementPropertySearch;

		// Token: 0x04000045 RID: 69
		[global::Cpp2ILInjected.Token(Token = "0x4000045")]
		protected static TernaryTreeReadOnly attributePropertySearch;
	}
}