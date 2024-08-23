using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Globalization
{
	// Token: 0x02000006 RID: 6
	[global::Cpp2ILInjected.Token(Token = "0x2000007")]
	internal class FormatProvider
	{
		// Token: 0x0600002F RID: 47 RVA: 0x000020DA File Offset: 0x000002DA
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

		// Token: 0x02000015 RID: 21
		[global::Cpp2ILInjected.Token(Token = "0x2000008")]
		private class Number
		{
			// Token: 0x0600004A RID: 74 RVA: 0x0000212B File Offset: 0x0000032B
			[global::Cpp2ILInjected.Token(Token = "0x6000030")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D59BFC", Offset = "0x1D59BFC", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal unsafe static void Int32ToDecChars(char* buffer, ref int index, uint value, int digits)
			{
				throw null;
			}

			// Token: 0x0600004B RID: 75 RVA: 0x0000212E File Offset: 0x0000032E
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

			// Token: 0x0600004C RID: 76 RVA: 0x00002131 File Offset: 0x00000331
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

			// Token: 0x0600004D RID: 77 RVA: 0x00002134 File Offset: 0x00000334
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

			// Token: 0x0600004E RID: 78 RVA: 0x00002137 File Offset: 0x00000337
			[global::Cpp2ILInjected.Token(Token = "0x6000034")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D5ADE4", Offset = "0x1D5ADE4", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private unsafe static int wcslen(char* s)
			{
				throw null;
			}

			// Token: 0x0600004F RID: 79 RVA: 0x0000213A File Offset: 0x0000033A
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

			// Token: 0x06000050 RID: 80 RVA: 0x0000213D File Offset: 0x0000033D
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

			// Token: 0x06000051 RID: 81 RVA: 0x00002140 File Offset: 0x00000340
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

			// Token: 0x06000052 RID: 82 RVA: 0x00002143 File Offset: 0x00000343
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

			// Token: 0x06000053 RID: 83 RVA: 0x00002146 File Offset: 0x00000346
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

			// Token: 0x06000054 RID: 84 RVA: 0x00002149 File Offset: 0x00000349
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

			// Token: 0x06000055 RID: 85 RVA: 0x0000214C File Offset: 0x0000034C
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

			// Token: 0x06000056 RID: 86 RVA: 0x0000214F File Offset: 0x0000034F
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

			// Token: 0x06000057 RID: 87 RVA: 0x00002152 File Offset: 0x00000352
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

			// Token: 0x06000058 RID: 88 RVA: 0x00002155 File Offset: 0x00000355
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x600003E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D5B3B4", Offset = "0x1D5B3B4", Length = "0x970")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 92)]
			static Number()
			{
				throw null;
			}

			// Token: 0x04000025 RID: 37
			[global::Cpp2ILInjected.Token(Token = "0x4000010")]
			private static string[] s_posCurrencyFormats;

			// Token: 0x04000026 RID: 38
			[global::Cpp2ILInjected.Token(Token = "0x4000011")]
			private static string[] s_negCurrencyFormats;

			// Token: 0x04000027 RID: 39
			[global::Cpp2ILInjected.Token(Token = "0x4000012")]
			private static string[] s_posPercentFormats;

			// Token: 0x04000028 RID: 40
			[global::Cpp2ILInjected.Token(Token = "0x4000013")]
			private static string[] s_negPercentFormats;

			// Token: 0x04000029 RID: 41
			[global::Cpp2ILInjected.Token(Token = "0x4000014")]
			private static string[] s_negNumberFormats;

			// Token: 0x0400002A RID: 42
			[global::Cpp2ILInjected.Token(Token = "0x4000015")]
			private static string s_posNumberFormat;

			// Token: 0x02000016 RID: 22
			[global::Cpp2ILInjected.Token(Token = "0x2000009")]
			internal struct NumberBuffer
			{
				// Token: 0x17000003 RID: 3
				// (get) Token: 0x06000059 RID: 89 RVA: 0x00002158 File Offset: 0x00000358
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

				// Token: 0x0400002B RID: 43
				[global::Cpp2ILInjected.Token(Token = "0x4000016")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
				public int precision;

				// Token: 0x0400002C RID: 44
				[global::Cpp2ILInjected.Token(Token = "0x4000017")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
				public int scale;

				// Token: 0x0400002D RID: 45
				[global::Cpp2ILInjected.Token(Token = "0x4000018")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
				public bool sign;

				// Token: 0x0400002E RID: 46
				[global::Cpp2ILInjected.Token(Token = "0x4000019")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public unsafe char* overrideDigits;
			}
		}
	}
}
