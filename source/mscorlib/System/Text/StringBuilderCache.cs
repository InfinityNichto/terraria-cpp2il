using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Text
{
	// Token: 0x020001F4 RID: 500
	[global::Cpp2ILInjected.Token(Token = "0x2000279")]
	internal static class StringBuilderCache
	{
		// Token: 0x060013CB RID: 5067 RVA: 0x00017C90 File Offset: 0x00015E90
		[global::Cpp2ILInjected.Token(Token = "0x6001585")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD7D38", Offset = "0x1AD7D38", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 23)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static StringBuilder Acquire(int capacity = 16)
		{
			throw null;
		}

		// Token: 0x060013CC RID: 5068 RVA: 0x00017C93 File Offset: 0x00015E93
		[global::Cpp2ILInjected.Token(Token = "0x6001586")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD7DFC", Offset = "0x1AD7DFC", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeFormat), Member = "FormatCustomized", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.TimeSpan),
			typeof(StringBuilder)
		}, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeFormat), Member = "TryFormat", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.Span<char>),
			typeof(ref int),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ParseByFormat", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(ref global::System.__DTString),
			typeof(ref global::System.ParsingInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Version), Member = "TryFormat", MemberParameters = new object[]
		{
			typeof(global::System.Span<char>),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringBuilderCache), Member = "GetStringAndRelease", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.TimeSpanFormat.FormatLiterals), Member = "Init", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.TimeSpanFormat), Member = "TryFormat", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(global::System.Span<char>),
			typeof(ref int),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.TimeSpanFormat), Member = "FormatCustomized", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(StringBuilder)
		}, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.TimeSpanParse), Member = "TryParseByFormat", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.TimeSpanStyles),
			typeof(ref global::System.Globalization.TimeSpanParse.TimeSpanResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Text.RegularExpressions.RegexReplacement", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			"System.Text.RegularExpressions.RegexNode",
			typeof(global::System.Collections.Hashtable)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.IPAddressParser", Member = "IPv6AddressToString", MemberParameters = new object[]
		{
			"System.UInt16[]",
			typeof(uint),
			"System.Span`1<Char>",
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 15)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void Release(StringBuilder sb)
		{
			throw null;
		}

		// Token: 0x060013CD RID: 5069 RVA: 0x00017C96 File Offset: 0x00015E96
		[global::Cpp2ILInjected.Token(Token = "0x6001587")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD7E70", Offset = "0x1AD7E70", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "FormatHelper", MemberParameters = new object[]
		{
			typeof(global::System.IFormatProvider),
			typeof(string),
			typeof(global::System.ParamsArray)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "Join", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Collections.Generic.IEnumerable<string>)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.AggregateException), Member = "get_Message", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeFormat), Member = "Format", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(string),
			typeof(global::System.IFormatProvider),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ParseByFormat", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(ref global::System.__DTString),
			typeof(ref global::System.ParsingInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Version), Member = "ToString", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.BinaryReader), Member = "ReadString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.TimeSpanFormat), Member = "Format", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.KeyValuePair), Member = "PairToString", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Text.RegularExpressions.Regex", Member = "Replace", MemberParameters = new object[]
		{
			"System.Text.RegularExpressions.MatchEvaluator",
			"System.Text.RegularExpressions.Regex",
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Text.RegularExpressions.RegexBoyerMoore", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(bool),
			typeof(global::System.Globalization.CultureInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Text.RegularExpressions.RegexCharClass", Member = "NegateCategory", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Text.RegularExpressions.RegexCharClass", Member = "ToStringClass", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Text.RegularExpressions.RegexParser", Member = "Escape", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Text.RegularExpressions.RegexParser", Member = "AddConcatenate", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Text.RegularExpressions.RegexReplacement", Member = "Replace", MemberParameters = new object[]
		{
			"System.Text.RegularExpressions.Regex",
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.IPAddress", Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.IPAddressParser", Member = "IPv6AddressToString", MemberParameters = new object[]
		{
			"System.UInt16[]",
			typeof(uint)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 18)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilderCache), Member = "Release", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(void))]
		public static string GetStringAndRelease(StringBuilder sb)
		{
			throw null;
		}

		// Token: 0x040008C5 RID: 2245
		[global::System.ThreadStatic]
		[global::Cpp2ILInjected.Token(Token = "0x4000B31")]
		private static StringBuilder t_cachedInstance;
	}
}
