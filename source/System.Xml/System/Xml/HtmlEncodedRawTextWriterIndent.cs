using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x02000012 RID: 18
	[global::Cpp2ILInjected.Token(Token = "0x2000012")]
	internal class HtmlEncodedRawTextWriterIndent : HtmlEncodedRawTextWriter
	{
		// Token: 0x06000043 RID: 67 RVA: 0x000030E9 File Offset: 0x000012E9
		[global::Cpp2ILInjected.Token(Token = "0x6000043")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D60340", Offset = "0x1D60340", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWriterSettings), Member = "CreateWriter", MemberParameters = new object[] { typeof(TextWriter) }, ReturnType = typeof(XmlWriter))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(TextWriter),
			typeof(XmlWriterSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HtmlEncodedRawTextWriter), Member = "Init", MemberParameters = new object[] { typeof(XmlWriterSettings) }, ReturnType = typeof(void))]
		public HtmlEncodedRawTextWriterIndent(TextWriter writer, XmlWriterSettings settings)
		{
			throw null;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000030EC File Offset: 0x000012EC
		[global::Cpp2ILInjected.Token(Token = "0x6000044")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D60398", Offset = "0x1D60398", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWriterSettings), Member = "CreateWriter", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(XmlWriter))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(XmlWriterSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HtmlEncodedRawTextWriter), Member = "Init", MemberParameters = new object[] { typeof(XmlWriterSettings) }, ReturnType = typeof(void))]
		public HtmlEncodedRawTextWriterIndent(Stream stream, XmlWriterSettings settings)
		{
			throw null;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x000030EF File Offset: 0x000012EF
		[global::Cpp2ILInjected.Token(Token = "0x6000045")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D603D8", Offset = "0x1D603D8", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HtmlEncodedRawTextWriter), Member = "WriteDocType", MemberParameters = new object[]
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

		// Token: 0x06000046 RID: 70 RVA: 0x000030F2 File Offset: 0x000012F2
		[global::Cpp2ILInjected.Token(Token = "0x6000046")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D603F4", Offset = "0x1D603F4", Length = "0x170")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "ChangeTextContentMark", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ByteStack), Member = "Push", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HtmlEncodedRawTextWriterIndent), Member = "WriteIndent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "RawText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TernaryTreeReadOnly), Member = "FindCaseInsensitiveString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WriteStartElement(string prefix, string localName, string ns)
		{
			throw null;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000030F5 File Offset: 0x000012F5
		[global::Cpp2ILInjected.Token(Token = "0x6000047")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D605AC", Offset = "0x1D605AC", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HtmlEncodedRawTextWriterIndent), Member = "WriteIndent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HtmlEncodedRawTextWriter), Member = "WriteMetaElement", ReturnType = typeof(void))]
		internal override void StartElementContent()
		{
			throw null;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x000030F8 File Offset: 0x000012F8
		[global::Cpp2ILInjected.Token(Token = "0x6000048")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D60604", Offset = "0x1D60604", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HtmlEncodedRawTextWriter), Member = "WriteEndElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HtmlEncodedRawTextWriterIndent), Member = "WriteIndent", ReturnType = typeof(void))]
		internal override void WriteEndElement(string prefix, string localName, string ns)
		{
			throw null;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000030FB File Offset: 0x000012FB
		[global::Cpp2ILInjected.Token(Token = "0x6000049")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D606A4", Offset = "0x1D606A4", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "RawText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HtmlEncodedRawTextWriterIndent), Member = "WriteIndent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HtmlEncodedRawTextWriter), Member = "WriteStartAttribute", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		public override void WriteStartAttribute(string prefix, string localName, string ns)
		{
			throw null;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000030FE File Offset: 0x000012FE
		[global::Cpp2ILInjected.Token(Token = "0x600004A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D60714", Offset = "0x1D60714", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected override void FlushBuffer()
		{
			throw null;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00003101 File Offset: 0x00001301
		[global::Cpp2ILInjected.Token(Token = "0x600004B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D60380", Offset = "0x1D60380", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void Init(XmlWriterSettings settings)
		{
			throw null;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00003104 File Offset: 0x00001304
		[global::Cpp2ILInjected.Token(Token = "0x600004C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D60564", Offset = "0x1D60564", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HtmlEncodedRawTextWriterIndent), Member = "WriteStartElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HtmlEncodedRawTextWriterIndent), Member = "StartElementContent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HtmlEncodedRawTextWriterIndent), Member = "WriteEndElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HtmlEncodedRawTextWriterIndent), Member = "WriteStartAttribute", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "RawText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		private void WriteIndent()
		{
			throw null;
		}

		// Token: 0x04000037 RID: 55
		[global::Cpp2ILInjected.Token(Token = "0x4000037")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE4")]
		private int indentLevel;

		// Token: 0x04000038 RID: 56
		[global::Cpp2ILInjected.Token(Token = "0x4000038")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
		private int endBlockPos;

		// Token: 0x04000039 RID: 57
		[global::Cpp2ILInjected.Token(Token = "0x4000039")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
		private string indentChars;

		// Token: 0x0400003A RID: 58
		[global::Cpp2ILInjected.Token(Token = "0x400003A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
		private bool newLineOnAttributes;
	}
}
