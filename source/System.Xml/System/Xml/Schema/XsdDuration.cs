using System;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x02000136 RID: 310
	[global::Cpp2ILInjected.Token(Token = "0x200016D")]
	internal struct XsdDuration
	{
		// Token: 0x06000BEA RID: 3050 RVA: 0x0000512C File Offset: 0x0000332C
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

		// Token: 0x06000BEB RID: 3051 RVA: 0x0000512F File Offset: 0x0000332F
		[global::Cpp2ILInjected.Token(Token = "0x6000C91")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DEEDF0", Offset = "0x1DEEDF0", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new object[] { typeof(TimeSpan) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public XsdDuration(TimeSpan timeSpan)
		{
			throw null;
		}

		// Token: 0x06000BEC RID: 3052 RVA: 0x00005132 File Offset: 0x00003332
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

		// Token: 0x06000BED RID: 3053 RVA: 0x00005135 File Offset: 0x00003335
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

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06000BEE RID: 3054 RVA: 0x00005138 File Offset: 0x00003338
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

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06000BEF RID: 3055 RVA: 0x0000513B File Offset: 0x0000333B
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

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06000BF0 RID: 3056 RVA: 0x0000513E File Offset: 0x0000333E
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

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06000BF1 RID: 3057 RVA: 0x00005141 File Offset: 0x00003341
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

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06000BF2 RID: 3058 RVA: 0x00005144 File Offset: 0x00003344
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

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06000BF3 RID: 3059 RVA: 0x00005147 File Offset: 0x00003347
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

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06000BF4 RID: 3060 RVA: 0x0000514A File Offset: 0x0000334A
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

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06000BF5 RID: 3061 RVA: 0x0000514D File Offset: 0x0000334D
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

		// Token: 0x06000BF6 RID: 3062 RVA: 0x00005150 File Offset: 0x00003350
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

		// Token: 0x06000BF7 RID: 3063 RVA: 0x00005153 File Offset: 0x00003353
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

		// Token: 0x06000BF8 RID: 3064 RVA: 0x00005156 File Offset: 0x00003356
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

		// Token: 0x06000BF9 RID: 3065 RVA: 0x00005159 File Offset: 0x00003359
		[global::Cpp2ILInjected.Token(Token = "0x6000C9F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DEFCD4", Offset = "0x1DEFCD4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new object[] { typeof(TimeSpan) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06000BFA RID: 3066 RVA: 0x0000515C File Offset: 0x0000335C
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

		// Token: 0x06000BFB RID: 3067 RVA: 0x0000515F File Offset: 0x0000335F
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

		// Token: 0x06000BFC RID: 3068 RVA: 0x00005162 File Offset: 0x00003362
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

		// Token: 0x06000BFD RID: 3069 RVA: 0x00005165 File Offset: 0x00003365
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

		// Token: 0x040004C3 RID: 1219
		[global::Cpp2ILInjected.Token(Token = "0x4000673")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int years;

		// Token: 0x040004C4 RID: 1220
		[global::Cpp2ILInjected.Token(Token = "0x4000674")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		private int months;

		// Token: 0x040004C5 RID: 1221
		[global::Cpp2ILInjected.Token(Token = "0x4000675")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private int days;

		// Token: 0x040004C6 RID: 1222
		[global::Cpp2ILInjected.Token(Token = "0x4000676")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		private int hours;

		// Token: 0x040004C7 RID: 1223
		[global::Cpp2ILInjected.Token(Token = "0x4000677")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int minutes;

		// Token: 0x040004C8 RID: 1224
		[global::Cpp2ILInjected.Token(Token = "0x4000678")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private int seconds;

		// Token: 0x040004C9 RID: 1225
		[global::Cpp2ILInjected.Token(Token = "0x4000679")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private uint nanoseconds;

		// Token: 0x0200017D RID: 381
		[global::Cpp2ILInjected.Token(Token = "0x200016E")]
		private enum Parts
		{
			// Token: 0x0400069F RID: 1695
			[global::Cpp2ILInjected.Token(Token = "0x400067B")]
			HasNone,
			// Token: 0x040006A0 RID: 1696
			[global::Cpp2ILInjected.Token(Token = "0x400067C")]
			HasYears,
			// Token: 0x040006A1 RID: 1697
			[global::Cpp2ILInjected.Token(Token = "0x400067D")]
			HasMonths,
			// Token: 0x040006A2 RID: 1698
			[global::Cpp2ILInjected.Token(Token = "0x400067E")]
			HasDays = 4,
			// Token: 0x040006A3 RID: 1699
			[global::Cpp2ILInjected.Token(Token = "0x400067F")]
			HasHours = 8,
			// Token: 0x040006A4 RID: 1700
			[global::Cpp2ILInjected.Token(Token = "0x4000680")]
			HasMinutes = 16,
			// Token: 0x040006A5 RID: 1701
			[global::Cpp2ILInjected.Token(Token = "0x4000681")]
			HasSeconds = 32
		}

		// Token: 0x0200017E RID: 382
		[global::Cpp2ILInjected.Token(Token = "0x200016F")]
		public enum DurationType
		{
			// Token: 0x040006A7 RID: 1703
			[global::Cpp2ILInjected.Token(Token = "0x4000683")]
			Duration,
			// Token: 0x040006A8 RID: 1704
			[global::Cpp2ILInjected.Token(Token = "0x4000684")]
			YearMonthDuration,
			// Token: 0x040006A9 RID: 1705
			[global::Cpp2ILInjected.Token(Token = "0x4000685")]
			DayTimeDuration
		}
	}
}
