using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Collections.Generic
{
	// Token: 0x02000531 RID: 1329
	[global::Cpp2ILInjected.Token(Token = "0x200064F")]
	internal class ArraySortHelper<T>
	{
		// Token: 0x06002CC0 RID: 11456 RVA: 0x0001C1A2 File Offset: 0x0001A3A2
		[global::Cpp2ILInjected.Token(Token = "0x6003151")]
		[global::Cpp2ILInjected.Address(RVA = "0x15C7E90", Offset = "0x15C7E90", Length = "0x280")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntrospectiveSortUtilities), Member = "ThrowOrIgnoreBadComparer", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 28)]
		public void Sort(T[] keys, int index, int length, IComparer<T> comparer)
		{
			throw null;
		}

		// Token: 0x06002CC1 RID: 11457 RVA: 0x0001C1A5 File Offset: 0x0001A3A5
		[global::Cpp2ILInjected.Token(Token = "0x6003152")]
		[global::Cpp2ILInjected.Address(RVA = "0x15C8110", Offset = "0x15C8110", Length = "0x19C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		public int BinarySearch(T[] array, int index, int length, T value, IComparer<T> comparer)
		{
			throw null;
		}

		// Token: 0x06002CC2 RID: 11458 RVA: 0x0001C1A8 File Offset: 0x0001A3A8
		[global::Cpp2ILInjected.Token(Token = "0x6003153")]
		[global::Cpp2ILInjected.Address(RVA = "0x15C82AC", Offset = "0x15C82AC", Length = "0x1DC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntrospectiveSortUtilities), Member = "ThrowOrIgnoreBadComparer", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 26)]
		internal static void Sort(T[] keys, int index, int length, global::System.Comparison<T> comparer)
		{
			throw null;
		}

		// Token: 0x06002CC3 RID: 11459 RVA: 0x0001C1AB File Offset: 0x0001A3AB
		[global::Cpp2ILInjected.Token(Token = "0x6003154")]
		[global::Cpp2ILInjected.Address(RVA = "0x15C8488", Offset = "0x15C8488", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal static int InternalBinarySearch(T[] array, int index, int length, T value, IComparer<T> comparer)
		{
			throw null;
		}

		// Token: 0x06002CC4 RID: 11460 RVA: 0x0001C1AE File Offset: 0x0001A3AE
		[global::Cpp2ILInjected.Token(Token = "0x6003155")]
		[global::Cpp2ILInjected.Address(RVA = "0x15C85AC", Offset = "0x15C85AC", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static void SwapIfGreater(T[] keys, global::System.Comparison<T> comparer, int a, int b)
		{
			throw null;
		}

		// Token: 0x06002CC5 RID: 11461 RVA: 0x0001C1B1 File Offset: 0x0001A3B1
		[global::Cpp2ILInjected.Token(Token = "0x6003156")]
		[global::Cpp2ILInjected.Address(RVA = "0x15C8674", Offset = "0x15C8674", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static void Swap(T[] a, int i, int j)
		{
			throw null;
		}

		// Token: 0x06002CC6 RID: 11462 RVA: 0x0001C1B4 File Offset: 0x0001A3B4
		[global::Cpp2ILInjected.Token(Token = "0x6003157")]
		[global::Cpp2ILInjected.Address(RVA = "0x15C8694", Offset = "0x15C8694", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntrospectiveSortUtilities), Member = "FloorLog2PlusOne", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal static void IntrospectiveSort(T[] keys, int left, int length, global::System.Comparison<T> comparer)
		{
			throw null;
		}

		// Token: 0x06002CC7 RID: 11463 RVA: 0x0001C1B7 File Offset: 0x0001A3B7
		[global::Cpp2ILInjected.Token(Token = "0x6003158")]
		[global::Cpp2ILInjected.Address(RVA = "0x15C8790", Offset = "0x15C8790", Length = "0x4AC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 33)]
		private static void IntroSort(T[] keys, int lo, int hi, int depthLimit, global::System.Comparison<T> comparer)
		{
			throw null;
		}

		// Token: 0x06002CC8 RID: 11464 RVA: 0x0001C1BA File Offset: 0x0001A3BA
		[global::Cpp2ILInjected.Token(Token = "0x6003159")]
		[global::Cpp2ILInjected.Address(RVA = "0x15C8C3C", Offset = "0x15C8C3C", Length = "0x40C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		private static int PickPivotAndPartition(T[] keys, int lo, int hi, global::System.Comparison<T> comparer)
		{
			throw null;
		}

		// Token: 0x06002CC9 RID: 11465 RVA: 0x0001C1BD File Offset: 0x0001A3BD
		[global::Cpp2ILInjected.Token(Token = "0x600315A")]
		[global::Cpp2ILInjected.Address(RVA = "0x15C9048", Offset = "0x15C9048", Length = "0x1F8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private static void Heapsort(T[] keys, int lo, int hi, global::System.Comparison<T> comparer)
		{
			throw null;
		}

		// Token: 0x06002CCA RID: 11466 RVA: 0x0001C1C0 File Offset: 0x0001A3C0
		[global::Cpp2ILInjected.Token(Token = "0x600315B")]
		[global::Cpp2ILInjected.Address(RVA = "0x15C9240", Offset = "0x15C9240", Length = "0x1C4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static void DownHeap(T[] keys, int i, int n, int lo, global::System.Comparison<T> comparer)
		{
			throw null;
		}

		// Token: 0x06002CCB RID: 11467 RVA: 0x0001C1C3 File Offset: 0x0001A3C3
		[global::Cpp2ILInjected.Token(Token = "0x600315C")]
		[global::Cpp2ILInjected.Address(RVA = "0x15C9404", Offset = "0x15C9404", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static void InsertionSort(T[] keys, int lo, int hi, global::System.Comparison<T> comparer)
		{
			throw null;
		}

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x06002CCC RID: 11468 RVA: 0x0001C1C6 File Offset: 0x0001A3C6
		[global::Cpp2ILInjected.Token(Token = "0x170007F6")]
		public static ArraySortHelper<T> Default
		{
			[global::Cpp2ILInjected.Token(Token = "0x600315D")]
			[global::Cpp2ILInjected.Address(RVA = "0x15C9528", Offset = "0x15C9528", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002CCD RID: 11469 RVA: 0x0001C1C9 File Offset: 0x0001A3C9
		[global::Cpp2ILInjected.Token(Token = "0x600315E")]
		[global::Cpp2ILInjected.Address(RVA = "0x15C9594", Offset = "0x15C9594", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ArraySortHelper()
		{
			throw null;
		}

		// Token: 0x06002CCE RID: 11470 RVA: 0x0001C1CC File Offset: 0x0001A3CC
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600315F")]
		[global::Cpp2ILInjected.Address(RVA = "0x15C959C", Offset = "0x15C959C", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		static ArraySortHelper()
		{
			throw null;
		}

		// Token: 0x04001636 RID: 5686
		[global::Cpp2ILInjected.Token(Token = "0x4001AA5")]
		private static readonly ArraySortHelper<T> s_defaultArraySortHelper;
	}
}
