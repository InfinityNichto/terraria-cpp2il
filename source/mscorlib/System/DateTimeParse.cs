using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x02000086 RID: 134
	[global::Cpp2ILInjected.Token(Token = "0x20000AD")]
	internal static class DateTimeParse
	{
		// Token: 0x06000611 RID: 1553 RVA: 0x00015731 File Offset: 0x00013931
		[global::Cpp2ILInjected.Token(Token = "0x60006AB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C18E74", Offset = "0x1C18E74", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = "ParseExact", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(global::System.IFormatProvider),
			typeof(global::System.Globalization.DateTimeStyles)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeResult), Member = "Init", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "TryParseExact", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "GetDateTimeParseException", MemberParameters = new object[] { typeof(ref global::System.DateTimeResult) }, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal static global::System.DateTime ParseExact(global::System.ReadOnlySpan<char> s, global::System.ReadOnlySpan<char> format, global::System.Globalization.DateTimeFormatInfo dtfi, global::System.Globalization.DateTimeStyles style)
		{
			throw null;
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x00015734 File Offset: 0x00013934
		[global::Cpp2ILInjected.Token(Token = "0x60006AC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1C35C", Offset = "0x1C1C35C", Length = "0x154")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeOffset), Member = "ParseExact", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(global::System.IFormatProvider),
			typeof(global::System.Globalization.DateTimeStyles)
		}, ReturnType = typeof(global::System.DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeResult), Member = "Init", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "TryParseExact", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "GetDateTimeParseException", MemberParameters = new object[] { typeof(ref global::System.DateTimeResult) }, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		internal static global::System.DateTime ParseExact(global::System.ReadOnlySpan<char> s, global::System.ReadOnlySpan<char> format, global::System.Globalization.DateTimeFormatInfo dtfi, global::System.Globalization.DateTimeStyles style, out global::System.TimeSpan offset)
		{
			throw null;
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x00015737 File Offset: 0x00013937
		[global::Cpp2ILInjected.Token(Token = "0x60006AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C19D1C", Offset = "0x1C19D1C", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeResult), Member = "Init", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "TryParseExact", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal static bool TryParseExact(global::System.ReadOnlySpan<char> s, global::System.ReadOnlySpan<char> format, global::System.Globalization.DateTimeFormatInfo dtfi, global::System.Globalization.DateTimeStyles style, out global::System.DateTime result)
		{
			throw null;
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x0001573A File Offset: 0x0001393A
		[global::Cpp2ILInjected.Token(Token = "0x60006AE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1D168", Offset = "0x1C1D168", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeOffset), Member = "TryParseExact", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(global::System.IFormatProvider),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeOffset)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeResult), Member = "Init", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "TryParseExact", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal static bool TryParseExact(global::System.ReadOnlySpan<char> s, global::System.ReadOnlySpan<char> format, global::System.Globalization.DateTimeFormatInfo dtfi, global::System.Globalization.DateTimeStyles style, out global::System.DateTime result, out global::System.TimeSpan offset)
		{
			throw null;
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x0001573D File Offset: 0x0001393D
		[global::Cpp2ILInjected.Token(Token = "0x60006AF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C2272C", Offset = "0x1C2272C", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ParseExact", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.Globalization.DateTimeStyles)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ParseExact", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.TimeSpan)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "TryParseExact", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "TryParseExact", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTime),
			typeof(ref global::System.TimeSpan)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "TryParseExactMultiple", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(string[]),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "DoStrictParse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeResult), Member = "SetFailure", MemberParameters = new object[]
		{
			typeof(global::System.ParseFailureKind),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeResult), Member = "SetBadFormatSpecifierFailure", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal static bool TryParseExact(global::System.ReadOnlySpan<char> s, global::System.ReadOnlySpan<char> format, global::System.Globalization.DateTimeFormatInfo dtfi, global::System.Globalization.DateTimeStyles style, ref global::System.DateTimeResult result)
		{
			throw null;
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x00015740 File Offset: 0x00013940
		[global::Cpp2ILInjected.Token(Token = "0x60006B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1925C", Offset = "0x1C1925C", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeResult), Member = "Init", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "TryParseExactMultiple", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(string[]),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "GetDateTimeParseException", MemberParameters = new object[] { typeof(ref global::System.DateTimeResult) }, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal static global::System.DateTime ParseExactMultiple(global::System.ReadOnlySpan<char> s, string[] formats, global::System.Globalization.DateTimeFormatInfo dtfi, global::System.Globalization.DateTimeStyles style)
		{
			throw null;
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x00015743 File Offset: 0x00013943
		[global::Cpp2ILInjected.Token(Token = "0x60006B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C2316C", Offset = "0x1C2316C", Length = "0x250")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ParseExactMultiple", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(string[]),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.Globalization.DateTimeStyles)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeResult), Member = "Init", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "TryParseExact", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeResult), Member = "SetBadDateTimeFailure", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeResult), Member = "SetFailure", MemberParameters = new object[]
		{
			typeof(global::System.ParseFailureKind),
			typeof(string),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeResult), Member = "SetFailure", MemberParameters = new object[]
		{
			typeof(global::System.ParseFailureKind),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeResult), Member = "SetBadFormatSpecifierFailure", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		internal static bool TryParseExactMultiple(global::System.ReadOnlySpan<char> s, string[] formats, global::System.Globalization.DateTimeFormatInfo dtfi, global::System.Globalization.DateTimeStyles style, ref global::System.DateTimeResult result)
		{
			throw null;
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x00015746 File Offset: 0x00013946
		[global::Cpp2ILInjected.Token(Token = "0x60006B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C233BC", Offset = "0x1C233BC", Length = "0x158")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "GetTimeZoneName", MemberParameters = new object[] { typeof(ref global::System.__DTString) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CompareInfo), Member = "Compare", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(string),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsLetter", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.__DTString), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static bool MatchWord(ref global::System.__DTString str, string target)
		{
			throw null;
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x00015749 File Offset: 0x00013949
		[global::Cpp2ILInjected.Token(Token = "0x60006B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C23514", Offset = "0x1C23514", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ParseByFormat", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(ref global::System.__DTString),
			typeof(ref global::System.ParsingInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "MatchWord", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static bool GetTimeZoneName(ref global::System.__DTString str)
		{
			throw null;
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x0001574C File Offset: 0x0001394C
		[global::Cpp2ILInjected.Token(Token = "0x60006B4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C235C4", Offset = "0x1C235C4", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.__DTString), Member = "GetRegularToken", MemberParameters = new object[]
		{
			typeof(ref global::System.TokenType),
			typeof(ref int),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.__DTString), Member = "GetSeparatorToken", MemberParameters = new object[]
		{
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref int),
			typeof(ref char)
		}, ReturnType = typeof(global::System.TokenType))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.__DTString), Member = "GetNextDigit", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		internal static bool IsDigit(char ch)
		{
			throw null;
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x0001574F File Offset: 0x0001394F
		[global::Cpp2ILInjected.Token(Token = "0x60006B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C235D8", Offset = "0x1C235D8", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "Lex", MemberParameters = new object[]
		{
			typeof(global::System.DateTimeParse.DS),
			typeof(ref global::System.__DTString),
			typeof(ref global::System.DateTimeToken),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.Globalization.DateTimeStyles)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ParseISO8601", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeRawInfo),
			typeof(ref global::System.__DTString),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.__DTString), Member = "GetNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static bool ParseFraction(ref global::System.__DTString str, out double result)
		{
			throw null;
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x00015752 File Offset: 0x00013952
		[global::Cpp2ILInjected.Token(Token = "0x60006B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C236A4", Offset = "0x1C236A4", Length = "0x228")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "HandleTimeZone", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "Lex", MemberParameters = new object[]
		{
			typeof(global::System.DateTimeParse.DS),
			typeof(ref global::System.__DTString),
			typeof(ref global::System.DateTimeToken),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.Globalization.DateTimeStyles)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ParseISO8601", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeRawInfo),
			typeof(ref global::System.__DTString),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.__DTString), Member = "GetSubString", ReturnType = typeof(global::System.DTSubString))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DTSubString), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.__DTString), Member = "ConsumeSubString", MemberParameters = new object[] { typeof(global::System.DTSubString) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = "Negate", ReturnType = typeof(global::System.TimeSpan))]
		private static bool ParseTimeZone(ref global::System.__DTString str, ref global::System.TimeSpan result)
		{
			throw null;
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x00015755 File Offset: 0x00013955
		[global::Cpp2ILInjected.Token(Token = "0x60006B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C238CC", Offset = "0x1C238CC", Length = "0x14C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "Lex", MemberParameters = new object[]
		{
			typeof(global::System.DateTimeParse.DS),
			typeof(ref global::System.__DTString),
			typeof(ref global::System.DateTimeToken),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.Globalization.DateTimeStyles)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.__DTString), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "ParseTimeZone", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(ref global::System.TimeSpan)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeResult), Member = "SetBadDateTimeFailure", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static bool HandleTimeZone(ref global::System.__DTString str, ref global::System.DateTimeResult result)
		{
			throw null;
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x00015758 File Offset: 0x00013958
		[global::Cpp2ILInjected.Token(Token = "0x60006B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C23A18", Offset = "0x1C23A18", Length = "0xB30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.__DTString), Member = "GetRegularToken", MemberParameters = new object[]
		{
			typeof(ref global::System.TokenType),
			typeof(ref int),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.__DTString), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "ParseFraction", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(ref double)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "HandleTimeZone", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.__DTString), Member = "GetSeparatorToken", MemberParameters = new object[]
		{
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref int),
			typeof(ref char)
		}, ReturnType = typeof(global::System.TokenType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeRawInfo), Member = "AddNumber", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "GetTaiwanCalendarDefaultInstance", ReturnType = typeof(global::System.Globalization.Calendar))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "GetTaiwanCalendarDTFI", ReturnType = typeof(global::System.Globalization.DateTimeFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "GetJapaneseCalendarDefaultInstance", ReturnType = typeof(global::System.Globalization.Calendar))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "GetJapaneseCalendarDTFI", ReturnType = typeof(global::System.Globalization.DateTimeFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsLetter", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeResult), Member = "SetFailure", MemberParameters = new object[]
		{
			typeof(global::System.ParseFailureKind),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "ParseTimeZone", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(ref global::System.TimeSpan)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "VerifyValidPunctuation", MemberParameters = new object[] { typeof(ref global::System.__DTString) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeResult), Member = "SetBadDateTimeFailure", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "ProcessTerminalState", MemberParameters = new object[]
		{
			typeof(global::System.DateTimeParse.DS),
			typeof(ref global::System.__DTString),
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 47)]
		private static bool Lex(global::System.DateTimeParse.DS dps, ref global::System.__DTString str, ref global::System.DateTimeToken dtok, ref global::System.DateTimeRawInfo raw, ref global::System.DateTimeResult result, ref global::System.Globalization.DateTimeFormatInfo dtfi, global::System.Globalization.DateTimeStyles styles)
		{
			throw null;
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x0001575B File Offset: 0x0001395B
		[global::Cpp2ILInjected.Token(Token = "0x60006B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C2484C", Offset = "0x1C2484C", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "Lex", MemberParameters = new object[]
		{
			typeof(global::System.DateTimeParse.DS),
			typeof(ref global::System.__DTString),
			typeof(ref global::System.DateTimeToken),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.Globalization.DateTimeStyles)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.JapaneseCalendar), Member = "GetDefaultInstance", ReturnType = typeof(global::System.Globalization.Calendar))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private static global::System.Globalization.Calendar GetJapaneseCalendarDefaultInstance()
		{
			throw null;
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x0001575E File Offset: 0x0001395E
		[global::Cpp2ILInjected.Token(Token = "0x60006BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C24934", Offset = "0x1C24934", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "Lex", MemberParameters = new object[]
		{
			typeof(global::System.DateTimeParse.DS),
			typeof(ref global::System.__DTString),
			typeof(ref global::System.DateTimeToken),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.Globalization.DateTimeStyles)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.TaiwanCalendar), Member = "GetDefaultInstance", ReturnType = typeof(global::System.Globalization.Calendar))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		internal static global::System.Globalization.Calendar GetTaiwanCalendarDefaultInstance()
		{
			throw null;
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x00015761 File Offset: 0x00013961
		[global::Cpp2ILInjected.Token(Token = "0x60006BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C24A1C", Offset = "0x1C24A1C", Length = "0x160")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "Lex", MemberParameters = new object[]
		{
			typeof(global::System.DateTimeParse.DS),
			typeof(ref global::System.__DTString),
			typeof(ref global::System.DateTimeToken),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.Globalization.DateTimeStyles)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ParseISO8601", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeRawInfo),
			typeof(ref global::System.__DTString),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.__DTString), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.__DTString), Member = "GetNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static bool VerifyValidPunctuation(ref global::System.__DTString str)
		{
			throw null;
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x00015764 File Offset: 0x00013964
		[global::Cpp2ILInjected.Token(Token = "0x60006BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C24B7C", Offset = "0x1C24B7C", Length = "0x28C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "GetDayOfNNN", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "GetDayOfMNN", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "GetDayOfYNN", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "GetDayOfNNY", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "GetDateOfNNDS", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		private static bool GetYearMonthDayOrder(string datePattern, global::System.Globalization.DateTimeFormatInfo dtfi, out int order)
		{
			throw null;
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x00015767 File Offset: 0x00013967
		[global::Cpp2ILInjected.Token(Token = "0x60006BD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C24E08", Offset = "0x1C24E08", Length = "0x1A4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "GetDayOfMN", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "GetDayOfNM", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		private static bool GetYearMonthOrder(string pattern, global::System.Globalization.DateTimeFormatInfo dtfi, out int order)
		{
			throw null;
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x0001576A File Offset: 0x0001396A
		[global::Cpp2ILInjected.Token(Token = "0x60006BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C24FAC", Offset = "0x1C24FAC", Length = "0x1E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "GetDayOfNN", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "GetDayOfMN", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "GetHebrewDayOfNM", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "GetDayOfNM", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		private static bool GetMonthDayOrder(string pattern, global::System.Globalization.DateTimeFormatInfo dtfi, out int order)
		{
			throw null;
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x0001576D File Offset: 0x0001396D
		[global::Cpp2ILInjected.Token(Token = "0x60006BF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C25194", Offset = "0x1C25194", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "GetDayOfNNN", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "GetDayOfMN", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "GetDayOfNM", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "GetDayOfMNN", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "GetDateOfNDS", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.DateTimeRawInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "GetDateOfNNDS", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private static bool TryAdjustYear(ref global::System.DateTimeResult result, int year, out int adjustedYear)
		{
			throw null;
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x00015770 File Offset: 0x00013970
		[global::Cpp2ILInjected.Token(Token = "0x60006C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C2524C", Offset = "0x1C2524C", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "SetDateMDY", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "SetDateDMY", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "SetDateYDM", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "GetDayOfNN", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "GetDayOfNNN", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "GetDayOfMN", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "GetDayOfNM", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "GetDayOfYNN", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "GetDayOfNNY", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "GetDayOfYMN", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.DateTimeRawInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "GetDayOfYN", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.DateTimeRawInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "GetDayOfYM", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.DateTimeRawInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "GetDateOfNNDS", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 15)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeResult), Member = "SetDate", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		private static bool SetDateYMD(ref global::System.DateTimeResult result, int year, int month, int day)
		{
			throw null;
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x00015773 File Offset: 0x00013973
		[global::Cpp2ILInjected.Token(Token = "0x60006C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C252B8", Offset = "0x1C252B8", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "GetDayOfNNN", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "SetDateYMD", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static bool SetDateMDY(ref global::System.DateTimeResult result, int month, int day, int year)
		{
			throw null;
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x00015776 File Offset: 0x00013976
		[global::Cpp2ILInjected.Token(Token = "0x60006C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C25334", Offset = "0x1C25334", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "GetDayOfNNN", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "SetDateYMD", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static bool SetDateDMY(ref global::System.DateTimeResult result, int day, int month, int year)
		{
			throw null;
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x00015779 File Offset: 0x00013979
		[global::Cpp2ILInjected.Token(Token = "0x60006C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C253B0", Offset = "0x1C253B0", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "GetDayOfNNN", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "SetDateYMD", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static bool SetDateYDM(ref global::System.DateTimeResult result, int year, int day, int month)
		{
			throw null;
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x0001577C File Offset: 0x0001397C
		[global::Cpp2ILInjected.Token(Token = "0x60006C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C2542C", Offset = "0x1C2542C", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "GetDayOfNN", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "GetDayOfMN", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "GetDayOfNM", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ProcessHebrewTerminalState", MemberParameters = new object[]
		{
			typeof(global::System.DateTimeParse.DS),
			typeof(ref global::System.__DTString),
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "GetDateTimeNow", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.Globalization.DateTimeStyles)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static void GetDefaultYear(ref global::System.DateTimeResult result, ref global::System.Globalization.DateTimeStyles styles)
		{
			throw null;
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x0001577F File Offset: 0x0001397F
		[global::Cpp2ILInjected.Token(Token = "0x60006C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C25588", Offset = "0x1C25588", Length = "0x16C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ProcessTerminalState", MemberParameters = new object[]
		{
			typeof(global::System.DateTimeParse.DS),
			typeof(ref global::System.__DTString),
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeRawInfo), Member = "GetNumber", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "GetDefaultYear", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.Globalization.DateTimeStyles)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "get_MonthDayPattern", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "GetMonthDayOrder", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeResult), Member = "SetFailure", MemberParameters = new object[]
		{
			typeof(global::System.ParseFailureKind),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "SetDateYMD", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeResult), Member = "SetBadDateTimeFailure", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static bool GetDayOfNN(ref global::System.DateTimeResult result, ref global::System.Globalization.DateTimeStyles styles, ref global::System.DateTimeRawInfo raw, global::System.Globalization.DateTimeFormatInfo dtfi)
		{
			throw null;
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x00015782 File Offset: 0x00013982
		[global::Cpp2ILInjected.Token(Token = "0x60006C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C256F4", Offset = "0x1C256F4", Length = "0x2AC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ProcessTerminalState", MemberParameters = new object[]
		{
			typeof(global::System.DateTimeParse.DS),
			typeof(ref global::System.__DTString),
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeRawInfo), Member = "GetNumber", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "get_ShortDatePattern", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "GetYearMonthDayOrder", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "TryAdjustYear", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "SetDateYMD", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeResult), Member = "SetFailure", MemberParameters = new object[]
		{
			typeof(global::System.ParseFailureKind),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "SetDateMDY", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "SetDateDMY", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "SetDateYDM", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeResult), Member = "SetBadDateTimeFailure", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private static bool GetDayOfNNN(ref global::System.DateTimeResult result, ref global::System.DateTimeRawInfo raw, global::System.Globalization.DateTimeFormatInfo dtfi)
		{
			throw null;
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x00015785 File Offset: 0x00013985
		[global::Cpp2ILInjected.Token(Token = "0x60006C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C259A0", Offset = "0x1C259A0", Length = "0x21C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ProcessTerminalState", MemberParameters = new object[]
		{
			typeof(global::System.DateTimeParse.DS),
			typeof(ref global::System.__DTString),
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "get_MonthDayPattern", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "GetMonthDayOrder", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "get_YearMonthPattern", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "GetYearMonthOrder", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeRawInfo), Member = "GetNumber", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "TryAdjustYear", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "SetDateYMD", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeResult), Member = "SetFailure", MemberParameters = new object[]
		{
			typeof(global::System.ParseFailureKind),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "GetDefaultYear", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.Globalization.DateTimeStyles)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeResult), Member = "SetBadDateTimeFailure", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private static bool GetDayOfMN(ref global::System.DateTimeResult result, ref global::System.Globalization.DateTimeStyles styles, ref global::System.DateTimeRawInfo raw, global::System.Globalization.DateTimeFormatInfo dtfi)
		{
			throw null;
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x00015788 File Offset: 0x00013988
		[global::Cpp2ILInjected.Token(Token = "0x60006C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C25BBC", Offset = "0x1C25BBC", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ProcessHebrewTerminalState", MemberParameters = new object[]
		{
			typeof(global::System.DateTimeParse.DS),
			typeof(ref global::System.__DTString),
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "get_MonthDayPattern", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "GetMonthDayOrder", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeRawInfo), Member = "GetNumber", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeResult), Member = "SetFailure", MemberParameters = new object[]
		{
			typeof(global::System.ParseFailureKind),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeResult), Member = "SetBadDateTimeFailure", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static bool GetHebrewDayOfNM(ref global::System.DateTimeResult result, ref global::System.DateTimeRawInfo raw, global::System.Globalization.DateTimeFormatInfo dtfi)
		{
			throw null;
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x0001578B File Offset: 0x0001398B
		[global::Cpp2ILInjected.Token(Token = "0x60006C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C25D0C", Offset = "0x1C25D0C", Length = "0x21C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ProcessTerminalState", MemberParameters = new object[]
		{
			typeof(global::System.DateTimeParse.DS),
			typeof(ref global::System.__DTString),
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "get_MonthDayPattern", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "GetMonthDayOrder", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "get_YearMonthPattern", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "GetYearMonthOrder", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeRawInfo), Member = "GetNumber", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "TryAdjustYear", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "SetDateYMD", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeResult), Member = "SetFailure", MemberParameters = new object[]
		{
			typeof(global::System.ParseFailureKind),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "GetDefaultYear", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.Globalization.DateTimeStyles)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeResult), Member = "SetBadDateTimeFailure", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private static bool GetDayOfNM(ref global::System.DateTimeResult result, ref global::System.Globalization.DateTimeStyles styles, ref global::System.DateTimeRawInfo raw, global::System.Globalization.DateTimeFormatInfo dtfi)
		{
			throw null;
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x0001578E File Offset: 0x0001398E
		[global::Cpp2ILInjected.Token(Token = "0x60006CA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C25F28", Offset = "0x1C25F28", Length = "0x2CC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ProcessHebrewTerminalState", MemberParameters = new object[]
		{
			typeof(global::System.DateTimeParse.DS),
			typeof(ref global::System.__DTString),
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ProcessTerminalState", MemberParameters = new object[]
		{
			typeof(global::System.DateTimeParse.DS),
			typeof(ref global::System.__DTString),
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeRawInfo), Member = "GetNumber", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "get_ShortDatePattern", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "GetYearMonthDayOrder", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "TryAdjustYear", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeResult), Member = "SetFailure", MemberParameters = new object[]
		{
			typeof(global::System.ParseFailureKind),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeResult), Member = "SetDate", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeResult), Member = "SetBadDateTimeFailure", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private static bool GetDayOfMNN(ref global::System.DateTimeResult result, ref global::System.DateTimeRawInfo raw, global::System.Globalization.DateTimeFormatInfo dtfi)
		{
			throw null;
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x00015791 File Offset: 0x00013991
		[global::Cpp2ILInjected.Token(Token = "0x60006CB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C261F4", Offset = "0x1C261F4", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ProcessTerminalState", MemberParameters = new object[]
		{
			typeof(global::System.DateTimeParse.DS),
			typeof(ref global::System.__DTString),
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeRawInfo), Member = "GetNumber", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "get_ShortDatePattern", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "GetYearMonthDayOrder", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "SetDateYMD", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeResult), Member = "SetBadDateTimeFailure", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static bool GetDayOfYNN(ref global::System.DateTimeResult result, ref global::System.DateTimeRawInfo raw, global::System.Globalization.DateTimeFormatInfo dtfi)
		{
			throw null;
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x00015794 File Offset: 0x00013994
		[global::Cpp2ILInjected.Token(Token = "0x60006CC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C26324", Offset = "0x1C26324", Length = "0x16C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ProcessHebrewTerminalState", MemberParameters = new object[]
		{
			typeof(global::System.DateTimeParse.DS),
			typeof(ref global::System.__DTString),
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ProcessTerminalState", MemberParameters = new object[]
		{
			typeof(global::System.DateTimeParse.DS),
			typeof(ref global::System.__DTString),
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeRawInfo), Member = "GetNumber", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "get_ShortDatePattern", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "GetYearMonthDayOrder", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeResult), Member = "SetFailure", MemberParameters = new object[]
		{
			typeof(global::System.ParseFailureKind),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "SetDateYMD", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeResult), Member = "SetBadDateTimeFailure", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static bool GetDayOfNNY(ref global::System.DateTimeResult result, ref global::System.DateTimeRawInfo raw, global::System.Globalization.DateTimeFormatInfo dtfi)
		{
			throw null;
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x00015797 File Offset: 0x00013997
		[global::Cpp2ILInjected.Token(Token = "0x60006CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C26490", Offset = "0x1C26490", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ProcessHebrewTerminalState", MemberParameters = new object[]
		{
			typeof(global::System.DateTimeParse.DS),
			typeof(ref global::System.__DTString),
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ProcessTerminalState", MemberParameters = new object[]
		{
			typeof(global::System.DateTimeParse.DS),
			typeof(ref global::System.__DTString),
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeRawInfo), Member = "GetNumber", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "SetDateYMD", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeResult), Member = "SetBadDateTimeFailure", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static bool GetDayOfYMN(ref global::System.DateTimeResult result, ref global::System.DateTimeRawInfo raw)
		{
			throw null;
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x0001579A File Offset: 0x0001399A
		[global::Cpp2ILInjected.Token(Token = "0x60006CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C2654C", Offset = "0x1C2654C", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ProcessTerminalState", MemberParameters = new object[]
		{
			typeof(global::System.DateTimeParse.DS),
			typeof(ref global::System.__DTString),
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeRawInfo), Member = "GetNumber", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "SetDateYMD", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeResult), Member = "SetBadDateTimeFailure", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static bool GetDayOfYN(ref global::System.DateTimeResult result, ref global::System.DateTimeRawInfo raw)
		{
			throw null;
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x0001579D File Offset: 0x0001399D
		[global::Cpp2ILInjected.Token(Token = "0x60006CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C26608", Offset = "0x1C26608", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ProcessHebrewTerminalState", MemberParameters = new object[]
		{
			typeof(global::System.DateTimeParse.DS),
			typeof(ref global::System.__DTString),
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ProcessTerminalState", MemberParameters = new object[]
		{
			typeof(global::System.DateTimeParse.DS),
			typeof(ref global::System.__DTString),
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "SetDateYMD", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeResult), Member = "SetBadDateTimeFailure", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static bool GetDayOfYM(ref global::System.DateTimeResult result, ref global::System.DateTimeRawInfo raw)
		{
			throw null;
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x000157A0 File Offset: 0x000139A0
		[global::Cpp2ILInjected.Token(Token = "0x60006D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C266A4", Offset = "0x1C266A4", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "get_AMDesignator", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "get_PMDesignator", ReturnType = typeof(string))]
		private static void AdjustTimeMark(global::System.Globalization.DateTimeFormatInfo dtfi, ref global::System.DateTimeRawInfo raw)
		{
			throw null;
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x000157A3 File Offset: 0x000139A3
		[global::Cpp2ILInjected.Token(Token = "0x60006D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C26748", Offset = "0x1C26748", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static bool AdjustHour(ref int hour, global::System.DateTimeParse.TM timeMark)
		{
			throw null;
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x000157A6 File Offset: 0x000139A6
		[global::Cpp2ILInjected.Token(Token = "0x60006D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C26790", Offset = "0x1C26790", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ProcessHebrewTerminalState", MemberParameters = new object[]
		{
			typeof(global::System.DateTimeParse.DS),
			typeof(ref global::System.__DTString),
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ProcessTerminalState", MemberParameters = new object[]
		{
			typeof(global::System.DateTimeParse.DS),
			typeof(ref global::System.__DTString),
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeRawInfo), Member = "GetNumber", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeResult), Member = "SetBadDateTimeFailure", ReturnType = typeof(void))]
		private static bool GetTimeOfN(ref global::System.DateTimeResult result, ref global::System.DateTimeRawInfo raw)
		{
			throw null;
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x000157A9 File Offset: 0x000139A9
		[global::Cpp2ILInjected.Token(Token = "0x60006D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C267EC", Offset = "0x1C267EC", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ProcessHebrewTerminalState", MemberParameters = new object[]
		{
			typeof(global::System.DateTimeParse.DS),
			typeof(ref global::System.__DTString),
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ProcessTerminalState", MemberParameters = new object[]
		{
			typeof(global::System.DateTimeParse.DS),
			typeof(ref global::System.__DTString),
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeRawInfo), Member = "GetNumber", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeResult), Member = "SetBadDateTimeFailure", ReturnType = typeof(void))]
		private static bool GetTimeOfNN(ref global::System.DateTimeResult result, ref global::System.DateTimeRawInfo raw)
		{
			throw null;
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x000157AC File Offset: 0x000139AC
		[global::Cpp2ILInjected.Token(Token = "0x60006D4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C26860", Offset = "0x1C26860", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ProcessHebrewTerminalState", MemberParameters = new object[]
		{
			typeof(global::System.DateTimeParse.DS),
			typeof(ref global::System.__DTString),
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ProcessTerminalState", MemberParameters = new object[]
		{
			typeof(global::System.DateTimeParse.DS),
			typeof(ref global::System.__DTString),
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeRawInfo), Member = "GetNumber", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeResult), Member = "SetBadDateTimeFailure", ReturnType = typeof(void))]
		private static bool GetTimeOfNNN(ref global::System.DateTimeResult result, ref global::System.DateTimeRawInfo raw)
		{
			throw null;
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x000157AF File Offset: 0x000139AF
		[global::Cpp2ILInjected.Token(Token = "0x60006D5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C268E8", Offset = "0x1C268E8", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ProcessTerminalState", MemberParameters = new object[]
		{
			typeof(global::System.DateTimeParse.DS),
			typeof(ref global::System.__DTString),
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeResult), Member = "SetBadDateTimeFailure", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeRawInfo), Member = "GetNumber", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		private static bool GetDateOfDSN(ref global::System.DateTimeResult result, ref global::System.DateTimeRawInfo raw)
		{
			throw null;
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x000157B2 File Offset: 0x000139B2
		[global::Cpp2ILInjected.Token(Token = "0x60006D6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C2693C", Offset = "0x1C2693C", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ProcessTerminalState", MemberParameters = new object[]
		{
			typeof(global::System.DateTimeParse.DS),
			typeof(ref global::System.__DTString),
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeRawInfo), Member = "GetNumber", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "TryAdjustYear", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeResult), Member = "SetBadDateTimeFailure", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static bool GetDateOfNDS(ref global::System.DateTimeResult result, ref global::System.DateTimeRawInfo raw)
		{
			throw null;
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x000157B5 File Offset: 0x000139B5
		[global::Cpp2ILInjected.Token(Token = "0x60006D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C269F0", Offset = "0x1C269F0", Length = "0x21C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ProcessTerminalState", MemberParameters = new object[]
		{
			typeof(global::System.DateTimeParse.DS),
			typeof(ref global::System.__DTString),
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "get_ShortDatePattern", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "GetYearMonthDayOrder", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeRawInfo), Member = "GetNumber", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "TryAdjustYear", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "SetDateYMD", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeResult), Member = "SetFailure", MemberParameters = new object[]
		{
			typeof(global::System.ParseFailureKind),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeResult), Member = "SetBadDateTimeFailure", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private static bool GetDateOfNNDS(ref global::System.DateTimeResult result, ref global::System.DateTimeRawInfo raw, global::System.Globalization.DateTimeFormatInfo dtfi)
		{
			throw null;
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x000157B8 File Offset: 0x000139B8
		[global::Cpp2ILInjected.Token(Token = "0x60006D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C26C0C", Offset = "0x1C26C0C", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		private static bool ProcessDateTimeSuffix(ref global::System.DateTimeResult result, ref global::System.DateTimeRawInfo raw, ref global::System.DateTimeToken dtok)
		{
			throw null;
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x000157BB File Offset: 0x000139BB
		[global::Cpp2ILInjected.Token(Token = "0x60006D9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C26D04", Offset = "0x1C26D04", Length = "0x32C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "GetDefaultYear", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.Globalization.DateTimeStyles)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "YearMonthAdjustment", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "GetHebrewDayOfNM", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeRawInfo), Member = "GetNumber", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "GetDayOfMNN", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeResult), Member = "SetBadDateTimeFailure", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "GetDayOfYMN", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.DateTimeRawInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "GetDayOfYM", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.DateTimeRawInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "GetTimeOfN", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.DateTimeRawInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "GetTimeOfNN", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.DateTimeRawInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "GetTimeOfNNN", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.DateTimeRawInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "GetDayOfNNY", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeResult), Member = "SetFailure", MemberParameters = new object[]
		{
			typeof(global::System.ParseFailureKind),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		internal static bool ProcessHebrewTerminalState(global::System.DateTimeParse.DS dps, ref global::System.__DTString str, ref global::System.DateTimeResult result, ref global::System.Globalization.DateTimeStyles styles, ref global::System.DateTimeRawInfo raw, global::System.Globalization.DateTimeFormatInfo dtfi)
		{
			throw null;
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x000157BE File Offset: 0x000139BE
		[global::Cpp2ILInjected.Token(Token = "0x60006DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C24548", Offset = "0x1C24548", Length = "0x304")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "Lex", MemberParameters = new object[]
		{
			typeof(global::System.DateTimeParse.DS),
			typeof(ref global::System.__DTString),
			typeof(ref global::System.DateTimeToken),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.Globalization.DateTimeStyles)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "GetDayOfNN", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "GetDayOfNNN", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "GetDayOfMN", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "GetDayOfNM", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "GetDayOfMNN", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "GetDateOfDSN", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.DateTimeRawInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "GetDateOfNDS", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.DateTimeRawInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "GetDateOfNNDS", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "GetDayOfYNN", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "GetDayOfYMN", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.DateTimeRawInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "GetDayOfYN", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.DateTimeRawInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "GetDayOfYM", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.DateTimeRawInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "GetTimeOfN", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.DateTimeRawInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "GetTimeOfNN", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.DateTimeRawInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "GetTimeOfNNN", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.DateTimeRawInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "GetDayOfNNY", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		internal static bool ProcessTerminalState(global::System.DateTimeParse.DS dps, ref global::System.__DTString str, ref global::System.DateTimeResult result, ref global::System.Globalization.DateTimeStyles styles, ref global::System.DateTimeRawInfo raw, global::System.Globalization.DateTimeFormatInfo dtfi)
		{
			throw null;
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x000157C1 File Offset: 0x000139C1
		[global::Cpp2ILInjected.Token(Token = "0x60006DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C18AF0", Offset = "0x1C18AF0", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider),
			typeof(global::System.Globalization.DateTimeStyles)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeResult), Member = "Init", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "GetDateTimeParseException", MemberParameters = new object[] { typeof(ref global::System.DateTimeResult) }, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal static global::System.DateTime Parse(global::System.ReadOnlySpan<char> s, global::System.Globalization.DateTimeFormatInfo dtfi, global::System.Globalization.DateTimeStyles styles)
		{
			throw null;
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x000157C4 File Offset: 0x000139C4
		[global::Cpp2ILInjected.Token(Token = "0x60006DC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1C07C", Offset = "0x1C1C07C", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeOffset), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider),
			typeof(global::System.Globalization.DateTimeStyles)
		}, ReturnType = typeof(global::System.DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeResult), Member = "Init", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "GetDateTimeParseException", MemberParameters = new object[] { typeof(ref global::System.DateTimeResult) }, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal static global::System.DateTime Parse(global::System.ReadOnlySpan<char> s, global::System.Globalization.DateTimeFormatInfo dtfi, global::System.Globalization.DateTimeStyles styles, out global::System.TimeSpan offset)
		{
			throw null;
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x000157C7 File Offset: 0x000139C7
		[global::Cpp2ILInjected.Token(Token = "0x60006DD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C19A74", Offset = "0x1C19A74", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeResult), Member = "Init", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal static bool TryParse(global::System.ReadOnlySpan<char> s, global::System.Globalization.DateTimeFormatInfo dtfi, global::System.Globalization.DateTimeStyles styles, out global::System.DateTime result)
		{
			throw null;
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x000157CA File Offset: 0x000139CA
		[global::Cpp2ILInjected.Token(Token = "0x60006DE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1CE34", Offset = "0x1C1CE34", Length = "0x16C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeOffset), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeOffset)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeResult), Member = "Init", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal static bool TryParse(global::System.ReadOnlySpan<char> s, global::System.Globalization.DateTimeFormatInfo dtfi, global::System.Globalization.DateTimeStyles styles, out global::System.DateTime result, out global::System.TimeSpan offset)
		{
			throw null;
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x000157CD File Offset: 0x000139CD
		[global::Cpp2ILInjected.Token(Token = "0x60006DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C27030", Offset = "0x1C27030", Length = "0x6E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "Parse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.Globalization.DateTimeStyles)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "Parse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.TimeSpan)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTime),
			typeof(ref global::System.TimeSpan)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeRawInfo), Member = "Init", MemberParameters = new object[] { typeof(int*) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "get_DateSeparator", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "get_TimeSeparator", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.StringComparison)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.__DTString), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.__DTString), Member = "GetNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "Lex", MemberParameters = new object[]
		{
			typeof(global::System.DateTimeParse.DS),
			typeof(ref global::System.__DTString),
			typeof(ref global::System.DateTimeToken),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.Globalization.DateTimeStyles)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "ProcessDateTimeSuffix", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(ref global::System.DateTimeToken)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.__DTString), Member = "AtEnd", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "get_FormatFlags", ReturnType = typeof(global::System.Globalization.DateTimeFormatFlags))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "ProcessTerminalState", MemberParameters = new object[]
		{
			typeof(global::System.DateTimeParse.DS),
			typeof(ref global::System.__DTString),
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "ProcessHebrewTerminalState", MemberParameters = new object[]
		{
			typeof(global::System.DateTimeParse.DS),
			typeof(ref global::System.__DTString),
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "AdjustTimeMark", MemberParameters = new object[]
		{
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref global::System.DateTimeRawInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeResult), Member = "SetFailure", MemberParameters = new object[]
		{
			typeof(global::System.ParseFailureKind),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "ParseISO8601", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeRawInfo),
			typeof(ref global::System.__DTString),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "CheckDefaultDateTime", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.Globalization.Calendar),
			typeof(global::System.Globalization.DateTimeStyles)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeResult), Member = "SetBadDateTimeFailure", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "AddTicks", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "DetermineTimeZoneAdjustments", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(ref global::System.DateTimeResult),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		internal unsafe static bool TryParse(global::System.ReadOnlySpan<char> s, global::System.Globalization.DateTimeFormatInfo dtfi, global::System.Globalization.DateTimeStyles styles, ref global::System.DateTimeResult result)
		{
			throw null;
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x000157D0 File Offset: 0x000139D0
		[global::Cpp2ILInjected.Token(Token = "0x60006E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C27E7C", Offset = "0x1C27E7C", Length = "0x254")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ParseISO8601", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeRawInfo),
			typeof(ref global::System.__DTString),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "DoStrictParse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeResult), Member = "SetFailure", MemberParameters = new object[]
		{
			typeof(global::System.ParseFailureKind),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(long),
			typeof(global::System.DateTimeKind)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "GetLocalUtcOffset", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfoOptions)
		}, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "AdjustTimeZoneToLocal", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "AdjustTimeZoneToUniversal", MemberParameters = new object[] { typeof(ref global::System.DateTimeResult) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private static bool DetermineTimeZoneAdjustments(ref global::System.__DTString str, ref global::System.DateTimeResult result, global::System.Globalization.DateTimeStyles styles, bool bTimeOnly)
		{
			throw null;
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x000157D3 File Offset: 0x000139D3
		[global::Cpp2ILInjected.Token(Token = "0x60006E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C280D0", Offset = "0x1C280D0", Length = "0x1FC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "GetLocalUtcOffset", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfoOptions)
		}, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(long),
			typeof(global::System.DateTimeKind)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeResult), Member = "SetFailure", MemberParameters = new object[]
		{
			typeof(global::System.ParseFailureKind),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "AdjustTimeZoneToUniversal", MemberParameters = new object[] { typeof(ref global::System.DateTimeResult) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private static bool DateTimeOffsetTimeZonePostProcessing(ref global::System.__DTString str, ref global::System.DateTimeResult result, global::System.Globalization.DateTimeStyles styles)
		{
			throw null;
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x000157D6 File Offset: 0x000139D6
		[global::Cpp2ILInjected.Token(Token = "0x60006E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C282CC", Offset = "0x1C282CC", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "DetermineTimeZoneAdjustments", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(ref global::System.DateTimeResult),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "DateTimeOffsetTimeZonePostProcessing", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(ref global::System.DateTimeResult),
			typeof(global::System.Globalization.DateTimeStyles)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(long),
			typeof(global::System.DateTimeKind)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeResult), Member = "SetFailure", MemberParameters = new object[]
		{
			typeof(global::System.ParseFailureKind),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private static bool AdjustTimeZoneToUniversal(ref global::System.DateTimeResult result)
		{
			throw null;
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x000157D9 File Offset: 0x000139D9
		[global::Cpp2ILInjected.Token(Token = "0x60006E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C28388", Offset = "0x1C28388", Length = "0x200")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "DetermineTimeZoneAdjustments", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(ref global::System.DateTimeResult),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "get_Local", ReturnType = typeof(global::System.TimeZoneInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(long),
			typeof(global::System.DateTimeKind)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "GetUtcOffsetFromUtc", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfo),
			typeof(ref bool),
			typeof(ref bool)
		}, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Now", ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfoOptions)
		}, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(long),
			typeof(global::System.DateTimeKind),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeResult), Member = "SetFailure", MemberParameters = new object[]
		{
			typeof(global::System.ParseFailureKind),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private static bool AdjustTimeZoneToLocal(ref global::System.DateTimeResult result, bool bTimeOnly)
		{
			throw null;
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x000157DC File Offset: 0x000139DC
		[global::Cpp2ILInjected.Token(Token = "0x60006E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C27714", Offset = "0x1C27714", Length = "0x500")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeRawInfo), Member = "GetNumber", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.__DTString), Member = "SkipWhiteSpaces", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "ParseDigits", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.__DTString), Member = "Match", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "ParseFraction", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(ref double)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.__DTString), Member = "GetNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.__DTString), Member = "GetChar", ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "ParseTimeZone", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(ref global::System.TimeSpan)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "VerifyValidPunctuation", MemberParameters = new object[] { typeof(ref global::System.__DTString) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeResult), Member = "SetBadDateTimeFailure", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.GregorianCalendar), Member = "GetDefaultInstance", ReturnType = typeof(global::System.Globalization.Calendar))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeResult), Member = "SetFailure", MemberParameters = new object[]
		{
			typeof(global::System.ParseFailureKind),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "AddTicks", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "DetermineTimeZoneAdjustments", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(ref global::System.DateTimeResult),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		private static bool ParseISO8601(ref global::System.DateTimeRawInfo raw, ref global::System.__DTString str, global::System.Globalization.DateTimeStyles styles, ref global::System.DateTimeResult result)
		{
			throw null;
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x000157DF File Offset: 0x000139DF
		[global::Cpp2ILInjected.Token(Token = "0x60006E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C28610", Offset = "0x1C28610", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.HebrewNumberParsingContext), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.__DTString), Member = "GetNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.__DTString), Member = "GetChar", ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.HebrewNumber), Member = "ParseByChar", MemberParameters = new object[]
		{
			typeof(char),
			typeof(ref global::System.Globalization.HebrewNumberParsingContext)
		}, ReturnType = typeof(global::System.Globalization.HebrewNumberParsingState))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static bool MatchHebrewDigits(ref global::System.__DTString str, int digitLen, out int number)
		{
			throw null;
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x000157E2 File Offset: 0x000139E2
		[global::Cpp2ILInjected.Token(Token = "0x60006E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C28588", Offset = "0x1C28588", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ParseISO8601", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeRawInfo),
			typeof(ref global::System.__DTString),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ParseTimeZoneOffset", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(int),
			typeof(ref global::System.TimeSpan)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ParseByFormat", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(ref global::System.__DTString),
			typeof(ref global::System.ParsingInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "ParseDigits", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(int),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static bool ParseDigits(ref global::System.__DTString str, int digitLen, out int result)
		{
			throw null;
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x000157E5 File Offset: 0x000139E5
		[global::Cpp2ILInjected.Token(Token = "0x60006E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C286E4", Offset = "0x1C286E4", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ParseDigits", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ParseByFormat", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(ref global::System.__DTString),
			typeof(ref global::System.ParsingInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.__DTString), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.__DTString), Member = "GetDigit", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static bool ParseDigits(ref global::System.__DTString str, int minDigitLen, int maxDigitLen, out int result)
		{
			throw null;
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x000157E8 File Offset: 0x000139E8
		[global::Cpp2ILInjected.Token(Token = "0x60006E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C28814", Offset = "0x1C28814", Length = "0x1B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ParseByFormat", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(ref global::System.__DTString),
			typeof(ref global::System.ParsingInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.__DTString), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.__DTString), Member = "GetDigit", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.TimeSpanParse), Member = "Pow10", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static bool ParseFractionExact(ref global::System.__DTString str, int maxDigitLen, ref double result)
		{
			throw null;
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x000157EB File Offset: 0x000139EB
		[global::Cpp2ILInjected.Token(Token = "0x60006E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C289C4", Offset = "0x1C289C4", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ParseTimeZoneOffset", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(int),
			typeof(ref global::System.TimeSpan)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.__DTString), Member = "GetNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.__DTString), Member = "GetChar", ReturnType = typeof(char))]
		private static bool ParseSign(ref global::System.__DTString str, ref bool result)
		{
			throw null;
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x000157EE File Offset: 0x000139EE
		[global::Cpp2ILInjected.Token(Token = "0x60006EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C28A28", Offset = "0x1C28A28", Length = "0x180")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ParseByFormat", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(ref global::System.__DTString),
			typeof(ref global::System.ParsingInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "ParseSign", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(ref bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "ParseDigits", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.__DTString), Member = "Match", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = "Negate", ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static bool ParseTimeZoneOffset(ref global::System.__DTString str, int len, ref global::System.TimeSpan result)
		{
			throw null;
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x000157F1 File Offset: 0x000139F1
		[global::Cpp2ILInjected.Token(Token = "0x60006EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C28BA8", Offset = "0x1C28BA8", Length = "0x214")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ParseByFormat", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(ref global::System.__DTString),
			typeof(ref global::System.ParsingInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.__DTString), Member = "GetNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "GetMonthName", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "GetAbbreviatedMonthName", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "get_HasSpacesInMonthNames", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.__DTString), Member = "MatchSpecifiedWords", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.__DTString), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CompareInfo), Member = "Compare", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(string),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "get_FormatFlags", ReturnType = typeof(global::System.Globalization.DateTimeFormatFlags))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "internalGetLeapYearMonthNames", ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.__DTString), Member = "MatchLongestWords", MemberParameters = new object[]
		{
			typeof(string[]),
			typeof(ref int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static bool MatchAbbreviatedMonthName(ref global::System.__DTString str, global::System.Globalization.DateTimeFormatInfo dtfi, ref int result)
		{
			throw null;
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x000157F4 File Offset: 0x000139F4
		[global::Cpp2ILInjected.Token(Token = "0x60006EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C28DBC", Offset = "0x1C28DBC", Length = "0x254")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ParseByFormat", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(ref global::System.__DTString),
			typeof(ref global::System.ParsingInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.__DTString), Member = "GetNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "GetMonthName", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "get_HasSpacesInMonthNames", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.__DTString), Member = "MatchSpecifiedWords", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.__DTString), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CompareInfo), Member = "Compare", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(string),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "get_FormatFlags", ReturnType = typeof(global::System.Globalization.DateTimeFormatFlags))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "get_MonthGenitiveNames", ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.__DTString), Member = "MatchLongestWords", MemberParameters = new object[]
		{
			typeof(string[]),
			typeof(ref int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "internalGetLeapYearMonthNames", ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static bool MatchMonthName(ref global::System.__DTString str, global::System.Globalization.DateTimeFormatInfo dtfi, ref int result)
		{
			throw null;
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x000157F7 File Offset: 0x000139F7
		[global::Cpp2ILInjected.Token(Token = "0x60006ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C29010", Offset = "0x1C29010", Length = "0x1B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ParseByFormat", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(ref global::System.__DTString),
			typeof(ref global::System.ParsingInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.__DTString), Member = "GetNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "GetAbbreviatedDayName", MemberParameters = new object[] { typeof(global::System.DayOfWeek) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "get_HasSpacesInDayNames", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.__DTString), Member = "MatchSpecifiedWords", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.__DTString), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CompareInfo), Member = "Compare", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(string),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static bool MatchAbbreviatedDayName(ref global::System.__DTString str, global::System.Globalization.DateTimeFormatInfo dtfi, ref int result)
		{
			throw null;
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x000157FA File Offset: 0x000139FA
		[global::Cpp2ILInjected.Token(Token = "0x60006EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C291C0", Offset = "0x1C291C0", Length = "0x1B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ParseByFormat", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(ref global::System.__DTString),
			typeof(ref global::System.ParsingInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.__DTString), Member = "GetNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "GetDayName", MemberParameters = new object[] { typeof(global::System.DayOfWeek) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "get_HasSpacesInDayNames", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.__DTString), Member = "MatchSpecifiedWords", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.__DTString), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CompareInfo), Member = "Compare", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(string),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static bool MatchDayName(ref global::System.__DTString str, global::System.Globalization.DateTimeFormatInfo dtfi, ref int result)
		{
			throw null;
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x000157FD File Offset: 0x000139FD
		[global::Cpp2ILInjected.Token(Token = "0x60006EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C29370", Offset = "0x1C29370", Length = "0x244")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ParseByFormat", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(ref global::System.__DTString),
			typeof(ref global::System.ParsingInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.__DTString), Member = "GetNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "GetEraName", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.__DTString), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CompareInfo), Member = "Compare", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(string),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "GetAbbreviatedEraName", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static bool MatchEraName(ref global::System.__DTString str, global::System.Globalization.DateTimeFormatInfo dtfi, ref int result)
		{
			throw null;
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x00015800 File Offset: 0x00013A00
		[global::Cpp2ILInjected.Token(Token = "0x60006F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C295B4", Offset = "0x1C295B4", Length = "0x268")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ParseByFormat", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(ref global::System.__DTString),
			typeof(ref global::System.ParsingInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "get_AMDesignator", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "get_PMDesignator", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.__DTString), Member = "GetNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.__DTString), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CompareInfo), Member = "Compare", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(string),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static bool MatchTimeMark(ref global::System.__DTString str, global::System.Globalization.DateTimeFormatInfo dtfi, ref global::System.DateTimeParse.TM result)
		{
			throw null;
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x00015803 File Offset: 0x00013A03
		[global::Cpp2ILInjected.Token(Token = "0x60006F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C2981C", Offset = "0x1C2981C", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ParseByFormat", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(ref global::System.__DTString),
			typeof(ref global::System.ParsingInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.__DTString), Member = "GetNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "get_AMDesignator", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.__DTString), Member = "GetChar", ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "get_PMDesignator", ReturnType = typeof(string))]
		private static bool MatchAbbreviatedTimeMark(ref global::System.__DTString str, global::System.Globalization.DateTimeFormatInfo dtfi, ref global::System.DateTimeParse.TM result)
		{
			throw null;
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x00015806 File Offset: 0x00013A06
		[global::Cpp2ILInjected.Token(Token = "0x60006F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C298F8", Offset = "0x1C298F8", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ParseByFormat", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(ref global::System.__DTString),
			typeof(ref global::System.ParsingInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeResult), Member = "SetFailure", MemberParameters = new object[]
		{
			typeof(global::System.ParseFailureKind),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static bool CheckNewValue(ref int currentValue, int newValue, char patternChar, ref global::System.DateTimeResult result)
		{
			throw null;
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x00015809 File Offset: 0x00013A09
		[global::Cpp2ILInjected.Token(Token = "0x60006F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C254C0", Offset = "0x1C254C0", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "GetDefaultYear", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.Globalization.DateTimeStyles)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "CheckDefaultDateTime", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.Globalization.Calendar),
			typeof(global::System.Globalization.DateTimeStyles)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Now", ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_UtcNow", ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(long),
			typeof(global::System.DateTimeKind)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static global::System.DateTime GetDateTimeNow(ref global::System.DateTimeResult result, ref global::System.Globalization.DateTimeStyles styles)
		{
			throw null;
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x0001580C File Offset: 0x00013A0C
		[global::Cpp2ILInjected.Token(Token = "0x60006F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C27C14", Offset = "0x1C27C14", Length = "0x268")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "DoStrictParse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "GetDateTimeNow", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.Globalization.DateTimeStyles)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeResult), Member = "SetFailure", MemberParameters = new object[]
		{
			typeof(global::System.ParseFailureKind),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.GregorianCalendar), Member = "GetDefaultInstance", ReturnType = typeof(global::System.Globalization.Calendar))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static bool CheckDefaultDateTime(ref global::System.DateTimeResult result, ref global::System.Globalization.Calendar cal, global::System.Globalization.DateTimeStyles styles)
		{
			throw null;
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x0001580F File Offset: 0x00013A0F
		[global::Cpp2ILInjected.Token(Token = "0x60006F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C299B4", Offset = "0x1C299B4", Length = "0x314")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "DoStrictParse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.GregorianCalendar), Member = "GetDefaultInstance", ReturnType = typeof(global::System.Globalization.Calendar))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(global::System.Globalization.DateTimeFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "Clone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeFormat), Member = "GetRealFormat", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "set_Calendar", MemberParameters = new object[] { typeof(global::System.Globalization.Calendar) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		private static string ExpandPredefinedFormat(global::System.ReadOnlySpan<char> format, ref global::System.Globalization.DateTimeFormatInfo dtfi, ref global::System.ParsingInfo parseInfo, ref global::System.DateTimeResult result)
		{
			throw null;
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x00015812 File Offset: 0x00013A12
		[global::Cpp2ILInjected.Token(Token = "0x60006F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C29CC8", Offset = "0x1C29CC8", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.__DTString), Member = "GetNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(256)]
		private static bool ParseJapaneseEraStart(ref global::System.__DTString str, global::System.Globalization.DateTimeFormatInfo dtfi)
		{
			throw null;
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x00015815 File Offset: 0x00013A15
		[global::Cpp2ILInjected.Token(Token = "0x60006F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C29D9C", Offset = "0x1C29D9C", Length = "0xF24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ParseByFormat", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(ref global::System.__DTString),
			typeof(ref global::System.ParsingInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "DoStrictParse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.__DTString), Member = "GetChar", ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "get_TimeSeparator", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.__DTString), Member = "Match", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.__DTString), Member = "GetRepeatCount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "ParseDigits", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.__DTString), Member = "GetNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "MatchAbbreviatedDayName", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilderCache), Member = "Acquire", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "TryParseQuoteString", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(int),
			typeof(global::System.Text.StringBuilder),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilderCache), Member = "GetStringAndRelease", MemberParameters = new object[] { typeof(global::System.Text.StringBuilder) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.__DTString), Member = "SkipWhiteSpaces", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "ParseFractionExact", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(int),
			typeof(ref double)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "MatchAbbreviatedMonthName", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "get_DateSeparator", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeResult), Member = "SetFailure", MemberParameters = new object[]
		{
			typeof(global::System.ParseFailureKind),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilderCache), Member = "Release", MemberParameters = new object[] { typeof(global::System.Text.StringBuilder) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "ParseByFormat", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(ref global::System.__DTString),
			typeof(ref global::System.ParsingInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.__DTString), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CompareInfo), Member = "Compare", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(string),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.__DTString), Member = "Match", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "MatchAbbreviatedTimeMark", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref global::System.DateTimeParse.TM)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "ParseTimeZoneOffset", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(int),
			typeof(ref global::System.TimeSpan)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeResult), Member = "SetBadFormatSpecifierFailure", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "MatchEraName", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "MatchTimeMark", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref global::System.DateTimeParse.TM)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "GetTimeZoneName", MemberParameters = new object[] { typeof(ref global::System.__DTString) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "MatchMonthName", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "MatchDayName", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "CheckNewValue", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(int),
			typeof(char),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "get_HasForceTwoDigitYears", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "ParseDigits", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(int),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeResult), Member = "SetBadDateTimeFailure", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 47)]
		private static bool ParseByFormat(ref global::System.__DTString str, ref global::System.__DTString format, ref global::System.ParsingInfo parseInfo, global::System.Globalization.DateTimeFormatInfo dtfi, ref global::System.DateTimeResult result)
		{
			throw null;
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x00015818 File Offset: 0x00013A18
		[global::Cpp2ILInjected.Token(Token = "0x60006F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C2ACC0", Offset = "0x1C2ACC0", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ParseByFormat", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(ref global::System.__DTString),
			typeof(ref global::System.ParsingInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.TimeSpanParse), Member = "TryParseByFormat", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.TimeSpanStyles),
			typeof(ref global::System.Globalization.TimeSpanParse.TimeSpanResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal static bool TryParseQuoteString(global::System.ReadOnlySpan<char> format, int pos, global::System.Text.StringBuilder result, out int returnValue)
		{
			throw null;
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x0001581B File Offset: 0x00013A1B
		[global::Cpp2ILInjected.Token(Token = "0x60006F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C229E4", Offset = "0x1C229E4", Length = "0x788")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "TryParseExact", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ParsingInfo), Member = "Init", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeResult), Member = "SetBadFormatSpecifierFailure", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "ExpandPredefinedFormat", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(ref global::System.Globalization.DateTimeFormatInfo),
			typeof(ref global::System.ParsingInfo),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Func<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.LazyInitializer), Member = "EnsureInitialized", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T&", "System.Func`1<T>" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.__DTString), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.__DTString), Member = "TrimTail", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.__DTString), Member = "RemoveTrailingInQuoteSpaces", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.__DTString), Member = "SkipWhiteSpaces", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.__DTString), Member = "RemoveLeadingInQuoteSpaces", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.__DTString), Member = "GetNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "ParseByFormat", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(ref global::System.__DTString),
			typeof(ref global::System.ParsingInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeResult), Member = "SetBadDateTimeFailure", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "get_FormatFlags", ReturnType = typeof(global::System.Globalization.DateTimeFormatFlags))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "CheckDefaultDateTime", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.Globalization.Calendar),
			typeof(global::System.Globalization.DateTimeStyles)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "get_HasYearMonthAdjustment", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "YearMonthAdjustment", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeResult), Member = "SetFailure", MemberParameters = new object[]
		{
			typeof(global::System.ParseFailureKind),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "AddTicks", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "DetermineTimeZoneAdjustments", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(ref global::System.DateTimeResult),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 34)]
		private static bool DoStrictParse(global::System.ReadOnlySpan<char> s, global::System.ReadOnlySpan<char> formatParam, global::System.Globalization.DateTimeStyles styles, global::System.Globalization.DateTimeFormatInfo dtfi, ref global::System.DateTimeResult result)
		{
			throw null;
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x0001581E File Offset: 0x00013A1E
		[global::Cpp2ILInjected.Token(Token = "0x60006FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C22830", Offset = "0x1C22830", Length = "0x1B4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ParseExact", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.Globalization.DateTimeStyles)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ParseExact", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.TimeSpan)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ParseExactMultiple", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(string[]),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.Globalization.DateTimeStyles)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "Parse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.Globalization.DateTimeStyles)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "Parse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.TimeSpan)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static global::System.Exception GetDateTimeParseException(ref global::System.DateTimeResult result)
		{
			throw null;
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x00015821 File Offset: 0x00013A21
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60006FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C2AD8C", Offset = "0x1C2AD8C", Length = "0x1688")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(global::System.RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 67)]
		static DateTimeParse()
		{
			throw null;
		}

		// Token: 0x0400018E RID: 398
		[global::Cpp2ILInjected.Token(Token = "0x4000275")]
		internal static global::System.DateTimeParse.MatchNumberDelegate m_hebrewNumberParser;

		// Token: 0x0400018F RID: 399
		[global::Cpp2ILInjected.Token(Token = "0x4000276")]
		private static global::System.DateTimeParse.DS[][] dateParsingStates;

		// Token: 0x0200057C RID: 1404
		// (Invoke) Token: 0x06003F8A RID: 16266
		[global::Cpp2ILInjected.Token(Token = "0x20000AE")]
		internal delegate bool MatchNumberDelegate(ref global::System.__DTString str, int digitLen, out int result);

		// Token: 0x0200057D RID: 1405
		[global::Cpp2ILInjected.Token(Token = "0x20000AF")]
		internal enum DTT
		{
			// Token: 0x0400178F RID: 6031
			[global::Cpp2ILInjected.Token(Token = "0x4000278")]
			End,
			// Token: 0x04001790 RID: 6032
			[global::Cpp2ILInjected.Token(Token = "0x4000279")]
			NumEnd,
			// Token: 0x04001791 RID: 6033
			[global::Cpp2ILInjected.Token(Token = "0x400027A")]
			NumAmpm,
			// Token: 0x04001792 RID: 6034
			[global::Cpp2ILInjected.Token(Token = "0x400027B")]
			NumSpace,
			// Token: 0x04001793 RID: 6035
			[global::Cpp2ILInjected.Token(Token = "0x400027C")]
			NumDatesep,
			// Token: 0x04001794 RID: 6036
			[global::Cpp2ILInjected.Token(Token = "0x400027D")]
			NumTimesep,
			// Token: 0x04001795 RID: 6037
			[global::Cpp2ILInjected.Token(Token = "0x400027E")]
			MonthEnd,
			// Token: 0x04001796 RID: 6038
			[global::Cpp2ILInjected.Token(Token = "0x400027F")]
			MonthSpace,
			// Token: 0x04001797 RID: 6039
			[global::Cpp2ILInjected.Token(Token = "0x4000280")]
			MonthDatesep,
			// Token: 0x04001798 RID: 6040
			[global::Cpp2ILInjected.Token(Token = "0x4000281")]
			NumDatesuff,
			// Token: 0x04001799 RID: 6041
			[global::Cpp2ILInjected.Token(Token = "0x4000282")]
			NumTimesuff,
			// Token: 0x0400179A RID: 6042
			[global::Cpp2ILInjected.Token(Token = "0x4000283")]
			DayOfWeek,
			// Token: 0x0400179B RID: 6043
			[global::Cpp2ILInjected.Token(Token = "0x4000284")]
			YearSpace,
			// Token: 0x0400179C RID: 6044
			[global::Cpp2ILInjected.Token(Token = "0x4000285")]
			YearDateSep,
			// Token: 0x0400179D RID: 6045
			[global::Cpp2ILInjected.Token(Token = "0x4000286")]
			YearEnd,
			// Token: 0x0400179E RID: 6046
			[global::Cpp2ILInjected.Token(Token = "0x4000287")]
			TimeZone,
			// Token: 0x0400179F RID: 6047
			[global::Cpp2ILInjected.Token(Token = "0x4000288")]
			Era,
			// Token: 0x040017A0 RID: 6048
			[global::Cpp2ILInjected.Token(Token = "0x4000289")]
			NumUTCTimeMark,
			// Token: 0x040017A1 RID: 6049
			[global::Cpp2ILInjected.Token(Token = "0x400028A")]
			Unk,
			// Token: 0x040017A2 RID: 6050
			[global::Cpp2ILInjected.Token(Token = "0x400028B")]
			NumLocalTimeMark,
			// Token: 0x040017A3 RID: 6051
			[global::Cpp2ILInjected.Token(Token = "0x400028C")]
			Max
		}

		// Token: 0x0200057E RID: 1406
		[global::Cpp2ILInjected.Token(Token = "0x20000B0")]
		internal enum TM
		{
			// Token: 0x040017A5 RID: 6053
			[global::Cpp2ILInjected.Token(Token = "0x400028E")]
			NotSet = -1,
			// Token: 0x040017A6 RID: 6054
			[global::Cpp2ILInjected.Token(Token = "0x400028F")]
			AM,
			// Token: 0x040017A7 RID: 6055
			[global::Cpp2ILInjected.Token(Token = "0x4000290")]
			PM
		}

		// Token: 0x0200057F RID: 1407
		[global::Cpp2ILInjected.Token(Token = "0x20000B1")]
		internal enum DS
		{
			// Token: 0x040017A9 RID: 6057
			[global::Cpp2ILInjected.Token(Token = "0x4000292")]
			BEGIN,
			// Token: 0x040017AA RID: 6058
			[global::Cpp2ILInjected.Token(Token = "0x4000293")]
			N,
			// Token: 0x040017AB RID: 6059
			[global::Cpp2ILInjected.Token(Token = "0x4000294")]
			NN,
			// Token: 0x040017AC RID: 6060
			[global::Cpp2ILInjected.Token(Token = "0x4000295")]
			D_Nd,
			// Token: 0x040017AD RID: 6061
			[global::Cpp2ILInjected.Token(Token = "0x4000296")]
			D_NN,
			// Token: 0x040017AE RID: 6062
			[global::Cpp2ILInjected.Token(Token = "0x4000297")]
			D_NNd,
			// Token: 0x040017AF RID: 6063
			[global::Cpp2ILInjected.Token(Token = "0x4000298")]
			D_M,
			// Token: 0x040017B0 RID: 6064
			[global::Cpp2ILInjected.Token(Token = "0x4000299")]
			D_MN,
			// Token: 0x040017B1 RID: 6065
			[global::Cpp2ILInjected.Token(Token = "0x400029A")]
			D_NM,
			// Token: 0x040017B2 RID: 6066
			[global::Cpp2ILInjected.Token(Token = "0x400029B")]
			D_MNd,
			// Token: 0x040017B3 RID: 6067
			[global::Cpp2ILInjected.Token(Token = "0x400029C")]
			D_NDS,
			// Token: 0x040017B4 RID: 6068
			[global::Cpp2ILInjected.Token(Token = "0x400029D")]
			D_Y,
			// Token: 0x040017B5 RID: 6069
			[global::Cpp2ILInjected.Token(Token = "0x400029E")]
			D_YN,
			// Token: 0x040017B6 RID: 6070
			[global::Cpp2ILInjected.Token(Token = "0x400029F")]
			D_YNd,
			// Token: 0x040017B7 RID: 6071
			[global::Cpp2ILInjected.Token(Token = "0x40002A0")]
			D_YM,
			// Token: 0x040017B8 RID: 6072
			[global::Cpp2ILInjected.Token(Token = "0x40002A1")]
			D_YMd,
			// Token: 0x040017B9 RID: 6073
			[global::Cpp2ILInjected.Token(Token = "0x40002A2")]
			D_S,
			// Token: 0x040017BA RID: 6074
			[global::Cpp2ILInjected.Token(Token = "0x40002A3")]
			T_S,
			// Token: 0x040017BB RID: 6075
			[global::Cpp2ILInjected.Token(Token = "0x40002A4")]
			T_Nt,
			// Token: 0x040017BC RID: 6076
			[global::Cpp2ILInjected.Token(Token = "0x40002A5")]
			T_NNt,
			// Token: 0x040017BD RID: 6077
			[global::Cpp2ILInjected.Token(Token = "0x40002A6")]
			ERROR,
			// Token: 0x040017BE RID: 6078
			[global::Cpp2ILInjected.Token(Token = "0x40002A7")]
			DX_NN,
			// Token: 0x040017BF RID: 6079
			[global::Cpp2ILInjected.Token(Token = "0x40002A8")]
			DX_NNN,
			// Token: 0x040017C0 RID: 6080
			[global::Cpp2ILInjected.Token(Token = "0x40002A9")]
			DX_MN,
			// Token: 0x040017C1 RID: 6081
			[global::Cpp2ILInjected.Token(Token = "0x40002AA")]
			DX_NM,
			// Token: 0x040017C2 RID: 6082
			[global::Cpp2ILInjected.Token(Token = "0x40002AB")]
			DX_MNN,
			// Token: 0x040017C3 RID: 6083
			[global::Cpp2ILInjected.Token(Token = "0x40002AC")]
			DX_DS,
			// Token: 0x040017C4 RID: 6084
			[global::Cpp2ILInjected.Token(Token = "0x40002AD")]
			DX_DSN,
			// Token: 0x040017C5 RID: 6085
			[global::Cpp2ILInjected.Token(Token = "0x40002AE")]
			DX_NDS,
			// Token: 0x040017C6 RID: 6086
			[global::Cpp2ILInjected.Token(Token = "0x40002AF")]
			DX_NNDS,
			// Token: 0x040017C7 RID: 6087
			[global::Cpp2ILInjected.Token(Token = "0x40002B0")]
			DX_YNN,
			// Token: 0x040017C8 RID: 6088
			[global::Cpp2ILInjected.Token(Token = "0x40002B1")]
			DX_YMN,
			// Token: 0x040017C9 RID: 6089
			[global::Cpp2ILInjected.Token(Token = "0x40002B2")]
			DX_YN,
			// Token: 0x040017CA RID: 6090
			[global::Cpp2ILInjected.Token(Token = "0x40002B3")]
			DX_YM,
			// Token: 0x040017CB RID: 6091
			[global::Cpp2ILInjected.Token(Token = "0x40002B4")]
			TX_N,
			// Token: 0x040017CC RID: 6092
			[global::Cpp2ILInjected.Token(Token = "0x40002B5")]
			TX_NN,
			// Token: 0x040017CD RID: 6093
			[global::Cpp2ILInjected.Token(Token = "0x40002B6")]
			TX_NNN,
			// Token: 0x040017CE RID: 6094
			[global::Cpp2ILInjected.Token(Token = "0x40002B7")]
			TX_TS,
			// Token: 0x040017CF RID: 6095
			[global::Cpp2ILInjected.Token(Token = "0x40002B8")]
			DX_NNY
		}

		// Token: 0x02000580 RID: 1408
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20000B2")]
		[global::System.Serializable]
		private sealed class <>c
		{
			// Token: 0x06003F8B RID: 16267 RVA: 0x0001F961 File Offset: 0x0001DB61
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x60006FE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C2C500", Offset = "0x1C2C500", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			// Token: 0x06003F8C RID: 16268 RVA: 0x0001F964 File Offset: 0x0001DB64
			[global::Cpp2ILInjected.Token(Token = "0x60006FF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C2C55C", Offset = "0x1C2C55C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			// Token: 0x06003F8D RID: 16269 RVA: 0x0001F967 File Offset: 0x0001DB67
			[global::Cpp2ILInjected.Token(Token = "0x6000700")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C2C564", Offset = "0x1C2C564", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse.MatchNumberDelegate), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(global::System.IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal global::System.DateTimeParse.MatchNumberDelegate <DoStrictParse>b__98_0()
			{
				throw null;
			}

			// Token: 0x040017D0 RID: 6096
			[global::Cpp2ILInjected.Token(Token = "0x40002B9")]
			public static readonly global::System.DateTimeParse.<>c <>9;

			// Token: 0x040017D1 RID: 6097
			[global::Cpp2ILInjected.Token(Token = "0x40002BA")]
			public static global::System.Func<global::System.DateTimeParse.MatchNumberDelegate> <>9__98_0;
		}
	}
}
