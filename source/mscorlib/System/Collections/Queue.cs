using System;
using System.Diagnostics;
using System.Runtime.Remoting.Lifetime;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Collections
{
	// Token: 0x020004FE RID: 1278
	[global::System.Diagnostics.DebuggerDisplay("Count = {Count}")]
	[global::System.Diagnostics.DebuggerTypeProxy(typeof(Queue.QueueDebugView))]
	[global::Cpp2ILInjected.Token(Token = "0x20005F6")]
	[global::System.Serializable]
	public class Queue : ICollection, IEnumerable, global::System.ICloneable
	{
		// Token: 0x06002AA1 RID: 10913 RVA: 0x0001BBA8 File Offset: 0x00019DA8
		[global::Cpp2ILInjected.Token(Token = "0x6002E17")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C095B4", Offset = "0x1C095B4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.ObjectWriter), Member = "Serialize", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Runtime.Remoting.Messaging.Header[]),
			typeof(global::System.Runtime.Serialization.Formatters.Binary.__BinaryWriter),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.ParticleContentValidator", Member = "BuildTransitionTable", MemberParameters = new object[]
		{
			"System.Xml.Schema.BitSet",
			"System.Xml.Schema.BitSet[]",
			typeof(int)
		}, ReturnType = "System.Int32[][]")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public Queue()
		{
			throw null;
		}

		// Token: 0x06002AA2 RID: 10914 RVA: 0x0001BBAB File Offset: 0x00019DAB
		[global::Cpp2ILInjected.Token(Token = "0x6002E18")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C09778", Offset = "0x1C09778", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Queue), Member = ".ctor", MemberParameters = new object[] { typeof(ICollection) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Queue), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(float)
		}, ReturnType = typeof(void))]
		public Queue(int capacity)
		{
			throw null;
		}

		// Token: 0x06002AA3 RID: 10915 RVA: 0x0001BBAE File Offset: 0x00019DAE
		[global::Cpp2ILInjected.Token(Token = "0x6002E19")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C095C0", Offset = "0x1C095C0", Length = "0x1B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Queue), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Queue), Member = ".ctor", MemberParameters = new object[] { typeof(ICollection) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Queue), Member = "Clone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public Queue(int capacity, float growFactor)
		{
			throw null;
		}

		// Token: 0x06002AA4 RID: 10916 RVA: 0x0001BBB1 File Offset: 0x00019DB1
		[global::Cpp2ILInjected.Token(Token = "0x6002E1A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C09780", Offset = "0x1C09780", Length = "0x260")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Lifetime.Lease), Member = "UpdateState", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Queue), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Queue), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public Queue(ICollection col)
		{
			throw null;
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x06002AA5 RID: 10917 RVA: 0x0001BBB4 File Offset: 0x00019DB4
		[global::Cpp2ILInjected.Token(Token = "0x17000721")]
		public virtual int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002E1B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C099E0", Offset = "0x1C099E0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002AA6 RID: 10918 RVA: 0x0001BBB7 File Offset: 0x00019DB7
		[global::Cpp2ILInjected.Token(Token = "0x6002E1C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C099E8", Offset = "0x1C099E8", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Queue), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual object Clone()
		{
			throw null;
		}

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x06002AA7 RID: 10919 RVA: 0x0001BBBA File Offset: 0x00019DBA
		[global::Cpp2ILInjected.Token(Token = "0x17000722")]
		public virtual bool IsSynchronized
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002E1D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C09ABC", Offset = "0x1C09ABC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x06002AA8 RID: 10920 RVA: 0x0001BBBD File Offset: 0x00019DBD
		[global::Cpp2ILInjected.Token(Token = "0x17000723")]
		public virtual object SyncRoot
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002E1E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C09AC4", Offset = "0x1C09AC4", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Interlocked), Member = "CompareExchange", MemberParameters = new object[]
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

		// Token: 0x06002AA9 RID: 10921 RVA: 0x0001BBC0 File Offset: 0x00019DC0
		[global::Cpp2ILInjected.Token(Token = "0x6002E1F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C09B38", Offset = "0x1C09B38", Length = "0x1D8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Rank", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public virtual void CopyTo(global::System.Array array, int index)
		{
			throw null;
		}

		// Token: 0x06002AAA RID: 10922 RVA: 0x0001BBC3 File Offset: 0x00019DC3
		[global::Cpp2ILInjected.Token(Token = "0x6002E20")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C09D10", Offset = "0x1C09D10", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Queue), Member = "SetCapacity", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public virtual void Enqueue(object obj)
		{
			throw null;
		}

		// Token: 0x06002AAB RID: 10923 RVA: 0x0001BBC6 File Offset: 0x00019DC6
		[global::Cpp2ILInjected.Token(Token = "0x6002E21")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C09EE0", Offset = "0x1C09EE0", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual IEnumerator GetEnumerator()
		{
			throw null;
		}

		// Token: 0x06002AAC RID: 10924 RVA: 0x0001BBC9 File Offset: 0x00019DC9
		[global::Cpp2ILInjected.Token(Token = "0x6002E22")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C09FA4", Offset = "0x1C09FA4", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public virtual object Dequeue()
		{
			throw null;
		}

		// Token: 0x06002AAD RID: 10925 RVA: 0x0001BBCC File Offset: 0x00019DCC
		[global::Cpp2ILInjected.Token(Token = "0x6002E23")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0A050", Offset = "0x1C0A050", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public virtual object Peek()
		{
			throw null;
		}

		// Token: 0x06002AAE RID: 10926 RVA: 0x0001BBCF File Offset: 0x00019DCF
		[global::Cpp2ILInjected.Token(Token = "0x6002E24")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0A0C8", Offset = "0x1C0A0C8", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal object GetElement(int i)
		{
			throw null;
		}

		// Token: 0x06002AAF RID: 10927 RVA: 0x0001BBD2 File Offset: 0x00019DD2
		[global::Cpp2ILInjected.Token(Token = "0x6002E25")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C09E00", Offset = "0x1C09E00", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Queue), Member = "Enqueue", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void SetCapacity(int capacity)
		{
			throw null;
		}

		// Token: 0x040015BC RID: 5564
		[global::Cpp2ILInjected.Token(Token = "0x40019BA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private object[] _array;

		// Token: 0x040015BD RID: 5565
		[global::Cpp2ILInjected.Token(Token = "0x40019BB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int _head;

		// Token: 0x040015BE RID: 5566
		[global::Cpp2ILInjected.Token(Token = "0x40019BC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private int _tail;

		// Token: 0x040015BF RID: 5567
		[global::Cpp2ILInjected.Token(Token = "0x40019BD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int _size;

		// Token: 0x040015C0 RID: 5568
		[global::Cpp2ILInjected.Token(Token = "0x40019BE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private int _growFactor;

		// Token: 0x040015C1 RID: 5569
		[global::Cpp2ILInjected.Token(Token = "0x40019BF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private int _version;

		// Token: 0x040015C2 RID: 5570
		[global::Cpp2ILInjected.Token(Token = "0x40019C0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		[global::System.NonSerialized]
		private object _syncRoot;

		// Token: 0x02000641 RID: 1601
		[global::Cpp2ILInjected.Token(Token = "0x20005F7")]
		[global::System.Serializable]
		private class QueueEnumerator : IEnumerator, global::System.ICloneable
		{
			// Token: 0x06004246 RID: 16966 RVA: 0x00020126 File Offset: 0x0001E326
			[global::Cpp2ILInjected.Token(Token = "0x6002E26")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C09F5C", Offset = "0x1C09F5C", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			internal QueueEnumerator(Queue q)
			{
				throw null;
			}

			// Token: 0x06004247 RID: 16967 RVA: 0x00020129 File Offset: 0x0001E329
			[global::Cpp2ILInjected.Token(Token = "0x6002E27")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0A0EC", Offset = "0x1C0A0EC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "MemberwiseClone", ReturnType = typeof(object))]
			public object Clone()
			{
				throw null;
			}

			// Token: 0x06004248 RID: 16968 RVA: 0x0002012C File Offset: 0x0001E32C
			[global::Cpp2ILInjected.Token(Token = "0x6002E28")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0A0F4", Offset = "0x1C0A0F4", Length = "0xC8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public virtual bool MoveNext()
			{
				throw null;
			}

			// Token: 0x17000799 RID: 1945
			// (get) Token: 0x06004249 RID: 16969 RVA: 0x0002012F File Offset: 0x0001E32F
			[global::Cpp2ILInjected.Token(Token = "0x17000724")]
			public virtual object Current
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002E29")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C0A1BC", Offset = "0x1C0A1BC", Length = "0x88")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0600424A RID: 16970 RVA: 0x00020132 File Offset: 0x0001E332
			[global::Cpp2ILInjected.Token(Token = "0x6002E2A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0A244", Offset = "0x1C0A244", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public virtual void Reset()
			{
				throw null;
			}

			// Token: 0x04001A7F RID: 6783
			[global::Cpp2ILInjected.Token(Token = "0x40019C1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private Queue _q;

			// Token: 0x04001A80 RID: 6784
			[global::Cpp2ILInjected.Token(Token = "0x40019C2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private int _index;

			// Token: 0x04001A81 RID: 6785
			[global::Cpp2ILInjected.Token(Token = "0x40019C3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
			private int _version;

			// Token: 0x04001A82 RID: 6786
			[global::Cpp2ILInjected.Token(Token = "0x40019C4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private object _currentElement;
		}

		// Token: 0x02000642 RID: 1602
		[global::Cpp2ILInjected.Token(Token = "0x20005F8")]
		internal class QueueDebugView
		{
		}
	}
}
