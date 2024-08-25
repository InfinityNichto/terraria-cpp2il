using System;
using System.Net;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Collections.Generic
{
	[global::Cpp2ILInjected.Token(Token = "0x2000432")]
	public sealed class LinkedListNode<T>
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001D23")]
		[global::Cpp2ILInjected.Address(RVA = "0x1727AB0", Offset = "0x1727AB0", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal LinkedListNode(LinkedList<T> list, T value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000689")]
		public LinkedListNode<T> Next
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D24")]
			[global::Cpp2ILInjected.Address(RVA = "0x1727AEC", Offset = "0x1727AEC", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServicePointScheduler), Member = "RemoveOperation", MemberParameters = new object[] { typeof(WebOperation) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700068A")]
		public T Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D25")]
			[global::Cpp2ILInjected.Address(RVA = "0x1727B10", Offset = "0x1727B10", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001D26")]
		[global::Cpp2ILInjected.Address(RVA = "0x1727B1C", Offset = "0x1727B1C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void Invalidate()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40013E4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		internal LinkedList<T> list;

		[global::Cpp2ILInjected.Token(Token = "0x40013E5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		internal LinkedListNode<T> next;

		[global::Cpp2ILInjected.Token(Token = "0x40013E6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		internal LinkedListNode<T> prev;

		[global::Cpp2ILInjected.Token(Token = "0x40013E7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		internal T item;
	}
}
