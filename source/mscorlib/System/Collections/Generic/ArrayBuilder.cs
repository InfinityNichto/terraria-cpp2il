using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Collections.Generic
{
	[global::Cpp2ILInjected.Token(Token = "0x200063D")]
	internal struct ArrayBuilder<T>
	{
		[global::Cpp2ILInjected.Token(Token = "0x170007E2")]
		public int Capacity
		{
			[global::Cpp2ILInjected.Token(Token = "0x60030E5")]
			[global::Cpp2ILInjected.Address(RVA = "0x15C64F4", Offset = "0x15C64F4", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170007E3")]
		public int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x60030E6")]
			[global::Cpp2ILInjected.Address(RVA = "0x15C650C", Offset = "0x15C650C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170007E4")]
		public T this[int index]
		{
			[global::Cpp2ILInjected.Token(Token = "0x60030E7")]
			[global::Cpp2ILInjected.Address(RVA = "0x15C6514", Offset = "0x15C6514", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LargeArrayBuilder<>), Member = "GetBuffer", MemberParameters = new object[] { typeof(int) }, ReturnType = "T[]")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60030E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x15C6524", Offset = "0x15C6524", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LargeArrayBuilder<>), Member = "AllocateBuffer", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayBuilder<>), Member = "EnsureCapacity", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void Add(T item)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60030E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x15C65C8", Offset = "0x15C65C8", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void UncheckedAdd(T item)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60030EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x15C65E4", Offset = "0x15C65E4", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ArrayBuilder<>), Member = "Add", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Math), Member = "Max", MemberParameters = new object[]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private void EnsureCapacity(int minimum)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4001A7C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private T[] _array;

		[global::Cpp2ILInjected.Token(Token = "0x4001A7D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int _count;
	}
}
