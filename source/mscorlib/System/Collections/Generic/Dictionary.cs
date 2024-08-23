using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Collections.Generic
{
	// Token: 0x02000510 RID: 1296
	[global::System.Diagnostics.DebuggerDisplay("Count = {Count}")]
	[global::System.Diagnostics.DebuggerTypeProxy(typeof(IDictionaryDebugView<, >))]
	[global::Cpp2ILInjected.Token(Token = "0x2000622")]
	[global::System.Serializable]
	public class Dictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair<TKey, TValue>>, global::System.Runtime.Serialization.ISerializable, global::System.Runtime.Serialization.IDeserializationCallback
	{
		// Token: 0x06002BDB RID: 11227 RVA: 0x0001BF47 File Offset: 0x0001A147
		[global::Cpp2ILInjected.Token(Token = "0x600301B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1926F00", Offset = "0x1926F00", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public Dictionary()
		{
			throw null;
		}

		// Token: 0x06002BDC RID: 11228 RVA: 0x0001BF4A File Offset: 0x0001A14A
		[global::Cpp2ILInjected.Token(Token = "0x600301C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1926F1C", Offset = "0x1926F1C", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public Dictionary(int capacity)
		{
			throw null;
		}

		// Token: 0x06002BDD RID: 11229 RVA: 0x0001BF4D File Offset: 0x0001A14D
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

		// Token: 0x06002BDE RID: 11230 RVA: 0x0001BF50 File Offset: 0x0001A150
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

		// Token: 0x06002BDF RID: 11231 RVA: 0x0001BF53 File Offset: 0x0001A153
		[global::Cpp2ILInjected.Token(Token = "0x600301F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1926FDC", Offset = "0x1926FDC", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public Dictionary(IDictionary<TKey, TValue> dictionary)
		{
			throw null;
		}

		// Token: 0x06002BE0 RID: 11232 RVA: 0x0001BF56 File Offset: 0x0001A156
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

		// Token: 0x06002BE1 RID: 11233 RVA: 0x0001BF59 File Offset: 0x0001A159
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

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x06002BE2 RID: 11234 RVA: 0x0001BF5C File Offset: 0x0001A15C
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

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x06002BE3 RID: 11235 RVA: 0x0001BF5F File Offset: 0x0001A15F
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

		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x06002BE4 RID: 11236 RVA: 0x0001BF62 File Offset: 0x0001A162
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

		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x06002BE5 RID: 11237 RVA: 0x0001BF65 File Offset: 0x0001A165
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

		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x06002BE6 RID: 11238 RVA: 0x0001BF68 File Offset: 0x0001A168
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

		// Token: 0x170006CF RID: 1743
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

		// Token: 0x06002BE9 RID: 11241 RVA: 0x0001BF71 File Offset: 0x0001A171
		[global::Cpp2ILInjected.Token(Token = "0x6003029")]
		[global::Cpp2ILInjected.Address(RVA = "0x1927784", Offset = "0x1927784", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Add(TKey key, TValue value)
		{
			throw null;
		}

		// Token: 0x06002BEA RID: 11242 RVA: 0x0001BF74 File Offset: 0x0001A174
		[global::Cpp2ILInjected.Token(Token = "0x600302A")]
		[global::Cpp2ILInjected.Address(RVA = "0x192779C", Offset = "0x192779C", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void Method_Private_Virtual_Final_New_Void_KeyValuePair_2_0(KeyValuePair<TKey, TValue> keyValuePair)
		{
			throw null;
		}

		// Token: 0x06002BEB RID: 11243 RVA: 0x0001BF77 File Offset: 0x0001A177
		[global::Cpp2ILInjected.Token(Token = "0x600302B")]
		[global::Cpp2ILInjected.Address(RVA = "0x19277BC", Offset = "0x19277BC", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private bool Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_0(KeyValuePair<TKey, TValue> keyValuePair)
		{
			throw null;
		}

		// Token: 0x06002BEC RID: 11244 RVA: 0x0001BF7A File Offset: 0x0001A17A
		[global::Cpp2ILInjected.Token(Token = "0x600302C")]
		[global::Cpp2ILInjected.Address(RVA = "0x192784C", Offset = "0x192784C", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private bool Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_1(KeyValuePair<TKey, TValue> keyValuePair)
		{
			throw null;
		}

		// Token: 0x06002BED RID: 11245 RVA: 0x0001BF7D File Offset: 0x0001A17D
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

		// Token: 0x06002BEE RID: 11246 RVA: 0x0001BF80 File Offset: 0x0001A180
		[global::Cpp2ILInjected.Token(Token = "0x600302E")]
		[global::Cpp2ILInjected.Address(RVA = "0x192795C", Offset = "0x192795C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool ContainsKey(TKey key)
		{
			throw null;
		}

		// Token: 0x06002BEF RID: 11247 RVA: 0x0001BF83 File Offset: 0x0001A183
		[global::Cpp2ILInjected.Token(Token = "0x600302F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1927984", Offset = "0x1927984", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool ContainsValue(TValue value)
		{
			throw null;
		}

		// Token: 0x06002BF0 RID: 11248 RVA: 0x0001BF86 File Offset: 0x0001A186
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

		// Token: 0x06002BF1 RID: 11249 RVA: 0x0001BF89 File Offset: 0x0001A189
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

		// Token: 0x06002BF2 RID: 11250 RVA: 0x0001BF8C File Offset: 0x0001A18C
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

		// Token: 0x06002BF3 RID: 11251 RVA: 0x0001BF8F File Offset: 0x0001A18F
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

		// Token: 0x06002BF4 RID: 11252 RVA: 0x0001BF92 File Offset: 0x0001A192
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

		// Token: 0x06002BF5 RID: 11253 RVA: 0x0001BF95 File Offset: 0x0001A195
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

		// Token: 0x06002BF6 RID: 11254 RVA: 0x0001BF98 File Offset: 0x0001A198
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

		// Token: 0x06002BF7 RID: 11255 RVA: 0x0001BF9B File Offset: 0x0001A19B
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

		// Token: 0x06002BF8 RID: 11256 RVA: 0x0001BF9E File Offset: 0x0001A19E
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

		// Token: 0x06002BF9 RID: 11257 RVA: 0x0001BFA1 File Offset: 0x0001A1A1
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

		// Token: 0x06002BFA RID: 11258 RVA: 0x0001BFA4 File Offset: 0x0001A1A4
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

		// Token: 0x06002BFB RID: 11259 RVA: 0x0001BFA7 File Offset: 0x0001A1A7
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

		// Token: 0x06002BFC RID: 11260 RVA: 0x0001BFAA File Offset: 0x0001A1AA
		[global::Cpp2ILInjected.Token(Token = "0x600303C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1928DBC", Offset = "0x1928DBC", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public bool TryAdd(TKey key, TValue value)
		{
			throw null;
		}

		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x06002BFD RID: 11261 RVA: 0x0001BFAD File Offset: 0x0001A1AD
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

		// Token: 0x06002BFE RID: 11262 RVA: 0x0001BFB0 File Offset: 0x0001A1B0
		[global::Cpp2ILInjected.Token(Token = "0x600303E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1928DDC", Offset = "0x1928DDC", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void Method_Private_Virtual_Final_New_Void_KeyValuePair_2_Int32_0(KeyValuePair<TKey, TValue>[] array, int index)
		{
			throw null;
		}

		// Token: 0x06002BFF RID: 11263 RVA: 0x0001BFB3 File Offset: 0x0001A1B3
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

		// Token: 0x06002C00 RID: 11264 RVA: 0x0001BFB6 File Offset: 0x0001A1B6
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

		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x06002C01 RID: 11265 RVA: 0x0001BFB9 File Offset: 0x0001A1B9
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

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x06002C02 RID: 11266 RVA: 0x0001BFBC File Offset: 0x0001A1BC
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

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x06002C03 RID: 11267 RVA: 0x0001BFBF File Offset: 0x0001A1BF
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

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x06002C04 RID: 11268 RVA: 0x0001BFC2 File Offset: 0x0001A1C2
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

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x06002C05 RID: 11269 RVA: 0x0001BFC5 File Offset: 0x0001A1C5
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

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x06002C06 RID: 11270 RVA: 0x0001BFC8 File Offset: 0x0001A1C8
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

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x06002C07 RID: 11271 RVA: 0x0001BFCB File Offset: 0x0001A1CB
		// (set) Token: 0x06002C08 RID: 11272 RVA: 0x0001BFCE File Offset: 0x0001A1CE
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

		// Token: 0x06002C09 RID: 11273 RVA: 0x0001BFD1 File Offset: 0x0001A1D1
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

		// Token: 0x06002C0A RID: 11274 RVA: 0x0001BFD4 File Offset: 0x0001A1D4
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

		// Token: 0x06002C0B RID: 11275 RVA: 0x0001BFD7 File Offset: 0x0001A1D7
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

		// Token: 0x06002C0C RID: 11276 RVA: 0x0001BFDA File Offset: 0x0001A1DA
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

		// Token: 0x06002C0D RID: 11277 RVA: 0x0001BFDD File Offset: 0x0001A1DD
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

		// Token: 0x04001603 RID: 5635
		[global::Cpp2ILInjected.Token(Token = "0x4001A4C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int[] _buckets;

		// Token: 0x04001604 RID: 5636
		[global::Cpp2ILInjected.Token(Token = "0x4001A4D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private Dictionary<TKey, TValue>.Entry[] _entries;

		// Token: 0x04001605 RID: 5637
		[global::Cpp2ILInjected.Token(Token = "0x4001A4E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int _count;

		// Token: 0x04001606 RID: 5638
		[global::Cpp2ILInjected.Token(Token = "0x4001A4F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int _freeList;

		// Token: 0x04001607 RID: 5639
		[global::Cpp2ILInjected.Token(Token = "0x4001A50")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int _freeCount;

		// Token: 0x04001608 RID: 5640
		[global::Cpp2ILInjected.Token(Token = "0x4001A51")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int _version;

		// Token: 0x04001609 RID: 5641
		[global::Cpp2ILInjected.Token(Token = "0x4001A52")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private IEqualityComparer<TKey> _comparer;

		// Token: 0x0400160A RID: 5642
		[global::Cpp2ILInjected.Token(Token = "0x4001A53")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private Dictionary<TKey, TValue>.KeyCollection _keys;

		// Token: 0x0400160B RID: 5643
		[global::Cpp2ILInjected.Token(Token = "0x4001A54")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private Dictionary<TKey, TValue>.ValueCollection _values;

		// Token: 0x0400160C RID: 5644
		[global::Cpp2ILInjected.Token(Token = "0x4001A55")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private object _syncRoot;

		// Token: 0x0400160D RID: 5645
		[global::Cpp2ILInjected.Token(Token = "0x4001A56")]
		private const string VersionName = "Version";

		// Token: 0x0400160E RID: 5646
		[global::Cpp2ILInjected.Token(Token = "0x4001A57")]
		private const string HashSizeName = "HashSize";

		// Token: 0x0400160F RID: 5647
		[global::Cpp2ILInjected.Token(Token = "0x4001A58")]
		private const string KeyValuePairsName = "KeyValuePairs";

		// Token: 0x04001610 RID: 5648
		[global::Cpp2ILInjected.Token(Token = "0x4001A59")]
		private const string ComparerName = "Comparer";

		// Token: 0x0200065A RID: 1626
		[global::Cpp2ILInjected.Token(Token = "0x2000623")]
		private struct Entry
		{
			// Token: 0x04001AC8 RID: 6856
			[global::Cpp2ILInjected.Token(Token = "0x4001A5A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int hashCode;

			// Token: 0x04001AC9 RID: 6857
			[global::Cpp2ILInjected.Token(Token = "0x4001A5B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int next;

			// Token: 0x04001ACA RID: 6858
			[global::Cpp2ILInjected.Token(Token = "0x4001A5C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public TKey key;

			// Token: 0x04001ACB RID: 6859
			[global::Cpp2ILInjected.Token(Token = "0x4001A5D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public TValue value;
		}

		// Token: 0x0200065B RID: 1627
		[global::Cpp2ILInjected.Token(Token = "0x2000624")]
		[global::System.Serializable]
		public struct Enumerator : IEnumerator<KeyValuePair<TKey, TValue>>, global::System.IDisposable, IEnumerator, IDictionaryEnumerator
		{
			// Token: 0x06004310 RID: 17168 RVA: 0x00020384 File Offset: 0x0001E584
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

			// Token: 0x06004311 RID: 17169 RVA: 0x00020387 File Offset: 0x0001E587
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

			// Token: 0x170007DC RID: 2012
			// (get) Token: 0x06004312 RID: 17170 RVA: 0x0002038A File Offset: 0x0001E58A
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

			// Token: 0x06004313 RID: 17171 RVA: 0x0002038D File Offset: 0x0001E58D
			[global::Cpp2ILInjected.Token(Token = "0x6003051")]
			[global::Cpp2ILInjected.Address(RVA = "0x164EB90", Offset = "0x164EB90", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void Dispose()
			{
				throw null;
			}

			// Token: 0x170007DD RID: 2013
			// (get) Token: 0x06004314 RID: 17172 RVA: 0x00020390 File Offset: 0x0001E590
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

			// Token: 0x06004315 RID: 17173 RVA: 0x00020393 File Offset: 0x0001E593
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

			// Token: 0x170007DE RID: 2014
			// (get) Token: 0x06004316 RID: 17174 RVA: 0x00020396 File Offset: 0x0001E596
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

			// Token: 0x170007DF RID: 2015
			// (get) Token: 0x06004317 RID: 17175 RVA: 0x00020399 File Offset: 0x0001E599
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

			// Token: 0x170007E0 RID: 2016
			// (get) Token: 0x06004318 RID: 17176 RVA: 0x0002039C File Offset: 0x0001E59C
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

			// Token: 0x04001ACC RID: 6860
			[global::Cpp2ILInjected.Token(Token = "0x4001A5E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private Dictionary<TKey, TValue> _dictionary;

			// Token: 0x04001ACD RID: 6861
			[global::Cpp2ILInjected.Token(Token = "0x4001A5F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int _version;

			// Token: 0x04001ACE RID: 6862
			[global::Cpp2ILInjected.Token(Token = "0x4001A60")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int _index;

			// Token: 0x04001ACF RID: 6863
			[global::Cpp2ILInjected.Token(Token = "0x4001A61")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private KeyValuePair<TKey, TValue> _current;

			// Token: 0x04001AD0 RID: 6864
			[global::Cpp2ILInjected.Token(Token = "0x4001A62")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int _getEnumeratorRetType;
		}

		// Token: 0x0200065C RID: 1628
		[global::System.Diagnostics.DebuggerDisplay("Count = {Count}")]
		[global::System.Diagnostics.DebuggerTypeProxy(typeof(DictionaryKeyCollectionDebugView<, >))]
		[global::Cpp2ILInjected.Token(Token = "0x2000625")]
		[global::System.Serializable]
		public sealed class KeyCollection : ICollection<TKey>, IEnumerable<TKey>, IEnumerable, ICollection, IReadOnlyCollection<TKey>
		{
			// Token: 0x06004319 RID: 17177 RVA: 0x0002039F File Offset: 0x0001E59F
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

			// Token: 0x0600431A RID: 17178 RVA: 0x000203A2 File Offset: 0x0001E5A2
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

			// Token: 0x0600431B RID: 17179 RVA: 0x000203A5 File Offset: 0x0001E5A5
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

			// Token: 0x170007E1 RID: 2017
			// (get) Token: 0x0600431C RID: 17180 RVA: 0x000203A8 File Offset: 0x0001E5A8
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

			// Token: 0x170007E2 RID: 2018
			// (get) Token: 0x0600431D RID: 17181 RVA: 0x000203AB File Offset: 0x0001E5AB
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

			// Token: 0x0600431E RID: 17182 RVA: 0x000203AE File Offset: 0x0001E5AE
			[global::Cpp2ILInjected.Token(Token = "0x600305C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1713654", Offset = "0x1713654", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowNotSupportedException", MemberParameters = new object[] { typeof(global::System.ExceptionResource) }, ReturnType = typeof(void))]
			private void System.Collections.Generic.ICollection<TKey>.Add(TKey item)
			{
				throw null;
			}

			// Token: 0x0600431F RID: 17183 RVA: 0x000203B1 File Offset: 0x0001E5B1
			[global::Cpp2ILInjected.Token(Token = "0x600305D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1713660", Offset = "0x1713660", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowNotSupportedException", MemberParameters = new object[] { typeof(global::System.ExceptionResource) }, ReturnType = typeof(void))]
			private void System.Collections.Generic.ICollection<TKey>.Clear()
			{
				throw null;
			}

			// Token: 0x06004320 RID: 17184 RVA: 0x000203B4 File Offset: 0x0001E5B4
			[global::Cpp2ILInjected.Token(Token = "0x600305E")]
			[global::Cpp2ILInjected.Address(RVA = "0x171366C", Offset = "0x171366C", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private bool System.Collections.Generic.ICollection<TKey>.Contains(TKey item)
			{
				throw null;
			}

			// Token: 0x06004321 RID: 17185 RVA: 0x000203B7 File Offset: 0x0001E5B7
			[global::Cpp2ILInjected.Token(Token = "0x600305F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1713684", Offset = "0x1713684", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowNotSupportedException", MemberParameters = new object[] { typeof(global::System.ExceptionResource) }, ReturnType = typeof(void))]
			private bool System.Collections.Generic.ICollection<TKey>.Remove(TKey item)
			{
				throw null;
			}

			// Token: 0x06004322 RID: 17186 RVA: 0x000203BA File Offset: 0x0001E5BA
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

			// Token: 0x06004323 RID: 17187 RVA: 0x000203BD File Offset: 0x0001E5BD
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

			// Token: 0x06004324 RID: 17188 RVA: 0x000203C0 File Offset: 0x0001E5C0
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

			// Token: 0x170007E3 RID: 2019
			// (get) Token: 0x06004325 RID: 17189 RVA: 0x000203C3 File Offset: 0x0001E5C3
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

			// Token: 0x170007E4 RID: 2020
			// (get) Token: 0x06004326 RID: 17190 RVA: 0x000203C6 File Offset: 0x0001E5C6
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

			// Token: 0x04001AD1 RID: 6865
			[global::Cpp2ILInjected.Token(Token = "0x4001A63")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private Dictionary<TKey, TValue> _dictionary;

			// Token: 0x020006B4 RID: 1716
			[global::Cpp2ILInjected.Token(Token = "0x2000626")]
			[global::System.Serializable]
			public struct Enumerator : IEnumerator<TKey>, global::System.IDisposable, IEnumerator
			{
				// Token: 0x0600437D RID: 17277 RVA: 0x000204C5 File Offset: 0x0001E6C5
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

				// Token: 0x0600437E RID: 17278 RVA: 0x000204C8 File Offset: 0x0001E6C8
				[global::Cpp2ILInjected.Token(Token = "0x6003066")]
				[global::Cpp2ILInjected.Address(RVA = "0x164EF14", Offset = "0x164EF14", Length = "0x4")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void Dispose()
				{
					throw null;
				}

				// Token: 0x0600437F RID: 17279 RVA: 0x000204CB File Offset: 0x0001E6CB
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

				// Token: 0x170007F9 RID: 2041
				// (get) Token: 0x06004380 RID: 17280 RVA: 0x000204CE File Offset: 0x0001E6CE
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

				// Token: 0x170007FA RID: 2042
				// (get) Token: 0x06004381 RID: 17281 RVA: 0x000204D1 File Offset: 0x0001E6D1
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

				// Token: 0x06004382 RID: 17282 RVA: 0x000204D4 File Offset: 0x0001E6D4
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

				// Token: 0x04001B48 RID: 6984
				[global::Cpp2ILInjected.Token(Token = "0x4001A64")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
				private Dictionary<TKey, TValue> _dictionary;

				// Token: 0x04001B49 RID: 6985
				[global::Cpp2ILInjected.Token(Token = "0x4001A65")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
				private int _index;

				// Token: 0x04001B4A RID: 6986
				[global::Cpp2ILInjected.Token(Token = "0x4001A66")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
				private int _version;

				// Token: 0x04001B4B RID: 6987
				[global::Cpp2ILInjected.Token(Token = "0x4001A67")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
				private TKey _currentKey;
			}
		}

		// Token: 0x0200065D RID: 1629
		[global::System.Diagnostics.DebuggerDisplay("Count = {Count}")]
		[global::System.Diagnostics.DebuggerTypeProxy(typeof(DictionaryValueCollectionDebugView<, >))]
		[global::Cpp2ILInjected.Token(Token = "0x2000627")]
		[global::System.Serializable]
		public sealed class ValueCollection : ICollection<TValue>, IEnumerable<TValue>, IEnumerable, ICollection, IReadOnlyCollection<TValue>
		{
			// Token: 0x06004327 RID: 17191 RVA: 0x000203C9 File Offset: 0x0001E5C9
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

			// Token: 0x06004328 RID: 17192 RVA: 0x000203CC File Offset: 0x0001E5CC
			[global::Cpp2ILInjected.Token(Token = "0x600306C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1899570", Offset = "0x1899570", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<, >.ValueCollection.Enumerator), Member = ".ctor", MemberParameters = new object[] { "System.Collections.Generic.Dictionary`2<TKey, TValue>" }, ReturnType = typeof(void))]
			public Dictionary<TKey, TValue>.ValueCollection.Enumerator GetEnumerator()
			{
				throw null;
			}

			// Token: 0x06004329 RID: 17193 RVA: 0x000203CF File Offset: 0x0001E5CF
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

			// Token: 0x170007E5 RID: 2021
			// (get) Token: 0x0600432A RID: 17194 RVA: 0x000203D2 File Offset: 0x0001E5D2
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

			// Token: 0x170007E6 RID: 2022
			// (get) Token: 0x0600432B RID: 17195 RVA: 0x000203D5 File Offset: 0x0001E5D5
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

			// Token: 0x0600432C RID: 17196 RVA: 0x000203D8 File Offset: 0x0001E5D8
			[global::Cpp2ILInjected.Token(Token = "0x6003070")]
			[global::Cpp2ILInjected.Address(RVA = "0x189967C", Offset = "0x189967C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowNotSupportedException", MemberParameters = new object[] { typeof(global::System.ExceptionResource) }, ReturnType = typeof(void))]
			private void System.Collections.Generic.ICollection<TValue>.Add(TValue item)
			{
				throw null;
			}

			// Token: 0x0600432D RID: 17197 RVA: 0x000203DB File Offset: 0x0001E5DB
			[global::Cpp2ILInjected.Token(Token = "0x6003071")]
			[global::Cpp2ILInjected.Address(RVA = "0x1899688", Offset = "0x1899688", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowNotSupportedException", MemberParameters = new object[] { typeof(global::System.ExceptionResource) }, ReturnType = typeof(void))]
			private bool System.Collections.Generic.ICollection<TValue>.Remove(TValue item)
			{
				throw null;
			}

			// Token: 0x0600432E RID: 17198 RVA: 0x000203DE File Offset: 0x0001E5DE
			[global::Cpp2ILInjected.Token(Token = "0x6003072")]
			[global::Cpp2ILInjected.Address(RVA = "0x18996A4", Offset = "0x18996A4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowNotSupportedException", MemberParameters = new object[] { typeof(global::System.ExceptionResource) }, ReturnType = typeof(void))]
			private void System.Collections.Generic.ICollection<TValue>.Clear()
			{
				throw null;
			}

			// Token: 0x0600432F RID: 17199 RVA: 0x000203E1 File Offset: 0x0001E5E1
			[global::Cpp2ILInjected.Token(Token = "0x6003073")]
			[global::Cpp2ILInjected.Address(RVA = "0x18996B0", Offset = "0x18996B0", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private bool System.Collections.Generic.ICollection<TValue>.Contains(TValue item)
			{
				throw null;
			}

			// Token: 0x06004330 RID: 17200 RVA: 0x000203E4 File Offset: 0x0001E5E4
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

			// Token: 0x06004331 RID: 17201 RVA: 0x000203E7 File Offset: 0x0001E5E7
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

			// Token: 0x06004332 RID: 17202 RVA: 0x000203EA File Offset: 0x0001E5EA
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

			// Token: 0x170007E7 RID: 2023
			// (get) Token: 0x06004333 RID: 17203 RVA: 0x000203ED File Offset: 0x0001E5ED
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

			// Token: 0x170007E8 RID: 2024
			// (get) Token: 0x06004334 RID: 17204 RVA: 0x000203F0 File Offset: 0x0001E5F0
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

			// Token: 0x04001AD2 RID: 6866
			[global::Cpp2ILInjected.Token(Token = "0x4001A68")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private Dictionary<TKey, TValue> _dictionary;

			// Token: 0x020006B5 RID: 1717
			[global::Cpp2ILInjected.Token(Token = "0x2000628")]
			[global::System.Serializable]
			public struct Enumerator : IEnumerator<TValue>, global::System.IDisposable, IEnumerator
			{
				// Token: 0x06004383 RID: 17283 RVA: 0x000204D7 File Offset: 0x0001E6D7
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

				// Token: 0x06004384 RID: 17284 RVA: 0x000204DA File Offset: 0x0001E6DA
				[global::Cpp2ILInjected.Token(Token = "0x600307A")]
				[global::Cpp2ILInjected.Address(RVA = "0x164F064", Offset = "0x164F064", Length = "0x4")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void Dispose()
				{
					throw null;
				}

				// Token: 0x06004385 RID: 17285 RVA: 0x000204DD File Offset: 0x0001E6DD
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

				// Token: 0x170007FB RID: 2043
				// (get) Token: 0x06004386 RID: 17286 RVA: 0x000204E0 File Offset: 0x0001E6E0
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

				// Token: 0x170007FC RID: 2044
				// (get) Token: 0x06004387 RID: 17287 RVA: 0x000204E3 File Offset: 0x0001E6E3
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

				// Token: 0x06004388 RID: 17288 RVA: 0x000204E6 File Offset: 0x0001E6E6
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

				// Token: 0x04001B4C RID: 6988
				[global::Cpp2ILInjected.Token(Token = "0x4001A69")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
				private Dictionary<TKey, TValue> _dictionary;

				// Token: 0x04001B4D RID: 6989
				[global::Cpp2ILInjected.Token(Token = "0x4001A6A")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
				private int _index;

				// Token: 0x04001B4E RID: 6990
				[global::Cpp2ILInjected.Token(Token = "0x4001A6B")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
				private int _version;

				// Token: 0x04001B4F RID: 6991
				[global::Cpp2ILInjected.Token(Token = "0x4001A6C")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
				private TValue _currentValue;
			}
		}
	}
}
