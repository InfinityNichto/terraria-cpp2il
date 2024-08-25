using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Collections.Generic
{
	[global::Cpp2ILInjected.Token(Token = "0x200063F")]
	internal struct LargeArrayBuilder<T>
	{
		[global::Cpp2ILInjected.Token(Token = "0x60030EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1727228", Offset = "0x1727228", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EnumerableHelpers), Member = "ToArray", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<T>" }, ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public LargeArrayBuilder(bool initialize)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60030ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1727260", Offset = "0x1727260", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public LargeArrayBuilder(int maxCapacity)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60030EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x17272E4", Offset = "0x17272E4", Length = "0x36C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EnumerableHelpers), Member = "ToArray", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<T>" }, ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LargeArrayBuilder<>), Member = "AddWithBufferAllocation", MemberParameters = new object[]
		{
			"T",
			"T[]&",
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public void AddRange(IEnumerable<T> items)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60030EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1727650", Offset = "0x1727650", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LargeArrayBuilder<>), Member = "AddRange", MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<T>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LargeArrayBuilder<>), Member = "AllocateBuffer", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(8)]
		private void AddWithBufferAllocation(T item, ref T[] destination, ref int index)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60030F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x17276D4", Offset = "0x17276D4", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LargeArrayBuilder<>), Member = "ToArray", ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LargeArrayBuilder<>), Member = "GetBuffer", MemberParameters = new object[] { typeof(int) }, ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void CopyTo(T[] array, int arrayIndex, int count)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60030F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x17277C8", Offset = "0x17277C8", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LargeArrayBuilder<>), Member = "CopyTo", MemberParameters = new object[]
		{
			"T[]",
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayBuilder<>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public T[] GetBuffer(int index)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60030F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1727848", Offset = "0x1727848", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EnumerableHelpers), Member = "ToArray", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<T>" }, ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LargeArrayBuilder<>), Member = "CopyTo", MemberParameters = new object[]
		{
			"T[]",
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public T[] ToArray()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60030F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1727900", Offset = "0x1727900", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool TryMove(out T[] array)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60030F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1727920", Offset = "0x1727920", Length = "0x190")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LargeArrayBuilder<>), Member = "AddWithBufferAllocation", MemberParameters = new object[]
		{
			"T",
			"T[]&",
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayBuilder<>), Member = "Add", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private void AllocateBuffer()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4001A7E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly int _maxCapacity;

		[global::Cpp2ILInjected.Token(Token = "0x4001A7F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private T[] _first;

		[global::Cpp2ILInjected.Token(Token = "0x4001A80")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private ArrayBuilder<T[]> _buffers;

		[global::Cpp2ILInjected.Token(Token = "0x4001A81")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private T[] _current;

		[global::Cpp2ILInjected.Token(Token = "0x4001A82")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int _index;

		[global::Cpp2ILInjected.Token(Token = "0x4001A83")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int _count;
	}
}
