using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Collections
{
	[global::Cpp2ILInjected.Token(Token = "0x20005ED")]
	[global::System.Serializable]
	internal class ListDictionaryInternal : IDictionary, ICollection, IEnumerable
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002DCA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C072DC", Offset = "0x1C072DC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Exception), Member = "get_Data", ReturnType = typeof(IDictionary))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ListDictionaryInternal()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6002DD5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C077E0", Offset = "0x1C077E0", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Clear()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6002DD8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C07A78", Offset = "0x1C07A78", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public IDictionaryEnumerator GetEnumerator()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002DD9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C07B24", Offset = "0x1C07B24", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x40019A3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private ListDictionaryInternal.DictionaryNode head;

		[global::Cpp2ILInjected.Token(Token = "0x40019A4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int version;

		[global::Cpp2ILInjected.Token(Token = "0x40019A5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private int count;

		[global::Cpp2ILInjected.Token(Token = "0x40019A6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		[global::System.NonSerialized]
		private object _syncRoot;

		[global::Cpp2ILInjected.Token(Token = "0x20005EE")]
		private class NodeEnumerator : IDictionaryEnumerator, IEnumerator
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002DDB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C07AE8", Offset = "0x1C07AE8", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public NodeEnumerator(ListDictionaryInternal list)
			{
				throw null;
			}

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

			[global::Cpp2ILInjected.Token(Token = "0x40019A7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private ListDictionaryInternal list;

			[global::Cpp2ILInjected.Token(Token = "0x40019A8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private ListDictionaryInternal.DictionaryNode current;

			[global::Cpp2ILInjected.Token(Token = "0x40019A9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private int version;

			[global::Cpp2ILInjected.Token(Token = "0x40019AA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
			private bool start;
		}

		[global::Cpp2ILInjected.Token(Token = "0x20005EF")]
		private class NodeKeyValueCollection : ICollection, IEnumerable
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002DE2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0753C", Offset = "0x1C0753C", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public NodeKeyValueCollection(ListDictionaryInternal list, bool isKeys)
			{
				throw null;
			}

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

			[global::Cpp2ILInjected.Token(Token = "0x6002DE7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0810C", Offset = "0x1C0810C", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x40019AB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private ListDictionaryInternal list;

			[global::Cpp2ILInjected.Token(Token = "0x40019AC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private bool isKeys;

			[global::Cpp2ILInjected.Token(Token = "0x20005F0")]
			private class NodeKeyValueEnumerator : IEnumerator
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002DE8")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C08190", Offset = "0x1C08190", Length = "0x44")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public NodeKeyValueEnumerator(ListDictionaryInternal list, bool isKeys)
				{
					throw null;
				}

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

				[global::Cpp2ILInjected.Token(Token = "0x40019AD")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				private ListDictionaryInternal list;

				[global::Cpp2ILInjected.Token(Token = "0x40019AE")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
				private ListDictionaryInternal.DictionaryNode current;

				[global::Cpp2ILInjected.Token(Token = "0x40019AF")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
				private int version;

				[global::Cpp2ILInjected.Token(Token = "0x40019B0")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
				private bool isKeys;

				[global::Cpp2ILInjected.Token(Token = "0x40019B1")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x25")]
				private bool start;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x20005F1")]
		[global::System.Serializable]
		private class DictionaryNode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002DEC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C074C8", Offset = "0x1C074C8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public DictionaryNode()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x40019B2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public object key;

			[global::Cpp2ILInjected.Token(Token = "0x40019B3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public object value;

			[global::Cpp2ILInjected.Token(Token = "0x40019B4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public ListDictionaryInternal.DictionaryNode next;
		}
	}
}
