using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Collections.Generic
{
	[global::Cpp2ILInjected.Token(Token = "0x200064E")]
	internal static class IntrospectiveSortUtilities
	{
		[global::Cpp2ILInjected.Token(Token = "0x600314F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C15080", Offset = "0x1C15080", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Array.SorterObjectArray", Member = "IntrospectiveSort", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Array.SorterGenericArray", Member = "IntrospectiveSort", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ArraySortHelper<>), Member = "IntrospectiveSort", MemberParameters = new object[]
		{
			"T[]",
			typeof(int),
			typeof(int),
			"System.Comparison`1<T>"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ArraySortHelper<, >), Member = "IntrospectiveSort", MemberParameters = new object[]
		{
			"TKey[]",
			"TValue[]",
			typeof(int),
			typeof(int),
			"System.Collections.Generic.IComparer`1<TKey>"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		internal static int FloorLog2PlusOne(int n)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003150")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C150B4", Offset = "0x1C150B4", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Array.SorterObjectArray", Member = "IntrospectiveSort", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Array.SorterGenericArray", Member = "IntrospectiveSort", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ArraySortHelper<>), Member = "Sort", MemberParameters = new object[]
		{
			"T[]",
			typeof(int),
			typeof(int),
			"System.Collections.Generic.IComparer`1<T>"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ArraySortHelper<>), Member = "Sort", MemberParameters = new object[]
		{
			"T[]",
			typeof(int),
			typeof(int),
			"System.Comparison`1<T>"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ArraySortHelper<, >), Member = "Sort", MemberParameters = new object[]
		{
			"TKey[]",
			"TValue[]",
			typeof(int),
			typeof(int),
			"System.Collections.Generic.IComparer`1<TKey>"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal static void ThrowOrIgnoreBadComparer(object comparer)
		{
			throw null;
		}
	}
}
