using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x02000015 RID: 21
	[global::Cpp2ILInjected.Token(Token = "0x2000015")]
	internal class HtmlUtf8RawTextWriterIndent : HtmlUtf8RawTextWriter
	{
		// Token: 0x06000065 RID: 101 RVA: 0x0000314F File Offset: 0x0000134F
		[global::Cpp2ILInjected.Token(Token = "0x6000065")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D61B90", Offset = "0x1D61B90", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWriterSettings), Member = "CreateWriter", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(XmlWriter))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(XmlWriterSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HtmlUtf8RawTextWriter), Member = "Init", MemberParameters = new object[] { typeof(XmlWriterSettings) }, ReturnType = typeof(void))]
		public HtmlUtf8RawTextWriterIndent(Stream stream, XmlWriterSettings settings)
		{
			throw null;
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00003152 File Offset: 0x00001352
		[global::Cpp2ILInjected.Token(Token = "0x6000066")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D61BEC", Offset = "0x1D61BEC", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HtmlUtf8RawTextWriter), Member = "WriteDocType", MemberParameters = new object[]
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

		// Token: 0x06000067 RID: 103 RVA: 0x00003155 File Offset: 0x00001355
		[global::Cpp2ILInjected.Token(Token = "0x6000067")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D61C08", Offset = "0x1D61C08", Length = "0x160")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ByteStack), Member = "Push", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HtmlUtf8RawTextWriterIndent), Member = "WriteIndent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "RawText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TernaryTreeReadOnly), Member = "FindCaseInsensitiveString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WriteStartElement(string prefix, string localName, string ns)
		{
			throw null;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00003158 File Offset: 0x00001358
		[global::Cpp2ILInjected.Token(Token = "0x6000068")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D61DB8", Offset = "0x1D61DB8", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HtmlUtf8RawTextWriterIndent), Member = "WriteIndent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HtmlUtf8RawTextWriter), Member = "WriteMetaElement", ReturnType = typeof(void))]
		internal override void StartElementContent()
		{
			throw null;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x0000315B File Offset: 0x0000135B
		[global::Cpp2ILInjected.Token(Token = "0x6000069")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D61E14", Offset = "0x1D61E14", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HtmlUtf8RawTextWriter), Member = "WriteEndElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HtmlUtf8RawTextWriterIndent), Member = "WriteIndent", ReturnType = typeof(void))]
		internal override void WriteEndElement(string prefix, string localName, string ns)
		{
			throw null;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0000315E File Offset: 0x0000135E
		[global::Cpp2ILInjected.Token(Token = "0x600006A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D61EB4", Offset = "0x1D61EB4", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "RawText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HtmlUtf8RawTextWriterIndent), Member = "WriteIndent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HtmlUtf8RawTextWriter), Member = "WriteStartAttribute", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		public override void WriteStartAttribute(string prefix, string localName, string ns)
		{
			throw null;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00003161 File Offset: 0x00001361
		[global::Cpp2ILInjected.Token(Token = "0x600006B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D61F28", Offset = "0x1D61F28", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "FlushBuffer", ReturnType = typeof(void))]
		protected override void FlushBuffer()
		{
			throw null;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00003164 File Offset: 0x00001364
		[global::Cpp2ILInjected.Token(Token = "0x600006C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D61BD4", Offset = "0x1D61BD4", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void Init(XmlWriterSettings settings)
		{
			throw null;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00003167 File Offset: 0x00001367
		[global::Cpp2ILInjected.Token(Token = "0x600006D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D61D68", Offset = "0x1D61D68", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HtmlUtf8RawTextWriterIndent), Member = "WriteStartElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HtmlUtf8RawTextWriterIndent), Member = "StartElementContent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HtmlUtf8RawTextWriterIndent), Member = "WriteEndElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HtmlUtf8RawTextWriterIndent), Member = "WriteStartAttribute", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "RawText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		private void WriteIndent()
		{
			throw null;
		}

		// Token: 0x04000046 RID: 70
		[global::Cpp2ILInjected.Token(Token = "0x4000046")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB4")]
		private int indentLevel;

		// Token: 0x04000047 RID: 71
		[global::Cpp2ILInjected.Token(Token = "0x4000047")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		private int endBlockPos;

		// Token: 0x04000048 RID: 72
		[global::Cpp2ILInjected.Token(Token = "0x4000048")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
		private string indentChars;

		// Token: 0x04000049 RID: 73
		[global::Cpp2ILInjected.Token(Token = "0x4000049")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
		private bool newLineOnAttributes;
	}
}
