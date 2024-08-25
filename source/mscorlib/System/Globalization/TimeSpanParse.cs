using System;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Globalization
{
	[global::Cpp2ILInjected.Token(Token = "0x200059C")]
	internal static class TimeSpanParse
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002B34")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BE2A4C", Offset = "0x1BE2A4C", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ParseFractionExact", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(int),
			typeof(ref double)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanFormat), Member = "FormatStandard", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(bool),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(TimeSpanFormat.Pattern)
		}, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanFormat), Member = "FormatCustomized", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(DateTimeFormatInfo),
			typeof(global::System.Text.StringBuilder)
		}, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanParse.TimeSpanToken), Member = "IsInvalidFraction", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanParse), Member = "TryTimeToTicks", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(TimeSpanParse.TimeSpanToken),
			typeof(TimeSpanParse.TimeSpanToken),
			typeof(TimeSpanParse.TimeSpanToken),
			typeof(TimeSpanParse.TimeSpanToken),
			typeof(TimeSpanParse.TimeSpanToken),
			typeof(ref long)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Math), Member = "Pow", MemberParameters = new object[]
		{
			typeof(double),
			typeof(double)
		}, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static long Pow10(int pow)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002B35")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BE2D74", Offset = "0x1BE2D74", Length = "0x160")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_DHMSF", MemberParameters = new object[]
		{
			typeof(ref TimeSpanParse.TimeSpanRawInfo),
			typeof(TimeSpanParse.TimeSpanStandardStyles),
			typeof(ref TimeSpanParse.TimeSpanResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HMS_F_D", MemberParameters = new object[]
		{
			typeof(ref TimeSpanParse.TimeSpanRawInfo),
			typeof(TimeSpanParse.TimeSpanStandardStyles),
			typeof(ref TimeSpanParse.TimeSpanResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HM_S_D", MemberParameters = new object[]
		{
			typeof(ref TimeSpanParse.TimeSpanRawInfo),
			typeof(TimeSpanParse.TimeSpanStandardStyles),
			typeof(ref TimeSpanParse.TimeSpanResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HM", MemberParameters = new object[]
		{
			typeof(ref TimeSpanParse.TimeSpanRawInfo),
			typeof(TimeSpanParse.TimeSpanStandardStyles),
			typeof(ref TimeSpanParse.TimeSpanResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_D", MemberParameters = new object[]
		{
			typeof(ref TimeSpanParse.TimeSpanRawInfo),
			typeof(TimeSpanParse.TimeSpanStandardStyles),
			typeof(ref TimeSpanParse.TimeSpanResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanParse), Member = "TryParseByFormat", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(TimeSpanStyles),
			typeof(ref TimeSpanParse.TimeSpanResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 28)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpanParse.TimeSpanToken), Member = "IsInvalidFraction", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpanParse), Member = "Pow10", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(long))]
		private static bool TryTimeToTicks(bool positive, TimeSpanParse.TimeSpanToken days, TimeSpanParse.TimeSpanToken hours, TimeSpanParse.TimeSpanToken minutes, TimeSpanParse.TimeSpanToken seconds, TimeSpanParse.TimeSpanToken fraction, out long result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002B36")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BE2F30", Offset = "0x1BE2F30", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeSpan), Member = "Parse", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeSpan), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpanParse), Member = "TryParseTimeSpan", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(TimeSpanParse.TimeSpanStandardStyles),
			typeof(global::System.IFormatProvider),
			typeof(ref TimeSpanParse.TimeSpanResult)
		}, ReturnType = typeof(bool))]
		internal static global::System.TimeSpan Parse(global::System.ReadOnlySpan<char> input, global::System.IFormatProvider formatProvider)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002B37")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BE3130", Offset = "0x1BE3130", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeSpan), Member = "TryParseExact", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(global::System.IFormatProvider),
			typeof(ref global::System.TimeSpan)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpanParse), Member = "TryParseExactTimeSpan", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider),
			typeof(TimeSpanStyles),
			typeof(ref TimeSpanParse.TimeSpanResult)
		}, ReturnType = typeof(bool))]
		internal static bool TryParseExact(global::System.ReadOnlySpan<char> input, global::System.ReadOnlySpan<char> format, global::System.IFormatProvider formatProvider, TimeSpanStyles styles, out global::System.TimeSpan result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002B38")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BE2F70", Offset = "0x1BE2F70", Length = "0x1C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanParse), Member = "Parse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanParse), Member = "TryParseExactTimeSpan", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider),
			typeof(TimeSpanStyles),
			typeof(ref TimeSpanParse.TimeSpanResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MemoryExtensions), Member = "Trim", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = typeof(global::System.ReadOnlySpan<char>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ReadOnlySpan<char>), Member = "get_IsEmpty", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "GetInstance", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(DateTimeFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "get_FullTimeSpanPositivePattern", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "get_FullTimeSpanNegativePattern", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpanParse.TimeSpanTokenizer), Member = "GetNextToken", ReturnType = typeof(TimeSpanParse.TimeSpanToken))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpanParse.TimeSpanRawInfo), Member = "ProcessToken", MemberParameters = new object[]
		{
			typeof(ref TimeSpanParse.TimeSpanToken),
			typeof(ref TimeSpanParse.TimeSpanResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpanParse), Member = "ProcessTerminalState", MemberParameters = new object[]
		{
			typeof(ref TimeSpanParse.TimeSpanRawInfo),
			typeof(TimeSpanParse.TimeSpanStandardStyles),
			typeof(ref TimeSpanParse.TimeSpanResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpanParse.TimeSpanResult), Member = "SetFailure", MemberParameters = new object[]
		{
			typeof(TimeSpanParse.ParseFailureKind),
			typeof(string),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static bool TryParseTimeSpan(global::System.ReadOnlySpan<char> input, TimeSpanParse.TimeSpanStandardStyles style, global::System.IFormatProvider formatProvider, ref TimeSpanParse.TimeSpanResult result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002B39")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BE3788", Offset = "0x1BE3788", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanParse), Member = "TryParseTimeSpan", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(TimeSpanParse.TimeSpanStandardStyles),
			typeof(global::System.IFormatProvider),
			typeof(ref TimeSpanParse.TimeSpanResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpanParse.TimeSpanRawInfo), Member = "ProcessToken", MemberParameters = new object[]
		{
			typeof(ref TimeSpanParse.TimeSpanToken),
			typeof(ref TimeSpanParse.TimeSpanResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_D", MemberParameters = new object[]
		{
			typeof(ref TimeSpanParse.TimeSpanRawInfo),
			typeof(TimeSpanParse.TimeSpanStandardStyles),
			typeof(ref TimeSpanParse.TimeSpanResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpanParse.TimeSpanResult), Member = "SetFailure", MemberParameters = new object[]
		{
			typeof(TimeSpanParse.ParseFailureKind),
			typeof(string),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HM", MemberParameters = new object[]
		{
			typeof(ref TimeSpanParse.TimeSpanRawInfo),
			typeof(TimeSpanParse.TimeSpanStandardStyles),
			typeof(ref TimeSpanParse.TimeSpanResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HM_S_D", MemberParameters = new object[]
		{
			typeof(ref TimeSpanParse.TimeSpanRawInfo),
			typeof(TimeSpanParse.TimeSpanStandardStyles),
			typeof(ref TimeSpanParse.TimeSpanResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HMS_F_D", MemberParameters = new object[]
		{
			typeof(ref TimeSpanParse.TimeSpanRawInfo),
			typeof(TimeSpanParse.TimeSpanStandardStyles),
			typeof(ref TimeSpanParse.TimeSpanResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_DHMSF", MemberParameters = new object[]
		{
			typeof(ref TimeSpanParse.TimeSpanRawInfo),
			typeof(TimeSpanParse.TimeSpanStandardStyles),
			typeof(ref TimeSpanParse.TimeSpanResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static bool ProcessTerminalState(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002B3A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BE59DC", Offset = "0x1BE59DC", Length = "0x26C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminalState", MemberParameters = new object[]
		{
			typeof(ref TimeSpanParse.TimeSpanRawInfo),
			typeof(TimeSpanParse.TimeSpanStandardStyles),
			typeof(ref TimeSpanParse.TimeSpanResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpanParse.TimeSpanRawInfo), Member = "FullMatch", MemberParameters = new object[] { typeof(TimeSpanFormat.FormatLiterals) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpanParse.TimeSpanRawInfo), Member = "get_PositiveLocalized", ReturnType = typeof(TimeSpanFormat.FormatLiterals))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpanParse.TimeSpanRawInfo), Member = "get_NegativeLocalized", ReturnType = typeof(TimeSpanFormat.FormatLiterals))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpanParse), Member = "TryTimeToTicks", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(TimeSpanParse.TimeSpanToken),
			typeof(TimeSpanParse.TimeSpanToken),
			typeof(TimeSpanParse.TimeSpanToken),
			typeof(TimeSpanParse.TimeSpanToken),
			typeof(TimeSpanParse.TimeSpanToken),
			typeof(ref long)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpanParse.TimeSpanResult), Member = "SetFailure", MemberParameters = new object[]
		{
			typeof(TimeSpanParse.ParseFailureKind),
			typeof(string),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static bool ProcessTerminal_DHMSF(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002B3B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BE4E04", Offset = "0x1BE4E04", Length = "0xBD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminalState", MemberParameters = new object[]
		{
			typeof(ref TimeSpanParse.TimeSpanRawInfo),
			typeof(TimeSpanParse.TimeSpanStandardStyles),
			typeof(ref TimeSpanParse.TimeSpanResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpanParse.TimeSpanRawInfo), Member = "FullHMSFMatch", MemberParameters = new object[] { typeof(TimeSpanFormat.FormatLiterals) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpanParse), Member = "TryTimeToTicks", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(TimeSpanParse.TimeSpanToken),
			typeof(TimeSpanParse.TimeSpanToken),
			typeof(TimeSpanParse.TimeSpanToken),
			typeof(TimeSpanParse.TimeSpanToken),
			typeof(TimeSpanParse.TimeSpanToken),
			typeof(ref long)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpanParse.TimeSpanRawInfo), Member = "FullDHMSMatch", MemberParameters = new object[] { typeof(TimeSpanFormat.FormatLiterals) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpanParse.TimeSpanRawInfo), Member = "FullAppCompatMatch", MemberParameters = new object[] { typeof(TimeSpanFormat.FormatLiterals) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpanParse.TimeSpanResult), Member = "SetFailure", MemberParameters = new object[]
		{
			typeof(TimeSpanParse.ParseFailureKind),
			typeof(string),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpanParse.TimeSpanRawInfo), Member = "get_PositiveLocalized", ReturnType = typeof(TimeSpanFormat.FormatLiterals))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpanParse.TimeSpanRawInfo), Member = "get_NegativeLocalized", ReturnType = typeof(TimeSpanFormat.FormatLiterals))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private static bool ProcessTerminal_HMS_F_D(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002B3C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BE3FA0", Offset = "0x1BE3FA0", Length = "0xE64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminalState", MemberParameters = new object[]
		{
			typeof(ref TimeSpanParse.TimeSpanRawInfo),
			typeof(TimeSpanParse.TimeSpanStandardStyles),
			typeof(ref TimeSpanParse.TimeSpanResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpanParse.TimeSpanRawInfo), Member = "FullHMSMatch", MemberParameters = new object[] { typeof(TimeSpanFormat.FormatLiterals) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpanParse), Member = "TryTimeToTicks", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(TimeSpanParse.TimeSpanToken),
			typeof(TimeSpanParse.TimeSpanToken),
			typeof(TimeSpanParse.TimeSpanToken),
			typeof(TimeSpanParse.TimeSpanToken),
			typeof(TimeSpanParse.TimeSpanToken),
			typeof(ref long)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpanParse.TimeSpanRawInfo), Member = "FullDHMMatch", MemberParameters = new object[] { typeof(TimeSpanFormat.FormatLiterals) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpanParse.TimeSpanRawInfo), Member = "PartialAppCompatMatch", MemberParameters = new object[] { typeof(TimeSpanFormat.FormatLiterals) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpanParse.TimeSpanResult), Member = "SetFailure", MemberParameters = new object[]
		{
			typeof(TimeSpanParse.ParseFailureKind),
			typeof(string),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpanParse.TimeSpanRawInfo), Member = "get_PositiveLocalized", ReturnType = typeof(TimeSpanFormat.FormatLiterals))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpanParse.TimeSpanRawInfo), Member = "get_NegativeLocalized", ReturnType = typeof(TimeSpanFormat.FormatLiterals))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private static bool ProcessTerminal_HM_S_D(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002B3D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BE3C4C", Offset = "0x1BE3C4C", Length = "0x354")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminalState", MemberParameters = new object[]
		{
			typeof(ref TimeSpanParse.TimeSpanRawInfo),
			typeof(TimeSpanParse.TimeSpanStandardStyles),
			typeof(ref TimeSpanParse.TimeSpanResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpanParse.TimeSpanRawInfo), Member = "FullHMMatch", MemberParameters = new object[] { typeof(TimeSpanFormat.FormatLiterals) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpanParse.TimeSpanRawInfo), Member = "get_PositiveLocalized", ReturnType = typeof(TimeSpanFormat.FormatLiterals))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpanParse), Member = "TryTimeToTicks", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(TimeSpanParse.TimeSpanToken),
			typeof(TimeSpanParse.TimeSpanToken),
			typeof(TimeSpanParse.TimeSpanToken),
			typeof(TimeSpanParse.TimeSpanToken),
			typeof(TimeSpanParse.TimeSpanToken),
			typeof(ref long)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpanParse.TimeSpanRawInfo), Member = "get_NegativeLocalized", ReturnType = typeof(TimeSpanFormat.FormatLiterals))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpanParse.TimeSpanResult), Member = "SetFailure", MemberParameters = new object[]
		{
			typeof(TimeSpanParse.ParseFailureKind),
			typeof(string),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private static bool ProcessTerminal_HM(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002B3E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BE38C0", Offset = "0x1BE38C0", Length = "0x38C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminalState", MemberParameters = new object[]
		{
			typeof(ref TimeSpanParse.TimeSpanRawInfo),
			typeof(TimeSpanParse.TimeSpanStandardStyles),
			typeof(ref TimeSpanParse.TimeSpanResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpanParse.TimeSpanRawInfo), Member = "FullDMatch", MemberParameters = new object[] { typeof(TimeSpanFormat.FormatLiterals) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpanParse.TimeSpanRawInfo), Member = "get_PositiveLocalized", ReturnType = typeof(TimeSpanFormat.FormatLiterals))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpanParse), Member = "TryTimeToTicks", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(TimeSpanParse.TimeSpanToken),
			typeof(TimeSpanParse.TimeSpanToken),
			typeof(TimeSpanParse.TimeSpanToken),
			typeof(TimeSpanParse.TimeSpanToken),
			typeof(TimeSpanParse.TimeSpanToken),
			typeof(ref long)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpanParse.TimeSpanRawInfo), Member = "get_NegativeLocalized", ReturnType = typeof(TimeSpanFormat.FormatLiterals))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpanParse.TimeSpanResult), Member = "SetFailure", MemberParameters = new object[]
		{
			typeof(TimeSpanParse.ParseFailureKind),
			typeof(string),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private static bool ProcessTerminal_D(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002B3F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BE3170", Offset = "0x1BE3170", Length = "0x174")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanParse), Member = "TryParseExact", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider),
			typeof(TimeSpanStyles),
			typeof(ref global::System.TimeSpan)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpanParse.TimeSpanResult), Member = "SetFailure", MemberParameters = new object[]
		{
			typeof(TimeSpanParse.ParseFailureKind),
			typeof(string),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpanParse), Member = "TryParseByFormat", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(TimeSpanStyles),
			typeof(ref TimeSpanParse.TimeSpanResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpanParse.StringParser), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(ref TimeSpanParse.TimeSpanResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpanParse), Member = "TryParseTimeSpan", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(TimeSpanParse.TimeSpanStandardStyles),
			typeof(global::System.IFormatProvider),
			typeof(ref TimeSpanParse.TimeSpanResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static bool TryParseExactTimeSpan(global::System.ReadOnlySpan<char> input, global::System.ReadOnlySpan<char> format, global::System.IFormatProvider formatProvider, TimeSpanStyles styles, ref TimeSpanParse.TimeSpanResult result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002B40")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BE8F68", Offset = "0x1BE8F68", Length = "0x6EC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanParse), Member = "TryParseExactTimeSpan", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider),
			typeof(TimeSpanStyles),
			typeof(ref TimeSpanParse.TimeSpanResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeFormat), Member = "ParseNextChar", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeFormat), Member = "ParseRepeatPattern", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(int),
			typeof(char)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpanParse), Member = "ParseExactDigits", MemberParameters = new object[]
		{
			typeof(ref TimeSpanParse.TimeSpanTokenizer),
			typeof(int),
			typeof(int),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilderCache), Member = "Acquire", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "TryParseQuoteString", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(int),
			typeof(global::System.Text.StringBuilder),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpanParse), Member = "ParseExactLiteral", MemberParameters = new object[]
		{
			typeof(ref TimeSpanParse.TimeSpanTokenizer),
			typeof(global::System.Text.StringBuilder)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilderCache), Member = "Release", MemberParameters = new object[] { typeof(global::System.Text.StringBuilder) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpanParse.TimeSpanResult), Member = "SetFailure", MemberParameters = new object[]
		{
			typeof(TimeSpanParse.ParseFailureKind),
			typeof(string),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpanParse), Member = "TryTimeToTicks", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(TimeSpanParse.TimeSpanToken),
			typeof(TimeSpanParse.TimeSpanToken),
			typeof(TimeSpanParse.TimeSpanToken),
			typeof(TimeSpanParse.TimeSpanToken),
			typeof(TimeSpanParse.TimeSpanToken),
			typeof(ref long)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		private static bool TryParseByFormat(global::System.ReadOnlySpan<char> input, global::System.ReadOnlySpan<char> format, TimeSpanStyles styles, ref TimeSpanParse.TimeSpanResult result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002B41")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BE9660", Offset = "0x1BE9660", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpanParse), Member = "ParseExactDigits", MemberParameters = new object[]
		{
			typeof(ref TimeSpanParse.TimeSpanTokenizer),
			typeof(int),
			typeof(int),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		private static bool ParseExactDigits(ref TimeSpanParse.TimeSpanTokenizer tokenizer, int minDigitLength, out int result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002B42")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BE9690", Offset = "0x1BE9690", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanParse), Member = "TryParseByFormat", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(TimeSpanStyles),
			typeof(ref TimeSpanParse.TimeSpanResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanParse), Member = "ParseExactDigits", MemberParameters = new object[]
		{
			typeof(ref TimeSpanParse.TimeSpanTokenizer),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpanParse.TimeSpanTokenizer), Member = "get_NextChar", ReturnType = typeof(char))]
		private static bool ParseExactDigits(ref TimeSpanParse.TimeSpanTokenizer tokenizer, int minDigitLength, int maxDigitLength, out int zeroes, out int result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002B43")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BE9754", Offset = "0x1BE9754", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanParse), Member = "TryParseByFormat", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(TimeSpanStyles),
			typeof(ref TimeSpanParse.TimeSpanResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpanParse.TimeSpanTokenizer), Member = "get_NextChar", ReturnType = typeof(char))]
		private static bool ParseExactLiteral(ref TimeSpanParse.TimeSpanTokenizer tokenizer, global::System.Text.StringBuilder enquotedString)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002B44")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BE8F34", Offset = "0x1BE8F34", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpanParse.StringParser), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(ref TimeSpanParse.TimeSpanResult)
		}, ReturnType = typeof(bool))]
		private static bool TryParseTimeSpanConstant(global::System.ReadOnlySpan<char> input, ref TimeSpanParse.TimeSpanResult result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x200059D")]
		private enum ParseFailureKind : byte
		{
			[global::Cpp2ILInjected.Token(Token = "0x40017C4")]
			None,
			[global::Cpp2ILInjected.Token(Token = "0x40017C5")]
			ArgumentNull,
			[global::Cpp2ILInjected.Token(Token = "0x40017C6")]
			Format,
			[global::Cpp2ILInjected.Token(Token = "0x40017C7")]
			FormatWithParameter,
			[global::Cpp2ILInjected.Token(Token = "0x40017C8")]
			Overflow
		}

		[global::System.Flags]
		[global::Cpp2ILInjected.Token(Token = "0x200059E")]
		private enum TimeSpanStandardStyles : byte
		{
			[global::Cpp2ILInjected.Token(Token = "0x40017CA")]
			None = 0,
			[global::Cpp2ILInjected.Token(Token = "0x40017CB")]
			Invariant = 1,
			[global::Cpp2ILInjected.Token(Token = "0x40017CC")]
			Localized = 2,
			[global::Cpp2ILInjected.Token(Token = "0x40017CD")]
			RequireFull = 4,
			[global::Cpp2ILInjected.Token(Token = "0x40017CE")]
			Any = 3
		}

		[global::Cpp2ILInjected.Token(Token = "0x200059F")]
		private enum TTT : byte
		{
			[global::Cpp2ILInjected.Token(Token = "0x40017D0")]
			None,
			[global::Cpp2ILInjected.Token(Token = "0x40017D1")]
			End,
			[global::Cpp2ILInjected.Token(Token = "0x40017D2")]
			Num,
			[global::Cpp2ILInjected.Token(Token = "0x40017D3")]
			Sep,
			[global::Cpp2ILInjected.Token(Token = "0x40017D4")]
			NumOverflow
		}

		[global::System.Obsolete("Types with embedded references are not supported in this version of your compiler.", true)]
		[global::Cpp2ILInjected.Token(Token = "0x20005A0")]
		private ref struct TimeSpanToken
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002B45")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BE9B64", Offset = "0x1BE9B64", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public TimeSpanToken(TimeSpanParse.TTT type)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002B46")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BE6548", Offset = "0x1BE6548", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public TimeSpanToken(int number)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002B47")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BE9884", Offset = "0x1BE9884", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public TimeSpanToken(int number, int leadingZeroes)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002B48")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BE9B74", Offset = "0x1BE9B74", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public TimeSpanToken(TimeSpanParse.TTT type, int number, int leadingZeroes, global::System.ReadOnlySpan<char> separator)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002B49")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BE2ED4", Offset = "0x1BE2ED4", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanParse), Member = "TryTimeToTicks", MemberParameters = new object[]
			{
				typeof(bool),
				typeof(TimeSpanParse.TimeSpanToken),
				typeof(TimeSpanParse.TimeSpanToken),
				typeof(TimeSpanParse.TimeSpanToken),
				typeof(TimeSpanParse.TimeSpanToken),
				typeof(TimeSpanParse.TimeSpanToken),
				typeof(ref long)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpanParse), Member = "Pow10", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(long))]
			public bool IsInvalidFraction()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x40017D5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal TimeSpanParse.TTT _ttt;

			[global::Cpp2ILInjected.Token(Token = "0x40017D6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
			internal int _num;

			[global::Cpp2ILInjected.Token(Token = "0x40017D7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			internal int _zeroes;

			[global::Cpp2ILInjected.Token(Token = "0x40017D8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			internal global::System.ReadOnlySpan<char> _sep;
		}

		[global::System.Obsolete("Types with embedded references are not supported in this version of your compiler.", true)]
		[global::Cpp2ILInjected.Token(Token = "0x20005A1")]
		private ref struct TimeSpanTokenizer
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002B4A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BE340C", Offset = "0x1BE340C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal TimeSpanTokenizer(global::System.ReadOnlySpan<char> input)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002B4B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BE9654", Offset = "0x1BE9654", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal TimeSpanTokenizer(global::System.ReadOnlySpan<char> input, int startPosition)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002B4C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BE3464", Offset = "0x1BE3464", Length = "0x214")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanParse), Member = "TryParseTimeSpan", MemberParameters = new object[]
			{
				typeof(global::System.ReadOnlySpan<char>),
				"System.Globalization.TimeSpanParse.TimeSpanStandardStyles",
				typeof(global::System.IFormatProvider),
				typeof(ref TimeSpanParse.TimeSpanResult)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal TimeSpanParse.TimeSpanToken GetNextToken()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x1700065D")]
			internal bool EOL
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002B4D")]
				[global::Cpp2ILInjected.Address(RVA = "0x1BE9838", Offset = "0x1BE9838", Length = "0x4C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002B4E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BE9898", Offset = "0x1BE9898", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal void BackOne()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x1700065E")]
			internal char NextChar
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002B4F")]
				[global::Cpp2ILInjected.Address(RVA = "0x1BE97D8", Offset = "0x1BE97D8", Length = "0x60")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanParse), Member = "ParseExactDigits", MemberParameters = new object[]
				{
					typeof(ref TimeSpanParse.TimeSpanTokenizer),
					typeof(int),
					typeof(int),
					typeof(ref int),
					typeof(ref int)
				}, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanParse), Member = "ParseExactLiteral", MemberParameters = new object[]
				{
					typeof(ref TimeSpanParse.TimeSpanTokenizer),
					typeof(global::System.Text.StringBuilder)
				}, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x40017D9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private global::System.ReadOnlySpan<char> _value;

			[global::Cpp2ILInjected.Token(Token = "0x40017DA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private int _pos;
		}

		[global::System.Obsolete("Types with embedded references are not supported in this version of your compiler.", true)]
		[global::Cpp2ILInjected.Token(Token = "0x20005A2")]
		private ref struct TimeSpanRawInfo
		{
			[global::Cpp2ILInjected.Token(Token = "0x1700065F")]
			internal TimeSpanFormat.FormatLiterals PositiveInvariant
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002B50")]
				[global::Cpp2ILInjected.Address(RVA = "0x1BE9B84", Offset = "0x1BE9B84", Length = "0x68")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x17000660")]
			internal TimeSpanFormat.FormatLiterals NegativeInvariant
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002B51")]
				[global::Cpp2ILInjected.Address(RVA = "0x1BE9BEC", Offset = "0x1BE9BEC", Length = "0x6C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x17000661")]
			internal TimeSpanFormat.FormatLiterals PositiveLocalized
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002B52")]
				[global::Cpp2ILInjected.Address(RVA = "0x1BE63E4", Offset = "0x1BE63E4", Length = "0xB0")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_DHMSF", MemberParameters = new object[]
				{
					typeof(ref TimeSpanParse.TimeSpanRawInfo),
					"System.Globalization.TimeSpanParse.TimeSpanStandardStyles",
					typeof(ref TimeSpanParse.TimeSpanResult)
				}, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HMS_F_D", MemberParameters = new object[]
				{
					typeof(ref TimeSpanParse.TimeSpanRawInfo),
					"System.Globalization.TimeSpanParse.TimeSpanStandardStyles",
					typeof(ref TimeSpanParse.TimeSpanResult)
				}, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HM_S_D", MemberParameters = new object[]
				{
					typeof(ref TimeSpanParse.TimeSpanRawInfo),
					"System.Globalization.TimeSpanParse.TimeSpanStandardStyles",
					typeof(ref TimeSpanParse.TimeSpanResult)
				}, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HM", MemberParameters = new object[]
				{
					typeof(ref TimeSpanParse.TimeSpanRawInfo),
					"System.Globalization.TimeSpanParse.TimeSpanStandardStyles",
					typeof(ref TimeSpanParse.TimeSpanResult)
				}, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_D", MemberParameters = new object[]
				{
					typeof(ref TimeSpanParse.TimeSpanRawInfo),
					"System.Globalization.TimeSpanParse.TimeSpanStandardStyles",
					typeof(ref TimeSpanParse.TimeSpanResult)
				}, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpanFormat.FormatLiterals), Member = "Init", MemberParameters = new object[]
				{
					typeof(global::System.ReadOnlySpan<char>),
					typeof(bool)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x17000662")]
			internal TimeSpanFormat.FormatLiterals NegativeLocalized
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002B53")]
				[global::Cpp2ILInjected.Address(RVA = "0x1BE6494", Offset = "0x1BE6494", Length = "0xB4")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_DHMSF", MemberParameters = new object[]
				{
					typeof(ref TimeSpanParse.TimeSpanRawInfo),
					"System.Globalization.TimeSpanParse.TimeSpanStandardStyles",
					typeof(ref TimeSpanParse.TimeSpanResult)
				}, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HMS_F_D", MemberParameters = new object[]
				{
					typeof(ref TimeSpanParse.TimeSpanRawInfo),
					"System.Globalization.TimeSpanParse.TimeSpanStandardStyles",
					typeof(ref TimeSpanParse.TimeSpanResult)
				}, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HM_S_D", MemberParameters = new object[]
				{
					typeof(ref TimeSpanParse.TimeSpanRawInfo),
					"System.Globalization.TimeSpanParse.TimeSpanStandardStyles",
					typeof(ref TimeSpanParse.TimeSpanResult)
				}, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HM", MemberParameters = new object[]
				{
					typeof(ref TimeSpanParse.TimeSpanRawInfo),
					"System.Globalization.TimeSpanParse.TimeSpanStandardStyles",
					typeof(ref TimeSpanParse.TimeSpanResult)
				}, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_D", MemberParameters = new object[]
				{
					typeof(ref TimeSpanParse.TimeSpanRawInfo),
					"System.Globalization.TimeSpanParse.TimeSpanStandardStyles",
					typeof(ref TimeSpanParse.TimeSpanResult)
				}, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpanFormat.FormatLiterals), Member = "Init", MemberParameters = new object[]
				{
					typeof(global::System.ReadOnlySpan<char>),
					typeof(bool)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002B54")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BE7234", Offset = "0x1BE7234", Length = "0x668")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HMS_F_D", MemberParameters = new object[]
			{
				typeof(ref TimeSpanParse.TimeSpanRawInfo),
				"System.Globalization.TimeSpanParse.TimeSpanStandardStyles",
				typeof(ref TimeSpanParse.TimeSpanResult)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SpanHelpers), Member = "SequenceEqual", MemberParameters = new object[]
			{
				typeof(ref byte),
				typeof(ref byte),
				typeof(ulong)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
			internal bool FullAppCompatMatch(TimeSpanFormat.FormatLiterals pattern)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002B55")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BE8314", Offset = "0x1BE8314", Length = "0x538")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HM_S_D", MemberParameters = new object[]
			{
				typeof(ref TimeSpanParse.TimeSpanRawInfo),
				"System.Globalization.TimeSpanParse.TimeSpanStandardStyles",
				typeof(ref TimeSpanParse.TimeSpanResult)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SpanHelpers), Member = "SequenceEqual", MemberParameters = new object[]
			{
				typeof(ref byte),
				typeof(ref byte),
				typeof(ulong)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
			internal bool PartialAppCompatMatch(TimeSpanFormat.FormatLiterals pattern)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002B56")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BE5C48", Offset = "0x1BE5C48", Length = "0x79C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_DHMSF", MemberParameters = new object[]
			{
				typeof(ref TimeSpanParse.TimeSpanRawInfo),
				"System.Globalization.TimeSpanParse.TimeSpanStandardStyles",
				typeof(ref TimeSpanParse.TimeSpanResult)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SpanHelpers), Member = "SequenceEqual", MemberParameters = new object[]
			{
				typeof(ref byte),
				typeof(ref byte),
				typeof(ulong)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
			internal bool FullMatch(TimeSpanFormat.FormatLiterals pattern)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002B57")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BE8C58", Offset = "0x1BE8C58", Length = "0x2DC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_D", MemberParameters = new object[]
			{
				typeof(ref TimeSpanParse.TimeSpanRawInfo),
				"System.Globalization.TimeSpanParse.TimeSpanStandardStyles",
				typeof(ref TimeSpanParse.TimeSpanResult)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SpanHelpers), Member = "SequenceEqual", MemberParameters = new object[]
			{
				typeof(ref byte),
				typeof(ref byte),
				typeof(ulong)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			internal bool FullDMatch(TimeSpanFormat.FormatLiterals pattern)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002B58")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BE884C", Offset = "0x1BE884C", Length = "0x40C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HM", MemberParameters = new object[]
			{
				typeof(ref TimeSpanParse.TimeSpanRawInfo),
				"System.Globalization.TimeSpanParse.TimeSpanStandardStyles",
				typeof(ref TimeSpanParse.TimeSpanResult)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SpanHelpers), Member = "SequenceEqual", MemberParameters = new object[]
			{
				typeof(ref byte),
				typeof(ref byte),
				typeof(ulong)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			internal bool FullHMMatch(TimeSpanFormat.FormatLiterals pattern)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002B59")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BE7DD8", Offset = "0x1BE7DD8", Length = "0x53C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HM_S_D", MemberParameters = new object[]
			{
				typeof(ref TimeSpanParse.TimeSpanRawInfo),
				"System.Globalization.TimeSpanParse.TimeSpanStandardStyles",
				typeof(ref TimeSpanParse.TimeSpanResult)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SpanHelpers), Member = "SequenceEqual", MemberParameters = new object[]
			{
				typeof(ref byte),
				typeof(ref byte),
				typeof(ulong)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
			internal bool FullDHMMatch(TimeSpanFormat.FormatLiterals pattern)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002B5A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BE789C", Offset = "0x1BE789C", Length = "0x53C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HM_S_D", MemberParameters = new object[]
			{
				typeof(ref TimeSpanParse.TimeSpanRawInfo),
				"System.Globalization.TimeSpanParse.TimeSpanStandardStyles",
				typeof(ref TimeSpanParse.TimeSpanResult)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SpanHelpers), Member = "SequenceEqual", MemberParameters = new object[]
			{
				typeof(ref byte),
				typeof(ref byte),
				typeof(ulong)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
			internal bool FullHMSMatch(TimeSpanFormat.FormatLiterals pattern)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002B5B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BE6BC8", Offset = "0x1BE6BC8", Length = "0x66C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HMS_F_D", MemberParameters = new object[]
			{
				typeof(ref TimeSpanParse.TimeSpanRawInfo),
				"System.Globalization.TimeSpanParse.TimeSpanStandardStyles",
				typeof(ref TimeSpanParse.TimeSpanResult)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SpanHelpers), Member = "SequenceEqual", MemberParameters = new object[]
			{
				typeof(ref byte),
				typeof(ref byte),
				typeof(ulong)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
			internal bool FullDHMSMatch(TimeSpanFormat.FormatLiterals pattern)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002B5C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BE655C", Offset = "0x1BE655C", Length = "0x66C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HMS_F_D", MemberParameters = new object[]
			{
				typeof(ref TimeSpanParse.TimeSpanRawInfo),
				"System.Globalization.TimeSpanParse.TimeSpanStandardStyles",
				typeof(ref TimeSpanParse.TimeSpanResult)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SpanHelpers), Member = "SequenceEqual", MemberParameters = new object[]
			{
				typeof(ref byte),
				typeof(ref byte),
				typeof(ulong)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
			internal bool FullHMSFMatch(TimeSpanFormat.FormatLiterals pattern)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002B5D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BE3418", Offset = "0x1BE3418", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "get_FullTimeSpanPositivePattern", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "get_FullTimeSpanNegativePattern", ReturnType = typeof(string))]
			internal void Init(DateTimeFormatInfo dtfi)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002B5E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BE3678", Offset = "0x1BE3678", Length = "0x110")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanParse), Member = "TryParseTimeSpan", MemberParameters = new object[]
			{
				typeof(global::System.ReadOnlySpan<char>),
				"System.Globalization.TimeSpanParse.TimeSpanStandardStyles",
				typeof(global::System.IFormatProvider),
				typeof(ref TimeSpanParse.TimeSpanResult)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminalState", MemberParameters = new object[]
			{
				typeof(ref TimeSpanParse.TimeSpanRawInfo),
				"System.Globalization.TimeSpanParse.TimeSpanStandardStyles",
				typeof(ref TimeSpanParse.TimeSpanResult)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpanParse.TimeSpanRawInfo), Member = "AddSep", MemberParameters = new object[]
			{
				typeof(global::System.ReadOnlySpan<char>),
				typeof(ref TimeSpanParse.TimeSpanResult)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpanParse.TimeSpanRawInfo), Member = "AddNum", MemberParameters = new object[]
			{
				"System.Globalization.TimeSpanParse.TimeSpanToken",
				typeof(ref TimeSpanParse.TimeSpanResult)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Globalization.TimeSpanParse.TimeSpanResult", Member = "SetFailure", MemberParameters = new object[]
			{
				"System.Globalization.TimeSpanParse.ParseFailureKind",
				typeof(string),
				typeof(object),
				typeof(string)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal bool ProcessToken(ref TimeSpanParse.TimeSpanToken tok, ref TimeSpanParse.TimeSpanResult result)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002B5F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BE9C58", Offset = "0x1BE9C58", Length = "0x10C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanParse.TimeSpanRawInfo), Member = "ProcessToken", MemberParameters = new object[]
			{
				typeof(ref TimeSpanParse.TimeSpanToken),
				typeof(ref TimeSpanParse.TimeSpanResult)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Globalization.TimeSpanParse.TimeSpanResult", Member = "SetFailure", MemberParameters = new object[]
			{
				"System.Globalization.TimeSpanParse.ParseFailureKind",
				typeof(string),
				typeof(object),
				typeof(string)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			private bool AddSep(global::System.ReadOnlySpan<char> sep, ref TimeSpanParse.TimeSpanResult result)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002B60")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BE9D64", Offset = "0x1BE9D64", Length = "0x110")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanParse.TimeSpanRawInfo), Member = "ProcessToken", MemberParameters = new object[]
			{
				typeof(ref TimeSpanParse.TimeSpanToken),
				typeof(ref TimeSpanParse.TimeSpanResult)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Globalization.TimeSpanParse.TimeSpanResult", Member = "SetFailure", MemberParameters = new object[]
			{
				"System.Globalization.TimeSpanParse.ParseFailureKind",
				typeof(string),
				typeof(object),
				typeof(string)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			private bool AddNum(TimeSpanParse.TimeSpanToken num, ref TimeSpanParse.TimeSpanResult result)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x40017DB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal TimeSpanParse.TTT _lastSeenTTT;

			[global::Cpp2ILInjected.Token(Token = "0x40017DC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
			internal int _tokenCount;

			[global::Cpp2ILInjected.Token(Token = "0x40017DD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			internal int _sepCount;

			[global::Cpp2ILInjected.Token(Token = "0x40017DE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
			internal int _numCount;

			[global::Cpp2ILInjected.Token(Token = "0x40017DF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private TimeSpanFormat.FormatLiterals _posLoc;

			[global::Cpp2ILInjected.Token(Token = "0x40017E0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			private TimeSpanFormat.FormatLiterals _negLoc;

			[global::Cpp2ILInjected.Token(Token = "0x40017E1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
			private bool _posLocInit;

			[global::Cpp2ILInjected.Token(Token = "0x40017E2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x61")]
			private bool _negLocInit;

			[global::Cpp2ILInjected.Token(Token = "0x40017E3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
			private string _fullPosPattern;

			[global::Cpp2ILInjected.Token(Token = "0x40017E4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
			private string _fullNegPattern;

			[global::Cpp2ILInjected.Token(Token = "0x40017E5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
			internal TimeSpanParse.TimeSpanToken _numbers0;

			[global::Cpp2ILInjected.Token(Token = "0x40017E6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
			internal TimeSpanParse.TimeSpanToken _numbers1;

			[global::Cpp2ILInjected.Token(Token = "0x40017E7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
			internal TimeSpanParse.TimeSpanToken _numbers2;

			[global::Cpp2ILInjected.Token(Token = "0x40017E8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
			internal TimeSpanParse.TimeSpanToken _numbers3;

			[global::Cpp2ILInjected.Token(Token = "0x40017E9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
			internal TimeSpanParse.TimeSpanToken _numbers4;

			[global::Cpp2ILInjected.Token(Token = "0x40017EA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
			internal global::System.ReadOnlySpan<char> _literals0;

			[global::Cpp2ILInjected.Token(Token = "0x40017EB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
			internal global::System.ReadOnlySpan<char> _literals1;

			[global::Cpp2ILInjected.Token(Token = "0x40017EC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x138")]
			internal global::System.ReadOnlySpan<char> _literals2;

			[global::Cpp2ILInjected.Token(Token = "0x40017ED")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
			internal global::System.ReadOnlySpan<char> _literals3;

			[global::Cpp2ILInjected.Token(Token = "0x40017EE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
			internal global::System.ReadOnlySpan<char> _literals4;

			[global::Cpp2ILInjected.Token(Token = "0x40017EF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x168")]
			internal global::System.ReadOnlySpan<char> _literals5;
		}

		[global::Cpp2ILInjected.Token(Token = "0x20005A3")]
		private struct TimeSpanResult
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002B61")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BE2F60", Offset = "0x1BE2F60", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal TimeSpanResult(bool throwOnFailure)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002B62")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BE32E4", Offset = "0x1BE32E4", Length = "0x128")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Globalization.TimeSpanParse.TimeSpanRawInfo", Member = "ProcessToken", MemberParameters = new object[]
			{
				typeof(ref TimeSpanParse.TimeSpanToken),
				typeof(ref TimeSpanParse.TimeSpanResult)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Globalization.TimeSpanParse.TimeSpanRawInfo", Member = "AddSep", MemberParameters = new object[]
			{
				typeof(global::System.ReadOnlySpan<char>),
				typeof(ref TimeSpanParse.TimeSpanResult)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Globalization.TimeSpanParse.TimeSpanRawInfo", Member = "AddNum", MemberParameters = new object[]
			{
				"System.Globalization.TimeSpanParse.TimeSpanToken",
				typeof(ref TimeSpanParse.TimeSpanResult)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Globalization.TimeSpanParse.StringParser", Member = "TryParse", MemberParameters = new object[]
			{
				typeof(global::System.ReadOnlySpan<char>),
				typeof(ref TimeSpanParse.TimeSpanResult)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Globalization.TimeSpanParse.StringParser", Member = "ParseInt", MemberParameters = new object[]
			{
				typeof(int),
				typeof(ref int),
				typeof(ref TimeSpanParse.TimeSpanResult)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Globalization.TimeSpanParse.StringParser", Member = "ParseTime", MemberParameters = new object[]
			{
				typeof(ref long),
				typeof(ref TimeSpanParse.TimeSpanResult)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanParse), Member = "TryParseTimeSpan", MemberParameters = new object[]
			{
				typeof(global::System.ReadOnlySpan<char>),
				"System.Globalization.TimeSpanParse.TimeSpanStandardStyles",
				typeof(global::System.IFormatProvider),
				typeof(ref TimeSpanParse.TimeSpanResult)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminalState", MemberParameters = new object[]
			{
				typeof(ref TimeSpanParse.TimeSpanRawInfo),
				"System.Globalization.TimeSpanParse.TimeSpanStandardStyles",
				typeof(ref TimeSpanParse.TimeSpanResult)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_DHMSF", MemberParameters = new object[]
			{
				typeof(ref TimeSpanParse.TimeSpanRawInfo),
				"System.Globalization.TimeSpanParse.TimeSpanStandardStyles",
				typeof(ref TimeSpanParse.TimeSpanResult)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HMS_F_D", MemberParameters = new object[]
			{
				typeof(ref TimeSpanParse.TimeSpanRawInfo),
				"System.Globalization.TimeSpanParse.TimeSpanStandardStyles",
				typeof(ref TimeSpanParse.TimeSpanResult)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HM_S_D", MemberParameters = new object[]
			{
				typeof(ref TimeSpanParse.TimeSpanRawInfo),
				"System.Globalization.TimeSpanParse.TimeSpanStandardStyles",
				typeof(ref TimeSpanParse.TimeSpanResult)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HM", MemberParameters = new object[]
			{
				typeof(ref TimeSpanParse.TimeSpanRawInfo),
				"System.Globalization.TimeSpanParse.TimeSpanStandardStyles",
				typeof(ref TimeSpanParse.TimeSpanResult)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_D", MemberParameters = new object[]
			{
				typeof(ref TimeSpanParse.TimeSpanRawInfo),
				"System.Globalization.TimeSpanParse.TimeSpanStandardStyles",
				typeof(ref TimeSpanParse.TimeSpanResult)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanParse), Member = "TryParseExactTimeSpan", MemberParameters = new object[]
			{
				typeof(global::System.ReadOnlySpan<char>),
				typeof(global::System.ReadOnlySpan<char>),
				typeof(global::System.IFormatProvider),
				typeof(TimeSpanStyles),
				typeof(ref TimeSpanParse.TimeSpanResult)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanParse), Member = "TryParseByFormat", MemberParameters = new object[]
			{
				typeof(global::System.ReadOnlySpan<char>),
				typeof(global::System.ReadOnlySpan<char>),
				typeof(TimeSpanStyles),
				typeof(ref TimeSpanParse.TimeSpanResult)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 15)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.OverflowException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.FormatException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
			internal bool SetFailure(TimeSpanParse.ParseFailureKind kind, string resourceKey, object messageArgument = null, string argumentName = null)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x40017F0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal global::System.TimeSpan parsedTimeSpan;

			[global::Cpp2ILInjected.Token(Token = "0x40017F1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			private readonly bool _throwOnFailure;
		}

		[global::Cpp2ILInjected.Token(Token = "0x20005A4")]
		private ref struct StringParser
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002B63")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BE9E74", Offset = "0x1BE9E74", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal void NextChar()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002B64")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BE9EA8", Offset = "0x1BE9EA8", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal char NextNonDigit()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002B65")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BE98AC", Offset = "0x1BE98AC", Length = "0x2B8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanParse), Member = "TryParseExactTimeSpan", MemberParameters = new object[]
			{
				typeof(global::System.ReadOnlySpan<char>),
				typeof(global::System.ReadOnlySpan<char>),
				typeof(global::System.IFormatProvider),
				typeof(TimeSpanStyles),
				typeof(ref TimeSpanParse.TimeSpanResult)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanParse), Member = "TryParseTimeSpanConstant", MemberParameters = new object[]
			{
				typeof(global::System.ReadOnlySpan<char>),
				typeof(ref TimeSpanParse.TimeSpanResult)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpanParse.StringParser), Member = "ParseTime", MemberParameters = new object[]
			{
				typeof(ref long),
				typeof(ref TimeSpanParse.TimeSpanResult)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpanParse.StringParser), Member = "ParseInt", MemberParameters = new object[]
			{
				typeof(int),
				typeof(ref int),
				typeof(ref TimeSpanParse.TimeSpanResult)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Globalization.TimeSpanParse.TimeSpanResult", Member = "SetFailure", MemberParameters = new object[]
			{
				"System.Globalization.TimeSpanParse.ParseFailureKind",
				typeof(string),
				typeof(object),
				typeof(string)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal bool TryParse(global::System.ReadOnlySpan<char> input, ref TimeSpanParse.TimeSpanResult result)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002B66")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BEA188", Offset = "0x1BEA188", Length = "0x12C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanParse.StringParser), Member = "TryParse", MemberParameters = new object[]
			{
				typeof(global::System.ReadOnlySpan<char>),
				typeof(ref TimeSpanParse.TimeSpanResult)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanParse.StringParser), Member = "ParseTime", MemberParameters = new object[]
			{
				typeof(ref long),
				typeof(ref TimeSpanParse.TimeSpanResult)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Globalization.TimeSpanParse.TimeSpanResult", Member = "SetFailure", MemberParameters = new object[]
			{
				"System.Globalization.TimeSpanParse.ParseFailureKind",
				typeof(string),
				typeof(object),
				typeof(string)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal bool ParseInt(int max, out int i, ref TimeSpanParse.TimeSpanResult result)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002B67")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BE9F30", Offset = "0x1BE9F30", Length = "0x258")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanParse.StringParser), Member = "TryParse", MemberParameters = new object[]
			{
				typeof(global::System.ReadOnlySpan<char>),
				typeof(ref TimeSpanParse.TimeSpanResult)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpanParse.StringParser), Member = "ParseInt", MemberParameters = new object[]
			{
				typeof(int),
				typeof(ref int),
				typeof(ref TimeSpanParse.TimeSpanResult)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Globalization.TimeSpanParse.TimeSpanResult", Member = "SetFailure", MemberParameters = new object[]
			{
				"System.Globalization.TimeSpanParse.ParseFailureKind",
				typeof(string),
				typeof(object),
				typeof(string)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal bool ParseTime(out long time, ref TimeSpanParse.TimeSpanResult result)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002B68")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BE9EE0", Offset = "0x1BE9EE0", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal void SkipBlanks()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x40017F2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private global::System.ReadOnlySpan<char> _str;

			[global::Cpp2ILInjected.Token(Token = "0x40017F3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private char _ch;

			[global::Cpp2ILInjected.Token(Token = "0x40017F4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
			private int _pos;

			[global::Cpp2ILInjected.Token(Token = "0x40017F5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private int _len;
		}
	}
}
