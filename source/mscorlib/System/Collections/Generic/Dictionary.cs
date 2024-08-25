using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Collections.Generic
{
	[global::System.Diagnostics.DebuggerDisplay("Count = {Count}")]
	[global::System.Diagnostics.DebuggerTypeProxy(typeof(IDictionaryDebugView<, >))]
	[global::Cpp2ILInjected.Token(Token = "0x2000622")]
	[global::System.Serializable]
	public class Dictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair<TKey, TValue>>, global::System.Runtime.Serialization.ISerializable, global::System.Runtime.Serialization.IDeserializationCallback
	{
		[global::Cpp2ILInjected.Token(Token = "0x600301B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1926F00", Offset = "0x1926F00", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public Dictionary()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600301C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1926F1C", Offset = "0x1926F1C", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public Dictionary(int capacity)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600301D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1926F34", Offset = "0x1926F34", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Runtime.InteropServices.Marshal.<>c", Member = "<GetCustomMarshalerInstance>b__201_0", ReturnType = typeof(Dictionary<global::System.ValueTuple<global::System.Type, string>, global::System.Runtime.InteropServices.ICustomMarshaler>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public Dictionary(IEqualityComparer<TKey> comparer)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600301E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1926F54", Offset = "0x1926F54", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		public Dictionary(int capacity, IEqualityComparer<TKey> comparer)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600301F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1926FDC", Offset = "0x1926FDC", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public Dictionary(IDictionary<TKey, TValue> dictionary)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003020")]
		[global::Cpp2ILInjected.Address(RVA = "0x1926FF4", Offset = "0x1926FF4", Length = "0x4B8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		public Dictionary(IDictionary<TKey, TValue> dictionary, IEqualityComparer<TKey> comparer)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003021")]
		[global::Cpp2ILInjected.Address(RVA = "0x19274AC", Offset = "0x19274AC", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashHelpers), Member = "get_SerializationInfoTable", ReturnType = typeof(global::System.Runtime.CompilerServices.ConditionalWeakTable<object, global::System.Runtime.Serialization.SerializationInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.ConditionalWeakTable<, >), Member = "Add", MemberParameters = new object[] { "TKey", "TValue" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		protected Dictionary(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170007AC")]
		public int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003022")]
			[global::Cpp2ILInjected.Address(RVA = "0x192753C", Offset = "0x192753C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170007AD")]
		public Dictionary<TKey, TValue>.KeyCollection Keys
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003023")]
			[global::Cpp2ILInjected.Address(RVA = "0x192754C", Offset = "0x192754C", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170007AE")]
		private ICollection<TKey> prop_ICollection_1_0
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003024")]
			[global::Cpp2ILInjected.Address(RVA = "0x19275B0", Offset = "0x19275B0", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170007AF")]
		public Dictionary<TKey, TValue>.ValueCollection Values
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003025")]
			[global::Cpp2ILInjected.Address(RVA = "0x1927614", Offset = "0x1927614", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170007B0")]
		private ICollection<TValue> prop_ICollection_1_1
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003026")]
			[global::Cpp2ILInjected.Address(RVA = "0x1927678", Offset = "0x1927678", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170007B1")]
		public TValue this[TKey key]
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003027")]
			[global::Cpp2ILInjected.Address(RVA = "0x19276DC", Offset = "0x19276DC", Length = "0x90")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowKeyNotFoundException", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003028")]
			[global::Cpp2ILInjected.Address(RVA = "0x192776C", Offset = "0x192776C", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.InteropServices.Marshal), Member = "GetCustomMarshalerInstance", MemberParameters = new object[]
			{
				typeof(global::System.Type),
				typeof(string)
			}, ReturnType = typeof(global::System.Runtime.InteropServices.ICustomMarshaler))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003029")]
		[global::Cpp2ILInjected.Address(RVA = "0x1927784", Offset = "0x1927784", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Add(TKey key, TValue value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600302A")]
		[global::Cpp2ILInjected.Address(RVA = "0x192779C", Offset = "0x192779C", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void Method_Private_Virtual_Final_New_Void_KeyValuePair_2_0(KeyValuePair<TKey, TValue> keyValuePair)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600302B")]
		[global::Cpp2ILInjected.Address(RVA = "0x19277BC", Offset = "0x19277BC", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private bool Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_0(KeyValuePair<TKey, TValue> keyValuePair)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600302C")]
		[global::Cpp2ILInjected.Address(RVA = "0x192784C", Offset = "0x192784C", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private bool Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_1(KeyValuePair<TKey, TValue> keyValuePair)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600302D")]
		[global::Cpp2ILInjected.Address(RVA = "0x19278F8", Offset = "0x19278F8", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public void Clear()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600302E")]
		[global::Cpp2ILInjected.Address(RVA = "0x192795C", Offset = "0x192795C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool ContainsKey(TKey key)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600302F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1927984", Offset = "0x1927984", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool ContainsValue(TValue value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003030")]
		[global::Cpp2ILInjected.Address(RVA = "0x1927A58", Offset = "0x1927A58", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowIndexArgumentOutOfRange_NeedNonNegNumException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new object[] { typeof(global::System.ExceptionResource) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyValuePair<, >), Member = ".ctor", MemberParameters = new object[] { "TKey", "TValue" }, ReturnType = typeof(void))]
		private void CopyTo(KeyValuePair<TKey, TValue>[] array, int index)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003031")]
		[global::Cpp2ILInjected.Address(RVA = "0x1927B58", Offset = "0x1927B58", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<, >.Enumerator), Member = ".ctor", MemberParameters = new object[]
		{
			"System.Collections.Generic.Dictionary`2<TKey, TValue>",
			typeof(int)
		}, ReturnType = typeof(void))]
		public Dictionary<TKey, TValue>.Enumerator GetEnumerator()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003032")]
		[global::Cpp2ILInjected.Address(RVA = "0x1927B80", Offset = "0x1927B80", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<, >.Enumerator), Member = ".ctor", MemberParameters = new object[]
		{
			"System.Collections.Generic.Dictionary`2<TKey, TValue>",
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private IEnumerator<KeyValuePair<TKey, TValue>> Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_0()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003033")]
		[global::Cpp2ILInjected.Address(RVA = "0x1927BF0", Offset = "0x1927BF0", Length = "0x224")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(global::System.Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public virtual void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003034")]
		[global::Cpp2ILInjected.Address(RVA = "0x1927E14", Offset = "0x1927E14", Length = "0x284")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ValueTuple<object, object>), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowInvalidOperationException_ConcurrentOperationsNotSupported", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private int FindEntry(TKey key)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003035")]
		[global::Cpp2ILInjected.Address(RVA = "0x1928098", Offset = "0x1928098", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashHelpers), Member = "GetPrime", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private int Initialize(int capacity)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003036")]
		[global::Cpp2ILInjected.Address(RVA = "0x1928160", Offset = "0x1928160", Length = "0x404")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsInvalidInstructions]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ValueTuple<object, object>), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowInvalidOperationException_ConcurrentOperationsNotSupported", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowAddingDuplicateWithKeyArgumentException", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private bool TryInsert(TKey key, TValue value, InsertionBehavior behavior)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003037")]
		[global::Cpp2ILInjected.Address(RVA = "0x1928564", Offset = "0x1928564", Length = "0x334")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashHelpers), Member = "get_SerializationInfoTable", ReturnType = typeof(global::System.Runtime.CompilerServices.ConditionalWeakTable<object, global::System.Runtime.Serialization.SerializationInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.ConditionalWeakTable<, >), Member = "TryGetValue", MemberParameters = new object[] { "TKey", "TValue&" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "GetInt32", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "GetValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.ConditionalWeakTable<, >), Member = "Remove", MemberParameters = new object[] { "TKey" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowSerializationException", MemberParameters = new object[] { typeof(global::System.ExceptionResource) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		public virtual void OnDeserialization(object sender)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003038")]
		[global::Cpp2ILInjected.Address(RVA = "0x1928898", Offset = "0x1928898", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashHelpers), Member = "ExpandPrime", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void Resize()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003039")]
		[global::Cpp2ILInjected.Address(RVA = "0x1928920", Offset = "0x1928920", Length = "0x188")]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ValueTuple<object, object>), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void Resize(int newSize, bool forceNewHashCodes)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600303A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1928AA8", Offset = "0x1928AA8", Length = "0x2BC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ValueTuple<object, object>), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public bool Remove(TKey key)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600303B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1928D64", Offset = "0x1928D64", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.InteropServices.Marshal), Member = "GetCustomMarshalerInstance", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string)
		}, ReturnType = typeof(global::System.Runtime.InteropServices.ICustomMarshaler))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public bool TryGetValue(TKey key, out TValue value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600303C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1928DBC", Offset = "0x1928DBC", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public bool TryAdd(TKey key, TValue value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170007B2")]
		private bool prop_Boolean_0
		{
			[global::Cpp2ILInjected.Token(Token = "0x600303D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1928DD4", Offset = "0x1928DD4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x600303E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1928DDC", Offset = "0x1928DDC", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void Method_Private_Virtual_Final_New_Void_KeyValuePair_2_Int32_0(KeyValuePair<TKey, TValue>[] array, int index)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600303F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1928DF0", Offset = "0x1928DF0", Length = "0x36C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Rank", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new object[] { typeof(global::System.ExceptionResource) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "GetLowerBound", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowIndexArgumentOutOfRange_NeedNonNegNumException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DictionaryEntry), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentException_Argument_InvalidArrayType", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyValuePair<, >), Member = ".ctor", MemberParameters = new object[] { "TKey", "TValue" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		private void System.Collections.ICollection.CopyTo(global::System.Array array, int index)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003040")]
		[global::Cpp2ILInjected.Address(RVA = "0x192915C", Offset = "0x192915C", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<, >.Enumerator), Member = ".ctor", MemberParameters = new object[]
		{
			"System.Collections.Generic.Dictionary`2<TKey, TValue>",
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170007B3")]
		private bool System.Collections.ICollection.IsSynchronized
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003041")]
			[global::Cpp2ILInjected.Address(RVA = "0x19291CC", Offset = "0x19291CC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170007B4")]
		private object System.Collections.ICollection.SyncRoot
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003042")]
			[global::Cpp2ILInjected.Address(RVA = "0x19291D4", Offset = "0x19291D4", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170007B5")]
		private bool System.Collections.IDictionary.IsFixedSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003043")]
			[global::Cpp2ILInjected.Address(RVA = "0x1929244", Offset = "0x1929244", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170007B6")]
		private bool System.Collections.IDictionary.IsReadOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003044")]
			[global::Cpp2ILInjected.Address(RVA = "0x192924C", Offset = "0x192924C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170007B7")]
		private ICollection System.Collections.IDictionary.Keys
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003045")]
			[global::Cpp2ILInjected.Address(RVA = "0x1929254", Offset = "0x1929254", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170007B8")]
		private ICollection System.Collections.IDictionary.Values
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003046")]
			[global::Cpp2ILInjected.Address(RVA = "0x1929268", Offset = "0x1929268", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170007B9")]
		private object System.Collections.IDictionary.Item
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003047")]
			[global::Cpp2ILInjected.Address(RVA = "0x192927C", Offset = "0x192927C", Length = "0xBC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003048")]
			[global::Cpp2ILInjected.Address(RVA = "0x1929338", Offset = "0x1929338", Length = "0x2AC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowWrongValueTypeArgumentException", MemberParameters = new object[]
			{
				typeof(object),
				typeof(global::System.Type)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowWrongKeyTypeArgumentException", MemberParameters = new object[]
			{
				typeof(object),
				typeof(global::System.Type)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 26)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003049")]
		[global::Cpp2ILInjected.Address(RVA = "0x19295E4", Offset = "0x19295E4", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static bool IsCompatibleKey(object key)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600304A")]
		[global::Cpp2ILInjected.Address(RVA = "0x192964C", Offset = "0x192964C", Length = "0x2AC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowWrongValueTypeArgumentException", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowWrongKeyTypeArgumentException", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 26)]
		private void System.Collections.IDictionary.Add(object key, object value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600304B")]
		[global::Cpp2ILInjected.Address(RVA = "0x19298F8", Offset = "0x19298F8", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private bool System.Collections.IDictionary.Contains(object key)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600304C")]
		[global::Cpp2ILInjected.Address(RVA = "0x19299B4", Offset = "0x19299B4", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<, >.Enumerator), Member = ".ctor", MemberParameters = new object[]
		{
			"System.Collections.Generic.Dictionary`2<TKey, TValue>",
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600304D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1929A24", Offset = "0x1929A24", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void System.Collections.IDictionary.Remove(object key)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4001A4C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int[] _buckets;

		[global::Cpp2ILInjected.Token(Token = "0x4001A4D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private Dictionary<TKey, TValue>.Entry[] _entries;

		[global::Cpp2ILInjected.Token(Token = "0x4001A4E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int _count;

		[global::Cpp2ILInjected.Token(Token = "0x4001A4F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int _freeList;

		[global::Cpp2ILInjected.Token(Token = "0x4001A50")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int _freeCount;

		[global::Cpp2ILInjected.Token(Token = "0x4001A51")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int _version;

		[global::Cpp2ILInjected.Token(Token = "0x4001A52")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private IEqualityComparer<TKey> _comparer;

		[global::Cpp2ILInjected.Token(Token = "0x4001A53")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private Dictionary<TKey, TValue>.KeyCollection _keys;

		[global::Cpp2ILInjected.Token(Token = "0x4001A54")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private Dictionary<TKey, TValue>.ValueCollection _values;

		[global::Cpp2ILInjected.Token(Token = "0x4001A55")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private object _syncRoot;

		[global::Cpp2ILInjected.Token(Token = "0x4001A56")]
		private const string VersionName = "Version";

		[global::Cpp2ILInjected.Token(Token = "0x4001A57")]
		private const string HashSizeName = "HashSize";

		[global::Cpp2ILInjected.Token(Token = "0x4001A58")]
		private const string KeyValuePairsName = "KeyValuePairs";

		[global::Cpp2ILInjected.Token(Token = "0x4001A59")]
		private const string ComparerName = "Comparer";

		[global::Cpp2ILInjected.Token(Token = "0x2000623")]
		private struct Entry
		{
			[global::Cpp2ILInjected.Token(Token = "0x4001A5A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int hashCode;

			[global::Cpp2ILInjected.Token(Token = "0x4001A5B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int next;

			[global::Cpp2ILInjected.Token(Token = "0x4001A5C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public TKey key;

			[global::Cpp2ILInjected.Token(Token = "0x4001A5D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public TValue value;
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000624")]
		[global::System.Serializable]
		public struct Enumerator : IEnumerator<KeyValuePair<TKey, TValue>>, global::System.IDisposable, IEnumerator, IDictionaryEnumerator
		{
			[global::Cpp2ILInjected.Token(Token = "0x600304E")]
			[global::Cpp2ILInjected.Address(RVA = "0x164EA80", Offset = "0x164EA80", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dictionary<, >), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dictionary<, >), Member = "System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<KeyValuePair`2<TKey, TValue>>")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dictionary<, >), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dictionary<, >), Member = "System.Collections.IDictionary.GetEnumerator", ReturnType = typeof(IDictionaryEnumerator))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			internal Enumerator(Dictionary<TKey, TValue> dictionary, int getEnumeratorRetType)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600304F")]
			[global::Cpp2ILInjected.Address(RVA = "0x164EA9C", Offset = "0x164EA9C", Length = "0xE0")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyValuePair<, >), Member = ".ctor", MemberParameters = new object[] { "TKey", "TValue" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public bool MoveNext()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x170007BA")]
			public KeyValuePair<TKey, TValue> Current
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003050")]
				[global::Cpp2ILInjected.Address(RVA = "0x164EB7C", Offset = "0x164EB7C", Length = "0x14")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x6003051")]
			[global::Cpp2ILInjected.Address(RVA = "0x164EB90", Offset = "0x164EB90", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void Dispose()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x170007BB")]
			private object System.Collections.IEnumerator.Current
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003052")]
				[global::Cpp2ILInjected.Address(RVA = "0x164EB94", Offset = "0x164EB94", Length = "0x190")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DictionaryEntry), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(object)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyValuePair<, >), Member = ".ctor", MemberParameters = new object[] { "TKey", "TValue" }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x6003053")]
			[global::Cpp2ILInjected.Address(RVA = "0x164ED24", Offset = "0x164ED24", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion", ReturnType = typeof(void))]
			private void System.Collections.IEnumerator.Reset()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x170007BC")]
			private DictionaryEntry System.Collections.IDictionaryEnumerator.Entry
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003054")]
				[global::Cpp2ILInjected.Address(RVA = "0x164ED60", Offset = "0x164ED60", Length = "0xC0")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DictionaryEntry), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(object)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x170007BD")]
			private object System.Collections.IDictionaryEnumerator.Key
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003055")]
				[global::Cpp2ILInjected.Address(RVA = "0x164EE20", Offset = "0x164EE20", Length = "0x8C")]
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

			[global::Cpp2ILInjected.Token(Token = "0x170007BE")]
			private object System.Collections.IDictionaryEnumerator.Value
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003056")]
				[global::Cpp2ILInjected.Address(RVA = "0x164EEAC", Offset = "0x164EEAC", Length = "0x54")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x4001A5E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private Dictionary<TKey, TValue> _dictionary;

			[global::Cpp2ILInjected.Token(Token = "0x4001A5F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int _version;

			[global::Cpp2ILInjected.Token(Token = "0x4001A60")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int _index;

			[global::Cpp2ILInjected.Token(Token = "0x4001A61")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private KeyValuePair<TKey, TValue> _current;

			[global::Cpp2ILInjected.Token(Token = "0x4001A62")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int _getEnumeratorRetType;
		}

		[global::System.Diagnostics.DebuggerDisplay("Count = {Count}")]
		[global::System.Diagnostics.DebuggerTypeProxy(typeof(DictionaryKeyCollectionDebugView<, >))]
		[global::Cpp2ILInjected.Token(Token = "0x2000625")]
		[global::System.Serializable]
		public sealed class KeyCollection : ICollection<TKey>, IEnumerable<TKey>, IEnumerable, ICollection, IReadOnlyCollection<TKey>
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003057")]
			[global::Cpp2ILInjected.Address(RVA = "0x1713510", Offset = "0x1713510", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
			public KeyCollection(Dictionary<TKey, TValue> dictionary)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6003058")]
			[global::Cpp2ILInjected.Address(RVA = "0x1713548", Offset = "0x1713548", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<, >.KeyCollection.Enumerator), Member = ".ctor", MemberParameters = new object[] { "System.Collections.Generic.Dictionary`2<TKey, TValue>" }, ReturnType = typeof(void))]
			public Dictionary<TKey, TValue>.KeyCollection.Enumerator GetEnumerator()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6003059")]
			[global::Cpp2ILInjected.Address(RVA = "0x171356C", Offset = "0x171356C", Length = "0xC8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowIndexArgumentOutOfRange_NeedNonNegNumException", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new object[] { typeof(global::System.ExceptionResource) }, ReturnType = typeof(void))]
			public void CopyTo(TKey[] array, int index)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x170007BF")]
			public int Count
			{
				[global::Cpp2ILInjected.Token(Token = "0x600305A")]
				[global::Cpp2ILInjected.Address(RVA = "0x1713634", Offset = "0x1713634", Length = "0x18")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x170007C0")]
			private bool System.Collections.Generic.ICollection<TKey>.IsReadOnly
			{
				[global::Cpp2ILInjected.Token(Token = "0x600305B")]
				[global::Cpp2ILInjected.Address(RVA = "0x171364C", Offset = "0x171364C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x600305C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1713654", Offset = "0x1713654", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowNotSupportedException", MemberParameters = new object[] { typeof(global::System.ExceptionResource) }, ReturnType = typeof(void))]
			private void System.Collections.Generic.ICollection<TKey>.Add(TKey item)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600305D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1713660", Offset = "0x1713660", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowNotSupportedException", MemberParameters = new object[] { typeof(global::System.ExceptionResource) }, ReturnType = typeof(void))]
			private void System.Collections.Generic.ICollection<TKey>.Clear()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600305E")]
			[global::Cpp2ILInjected.Address(RVA = "0x171366C", Offset = "0x171366C", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private bool System.Collections.Generic.ICollection<TKey>.Contains(TKey item)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600305F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1713684", Offset = "0x1713684", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowNotSupportedException", MemberParameters = new object[] { typeof(global::System.ExceptionResource) }, ReturnType = typeof(void))]
			private bool System.Collections.Generic.ICollection<TKey>.Remove(TKey item)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6003060")]
			[global::Cpp2ILInjected.Address(RVA = "0x17136A0", Offset = "0x17136A0", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<, >.KeyCollection.Enumerator), Member = ".ctor", MemberParameters = new object[] { "System.Collections.Generic.Dictionary`2<TKey, TValue>" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			private IEnumerator<TKey> System.Collections.Generic.IEnumerable<TKey>.GetEnumerator()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6003061")]
			[global::Cpp2ILInjected.Address(RVA = "0x1713700", Offset = "0x1713700", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<, >.KeyCollection.Enumerator), Member = ".ctor", MemberParameters = new object[] { "System.Collections.Generic.Dictionary`2<TKey, TValue>" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6003062")]
			[global::Cpp2ILInjected.Address(RVA = "0x1713760", Offset = "0x1713760", Length = "0x290")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Rank", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new object[] { typeof(global::System.ExceptionResource) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "GetLowerBound", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Length", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowIndexArgumentOutOfRange_NeedNonNegNumException", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentException_Argument_InvalidArrayType", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
			private void System.Collections.ICollection.CopyTo(global::System.Array array, int index)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x170007C1")]
			private bool System.Collections.ICollection.IsSynchronized
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003063")]
				[global::Cpp2ILInjected.Address(RVA = "0x17139F0", Offset = "0x17139F0", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x170007C2")]
			private object System.Collections.ICollection.SyncRoot
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003064")]
				[global::Cpp2ILInjected.Address(RVA = "0x17139F8", Offset = "0x17139F8", Length = "0x9C")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x4001A63")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private Dictionary<TKey, TValue> _dictionary;

			[global::Cpp2ILInjected.Token(Token = "0x2000626")]
			[global::System.Serializable]
			public struct Enumerator : IEnumerator<TKey>, global::System.IDisposable, IEnumerator
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003065")]
				[global::Cpp2ILInjected.Address(RVA = "0x164EF00", Offset = "0x164EF00", Length = "0x14")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dictionary<, >.KeyCollection), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dictionary<, >.KeyCollection), Member = "System.Collections.Generic.IEnumerable<TKey>.GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<TKey>")]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dictionary<, >.KeyCollection), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
				internal Enumerator(Dictionary<TKey, TValue> dictionary)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x6003066")]
				[global::Cpp2ILInjected.Address(RVA = "0x164EF14", Offset = "0x164EF14", Length = "0x4")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void Dispose()
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x6003067")]
				[global::Cpp2ILInjected.Address(RVA = "0x164EF18", Offset = "0x164EF18", Length = "0x7C")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion", ReturnType = typeof(void))]
				public bool MoveNext()
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x170007C3")]
				public TKey Current
				{
					[global::Cpp2ILInjected.Token(Token = "0x6003068")]
					[global::Cpp2ILInjected.Address(RVA = "0x164EF94", Offset = "0x164EF94", Length = "0xC")]
					[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
					[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
					get
					{
						throw null;
					}
				}

				[global::Cpp2ILInjected.Token(Token = "0x170007C4")]
				private object System.Collections.IEnumerator.Current
				{
					[global::Cpp2ILInjected.Token(Token = "0x6003069")]
					[global::Cpp2ILInjected.Address(RVA = "0x164EFA0", Offset = "0x164EFA0", Length = "0x7C")]
					[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
					[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
					[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
					[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen", ReturnType = typeof(void))]
					[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
					get
					{
						throw null;
					}
				}

				[global::Cpp2ILInjected.Token(Token = "0x600306A")]
				[global::Cpp2ILInjected.Address(RVA = "0x164F01C", Offset = "0x164F01C", Length = "0x34")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion", ReturnType = typeof(void))]
				private void System.Collections.IEnumerator.Reset()
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x4001A64")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
				private Dictionary<TKey, TValue> _dictionary;

				[global::Cpp2ILInjected.Token(Token = "0x4001A65")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
				private int _index;

				[global::Cpp2ILInjected.Token(Token = "0x4001A66")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
				private int _version;

				[global::Cpp2ILInjected.Token(Token = "0x4001A67")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
				private TKey _currentKey;
			}
		}

		[global::System.Diagnostics.DebuggerDisplay("Count = {Count}")]
		[global::System.Diagnostics.DebuggerTypeProxy(typeof(DictionaryValueCollectionDebugView<, >))]
		[global::Cpp2ILInjected.Token(Token = "0x2000627")]
		[global::System.Serializable]
		public sealed class ValueCollection : ICollection<TValue>, IEnumerable<TValue>, IEnumerable, ICollection, IReadOnlyCollection<TValue>
		{
			[global::Cpp2ILInjected.Token(Token = "0x600306B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1899538", Offset = "0x1899538", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
			public ValueCollection(Dictionary<TKey, TValue> dictionary)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600306C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1899570", Offset = "0x1899570", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<, >.ValueCollection.Enumerator), Member = ".ctor", MemberParameters = new object[] { "System.Collections.Generic.Dictionary`2<TKey, TValue>" }, ReturnType = typeof(void))]
			public Dictionary<TKey, TValue>.ValueCollection.Enumerator GetEnumerator()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600306D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1899594", Offset = "0x1899594", Length = "0xC8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowIndexArgumentOutOfRange_NeedNonNegNumException", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new object[] { typeof(global::System.ExceptionResource) }, ReturnType = typeof(void))]
			public void CopyTo(TValue[] array, int index)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x170007C5")]
			public int Count
			{
				[global::Cpp2ILInjected.Token(Token = "0x600306E")]
				[global::Cpp2ILInjected.Address(RVA = "0x189965C", Offset = "0x189965C", Length = "0x18")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x170007C6")]
			private bool System.Collections.Generic.ICollection<TValue>.IsReadOnly
			{
				[global::Cpp2ILInjected.Token(Token = "0x600306F")]
				[global::Cpp2ILInjected.Address(RVA = "0x1899674", Offset = "0x1899674", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x6003070")]
			[global::Cpp2ILInjected.Address(RVA = "0x189967C", Offset = "0x189967C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowNotSupportedException", MemberParameters = new object[] { typeof(global::System.ExceptionResource) }, ReturnType = typeof(void))]
			private void System.Collections.Generic.ICollection<TValue>.Add(TValue item)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6003071")]
			[global::Cpp2ILInjected.Address(RVA = "0x1899688", Offset = "0x1899688", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowNotSupportedException", MemberParameters = new object[] { typeof(global::System.ExceptionResource) }, ReturnType = typeof(void))]
			private bool System.Collections.Generic.ICollection<TValue>.Remove(TValue item)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6003072")]
			[global::Cpp2ILInjected.Address(RVA = "0x18996A4", Offset = "0x18996A4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowNotSupportedException", MemberParameters = new object[] { typeof(global::System.ExceptionResource) }, ReturnType = typeof(void))]
			private void System.Collections.Generic.ICollection<TValue>.Clear()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6003073")]
			[global::Cpp2ILInjected.Address(RVA = "0x18996B0", Offset = "0x18996B0", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private bool System.Collections.Generic.ICollection<TValue>.Contains(TValue item)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6003074")]
			[global::Cpp2ILInjected.Address(RVA = "0x18996C8", Offset = "0x18996C8", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<, >.ValueCollection.Enumerator), Member = ".ctor", MemberParameters = new object[] { "System.Collections.Generic.Dictionary`2<TKey, TValue>" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			private IEnumerator<TValue> System.Collections.Generic.IEnumerable<TValue>.GetEnumerator()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6003075")]
			[global::Cpp2ILInjected.Address(RVA = "0x1899730", Offset = "0x1899730", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<, >.ValueCollection.Enumerator), Member = ".ctor", MemberParameters = new object[] { "System.Collections.Generic.Dictionary`2<TKey, TValue>" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6003076")]
			[global::Cpp2ILInjected.Address(RVA = "0x1899798", Offset = "0x1899798", Length = "0x258")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Rank", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new object[] { typeof(global::System.ExceptionResource) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "GetLowerBound", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Length", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowIndexArgumentOutOfRange_NeedNonNegNumException", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentException_Argument_InvalidArrayType", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
			private void System.Collections.ICollection.CopyTo(global::System.Array array, int index)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x170007C7")]
			private bool System.Collections.ICollection.IsSynchronized
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003077")]
				[global::Cpp2ILInjected.Address(RVA = "0x18999F0", Offset = "0x18999F0", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x170007C8")]
			private object System.Collections.ICollection.SyncRoot
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003078")]
				[global::Cpp2ILInjected.Address(RVA = "0x18999F8", Offset = "0x18999F8", Length = "0x9C")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x4001A68")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private Dictionary<TKey, TValue> _dictionary;

			[global::Cpp2ILInjected.Token(Token = "0x2000628")]
			[global::System.Serializable]
			public struct Enumerator : IEnumerator<TValue>, global::System.IDisposable, IEnumerator
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003079")]
				[global::Cpp2ILInjected.Address(RVA = "0x164F050", Offset = "0x164F050", Length = "0x14")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dictionary<, >.ValueCollection), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dictionary<, >.ValueCollection), Member = "System.Collections.Generic.IEnumerable<TValue>.GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<TValue>")]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dictionary<, >.ValueCollection), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
				internal Enumerator(Dictionary<TKey, TValue> dictionary)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x600307A")]
				[global::Cpp2ILInjected.Address(RVA = "0x164F064", Offset = "0x164F064", Length = "0x4")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void Dispose()
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x600307B")]
				[global::Cpp2ILInjected.Address(RVA = "0x164F068", Offset = "0x164F068", Length = "0x7C")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion", ReturnType = typeof(void))]
				public bool MoveNext()
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x170007C9")]
				public TValue Current
				{
					[global::Cpp2ILInjected.Token(Token = "0x600307C")]
					[global::Cpp2ILInjected.Address(RVA = "0x164F0E4", Offset = "0x164F0E4", Length = "0x8")]
					[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
					[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
					get
					{
						throw null;
					}
				}

				[global::Cpp2ILInjected.Token(Token = "0x170007CA")]
				private object System.Collections.IEnumerator.Current
				{
					[global::Cpp2ILInjected.Token(Token = "0x600307D")]
					[global::Cpp2ILInjected.Address(RVA = "0x164F0EC", Offset = "0x164F0EC", Length = "0x38")]
					[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
					[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
					[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
					[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen", ReturnType = typeof(void))]
					get
					{
						throw null;
					}
				}

				[global::Cpp2ILInjected.Token(Token = "0x600307E")]
				[global::Cpp2ILInjected.Address(RVA = "0x164F124", Offset = "0x164F124", Length = "0x34")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion", ReturnType = typeof(void))]
				private void System.Collections.IEnumerator.Reset()
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x4001A69")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
				private Dictionary<TKey, TValue> _dictionary;

				[global::Cpp2ILInjected.Token(Token = "0x4001A6A")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
				private int _index;

				[global::Cpp2ILInjected.Token(Token = "0x4001A6B")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
				private int _version;

				[global::Cpp2ILInjected.Token(Token = "0x4001A6C")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
				private TValue _currentValue;
			}
		}
	}
}
