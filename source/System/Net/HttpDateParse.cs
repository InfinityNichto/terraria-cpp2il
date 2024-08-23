using System;
using System.Globalization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x02000156 RID: 342
	[global::Cpp2ILInjected.Token(Token = "0x20001E9")]
	internal static class HttpDateParse
	{
		// Token: 0x06000ADA RID: 2778 RVA: 0x00004D06 File Offset: 0x00002F06
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

		// Token: 0x06000ADB RID: 2779 RVA: 0x00004D09 File Offset: 0x00002F09
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

		// Token: 0x06000ADC RID: 2780 RVA: 0x00004D0C File Offset: 0x00002F0C
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

		// Token: 0x04000809 RID: 2057
		[global::Cpp2ILInjected.Token(Token = "0x4000A4D")]
		private const int BASE_DEC = 10;

		// Token: 0x0400080A RID: 2058
		[global::Cpp2ILInjected.Token(Token = "0x4000A4E")]
		private const int DATE_INDEX_DAY_OF_WEEK = 0;

		// Token: 0x0400080B RID: 2059
		[global::Cpp2ILInjected.Token(Token = "0x4000A4F")]
		private const int DATE_1123_INDEX_DAY = 1;

		// Token: 0x0400080C RID: 2060
		[global::Cpp2ILInjected.Token(Token = "0x4000A50")]
		private const int DATE_1123_INDEX_MONTH = 2;

		// Token: 0x0400080D RID: 2061
		[global::Cpp2ILInjected.Token(Token = "0x4000A51")]
		private const int DATE_1123_INDEX_YEAR = 3;

		// Token: 0x0400080E RID: 2062
		[global::Cpp2ILInjected.Token(Token = "0x4000A52")]
		private const int DATE_1123_INDEX_HRS = 4;

		// Token: 0x0400080F RID: 2063
		[global::Cpp2ILInjected.Token(Token = "0x4000A53")]
		private const int DATE_1123_INDEX_MINS = 5;

		// Token: 0x04000810 RID: 2064
		[global::Cpp2ILInjected.Token(Token = "0x4000A54")]
		private const int DATE_1123_INDEX_SECS = 6;

		// Token: 0x04000811 RID: 2065
		[global::Cpp2ILInjected.Token(Token = "0x4000A55")]
		private const int DATE_ANSI_INDEX_MONTH = 1;

		// Token: 0x04000812 RID: 2066
		[global::Cpp2ILInjected.Token(Token = "0x4000A56")]
		private const int DATE_ANSI_INDEX_DAY = 2;

		// Token: 0x04000813 RID: 2067
		[global::Cpp2ILInjected.Token(Token = "0x4000A57")]
		private const int DATE_ANSI_INDEX_HRS = 3;

		// Token: 0x04000814 RID: 2068
		[global::Cpp2ILInjected.Token(Token = "0x4000A58")]
		private const int DATE_ANSI_INDEX_MINS = 4;

		// Token: 0x04000815 RID: 2069
		[global::Cpp2ILInjected.Token(Token = "0x4000A59")]
		private const int DATE_ANSI_INDEX_SECS = 5;

		// Token: 0x04000816 RID: 2070
		[global::Cpp2ILInjected.Token(Token = "0x4000A5A")]
		private const int DATE_ANSI_INDEX_YEAR = 6;

		// Token: 0x04000817 RID: 2071
		[global::Cpp2ILInjected.Token(Token = "0x4000A5B")]
		private const int DATE_INDEX_TZ = 7;

		// Token: 0x04000818 RID: 2072
		[global::Cpp2ILInjected.Token(Token = "0x4000A5C")]
		private const int DATE_INDEX_LAST = 7;

		// Token: 0x04000819 RID: 2073
		[global::Cpp2ILInjected.Token(Token = "0x4000A5D")]
		private const int MAX_FIELD_DATE_ENTRIES = 8;

		// Token: 0x0400081A RID: 2074
		[global::Cpp2ILInjected.Token(Token = "0x4000A5E")]
		private const int DATE_TOKEN_JANUARY = 1;

		// Token: 0x0400081B RID: 2075
		[global::Cpp2ILInjected.Token(Token = "0x4000A5F")]
		private const int DATE_TOKEN_FEBRUARY = 2;

		// Token: 0x0400081C RID: 2076
		[global::Cpp2ILInjected.Token(Token = "0x4000A60")]
		private const int DATE_TOKEN_Microsoft = 3;

		// Token: 0x0400081D RID: 2077
		[global::Cpp2ILInjected.Token(Token = "0x4000A61")]
		private const int DATE_TOKEN_APRIL = 4;

		// Token: 0x0400081E RID: 2078
		[global::Cpp2ILInjected.Token(Token = "0x4000A62")]
		private const int DATE_TOKEN_MAY = 5;

		// Token: 0x0400081F RID: 2079
		[global::Cpp2ILInjected.Token(Token = "0x4000A63")]
		private const int DATE_TOKEN_JUNE = 6;

		// Token: 0x04000820 RID: 2080
		[global::Cpp2ILInjected.Token(Token = "0x4000A64")]
		private const int DATE_TOKEN_JULY = 7;

		// Token: 0x04000821 RID: 2081
		[global::Cpp2ILInjected.Token(Token = "0x4000A65")]
		private const int DATE_TOKEN_AUGUST = 8;

		// Token: 0x04000822 RID: 2082
		[global::Cpp2ILInjected.Token(Token = "0x4000A66")]
		private const int DATE_TOKEN_SEPTEMBER = 9;

		// Token: 0x04000823 RID: 2083
		[global::Cpp2ILInjected.Token(Token = "0x4000A67")]
		private const int DATE_TOKEN_OCTOBER = 10;

		// Token: 0x04000824 RID: 2084
		[global::Cpp2ILInjected.Token(Token = "0x4000A68")]
		private const int DATE_TOKEN_NOVEMBER = 11;

		// Token: 0x04000825 RID: 2085
		[global::Cpp2ILInjected.Token(Token = "0x4000A69")]
		private const int DATE_TOKEN_DECEMBER = 12;

		// Token: 0x04000826 RID: 2086
		[global::Cpp2ILInjected.Token(Token = "0x4000A6A")]
		private const int DATE_TOKEN_LAST_MONTH = 13;

		// Token: 0x04000827 RID: 2087
		[global::Cpp2ILInjected.Token(Token = "0x4000A6B")]
		private const int DATE_TOKEN_SUNDAY = 0;

		// Token: 0x04000828 RID: 2088
		[global::Cpp2ILInjected.Token(Token = "0x4000A6C")]
		private const int DATE_TOKEN_MONDAY = 1;

		// Token: 0x04000829 RID: 2089
		[global::Cpp2ILInjected.Token(Token = "0x4000A6D")]
		private const int DATE_TOKEN_TUESDAY = 2;

		// Token: 0x0400082A RID: 2090
		[global::Cpp2ILInjected.Token(Token = "0x4000A6E")]
		private const int DATE_TOKEN_WEDNESDAY = 3;

		// Token: 0x0400082B RID: 2091
		[global::Cpp2ILInjected.Token(Token = "0x4000A6F")]
		private const int DATE_TOKEN_THURSDAY = 4;

		// Token: 0x0400082C RID: 2092
		[global::Cpp2ILInjected.Token(Token = "0x4000A70")]
		private const int DATE_TOKEN_FRIDAY = 5;

		// Token: 0x0400082D RID: 2093
		[global::Cpp2ILInjected.Token(Token = "0x4000A71")]
		private const int DATE_TOKEN_SATURDAY = 6;

		// Token: 0x0400082E RID: 2094
		[global::Cpp2ILInjected.Token(Token = "0x4000A72")]
		private const int DATE_TOKEN_LAST_DAY = 7;

		// Token: 0x0400082F RID: 2095
		[global::Cpp2ILInjected.Token(Token = "0x4000A73")]
		private const int DATE_TOKEN_GMT = -1000;

		// Token: 0x04000830 RID: 2096
		[global::Cpp2ILInjected.Token(Token = "0x4000A74")]
		private const int DATE_TOKEN_LAST = -1000;

		// Token: 0x04000831 RID: 2097
		[global::Cpp2ILInjected.Token(Token = "0x4000A75")]
		private const int DATE_TOKEN_ERROR = -999;
	}
}
