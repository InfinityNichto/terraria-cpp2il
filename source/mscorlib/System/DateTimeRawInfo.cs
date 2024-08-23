using System;
using System.Globalization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x0200008B RID: 139
	[global::Cpp2ILInjected.Token(Token = "0x20000B7")]
	internal struct DateTimeRawInfo
	{
		// Token: 0x0600067D RID: 1661 RVA: 0x00015875 File Offset: 0x00013A75
		[global::Cpp2ILInjected.Token(Token = "0x600071C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C2DE04", Offset = "0x1C2DE04", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		internal unsafe void Init(int* numberBuffer)
		{
			throw null;
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x00015878 File Offset: 0x00013A78
		[global::Cpp2ILInjected.Token(Token = "0x600071D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C2DE24", Offset = "0x1C2DE24", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		internal void AddNumber(int value)
		{
			throw null;
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x0001587B File Offset: 0x00013A7B
		[global::Cpp2ILInjected.Token(Token = "0x600071E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C2DE3C", Offset = "0x1C2DE3C", Length = "0xC")]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "GetDayOfYNN", MemberParameters = new object[]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "GetDayOfYMN", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.DateTimeRawInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "GetDayOfYN", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.DateTimeRawInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "GetTimeOfN", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.DateTimeRawInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "GetTimeOfNN", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.DateTimeRawInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "GetTimeOfNNN", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.DateTimeRawInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "GetDateOfDSN", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.DateTimeRawInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "GetDateOfNDS", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.DateTimeRawInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "GetDateOfNNDS", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo)
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ParseISO8601", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeRawInfo),
			typeof(ref global::System.__DTString),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 36)]
		internal int GetNumber(int index)
		{
			throw null;
		}

		// Token: 0x040001A4 RID: 420
		[global::Cpp2ILInjected.Token(Token = "0x40002CF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private unsafe int* num;

		// Token: 0x040001A5 RID: 421
		[global::Cpp2ILInjected.Token(Token = "0x40002D0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		internal int numCount;

		// Token: 0x040001A6 RID: 422
		[global::Cpp2ILInjected.Token(Token = "0x40002D1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		internal int month;

		// Token: 0x040001A7 RID: 423
		[global::Cpp2ILInjected.Token(Token = "0x40002D2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal int year;

		// Token: 0x040001A8 RID: 424
		[global::Cpp2ILInjected.Token(Token = "0x40002D3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		internal int dayOfWeek;

		// Token: 0x040001A9 RID: 425
		[global::Cpp2ILInjected.Token(Token = "0x40002D4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal int era;

		// Token: 0x040001AA RID: 426
		[global::Cpp2ILInjected.Token(Token = "0x40002D5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		internal global::System.DateTimeParse.TM timeMark;

		// Token: 0x040001AB RID: 427
		[global::Cpp2ILInjected.Token(Token = "0x40002D6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal double fraction;

		// Token: 0x040001AC RID: 428
		[global::Cpp2ILInjected.Token(Token = "0x40002D7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal bool hasSameDateAndTimeSeparators;
	}
}
