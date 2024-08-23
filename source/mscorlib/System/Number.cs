using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x020000B5 RID: 181
	[global::Cpp2ILInjected.Token(Token = "0x20000E5")]
	internal static class Number
	{
		// Token: 0x060007B4 RID: 1972 RVA: 0x00015B93 File Offset: 0x00013D93
		[global::Cpp2ILInjected.Token(Token = "0x6000859")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C37928", Offset = "0x1C37928", Length = "0x1E0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal), Member = "ToString", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "ParseFormatSpecifier", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(ref int)
		}, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "DecimalToNumber", MemberParameters = new object[]
		{
			typeof(decimal),
			typeof(ref global::System.Number.NumberBuffer)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.ValueStringBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Span<char>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "NumberToString", MemberParameters = new object[]
		{
			typeof(ref global::System.Text.ValueStringBuilder),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(char),
			typeof(int),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "NumberToStringFormat", MemberParameters = new object[]
		{
			typeof(ref global::System.Text.ValueStringBuilder),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.ValueStringBuilder), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static string FormatDecimal(decimal value, global::System.ReadOnlySpan<char> format, global::System.Globalization.NumberFormatInfo info)
		{
			throw null;
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x00015B96 File Offset: 0x00013D96
		[global::Cpp2ILInjected.Token(Token = "0x600085A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C39390", Offset = "0x1C39390", Length = "0x20C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal), Member = "TryFormat", MemberParameters = new object[]
		{
			typeof(global::System.Span<char>),
			typeof(ref int),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "ParseFormatSpecifier", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(ref int)
		}, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "DecimalToNumber", MemberParameters = new object[]
		{
			typeof(decimal),
			typeof(ref global::System.Number.NumberBuffer)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.ValueStringBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Span<char>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "NumberToString", MemberParameters = new object[]
		{
			typeof(ref global::System.Text.ValueStringBuilder),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(char),
			typeof(int),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "NumberToStringFormat", MemberParameters = new object[]
		{
			typeof(ref global::System.Text.ValueStringBuilder),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.ValueStringBuilder), Member = "TryCopyTo", MemberParameters = new object[]
		{
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static bool TryFormatDecimal(decimal value, global::System.ReadOnlySpan<char> format, global::System.Globalization.NumberFormatInfo info, global::System.Span<char> destination, out int charsWritten)
		{
			throw null;
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x00015B99 File Offset: 0x00013D99
		[global::Cpp2ILInjected.Token(Token = "0x600085B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C37C44", Offset = "0x1C37C44", Length = "0x218")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatDecimal", MemberParameters = new object[]
		{
			typeof(decimal),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryFormatDecimal", MemberParameters = new object[]
		{
			typeof(decimal),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number.NumberBuffer), Member = "get_digits", ReturnType = typeof(char*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "get_IsNegative", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number.NumberBuffer), Member = "set_sign", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "DecDivMod1E9", MemberParameters = new object[] { typeof(ref decimal) }, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "get_Scale", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private unsafe static void DecimalToNumber(decimal value, ref global::System.Number.NumberBuffer number)
		{
			throw null;
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x00015B9C File Offset: 0x00013D9C
		[global::Cpp2ILInjected.Token(Token = "0x600085C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C395E8", Offset = "0x1C395E8", Length = "0x160")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(double), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(double), Member = "ToString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(double), Member = "ToString", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(double), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.ValueStringBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Span<char>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "FormatDouble", MemberParameters = new object[]
		{
			typeof(ref global::System.Text.ValueStringBuilder),
			typeof(double),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.ValueStringBuilder), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static string FormatDouble(double value, string format, global::System.Globalization.NumberFormatInfo info)
		{
			throw null;
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x00015B9F File Offset: 0x00013D9F
		[global::Cpp2ILInjected.Token(Token = "0x600085D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C39A0C", Offset = "0x1C39A0C", Length = "0x17C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(double), Member = "TryFormat", MemberParameters = new object[]
		{
			typeof(global::System.Span<char>),
			typeof(ref int),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.ValueStringBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Span<char>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "FormatDouble", MemberParameters = new object[]
		{
			typeof(ref global::System.Text.ValueStringBuilder),
			typeof(double),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "TryCopyTo", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.ValueStringBuilder), Member = "TryCopyTo", MemberParameters = new object[]
		{
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static bool TryFormatDouble(double value, global::System.ReadOnlySpan<char> format, global::System.Globalization.NumberFormatInfo info, global::System.Span<char> destination, out int charsWritten)
		{
			throw null;
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x00015BA2 File Offset: 0x00013DA2
		[global::Cpp2ILInjected.Token(Token = "0x600085E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C39748", Offset = "0x1C39748", Length = "0x2C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatDouble", MemberParameters = new object[]
		{
			typeof(double),
			typeof(string),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryFormatDouble", MemberParameters = new object[]
		{
			typeof(double),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "ParseFormatSpecifier", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(ref int)
		}, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "DoubleToNumber", MemberParameters = new object[]
		{
			typeof(double),
			typeof(int),
			typeof(ref global::System.Number.NumberBuffer)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "NumberToDouble", MemberParameters = new object[] { typeof(ref global::System.Number.NumberBuffer) }, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number.NumberBuffer), Member = "get_sign", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "NumberToStringFormat", MemberParameters = new object[]
		{
			typeof(ref global::System.Text.ValueStringBuilder),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "NumberToString", MemberParameters = new object[]
		{
			typeof(ref global::System.Text.ValueStringBuilder),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(char),
			typeof(int),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private static string FormatDouble(ref global::System.Text.ValueStringBuilder sb, double value, global::System.ReadOnlySpan<char> format, global::System.Globalization.NumberFormatInfo info)
		{
			throw null;
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x00015BA5 File Offset: 0x00013DA5
		[global::Cpp2ILInjected.Token(Token = "0x600085F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C3A550", Offset = "0x1C3A550", Length = "0x160")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(float), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(float), Member = "ToString", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(float), Member = "ToString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(float), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.ValueStringBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Span<char>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "FormatSingle", MemberParameters = new object[]
		{
			typeof(ref global::System.Text.ValueStringBuilder),
			typeof(float),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.ValueStringBuilder), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static string FormatSingle(float value, string format, global::System.Globalization.NumberFormatInfo info)
		{
			throw null;
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x00015BA8 File Offset: 0x00013DA8
		[global::Cpp2ILInjected.Token(Token = "0x6000860")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C3A980", Offset = "0x1C3A980", Length = "0x17C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(float), Member = "TryFormat", MemberParameters = new object[]
		{
			typeof(global::System.Span<char>),
			typeof(ref int),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.ValueStringBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Span<char>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "FormatSingle", MemberParameters = new object[]
		{
			typeof(ref global::System.Text.ValueStringBuilder),
			typeof(float),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "TryCopyTo", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.ValueStringBuilder), Member = "TryCopyTo", MemberParameters = new object[]
		{
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static bool TryFormatSingle(float value, global::System.ReadOnlySpan<char> format, global::System.Globalization.NumberFormatInfo info, global::System.Span<char> destination, out int charsWritten)
		{
			throw null;
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x00015BAB File Offset: 0x00013DAB
		[global::Cpp2ILInjected.Token(Token = "0x6000861")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C3A6B0", Offset = "0x1C3A6B0", Length = "0x2D0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatSingle", MemberParameters = new object[]
		{
			typeof(float),
			typeof(string),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryFormatSingle", MemberParameters = new object[]
		{
			typeof(float),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "ParseFormatSpecifier", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(ref int)
		}, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "DoubleToNumber", MemberParameters = new object[]
		{
			typeof(double),
			typeof(int),
			typeof(ref global::System.Number.NumberBuffer)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "NumberToDouble", MemberParameters = new object[] { typeof(ref global::System.Number.NumberBuffer) }, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number.NumberBuffer), Member = "get_sign", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "NumberToStringFormat", MemberParameters = new object[]
		{
			typeof(ref global::System.Text.ValueStringBuilder),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "NumberToString", MemberParameters = new object[]
		{
			typeof(ref global::System.Text.ValueStringBuilder),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(char),
			typeof(int),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private static string FormatSingle(ref global::System.Text.ValueStringBuilder sb, float value, global::System.ReadOnlySpan<char> format, global::System.Globalization.NumberFormatInfo info)
		{
			throw null;
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x00015BAE File Offset: 0x00013DAE
		[global::Cpp2ILInjected.Token(Token = "0x6000862")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C39B88", Offset = "0x1C39B88", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryFormatDouble", MemberParameters = new object[]
		{
			typeof(double),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryFormatSingle", MemberParameters = new object[]
		{
			typeof(float),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ReadOnlySpan<char>), Member = "TryCopyTo", MemberParameters = new object[] { typeof(global::System.Span<char>) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static bool TryCopyTo(string source, global::System.Span<char> destination, out int charsWritten)
		{
			throw null;
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x00015BB1 File Offset: 0x00013DB1
		[global::Cpp2ILInjected.Token(Token = "0x6000863")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C30B5C", Offset = "0x1C30B5C", Length = "0x3B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(byte), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(byte), Member = "ToString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(byte), Member = "ToString", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(byte), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(short), Member = "ToString", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(short), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(int), Member = "ToString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(int), Member = "ToString", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(int), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(sbyte), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(sbyte), Member = "ToString", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(sbyte), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "ParseFormatSpecifier", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(ref int)
		}, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.NumberFormatInfo), Member = "GetInstance", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(global::System.Globalization.NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "Int32ToHexStr", MemberParameters = new object[]
		{
			typeof(int),
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "UInt32ToDecStr", MemberParameters = new object[]
		{
			typeof(uint),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number.NumberBuffer), Member = "set_sign", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "NegativeInt32ToDecStr", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number.NumberBuffer), Member = "get_digits", ReturnType = typeof(char*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.ValueStringBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Span<char>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "NumberToString", MemberParameters = new object[]
		{
			typeof(ref global::System.Text.ValueStringBuilder),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(char),
			typeof(int),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "NumberToStringFormat", MemberParameters = new object[]
		{
			typeof(ref global::System.Text.ValueStringBuilder),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.ValueStringBuilder), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public unsafe static string FormatInt32(int value, global::System.ReadOnlySpan<char> format, global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060007BF RID: 1983 RVA: 0x00015BB4 File Offset: 0x00013DB4
		[global::Cpp2ILInjected.Token(Token = "0x6000864")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C3197C", Offset = "0x1C3197C", Length = "0x420")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(byte), Member = "TryFormat", MemberParameters = new object[]
		{
			typeof(global::System.Span<char>),
			typeof(ref int),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(short), Member = "TryFormat", MemberParameters = new object[]
		{
			typeof(global::System.Span<char>),
			typeof(ref int),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(int), Member = "TryFormat", MemberParameters = new object[]
		{
			typeof(global::System.Span<char>),
			typeof(ref int),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(sbyte), Member = "TryFormat", MemberParameters = new object[]
		{
			typeof(global::System.Span<char>),
			typeof(ref int),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "ParseFormatSpecifier", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(ref int)
		}, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.NumberFormatInfo), Member = "GetInstance", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(global::System.Globalization.NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "TryInt32ToHexStr", MemberParameters = new object[]
		{
			typeof(int),
			typeof(char),
			typeof(int),
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "TryUInt32ToDecStr", MemberParameters = new object[]
		{
			typeof(uint),
			typeof(int),
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number.NumberBuffer), Member = "set_sign", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "TryNegativeInt32ToDecStr", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(string),
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number.NumberBuffer), Member = "get_digits", ReturnType = typeof(char*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.ValueStringBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Span<char>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "NumberToString", MemberParameters = new object[]
		{
			typeof(ref global::System.Text.ValueStringBuilder),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(char),
			typeof(int),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "NumberToStringFormat", MemberParameters = new object[]
		{
			typeof(ref global::System.Text.ValueStringBuilder),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.ValueStringBuilder), Member = "TryCopyTo", MemberParameters = new object[]
		{
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public unsafe static bool TryFormatInt32(int value, global::System.ReadOnlySpan<char> format, global::System.IFormatProvider provider, global::System.Span<char> destination, out int charsWritten)
		{
			throw null;
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x00015BB7 File Offset: 0x00013DB7
		[global::Cpp2ILInjected.Token(Token = "0x6000865")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C31120", Offset = "0x1C31120", Length = "0x370")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(sbyte), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ushort), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ushort), Member = "ToString", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ushort), Member = "ToString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ushort), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(uint), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(uint), Member = "ToString", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(uint), Member = "ToString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(uint), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "ParseFormatSpecifier", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(ref int)
		}, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.NumberFormatInfo), Member = "GetInstance", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(global::System.Globalization.NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "Int32ToHexStr", MemberParameters = new object[]
		{
			typeof(int),
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "UInt32ToDecStr", MemberParameters = new object[]
		{
			typeof(uint),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number.NumberBuffer), Member = "set_sign", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number.NumberBuffer), Member = "get_digits", ReturnType = typeof(char*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.ValueStringBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Span<char>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "NumberToString", MemberParameters = new object[]
		{
			typeof(ref global::System.Text.ValueStringBuilder),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(char),
			typeof(int),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "NumberToStringFormat", MemberParameters = new object[]
		{
			typeof(ref global::System.Text.ValueStringBuilder),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.ValueStringBuilder), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public unsafe static string FormatUInt32(uint value, global::System.ReadOnlySpan<char> format, global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060007C1 RID: 1985 RVA: 0x00015BBA File Offset: 0x00013DBA
		[global::Cpp2ILInjected.Token(Token = "0x6000866")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C315A4", Offset = "0x1C315A4", Length = "0x3D8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(sbyte), Member = "TryFormat", MemberParameters = new object[]
		{
			typeof(global::System.Span<char>),
			typeof(ref int),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ushort), Member = "TryFormat", MemberParameters = new object[]
		{
			typeof(global::System.Span<char>),
			typeof(ref int),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(uint), Member = "TryFormat", MemberParameters = new object[]
		{
			typeof(global::System.Span<char>),
			typeof(ref int),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "ParseFormatSpecifier", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(ref int)
		}, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.NumberFormatInfo), Member = "GetInstance", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(global::System.Globalization.NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "TryInt32ToHexStr", MemberParameters = new object[]
		{
			typeof(int),
			typeof(char),
			typeof(int),
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "TryUInt32ToDecStr", MemberParameters = new object[]
		{
			typeof(uint),
			typeof(int),
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number.NumberBuffer), Member = "set_sign", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number.NumberBuffer), Member = "get_digits", ReturnType = typeof(char*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.ValueStringBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Span<char>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "NumberToString", MemberParameters = new object[]
		{
			typeof(ref global::System.Text.ValueStringBuilder),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(char),
			typeof(int),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "NumberToStringFormat", MemberParameters = new object[]
		{
			typeof(ref global::System.Text.ValueStringBuilder),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.ValueStringBuilder), Member = "TryCopyTo", MemberParameters = new object[]
		{
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public unsafe static bool TryFormatUInt32(uint value, global::System.ReadOnlySpan<char> format, global::System.IFormatProvider provider, global::System.Span<char> destination, out int charsWritten)
		{
			throw null;
		}

		// Token: 0x060007C2 RID: 1986 RVA: 0x00015BBD File Offset: 0x00013DBD
		[global::Cpp2ILInjected.Token(Token = "0x6000867")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C33DFC", Offset = "0x1C33DFC", Length = "0x2C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(long), Member = "ToString", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(long), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "ParseFormatSpecifier", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(ref int)
		}, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.NumberFormatInfo), Member = "GetInstance", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(global::System.Globalization.NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "Int64ToHexStr", MemberParameters = new object[]
		{
			typeof(long),
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "UInt64ToDecStr", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "Int64ToNumber", MemberParameters = new object[]
		{
			typeof(long),
			typeof(ref global::System.Number.NumberBuffer)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.ValueStringBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Span<char>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "NumberToString", MemberParameters = new object[]
		{
			typeof(ref global::System.Text.ValueStringBuilder),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(char),
			typeof(int),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "NegativeInt64ToDecStr", MemberParameters = new object[]
		{
			typeof(long),
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "NumberToStringFormat", MemberParameters = new object[]
		{
			typeof(ref global::System.Text.ValueStringBuilder),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.ValueStringBuilder), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public static string FormatInt64(long value, global::System.ReadOnlySpan<char> format, global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060007C3 RID: 1987 RVA: 0x00015BC0 File Offset: 0x00013DC0
		[global::Cpp2ILInjected.Token(Token = "0x6000868")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C342A8", Offset = "0x1C342A8", Length = "0x324")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "ParseFormatSpecifier", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(ref int)
		}, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.NumberFormatInfo), Member = "GetInstance", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(global::System.Globalization.NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "TryInt64ToHexStr", MemberParameters = new object[]
		{
			typeof(long),
			typeof(char),
			typeof(int),
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "TryUInt64ToDecStr", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(int),
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "Int64ToNumber", MemberParameters = new object[]
		{
			typeof(long),
			typeof(ref global::System.Number.NumberBuffer)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.ValueStringBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Span<char>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "NumberToString", MemberParameters = new object[]
		{
			typeof(ref global::System.Text.ValueStringBuilder),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(char),
			typeof(int),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "TryNegativeInt64ToDecStr", MemberParameters = new object[]
		{
			typeof(long),
			typeof(int),
			typeof(string),
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "NumberToStringFormat", MemberParameters = new object[]
		{
			typeof(ref global::System.Text.ValueStringBuilder),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.ValueStringBuilder), Member = "TryCopyTo", MemberParameters = new object[]
		{
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public static bool TryFormatInt64(long value, global::System.ReadOnlySpan<char> format, global::System.IFormatProvider provider, global::System.Span<char> destination, out int charsWritten)
		{
			throw null;
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x00015BC3 File Offset: 0x00013DC3
		[global::Cpp2ILInjected.Token(Token = "0x6000869")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C3C448", Offset = "0x1C3C448", Length = "0x290")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ulong), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ulong), Member = "ToString", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ulong), Member = "ToString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ulong), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "ParseFormatSpecifier", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(ref int)
		}, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.NumberFormatInfo), Member = "GetInstance", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(global::System.Globalization.NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "Int64ToHexStr", MemberParameters = new object[]
		{
			typeof(long),
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "UInt64ToDecStr", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "UInt64ToNumber", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(ref global::System.Number.NumberBuffer)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.ValueStringBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Span<char>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "NumberToString", MemberParameters = new object[]
		{
			typeof(ref global::System.Text.ValueStringBuilder),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(char),
			typeof(int),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "NumberToStringFormat", MemberParameters = new object[]
		{
			typeof(ref global::System.Text.ValueStringBuilder),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.ValueStringBuilder), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public static string FormatUInt64(ulong value, global::System.ReadOnlySpan<char> format, global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x00015BC6 File Offset: 0x00013DC6
		[global::Cpp2ILInjected.Token(Token = "0x600086A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C3C86C", Offset = "0x1C3C86C", Length = "0x2DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ulong), Member = "TryFormat", MemberParameters = new object[]
		{
			typeof(global::System.Span<char>),
			typeof(ref int),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "ParseFormatSpecifier", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(ref int)
		}, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.NumberFormatInfo), Member = "GetInstance", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(global::System.Globalization.NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "TryInt64ToHexStr", MemberParameters = new object[]
		{
			typeof(long),
			typeof(char),
			typeof(int),
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "TryUInt64ToDecStr", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(int),
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "UInt64ToNumber", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(ref global::System.Number.NumberBuffer)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.ValueStringBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Span<char>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "NumberToString", MemberParameters = new object[]
		{
			typeof(ref global::System.Text.ValueStringBuilder),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(char),
			typeof(int),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "NumberToStringFormat", MemberParameters = new object[]
		{
			typeof(ref global::System.Text.ValueStringBuilder),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.ValueStringBuilder), Member = "TryCopyTo", MemberParameters = new object[]
		{
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public static bool TryFormatUInt64(ulong value, global::System.ReadOnlySpan<char> format, global::System.IFormatProvider provider, global::System.Span<char> destination, out int charsWritten)
		{
			throw null;
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x00015BC9 File Offset: 0x00013DC9
		[global::Cpp2ILInjected.Token(Token = "0x600086B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C3CB48", Offset = "0x1C3CB48", Length = "0x12C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number.NumberBuffer), Member = "set_sign", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number.NumberBuffer), Member = "get_digits", ReturnType = typeof(char*))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(256)]
		private unsafe static void Int32ToNumber(int value, ref global::System.Number.NumberBuffer number)
		{
			throw null;
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x00015BCC File Offset: 0x00013DCC
		[global::Cpp2ILInjected.Token(Token = "0x600086C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C3AC8C", Offset = "0x1C3AC8C", Length = "0x1A4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatInt32", MemberParameters = new object[]
		{
			typeof(int),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "FastAllocateString", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static string NegativeInt32ToDecStr(int value, int digits, string sNegative)
		{
			throw null;
		}

		// Token: 0x060007C8 RID: 1992 RVA: 0x00015BCF File Offset: 0x00013DCF
		[global::Cpp2ILInjected.Token(Token = "0x600086D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C3B12C", Offset = "0x1C3B12C", Length = "0x1E0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryFormatInt32", MemberParameters = new object[]
		{
			typeof(int),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider),
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.MemoryMarshal[]), Member = "GetReference", MemberTypeParameters = new object[] { typeof(char) }, MemberParameters = new object[] { typeof(global::System.Span<char>) }, ReturnType = "T&")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static bool TryNegativeInt32ToDecStr(int value, int digits, string sNegative, global::System.Span<char> destination, out int charsWritten)
		{
			throw null;
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x00015BD2 File Offset: 0x00013DD2
		[global::Cpp2ILInjected.Token(Token = "0x600086E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C3AE30", Offset = "0x1C3AE30", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatInt32", MemberParameters = new object[]
		{
			typeof(int),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatUInt32", MemberParameters = new object[]
		{
			typeof(uint),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "FastAllocateString", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static string Int32ToHexStr(int value, char hexBase, int digits)
		{
			throw null;
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x00015BD5 File Offset: 0x00013DD5
		[global::Cpp2ILInjected.Token(Token = "0x600086F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C3B30C", Offset = "0x1C3B30C", Length = "0x174")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryFormatInt32", MemberParameters = new object[]
		{
			typeof(int),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider),
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryFormatUInt32", MemberParameters = new object[]
		{
			typeof(uint),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider),
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.MemoryMarshal[]), Member = "GetReference", MemberTypeParameters = new object[] { typeof(char) }, MemberParameters = new object[] { typeof(global::System.Span<char>) }, ReturnType = "T&")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static bool TryInt32ToHexStr(int value, char hexBase, int digits, global::System.Span<char> destination, out int charsWritten)
		{
			throw null;
		}

		// Token: 0x060007CB RID: 1995 RVA: 0x00015BD8 File Offset: 0x00013DD8
		[global::Cpp2ILInjected.Token(Token = "0x6000870")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C3CC74", Offset = "0x1C3CC74", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private unsafe static char* Int32ToHexChars(char* buffer, uint value, int hexBase, int digits)
		{
			throw null;
		}

		// Token: 0x060007CC RID: 1996 RVA: 0x00015BDB File Offset: 0x00013DDB
		[global::Cpp2ILInjected.Token(Token = "0x6000871")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C3CCB4", Offset = "0x1C3CCB4", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number.NumberBuffer), Member = "set_sign", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number.NumberBuffer), Member = "get_digits", ReturnType = typeof(char*))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(256)]
		private unsafe static void UInt32ToNumber(uint value, ref global::System.Number.NumberBuffer number)
		{
			throw null;
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x00015BDE File Offset: 0x00013DDE
		[global::Cpp2ILInjected.Token(Token = "0x6000872")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C3959C", Offset = "0x1C3959C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal unsafe static char* UInt32ToDecChars(char* bufferEnd, uint value, int digits)
		{
			throw null;
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x00015BE1 File Offset: 0x00013DE1
		[global::Cpp2ILInjected.Token(Token = "0x6000873")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C3AAFC", Offset = "0x1C3AAFC", Length = "0x190")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatInt32", MemberParameters = new object[]
		{
			typeof(int),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatUInt32", MemberParameters = new object[]
		{
			typeof(uint),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "FastAllocateString", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static string UInt32ToDecStr(uint value, int digits)
		{
			throw null;
		}

		// Token: 0x060007CF RID: 1999 RVA: 0x00015BE4 File Offset: 0x00013DE4
		[global::Cpp2ILInjected.Token(Token = "0x6000874")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C3AF68", Offset = "0x1C3AF68", Length = "0x1C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryFormatInt32", MemberParameters = new object[]
		{
			typeof(int),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider),
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryFormatUInt32", MemberParameters = new object[]
		{
			typeof(uint),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider),
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.MemoryMarshal[]), Member = "GetReference", MemberTypeParameters = new object[] { typeof(char) }, MemberParameters = new object[] { typeof(global::System.Span<char>) }, ReturnType = "T&")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static bool TryUInt32ToDecStr(uint value, int digits, global::System.Span<char> destination, out int charsWritten)
		{
			throw null;
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x00015BE7 File Offset: 0x00013DE7
		[global::Cpp2ILInjected.Token(Token = "0x6000875")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C3BB5C", Offset = "0x1C3BB5C", Length = "0x1A8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatInt64", MemberParameters = new object[]
		{
			typeof(long),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryFormatInt64", MemberParameters = new object[]
		{
			typeof(long),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider),
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number.NumberBuffer), Member = "set_sign", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number.NumberBuffer), Member = "get_sign", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number.NumberBuffer), Member = "get_digits", ReturnType = typeof(char*))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private unsafe static void Int64ToNumber(long input, ref global::System.Number.NumberBuffer number)
		{
			throw null;
		}

		// Token: 0x060007D1 RID: 2001 RVA: 0x00015BEA File Offset: 0x00013DEA
		[global::Cpp2ILInjected.Token(Token = "0x6000876")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C3B6D8", Offset = "0x1C3B6D8", Length = "0x298")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatInt64", MemberParameters = new object[]
		{
			typeof(long),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "FastAllocateString", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static string NegativeInt64ToDecStr(long input, int digits, string sNegative)
		{
			throw null;
		}

		// Token: 0x060007D2 RID: 2002 RVA: 0x00015BED File Offset: 0x00013DED
		[global::Cpp2ILInjected.Token(Token = "0x6000877")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C3BF88", Offset = "0x1C3BF88", Length = "0x2BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryFormatInt64", MemberParameters = new object[]
		{
			typeof(long),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider),
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.MemoryMarshal[]), Member = "GetReference", MemberTypeParameters = new object[] { typeof(char) }, MemberParameters = new object[] { typeof(global::System.Span<char>) }, ReturnType = "T&")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private static bool TryNegativeInt64ToDecStr(long input, int digits, string sNegative, global::System.Span<char> destination, out int charsWritten)
		{
			throw null;
		}

		// Token: 0x060007D3 RID: 2003 RVA: 0x00015BF0 File Offset: 0x00013DF0
		[global::Cpp2ILInjected.Token(Token = "0x6000878")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C3B970", Offset = "0x1C3B970", Length = "0x1EC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatInt64", MemberParameters = new object[]
		{
			typeof(long),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatUInt64", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "FastAllocateString", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static string Int64ToHexStr(long value, char hexBase, int digits)
		{
			throw null;
		}

		// Token: 0x060007D4 RID: 2004 RVA: 0x00015BF3 File Offset: 0x00013DF3
		[global::Cpp2ILInjected.Token(Token = "0x6000879")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C3C244", Offset = "0x1C3C244", Length = "0x204")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryFormatInt64", MemberParameters = new object[]
		{
			typeof(long),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider),
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryFormatUInt64", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider),
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.MemoryMarshal[]), Member = "GetReference", MemberTypeParameters = new object[] { typeof(char) }, MemberParameters = new object[] { typeof(global::System.Span<char>) }, ReturnType = "T&")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private static bool TryInt64ToHexStr(long value, char hexBase, int digits, global::System.Span<char> destination, out int charsWritten)
		{
			throw null;
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x00015BF6 File Offset: 0x00013DF6
		[global::Cpp2ILInjected.Token(Token = "0x600087A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C3C6D8", Offset = "0x1C3C6D8", Length = "0x194")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatUInt64", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryFormatUInt64", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider),
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number.NumberBuffer), Member = "set_sign", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number.NumberBuffer), Member = "get_digits", ReturnType = typeof(char*))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private unsafe static void UInt64ToNumber(ulong value, ref global::System.Number.NumberBuffer number)
		{
			throw null;
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x00015BF9 File Offset: 0x00013DF9
		[global::Cpp2ILInjected.Token(Token = "0x600087B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C3B480", Offset = "0x1C3B480", Length = "0x258")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatInt64", MemberParameters = new object[]
		{
			typeof(long),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatUInt64", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "FastAllocateString", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static string UInt64ToDecStr(ulong value, int digits)
		{
			throw null;
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x00015BFC File Offset: 0x00013DFC
		[global::Cpp2ILInjected.Token(Token = "0x600087C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C3BD04", Offset = "0x1C3BD04", Length = "0x284")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryFormatInt64", MemberParameters = new object[]
		{
			typeof(long),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider),
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryFormatUInt64", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider),
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.MemoryMarshal[]), Member = "GetReference", MemberTypeParameters = new object[] { typeof(char) }, MemberParameters = new object[] { typeof(global::System.Span<char>) }, ReturnType = "T&")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private static bool TryUInt64ToDecStr(ulong value, int digits, global::System.Span<char> destination, out int charsWritten)
		{
			throw null;
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x00015BFF File Offset: 0x00013DFF
		[global::Cpp2ILInjected.Token(Token = "0x600087D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C37B08", Offset = "0x1C37B08", Length = "0x13C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatDecimal", MemberParameters = new object[]
		{
			typeof(decimal),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryFormatDecimal", MemberParameters = new object[]
		{
			typeof(decimal),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatDouble", MemberParameters = new object[]
		{
			typeof(ref global::System.Text.ValueStringBuilder),
			typeof(double),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatSingle", MemberParameters = new object[]
		{
			typeof(ref global::System.Text.ValueStringBuilder),
			typeof(float),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatInt32", MemberParameters = new object[]
		{
			typeof(int),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryFormatInt32", MemberParameters = new object[]
		{
			typeof(int),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider),
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatUInt32", MemberParameters = new object[]
		{
			typeof(uint),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryFormatUInt32", MemberParameters = new object[]
		{
			typeof(uint),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider),
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatInt64", MemberParameters = new object[]
		{
			typeof(long),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryFormatInt64", MemberParameters = new object[]
		{
			typeof(long),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider),
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatUInt64", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryFormatUInt64", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider),
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal static char ParseFormatSpecifier(global::System.ReadOnlySpan<char> format, out int digits)
		{
			throw null;
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x00015C02 File Offset: 0x00013E02
		[global::Cpp2ILInjected.Token(Token = "0x600087E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C37E5C", Offset = "0x1C37E5C", Length = "0x52C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatDecimal", MemberParameters = new object[]
		{
			typeof(decimal),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryFormatDecimal", MemberParameters = new object[]
		{
			typeof(decimal),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatDouble", MemberParameters = new object[]
		{
			typeof(ref global::System.Text.ValueStringBuilder),
			typeof(double),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatSingle", MemberParameters = new object[]
		{
			typeof(ref global::System.Text.ValueStringBuilder),
			typeof(float),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatInt32", MemberParameters = new object[]
		{
			typeof(int),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryFormatInt32", MemberParameters = new object[]
		{
			typeof(int),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider),
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatUInt32", MemberParameters = new object[]
		{
			typeof(uint),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryFormatUInt32", MemberParameters = new object[]
		{
			typeof(uint),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider),
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatInt64", MemberParameters = new object[]
		{
			typeof(long),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryFormatInt64", MemberParameters = new object[]
		{
			typeof(long),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider),
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatUInt64", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryFormatUInt64", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider),
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "RoundNumber", MemberParameters = new object[]
		{
			typeof(ref global::System.Number.NumberBuffer),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "FormatCurrency", MemberParameters = new object[]
		{
			typeof(ref global::System.Text.ValueStringBuilder),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(int),
			typeof(int),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number.NumberBuffer), Member = "get_sign", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number.NumberBuffer), Member = "get_digits", ReturnType = typeof(char*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number.NumberBuffer), Member = "set_sign", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "FormatPercent", MemberParameters = new object[]
		{
			typeof(ref global::System.Text.ValueStringBuilder),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(int),
			typeof(int),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "FormatNumber", MemberParameters = new object[]
		{
			typeof(ref global::System.Text.ValueStringBuilder),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(int),
			typeof(int),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.ValueStringBuilder), Member = "AppendSlow", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "FormatScientific", MemberParameters = new object[]
		{
			typeof(ref global::System.Text.ValueStringBuilder),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(int),
			typeof(int),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(char)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "FormatFixed", MemberParameters = new object[]
		{
			typeof(ref global::System.Text.ValueStringBuilder),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(int),
			typeof(int),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(int[]),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "FormatGeneral", MemberParameters = new object[]
		{
			typeof(ref global::System.Text.ValueStringBuilder),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(int),
			typeof(int),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(char),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.FormatException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		internal unsafe static void NumberToString(ref global::System.Text.ValueStringBuilder sb, ref global::System.Number.NumberBuffer number, char format, int nMaxDigits, global::System.Globalization.NumberFormatInfo info, bool isDecimal)
		{
			throw null;
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x00015C05 File Offset: 0x00013E05
		[global::Cpp2ILInjected.Token(Token = "0x600087F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C38388", Offset = "0x1C38388", Length = "0x1008")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatDecimal", MemberParameters = new object[]
		{
			typeof(decimal),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryFormatDecimal", MemberParameters = new object[]
		{
			typeof(decimal),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatDouble", MemberParameters = new object[]
		{
			typeof(ref global::System.Text.ValueStringBuilder),
			typeof(double),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatSingle", MemberParameters = new object[]
		{
			typeof(ref global::System.Text.ValueStringBuilder),
			typeof(float),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatInt32", MemberParameters = new object[]
		{
			typeof(int),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryFormatInt32", MemberParameters = new object[]
		{
			typeof(int),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider),
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatUInt32", MemberParameters = new object[]
		{
			typeof(uint),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryFormatUInt32", MemberParameters = new object[]
		{
			typeof(uint),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider),
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatInt64", MemberParameters = new object[]
		{
			typeof(long),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryFormatInt64", MemberParameters = new object[]
		{
			typeof(long),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider),
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatUInt64", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryFormatUInt64", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider),
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number.NumberBuffer), Member = "get_digits", ReturnType = typeof(char*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number.NumberBuffer), Member = "get_sign", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "FindSection", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.MemoryMarshal[]), Member = "GetReference", MemberTypeParameters = new object[] { typeof(char) }, MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = "T&")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "RoundNumber", MemberParameters = new object[]
		{
			typeof(ref global::System.Number.NumberBuffer),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number.NumberBuffer), Member = "set_sign", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Span<int>), Member = "op_Implicit", MemberParameters = new object[] { typeof(int[]) }, ReturnType = "System.Span`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Span<int>), Member = "CopyTo", MemberParameters = new object[] { typeof(global::System.Span<int>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.ValueStringBuilder), Member = "AppendSlow", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.ValueStringBuilder), Member = "GrowAndAppend", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "FormatExponent", MemberParameters = new object[]
		{
			typeof(ref global::System.Text.ValueStringBuilder),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(int),
			typeof(char),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 31)]
		internal unsafe static void NumberToStringFormat(ref global::System.Text.ValueStringBuilder sb, ref global::System.Number.NumberBuffer number, global::System.ReadOnlySpan<char> format, global::System.Globalization.NumberFormatInfo info)
		{
			throw null;
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x00015C08 File Offset: 0x00013E08
		[global::Cpp2ILInjected.Token(Token = "0x6000880")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C3CF10", Offset = "0x1C3CF10", Length = "0x234")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "NumberToString", MemberParameters = new object[]
		{
			typeof(ref global::System.Text.ValueStringBuilder),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(char),
			typeof(int),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number.NumberBuffer), Member = "get_sign", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "FormatFixed", MemberParameters = new object[]
		{
			typeof(ref global::System.Text.ValueStringBuilder),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(int),
			typeof(int),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(int[]),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.ValueStringBuilder), Member = "AppendSlow", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.ValueStringBuilder), Member = "GrowAndAppend", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static void FormatCurrency(ref global::System.Text.ValueStringBuilder sb, ref global::System.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, global::System.Globalization.NumberFormatInfo info)
		{
			throw null;
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x00015C0B File Offset: 0x00013E0B
		[global::Cpp2ILInjected.Token(Token = "0x6000881")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C3D144", Offset = "0x1C3D144", Length = "0x504")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "NumberToString", MemberParameters = new object[]
		{
			typeof(ref global::System.Text.ValueStringBuilder),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(char),
			typeof(int),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatCurrency", MemberParameters = new object[]
		{
			typeof(ref global::System.Text.ValueStringBuilder),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(int),
			typeof(int),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatNumber", MemberParameters = new object[]
		{
			typeof(ref global::System.Text.ValueStringBuilder),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(int),
			typeof(int),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatPercent", MemberParameters = new object[]
		{
			typeof(ref global::System.Text.ValueStringBuilder),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(int),
			typeof(int),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number.NumberBuffer), Member = "get_digits", ReturnType = typeof(char*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.ValueStringBuilder), Member = "GrowAndAppend", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "wcslen", MemberParameters = new object[] { typeof(char*) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.ValueStringBuilder), Member = "Grow", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.MemoryMarshal[]), Member = "GetReference", MemberTypeParameters = new object[] { typeof(char) }, MemberParameters = new object[] { typeof(global::System.Span<char>) }, ReturnType = "T&")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.ValueStringBuilder), Member = "AppendSlow", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.ValueStringBuilder), Member = "Append", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		private unsafe static void FormatFixed(ref global::System.Text.ValueStringBuilder sb, ref global::System.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, global::System.Globalization.NumberFormatInfo info, int[] groupDigits, string sDecimal, string sGroup)
		{
			throw null;
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x00015C0E File Offset: 0x00013E0E
		[global::Cpp2ILInjected.Token(Token = "0x6000882")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C3D648", Offset = "0x1C3D648", Length = "0x218")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "NumberToString", MemberParameters = new object[]
		{
			typeof(ref global::System.Text.ValueStringBuilder),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(char),
			typeof(int),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number.NumberBuffer), Member = "get_sign", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "FormatFixed", MemberParameters = new object[]
		{
			typeof(ref global::System.Text.ValueStringBuilder),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(int),
			typeof(int),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(int[]),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.ValueStringBuilder), Member = "AppendSlow", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.ValueStringBuilder), Member = "GrowAndAppend", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static void FormatNumber(ref global::System.Text.ValueStringBuilder sb, ref global::System.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, global::System.Globalization.NumberFormatInfo info)
		{
			throw null;
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x00015C11 File Offset: 0x00013E11
		[global::Cpp2ILInjected.Token(Token = "0x6000883")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C3D860", Offset = "0x1C3D860", Length = "0x230")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "NumberToString", MemberParameters = new object[]
		{
			typeof(ref global::System.Text.ValueStringBuilder),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(char),
			typeof(int),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number.NumberBuffer), Member = "get_digits", ReturnType = typeof(char*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.ValueStringBuilder), Member = "GrowAndAppend", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.ValueStringBuilder), Member = "AppendSlow", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "FormatExponent", MemberParameters = new object[]
		{
			typeof(ref global::System.Text.ValueStringBuilder),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(int),
			typeof(char),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private unsafe static void FormatScientific(ref global::System.Text.ValueStringBuilder sb, ref global::System.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, global::System.Globalization.NumberFormatInfo info, char expChar)
		{
			throw null;
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x00015C14 File Offset: 0x00013E14
		[global::Cpp2ILInjected.Token(Token = "0x6000884")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C3E180", Offset = "0x1C3E180", Length = "0x278")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "NumberToStringFormat", MemberParameters = new object[]
		{
			typeof(ref global::System.Text.ValueStringBuilder),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatScientific", MemberParameters = new object[]
		{
			typeof(ref global::System.Text.ValueStringBuilder),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(int),
			typeof(int),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(char)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatGeneral", MemberParameters = new object[]
		{
			typeof(ref global::System.Text.ValueStringBuilder),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(int),
			typeof(int),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(char),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.ValueStringBuilder), Member = "GrowAndAppend", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.ValueStringBuilder), Member = "AppendSlow", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.ValueStringBuilder), Member = "Append", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private unsafe static void FormatExponent(ref global::System.Text.ValueStringBuilder sb, global::System.Globalization.NumberFormatInfo info, int value, char expChar, int minDigits, bool positiveSign)
		{
			throw null;
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x00015C17 File Offset: 0x00013E17
		[global::Cpp2ILInjected.Token(Token = "0x6000885")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C3DA90", Offset = "0x1C3DA90", Length = "0x384")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "NumberToString", MemberParameters = new object[]
		{
			typeof(ref global::System.Text.ValueStringBuilder),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(char),
			typeof(int),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number.NumberBuffer), Member = "get_digits", ReturnType = typeof(char*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.ValueStringBuilder), Member = "GrowAndAppend", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.ValueStringBuilder), Member = "AppendSlow", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "FormatExponent", MemberParameters = new object[]
		{
			typeof(ref global::System.Text.ValueStringBuilder),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(int),
			typeof(char),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private unsafe static void FormatGeneral(ref global::System.Text.ValueStringBuilder sb, ref global::System.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, global::System.Globalization.NumberFormatInfo info, char expChar, bool bSuppressScientific)
		{
			throw null;
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x00015C1A File Offset: 0x00013E1A
		[global::Cpp2ILInjected.Token(Token = "0x6000886")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C3DE14", Offset = "0x1C3DE14", Length = "0x238")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "NumberToString", MemberParameters = new object[]
		{
			typeof(ref global::System.Text.ValueStringBuilder),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(char),
			typeof(int),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number.NumberBuffer), Member = "get_sign", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "FormatFixed", MemberParameters = new object[]
		{
			typeof(ref global::System.Text.ValueStringBuilder),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(int),
			typeof(int),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(int[]),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.ValueStringBuilder), Member = "AppendSlow", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.ValueStringBuilder), Member = "GrowAndAppend", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static void FormatPercent(ref global::System.Text.ValueStringBuilder sb, ref global::System.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, global::System.Globalization.NumberFormatInfo info)
		{
			throw null;
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x00015C1D File Offset: 0x00013E1D
		[global::Cpp2ILInjected.Token(Token = "0x6000887")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C3CE10", Offset = "0x1C3CE10", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "NumberToString", MemberParameters = new object[]
		{
			typeof(ref global::System.Text.ValueStringBuilder),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(char),
			typeof(int),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "NumberToStringFormat", MemberParameters = new object[]
		{
			typeof(ref global::System.Text.ValueStringBuilder),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number.NumberBuffer), Member = "get_digits", ReturnType = typeof(char*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number.NumberBuffer), Member = "set_sign", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		private unsafe static void RoundNumber(ref global::System.Number.NumberBuffer number, int pos)
		{
			throw null;
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x00015C20 File Offset: 0x00013E20
		[global::Cpp2ILInjected.Token(Token = "0x6000888")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C3E04C", Offset = "0x1C3E04C", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "NumberToStringFormat", MemberParameters = new object[]
		{
			typeof(ref global::System.Text.ValueStringBuilder),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.MemoryMarshal[]), Member = "GetReference", MemberTypeParameters = new object[] { typeof(char) }, MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = "T&")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static int FindSection(global::System.ReadOnlySpan<char> format, int section)
		{
			throw null;
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x00015C23 File Offset: 0x00013E23
		[global::Cpp2ILInjected.Token(Token = "0x6000889")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C3CE0C", Offset = "0x1C3CE0C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static uint Low32(ulong value)
		{
			throw null;
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x00015C26 File Offset: 0x00013E26
		[global::Cpp2ILInjected.Token(Token = "0x600088A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C3CE04", Offset = "0x1C3CE04", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static uint High32(ulong value)
		{
			throw null;
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x00015C29 File Offset: 0x00013E29
		[global::Cpp2ILInjected.Token(Token = "0x600088B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C3CDCC", Offset = "0x1C3CDCC", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static uint Int64DivMod1E9(ref ulong value)
		{
			throw null;
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x00015C2C File Offset: 0x00013E2C
		[global::Cpp2ILInjected.Token(Token = "0x600088C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C3E3F8", Offset = "0x1C3E3F8", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "ParseInt32", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryParseInt32", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number.NumberBuffer), Member = "get_digits", ReturnType = typeof(char*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number.NumberBuffer), Member = "get_sign", ReturnType = typeof(bool))]
		private unsafe static bool NumberToInt32(ref global::System.Number.NumberBuffer number, ref int value)
		{
			throw null;
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x00015C2F File Offset: 0x00013E2F
		[global::Cpp2ILInjected.Token(Token = "0x600088D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C3E4B4", Offset = "0x1C3E4B4", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "ParseInt64", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryParseInt64", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(ref long)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number.NumberBuffer), Member = "get_digits", ReturnType = typeof(char*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number.NumberBuffer), Member = "get_sign", ReturnType = typeof(bool))]
		private unsafe static bool NumberToInt64(ref global::System.Number.NumberBuffer number, ref long value)
		{
			throw null;
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x00015C32 File Offset: 0x00013E32
		[global::Cpp2ILInjected.Token(Token = "0x600088E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C3E568", Offset = "0x1C3E568", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "ParseUInt32", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryParseUInt32", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(ref uint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number.NumberBuffer), Member = "get_sign", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number.NumberBuffer), Member = "get_digits", ReturnType = typeof(char*))]
		private unsafe static bool NumberToUInt32(ref global::System.Number.NumberBuffer number, ref uint value)
		{
			throw null;
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x00015C35 File Offset: 0x00013E35
		[global::Cpp2ILInjected.Token(Token = "0x600088F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C3E618", Offset = "0x1C3E618", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "ParseUInt64", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryParseUInt64", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(ref ulong)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number.NumberBuffer), Member = "get_sign", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number.NumberBuffer), Member = "get_digits", ReturnType = typeof(char*))]
		private unsafe static bool NumberToUInt64(ref global::System.Number.NumberBuffer number, ref ulong value)
		{
			throw null;
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x00015C38 File Offset: 0x00013E38
		[global::Cpp2ILInjected.Token(Token = "0x6000890")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C32068", Offset = "0x1C32068", Length = "0x1D8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(byte), Member = "Parse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(short), Member = "Parse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(int), Member = "Parse", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(int), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Globalization.NumberStyles)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(int), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(int), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(int), Member = "Parse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(sbyte), Member = "Parse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(sbyte))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "StringToNumber", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "NumberToInt32", MemberParameters = new object[]
		{
			typeof(ref global::System.Number.NumberBuffer),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "ThrowOverflowOrFormatException", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "TryParseInt32IntegerStyle", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(ref int),
			typeof(ref bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "TryParseUInt32HexNumberStyle", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(ref uint),
			typeof(ref bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		internal static int ParseInt32(global::System.ReadOnlySpan<char> value, global::System.Globalization.NumberStyles styles, global::System.Globalization.NumberFormatInfo info)
		{
			throw null;
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x00015C3B File Offset: 0x00013E3B
		[global::Cpp2ILInjected.Token(Token = "0x6000891")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C3468C", Offset = "0x1C3468C", Length = "0x1DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(long), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(long), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "StringToNumber", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "NumberToInt64", MemberParameters = new object[]
		{
			typeof(ref global::System.Number.NumberBuffer),
			typeof(ref long)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "ThrowOverflowOrFormatException", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "TryParseInt64IntegerStyle", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(ref long),
			typeof(ref bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "TryParseUInt64HexNumberStyle", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(ref ulong),
			typeof(ref bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		internal static long ParseInt64(global::System.ReadOnlySpan<char> value, global::System.Globalization.NumberStyles styles, global::System.Globalization.NumberFormatInfo info)
		{
			throw null;
		}

		// Token: 0x060007ED RID: 2029 RVA: 0x00015C3E File Offset: 0x00013E3E
		[global::Cpp2ILInjected.Token(Token = "0x6000892")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C3FDFC", Offset = "0x1C3FDFC", Length = "0x1B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ushort), Member = "Parse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(uint), Member = "Parse", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(uint), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(uint), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "StringToNumber", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "NumberToUInt32", MemberParameters = new object[]
		{
			typeof(ref global::System.Number.NumberBuffer),
			typeof(ref uint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "ThrowOverflowOrFormatException", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "TryParseUInt32IntegerStyle", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(ref uint),
			typeof(ref bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "TryParseUInt32HexNumberStyle", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(ref uint),
			typeof(ref bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		internal static uint ParseUInt32(global::System.ReadOnlySpan<char> value, global::System.Globalization.NumberStyles styles, global::System.Globalization.NumberFormatInfo info)
		{
			throw null;
		}

		// Token: 0x060007EE RID: 2030 RVA: 0x00015C41 File Offset: 0x00013E41
		[global::Cpp2ILInjected.Token(Token = "0x6000893")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C40738", Offset = "0x1C40738", Length = "0x1B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ulong), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ulong), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "StringToNumber", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "NumberToUInt64", MemberParameters = new object[]
		{
			typeof(ref global::System.Number.NumberBuffer),
			typeof(ref ulong)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "ThrowOverflowOrFormatException", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "TryParseUInt64IntegerStyle", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(ref ulong),
			typeof(ref bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "TryParseUInt64HexNumberStyle", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(ref ulong),
			typeof(ref bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		internal static ulong ParseUInt64(global::System.ReadOnlySpan<char> value, global::System.Globalization.NumberStyles styles, global::System.Globalization.NumberFormatInfo info)
		{
			throw null;
		}

		// Token: 0x060007EF RID: 2031 RVA: 0x00015C44 File Offset: 0x00013E44
		[global::Cpp2ILInjected.Token(Token = "0x6000894")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C41080", Offset = "0x1C41080", Length = "0x6F8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "StringToNumber", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryStringToNumber", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number.NumberBuffer), Member = "set_sign", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "MatchChars", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*),
			typeof(string)
		}, ReturnType = typeof(char*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number.NumberBuffer), Member = "get_digits", ReturnType = typeof(char*))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		private unsafe static bool ParseNumber(ref char* str, char* strEnd, global::System.Globalization.NumberStyles styles, ref global::System.Number.NumberBuffer number, global::System.Globalization.NumberFormatInfo info, bool parseDecimal)
		{
			throw null;
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x00015C47 File Offset: 0x00013E47
		[global::Cpp2ILInjected.Token(Token = "0x6000895")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C323AC", Offset = "0x1C323AC", Length = "0x18C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(byte), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(ref byte)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(short), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(ref short)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(int), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(int), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(int), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.IFormatProvider),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(int), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.IFormatProvider),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(sbyte), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(ref sbyte)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "TryStringToNumber", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "NumberToInt32", MemberParameters = new object[]
		{
			typeof(ref global::System.Number.NumberBuffer),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "TryParseInt32IntegerStyle", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(ref int),
			typeof(ref bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "TryParseUInt32HexNumberStyle", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(ref uint),
			typeof(ref bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal static bool TryParseInt32(global::System.ReadOnlySpan<char> value, global::System.Globalization.NumberStyles styles, global::System.Globalization.NumberFormatInfo info, out int result)
		{
			throw null;
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x00015C4A File Offset: 0x00013E4A
		[global::Cpp2ILInjected.Token(Token = "0x6000896")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C3E6C8", Offset = "0x1C3E6C8", Length = "0x78C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsInvalidInstructions]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "ParseInt32", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryParseInt32", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SpanHelpers), Member = "SequenceEqual", MemberParameters = new object[]
		{
			typeof(ref byte),
			typeof(ref byte),
			typeof(ulong)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "TrailingZeros", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		private static bool TryParseInt32IntegerStyle(global::System.ReadOnlySpan<char> value, global::System.Globalization.NumberStyles styles, global::System.Globalization.NumberFormatInfo info, out int result, ref bool failureIsOverflow)
		{
			throw null;
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x00015C4D File Offset: 0x00013E4D
		[global::Cpp2ILInjected.Token(Token = "0x6000897")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C3F33C", Offset = "0x1C3F33C", Length = "0x798")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsInvalidInstructions]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "ParseInt64", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryParseInt64", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(ref long)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SpanHelpers), Member = "SequenceEqual", MemberParameters = new object[]
		{
			typeof(ref byte),
			typeof(ref byte),
			typeof(ulong)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "TrailingZeros", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		private static bool TryParseInt64IntegerStyle(global::System.ReadOnlySpan<char> value, global::System.Globalization.NumberStyles styles, global::System.Globalization.NumberFormatInfo info, out long result, ref bool failureIsOverflow)
		{
			throw null;
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x00015C50 File Offset: 0x00013E50
		[global::Cpp2ILInjected.Token(Token = "0x6000898")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C34AE8", Offset = "0x1C34AE8", Length = "0x18C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(long), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.IFormatProvider),
			typeof(ref long)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "TryStringToNumber", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "NumberToInt64", MemberParameters = new object[]
		{
			typeof(ref global::System.Number.NumberBuffer),
			typeof(ref long)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "TryParseInt64IntegerStyle", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(ref long),
			typeof(ref bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "TryParseUInt64HexNumberStyle", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(ref ulong),
			typeof(ref bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal static bool TryParseInt64(global::System.ReadOnlySpan<char> value, global::System.Globalization.NumberStyles styles, global::System.Globalization.NumberFormatInfo info, out long result)
		{
			throw null;
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x00015C53 File Offset: 0x00013E53
		[global::Cpp2ILInjected.Token(Token = "0x6000899")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C419C8", Offset = "0x1C419C8", Length = "0x18C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ushort), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(ref ushort)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(uint), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.IFormatProvider),
			typeof(ref uint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "TryStringToNumber", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "NumberToUInt32", MemberParameters = new object[]
		{
			typeof(ref global::System.Number.NumberBuffer),
			typeof(ref uint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "TryParseUInt32IntegerStyle", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(ref uint),
			typeof(ref bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "TryParseUInt32HexNumberStyle", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(ref uint),
			typeof(ref bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal static bool TryParseUInt32(global::System.ReadOnlySpan<char> value, global::System.Globalization.NumberStyles styles, global::System.Globalization.NumberFormatInfo info, out uint result)
		{
			throw null;
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x00015C56 File Offset: 0x00013E56
		[global::Cpp2ILInjected.Token(Token = "0x600089A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C3FFB4", Offset = "0x1C3FFB4", Length = "0x784")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsInvalidInstructions]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "ParseUInt32", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryParseUInt32", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(ref uint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SpanHelpers), Member = "SequenceEqual", MemberParameters = new object[]
		{
			typeof(ref byte),
			typeof(ref byte),
			typeof(ulong)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "TrailingZeros", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		private static bool TryParseUInt32IntegerStyle(global::System.ReadOnlySpan<char> value, global::System.Globalization.NumberStyles styles, global::System.Globalization.NumberFormatInfo info, out uint result, ref bool failureIsOverflow)
		{
			throw null;
		}

		// Token: 0x060007F6 RID: 2038 RVA: 0x00015C59 File Offset: 0x00013E59
		[global::Cpp2ILInjected.Token(Token = "0x600089B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C3EEDC", Offset = "0x1C3EEDC", Length = "0x328")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "ParseInt32", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "ParseUInt32", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryParseInt32", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryParseUInt32", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(ref uint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "TrailingZeros", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private static bool TryParseUInt32HexNumberStyle(global::System.ReadOnlySpan<char> value, global::System.Globalization.NumberStyles styles, global::System.Globalization.NumberFormatInfo info, out uint result, ref bool failureIsOverflow)
		{
			throw null;
		}

		// Token: 0x060007F7 RID: 2039 RVA: 0x00015C5C File Offset: 0x00013E5C
		[global::Cpp2ILInjected.Token(Token = "0x600089C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C41B54", Offset = "0x1C41B54", Length = "0x18C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ulong), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.IFormatProvider),
			typeof(ref ulong)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "TryStringToNumber", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "NumberToUInt64", MemberParameters = new object[]
		{
			typeof(ref global::System.Number.NumberBuffer),
			typeof(ref ulong)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "TryParseUInt64IntegerStyle", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(ref ulong),
			typeof(ref bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "TryParseUInt64HexNumberStyle", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(ref ulong),
			typeof(ref bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal static bool TryParseUInt64(global::System.ReadOnlySpan<char> value, global::System.Globalization.NumberStyles styles, global::System.Globalization.NumberFormatInfo info, out ulong result)
		{
			throw null;
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x00015C5F File Offset: 0x00013E5F
		[global::Cpp2ILInjected.Token(Token = "0x600089D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C408F0", Offset = "0x1C408F0", Length = "0x790")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsInvalidInstructions]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "ParseUInt64", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryParseUInt64", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(ref ulong)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SpanHelpers), Member = "SequenceEqual", MemberParameters = new object[]
		{
			typeof(ref byte),
			typeof(ref byte),
			typeof(ulong)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "TrailingZeros", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		private static bool TryParseUInt64IntegerStyle(global::System.ReadOnlySpan<char> value, global::System.Globalization.NumberStyles styles, global::System.Globalization.NumberFormatInfo info, out ulong result, ref bool failureIsOverflow)
		{
			throw null;
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x00015C62 File Offset: 0x00013E62
		[global::Cpp2ILInjected.Token(Token = "0x600089E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C3FAD4", Offset = "0x1C3FAD4", Length = "0x328")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "ParseInt64", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "ParseUInt64", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryParseInt64", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(ref long)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryParseUInt64", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(ref ulong)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "TrailingZeros", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private static bool TryParseUInt64HexNumberStyle(global::System.ReadOnlySpan<char> value, global::System.Globalization.NumberStyles styles, global::System.Globalization.NumberFormatInfo info, out ulong result, ref bool failureIsOverflow)
		{
			throw null;
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x00015C65 File Offset: 0x00013E65
		[global::Cpp2ILInjected.Token(Token = "0x600089F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C41CE0", Offset = "0x1C41CE0", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "StringToNumber", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "NumberBufferToDecimal", MemberParameters = new object[]
		{
			typeof(ref global::System.Number.NumberBuffer),
			typeof(ref decimal)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "ThrowOverflowOrFormatException", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal static decimal ParseDecimal(global::System.ReadOnlySpan<char> value, global::System.Globalization.NumberStyles styles, global::System.Globalization.NumberFormatInfo info)
		{
			throw null;
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x00015C68 File Offset: 0x00013E68
		[global::Cpp2ILInjected.Token(Token = "0x60008A0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C41DE8", Offset = "0x1C41DE8", Length = "0x2D8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "ParseDecimal", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryParseDecimal", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(ref decimal)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number.NumberBuffer), Member = "get_digits", ReturnType = typeof(char*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number.NumberBuffer), Member = "get_sign", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private unsafe static bool NumberBufferToDecimal(ref global::System.Number.NumberBuffer number, ref decimal value)
		{
			throw null;
		}

		// Token: 0x060007FC RID: 2044 RVA: 0x00015C6B File Offset: 0x00013E6B
		[global::Cpp2ILInjected.Token(Token = "0x60008A1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C420C0", Offset = "0x1C420C0", Length = "0x528")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(double), Member = "Parse", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(double), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(double), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "TryStringToNumber", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "NumberBufferToDouble", MemberParameters = new object[]
		{
			typeof(ref global::System.Number.NumberBuffer),
			typeof(ref double)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MemoryExtensions), Member = "TrimStart", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = typeof(global::System.ReadOnlySpan<char>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MemoryExtensions), Member = "TrimEnd", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = typeof(global::System.ReadOnlySpan<char>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SpanHelpers), Member = "SequenceEqual", MemberParameters = new object[]
		{
			typeof(ref byte),
			typeof(ref byte),
			typeof(ulong)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "ThrowOverflowOrFormatException", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		internal static double ParseDouble(global::System.ReadOnlySpan<char> value, global::System.Globalization.NumberStyles styles, global::System.Globalization.NumberFormatInfo info)
		{
			throw null;
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x00015C6E File Offset: 0x00013E6E
		[global::Cpp2ILInjected.Token(Token = "0x60008A2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C426B8", Offset = "0x1C426B8", Length = "0x598")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(float), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(float), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "TryStringToNumber", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "NumberBufferToDouble", MemberParameters = new object[]
		{
			typeof(ref global::System.Number.NumberBuffer),
			typeof(ref double)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "ThrowOverflowOrFormatException", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MemoryExtensions), Member = "TrimStart", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = typeof(global::System.ReadOnlySpan<char>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MemoryExtensions), Member = "TrimEnd", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = typeof(global::System.ReadOnlySpan<char>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SpanHelpers), Member = "SequenceEqual", MemberParameters = new object[]
		{
			typeof(ref byte),
			typeof(ref byte),
			typeof(ulong)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		internal static float ParseSingle(global::System.ReadOnlySpan<char> value, global::System.Globalization.NumberStyles styles, global::System.Globalization.NumberFormatInfo info)
		{
			throw null;
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x00015C71 File Offset: 0x00013E71
		[global::Cpp2ILInjected.Token(Token = "0x60008A3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C42C50", Offset = "0x1C42C50", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.IFormatProvider),
			typeof(ref decimal)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "TryStringToNumber", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "NumberBufferToDecimal", MemberParameters = new object[]
		{
			typeof(ref global::System.Number.NumberBuffer),
			typeof(ref decimal)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal static bool TryParseDecimal(global::System.ReadOnlySpan<char> value, global::System.Globalization.NumberStyles styles, global::System.Globalization.NumberFormatInfo info, out decimal result)
		{
			throw null;
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x00015C74 File Offset: 0x00013E74
		[global::Cpp2ILInjected.Token(Token = "0x60008A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C42D54", Offset = "0x1C42D54", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(double), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(ref double)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "TryStringToNumber", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "NumberBufferToDouble", MemberParameters = new object[]
		{
			typeof(ref global::System.Number.NumberBuffer),
			typeof(ref double)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal static bool TryParseDouble(global::System.ReadOnlySpan<char> value, global::System.Globalization.NumberStyles styles, global::System.Globalization.NumberFormatInfo info, out double result)
		{
			throw null;
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x00015C77 File Offset: 0x00013E77
		[global::Cpp2ILInjected.Token(Token = "0x60008A5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C42E58", Offset = "0x1C42E58", Length = "0x174")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(float), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(ref float)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "TryStringToNumber", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "NumberBufferToDouble", MemberParameters = new object[]
		{
			typeof(ref global::System.Number.NumberBuffer),
			typeof(ref double)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal static bool TryParseSingle(global::System.ReadOnlySpan<char> value, global::System.Globalization.NumberStyles styles, global::System.Globalization.NumberFormatInfo info, out float result)
		{
			throw null;
		}

		// Token: 0x06000801 RID: 2049 RVA: 0x00015C7A File Offset: 0x00013E7A
		[global::Cpp2ILInjected.Token(Token = "0x60008A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C3F204", Offset = "0x1C3F204", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "ParseInt32", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "ParseInt64", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "ParseUInt32", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "ParseUInt64", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "ParseDecimal", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.MemoryMarshal[]), Member = "GetReference", MemberTypeParameters = new object[] { typeof(char) }, MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = "T&")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "ParseNumber", MemberParameters = new object[]
		{
			typeof(ref char*),
			typeof(char*),
			typeof(global::System.Globalization.NumberStyles),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "TrailingZeros", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "ThrowOverflowOrFormatException", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private unsafe static void StringToNumber(global::System.ReadOnlySpan<char> value, global::System.Globalization.NumberStyles styles, ref global::System.Number.NumberBuffer number, global::System.Globalization.NumberFormatInfo info, bool parseDecimal)
		{
			throw null;
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x00015C7D File Offset: 0x00013E7D
		[global::Cpp2ILInjected.Token(Token = "0x60008A7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C41828", Offset = "0x1C41828", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryParseInt32", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryParseInt64", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(ref long)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryParseUInt32", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(ref uint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryParseUInt64", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(ref ulong)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "ParseDouble", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "ParseSingle", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryParseDecimal", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(ref decimal)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryParseDouble", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(ref double)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryParseSingle", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(ref float)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.MemoryMarshal[]), Member = "GetReference", MemberTypeParameters = new object[] { typeof(char) }, MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = "T&")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "ParseNumber", MemberParameters = new object[]
		{
			typeof(ref char*),
			typeof(char*),
			typeof(global::System.Globalization.NumberStyles),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "TrailingZeros", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal unsafe static bool TryStringToNumber(global::System.ReadOnlySpan<char> value, global::System.Globalization.NumberStyles styles, ref global::System.Number.NumberBuffer number, global::System.Globalization.NumberFormatInfo info, bool parseDecimal)
		{
			throw null;
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x00015C80 File Offset: 0x00013E80
		[global::Cpp2ILInjected.Token(Token = "0x60008A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C41958", Offset = "0x1C41958", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryParseInt32IntegerStyle", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(ref int),
			typeof(ref bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryParseInt64IntegerStyle", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(ref long),
			typeof(ref bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryParseUInt32IntegerStyle", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(ref uint),
			typeof(ref bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryParseUInt32HexNumberStyle", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(ref uint),
			typeof(ref bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryParseUInt64IntegerStyle", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(ref ulong),
			typeof(ref bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryParseUInt64HexNumberStyle", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(ref ulong),
			typeof(ref bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "StringToNumber", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryStringToNumber", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private static bool TrailingZeros(global::System.ReadOnlySpan<char> value, int index)
		{
			throw null;
		}

		// Token: 0x06000804 RID: 2052 RVA: 0x00015C83 File Offset: 0x00013E83
		[global::Cpp2ILInjected.Token(Token = "0x60008A9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C41794", Offset = "0x1C41794", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "ParseNumber", MemberParameters = new object[]
		{
			typeof(ref char*),
			typeof(char*),
			typeof(global::System.Globalization.NumberStyles),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		private unsafe static char* MatchChars(char* p, char* pEnd, string value)
		{
			throw null;
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x00015C86 File Offset: 0x00013E86
		[global::Cpp2ILInjected.Token(Token = "0x60008AA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C41778", Offset = "0x1C41778", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static bool IsWhite(int ch)
		{
			throw null;
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x00015C89 File Offset: 0x00013E89
		[global::Cpp2ILInjected.Token(Token = "0x60008AB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C41818", Offset = "0x1C41818", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static bool IsDigit(int ch)
		{
			throw null;
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x00015C8C File Offset: 0x00013E8C
		[global::Cpp2ILInjected.Token(Token = "0x60008AC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C3EE54", Offset = "0x1C3EE54", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "ParseInt32", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "ParseInt64", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "ParseUInt32", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "ParseUInt64", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "ParseDecimal", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "ParseDouble", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "ParseSingle", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "StringToNumber", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.OverflowException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.FormatException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private static void ThrowOverflowOrFormatException(bool overflow, string overflowResourceKey)
		{
			throw null;
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x00015C8F File Offset: 0x00013E8F
		[global::Cpp2ILInjected.Token(Token = "0x60008AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C425E8", Offset = "0x1C425E8", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "ParseDouble", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "ParseSingle", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryParseDouble", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(ref double)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryParseSingle", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(ref float)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "NumberToDouble", MemberParameters = new object[] { typeof(ref global::System.Number.NumberBuffer) }, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static bool NumberBufferToDouble(ref global::System.Number.NumberBuffer number, ref double value)
		{
			throw null;
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x00015C92 File Offset: 0x00013E92
		[global::Cpp2ILInjected.Token(Token = "0x60008AE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C42FCC", Offset = "0x1C42FCC", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private unsafe static uint DigitsToInt(char* p, int count)
		{
			throw null;
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x00015C95 File Offset: 0x00013E95
		[global::Cpp2ILInjected.Token(Token = "0x60008AF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C43000", Offset = "0x1C43000", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static ulong Mul32x32To64(uint a, uint b)
		{
			throw null;
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x00015C98 File Offset: 0x00013E98
		[global::Cpp2ILInjected.Token(Token = "0x60008B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C43008", Offset = "0x1C43008", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "NumberToDouble", MemberParameters = new object[] { typeof(ref global::System.Number.NumberBuffer) }, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static ulong Mul64Lossy(ulong a, ulong b, ref int pexp)
		{
			throw null;
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x00015C9B File Offset: 0x00013E9B
		[global::Cpp2ILInjected.Token(Token = "0x60008B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C430A0", Offset = "0x1C430A0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static int abs(int value)
		{
			throw null;
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x00015C9E File Offset: 0x00013E9E
		[global::Cpp2ILInjected.Token(Token = "0x60008B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C3A0D8", Offset = "0x1C3A0D8", Length = "0x478")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatDouble", MemberParameters = new object[]
		{
			typeof(ref global::System.Text.ValueStringBuilder),
			typeof(double),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatSingle", MemberParameters = new object[]
		{
			typeof(ref global::System.Text.ValueStringBuilder),
			typeof(float),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "NumberBufferToDouble", MemberParameters = new object[]
		{
			typeof(ref global::System.Number.NumberBuffer),
			typeof(ref double)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number.NumberBuffer), Member = "get_digits", ReturnType = typeof(char*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "wcslen", MemberParameters = new object[] { typeof(char*) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "Mul64Lossy", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(ulong),
			typeof(ref int)
		}, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number.NumberBuffer), Member = "get_sign", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private unsafe static double NumberToDouble(ref global::System.Number.NumberBuffer number)
		{
			throw null;
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x00015CA1 File Offset: 0x00013EA1
		[global::Cpp2ILInjected.Token(Token = "0x60008B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C39C5C", Offset = "0x1C39C5C", Length = "0x47C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatDouble", MemberParameters = new object[]
		{
			typeof(ref global::System.Text.ValueStringBuilder),
			typeof(double),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatSingle", MemberParameters = new object[]
		{
			typeof(ref global::System.Text.ValueStringBuilder),
			typeof(float),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number.NumberBuffer), Member = "set_sign", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number.NumberBuffer), Member = "get_digits", ReturnType = typeof(char*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Interop.Sys), Member = "DoubleToString", MemberParameters = new object[]
		{
			typeof(double),
			typeof(byte*),
			typeof(byte*),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private unsafe static void DoubleToNumber(double value, int precision, ref global::System.Number.NumberBuffer number)
		{
			throw null;
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x00015CA4 File Offset: 0x00013EA4
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60008B4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C430AC", Offset = "0x1C430AC", Length = "0xAEC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(global::System.RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 105)]
		static Number()
		{
			throw null;
		}

		// Token: 0x04000222 RID: 546
		[global::Cpp2ILInjected.Token(Token = "0x400036F")]
		private static readonly string[] s_posCurrencyFormats;

		// Token: 0x04000223 RID: 547
		[global::Cpp2ILInjected.Token(Token = "0x4000370")]
		private static readonly string[] s_negCurrencyFormats;

		// Token: 0x04000224 RID: 548
		[global::Cpp2ILInjected.Token(Token = "0x4000371")]
		private static readonly string[] s_posPercentFormats;

		// Token: 0x04000225 RID: 549
		[global::Cpp2ILInjected.Token(Token = "0x4000372")]
		private static readonly string[] s_negPercentFormats;

		// Token: 0x04000226 RID: 550
		[global::Cpp2ILInjected.Token(Token = "0x4000373")]
		private static readonly string[] s_negNumberFormats;

		// Token: 0x04000227 RID: 551
		[global::Cpp2ILInjected.Token(Token = "0x4000374")]
		private static readonly int[] s_charToHexLookup;

		// Token: 0x04000228 RID: 552
		[global::Cpp2ILInjected.Token(Token = "0x4000375")]
		private static readonly ulong[] s_rgval64Power10;

		// Token: 0x04000229 RID: 553
		[global::Cpp2ILInjected.Token(Token = "0x4000376")]
		private static readonly sbyte[] s_rgexp64Power10;

		// Token: 0x0400022A RID: 554
		[global::Cpp2ILInjected.Token(Token = "0x4000377")]
		private static readonly ulong[] s_rgval64Power10By16;

		// Token: 0x0400022B RID: 555
		[global::Cpp2ILInjected.Token(Token = "0x4000378")]
		private static readonly short[] s_rgexp64Power10By16;

		// Token: 0x02000585 RID: 1413
		[global::Cpp2ILInjected.Token(Token = "0x20000E6")]
		[StructLayout(0, Pack = 1, Size = 122)]
		internal ref struct NumberBuffer
		{
			// Token: 0x1700071B RID: 1819
			// (get) Token: 0x06003F94 RID: 16276 RVA: 0x0001F97C File Offset: 0x0001DB7C
			// (set) Token: 0x06003F95 RID: 16277 RVA: 0x0001F97F File Offset: 0x0001DB7F
			[global::Cpp2ILInjected.Token(Token = "0x17000095")]
			public unsafe bool sign
			{
				[global::Cpp2ILInjected.Token(Token = "0x60008B5")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C43B98", Offset = "0x1C43B98", Length = "0x10")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatDouble", MemberParameters = new object[]
				{
					typeof(ref global::System.Text.ValueStringBuilder),
					typeof(double),
					typeof(global::System.ReadOnlySpan<char>),
					typeof(global::System.Globalization.NumberFormatInfo)
				}, ReturnType = typeof(string))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatSingle", MemberParameters = new object[]
				{
					typeof(ref global::System.Text.ValueStringBuilder),
					typeof(float),
					typeof(global::System.ReadOnlySpan<char>),
					typeof(global::System.Globalization.NumberFormatInfo)
				}, ReturnType = typeof(string))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "Int64ToNumber", MemberParameters = new object[]
				{
					typeof(long),
					typeof(ref global::System.Number.NumberBuffer)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "NumberToString", MemberParameters = new object[]
				{
					typeof(ref global::System.Text.ValueStringBuilder),
					typeof(ref global::System.Number.NumberBuffer),
					typeof(char),
					typeof(int),
					typeof(global::System.Globalization.NumberFormatInfo),
					typeof(bool)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "NumberToStringFormat", MemberParameters = new object[]
				{
					typeof(ref global::System.Text.ValueStringBuilder),
					typeof(ref global::System.Number.NumberBuffer),
					typeof(global::System.ReadOnlySpan<char>),
					typeof(global::System.Globalization.NumberFormatInfo)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatCurrency", MemberParameters = new object[]
				{
					typeof(ref global::System.Text.ValueStringBuilder),
					typeof(ref global::System.Number.NumberBuffer),
					typeof(int),
					typeof(int),
					typeof(global::System.Globalization.NumberFormatInfo)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatNumber", MemberParameters = new object[]
				{
					typeof(ref global::System.Text.ValueStringBuilder),
					typeof(ref global::System.Number.NumberBuffer),
					typeof(int),
					typeof(int),
					typeof(global::System.Globalization.NumberFormatInfo)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatPercent", MemberParameters = new object[]
				{
					typeof(ref global::System.Text.ValueStringBuilder),
					typeof(ref global::System.Number.NumberBuffer),
					typeof(int),
					typeof(int),
					typeof(global::System.Globalization.NumberFormatInfo)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "NumberToInt32", MemberParameters = new object[]
				{
					typeof(ref global::System.Number.NumberBuffer),
					typeof(ref int)
				}, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "NumberToInt64", MemberParameters = new object[]
				{
					typeof(ref global::System.Number.NumberBuffer),
					typeof(ref long)
				}, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "NumberToUInt32", MemberParameters = new object[]
				{
					typeof(ref global::System.Number.NumberBuffer),
					typeof(ref uint)
				}, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "NumberToUInt64", MemberParameters = new object[]
				{
					typeof(ref global::System.Number.NumberBuffer),
					typeof(ref ulong)
				}, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "NumberBufferToDecimal", MemberParameters = new object[]
				{
					typeof(ref global::System.Number.NumberBuffer),
					typeof(ref decimal)
				}, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "NumberToDouble", MemberParameters = new object[] { typeof(ref global::System.Number.NumberBuffer) }, ReturnType = typeof(double))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 17)]
				get
				{
					throw null;
				}
				[global::Cpp2ILInjected.Token(Token = "0x60008B6")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C43BA8", Offset = "0x1C43BA8", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "DecimalToNumber", MemberParameters = new object[]
				{
					typeof(decimal),
					typeof(ref global::System.Number.NumberBuffer)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatInt32", MemberParameters = new object[]
				{
					typeof(int),
					typeof(global::System.ReadOnlySpan<char>),
					typeof(global::System.IFormatProvider)
				}, ReturnType = typeof(string))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryFormatInt32", MemberParameters = new object[]
				{
					typeof(int),
					typeof(global::System.ReadOnlySpan<char>),
					typeof(global::System.IFormatProvider),
					typeof(global::System.Span<char>),
					typeof(ref int)
				}, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatUInt32", MemberParameters = new object[]
				{
					typeof(uint),
					typeof(global::System.ReadOnlySpan<char>),
					typeof(global::System.IFormatProvider)
				}, ReturnType = typeof(string))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryFormatUInt32", MemberParameters = new object[]
				{
					typeof(uint),
					typeof(global::System.ReadOnlySpan<char>),
					typeof(global::System.IFormatProvider),
					typeof(global::System.Span<char>),
					typeof(ref int)
				}, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "Int32ToNumber", MemberParameters = new object[]
				{
					typeof(int),
					typeof(ref global::System.Number.NumberBuffer)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "UInt32ToNumber", MemberParameters = new object[]
				{
					typeof(uint),
					typeof(ref global::System.Number.NumberBuffer)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "Int64ToNumber", MemberParameters = new object[]
				{
					typeof(long),
					typeof(ref global::System.Number.NumberBuffer)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "UInt64ToNumber", MemberParameters = new object[]
				{
					typeof(ulong),
					typeof(ref global::System.Number.NumberBuffer)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "NumberToString", MemberParameters = new object[]
				{
					typeof(ref global::System.Text.ValueStringBuilder),
					typeof(ref global::System.Number.NumberBuffer),
					typeof(char),
					typeof(int),
					typeof(global::System.Globalization.NumberFormatInfo),
					typeof(bool)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "NumberToStringFormat", MemberParameters = new object[]
				{
					typeof(ref global::System.Text.ValueStringBuilder),
					typeof(ref global::System.Number.NumberBuffer),
					typeof(global::System.ReadOnlySpan<char>),
					typeof(global::System.Globalization.NumberFormatInfo)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "RoundNumber", MemberParameters = new object[]
				{
					typeof(ref global::System.Number.NumberBuffer),
					typeof(int)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "ParseNumber", MemberParameters = new object[]
				{
					typeof(ref char*),
					typeof(char*),
					typeof(global::System.Globalization.NumberStyles),
					typeof(ref global::System.Number.NumberBuffer),
					typeof(global::System.Globalization.NumberFormatInfo),
					typeof(bool)
				}, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "DoubleToNumber", MemberParameters = new object[]
				{
					typeof(double),
					typeof(int),
					typeof(ref global::System.Number.NumberBuffer)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 22)]
				set
				{
					throw null;
				}
			}

			// Token: 0x1700071C RID: 1820
			// (get) Token: 0x06003F96 RID: 16278 RVA: 0x0001F982 File Offset: 0x0001DB82
			[global::Cpp2ILInjected.Token(Token = "0x17000096")]
			public unsafe char* digits
			{
				[global::Cpp2ILInjected.Token(Token = "0x60008B7")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C43BB4", Offset = "0x1C43BB4", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 36)]
				get
				{
					throw null;
				}
			}

			// Token: 0x040017F4 RID: 6132
			[global::Cpp2ILInjected.Token(Token = "0x4000379")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int precision;

			// Token: 0x040017F5 RID: 6133
			[global::Cpp2ILInjected.Token(Token = "0x400037A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
			public int scale;

			// Token: 0x040017F6 RID: 6134
			[global::Cpp2ILInjected.Token(Token = "0x400037B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			private int _sign;

			// Token: 0x040017F7 RID: 6135
			[global::Cpp2ILInjected.Token(Token = "0x400037C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
			private global::System.Number.NumberBuffer.DigitsAndNullTerminator _digits;

			// Token: 0x040017F8 RID: 6136
			[global::Cpp2ILInjected.Token(Token = "0x400037D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x72")]
			private unsafe char* _allDigits;

			// Token: 0x020006A7 RID: 1703
			[global::Cpp2ILInjected.Token(Token = "0x20000E7")]
			private struct DigitsAndNullTerminator
			{
			}
		}
	}
}
