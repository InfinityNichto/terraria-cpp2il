using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Linq
{
	// Token: 0x02000013 RID: 19
	[global::Cpp2ILInjected.Token(Token = "0x200002A")]
	internal class EnumerableSorter<TElement, TKey> : EnumerableSorter<TElement>
	{
		// Token: 0x06000089 RID: 137 RVA: 0x00004451 File Offset: 0x00002651
		[global::Cpp2ILInjected.Token(Token = "0x6000128")]
		[global::Cpp2ILInjected.Address(RVA = "0x1642848", Offset = "0x1642848", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal EnumerableSorter(Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending, EnumerableSorter<TElement> next)
		{
			throw null;
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00004454 File Offset: 0x00002654
		[global::Cpp2ILInjected.Token(Token = "0x6000129")]
		[global::Cpp2ILInjected.Address(RVA = "0x1642898", Offset = "0x1642898", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal override void ComputeKeys(TElement[] elements, int count)
		{
			throw null;
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00004457 File Offset: 0x00002657
		[global::Cpp2ILInjected.Token(Token = "0x600012A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1642990", Offset = "0x1642990", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal override int CompareKeys(int index1, int index2)
		{
			throw null;
		}

		// Token: 0x04000023 RID: 35
		[global::Cpp2ILInjected.Token(Token = "0x400009D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		internal Func<TElement, TKey> keySelector;

		// Token: 0x04000024 RID: 36
		[global::Cpp2ILInjected.Token(Token = "0x400009E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		internal IComparer<TKey> comparer;

		// Token: 0x04000025 RID: 37
		[global::Cpp2ILInjected.Token(Token = "0x400009F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		internal bool descending;

		// Token: 0x04000026 RID: 38
		[global::Cpp2ILInjected.Token(Token = "0x40000A0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		internal EnumerableSorter<TElement> next;

		// Token: 0x04000027 RID: 39
		[global::Cpp2ILInjected.Token(Token = "0x40000A1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		internal TKey[] keys;
	}
}
