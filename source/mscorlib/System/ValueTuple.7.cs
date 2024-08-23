using System;
using System.Collections;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x020000EF RID: 239
	[global::Cpp2ILInjected.Token(Token = "0x2000121")]
	[global::System.Serializable]
	[StructLayout(3)]
	public struct ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest> : global::System.IEquatable<global::System.ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>>, global::System.Collections.IStructuralEquatable, global::System.Collections.IStructuralComparable, global::System.IComparable, global::System.IComparable<global::System.ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>>, global::System.IValueTupleInternal, global::System.Runtime.CompilerServices.ITuple where TRest : struct
	{
		// Token: 0x06000ABC RID: 2748 RVA: 0x00016430 File Offset: 0x00014630
		[global::Cpp2ILInjected.Token(Token = "0x6000B64")]
		[global::Cpp2ILInjected.Address(RVA = "0x18BEDD0", Offset = "0x18BEDD0", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Path), Member = "JoinInternal", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public ValueTuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, TRest rest)
		{
			throw null;
		}

		// Token: 0x06000ABD RID: 2749 RVA: 0x00016433 File Offset: 0x00014633
		[global::Cpp2ILInjected.Token(Token = "0x6000B65")]
		[global::Cpp2ILInjected.Address(RVA = "0x18BEED4", Offset = "0x18BEED4", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ValueTuple<, , , , , , , >), Member = "Equals", MemberParameters = new object[] { "System.ValueTuple`8<T1, T2, T3, T4, T5, T6, T7, TRest>" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06000ABE RID: 2750 RVA: 0x00016436 File Offset: 0x00014636
		[global::Cpp2ILInjected.Token(Token = "0x6000B66")]
		[global::Cpp2ILInjected.Address(RVA = "0x18BEFD4", Offset = "0x18BEFD4", Length = "0x358")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ValueTuple<, , , , , , , >), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public bool Equals(global::System.ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest> other)
		{
			throw null;
		}

		// Token: 0x06000ABF RID: 2751 RVA: 0x00016439 File Offset: 0x00014639
		[global::Cpp2ILInjected.Token(Token = "0x6000B67")]
		[global::Cpp2ILInjected.Address(RVA = "0x18BF32C", Offset = "0x18BF32C", Length = "0x7E8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 63)]
		private bool System.Collections.IStructuralEquatable.Equals(object other, global::System.Collections.IEqualityComparer comparer)
		{
			throw null;
		}

		// Token: 0x06000AC0 RID: 2752 RVA: 0x0001643C File Offset: 0x0001463C
		[global::Cpp2ILInjected.Token(Token = "0x6000B68")]
		[global::Cpp2ILInjected.Address(RVA = "0x18BFB14", Offset = "0x18BFB14", Length = "0x1A0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ValueTuple<, , , , , , , >), Member = "CompareTo", MemberParameters = new object[] { "System.ValueTuple`8<T1, T2, T3, T4, T5, T6, T7, TRest>" }, ReturnType = typeof(int))]
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

		// Token: 0x06000AC1 RID: 2753 RVA: 0x0001643F File Offset: 0x0001463F
		[global::Cpp2ILInjected.Token(Token = "0x6000B69")]
		[global::Cpp2ILInjected.Address(RVA = "0x18BFCB4", Offset = "0x18BFCB4", Length = "0x354")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ValueTuple<, , , , , , , >), Member = "System.IComparable.CompareTo", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public int CompareTo(global::System.ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest> other)
		{
			throw null;
		}

		// Token: 0x06000AC2 RID: 2754 RVA: 0x00016442 File Offset: 0x00014642
		[global::Cpp2ILInjected.Token(Token = "0x6000B6A")]
		[global::Cpp2ILInjected.Address(RVA = "0x18C0008", Offset = "0x18C0008", Length = "0x890")]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 72)]
		private int System.Collections.IStructuralComparable.CompareTo(object other, global::System.Collections.IComparer comparer)
		{
			throw null;
		}

		// Token: 0x06000AC3 RID: 2755 RVA: 0x00016445 File Offset: 0x00014645
		[global::Cpp2ILInjected.Token(Token = "0x6000B6B")]
		[global::Cpp2ILInjected.Address(RVA = "0x18C0898", Offset = "0x18C0898", Length = "0x81C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
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
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ValueTuple), Member = "CombineHashCodes", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ValueTuple), Member = "CombineHashCodes", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ValueTuple), Member = "CombineHashCodes", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ValueTuple), Member = "CombineHashCodes", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ValueTuple), Member = "CombineHashCodes", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ValueTuple), Member = "CombineHashCodes", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 41)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06000AC4 RID: 2756 RVA: 0x00016448 File Offset: 0x00014648
		[global::Cpp2ILInjected.Token(Token = "0x6000B6C")]
		[global::Cpp2ILInjected.Address(RVA = "0x18C10B4", Offset = "0x18C10B4", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private int System.Collections.IStructuralEquatable.GetHashCode(global::System.Collections.IEqualityComparer comparer)
		{
			throw null;
		}

		// Token: 0x06000AC5 RID: 2757 RVA: 0x0001644B File Offset: 0x0001464B
		[global::Cpp2ILInjected.Token(Token = "0x6000B6D")]
		[global::Cpp2ILInjected.Address(RVA = "0x18C10F8", Offset = "0x18C10F8", Length = "0x1B78")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ValueTuple<, , , , , , , >), Member = "System.IValueTupleInternal.GetHashCode", MemberParameters = new object[] { typeof(global::System.Collections.IEqualityComparer) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ValueTuple), Member = "CombineHashCodes", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ValueTuple), Member = "CombineHashCodes", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ValueTuple), Member = "CombineHashCodes", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ValueTuple), Member = "CombineHashCodes", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ValueTuple), Member = "CombineHashCodes", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ValueTuple), Member = "CombineHashCodes", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ValueTuple), Member = "CombineHashCodes", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 156)]
		private int GetHashCodeCore(global::System.Collections.IEqualityComparer comparer)
		{
			throw null;
		}

		// Token: 0x06000AC6 RID: 2758 RVA: 0x0001644E File Offset: 0x0001464E
		[global::Cpp2ILInjected.Token(Token = "0x6000B6E")]
		[global::Cpp2ILInjected.Address(RVA = "0x18C2C70", Offset = "0x18C2C70", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ValueTuple<, , , , , , , >), Member = "GetHashCodeCore", MemberParameters = new object[] { typeof(global::System.Collections.IEqualityComparer) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private int System.IValueTupleInternal.GetHashCode(global::System.Collections.IEqualityComparer comparer)
		{
			throw null;
		}

		// Token: 0x06000AC7 RID: 2759 RVA: 0x00016451 File Offset: 0x00014651
		[global::Cpp2ILInjected.Token(Token = "0x6000B6F")]
		[global::Cpp2ILInjected.Address(RVA = "0x18C2CB4", Offset = "0x18C2CB4", Length = "0x7B8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(bool), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ValueTuple<>), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 61)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06000AC8 RID: 2760 RVA: 0x00016454 File Offset: 0x00014654
		[global::Cpp2ILInjected.Token(Token = "0x6000B70")]
		[global::Cpp2ILInjected.Address(RVA = "0x18C346C", Offset = "0x18C346C", Length = "0x76C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(bool), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ValueTuple<>), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 58)]
		private string System.IValueTupleInternal.ToStringEnd()
		{
			throw null;
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000AC9 RID: 2761 RVA: 0x00016457 File Offset: 0x00014657
		[global::Cpp2ILInjected.Token(Token = "0x170000FA")]
		private int System.Runtime.CompilerServices.ITuple.Length
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B71")]
			[global::Cpp2ILInjected.Address(RVA = "0x18C3BD8", Offset = "0x18C3BD8", Length = "0xEC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x040002BE RID: 702
		[global::Cpp2ILInjected.Token(Token = "0x4000410")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public T1 Item1;

		// Token: 0x040002BF RID: 703
		[global::Cpp2ILInjected.Token(Token = "0x4000411")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public T2 Item2;

		// Token: 0x040002C0 RID: 704
		[global::Cpp2ILInjected.Token(Token = "0x4000412")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public T3 Item3;

		// Token: 0x040002C1 RID: 705
		[global::Cpp2ILInjected.Token(Token = "0x4000413")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public T4 Item4;

		// Token: 0x040002C2 RID: 706
		[global::Cpp2ILInjected.Token(Token = "0x4000414")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public T5 Item5;

		// Token: 0x040002C3 RID: 707
		[global::Cpp2ILInjected.Token(Token = "0x4000415")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public T6 Item6;

		// Token: 0x040002C4 RID: 708
		[global::Cpp2ILInjected.Token(Token = "0x4000416")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public T7 Item7;

		// Token: 0x040002C5 RID: 709
		[global::Cpp2ILInjected.Token(Token = "0x4000417")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public TRest Rest;
	}
}
