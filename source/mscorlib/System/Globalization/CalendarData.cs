using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Globalization
{
	// Token: 0x020004BC RID: 1212
	[global::Cpp2ILInjected.Token(Token = "0x20005A9")]
	[StructLayout(0)]
	internal class CalendarData
	{
		// Token: 0x0600282F RID: 10287 RVA: 0x0001B506 File Offset: 0x00019706
		[global::Cpp2ILInjected.Token(Token = "0x6002B8D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BEAD88", Offset = "0x1BEAD88", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		private CalendarData()
		{
			throw null;
		}

		// Token: 0x06002830 RID: 10288 RVA: 0x0001B509 File Offset: 0x00019709
		[global::Cpp2ILInjected.Token(Token = "0x6002B8E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BEAD98", Offset = "0x1BEAD98", Length = "0x11B0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 165)]
		static CalendarData()
		{
			throw null;
		}

		// Token: 0x06002831 RID: 10289 RVA: 0x0001B50C File Offset: 0x0001970C
		[global::Cpp2ILInjected.Token(Token = "0x6002B8F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BEBF48", Offset = "0x1BEBF48", Length = "0x508")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureData), Member = "GetCalendar", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(CalendarData))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CalendarData), Member = "nativeGetCalendarData", MemberParameters = new object[]
		{
			typeof(CalendarData),
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureData), Member = "ReescapeWin32Strings", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureData), Member = "ReescapeWin32String", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CalendarData), Member = "InitializeEraNames", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CalendarData), Member = "InitializeAbbreviatedEraNames", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CalendarData), Member = "GetJapaneseEnglishEraNames", ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
		internal CalendarData(string localeName, int calendarId, bool bUseUserOverrides)
		{
			throw null;
		}

		// Token: 0x06002832 RID: 10290 RVA: 0x0001B50F File Offset: 0x0001970F
		[global::Cpp2ILInjected.Token(Token = "0x6002B90")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BEC500", Offset = "0x1BEC500", Length = "0x368")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CalendarData), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CalendarData), Member = "GetJapaneseEraNames", ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
		private void InitializeEraNames(string localeName, int calendarId)
		{
			throw null;
		}

		// Token: 0x06002833 RID: 10291 RVA: 0x0001B512 File Offset: 0x00019712
		[global::Cpp2ILInjected.Token(Token = "0x6002B91")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BECC28", Offset = "0x1BECC28", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CalendarData), Member = "InitializeEraNames", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private static string[] GetJapaneseEraNames()
		{
			throw null;
		}

		// Token: 0x06002834 RID: 10292 RVA: 0x0001B515 File Offset: 0x00019715
		[global::Cpp2ILInjected.Token(Token = "0x6002B92")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BECB44", Offset = "0x1BECB44", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CalendarData), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JapaneseCalendar), Member = "EnglishEraNames", ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private static string[] GetJapaneseEnglishEraNames()
		{
			throw null;
		}

		// Token: 0x06002835 RID: 10293 RVA: 0x0001B518 File Offset: 0x00019718
		[global::Cpp2ILInjected.Token(Token = "0x6002B93")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BEC868", Offset = "0x1BEC868", Length = "0x2DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CalendarData), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		private void InitializeAbbreviatedEraNames(string localeName, int calendarId)
		{
			throw null;
		}

		// Token: 0x06002836 RID: 10294 RVA: 0x0001B51B File Offset: 0x0001971B
		[global::Cpp2ILInjected.Token(Token = "0x6002B94")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BEA6A4", Offset = "0x1BEA6A4", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Calendar), Member = "get_CurrentEraValue", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CalendarData), Member = "CalendarIdToCultureName", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "GetCultureInfo", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureData), Member = "GetCalendar", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(CalendarData))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal static CalendarData GetCalendarData(int calendarId)
		{
			throw null;
		}

		// Token: 0x06002837 RID: 10295 RVA: 0x0001B51E File Offset: 0x0001971E
		[global::Cpp2ILInjected.Token(Token = "0x6002B95")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BECEDC", Offset = "0x1BECEDC", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CalendarData), Member = "GetCalendarData", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(CalendarData))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private static string CalendarIdToCultureName(int calendarId)
		{
			throw null;
		}

		// Token: 0x06002838 RID: 10296 RVA: 0x0001B521 File Offset: 0x00019721
		[global::Cpp2ILInjected.Token(Token = "0x6002B96")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BEAD80", Offset = "0x1BEAD80", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static int nativeGetTwoDigitYearMax(int calID)
		{
			throw null;
		}

		// Token: 0x06002839 RID: 10297 RVA: 0x0001B524 File Offset: 0x00019724
		[global::Cpp2ILInjected.Token(Token = "0x6002B97")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BEC450", Offset = "0x1BEC450", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CalendarData), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToLowerInvariant", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static bool nativeGetCalendarData(CalendarData data, string localeName, int calendarId)
		{
			throw null;
		}

		// Token: 0x0600283A RID: 10298
		[global::Cpp2ILInjected.Token(Token = "0x6002B98")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BECFA8", Offset = "0x1BECFA8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private extern bool fill_calendar_data(string localeName, int datetimeIndex);

		// Token: 0x0400147F RID: 5247
		[global::Cpp2ILInjected.Token(Token = "0x4001843")]
		internal const int MAX_CALENDARS = 23;

		// Token: 0x04001480 RID: 5248
		[global::Cpp2ILInjected.Token(Token = "0x4001844")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal string sNativeName;

		// Token: 0x04001481 RID: 5249
		[global::Cpp2ILInjected.Token(Token = "0x4001845")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal string[] saShortDates;

		// Token: 0x04001482 RID: 5250
		[global::Cpp2ILInjected.Token(Token = "0x4001846")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal string[] saYearMonths;

		// Token: 0x04001483 RID: 5251
		[global::Cpp2ILInjected.Token(Token = "0x4001847")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal string[] saLongDates;

		// Token: 0x04001484 RID: 5252
		[global::Cpp2ILInjected.Token(Token = "0x4001848")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		internal string sMonthDay;

		// Token: 0x04001485 RID: 5253
		[global::Cpp2ILInjected.Token(Token = "0x4001849")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		internal string[] saEraNames;

		// Token: 0x04001486 RID: 5254
		[global::Cpp2ILInjected.Token(Token = "0x400184A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		internal string[] saAbbrevEraNames;

		// Token: 0x04001487 RID: 5255
		[global::Cpp2ILInjected.Token(Token = "0x400184B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		internal string[] saAbbrevEnglishEraNames;

		// Token: 0x04001488 RID: 5256
		[global::Cpp2ILInjected.Token(Token = "0x400184C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		internal string[] saDayNames;

		// Token: 0x04001489 RID: 5257
		[global::Cpp2ILInjected.Token(Token = "0x400184D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		internal string[] saAbbrevDayNames;

		// Token: 0x0400148A RID: 5258
		[global::Cpp2ILInjected.Token(Token = "0x400184E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		internal string[] saSuperShortDayNames;

		// Token: 0x0400148B RID: 5259
		[global::Cpp2ILInjected.Token(Token = "0x400184F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		internal string[] saMonthNames;

		// Token: 0x0400148C RID: 5260
		[global::Cpp2ILInjected.Token(Token = "0x4001850")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		internal string[] saAbbrevMonthNames;

		// Token: 0x0400148D RID: 5261
		[global::Cpp2ILInjected.Token(Token = "0x4001851")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		internal string[] saMonthGenitiveNames;

		// Token: 0x0400148E RID: 5262
		[global::Cpp2ILInjected.Token(Token = "0x4001852")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		internal string[] saAbbrevMonthGenitiveNames;

		// Token: 0x0400148F RID: 5263
		[global::Cpp2ILInjected.Token(Token = "0x4001853")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		internal string[] saLeapYearMonthNames;

		// Token: 0x04001490 RID: 5264
		[global::Cpp2ILInjected.Token(Token = "0x4001854")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		internal int iTwoDigitYearMax;

		// Token: 0x04001491 RID: 5265
		[global::Cpp2ILInjected.Token(Token = "0x4001855")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x94")]
		internal int iCurrentEra;

		// Token: 0x04001492 RID: 5266
		[global::Cpp2ILInjected.Token(Token = "0x4001856")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		internal bool bUseUserOverrides;

		// Token: 0x04001493 RID: 5267
		[global::Cpp2ILInjected.Token(Token = "0x4001857")]
		internal static CalendarData Invariant;

		// Token: 0x04001494 RID: 5268
		[global::Cpp2ILInjected.Token(Token = "0x4001858")]
		private static string[] HEBREW_MONTH_NAMES;

		// Token: 0x04001495 RID: 5269
		[global::Cpp2ILInjected.Token(Token = "0x4001859")]
		private static string[] HEBREW_LEAP_MONTH_NAMES;
	}
}
