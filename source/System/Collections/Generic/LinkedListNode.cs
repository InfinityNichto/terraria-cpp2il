using System;
using System.Net;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Collections.Generic
{
	// Token: 0x02000315 RID: 789
	[global::Cpp2ILInjected.Token(Token = "0x2000432")]
	public sealed class LinkedListNode<T>
	{
		// Token: 0x06001A11 RID: 6673 RVA: 0x00007790 File Offset: 0x00005990
		[global::Cpp2ILInjected.Token(Token = "0x6001D23")]
		[global::Cpp2ILInjected.Address(RVA = "0x1727AB0", Offset = "0x1727AB0", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal LinkedListNode(LinkedList<T> list, T value)
		{
			throw null;
		}

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x06001A12 RID: 6674 RVA: 0x00007793 File Offset: 0x00005993
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

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x06001A13 RID: 6675 RVA: 0x00007796 File Offset: 0x00005996
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

		// Token: 0x06001A14 RID: 6676 RVA: 0x00007799 File Offset: 0x00005999
		[global::Cpp2ILInjected.Token(Token = "0x6001D26")]
		[global::Cpp2ILInjected.Address(RVA = "0x1727B1C", Offset = "0x1727B1C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void Invalidate()
		{
			throw null;
		}

		// Token: 0x04000F86 RID: 3974
		[global::Cpp2ILInjected.Token(Token = "0x40013E4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		internal LinkedList<T> list;

		// Token: 0x04000F87 RID: 3975
		[global::Cpp2ILInjected.Token(Token = "0x40013E5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		internal LinkedListNode<T> next;

		// Token: 0x04000F88 RID: 3976
		[global::Cpp2ILInjected.Token(Token = "0x40013E6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		internal LinkedListNode<T> prev;

		// Token: 0x04000F89 RID: 3977
		[global::Cpp2ILInjected.Token(Token = "0x40013E7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		internal T item;
	}
}
