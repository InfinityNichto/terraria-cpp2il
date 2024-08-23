using System;
using System.Globalization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Text.RegularExpressions
{
	// Token: 0x0200005E RID: 94
	[global::Cpp2ILInjected.Token(Token = "0x20000B3")]
	internal sealed class RegexBoyerMoore
	{
		// Token: 0x060002ED RID: 749 RVA: 0x00003677 File Offset: 0x00001877
		[global::Cpp2ILInjected.Token(Token = "0x6000388")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAE298", Offset = "0x1EAE298", Length = "0x3F8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexWriter), Member = "RegexCodeFromRegexTree", MemberParameters = new object[] { typeof(RegexTree) }, ReturnType = typeof(RegexCode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Text.StringBuilderCache", Member = "Acquire", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Text.StringBuilderCache", Member = "GetStringAndRelease", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public RegexBoyerMoore(string pattern, bool caseInsensitive, bool rightToLeft, CultureInfo culture)
		{
			throw null;
		}

		// Token: 0x060002EE RID: 750 RVA: 0x0000367A File Offset: 0x0000187A
		[global::Cpp2ILInjected.Token(Token = "0x6000389")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAE690", Offset = "0x1EAE690", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexBoyerMoore), Member = "IsMatch", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CompareOrdinal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		private bool MatchPattern(string text, int index)
		{
			throw null;
		}

		// Token: 0x060002EF RID: 751 RVA: 0x0000367D File Offset: 0x0000187D
		[global::Cpp2ILInjected.Token(Token = "0x600038A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAE794", Offset = "0x1EAE794", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexInterpreter), Member = "FindFirstChar", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexBoyerMoore), Member = "MatchPattern", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(bool))]
		public bool IsMatch(string text, int index, int beglimit, int endlimit)
		{
			throw null;
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x00003680 File Offset: 0x00001880
		[global::Cpp2ILInjected.Token(Token = "0x600038B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAE7E8", Offset = "0x1EAE7E8", Length = "0x26C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexInterpreter), Member = "FindFirstChar", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		public int Scan(string text, int index, int beglimit, int endlimit)
		{
			throw null;
		}

		// Token: 0x04000192 RID: 402
		[global::Cpp2ILInjected.Token(Token = "0x40002CC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public readonly int[] Positive;

		// Token: 0x04000193 RID: 403
		[global::Cpp2ILInjected.Token(Token = "0x40002CD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public readonly int[] NegativeASCII;

		// Token: 0x04000194 RID: 404
		[global::Cpp2ILInjected.Token(Token = "0x40002CE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public readonly int[][] NegativeUnicode;

		// Token: 0x04000195 RID: 405
		[global::Cpp2ILInjected.Token(Token = "0x40002CF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public readonly string Pattern;

		// Token: 0x04000196 RID: 406
		[global::Cpp2ILInjected.Token(Token = "0x40002D0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public readonly int LowASCII;

		// Token: 0x04000197 RID: 407
		[global::Cpp2ILInjected.Token(Token = "0x40002D1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		public readonly int HighASCII;

		// Token: 0x04000198 RID: 408
		[global::Cpp2ILInjected.Token(Token = "0x40002D2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public readonly bool RightToLeft;

		// Token: 0x04000199 RID: 409
		[global::Cpp2ILInjected.Token(Token = "0x40002D3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x39")]
		public readonly bool CaseInsensitive;

		// Token: 0x0400019A RID: 410
		[global::Cpp2ILInjected.Token(Token = "0x40002D4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private readonly CultureInfo _culture;
	}
}
