using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Collections
{
	// Token: 0x020004F9 RID: 1273
	[global::Cpp2ILInjected.Token(Token = "0x20005ED")]
	[global::System.Serializable]
	internal class ListDictionaryInternal : IDictionary, ICollection, IEnumerable
	{
		// Token: 0x06002A66 RID: 10854 RVA: 0x0001BAF7 File Offset: 0x00019CF7
		[global::Cpp2ILInjected.Token(Token = "0x6002DCA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C072DC", Offset = "0x1C072DC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Exception), Member = "get_Data", ReturnType = typeof(IDictionary))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ListDictionaryInternal()
		{
			throw null;
		}

		// Token: 0x1700066E RID: 1646
		[global::Cpp2ILInjected.Token(Token = "0x17000705")]
		public object this[object key]
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002DCB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C072E4", Offset = "0x1C072E4", Length = "0xAC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6002DCC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C07390", Offset = "0x1C07390", Length = "0x138")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x06002A69 RID: 10857 RVA: 0x0001BB00 File Offset: 0x00019D00
		[global::Cpp2ILInjected.Token(Token = "0x17000706")]
		public int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002DCD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C074D0", Offset = "0x1C074D0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x06002A6A RID: 10858 RVA: 0x0001BB03 File Offset: 0x00019D03
		[global::Cpp2ILInjected.Token(Token = "0x17000707")]
		public ICollection Keys
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002DCE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C074D8", Offset = "0x1C074D8", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x06002A6B RID: 10859 RVA: 0x0001BB06 File Offset: 0x00019D06
		[global::Cpp2ILInjected.Token(Token = "0x17000708")]
		public bool IsReadOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002DCF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0756C", Offset = "0x1C0756C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x06002A6C RID: 10860 RVA: 0x0001BB09 File Offset: 0x00019D09
		[global::Cpp2ILInjected.Token(Token = "0x17000709")]
		public bool IsFixedSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002DD0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C07574", Offset = "0x1C07574", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x06002A6D RID: 10861 RVA: 0x0001BB0C File Offset: 0x00019D0C
		[global::Cpp2ILInjected.Token(Token = "0x1700070A")]
		public bool IsSynchronized
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002DD1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0757C", Offset = "0x1C0757C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x06002A6E RID: 10862 RVA: 0x0001BB0F File Offset: 0x00019D0F
		[global::Cpp2ILInjected.Token(Token = "0x1700070B")]
		public object SyncRoot
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002DD2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C07584", Offset = "0x1C07584", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ListDictionaryInternal.NodeKeyValueCollection), Member = "System.Collections.ICollection.get_SyncRoot", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x06002A6F RID: 10863 RVA: 0x0001BB12 File Offset: 0x00019D12
		[global::Cpp2ILInjected.Token(Token = "0x1700070C")]
		public ICollection Values
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002DD3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C075F4", Offset = "0x1C075F4", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002A70 RID: 10864 RVA: 0x0001BB15 File Offset: 0x00019D15
		[global::Cpp2ILInjected.Token(Token = "0x6002DD4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C07654", Offset = "0x1C07654", Length = "0x18C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public void Add(object key, object value)
		{
			throw null;
		}

		// Token: 0x06002A71 RID: 10865 RVA: 0x0001BB18 File Offset: 0x00019D18
		[global::Cpp2ILInjected.Token(Token = "0x6002DD5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C077E0", Offset = "0x1C077E0", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x06002A72 RID: 10866 RVA: 0x0001BB1B File Offset: 0x00019D1B
		[global::Cpp2ILInjected.Token(Token = "0x6002DD6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C077F4", Offset = "0x1C077F4", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public bool Contains(object key)
		{
			throw null;
		}

		// Token: 0x06002A73 RID: 10867 RVA: 0x0001BB1E File Offset: 0x00019D1E
		[global::Cpp2ILInjected.Token(Token = "0x6002DD7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C078A0", Offset = "0x1C078A0", Length = "0x1D8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Rank", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "SetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public void CopyTo(global::System.Array array, int index)
		{
			throw null;
		}

		// Token: 0x06002A74 RID: 10868 RVA: 0x0001BB21 File Offset: 0x00019D21
		[global::Cpp2ILInjected.Token(Token = "0x6002DD8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C07A78", Offset = "0x1C07A78", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public IDictionaryEnumerator GetEnumerator()
		{
			throw null;
		}

		// Token: 0x06002A75 RID: 10869 RVA: 0x0001BB24 File Offset: 0x00019D24
		[global::Cpp2ILInjected.Token(Token = "0x6002DD9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C07B24", Offset = "0x1C07B24", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw null;
		}

		// Token: 0x06002A76 RID: 10870 RVA: 0x0001BB27 File Offset: 0x00019D27
		[global::Cpp2ILInjected.Token(Token = "0x6002DDA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C07B94", Offset = "0x1C07B94", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public void Remove(object key)
		{
			throw null;
		}

		// Token: 0x040015B3 RID: 5555
		[global::Cpp2ILInjected.Token(Token = "0x40019A3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private ListDictionaryInternal.DictionaryNode head;

		// Token: 0x040015B4 RID: 5556
		[global::Cpp2ILInjected.Token(Token = "0x40019A4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int version;

		// Token: 0x040015B5 RID: 5557
		[global::Cpp2ILInjected.Token(Token = "0x40019A5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private int count;

		// Token: 0x040015B6 RID: 5558
		[global::Cpp2ILInjected.Token(Token = "0x40019A6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		[global::System.NonSerialized]
		private object _syncRoot;

		// Token: 0x0200063E RID: 1598
		[global::Cpp2ILInjected.Token(Token = "0x20005EE")]
		private class NodeEnumerator : IDictionaryEnumerator, IEnumerator
		{
			// Token: 0x06004238 RID: 16952 RVA: 0x000200FC File Offset: 0x0001E2FC
			[global::Cpp2ILInjected.Token(Token = "0x6002DDB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C07AE8", Offset = "0x1C07AE8", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public NodeEnumerator(ListDictionaryInternal list)
			{
				throw null;
			}

			// Token: 0x17000792 RID: 1938
			// (get) Token: 0x06004239 RID: 16953 RVA: 0x000200FF File Offset: 0x0001E2FF
			[global::Cpp2ILInjected.Token(Token = "0x1700070D")]
			public object Current
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002DDC")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C07C94", Offset = "0x1C07C94", Length = "0x64")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ListDictionaryInternal.NodeEnumerator), Member = "get_Entry", ReturnType = typeof(DictionaryEntry))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000793 RID: 1939
			// (get) Token: 0x0600423A RID: 16954 RVA: 0x00020102 File Offset: 0x0001E302
			[global::Cpp2ILInjected.Token(Token = "0x1700070E")]
			public DictionaryEntry Entry
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002DDD")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C07CF8", Offset = "0x1C07CF8", Length = "0x60")]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ListDictionaryInternal.NodeEnumerator), Member = "get_Current", ReturnType = typeof(object))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000794 RID: 1940
			// (get) Token: 0x0600423B RID: 16955 RVA: 0x00020105 File Offset: 0x0001E305
			[global::Cpp2ILInjected.Token(Token = "0x1700070F")]
			public object Key
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002DDE")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C07D58", Offset = "0x1C07D58", Length = "0x60")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000795 RID: 1941
			// (get) Token: 0x0600423C RID: 16956 RVA: 0x00020108 File Offset: 0x0001E308
			[global::Cpp2ILInjected.Token(Token = "0x17000710")]
			public object Value
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002DDF")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C07DB8", Offset = "0x1C07DB8", Length = "0x60")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0600423D RID: 16957 RVA: 0x0002010B File Offset: 0x0001E30B
			[global::Cpp2ILInjected.Token(Token = "0x6002DE0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C07E18", Offset = "0x1C07E18", Length = "0x94")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public bool MoveNext()
			{
				throw null;
			}

			// Token: 0x0600423E RID: 16958 RVA: 0x0002010E File Offset: 0x0001E30E
			[global::Cpp2ILInjected.Token(Token = "0x6002DE1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C07EAC", Offset = "0x1C07EAC", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public void Reset()
			{
				throw null;
			}

			// Token: 0x04001A76 RID: 6774
			[global::Cpp2ILInjected.Token(Token = "0x40019A7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private ListDictionaryInternal list;

			// Token: 0x04001A77 RID: 6775
			[global::Cpp2ILInjected.Token(Token = "0x40019A8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private ListDictionaryInternal.DictionaryNode current;

			// Token: 0x04001A78 RID: 6776
			[global::Cpp2ILInjected.Token(Token = "0x40019A9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private int version;

			// Token: 0x04001A79 RID: 6777
			[global::Cpp2ILInjected.Token(Token = "0x40019AA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
			private bool start;
		}

		// Token: 0x0200063F RID: 1599
		[global::Cpp2ILInjected.Token(Token = "0x20005EF")]
		private class NodeKeyValueCollection : ICollection, IEnumerable
		{
			// Token: 0x0600423F RID: 16959 RVA: 0x00020111 File Offset: 0x0001E311
			[global::Cpp2ILInjected.Token(Token = "0x6002DE2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0753C", Offset = "0x1C0753C", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public NodeKeyValueCollection(ListDictionaryInternal list, bool isKeys)
			{
				throw null;
			}

			// Token: 0x06004240 RID: 16960 RVA: 0x00020114 File Offset: 0x0001E314
			[global::Cpp2ILInjected.Token(Token = "0x6002DE3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C07F20", Offset = "0x1C07F20", Length = "0x1B4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Rank", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Length", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "SetValue", MemberParameters = new object[]
			{
				typeof(object),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
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
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
			private void System.Collections.ICollection.CopyTo(global::System.Array array, int index)
			{
				throw null;
			}

			// Token: 0x17000796 RID: 1942
			// (get) Token: 0x06004241 RID: 16961 RVA: 0x00020117 File Offset: 0x0001E317
			[global::Cpp2ILInjected.Token(Token = "0x17000711")]
			private int System.Collections.ICollection.Count
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002DE4")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C080D4", Offset = "0x1C080D4", Length = "0x28")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000797 RID: 1943
			// (get) Token: 0x06004242 RID: 16962 RVA: 0x0002011A File Offset: 0x0001E31A
			[global::Cpp2ILInjected.Token(Token = "0x17000712")]
			private bool System.Collections.ICollection.IsSynchronized
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002DE5")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C080FC", Offset = "0x1C080FC", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000798 RID: 1944
			// (get) Token: 0x06004243 RID: 16963 RVA: 0x0002011D File Offset: 0x0001E31D
			[global::Cpp2ILInjected.Token(Token = "0x17000713")]
			private object System.Collections.ICollection.SyncRoot
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002DE6")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C08104", Offset = "0x1C08104", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ListDictionaryInternal), Member = "get_SyncRoot", ReturnType = typeof(object))]
				get
				{
					throw null;
				}
			}

			// Token: 0x06004244 RID: 16964 RVA: 0x00020120 File Offset: 0x0001E320
			[global::Cpp2ILInjected.Token(Token = "0x6002DE7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0810C", Offset = "0x1C0810C", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				throw null;
			}

			// Token: 0x04001A7A RID: 6778
			[global::Cpp2ILInjected.Token(Token = "0x40019AB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private ListDictionaryInternal list;

			// Token: 0x04001A7B RID: 6779
			[global::Cpp2ILInjected.Token(Token = "0x40019AC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private bool isKeys;

			// Token: 0x020006B2 RID: 1714
			[global::Cpp2ILInjected.Token(Token = "0x20005F0")]
			private class NodeKeyValueEnumerator : IEnumerator
			{
				// Token: 0x06004379 RID: 17273 RVA: 0x000204B9 File Offset: 0x0001E6B9
				[global::Cpp2ILInjected.Token(Token = "0x6002DE8")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C08190", Offset = "0x1C08190", Length = "0x44")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public NodeKeyValueEnumerator(ListDictionaryInternal list, bool isKeys)
				{
					throw null;
				}

				// Token: 0x170007F8 RID: 2040
				// (get) Token: 0x0600437A RID: 17274 RVA: 0x000204BC File Offset: 0x0001E6BC
				[global::Cpp2ILInjected.Token(Token = "0x17000714")]
				public object Current
				{
					[global::Cpp2ILInjected.Token(Token = "0x6002DE9")]
					[global::Cpp2ILInjected.Address(RVA = "0x1C081D4", Offset = "0x1C081D4", Length = "0x74")]
					[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
					[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
					[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
					[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
					get
					{
						throw null;
					}
				}

				// Token: 0x0600437B RID: 17275 RVA: 0x000204BF File Offset: 0x0001E6BF
				[global::Cpp2ILInjected.Token(Token = "0x6002DEA")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C08248", Offset = "0x1C08248", Length = "0x94")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
				public bool MoveNext()
				{
					throw null;
				}

				// Token: 0x0600437C RID: 17276 RVA: 0x000204C2 File Offset: 0x0001E6C2
				[global::Cpp2ILInjected.Token(Token = "0x6002DEB")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C082DC", Offset = "0x1C082DC", Length = "0x74")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
				public void Reset()
				{
					throw null;
				}

				// Token: 0x04001B41 RID: 6977
				[global::Cpp2ILInjected.Token(Token = "0x40019AD")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				private ListDictionaryInternal list;

				// Token: 0x04001B42 RID: 6978
				[global::Cpp2ILInjected.Token(Token = "0x40019AE")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
				private ListDictionaryInternal.DictionaryNode current;

				// Token: 0x04001B43 RID: 6979
				[global::Cpp2ILInjected.Token(Token = "0x40019AF")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
				private int version;

				// Token: 0x04001B44 RID: 6980
				[global::Cpp2ILInjected.Token(Token = "0x40019B0")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
				private bool isKeys;

				// Token: 0x04001B45 RID: 6981
				[global::Cpp2ILInjected.Token(Token = "0x40019B1")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x25")]
				private bool start;
			}
		}

		// Token: 0x02000640 RID: 1600
		[global::Cpp2ILInjected.Token(Token = "0x20005F1")]
		[global::System.Serializable]
		private class DictionaryNode
		{
			// Token: 0x06004245 RID: 16965 RVA: 0x00020123 File Offset: 0x0001E323
			[global::Cpp2ILInjected.Token(Token = "0x6002DEC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C074C8", Offset = "0x1C074C8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public DictionaryNode()
			{
				throw null;
			}

			// Token: 0x04001A7C RID: 6780
			[global::Cpp2ILInjected.Token(Token = "0x40019B2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public object key;

			// Token: 0x04001A7D RID: 6781
			[global::Cpp2ILInjected.Token(Token = "0x40019B3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public object value;

			// Token: 0x04001A7E RID: 6782
			[global::Cpp2ILInjected.Token(Token = "0x40019B4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public ListDictionaryInternal.DictionaryNode next;
		}
	}
}
