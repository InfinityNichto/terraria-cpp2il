using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x020000EB RID: 235
	[global::Cpp2ILInjected.Token(Token = "0x200011D")]
	[global::System.Serializable]
	[StructLayout(3)]
	public struct ValueTuple<T1, T2> : global::System.IEquatable<global::System.ValueTuple<T1, T2>>, global::System.Collections.IStructuralEquatable, global::System.Collections.IStructuralComparable, global::System.IComparable, global::System.IComparable<global::System.ValueTuple<T1, T2>>, global::System.IValueTupleInternal, global::System.Runtime.CompilerServices.ITuple
	{
		// Token: 0x06000A84 RID: 2692 RVA: 0x00016388 File Offset: 0x00014588
		[global::Cpp2ILInjected.Token(Token = "0x6000B2C")]
		[global::Cpp2ILInjected.Address(RVA = "0x18AFA40", Offset = "0x18AFA40", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebOperation", Member = "Finish", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public ValueTuple(T1 item1, T2 item2)
		{
			throw null;
		}

		// Token: 0x06000A85 RID: 2693 RVA: 0x0001638B File Offset: 0x0001458B
		[global::Cpp2ILInjected.Token(Token = "0x6000B2D")]
		[global::Cpp2ILInjected.Address(RVA = "0x18AFA50", Offset = "0x18AFA50", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06000A86 RID: 2694 RVA: 0x0001638E File Offset: 0x0001458E
		[global::Cpp2ILInjected.Token(Token = "0x6000B2E")]
		[global::Cpp2ILInjected.Address(RVA = "0x18AFB34", Offset = "0x18AFB34", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public bool Equals(global::System.ValueTuple<T1, T2> other)
		{
			throw null;
		}

		// Token: 0x06000A87 RID: 2695 RVA: 0x00016391 File Offset: 0x00014591
		[global::Cpp2ILInjected.Token(Token = "0x6000B2F")]
		[global::Cpp2ILInjected.Address(RVA = "0x18AFC34", Offset = "0x18AFC34", Length = "0x22C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private bool System.Collections.IStructuralEquatable.Equals(object other, global::System.Collections.IEqualityComparer comparer)
		{
			throw null;
		}

		// Token: 0x06000A88 RID: 2696 RVA: 0x00016394 File Offset: 0x00014594
		[global::Cpp2ILInjected.Token(Token = "0x6000B30")]
		[global::Cpp2ILInjected.Address(RVA = "0x18AFE60", Offset = "0x18AFE60", Length = "0x18C")]
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

		// Token: 0x06000A89 RID: 2697 RVA: 0x00016397 File Offset: 0x00014597
		[global::Cpp2ILInjected.Token(Token = "0x6000B31")]
		[global::Cpp2ILInjected.Address(RVA = "0x18AFFEC", Offset = "0x18AFFEC", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public int CompareTo(global::System.ValueTuple<T1, T2> other)
		{
			throw null;
		}

		// Token: 0x06000A8A RID: 2698 RVA: 0x0001639A File Offset: 0x0001459A
		[global::Cpp2ILInjected.Token(Token = "0x6000B32")]
		[global::Cpp2ILInjected.Address(RVA = "0x18B00E8", Offset = "0x18B00E8", Length = "0x2D4")]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		private int System.Collections.IStructuralComparable.CompareTo(object other, global::System.Collections.IComparer comparer)
		{
			throw null;
		}

		// Token: 0x06000A8B RID: 2699 RVA: 0x0001639D File Offset: 0x0001459D
		[global::Cpp2ILInjected.Token(Token = "0x6000B33")]
		[global::Cpp2ILInjected.Address(RVA = "0x18B03BC", Offset = "0x18B03BC", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(bool), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ValueTuple), Member = "CombineHashCodes", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06000A8C RID: 2700 RVA: 0x000163A0 File Offset: 0x000145A0
		[global::Cpp2ILInjected.Token(Token = "0x6000B34")]
		[global::Cpp2ILInjected.Address(RVA = "0x18B0424", Offset = "0x18B0424", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private int System.Collections.IStructuralEquatable.GetHashCode(global::System.Collections.IEqualityComparer comparer)
		{
			throw null;
		}

		// Token: 0x06000A8D RID: 2701 RVA: 0x000163A3 File Offset: 0x000145A3
		[global::Cpp2ILInjected.Token(Token = "0x6000B35")]
		[global::Cpp2ILInjected.Address(RVA = "0x18B0468", Offset = "0x18B0468", Length = "0x160")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ValueTuple<, >), Member = "System.IValueTupleInternal.GetHashCode", MemberParameters = new object[] { typeof(global::System.Collections.IEqualityComparer) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ValueTuple), Member = "CombineHashCodes", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private int GetHashCodeCore(global::System.Collections.IEqualityComparer comparer)
		{
			throw null;
		}

		// Token: 0x06000A8E RID: 2702 RVA: 0x000163A6 File Offset: 0x000145A6
		[global::Cpp2ILInjected.Token(Token = "0x6000B36")]
		[global::Cpp2ILInjected.Address(RVA = "0x18B05C8", Offset = "0x18B05C8", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ValueTuple<, >), Member = "GetHashCodeCore", MemberParameters = new object[] { typeof(global::System.Collections.IEqualityComparer) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private int System.IValueTupleInternal.GetHashCode(global::System.Collections.IEqualityComparer comparer)
		{
			throw null;
		}

		// Token: 0x06000A8F RID: 2703 RVA: 0x000163A9 File Offset: 0x000145A9
		[global::Cpp2ILInjected.Token(Token = "0x6000B37")]
		[global::Cpp2ILInjected.Address(RVA = "0x18B060C", Offset = "0x18B060C", Length = "0x18C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(bool), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06000A90 RID: 2704 RVA: 0x000163AC File Offset: 0x000145AC
		[global::Cpp2ILInjected.Token(Token = "0x6000B38")]
		[global::Cpp2ILInjected.Address(RVA = "0x18B0798", Offset = "0x18B0798", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(bool), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private string System.IValueTupleInternal.ToStringEnd()
		{
			throw null;
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000A91 RID: 2705 RVA: 0x000163AF File Offset: 0x000145AF
		[global::Cpp2ILInjected.Token(Token = "0x170000F6")]
		private int System.Runtime.CompilerServices.ITuple.Length
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B39")]
			[global::Cpp2ILInjected.Address(RVA = "0x18B084C", Offset = "0x18B084C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x040002B0 RID: 688
		[global::Cpp2ILInjected.Token(Token = "0x4000402")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public T1 Item1;

		// Token: 0x040002B1 RID: 689
		[global::Cpp2ILInjected.Token(Token = "0x4000403")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public T2 Item2;
	}
}
