using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x02000032 RID: 50
	[global::Cpp2ILInjected.Token(Token = "0x2000033")]
	internal class XmlEncodedRawTextWriterIndent : XmlEncodedRawTextWriter
	{
		// Token: 0x06000186 RID: 390 RVA: 0x000033E3 File Offset: 0x000015E3
		[global::Cpp2ILInjected.Token(Token = "0x6000188")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D663C8", Offset = "0x1D663C8", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWriterSettings), Member = "CreateWriter", MemberParameters = new object[] { typeof(TextWriter) }, ReturnType = typeof(XmlWriter))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(TextWriter),
			typeof(XmlWriterSettings)
		}, ReturnType = typeof(void))]
		public XmlEncodedRawTextWriterIndent(TextWriter writer, XmlWriterSettings settings)
		{
			throw null;
		}

		// Token: 0x06000187 RID: 391 RVA: 0x000033E6 File Offset: 0x000015E6
		[global::Cpp2ILInjected.Token(Token = "0x6000189")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D66504", Offset = "0x1D66504", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWriterSettings), Member = "CreateWriter", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(XmlWriter))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(XmlWriterSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriterIndent), Member = "Init", MemberParameters = new object[] { typeof(XmlWriterSettings) }, ReturnType = typeof(void))]
		public XmlEncodedRawTextWriterIndent(Stream stream, XmlWriterSettings settings)
		{
			throw null;
		}

		// Token: 0x06000188 RID: 392 RVA: 0x000033E9 File Offset: 0x000015E9
		[global::Cpp2ILInjected.Token(Token = "0x600018A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6652C", Offset = "0x1D6652C", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriterIndent), Member = "WriteIndent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteDocType", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		public override void WriteDocType(string name, string pubid, string sysid, string subset)
		{
			throw null;
		}

		// Token: 0x06000189 RID: 393 RVA: 0x000033EC File Offset: 0x000015EC
		[global::Cpp2ILInjected.Token(Token = "0x600018B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D665D4", Offset = "0x1D665D4", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriterIndent), Member = "WriteIndent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitStack), Member = "PushCurr", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteStartElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		public override void WriteStartElement(string prefix, string localName, string ns)
		{
			throw null;
		}

		// Token: 0x0600018A RID: 394 RVA: 0x000033EF File Offset: 0x000015EF
		[global::Cpp2ILInjected.Token(Token = "0x600018C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D66664", Offset = "0x1D66664", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal override void StartElementContent()
		{
			throw null;
		}

		// Token: 0x0600018B RID: 395 RVA: 0x000033F2 File Offset: 0x000015F2
		[global::Cpp2ILInjected.Token(Token = "0x600018D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D666B8", Offset = "0x1D666B8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal override void OnRootElement(ConformanceLevel currentConformanceLevel)
		{
			throw null;
		}

		// Token: 0x0600018C RID: 396 RVA: 0x000033F5 File Offset: 0x000015F5
		[global::Cpp2ILInjected.Token(Token = "0x600018E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D666C0", Offset = "0x1D666C0", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriterIndent), Member = "WriteIndent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteEndElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		internal override void WriteEndElement(string prefix, string localName, string ns)
		{
			throw null;
		}

		// Token: 0x0600018D RID: 397 RVA: 0x000033F8 File Offset: 0x000015F8
		[global::Cpp2ILInjected.Token(Token = "0x600018F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D66764", Offset = "0x1D66764", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriterIndent), Member = "WriteIndent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteFullEndElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		internal override void WriteFullEndElement(string prefix, string localName, string ns)
		{
			throw null;
		}

		// Token: 0x0600018E RID: 398 RVA: 0x000033FB File Offset: 0x000015FB
		[global::Cpp2ILInjected.Token(Token = "0x6000190")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D66808", Offset = "0x1D66808", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriterIndent), Member = "WriteIndent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteStartAttribute", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		public override void WriteStartAttribute(string prefix, string localName, string ns)
		{
			throw null;
		}

		// Token: 0x0600018F RID: 399 RVA: 0x000033FE File Offset: 0x000015FE
		[global::Cpp2ILInjected.Token(Token = "0x6000191")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D66844", Offset = "0x1D66844", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteCData", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public override void WriteCData(string text)
		{
			throw null;
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00003401 File Offset: 0x00001601
		[global::Cpp2ILInjected.Token(Token = "0x6000192")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D66850", Offset = "0x1D66850", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriterIndent), Member = "WriteIndent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteComment", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public override void WriteComment(string text)
		{
			throw null;
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00003404 File Offset: 0x00001604
		[global::Cpp2ILInjected.Token(Token = "0x6000193")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D66890", Offset = "0x1D66890", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriterIndent), Member = "WriteIndent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteProcessingInstruction", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		public override void WriteProcessingInstruction(string target, string text)
		{
			throw null;
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00003407 File Offset: 0x00001607
		[global::Cpp2ILInjected.Token(Token = "0x6000194")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D668D8", Offset = "0x1D668D8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteEntityRef", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public override void WriteEntityRef(string name)
		{
			throw null;
		}

		// Token: 0x06000193 RID: 403 RVA: 0x0000340A File Offset: 0x0000160A
		[global::Cpp2ILInjected.Token(Token = "0x6000195")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D668E4", Offset = "0x1D668E4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteCharEntity", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
		public override void WriteCharEntity(char ch)
		{
			throw null;
		}

		// Token: 0x06000194 RID: 404 RVA: 0x0000340D File Offset: 0x0000160D
		[global::Cpp2ILInjected.Token(Token = "0x6000196")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D668F0", Offset = "0x1D668F0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteSurrogateCharEntity", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char)
		}, ReturnType = typeof(void))]
		public override void WriteSurrogateCharEntity(char lowChar, char highChar)
		{
			throw null;
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00003410 File Offset: 0x00001610
		[global::Cpp2ILInjected.Token(Token = "0x6000197")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D668FC", Offset = "0x1D668FC", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteWhitespace", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public override void WriteWhitespace(string ws)
		{
			throw null;
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00003413 File Offset: 0x00001613
		[global::Cpp2ILInjected.Token(Token = "0x6000198")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D66908", Offset = "0x1D66908", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public override void WriteString(string text)
		{
			throw null;
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00003416 File Offset: 0x00001616
		[global::Cpp2ILInjected.Token(Token = "0x6000199")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D66914", Offset = "0x1D66914", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteChars", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public override void WriteChars(char[] buffer, int index, int count)
		{
			throw null;
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00003419 File Offset: 0x00001619
		[global::Cpp2ILInjected.Token(Token = "0x600019A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D66920", Offset = "0x1D66920", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteRaw", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public override void WriteRaw(char[] buffer, int index, int count)
		{
			throw null;
		}

		// Token: 0x06000199 RID: 409 RVA: 0x0000341C File Offset: 0x0000161C
		[global::Cpp2ILInjected.Token(Token = "0x600019B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6692C", Offset = "0x1D6692C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteRaw", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public override void WriteRaw(string data)
		{
			throw null;
		}

		// Token: 0x0600019A RID: 410 RVA: 0x0000341F File Offset: 0x0000161F
		[global::Cpp2ILInjected.Token(Token = "0x600019C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D66938", Offset = "0x1D66938", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void WriteBase64(byte[] buffer, int index, int count)
		{
			throw null;
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00003422 File Offset: 0x00001622
		[global::Cpp2ILInjected.Token(Token = "0x600019D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D663F0", Offset = "0x1D663F0", Length = "0x114")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEncodedRawTextWriterIndent), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(XmlWriterSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "ValidateContentChars", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void Init(XmlWriterSettings settings)
		{
			throw null;
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00003425 File Offset: 0x00001625
		[global::Cpp2ILInjected.Token(Token = "0x600019E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6658C", Offset = "0x1D6658C", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEncodedRawTextWriterIndent), Member = "WriteDocType", MemberParameters = new object[]
		{
			typeof(string),
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEncodedRawTextWriterIndent), Member = "WriteEndElement", MemberParameters = new object[]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEncodedRawTextWriterIndent), Member = "WriteStartAttribute", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEncodedRawTextWriterIndent), Member = "WriteComment", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEncodedRawTextWriterIndent), Member = "WriteProcessingInstruction", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "RawText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		private void WriteIndent()
		{
			throw null;
		}

		// Token: 0x040000A7 RID: 167
		[global::Cpp2ILInjected.Token(Token = "0x40000A7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		protected int indentLevel;

		// Token: 0x040000A8 RID: 168
		[global::Cpp2ILInjected.Token(Token = "0x40000A8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xBC")]
		protected bool newLineOnAttributes;

		// Token: 0x040000A9 RID: 169
		[global::Cpp2ILInjected.Token(Token = "0x40000A9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
		protected string indentChars;

		// Token: 0x040000AA RID: 170
		[global::Cpp2ILInjected.Token(Token = "0x40000AA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
		protected bool mixedContent;

		// Token: 0x040000AB RID: 171
		[global::Cpp2ILInjected.Token(Token = "0x40000AB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
		private BitStack mixedContentStack;

		// Token: 0x040000AC RID: 172
		[global::Cpp2ILInjected.Token(Token = "0x40000AC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
		protected ConformanceLevel conformanceLevel;
	}
}
