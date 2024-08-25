using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Globalization
{
	[global::Cpp2ILInjected.Token(Token = "0x20005A9")]
	[StructLayout(0)]
	internal class CalendarData
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002B8D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BEAD88", Offset = "0x1BEAD88", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		private CalendarData()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002B8E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BEAD98", Offset = "0x1BEAD98", Length = "0x11B0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 165)]
		static CalendarData()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6002B96")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BEAD80", Offset = "0x1BEAD80", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static int nativeGetTwoDigitYearMax(int calID)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6002B98")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BECFA8", Offset = "0x1BECFA8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private extern bool fill_calendar_data(string localeName, int datetimeIndex);

		[global::Cpp2ILInjected.Token(Token = "0x4001843")]
		internal const int MAX_CALENDARS = 23;

		[global::Cpp2ILInjected.Token(Token = "0x4001844")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal string sNativeName;

		[global::Cpp2ILInjected.Token(Token = "0x4001845")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal string[] saShortDates;

		[global::Cpp2ILInjected.Token(Token = "0x4001846")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal string[] saYearMonths;

		[global::Cpp2ILInjected.Token(Token = "0x4001847")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal string[] saLongDates;

		[global::Cpp2ILInjected.Token(Token = "0x4001848")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		internal string sMonthDay;

		[global::Cpp2ILInjected.Token(Token = "0x4001849")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		internal string[] saEraNames;

		[global::Cpp2ILInjected.Token(Token = "0x400184A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		internal string[] saAbbrevEraNames;

		[global::Cpp2ILInjected.Token(Token = "0x400184B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		internal string[] saAbbrevEnglishEraNames;

		[global::Cpp2ILInjected.Token(Token = "0x400184C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		internal string[] saDayNames;

		[global::Cpp2ILInjected.Token(Token = "0x400184D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		internal string[] saAbbrevDayNames;

		[global::Cpp2ILInjected.Token(Token = "0x400184E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		internal string[] saSuperShortDayNames;

		[global::Cpp2ILInjected.Token(Token = "0x400184F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		internal string[] saMonthNames;

		[global::Cpp2ILInjected.Token(Token = "0x4001850")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		internal string[] saAbbrevMonthNames;

		[global::Cpp2ILInjected.Token(Token = "0x4001851")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		internal string[] saMonthGenitiveNames;

		[global::Cpp2ILInjected.Token(Token = "0x4001852")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		internal string[] saAbbrevMonthGenitiveNames;

		[global::Cpp2ILInjected.Token(Token = "0x4001853")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		internal string[] saLeapYearMonthNames;

		[global::Cpp2ILInjected.Token(Token = "0x4001854")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		internal int iTwoDigitYearMax;

		[global::Cpp2ILInjected.Token(Token = "0x4001855")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x94")]
		internal int iCurrentEra;

		[global::Cpp2ILInjected.Token(Token = "0x4001856")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		internal bool bUseUserOverrides;

		[global::Cpp2ILInjected.Token(Token = "0x4001857")]
		internal static CalendarData Invariant;

		[global::Cpp2ILInjected.Token(Token = "0x4001858")]
		private static string[] HEBREW_MONTH_NAMES;

		[global::Cpp2ILInjected.Token(Token = "0x4001859")]
		private static string[] HEBREW_LEAP_MONTH_NAMES;
	}
}
