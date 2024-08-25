using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Globalization
{
	[global::Cpp2ILInjected.Token(Token = "0x2000007")]
	internal class FormatProvider
	{
		[global::Cpp2ILInjected.Token(Token = "0x600002F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D5849C", Offset = "0x1D5849C", Length = "0x140")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigNumber), Member = "FormatBigInteger", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(BigInteger),
			typeof(string),
			typeof(ReadOnlySpan<char>),
			typeof(NumberFormatInfo),
			typeof(Span<char>),
			typeof(ref int),
			typeof(ref bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatProvider.Number), Member = "ParseFormatSpecifier", MemberParameters = new object[]
		{
			typeof(ReadOnlySpan<char>),
			typeof(ref int)
		}, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatProvider.Number), Member = "NumberToString", MemberParameters = new object[]
		{
			typeof(ref ValueStringBuilder),
			typeof(ref FormatProvider.Number.NumberBuffer),
			typeof(char),
			typeof(int),
			typeof(NumberFormatInfo),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatProvider.Number), Member = "NumberToStringFormat", MemberParameters = new object[]
		{
			typeof(ref ValueStringBuilder),
			typeof(ref FormatProvider.Number.NumberBuffer),
			typeof(ReadOnlySpan<char>),
			typeof(NumberFormatInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal static void FormatBigInteger(ref ValueStringBuilder sb, int precision, int scale, bool sign, ReadOnlySpan<char> format, NumberFormatInfo numberFormatInfo, char[] digits, int startIndex)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000008")]
		private class Number
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000030")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D59BFC", Offset = "0x1D59BFC", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal unsafe static void Int32ToDecChars(char* buffer, ref int index, uint value, int digits)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6000031")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D585E4", Offset = "0x1D585E4", Length = "0x13C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FormatProvider), Member = "FormatBigInteger", MemberParameters = new object[]
			{
				typeof(ref ValueStringBuilder),
				typeof(int),
				typeof(int),
				typeof(bool),
				typeof(ReadOnlySpan<char>),
				typeof(NumberFormatInfo),
				typeof(char[]),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal static char ParseFormatSpecifier(ReadOnlySpan<char> format, out int digits)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6000032")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D58720", Offset = "0x1D58720", Length = "0x4F4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FormatProvider), Member = "FormatBigInteger", MemberParameters = new object[]
			{
				typeof(ref ValueStringBuilder),
				typeof(int),
				typeof(int),
				typeof(bool),
				typeof(ReadOnlySpan<char>),
				typeof(NumberFormatInfo),
				typeof(char[]),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatProvider.Number), Member = "RoundNumber", MemberParameters = new object[]
			{
				typeof(ref FormatProvider.Number.NumberBuffer),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatProvider.Number), Member = "FormatCurrency", MemberParameters = new object[]
			{
				typeof(ref ValueStringBuilder),
				typeof(ref FormatProvider.Number.NumberBuffer),
				typeof(int),
				typeof(int),
				typeof(NumberFormatInfo)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatProvider.Number), Member = "FormatPercent", MemberParameters = new object[]
			{
				typeof(ref ValueStringBuilder),
				typeof(ref FormatProvider.Number.NumberBuffer),
				typeof(int),
				typeof(int),
				typeof(NumberFormatInfo)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatProvider.Number), Member = "FormatNumber", MemberParameters = new object[]
			{
				typeof(ref ValueStringBuilder),
				typeof(ref FormatProvider.Number.NumberBuffer),
				typeof(int),
				typeof(int),
				typeof(NumberFormatInfo)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueStringBuilder), Member = "AppendSlow", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatProvider.Number), Member = "FormatScientific", MemberParameters = new object[]
			{
				typeof(ref ValueStringBuilder),
				typeof(ref FormatProvider.Number.NumberBuffer),
				typeof(int),
				typeof(int),
				typeof(NumberFormatInfo),
				typeof(char)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatProvider.Number), Member = "FormatFixed", MemberParameters = new object[]
			{
				typeof(ref ValueStringBuilder),
				typeof(ref FormatProvider.Number.NumberBuffer),
				typeof(int),
				typeof(int),
				typeof(NumberFormatInfo),
				typeof(int[]),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatProvider.Number), Member = "FormatGeneral", MemberParameters = new object[]
			{
				typeof(ref ValueStringBuilder),
				typeof(ref FormatProvider.Number.NumberBuffer),
				typeof(int),
				typeof(int),
				typeof(NumberFormatInfo),
				typeof(char),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
			internal static void NumberToString(ref ValueStringBuilder sb, ref FormatProvider.Number.NumberBuffer number, char format, int nMaxDigits, NumberFormatInfo info, bool isDecimal)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6000033")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D59D2C", Offset = "0x1D59D2C", Length = "0x22C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FormatProvider.Number), Member = "NumberToString", MemberParameters = new object[]
			{
				typeof(ref ValueStringBuilder),
				typeof(ref FormatProvider.Number.NumberBuffer),
				typeof(char),
				typeof(int),
				typeof(NumberFormatInfo),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrencyGroupSizes", ReturnType = typeof(int[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatProvider.Number), Member = "FormatFixed", MemberParameters = new object[]
			{
				typeof(ref ValueStringBuilder),
				typeof(ref FormatProvider.Number.NumberBuffer),
				typeof(int),
				typeof(int),
				typeof(NumberFormatInfo),
				typeof(int[]),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueStringBuilder), Member = "AppendSlow", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueStringBuilder), Member = "GrowAndAppend", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			private static void FormatCurrency(ref ValueStringBuilder sb, ref FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6000034")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D5ADE4", Offset = "0x1D5ADE4", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private unsafe static int wcslen(char* s)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6000035")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D59F58", Offset = "0x1D59F58", Length = "0x4EC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FormatProvider.Number), Member = "NumberToString", MemberParameters = new object[]
			{
				typeof(ref ValueStringBuilder),
				typeof(ref FormatProvider.Number.NumberBuffer),
				typeof(char),
				typeof(int),
				typeof(NumberFormatInfo),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FormatProvider.Number), Member = "FormatCurrency", MemberParameters = new object[]
			{
				typeof(ref ValueStringBuilder),
				typeof(ref FormatProvider.Number.NumberBuffer),
				typeof(int),
				typeof(int),
				typeof(NumberFormatInfo)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FormatProvider.Number), Member = "FormatNumber", MemberParameters = new object[]
			{
				typeof(ref ValueStringBuilder),
				typeof(ref FormatProvider.Number.NumberBuffer),
				typeof(int),
				typeof(int),
				typeof(NumberFormatInfo)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FormatProvider.Number), Member = "FormatPercent", MemberParameters = new object[]
			{
				typeof(ref ValueStringBuilder),
				typeof(ref FormatProvider.Number.NumberBuffer),
				typeof(int),
				typeof(int),
				typeof(NumberFormatInfo)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueStringBuilder), Member = "Append", MemberParameters = new object[]
			{
				typeof(char*),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueStringBuilder), Member = "Append", MemberParameters = new object[]
			{
				typeof(char),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueStringBuilder), Member = "GrowAndAppend", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueStringBuilder), Member = "AppendSlow", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
			private unsafe static void FormatFixed(ref ValueStringBuilder sb, ref FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, int[] groupDigits, string sDecimal, string sGroup)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6000036")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D5A444", Offset = "0x1D5A444", Length = "0x208")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FormatProvider.Number), Member = "NumberToString", MemberParameters = new object[]
			{
				typeof(ref ValueStringBuilder),
				typeof(ref FormatProvider.Number.NumberBuffer),
				typeof(char),
				typeof(int),
				typeof(NumberFormatInfo),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NumberFormatInfo), Member = "get_NumberGroupSizes", ReturnType = typeof(int[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatProvider.Number), Member = "FormatFixed", MemberParameters = new object[]
			{
				typeof(ref ValueStringBuilder),
				typeof(ref FormatProvider.Number.NumberBuffer),
				typeof(int),
				typeof(int),
				typeof(NumberFormatInfo),
				typeof(int[]),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueStringBuilder), Member = "AppendSlow", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueStringBuilder), Member = "GrowAndAppend", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			private static void FormatNumber(ref ValueStringBuilder sb, ref FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6000037")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D5A64C", Offset = "0x1D5A64C", Length = "0x214")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FormatProvider.Number), Member = "NumberToString", MemberParameters = new object[]
			{
				typeof(ref ValueStringBuilder),
				typeof(ref FormatProvider.Number.NumberBuffer),
				typeof(char),
				typeof(int),
				typeof(NumberFormatInfo),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueStringBuilder), Member = "GrowAndAppend", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueStringBuilder), Member = "AppendSlow", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatProvider.Number), Member = "FormatExponent", MemberParameters = new object[]
			{
				typeof(ref ValueStringBuilder),
				typeof(NumberFormatInfo),
				typeof(int),
				typeof(char),
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			private static void FormatScientific(ref ValueStringBuilder sb, ref FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6000038")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D5AFC0", Offset = "0x1D5AFC0", Length = "0x2C0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FormatProvider.Number), Member = "FormatScientific", MemberParameters = new object[]
			{
				typeof(ref ValueStringBuilder),
				typeof(ref FormatProvider.Number.NumberBuffer),
				typeof(int),
				typeof(int),
				typeof(NumberFormatInfo),
				typeof(char)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FormatProvider.Number), Member = "FormatGeneral", MemberParameters = new object[]
			{
				typeof(ref ValueStringBuilder),
				typeof(ref FormatProvider.Number.NumberBuffer),
				typeof(int),
				typeof(int),
				typeof(NumberFormatInfo),
				typeof(char),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FormatProvider.Number), Member = "NumberToStringFormat", MemberParameters = new object[]
			{
				typeof(ref ValueStringBuilder),
				typeof(ref FormatProvider.Number.NumberBuffer),
				typeof(ReadOnlySpan<char>),
				typeof(NumberFormatInfo)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueStringBuilder), Member = "GrowAndAppend", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueStringBuilder), Member = "AppendSlow", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			private static void FormatExponent(ref ValueStringBuilder sb, NumberFormatInfo info, int value, char expChar, int minDigits, bool positiveSign)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6000039")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D5A860", Offset = "0x1D5A860", Length = "0x354")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FormatProvider.Number), Member = "NumberToString", MemberParameters = new object[]
			{
				typeof(ref ValueStringBuilder),
				typeof(ref FormatProvider.Number.NumberBuffer),
				typeof(char),
				typeof(int),
				typeof(NumberFormatInfo),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueStringBuilder), Member = "GrowAndAppend", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueStringBuilder), Member = "AppendSlow", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatProvider.Number), Member = "FormatExponent", MemberParameters = new object[]
			{
				typeof(ref ValueStringBuilder),
				typeof(NumberFormatInfo),
				typeof(int),
				typeof(char),
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			private static void FormatGeneral(ref ValueStringBuilder sb, ref FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar, bool bSuppressScientific)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600003A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D5ABB4", Offset = "0x1D5ABB4", Length = "0x230")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FormatProvider.Number), Member = "NumberToString", MemberParameters = new object[]
			{
				typeof(ref ValueStringBuilder),
				typeof(ref FormatProvider.Number.NumberBuffer),
				typeof(char),
				typeof(int),
				typeof(NumberFormatInfo),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NumberFormatInfo), Member = "get_PercentGroupSizes", ReturnType = typeof(int[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatProvider.Number), Member = "FormatFixed", MemberParameters = new object[]
			{
				typeof(ref ValueStringBuilder),
				typeof(ref FormatProvider.Number.NumberBuffer),
				typeof(int),
				typeof(int),
				typeof(NumberFormatInfo),
				typeof(int[]),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueStringBuilder), Member = "AppendSlow", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueStringBuilder), Member = "GrowAndAppend", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			private static void FormatPercent(ref ValueStringBuilder sb, ref FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600003B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D59C58", Offset = "0x1D59C58", Length = "0xD4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FormatProvider.Number), Member = "NumberToString", MemberParameters = new object[]
			{
				typeof(ref ValueStringBuilder),
				typeof(ref FormatProvider.Number.NumberBuffer),
				typeof(char),
				typeof(int),
				typeof(NumberFormatInfo),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FormatProvider.Number), Member = "NumberToStringFormat", MemberParameters = new object[]
			{
				typeof(ref ValueStringBuilder),
				typeof(ref FormatProvider.Number.NumberBuffer),
				typeof(ReadOnlySpan<char>),
				typeof(NumberFormatInfo)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
			private static void RoundNumber(ref FormatProvider.Number.NumberBuffer number, int pos)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600003C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D5B280", Offset = "0x1D5B280", Length = "0x134")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FormatProvider.Number), Member = "NumberToStringFormat", MemberParameters = new object[]
			{
				typeof(ref ValueStringBuilder),
				typeof(ref FormatProvider.Number.NumberBuffer),
				typeof(ReadOnlySpan<char>),
				typeof(NumberFormatInfo)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryMarshal[]), Member = "GetReference", MemberTypeParameters = new object[] { typeof(char) }, MemberParameters = new object[] { typeof(ReadOnlySpan<char>) }, ReturnType = "T&")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			private static int FindSection(ReadOnlySpan<char> format, int section)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600003D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D58C14", Offset = "0x1D58C14", Length = "0xFE8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FormatProvider), Member = "FormatBigInteger", MemberParameters = new object[]
			{
				typeof(ref ValueStringBuilder),
				typeof(int),
				typeof(int),
				typeof(bool),
				typeof(ReadOnlySpan<char>),
				typeof(NumberFormatInfo),
				typeof(char[]),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatProvider.Number), Member = "FindSection", MemberParameters = new object[]
			{
				typeof(ReadOnlySpan<char>),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryMarshal[]), Member = "GetReference", MemberTypeParameters = new object[] { typeof(char) }, MemberParameters = new object[] { typeof(ReadOnlySpan<char>) }, ReturnType = "T&")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatProvider.Number), Member = "RoundNumber", MemberParameters = new object[]
			{
				typeof(ref FormatProvider.Number.NumberBuffer),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NumberFormatInfo), Member = "get_NumberGroupSizes", ReturnType = typeof(int[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueStringBuilder), Member = "AppendSlow", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueStringBuilder), Member = "GrowAndAppend", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatProvider.Number), Member = "FormatExponent", MemberParameters = new object[]
			{
				typeof(ref ValueStringBuilder),
				typeof(NumberFormatInfo),
				typeof(int),
				typeof(char),
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Span<int>), Member = "op_Implicit", MemberParameters = new object[] { typeof(int[]) }, ReturnType = "System.Span`1<T>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Span<int>), Member = "CopyTo", MemberParameters = new object[] { typeof(Span<int>) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 31)]
			internal static void NumberToStringFormat(ref ValueStringBuilder sb, ref FormatProvider.Number.NumberBuffer number, ReadOnlySpan<char> format, NumberFormatInfo info)
			{
				throw null;
			}

			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x600003E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D5B3B4", Offset = "0x1D5B3B4", Length = "0x970")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 92)]
			static Number()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4000010")]
			private static string[] s_posCurrencyFormats;

			[global::Cpp2ILInjected.Token(Token = "0x4000011")]
			private static string[] s_negCurrencyFormats;

			[global::Cpp2ILInjected.Token(Token = "0x4000012")]
			private static string[] s_posPercentFormats;

			[global::Cpp2ILInjected.Token(Token = "0x4000013")]
			private static string[] s_negPercentFormats;

			[global::Cpp2ILInjected.Token(Token = "0x4000014")]
			private static string[] s_negNumberFormats;

			[global::Cpp2ILInjected.Token(Token = "0x4000015")]
			private static string s_posNumberFormat;

			[global::Cpp2ILInjected.Token(Token = "0x2000009")]
			internal struct NumberBuffer
			{
				[global::Cpp2ILInjected.Token(Token = "0x17000002")]
				public unsafe char* digits
				{
					[global::Cpp2ILInjected.Token(Token = "0x600003F")]
					[global::Cpp2ILInjected.Address(RVA = "0x1D5BD24", Offset = "0x1D5BD24", Length = "0x8")]
					[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
					get
					{
						throw null;
					}
				}

				[global::Cpp2ILInjected.Token(Token = "0x4000016")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
				public int precision;

				[global::Cpp2ILInjected.Token(Token = "0x4000017")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
				public int scale;

				[global::Cpp2ILInjected.Token(Token = "0x4000018")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
				public bool sign;

				[global::Cpp2ILInjected.Token(Token = "0x4000019")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public unsafe char* overrideDigits;
			}
		}
	}
}
