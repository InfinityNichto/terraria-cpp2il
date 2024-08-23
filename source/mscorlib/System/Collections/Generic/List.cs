using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Collections.Generic
{
	// Token: 0x02000522 RID: 1314
	[global::System.Diagnostics.DebuggerDisplay("Count = {Count}")]
	[global::System.Diagnostics.DebuggerTypeProxy(typeof(ICollectionDebugView<>))]
	[global::Cpp2ILInjected.Token(Token = "0x200063A")]
	[global::System.Serializable]
	public class List<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection, IReadOnlyList<T>, IReadOnlyCollection<T>
	{
		// Token: 0x06002C32 RID: 11314 RVA: 0x0001BFF8 File Offset: 0x0001A1F8
		[global::Cpp2ILInjected.Token(Token = "0x60030A3")]
		[global::Cpp2ILInjected.Address(RVA = "0x172B354", Offset = "0x172B354", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public List()
		{
			throw null;
		}

		// Token: 0x06002C33 RID: 11315 RVA: 0x0001BFFB File Offset: 0x0001A1FB
		[global::Cpp2ILInjected.Token(Token = "0x60030A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x172B3C0", Offset = "0x172B3C0", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new object[]
		{
			typeof(global::System.ExceptionArgument),
			typeof(global::System.ExceptionResource)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public List(int capacity)
		{
			throw null;
		}

		// Token: 0x06002C34 RID: 11316 RVA: 0x0001BFFE File Offset: 0x0001A1FE
		[global::Cpp2ILInjected.Token(Token = "0x60030A5")]
		[global::Cpp2ILInjected.Address(RVA = "0x172B470", Offset = "0x172B470", Length = "0x250")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public List(IEnumerable<T> collection)
		{
			throw null;
		}

		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x06002C35 RID: 11317 RVA: 0x0001C001 File Offset: 0x0001A201
		// (set) Token: 0x06002C36 RID: 11318 RVA: 0x0001C004 File Offset: 0x0001A204
		[global::Cpp2ILInjected.Token(Token = "0x170007D6")]
		public int Capacity
		{
			[global::Cpp2ILInjected.Token(Token = "0x60030A6")]
			[global::Cpp2ILInjected.Address(RVA = "0x172B6C0", Offset = "0x172B6C0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60030A7")]
			[global::Cpp2ILInjected.Address(RVA = "0x172B6CC", Offset = "0x172B6CC", Length = "0xE4")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new object[]
			{
				typeof(global::System.ExceptionArgument),
				typeof(global::System.ExceptionResource)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
			{
				typeof(global::System.Array),
				typeof(int),
				typeof(global::System.Array),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x06002C37 RID: 11319 RVA: 0x0001C007 File Offset: 0x0001A207
		[global::Cpp2ILInjected.Token(Token = "0x170007D7")]
		public int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x60030A8")]
			[global::Cpp2ILInjected.Address(RVA = "0x172B7B0", Offset = "0x172B7B0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x06002C38 RID: 11320 RVA: 0x0001C00A File Offset: 0x0001A20A
		[global::Cpp2ILInjected.Token(Token = "0x170007D8")]
		private bool System.Collections.IList.IsFixedSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x60030A9")]
			[global::Cpp2ILInjected.Address(RVA = "0x172B7B8", Offset = "0x172B7B8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x06002C39 RID: 11321 RVA: 0x0001C00D File Offset: 0x0001A20D
		[global::Cpp2ILInjected.Token(Token = "0x170007D9")]
		private bool System.Collections.Generic.ICollection<T>.IsReadOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x60030AA")]
			[global::Cpp2ILInjected.Address(RVA = "0x172B7C0", Offset = "0x172B7C0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x06002C3A RID: 11322 RVA: 0x0001C010 File Offset: 0x0001A210
		[global::Cpp2ILInjected.Token(Token = "0x170007DA")]
		private bool System.Collections.IList.IsReadOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x60030AB")]
			[global::Cpp2ILInjected.Address(RVA = "0x172B7C8", Offset = "0x172B7C8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x06002C3B RID: 11323 RVA: 0x0001C013 File Offset: 0x0001A213
		[global::Cpp2ILInjected.Token(Token = "0x170007DB")]
		private bool System.Collections.ICollection.IsSynchronized
		{
			[global::Cpp2ILInjected.Token(Token = "0x60030AC")]
			[global::Cpp2ILInjected.Address(RVA = "0x172B7D0", Offset = "0x172B7D0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x06002C3C RID: 11324 RVA: 0x0001C016 File Offset: 0x0001A216
		[global::Cpp2ILInjected.Token(Token = "0x170007DC")]
		private object System.Collections.ICollection.SyncRoot
		{
			[global::Cpp2ILInjected.Token(Token = "0x60030AD")]
			[global::Cpp2ILInjected.Address(RVA = "0x172B7D8", Offset = "0x172B7D8", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170006EA RID: 1770
		[global::Cpp2ILInjected.Token(Token = "0x170007DD")]
		public T this[int index]
		{
			[global::Cpp2ILInjected.Token(Token = "0x60030AE")]
			[global::Cpp2ILInjected.Address(RVA = "0x172B848", Offset = "0x172B848", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException", ReturnType = typeof(void))]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60030AF")]
			[global::Cpp2ILInjected.Address(RVA = "0x172B884", Offset = "0x172B884", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException", ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x06002C3F RID: 11327 RVA: 0x0001C01F File Offset: 0x0001A21F
		[global::Cpp2ILInjected.Token(Token = "0x60030B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x172B8DC", Offset = "0x172B8DC", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static bool IsCompatibleObject(object value)
		{
			throw null;
		}

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x06002C40 RID: 11328 RVA: 0x0001C022 File Offset: 0x0001A222
		// (set) Token: 0x06002C41 RID: 11329 RVA: 0x0001C025 File Offset: 0x0001A225
		[global::Cpp2ILInjected.Token(Token = "0x170007DE")]
		private object System.Collections.IList.Item
		{
			[global::Cpp2ILInjected.Token(Token = "0x60030B1")]
			[global::Cpp2ILInjected.Address(RVA = "0x172B98C", Offset = "0x172B98C", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60030B2")]
			[global::Cpp2ILInjected.Address(RVA = "0x172B9DC", Offset = "0x172B9DC", Length = "0x168")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowWrongValueTypeArgumentException", MemberParameters = new object[]
			{
				typeof(object),
				typeof(global::System.Type)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06002C42 RID: 11330 RVA: 0x0001C028 File Offset: 0x0001A228
		[global::Cpp2ILInjected.Token(Token = "0x60030B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x172BB44", Offset = "0x172BB44", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(256)]
		public void Add(T item)
		{
			throw null;
		}

		// Token: 0x06002C43 RID: 11331 RVA: 0x0001C02B File Offset: 0x0001A22B
		[global::Cpp2ILInjected.Token(Token = "0x60030B4")]
		[global::Cpp2ILInjected.Address(RVA = "0x172BB8C", Offset = "0x172BB8C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(8)]
		private void AddWithResize(T item)
		{
			throw null;
		}

		// Token: 0x06002C44 RID: 11332 RVA: 0x0001C02E File Offset: 0x0001A22E
		[global::Cpp2ILInjected.Token(Token = "0x60030B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x172BBE4", Offset = "0x172BBE4", Length = "0x174")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowWrongValueTypeArgumentException", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		private int System.Collections.IList.Add(object item)
		{
			throw null;
		}

		// Token: 0x06002C45 RID: 11333 RVA: 0x0001C031 File Offset: 0x0001A231
		[global::Cpp2ILInjected.Token(Token = "0x60030B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x172BD58", Offset = "0x172BD58", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void AddRange(IEnumerable<T> collection)
		{
			throw null;
		}

		// Token: 0x06002C46 RID: 11334 RVA: 0x0001C034 File Offset: 0x0001A234
		[global::Cpp2ILInjected.Token(Token = "0x60030B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x172BD78", Offset = "0x172BD78", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public global::System.Collections.ObjectModel.ReadOnlyCollection<T> AsReadOnly()
		{
			throw null;
		}

		// Token: 0x06002C47 RID: 11335 RVA: 0x0001C037 File Offset: 0x0001A237
		[global::Cpp2ILInjected.Token(Token = "0x60030B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x172BDDC", Offset = "0x172BDDC", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[MethodImpl(256)]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x06002C48 RID: 11336 RVA: 0x0001C03A File Offset: 0x0001A23A
		[global::Cpp2ILInjected.Token(Token = "0x60030B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x172BE04", Offset = "0x172BE04", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool Contains(T item)
		{
			throw null;
		}

		// Token: 0x06002C49 RID: 11337 RVA: 0x0001C03D File Offset: 0x0001A23D
		[global::Cpp2ILInjected.Token(Token = "0x60030BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x172BE3C", Offset = "0x172BE3C", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private bool System.Collections.IList.Contains(object item)
		{
			throw null;
		}

		// Token: 0x06002C4A RID: 11338 RVA: 0x0001C040 File Offset: 0x0001A240
		[global::Cpp2ILInjected.Token(Token = "0x60030BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x172BF28", Offset = "0x172BF28", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void CopyTo(T[] array)
		{
			throw null;
		}

		// Token: 0x06002C4B RID: 11339 RVA: 0x0001C043 File Offset: 0x0001A243
		[global::Cpp2ILInjected.Token(Token = "0x60030BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x172BF40", Offset = "0x172BF40", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Rank", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new object[] { typeof(global::System.ExceptionResource) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentException_Argument_InvalidArrayType", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private void System.Collections.ICollection.CopyTo(global::System.Array array, int arrayIndex)
		{
			throw null;
		}

		// Token: 0x06002C4C RID: 11340 RVA: 0x0001C046 File Offset: 0x0001A246
		[global::Cpp2ILInjected.Token(Token = "0x60030BD")]
		[global::Cpp2ILInjected.Address(RVA = "0x172C01C", Offset = "0x172C01C", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public void CopyTo(T[] array, int arrayIndex)
		{
			throw null;
		}

		// Token: 0x06002C4D RID: 11341 RVA: 0x0001C049 File Offset: 0x0001A249
		[global::Cpp2ILInjected.Token(Token = "0x60030BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x172C03C", Offset = "0x172C03C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void EnsureCapacity(int min)
		{
			throw null;
		}

		// Token: 0x06002C4E RID: 11342 RVA: 0x0001C04C File Offset: 0x0001A24C
		[global::Cpp2ILInjected.Token(Token = "0x60030BF")]
		[global::Cpp2ILInjected.Address(RVA = "0x172C088", Offset = "0x172C088", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		public T Find(global::System.Predicate<T> match)
		{
			throw null;
		}

		// Token: 0x06002C4F RID: 11343 RVA: 0x0001C04F File Offset: 0x0001A24F
		[global::Cpp2ILInjected.Token(Token = "0x60030C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x172C124", Offset = "0x172C124", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion", ReturnType = typeof(void))]
		public void ForEach(global::System.Action<T> action)
		{
			throw null;
		}

		// Token: 0x06002C50 RID: 11344 RVA: 0x0001C052 File Offset: 0x0001A252
		[global::Cpp2ILInjected.Token(Token = "0x60030C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x172C1E0", Offset = "0x172C1E0", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<>.Enumerator), Member = ".ctor", MemberParameters = new object[] { "System.Collections.Generic.List`1<T>" }, ReturnType = typeof(void))]
		public List<T>.Enumerator GetEnumerator()
		{
			throw null;
		}

		// Token: 0x06002C51 RID: 11345 RVA: 0x0001C055 File Offset: 0x0001A255
		[global::Cpp2ILInjected.Token(Token = "0x60030C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x172C200", Offset = "0x172C200", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<>.Enumerator), Member = ".ctor", MemberParameters = new object[] { "System.Collections.Generic.List`1<T>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
		{
			throw null;
		}

		// Token: 0x06002C52 RID: 11346 RVA: 0x0001C058 File Offset: 0x0001A258
		[global::Cpp2ILInjected.Token(Token = "0x60030C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x172C260", Offset = "0x172C260", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<>.Enumerator), Member = ".ctor", MemberParameters = new object[] { "System.Collections.Generic.List`1<T>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw null;
		}

		// Token: 0x06002C53 RID: 11347 RVA: 0x0001C05B File Offset: 0x0001A25B
		[global::Cpp2ILInjected.Token(Token = "0x60030C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x172C2C0", Offset = "0x172C2C0", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public int IndexOf(T item)
		{
			throw null;
		}

		// Token: 0x06002C54 RID: 11348 RVA: 0x0001C05E File Offset: 0x0001A25E
		[global::Cpp2ILInjected.Token(Token = "0x60030C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x172C2E4", Offset = "0x172C2E4", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private int System.Collections.IList.IndexOf(object item)
		{
			throw null;
		}

		// Token: 0x06002C55 RID: 11349 RVA: 0x0001C061 File Offset: 0x0001A261
		[global::Cpp2ILInjected.Token(Token = "0x60030C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x172C3D0", Offset = "0x172C3D0", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new object[]
		{
			typeof(global::System.ExceptionArgument),
			typeof(global::System.ExceptionResource)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public void Insert(int index, T item)
		{
			throw null;
		}

		// Token: 0x06002C56 RID: 11350 RVA: 0x0001C064 File Offset: 0x0001A264
		[global::Cpp2ILInjected.Token(Token = "0x60030C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x172C48C", Offset = "0x172C48C", Length = "0x168")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowWrongValueTypeArgumentException", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		private void System.Collections.IList.Insert(int index, object item)
		{
			throw null;
		}

		// Token: 0x06002C57 RID: 11351 RVA: 0x0001C067 File Offset: 0x0001A267
		[global::Cpp2ILInjected.Token(Token = "0x60030C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x172C5F4", Offset = "0x172C5F4", Length = "0x548")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		public void InsertRange(int index, IEnumerable<T> collection)
		{
			throw null;
		}

		// Token: 0x06002C58 RID: 11352 RVA: 0x0001C06A File Offset: 0x0001A26A
		[global::Cpp2ILInjected.Token(Token = "0x60030C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x172CB3C", Offset = "0x172CB3C", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool Remove(T item)
		{
			throw null;
		}

		// Token: 0x06002C59 RID: 11353 RVA: 0x0001C06D File Offset: 0x0001A26D
		[global::Cpp2ILInjected.Token(Token = "0x60030CA")]
		[global::Cpp2ILInjected.Address(RVA = "0x172CB98", Offset = "0x172CB98", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void System.Collections.IList.Remove(object item)
		{
			throw null;
		}

		// Token: 0x06002C5A RID: 11354 RVA: 0x0001C070 File Offset: 0x0001A270
		[global::Cpp2ILInjected.Token(Token = "0x60030CB")]
		[global::Cpp2ILInjected.Address(RVA = "0x172CC80", Offset = "0x172CC80", Length = "0x154")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public int RemoveAll(global::System.Predicate<T> match)
		{
			throw null;
		}

		// Token: 0x06002C5B RID: 11355 RVA: 0x0001C073 File Offset: 0x0001A273
		[global::Cpp2ILInjected.Token(Token = "0x60030CC")]
		[global::Cpp2ILInjected.Address(RVA = "0x172CDD4", Offset = "0x172CDD4", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public void RemoveAt(int index)
		{
			throw null;
		}

		// Token: 0x06002C5C RID: 11356 RVA: 0x0001C076 File Offset: 0x0001A276
		[global::Cpp2ILInjected.Token(Token = "0x60030CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x172CE4C", Offset = "0x172CE4C", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new object[]
		{
			typeof(global::System.ExceptionArgument),
			typeof(global::System.ExceptionResource)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new object[] { typeof(global::System.ExceptionResource) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowIndexArgumentOutOfRange_NeedNonNegNumException", ReturnType = typeof(void))]
		public void RemoveRange(int index, int count)
		{
			throw null;
		}

		// Token: 0x06002C5D RID: 11357 RVA: 0x0001C079 File Offset: 0x0001A279
		[global::Cpp2ILInjected.Token(Token = "0x60030CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x172CF0C", Offset = "0x172CF0C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Reverse()
		{
			throw null;
		}

		// Token: 0x06002C5E RID: 11358 RVA: 0x0001C07C File Offset: 0x0001A27C
		[global::Cpp2ILInjected.Token(Token = "0x60030CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x172CF58", Offset = "0x172CF58", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new object[] { typeof(global::System.ExceptionResource) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowIndexArgumentOutOfRange_NeedNonNegNumException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new object[]
		{
			typeof(global::System.ExceptionArgument),
			typeof(global::System.ExceptionResource)
		}, ReturnType = typeof(void))]
		public void Reverse(int index, int count)
		{
			throw null;
		}

		// Token: 0x06002C5F RID: 11359 RVA: 0x0001C07F File Offset: 0x0001A27F
		[global::Cpp2ILInjected.Token(Token = "0x60030D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x172CFFC", Offset = "0x172CFFC", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Sort()
		{
			throw null;
		}

		// Token: 0x06002C60 RID: 11360 RVA: 0x0001C082 File Offset: 0x0001A282
		[global::Cpp2ILInjected.Token(Token = "0x60030D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x172D04C", Offset = "0x172D04C", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Sort(IComparer<T> comparer)
		{
			throw null;
		}

		// Token: 0x06002C61 RID: 11361 RVA: 0x0001C085 File Offset: 0x0001A285
		[global::Cpp2ILInjected.Token(Token = "0x60030D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x172D0A0", Offset = "0x172D0A0", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new object[] { typeof(global::System.ExceptionResource) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowIndexArgumentOutOfRange_NeedNonNegNumException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new object[]
		{
			typeof(global::System.ExceptionArgument),
			typeof(global::System.ExceptionResource)
		}, ReturnType = typeof(void))]
		public void Sort(int index, int count, IComparer<T> comparer)
		{
			throw null;
		}

		// Token: 0x06002C62 RID: 11362 RVA: 0x0001C088 File Offset: 0x0001A288
		[global::Cpp2ILInjected.Token(Token = "0x60030D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x172D14C", Offset = "0x172D14C", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Sort(global::System.Comparison<T> comparison)
		{
			throw null;
		}

		// Token: 0x06002C63 RID: 11363 RVA: 0x0001C08B File Offset: 0x0001A28B
		[global::Cpp2ILInjected.Token(Token = "0x60030D4")]
		[global::Cpp2ILInjected.Address(RVA = "0x172D1E4", Offset = "0x172D1E4", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public T[] ToArray()
		{
			throw null;
		}

		// Token: 0x06002C64 RID: 11364 RVA: 0x0001C08E File Offset: 0x0001A28E
		[global::Cpp2ILInjected.Token(Token = "0x60030D5")]
		[global::Cpp2ILInjected.Address(RVA = "0x172D290", Offset = "0x172D290", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void TrimExcess()
		{
			throw null;
		}

		// Token: 0x06002C65 RID: 11365 RVA: 0x0001C091 File Offset: 0x0001A291
		[global::Cpp2ILInjected.Token(Token = "0x60030D6")]
		[global::Cpp2ILInjected.Address(RVA = "0x172D2E8", Offset = "0x172D2E8", Length = "0x32C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private void AddEnumerable(IEnumerable<T> enumerable)
		{
			throw null;
		}

		// Token: 0x06002C66 RID: 11366 RVA: 0x0001C094 File Offset: 0x0001A294
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60030D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x172D614", Offset = "0x172D614", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		static List()
		{
			throw null;
		}

		// Token: 0x04001613 RID: 5651
		[global::Cpp2ILInjected.Token(Token = "0x4001A6F")]
		private const int DefaultCapacity = 4;

		// Token: 0x04001614 RID: 5652
		[global::Cpp2ILInjected.Token(Token = "0x4001A70")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private T[] _items;

		// Token: 0x04001615 RID: 5653
		[global::Cpp2ILInjected.Token(Token = "0x4001A71")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int _size;

		// Token: 0x04001616 RID: 5654
		[global::Cpp2ILInjected.Token(Token = "0x4001A72")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int _version;

		// Token: 0x04001617 RID: 5655
		[global::Cpp2ILInjected.Token(Token = "0x4001A73")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		[global::System.NonSerialized]
		private object _syncRoot;

		// Token: 0x04001618 RID: 5656
		[global::Cpp2ILInjected.Token(Token = "0x4001A74")]
		private static readonly T[] s_emptyArray;

		// Token: 0x0200065E RID: 1630
		[global::Cpp2ILInjected.Token(Token = "0x200063B")]
		[global::System.Serializable]
		public struct Enumerator : IEnumerator<T>, global::System.IDisposable, IEnumerator
		{
			// Token: 0x06004335 RID: 17205 RVA: 0x000203F3 File Offset: 0x0001E5F3
			[global::Cpp2ILInjected.Token(Token = "0x60030D8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1643D84", Offset = "0x1643D84", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(List<>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(List<>), Member = "System.Collections.Generic.IEnumerable<T>.GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<T>")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(List<>), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			internal Enumerator(List<T> list)
			{
				throw null;
			}

			// Token: 0x06004336 RID: 17206 RVA: 0x000203F6 File Offset: 0x0001E5F6
			[global::Cpp2ILInjected.Token(Token = "0x60030D9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1643D9C", Offset = "0x1643D9C", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void Dispose()
			{
				throw null;
			}

			// Token: 0x06004337 RID: 17207 RVA: 0x000203F9 File Offset: 0x0001E5F9
			[global::Cpp2ILInjected.Token(Token = "0x60030DA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1643DA0", Offset = "0x1643DA0", Length = "0x98")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Linq.Enumerable.WhereListIterator`1", Member = "MoveNext", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Linq.Enumerable.WhereSelectListIterator`2", Member = "MoveNext", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public bool MoveNext()
			{
				throw null;
			}

			// Token: 0x06004338 RID: 17208 RVA: 0x000203FC File Offset: 0x0001E5FC
			[global::Cpp2ILInjected.Token(Token = "0x60030DB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1643E38", Offset = "0x1643E38", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion", ReturnType = typeof(void))]
			private bool MoveNextRare()
			{
				throw null;
			}

			// Token: 0x170007E9 RID: 2025
			// (get) Token: 0x06004339 RID: 17209 RVA: 0x000203FF File Offset: 0x0001E5FF
			[global::Cpp2ILInjected.Token(Token = "0x170007DF")]
			public T Current
			{
				[global::Cpp2ILInjected.Token(Token = "0x60030DC")]
				[global::Cpp2ILInjected.Address(RVA = "0x1643E7C", Offset = "0x1643E7C", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170007EA RID: 2026
			// (get) Token: 0x0600433A RID: 17210 RVA: 0x00020402 File Offset: 0x0001E602
			[global::Cpp2ILInjected.Token(Token = "0x170007E0")]
			private object System.Collections.IEnumerator.Current
			{
				[global::Cpp2ILInjected.Token(Token = "0x60030DD")]
				[global::Cpp2ILInjected.Address(RVA = "0x1643E88", Offset = "0x1643E88", Length = "0x8C")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0600433B RID: 17211 RVA: 0x00020405 File Offset: 0x0001E605
			[global::Cpp2ILInjected.Token(Token = "0x60030DE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1643F14", Offset = "0x1643F14", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion", ReturnType = typeof(void))]
			private void System.Collections.IEnumerator.Reset()
			{
				throw null;
			}

			// Token: 0x04001AD3 RID: 6867
			[global::Cpp2ILInjected.Token(Token = "0x4001A75")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private List<T> _list;

			// Token: 0x04001AD4 RID: 6868
			[global::Cpp2ILInjected.Token(Token = "0x4001A76")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int _index;

			// Token: 0x04001AD5 RID: 6869
			[global::Cpp2ILInjected.Token(Token = "0x4001A77")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int _version;

			// Token: 0x04001AD6 RID: 6870
			[global::Cpp2ILInjected.Token(Token = "0x4001A78")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private T _current;
		}
	}
}
