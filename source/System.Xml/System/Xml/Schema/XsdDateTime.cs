using System;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x02000135 RID: 309
	[global::Cpp2ILInjected.Token(Token = "0x2000169")]
	internal struct XsdDateTime
	{
		// Token: 0x06000BCF RID: 3023 RVA: 0x000050DB File Offset: 0x000032DB
		[global::Cpp2ILInjected.Token(Token = "0x6000C6A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DEBE6C", Offset = "0x1DEBE6C", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToDate", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToDateTime", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToGDay", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToGMonth", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToGMonthDay", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToGYear", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToGYearMonth", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToDateOffset", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToDateTimeOffset", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToGDayOffset", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToGMonthOffset", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToGMonthDayOffset", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToGYearOffset", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToGYearMonthOffset", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToTime", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToTimeOffset", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "UntypedAtomicToDateTime", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "UntypedAtomicToDateTimeOffset", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 18)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime.Parser), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XsdDateTimeFlags)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = "InitiateXsdDateTime", MemberParameters = new object[] { typeof(XsdDateTime.Parser) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public XsdDateTime(string text, XsdDateTimeFlags kinds)
		{
			throw null;
		}

		// Token: 0x06000BD0 RID: 3024 RVA: 0x000050DE File Offset: 0x000032DE
		[global::Cpp2ILInjected.Token(Token = "0x6000C6B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DEC98C", Offset = "0x1DEC98C", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = "InitiateXsdDateTime", MemberParameters = new object[] { typeof(XsdDateTime.Parser) }, ReturnType = typeof(void))]
		private XsdDateTime(XsdDateTime.Parser parser)
		{
			throw null;
		}

		// Token: 0x06000BD1 RID: 3025 RVA: 0x000050E1 File Offset: 0x000032E1
		[global::Cpp2ILInjected.Token(Token = "0x6000C6C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DEC910", Offset = "0x1DEC910", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XsdDateTimeFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new object[] { typeof(XsdDateTime.Parser) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XsdDateTime), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XsdDateTimeFlags),
			typeof(ref XsdDateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "AddTicks", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(DateTime))]
		private void InitiateXsdDateTime(XsdDateTime.Parser parser)
		{
			throw null;
		}

		// Token: 0x06000BD2 RID: 3026 RVA: 0x000050E4 File Offset: 0x000032E4
		[global::Cpp2ILInjected.Token(Token = "0x6000C6D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DEC9BC", Offset = "0x1DEC9BC", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Datatype_dateTimeBase), Member = "TryParseValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XmlNameTable),
			typeof(IXmlNamespaceResolver),
			typeof(ref object)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime.Parser), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XsdDateTimeFlags)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = "InitiateXsdDateTime", MemberParameters = new object[] { typeof(XsdDateTime.Parser) }, ReturnType = typeof(void))]
		internal static bool TryParse(string text, XsdDateTimeFlags kinds, out XsdDateTime result)
		{
			throw null;
		}

		// Token: 0x06000BD3 RID: 3027 RVA: 0x000050E7 File Offset: 0x000032E7
		[global::Cpp2ILInjected.Token(Token = "0x6000C6E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DECA30", Offset = "0x1DECA30", Length = "0x154")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(XmlDateTimeSerializationMode)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "DateToString", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "DateTimeToString", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "GDayToString", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "GMonthToString", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "GMonthDayToString", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "GYearToString", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "GYearMonthToString", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "TimeToString", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Bits), Member = "LeastPosition", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Kind", ReturnType = typeof(DateTimeKind))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeZoneInfo), Member = "get_Local", ReturnType = typeof(TimeZoneInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "get_Hours", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "get_Minutes", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public XsdDateTime(DateTime dateTime, XsdDateTimeFlags kinds)
		{
			throw null;
		}

		// Token: 0x06000BD4 RID: 3028 RVA: 0x000050EA File Offset: 0x000032EA
		[global::Cpp2ILInjected.Token(Token = "0x6000C6F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DECB84", Offset = "0x1DECB84", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new object[] { typeof(DateTimeOffset) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public XsdDateTime(DateTimeOffset dateTimeOffset)
		{
			throw null;
		}

		// Token: 0x06000BD5 RID: 3029 RVA: 0x000050ED File Offset: 0x000032ED
		[global::Cpp2ILInjected.Token(Token = "0x6000C70")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DECB8C", Offset = "0x1DECB8C", Length = "0x114")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "DateOffsetToString", MemberParameters = new object[] { typeof(DateTimeOffset) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "DateTimeOffsetToString", MemberParameters = new object[] { typeof(DateTimeOffset) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "GDayOffsetToString", MemberParameters = new object[] { typeof(DateTimeOffset) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "GMonthOffsetToString", MemberParameters = new object[] { typeof(DateTimeOffset) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "GMonthDayOffsetToString", MemberParameters = new object[] { typeof(DateTimeOffset) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "GYearOffsetToString", MemberParameters = new object[] { typeof(DateTimeOffset) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "GYearMonthOffsetToString", MemberParameters = new object[] { typeof(DateTimeOffset) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "TimeOffsetToString", MemberParameters = new object[] { typeof(DateTimeOffset) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeOffset), Member = "get_DateTime", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeOffset), Member = "get_Offset", ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Bits), Member = "LeastPosition", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "get_TotalMinutes", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "Negate", ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "get_Hours", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "get_Minutes", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public XsdDateTime(DateTimeOffset dateTimeOffset, XsdDateTimeFlags kinds)
		{
			throw null;
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06000BD6 RID: 3030 RVA: 0x000050F0 File Offset: 0x000032F0
		[global::Cpp2ILInjected.Token(Token = "0x1700033A")]
		private XsdDateTime.DateTimeTypeCode InternalTypeCode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000C71")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DECCA0", Offset = "0x1DECCA0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06000BD7 RID: 3031 RVA: 0x000050F3 File Offset: 0x000032F3
		[global::Cpp2ILInjected.Token(Token = "0x1700033B")]
		private XsdDateTime.XsdDateTimeKind InternalKind
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000C72")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DECCA8", Offset = "0x1DECCA8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06000BD8 RID: 3032 RVA: 0x000050F6 File Offset: 0x000032F6
		[global::Cpp2ILInjected.Token(Token = "0x1700033C")]
		public int Year
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000C73")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DECCB0", Offset = "0x1DECCB0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Year", ReturnType = typeof(int))]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000BD9 RID: 3033 RVA: 0x000050F9 File Offset: 0x000032F9
		[global::Cpp2ILInjected.Token(Token = "0x1700033D")]
		public int Month
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000C74")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DECCB8", Offset = "0x1DECCB8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Month", ReturnType = typeof(int))]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000BDA RID: 3034 RVA: 0x000050FC File Offset: 0x000032FC
		[global::Cpp2ILInjected.Token(Token = "0x1700033E")]
		public int Day
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000C75")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DECCC0", Offset = "0x1DECCC0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Day", ReturnType = typeof(int))]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06000BDB RID: 3035 RVA: 0x000050FF File Offset: 0x000032FF
		[global::Cpp2ILInjected.Token(Token = "0x1700033F")]
		public int Hour
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000C76")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DECCC8", Offset = "0x1DECCC8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Hour", ReturnType = typeof(int))]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06000BDC RID: 3036 RVA: 0x00005102 File Offset: 0x00003302
		[global::Cpp2ILInjected.Token(Token = "0x17000340")]
		public int Minute
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000C77")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DECCD0", Offset = "0x1DECCD0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Minute", ReturnType = typeof(int))]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06000BDD RID: 3037 RVA: 0x00005105 File Offset: 0x00003305
		[global::Cpp2ILInjected.Token(Token = "0x17000341")]
		public int Second
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000C78")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DECCD8", Offset = "0x1DECCD8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Second", ReturnType = typeof(int))]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06000BDE RID: 3038 RVA: 0x00005108 File Offset: 0x00003308
		[global::Cpp2ILInjected.Token(Token = "0x17000342")]
		public int Fraction
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000C79")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DECCE0", Offset = "0x1DECCE0", Length = "0xD8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XsdDateTime), Member = "PrintTime", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Year", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Month", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Day", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Hour", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Minute", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Second", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06000BDF RID: 3039 RVA: 0x0000510B File Offset: 0x0000330B
		[global::Cpp2ILInjected.Token(Token = "0x17000343")]
		public int ZoneHour
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000C7A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DECDB8", Offset = "0x1DECDB8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06000BE0 RID: 3040 RVA: 0x0000510E File Offset: 0x0000330E
		[global::Cpp2ILInjected.Token(Token = "0x17000344")]
		public int ZoneMinute
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000C7B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DECDC0", Offset = "0x1DECDC0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000BE1 RID: 3041 RVA: 0x00005111 File Offset: 0x00003311
		[global::Cpp2ILInjected.Token(Token = "0x6000C7C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DECDC8", Offset = "0x1DECDC8", Length = "0x414")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Datatype_dateTimeBase), Member = "TryParseValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XmlNameTable),
			typeof(IXmlNamespaceResolver),
			typeof(ref object)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToDate", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToDateTime", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToGDay", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToGMonth", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToGMonthDay", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToGYear", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToGYearMonth", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToTime", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "UntypedAtomicToDateTime", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Year", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Month", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Day", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(DateTime)
		}, ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "Add", MemberParameters = new object[] { typeof(TimeSpan) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(long),
			typeof(DateTimeKind)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeZoneInfo), Member = "get_Local", ReturnType = typeof(TimeZoneInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "ToLocalTime", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public static implicit operator DateTime(XsdDateTime xdt)
		{
			throw null;
		}

		// Token: 0x06000BE2 RID: 3042 RVA: 0x00005114 File Offset: 0x00003314
		[global::Cpp2ILInjected.Token(Token = "0x6000C7D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DED1DC", Offset = "0x1DED1DC", Length = "0x278")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToDateOffset", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToDateTimeOffset", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToGDayOffset", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToGMonthOffset", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToGMonthDayOffset", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToGYearOffset", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToGYearMonthOffset", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToTimeOffset", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "UntypedAtomicToDateTimeOffset", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Year", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Month", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Day", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(DateTime)
		}, ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "Add", MemberParameters = new object[] { typeof(TimeSpan) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeZoneInfo), Member = "get_Local", ReturnType = typeof(TimeZoneInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeOffset), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(TimeSpan)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static implicit operator DateTimeOffset(XsdDateTime xdt)
		{
			throw null;
		}

		// Token: 0x06000BE3 RID: 3043 RVA: 0x00005117 File Offset: 0x00003317
		[global::Cpp2ILInjected.Token(Token = "0x6000C7E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DED454", Offset = "0x1DED454", Length = "0x478")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(XmlDateTimeSerializationMode)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new object[] { typeof(DateTimeOffset) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "DateToString", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "DateTimeToString", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "GDayToString", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "GMonthToString", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "GMonthDayToString", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "GYearToString", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "GYearMonthToString", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "DateOffsetToString", MemberParameters = new object[] { typeof(DateTimeOffset) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "DateTimeOffsetToString", MemberParameters = new object[] { typeof(DateTimeOffset) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "GDayOffsetToString", MemberParameters = new object[] { typeof(DateTimeOffset) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "GMonthOffsetToString", MemberParameters = new object[] { typeof(DateTimeOffset) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "GMonthDayOffsetToString", MemberParameters = new object[] { typeof(DateTimeOffset) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "GYearOffsetToString", MemberParameters = new object[] { typeof(DateTimeOffset) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "GYearMonthOffsetToString", MemberParameters = new object[] { typeof(DateTimeOffset) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "TimeToString", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "TimeOffsetToString", MemberParameters = new object[] { typeof(DateTimeOffset) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 18)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = "PrintDate", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = "PrintTime", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Year", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Month", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Day", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = "PrintZone", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06000BE4 RID: 3044 RVA: 0x0000511A File Offset: 0x0000331A
		[global::Cpp2ILInjected.Token(Token = "0x6000C7F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DED8CC", Offset = "0x1DED8CC", Length = "0x194")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XsdDateTime), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Year", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Month", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Day", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void PrintDate(StringBuilder sb)
		{
			throw null;
		}

		// Token: 0x06000BE5 RID: 3045 RVA: 0x0000511D File Offset: 0x0000331D
		[global::Cpp2ILInjected.Token(Token = "0x6000C80")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DEDA60", Offset = "0x1DEDA60", Length = "0x260")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XsdDateTime), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Hour", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Minute", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Second", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = "get_Fraction", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void PrintTime(StringBuilder sb)
		{
			throw null;
		}

		// Token: 0x06000BE6 RID: 3046 RVA: 0x00005120 File Offset: 0x00003320
		[global::Cpp2ILInjected.Token(Token = "0x6000C81")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DEDD44", Offset = "0x1DEDD44", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XsdDateTime), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void PrintZone(StringBuilder sb)
		{
			throw null;
		}

		// Token: 0x06000BE7 RID: 3047 RVA: 0x00005123 File Offset: 0x00003323
		[global::Cpp2ILInjected.Token(Token = "0x6000C82")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DEDCC0", Offset = "0x1DEDCC0", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void IntToCharArray(char[] text, int start, int value, int digits)
		{
			throw null;
		}

		// Token: 0x06000BE8 RID: 3048 RVA: 0x00005126 File Offset: 0x00003326
		[global::Cpp2ILInjected.Token(Token = "0x6000C83")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DEDD08", Offset = "0x1DEDD08", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void ShortToCharArray(char[] text, int start, int value)
		{
			throw null;
		}

		// Token: 0x06000BE9 RID: 3049 RVA: 0x00005129 File Offset: 0x00003329
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000C84")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DEDEC8", Offset = "0x1DEDEC8", Length = "0x3E4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 26)]
		static XsdDateTime()
		{
			throw null;
		}

		// Token: 0x040004AA RID: 1194
		[global::Cpp2ILInjected.Token(Token = "0x400063D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private DateTime dt;

		// Token: 0x040004AB RID: 1195
		[global::Cpp2ILInjected.Token(Token = "0x400063E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private uint extra;

		// Token: 0x040004AC RID: 1196
		[global::Cpp2ILInjected.Token(Token = "0x400063F")]
		private static readonly int Lzyyyy;

		// Token: 0x040004AD RID: 1197
		[global::Cpp2ILInjected.Token(Token = "0x4000640")]
		private static readonly int Lzyyyy_;

		// Token: 0x040004AE RID: 1198
		[global::Cpp2ILInjected.Token(Token = "0x4000641")]
		private static readonly int Lzyyyy_MM;

		// Token: 0x040004AF RID: 1199
		[global::Cpp2ILInjected.Token(Token = "0x4000642")]
		private static readonly int Lzyyyy_MM_;

		// Token: 0x040004B0 RID: 1200
		[global::Cpp2ILInjected.Token(Token = "0x4000643")]
		private static readonly int Lzyyyy_MM_dd;

		// Token: 0x040004B1 RID: 1201
		[global::Cpp2ILInjected.Token(Token = "0x4000644")]
		private static readonly int Lzyyyy_MM_ddT;

		// Token: 0x040004B2 RID: 1202
		[global::Cpp2ILInjected.Token(Token = "0x4000645")]
		private static readonly int LzHH;

		// Token: 0x040004B3 RID: 1203
		[global::Cpp2ILInjected.Token(Token = "0x4000646")]
		private static readonly int LzHH_;

		// Token: 0x040004B4 RID: 1204
		[global::Cpp2ILInjected.Token(Token = "0x4000647")]
		private static readonly int LzHH_mm;

		// Token: 0x040004B5 RID: 1205
		[global::Cpp2ILInjected.Token(Token = "0x4000648")]
		private static readonly int LzHH_mm_;

		// Token: 0x040004B6 RID: 1206
		[global::Cpp2ILInjected.Token(Token = "0x4000649")]
		private static readonly int LzHH_mm_ss;

		// Token: 0x040004B7 RID: 1207
		[global::Cpp2ILInjected.Token(Token = "0x400064A")]
		private static readonly int Lz_;

		// Token: 0x040004B8 RID: 1208
		[global::Cpp2ILInjected.Token(Token = "0x400064B")]
		private static readonly int Lz_zz;

		// Token: 0x040004B9 RID: 1209
		[global::Cpp2ILInjected.Token(Token = "0x400064C")]
		private static readonly int Lz_zz_;

		// Token: 0x040004BA RID: 1210
		[global::Cpp2ILInjected.Token(Token = "0x400064D")]
		private static readonly int Lz_zz_zz;

		// Token: 0x040004BB RID: 1211
		[global::Cpp2ILInjected.Token(Token = "0x400064E")]
		private static readonly int Lz__;

		// Token: 0x040004BC RID: 1212
		[global::Cpp2ILInjected.Token(Token = "0x400064F")]
		private static readonly int Lz__mm;

		// Token: 0x040004BD RID: 1213
		[global::Cpp2ILInjected.Token(Token = "0x4000650")]
		private static readonly int Lz__mm_;

		// Token: 0x040004BE RID: 1214
		[global::Cpp2ILInjected.Token(Token = "0x4000651")]
		private static readonly int Lz__mm__;

		// Token: 0x040004BF RID: 1215
		[global::Cpp2ILInjected.Token(Token = "0x4000652")]
		private static readonly int Lz__mm_dd;

		// Token: 0x040004C0 RID: 1216
		[global::Cpp2ILInjected.Token(Token = "0x4000653")]
		private static readonly int Lz___;

		// Token: 0x040004C1 RID: 1217
		[global::Cpp2ILInjected.Token(Token = "0x4000654")]
		private static readonly int Lz___dd;

		// Token: 0x040004C2 RID: 1218
		[global::Cpp2ILInjected.Token(Token = "0x4000655")]
		private static readonly XmlTypeCode[] typeCodes;

		// Token: 0x0200017A RID: 378
		[global::Cpp2ILInjected.Token(Token = "0x200016A")]
		private enum DateTimeTypeCode
		{
			// Token: 0x04000682 RID: 1666
			[global::Cpp2ILInjected.Token(Token = "0x4000657")]
			DateTime,
			// Token: 0x04000683 RID: 1667
			[global::Cpp2ILInjected.Token(Token = "0x4000658")]
			Time,
			// Token: 0x04000684 RID: 1668
			[global::Cpp2ILInjected.Token(Token = "0x4000659")]
			Date,
			// Token: 0x04000685 RID: 1669
			[global::Cpp2ILInjected.Token(Token = "0x400065A")]
			GYearMonth,
			// Token: 0x04000686 RID: 1670
			[global::Cpp2ILInjected.Token(Token = "0x400065B")]
			GYear,
			// Token: 0x04000687 RID: 1671
			[global::Cpp2ILInjected.Token(Token = "0x400065C")]
			GMonthDay,
			// Token: 0x04000688 RID: 1672
			[global::Cpp2ILInjected.Token(Token = "0x400065D")]
			GDay,
			// Token: 0x04000689 RID: 1673
			[global::Cpp2ILInjected.Token(Token = "0x400065E")]
			GMonth,
			// Token: 0x0400068A RID: 1674
			[global::Cpp2ILInjected.Token(Token = "0x400065F")]
			XdrDateTime
		}

		// Token: 0x0200017B RID: 379
		[global::Cpp2ILInjected.Token(Token = "0x200016B")]
		private enum XsdDateTimeKind
		{
			// Token: 0x0400068C RID: 1676
			[global::Cpp2ILInjected.Token(Token = "0x4000661")]
			Unspecified,
			// Token: 0x0400068D RID: 1677
			[global::Cpp2ILInjected.Token(Token = "0x4000662")]
			Zulu,
			// Token: 0x0400068E RID: 1678
			[global::Cpp2ILInjected.Token(Token = "0x4000663")]
			LocalWestOfZulu,
			// Token: 0x0400068F RID: 1679
			[global::Cpp2ILInjected.Token(Token = "0x4000664")]
			LocalEastOfZulu
		}

		// Token: 0x0200017C RID: 380
		[global::Cpp2ILInjected.Token(Token = "0x200016C")]
		private struct Parser
		{
			// Token: 0x06000CCE RID: 3278 RVA: 0x000053C6 File Offset: 0x000035C6
			[global::Cpp2ILInjected.Token(Token = "0x6000C85")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DEBF78", Offset = "0x1DEBF78", Length = "0x998")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(XsdDateTimeFlags)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XsdDateTime), Member = "TryParse", MemberParameters = new object[]
			{
				typeof(string),
				typeof(XsdDateTimeFlags),
				typeof(ref XsdDateTime)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime.Parser), Member = "ParseDate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime.Parser), Member = "ParseTimeAndZoneAndWhitespace", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime.Parser), Member = "ParseZoneAndWhitespace", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime.Parser), Member = "ParseTimeAndWhitespace", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime.Parser), Member = "Parse4Dig", MemberParameters = new object[]
			{
				typeof(int),
				typeof(ref int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime.Parser), Member = "Parse2Dig", MemberParameters = new object[]
			{
				typeof(int),
				typeof(ref int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "DaysInMonth", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 46)]
			public bool Parse(string text, XsdDateTimeFlags kinds)
			{
				throw null;
			}

			// Token: 0x06000CCF RID: 3279 RVA: 0x000053C9 File Offset: 0x000035C9
			[global::Cpp2ILInjected.Token(Token = "0x6000C86")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DEE2B8", Offset = "0x1DEE2B8", Length = "0x1C8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XsdDateTime.Parser), Member = "Parse", MemberParameters = new object[]
			{
				typeof(string),
				typeof(XsdDateTimeFlags)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime.Parser), Member = "Parse4Dig", MemberParameters = new object[]
			{
				typeof(int),
				typeof(ref int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime.Parser), Member = "Parse2Dig", MemberParameters = new object[]
			{
				typeof(int),
				typeof(ref int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "DaysInMonth", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			private bool ParseDate(int start)
			{
				throw null;
			}

			// Token: 0x06000CD0 RID: 3280 RVA: 0x000053CC File Offset: 0x000035CC
			[global::Cpp2ILInjected.Token(Token = "0x6000C87")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DEE4BC", Offset = "0x1DEE4BC", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XsdDateTime.Parser), Member = "Parse", MemberParameters = new object[]
			{
				typeof(string),
				typeof(XsdDateTimeFlags)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime.Parser), Member = "ParseTime", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime.Parser), Member = "ParseZoneAndWhitespace", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
			private bool ParseTimeAndZoneAndWhitespace(int start)
			{
				throw null;
			}

			// Token: 0x06000CD1 RID: 3281 RVA: 0x000053CF File Offset: 0x000035CF
			[global::Cpp2ILInjected.Token(Token = "0x6000C88")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DEE71C", Offset = "0x1DEE71C", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XsdDateTime.Parser), Member = "Parse", MemberParameters = new object[]
			{
				typeof(string),
				typeof(XsdDateTimeFlags)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime.Parser), Member = "ParseTime", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(bool))]
			private bool ParseTimeAndWhitespace(int start)
			{
				throw null;
			}

			// Token: 0x06000CD2 RID: 3282 RVA: 0x000053D2 File Offset: 0x000035D2
			[global::Cpp2ILInjected.Token(Token = "0x6000C89")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DEE8F0", Offset = "0x1DEE8F0", Length = "0x310")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XsdDateTime.Parser), Member = "ParseTimeAndZoneAndWhitespace", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XsdDateTime.Parser), Member = "ParseTimeAndWhitespace", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime.Parser), Member = "Parse2Dig", MemberParameters = new object[]
			{
				typeof(int),
				typeof(ref int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			private bool ParseTime(ref int start)
			{
				throw null;
			}

			// Token: 0x06000CD3 RID: 3283 RVA: 0x000053D5 File Offset: 0x000035D5
			[global::Cpp2ILInjected.Token(Token = "0x6000C8A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DEE500", Offset = "0x1DEE500", Length = "0x21C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XsdDateTime.Parser), Member = "Parse", MemberParameters = new object[]
			{
				typeof(string),
				typeof(XsdDateTimeFlags)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XsdDateTime.Parser), Member = "ParseTimeAndZoneAndWhitespace", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime.Parser), Member = "Parse2Dig", MemberParameters = new object[]
			{
				typeof(int),
				typeof(ref int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			private bool ParseZoneAndWhitespace(int start)
			{
				throw null;
			}

			// Token: 0x06000CD4 RID: 3284 RVA: 0x000053D8 File Offset: 0x000035D8
			[global::Cpp2ILInjected.Token(Token = "0x6000C8B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DEE774", Offset = "0x1DEE774", Length = "0xF0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XsdDateTime.Parser), Member = "Parse", MemberParameters = new object[]
			{
				typeof(string),
				typeof(XsdDateTimeFlags)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XsdDateTime.Parser), Member = "ParseDate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
			private bool Parse4Dig(int start, ref int num)
			{
				throw null;
			}

			// Token: 0x06000CD5 RID: 3285 RVA: 0x000053DB File Offset: 0x000035DB
			[global::Cpp2ILInjected.Token(Token = "0x6000C8C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DEE864", Offset = "0x1DEE864", Length = "0x8C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XsdDateTime.Parser), Member = "Parse", MemberParameters = new object[]
			{
				typeof(string),
				typeof(XsdDateTimeFlags)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XsdDateTime.Parser), Member = "ParseDate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XsdDateTime.Parser), Member = "ParseTime", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XsdDateTime.Parser), Member = "ParseZoneAndWhitespace", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
			private bool Parse2Dig(int start, ref int num)
			{
				throw null;
			}

			// Token: 0x06000CD6 RID: 3286 RVA: 0x000053DE File Offset: 0x000035DE
			[global::Cpp2ILInjected.Token(Token = "0x6000C8D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DEE480", Offset = "0x1DEE480", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
			private bool ParseChar(int start, char ch)
			{
				throw null;
			}

			// Token: 0x06000CD7 RID: 3287 RVA: 0x000053E1 File Offset: 0x000035E1
			[global::Cpp2ILInjected.Token(Token = "0x6000C8E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DEE2AC", Offset = "0x1DEE2AC", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private static bool Test(XsdDateTimeFlags left, XsdDateTimeFlags right)
			{
				throw null;
			}

			// Token: 0x06000CD8 RID: 3288 RVA: 0x000053E4 File Offset: 0x000035E4
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6000C8F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DEEC00", Offset = "0x1DEEC00", Length = "0x94")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
			{
				typeof(Array),
				typeof(RuntimeFieldHandle)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			static Parser()
			{
				throw null;
			}

			// Token: 0x04000690 RID: 1680
			[global::Cpp2ILInjected.Token(Token = "0x4000665")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public XsdDateTime.DateTimeTypeCode typeCode;

			// Token: 0x04000691 RID: 1681
			[global::Cpp2ILInjected.Token(Token = "0x4000666")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
			public int year;

			// Token: 0x04000692 RID: 1682
			[global::Cpp2ILInjected.Token(Token = "0x4000667")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public int month;

			// Token: 0x04000693 RID: 1683
			[global::Cpp2ILInjected.Token(Token = "0x4000668")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
			public int day;

			// Token: 0x04000694 RID: 1684
			[global::Cpp2ILInjected.Token(Token = "0x4000669")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public int hour;

			// Token: 0x04000695 RID: 1685
			[global::Cpp2ILInjected.Token(Token = "0x400066A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
			public int minute;

			// Token: 0x04000696 RID: 1686
			[global::Cpp2ILInjected.Token(Token = "0x400066B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public int second;

			// Token: 0x04000697 RID: 1687
			[global::Cpp2ILInjected.Token(Token = "0x400066C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
			public int fraction;

			// Token: 0x04000698 RID: 1688
			[global::Cpp2ILInjected.Token(Token = "0x400066D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public XsdDateTime.XsdDateTimeKind kind;

			// Token: 0x04000699 RID: 1689
			[global::Cpp2ILInjected.Token(Token = "0x400066E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
			public int zoneHour;

			// Token: 0x0400069A RID: 1690
			[global::Cpp2ILInjected.Token(Token = "0x400066F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public int zoneMinute;

			// Token: 0x0400069B RID: 1691
			[global::Cpp2ILInjected.Token(Token = "0x4000670")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private string text;

			// Token: 0x0400069C RID: 1692
			[global::Cpp2ILInjected.Token(Token = "0x4000671")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			private int length;

			// Token: 0x0400069D RID: 1693
			[global::Cpp2ILInjected.Token(Token = "0x4000672")]
			private static int[] Power10;
		}
	}
}
