using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Collections.Generic
{
	[global::Cpp2ILInjected.Token(Token = "0x200064F")]
	internal class ArraySortHelper<T>
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x6003156")]
		[global::Cpp2ILInjected.Address(RVA = "0x15C8674", Offset = "0x15C8674", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static void Swap(T[] a, int i, int j)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x600315E")]
		[global::Cpp2ILInjected.Address(RVA = "0x15C9594", Offset = "0x15C9594", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ArraySortHelper()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x4001AA5")]
		private static readonly ArraySortHelper<T> s_defaultArraySortHelper;
	}
}
