using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x0200003C RID: 60
	[global::Cpp2ILInjected.Token(Token = "0x200004D")]
	internal class XmlUtf8RawTextWriterIndent : XmlUtf8RawTextWriter
	{
		// Token: 0x06000356 RID: 854 RVA: 0x00003917 File Offset: 0x00001B17
		[global::Cpp2ILInjected.Token(Token = "0x60003B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D82C94", Offset = "0x1D82C94", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(XmlWriterSettings)
		}, ReturnType = typeof(void))]
		public XmlUtf8RawTextWriterIndent(Stream stream, XmlWriterSettings settings)
		{
			throw null;
		}

		// Token: 0x06000357 RID: 855 RVA: 0x0000391A File Offset: 0x00001B1A
		[global::Cpp2ILInjected.Token(Token = "0x60003B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D82DC8", Offset = "0x1D82DC8", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriterIndent), Member = "WriteIndent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteDocType", MemberParameters = new object[]
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

		// Token: 0x06000358 RID: 856 RVA: 0x0000391D File Offset: 0x00001B1D
		[global::Cpp2ILInjected.Token(Token = "0x60003B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D82E70", Offset = "0x1D82E70", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriterIndent), Member = "WriteIndent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitStack), Member = "PushBit", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteStartElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		public override void WriteStartElement(string prefix, string localName, string ns)
		{
			throw null;
		}

		// Token: 0x06000359 RID: 857 RVA: 0x00003920 File Offset: 0x00001B20
		[global::Cpp2ILInjected.Token(Token = "0x60003B4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D82EEC", Offset = "0x1D82EEC", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitStack), Member = "PeekBit", ReturnType = typeof(bool))]
		internal override void StartElementContent()
		{
			throw null;
		}

		// Token: 0x0600035A RID: 858 RVA: 0x00003923 File Offset: 0x00001B23
		[global::Cpp2ILInjected.Token(Token = "0x60003B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D82F54", Offset = "0x1D82F54", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal override void OnRootElement(ConformanceLevel currentConformanceLevel)
		{
			throw null;
		}

		// Token: 0x0600035B RID: 859 RVA: 0x00003926 File Offset: 0x00001B26
		[global::Cpp2ILInjected.Token(Token = "0x60003B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D82F5C", Offset = "0x1D82F5C", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriterIndent), Member = "WriteIndent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitStack), Member = "PopBit", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteEndElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		internal override void WriteEndElement(string prefix, string localName, string ns)
		{
			throw null;
		}

		// Token: 0x0600035C RID: 860 RVA: 0x00003929 File Offset: 0x00001B29
		[global::Cpp2ILInjected.Token(Token = "0x60003B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D82FD4", Offset = "0x1D82FD4", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriterIndent), Member = "WriteIndent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitStack), Member = "PopBit", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteFullEndElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		internal override void WriteFullEndElement(string prefix, string localName, string ns)
		{
			throw null;
		}

		// Token: 0x0600035D RID: 861 RVA: 0x0000392C File Offset: 0x00001B2C
		[global::Cpp2ILInjected.Token(Token = "0x60003B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8304C", Offset = "0x1D8304C", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriterIndent), Member = "WriteIndent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteStartAttribute", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		public override void WriteStartAttribute(string prefix, string localName, string ns)
		{
			throw null;
		}

		// Token: 0x0600035E RID: 862 RVA: 0x0000392F File Offset: 0x00001B2F
		[global::Cpp2ILInjected.Token(Token = "0x60003B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D83088", Offset = "0x1D83088", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteCData", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public override void WriteCData(string text)
		{
			throw null;
		}

		// Token: 0x0600035F RID: 863 RVA: 0x00003932 File Offset: 0x00001B32
		[global::Cpp2ILInjected.Token(Token = "0x60003BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D83094", Offset = "0x1D83094", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriterIndent), Member = "WriteIndent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteComment", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public override void WriteComment(string text)
		{
			throw null;
		}

		// Token: 0x06000360 RID: 864 RVA: 0x00003935 File Offset: 0x00001B35
		[global::Cpp2ILInjected.Token(Token = "0x60003BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D830D4", Offset = "0x1D830D4", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriterIndent), Member = "WriteIndent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteProcessingInstruction", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		public override void WriteProcessingInstruction(string target, string text)
		{
			throw null;
		}

		// Token: 0x06000361 RID: 865 RVA: 0x00003938 File Offset: 0x00001B38
		[global::Cpp2ILInjected.Token(Token = "0x60003BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8311C", Offset = "0x1D8311C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteEntityRef", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public override void WriteEntityRef(string name)
		{
			throw null;
		}

		// Token: 0x06000362 RID: 866 RVA: 0x0000393B File Offset: 0x00001B3B
		[global::Cpp2ILInjected.Token(Token = "0x60003BD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D83128", Offset = "0x1D83128", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteCharEntity", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
		public override void WriteCharEntity(char ch)
		{
			throw null;
		}

		// Token: 0x06000363 RID: 867 RVA: 0x0000393E File Offset: 0x00001B3E
		[global::Cpp2ILInjected.Token(Token = "0x60003BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D83134", Offset = "0x1D83134", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteSurrogateCharEntity", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char)
		}, ReturnType = typeof(void))]
		public override void WriteSurrogateCharEntity(char lowChar, char highChar)
		{
			throw null;
		}

		// Token: 0x06000364 RID: 868 RVA: 0x00003941 File Offset: 0x00001B41
		[global::Cpp2ILInjected.Token(Token = "0x60003BF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D83140", Offset = "0x1D83140", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteWhitespace", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public override void WriteWhitespace(string ws)
		{
			throw null;
		}

		// Token: 0x06000365 RID: 869 RVA: 0x00003944 File Offset: 0x00001B44
		[global::Cpp2ILInjected.Token(Token = "0x60003C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8314C", Offset = "0x1D8314C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public override void WriteString(string text)
		{
			throw null;
		}

		// Token: 0x06000366 RID: 870 RVA: 0x00003947 File Offset: 0x00001B47
		[global::Cpp2ILInjected.Token(Token = "0x60003C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D83158", Offset = "0x1D83158", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteChars", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public override void WriteChars(char[] buffer, int index, int count)
		{
			throw null;
		}

		// Token: 0x06000367 RID: 871 RVA: 0x0000394A File Offset: 0x00001B4A
		[global::Cpp2ILInjected.Token(Token = "0x60003C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D83164", Offset = "0x1D83164", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteRawWithCharChecking", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*)
		}, ReturnType = typeof(void))]
		public unsafe override void WriteRaw(char[] buffer, int index, int count)
		{
			throw null;
		}

		// Token: 0x06000368 RID: 872 RVA: 0x0000394D File Offset: 0x00001B4D
		[global::Cpp2ILInjected.Token(Token = "0x60003C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D83194", Offset = "0x1D83194", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteRaw", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public override void WriteRaw(string data)
		{
			throw null;
		}

		// Token: 0x06000369 RID: 873 RVA: 0x00003950 File Offset: 0x00001B50
		[global::Cpp2ILInjected.Token(Token = "0x60003C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D831A0", Offset = "0x1D831A0", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlRawWriter), Member = "WriteBase64", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public override void WriteBase64(byte[] buffer, int index, int count)
		{
			throw null;
		}

		// Token: 0x0600036A RID: 874 RVA: 0x00003953 File Offset: 0x00001B53
		[global::Cpp2ILInjected.Token(Token = "0x60003C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D82CBC", Offset = "0x1D82CBC", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWriterSettings), Member = "CreateWriter", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(XmlWriter))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitStack), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "ValidateContentChars", MemberParameters = new object[]
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

		// Token: 0x0600036B RID: 875 RVA: 0x00003956 File Offset: 0x00001B56
		[global::Cpp2ILInjected.Token(Token = "0x60003C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D82E28", Offset = "0x1D82E28", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUtf8RawTextWriterIndent), Member = "WriteDocType", MemberParameters = new object[]
		{
			typeof(string),
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUtf8RawTextWriterIndent), Member = "WriteEndElement", MemberParameters = new object[]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUtf8RawTextWriterIndent), Member = "WriteStartAttribute", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUtf8RawTextWriterIndent), Member = "WriteComment", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUtf8RawTextWriterIndent), Member = "WriteProcessingInstruction", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "RawText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		private void WriteIndent()
		{
			throw null;
		}

		// Token: 0x0400013E RID: 318
		[global::Cpp2ILInjected.Token(Token = "0x40001D8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		protected int indentLevel;

		// Token: 0x0400013F RID: 319
		[global::Cpp2ILInjected.Token(Token = "0x40001D9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8C")]
		protected bool newLineOnAttributes;

		// Token: 0x04000140 RID: 320
		[global::Cpp2ILInjected.Token(Token = "0x40001DA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		protected string indentChars;

		// Token: 0x04000141 RID: 321
		[global::Cpp2ILInjected.Token(Token = "0x40001DB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		protected bool mixedContent;

		// Token: 0x04000142 RID: 322
		[global::Cpp2ILInjected.Token(Token = "0x40001DC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		private BitStack mixedContentStack;

		// Token: 0x04000143 RID: 323
		[global::Cpp2ILInjected.Token(Token = "0x40001DD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		protected ConformanceLevel conformanceLevel;
	}
}
