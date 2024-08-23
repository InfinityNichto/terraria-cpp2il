using System;
using System.Collections;
using System.Numerics.Hashing;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x020000E9 RID: 233
	[global::Cpp2ILInjected.Token(Token = "0x200011B")]
	[global::System.Serializable]
	public struct ValueTuple : global::System.IEquatable<global::System.ValueTuple>, global::System.Collections.IStructuralEquatable, global::System.Collections.IStructuralComparable, global::System.IComparable, global::System.IComparable<global::System.ValueTuple>, global::System.IValueTupleInternal, global::System.Runtime.CompilerServices.ITuple
	{
		// Token: 0x06000A64 RID: 2660 RVA: 0x00016328 File Offset: 0x00014528
		[global::Cpp2ILInjected.Token(Token = "0x6000B0C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C53208", Offset = "0x1C53208", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06000A65 RID: 2661 RVA: 0x0001632B File Offset: 0x0001452B
		[global::Cpp2ILInjected.Token(Token = "0x6000B0D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C53264", Offset = "0x1C53264", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool Equals(global::System.ValueTuple other)
		{
			throw null;
		}

		// Token: 0x06000A66 RID: 2662 RVA: 0x0001632E File Offset: 0x0001452E
		[global::Cpp2ILInjected.Token(Token = "0x6000B0E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5326C", Offset = "0x1C5326C", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private bool System.Collections.IStructuralEquatable.Equals(object other, global::System.Collections.IEqualityComparer comparer)
		{
			throw null;
		}

		// Token: 0x06000A67 RID: 2663 RVA: 0x00016331 File Offset: 0x00014531
		[global::Cpp2ILInjected.Token(Token = "0x6000B0F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C532C8", Offset = "0x1C532C8", Length = "0x108")]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private int System.IComparable.CompareTo(object other)
		{
			throw null;
		}

		// Token: 0x06000A68 RID: 2664 RVA: 0x00016334 File Offset: 0x00014534
		[global::Cpp2ILInjected.Token(Token = "0x6000B10")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C533D0", Offset = "0x1C533D0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public int CompareTo(global::System.ValueTuple other)
		{
			throw null;
		}

		// Token: 0x06000A69 RID: 2665 RVA: 0x00016337 File Offset: 0x00014537
		[global::Cpp2ILInjected.Token(Token = "0x6000B11")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C533D8", Offset = "0x1C533D8", Length = "0x108")]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private int System.Collections.IStructuralComparable.CompareTo(object other, global::System.Collections.IComparer comparer)
		{
			throw null;
		}

		// Token: 0x06000A6A RID: 2666 RVA: 0x0001633A File Offset: 0x0001453A
		[global::Cpp2ILInjected.Token(Token = "0x6000B12")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C534E0", Offset = "0x1C534E0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06000A6B RID: 2667 RVA: 0x0001633D File Offset: 0x0001453D
		[global::Cpp2ILInjected.Token(Token = "0x6000B13")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C534E8", Offset = "0x1C534E8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private int System.Collections.IStructuralEquatable.GetHashCode(global::System.Collections.IEqualityComparer comparer)
		{
			throw null;
		}

		// Token: 0x06000A6C RID: 2668 RVA: 0x00016340 File Offset: 0x00014540
		[global::Cpp2ILInjected.Token(Token = "0x6000B14")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C534F0", Offset = "0x1C534F0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private int System.IValueTupleInternal.GetHashCode(global::System.Collections.IEqualityComparer comparer)
		{
			throw null;
		}

		// Token: 0x06000A6D RID: 2669 RVA: 0x00016343 File Offset: 0x00014543
		[global::Cpp2ILInjected.Token(Token = "0x6000B15")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C534F8", Offset = "0x1C534F8", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06000A6E RID: 2670 RVA: 0x00016346 File Offset: 0x00014546
		[global::Cpp2ILInjected.Token(Token = "0x6000B16")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C53538", Offset = "0x1C53538", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private string System.IValueTupleInternal.ToStringEnd()
		{
			throw null;
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000A6F RID: 2671 RVA: 0x00016349 File Offset: 0x00014549
		[global::Cpp2ILInjected.Token(Token = "0x170000F4")]
		private int System.Runtime.CompilerServices.ITuple.Length
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B17")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C53578", Offset = "0x1C53578", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000A70 RID: 2672 RVA: 0x0001634C File Offset: 0x0001454C
		[global::Cpp2ILInjected.Token(Token = "0x6000B18")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C53580", Offset = "0x1C53580", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ValueTuple), Member = "CombineHashCodes", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ValueTuple<, >), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ValueTuple<, >), Member = "GetHashCodeCore", MemberParameters = new object[] { typeof(global::System.Collections.IEqualityComparer) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ValueTuple<, , , , , , , >), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ValueTuple<, , , , , , , >), Member = "GetHashCodeCore", MemberParameters = new object[] { typeof(global::System.Collections.IEqualityComparer) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Numerics.Hashing.HashHelpers), Member = "Combine", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static int CombineHashCodes(int h1, int h2)
		{
			throw null;
		}

		// Token: 0x06000A71 RID: 2673 RVA: 0x0001634F File Offset: 0x0001454F
		[global::Cpp2ILInjected.Token(Token = "0x6000B19")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C535FC", Offset = "0x1C535FC", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ValueTuple), Member = "CombineHashCodes", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ValueTuple<, , >), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ValueTuple<, , >), Member = "GetHashCodeCore", MemberParameters = new object[] { typeof(global::System.Collections.IEqualityComparer) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ValueTuple<, , , , , , , >), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ValueTuple<, , , , , , , >), Member = "GetHashCodeCore", MemberParameters = new object[] { typeof(global::System.Collections.IEqualityComparer) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ValueTuple), Member = "CombineHashCodes", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Numerics.Hashing.HashHelpers), Member = "Combine", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static int CombineHashCodes(int h1, int h2, int h3)
		{
			throw null;
		}

		// Token: 0x06000A72 RID: 2674 RVA: 0x00016352 File Offset: 0x00014552
		[global::Cpp2ILInjected.Token(Token = "0x6000B1A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5367C", Offset = "0x1C5367C", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ValueTuple), Member = "CombineHashCodes", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ValueTuple<, , , >), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ValueTuple<, , , >), Member = "GetHashCodeCore", MemberParameters = new object[] { typeof(global::System.Collections.IEqualityComparer) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ValueTuple<, , , , , , , >), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ValueTuple<, , , , , , , >), Member = "GetHashCodeCore", MemberParameters = new object[] { typeof(global::System.Collections.IEqualityComparer) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ValueTuple), Member = "CombineHashCodes", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Numerics.Hashing.HashHelpers), Member = "Combine", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static int CombineHashCodes(int h1, int h2, int h3, int h4)
		{
			throw null;
		}

		// Token: 0x06000A73 RID: 2675 RVA: 0x00016355 File Offset: 0x00014555
		[global::Cpp2ILInjected.Token(Token = "0x6000B1B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5370C", Offset = "0x1C5370C", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ValueTuple), Member = "CombineHashCodes", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ValueTuple<, , , , >), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ValueTuple<, , , , >), Member = "GetHashCodeCore", MemberParameters = new object[] { typeof(global::System.Collections.IEqualityComparer) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ValueTuple<, , , , , , , >), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ValueTuple<, , , , , , , >), Member = "GetHashCodeCore", MemberParameters = new object[] { typeof(global::System.Collections.IEqualityComparer) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ValueTuple), Member = "CombineHashCodes", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Numerics.Hashing.HashHelpers), Member = "Combine", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5)
		{
			throw null;
		}

		// Token: 0x06000A74 RID: 2676 RVA: 0x00016358 File Offset: 0x00014558
		[global::Cpp2ILInjected.Token(Token = "0x6000B1C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C537A4", Offset = "0x1C537A4", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ValueTuple), Member = "CombineHashCodes", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ValueTuple<, , , , , , , >), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ValueTuple<, , , , , , , >), Member = "GetHashCodeCore", MemberParameters = new object[] { typeof(global::System.Collections.IEqualityComparer) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ValueTuple), Member = "CombineHashCodes", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Numerics.Hashing.HashHelpers), Member = "Combine", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5, int h6)
		{
			throw null;
		}

		// Token: 0x06000A75 RID: 2677 RVA: 0x0001635B File Offset: 0x0001455B
		[global::Cpp2ILInjected.Token(Token = "0x6000B1D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5384C", Offset = "0x1C5384C", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ValueTuple), Member = "CombineHashCodes", MemberParameters = new object[]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ValueTuple<, , , , , , , >), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ValueTuple<, , , , , , , >), Member = "GetHashCodeCore", MemberParameters = new object[] { typeof(global::System.Collections.IEqualityComparer) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ValueTuple), Member = "CombineHashCodes", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Numerics.Hashing.HashHelpers), Member = "Combine", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5, int h6, int h7)
		{
			throw null;
		}

		// Token: 0x06000A76 RID: 2678 RVA: 0x0001635E File Offset: 0x0001455E
		[global::Cpp2ILInjected.Token(Token = "0x6000B1E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C538FC", Offset = "0x1C538FC", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ValueTuple<, , , , , , , >), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ValueTuple<, , , , , , , >), Member = "GetHashCodeCore", MemberParameters = new object[] { typeof(global::System.Collections.IEqualityComparer) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Numerics.Hashing.HashHelpers), Member = "Combine", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5, int h6, int h7, int h8)
		{
			throw null;
		}
	}
}
