using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Math;

namespace System
{
	// Token: 0x020000FB RID: 251
	[global::System.Diagnostics.StackTraceHidden]
	[global::Cpp2ILInjected.Token(Token = "0x200012D")]
	internal static class ThrowHelper
	{
		// Token: 0x06000AF7 RID: 2807 RVA: 0x000164D8 File Offset: 0x000146D8
		[global::Cpp2ILInjected.Token(Token = "0x6000B9F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C462C0", Offset = "0x1C462C0", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 96)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "CreateArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static void ThrowArgumentNullException(global::System.ExceptionArgument argument)
		{
			throw null;
		}

		// Token: 0x06000AF8 RID: 2808 RVA: 0x000164DB File Offset: 0x000146DB
		[global::Cpp2ILInjected.Token(Token = "0x6000BA0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C54F60", Offset = "0x1C54F60", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Enum), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		[MethodImpl(8)]
		private static global::System.Exception CreateArgumentNullException(global::System.ExceptionArgument argument)
		{
			throw null;
		}

		// Token: 0x06000AF9 RID: 2809 RVA: 0x000164DE File Offset: 0x000146DE
		[global::Cpp2ILInjected.Token(Token = "0x6000BA1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C55004", Offset = "0x1C55004", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "CreateArrayTypeMismatchException", ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static void ThrowArrayTypeMismatchException()
		{
			throw null;
		}

		// Token: 0x06000AFA RID: 2810 RVA: 0x000164E1 File Offset: 0x000146E1
		[global::Cpp2ILInjected.Token(Token = "0x6000BA2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C55028", Offset = "0x1C55028", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ThrowHelper), Member = "ThrowArrayTypeMismatchException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArrayTypeMismatchException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(8)]
		private static global::System.Exception CreateArrayTypeMismatchException()
		{
			throw null;
		}

		// Token: 0x06000AFB RID: 2811 RVA: 0x000164E4 File Offset: 0x000146E4
		[global::Cpp2ILInjected.Token(Token = "0x6000BA3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5507C", Offset = "0x1C5507C", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ReadOnlySpan<>), Member = "CopyTo", MemberParameters = new object[] { "System.Span`1<T>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Span<>), Member = "CopyTo", MemberParameters = new object[] { "System.Span`1<T>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "CreateArgumentException_DestinationTooShort", ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static void ThrowArgumentException_DestinationTooShort()
		{
			throw null;
		}

		// Token: 0x06000AFC RID: 2812 RVA: 0x000164E7 File Offset: 0x000146E7
		[global::Cpp2ILInjected.Token(Token = "0x6000BA4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C550A0", Offset = "0x1C550A0", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentException_DestinationTooShort", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		[MethodImpl(8)]
		private static global::System.Exception CreateArgumentException_DestinationTooShort()
		{
			throw null;
		}

		// Token: 0x06000AFD RID: 2813 RVA: 0x000164EA File Offset: 0x000146EA
		[global::Cpp2ILInjected.Token(Token = "0x6000BA5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5510C", Offset = "0x1C5510C", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Math.BigInteger), Member = "ToString", MemberParameters = new object[]
		{
			typeof(uint),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "EndsWith", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "Replace", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "MakeSeparatorList", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(ref global::System.Collections.Generic.ValueListBuilder<int>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "MakeSeparatorList", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref global::System.Collections.Generic.ValueListBuilder<int>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "MakeSeparatorList", MemberParameters = new object[]
		{
			typeof(string[]),
			typeof(ref global::System.Collections.Generic.ValueListBuilder<int>),
			typeof(ref global::System.Collections.Generic.ValueListBuilder<int>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "TrimWhiteSpaceHelper", MemberParameters = new object[] { "System.String.TrimType" }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "TrimHelper", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			"System.String.TrimType"
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "IsNullOrWhiteSpace", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ReadOnlySpan<>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T&")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Span<>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T&")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 20)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "CreateIndexOutOfRangeException", ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal unsafe static void ThrowIndexOutOfRangeException()
		{
			throw null;
		}

		// Token: 0x06000AFE RID: 2814 RVA: 0x000164ED File Offset: 0x000146ED
		[global::Cpp2ILInjected.Token(Token = "0x6000BA6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C55130", Offset = "0x1C55130", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ThrowHelper), Member = "ThrowIndexOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IndexOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(8)]
		private static global::System.Exception CreateIndexOutOfRangeException()
		{
			throw null;
		}

		// Token: 0x06000AFF RID: 2815 RVA: 0x000164F0 File Offset: 0x000146F0
		[global::Cpp2ILInjected.Token(Token = "0x6000BA7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C55184", Offset = "0x1C55184", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 217)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "CreateArgumentOutOfRangeException", ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static void ThrowArgumentOutOfRangeException()
		{
			throw null;
		}

		// Token: 0x06000B00 RID: 2816 RVA: 0x000164F3 File Offset: 0x000146F3
		[global::Cpp2ILInjected.Token(Token = "0x6000BA8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C551A8", Offset = "0x1C551A8", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(8)]
		private static global::System.Exception CreateArgumentOutOfRangeException()
		{
			throw null;
		}

		// Token: 0x06000B01 RID: 2817 RVA: 0x000164F6 File Offset: 0x000146F6
		[global::Cpp2ILInjected.Token(Token = "0x6000BA9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C551FC", Offset = "0x1C551FC", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "ReplaceHelper", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(global::System.ReadOnlySpan<int>)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "MakeSeparatorList", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref global::System.Collections.Generic.ValueListBuilder<int>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "MakeSeparatorList", MemberParameters = new object[]
		{
			typeof(string[]),
			typeof(ref global::System.Collections.Generic.ValueListBuilder<int>),
			typeof(ref global::System.Collections.Generic.ValueListBuilder<int>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "TZif_ParseMDateRule", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int),
			typeof(ref int),
			typeof(ref global::System.DayOfWeek)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.__DTString), Member = "MatchSpecifiedWords", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MemoryExtensions), Member = "AsSpan", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(global::System.ReadOnlySpan<char>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MemoryExtensions), Member = "AsSpan", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(global::System.ReadOnlySpan<char>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Buffer), Member = "MemoryCopy", MemberParameters = new object[]
		{
			typeof(void*),
			typeof(void*),
			typeof(long),
			typeof(long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Threading.Tasks.ValueTask.ValueTaskSourceAsTask.<>c", Member = "<.cctor>b__4_0", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Threading.Tasks.ValueTask`1.ValueTaskSourceAsTask.<>c", Member = "<.cctor>b__4_0", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.StringBuilder), Member = "AppendFormatHelper", MemberParameters = new object[]
		{
			typeof(global::System.IFormatProvider),
			typeof(string),
			typeof(global::System.ParamsArray)
		}, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Runtime.CompilerServices.ValueTaskAwaiter.<>c", Member = "<.cctor>b__9_0", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.CompareInfo), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.CompareInfo), Member = "CompareOrdinalIgnoreCase", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.Dictionary<, >), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			"System.Collections.Generic.IEqualityComparer`1<TKey>"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Text.RegularExpressions.Capture", Member = "GetLeftSubstring", ReturnType = "System.ReadOnlySpan`1<Char>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Text.RegularExpressions.Capture", Member = "GetRightSubstring", ReturnType = "System.ReadOnlySpan`1<Char>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Text.RegularExpressions.Match", Member = "GroupToStringImpl", MemberParameters = new object[] { typeof(int) }, ReturnType = "System.ReadOnlySpan`1<Char>")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 35)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "CreateArgumentOutOfRangeException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal unsafe static void ThrowArgumentOutOfRangeException(global::System.ExceptionArgument argument)
		{
			throw null;
		}

		// Token: 0x06000B02 RID: 2818 RVA: 0x000164F9 File Offset: 0x000146F9
		[global::Cpp2ILInjected.Token(Token = "0x6000BAA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C55220", Offset = "0x1C55220", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Enum), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		[MethodImpl(8)]
		private static global::System.Exception CreateArgumentOutOfRangeException(global::System.ExceptionArgument argument)
		{
			throw null;
		}

		// Token: 0x06000B03 RID: 2819 RVA: 0x000164FC File Offset: 0x000146FC
		[global::Cpp2ILInjected.Token(Token = "0x6000BAB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C552C4", Offset = "0x1C552C4", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ArraySegment<>), Member = "System.Collections.Generic.IList<T>.Insert", MemberParameters = new object[]
		{
			typeof(int),
			"T"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ArraySegment<>), Member = "System.Collections.Generic.IList<T>.RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ArraySegment<>), Member = "System.Collections.Generic.ICollection<T>.Add", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ArraySegment<>), Member = "System.Collections.Generic.ICollection<T>.Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ArraySegment<>), Member = "System.Collections.Generic.ICollection<T>.Remove", MemberParameters = new object[] { "T" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "CreateThrowNotSupportedException", ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static void ThrowNotSupportedException()
		{
			throw null;
		}

		// Token: 0x06000B04 RID: 2820 RVA: 0x000164FF File Offset: 0x000146FF
		[global::Cpp2ILInjected.Token(Token = "0x6000BAC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C552E8", Offset = "0x1C552E8", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ThrowHelper), Member = "ThrowNotSupportedException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(8)]
		private static global::System.Exception CreateThrowNotSupportedException()
		{
			throw null;
		}

		// Token: 0x06000B05 RID: 2821 RVA: 0x00016502 File Offset: 0x00014702
		[global::Cpp2ILInjected.Token(Token = "0x6000BAD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5533C", Offset = "0x1C5533C", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.Dictionary<, >), Member = "System.Collections.IDictionary.set_Item", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.Dictionary<, >), Member = "System.Collections.IDictionary.Add", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		internal static void ThrowWrongKeyTypeArgumentException(object key, global::System.Type targetType)
		{
			throw null;
		}

		// Token: 0x06000B06 RID: 2822 RVA: 0x00016505 File Offset: 0x00014705
		[global::Cpp2ILInjected.Token(Token = "0x6000BAE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C553E8", Offset = "0x1C553E8", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.ObjectModel.Collection<>), Member = "System.Collections.IList.set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.ObjectModel.Collection<>), Member = "System.Collections.IList.Add", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.ObjectModel.Collection<>), Member = "System.Collections.IList.Insert", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.Dictionary<, >), Member = "System.Collections.IDictionary.set_Item", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.Dictionary<, >), Member = "System.Collections.IDictionary.Add", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.List<>), Member = "System.Collections.IList.set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.List<>), Member = "System.Collections.IList.Add", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.List<>), Member = "System.Collections.IList.Insert", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		internal static void ThrowWrongValueTypeArgumentException(object value, global::System.Type targetType)
		{
			throw null;
		}

		// Token: 0x06000B07 RID: 2823 RVA: 0x00016508 File Offset: 0x00014708
		[global::Cpp2ILInjected.Token(Token = "0x6000BAF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C55494", Offset = "0x1C55494", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.ObjectModel.Collection<>), Member = "System.Collections.ICollection.CopyTo", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.ObjectModel.ReadOnlyCollection<>), Member = "System.Collections.ICollection.CopyTo", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.Dictionary<, >.KeyCollection), Member = "CopyTo", MemberParameters = new object[]
		{
			"TKey[]",
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.Dictionary<, >.KeyCollection), Member = "System.Collections.ICollection.CopyTo", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.Dictionary<, >.ValueCollection), Member = "CopyTo", MemberParameters = new object[]
		{
			"TValue[]",
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.Dictionary<, >.ValueCollection), Member = "System.Collections.ICollection.CopyTo", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.Dictionary<, >), Member = "CopyTo", MemberParameters = new object[]
		{
			"System.Collections.Generic.KeyValuePair`2<TKey, TValue>[]",
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.Dictionary<, >), Member = "System.Collections.ICollection.CopyTo", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.List<>), Member = "System.Collections.ICollection.CopyTo", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.List<>), Member = "RemoveRange", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.List<>), Member = "Reverse", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.List<>), Member = "Sort", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			"System.Collections.Generic.IComparer`1<T>"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.Comparer<>), Member = "System.Collections.IComparer.Compare", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.EqualityComparer<>), Member = "System.Collections.IEqualityComparer.GetHashCode", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.EqualityComparer<>), Member = "System.Collections.IEqualityComparer.Equals", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 25)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "GetResourceName", MemberParameters = new object[] { typeof(global::System.ExceptionResource) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal static void ThrowArgumentException(global::System.ExceptionResource resource)
		{
			throw null;
		}

		// Token: 0x06000B08 RID: 2824 RVA: 0x0001650B File Offset: 0x0001470B
		[global::Cpp2ILInjected.Token(Token = "0x6000BB0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C55770", Offset = "0x1C55770", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(global::System.StringComparison)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(global::System.StringComparison)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "EndsWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.StringComparison)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "Equals", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.StringComparison)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "Equals", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(global::System.StringComparison)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "StartsWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.StringComparison)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "CheckStringComparison", MemberParameters = new object[] { typeof(global::System.StringComparison) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.BitConverter), Member = "ToInt16", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.BitConverter), Member = "ToInt32", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.BitConverter), Member = "ToInt64", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.BitConverter), Member = "ToString", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 15)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "GetResourceName", MemberParameters = new object[] { typeof(global::System.ExceptionResource) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "GetArgumentName", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal static void ThrowArgumentException(global::System.ExceptionResource resource, global::System.ExceptionArgument argument)
		{
			throw null;
		}

		// Token: 0x06000B09 RID: 2825 RVA: 0x0001650E File Offset: 0x0001470E
		[global::Cpp2ILInjected.Token(Token = "0x6000BB1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C55958", Offset = "0x1C55958", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.BitConverter), Member = "ToInt16", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.BitConverter), Member = "ToInt32", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.BitConverter), Member = "ToInt64", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.BitConverter), Member = "ToString", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.List<>), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.List<>), Member = "set_Capacity", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.List<>), Member = "Insert", MemberParameters = new object[]
		{
			typeof(int),
			"T"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.List<>), Member = "RemoveRange", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.List<>), Member = "Reverse", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.List<>), Member = "Sort", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			"System.Collections.Generic.IComparer`1<T>"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "GetArgumentName", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "GetResourceName", MemberParameters = new object[] { typeof(global::System.ExceptionResource) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal static void ThrowArgumentOutOfRangeException(global::System.ExceptionArgument argument, global::System.ExceptionResource resource)
		{
			throw null;
		}

		// Token: 0x06000B0A RID: 2826 RVA: 0x00016511 File Offset: 0x00014711
		[global::Cpp2ILInjected.Token(Token = "0x6000BB2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C559F4", Offset = "0x1C559F4", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ArraySegment<>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ArraySegment<>), Member = "CopyTo", MemberParameters = new object[]
		{
			"T[]",
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ArraySegment<>), Member = "System.Collections.Generic.IList<T>.get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ArraySegment<>), Member = "System.Collections.Generic.IList<T>.set_Item", MemberParameters = new object[]
		{
			typeof(int),
			"T"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ArraySegment<>), Member = "System.Collections.Generic.IList<T>.IndexOf", MemberParameters = new object[] { "T" }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ArraySegment<>), Member = "System.Collections.Generic.IReadOnlyList<T>.get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ArraySegment<>), Member = "System.Collections.Generic.ICollection<T>.Contains", MemberParameters = new object[] { "T" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ArraySegment<>), Member = "ThrowInvalidOperationIfDefault", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "GetResourceName", MemberParameters = new object[] { typeof(global::System.ExceptionResource) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal static void ThrowInvalidOperationException(global::System.ExceptionResource resource)
		{
			throw null;
		}

		// Token: 0x06000B0B RID: 2827 RVA: 0x00016514 File Offset: 0x00014714
		[global::Cpp2ILInjected.Token(Token = "0x6000BB3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C55A44", Offset = "0x1C55A44", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.Dictionary<, >), Member = "OnDeserialization", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "GetResourceName", MemberParameters = new object[] { typeof(global::System.ExceptionResource) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal static void ThrowSerializationException(global::System.ExceptionResource resource)
		{
			throw null;
		}

		// Token: 0x06000B0C RID: 2828 RVA: 0x00016517 File Offset: 0x00014717
		[global::Cpp2ILInjected.Token(Token = "0x6000BB4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C55A94", Offset = "0x1C55A94", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 27)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "GetResourceName", MemberParameters = new object[] { typeof(global::System.ExceptionResource) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal static void ThrowNotSupportedException(global::System.ExceptionResource resource)
		{
			throw null;
		}

		// Token: 0x06000B0D RID: 2829 RVA: 0x0001651A File Offset: 0x0001471A
		[global::Cpp2ILInjected.Token(Token = "0x6000BB5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C55AE4", Offset = "0x1C55AE4", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.Dictionary<, >.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.Dictionary<, >.Enumerator), Member = "System.Collections.IEnumerator.Reset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.Dictionary<, >.KeyCollection.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.Dictionary<, >.KeyCollection.Enumerator), Member = "System.Collections.IEnumerator.Reset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.Dictionary<, >.ValueCollection.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.Dictionary<, >.ValueCollection.Enumerator), Member = "System.Collections.IEnumerator.Reset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.List<>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.List<>.Enumerator), Member = "MoveNextRare", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.List<>.Enumerator), Member = "System.Collections.IEnumerator.Reset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.List<>), Member = "ForEach", MemberParameters = new object[] { "System.Action`1<T>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal static void ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion()
		{
			throw null;
		}

		// Token: 0x06000B0E RID: 2830 RVA: 0x0001651D File Offset: 0x0001471D
		[global::Cpp2ILInjected.Token(Token = "0x6000BB6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C55B30", Offset = "0x1C55B30", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Runtime.CompilerServices.ConditionalWeakTable`2.Enumerator", Member = "get_Current", ReturnType = "System.Collections.Generic.KeyValuePair`2<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.Dictionary<, >.Enumerator), Member = "System.Collections.IEnumerator.get_Current", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.Dictionary<, >.Enumerator), Member = "System.Collections.IDictionaryEnumerator.get_Entry", ReturnType = typeof(global::System.Collections.DictionaryEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.Dictionary<, >.Enumerator), Member = "System.Collections.IDictionaryEnumerator.get_Key", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.Dictionary<, >.Enumerator), Member = "System.Collections.IDictionaryEnumerator.get_Value", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.Dictionary<, >.KeyCollection.Enumerator), Member = "System.Collections.IEnumerator.get_Current", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.Dictionary<, >.ValueCollection.Enumerator), Member = "System.Collections.IEnumerator.get_Current", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.List<>.Enumerator), Member = "System.Collections.IEnumerator.get_Current", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal static void ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen()
		{
			throw null;
		}

		// Token: 0x06000B0F RID: 2831 RVA: 0x00016520 File Offset: 0x00014720
		[global::Cpp2ILInjected.Token(Token = "0x6000BB7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C55B7C", Offset = "0x1C55B7C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ArraySegment<>.Enumerator), Member = "get_Current", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal static void ThrowInvalidOperationException_InvalidOperation_EnumNotStarted()
		{
			throw null;
		}

		// Token: 0x06000B10 RID: 2832 RVA: 0x00016523 File Offset: 0x00014723
		[global::Cpp2ILInjected.Token(Token = "0x6000BB8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C55BC8", Offset = "0x1C55BC8", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ArraySegment<>.Enumerator), Member = "get_Current", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal static void ThrowInvalidOperationException_InvalidOperation_EnumEnded()
		{
			throw null;
		}

		// Token: 0x06000B11 RID: 2833 RVA: 0x00016526 File Offset: 0x00014726
		[global::Cpp2ILInjected.Token(Token = "0x6000BB9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C55C14", Offset = "0x1C55C14", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Nullable<>), Member = "get_Value", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal static void ThrowInvalidOperationException_InvalidOperation_NoValue()
		{
			throw null;
		}

		// Token: 0x06000B12 RID: 2834 RVA: 0x00016529 File Offset: 0x00014729
		[global::Cpp2ILInjected.Token(Token = "0x6000BBA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C55C60", Offset = "0x1C55C60", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ThrowHelper), Member = "ThrowIndexArgumentOutOfRange_NeedNonNegNumException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "GetArgumentName", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static global::System.ArgumentOutOfRangeException GetArgumentOutOfRangeException(global::System.ExceptionArgument argument, string resource)
		{
			throw null;
		}

		// Token: 0x06000B13 RID: 2835 RVA: 0x0001652C File Offset: 0x0001472C
		[global::Cpp2ILInjected.Token(Token = "0x6000BBB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C55CDC", Offset = "0x1C55CDC", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ArraySegment<>), Member = "System.Collections.Generic.IList<T>.get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ArraySegment<>), Member = "System.Collections.Generic.IList<T>.set_Item", MemberParameters = new object[]
		{
			typeof(int),
			"T"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ArraySegment<>), Member = "System.Collections.Generic.IReadOnlyList<T>.get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.ObjectModel.Collection<>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			"T"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.ObjectModel.Collection<>), Member = "Insert", MemberParameters = new object[]
		{
			typeof(int),
			"T"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.ObjectModel.Collection<>), Member = "RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.List<>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.List<>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			"T"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.List<>), Member = "InsertRange", MemberParameters = new object[]
		{
			typeof(int),
			"System.Collections.Generic.IEnumerable`1<T>"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.List<>), Member = "RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "GetArgumentOutOfRangeException", MemberParameters = new object[]
		{
			typeof(global::System.ExceptionArgument),
			typeof(string)
		}, ReturnType = typeof(global::System.ArgumentOutOfRangeException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal static void ThrowArgumentOutOfRange_IndexException()
		{
			throw null;
		}

		// Token: 0x06000B14 RID: 2836 RVA: 0x0001652F File Offset: 0x0001472F
		[global::Cpp2ILInjected.Token(Token = "0x6000BBC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C55D14", Offset = "0x1C55D14", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.ObjectModel.Collection<>), Member = "System.Collections.ICollection.CopyTo", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.ObjectModel.ReadOnlyCollection<>), Member = "System.Collections.ICollection.CopyTo", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.Dictionary<, >.KeyCollection), Member = "CopyTo", MemberParameters = new object[]
		{
			"TKey[]",
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.Dictionary<, >.KeyCollection), Member = "System.Collections.ICollection.CopyTo", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.Dictionary<, >.ValueCollection), Member = "CopyTo", MemberParameters = new object[]
		{
			"TValue[]",
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.Dictionary<, >.ValueCollection), Member = "System.Collections.ICollection.CopyTo", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.Dictionary<, >), Member = "CopyTo", MemberParameters = new object[]
		{
			"System.Collections.Generic.KeyValuePair`2<TKey, TValue>[]",
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.Dictionary<, >), Member = "System.Collections.ICollection.CopyTo", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.List<>), Member = "RemoveRange", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.List<>), Member = "Reverse", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.List<>), Member = "Sort", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			"System.Collections.Generic.IComparer`1<T>"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "GetArgumentOutOfRangeException", MemberParameters = new object[]
		{
			typeof(global::System.ExceptionArgument),
			typeof(string)
		}, ReturnType = typeof(global::System.ArgumentOutOfRangeException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal static void ThrowIndexArgumentOutOfRange_NeedNonNegNumException()
		{
			throw null;
		}

		// Token: 0x06000B15 RID: 2837 RVA: 0x00016532 File Offset: 0x00014732
		[global::Cpp2ILInjected.Token(Token = "0x6000BBD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C55D4C", Offset = "0x1C55D4C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.ObjectModel.Collection<>), Member = "System.Collections.ICollection.CopyTo", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.ObjectModel.ReadOnlyCollection<>), Member = "System.Collections.ICollection.CopyTo", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.Dictionary<, >.KeyCollection), Member = "System.Collections.ICollection.CopyTo", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.Dictionary<, >.ValueCollection), Member = "System.Collections.ICollection.CopyTo", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.Dictionary<, >), Member = "System.Collections.ICollection.CopyTo", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.List<>), Member = "System.Collections.ICollection.CopyTo", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal static void ThrowArgumentException_Argument_InvalidArrayType()
		{
			throw null;
		}

		// Token: 0x06000B16 RID: 2838 RVA: 0x00016535 File Offset: 0x00014735
		[global::Cpp2ILInjected.Token(Token = "0x6000BBE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C55D98", Offset = "0x1C55D98", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ThrowHelper), Member = "ThrowAddingDuplicateWithKeyArgumentException", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static global::System.ArgumentException GetAddingDuplicateWithKeyArgumentException(object key)
		{
			throw null;
		}

		// Token: 0x06000B17 RID: 2839 RVA: 0x00016538 File Offset: 0x00014738
		[global::Cpp2ILInjected.Token(Token = "0x6000BBF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C55E28", Offset = "0x1C55E28", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.Dictionary<, >), Member = "TryInsert", MemberParameters = new object[]
		{
			"TKey",
			"TValue",
			typeof(global::System.Collections.Generic.InsertionBehavior)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "GetAddingDuplicateWithKeyArgumentException", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(global::System.ArgumentException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static void ThrowAddingDuplicateWithKeyArgumentException(object key)
		{
			throw null;
		}

		// Token: 0x06000B18 RID: 2840 RVA: 0x0001653B File Offset: 0x0001473B
		[global::Cpp2ILInjected.Token(Token = "0x6000BC0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C55E4C", Offset = "0x1C55E4C", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ThrowHelper), Member = "ThrowKeyNotFoundException", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.KeyNotFoundException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static global::System.Collections.Generic.KeyNotFoundException GetKeyNotFoundException(object key)
		{
			throw null;
		}

		// Token: 0x06000B19 RID: 2841 RVA: 0x0001653E File Offset: 0x0001473E
		[global::Cpp2ILInjected.Token(Token = "0x6000BC1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C55EB8", Offset = "0x1C55EB8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.Dictionary<, >), Member = "get_Item", MemberParameters = new object[] { "TKey" }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "GetKeyNotFoundException", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(global::System.Collections.Generic.KeyNotFoundException))]
		internal static void ThrowKeyNotFoundException(object key)
		{
			throw null;
		}

		// Token: 0x06000B1A RID: 2842 RVA: 0x00016541 File Offset: 0x00014741
		[global::Cpp2ILInjected.Token(Token = "0x6000BC2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C55EC0", Offset = "0x1C55EC0", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal static void ThrowInvalidTypeWithPointersNotSupported(global::System.Type targetType)
		{
			throw null;
		}

		// Token: 0x06000B1B RID: 2843 RVA: 0x00016544 File Offset: 0x00014744
		[global::Cpp2ILInjected.Token(Token = "0x6000BC3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C55F20", Offset = "0x1C55F20", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.Dictionary<, >), Member = "FindEntry", MemberParameters = new object[] { "TKey" }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.Dictionary<, >), Member = "TryInsert", MemberParameters = new object[]
		{
			"TKey",
			"TValue",
			typeof(global::System.Collections.Generic.InsertionBehavior)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "GetInvalidOperationException", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.InvalidOperationException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal static void ThrowInvalidOperationException_ConcurrentOperationsNotSupported()
		{
			throw null;
		}

		// Token: 0x06000B1C RID: 2844 RVA: 0x00016547 File Offset: 0x00014747
		[global::Cpp2ILInjected.Token(Token = "0x6000BC4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C55F50", Offset = "0x1C55F50", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ThrowHelper), Member = "ThrowInvalidOperationException_ConcurrentOperationsNotSupported", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static global::System.InvalidOperationException GetInvalidOperationException(string str)
		{
			throw null;
		}

		// Token: 0x06000B1D RID: 2845 RVA: 0x0001654A File Offset: 0x0001474A
		[global::Cpp2ILInjected.Token(Token = "0x6000BC5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C55FAC", Offset = "0x1C55FAC", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ArraySegment<>), Member = ".ctor", MemberParameters = new object[]
		{
			"T[]",
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "GetArraySegmentCtorValidationFailedException", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static void ThrowArraySegmentCtorValidationFailedExceptions(global::System.Array array, int offset, int count)
		{
			throw null;
		}

		// Token: 0x06000B1E RID: 2846 RVA: 0x0001654D File Offset: 0x0001474D
		[global::Cpp2ILInjected.Token(Token = "0x6000BC6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C55FD0", Offset = "0x1C55FD0", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ThrowHelper), Member = "ThrowArraySegmentCtorValidationFailedExceptions", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "GetArgumentException", MemberParameters = new object[] { typeof(global::System.ExceptionResource) }, ReturnType = typeof(global::System.ArgumentException))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "GetArgumentOutOfRangeException", MemberParameters = new object[]
		{
			typeof(global::System.ExceptionArgument),
			typeof(global::System.ExceptionResource)
		}, ReturnType = typeof(global::System.ArgumentOutOfRangeException))]
		private static global::System.Exception GetArraySegmentCtorValidationFailedException(global::System.Array array, int offset, int count)
		{
			throw null;
		}

		// Token: 0x06000B1F RID: 2847 RVA: 0x00016550 File Offset: 0x00014750
		[global::Cpp2ILInjected.Token(Token = "0x6000BC7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C56124", Offset = "0x1C56124", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ThrowHelper), Member = "GetArraySegmentCtorValidationFailedException", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Enum), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static global::System.ArgumentException GetArgumentException(global::System.ExceptionResource resource)
		{
			throw null;
		}

		// Token: 0x06000B20 RID: 2848 RVA: 0x00016553 File Offset: 0x00014753
		[global::Cpp2ILInjected.Token(Token = "0x6000BC8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C56000", Offset = "0x1C56000", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "GetArgumentName", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static global::System.ArgumentNullException GetArgumentNullException(global::System.ExceptionArgument argument)
		{
			throw null;
		}

		// Token: 0x06000B21 RID: 2849 RVA: 0x00016556 File Offset: 0x00014756
		[global::Cpp2ILInjected.Token(Token = "0x6000BC9")]
		[global::Cpp2ILInjected.Address(RVA = "0x15A1400", Offset = "0x15A1400", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		internal static void IfNullAndNullsAreIllegalThenThrow<T>(object value, global::System.ExceptionArgument argName)
		{
			throw null;
		}

		// Token: 0x06000B22 RID: 2850 RVA: 0x00016559 File Offset: 0x00014759
		[global::Cpp2ILInjected.Token(Token = "0x6000BCA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C557D4", Offset = "0x1C557D4", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new object[]
		{
			typeof(global::System.ExceptionResource),
			typeof(global::System.ExceptionArgument)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new object[]
		{
			typeof(global::System.ExceptionArgument),
			typeof(global::System.ExceptionResource)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ThrowHelper), Member = "GetArgumentOutOfRangeException", MemberParameters = new object[]
		{
			typeof(global::System.ExceptionArgument),
			typeof(string)
		}, ReturnType = typeof(global::System.ArgumentOutOfRangeException))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ThrowHelper), Member = "GetArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(global::System.ArgumentNullException))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ThrowHelper), Member = "GetArgumentOutOfRangeException", MemberParameters = new object[]
		{
			typeof(global::System.ExceptionArgument),
			typeof(global::System.ExceptionResource)
		}, ReturnType = typeof(global::System.ArgumentOutOfRangeException))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		internal static string GetArgumentName(global::System.ExceptionArgument argument)
		{
			throw null;
		}

		// Token: 0x06000B23 RID: 2851 RVA: 0x0001655C File Offset: 0x0001475C
		[global::Cpp2ILInjected.Token(Token = "0x6000BCB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5606C", Offset = "0x1C5606C", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ThrowHelper), Member = "GetArraySegmentCtorValidationFailedException", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "GetArgumentName", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Enum), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static global::System.ArgumentOutOfRangeException GetArgumentOutOfRangeException(global::System.ExceptionArgument argument, global::System.ExceptionResource resource)
		{
			throw null;
		}

		// Token: 0x06000B24 RID: 2852 RVA: 0x0001655F File Offset: 0x0001475F
		[global::Cpp2ILInjected.Token(Token = "0x6000BCC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C554E4", Offset = "0x1C554E4", Length = "0x28C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new object[] { typeof(global::System.ExceptionResource) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new object[]
		{
			typeof(global::System.ExceptionResource),
			typeof(global::System.ExceptionArgument)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new object[]
		{
			typeof(global::System.ExceptionArgument),
			typeof(global::System.ExceptionResource)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ThrowHelper), Member = "ThrowInvalidOperationException", MemberParameters = new object[] { typeof(global::System.ExceptionResource) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ThrowHelper), Member = "ThrowSerializationException", MemberParameters = new object[] { typeof(global::System.ExceptionResource) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ThrowHelper), Member = "ThrowNotSupportedException", MemberParameters = new object[] { typeof(global::System.ExceptionResource) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 47)]
		internal static string GetResourceName(global::System.ExceptionResource resource)
		{
			throw null;
		}
	}
}
