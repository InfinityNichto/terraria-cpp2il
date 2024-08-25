using System;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	[global::Cpp2ILInjected.Token(Token = "0x2000169")]
	internal struct XsdDateTime
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x6000C6B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DEC98C", Offset = "0x1DEC98C", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDateTime), Member = "InitiateXsdDateTime", MemberParameters = new object[] { typeof(XsdDateTime.Parser) }, ReturnType = typeof(void))]
		private XsdDateTime(XsdDateTime.Parser parser)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6000C6F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DECB84", Offset = "0x1DECB84", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new object[] { typeof(DateTimeOffset) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public XsdDateTime(DateTimeOffset dateTimeOffset)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6000C82")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DEDCC0", Offset = "0x1DEDCC0", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void IntToCharArray(char[] text, int start, int value, int digits)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000C83")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DEDD08", Offset = "0x1DEDD08", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void ShortToCharArray(char[] text, int start, int value)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x400063D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private DateTime dt;

		[global::Cpp2ILInjected.Token(Token = "0x400063E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private uint extra;

		[global::Cpp2ILInjected.Token(Token = "0x400063F")]
		private static readonly int Lzyyyy;

		[global::Cpp2ILInjected.Token(Token = "0x4000640")]
		private static readonly int Lzyyyy_;

		[global::Cpp2ILInjected.Token(Token = "0x4000641")]
		private static readonly int Lzyyyy_MM;

		[global::Cpp2ILInjected.Token(Token = "0x4000642")]
		private static readonly int Lzyyyy_MM_;

		[global::Cpp2ILInjected.Token(Token = "0x4000643")]
		private static readonly int Lzyyyy_MM_dd;

		[global::Cpp2ILInjected.Token(Token = "0x4000644")]
		private static readonly int Lzyyyy_MM_ddT;

		[global::Cpp2ILInjected.Token(Token = "0x4000645")]
		private static readonly int LzHH;

		[global::Cpp2ILInjected.Token(Token = "0x4000646")]
		private static readonly int LzHH_;

		[global::Cpp2ILInjected.Token(Token = "0x4000647")]
		private static readonly int LzHH_mm;

		[global::Cpp2ILInjected.Token(Token = "0x4000648")]
		private static readonly int LzHH_mm_;

		[global::Cpp2ILInjected.Token(Token = "0x4000649")]
		private static readonly int LzHH_mm_ss;

		[global::Cpp2ILInjected.Token(Token = "0x400064A")]
		private static readonly int Lz_;

		[global::Cpp2ILInjected.Token(Token = "0x400064B")]
		private static readonly int Lz_zz;

		[global::Cpp2ILInjected.Token(Token = "0x400064C")]
		private static readonly int Lz_zz_;

		[global::Cpp2ILInjected.Token(Token = "0x400064D")]
		private static readonly int Lz_zz_zz;

		[global::Cpp2ILInjected.Token(Token = "0x400064E")]
		private static readonly int Lz__;

		[global::Cpp2ILInjected.Token(Token = "0x400064F")]
		private static readonly int Lz__mm;

		[global::Cpp2ILInjected.Token(Token = "0x4000650")]
		private static readonly int Lz__mm_;

		[global::Cpp2ILInjected.Token(Token = "0x4000651")]
		private static readonly int Lz__mm__;

		[global::Cpp2ILInjected.Token(Token = "0x4000652")]
		private static readonly int Lz__mm_dd;

		[global::Cpp2ILInjected.Token(Token = "0x4000653")]
		private static readonly int Lz___;

		[global::Cpp2ILInjected.Token(Token = "0x4000654")]
		private static readonly int Lz___dd;

		[global::Cpp2ILInjected.Token(Token = "0x4000655")]
		private static readonly XmlTypeCode[] typeCodes;

		[global::Cpp2ILInjected.Token(Token = "0x200016A")]
		private enum DateTimeTypeCode
		{
			[global::Cpp2ILInjected.Token(Token = "0x4000657")]
			DateTime,
			[global::Cpp2ILInjected.Token(Token = "0x4000658")]
			Time,
			[global::Cpp2ILInjected.Token(Token = "0x4000659")]
			Date,
			[global::Cpp2ILInjected.Token(Token = "0x400065A")]
			GYearMonth,
			[global::Cpp2ILInjected.Token(Token = "0x400065B")]
			GYear,
			[global::Cpp2ILInjected.Token(Token = "0x400065C")]
			GMonthDay,
			[global::Cpp2ILInjected.Token(Token = "0x400065D")]
			GDay,
			[global::Cpp2ILInjected.Token(Token = "0x400065E")]
			GMonth,
			[global::Cpp2ILInjected.Token(Token = "0x400065F")]
			XdrDateTime
		}

		[global::Cpp2ILInjected.Token(Token = "0x200016B")]
		private enum XsdDateTimeKind
		{
			[global::Cpp2ILInjected.Token(Token = "0x4000661")]
			Unspecified,
			[global::Cpp2ILInjected.Token(Token = "0x4000662")]
			Zulu,
			[global::Cpp2ILInjected.Token(Token = "0x4000663")]
			LocalWestOfZulu,
			[global::Cpp2ILInjected.Token(Token = "0x4000664")]
			LocalEastOfZulu
		}

		[global::Cpp2ILInjected.Token(Token = "0x200016C")]
		private struct Parser
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x6000C8D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DEE480", Offset = "0x1DEE480", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
			private bool ParseChar(int start, char ch)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6000C8E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DEE2AC", Offset = "0x1DEE2AC", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private static bool Test(XsdDateTimeFlags left, XsdDateTimeFlags right)
			{
				throw null;
			}

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

			[global::Cpp2ILInjected.Token(Token = "0x4000665")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public XsdDateTime.DateTimeTypeCode typeCode;

			[global::Cpp2ILInjected.Token(Token = "0x4000666")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
			public int year;

			[global::Cpp2ILInjected.Token(Token = "0x4000667")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public int month;

			[global::Cpp2ILInjected.Token(Token = "0x4000668")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
			public int day;

			[global::Cpp2ILInjected.Token(Token = "0x4000669")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public int hour;

			[global::Cpp2ILInjected.Token(Token = "0x400066A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
			public int minute;

			[global::Cpp2ILInjected.Token(Token = "0x400066B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public int second;

			[global::Cpp2ILInjected.Token(Token = "0x400066C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
			public int fraction;

			[global::Cpp2ILInjected.Token(Token = "0x400066D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public XsdDateTime.XsdDateTimeKind kind;

			[global::Cpp2ILInjected.Token(Token = "0x400066E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
			public int zoneHour;

			[global::Cpp2ILInjected.Token(Token = "0x400066F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public int zoneMinute;

			[global::Cpp2ILInjected.Token(Token = "0x4000670")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private string text;

			[global::Cpp2ILInjected.Token(Token = "0x4000671")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			private int length;

			[global::Cpp2ILInjected.Token(Token = "0x4000672")]
			private static int[] Power10;
		}
	}
}
