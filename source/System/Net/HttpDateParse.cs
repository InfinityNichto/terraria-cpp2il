using System;
using System.Globalization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x20001E9")]
	internal static class HttpDateParse
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000C05")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F23FA0", Offset = "0x1F23FA0", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpDateParse), Member = "MapDayMonthToDword", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "ToUpper", MemberParameters = new object[]
		{
			typeof(char),
			typeof(CultureInfo)
		}, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static char MAKE_UPPER(char c)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000C06")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F24030", Offset = "0x1F24030", Length = "0x20C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpDateParse), Member = "ParseHttpDate", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpDateParse), Member = "MAKE_UPPER", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private static int MapDayMonthToDword(char[] lpszDay, int index)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000C07")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F2423C", Offset = "0x1F2423C", Length = "0x328")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpProtocolUtils), Member = "string2date", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToCharArray", ReturnType = typeof(char[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpDateParse), Member = "MapDayMonthToDword", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "ToUniversalTime", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "AddHours", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "ToLocalTime", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool ParseHttpDate(string DateString, out DateTime dtOut)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000A4D")]
		private const int BASE_DEC = 10;

		[global::Cpp2ILInjected.Token(Token = "0x4000A4E")]
		private const int DATE_INDEX_DAY_OF_WEEK = 0;

		[global::Cpp2ILInjected.Token(Token = "0x4000A4F")]
		private const int DATE_1123_INDEX_DAY = 1;

		[global::Cpp2ILInjected.Token(Token = "0x4000A50")]
		private const int DATE_1123_INDEX_MONTH = 2;

		[global::Cpp2ILInjected.Token(Token = "0x4000A51")]
		private const int DATE_1123_INDEX_YEAR = 3;

		[global::Cpp2ILInjected.Token(Token = "0x4000A52")]
		private const int DATE_1123_INDEX_HRS = 4;

		[global::Cpp2ILInjected.Token(Token = "0x4000A53")]
		private const int DATE_1123_INDEX_MINS = 5;

		[global::Cpp2ILInjected.Token(Token = "0x4000A54")]
		private const int DATE_1123_INDEX_SECS = 6;

		[global::Cpp2ILInjected.Token(Token = "0x4000A55")]
		private const int DATE_ANSI_INDEX_MONTH = 1;

		[global::Cpp2ILInjected.Token(Token = "0x4000A56")]
		private const int DATE_ANSI_INDEX_DAY = 2;

		[global::Cpp2ILInjected.Token(Token = "0x4000A57")]
		private const int DATE_ANSI_INDEX_HRS = 3;

		[global::Cpp2ILInjected.Token(Token = "0x4000A58")]
		private const int DATE_ANSI_INDEX_MINS = 4;

		[global::Cpp2ILInjected.Token(Token = "0x4000A59")]
		private const int DATE_ANSI_INDEX_SECS = 5;

		[global::Cpp2ILInjected.Token(Token = "0x4000A5A")]
		private const int DATE_ANSI_INDEX_YEAR = 6;

		[global::Cpp2ILInjected.Token(Token = "0x4000A5B")]
		private const int DATE_INDEX_TZ = 7;

		[global::Cpp2ILInjected.Token(Token = "0x4000A5C")]
		private const int DATE_INDEX_LAST = 7;

		[global::Cpp2ILInjected.Token(Token = "0x4000A5D")]
		private const int MAX_FIELD_DATE_ENTRIES = 8;

		[global::Cpp2ILInjected.Token(Token = "0x4000A5E")]
		private const int DATE_TOKEN_JANUARY = 1;

		[global::Cpp2ILInjected.Token(Token = "0x4000A5F")]
		private const int DATE_TOKEN_FEBRUARY = 2;

		[global::Cpp2ILInjected.Token(Token = "0x4000A60")]
		private const int DATE_TOKEN_Microsoft = 3;

		[global::Cpp2ILInjected.Token(Token = "0x4000A61")]
		private const int DATE_TOKEN_APRIL = 4;

		[global::Cpp2ILInjected.Token(Token = "0x4000A62")]
		private const int DATE_TOKEN_MAY = 5;

		[global::Cpp2ILInjected.Token(Token = "0x4000A63")]
		private const int DATE_TOKEN_JUNE = 6;

		[global::Cpp2ILInjected.Token(Token = "0x4000A64")]
		private const int DATE_TOKEN_JULY = 7;

		[global::Cpp2ILInjected.Token(Token = "0x4000A65")]
		private const int DATE_TOKEN_AUGUST = 8;

		[global::Cpp2ILInjected.Token(Token = "0x4000A66")]
		private const int DATE_TOKEN_SEPTEMBER = 9;

		[global::Cpp2ILInjected.Token(Token = "0x4000A67")]
		private const int DATE_TOKEN_OCTOBER = 10;

		[global::Cpp2ILInjected.Token(Token = "0x4000A68")]
		private const int DATE_TOKEN_NOVEMBER = 11;

		[global::Cpp2ILInjected.Token(Token = "0x4000A69")]
		private const int DATE_TOKEN_DECEMBER = 12;

		[global::Cpp2ILInjected.Token(Token = "0x4000A6A")]
		private const int DATE_TOKEN_LAST_MONTH = 13;

		[global::Cpp2ILInjected.Token(Token = "0x4000A6B")]
		private const int DATE_TOKEN_SUNDAY = 0;

		[global::Cpp2ILInjected.Token(Token = "0x4000A6C")]
		private const int DATE_TOKEN_MONDAY = 1;

		[global::Cpp2ILInjected.Token(Token = "0x4000A6D")]
		private const int DATE_TOKEN_TUESDAY = 2;

		[global::Cpp2ILInjected.Token(Token = "0x4000A6E")]
		private const int DATE_TOKEN_WEDNESDAY = 3;

		[global::Cpp2ILInjected.Token(Token = "0x4000A6F")]
		private const int DATE_TOKEN_THURSDAY = 4;

		[global::Cpp2ILInjected.Token(Token = "0x4000A70")]
		private const int DATE_TOKEN_FRIDAY = 5;

		[global::Cpp2ILInjected.Token(Token = "0x4000A71")]
		private const int DATE_TOKEN_SATURDAY = 6;

		[global::Cpp2ILInjected.Token(Token = "0x4000A72")]
		private const int DATE_TOKEN_LAST_DAY = 7;

		[global::Cpp2ILInjected.Token(Token = "0x4000A73")]
		private const int DATE_TOKEN_GMT = -1000;

		[global::Cpp2ILInjected.Token(Token = "0x4000A74")]
		private const int DATE_TOKEN_LAST = -1000;

		[global::Cpp2ILInjected.Token(Token = "0x4000A75")]
		private const int DATE_TOKEN_ERROR = -999;
	}
}
