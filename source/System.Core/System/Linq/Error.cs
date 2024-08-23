using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Linq
{
	// Token: 0x02000007 RID: 7
	[global::Cpp2ILInjected.Token(Token = "0x2000007")]
	internal static class Error
	{
		// Token: 0x06000031 RID: 49 RVA: 0x00004358 File Offset: 0x00002558
		[global::Cpp2ILInjected.Token(Token = "0x6000031")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3F2E8", Offset = "0x1D3F2E8", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 35)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static Exception ArgumentNull(string s)
		{
			throw null;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x0000435B File Offset: 0x0000255B
		[global::Cpp2ILInjected.Token(Token = "0x6000032")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3F344", Offset = "0x1D3F344", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Enumerable), Member = "ElementAt", MemberTypeParameters = new object[] { "TSource" }, MemberParameters = new object[]
		{
			"System.Collections.Generic.IEnumerable`1<TSource>",
			typeof(int)
		}, ReturnType = "TSource")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lookup<, >.Grouping), Member = "System.Collections.Generic.IList<TElement>.get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TElement")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static Exception ArgumentOutOfRange(string s)
		{
			throw null;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x0000435E File Offset: 0x0000255E
		[global::Cpp2ILInjected.Token(Token = "0x6000033")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3F3A0", Offset = "0x1D3F3A0", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Enumerable), Member = "Single", MemberTypeParameters = new object[] { "TSource" }, MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<TSource>" }, ReturnType = "TSource")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Enumerable), Member = "SingleOrDefault", MemberTypeParameters = new object[] { "TSource" }, MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<TSource>" }, ReturnType = "TSource")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal static Exception MoreThanOneElement()
		{
			throw null;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00004361 File Offset: 0x00002561
		[global::Cpp2ILInjected.Token(Token = "0x6000034")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3F40C", Offset = "0x1D3F40C", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Enumerable), Member = "SingleOrDefault", MemberTypeParameters = new object[] { "TSource" }, MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>" }, ReturnType = "TSource")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal static Exception MoreThanOneMatch()
		{
			throw null;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00004364 File Offset: 0x00002564
		[global::Cpp2ILInjected.Token(Token = "0x6000035")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3F478", Offset = "0x1D3F478", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Enumerable), Member = "First", MemberTypeParameters = new object[] { "TSource" }, MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<TSource>" }, ReturnType = "TSource")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Enumerable), Member = "Last", MemberTypeParameters = new object[] { "TSource" }, MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<TSource>" }, ReturnType = "TSource")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Enumerable), Member = "Single", MemberTypeParameters = new object[] { "TSource" }, MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<TSource>" }, ReturnType = "TSource")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Enumerable), Member = "Min", MemberParameters = new object[] { typeof(IEnumerable<int>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Enumerable), Member = "Max", MemberParameters = new object[] { typeof(IEnumerable<int>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal static Exception NoElements()
		{
			throw null;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00004367 File Offset: 0x00002567
		[global::Cpp2ILInjected.Token(Token = "0x6000036")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3F4E4", Offset = "0x1D3F4E4", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lookup<, >.Grouping), Member = "System.Collections.Generic.ICollection<TElement>.Add", MemberParameters = new object[] { "TElement" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lookup<, >.Grouping), Member = "System.Collections.Generic.ICollection<TElement>.Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lookup<, >.Grouping), Member = "System.Collections.Generic.ICollection<TElement>.Remove", MemberParameters = new object[] { "TElement" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lookup<, >.Grouping), Member = "System.Collections.Generic.IList<TElement>.Insert", MemberParameters = new object[]
		{
			typeof(int),
			"TElement"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lookup<, >.Grouping), Member = "System.Collections.Generic.IList<TElement>.RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lookup<, >.Grouping), Member = "System.Collections.Generic.IList<TElement>.set_Item", MemberParameters = new object[]
		{
			typeof(int),
			"TElement"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static Exception NotSupported()
		{
			throw null;
		}
	}
}
