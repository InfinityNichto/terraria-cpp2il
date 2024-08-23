using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Globalization
{
	// Token: 0x020004C4 RID: 1220
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20005B1")]
	[global::System.Serializable]
	public class TaiwanCalendar : Calendar
	{
		// Token: 0x060028CB RID: 10443 RVA: 0x0001B6D7 File Offset: 0x000198D7
		[global::Cpp2ILInjected.Token(Token = "0x6002C29")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF27B0", Offset = "0x1BF27B0", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "GetTaiwanCalendarDefaultInstance", ReturnType = typeof(Calendar))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetTaiwanCalendarDTFI", ReturnType = typeof(DateTimeFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaiwanCalendar), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		internal static Calendar GetDefaultInstance()
		{
			throw null;
		}

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x060028CC RID: 10444 RVA: 0x0001B6DA File Offset: 0x000198DA
		[global::System.Runtime.InteropServices.ComVisible(false)]
		[global::Cpp2ILInjected.Token(Token = "0x1700069A")]
		public override global::System.DateTime MinSupportedDateTime
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002C2A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF2A3C", Offset = "0x1BF2A3C", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x060028CD RID: 10445 RVA: 0x0001B6DD File Offset: 0x000198DD
		[global::System.Runtime.InteropServices.ComVisible(false)]
		[global::Cpp2ILInjected.Token(Token = "0x1700069B")]
		public override global::System.DateTime MaxSupportedDateTime
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002C2B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF2A94", Offset = "0x1BF2A94", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060028CE RID: 10446 RVA: 0x0001B6E0 File Offset: 0x000198E0
		[global::Cpp2ILInjected.Token(Token = "0x6002C2C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF2860", Offset = "0x1BF2860", Length = "0x1DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TaiwanCalendar), Member = "GetDefaultInstance", ReturnType = typeof(Calendar))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TypeInitializationException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		public TaiwanCalendar()
		{
			throw null;
		}

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x060028CF RID: 10447 RVA: 0x0001B6E3 File Offset: 0x000198E3
		[global::Cpp2ILInjected.Token(Token = "0x1700069C")]
		internal override int ID
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002C2D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF2AEC", Offset = "0x1BF2AEC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060028D0 RID: 10448 RVA: 0x0001B6E6 File Offset: 0x000198E6
		[global::Cpp2ILInjected.Token(Token = "0x6002C2E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF2AF4", Offset = "0x1BF2AF4", Length = "0x8")]
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

		// Token: 0x060028D1 RID: 10449 RVA: 0x0001B6E9 File Offset: 0x000198E9
		[global::Cpp2ILInjected.Token(Token = "0x6002C2F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF2AFC", Offset = "0x1BF2AFC", Length = "0x8")]
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

		// Token: 0x060028D2 RID: 10450 RVA: 0x0001B6EC File Offset: 0x000198EC
		[global::Cpp2ILInjected.Token(Token = "0x6002C30")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF2B04", Offset = "0x1BF2B04", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
		public override int GetDayOfMonth(global::System.DateTime time)
		{
			throw null;
		}

		// Token: 0x060028D3 RID: 10451 RVA: 0x0001B6EF File Offset: 0x000198EF
		[global::Cpp2ILInjected.Token(Token = "0x6002C31")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF2B44", Offset = "0x1BF2B44", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GregorianCalendarHelper), Member = "GetDayOfWeek", MemberParameters = new object[] { typeof(global::System.DateTime) }, ReturnType = typeof(global::System.DayOfWeek))]
		public override global::System.DayOfWeek GetDayOfWeek(global::System.DateTime time)
		{
			throw null;
		}

		// Token: 0x060028D4 RID: 10452 RVA: 0x0001B6F2 File Offset: 0x000198F2
		[global::Cpp2ILInjected.Token(Token = "0x6002C32")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF2B4C", Offset = "0x1BF2B4C", Length = "0x1C")]
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

		// Token: 0x060028D5 RID: 10453 RVA: 0x0001B6F5 File Offset: 0x000198F5
		[global::Cpp2ILInjected.Token(Token = "0x6002C33")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF2B68", Offset = "0x1BF2B68", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GregorianCalendarHelper), Member = "GetEra", MemberParameters = new object[] { typeof(global::System.DateTime) }, ReturnType = typeof(int))]
		public override int GetEra(global::System.DateTime time)
		{
			throw null;
		}

		// Token: 0x060028D6 RID: 10454 RVA: 0x0001B6F8 File Offset: 0x000198F8
		[global::Cpp2ILInjected.Token(Token = "0x6002C34")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF2B70", Offset = "0x1BF2B70", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
		public override int GetMonth(global::System.DateTime time)
		{
			throw null;
		}

		// Token: 0x060028D7 RID: 10455 RVA: 0x0001B6FB File Offset: 0x000198FB
		[global::Cpp2ILInjected.Token(Token = "0x6002C35")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF2BB0", Offset = "0x1BF2BB0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GregorianCalendarHelper), Member = "GetYear", MemberParameters = new object[] { typeof(global::System.DateTime) }, ReturnType = typeof(int))]
		public override int GetYear(global::System.DateTime time)
		{
			throw null;
		}

		// Token: 0x060028D8 RID: 10456 RVA: 0x0001B6FE File Offset: 0x000198FE
		[global::Cpp2ILInjected.Token(Token = "0x6002C36")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF2BB8", Offset = "0x1BF2BB8", Length = "0x8")]
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

		// Token: 0x060028D9 RID: 10457 RVA: 0x0001B701 File Offset: 0x00019901
		[global::Cpp2ILInjected.Token(Token = "0x6002C37")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF2BC0", Offset = "0x1BF2BC0", Length = "0x10")]
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

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x060028DA RID: 10458 RVA: 0x0001B704 File Offset: 0x00019904
		[global::Cpp2ILInjected.Token(Token = "0x1700069D")]
		public override int[] Eras
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002C38")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF2BD0", Offset = "0x1BF2BD0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GregorianCalendarHelper), Member = "get_Eras", ReturnType = typeof(int[]))]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x060028DB RID: 10459 RVA: 0x0001B707 File Offset: 0x00019907
		// (set) Token: 0x060028DC RID: 10460 RVA: 0x0001B70A File Offset: 0x0001990A
		[global::Cpp2ILInjected.Token(Token = "0x1700069E")]
		public override int TwoDigitYearMax
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002C39")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF2BD8", Offset = "0x1BF2BD8", Length = "0x44")]
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
			[global::Cpp2ILInjected.Token(Token = "0x6002C3A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF2C1C", Offset = "0x1BF2C1C", Length = "0x128")]
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

		// Token: 0x060028DD RID: 10461 RVA: 0x0001B70D File Offset: 0x0001990D
		[global::Cpp2ILInjected.Token(Token = "0x6002C3B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF2D44", Offset = "0x1BF2D44", Length = "0x13C")]
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

		// Token: 0x060028DE RID: 10462 RVA: 0x0001B710 File Offset: 0x00019910
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6002C3C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF2E80", Offset = "0x1BF2E80", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EraInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		static TaiwanCalendar()
		{
			throw null;
		}

		// Token: 0x040014DE RID: 5342
		[global::Cpp2ILInjected.Token(Token = "0x40018A2")]
		internal static EraInfo[] taiwanEraInfo;

		// Token: 0x040014DF RID: 5343
		[global::Cpp2ILInjected.Token(Token = "0x40018A3")]
		internal static Calendar s_defaultInstance;

		// Token: 0x040014E0 RID: 5344
		[global::Cpp2ILInjected.Token(Token = "0x40018A4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal GregorianCalendarHelper helper;

		// Token: 0x040014E1 RID: 5345
		[global::Cpp2ILInjected.Token(Token = "0x40018A5")]
		internal static readonly global::System.DateTime calendarMinValue;
	}
}
