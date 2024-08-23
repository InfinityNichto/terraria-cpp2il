using System;
using System.Globalization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x0200008E RID: 142
	[global::System.Obsolete("Types with embedded references are not supported in this version of your compiler.", true)]
	[global::Cpp2ILInjected.Token(Token = "0x20000BA")]
	internal ref struct DateTimeResult
	{
		// Token: 0x06000680 RID: 1664 RVA: 0x0001587E File Offset: 0x00013A7E
		[global::Cpp2ILInjected.Token(Token = "0x600071F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C2DE48", Offset = "0x1C2DE48", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ParseExact", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.Globalization.DateTimeStyles)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ParseExact", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.TimeSpan)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "TryParseExact", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "TryParseExact", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTime),
			typeof(ref global::System.TimeSpan)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ParseExactMultiple", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(string[]),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.Globalization.DateTimeStyles)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "TryParseExactMultiple", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(string[]),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "Parse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.Globalization.DateTimeStyles)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "Parse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.TimeSpan)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTime),
			typeof(ref global::System.TimeSpan)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		internal void Init(global::System.ReadOnlySpan<char> originalDateTimeString)
		{
			throw null;
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x00015881 File Offset: 0x00013A81
		[global::Cpp2ILInjected.Token(Token = "0x6000720")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C2DE6C", Offset = "0x1C2DE6C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "SetDateYMD", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "GetDayOfMNN", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		internal void SetDate(int year, int month, int day)
		{
			throw null;
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x00015884 File Offset: 0x00013A84
		[global::Cpp2ILInjected.Token(Token = "0x6000721")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C2DE78", Offset = "0x1C2DE78", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "TryParseExact", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "TryParseExactMultiple", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(string[]),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ReadOnlySpan<char>), Member = "get_Empty", ReturnType = "System.ReadOnlySpan`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal void SetBadFormatSpecifierFailure()
		{
			throw null;
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x00015887 File Offset: 0x00013A87
		[global::Cpp2ILInjected.Token(Token = "0x6000722")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C2DF0C", Offset = "0x1C2DF0C", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ParseByFormat", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(ref global::System.__DTString),
			typeof(ref global::System.ParsingInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "DoStrictParse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal void SetBadFormatSpecifierFailure(global::System.ReadOnlySpan<char> failedFormatSpecifier)
		{
			throw null;
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x0001588A File Offset: 0x00013A8A
		[global::Cpp2ILInjected.Token(Token = "0x6000723")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C2DF70", Offset = "0x1C2DF70", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 26)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal void SetBadDateTimeFailure()
		{
			throw null;
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x0001588D File Offset: 0x00013A8D
		[global::Cpp2ILInjected.Token(Token = "0x6000724")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C2DFC0", Offset = "0x1C2DFC0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "TryParseExact", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "TryParseExactMultiple", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(string[]),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ProcessHebrewTerminalState", MemberParameters = new object[]
		{
			typeof(global::System.DateTimeParse.DS),
			typeof(ref global::System.__DTString),
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "DetermineTimeZoneAdjustments", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(ref global::System.DateTimeResult),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "DateTimeOffsetTimeZonePostProcessing", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(ref global::System.DateTimeResult),
			typeof(global::System.Globalization.DateTimeStyles)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "AdjustTimeZoneToUniversal", MemberParameters = new object[] { typeof(ref global::System.DateTimeResult) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "AdjustTimeZoneToLocal", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ParseISO8601", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeRawInfo),
			typeof(ref global::System.__DTString),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "CheckDefaultDateTime", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.Globalization.Calendar),
			typeof(global::System.Globalization.DateTimeStyles)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "DoStrictParse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		internal void SetFailure(global::System.ParseFailureKind failure, string failureMessageID)
		{
			throw null;
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x00015890 File Offset: 0x00013A90
		[global::Cpp2ILInjected.Token(Token = "0x6000725")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C2DFCC", Offset = "0x1C2DFCC", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "Lex", MemberParameters = new object[]
		{
			typeof(global::System.DateTimeParse.DS),
			typeof(ref global::System.__DTString),
			typeof(ref global::System.DateTimeToken),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.Globalization.DateTimeStyles)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "GetDayOfNN", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "GetDayOfNNN", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "GetDayOfMN", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "GetHebrewDayOfNM", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "GetDayOfNM", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "GetDayOfMNN", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "GetDayOfNNY", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "GetDateOfNNDS", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "CheckNewValue", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(int),
			typeof(char),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ParseByFormat", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(ref global::System.__DTString),
			typeof(ref global::System.ParsingInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		internal void SetFailure(global::System.ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument)
		{
			throw null;
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x00015893 File Offset: 0x00013A93
		[global::Cpp2ILInjected.Token(Token = "0x6000726")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C2DFD8", Offset = "0x1C2DFD8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "TryParseExactMultiple", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(string[]),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		internal void SetFailure(global::System.ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument, string failureArgumentName)
		{
			throw null;
		}

		// Token: 0x040001C6 RID: 454
		[global::Cpp2ILInjected.Token(Token = "0x40002F1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		internal int Year;

		// Token: 0x040001C7 RID: 455
		[global::Cpp2ILInjected.Token(Token = "0x40002F2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		internal int Month;

		// Token: 0x040001C8 RID: 456
		[global::Cpp2ILInjected.Token(Token = "0x40002F3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		internal int Day;

		// Token: 0x040001C9 RID: 457
		[global::Cpp2ILInjected.Token(Token = "0x40002F4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		internal int Hour;

		// Token: 0x040001CA RID: 458
		[global::Cpp2ILInjected.Token(Token = "0x40002F5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal int Minute;

		// Token: 0x040001CB RID: 459
		[global::Cpp2ILInjected.Token(Token = "0x40002F6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		internal int Second;

		// Token: 0x040001CC RID: 460
		[global::Cpp2ILInjected.Token(Token = "0x40002F7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal double fraction;

		// Token: 0x040001CD RID: 461
		[global::Cpp2ILInjected.Token(Token = "0x40002F8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal int era;

		// Token: 0x040001CE RID: 462
		[global::Cpp2ILInjected.Token(Token = "0x40002F9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		internal global::System.ParseFlags flags;

		// Token: 0x040001CF RID: 463
		[global::Cpp2ILInjected.Token(Token = "0x40002FA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal global::System.TimeSpan timeZoneOffset;

		// Token: 0x040001D0 RID: 464
		[global::Cpp2ILInjected.Token(Token = "0x40002FB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		internal global::System.Globalization.Calendar calendar;

		// Token: 0x040001D1 RID: 465
		[global::Cpp2ILInjected.Token(Token = "0x40002FC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		internal global::System.DateTime parsedDate;

		// Token: 0x040001D2 RID: 466
		[global::Cpp2ILInjected.Token(Token = "0x40002FD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		internal global::System.ParseFailureKind failure;

		// Token: 0x040001D3 RID: 467
		[global::Cpp2ILInjected.Token(Token = "0x40002FE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		internal string failureMessageID;

		// Token: 0x040001D4 RID: 468
		[global::Cpp2ILInjected.Token(Token = "0x40002FF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		internal object failureMessageFormatArgument;

		// Token: 0x040001D5 RID: 469
		[global::Cpp2ILInjected.Token(Token = "0x4000300")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		internal string failureArgumentName;

		// Token: 0x040001D6 RID: 470
		[global::Cpp2ILInjected.Token(Token = "0x4000301")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		internal global::System.ReadOnlySpan<char> originalDateTimeString;

		// Token: 0x040001D7 RID: 471
		[global::Cpp2ILInjected.Token(Token = "0x4000302")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		internal global::System.ReadOnlySpan<char> failedFormatSpecifier;
	}
}
