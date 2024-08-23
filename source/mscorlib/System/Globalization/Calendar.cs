using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Globalization
{
	// Token: 0x020004BB RID: 1211
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20005A8")]
	[global::System.Serializable]
	public abstract class Calendar : global::System.ICloneable
	{
		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x0600280E RID: 10254 RVA: 0x0001B4C4 File Offset: 0x000196C4
		[global::System.Runtime.InteropServices.ComVisible(false)]
		[global::Cpp2ILInjected.Token(Token = "0x17000664")]
		public virtual global::System.DateTime MinSupportedDateTime
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002B6C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BEA35C", Offset = "0x1BEA35C", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x0600280F RID: 10255 RVA: 0x0001B4C7 File Offset: 0x000196C7
		[global::System.Runtime.InteropServices.ComVisible(false)]
		[global::Cpp2ILInjected.Token(Token = "0x17000665")]
		public virtual global::System.DateTime MaxSupportedDateTime
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002B6D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BEA3B4", Offset = "0x1BEA3B4", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002810 RID: 10256 RVA: 0x0001B4CA File Offset: 0x000196CA
		[global::Cpp2ILInjected.Token(Token = "0x6002B6E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BEA40C", Offset = "0x1BEA40C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UmAlQuraCalendar), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected Calendar()
		{
			throw null;
		}

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x06002811 RID: 10257 RVA: 0x0001B4CD File Offset: 0x000196CD
		[global::Cpp2ILInjected.Token(Token = "0x17000666")]
		internal virtual int ID
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002B6F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BEA420", Offset = "0x1BEA420", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x06002812 RID: 10258 RVA: 0x0001B4D0 File Offset: 0x000196D0
		[global::Cpp2ILInjected.Token(Token = "0x17000667")]
		internal virtual int BaseCalendarID
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002B70")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BEA428", Offset = "0x1BEA428", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x06002813 RID: 10259 RVA: 0x0001B4D3 File Offset: 0x000196D3
		[global::System.Runtime.InteropServices.ComVisible(false)]
		[global::Cpp2ILInjected.Token(Token = "0x17000668")]
		public bool IsReadOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002B71")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BEA434", Offset = "0x1BEA434", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002814 RID: 10260 RVA: 0x0001B4D6 File Offset: 0x000196D6
		[global::System.Runtime.InteropServices.ComVisible(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6002B72")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BEA43C", Offset = "0x1BEA43C", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "MemberwiseClone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual object Clone()
		{
			throw null;
		}

		// Token: 0x06002815 RID: 10261 RVA: 0x0001B4D9 File Offset: 0x000196D9
		[global::System.Runtime.InteropServices.ComVisible(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6002B73")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BEA4C0", Offset = "0x1BEA4C0", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "ReadOnly", MemberParameters = new object[] { typeof(DateTimeFormatInfo) }, ReturnType = typeof(DateTimeFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "MemberwiseClone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static Calendar ReadOnly(Calendar calendar)
		{
			throw null;
		}

		// Token: 0x06002816 RID: 10262 RVA: 0x0001B4DC File Offset: 0x000196DC
		[global::Cpp2ILInjected.Token(Token = "0x6002B74")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BEA5A8", Offset = "0x1BEA5A8", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Calendar), Member = "set_TwoDigitYearMax", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GregorianCalendar), Member = "set_TwoDigitYearMax", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HijriCalendar), Member = "set_TwoDigitYearMax", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JapaneseCalendar), Member = "set_TwoDigitYearMax", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TaiwanCalendar), Member = "set_TwoDigitYearMax", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThaiBuddhistCalendar), Member = "set_TwoDigitYearMax", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UmAlQuraCalendar), Member = "set_TwoDigitYearMax", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal void VerifyWritable()
		{
			throw null;
		}

		// Token: 0x06002817 RID: 10263 RVA: 0x0001B4DF File Offset: 0x000196DF
		[global::Cpp2ILInjected.Token(Token = "0x6002B75")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BEA614", Offset = "0x1BEA614", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void SetReadOnlyState(bool readOnly)
		{
			throw null;
		}

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x06002818 RID: 10264 RVA: 0x0001B4E2 File Offset: 0x000196E2
		[global::Cpp2ILInjected.Token(Token = "0x17000669")]
		internal virtual int CurrentEraValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002B76")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BEA620", Offset = "0x1BEA620", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CalendarData), Member = "GetCalendarData", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(CalendarData))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002819 RID: 10265
		[global::Cpp2ILInjected.Token(Token = "0x6002B77")]
		public abstract int GetDayOfMonth(global::System.DateTime time);

		// Token: 0x0600281A RID: 10266
		[global::Cpp2ILInjected.Token(Token = "0x6002B78")]
		public abstract global::System.DayOfWeek GetDayOfWeek(global::System.DateTime time);

		// Token: 0x0600281B RID: 10267
		[global::Cpp2ILInjected.Token(Token = "0x6002B79")]
		public abstract int GetDaysInMonth(int year, int month, int era);

		// Token: 0x0600281C RID: 10268
		[global::Cpp2ILInjected.Token(Token = "0x6002B7A")]
		public abstract int GetDaysInYear(int year, int era);

		// Token: 0x0600281D RID: 10269
		[global::Cpp2ILInjected.Token(Token = "0x6002B7B")]
		public abstract int GetEra(global::System.DateTime time);

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x0600281E RID: 10270
		[global::Cpp2ILInjected.Token(Token = "0x1700066A")]
		public abstract int[] Eras
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002B7C")]
			get;
		}

		// Token: 0x0600281F RID: 10271
		[global::Cpp2ILInjected.Token(Token = "0x6002B7D")]
		public abstract int GetMonth(global::System.DateTime time);

		// Token: 0x06002820 RID: 10272
		[global::Cpp2ILInjected.Token(Token = "0x6002B7E")]
		public abstract int GetMonthsInYear(int year, int era);

		// Token: 0x06002821 RID: 10273
		[global::Cpp2ILInjected.Token(Token = "0x6002B7F")]
		public abstract int GetYear(global::System.DateTime time);

		// Token: 0x06002822 RID: 10274 RVA: 0x0001B4E5 File Offset: 0x000196E5
		[global::Cpp2ILInjected.Token(Token = "0x6002B80")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BEA740", Offset = "0x1BEA740", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual bool IsLeapYear(int year)
		{
			throw null;
		}

		// Token: 0x06002823 RID: 10275
		[global::Cpp2ILInjected.Token(Token = "0x6002B81")]
		public abstract bool IsLeapYear(int year, int era);

		// Token: 0x06002824 RID: 10276 RVA: 0x0001B4E8 File Offset: 0x000196E8
		[global::Cpp2ILInjected.Token(Token = "0x6002B82")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BEA754", Offset = "0x1BEA754", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual global::System.DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond)
		{
			throw null;
		}

		// Token: 0x06002825 RID: 10277
		[global::Cpp2ILInjected.Token(Token = "0x6002B83")]
		public abstract global::System.DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era);

		// Token: 0x06002826 RID: 10278 RVA: 0x0001B4EB File Offset: 0x000196EB
		[global::Cpp2ILInjected.Token(Token = "0x6002B84")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BEA77C", Offset = "0x1BEA77C", Length = "0x160")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		internal virtual bool TryToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era, out global::System.DateTime result)
		{
			throw null;
		}

		// Token: 0x06002827 RID: 10279 RVA: 0x0001B4EE File Offset: 0x000196EE
		[global::Cpp2ILInjected.Token(Token = "0x6002B85")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BEA8DC", Offset = "0x1BEA8DC", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal virtual bool IsValidYear(int year, int era)
		{
			throw null;
		}

		// Token: 0x06002828 RID: 10280 RVA: 0x0001B4F1 File Offset: 0x000196F1
		[global::Cpp2ILInjected.Token(Token = "0x6002B86")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BEA960", Offset = "0x1BEA960", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal virtual bool IsValidMonth(int year, int month, int era)
		{
			throw null;
		}

		// Token: 0x06002829 RID: 10281 RVA: 0x0001B4F4 File Offset: 0x000196F4
		[global::Cpp2ILInjected.Token(Token = "0x6002B87")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BEA9D8", Offset = "0x1BEA9D8", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal virtual bool IsValidDay(int year, int month, int day, int era)
		{
			throw null;
		}

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x0600282A RID: 10282 RVA: 0x0001B4F7 File Offset: 0x000196F7
		// (set) Token: 0x0600282B RID: 10283 RVA: 0x0001B4FA File Offset: 0x000196FA
		[global::Cpp2ILInjected.Token(Token = "0x1700066B")]
		public virtual int TwoDigitYearMax
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002B88")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BEAA58", Offset = "0x1BEAA58", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6002B89")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BEAA60", Offset = "0x1BEAA60", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Calendar), Member = "VerifyWritable", ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600282C RID: 10284 RVA: 0x0001B4FD File Offset: 0x000196FD
		[global::Cpp2ILInjected.Token(Token = "0x6002B8A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BEAA84", Offset = "0x1BEAA84", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GregorianCalendar), Member = "ToFourDigitYear", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HijriCalendar), Member = "ToFourDigitYear", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UmAlQuraCalendar), Member = "ToFourDigitYear", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public virtual int ToFourDigitYear(int year)
		{
			throw null;
		}

		// Token: 0x0600282D RID: 10285 RVA: 0x0001B500 File Offset: 0x00019700
		[global::Cpp2ILInjected.Token(Token = "0x6002B8B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BEAB7C", Offset = "0x1BEAB7C", Length = "0x1B0")]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UmAlQuraCalendar), Member = "ToDateTime", MemberParameters = new object[]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = "TimeToTicks", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
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

		// Token: 0x0600282E RID: 10286 RVA: 0x0001B503 File Offset: 0x00019703
		[global::Cpp2ILInjected.Token(Token = "0x6002B8C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BEAD2C", Offset = "0x1BEAD2C", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GregorianCalendar), Member = "get_TwoDigitYearMax", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HijriCalendar), Member = "get_TwoDigitYearMax", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JapaneseCalendar), Member = "get_TwoDigitYearMax", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TaiwanCalendar), Member = "get_TwoDigitYearMax", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThaiBuddhistCalendar), Member = "get_TwoDigitYearMax", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UmAlQuraCalendar), Member = "get_TwoDigitYearMax", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static int GetSystemTwoDigitYearSetting(int CalID, int defaultYearValue)
		{
			throw null;
		}

		// Token: 0x04001455 RID: 5205
		[global::Cpp2ILInjected.Token(Token = "0x4001819")]
		internal const long TicksPerMillisecond = 10000L;

		// Token: 0x04001456 RID: 5206
		[global::Cpp2ILInjected.Token(Token = "0x400181A")]
		internal const long TicksPerSecond = 10000000L;

		// Token: 0x04001457 RID: 5207
		[global::Cpp2ILInjected.Token(Token = "0x400181B")]
		internal const long TicksPerMinute = 600000000L;

		// Token: 0x04001458 RID: 5208
		[global::Cpp2ILInjected.Token(Token = "0x400181C")]
		internal const long TicksPerHour = 36000000000L;

		// Token: 0x04001459 RID: 5209
		[global::Cpp2ILInjected.Token(Token = "0x400181D")]
		internal const long TicksPerDay = 864000000000L;

		// Token: 0x0400145A RID: 5210
		[global::Cpp2ILInjected.Token(Token = "0x400181E")]
		internal const int MillisPerSecond = 1000;

		// Token: 0x0400145B RID: 5211
		[global::Cpp2ILInjected.Token(Token = "0x400181F")]
		internal const int MillisPerMinute = 60000;

		// Token: 0x0400145C RID: 5212
		[global::Cpp2ILInjected.Token(Token = "0x4001820")]
		internal const int MillisPerHour = 3600000;

		// Token: 0x0400145D RID: 5213
		[global::Cpp2ILInjected.Token(Token = "0x4001821")]
		internal const int MillisPerDay = 86400000;

		// Token: 0x0400145E RID: 5214
		[global::Cpp2ILInjected.Token(Token = "0x4001822")]
		internal const int DaysPerYear = 365;

		// Token: 0x0400145F RID: 5215
		[global::Cpp2ILInjected.Token(Token = "0x4001823")]
		internal const int DaysPer4Years = 1461;

		// Token: 0x04001460 RID: 5216
		[global::Cpp2ILInjected.Token(Token = "0x4001824")]
		internal const int DaysPer100Years = 36524;

		// Token: 0x04001461 RID: 5217
		[global::Cpp2ILInjected.Token(Token = "0x4001825")]
		internal const int DaysPer400Years = 146097;

		// Token: 0x04001462 RID: 5218
		[global::Cpp2ILInjected.Token(Token = "0x4001826")]
		internal const int DaysTo10000 = 3652059;

		// Token: 0x04001463 RID: 5219
		[global::Cpp2ILInjected.Token(Token = "0x4001827")]
		internal const long MaxMillis = 315537897600000L;

		// Token: 0x04001464 RID: 5220
		[global::Cpp2ILInjected.Token(Token = "0x4001828")]
		internal const int CAL_GREGORIAN = 1;

		// Token: 0x04001465 RID: 5221
		[global::Cpp2ILInjected.Token(Token = "0x4001829")]
		internal const int CAL_GREGORIAN_US = 2;

		// Token: 0x04001466 RID: 5222
		[global::Cpp2ILInjected.Token(Token = "0x400182A")]
		internal const int CAL_JAPAN = 3;

		// Token: 0x04001467 RID: 5223
		[global::Cpp2ILInjected.Token(Token = "0x400182B")]
		internal const int CAL_TAIWAN = 4;

		// Token: 0x04001468 RID: 5224
		[global::Cpp2ILInjected.Token(Token = "0x400182C")]
		internal const int CAL_KOREA = 5;

		// Token: 0x04001469 RID: 5225
		[global::Cpp2ILInjected.Token(Token = "0x400182D")]
		internal const int CAL_HIJRI = 6;

		// Token: 0x0400146A RID: 5226
		[global::Cpp2ILInjected.Token(Token = "0x400182E")]
		internal const int CAL_THAI = 7;

		// Token: 0x0400146B RID: 5227
		[global::Cpp2ILInjected.Token(Token = "0x400182F")]
		internal const int CAL_HEBREW = 8;

		// Token: 0x0400146C RID: 5228
		[global::Cpp2ILInjected.Token(Token = "0x4001830")]
		internal const int CAL_GREGORIAN_ME_FRENCH = 9;

		// Token: 0x0400146D RID: 5229
		[global::Cpp2ILInjected.Token(Token = "0x4001831")]
		internal const int CAL_GREGORIAN_ARABIC = 10;

		// Token: 0x0400146E RID: 5230
		[global::Cpp2ILInjected.Token(Token = "0x4001832")]
		internal const int CAL_GREGORIAN_XLIT_ENGLISH = 11;

		// Token: 0x0400146F RID: 5231
		[global::Cpp2ILInjected.Token(Token = "0x4001833")]
		internal const int CAL_GREGORIAN_XLIT_FRENCH = 12;

		// Token: 0x04001470 RID: 5232
		[global::Cpp2ILInjected.Token(Token = "0x4001834")]
		internal const int CAL_JULIAN = 13;

		// Token: 0x04001471 RID: 5233
		[global::Cpp2ILInjected.Token(Token = "0x4001835")]
		internal const int CAL_JAPANESELUNISOLAR = 14;

		// Token: 0x04001472 RID: 5234
		[global::Cpp2ILInjected.Token(Token = "0x4001836")]
		internal const int CAL_CHINESELUNISOLAR = 15;

		// Token: 0x04001473 RID: 5235
		[global::Cpp2ILInjected.Token(Token = "0x4001837")]
		internal const int CAL_SAKA = 16;

		// Token: 0x04001474 RID: 5236
		[global::Cpp2ILInjected.Token(Token = "0x4001838")]
		internal const int CAL_LUNAR_ETO_CHN = 17;

		// Token: 0x04001475 RID: 5237
		[global::Cpp2ILInjected.Token(Token = "0x4001839")]
		internal const int CAL_LUNAR_ETO_KOR = 18;

		// Token: 0x04001476 RID: 5238
		[global::Cpp2ILInjected.Token(Token = "0x400183A")]
		internal const int CAL_LUNAR_ETO_ROKUYOU = 19;

		// Token: 0x04001477 RID: 5239
		[global::Cpp2ILInjected.Token(Token = "0x400183B")]
		internal const int CAL_KOREANLUNISOLAR = 20;

		// Token: 0x04001478 RID: 5240
		[global::Cpp2ILInjected.Token(Token = "0x400183C")]
		internal const int CAL_TAIWANLUNISOLAR = 21;

		// Token: 0x04001479 RID: 5241
		[global::Cpp2ILInjected.Token(Token = "0x400183D")]
		internal const int CAL_PERSIAN = 22;

		// Token: 0x0400147A RID: 5242
		[global::Cpp2ILInjected.Token(Token = "0x400183E")]
		internal const int CAL_UMALQURA = 23;

		// Token: 0x0400147B RID: 5243
		[global::Cpp2ILInjected.Token(Token = "0x400183F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal int m_currentEraValue;

		// Token: 0x0400147C RID: 5244
		[global::System.Runtime.Serialization.OptionalField(VersionAdded = 2)]
		[global::Cpp2ILInjected.Token(Token = "0x4001840")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private bool m_isReadOnly;

		// Token: 0x0400147D RID: 5245
		[global::Cpp2ILInjected.Token(Token = "0x4001841")]
		public const int CurrentEra = 0;

		// Token: 0x0400147E RID: 5246
		[global::Cpp2ILInjected.Token(Token = "0x4001842")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal int twoDigitYearMax;
	}
}
