using System;
using System.Net;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Collections.Specialized
{
	// Token: 0x02000305 RID: 773
	[global::Cpp2ILInjected.Token(Token = "0x2000418")]
	[Serializable]
	public class ListDictionary : IDictionary, ICollection, IEnumerable
	{
		// Token: 0x0600194A RID: 6474 RVA: 0x0000753B File Offset: 0x0000573B
		[global::Cpp2ILInjected.Token(Token = "0x6001C28")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8CA3C", Offset = "0x1E8CA3C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ListDictionary()
		{
			throw null;
		}

		// Token: 0x0600194B RID: 6475 RVA: 0x0000753E File Offset: 0x0000573E
		[global::Cpp2ILInjected.Token(Token = "0x6001C29")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8CA44", Offset = "0x1E8CA44", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(KnownHttpVerb), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ListDictionary(IComparer comparer)
		{
			throw null;
		}

		// Token: 0x170005FF RID: 1535
		[global::Cpp2ILInjected.Token(Token = "0x17000641")]
		public object this[object key]
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001C2A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E8CA6C", Offset = "0x1E8CA6C", Length = "0x154")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(KnownHttpVerb), Member = "Parse", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(KnownHttpVerb))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001C2B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E8CBC0", Offset = "0x1E8CBC0", Length = "0x1B4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(KnownHttpVerb), Member = ".cctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x0600194E RID: 6478 RVA: 0x00007547 File Offset: 0x00005747
		[global::Cpp2ILInjected.Token(Token = "0x17000642")]
		public int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001C2C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E8CD7C", Offset = "0x1E8CD7C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x0600194F RID: 6479 RVA: 0x0000754A File Offset: 0x0000574A
		[global::Cpp2ILInjected.Token(Token = "0x17000643")]
		public ICollection Keys
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001C2D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E8CD84", Offset = "0x1E8CD84", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x06001950 RID: 6480 RVA: 0x0000754D File Offset: 0x0000574D
		[global::Cpp2ILInjected.Token(Token = "0x17000644")]
		public bool IsReadOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001C2E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E8CE18", Offset = "0x1E8CE18", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x06001951 RID: 6481 RVA: 0x00007550 File Offset: 0x00005750
		[global::Cpp2ILInjected.Token(Token = "0x17000645")]
		public bool IsFixedSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001C2F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E8CE20", Offset = "0x1E8CE20", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x06001952 RID: 6482 RVA: 0x00007553 File Offset: 0x00005753
		[global::Cpp2ILInjected.Token(Token = "0x17000646")]
		public bool IsSynchronized
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001C30")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E8CE28", Offset = "0x1E8CE28", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x06001953 RID: 6483 RVA: 0x00007556 File Offset: 0x00005756
		[global::Cpp2ILInjected.Token(Token = "0x17000647")]
		public object SyncRoot
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001C31")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E8CE30", Offset = "0x1E8CE30", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ListDictionary.NodeKeyValueCollection), Member = "System.Collections.ICollection.get_SyncRoot", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
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

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x06001954 RID: 6484 RVA: 0x00007559 File Offset: 0x00005759
		[global::Cpp2ILInjected.Token(Token = "0x17000648")]
		public ICollection Values
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001C32")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E8CEA4", Offset = "0x1E8CEA4", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001955 RID: 6485 RVA: 0x0000755C File Offset: 0x0000575C
		[global::Cpp2ILInjected.Token(Token = "0x6001C33")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8CF04", Offset = "0x1E8CF04", Length = "0x200")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public void Add(object key, object value)
		{
			throw null;
		}

		// Token: 0x06001956 RID: 6486 RVA: 0x0000755F File Offset: 0x0000575F
		[global::Cpp2ILInjected.Token(Token = "0x6001C34")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8D104", Offset = "0x1E8D104", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x06001957 RID: 6487 RVA: 0x00007562 File Offset: 0x00005762
		[global::Cpp2ILInjected.Token(Token = "0x6001C35")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8D118", Offset = "0x1E8D118", Length = "0x148")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public bool Contains(object key)
		{
			throw null;
		}

		// Token: 0x06001958 RID: 6488 RVA: 0x00007565 File Offset: 0x00005765
		[global::Cpp2ILInjected.Token(Token = "0x6001C36")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8D260", Offset = "0x1E8D260", Length = "0x1C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DictionaryEntry), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public void CopyTo(Array array, int index)
		{
			throw null;
		}

		// Token: 0x06001959 RID: 6489 RVA: 0x00007568 File Offset: 0x00005768
		[global::Cpp2ILInjected.Token(Token = "0x6001C37")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8D424", Offset = "0x1E8D424", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public IDictionaryEnumerator GetEnumerator()
		{
			throw null;
		}

		// Token: 0x0600195A RID: 6490 RVA: 0x0000756B File Offset: 0x0000576B
		[global::Cpp2ILInjected.Token(Token = "0x6001C38")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8D4D0", Offset = "0x1E8D4D0", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw null;
		}

		// Token: 0x0600195B RID: 6491 RVA: 0x0000756E File Offset: 0x0000576E
		[global::Cpp2ILInjected.Token(Token = "0x6001C39")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8D540", Offset = "0x1E8D540", Length = "0x188")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public void Remove(object key)
		{
			throw null;
		}

		// Token: 0x04000F55 RID: 3925
		[global::Cpp2ILInjected.Token(Token = "0x4001396")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private ListDictionary.DictionaryNode head;

		// Token: 0x04000F56 RID: 3926
		[global::Cpp2ILInjected.Token(Token = "0x4001397")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int version;

		// Token: 0x04000F57 RID: 3927
		[global::Cpp2ILInjected.Token(Token = "0x4001398")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private int count;

		// Token: 0x04000F58 RID: 3928
		[global::Cpp2ILInjected.Token(Token = "0x4001399")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly IComparer comparer;

		// Token: 0x04000F59 RID: 3929
		[global::Cpp2ILInjected.Token(Token = "0x400139A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		[NonSerialized]
		private object _syncRoot;

		// Token: 0x02000471 RID: 1137
		[global::Cpp2ILInjected.Token(Token = "0x2000419")]
		private class NodeEnumerator : IDictionaryEnumerator, IEnumerator
		{
			// Token: 0x06001F4B RID: 8011 RVA: 0x00008660 File Offset: 0x00006860
			[global::Cpp2ILInjected.Token(Token = "0x6001C3A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E8D494", Offset = "0x1E8D494", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public NodeEnumerator(ListDictionary list)
			{
				throw null;
			}

			// Token: 0x17000765 RID: 1893
			// (get) Token: 0x06001F4C RID: 8012 RVA: 0x00008663 File Offset: 0x00006863
			[global::Cpp2ILInjected.Token(Token = "0x17000649")]
			public object Current
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001C3B")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E8D6C8", Offset = "0x1E8D6C8", Length = "0x64")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ListDictionary.NodeEnumerator), Member = "get_Entry", ReturnType = typeof(DictionaryEntry))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000766 RID: 1894
			// (get) Token: 0x06001F4D RID: 8013 RVA: 0x00008666 File Offset: 0x00006866
			[global::Cpp2ILInjected.Token(Token = "0x1700064A")]
			public DictionaryEntry Entry
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001C3C")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E8D72C", Offset = "0x1E8D72C", Length = "0x7C")]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ListDictionary.NodeEnumerator), Member = "get_Current", ReturnType = typeof(object))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DictionaryEntry), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(object)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000767 RID: 1895
			// (get) Token: 0x06001F4E RID: 8014 RVA: 0x00008669 File Offset: 0x00006869
			[global::Cpp2ILInjected.Token(Token = "0x1700064B")]
			public object Key
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001C3D")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E8D7A8", Offset = "0x1E8D7A8", Length = "0x60")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000768 RID: 1896
			// (get) Token: 0x06001F4F RID: 8015 RVA: 0x0000866C File Offset: 0x0000686C
			[global::Cpp2ILInjected.Token(Token = "0x1700064C")]
			public object Value
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001C3E")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E8D808", Offset = "0x1E8D808", Length = "0x60")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06001F50 RID: 8016 RVA: 0x0000866F File Offset: 0x0000686F
			[global::Cpp2ILInjected.Token(Token = "0x6001C3F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E8D868", Offset = "0x1E8D868", Length = "0x94")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public bool MoveNext()
			{
				throw null;
			}

			// Token: 0x06001F51 RID: 8017 RVA: 0x00008672 File Offset: 0x00006872
			[global::Cpp2ILInjected.Token(Token = "0x6001C40")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E8D8FC", Offset = "0x1E8D8FC", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public void Reset()
			{
				throw null;
			}

			// Token: 0x040013BD RID: 5053
			[global::Cpp2ILInjected.Token(Token = "0x400139B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private ListDictionary _list;

			// Token: 0x040013BE RID: 5054
			[global::Cpp2ILInjected.Token(Token = "0x400139C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private ListDictionary.DictionaryNode _current;

			// Token: 0x040013BF RID: 5055
			[global::Cpp2ILInjected.Token(Token = "0x400139D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private int _version;

			// Token: 0x040013C0 RID: 5056
			[global::Cpp2ILInjected.Token(Token = "0x400139E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
			private bool _start;
		}

		// Token: 0x02000472 RID: 1138
		[global::Cpp2ILInjected.Token(Token = "0x200041A")]
		private class NodeKeyValueCollection : ICollection, IEnumerable
		{
			// Token: 0x06001F52 RID: 8018 RVA: 0x00008675 File Offset: 0x00006875
			[global::Cpp2ILInjected.Token(Token = "0x6001C41")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E8CDE8", Offset = "0x1E8CDE8", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public NodeKeyValueCollection(ListDictionary list, bool isKeys)
			{
				throw null;
			}

			// Token: 0x06001F53 RID: 8019 RVA: 0x00008678 File Offset: 0x00006878
			[global::Cpp2ILInjected.Token(Token = "0x6001C42")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E8D970", Offset = "0x1E8D970", Length = "0x13C")]
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
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
			private void System.Collections.ICollection.CopyTo(Array array, int index)
			{
				throw null;
			}

			// Token: 0x17000769 RID: 1897
			// (get) Token: 0x06001F54 RID: 8020 RVA: 0x0000867B File Offset: 0x0000687B
			[global::Cpp2ILInjected.Token(Token = "0x1700064D")]
			private int System.Collections.ICollection.Count
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001C43")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E8DAAC", Offset = "0x1E8DAAC", Length = "0x28")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700076A RID: 1898
			// (get) Token: 0x06001F55 RID: 8021 RVA: 0x0000867E File Offset: 0x0000687E
			[global::Cpp2ILInjected.Token(Token = "0x1700064E")]
			private bool System.Collections.ICollection.IsSynchronized
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001C44")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E8DAD4", Offset = "0x1E8DAD4", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700076B RID: 1899
			// (get) Token: 0x06001F56 RID: 8022 RVA: 0x00008681 File Offset: 0x00006881
			[global::Cpp2ILInjected.Token(Token = "0x1700064F")]
			private object System.Collections.ICollection.SyncRoot
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001C45")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E8DADC", Offset = "0x1E8DADC", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ListDictionary), Member = "get_SyncRoot", ReturnType = typeof(object))]
				get
				{
					throw null;
				}
			}

			// Token: 0x06001F57 RID: 8023 RVA: 0x00008684 File Offset: 0x00006884
			[global::Cpp2ILInjected.Token(Token = "0x6001C46")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E8DAE4", Offset = "0x1E8DAE4", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				throw null;
			}

			// Token: 0x040013C1 RID: 5057
			[global::Cpp2ILInjected.Token(Token = "0x400139F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private ListDictionary _list;

			// Token: 0x040013C2 RID: 5058
			[global::Cpp2ILInjected.Token(Token = "0x40013A0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private bool _isKeys;

			// Token: 0x020004C0 RID: 1216
			[global::Cpp2ILInjected.Token(Token = "0x200041B")]
			private class NodeKeyValueEnumerator : IEnumerator
			{
				// Token: 0x0600203C RID: 8252 RVA: 0x00008861 File Offset: 0x00006A61
				[global::Cpp2ILInjected.Token(Token = "0x6001C47")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E8DB68", Offset = "0x1E8DB68", Length = "0x44")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public NodeKeyValueEnumerator(ListDictionary list, bool isKeys)
				{
					throw null;
				}

				// Token: 0x1700078D RID: 1933
				// (get) Token: 0x0600203D RID: 8253 RVA: 0x00008864 File Offset: 0x00006A64
				[global::Cpp2ILInjected.Token(Token = "0x17000650")]
				public object Current
				{
					[global::Cpp2ILInjected.Token(Token = "0x6001C48")]
					[global::Cpp2ILInjected.Address(RVA = "0x1E8DBAC", Offset = "0x1E8DBAC", Length = "0x74")]
					[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
					[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
					[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
					[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
					get
					{
						throw null;
					}
				}

				// Token: 0x0600203E RID: 8254 RVA: 0x00008867 File Offset: 0x00006A67
				[global::Cpp2ILInjected.Token(Token = "0x6001C49")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E8DC20", Offset = "0x1E8DC20", Length = "0x94")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
				public bool MoveNext()
				{
					throw null;
				}

				// Token: 0x0600203F RID: 8255 RVA: 0x0000886A File Offset: 0x00006A6A
				[global::Cpp2ILInjected.Token(Token = "0x6001C4A")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E8DCB4", Offset = "0x1E8DCB4", Length = "0x74")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
				public void Reset()
				{
					throw null;
				}

				// Token: 0x0400144F RID: 5199
				[global::Cpp2ILInjected.Token(Token = "0x40013A1")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				private ListDictionary _list;

				// Token: 0x04001450 RID: 5200
				[global::Cpp2ILInjected.Token(Token = "0x40013A2")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
				private ListDictionary.DictionaryNode _current;

				// Token: 0x04001451 RID: 5201
				[global::Cpp2ILInjected.Token(Token = "0x40013A3")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
				private int _version;

				// Token: 0x04001452 RID: 5202
				[global::Cpp2ILInjected.Token(Token = "0x40013A4")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
				private bool _isKeys;

				// Token: 0x04001453 RID: 5203
				[global::Cpp2ILInjected.Token(Token = "0x40013A5")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x25")]
				private bool _start;
			}
		}

		// Token: 0x02000473 RID: 1139
		[global::Cpp2ILInjected.Token(Token = "0x200041C")]
		[Serializable]
		public class DictionaryNode
		{
			// Token: 0x06001F58 RID: 8024 RVA: 0x00008687 File Offset: 0x00006887
			[global::Cpp2ILInjected.Token(Token = "0x6001C4B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E8CD74", Offset = "0x1E8CD74", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public DictionaryNode()
			{
				throw null;
			}

			// Token: 0x040013C3 RID: 5059
			[global::Cpp2ILInjected.Token(Token = "0x40013A6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public object key;

			// Token: 0x040013C4 RID: 5060
			[global::Cpp2ILInjected.Token(Token = "0x40013A7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public object value;

			// Token: 0x040013C5 RID: 5061
			[global::Cpp2ILInjected.Token(Token = "0x40013A8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public ListDictionary.DictionaryNode next;
		}
	}
}
