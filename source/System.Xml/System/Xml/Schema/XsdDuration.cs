using System;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	[global::Cpp2ILInjected.Token(Token = "0x200016D")]
	internal struct XsdDuration
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000C90")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DEEC94", Offset = "0x1DEEC94", Length = "0x15C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XsdDuration), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(TimeSpan),
			typeof(XsdDuration.DurationType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public XsdDuration(bool isNegative, int years, int months, int days, int hours, int minutes, int seconds, int nanoseconds)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000C91")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DEEDF0", Offset = "0x1DEEDF0", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new object[] { typeof(TimeSpan) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public XsdDuration(TimeSpan timeSpan)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000C92")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DEEEC8", Offset = "0x1DEEEC8", Length = "0x180")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "DayTimeDurationToString", MemberParameters = new object[] { typeof(TimeSpan) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "DurationToString", MemberParameters = new object[] { typeof(TimeSpan) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "YearMonthDurationToString", MemberParameters = new object[] { typeof(TimeSpan) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDuration), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public XsdDuration(TimeSpan timeSpan, XsdDuration.DurationType durationType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000C93")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DEF048", Offset = "0x1DEF048", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToDayTimeDuration", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToDuration", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToYearMonthDuration", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDuration), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XsdDuration.DurationType),
			typeof(ref XsdDuration)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public XsdDuration(string s, XsdDuration.DurationType durationType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000345")]
		public bool IsNegative
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000C94")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DEF788", Offset = "0x1DEF788", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000346")]
		public int Years
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000C95")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DEF794", Offset = "0x1DEF794", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000347")]
		public int Months
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000C96")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DEF79C", Offset = "0x1DEF79C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000348")]
		public int Days
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000C97")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DEF7A4", Offset = "0x1DEF7A4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000349")]
		public int Hours
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000C98")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DEF7AC", Offset = "0x1DEF7AC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700034A")]
		public int Minutes
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000C99")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DEF7B4", Offset = "0x1DEF7B4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700034B")]
		public int Seconds
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000C9A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DEF7BC", Offset = "0x1DEF7BC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700034C")]
		public int Nanoseconds
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000C9B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DEF77C", Offset = "0x1DEF77C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000C9C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DEF7C4", Offset = "0x1DEF7C4", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToDayTimeDuration", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToDuration", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToYearMonthDuration", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDuration), Member = "TryToTimeSpan", MemberParameters = new object[]
		{
			typeof(XsdDuration.DurationType),
			typeof(ref TimeSpan)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public TimeSpan ToTimeSpan(XsdDuration.DurationType durationType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000C9D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DEFCC8", Offset = "0x1DEFCC8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlConvert), Member = "TryToTimeSpan", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref TimeSpan)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDuration), Member = "TryToTimeSpan", MemberParameters = new object[]
		{
			typeof(XsdDuration.DurationType),
			typeof(ref TimeSpan)
		}, ReturnType = typeof(Exception))]
		internal Exception TryToTimeSpan(out TimeSpan result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000C9E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DEF80C", Offset = "0x1DEF80C", Length = "0x4BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Datatype_yearMonthDuration), Member = "TryParseValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XmlNameTable),
			typeof(IXmlNamespaceResolver),
			typeof(ref object)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Datatype_dayTimeDuration), Member = "TryParseValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XmlNameTable),
			typeof(IXmlNamespaceResolver),
			typeof(ref object)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XsdDuration), Member = "ToTimeSpan", MemberParameters = new object[] { typeof(XsdDuration.DurationType) }, ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XsdDuration), Member = "TryToTimeSpan", MemberParameters = new object[] { typeof(ref TimeSpan) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 58)]
		internal Exception TryToTimeSpan(XsdDuration.DurationType durationType, out TimeSpan result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000C9F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DEFCD4", Offset = "0x1DEFCD4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new object[] { typeof(TimeSpan) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public override string ToString()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000CA0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DEFCDC", Offset = "0x1DEFCDC", Length = "0x3F4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "DayTimeDurationToString", MemberParameters = new object[] { typeof(TimeSpan) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "DurationToString", MemberParameters = new object[] { typeof(TimeSpan) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "YearMonthDurationToString", MemberParameters = new object[] { typeof(TimeSpan) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "set_Chars", MemberParameters = new object[]
		{
			typeof(int),
			typeof(char)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		internal string ToString(XsdDuration.DurationType durationType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000CA1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF00D0", Offset = "0x1DF00D0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlConvert), Member = "TryToTimeSpan", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref TimeSpan)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDuration), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XsdDuration.DurationType),
			typeof(ref XsdDuration)
		}, ReturnType = typeof(Exception))]
		internal static Exception TryParse(string s, out XsdDuration result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000CA2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DEF0D4", Offset = "0x1DEF0D4", Length = "0x6A8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Datatype_yearMonthDuration), Member = "TryParseValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XmlNameTable),
			typeof(IXmlNamespaceResolver),
			typeof(ref object)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Datatype_dayTimeDuration), Member = "TryParseValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XmlNameTable),
			typeof(IXmlNamespaceResolver),
			typeof(ref object)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XsdDuration), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XsdDuration.DurationType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XsdDuration), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref XsdDuration)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XsdDuration), Member = "TryParseDigits", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int),
			typeof(bool),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		internal static Exception TryParse(string s, XsdDuration.DurationType durationType, out XsdDuration result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000CA3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF00DC", Offset = "0x1DF00DC", Length = "0x1B4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XsdDuration), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XsdDuration.DurationType),
			typeof(ref XsdDuration)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private static string TryParseDigits(string s, ref int offset, bool eatDigits, out int result, out int numDigits)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000673")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int years;

		[global::Cpp2ILInjected.Token(Token = "0x4000674")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		private int months;

		[global::Cpp2ILInjected.Token(Token = "0x4000675")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private int days;

		[global::Cpp2ILInjected.Token(Token = "0x4000676")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		private int hours;

		[global::Cpp2ILInjected.Token(Token = "0x4000677")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int minutes;

		[global::Cpp2ILInjected.Token(Token = "0x4000678")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private int seconds;

		[global::Cpp2ILInjected.Token(Token = "0x4000679")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private uint nanoseconds;

		[global::Cpp2ILInjected.Token(Token = "0x200016E")]
		private enum Parts
		{
			[global::Cpp2ILInjected.Token(Token = "0x400067B")]
			HasNone,
			[global::Cpp2ILInjected.Token(Token = "0x400067C")]
			HasYears,
			[global::Cpp2ILInjected.Token(Token = "0x400067D")]
			HasMonths,
			[global::Cpp2ILInjected.Token(Token = "0x400067E")]
			HasDays = 4,
			[global::Cpp2ILInjected.Token(Token = "0x400067F")]
			HasHours = 8,
			[global::Cpp2ILInjected.Token(Token = "0x4000680")]
			HasMinutes = 16,
			[global::Cpp2ILInjected.Token(Token = "0x4000681")]
			HasSeconds = 32
		}

		[global::Cpp2ILInjected.Token(Token = "0x200016F")]
		public enum DurationType
		{
			[global::Cpp2ILInjected.Token(Token = "0x4000683")]
			Duration,
			[global::Cpp2ILInjected.Token(Token = "0x4000684")]
			YearMonthDuration,
			[global::Cpp2ILInjected.Token(Token = "0x4000685")]
			DayTimeDuration
		}
	}
}
