using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Globalization
{
	// Token: 0x020004BF RID: 1215
	[global::Cpp2ILInjected.Token(Token = "0x20005AC")]
	[global::System.Serializable]
	internal class GregorianCalendarHelper
	{
		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x06002856 RID: 10326 RVA: 0x0001B578 File Offset: 0x00019778
		[global::Cpp2ILInjected.Token(Token = "0x17000671")]
		internal int MaxYear
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002BB4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BEE564", Offset = "0x1BEE564", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002857 RID: 10327 RVA: 0x0001B57B File Offset: 0x0001977B
		[global::Cpp2ILInjected.Token(Token = "0x6002BB5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BEE56C", Offset = "0x1BEE56C", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal GregorianCalendarHelper(Calendar cal, EraInfo[] eraInfo)
		{
			throw null;
		}

		// Token: 0x06002858 RID: 10328 RVA: 0x0001B57E File Offset: 0x0001977E
		[global::Cpp2ILInjected.Token(Token = "0x6002BB6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BEE5C8", Offset = "0x1BEE5C8", Length = "0x294")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GregorianCalendarHelper), Member = "GetGregorianYear", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GregorianCalendarHelper), Member = "IsValidYear", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GregorianCalendarHelper), Member = "GetDaysInMonth", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GregorianCalendarHelper), Member = "GetDaysInYear", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GregorianCalendarHelper), Member = "GetMonthsInYear", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GregorianCalendarHelper), Member = "IsLeapYear", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GregorianCalendarHelper), Member = "ToDateTime", MemberParameters = new object[]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JapaneseCalendar), Member = "GetMonthsInYear", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JapaneseCalendar), Member = "IsValidYear", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TaiwanCalendar), Member = "GetMonthsInYear", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThaiBuddhistCalendar), Member = "GetMonthsInYear", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(global::System.IFormatProvider),
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		private int GetYearOffset(int year, int era, bool throwOnError)
		{
			throw null;
		}

		// Token: 0x06002859 RID: 10329 RVA: 0x0001B581 File Offset: 0x00019781
		[global::Cpp2ILInjected.Token(Token = "0x6002BB7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BEE85C", Offset = "0x1BEE85C", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GregorianCalendarHelper), Member = "GetYearOffset", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		internal int GetGregorianYear(int year, int era)
		{
			throw null;
		}

		// Token: 0x0600285A RID: 10330 RVA: 0x0001B584 File Offset: 0x00019784
		[global::Cpp2ILInjected.Token(Token = "0x6002BB8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BEE878", Offset = "0x1BEE878", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GregorianCalendarHelper), Member = "GetYearOffset", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		internal bool IsValidYear(int year, int era)
		{
			throw null;
		}

		// Token: 0x0600285B RID: 10331 RVA: 0x0001B587 File Offset: 0x00019787
		[global::Cpp2ILInjected.Token(Token = "0x6002BB9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BEE894", Offset = "0x1BEE894", Length = "0x1F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GregorianCalendarHelper), Member = "CheckTicksRange", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal virtual int GetDatePart(long ticks, int part)
		{
			throw null;
		}

		// Token: 0x0600285C RID: 10332 RVA: 0x0001B58A File Offset: 0x0001978A
		[global::Cpp2ILInjected.Token(Token = "0x6002BBA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BEEBFC", Offset = "0x1BEEBFC", Length = "0x1C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GregorianCalendarHelper), Member = "DateToTicks", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		internal static long GetAbsoluteDate(int year, int month, int day)
		{
			throw null;
		}

		// Token: 0x0600285D RID: 10333 RVA: 0x0001B58D File Offset: 0x0001978D
		[global::Cpp2ILInjected.Token(Token = "0x6002BBB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BEEDBC", Offset = "0x1BEEDBC", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GregorianCalendarHelper), Member = "ToDateTime", MemberParameters = new object[]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GregorianCalendarHelper), Member = "GetAbsoluteDate", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static long DateToTicks(int year, int month, int day)
		{
			throw null;
		}

		// Token: 0x0600285E RID: 10334 RVA: 0x0001B590 File Offset: 0x00019790
		[global::Cpp2ILInjected.Token(Token = "0x6002BBC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BEEE3C", Offset = "0x1BEEE3C", Length = "0x1B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GregorianCalendarHelper), Member = "ToDateTime", MemberParameters = new object[]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = "TimeToTicks", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(long))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		internal static long TimeToTicks(int hour, int minute, int second, int millisecond)
		{
			throw null;
		}

		// Token: 0x0600285F RID: 10335 RVA: 0x0001B593 File Offset: 0x00019793
		[global::Cpp2ILInjected.Token(Token = "0x6002BBD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BEEA84", Offset = "0x1BEEA84", Length = "0x178")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GregorianCalendarHelper), Member = "GetDatePart", MemberParameters = new object[]
		{
			typeof(long),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GregorianCalendarHelper), Member = "GetDayOfWeek", MemberParameters = new object[] { typeof(global::System.DateTime) }, ReturnType = typeof(global::System.DayOfWeek))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GregorianCalendarHelper), Member = "ToDateTime", MemberParameters = new object[]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		internal void CheckTicksRange(long ticks)
		{
			throw null;
		}

		// Token: 0x06002860 RID: 10336 RVA: 0x0001B596 File Offset: 0x00019796
		[global::Cpp2ILInjected.Token(Token = "0x6002BBE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BEEFEC", Offset = "0x1BEEFEC", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
		public int GetDayOfMonth(global::System.DateTime time)
		{
			throw null;
		}

		// Token: 0x06002861 RID: 10337 RVA: 0x0001B599 File Offset: 0x00019799
		[global::Cpp2ILInjected.Token(Token = "0x6002BBF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BEF02C", Offset = "0x1BEF02C", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JapaneseCalendar), Member = "GetDayOfWeek", MemberParameters = new object[] { typeof(global::System.DateTime) }, ReturnType = typeof(global::System.DayOfWeek))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TaiwanCalendar), Member = "GetDayOfWeek", MemberParameters = new object[] { typeof(global::System.DateTime) }, ReturnType = typeof(global::System.DayOfWeek))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThaiBuddhistCalendar), Member = "GetDayOfWeek", MemberParameters = new object[] { typeof(global::System.DateTime) }, ReturnType = typeof(global::System.DayOfWeek))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GregorianCalendarHelper), Member = "CheckTicksRange", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		public global::System.DayOfWeek GetDayOfWeek(global::System.DateTime time)
		{
			throw null;
		}

		// Token: 0x06002862 RID: 10338 RVA: 0x0001B59C File Offset: 0x0001979C
		[global::Cpp2ILInjected.Token(Token = "0x6002BC0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BEF0B8", Offset = "0x1BEF0B8", Length = "0x168")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JapaneseCalendar), Member = "GetDaysInMonth", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TaiwanCalendar), Member = "GetDaysInMonth", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThaiBuddhistCalendar), Member = "GetDaysInMonth", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GregorianCalendarHelper), Member = "GetYearOffset", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public int GetDaysInMonth(int year, int month, int era)
		{
			throw null;
		}

		// Token: 0x06002863 RID: 10339 RVA: 0x0001B59F File Offset: 0x0001979F
		[global::Cpp2ILInjected.Token(Token = "0x6002BC1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BEF220", Offset = "0x1BEF220", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JapaneseCalendar), Member = "GetDaysInYear", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TaiwanCalendar), Member = "GetDaysInYear", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThaiBuddhistCalendar), Member = "GetDaysInYear", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GregorianCalendarHelper), Member = "GetYearOffset", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		public int GetDaysInYear(int year, int era)
		{
			throw null;
		}

		// Token: 0x06002864 RID: 10340 RVA: 0x0001B5A2 File Offset: 0x000197A2
		[global::Cpp2ILInjected.Token(Token = "0x6002BC2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BEF290", Offset = "0x1BEF290", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JapaneseCalendar), Member = "GetEra", MemberParameters = new object[] { typeof(global::System.DateTime) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TaiwanCalendar), Member = "GetEra", MemberParameters = new object[] { typeof(global::System.DateTime) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThaiBuddhistCalendar), Member = "GetEra", MemberParameters = new object[] { typeof(global::System.DateTime) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public int GetEra(global::System.DateTime time)
		{
			throw null;
		}

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x06002865 RID: 10341 RVA: 0x0001B5A5 File Offset: 0x000197A5
		[global::Cpp2ILInjected.Token(Token = "0x17000672")]
		public int[] Eras
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002BC3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BEF340", Offset = "0x1BEF340", Length = "0xC0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JapaneseCalendar), Member = "get_Eras", ReturnType = typeof(int[]))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TaiwanCalendar), Member = "get_Eras", ReturnType = typeof(int[]))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThaiBuddhistCalendar), Member = "get_Eras", ReturnType = typeof(int[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clone", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002866 RID: 10342 RVA: 0x0001B5A8 File Offset: 0x000197A8
		[global::Cpp2ILInjected.Token(Token = "0x6002BC4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BEF400", Offset = "0x1BEF400", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
		public int GetMonth(global::System.DateTime time)
		{
			throw null;
		}

		// Token: 0x06002867 RID: 10343 RVA: 0x0001B5AB File Offset: 0x000197AB
		[global::Cpp2ILInjected.Token(Token = "0x6002BC5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BEF440", Offset = "0x1BEF440", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GregorianCalendarHelper), Member = "GetYearOffset", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		public int GetMonthsInYear(int year, int era)
		{
			throw null;
		}

		// Token: 0x06002868 RID: 10344 RVA: 0x0001B5AE File Offset: 0x000197AE
		[global::Cpp2ILInjected.Token(Token = "0x6002BC6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BEF458", Offset = "0x1BEF458", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JapaneseCalendar), Member = "GetYear", MemberParameters = new object[] { typeof(global::System.DateTime) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TaiwanCalendar), Member = "GetYear", MemberParameters = new object[] { typeof(global::System.DateTime) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThaiBuddhistCalendar), Member = "GetYear", MemberParameters = new object[] { typeof(global::System.DateTime) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public int GetYear(global::System.DateTime time)
		{
			throw null;
		}

		// Token: 0x06002869 RID: 10345 RVA: 0x0001B5B1 File Offset: 0x000197B1
		[global::Cpp2ILInjected.Token(Token = "0x6002BC7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BEF528", Offset = "0x1BEF528", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JapaneseCalendar), Member = "IsLeapYear", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TaiwanCalendar), Member = "IsLeapYear", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThaiBuddhistCalendar), Member = "IsLeapYear", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GregorianCalendarHelper), Member = "GetYearOffset", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		public bool IsLeapYear(int year, int era)
		{
			throw null;
		}

		// Token: 0x0600286A RID: 10346 RVA: 0x0001B5B4 File Offset: 0x000197B4
		[global::Cpp2ILInjected.Token(Token = "0x6002BC8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BEF598", Offset = "0x1BEF598", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JapaneseCalendar), Member = "ToDateTime", MemberParameters = new object[]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TaiwanCalendar), Member = "ToDateTime", MemberParameters = new object[]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThaiBuddhistCalendar), Member = "ToDateTime", MemberParameters = new object[]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GregorianCalendarHelper), Member = "GetYearOffset", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GregorianCalendarHelper), Member = "DateToTicks", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GregorianCalendarHelper), Member = "TimeToTicks", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GregorianCalendarHelper), Member = "CheckTicksRange", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = ".ctor", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public global::System.DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era)
		{
			throw null;
		}

		// Token: 0x0600286B RID: 10347 RVA: 0x0001B5B7 File Offset: 0x000197B7
		[global::Cpp2ILInjected.Token(Token = "0x6002BC9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BEF69C", Offset = "0x1BEF69C", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThaiBuddhistCalendar), Member = "ToFourDigitYear", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public int ToFourDigitYear(int year, int twoDigitYearMax)
		{
			throw null;
		}

		// Token: 0x0600286C RID: 10348 RVA: 0x0001B5BA File Offset: 0x000197BA
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6002BCA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BEF820", Offset = "0x1BEF820", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(global::System.RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		static GregorianCalendarHelper()
		{
			throw null;
		}

		// Token: 0x040014A2 RID: 5282
		[global::Cpp2ILInjected.Token(Token = "0x4001866")]
		internal static readonly int[] DaysToMonth365;

		// Token: 0x040014A3 RID: 5283
		[global::Cpp2ILInjected.Token(Token = "0x4001867")]
		internal static readonly int[] DaysToMonth366;

		// Token: 0x040014A4 RID: 5284
		[global::System.Runtime.Serialization.OptionalField(VersionAdded = 1)]
		[global::Cpp2ILInjected.Token(Token = "0x4001868")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal int m_maxYear;

		// Token: 0x040014A5 RID: 5285
		[global::System.Runtime.Serialization.OptionalField(VersionAdded = 1)]
		[global::Cpp2ILInjected.Token(Token = "0x4001869")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		internal int m_minYear;

		// Token: 0x040014A6 RID: 5286
		[global::Cpp2ILInjected.Token(Token = "0x400186A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal Calendar m_Cal;

		// Token: 0x040014A7 RID: 5287
		[global::System.Runtime.Serialization.OptionalField(VersionAdded = 1)]
		[global::Cpp2ILInjected.Token(Token = "0x400186B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal EraInfo[] m_EraInfo;

		// Token: 0x040014A8 RID: 5288
		[global::System.Runtime.Serialization.OptionalField(VersionAdded = 1)]
		[global::Cpp2ILInjected.Token(Token = "0x400186C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal int[] m_eras;

		// Token: 0x040014A9 RID: 5289
		[global::System.Runtime.Serialization.OptionalField(VersionAdded = 1)]
		[global::Cpp2ILInjected.Token(Token = "0x400186D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		internal global::System.DateTime m_minDate;
	}
}
