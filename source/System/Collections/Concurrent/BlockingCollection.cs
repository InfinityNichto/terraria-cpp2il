using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Collections.Concurrent
{
	// Token: 0x0200030D RID: 781
	[DebuggerTypeProxy(typeof(BlockingCollectionDebugView<>))]
	[DebuggerDisplay("Count = {Count}, Type = {_collection}")]
	[global::Cpp2ILInjected.Token(Token = "0x2000429")]
	public class BlockingCollection<T> : IEnumerable<T>, IEnumerable, ICollection, IDisposable, IReadOnlyCollection<T>
	{
		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x060019D6 RID: 6614 RVA: 0x000076DF File Offset: 0x000058DF
		[global::Cpp2ILInjected.Token(Token = "0x1700067B")]
		public bool IsAddingCompleted
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001CDF")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E7C24", Offset = "0x18E7C24", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x060019D7 RID: 6615 RVA: 0x000076E2 File Offset: 0x000058E2
		[global::Cpp2ILInjected.Token(Token = "0x1700067C")]
		public bool IsCompleted
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001CE0")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E7C5C", Offset = "0x18E7C5C", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SemaphoreSlim), Member = "get_CurrentCount", ReturnType = typeof(int))]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x060019D8 RID: 6616 RVA: 0x000076E5 File Offset: 0x000058E5
		[global::Cpp2ILInjected.Token(Token = "0x1700067D")]
		public int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001CE1")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E7CC4", Offset = "0x18E7CC4", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.Threading.AsyncActionDispatcher", Member = "get_ActionsRemaining", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SemaphoreSlim), Member = "get_CurrentCount", ReturnType = typeof(int))]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x060019D9 RID: 6617 RVA: 0x000076E8 File Offset: 0x000058E8
		[global::Cpp2ILInjected.Token(Token = "0x1700067E")]
		private bool System.Collections.ICollection.IsSynchronized
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001CE2")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E7CF0", Offset = "0x18E7CF0", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x060019DA RID: 6618 RVA: 0x000076EB File Offset: 0x000058EB
		[global::Cpp2ILInjected.Token(Token = "0x1700067F")]
		private object System.Collections.ICollection.SyncRoot
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001CE3")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E7D14", Offset = "0x18E7D14", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060019DB RID: 6619 RVA: 0x000076EE File Offset: 0x000058EE
		[global::Cpp2ILInjected.Token(Token = "0x6001CE4")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E7D60", Offset = "0x18E7D60", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.Threading.AsyncActionDispatcher", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.OS.Windows.STATaskInvoker", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public BlockingCollection()
		{
			throw null;
		}

		// Token: 0x060019DC RID: 6620 RVA: 0x000076F1 File Offset: 0x000058F1
		[global::Cpp2ILInjected.Token(Token = "0x6001CE5")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E7DD4", Offset = "0x18E7DD4", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public BlockingCollection(IProducerConsumerCollection<T> collection)
		{
			throw null;
		}

		// Token: 0x060019DD RID: 6621 RVA: 0x000076F4 File Offset: 0x000058F4
		[global::Cpp2ILInjected.Token(Token = "0x6001CE6")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E7EF8", Offset = "0x18E7EF8", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationTokenSource), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SemaphoreSlim), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void Initialize(IProducerConsumerCollection<T> collection, int boundedCapacity, int collectionCount)
		{
			throw null;
		}

		// Token: 0x060019DE RID: 6622 RVA: 0x000076F7 File Offset: 0x000058F7
		[global::Cpp2ILInjected.Token(Token = "0x6001CE7")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E7FEC", Offset = "0x18E7FEC", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.Threading.AsyncActionDispatcher", Member = "Queue", MemberParameters = new object[] { typeof(Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.OS.Windows.STATaskInvoker", Member = "InvokeAndWait", MemberParameters = new object[] { typeof(Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Add(T item)
		{
			throw null;
		}

		// Token: 0x060019DF RID: 6623 RVA: 0x000076FA File Offset: 0x000058FA
		[global::Cpp2ILInjected.Token(Token = "0x6001CE8")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E8008", Offset = "0x18E8008", Length = "0x620")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SemaphoreSlim), Member = "Wait", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationTokenSource), Member = "get_Token", ReturnType = typeof(CancellationToken))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationTokenSource), Member = "CreateLinkedTokenSource", MemberParameters = new object[]
		{
			typeof(CancellationToken),
			typeof(CancellationToken)
		}, ReturnType = typeof(CancellationTokenSource))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SemaphoreSlim), Member = "Wait", MemberParameters = new object[]
		{
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationTokenSource), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpinWait), Member = "SpinOnce", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpinWait), Member = "Reset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = "ThrowIfCancellationRequested", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "Decrement", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OperationCanceledException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(CancellationToken)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 60)]
		private bool TryAddWithNoTimeValidation(T item, int millisecondsTimeout, CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x060019E0 RID: 6624 RVA: 0x000076FD File Offset: 0x000058FD
		[global::Cpp2ILInjected.Token(Token = "0x6001CE9")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E8628", Offset = "0x18E8628", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.OS.Windows.STATaskInvoker", Member = "TaskThreadStart", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = "get_None", ReturnType = typeof(CancellationToken))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public T Take()
		{
			throw null;
		}

		// Token: 0x060019E1 RID: 6625 RVA: 0x00007700 File Offset: 0x00005900
		[global::Cpp2ILInjected.Token(Token = "0x6001CEA")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E8704", Offset = "0x18E8704", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.Threading.AsyncActionDispatcher", Member = "LoaderThreadStart", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public T Take(CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x060019E2 RID: 6626 RVA: 0x00007703 File Offset: 0x00005903
		[global::Cpp2ILInjected.Token(Token = "0x6001CEB")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E878C", Offset = "0x18E878C", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public bool TryTake(out T item, int millisecondsTimeout, CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x060019E3 RID: 6627 RVA: 0x00007706 File Offset: 0x00005906
		[global::Cpp2ILInjected.Token(Token = "0x6001CEC")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E87F8", Offset = "0x18E87F8", Length = "0x534")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SemaphoreSlim), Member = "Wait", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationTokenSource), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = "ThrowIfCancellationRequested", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationTokenSource), Member = "get_Token", ReturnType = typeof(CancellationToken))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationTokenSource), Member = "CreateLinkedTokenSource", MemberParameters = new object[]
		{
			typeof(CancellationToken),
			typeof(CancellationToken)
		}, ReturnType = typeof(CancellationTokenSource))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SemaphoreSlim), Member = "Wait", MemberParameters = new object[]
		{
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OperationCanceledException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(CancellationToken)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 36)]
		private bool TryTakeWithNoTimeValidation(out T item, int millisecondsTimeout, CancellationToken cancellationToken, CancellationTokenSource combinedTokenSource)
		{
			throw null;
		}

		// Token: 0x060019E4 RID: 6628 RVA: 0x00007709 File Offset: 0x00005909
		[global::Cpp2ILInjected.Token(Token = "0x6001CED")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E8D2C", Offset = "0x18E8D2C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationTokenSource), Member = "Cancel", ReturnType = typeof(void))]
		private void CancelWaitingConsumers()
		{
			throw null;
		}

		// Token: 0x060019E5 RID: 6629 RVA: 0x0000770C File Offset: 0x0000590C
		[global::Cpp2ILInjected.Token(Token = "0x6001CEE")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E8D38", Offset = "0x18E8D38", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.Threading.AsyncActionDispatcher", Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.OS.Windows.STATaskInvoker", Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x060019E6 RID: 6630 RVA: 0x0000770F File Offset: 0x0000590F
		[global::Cpp2ILInjected.Token(Token = "0x6001CEF")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E8DA4", Offset = "0x18E8DA4", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SemaphoreSlim), Member = "Dispose", ReturnType = typeof(void))]
		protected virtual void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x060019E7 RID: 6631 RVA: 0x00007712 File Offset: 0x00005912
		[global::Cpp2ILInjected.Token(Token = "0x6001CF0")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E8DE0", Offset = "0x18E8DE0", Length = "0x338")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 47)]
		private void System.Collections.ICollection.CopyTo(Array array, int index)
		{
			throw null;
		}

		// Token: 0x060019E8 RID: 6632 RVA: 0x00007715 File Offset: 0x00005915
		[global::Cpp2ILInjected.Token(Token = "0x6001CF1")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E9118", Offset = "0x18E9118", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
		{
			throw null;
		}

		// Token: 0x060019E9 RID: 6633 RVA: 0x00007718 File Offset: 0x00005918
		[global::Cpp2ILInjected.Token(Token = "0x6001CF2")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E91BC", Offset = "0x18E91BC", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw null;
		}

		// Token: 0x060019EA RID: 6634 RVA: 0x0000771B File Offset: 0x0000591B
		[global::Cpp2ILInjected.Token(Token = "0x6001CF3")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E923C", Offset = "0x18E923C", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(IFormatProvider),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private static void ValidateMillisecondsTimeout(int millisecondsTimeout)
		{
			throw null;
		}

		// Token: 0x060019EB RID: 6635 RVA: 0x0000771E File Offset: 0x0000591E
		[global::Cpp2ILInjected.Token(Token = "0x6001CF4")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E9320", Offset = "0x18E9320", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void CheckDisposed()
		{
			throw null;
		}

		// Token: 0x04000F73 RID: 3955
		[global::Cpp2ILInjected.Token(Token = "0x40013CC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private IProducerConsumerCollection<T> _collection;

		// Token: 0x04000F74 RID: 3956
		[global::Cpp2ILInjected.Token(Token = "0x40013CD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int _boundedCapacity;

		// Token: 0x04000F75 RID: 3957
		[global::Cpp2ILInjected.Token(Token = "0x40013CE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private SemaphoreSlim _freeNodes;

		// Token: 0x04000F76 RID: 3958
		[global::Cpp2ILInjected.Token(Token = "0x40013CF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private SemaphoreSlim _occupiedNodes;

		// Token: 0x04000F77 RID: 3959
		[global::Cpp2ILInjected.Token(Token = "0x40013D0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private bool _isDisposed;

		// Token: 0x04000F78 RID: 3960
		[global::Cpp2ILInjected.Token(Token = "0x40013D1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private CancellationTokenSource _consumersCancellationTokenSource;

		// Token: 0x04000F79 RID: 3961
		[global::Cpp2ILInjected.Token(Token = "0x40013D2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private CancellationTokenSource _producersCancellationTokenSource;

		// Token: 0x04000F7A RID: 3962
		[global::Cpp2ILInjected.Token(Token = "0x40013D3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int _currentAdders;
	}
}
