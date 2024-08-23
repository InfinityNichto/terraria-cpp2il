using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x0200002C RID: 44
	[global::Cpp2ILInjected.Token(Token = "0x200002D")]
	internal class TextUtf8RawTextWriter : XmlUtf8RawTextWriter
	{
		// Token: 0x060000F4 RID: 244 RVA: 0x0000322D File Offset: 0x0000142D
		[global::Cpp2ILInjected.Token(Token = "0x60000F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D62F5C", Offset = "0x1D62F5C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWriterSettings), Member = "CreateWriter", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(XmlWriter))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(XmlWriterSettings)
		}, ReturnType = typeof(void))]
		public TextUtf8RawTextWriter(Stream stream, XmlWriterSettings settings)
		{
			throw null;
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00003230 File Offset: 0x00001430
		[global::Cpp2ILInjected.Token(Token = "0x60000F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D62F64", Offset = "0x1D62F64", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal override void WriteXmlDeclaration(XmlStandalone standalone)
		{
			throw null;
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00003233 File Offset: 0x00001433
		[global::Cpp2ILInjected.Token(Token = "0x60000F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D62F68", Offset = "0x1D62F68", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal override void WriteXmlDeclaration(string xmldecl)
		{
			throw null;
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00003236 File Offset: 0x00001436
		[global::Cpp2ILInjected.Token(Token = "0x60000F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D62F6C", Offset = "0x1D62F6C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void WriteDocType(string name, string pubid, string sysid, string subset)
		{
			throw null;
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00003239 File Offset: 0x00001439
		[global::Cpp2ILInjected.Token(Token = "0x60000FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D62F70", Offset = "0x1D62F70", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void WriteStartElement(string prefix, string localName, string ns)
		{
			throw null;
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x0000323C File Offset: 0x0000143C
		[global::Cpp2ILInjected.Token(Token = "0x60000FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D62F74", Offset = "0x1D62F74", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal override void WriteEndElement(string prefix, string localName, string ns)
		{
			throw null;
		}

		// Token: 0x060000FA RID: 250 RVA: 0x0000323F File Offset: 0x0000143F
		[global::Cpp2ILInjected.Token(Token = "0x60000FC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D62F78", Offset = "0x1D62F78", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal override void WriteFullEndElement(string prefix, string localName, string ns)
		{
			throw null;
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00003242 File Offset: 0x00001442
		[global::Cpp2ILInjected.Token(Token = "0x60000FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D62F7C", Offset = "0x1D62F7C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal override void StartElementContent()
		{
			throw null;
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00003245 File Offset: 0x00001445
		[global::Cpp2ILInjected.Token(Token = "0x60000FE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D62F80", Offset = "0x1D62F80", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void WriteStartAttribute(string prefix, string localName, string ns)
		{
			throw null;
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00003248 File Offset: 0x00001448
		[global::Cpp2ILInjected.Token(Token = "0x60000FF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D62F8C", Offset = "0x1D62F8C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void WriteEndAttribute()
		{
			throw null;
		}

		// Token: 0x060000FE RID: 254 RVA: 0x0000324B File Offset: 0x0000144B
		[global::Cpp2ILInjected.Token(Token = "0x6000100")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D62F94", Offset = "0x1D62F94", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal override void WriteNamespaceDeclaration(string prefix, string ns)
		{
			throw null;
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000FF RID: 255 RVA: 0x0000324E File Offset: 0x0000144E
		[global::Cpp2ILInjected.Token(Token = "0x17000036")]
		internal override bool SupportsNamespaceDeclarationInChunks
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000101")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D62F98", Offset = "0x1D62F98", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00003251 File Offset: 0x00001451
		[global::Cpp2ILInjected.Token(Token = "0x6000102")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D62FA0", Offset = "0x1D62FA0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteRaw", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public override void WriteCData(string text)
		{
			throw null;
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00003254 File Offset: 0x00001454
		[global::Cpp2ILInjected.Token(Token = "0x6000103")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D62FA8", Offset = "0x1D62FA8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void WriteComment(string text)
		{
			throw null;
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00003257 File Offset: 0x00001457
		[global::Cpp2ILInjected.Token(Token = "0x6000104")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D62FAC", Offset = "0x1D62FAC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void WriteProcessingInstruction(string name, string text)
		{
			throw null;
		}

		// Token: 0x06000103 RID: 259 RVA: 0x0000325A File Offset: 0x0000145A
		[global::Cpp2ILInjected.Token(Token = "0x6000105")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D62FB0", Offset = "0x1D62FB0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void WriteEntityRef(string name)
		{
			throw null;
		}

		// Token: 0x06000104 RID: 260 RVA: 0x0000325D File Offset: 0x0000145D
		[global::Cpp2ILInjected.Token(Token = "0x6000106")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D62FB4", Offset = "0x1D62FB4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void WriteCharEntity(char ch)
		{
			throw null;
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00003260 File Offset: 0x00001460
		[global::Cpp2ILInjected.Token(Token = "0x6000107")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D62FB8", Offset = "0x1D62FB8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void WriteSurrogateCharEntity(char lowChar, char highChar)
		{
			throw null;
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00003263 File Offset: 0x00001463
		[global::Cpp2ILInjected.Token(Token = "0x6000108")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D62FBC", Offset = "0x1D62FBC", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteRaw", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public override void WriteWhitespace(string ws)
		{
			throw null;
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00003266 File Offset: 0x00001466
		[global::Cpp2ILInjected.Token(Token = "0x6000109")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D62FD0", Offset = "0x1D62FD0", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteRaw", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public override void WriteString(string textBlock)
		{
			throw null;
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00003269 File Offset: 0x00001469
		[global::Cpp2ILInjected.Token(Token = "0x600010A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D62FE4", Offset = "0x1D62FE4", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteRaw", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public override void WriteChars(char[] buffer, int index, int count)
		{
			throw null;
		}

		// Token: 0x06000109 RID: 265 RVA: 0x0000326C File Offset: 0x0000146C
		[global::Cpp2ILInjected.Token(Token = "0x600010B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D62FF8", Offset = "0x1D62FF8", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteRaw", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public override void WriteRaw(char[] buffer, int index, int count)
		{
			throw null;
		}

		// Token: 0x0600010A RID: 266 RVA: 0x0000326F File Offset: 0x0000146F
		[global::Cpp2ILInjected.Token(Token = "0x600010C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6300C", Offset = "0x1D6300C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteRaw", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public override void WriteRaw(string data)
		{
			throw null;
		}
	}
}
