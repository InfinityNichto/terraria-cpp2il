using System;
using System.Collections;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x020000EE RID: 238
	[global::Cpp2ILInjected.Token(Token = "0x2000120")]
	[global::System.Serializable]
	[StructLayout(3)]
	public struct ValueTuple<T1, T2, T3, T4, T5> : global::System.IEquatable<global::System.ValueTuple<T1, T2, T3, T4, T5>>, global::System.Collections.IStructuralEquatable, global::System.Collections.IStructuralComparable, global::System.IComparable, global::System.IComparable<global::System.ValueTuple<T1, T2, T3, T4, T5>>, global::System.IValueTupleInternal, global::System.Runtime.CompilerServices.ITuple
	{
		// Token: 0x06000AAE RID: 2734 RVA: 0x00016406 File Offset: 0x00014606
		[global::Cpp2ILInjected.Token(Token = "0x6000B56")]
		[global::Cpp2ILInjected.Address(RVA = "0x18BA168", Offset = "0x18BA168", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Path), Member = "JoinInternal", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public ValueTuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5)
		{
			throw null;
		}

		// Token: 0x06000AAF RID: 2735 RVA: 0x00016409 File Offset: 0x00014609
		[global::Cpp2ILInjected.Token(Token = "0x6000B57")]
		[global::Cpp2ILInjected.Address(RVA = "0x18BA184", Offset = "0x18BA184", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ValueTuple<, , , , >), Member = "Equals", MemberParameters = new object[] { "System.ValueTuple`5<T1, T2, T3, T4, T5>" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06000AB0 RID: 2736 RVA: 0x0001640C File Offset: 0x0001460C
		[global::Cpp2ILInjected.Token(Token = "0x6000B58")]
		[global::Cpp2ILInjected.Address(RVA = "0x18BA274", Offset = "0x18BA274", Length = "0x22C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ValueTuple<, , , , >), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public bool Equals(global::System.ValueTuple<T1, T2, T3, T4, T5> other)
		{
			throw null;
		}

		// Token: 0x06000AB1 RID: 2737 RVA: 0x0001640F File Offset: 0x0001460F
		[global::Cpp2ILInjected.Token(Token = "0x6000B59")]
		[global::Cpp2ILInjected.Address(RVA = "0x18BA4A0", Offset = "0x18BA4A0", Length = "0x548")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 42)]
		private bool System.Collections.IStructuralEquatable.Equals(object other, global::System.Collections.IEqualityComparer comparer)
		{
			throw null;
		}

		// Token: 0x06000AB2 RID: 2738 RVA: 0x00016412 File Offset: 0x00014612
		[global::Cpp2ILInjected.Token(Token = "0x6000B5A")]
		[global::Cpp2ILInjected.Address(RVA = "0x18BA9E8", Offset = "0x18BA9E8", Length = "0x188")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ValueTuple<, , , , >), Member = "CompareTo", MemberParameters = new object[] { "System.ValueTuple`5<T1, T2, T3, T4, T5>" }, ReturnType = typeof(int))]
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

		// Token: 0x06000AB3 RID: 2739 RVA: 0x00016415 File Offset: 0x00014615
		[global::Cpp2ILInjected.Token(Token = "0x6000B5B")]
		[global::Cpp2ILInjected.Address(RVA = "0x18BAB70", Offset = "0x18BAB70", Length = "0x228")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ValueTuple<, , , , >), Member = "System.IComparable.CompareTo", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public int CompareTo(global::System.ValueTuple<T1, T2, T3, T4, T5> other)
		{
			throw null;
		}

		// Token: 0x06000AB4 RID: 2740 RVA: 0x00016418 File Offset: 0x00014618
		[global::Cpp2ILInjected.Token(Token = "0x6000B5C")]
		[global::Cpp2ILInjected.Address(RVA = "0x18BAD98", Offset = "0x18BAD98", Length = "0x5E8")]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 51)]
		private int System.Collections.IStructuralComparable.CompareTo(object other, global::System.Collections.IComparer comparer)
		{
			throw null;
		}

		// Token: 0x06000AB5 RID: 2741 RVA: 0x0001641B File Offset: 0x0001461B
		[global::Cpp2ILInjected.Token(Token = "0x6000B5D")]
		[global::Cpp2ILInjected.Address(RVA = "0x18BB380", Offset = "0x18BB380", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(bool), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ValueTuple), Member = "CombineHashCodes", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06000AB6 RID: 2742 RVA: 0x0001641E File Offset: 0x0001461E
		[global::Cpp2ILInjected.Token(Token = "0x6000B5E")]
		[global::Cpp2ILInjected.Address(RVA = "0x18BB48C", Offset = "0x18BB48C", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private int System.Collections.IStructuralEquatable.GetHashCode(global::System.Collections.IEqualityComparer comparer)
		{
			throw null;
		}

		// Token: 0x06000AB7 RID: 2743 RVA: 0x00016421 File Offset: 0x00014621
		[global::Cpp2ILInjected.Token(Token = "0x6000B5F")]
		[global::Cpp2ILInjected.Address(RVA = "0x18BB4D0", Offset = "0x18BB4D0", Length = "0x3AC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ValueTuple<, , , , >), Member = "System.IValueTupleInternal.GetHashCode", MemberParameters = new object[] { typeof(global::System.Collections.IEqualityComparer) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ValueTuple), Member = "CombineHashCodes", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		private int GetHashCodeCore(global::System.Collections.IEqualityComparer comparer)
		{
			throw null;
		}

		// Token: 0x06000AB8 RID: 2744 RVA: 0x00016424 File Offset: 0x00014624
		[global::Cpp2ILInjected.Token(Token = "0x6000B60")]
		[global::Cpp2ILInjected.Address(RVA = "0x18BB87C", Offset = "0x18BB87C", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ValueTuple<, , , , >), Member = "GetHashCodeCore", MemberParameters = new object[] { typeof(global::System.Collections.IEqualityComparer) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private int System.IValueTupleInternal.GetHashCode(global::System.Collections.IEqualityComparer comparer)
		{
			throw null;
		}

		// Token: 0x06000AB9 RID: 2745 RVA: 0x00016427 File Offset: 0x00014627
		[global::Cpp2ILInjected.Token(Token = "0x6000B61")]
		[global::Cpp2ILInjected.Address(RVA = "0x18BB8C0", Offset = "0x18BB8C0", Length = "0x2C0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(bool), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06000ABA RID: 2746 RVA: 0x0001642A File Offset: 0x0001462A
		[global::Cpp2ILInjected.Token(Token = "0x6000B62")]
		[global::Cpp2ILInjected.Address(RVA = "0x18BBB80", Offset = "0x18BBB80", Length = "0x290")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(bool), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		private string System.IValueTupleInternal.ToStringEnd()
		{
			throw null;
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000ABB RID: 2747 RVA: 0x0001642D File Offset: 0x0001462D
		[global::Cpp2ILInjected.Token(Token = "0x170000F9")]
		private int System.Runtime.CompilerServices.ITuple.Length
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B63")]
			[global::Cpp2ILInjected.Address(RVA = "0x18BBE10", Offset = "0x18BBE10", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x040002B9 RID: 697
		[global::Cpp2ILInjected.Token(Token = "0x400040B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public T1 Item1;

		// Token: 0x040002BA RID: 698
		[global::Cpp2ILInjected.Token(Token = "0x400040C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public T2 Item2;

		// Token: 0x040002BB RID: 699
		[global::Cpp2ILInjected.Token(Token = "0x400040D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public T3 Item3;

		// Token: 0x040002BC RID: 700
		[global::Cpp2ILInjected.Token(Token = "0x400040E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public T4 Item4;

		// Token: 0x040002BD RID: 701
		[global::Cpp2ILInjected.Token(Token = "0x400040F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public T5 Item5;
	}
}
