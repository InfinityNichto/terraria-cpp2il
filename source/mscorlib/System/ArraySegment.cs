using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics.Hashing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x02000062 RID: 98
	[global::System.Reflection.DefaultMember("Item")]
	[global::Cpp2ILInjected.Token(Token = "0x2000087")]
	[global::System.Serializable]
	public readonly struct ArraySegment<T> : global::System.Collections.Generic.IList<T>, global::System.Collections.Generic.ICollection<T>, global::System.Collections.Generic.IEnumerable<T>, global::System.Collections.IEnumerable, global::System.Collections.Generic.IReadOnlyList<T>, global::System.Collections.Generic.IReadOnlyCollection<T>
	{
		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600034C RID: 844 RVA: 0x00014F15 File Offset: 0x00013115
		[global::Cpp2ILInjected.Token(Token = "0x1700005A")]
		public static global::System.ArraySegment<T> Empty
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60003DD")]
			[global::Cpp2ILInjected.Address(RVA = "0x15C6C98", Offset = "0x15C6C98", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600034D RID: 845 RVA: 0x00014F18 File Offset: 0x00013118
		[global::Cpp2ILInjected.Token(Token = "0x60003DE")]
		[global::Cpp2ILInjected.Address(RVA = "0x15C6D04", Offset = "0x15C6D04", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		public ArraySegment(T[] array)
		{
			throw null;
		}

		// Token: 0x0600034E RID: 846 RVA: 0x00014F1B File Offset: 0x0001311B
		[global::Cpp2ILInjected.Token(Token = "0x60003DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x15C6D3C", Offset = "0x15C6D3C", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.InteropServices.MemoryMarshal), Member = "TryGetArray", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "System.ReadOnlyMemory`1<T>", "System.ArraySegment`1<T>&" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArraySegmentCtorValidationFailedExceptions", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public ArraySegment(T[] array, int offset, int count)
		{
			throw null;
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600034F RID: 847 RVA: 0x00014F1E File Offset: 0x0001311E
		[global::Cpp2ILInjected.Token(Token = "0x1700005B")]
		public T[] Array
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003E0")]
			[global::Cpp2ILInjected.Address(RVA = "0x15C6D9C", Offset = "0x15C6D9C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000350 RID: 848 RVA: 0x00014F21 File Offset: 0x00013121
		[global::Cpp2ILInjected.Token(Token = "0x1700005C")]
		public int Offset
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003E1")]
			[global::Cpp2ILInjected.Address(RVA = "0x15C6DA4", Offset = "0x15C6DA4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000351 RID: 849 RVA: 0x00014F24 File Offset: 0x00013124
		[global::Cpp2ILInjected.Token(Token = "0x1700005D")]
		public int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003E2")]
			[global::Cpp2ILInjected.Address(RVA = "0x15C6DAC", Offset = "0x15C6DAC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000352 RID: 850 RVA: 0x00014F27 File Offset: 0x00013127
		[global::Cpp2ILInjected.Token(Token = "0x60003E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x15C6DB4", Offset = "0x15C6DB4", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ArraySegment<>), Member = "System.Collections.Generic.IEnumerable<T>.GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ArraySegment<>), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(global::System.Collections.IEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowInvalidOperationException", MemberParameters = new object[] { typeof(global::System.ExceptionResource) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArraySegment<>.Enumerator), Member = ".ctor", MemberParameters = new object[] { "System.ArraySegment`1<T>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public global::System.ArraySegment<T>.Enumerator GetEnumerator()
		{
			throw null;
		}

		// Token: 0x06000353 RID: 851 RVA: 0x00014F2A File Offset: 0x0001312A
		[global::Cpp2ILInjected.Token(Token = "0x60003E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x15C6E34", Offset = "0x15C6E34", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Numerics.Hashing.HashHelpers), Member = "Combine", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06000354 RID: 852 RVA: 0x00014F2D File Offset: 0x0001312D
		[global::Cpp2ILInjected.Token(Token = "0x60003E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x15C6ED0", Offset = "0x15C6ED0", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowInvalidOperationException", MemberParameters = new object[] { typeof(global::System.ExceptionResource) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void CopyTo(T[] destination, int destinationIndex)
		{
			throw null;
		}

		// Token: 0x06000355 RID: 853 RVA: 0x00014F30 File Offset: 0x00013130
		[global::Cpp2ILInjected.Token(Token = "0x60003E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x15C6F2C", Offset = "0x15C6F2C", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Array), Member = "InternalArray__ICollection_Contains", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Array), Member = "InternalArray__IndexOf", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T" }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06000356 RID: 854 RVA: 0x00014F33 File Offset: 0x00013133
		[global::Cpp2ILInjected.Token(Token = "0x60003E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x15C701C", Offset = "0x15C701C", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool Equals(global::System.ArraySegment<T> obj)
		{
			throw null;
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000357 RID: 855 RVA: 0x00014F36 File Offset: 0x00013136
		// (set) Token: 0x06000358 RID: 856 RVA: 0x00014F39 File Offset: 0x00013139
		[global::Cpp2ILInjected.Token(Token = "0x1700005E")]
		private T System.Collections.Generic.IList<T>.Item
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003E8")]
			[global::Cpp2ILInjected.Address(RVA = "0x15C7050", Offset = "0x15C7050", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowInvalidOperationException", MemberParameters = new object[] { typeof(global::System.ExceptionResource) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60003E9")]
			[global::Cpp2ILInjected.Address(RVA = "0x15C70C8", Offset = "0x15C70C8", Length = "0x7C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowInvalidOperationException", MemberParameters = new object[] { typeof(global::System.ExceptionResource) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000359 RID: 857 RVA: 0x00014F3C File Offset: 0x0001313C
		[global::Cpp2ILInjected.Token(Token = "0x60003EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x15C7144", Offset = "0x15C7144", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowInvalidOperationException", MemberParameters = new object[] { typeof(global::System.ExceptionResource) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private int System.Collections.Generic.IList<T>.IndexOf(T item)
		{
			throw null;
		}

		// Token: 0x0600035A RID: 858 RVA: 0x00014F3F File Offset: 0x0001313F
		[global::Cpp2ILInjected.Token(Token = "0x60003EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x15C7214", Offset = "0x15C7214", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowNotSupportedException", ReturnType = typeof(void))]
		private void System.Collections.Generic.IList<T>.Insert(int index, T item)
		{
			throw null;
		}

		// Token: 0x0600035B RID: 859 RVA: 0x00014F42 File Offset: 0x00013142
		[global::Cpp2ILInjected.Token(Token = "0x60003EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x15C721C", Offset = "0x15C721C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowNotSupportedException", ReturnType = typeof(void))]
		private void System.Collections.Generic.IList<T>.RemoveAt(int index)
		{
			throw null;
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600035C RID: 860 RVA: 0x00014F45 File Offset: 0x00013145
		[global::Cpp2ILInjected.Token(Token = "0x1700005F")]
		private T System.Collections.Generic.IReadOnlyList<T>.Item
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003ED")]
			[global::Cpp2ILInjected.Address(RVA = "0x15C7224", Offset = "0x15C7224", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowInvalidOperationException", MemberParameters = new object[] { typeof(global::System.ExceptionResource) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600035D RID: 861 RVA: 0x00014F48 File Offset: 0x00013148
		[global::Cpp2ILInjected.Token(Token = "0x17000060")]
		private bool System.Collections.Generic.ICollection<T>.IsReadOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003EE")]
			[global::Cpp2ILInjected.Address(RVA = "0x15C729C", Offset = "0x15C729C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600035E RID: 862 RVA: 0x00014F4B File Offset: 0x0001314B
		[global::Cpp2ILInjected.Token(Token = "0x60003EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x15C72A4", Offset = "0x15C72A4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowNotSupportedException", ReturnType = typeof(void))]
		private void System.Collections.Generic.ICollection<T>.Add(T item)
		{
			throw null;
		}

		// Token: 0x0600035F RID: 863 RVA: 0x00014F4E File Offset: 0x0001314E
		[global::Cpp2ILInjected.Token(Token = "0x60003F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x15C72AC", Offset = "0x15C72AC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowNotSupportedException", ReturnType = typeof(void))]
		private void System.Collections.Generic.ICollection<T>.Clear()
		{
			throw null;
		}

		// Token: 0x06000360 RID: 864 RVA: 0x00014F51 File Offset: 0x00013151
		[global::Cpp2ILInjected.Token(Token = "0x60003F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x15C72B4", Offset = "0x15C72B4", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowInvalidOperationException", MemberParameters = new object[] { typeof(global::System.ExceptionResource) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private bool System.Collections.Generic.ICollection<T>.Contains(T item)
		{
			throw null;
		}

		// Token: 0x06000361 RID: 865 RVA: 0x00014F54 File Offset: 0x00013154
		[global::Cpp2ILInjected.Token(Token = "0x60003F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x15C7370", Offset = "0x15C7370", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowNotSupportedException", ReturnType = typeof(void))]
		private bool System.Collections.Generic.ICollection<T>.Remove(T item)
		{
			throw null;
		}

		// Token: 0x06000362 RID: 866 RVA: 0x00014F57 File Offset: 0x00013157
		[global::Cpp2ILInjected.Token(Token = "0x60003F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x15C7388", Offset = "0x15C7388", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArraySegment<>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private global::System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
		{
			throw null;
		}

		// Token: 0x06000363 RID: 867 RVA: 0x00014F5A File Offset: 0x0001315A
		[global::Cpp2ILInjected.Token(Token = "0x60003F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x15C741C", Offset = "0x15C741C", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArraySegment<>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private global::System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw null;
		}

		// Token: 0x06000364 RID: 868 RVA: 0x00014F5D File Offset: 0x0001315D
		[global::Cpp2ILInjected.Token(Token = "0x60003F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x15C74B0", Offset = "0x15C74B0", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowInvalidOperationException", MemberParameters = new object[] { typeof(global::System.ExceptionResource) }, ReturnType = typeof(void))]
		private void ThrowInvalidOperationIfDefault()
		{
			throw null;
		}

		// Token: 0x06000365 RID: 869 RVA: 0x00014F60 File Offset: 0x00013160
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60003F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x15C74C8", Offset = "0x15C74C8", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		static ArraySegment()
		{
			throw null;
		}

		// Token: 0x040000FC RID: 252
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40001DD")]
		private static readonly global::System.ArraySegment<T> <Empty>k__BackingField;

		// Token: 0x040000FD RID: 253
		[global::Cpp2ILInjected.Token(Token = "0x40001DE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly T[] _array;

		// Token: 0x040000FE RID: 254
		[global::Cpp2ILInjected.Token(Token = "0x40001DF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly int _offset;

		// Token: 0x040000FF RID: 255
		[global::Cpp2ILInjected.Token(Token = "0x40001E0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly int _count;

		// Token: 0x0200057A RID: 1402
		[global::Cpp2ILInjected.Token(Token = "0x2000088")]
		public struct Enumerator : global::System.Collections.Generic.IEnumerator<T>, global::System.IDisposable, global::System.Collections.IEnumerator
		{
			// Token: 0x06003F80 RID: 16256 RVA: 0x0001F946 File Offset: 0x0001DB46
			[global::Cpp2ILInjected.Token(Token = "0x60003F7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1644FF8", Offset = "0x1644FF8", Length = "0xAC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ArraySegment<>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			internal Enumerator(global::System.ArraySegment<T> arraySegment)
			{
				throw null;
			}

			// Token: 0x06003F81 RID: 16257 RVA: 0x0001F949 File Offset: 0x0001DB49
			[global::Cpp2ILInjected.Token(Token = "0x60003F8")]
			[global::Cpp2ILInjected.Address(RVA = "0x16450A4", Offset = "0x16450A4", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool MoveNext()
			{
				throw null;
			}

			// Token: 0x17000719 RID: 1817
			// (get) Token: 0x06003F82 RID: 16258 RVA: 0x0001F94C File Offset: 0x0001DB4C
			[global::Cpp2ILInjected.Token(Token = "0x17000061")]
			public T Current
			{
				[global::Cpp2ILInjected.Token(Token = "0x60003F9")]
				[global::Cpp2ILInjected.Address(RVA = "0x16450CC", Offset = "0x16450CC", Length = "0x50")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ArraySegment<>.Enumerator), Member = "System.Collections.IEnumerator.get_Current", ReturnType = typeof(object))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumNotStarted", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumEnded", ReturnType = typeof(void))]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700071A RID: 1818
			// (get) Token: 0x06003F83 RID: 16259 RVA: 0x0001F94F File Offset: 0x0001DB4F
			[global::Cpp2ILInjected.Token(Token = "0x17000062")]
			private object System.Collections.IEnumerator.Current
			{
				[global::Cpp2ILInjected.Token(Token = "0x60003FA")]
				[global::Cpp2ILInjected.Address(RVA = "0x164511C", Offset = "0x164511C", Length = "0x68")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArraySegment<>.Enumerator), Member = "get_Current", ReturnType = "T")]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06003F84 RID: 16260 RVA: 0x0001F952 File Offset: 0x0001DB52
			[global::Cpp2ILInjected.Token(Token = "0x60003FB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1645184", Offset = "0x1645184", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private void System.Collections.IEnumerator.Reset()
			{
				throw null;
			}

			// Token: 0x06003F85 RID: 16261 RVA: 0x0001F955 File Offset: 0x0001DB55
			[global::Cpp2ILInjected.Token(Token = "0x60003FC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1645194", Offset = "0x1645194", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void Dispose()
			{
				throw null;
			}

			// Token: 0x04001788 RID: 6024
			[global::Cpp2ILInjected.Token(Token = "0x40001E1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private readonly T[] _array;

			// Token: 0x04001789 RID: 6025
			[global::Cpp2ILInjected.Token(Token = "0x40001E2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private readonly int _start;

			// Token: 0x0400178A RID: 6026
			[global::Cpp2ILInjected.Token(Token = "0x40001E3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private readonly int _end;

			// Token: 0x0400178B RID: 6027
			[global::Cpp2ILInjected.Token(Token = "0x40001E4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int _current;
		}
	}
}
