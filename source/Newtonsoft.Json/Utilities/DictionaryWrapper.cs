using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000051 RID: 81
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000062")]
	internal class DictionaryWrapper<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IWrappedDictionary, IDictionary, ICollection
	{
		// Token: 0x06000355 RID: 853 RVA: 0x00002A77 File Offset: 0x00000C77
		[global::Cpp2ILInjected.Token(Token = "0x6000377")]
		[global::Cpp2ILInjected.Address(RVA = "0x1924348", Offset = "0x1924348", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public DictionaryWrapper(IDictionary dictionary)
		{
			throw null;
		}

		// Token: 0x06000356 RID: 854 RVA: 0x00002A7A File Offset: 0x00000C7A
		[global::Cpp2ILInjected.Token(Token = "0x6000378")]
		[global::Cpp2ILInjected.Address(RVA = "0x19243B4", Offset = "0x19243B4", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public DictionaryWrapper(IDictionary<TKey, TValue> dictionary)
		{
			throw null;
		}

		// Token: 0x06000357 RID: 855 RVA: 0x00002A7D File Offset: 0x00000C7D
		[global::Cpp2ILInjected.Token(Token = "0x6000379")]
		[global::Cpp2ILInjected.Address(RVA = "0x1924420", Offset = "0x1924420", Length = "0x148")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public void Add(TKey key, TValue value)
		{
			throw null;
		}

		// Token: 0x06000358 RID: 856 RVA: 0x00002A80 File Offset: 0x00000C80
		[global::Cpp2ILInjected.Token(Token = "0x600037A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1924568", Offset = "0x1924568", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public bool ContainsKey(TKey key)
		{
			throw null;
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000359 RID: 857 RVA: 0x00002A83 File Offset: 0x00000C83
		[global::Cpp2ILInjected.Token(Token = "0x170000A4")]
		public ICollection<TKey> Keys
		{
			[global::Cpp2ILInjected.Token(Token = "0x600037B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1924670", Offset = "0x1924670", Length = "0x148")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600035A RID: 858 RVA: 0x00002A86 File Offset: 0x00000C86
		[global::Cpp2ILInjected.Token(Token = "0x600037C")]
		[global::Cpp2ILInjected.Address(RVA = "0x19247B8", Offset = "0x19247B8", Length = "0x1B8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public bool Remove(TKey key)
		{
			throw null;
		}

		// Token: 0x0600035B RID: 859 RVA: 0x00002A89 File Offset: 0x00000C89
		[global::Cpp2ILInjected.Token(Token = "0x600037D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1924970", Offset = "0x1924970", Length = "0x258")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public bool TryGetValue(TKey key, out TValue value)
		{
			throw null;
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x0600035C RID: 860 RVA: 0x00002A8C File Offset: 0x00000C8C
		[global::Cpp2ILInjected.Token(Token = "0x170000A5")]
		public ICollection<TValue> Values
		{
			[global::Cpp2ILInjected.Token(Token = "0x600037E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1924BC8", Offset = "0x1924BC8", Length = "0x148")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000A4 RID: 164
		[global::Cpp2ILInjected.Token(Token = "0x170000A6")]
		public TValue this[TKey key]
		{
			[global::Cpp2ILInjected.Token(Token = "0x600037F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1924D10", Offset = "0x1924D10", Length = "0x184")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000380")]
			[global::Cpp2ILInjected.Address(RVA = "0x1924E94", Offset = "0x1924E94", Length = "0x110")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600035F RID: 863 RVA: 0x00002A95 File Offset: 0x00000C95
		[global::Cpp2ILInjected.Token(Token = "0x6000381")]
		[global::Cpp2ILInjected.Address(RVA = "0x1924FA4", Offset = "0x1924FA4", Length = "0x1C8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public void Add(KeyValuePair<TKey, TValue> item)
		{
			throw null;
		}

		// Token: 0x06000360 RID: 864 RVA: 0x00002A98 File Offset: 0x00000C98
		[global::Cpp2ILInjected.Token(Token = "0x6000382")]
		[global::Cpp2ILInjected.Address(RVA = "0x192516C", Offset = "0x192516C", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x06000361 RID: 865 RVA: 0x00002A9B File Offset: 0x00000C9B
		[global::Cpp2ILInjected.Token(Token = "0x6000383")]
		[global::Cpp2ILInjected.Address(RVA = "0x1925274", Offset = "0x1925274", Length = "0x1C8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public bool Contains(KeyValuePair<TKey, TValue> item)
		{
			throw null;
		}

		// Token: 0x06000362 RID: 866 RVA: 0x00002A9E File Offset: 0x00000C9E
		[global::Cpp2ILInjected.Token(Token = "0x6000384")]
		[global::Cpp2ILInjected.Address(RVA = "0x192543C", Offset = "0x192543C", Length = "0x48C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyValuePair<object, object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
		{
			throw null;
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000363 RID: 867 RVA: 0x00002AA1 File Offset: 0x00000CA1
		[global::Cpp2ILInjected.Token(Token = "0x170000A7")]
		public int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000385")]
			[global::Cpp2ILInjected.Address(RVA = "0x19258C8", Offset = "0x19258C8", Length = "0x10C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000364 RID: 868 RVA: 0x00002AA4 File Offset: 0x00000CA4
		[global::Cpp2ILInjected.Token(Token = "0x170000A8")]
		public bool IsReadOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000386")]
			[global::Cpp2ILInjected.Address(RVA = "0x19259D4", Offset = "0x19259D4", Length = "0x108")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000365 RID: 869 RVA: 0x00002AA7 File Offset: 0x00000CA7
		[global::Cpp2ILInjected.Token(Token = "0x6000387")]
		[global::Cpp2ILInjected.Address(RVA = "0x1925ADC", Offset = "0x1925ADC", Length = "0x230")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Equals", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public bool Remove(KeyValuePair<TKey, TValue> item)
		{
			throw null;
		}

		// Token: 0x06000366 RID: 870 RVA: 0x00002AAA File Offset: 0x00000CAA
		[global::Cpp2ILInjected.Token(Token = "0x6000388")]
		[global::Cpp2ILInjected.Address(RVA = "0x1925D0C", Offset = "0x1925D0C", Length = "0x25C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable), Member = "Cast", MemberTypeParameters = new object[] { "TResult" }, MemberParameters = new object[] { typeof(IEnumerable) }, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			throw null;
		}

		// Token: 0x06000367 RID: 871 RVA: 0x00002AAD File Offset: 0x00000CAD
		[global::Cpp2ILInjected.Token(Token = "0x6000389")]
		[global::Cpp2ILInjected.Address(RVA = "0x1925F68", Offset = "0x1925F68", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw null;
		}

		// Token: 0x06000368 RID: 872 RVA: 0x00002AB0 File Offset: 0x00000CB0
		[global::Cpp2ILInjected.Token(Token = "0x600038A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1925F7C", Offset = "0x1925F7C", Length = "0x1DC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private void System.Collections.IDictionary.Add(object key, object value)
		{
			throw null;
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000369 RID: 873 RVA: 0x00002AB3 File Offset: 0x00000CB3
		// (set) Token: 0x0600036A RID: 874 RVA: 0x00002AB6 File Offset: 0x00000CB6
		[global::Cpp2ILInjected.Token(Token = "0x170000A9")]
		private object System.Collections.IDictionary.Item
		{
			[global::Cpp2ILInjected.Token(Token = "0x600038B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1926158", Offset = "0x1926158", Length = "0x178")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600038C")]
			[global::Cpp2ILInjected.Address(RVA = "0x19262D0", Offset = "0x19262D0", Length = "0x1DC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600036B RID: 875 RVA: 0x00002AB9 File Offset: 0x00000CB9
		[global::Cpp2ILInjected.Token(Token = "0x600038D")]
		[global::Cpp2ILInjected.Address(RVA = "0x19264AC", Offset = "0x19264AC", Length = "0x16C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DictionaryWrapper<, >.DictionaryEnumerator<, >), Member = ".ctor", MemberParameters = new object[] { "System.Collections.Generic.IEnumerator`1<KeyValuePair`2<TEnumeratorKey, TEnumeratorValue>>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator()
		{
			throw null;
		}

		// Token: 0x0600036C RID: 876 RVA: 0x00002ABC File Offset: 0x00000CBC
		[global::Cpp2ILInjected.Token(Token = "0x600038E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1926618", Offset = "0x1926618", Length = "0x180")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private bool System.Collections.IDictionary.Contains(object key)
		{
			throw null;
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x0600036D RID: 877 RVA: 0x00002ABF File Offset: 0x00000CBF
		[global::Cpp2ILInjected.Token(Token = "0x170000AA")]
		private bool System.Collections.IDictionary.IsFixedSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x600038F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1926798", Offset = "0x1926798", Length = "0xB4")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x0600036E RID: 878 RVA: 0x00002AC2 File Offset: 0x00000CC2
		[global::Cpp2ILInjected.Token(Token = "0x170000AB")]
		private ICollection System.Collections.IDictionary.Keys
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000390")]
			[global::Cpp2ILInjected.Address(RVA = "0x192684C", Offset = "0x192684C", Length = "0x134")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600036F RID: 879 RVA: 0x00002AC5 File Offset: 0x00000CC5
		[global::Cpp2ILInjected.Token(Token = "0x6000391")]
		[global::Cpp2ILInjected.Address(RVA = "0x1926980", Offset = "0x1926980", Length = "0x180")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public void Remove(object key)
		{
			throw null;
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000370 RID: 880 RVA: 0x00002AC8 File Offset: 0x00000CC8
		[global::Cpp2ILInjected.Token(Token = "0x170000AC")]
		private ICollection System.Collections.IDictionary.Values
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000392")]
			[global::Cpp2ILInjected.Address(RVA = "0x1926B00", Offset = "0x1926B00", Length = "0x134")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000371 RID: 881 RVA: 0x00002ACB File Offset: 0x00000CCB
		[global::Cpp2ILInjected.Token(Token = "0x6000393")]
		[global::Cpp2ILInjected.Address(RVA = "0x1926C34", Offset = "0x1926C34", Length = "0x18C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private void System.Collections.ICollection.CopyTo(Array array, int index)
		{
			throw null;
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000372 RID: 882 RVA: 0x00002ACE File Offset: 0x00000CCE
		[global::Cpp2ILInjected.Token(Token = "0x170000AD")]
		private bool System.Collections.ICollection.IsSynchronized
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000394")]
			[global::Cpp2ILInjected.Address(RVA = "0x1926DC0", Offset = "0x1926DC0", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000373 RID: 883 RVA: 0x00002AD1 File Offset: 0x00000CD1
		[global::Cpp2ILInjected.Token(Token = "0x170000AE")]
		private object System.Collections.ICollection.SyncRoot
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000395")]
			[global::Cpp2ILInjected.Address(RVA = "0x1926E70", Offset = "0x1926E70", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new object[]
			{
				typeof(ref object),
				typeof(object),
				typeof(object)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000374 RID: 884 RVA: 0x00002AD4 File Offset: 0x00000CD4
		[global::Cpp2ILInjected.Token(Token = "0x170000AF")]
		public object UnderlyingDictionary
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000396")]
			[global::Cpp2ILInjected.Address(RVA = "0x1926EE4", Offset = "0x1926EE4", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x040001B2 RID: 434
		[global::Cpp2ILInjected.Token(Token = "0x40001E4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly IDictionary _dictionary;

		// Token: 0x040001B3 RID: 435
		[global::Cpp2ILInjected.Token(Token = "0x40001E5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly IDictionary<TKey, TValue> _genericDictionary;

		// Token: 0x040001B4 RID: 436
		[global::Cpp2ILInjected.Token(Token = "0x40001E6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private object _syncRoot;

		// Token: 0x02000103 RID: 259
		[global::Cpp2ILInjected.Token(Token = "0x2000063")]
		private struct DictionaryEnumerator<TEnumeratorKey, TEnumeratorValue> : IDictionaryEnumerator, IEnumerator
		{
			// Token: 0x06000AA8 RID: 2728 RVA: 0x00003F74 File Offset: 0x00002174
			[global::Cpp2ILInjected.Token(Token = "0x6000397")]
			[global::Cpp2ILInjected.Address(RVA = "0x1923EFC", Offset = "0x1923EFC", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DictionaryWrapper<, >), Member = "System.Collections.IDictionary.GetEnumerator", ReturnType = typeof(IDictionaryEnumerator))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
			{
				typeof(object),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public DictionaryEnumerator(IEnumerator<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> e)
			{
				throw null;
			}

			// Token: 0x17000216 RID: 534
			// (get) Token: 0x06000AA9 RID: 2729 RVA: 0x00003F77 File Offset: 0x00002177
			[global::Cpp2ILInjected.Token(Token = "0x170000B0")]
			public DictionaryEntry Entry
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000398")]
				[global::Cpp2ILInjected.Address(RVA = "0x1923F5C", Offset = "0x1923F5C", Length = "0x8C")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DictionaryWrapper<, >.DictionaryEnumerator<, >), Member = "get_Key", ReturnType = typeof(object))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DictionaryWrapper<, >.DictionaryEnumerator<, >), Member = "get_Value", ReturnType = typeof(object))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DictionaryWrapper<, >.DictionaryEnumerator<, >), Member = "get_Current", ReturnType = typeof(object))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000217 RID: 535
			// (get) Token: 0x06000AAA RID: 2730 RVA: 0x00003F7A File Offset: 0x0000217A
			[global::Cpp2ILInjected.Token(Token = "0x170000B1")]
			public object Key
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000399")]
				[global::Cpp2ILInjected.Address(RVA = "0x1923FE8", Offset = "0x1923FE8", Length = "0x34")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DictionaryWrapper<, >.DictionaryEnumerator<, >), Member = "get_Entry", ReturnType = typeof(DictionaryEntry))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000218 RID: 536
			// (get) Token: 0x06000AAB RID: 2731 RVA: 0x00003F7D File Offset: 0x0000217D
			[global::Cpp2ILInjected.Token(Token = "0x170000B2")]
			public object Value
			{
				[global::Cpp2ILInjected.Token(Token = "0x600039A")]
				[global::Cpp2ILInjected.Address(RVA = "0x192401C", Offset = "0x192401C", Length = "0x3C")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DictionaryWrapper<, >.DictionaryEnumerator<, >), Member = "get_Entry", ReturnType = typeof(DictionaryEntry))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000219 RID: 537
			// (get) Token: 0x06000AAC RID: 2732 RVA: 0x00003F80 File Offset: 0x00002180
			[global::Cpp2ILInjected.Token(Token = "0x170000B3")]
			public object Current
			{
				[global::Cpp2ILInjected.Token(Token = "0x600039B")]
				[global::Cpp2ILInjected.Address(RVA = "0x1924058", Offset = "0x1924058", Length = "0x1BC")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DictionaryWrapper<, >.DictionaryEnumerator<, >), Member = "get_Entry", ReturnType = typeof(DictionaryEntry))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DictionaryEntry), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(object)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06000AAD RID: 2733 RVA: 0x00003F83 File Offset: 0x00002183
			[global::Cpp2ILInjected.Token(Token = "0x600039C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1924214", Offset = "0x1924214", Length = "0x98")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public bool MoveNext()
			{
				throw null;
			}

			// Token: 0x06000AAE RID: 2734 RVA: 0x00003F86 File Offset: 0x00002186
			[global::Cpp2ILInjected.Token(Token = "0x600039D")]
			[global::Cpp2ILInjected.Address(RVA = "0x19242AC", Offset = "0x19242AC", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public void Reset()
			{
				throw null;
			}

			// Token: 0x04000396 RID: 918
			[global::Cpp2ILInjected.Token(Token = "0x40001E7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private readonly IEnumerator<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> _e;
		}

		// Token: 0x02000104 RID: 260
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000064")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06000AAF RID: 2735 RVA: 0x00003F89 File Offset: 0x00002189
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x600039E")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B10F4", Offset = "0x15B10F4", Length = "0xEC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			static <>c()
			{
				throw null;
			}

			// Token: 0x06000AB0 RID: 2736 RVA: 0x00003F8C File Offset: 0x0000218C
			[global::Cpp2ILInjected.Token(Token = "0x600039F")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B11E0", Offset = "0x15B11E0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			// Token: 0x06000AB1 RID: 2737 RVA: 0x00003F8F File Offset: 0x0000218F
			[global::Cpp2ILInjected.Token(Token = "0x60003A0")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B11E8", Offset = "0x15B11E8", Length = "0xDC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyValuePair<object, object>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			internal KeyValuePair<TKey, TValue> <GetEnumerator>b__25_0(DictionaryEntry de)
			{
				throw null;
			}

			// Token: 0x04000397 RID: 919
			[global::Cpp2ILInjected.Token(Token = "0x40001E8")]
			public static readonly DictionaryWrapper<TKey, TValue>.<>c <>9;

			// Token: 0x04000398 RID: 920
			[global::Cpp2ILInjected.Token(Token = "0x40001E9")]
			public static Func<DictionaryEntry, KeyValuePair<TKey, TValue>> <>9__25_0;
		}
	}
}
