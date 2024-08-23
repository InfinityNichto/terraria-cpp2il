using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Linq
{
	// Token: 0x02000012 RID: 18
	[global::Cpp2ILInjected.Token(Token = "0x2000029")]
	internal abstract class EnumerableSorter<TElement>
	{
		// Token: 0x06000084 RID: 132
		[global::Cpp2ILInjected.Token(Token = "0x6000123")]
		internal abstract void ComputeKeys(TElement[] elements, int count);

		// Token: 0x06000085 RID: 133
		[global::Cpp2ILInjected.Token(Token = "0x6000124")]
		internal abstract int CompareKeys(int index1, int index2);

		// Token: 0x06000086 RID: 134 RVA: 0x00004448 File Offset: 0x00002648
		[global::Cpp2ILInjected.Token(Token = "0x6000125")]
		[global::Cpp2ILInjected.Address(RVA = "0x16423B0", Offset = "0x16423B0", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal int[] Sort(TElement[] elements, int count)
		{
			throw null;
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0000444B File Offset: 0x0000264B
		[global::Cpp2ILInjected.Token(Token = "0x6000126")]
		[global::Cpp2ILInjected.Address(RVA = "0x164247C", Offset = "0x164247C", Length = "0x178")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void QuickSort(int[] map, int left, int right)
		{
			throw null;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0000444E File Offset: 0x0000264E
		[global::Cpp2ILInjected.Token(Token = "0x6000127")]
		[global::Cpp2ILInjected.Address(RVA = "0x16425F4", Offset = "0x16425F4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected EnumerableSorter()
		{
			throw null;
		}
	}
}
