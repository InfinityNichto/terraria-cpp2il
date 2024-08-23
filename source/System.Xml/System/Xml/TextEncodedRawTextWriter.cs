using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x0200002B RID: 43
	[global::Cpp2ILInjected.Token(Token = "0x200002C")]
	internal class TextEncodedRawTextWriter : XmlEncodedRawTextWriter
	{
		// Token: 0x060000DC RID: 220 RVA: 0x000031E5 File Offset: 0x000013E5
		[global::Cpp2ILInjected.Token(Token = "0x60000DE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D62DE4", Offset = "0x1D62DE4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWriterSettings), Member = "CreateWriter", MemberParameters = new object[] { typeof(TextWriter) }, ReturnType = typeof(XmlWriter))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(TextWriter),
			typeof(XmlWriterSettings)
		}, ReturnType = typeof(void))]
		public TextEncodedRawTextWriter(TextWriter writer, XmlWriterSettings settings)
		{
			throw null;
		}

		// Token: 0x060000DD RID: 221 RVA: 0x000031E8 File Offset: 0x000013E8
		[global::Cpp2ILInjected.Token(Token = "0x60000DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D62DE8", Offset = "0x1D62DE8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWriterSettings), Member = "CreateWriter", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(XmlWriter))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(XmlWriterSettings)
		}, ReturnType = typeof(void))]
		public TextEncodedRawTextWriter(Stream stream, XmlWriterSettings settings)
		{
			throw null;
		}

		// Token: 0x060000DE RID: 222 RVA: 0x000031EB File Offset: 0x000013EB
		[global::Cpp2ILInjected.Token(Token = "0x60000E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D62DEC", Offset = "0x1D62DEC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal override void WriteXmlDeclaration(XmlStandalone standalone)
		{
			throw null;
		}

		// Token: 0x060000DF RID: 223 RVA: 0x000031EE File Offset: 0x000013EE
		[global::Cpp2ILInjected.Token(Token = "0x60000E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D62DF0", Offset = "0x1D62DF0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal override void WriteXmlDeclaration(string xmldecl)
		{
			throw null;
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x000031F1 File Offset: 0x000013F1
		[global::Cpp2ILInjected.Token(Token = "0x60000E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D62DF4", Offset = "0x1D62DF4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void WriteDocType(string name, string pubid, string sysid, string subset)
		{
			throw null;
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x000031F4 File Offset: 0x000013F4
		[global::Cpp2ILInjected.Token(Token = "0x60000E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D62DF8", Offset = "0x1D62DF8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void WriteStartElement(string prefix, string localName, string ns)
		{
			throw null;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x000031F7 File Offset: 0x000013F7
		[global::Cpp2ILInjected.Token(Token = "0x60000E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D62DFC", Offset = "0x1D62DFC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal override void WriteEndElement(string prefix, string localName, string ns)
		{
			throw null;
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x000031FA File Offset: 0x000013FA
		[global::Cpp2ILInjected.Token(Token = "0x60000E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D62E00", Offset = "0x1D62E00", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal override void WriteFullEndElement(string prefix, string localName, string ns)
		{
			throw null;
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x000031FD File Offset: 0x000013FD
		[global::Cpp2ILInjected.Token(Token = "0x60000E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D62E04", Offset = "0x1D62E04", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal override void StartElementContent()
		{
			throw null;
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00003200 File Offset: 0x00001400
		[global::Cpp2ILInjected.Token(Token = "0x60000E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D62E08", Offset = "0x1D62E08", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void WriteStartAttribute(string prefix, string localName, string ns)
		{
			throw null;
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00003203 File Offset: 0x00001403
		[global::Cpp2ILInjected.Token(Token = "0x60000E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D62E14", Offset = "0x1D62E14", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void WriteEndAttribute()
		{
			throw null;
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00003206 File Offset: 0x00001406
		[global::Cpp2ILInjected.Token(Token = "0x60000E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D62E1C", Offset = "0x1D62E1C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal override void WriteNamespaceDeclaration(string prefix, string ns)
		{
			throw null;
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x00003209 File Offset: 0x00001409
		[global::Cpp2ILInjected.Token(Token = "0x17000035")]
		internal override bool SupportsNamespaceDeclarationInChunks
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000EA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D62E20", Offset = "0x1D62E20", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x0000320C File Offset: 0x0000140C
		[global::Cpp2ILInjected.Token(Token = "0x60000EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D62E28", Offset = "0x1D62E28", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void WriteCData(string text)
		{
			throw null;
		}

		// Token: 0x060000EA RID: 234 RVA: 0x0000320F File Offset: 0x0000140F
		[global::Cpp2ILInjected.Token(Token = "0x60000EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D62E94", Offset = "0x1D62E94", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void WriteComment(string text)
		{
			throw null;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00003212 File Offset: 0x00001412
		[global::Cpp2ILInjected.Token(Token = "0x60000ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D62E98", Offset = "0x1D62E98", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void WriteProcessingInstruction(string name, string text)
		{
			throw null;
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00003215 File Offset: 0x00001415
		[global::Cpp2ILInjected.Token(Token = "0x60000EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D62E9C", Offset = "0x1D62E9C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void WriteEntityRef(string name)
		{
			throw null;
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00003218 File Offset: 0x00001418
		[global::Cpp2ILInjected.Token(Token = "0x60000EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D62EA0", Offset = "0x1D62EA0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void WriteCharEntity(char ch)
		{
			throw null;
		}

		// Token: 0x060000EE RID: 238 RVA: 0x0000321B File Offset: 0x0000141B
		[global::Cpp2ILInjected.Token(Token = "0x60000F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D62EA4", Offset = "0x1D62EA4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void WriteSurrogateCharEntity(char lowChar, char highChar)
		{
			throw null;
		}

		// Token: 0x060000EF RID: 239 RVA: 0x0000321E File Offset: 0x0000141E
		[global::Cpp2ILInjected.Token(Token = "0x60000F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D62EA8", Offset = "0x1D62EA8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteRaw", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public override void WriteWhitespace(string ws)
		{
			throw null;
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00003221 File Offset: 0x00001421
		[global::Cpp2ILInjected.Token(Token = "0x60000F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D62EB8", Offset = "0x1D62EB8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteRaw", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public override void WriteString(string textBlock)
		{
			throw null;
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00003224 File Offset: 0x00001424
		[global::Cpp2ILInjected.Token(Token = "0x60000F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D62EC8", Offset = "0x1D62EC8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsInvalidInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void WriteChars(char[] buffer, int index, int count)
		{
			throw null;
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00003227 File Offset: 0x00001427
		[global::Cpp2ILInjected.Token(Token = "0x60000F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D62F3C", Offset = "0x1D62F3C", Length = "0x10")]
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

		// Token: 0x060000F3 RID: 243 RVA: 0x0000322A File Offset: 0x0000142A
		[global::Cpp2ILInjected.Token(Token = "0x60000F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D62F4C", Offset = "0x1D62F4C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteRaw", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public override void WriteRaw(string data)
		{
			throw null;
		}
	}
}
