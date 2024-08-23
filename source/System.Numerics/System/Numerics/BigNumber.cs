using System;
using System.Globalization;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Numerics
{
	// Token: 0x02000004 RID: 4
	[global::Cpp2ILInjected.Token(Token = "0x2000005")]
	internal static class BigNumber
	{
		// Token: 0x06000026 RID: 38 RVA: 0x000020BF File Offset: 0x000002BF
		[global::Cpp2ILInjected.Token(Token = "0x6000026")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D56EC4", Offset = "0x1D56EC4", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal static char ParseFormatSpecifier(ReadOnlySpan<char> format, out int digits)
		{
			throw null;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000020C2 File Offset: 0x000002C2
		[global::Cpp2ILInjected.Token(Token = "0x6000027")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D56FB0", Offset = "0x1D56FB0", Length = "0x5A4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigInteger), Member = "TryGetBytes", MemberParameters = new object[]
		{
			"System.Numerics.BigInteger.GetBytesMode",
			typeof(Span<byte>),
			typeof(bool),
			typeof(bool),
			typeof(ref int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Span<>), Member = "op_Implicit", MemberParameters = new object[] { "T[]" }, ReturnType = "System.Span`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueStringBuilder), Member = "Grow", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueStringBuilder), Member = "Insert", MemberParameters = new object[]
		{
			typeof(int),
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueStringBuilder), Member = "TryCopyTo", MemberParameters = new object[]
		{
			typeof(Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueStringBuilder), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueStringBuilder), Member = "GrowAndAppend", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 30)]
		private static string FormatBigIntegerToHex(bool targetSpan, BigInteger value, char format, int digits, NumberFormatInfo info, Span<char> destination, out int charsWritten, out bool spanSuccess)
		{
			throw null;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000020C5 File Offset: 0x000002C5
		[global::Cpp2ILInjected.Token(Token = "0x6000028")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D55DD4", Offset = "0x1D55DD4", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigNumber), Member = "FormatBigInteger", MemberParameters = new object[]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal static string FormatBigInteger(BigInteger value, string format, NumberFormatInfo info)
		{
			throw null;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000020C8 File Offset: 0x000002C8
		[global::Cpp2ILInjected.Token(Token = "0x6000029")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D57B44", Offset = "0x1D57B44", Length = "0x948")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigNumber), Member = "FormatBigInteger", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(string),
			typeof(NumberFormatInfo)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigNumber), Member = "ParseFormatSpecifier", MemberParameters = new object[]
		{
			typeof(ReadOnlySpan<char>),
			typeof(ref int)
		}, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigNumber), Member = "FormatBigIntegerToHex", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(BigInteger),
			typeof(char),
			typeof(int),
			typeof(NumberFormatInfo),
			typeof(Span<char>),
			typeof(ref int),
			typeof(ref bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatProvider), Member = "FormatBigInteger", MemberParameters = new object[]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueStringBuilder), Member = "TryCopyTo", MemberParameters = new object[]
		{
			typeof(Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueStringBuilder), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "TryFormat", MemberParameters = new object[]
		{
			typeof(Span<char>),
			typeof(ref int),
			typeof(ReadOnlySpan<char>),
			typeof(IFormatProvider)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadOnlySpan<char>), Member = "TryCopyTo", MemberParameters = new object[] { typeof(Span<char>) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 56)]
		private static string FormatBigInteger(bool targetSpan, BigInteger value, string formatString, ReadOnlySpan<char> formatSpan, NumberFormatInfo info, Span<char> destination, out int charsWritten, out bool spanSuccess)
		{
			throw null;
		}
	}
}
