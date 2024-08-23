using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Globalization
{
	// Token: 0x020004BD RID: 1213
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20005AA")]
	[global::System.Serializable]
	public class GregorianCalendar : Calendar
	{
		// Token: 0x0600283B RID: 10299 RVA: 0x0001B527 File Offset: 0x00019727
		[global::System.Runtime.Serialization.OnDeserialized]
		[global::Cpp2ILInjected.Token(Token = "0x6002B99")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BECFAC", Offset = "0x1BECFAC", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(global::System.IFormatProvider),
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private void OnDeserialized(global::System.Runtime.Serialization.StreamingContext ctx)
		{
			throw null;
		}

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x0600283C RID: 10300 RVA: 0x0001B52A File Offset: 0x0001972A
		[global::System.Runtime.InteropServices.ComVisible(false)]
		[global::Cpp2ILInjected.Token(Token = "0x1700066C")]
		public override global::System.DateTime MinSupportedDateTime
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002B9A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BED080", Offset = "0x1BED080", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x0600283D RID: 10301 RVA: 0x0001B52D File Offset: 0x0001972D
		[global::System.Runtime.InteropServices.ComVisible(false)]
		[global::Cpp2ILInjected.Token(Token = "0x1700066D")]
		public override global::System.DateTime MaxSupportedDateTime
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002B9B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BED0D8", Offset = "0x1BED0D8", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600283E RID: 10302 RVA: 0x0001B530 File Offset: 0x00019730
		[global::Cpp2ILInjected.Token(Token = "0x6002B9C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BED130", Offset = "0x1BED130", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeFormat), Member = "ExpandPredefinedFormat", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(ref global::System.DateTime),
			typeof(ref DateTimeFormatInfo),
			typeof(ref global::System.TimeSpan)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ParseISO8601", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeRawInfo),
			typeof(ref global::System.__DTString),
			typeof(DateTimeStyles),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "CheckDefaultDateTime", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref Calendar),
			typeof(DateTimeStyles)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ExpandPredefinedFormat", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(ref DateTimeFormatInfo),
			typeof(ref global::System.ParsingInfo),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		internal static Calendar GetDefaultInstance()
		{
			throw null;
		}

		// Token: 0x0600283F RID: 10303 RVA: 0x0001B533 File Offset: 0x00019733
		[global::Cpp2ILInjected.Token(Token = "0x6002B9D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BED1F8", Offset = "0x1BED1F8", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public GregorianCalendar()
		{
			throw null;
		}

		// Token: 0x06002840 RID: 10304 RVA: 0x0001B536 File Offset: 0x00019736
		[global::Cpp2ILInjected.Token(Token = "0x6002B9E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BED224", Offset = "0x1BED224", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureInfo), Member = "CreateCalendar", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Calendar))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public GregorianCalendar(GregorianCalendarTypes type)
		{
			throw null;
		}

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x06002841 RID: 10305 RVA: 0x0001B539 File Offset: 0x00019739
		[global::Cpp2ILInjected.Token(Token = "0x1700066E")]
		internal override int ID
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002B9F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BED34C", Offset = "0x1BED34C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002842 RID: 10306 RVA: 0x0001B53C File Offset: 0x0001973C
		[global::Cpp2ILInjected.Token(Token = "0x6002BA0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BED354", Offset = "0x1BED354", Length = "0x1E0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal virtual int GetDatePart(long ticks, int part)
		{
			throw null;
		}

		// Token: 0x06002843 RID: 10307 RVA: 0x0001B53F File Offset: 0x0001973F
		[global::Cpp2ILInjected.Token(Token = "0x6002BA1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BED534", Offset = "0x1BED534", Length = "0x1C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UmAlQuraCalendar), Member = "GetAbsoluteDateUmAlQura", MemberParameters = new object[]
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

		// Token: 0x06002844 RID: 10308 RVA: 0x0001B542 File Offset: 0x00019742
		[global::Cpp2ILInjected.Token(Token = "0x6002BA2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BED6F4", Offset = "0x1BED6F4", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
		public override int GetDayOfMonth(global::System.DateTime time)
		{
			throw null;
		}

		// Token: 0x06002845 RID: 10309 RVA: 0x0001B545 File Offset: 0x00019745
		[global::Cpp2ILInjected.Token(Token = "0x6002BA3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BED738", Offset = "0x1BED738", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
		public override global::System.DayOfWeek GetDayOfWeek(global::System.DateTime time)
		{
			throw null;
		}

		// Token: 0x06002846 RID: 10310 RVA: 0x0001B548 File Offset: 0x00019748
		[global::Cpp2ILInjected.Token(Token = "0x6002BA4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BED7A0", Offset = "0x1BED7A0", Length = "0x258")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		public override int GetDaysInMonth(int year, int month, int era)
		{
			throw null;
		}

		// Token: 0x06002847 RID: 10311 RVA: 0x0001B54B File Offset: 0x0001974B
		[global::Cpp2ILInjected.Token(Token = "0x6002BA5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BED9F8", Offset = "0x1BED9F8", Length = "0x18C")]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public override int GetDaysInYear(int year, int era)
		{
			throw null;
		}

		// Token: 0x06002848 RID: 10312 RVA: 0x0001B54E File Offset: 0x0001974E
		[global::Cpp2ILInjected.Token(Token = "0x6002BA6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BEDB84", Offset = "0x1BEDB84", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override int GetEra(global::System.DateTime time)
		{
			throw null;
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x06002849 RID: 10313 RVA: 0x0001B551 File Offset: 0x00019751
		[global::Cpp2ILInjected.Token(Token = "0x1700066F")]
		public override int[] Eras
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002BA7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BEDB8C", Offset = "0x1BEDB8C", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600284A RID: 10314 RVA: 0x0001B554 File Offset: 0x00019754
		[global::Cpp2ILInjected.Token(Token = "0x6002BA8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BEDBDC", Offset = "0x1BEDBDC", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
		public override int GetMonth(global::System.DateTime time)
		{
			throw null;
		}

		// Token: 0x0600284B RID: 10315 RVA: 0x0001B557 File Offset: 0x00019757
		[global::Cpp2ILInjected.Token(Token = "0x6002BA9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BEDC20", Offset = "0x1BEDC20", Length = "0x148")]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public override int GetMonthsInYear(int year, int era)
		{
			throw null;
		}

		// Token: 0x0600284C RID: 10316 RVA: 0x0001B55A File Offset: 0x0001975A
		[global::Cpp2ILInjected.Token(Token = "0x6002BAA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BEDD68", Offset = "0x1BEDD68", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
		public override int GetYear(global::System.DateTime time)
		{
			throw null;
		}

		// Token: 0x0600284D RID: 10317 RVA: 0x0001B55D File Offset: 0x0001975D
		[global::Cpp2ILInjected.Token(Token = "0x6002BAB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BEDDAC", Offset = "0x1BEDDAC", Length = "0x194")]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public override bool IsLeapYear(int year, int era)
		{
			throw null;
		}

		// Token: 0x0600284E RID: 10318 RVA: 0x0001B560 File Offset: 0x00019760
		[global::Cpp2ILInjected.Token(Token = "0x6002BAC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BEDF40", Offset = "0x1BEDF40", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override global::System.DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era)
		{
			throw null;
		}

		// Token: 0x0600284F RID: 10319 RVA: 0x0001B563 File Offset: 0x00019763
		[global::Cpp2ILInjected.Token(Token = "0x6002BAD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BEDFDC", Offset = "0x1BEDFDC", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "TryCreate", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(ref global::System.DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal override bool TryToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era, out global::System.DateTime result)
		{
			throw null;
		}

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x06002850 RID: 10320 RVA: 0x0001B566 File Offset: 0x00019766
		// (set) Token: 0x06002851 RID: 10321 RVA: 0x0001B569 File Offset: 0x00019769
		[global::Cpp2ILInjected.Token(Token = "0x17000670")]
		public override int TwoDigitYearMax
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002BAE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BEE0D0", Offset = "0x1BEE0D0", Length = "0x44")]
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
			[global::Cpp2ILInjected.Token(Token = "0x6002BAF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BEE114", Offset = "0x1BEE114", Length = "0x114")]
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

		// Token: 0x06002852 RID: 10322 RVA: 0x0001B56C File Offset: 0x0001976C
		[global::Cpp2ILInjected.Token(Token = "0x6002BB0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BEE228", Offset = "0x1BEE228", Length = "0x11C")]
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

		// Token: 0x06002853 RID: 10323 RVA: 0x0001B56F File Offset: 0x0001976F
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6002BB1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BEE344", Offset = "0x1BEE344", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(global::System.RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		static GregorianCalendar()
		{
			throw null;
		}

		// Token: 0x04001496 RID: 5270
		[global::Cpp2ILInjected.Token(Token = "0x400185A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		internal GregorianCalendarTypes m_type;

		// Token: 0x04001497 RID: 5271
		[global::Cpp2ILInjected.Token(Token = "0x400185B")]
		internal static readonly int[] DaysToMonth365;

		// Token: 0x04001498 RID: 5272
		[global::Cpp2ILInjected.Token(Token = "0x400185C")]
		internal static readonly int[] DaysToMonth366;

		// Token: 0x04001499 RID: 5273
		[global::Cpp2ILInjected.Token(Token = "0x400185D")]
		private static Calendar s_defaultInstance;
	}
}
