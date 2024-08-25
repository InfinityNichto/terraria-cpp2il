using System;
using System.Globalization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	[global::Cpp2ILInjected.Token(Token = "0x20000BB")]
	internal struct ParsingInfo
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000727")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C2DFE8", Offset = "0x1C2DFE8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "DoStrictParse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		internal void Init()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000303")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		internal global::System.Globalization.Calendar calendar;

		[global::Cpp2ILInjected.Token(Token = "0x4000304")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		internal int dayOfWeek;

		[global::Cpp2ILInjected.Token(Token = "0x4000305")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		internal global::System.DateTimeParse.TM timeMark;

		[global::Cpp2ILInjected.Token(Token = "0x4000306")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal bool fUseHour12;

		[global::Cpp2ILInjected.Token(Token = "0x4000307")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x11")]
		internal bool fUseTwoDigitYear;

		[global::Cpp2ILInjected.Token(Token = "0x4000308")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x12")]
		internal bool fAllowInnerWhite;

		[global::Cpp2ILInjected.Token(Token = "0x4000309")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x13")]
		internal bool fAllowTrailingWhite;

		[global::Cpp2ILInjected.Token(Token = "0x400030A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		internal bool fCustomNumberParser;

		[global::Cpp2ILInjected.Token(Token = "0x400030B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal global::System.DateTimeParse.MatchNumberDelegate parseNumberDelegate;
	}
}
