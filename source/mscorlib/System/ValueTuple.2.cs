using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x020000EA RID: 234
	[global::Cpp2ILInjected.Token(Token = "0x200011C")]
	[global::System.Serializable]
	public struct ValueTuple<T1> : global::System.IEquatable<global::System.ValueTuple<T1>>, global::System.Collections.IStructuralEquatable, global::System.Collections.IStructuralComparable, global::System.IComparable, global::System.IComparable<global::System.ValueTuple<T1>>, global::System.IValueTupleInternal, global::System.Runtime.CompilerServices.ITuple
	{
		// Token: 0x06000A77 RID: 2679 RVA: 0x00016361 File Offset: 0x00014561
		[global::Cpp2ILInjected.Token(Token = "0x6000B1F")]
		[global::Cpp2ILInjected.Address(RVA = "0x18AE620", Offset = "0x18AE620", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public ValueTuple(T1 item1)
		{
			throw null;
		}

		// Token: 0x06000A78 RID: 2680 RVA: 0x00016364 File Offset: 0x00014564
		[global::Cpp2ILInjected.Token(Token = "0x6000B20")]
		[global::Cpp2ILInjected.Address(RVA = "0x18AE62C", Offset = "0x18AE62C", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06000A79 RID: 2681 RVA: 0x00016367 File Offset: 0x00014567
		[global::Cpp2ILInjected.Token(Token = "0x6000B21")]
		[global::Cpp2ILInjected.Address(RVA = "0x18AE70C", Offset = "0x18AE70C", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.GenericEqualityComparer<>), Member = "Equals", MemberParameters = new object[] { "T", "T" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.GenericEqualityComparer<>), Member = "IndexOf", MemberParameters = new object[]
		{
			"T[]",
			"T",
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.GenericEqualityComparer<>), Member = "LastIndexOf", MemberParameters = new object[]
		{
			"T[]",
			"T",
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public bool Equals(global::System.ValueTuple<T1> other)
		{
			throw null;
		}

		// Token: 0x06000A7A RID: 2682 RVA: 0x0001636A File Offset: 0x0001456A
		[global::Cpp2ILInjected.Token(Token = "0x6000B22")]
		[global::Cpp2ILInjected.Address(RVA = "0x18AE788", Offset = "0x18AE788", Length = "0x1C4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		private bool System.Collections.IStructuralEquatable.Equals(object other, global::System.Collections.IEqualityComparer comparer)
		{
			throw null;
		}

		// Token: 0x06000A7B RID: 2683 RVA: 0x0001636D File Offset: 0x0001456D
		[global::Cpp2ILInjected.Token(Token = "0x6000B23")]
		[global::Cpp2ILInjected.Address(RVA = "0x18AE94C", Offset = "0x18AE94C", Length = "0x1C0")]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		private int System.IComparable.CompareTo(object other)
		{
			throw null;
		}

		// Token: 0x06000A7C RID: 2684 RVA: 0x00016370 File Offset: 0x00014570
		[global::Cpp2ILInjected.Token(Token = "0x6000B24")]
		[global::Cpp2ILInjected.Address(RVA = "0x18AEB0C", Offset = "0x18AEB0C", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.GenericComparer<>), Member = "Compare", MemberParameters = new object[] { "T", "T" }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public int CompareTo(global::System.ValueTuple<T1> other)
		{
			throw null;
		}

		// Token: 0x06000A7D RID: 2685 RVA: 0x00016373 File Offset: 0x00014573
		[global::Cpp2ILInjected.Token(Token = "0x6000B25")]
		[global::Cpp2ILInjected.Address(RVA = "0x18AEB88", Offset = "0x18AEB88", Length = "0x264")]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		private int System.Collections.IStructuralComparable.CompareTo(object other, global::System.Collections.IComparer comparer)
		{
			throw null;
		}

		// Token: 0x06000A7E RID: 2686 RVA: 0x00016376 File Offset: 0x00014576
		[global::Cpp2ILInjected.Token(Token = "0x6000B26")]
		[global::Cpp2ILInjected.Address(RVA = "0x18AEDEC", Offset = "0x18AEDEC", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.GenericEqualityComparer<>), Member = "GetHashCode", MemberParameters = new object[] { "T" }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(bool), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06000A7F RID: 2687 RVA: 0x00016379 File Offset: 0x00014579
		[global::Cpp2ILInjected.Token(Token = "0x6000B27")]
		[global::Cpp2ILInjected.Address(RVA = "0x18AEE20", Offset = "0x18AEE20", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private int System.Collections.IStructuralEquatable.GetHashCode(global::System.Collections.IEqualityComparer comparer)
		{
			throw null;
		}

		// Token: 0x06000A80 RID: 2688 RVA: 0x0001637C File Offset: 0x0001457C
		[global::Cpp2ILInjected.Token(Token = "0x6000B28")]
		[global::Cpp2ILInjected.Address(RVA = "0x18AEF08", Offset = "0x18AEF08", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private int System.IValueTupleInternal.GetHashCode(global::System.Collections.IEqualityComparer comparer)
		{
			throw null;
		}

		// Token: 0x06000A81 RID: 2689 RVA: 0x0001637F File Offset: 0x0001457F
		[global::Cpp2ILInjected.Token(Token = "0x6000B29")]
		[global::Cpp2ILInjected.Address(RVA = "0x18AEFF0", Offset = "0x18AEFF0", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ValueTuple<, , , , , , , >), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ValueTuple<, , , , , , , >), Member = "System.IValueTupleInternal.ToStringEnd", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(bool), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06000A82 RID: 2690 RVA: 0x00016382 File Offset: 0x00014582
		[global::Cpp2ILInjected.Token(Token = "0x6000B2A")]
		[global::Cpp2ILInjected.Address(RVA = "0x18AF084", Offset = "0x18AF084", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(bool), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private string System.IValueTupleInternal.ToStringEnd()
		{
			throw null;
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000A83 RID: 2691 RVA: 0x00016385 File Offset: 0x00014585
		[global::Cpp2ILInjected.Token(Token = "0x170000F5")]
		private int System.Runtime.CompilerServices.ITuple.Length
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B2B")]
			[global::Cpp2ILInjected.Address(RVA = "0x18AF0F0", Offset = "0x18AF0F0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x040002AF RID: 687
		[global::Cpp2ILInjected.Token(Token = "0x4000401")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public T1 Item1;
	}
}
