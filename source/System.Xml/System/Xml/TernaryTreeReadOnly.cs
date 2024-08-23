using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x02000028 RID: 40
	[global::Cpp2ILInjected.Token(Token = "0x2000028")]
	internal class TernaryTreeReadOnly
	{
		// Token: 0x060000D5 RID: 213 RVA: 0x000031D0 File Offset: 0x000013D0
		[global::Cpp2ILInjected.Token(Token = "0x60000D5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D5F9C8", Offset = "0x1D5F9C8", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public TernaryTreeReadOnly(byte[] nodeBuffer)
		{
			throw null;
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x000031D3 File Offset: 0x000013D3
		[global::Cpp2ILInjected.Token(Token = "0x60000D6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D5E524", Offset = "0x1D5E524", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HtmlEncodedRawTextWriter), Member = "WriteStartElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HtmlEncodedRawTextWriter), Member = "WriteStartAttribute", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HtmlEncodedRawTextWriterIndent), Member = "WriteStartElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HtmlUtf8RawTextWriter), Member = "WriteStartElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HtmlUtf8RawTextWriter), Member = "WriteStartAttribute", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HtmlUtf8RawTextWriterIndent), Member = "WriteStartElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		public byte FindCaseInsensitiveString(string stringToFind)
		{
			throw null;
		}

		// Token: 0x0400006C RID: 108
		[global::Cpp2ILInjected.Token(Token = "0x400006C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private byte[] nodeBuffer;
	}
}
