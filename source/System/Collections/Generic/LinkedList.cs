using System;
using System.Diagnostics;
using System.Net;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Collections.Generic
{
	[DebuggerTypeProxy(typeof(ICollectionDebugView<>))]
	[DebuggerDisplay("Count = {Count}")]
	[global::Cpp2ILInjected.Token(Token = "0x2000430")]
	[Serializable]
	public class LinkedList<T> : ICollection<T>, IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T>, ISerializable, IDeserializationCallback
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001CFD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1727C10", Offset = "0x1727C10", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServicePointScheduler), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(ServicePoint),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public LinkedList()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001CFE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1727C18", Offset = "0x1727C18", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected LinkedList(SerializationInfo info, StreamingContext context)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000682")]
		public int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001CFF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1727C40", Offset = "0x1727C40", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000683")]
		public LinkedListNode<T> First
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D00")]
			[global::Cpp2ILInjected.Address(RVA = "0x1727C48", Offset = "0x1727C48", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000684")]
		private bool System.Collections.Generic.ICollection<T>.IsReadOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D01")]
			[global::Cpp2ILInjected.Address(RVA = "0x1727C50", Offset = "0x1727C50", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001D02")]
		[global::Cpp2ILInjected.Address(RVA = "0x1727C58", Offset = "0x1727C58", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void System.Collections.Generic.ICollection<T>.Add(T value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001D03")]
		[global::Cpp2ILInjected.Address(RVA = "0x1727C6C", Offset = "0x1727C6C", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public LinkedListNode<T> AddAfter(LinkedListNode<T> node, T value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001D04")]
		[global::Cpp2ILInjected.Address(RVA = "0x1727D20", Offset = "0x1727D20", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public LinkedListNode<T> AddFirst(T value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001D05")]
		[global::Cpp2ILInjected.Address(RVA = "0x1727DDC", Offset = "0x1727DDC", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServicePointScheduler), Member = "OperationCompleted", MemberParameters = new object[]
		{
			"System.Net.ServicePointScheduler.ConnectionGroup",
			typeof(WebOperation)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServicePointScheduler), Member = "SchedulerIteration", MemberParameters = new object[] { "System.Net.ServicePointScheduler.ConnectionGroup" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public LinkedListNode<T> AddLast(T value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001D06")]
		[global::Cpp2ILInjected.Address(RVA = "0x1727E94", Offset = "0x1727E94", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void AddLast(LinkedListNode<T> node)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001D07")]
		[global::Cpp2ILInjected.Address(RVA = "0x1727F08", Offset = "0x1727F08", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Clear()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001D08")]
		[global::Cpp2ILInjected.Address(RVA = "0x1727F80", Offset = "0x1727F80", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool Contains(T value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001D09")]
		[global::Cpp2ILInjected.Address(RVA = "0x1727FA8", Offset = "0x1727FA8", Length = "0x1CC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.ServicePointScheduler.<RunScheduler>d__32", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		public void CopyTo(T[] array, int index)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001D0A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1728174", Offset = "0x1728174", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public LinkedListNode<T> Find(T value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001D0B")]
		[global::Cpp2ILInjected.Address(RVA = "0x17281F4", Offset = "0x17281F4", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinkedList<>.Enumerator), Member = ".ctor", MemberParameters = new object[] { "System.Collections.Generic.LinkedList`1<T>" }, ReturnType = typeof(void))]
		public LinkedList<T>.Enumerator GetEnumerator()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001D0C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1728218", Offset = "0x1728218", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001D0D")]
		[global::Cpp2ILInjected.Address(RVA = "0x172827C", Offset = "0x172827C", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.ServicePointScheduler.<RunScheduler>d__32", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public bool Remove(T value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001D0E")]
		[global::Cpp2ILInjected.Address(RVA = "0x17282D0", Offset = "0x17282D0", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServicePointScheduler), Member = "RemoveOperation", MemberParameters = new object[] { typeof(WebOperation) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Remove(LinkedListNode<T> node)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001D0F")]
		[global::Cpp2ILInjected.Address(RVA = "0x172831C", Offset = "0x172831C", Length = "0x1A4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001D10")]
		[global::Cpp2ILInjected.Address(RVA = "0x17284C0", Offset = "0x17284C0", Length = "0x1E4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "GetInt32", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "GetValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public virtual void OnDeserialization(object sender)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001D11")]
		[global::Cpp2ILInjected.Address(RVA = "0x17286A4", Offset = "0x17286A4", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void InternalInsertNodeBefore(LinkedListNode<T> node, LinkedListNode<T> newNode)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001D12")]
		[global::Cpp2ILInjected.Address(RVA = "0x17286D0", Offset = "0x17286D0", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void InternalInsertNodeToEmptyList(LinkedListNode<T> newNode)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001D13")]
		[global::Cpp2ILInjected.Address(RVA = "0x17286EC", Offset = "0x17286EC", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void InternalRemoveNode(LinkedListNode<T> node)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001D14")]
		[global::Cpp2ILInjected.Address(RVA = "0x1728764", Offset = "0x1728764", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		internal void ValidateNewNode(LinkedListNode<T> node)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001D15")]
		[global::Cpp2ILInjected.Address(RVA = "0x17287F8", Offset = "0x17287F8", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		internal void ValidateNode(LinkedListNode<T> node)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000685")]
		private bool System.Collections.ICollection.IsSynchronized
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D16")]
			[global::Cpp2ILInjected.Address(RVA = "0x1728890", Offset = "0x1728890", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000686")]
		private object System.Collections.ICollection.SyncRoot
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D17")]
			[global::Cpp2ILInjected.Address(RVA = "0x1728898", Offset = "0x1728898", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001D18")]
		[global::Cpp2ILInjected.Address(RVA = "0x1728908", Offset = "0x1728908", Length = "0x3A0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "get_Rank", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "GetLowerBound", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 43)]
		private void System.Collections.ICollection.CopyTo(Array array, int index)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001D19")]
		[global::Cpp2ILInjected.Address(RVA = "0x1728CA8", Offset = "0x1728CA8", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40013D7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		internal LinkedListNode<T> head;

		[global::Cpp2ILInjected.Token(Token = "0x40013D8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		internal int count;

		[global::Cpp2ILInjected.Token(Token = "0x40013D9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		internal int version;

		[global::Cpp2ILInjected.Token(Token = "0x40013DA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private object _syncRoot;

		[global::Cpp2ILInjected.Token(Token = "0x40013DB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private SerializationInfo _siInfo;

		[global::Cpp2ILInjected.Token(Token = "0x40013DC")]
		private const string VersionName = "Version";

		[global::Cpp2ILInjected.Token(Token = "0x40013DD")]
		private const string CountName = "Count";

		[global::Cpp2ILInjected.Token(Token = "0x40013DE")]
		private const string ValuesName = "Data";

		[global::Cpp2ILInjected.Token(Token = "0x2000431")]
		[Serializable]
		public struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator, ISerializable, IDeserializationCallback
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D1A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1644494", Offset = "0x1644494", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LinkedList<>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			internal Enumerator(LinkedList<T> list)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6001D1B")]
			[global::Cpp2ILInjected.Address(RVA = "0x16444B4", Offset = "0x16444B4", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			private Enumerator(SerializationInfo info, StreamingContext context)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x17000687")]
			public T Current
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001D1C")]
				[global::Cpp2ILInjected.Address(RVA = "0x16444EC", Offset = "0x16444EC", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x17000688")]
			private object System.Collections.IEnumerator.Current
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001D1D")]
				[global::Cpp2ILInjected.Address(RVA = "0x16444F8", Offset = "0x16444F8", Length = "0x110")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x6001D1E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1644608", Offset = "0x1644608", Length = "0x114")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			public bool MoveNext()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6001D1F")]
			[global::Cpp2ILInjected.Address(RVA = "0x164471C", Offset = "0x164471C", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			private void System.Collections.IEnumerator.Reset()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6001D20")]
			[global::Cpp2ILInjected.Address(RVA = "0x1644794", Offset = "0x1644794", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void Dispose()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6001D21")]
			[global::Cpp2ILInjected.Address(RVA = "0x1644798", Offset = "0x1644798", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6001D22")]
			[global::Cpp2ILInjected.Address(RVA = "0x16447D0", Offset = "0x16447D0", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x40013DF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private LinkedList<T> _list;

			[global::Cpp2ILInjected.Token(Token = "0x40013E0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private LinkedListNode<T> _node;

			[global::Cpp2ILInjected.Token(Token = "0x40013E1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int _version;

			[global::Cpp2ILInjected.Token(Token = "0x40013E2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private T _current;

			[global::Cpp2ILInjected.Token(Token = "0x40013E3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int _index;
		}
	}
}
