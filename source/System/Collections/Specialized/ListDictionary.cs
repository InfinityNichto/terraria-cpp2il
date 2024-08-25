using System;
using System.Net;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Collections.Specialized
{
	[global::Cpp2ILInjected.Token(Token = "0x2000418")]
	[Serializable]
	public class ListDictionary : IDictionary, ICollection, IEnumerable
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001C28")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8CA3C", Offset = "0x1E8CA3C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ListDictionary()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001C29")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8CA44", Offset = "0x1E8CA44", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(KnownHttpVerb), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ListDictionary(IComparer comparer)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6001C34")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8D104", Offset = "0x1E8D104", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Clear()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6001C37")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8D424", Offset = "0x1E8D424", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public IDictionaryEnumerator GetEnumerator()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001C38")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8D4D0", Offset = "0x1E8D4D0", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x4001396")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private ListDictionary.DictionaryNode head;

		[global::Cpp2ILInjected.Token(Token = "0x4001397")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int version;

		[global::Cpp2ILInjected.Token(Token = "0x4001398")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private int count;

		[global::Cpp2ILInjected.Token(Token = "0x4001399")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly IComparer comparer;

		[global::Cpp2ILInjected.Token(Token = "0x400139A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		[NonSerialized]
		private object _syncRoot;

		[global::Cpp2ILInjected.Token(Token = "0x2000419")]
		private class NodeEnumerator : IDictionaryEnumerator, IEnumerator
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001C3A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E8D494", Offset = "0x1E8D494", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public NodeEnumerator(ListDictionary list)
			{
				throw null;
			}

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

			[global::Cpp2ILInjected.Token(Token = "0x400139B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private ListDictionary _list;

			[global::Cpp2ILInjected.Token(Token = "0x400139C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private ListDictionary.DictionaryNode _current;

			[global::Cpp2ILInjected.Token(Token = "0x400139D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private int _version;

			[global::Cpp2ILInjected.Token(Token = "0x400139E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
			private bool _start;
		}

		[global::Cpp2ILInjected.Token(Token = "0x200041A")]
		private class NodeKeyValueCollection : ICollection, IEnumerable
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001C41")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E8CDE8", Offset = "0x1E8CDE8", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public NodeKeyValueCollection(ListDictionary list, bool isKeys)
			{
				throw null;
			}

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

			[global::Cpp2ILInjected.Token(Token = "0x6001C46")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E8DAE4", Offset = "0x1E8DAE4", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x400139F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private ListDictionary _list;

			[global::Cpp2ILInjected.Token(Token = "0x40013A0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private bool _isKeys;

			[global::Cpp2ILInjected.Token(Token = "0x200041B")]
			private class NodeKeyValueEnumerator : IEnumerator
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001C47")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E8DB68", Offset = "0x1E8DB68", Length = "0x44")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public NodeKeyValueEnumerator(ListDictionary list, bool isKeys)
				{
					throw null;
				}

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

				[global::Cpp2ILInjected.Token(Token = "0x40013A1")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				private ListDictionary _list;

				[global::Cpp2ILInjected.Token(Token = "0x40013A2")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
				private ListDictionary.DictionaryNode _current;

				[global::Cpp2ILInjected.Token(Token = "0x40013A3")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
				private int _version;

				[global::Cpp2ILInjected.Token(Token = "0x40013A4")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
				private bool _isKeys;

				[global::Cpp2ILInjected.Token(Token = "0x40013A5")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x25")]
				private bool _start;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x200041C")]
		[Serializable]
		public class DictionaryNode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001C4B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E8CD74", Offset = "0x1E8CD74", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public DictionaryNode()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x40013A6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public object key;

			[global::Cpp2ILInjected.Token(Token = "0x40013A7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public object value;

			[global::Cpp2ILInjected.Token(Token = "0x40013A8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public ListDictionary.DictionaryNode next;
		}
	}
}
