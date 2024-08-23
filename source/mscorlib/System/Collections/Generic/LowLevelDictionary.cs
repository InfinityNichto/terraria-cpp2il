using System;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Collections.Generic
{
	// Token: 0x02000527 RID: 1319
	[global::Cpp2ILInjected.Token(Token = "0x2000640")]
	internal class LowLevelDictionary<TKey, TValue>
	{
		// Token: 0x06002C7D RID: 11389 RVA: 0x0001C0D9 File Offset: 0x0001A2D9
		[global::Cpp2ILInjected.Token(Token = "0x60030F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x17C7EE4", Offset = "0x17C7EE4", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.DebuggerSupport), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public LowLevelDictionary()
		{
			throw null;
		}

		// Token: 0x06002C7E RID: 11390 RVA: 0x0001C0DC File Offset: 0x0001A2DC
		[global::Cpp2ILInjected.Token(Token = "0x60030F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x17C7F5C", Offset = "0x17C7F5C", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public LowLevelDictionary(int capacity, IEqualityComparer<TKey> comparer)
		{
			throw null;
		}

		// Token: 0x170006F0 RID: 1776
		[global::Cpp2ILInjected.Token(Token = "0x170007E5")]
		public TKey this[TKey key]
		{
			[global::Cpp2ILInjected.Token(Token = "0x60030F7")]
			[global::Cpp2ILInjected.Address(RVA = "0x17C7FAC", Offset = "0x17C7FAC", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.DebuggerSupport), Member = "AddToActiveTasksNonInlined", MemberParameters = new object[] { typeof(global::System.Threading.Tasks.Task) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06002C80 RID: 11392 RVA: 0x0001C0E2 File Offset: 0x0001A2E2
		[global::Cpp2ILInjected.Token(Token = "0x60030F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x17C802C", Offset = "0x17C802C", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Clear(int capacity = 17)
		{
			throw null;
		}

		// Token: 0x06002C81 RID: 11393 RVA: 0x0001C0E5 File Offset: 0x0001A2E5
		[global::Cpp2ILInjected.Token(Token = "0x60030F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x17C807C", Offset = "0x17C807C", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.DebuggerSupport), Member = "RemoveFromActiveTasksNonInlined", MemberParameters = new object[] { typeof(global::System.Threading.Tasks.Task) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public bool Remove(TKey key)
		{
			throw null;
		}

		// Token: 0x06002C82 RID: 11394 RVA: 0x0001C0E8 File Offset: 0x0001A2E8
		[global::Cpp2ILInjected.Token(Token = "0x60030FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x17C81E0", Offset = "0x17C81E0", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private LowLevelDictionary<TKey, TValue>.Entry Find(TKey key)
		{
			throw null;
		}

		// Token: 0x06002C83 RID: 11395 RVA: 0x0001C0EB File Offset: 0x0001A2EB
		[global::Cpp2ILInjected.Token(Token = "0x60030FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x17C82CC", Offset = "0x17C82CC", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private LowLevelDictionary<TKey, TValue>.Entry UncheckedAdd(TKey key, TValue value)
		{
			throw null;
		}

		// Token: 0x06002C84 RID: 11396 RVA: 0x0001C0EE File Offset: 0x0001A2EE
		[global::Cpp2ILInjected.Token(Token = "0x60030FC")]
		[global::Cpp2ILInjected.Address(RVA = "0x17C83D0", Offset = "0x17C83D0", Length = "0x188")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		private void ExpandBuckets()
		{
			throw null;
		}

		// Token: 0x06002C85 RID: 11397 RVA: 0x0001C0F1 File Offset: 0x0001A2F1
		[global::Cpp2ILInjected.Token(Token = "0x60030FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x17C8558", Offset = "0x17C8558", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private int GetBucket(TKey key, int numBuckets = 0)
		{
			throw null;
		}

		// Token: 0x04001624 RID: 5668
		[global::Cpp2ILInjected.Token(Token = "0x4001A84")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private LowLevelDictionary<TKey, TValue>.Entry[] _buckets;

		// Token: 0x04001625 RID: 5669
		[global::Cpp2ILInjected.Token(Token = "0x4001A85")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int _numEntries;

		// Token: 0x04001626 RID: 5670
		[global::Cpp2ILInjected.Token(Token = "0x4001A86")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int _version;

		// Token: 0x04001627 RID: 5671
		[global::Cpp2ILInjected.Token(Token = "0x4001A87")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private IEqualityComparer<TKey> _comparer;

		// Token: 0x0200065F RID: 1631
		[global::Cpp2ILInjected.Token(Token = "0x2000641")]
		private sealed class Entry
		{
			// Token: 0x0600433C RID: 17212 RVA: 0x00020408 File Offset: 0x0001E608
			[global::Cpp2ILInjected.Token(Token = "0x60030FE")]
			[global::Cpp2ILInjected.Address(RVA = "0x164118C", Offset = "0x164118C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public Entry()
			{
				throw null;
			}

			// Token: 0x04001AD7 RID: 6871
			[global::Cpp2ILInjected.Token(Token = "0x4001A88")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public TKey _key;

			// Token: 0x04001AD8 RID: 6872
			[global::Cpp2ILInjected.Token(Token = "0x4001A89")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public TValue _value;

			// Token: 0x04001AD9 RID: 6873
			[global::Cpp2ILInjected.Token(Token = "0x4001A8A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public LowLevelDictionary<TKey, TValue>.Entry _next;
		}

		// Token: 0x02000660 RID: 1632
		[global::Cpp2ILInjected.Token(Token = "0x2000642")]
		private sealed class DefaultComparer<T> : IEqualityComparer<T>
		{
			// Token: 0x0600433D RID: 17213 RVA: 0x0002040B File Offset: 0x0001E60B
			[global::Cpp2ILInjected.Token(Token = "0x60030FF")]
			[global::Cpp2ILInjected.Address(RVA = "0x192328C", Offset = "0x192328C", Length = "0x148")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			public bool Equals(T x, T y)
			{
				throw null;
			}

			// Token: 0x0600433E RID: 17214 RVA: 0x0002040E File Offset: 0x0001E60E
			[global::Cpp2ILInjected.Token(Token = "0x6003100")]
			[global::Cpp2ILInjected.Address(RVA = "0x19233D4", Offset = "0x19233D4", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public int GetHashCode(T obj)
			{
				throw null;
			}

			// Token: 0x0600433F RID: 17215 RVA: 0x00020411 File Offset: 0x0001E611
			[global::Cpp2ILInjected.Token(Token = "0x6003101")]
			[global::Cpp2ILInjected.Address(RVA = "0x1923410", Offset = "0x1923410", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public DefaultComparer()
			{
				throw null;
			}
		}
	}
}
