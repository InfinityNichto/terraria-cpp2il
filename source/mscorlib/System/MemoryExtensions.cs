using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO.Enumeration;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x020000AA RID: 170
	[global::Cpp2ILInjected.Token(Token = "0x20000DA")]
	public static class MemoryExtensions
	{
		// Token: 0x0600077E RID: 1918 RVA: 0x00015AF1 File Offset: 0x00013CF1
		[global::Cpp2ILInjected.Token(Token = "0x6000823")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C36918", Offset = "0x1C36918", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SpanHelpers), Member = "SequenceEqual", MemberParameters = new object[]
		{
			typeof(ref byte),
			typeof(ref byte),
			typeof(ulong)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(256)]
		internal static bool EqualsOrdinal(this global::System.ReadOnlySpan<char> span, global::System.ReadOnlySpan<char> value)
		{
			throw null;
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x00015AF4 File Offset: 0x00013CF4
		[global::Cpp2ILInjected.Token(Token = "0x6000824")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C36A4C", Offset = "0x1C36A4C", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CompareInfo), Member = "CompareOrdinalIgnoreCase", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		[MethodImpl(256)]
		internal static bool EqualsOrdinalIgnoreCase(this global::System.ReadOnlySpan<char> span, global::System.ReadOnlySpan<char> value)
		{
			throw null;
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x00015AF7 File Offset: 0x00013CF7
		[global::Cpp2ILInjected.Token(Token = "0x6000825")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C36AF8", Offset = "0x1C36AF8", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "MakeSeparatorList", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(ref global::System.Collections.Generic.ValueListBuilder<int>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.IPAddressParser", Member = "Parse", MemberParameters = new object[]
		{
			"System.ReadOnlySpan`1<Char>",
			typeof(bool)
		}, ReturnType = "System.Net.IPAddress")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal static bool Contains(this global::System.ReadOnlySpan<char> source, char value)
		{
			throw null;
		}

		// Token: 0x06000781 RID: 1921 RVA: 0x00015AFA File Offset: 0x00013CFA
		[global::Cpp2ILInjected.Token(Token = "0x6000826")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C36B70", Offset = "0x1C36B70", Length = "0x14C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.CompareInfo), Member = "GetIgnoreCaseHash", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.TextInfo), Member = "ToUpperAsciiInvariant", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Span<char>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.TextInfo), Member = "ChangeCase", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Span<char>),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static int ToUpperInvariant(this global::System.ReadOnlySpan<char> source, global::System.Span<char> destination)
		{
			throw null;
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x00015AFD File Offset: 0x00013CFD
		[global::Cpp2ILInjected.Token(Token = "0x6000827")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C36CBC", Offset = "0x1C36CBC", Length = "0x320")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsInvalidInstructions]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Enumeration.FileSystemName), Member = "MatchPattern", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CheckStringComparison", MemberParameters = new object[] { typeof(global::System.StringComparison) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SpanHelpers), Member = "SequenceEqual", MemberParameters = new object[]
		{
			typeof(ref byte),
			typeof(ref byte),
			typeof(ulong)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SpanHelpers), Member = "EndsWithCultureHelper", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.CompareInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SpanHelpers), Member = "EndsWithCultureIgnoreCaseHelper", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.CompareInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SpanHelpers), Member = "EndsWithOrdinalIgnoreCaseHelper", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public static bool EndsWith(this global::System.ReadOnlySpan<char> span, global::System.ReadOnlySpan<char> value, global::System.StringComparison comparisonType)
		{
			throw null;
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x00015B00 File Offset: 0x00013D00
		[global::Cpp2ILInjected.Token(Token = "0x6000828")]
		[global::Cpp2ILInjected.Address(RVA = "0x15906C0", Offset = "0x15906C0", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(256)]
		public static global::System.Span<T> AsSpan<T>(this T[] array, int start)
		{
			throw null;
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x00015B03 File Offset: 0x00013D03
		[global::Cpp2ILInjected.Token(Token = "0x6000829")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C36FDC", Offset = "0x1C36FDC", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(256)]
		public static global::System.ReadOnlySpan<char> AsSpan(this string text)
		{
			throw null;
		}

		// Token: 0x06000785 RID: 1925 RVA: 0x00015B06 File Offset: 0x00013D06
		[global::Cpp2ILInjected.Token(Token = "0x600082A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C37034", Offset = "0x1C37034", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(256)]
		public static global::System.ReadOnlySpan<char> AsSpan(this string text, int start)
		{
			throw null;
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x00015B09 File Offset: 0x00013D09
		[global::Cpp2ILInjected.Token(Token = "0x600082B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C370C0", Offset = "0x1C370C0", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(256)]
		public static global::System.ReadOnlySpan<char> AsSpan(this string text, int start, int length)
		{
			throw null;
		}

		// Token: 0x06000787 RID: 1927 RVA: 0x00015B0C File Offset: 0x00013D0C
		[global::Cpp2ILInjected.Token(Token = "0x600082C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C2E8B0", Offset = "0x1C2E8B0", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(double), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(ref double)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(float), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(ref float)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.TimeSpanParse), Member = "TryParseTimeSpan", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			"System.Globalization.TimeSpanParse.TimeSpanStandardStyles",
			typeof(global::System.IFormatProvider),
			typeof(ref global::System.Globalization.TimeSpanParse.TimeSpanResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MemoryExtensions), Member = "TrimStart", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = typeof(global::System.ReadOnlySpan<char>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MemoryExtensions), Member = "TrimEnd", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = typeof(global::System.ReadOnlySpan<char>))]
		public static global::System.ReadOnlySpan<char> Trim(this global::System.ReadOnlySpan<char> span)
		{
			throw null;
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x00015B0F File Offset: 0x00013D0F
		[global::Cpp2ILInjected.Token(Token = "0x600082D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C37160", Offset = "0x1C37160", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Guid), Member = "TryParseGuid", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			"System.Guid.GuidStyles",
			typeof(ref global::System.Guid.GuidResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MemoryExtensions), Member = "Trim", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = typeof(global::System.ReadOnlySpan<char>))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static global::System.ReadOnlySpan<char> TrimStart(this global::System.ReadOnlySpan<char> span)
		{
			throw null;
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x00015B12 File Offset: 0x00013D12
		[global::Cpp2ILInjected.Token(Token = "0x600082E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C37254", Offset = "0x1C37254", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Guid), Member = "TryParseGuid", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			"System.Guid.GuidStyles",
			typeof(ref global::System.Guid.GuidResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MemoryExtensions), Member = "Trim", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = typeof(global::System.ReadOnlySpan<char>))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static global::System.ReadOnlySpan<char> TrimEnd(this global::System.ReadOnlySpan<char> span)
		{
			throw null;
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x00015B15 File Offset: 0x00013D15
		[global::Cpp2ILInjected.Token(Token = "0x600082F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1590BCC", Offset = "0x1590BCC", Length = "0x1A4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SpanHelpers), Member = "IndexOf", MemberParameters = new object[]
		{
			typeof(ref byte),
			typeof(byte),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SpanHelpers), Member = "IndexOf", MemberParameters = new object[]
		{
			typeof(ref char),
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		[MethodImpl(256)]
		public static int IndexOf<T>(this global::System.ReadOnlySpan<T> span, T value) where T : global::System.IEquatable<T>
		{
			throw null;
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x00015B18 File Offset: 0x00013D18
		[global::Cpp2ILInjected.Token(Token = "0x6000830")]
		[global::Cpp2ILInjected.Address(RVA = "0x15910B8", Offset = "0x15910B8", Length = "0x154")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SpanHelpers), Member = "IndexOfAny", MemberParameters = new object[]
		{
			typeof(ref byte),
			typeof(int),
			typeof(ref byte),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		[MethodImpl(256)]
		public static int IndexOfAny<T>(this global::System.ReadOnlySpan<T> span, global::System.ReadOnlySpan<T> values) where T : global::System.IEquatable<T>
		{
			throw null;
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x00015B1B File Offset: 0x00013D1B
		[global::Cpp2ILInjected.Token(Token = "0x6000831")]
		[global::Cpp2ILInjected.Address(RVA = "0x1591B38", Offset = "0x1591B38", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsInvalidInstructions]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SpanHelpers), Member = "SequenceEqual", MemberParameters = new object[]
		{
			typeof(ref byte),
			typeof(ref byte),
			typeof(ulong)
		}, ReturnType = typeof(bool))]
		[MethodImpl(256)]
		public static bool SequenceEqual<T>(this global::System.ReadOnlySpan<T> span, global::System.ReadOnlySpan<T> other) where T : global::System.IEquatable<T>
		{
			throw null;
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x00015B1E File Offset: 0x00013D1E
		[global::Cpp2ILInjected.Token(Token = "0x6000832")]
		[global::Cpp2ILInjected.Address(RVA = "0x1591CD4", Offset = "0x1591CD4", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsInvalidInstructions]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SpanHelpers), Member = "SequenceEqual", MemberParameters = new object[]
		{
			typeof(ref byte),
			typeof(ref byte),
			typeof(ulong)
		}, ReturnType = typeof(bool))]
		[MethodImpl(256)]
		public static bool StartsWith<T>(this global::System.ReadOnlySpan<T> span, global::System.ReadOnlySpan<T> value) where T : global::System.IEquatable<T>
		{
			throw null;
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x00015B21 File Offset: 0x00013D21
		[global::Cpp2ILInjected.Token(Token = "0x6000833")]
		[global::Cpp2ILInjected.Address(RVA = "0x1590A14", Offset = "0x1590A14", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsInvalidInstructions]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SpanHelpers), Member = "SequenceEqual", MemberParameters = new object[]
		{
			typeof(ref byte),
			typeof(ref byte),
			typeof(ulong)
		}, ReturnType = typeof(bool))]
		[MethodImpl(256)]
		public static bool EndsWith<T>(this global::System.ReadOnlySpan<T> span, global::System.ReadOnlySpan<T> value) where T : global::System.IEquatable<T>
		{
			throw null;
		}

		// Token: 0x0600078F RID: 1935 RVA: 0x00015B24 File Offset: 0x00013D24
		[global::Cpp2ILInjected.Token(Token = "0x6000834")]
		[global::Cpp2ILInjected.Address(RVA = "0x1590820", Offset = "0x1590820", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(256)]
		public static global::System.Span<T> AsSpan<T>(this T[] array, int start, int length)
		{
			throw null;
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x00015B27 File Offset: 0x00013D27
		[global::Cpp2ILInjected.Token(Token = "0x6000835")]
		[global::Cpp2ILInjected.Address(RVA = "0x1590984", Offset = "0x1590984", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ReadOnlySpan<>), Member = "CopyTo", MemberParameters = new object[] { "System.Span`1<T>" }, ReturnType = typeof(void))]
		[MethodImpl(256)]
		public static void CopyTo<T>(this T[] source, global::System.Span<T> destination)
		{
			throw null;
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x00015B2A File Offset: 0x00013D2A
		[global::Cpp2ILInjected.Token(Token = "0x6000836")]
		[global::Cpp2ILInjected.Address(RVA = "0x1591360", Offset = "0x1591360", Length = "0x3EC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		[MethodImpl(256)]
		private static bool IsTypeComparableAsBytes<T>(out ulong size)
		{
			throw null;
		}
	}
}
