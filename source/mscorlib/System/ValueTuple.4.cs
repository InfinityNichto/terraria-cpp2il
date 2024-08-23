using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x020000EC RID: 236
	[global::Cpp2ILInjected.Token(Token = "0x200011E")]
	[global::System.Serializable]
	[StructLayout(3)]
	public struct ValueTuple<T1, T2, T3> : global::System.IEquatable<global::System.ValueTuple<T1, T2, T3>>, global::System.Collections.IStructuralEquatable, global::System.Collections.IStructuralComparable, global::System.IComparable, global::System.IComparable<global::System.ValueTuple<T1, T2, T3>>, global::System.IValueTupleInternal, global::System.Runtime.CompilerServices.ITuple
	{
		// Token: 0x06000A92 RID: 2706 RVA: 0x000163B2 File Offset: 0x000145B2
		[global::Cpp2ILInjected.Token(Token = "0x6000B3A")]
		[global::Cpp2ILInjected.Address(RVA = "0x18B4210", Offset = "0x18B4210", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.BitConverter), Member = "ToString", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public ValueTuple(T1 item1, T2 item2, T3 item3)
		{
			throw null;
		}

		// Token: 0x06000A93 RID: 2707 RVA: 0x000163B5 File Offset: 0x000145B5
		[global::Cpp2ILInjected.Token(Token = "0x6000B3B")]
		[global::Cpp2ILInjected.Address(RVA = "0x18B421C", Offset = "0x18B421C", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06000A94 RID: 2708 RVA: 0x000163B8 File Offset: 0x000145B8
		[global::Cpp2ILInjected.Token(Token = "0x6000B3C")]
		[global::Cpp2ILInjected.Address(RVA = "0x18B4300", Offset = "0x18B4300", Length = "0x168")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public bool Equals(global::System.ValueTuple<T1, T2, T3> other)
		{
			throw null;
		}

		// Token: 0x06000A95 RID: 2709 RVA: 0x000163BB File Offset: 0x000145BB
		[global::Cpp2ILInjected.Token(Token = "0x6000B3D")]
		[global::Cpp2ILInjected.Address(RVA = "0x18B4468", Offset = "0x18B4468", Length = "0x310")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		private bool System.Collections.IStructuralEquatable.Equals(object other, global::System.Collections.IEqualityComparer comparer)
		{
			throw null;
		}

		// Token: 0x06000A96 RID: 2710 RVA: 0x000163BE File Offset: 0x000145BE
		[global::Cpp2ILInjected.Token(Token = "0x6000B3E")]
		[global::Cpp2ILInjected.Address(RVA = "0x18B4778", Offset = "0x18B4778", Length = "0x18C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		private int System.IComparable.CompareTo(object other)
		{
			throw null;
		}

		// Token: 0x06000A97 RID: 2711 RVA: 0x000163C1 File Offset: 0x000145C1
		[global::Cpp2ILInjected.Token(Token = "0x6000B3F")]
		[global::Cpp2ILInjected.Address(RVA = "0x18B4904", Offset = "0x18B4904", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public int CompareTo(global::System.ValueTuple<T1, T2, T3> other)
		{
			throw null;
		}

		// Token: 0x06000A98 RID: 2712 RVA: 0x000163C4 File Offset: 0x000145C4
		[global::Cpp2ILInjected.Token(Token = "0x6000B40")]
		[global::Cpp2ILInjected.Address(RVA = "0x18B4A68", Offset = "0x18B4A68", Length = "0x3B8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 31)]
		private int System.Collections.IStructuralComparable.CompareTo(object other, global::System.Collections.IComparer comparer)
		{
			throw null;
		}

		// Token: 0x06000A99 RID: 2713 RVA: 0x000163C7 File Offset: 0x000145C7
		[global::Cpp2ILInjected.Token(Token = "0x6000B41")]
		[global::Cpp2ILInjected.Address(RVA = "0x18B4E20", Offset = "0x18B4E20", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ValueTuple), Member = "CombineHashCodes", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06000A9A RID: 2714 RVA: 0x000163CA File Offset: 0x000145CA
		[global::Cpp2ILInjected.Token(Token = "0x6000B42")]
		[global::Cpp2ILInjected.Address(RVA = "0x18B4EC0", Offset = "0x18B4EC0", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private int System.Collections.IStructuralEquatable.GetHashCode(global::System.Collections.IEqualityComparer comparer)
		{
			throw null;
		}

		// Token: 0x06000A9B RID: 2715 RVA: 0x000163CD File Offset: 0x000145CD
		[global::Cpp2ILInjected.Token(Token = "0x6000B43")]
		[global::Cpp2ILInjected.Address(RVA = "0x18B4F04", Offset = "0x18B4F04", Length = "0x218")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ValueTuple<, , >), Member = "System.IValueTupleInternal.GetHashCode", MemberParameters = new object[] { typeof(global::System.Collections.IEqualityComparer) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ValueTuple), Member = "CombineHashCodes", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private int GetHashCodeCore(global::System.Collections.IEqualityComparer comparer)
		{
			throw null;
		}

		// Token: 0x06000A9C RID: 2716 RVA: 0x000163D0 File Offset: 0x000145D0
		[global::Cpp2ILInjected.Token(Token = "0x6000B44")]
		[global::Cpp2ILInjected.Address(RVA = "0x18B511C", Offset = "0x18B511C", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ValueTuple<, , >), Member = "GetHashCodeCore", MemberParameters = new object[] { typeof(global::System.Collections.IEqualityComparer) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private int System.IValueTupleInternal.GetHashCode(global::System.Collections.IEqualityComparer comparer)
		{
			throw null;
		}

		// Token: 0x06000A9D RID: 2717 RVA: 0x000163D3 File Offset: 0x000145D3
		[global::Cpp2ILInjected.Token(Token = "0x6000B45")]
		[global::Cpp2ILInjected.Address(RVA = "0x18B5160", Offset = "0x18B5160", Length = "0x1F4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06000A9E RID: 2718 RVA: 0x000163D6 File Offset: 0x000145D6
		[global::Cpp2ILInjected.Token(Token = "0x6000B46")]
		[global::Cpp2ILInjected.Address(RVA = "0x18B5354", Offset = "0x18B5354", Length = "0x1C0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		private string System.IValueTupleInternal.ToStringEnd()
		{
			throw null;
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000A9F RID: 2719 RVA: 0x000163D9 File Offset: 0x000145D9
		[global::Cpp2ILInjected.Token(Token = "0x170000F7")]
		private int System.Runtime.CompilerServices.ITuple.Length
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B47")]
			[global::Cpp2ILInjected.Address(RVA = "0x18B5514", Offset = "0x18B5514", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x040002B2 RID: 690
		[global::Cpp2ILInjected.Token(Token = "0x4000404")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public T1 Item1;

		// Token: 0x040002B3 RID: 691
		[global::Cpp2ILInjected.Token(Token = "0x4000405")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public T2 Item2;

		// Token: 0x040002B4 RID: 692
		[global::Cpp2ILInjected.Token(Token = "0x4000406")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public T3 Item3;
	}
}
