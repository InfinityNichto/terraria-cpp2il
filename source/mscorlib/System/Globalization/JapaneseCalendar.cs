using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Globalization
{
	// Token: 0x020004C2 RID: 1218
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20005AF")]
	[global::System.Serializable]
	public class JapaneseCalendar : Calendar
	{
		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x06002889 RID: 10377 RVA: 0x0001B611 File Offset: 0x00019811
		[global::System.Runtime.InteropServices.ComVisible(false)]
		[global::Cpp2ILInjected.Token(Token = "0x17000679")]
		public override global::System.DateTime MinSupportedDateTime
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002BE7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF0D3C", Offset = "0x1BF0D3C", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x0600288A RID: 10378 RVA: 0x0001B614 File Offset: 0x00019814
		[global::System.Runtime.InteropServices.ComVisible(false)]
		[global::Cpp2ILInjected.Token(Token = "0x1700067A")]
		public override global::System.DateTime MaxSupportedDateTime
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002BE8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF0D94", Offset = "0x1BF0D94", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600288B RID: 10379 RVA: 0x0001B617 File Offset: 0x00019817
		[global::Cpp2ILInjected.Token(Token = "0x6002BE9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF0DEC", Offset = "0x1BF0DEC", Length = "0x41C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JapaneseCalendar), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JapaneseCalendar), Member = "EraNames", ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JapaneseCalendar), Member = "EnglishEraNames", ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EraInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 40)]
		internal static EraInfo[] GetEraInfo()
		{
			throw null;
		}

		// Token: 0x0600288C RID: 10380 RVA: 0x0001B61A File Offset: 0x0001981A
		[global::Cpp2ILInjected.Token(Token = "0x6002BEA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF1208", Offset = "0x1BF1208", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static EraInfo[] GetErasFromRegistry()
		{
			throw null;
		}

		// Token: 0x0600288D RID: 10381 RVA: 0x0001B61D File Offset: 0x0001981D
		[global::Cpp2ILInjected.Token(Token = "0x6002BEB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF1210", Offset = "0x1BF1210", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "GetJapaneseCalendarDefaultInstance", ReturnType = typeof(Calendar))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetJapaneseCalendarDTFI", ReturnType = typeof(DateTimeFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JapaneseCalendar), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		internal static Calendar GetDefaultInstance()
		{
			throw null;
		}

		// Token: 0x0600288E RID: 10382 RVA: 0x0001B620 File Offset: 0x00019820
		[global::Cpp2ILInjected.Token(Token = "0x6002BEC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF12C0", Offset = "0x1BF12C0", Length = "0x1DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JapaneseCalendar), Member = "GetDefaultInstance", ReturnType = typeof(Calendar))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JapaneseCalendar), Member = "GetEraInfo", ReturnType = typeof(EraInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TypeInitializationException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		public JapaneseCalendar()
		{
			throw null;
		}

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x0600288F RID: 10383 RVA: 0x0001B623 File Offset: 0x00019823
		[global::Cpp2ILInjected.Token(Token = "0x1700067B")]
		internal override int ID
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002BED")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF149C", Offset = "0x1BF149C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002890 RID: 10384 RVA: 0x0001B626 File Offset: 0x00019826
		[global::Cpp2ILInjected.Token(Token = "0x6002BEE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF14A4", Offset = "0x1BF14A4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GregorianCalendarHelper), Member = "GetDaysInMonth", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		public override int GetDaysInMonth(int year, int month, int era)
		{
			throw null;
		}

		// Token: 0x06002891 RID: 10385 RVA: 0x0001B629 File Offset: 0x00019829
		[global::Cpp2ILInjected.Token(Token = "0x6002BEF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF14AC", Offset = "0x1BF14AC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GregorianCalendarHelper), Member = "GetDaysInYear", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		public override int GetDaysInYear(int year, int era)
		{
			throw null;
		}

		// Token: 0x06002892 RID: 10386 RVA: 0x0001B62C File Offset: 0x0001982C
		[global::Cpp2ILInjected.Token(Token = "0x6002BF0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF14B4", Offset = "0x1BF14B4", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
		public override int GetDayOfMonth(global::System.DateTime time)
		{
			throw null;
		}

		// Token: 0x06002893 RID: 10387 RVA: 0x0001B62F File Offset: 0x0001982F
		[global::Cpp2ILInjected.Token(Token = "0x6002BF1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF14F4", Offset = "0x1BF14F4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GregorianCalendarHelper), Member = "GetDayOfWeek", MemberParameters = new object[] { typeof(global::System.DateTime) }, ReturnType = typeof(global::System.DayOfWeek))]
		public override global::System.DayOfWeek GetDayOfWeek(global::System.DateTime time)
		{
			throw null;
		}

		// Token: 0x06002894 RID: 10388 RVA: 0x0001B632 File Offset: 0x00019832
		[global::Cpp2ILInjected.Token(Token = "0x6002BF2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF14FC", Offset = "0x1BF14FC", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GregorianCalendarHelper), Member = "GetYearOffset", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		public override int GetMonthsInYear(int year, int era)
		{
			throw null;
		}

		// Token: 0x06002895 RID: 10389 RVA: 0x0001B635 File Offset: 0x00019835
		[global::Cpp2ILInjected.Token(Token = "0x6002BF3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF1518", Offset = "0x1BF1518", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GregorianCalendarHelper), Member = "GetEra", MemberParameters = new object[] { typeof(global::System.DateTime) }, ReturnType = typeof(int))]
		public override int GetEra(global::System.DateTime time)
		{
			throw null;
		}

		// Token: 0x06002896 RID: 10390 RVA: 0x0001B638 File Offset: 0x00019838
		[global::Cpp2ILInjected.Token(Token = "0x6002BF4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF1520", Offset = "0x1BF1520", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
		public override int GetMonth(global::System.DateTime time)
		{
			throw null;
		}

		// Token: 0x06002897 RID: 10391 RVA: 0x0001B63B File Offset: 0x0001983B
		[global::Cpp2ILInjected.Token(Token = "0x6002BF5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF1560", Offset = "0x1BF1560", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GregorianCalendarHelper), Member = "GetYear", MemberParameters = new object[] { typeof(global::System.DateTime) }, ReturnType = typeof(int))]
		public override int GetYear(global::System.DateTime time)
		{
			throw null;
		}

		// Token: 0x06002898 RID: 10392 RVA: 0x0001B63E File Offset: 0x0001983E
		[global::Cpp2ILInjected.Token(Token = "0x6002BF6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF1568", Offset = "0x1BF1568", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GregorianCalendarHelper), Member = "IsLeapYear", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		public override bool IsLeapYear(int year, int era)
		{
			throw null;
		}

		// Token: 0x06002899 RID: 10393 RVA: 0x0001B641 File Offset: 0x00019841
		[global::Cpp2ILInjected.Token(Token = "0x6002BF7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF1570", Offset = "0x1BF1570", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GregorianCalendarHelper), Member = "ToDateTime", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(global::System.DateTime))]
		public override global::System.DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era)
		{
			throw null;
		}

		// Token: 0x0600289A RID: 10394 RVA: 0x0001B644 File Offset: 0x00019844
		[global::Cpp2ILInjected.Token(Token = "0x6002BF8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF1580", Offset = "0x1BF1580", Length = "0x13C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(global::System.IFormatProvider),
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public override int ToFourDigitYear(int year)
		{
			throw null;
		}

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x0600289B RID: 10395 RVA: 0x0001B647 File Offset: 0x00019847
		[global::Cpp2ILInjected.Token(Token = "0x1700067C")]
		public override int[] Eras
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002BF9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF16BC", Offset = "0x1BF16BC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GregorianCalendarHelper), Member = "get_Eras", ReturnType = typeof(int[]))]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600289C RID: 10396 RVA: 0x0001B64A File Offset: 0x0001984A
		[global::Cpp2ILInjected.Token(Token = "0x6002BFA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BECD0C", Offset = "0x1BECD0C", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JapaneseCalendar), Member = "GetEraInfo", ReturnType = typeof(EraInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal static string[] EraNames()
		{
			throw null;
		}

		// Token: 0x0600289D RID: 10397 RVA: 0x0001B64D File Offset: 0x0001984D
		[global::Cpp2ILInjected.Token(Token = "0x6002BFB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BECDF4", Offset = "0x1BECDF4", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CalendarData), Member = "GetJapaneseEnglishEraNames", ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JapaneseCalendar), Member = "GetEraInfo", ReturnType = typeof(EraInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal static string[] EnglishEraNames()
		{
			throw null;
		}

		// Token: 0x0600289E RID: 10398 RVA: 0x0001B650 File Offset: 0x00019850
		[global::Cpp2ILInjected.Token(Token = "0x6002BFC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF16C4", Offset = "0x1BF16C4", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GregorianCalendarHelper), Member = "GetYearOffset", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		internal override bool IsValidYear(int year, int era)
		{
			throw null;
		}

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x0600289F RID: 10399 RVA: 0x0001B653 File Offset: 0x00019853
		// (set) Token: 0x060028A0 RID: 10400 RVA: 0x0001B656 File Offset: 0x00019856
		[global::Cpp2ILInjected.Token(Token = "0x1700067D")]
		public override int TwoDigitYearMax
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002BFD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF16E4", Offset = "0x1BF16E4", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Calendar), Member = "GetSystemTwoDigitYearSetting", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6002BFE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF1728", Offset = "0x1BF1728", Length = "0x128")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Calendar), Member = "VerifyWritable", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
			{
				typeof(global::System.IFormatProvider),
				typeof(string),
				typeof(object),
				typeof(object)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060028A1 RID: 10401 RVA: 0x0001B659 File Offset: 0x00019859
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6002BFF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF1850", Offset = "0x1BF1850", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static JapaneseCalendar()
		{
			throw null;
		}

		// Token: 0x040014B6 RID: 5302
		[global::Cpp2ILInjected.Token(Token = "0x400187A")]
		internal static readonly global::System.DateTime calendarMinValue;

		// Token: 0x040014B7 RID: 5303
		[global::Cpp2ILInjected.Token(Token = "0x400187B")]
		internal static EraInfo[] japaneseEraInfo;

		// Token: 0x040014B8 RID: 5304
		[global::Cpp2ILInjected.Token(Token = "0x400187C")]
		internal static Calendar s_defaultInstance;

		// Token: 0x040014B9 RID: 5305
		[global::Cpp2ILInjected.Token(Token = "0x400187D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal GregorianCalendarHelper helper;
	}
}
