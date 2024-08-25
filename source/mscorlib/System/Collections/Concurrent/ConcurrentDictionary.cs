using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Collections.Concurrent
{
	[global::System.Diagnostics.DebuggerDisplay("Count = {Count}")]
	[global::System.Diagnostics.DebuggerTypeProxy(typeof(global::System.Collections.Concurrent.IDictionaryDebugView<, >))]
	[global::Cpp2ILInjected.Token(Token = "0x2000616")]
	[global::System.Serializable]
	public class ConcurrentDictionary<TKey, TValue> : global::System.Collections.Generic.IDictionary<TKey, TValue>, global::System.Collections.Generic.ICollection<global::System.Collections.Generic.KeyValuePair<TKey, TValue>>, global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<TKey, TValue>>, IEnumerable, IDictionary, ICollection, global::System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>, global::System.Collections.Generic.IReadOnlyCollection<global::System.Collections.Generic.KeyValuePair<TKey, TValue>>
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002F7A")]
		[global::Cpp2ILInjected.Address(RVA = "0x19130A0", Offset = "0x19130A0", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeCode", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(global::System.TypeCode))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "get_Size", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static bool IsValueWriteAtomic()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002F7B")]
		[global::Cpp2ILInjected.Address(RVA = "0x191318C", Offset = "0x191318C", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Telepathy.Server", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public ConcurrentDictionary()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002F7C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1913210", Offset = "0x1913210", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public ConcurrentDictionary(global::System.Collections.Generic.IEqualityComparer<TKey> comparer)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002F7D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1913298", Offset = "0x1913298", Length = "0x428")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		private void InitializeFromCollection(global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<TKey, TValue>> collection)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002F7E")]
		[global::Cpp2ILInjected.Address(RVA = "0x19136C0", Offset = "0x19136C0", Length = "0x280")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		internal ConcurrentDictionary(int concurrencyLevel, int capacity, bool growLockArray, global::System.Collections.Generic.IEqualityComparer<TKey> comparer)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002F7F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1913940", Offset = "0x1913940", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public bool TryAdd(TKey key, TValue value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002F80")]
		[global::Cpp2ILInjected.Address(RVA = "0x1913A30", Offset = "0x1913A30", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool ContainsKey(TKey key)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002F81")]
		[global::Cpp2ILInjected.Address(RVA = "0x1913A5C", Offset = "0x1913A5C", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Telepathy.Server.<>c__DisplayClass8_0", Member = "<Listen>b__1", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public bool TryRemove(TKey key, out TValue value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002F82")]
		[global::Cpp2ILInjected.Address(RVA = "0x1913A78", Offset = "0x1913A78", Length = "0x3C0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		private bool TryRemoveInternal(TKey key, out TValue value, bool matchValue, TValue oldValue)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002F83")]
		[global::Cpp2ILInjected.Address(RVA = "0x1913E38", Offset = "0x1913E38", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Telepathy.Server", Member = "NextConnectionId", MemberParameters = new object[] { "System.Net.Sockets.TcpClient" }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Telepathy.Server", Member = "Send", MemberParameters = new object[]
		{
			typeof(int),
			"System.Byte[]",
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Telepathy.Server", Member = "GetClientAddress", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Telepathy.Server", Member = "Disconnect", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public bool TryGetValue(TKey key, out TValue value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002F84")]
		[global::Cpp2ILInjected.Address(RVA = "0x1913F08", Offset = "0x1913F08", Length = "0x154")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private bool TryGetValueInternal(TKey key, int hashcode, out TValue value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002F85")]
		[global::Cpp2ILInjected.Address(RVA = "0x191405C", Offset = "0x191405C", Length = "0x208")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Telepathy.Server", Member = "Cleanup", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public void Clear()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002F86")]
		[global::Cpp2ILInjected.Address(RVA = "0x1914264", Offset = "0x1914264", Length = "0x260")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		private void Method_Private_Virtual_Final_New_Void_KeyValuePair_2_Int32_0(global::System.Collections.Generic.KeyValuePair<TKey, TValue>[] array, int index)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002F87")]
		[global::Cpp2ILInjected.Address(RVA = "0x19144C4", Offset = "0x19144C4", Length = "0x204")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public global::System.Collections.Generic.KeyValuePair<TKey, TValue>[] ToArray()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002F88")]
		[global::Cpp2ILInjected.Address(RVA = "0x19146C8", Offset = "0x19146C8", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.KeyValuePair<int, object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void CopyToPairs(global::System.Collections.Generic.KeyValuePair<TKey, TValue>[] array, int index)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002F89")]
		[global::Cpp2ILInjected.Address(RVA = "0x1914774", Offset = "0x1914774", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DictionaryEntry), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void CopyToEntries(DictionaryEntry[] array, int index)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002F8A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1914840", Offset = "0x1914840", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.KeyValuePair<int, object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private void CopyToObjects(object[] array, int index)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002F8B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1914938", Offset = "0x1914938", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Telepathy.Server", Member = "Cleanup", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002F8C")]
		[global::Cpp2ILInjected.Address(RVA = "0x19149A0", Offset = "0x19149A0", Length = "0x4B8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
		private bool TryAddInternal(TKey key, int hashcode, TValue value, bool updateIfExists, bool acquireLock, out TValue resultingValue)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000784")]
		public TValue this[TKey key]
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002F8D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1914E58", Offset = "0x1914E58", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6002F8E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1914F08", Offset = "0x1914F08", Length = "0xEC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Telepathy.Server", Member = "Listen", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002F8F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1914FF4", Offset = "0x1914FF4", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.KeyNotFoundException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		[MethodImpl(8)]
		private static void ThrowKeyNotFoundException(object key)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002F90")]
		[global::Cpp2ILInjected.Address(RVA = "0x1915060", Offset = "0x1915060", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		[MethodImpl(8)]
		private static void ThrowKeyNullException()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000785")]
		public int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002F91")]
			[global::Cpp2ILInjected.Address(RVA = "0x19150AC", Offset = "0x19150AC", Length = "0xFC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002F92")]
		[global::Cpp2ILInjected.Address(RVA = "0x19151A8", Offset = "0x19151A8", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private int GetCountInternal()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002F93")]
		[global::Cpp2ILInjected.Address(RVA = "0x1915234", Offset = "0x1915234", Length = "0x180")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public TValue GetOrAdd(TKey key, global::System.Func<TKey, TValue> valueFactory)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002F94")]
		[global::Cpp2ILInjected.Address(RVA = "0x19153B4", Offset = "0x19153B4", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public TValue GetOrAdd(TKey key, TValue value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002F95")]
		[global::Cpp2ILInjected.Address(RVA = "0x19154D0", Offset = "0x19154D0", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void Method_Private_Virtual_Final_New_Void_TKey_TValue_0(TKey key, TValue value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002F96")]
		[global::Cpp2ILInjected.Address(RVA = "0x191553C", Offset = "0x191553C", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private bool Method_Private_Virtual_Final_New_Boolean_TKey_0(TKey key)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000786")]
		public global::System.Collections.Generic.ICollection<TKey> Keys
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002F97")]
			[global::Cpp2ILInjected.Address(RVA = "0x1915568", Offset = "0x1915568", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000787")]
		public global::System.Collections.Generic.ICollection<TValue> Values
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002F98")]
			[global::Cpp2ILInjected.Address(RVA = "0x191557C", Offset = "0x191557C", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002F99")]
		[global::Cpp2ILInjected.Address(RVA = "0x1915590", Offset = "0x1915590", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void Method_Private_Virtual_Final_New_Void_KeyValuePair_2_0(global::System.Collections.Generic.KeyValuePair<TKey, TValue> keyValuePair)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002F9A")]
		[global::Cpp2ILInjected.Address(RVA = "0x191562C", Offset = "0x191562C", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private bool Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_0(global::System.Collections.Generic.KeyValuePair<TKey, TValue> keyValuePair)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000788")]
		private bool prop_Boolean_0
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002F9B")]
			[global::Cpp2ILInjected.Address(RVA = "0x191569C", Offset = "0x191569C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002F9C")]
		[global::Cpp2ILInjected.Address(RVA = "0x19156A4", Offset = "0x19156A4", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private bool Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_1(global::System.Collections.Generic.KeyValuePair<TKey, TValue> keyValuePair)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002F9D")]
		[global::Cpp2ILInjected.Address(RVA = "0x19156D8", Offset = "0x19156D8", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002F9E")]
		[global::Cpp2ILInjected.Address(RVA = "0x19156EC", Offset = "0x19156EC", Length = "0x27C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
		private void System.Collections.IDictionary.Add(object key, object value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002F9F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1915968", Offset = "0x1915968", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private bool System.Collections.IDictionary.Contains(object key)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002FA0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1915A6C", Offset = "0x1915A6C", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000789")]
		private bool System.Collections.IDictionary.IsFixedSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002FA1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1915AD0", Offset = "0x1915AD0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700078A")]
		private bool System.Collections.IDictionary.IsReadOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002FA2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1915AD8", Offset = "0x1915AD8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700078B")]
		private ICollection System.Collections.IDictionary.Keys
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002FA3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1915AE0", Offset = "0x1915AE0", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002FA4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1915AF4", Offset = "0x1915AF4", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private void System.Collections.IDictionary.Remove(object key)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700078C")]
		private ICollection System.Collections.IDictionary.Values
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002FA5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1915BEC", Offset = "0x1915BEC", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700078D")]
		private object System.Collections.IDictionary.Item
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002FA6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1915C00", Offset = "0x1915C00", Length = "0x104")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6002FA7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1915D04", Offset = "0x1915D04", Length = "0x1E0")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002FA8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1915EE4", Offset = "0x1915EE4", Length = "0x3BC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 34)]
		private void System.Collections.ICollection.CopyTo(global::System.Array array, int index)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700078E")]
		private bool System.Collections.ICollection.IsSynchronized
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002FA9")]
			[global::Cpp2ILInjected.Address(RVA = "0x19162A0", Offset = "0x19162A0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700078F")]
		private object System.Collections.ICollection.SyncRoot
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002FAA")]
			[global::Cpp2ILInjected.Address(RVA = "0x19162A8", Offset = "0x19162A8", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002FAB")]
		[global::Cpp2ILInjected.Address(RVA = "0x19162F4", Offset = "0x19162F4", Length = "0x6B4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 47)]
		private void GrowTable(ConcurrentDictionary<TKey, TValue>.Tables tables)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002FAC")]
		[global::Cpp2ILInjected.Address(RVA = "0x19169A8", Offset = "0x19169A8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static int GetBucket(int hashcode, int bucketCount)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002FAD")]
		[global::Cpp2ILInjected.Address(RVA = "0x19169B8", Offset = "0x19169B8", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static void GetBucketAndLockNo(int hashcode, out int bucketNo, out int lockNo, int bucketCount, int lockCount)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000790")]
		private static int DefaultConcurrencyLevel
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002FAE")]
			[global::Cpp2ILInjected.Address(RVA = "0x19169D8", Offset = "0x19169D8", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.PlatformHelper), Member = "get_ProcessorCount", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002FAF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1916A28", Offset = "0x1916A28", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Diagnostics.Tracing.EventSource), Member = "IsEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CDSCollectionETWBCLProvider), Member = "ConcurrentDictionary_AcquiringAllLocks", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void AcquireAllLocks(ref int locksAcquired)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002FB0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1916B28", Offset = "0x1916B28", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private void AcquireLocks(int fromInclusive, int toExclusive, ref int locksAcquired)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002FB1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1916C18", Offset = "0x1916C18", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void ReleaseLocks(int fromInclusive, int toExclusive)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002FB2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1916C70", Offset = "0x1916C70", Length = "0x22C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.OutOfMemoryException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		private global::System.Collections.ObjectModel.ReadOnlyCollection<TKey> GetKeys()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002FB3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1916E9C", Offset = "0x1916E9C", Length = "0x22C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.OutOfMemoryException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		private global::System.Collections.ObjectModel.ReadOnlyCollection<TValue> GetValues()
		{
			throw null;
		}

		[global::System.Runtime.Serialization.OnSerializing]
		[global::Cpp2ILInjected.Token(Token = "0x6002FB4")]
		[global::Cpp2ILInjected.Address(RVA = "0x19170C8", Offset = "0x19170C8", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void OnSerializing(global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		[global::System.Runtime.Serialization.OnSerialized]
		[global::Cpp2ILInjected.Token(Token = "0x6002FB5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1917120", Offset = "0x1917120", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void OnSerialized(global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		[global::System.Runtime.Serialization.OnDeserialized]
		[global::Cpp2ILInjected.Token(Token = "0x6002FB6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1917128", Offset = "0x1917128", Length = "0x1A8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		private void OnDeserialized(global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6002FB7")]
		[global::Cpp2ILInjected.Address(RVA = "0x19172D0", Offset = "0x19172D0", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static ConcurrentDictionary()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4001A2B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		[global::System.NonSerialized]
		private ConcurrentDictionary<TKey, TValue>.Tables _tables;

		[global::Cpp2ILInjected.Token(Token = "0x4001A2C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private global::System.Collections.Generic.IEqualityComparer<TKey> _comparer;

		[global::Cpp2ILInjected.Token(Token = "0x4001A2D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		[global::System.NonSerialized]
		private readonly bool _growLockArray;

		[global::Cpp2ILInjected.Token(Token = "0x4001A2E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		[global::System.NonSerialized]
		private int _budget;

		[global::Cpp2ILInjected.Token(Token = "0x4001A2F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private global::System.Collections.Generic.KeyValuePair<TKey, TValue>[] _serializationArray;

		[global::Cpp2ILInjected.Token(Token = "0x4001A30")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int _serializationConcurrencyLevel;

		[global::Cpp2ILInjected.Token(Token = "0x4001A31")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int _serializationCapacity;

		[global::Cpp2ILInjected.Token(Token = "0x4001A32")]
		private static readonly bool s_isValueWriteAtomic;

		[global::Cpp2ILInjected.Token(Token = "0x2000617")]
		private sealed class Tables
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002FB8")]
			[global::Cpp2ILInjected.Address(RVA = "0x186FD6C", Offset = "0x186FD6C", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal Tables(ConcurrentDictionary<TKey, TValue>.Node[] buckets, object[] locks, int[] countPerLock)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4001A33")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal readonly ConcurrentDictionary<TKey, TValue>.Node[] _buckets;

			[global::Cpp2ILInjected.Token(Token = "0x4001A34")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal readonly object[] _locks;

			[global::Cpp2ILInjected.Token(Token = "0x4001A35")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal int[] _countPerLock;
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000618")]
		[global::System.Serializable]
		private sealed class Node
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002FB9")]
			[global::Cpp2ILInjected.Address(RVA = "0x17CE8D8", Offset = "0x17CE8D8", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal Node(TKey key, TValue value, int hashcode, ConcurrentDictionary<TKey, TValue>.Node next)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4001A36")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal readonly TKey _key;

			[global::Cpp2ILInjected.Token(Token = "0x4001A37")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal TValue _value;

			[global::Cpp2ILInjected.Token(Token = "0x4001A38")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal ConcurrentDictionary<TKey, TValue>.Node _next;

			[global::Cpp2ILInjected.Token(Token = "0x4001A39")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal readonly int _hashcode;
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000619")]
		[global::System.Serializable]
		private sealed class DictionaryEnumerator : IDictionaryEnumerator, IEnumerator
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002FBA")]
			[global::Cpp2ILInjected.Address(RVA = "0x192363C", Offset = "0x192363C", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			internal DictionaryEnumerator(ConcurrentDictionary<TKey, TValue> dictionary)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x17000791")]
			public DictionaryEntry Entry
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002FBB")]
				[global::Cpp2ILInjected.Address(RVA = "0x1923680", Offset = "0x1923680", Length = "0x158")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DictionaryEntry), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(object)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x17000792")]
			public object Key
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002FBC")]
				[global::Cpp2ILInjected.Address(RVA = "0x19237D8", Offset = "0x19237D8", Length = "0xB4")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x17000793")]
			public object Value
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002FBD")]
				[global::Cpp2ILInjected.Address(RVA = "0x192388C", Offset = "0x192388C", Length = "0x88")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x17000794")]
			public object Current
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002FBE")]
				[global::Cpp2ILInjected.Address(RVA = "0x1923914", Offset = "0x1923914", Length = "0x80")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002FBF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1923994", Offset = "0x1923994", Length = "0x98")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public bool MoveNext()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002FC0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1923A2C", Offset = "0x1923A2C", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public void Reset()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4001A3A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<TKey, TValue>> _enumerator;
		}

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200061A")]
		private sealed class <GetEnumerator>d__35 : global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<TKey, TValue>>, global::System.IDisposable, IEnumerator
		{
			[global::System.Diagnostics.DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6002FC1")]
			[global::Cpp2ILInjected.Address(RVA = "0x15BABCC", Offset = "0x15BABCC", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <GetEnumerator>d__35(int <>1__state)
			{
				throw null;
			}

			[global::System.Diagnostics.DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6002FC2")]
			[global::Cpp2ILInjected.Address(RVA = "0x15BABF4", Offset = "0x15BABF4", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private void System.IDisposable.Dispose()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002FC3")]
			[global::Cpp2ILInjected.Address(RVA = "0x15BABF8", Offset = "0x15BABF8", Length = "0xF0")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.KeyValuePair<int, object>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(int),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			private bool MoveNext()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x17000795")]
			private global::System.Collections.Generic.KeyValuePair<TKey, TValue> prop_KeyValuePair_2_0
			{
				[global::System.Diagnostics.DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x6002FC4")]
				[global::Cpp2ILInjected.Address(RVA = "0x15BACE8", Offset = "0x15BACE8", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			[global::System.Diagnostics.DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6002FC5")]
			[global::Cpp2ILInjected.Address(RVA = "0x15BACF4", Offset = "0x15BACF4", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			private void System.Collections.IEnumerator.Reset()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x17000796")]
			private object System.Collections.IEnumerator.Current
			{
				[global::System.Diagnostics.DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x6002FC6")]
				[global::Cpp2ILInjected.Address(RVA = "0x15BAD2C", Offset = "0x15BAD2C", Length = "0x3C")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x4001A3B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[global::Cpp2ILInjected.Token(Token = "0x4001A3C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private global::System.Collections.Generic.KeyValuePair<TKey, TValue> <>2__current;

			[global::Cpp2ILInjected.Token(Token = "0x4001A3D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public ConcurrentDictionary<TKey, TValue> <>4__this;

			[global::Cpp2ILInjected.Token(Token = "0x4001A3E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private ConcurrentDictionary<TKey, TValue>.Node[] <buckets>5__2;

			[global::Cpp2ILInjected.Token(Token = "0x4001A3F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int <i>5__3;

			[global::Cpp2ILInjected.Token(Token = "0x4001A40")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private ConcurrentDictionary<TKey, TValue>.Node <current>5__4;
		}
	}
}
