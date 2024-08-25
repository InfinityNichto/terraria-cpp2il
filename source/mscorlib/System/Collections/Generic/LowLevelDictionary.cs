using System;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Collections.Generic
{
	[global::Cpp2ILInjected.Token(Token = "0x2000640")]
	internal class LowLevelDictionary<TKey, TValue>
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x60030F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x17C802C", Offset = "0x17C802C", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Clear(int capacity = 17)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x4001A84")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private LowLevelDictionary<TKey, TValue>.Entry[] _buckets;

		[global::Cpp2ILInjected.Token(Token = "0x4001A85")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int _numEntries;

		[global::Cpp2ILInjected.Token(Token = "0x4001A86")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int _version;

		[global::Cpp2ILInjected.Token(Token = "0x4001A87")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private IEqualityComparer<TKey> _comparer;

		[global::Cpp2ILInjected.Token(Token = "0x2000641")]
		private sealed class Entry
		{
			[global::Cpp2ILInjected.Token(Token = "0x60030FE")]
			[global::Cpp2ILInjected.Address(RVA = "0x164118C", Offset = "0x164118C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public Entry()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4001A88")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public TKey _key;

			[global::Cpp2ILInjected.Token(Token = "0x4001A89")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public TValue _value;

			[global::Cpp2ILInjected.Token(Token = "0x4001A8A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public LowLevelDictionary<TKey, TValue>.Entry _next;
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000642")]
		private sealed class DefaultComparer<T> : IEqualityComparer<T>
		{
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
