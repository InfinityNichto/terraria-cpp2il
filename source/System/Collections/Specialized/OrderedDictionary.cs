using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Collections.Specialized
{
	// Token: 0x02000307 RID: 775
	[global::Cpp2ILInjected.Token(Token = "0x200041E")]
	[Serializable]
	public class OrderedDictionary : IDictionary, ICollection, IEnumerable, ISerializable, IDeserializationCallback
	{
		// Token: 0x06001974 RID: 6516 RVA: 0x000075B9 File Offset: 0x000057B9
		[global::Cpp2ILInjected.Token(Token = "0x6001C64")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8F000", Offset = "0x1E8F000", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public OrderedDictionary()
		{
			throw null;
		}

		// Token: 0x06001975 RID: 6517 RVA: 0x000075BC File Offset: 0x000057BC
		[global::Cpp2ILInjected.Token(Token = "0x6001C65")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8F020", Offset = "0x1E8F020", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider.ReflectedTypeData", Member = "GetAttributes", ReturnType = typeof(AttributeCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "PipelineFilter", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ICollection),
			typeof(object),
			typeof(IDictionary)
		}, ReturnType = typeof(ICollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public OrderedDictionary(int capacity)
		{
			throw null;
		}

		// Token: 0x06001976 RID: 6518 RVA: 0x000075BF File Offset: 0x000057BF
		[global::Cpp2ILInjected.Token(Token = "0x6001C66")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8F04C", Offset = "0x1E8F04C", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public OrderedDictionary(int capacity, IEqualityComparer comparer)
		{
			throw null;
		}

		// Token: 0x06001977 RID: 6519 RVA: 0x000075C2 File Offset: 0x000057C2
		[global::Cpp2ILInjected.Token(Token = "0x6001C67")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8F07C", Offset = "0x1E8F07C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected OrderedDictionary(SerializationInfo info, StreamingContext context)
		{
			throw null;
		}

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x06001978 RID: 6520 RVA: 0x000075C5 File Offset: 0x000057C5
		[global::Cpp2ILInjected.Token(Token = "0x17000654")]
		public int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001C68")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E8F0A4", Offset = "0x1E8F0A4", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider.ReflectedTypeData", Member = "GetAttributes", ReturnType = typeof(AttributeCollection))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OrderedDictionary), Member = "get_objectsArray", ReturnType = typeof(ArrayList))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x06001979 RID: 6521 RVA: 0x000075C8 File Offset: 0x000057C8
		[global::Cpp2ILInjected.Token(Token = "0x17000655")]
		private bool System.Collections.IDictionary.IsFixedSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001C69")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E8F12C", Offset = "0x1E8F12C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x0600197A RID: 6522 RVA: 0x000075CB File Offset: 0x000057CB
		[global::Cpp2ILInjected.Token(Token = "0x17000656")]
		public bool IsReadOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001C6A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E8F134", Offset = "0x1E8F134", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x0600197B RID: 6523 RVA: 0x000075CE File Offset: 0x000057CE
		[global::Cpp2ILInjected.Token(Token = "0x17000657")]
		private bool System.Collections.ICollection.IsSynchronized
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001C6B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E8F13C", Offset = "0x1E8F13C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x0600197C RID: 6524 RVA: 0x000075D1 File Offset: 0x000057D1
		[global::Cpp2ILInjected.Token(Token = "0x17000658")]
		public ICollection Keys
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001C6C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E8F144", Offset = "0x1E8F144", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OrderedDictionary), Member = "get_objectsArray", ReturnType = typeof(ArrayList))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x0600197D RID: 6525 RVA: 0x000075D4 File Offset: 0x000057D4
		[global::Cpp2ILInjected.Token(Token = "0x17000659")]
		private ArrayList objectsArray
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001C6D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E8F0C0", Offset = "0x1E8F0C0", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OrderedDictionary), Member = "get_Count", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OrderedDictionary), Member = "get_Keys", ReturnType = typeof(ICollection))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OrderedDictionary), Member = "set_Item", MemberParameters = new object[]
			{
				typeof(object),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OrderedDictionary), Member = "get_Values", ReturnType = typeof(ICollection))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OrderedDictionary), Member = "Add", MemberParameters = new object[]
			{
				typeof(object),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OrderedDictionary), Member = "Clear", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OrderedDictionary), Member = "IndexOfKey", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OrderedDictionary), Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OrderedDictionary), Member = "GetEnumerator", ReturnType = typeof(IDictionaryEnumerator))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OrderedDictionary), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OrderedDictionary), Member = "GetObjectData", MemberParameters = new object[]
			{
				typeof(SerializationInfo),
				typeof(StreamingContext)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OrderedDictionary), Member = "OnDeserialization", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x0600197E RID: 6526 RVA: 0x000075D7 File Offset: 0x000057D7
		[global::Cpp2ILInjected.Token(Token = "0x1700065A")]
		private Hashtable objectsTable
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001C6E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E8F1E8", Offset = "0x1E8F1E8", Length = "0x7C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OrderedDictionary), Member = "get_Item", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OrderedDictionary), Member = "set_Item", MemberParameters = new object[]
			{
				typeof(object),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OrderedDictionary), Member = "Add", MemberParameters = new object[]
			{
				typeof(object),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OrderedDictionary), Member = "Clear", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OrderedDictionary), Member = "Contains", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OrderedDictionary), Member = "CopyTo", MemberParameters = new object[]
			{
				typeof(Array),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OrderedDictionary), Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OrderedDictionary), Member = "OnDeserialization", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(int),
				typeof(IEqualityComparer)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x0600197F RID: 6527 RVA: 0x000075DA File Offset: 0x000057DA
		[global::Cpp2ILInjected.Token(Token = "0x1700065B")]
		private object System.Collections.ICollection.SyncRoot
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001C6F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E8F264", Offset = "0x1E8F264", Length = "0x74")]
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

		// Token: 0x17000612 RID: 1554
		[global::Cpp2ILInjected.Token(Token = "0x1700065C")]
		public object this[object key]
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001C70")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E8F2D8", Offset = "0x1E8F2D8", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "PipelineFilter", MemberParameters = new object[]
			{
				typeof(int),
				typeof(ICollection),
				typeof(object),
				typeof(IDictionary)
			}, ReturnType = typeof(ICollection))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OrderedDictionary), Member = "get_objectsTable", ReturnType = typeof(Hashtable))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001C71")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E8F2FC", Offset = "0x1E8F2FC", Length = "0x16C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider.ReflectedTypeData", Member = "GetAttributes", ReturnType = typeof(AttributeCollection))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "PipelineFilter", MemberParameters = new object[]
			{
				typeof(int),
				typeof(ICollection),
				typeof(object),
				typeof(IDictionary)
			}, ReturnType = typeof(ICollection))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OrderedDictionary), Member = "get_objectsTable", ReturnType = typeof(Hashtable))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OrderedDictionary), Member = "get_objectsArray", ReturnType = typeof(ArrayList))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OrderedDictionary), Member = "IndexOfKey", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DictionaryEntry), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OrderedDictionary), Member = "Add", MemberParameters = new object[]
			{
				typeof(object),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x06001982 RID: 6530 RVA: 0x000075E3 File Offset: 0x000057E3
		[global::Cpp2ILInjected.Token(Token = "0x1700065D")]
		public ICollection Values
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001C72")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E8F700", Offset = "0x1E8F700", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider.ReflectedTypeData", Member = "GetAttributes", ReturnType = typeof(AttributeCollection))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "PipelineFilter", MemberParameters = new object[]
			{
				typeof(int),
				typeof(ICollection),
				typeof(object),
				typeof(IDictionary)
			}, ReturnType = typeof(ICollection))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OrderedDictionary), Member = "get_objectsArray", ReturnType = typeof(ArrayList))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001983 RID: 6531 RVA: 0x000075E6 File Offset: 0x000057E6
		[global::Cpp2ILInjected.Token(Token = "0x6001C73")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8F5E8", Offset = "0x1E8F5E8", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OrderedDictionary), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OrderedDictionary), Member = "get_objectsTable", ReturnType = typeof(Hashtable))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OrderedDictionary), Member = "get_objectsArray", ReturnType = typeof(ArrayList))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DictionaryEntry), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public void Add(object key, object value)
		{
			throw null;
		}

		// Token: 0x06001984 RID: 6532 RVA: 0x000075E9 File Offset: 0x000057E9
		[global::Cpp2ILInjected.Token(Token = "0x6001C74")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8F770", Offset = "0x1E8F770", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OrderedDictionary), Member = "get_objectsTable", ReturnType = typeof(Hashtable))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OrderedDictionary), Member = "get_objectsArray", ReturnType = typeof(ArrayList))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x06001985 RID: 6533 RVA: 0x000075EC File Offset: 0x000057EC
		[global::Cpp2ILInjected.Token(Token = "0x6001C75")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8F7F8", Offset = "0x1E8F7F8", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider.ReflectedTypeData", Member = "GetAttributes", ReturnType = typeof(AttributeCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "PipelineFilter", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ICollection),
			typeof(object),
			typeof(IDictionary)
		}, ReturnType = typeof(ICollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OrderedDictionary), Member = "get_objectsTable", ReturnType = typeof(Hashtable))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public bool Contains(object key)
		{
			throw null;
		}

		// Token: 0x06001986 RID: 6534 RVA: 0x000075EF File Offset: 0x000057EF
		[global::Cpp2ILInjected.Token(Token = "0x6001C76")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8F81C", Offset = "0x1E8F81C", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OrderedDictionary), Member = "get_objectsTable", ReturnType = typeof(Hashtable))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void CopyTo(Array array, int index)
		{
			throw null;
		}

		// Token: 0x06001987 RID: 6535 RVA: 0x000075F2 File Offset: 0x000057F2
		[global::Cpp2ILInjected.Token(Token = "0x6001C77")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8F468", Offset = "0x1E8F468", Length = "0x180")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OrderedDictionary), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OrderedDictionary), Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OrderedDictionary), Member = "get_objectsArray", ReturnType = typeof(ArrayList))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private int IndexOfKey(object key)
		{
			throw null;
		}

		// Token: 0x06001988 RID: 6536 RVA: 0x000075F5 File Offset: 0x000057F5
		[global::Cpp2ILInjected.Token(Token = "0x6001C78")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8F850", Offset = "0x1E8F850", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "PipelineFilter", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ICollection),
			typeof(object),
			typeof(IDictionary)
		}, ReturnType = typeof(ICollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OrderedDictionary), Member = "IndexOfKey", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OrderedDictionary), Member = "get_objectsTable", ReturnType = typeof(Hashtable))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OrderedDictionary), Member = "get_objectsArray", ReturnType = typeof(ArrayList))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public void Remove(object key)
		{
			throw null;
		}

		// Token: 0x06001989 RID: 6537 RVA: 0x000075F8 File Offset: 0x000057F8
		[global::Cpp2ILInjected.Token(Token = "0x6001C79")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8F944", Offset = "0x1E8F944", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OrderedDictionary), Member = "get_objectsArray", ReturnType = typeof(ArrayList))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual IDictionaryEnumerator GetEnumerator()
		{
			throw null;
		}

		// Token: 0x0600198A RID: 6538 RVA: 0x000075FB File Offset: 0x000057FB
		[global::Cpp2ILInjected.Token(Token = "0x6001C7A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8FA10", Offset = "0x1E8FA10", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OrderedDictionary), Member = "get_objectsArray", ReturnType = typeof(ArrayList))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw null;
		}

		// Token: 0x0600198B RID: 6539 RVA: 0x000075FE File Offset: 0x000057FE
		[global::Cpp2ILInjected.Token(Token = "0x6001C7B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8FA98", Offset = "0x1E8FA98", Length = "0x1DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OrderedDictionary), Member = "get_objectsArray", ReturnType = typeof(ArrayList))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			throw null;
		}

		// Token: 0x0600198C RID: 6540 RVA: 0x00007601 File Offset: 0x00005801
		[global::Cpp2ILInjected.Token(Token = "0x6001C7C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8FC74", Offset = "0x1E8FC74", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender)
		{
			throw null;
		}

		// Token: 0x0600198D RID: 6541 RVA: 0x00007604 File Offset: 0x00005804
		[global::Cpp2ILInjected.Token(Token = "0x6001C7D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8FC84", Offset = "0x1E8FC84", Length = "0x380")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "GetValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "GetBoolean", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "GetInt32", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OrderedDictionary), Member = "get_objectsArray", ReturnType = typeof(ArrayList))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OrderedDictionary), Member = "get_objectsTable", ReturnType = typeof(Hashtable))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 35)]
		protected virtual void OnDeserialization(object sender)
		{
			throw null;
		}

		// Token: 0x04000F5C RID: 3932
		[global::Cpp2ILInjected.Token(Token = "0x40013AB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private ArrayList _objectsArray;

		// Token: 0x04000F5D RID: 3933
		[global::Cpp2ILInjected.Token(Token = "0x40013AC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private Hashtable _objectsTable;

		// Token: 0x04000F5E RID: 3934
		[global::Cpp2ILInjected.Token(Token = "0x40013AD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int _initialCapacity;

		// Token: 0x04000F5F RID: 3935
		[global::Cpp2ILInjected.Token(Token = "0x40013AE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private IEqualityComparer _comparer;

		// Token: 0x04000F60 RID: 3936
		[global::Cpp2ILInjected.Token(Token = "0x40013AF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private bool _readOnly;

		// Token: 0x04000F61 RID: 3937
		[global::Cpp2ILInjected.Token(Token = "0x40013B0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private object _syncRoot;

		// Token: 0x04000F62 RID: 3938
		[global::Cpp2ILInjected.Token(Token = "0x40013B1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private SerializationInfo _siInfo;

		// Token: 0x02000474 RID: 1140
		[global::Cpp2ILInjected.Token(Token = "0x200041F")]
		private class OrderedDictionaryEnumerator : IDictionaryEnumerator, IEnumerator
		{
			// Token: 0x06001F59 RID: 8025 RVA: 0x0000868A File Offset: 0x0000688A
			[global::Cpp2ILInjected.Token(Token = "0x6001C7E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E8F9CC", Offset = "0x1E8F9CC", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			internal OrderedDictionaryEnumerator(ArrayList array, int objectReturnType)
			{
				throw null;
			}

			// Token: 0x1700076C RID: 1900
			// (get) Token: 0x06001F5A RID: 8026 RVA: 0x0000868D File Offset: 0x0000688D
			[global::Cpp2ILInjected.Token(Token = "0x1700065E")]
			public object Current
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001C7F")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E90004", Offset = "0x1E90004", Length = "0x198")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OrderedDictionary.OrderedDictionaryEnumerator), Member = "get_Entry", ReturnType = typeof(DictionaryEntry))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700076D RID: 1901
			// (get) Token: 0x06001F5B RID: 8027 RVA: 0x00008690 File Offset: 0x00006890
			[global::Cpp2ILInjected.Token(Token = "0x1700065F")]
			public DictionaryEntry Entry
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001C80")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E9019C", Offset = "0x1E9019C", Length = "0x180")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OrderedDictionary.OrderedDictionaryEnumerator), Member = "get_Current", ReturnType = typeof(object))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DictionaryEntry), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(object)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700076E RID: 1902
			// (get) Token: 0x06001F5C RID: 8028 RVA: 0x00008693 File Offset: 0x00006893
			[global::Cpp2ILInjected.Token(Token = "0x17000660")]
			public object Key
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001C81")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E9031C", Offset = "0x1E9031C", Length = "0xD8")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700076F RID: 1903
			// (get) Token: 0x06001F5D RID: 8029 RVA: 0x00008696 File Offset: 0x00006896
			[global::Cpp2ILInjected.Token(Token = "0x17000661")]
			public object Value
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001C82")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E903F4", Offset = "0x1E903F4", Length = "0xD8")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06001F5E RID: 8030 RVA: 0x00008699 File Offset: 0x00006899
			[global::Cpp2ILInjected.Token(Token = "0x6001C83")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E904CC", Offset = "0x1E904CC", Length = "0x98")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public bool MoveNext()
			{
				throw null;
			}

			// Token: 0x06001F5F RID: 8031 RVA: 0x0000869C File Offset: 0x0000689C
			[global::Cpp2ILInjected.Token(Token = "0x6001C84")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E90564", Offset = "0x1E90564", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public void Reset()
			{
				throw null;
			}

			// Token: 0x040013C6 RID: 5062
			[global::Cpp2ILInjected.Token(Token = "0x40013B2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private int _objectReturnType;

			// Token: 0x040013C7 RID: 5063
			[global::Cpp2ILInjected.Token(Token = "0x40013B3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private IEnumerator _arrayEnumerator;
		}

		// Token: 0x02000475 RID: 1141
		[global::Cpp2ILInjected.Token(Token = "0x2000420")]
		private class OrderedDictionaryKeyValueCollection : ICollection, IEnumerable
		{
			// Token: 0x06001F60 RID: 8032 RVA: 0x0000869F File Offset: 0x0000689F
			[global::Cpp2ILInjected.Token(Token = "0x6001C85")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E8F1B8", Offset = "0x1E8F1B8", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public OrderedDictionaryKeyValueCollection(ArrayList array, bool isKeys)
			{
				throw null;
			}

			// Token: 0x06001F61 RID: 8033 RVA: 0x000086A2 File Offset: 0x000068A2
			[global::Cpp2ILInjected.Token(Token = "0x6001C86")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E90600", Offset = "0x1E90600", Length = "0x3C0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsInvalidInstructions]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "SetValue", MemberParameters = new object[]
			{
				typeof(object),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 32)]
			private void System.Collections.ICollection.CopyTo(Array array, int index)
			{
				throw null;
			}

			// Token: 0x17000770 RID: 1904
			// (get) Token: 0x06001F62 RID: 8034 RVA: 0x000086A5 File Offset: 0x000068A5
			[global::Cpp2ILInjected.Token(Token = "0x17000662")]
			private int System.Collections.ICollection.Count
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001C87")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E909C0", Offset = "0x1E909C0", Length = "0x14")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000771 RID: 1905
			// (get) Token: 0x06001F63 RID: 8035 RVA: 0x000086A8 File Offset: 0x000068A8
			[global::Cpp2ILInjected.Token(Token = "0x17000663")]
			private bool System.Collections.ICollection.IsSynchronized
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001C88")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E909D4", Offset = "0x1E909D4", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000772 RID: 1906
			// (get) Token: 0x06001F64 RID: 8036 RVA: 0x000086AB File Offset: 0x000068AB
			[global::Cpp2ILInjected.Token(Token = "0x17000664")]
			private object System.Collections.ICollection.SyncRoot
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001C89")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E909DC", Offset = "0x1E909DC", Length = "0x14")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06001F65 RID: 8037 RVA: 0x000086AE File Offset: 0x000068AE
			[global::Cpp2ILInjected.Token(Token = "0x6001C8A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E909F0", Offset = "0x1E909F0", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				throw null;
			}

			// Token: 0x040013C8 RID: 5064
			[global::Cpp2ILInjected.Token(Token = "0x40013B4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private ArrayList _objects;

			// Token: 0x040013C9 RID: 5065
			[global::Cpp2ILInjected.Token(Token = "0x40013B5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private bool _isKeys;
		}
	}
}
