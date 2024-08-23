using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading
{
	// Token: 0x0200017E RID: 382
	[global::Cpp2ILInjected.Token(Token = "0x20001D1")]
	public class CancellationTokenSource : global::System.IDisposable
	{
		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000FD4 RID: 4052 RVA: 0x000171D1 File Offset: 0x000153D1
		[global::Cpp2ILInjected.Token(Token = "0x17000191")]
		public bool IsCancellationRequested
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001109")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C94638", Offset = "0x1C94638", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebOperation", Member = "get_Aborted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000FD5 RID: 4053 RVA: 0x000171D4 File Offset: 0x000153D4
		[global::Cpp2ILInjected.Token(Token = "0x17000192")]
		internal bool IsCancellationCompleted
		{
			[global::Cpp2ILInjected.Token(Token = "0x600110A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C96660", Offset = "0x1C96660", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06000FD6 RID: 4054 RVA: 0x000171D7 File Offset: 0x000153D7
		[global::Cpp2ILInjected.Token(Token = "0x17000193")]
		internal bool IsDisposed
		{
			[global::Cpp2ILInjected.Token(Token = "0x600110B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C96880", Offset = "0x1C96880", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000FD7 RID: 4055 RVA: 0x000171DA File Offset: 0x000153DA
		// (set) Token: 0x06000FD8 RID: 4056 RVA: 0x000171DD File Offset: 0x000153DD
		[global::Cpp2ILInjected.Token(Token = "0x17000194")]
		internal int ThreadIDExecutingCallbacks
		{
			[global::Cpp2ILInjected.Token(Token = "0x600110C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C9667C", Offset = "0x1C9667C", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600110D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C96888", Offset = "0x1C96888", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000FD9 RID: 4057 RVA: 0x000171E0 File Offset: 0x000153E0
		[global::Cpp2ILInjected.Token(Token = "0x17000195")]
		public CancellationToken Token
		{
			[global::Cpp2ILInjected.Token(Token = "0x600110E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C968AC", Offset = "0x1C968AC", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.Threading.AsyncActionDispatcher", Member = "LoaderThreadStart", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpWebRequest", Member = "RunWithTimeout", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
			{
				"System.Func`2<CancellationToken, Task`1<T>>",
				typeof(int),
				typeof(global::System.Action),
				"System.Func`1<Boolean>",
				typeof(CancellationToken)
			}, ReturnType = "System.Threading.Tasks.Task`1<T>")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpWebRequest", Member = "RunWithTimeout", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "System.Func`2<CancellationToken, Task`1<T>>" }, ReturnType = "System.Threading.Tasks.Task`1<T>")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.ServicePointScheduler.<WaitAsync>d__46", Member = "MoveNext", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebOperation.<Run>d__58", Member = "MoveNext", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebOperation", Member = "RegisterRequest", MemberParameters = new object[] { "System.Net.ServicePoint", "System.Net.WebConnection" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebRequestStream.<WriteChunkTrailer>d__40", Member = "MoveNext", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebResponseStream.<ReadAllAsync>d__48", Member = "MoveNext", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Concurrent.BlockingCollection`1", Member = "TryAddWithNoTimeValidation", MemberParameters = new object[]
			{
				"T",
				typeof(int),
				typeof(CancellationToken)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Concurrent.BlockingCollection`1", Member = "TryTakeWithNoTimeValidation", MemberParameters = new object[]
			{
				"T&",
				typeof(int),
				typeof(CancellationToken),
				typeof(CancellationTokenSource)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 15)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationTokenSource), Member = "ThrowIfDisposed", ReturnType = typeof(void))]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000FDA RID: 4058 RVA: 0x000171E3 File Offset: 0x000153E3
		[global::Cpp2ILInjected.Token(Token = "0x17000196")]
		internal CancellationCallbackInfo ExecutingCallback
		{
			[global::Cpp2ILInjected.Token(Token = "0x600110F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C96918", Offset = "0x1C96918", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000FDB RID: 4059 RVA: 0x000171E6 File Offset: 0x000153E6
		[global::Cpp2ILInjected.Token(Token = "0x6001110")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C96930", Offset = "0x1C96930", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.Threading.AsyncActionDispatcher", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpWebRequest", Member = "RunWithTimeout", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "System.Func`2<CancellationToken, Task`1<T>>" }, ReturnType = "System.Threading.Tasks.Task`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.ServicePointScheduler.<WaitAsync>d__46", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebRequestStream.<WriteChunkTrailer>d__40", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebResponseStream.<ReadAllAsync>d__48", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Concurrent.BlockingCollection`1", Member = "Initialize", MemberParameters = new object[]
		{
			"System.Collections.Concurrent.IProducerConsumerCollection`1<T>",
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public CancellationTokenSource()
		{
			throw null;
		}

		// Token: 0x06000FDC RID: 4060 RVA: 0x000171E9 File Offset: 0x000153E9
		[global::Cpp2ILInjected.Token(Token = "0x6001111")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C96964", Offset = "0x1C96964", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.Threading.AsyncActionDispatcher", Member = "Stop", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpWebRequest.<RunWithTimeoutWorker>d__241`1", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.ServicePointScheduler.<WaitAsync>d__46", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebOperation", Member = "Abort", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebOperation", Member = "CheckThrowDisposed", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(ref global::System.Runtime.ExceptionServices.ExceptionDispatchInfo)
		}, ReturnType = typeof(global::System.Runtime.ExceptionServices.ExceptionDispatchInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebRequestStream.<WriteChunkTrailer>d__40", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebResponseStream.<ReadAllAsync>d__48", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Concurrent.BlockingCollection`1", Member = "CancelWaitingConsumers", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationTokenSource), Member = "ThrowIfDisposed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationTokenSource), Member = "NotifyCancellation", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		public void Cancel()
		{
			throw null;
		}

		// Token: 0x06000FDD RID: 4061 RVA: 0x000171EC File Offset: 0x000153EC
		[global::Cpp2ILInjected.Token(Token = "0x6001112")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C96980", Offset = "0x1C96980", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationTokenSource), Member = "ThrowIfDisposed", ReturnType = typeof(void))]
		public void Cancel(bool throwOnFirstException)
		{
			throw null;
		}

		// Token: 0x06000FDE RID: 4062 RVA: 0x000171EF File Offset: 0x000153EF
		[global::Cpp2ILInjected.Token(Token = "0x6001113")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C96A58", Offset = "0x1C96A58", Length = "0x1D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebRequestStream.<WriteChunkTrailer>d__40", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationTokenSource), Member = "ThrowIfDisposed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Timer), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(TimerCallback),
			typeof(object),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Timer), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Timer), Member = "Change", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		public void CancelAfter(int millisecondsDelay)
		{
			throw null;
		}

		// Token: 0x06000FDF RID: 4063 RVA: 0x000171F2 File Offset: 0x000153F2
		[global::Cpp2ILInjected.Token(Token = "0x6001114")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C96C2C", Offset = "0x1C96C2C", Length = "0x114")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationTokenSource), Member = "ThrowIfDisposed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationTokenSource), Member = "NotifyCancellation", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private static void TimerCallbackLogic(object obj)
		{
			throw null;
		}

		// Token: 0x06000FE0 RID: 4064 RVA: 0x000171F5 File Offset: 0x000153F5
		[global::Cpp2ILInjected.Token(Token = "0x6001115")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C96D40", Offset = "0x1C96D40", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.Threading.AsyncActionDispatcher", Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpWebRequest.<RunWithTimeoutWorker>d__241`1", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.ServicePointScheduler.<WaitAsync>d__46", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebRequestStream.<WriteChunkTrailer>d__40", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebResponseStream.<ReadAllAsync>d__48", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Concurrent.BlockingCollection`1", Member = "TryAddWithNoTimeValidation", MemberParameters = new object[]
		{
			"T",
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Concurrent.BlockingCollection`1", Member = "TryTakeWithNoTimeValidation", MemberParameters = new object[]
		{
			"T&",
			typeof(int),
			typeof(CancellationToken),
			typeof(CancellationTokenSource)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.GC), Member = "SuppressFinalize", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x06000FE1 RID: 4065 RVA: 0x000171F8 File Offset: 0x000153F8
		[global::Cpp2ILInjected.Token(Token = "0x6001116")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C96DAC", Offset = "0x1C96DAC", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CancellationTokenSource.Linked1CancellationTokenSource), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CancellationTokenSource.Linked2CancellationTokenSource), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Timer), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WaitHandle), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected virtual void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x06000FE2 RID: 4066 RVA: 0x000171FB File Offset: 0x000153FB
		[global::Cpp2ILInjected.Token(Token = "0x6001117")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C968C4", Offset = "0x1C968C4", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CancellationTokenSource), Member = "get_Token", ReturnType = typeof(CancellationToken))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CancellationTokenSource), Member = "Cancel", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CancellationTokenSource), Member = "Cancel", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CancellationTokenSource), Member = "CancelAfter", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CancellationTokenSource), Member = "TimerCallbackLogic", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Threading.SemaphoreSlim.<WaitUntilCountOrTimeoutAsync>d__32", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationTokenSource), Member = "ThrowObjectDisposedException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal void ThrowIfDisposed()
		{
			throw null;
		}

		// Token: 0x06000FE3 RID: 4067 RVA: 0x000171FE File Offset: 0x000153FE
		[global::Cpp2ILInjected.Token(Token = "0x6001118")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C96E3C", Offset = "0x1C96E3C", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CancellationTokenSource), Member = "ThrowIfDisposed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ObjectDisposedException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static void ThrowObjectDisposedException()
		{
			throw null;
		}

		// Token: 0x06000FE4 RID: 4068 RVA: 0x00017201 File Offset: 0x00015401
		[global::Cpp2ILInjected.Token(Token = "0x6001119")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C949A4", Offset = "0x1C949A4", Length = "0x284")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CancellationToken), Member = "Register", MemberParameters = new object[]
		{
			typeof(global::System.Action<object>),
			typeof(object),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(CancellationTokenRegistration))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "get_CurrentManagedThreadId", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SparselyPopulatedArray<>), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SparselyPopulatedArray<>), Member = "Add", MemberParameters = new object[] { "T" }, ReturnType = "System.Threading.SparselyPopulatedArrayAddInfo`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationTokenRegistration), Member = "Unregister", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		internal CancellationTokenRegistration InternalRegister(global::System.Action<object> callback, object stateForCallback, SynchronizationContext targetSyncContext, ExecutionContext executionContext)
		{
			throw null;
		}

		// Token: 0x06000FE5 RID: 4069 RVA: 0x00017204 File Offset: 0x00015404
		[global::Cpp2ILInjected.Token(Token = "0x600111A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C969A8", Offset = "0x1C969A8", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Threading.CancellationTokenSource.LinkedNCancellationTokenSource.<>c", Member = "<.cctor>b__4_0", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CancellationTokenSource), Member = "Cancel", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CancellationTokenSource), Member = "TimerCallbackLogic", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Threading.SemaphoreSlim.<WaitUntilCountOrTimeoutAsync>d__32", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Timer), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "get_CurrentManagedThreadId", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationTokenSource), Member = "ExecuteCallbackHandlers", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void NotifyCancellation(bool throwOnFirstException)
		{
			throw null;
		}

		// Token: 0x06000FE6 RID: 4070 RVA: 0x00017207 File Offset: 0x00015407
		[global::Cpp2ILInjected.Token(Token = "0x600111B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C96F1C", Offset = "0x1C96F1C", Length = "0x490")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CancellationTokenSource), Member = "NotifyCancellation", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SparselyPopulatedArray<>), Member = "get_Tail", ReturnType = "System.Threading.SparselyPopulatedArrayFragment`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SparselyPopulatedArrayFragment<>), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SparselyPopulatedArrayFragment<>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationTokenSource), Member = "CancellationCallbackCoreWork", MemberParameters = new object[] { typeof(CancellationCallbackCoreWorkArguments) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SendOrPostCallback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "get_CurrentManagedThreadId", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.LowLevelListWithIList<>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.LowLevelList<>), Member = "Add", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SparselyPopulatedArrayFragment<>), Member = "get_Prev", ReturnType = "System.Threading.SparselyPopulatedArrayFragment`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "Exchange", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "MemoryBarrier", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.AggregateException), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Collections.Generic.IEnumerable<global::System.Exception>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 43)]
		private void ExecuteCallbackHandlers(bool throwOnFirstException)
		{
			throw null;
		}

		// Token: 0x06000FE7 RID: 4071 RVA: 0x0001720A File Offset: 0x0001540A
		[global::Cpp2ILInjected.Token(Token = "0x600111C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C97464", Offset = "0x1C97464", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationTokenSource), Member = "CancellationCallbackCoreWork", MemberParameters = new object[] { typeof(CancellationCallbackCoreWorkArguments) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void CancellationCallbackCoreWork_OnSyncContext(object obj)
		{
			throw null;
		}

		// Token: 0x06000FE8 RID: 4072 RVA: 0x0001720D File Offset: 0x0001540D
		[global::Cpp2ILInjected.Token(Token = "0x600111D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C973B8", Offset = "0x1C973B8", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CancellationTokenSource), Member = "ExecuteCallbackHandlers", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CancellationTokenSource), Member = "CancellationCallbackCoreWork_OnSyncContext", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SparselyPopulatedArrayFragment<>), Member = "SafeAtomicRemove", MemberParameters = new object[]
		{
			typeof(int),
			"T"
		}, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "get_CurrentManagedThreadId", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationCallbackInfo), Member = "ExecuteCallback", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void CancellationCallbackCoreWork(CancellationCallbackCoreWorkArguments args)
		{
			throw null;
		}

		// Token: 0x06000FE9 RID: 4073 RVA: 0x00017210 File Offset: 0x00015410
		[global::Cpp2ILInjected.Token(Token = "0x600111E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C975D0", Offset = "0x1C975D0", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Threading.SemaphoreSlim.<WaitUntilCountOrTimeoutAsync>d__32", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Concurrent.BlockingCollection`1", Member = "TryAddWithNoTimeValidation", MemberParameters = new object[]
		{
			"T",
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Concurrent.BlockingCollection`1", Member = "TryTakeWithNoTimeValidation", MemberParameters = new object[]
		{
			"T&",
			typeof(int),
			typeof(CancellationToken),
			typeof(CancellationTokenSource)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationTokenSource.Linked2CancellationTokenSource), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(CancellationToken),
			typeof(CancellationToken)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationTokenSource), Member = "CreateLinkedTokenSource", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(CancellationTokenSource))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationTokenSource.Linked1CancellationTokenSource), Member = ".ctor", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static CancellationTokenSource CreateLinkedTokenSource(CancellationToken token1, CancellationToken token2)
		{
			throw null;
		}

		// Token: 0x06000FEA RID: 4074 RVA: 0x00017213 File Offset: 0x00015413
		[global::Cpp2ILInjected.Token(Token = "0x600111F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9787C", Offset = "0x1C9787C", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CancellationTokenSource), Member = "CreateLinkedTokenSource", MemberParameters = new object[]
		{
			typeof(CancellationToken),
			typeof(CancellationToken)
		}, ReturnType = typeof(CancellationTokenSource))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpWebRequest", Member = "RunWithTimeout", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			"System.Func`2<CancellationToken, Task`1<T>>",
			typeof(int),
			typeof(global::System.Action),
			"System.Func`1<Boolean>",
			typeof(CancellationToken)
		}, ReturnType = "System.Threading.Tasks.Task`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebOperation", Member = ".ctor", MemberParameters = new object[]
		{
			"System.Net.HttpWebRequest",
			"System.Net.BufferOffsetSize",
			typeof(bool),
			typeof(CancellationToken)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationTokenSource.Linked1CancellationTokenSource), Member = ".ctor", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal static CancellationTokenSource CreateLinkedTokenSource(CancellationToken token)
		{
			throw null;
		}

		// Token: 0x06000FEB RID: 4075 RVA: 0x00017216 File Offset: 0x00015416
		[global::Cpp2ILInjected.Token(Token = "0x6001120")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C96694", Offset = "0x1C96694", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CancellationTokenRegistration), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpinWait), Member = "SpinOnceCore", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal void WaitForCallbackToComplete(CancellationCallbackInfo callbackInfo)
		{
			throw null;
		}

		// Token: 0x06000FEC RID: 4076 RVA: 0x00017219 File Offset: 0x00015419
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001121")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C97920", Offset = "0x1C97920", Length = "0x170")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlatformHelper), Member = "get_ProcessorCount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimerCallback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		static CancellationTokenSource()
		{
			throw null;
		}

		// Token: 0x0400072A RID: 1834
		[global::Cpp2ILInjected.Token(Token = "0x400092B")]
		internal static readonly CancellationTokenSource s_canceledSource;

		// Token: 0x0400072B RID: 1835
		[global::Cpp2ILInjected.Token(Token = "0x400092C")]
		internal static readonly CancellationTokenSource s_neverCanceledSource;

		// Token: 0x0400072C RID: 1836
		[global::Cpp2ILInjected.Token(Token = "0x400092D")]
		private static readonly int s_nLists;

		// Token: 0x0400072D RID: 1837
		[global::Cpp2ILInjected.Token(Token = "0x400092E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private ManualResetEvent _kernelEvent;

		// Token: 0x0400072E RID: 1838
		[global::Cpp2ILInjected.Token(Token = "0x400092F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private SparselyPopulatedArray<CancellationCallbackInfo>[] _registeredCallbacksLists;

		// Token: 0x0400072F RID: 1839
		[global::Cpp2ILInjected.Token(Token = "0x4000930")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int _state;

		// Token: 0x04000730 RID: 1840
		[global::Cpp2ILInjected.Token(Token = "0x4000931")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private int _threadIDExecutingCallbacks;

		// Token: 0x04000731 RID: 1841
		[global::Cpp2ILInjected.Token(Token = "0x4000932")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private bool _disposed;

		// Token: 0x04000732 RID: 1842
		[global::Cpp2ILInjected.Token(Token = "0x4000933")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private CancellationCallbackInfo _executingCallback;

		// Token: 0x04000733 RID: 1843
		[global::Cpp2ILInjected.Token(Token = "0x4000934")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private Timer _timer;

		// Token: 0x04000734 RID: 1844
		[global::Cpp2ILInjected.Token(Token = "0x4000935")]
		private static readonly TimerCallback s_timerCallback;

		// Token: 0x020005A1 RID: 1441
		[global::Cpp2ILInjected.Token(Token = "0x20001D2")]
		private sealed class Linked1CancellationTokenSource : CancellationTokenSource
		{
			// Token: 0x06004015 RID: 16405 RVA: 0x0001FAF6 File Offset: 0x0001DCF6
			[global::Cpp2ILInjected.Token(Token = "0x6001122")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C97698", Offset = "0x1C97698", Length = "0xD8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CancellationTokenSource), Member = "CreateLinkedTokenSource", MemberParameters = new object[]
			{
				typeof(CancellationToken),
				typeof(CancellationToken)
			}, ReturnType = typeof(CancellationTokenSource))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CancellationTokenSource), Member = "CreateLinkedTokenSource", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(CancellationTokenSource))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = "Register", MemberParameters = new object[]
			{
				typeof(global::System.Action<object>),
				typeof(object),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(CancellationTokenRegistration))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			internal Linked1CancellationTokenSource(CancellationToken token1)
			{
				throw null;
			}

			// Token: 0x06004016 RID: 16406 RVA: 0x0001FAF9 File Offset: 0x0001DCF9
			[global::Cpp2ILInjected.Token(Token = "0x6001123")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C97A90", Offset = "0x1C97A90", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationTokenRegistration), Member = "Dispose", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationTokenSource), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			protected override void Dispose(bool disposing)
			{
				throw null;
			}

			// Token: 0x0400188C RID: 6284
			[global::Cpp2ILInjected.Token(Token = "0x4000936")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			private readonly CancellationTokenRegistration _reg1;
		}

		// Token: 0x020005A2 RID: 1442
		[global::Cpp2ILInjected.Token(Token = "0x20001D3")]
		private sealed class Linked2CancellationTokenSource : CancellationTokenSource
		{
			// Token: 0x06004017 RID: 16407 RVA: 0x0001FAFC File Offset: 0x0001DCFC
			[global::Cpp2ILInjected.Token(Token = "0x6001124")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C97770", Offset = "0x1C97770", Length = "0x10C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CancellationTokenSource), Member = "CreateLinkedTokenSource", MemberParameters = new object[]
			{
				typeof(CancellationToken),
				typeof(CancellationToken)
			}, ReturnType = typeof(CancellationTokenSource))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = "Register", MemberParameters = new object[]
			{
				typeof(global::System.Action<object>),
				typeof(object),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(CancellationTokenRegistration))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			internal Linked2CancellationTokenSource(CancellationToken token1, CancellationToken token2)
			{
				throw null;
			}

			// Token: 0x06004018 RID: 16408 RVA: 0x0001FAFF File Offset: 0x0001DCFF
			[global::Cpp2ILInjected.Token(Token = "0x6001125")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C97AC4", Offset = "0x1C97AC4", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationTokenRegistration), Member = "Dispose", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationTokenSource), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			protected override void Dispose(bool disposing)
			{
				throw null;
			}

			// Token: 0x0400188D RID: 6285
			[global::Cpp2ILInjected.Token(Token = "0x4000937")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			private readonly CancellationTokenRegistration _reg1;

			// Token: 0x0400188E RID: 6286
			[global::Cpp2ILInjected.Token(Token = "0x4000938")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
			private readonly CancellationTokenRegistration _reg2;
		}

		// Token: 0x020005A3 RID: 1443
		[global::Cpp2ILInjected.Token(Token = "0x20001D4")]
		private sealed class LinkedNCancellationTokenSource : CancellationTokenSource
		{
			// Token: 0x06004019 RID: 16409 RVA: 0x0001FB02 File Offset: 0x0001DD02
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6001126")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C97B00", Offset = "0x1C97B00", Length = "0xC4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Action<object>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(global::System.IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			static LinkedNCancellationTokenSource()
			{
				throw null;
			}

			// Token: 0x0400188F RID: 6287
			[global::Cpp2ILInjected.Token(Token = "0x4000939")]
			internal static readonly global::System.Action<object> s_linkedTokenCancelDelegate;

			// Token: 0x020006AE RID: 1710
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x20001D5")]
			[global::System.Serializable]
			private sealed class <>c
			{
				// Token: 0x0600436D RID: 17261 RVA: 0x00020495 File Offset: 0x0001E695
				// Note: this type is marked as 'beforefieldinit'.
				[global::Cpp2ILInjected.Token(Token = "0x6001127")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C97BC4", Offset = "0x1C97BC4", Length = "0x5C")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				static <>c()
				{
					throw null;
				}

				// Token: 0x0600436E RID: 17262 RVA: 0x00020498 File Offset: 0x0001E698
				[global::Cpp2ILInjected.Token(Token = "0x6001128")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C97C20", Offset = "0x1C97C20", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c()
				{
					throw null;
				}

				// Token: 0x0600436F RID: 17263 RVA: 0x0002049B File Offset: 0x0001E69B
				[global::Cpp2ILInjected.Token(Token = "0x6001129")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C97C28", Offset = "0x1C97C28", Length = "0x80")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationTokenSource), Member = "NotifyCancellation", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				internal void <.cctor>b__4_0(object s)
				{
					throw null;
				}

				// Token: 0x04001B3C RID: 6972
				[global::Cpp2ILInjected.Token(Token = "0x400093A")]
				public static readonly CancellationTokenSource.LinkedNCancellationTokenSource.<>c <>9;
			}
		}
	}
}
