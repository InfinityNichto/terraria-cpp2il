using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Globalization
{
	// Token: 0x020004C1 RID: 1217
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20005AE")]
	[global::System.Serializable]
	public class HijriCalendar : Calendar
	{
		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x0600286D RID: 10349 RVA: 0x0001B5BD File Offset: 0x000197BD
		[global::System.Runtime.InteropServices.ComVisible(false)]
		[global::Cpp2ILInjected.Token(Token = "0x17000673")]
		public override global::System.DateTime MinSupportedDateTime
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002BCB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BEF8F0", Offset = "0x1BEF8F0", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x0600286E RID: 10350 RVA: 0x0001B5C0 File Offset: 0x000197C0
		[global::System.Runtime.InteropServices.ComVisible(false)]
		[global::Cpp2ILInjected.Token(Token = "0x17000674")]
		public override global::System.DateTime MaxSupportedDateTime
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002BCC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BEF948", Offset = "0x1BEF948", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600286F RID: 10351 RVA: 0x0001B5C3 File Offset: 0x000197C3
		[global::Cpp2ILInjected.Token(Token = "0x6002BCD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BEF9A0", Offset = "0x1BEF9A0", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public HijriCalendar()
		{
			throw null;
		}

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x06002870 RID: 10352 RVA: 0x0001B5C6 File Offset: 0x000197C6
		[global::Cpp2ILInjected.Token(Token = "0x17000675")]
		internal override int ID
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002BCE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BEF9BC", Offset = "0x1BEF9BC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002871 RID: 10353 RVA: 0x0001B5C9 File Offset: 0x000197C9
		[global::Cpp2ILInjected.Token(Token = "0x6002BCF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BEF9C4", Offset = "0x1BEF9C4", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HijriCalendar), Member = "ToDateTime", MemberParameters = new object[]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HijriCalendar), Member = "DaysUpToHijriYear", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HijriCalendar), Member = "get_HijriAdjustment", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private long GetAbsoluteDateHijri(int y, int m, int d)
		{
			throw null;
		}

		// Token: 0x06002872 RID: 10354 RVA: 0x0001B5CC File Offset: 0x000197CC
		[global::Cpp2ILInjected.Token(Token = "0x6002BD0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BEFA74", Offset = "0x1BEFA74", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HijriCalendar), Member = "GetAbsoluteDateHijri", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HijriCalendar), Member = "GetDatePart", MemberParameters = new object[]
		{
			typeof(long),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		private long DaysUpToHijriYear(int HijriYear)
		{
			throw null;
		}

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x06002873 RID: 10355 RVA: 0x0001B5CF File Offset: 0x000197CF
		[global::Cpp2ILInjected.Token(Token = "0x17000676")]
		public int HijriAdjustment
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002BD1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BEFB30", Offset = "0x1BEFB30", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HijriCalendar), Member = "GetAbsoluteDateHijri", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(long))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HijriCalendar), Member = "GetDatePart", MemberParameters = new object[]
			{
				typeof(long),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002874 RID: 10356 RVA: 0x0001B5D2 File Offset: 0x000197D2
		[global::Cpp2ILInjected.Token(Token = "0x6002BD2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BEFB98", Offset = "0x1BEFB98", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static int GetAdvanceHijriDate()
		{
			throw null;
		}

		// Token: 0x06002875 RID: 10357 RVA: 0x0001B5D5 File Offset: 0x000197D5
		[global::Cpp2ILInjected.Token(Token = "0x6002BD3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BEFBA0", Offset = "0x1BEFBA0", Length = "0x1AC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HijriCalendar), Member = "GetDatePart", MemberParameters = new object[]
		{
			typeof(long),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HijriCalendar), Member = "GetEra", MemberParameters = new object[] { typeof(global::System.DateTime) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		internal static void CheckTicksRange(long ticks)
		{
			throw null;
		}

		// Token: 0x06002876 RID: 10358 RVA: 0x0001B5D8 File Offset: 0x000197D8
		[global::Cpp2ILInjected.Token(Token = "0x6002BD4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BEFD4C", Offset = "0x1BEFD4C", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HijriCalendar), Member = "CheckYearRange", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		internal static void CheckEraRange(int era)
		{
			throw null;
		}

		// Token: 0x06002877 RID: 10359 RVA: 0x0001B5DB File Offset: 0x000197DB
		[global::Cpp2ILInjected.Token(Token = "0x6002BD5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BEFE18", Offset = "0x1BEFE18", Length = "0x154")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HijriCalendar), Member = "CheckYearMonthRange", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HijriCalendar), Member = "GetDaysInYear", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HijriCalendar), Member = "GetMonthsInYear", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HijriCalendar), Member = "IsLeapYear", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HijriCalendar), Member = "CheckEraRange", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		internal static void CheckYearRange(int year, int era)
		{
			throw null;
		}

		// Token: 0x06002878 RID: 10360 RVA: 0x0001B5DE File Offset: 0x000197DE
		[global::Cpp2ILInjected.Token(Token = "0x6002BD6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BEFF6C", Offset = "0x1BEFF6C", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HijriCalendar), Member = "GetDaysInMonth", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HijriCalendar), Member = "CheckYearRange", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		internal static void CheckYearMonthRange(int year, int month, int era)
		{
			throw null;
		}

		// Token: 0x06002879 RID: 10361 RVA: 0x0001B5E1 File Offset: 0x000197E1
		[global::Cpp2ILInjected.Token(Token = "0x6002BD7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF00F0", Offset = "0x1BF00F0", Length = "0x234")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HijriCalendar), Member = "CheckTicksRange", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HijriCalendar), Member = "get_HijriAdjustment", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HijriCalendar), Member = "DaysUpToHijriYear", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		internal virtual int GetDatePart(long ticks, int part)
		{
			throw null;
		}

		// Token: 0x0600287A RID: 10362 RVA: 0x0001B5E4 File Offset: 0x000197E4
		[global::Cpp2ILInjected.Token(Token = "0x6002BD8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF0324", Offset = "0x1BF0324", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
		public override int GetDayOfMonth(global::System.DateTime time)
		{
			throw null;
		}

		// Token: 0x0600287B RID: 10363 RVA: 0x0001B5E7 File Offset: 0x000197E7
		[global::Cpp2ILInjected.Token(Token = "0x6002BD9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF0368", Offset = "0x1BF0368", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
		public override global::System.DayOfWeek GetDayOfWeek(global::System.DateTime time)
		{
			throw null;
		}

		// Token: 0x0600287C RID: 10364 RVA: 0x0001B5EA File Offset: 0x000197EA
		[global::Cpp2ILInjected.Token(Token = "0x6002BDA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF03D0", Offset = "0x1BF03D0", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HijriCalendar), Member = "CheckYearMonthRange", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override int GetDaysInMonth(int year, int month, int era)
		{
			throw null;
		}

		// Token: 0x0600287D RID: 10365 RVA: 0x0001B5ED File Offset: 0x000197ED
		[global::Cpp2ILInjected.Token(Token = "0x6002BDB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF049C", Offset = "0x1BF049C", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HijriCalendar), Member = "CheckYearRange", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override int GetDaysInYear(int year, int era)
		{
			throw null;
		}

		// Token: 0x0600287E RID: 10366 RVA: 0x0001B5F0 File Offset: 0x000197F0
		[global::Cpp2ILInjected.Token(Token = "0x6002BDC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF0530", Offset = "0x1BF0530", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HijriCalendar), Member = "CheckTicksRange", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override int GetEra(global::System.DateTime time)
		{
			throw null;
		}

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x0600287F RID: 10367 RVA: 0x0001B5F3 File Offset: 0x000197F3
		[global::Cpp2ILInjected.Token(Token = "0x17000677")]
		public override int[] Eras
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002BDD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF05A8", Offset = "0x1BF05A8", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002880 RID: 10368 RVA: 0x0001B5F6 File Offset: 0x000197F6
		[global::Cpp2ILInjected.Token(Token = "0x6002BDE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF0630", Offset = "0x1BF0630", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
		public override int GetMonth(global::System.DateTime time)
		{
			throw null;
		}

		// Token: 0x06002881 RID: 10369 RVA: 0x0001B5F9 File Offset: 0x000197F9
		[global::Cpp2ILInjected.Token(Token = "0x6002BDF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF0674", Offset = "0x1BF0674", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HijriCalendar), Member = "CheckYearRange", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override int GetMonthsInYear(int year, int era)
		{
			throw null;
		}

		// Token: 0x06002882 RID: 10370 RVA: 0x0001B5FC File Offset: 0x000197FC
		[global::Cpp2ILInjected.Token(Token = "0x6002BE0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF06E0", Offset = "0x1BF06E0", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
		public override int GetYear(global::System.DateTime time)
		{
			throw null;
		}

		// Token: 0x06002883 RID: 10371 RVA: 0x0001B5FF File Offset: 0x000197FF
		[global::Cpp2ILInjected.Token(Token = "0x6002BE1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF0724", Offset = "0x1BF0724", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HijriCalendar), Member = "CheckYearRange", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool IsLeapYear(int year, int era)
		{
			throw null;
		}

		// Token: 0x06002884 RID: 10372 RVA: 0x0001B602 File Offset: 0x00019802
		[global::Cpp2ILInjected.Token(Token = "0x6002BE2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF07C4", Offset = "0x1BF07C4", Length = "0x1D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HijriCalendar), Member = "GetAbsoluteDateHijri", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Calendar), Member = "TimeToTicks", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = ".ctor", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public override global::System.DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era)
		{
			throw null;
		}

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x06002885 RID: 10373 RVA: 0x0001B605 File Offset: 0x00019805
		// (set) Token: 0x06002886 RID: 10374 RVA: 0x0001B608 File Offset: 0x00019808
		[global::Cpp2ILInjected.Token(Token = "0x17000678")]
		public override int TwoDigitYearMax
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002BE3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF0998", Offset = "0x1BF0998", Length = "0x44")]
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
			[global::Cpp2ILInjected.Token(Token = "0x6002BE4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF09DC", Offset = "0x1BF09DC", Length = "0x114")]
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

		// Token: 0x06002887 RID: 10375 RVA: 0x0001B60B File Offset: 0x0001980B
		[global::Cpp2ILInjected.Token(Token = "0x6002BE5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF0AF0", Offset = "0x1BF0AF0", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Calendar), Member = "ToFourDigitYear", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
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

		// Token: 0x06002888 RID: 10376 RVA: 0x0001B60E File Offset: 0x0001980E
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6002BE6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF0C28", Offset = "0x1BF0C28", Length = "0x114")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(global::System.RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		static HijriCalendar()
		{
			throw null;
		}

		// Token: 0x040014B1 RID: 5297
		[global::Cpp2ILInjected.Token(Token = "0x4001875")]
		public static readonly int HijriEra;

		// Token: 0x040014B2 RID: 5298
		[global::Cpp2ILInjected.Token(Token = "0x4001876")]
		internal static readonly int[] HijriMonthDays;

		// Token: 0x040014B3 RID: 5299
		[global::Cpp2ILInjected.Token(Token = "0x4001877")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private int m_HijriAdvance;

		// Token: 0x040014B4 RID: 5300
		[global::Cpp2ILInjected.Token(Token = "0x4001878")]
		internal static readonly global::System.DateTime calendarMinValue;

		// Token: 0x040014B5 RID: 5301
		[global::Cpp2ILInjected.Token(Token = "0x4001879")]
		internal static readonly global::System.DateTime calendarMaxValue;
	}
}
