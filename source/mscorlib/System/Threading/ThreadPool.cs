using System;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Lifetime;
using System.Runtime.Remoting.Messaging;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading
{
	[global::Cpp2ILInjected.Token(Token = "0x2000207")]
	public static class ThreadPool
	{
		[global::Cpp2ILInjected.Token(Token = "0x600125B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA0224", Offset = "0x1CA0224", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Program", Member = "LaunchGame", MemberParameters = new object[]
		{
			"System.String[]",
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static bool SetMinThreads(int workerThreads, int completionPortThreads)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600125C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA022C", Offset = "0x1CA022C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NclUtilities", Member = "IsThreadPoolLow", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static void GetAvailableThreads(out int workerThreads, out int completionPortThreads)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600125D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA0234", Offset = "0x1CA0234", Length = "0x1C4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadPool), Member = "RegisterWaitForSingleObject", MemberParameters = new object[]
		{
			typeof(WaitHandle),
			typeof(WaitOrTimerCallback),
			typeof(object),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(RegisteredWaitHandle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadPool), Member = "RegisterWaitForSingleObject", MemberParameters = new object[]
		{
			typeof(WaitHandle),
			typeof(WaitOrTimerCallback),
			typeof(object),
			typeof(global::System.TimeSpan),
			typeof(bool)
		}, ReturnType = typeof(RegisteredWaitHandle))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegisteredWaitHandle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(WaitHandle),
			typeof(WaitOrTimerCallback),
			typeof(object),
			typeof(global::System.TimeSpan),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WaitCallback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadPool), Member = "QueueUserWorkItem", MemberParameters = new object[]
		{
			typeof(WaitCallback),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadPool), Member = "UnsafeQueueUserWorkItem", MemberParameters = new object[]
		{
			typeof(WaitCallback),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, uint millisecondsTimeOutInterval, bool executeOnlyOnce, ref StackCrawlMark stackMark, bool compressStack)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600125E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA04F4", Offset = "0x1CA04F4", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Diagnostics.Process", Member = "EnsureWatchingForExit", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadPool), Member = "RegisterWaitForSingleObject", MemberParameters = new object[]
		{
			typeof(WaitHandle),
			typeof(WaitOrTimerCallback),
			typeof(object),
			typeof(uint),
			typeof(bool),
			typeof(ref StackCrawlMark),
			typeof(bool)
		}, ReturnType = typeof(RegisteredWaitHandle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		[MethodImpl(8)]
		public static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, int millisecondsTimeOutInterval, bool executeOnlyOnce)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600125F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA0574", Offset = "0x1CA0574", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Lifetime.Lease), Member = "CheckNextSponsor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = "get_TotalMilliseconds", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadPool), Member = "RegisterWaitForSingleObject", MemberParameters = new object[]
		{
			typeof(WaitHandle),
			typeof(WaitOrTimerCallback),
			typeof(object),
			typeof(uint),
			typeof(bool),
			typeof(ref StackCrawlMark),
			typeof(bool)
		}, ReturnType = typeof(RegisteredWaitHandle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		[MethodImpl(8)]
		public static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, global::System.TimeSpan timeout, bool executeOnlyOnce)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001260")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA04A4", Offset = "0x1CA04A4", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen", Member = "RenameWorld", MemberParameters = new object[]
		{
			"Terraria.IO.WorldFileData",
			typeof(string),
			"System.Action`1<String>"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SynchronizationContext), Member = "Post", MemberParameters = new object[]
		{
			typeof(SendOrPostCallback),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadPool), Member = "RegisterWaitForSingleObject", MemberParameters = new object[]
		{
			typeof(WaitHandle),
			typeof(WaitOrTimerCallback),
			typeof(object),
			typeof(uint),
			typeof(bool),
			typeof(ref StackCrawlMark),
			typeof(bool)
		}, ReturnType = typeof(RegisteredWaitHandle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegisteredWaitHandle), Member = "Wait", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Channels.CrossAppDomainSink), Member = "AsyncProcessMessage", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Remoting.Messaging.IMessage),
			typeof(global::System.Runtime.Remoting.Messaging.IMessageSink)
		}, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessageCtrl))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.StackBuilderSink), Member = "AsyncProcessMessage", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Remoting.Messaging.IMessage),
			typeof(global::System.Runtime.Remoting.Messaging.IMessageSink)
		}, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessageCtrl))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.CompilerServices.AsyncMethodBuilderCore), Member = "ThrowAsync", MemberParameters = new object[]
		{
			typeof(global::System.Exception),
			typeof(SynchronizationContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FileWebRequest", Member = "BeginGetRequestStream", MemberParameters = new object[]
		{
			typeof(global::System.AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(global::System.IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FileWebRequest", Member = "BeginGetResponse", MemberParameters = new object[]
		{
			typeof(global::System.AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(global::System.IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadPool), Member = "QueueUserWorkItemHelper", MemberParameters = new object[]
		{
			typeof(WaitCallback),
			typeof(object),
			typeof(ref StackCrawlMark),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[MethodImpl(8)]
		public static bool QueueUserWorkItem(WaitCallback callBack, object state)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001261")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA0774", Offset = "0x1CA0774", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.LazyAsyncResult", Member = "Complete", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadPool), Member = "QueueUserWorkItemHelper", MemberParameters = new object[]
		{
			typeof(WaitCallback),
			typeof(object),
			typeof(ref StackCrawlMark),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[MethodImpl(8)]
		public static bool QueueUserWorkItem(WaitCallback callBack)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001262")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA04CC", Offset = "0x1CA04CC", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadPool), Member = "RegisterWaitForSingleObject", MemberParameters = new object[]
		{
			typeof(WaitHandle),
			typeof(WaitOrTimerCallback),
			typeof(object),
			typeof(uint),
			typeof(bool),
			typeof(ref StackCrawlMark),
			typeof(bool)
		}, ReturnType = typeof(RegisteredWaitHandle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Threading.Timer.Scheduler", Member = "FireTimer", MemberParameters = new object[] { typeof(Timer) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.UnwrapPromise<>), Member = "InvokeCoreAsync", MemberParameters = new object[] { typeof(global::System.Threading.Tasks.Task) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.ListenerAsyncResult", Member = "Complete", MemberParameters = new object[] { typeof(global::System.Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.ListenerAsyncResult", Member = "Complete", MemberParameters = new object[]
		{
			"System.Net.HttpListenerContext",
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.SocketAsyncResult", Member = "Complete", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadPool), Member = "QueueUserWorkItemHelper", MemberParameters = new object[]
		{
			typeof(WaitCallback),
			typeof(object),
			typeof(ref StackCrawlMark),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[MethodImpl(8)]
		public static bool UnsafeQueueUserWorkItem(WaitCallback callBack, object state)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001263")]
		[global::Cpp2ILInjected.Address(RVA = "0x15A12D8", Offset = "0x15A12D8", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket.AwaitableSocketAsyncEventArgs", Member = "InvokeContinuation", MemberParameters = new object[]
		{
			"System.Action`1<Object>",
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WaitCallback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadPool), Member = "QueueUserWorkItemHelper", MemberParameters = new object[]
		{
			typeof(WaitCallback),
			typeof(object),
			typeof(ref StackCrawlMark),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static bool QueueUserWorkItem<TState>(global::System.Action<TState> callBack, TState state, bool preferLocal)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001264")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA0664", Offset = "0x1CA0664", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadPool), Member = "QueueUserWorkItem", MemberParameters = new object[]
		{
			typeof(WaitCallback),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadPool), Member = "QueueUserWorkItem", MemberParameters = new object[] { typeof(WaitCallback) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadPool), Member = "UnsafeQueueUserWorkItem", MemberParameters = new object[]
		{
			typeof(WaitCallback),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadPool), Member = "QueueUserWorkItem", MemberTypeParameters = new object[] { "TState" }, MemberParameters = new object[]
		{
			"System.Action`1<TState>",
			"TState",
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadPool), Member = "EnsureVMInitialized", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(QueueUserWorkItemCallback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(WaitCallback),
			typeof(object),
			typeof(bool),
			typeof(ref StackCrawlMark)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadPoolWorkQueue), Member = "Enqueue", MemberParameters = new object[]
		{
			typeof(IThreadPoolWorkItem),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private static bool QueueUserWorkItemHelper(WaitCallback callBack, object state, ref StackCrawlMark stackMark, bool compressStack, bool forceGlobal = true)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001265")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA0834", Offset = "0x1CA0834", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SemaphoreSlim), Member = "Release", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SemaphoreSlim), Member = "QueueWaiterTask", MemberParameters = new object[] { "System.Threading.SemaphoreSlim.TaskNode" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.Task), Member = "FinishContinuations", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.AwaitTaskContinuation), Member = "Run", MemberParameters = new object[]
		{
			typeof(global::System.Threading.Tasks.Task),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.AwaitTaskContinuation), Member = "UnsafeScheduleAction", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.ThreadPoolTaskScheduler), Member = "QueueTask", MemberParameters = new object[] { typeof(global::System.Threading.Tasks.Task) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadPool), Member = "EnsureVMInitialized", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadPoolWorkQueue), Member = "Enqueue", MemberParameters = new object[]
		{
			typeof(IThreadPoolWorkItem),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static void UnsafeQueueCustomWorkItem(IThreadPoolWorkItem workItem, bool forceGlobal)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001266")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA08A8", Offset = "0x1CA08A8", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.ThreadPoolTaskScheduler), Member = "TryExecuteTaskInline", MemberParameters = new object[]
		{
			typeof(global::System.Threading.Tasks.Task),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.ThreadPoolTaskScheduler), Member = "TryDequeue", MemberParameters = new object[] { typeof(global::System.Threading.Tasks.Task) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadPoolWorkQueue), Member = "LocalFindAndPop", MemberParameters = new object[] { typeof(IThreadPoolWorkItem) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal static bool TryPopCustomWorkItem(IThreadPoolWorkItem workItem)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001267")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9E860", Offset = "0x1C9E860", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal static extern bool RequestWorkerThread();

		[global::Cpp2ILInjected.Token(Token = "0x6001268")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA07A0", Offset = "0x1CA07A0", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadPool), Member = "QueueUserWorkItemHelper", MemberParameters = new object[]
		{
			typeof(WaitCallback),
			typeof(object),
			typeof(ref StackCrawlMark),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadPool), Member = "UnsafeQueueCustomWorkItem", MemberParameters = new object[]
		{
			typeof(IThreadPoolWorkItem),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadPool), Member = "NotifyWorkItemProgress", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.ThreadPoolTaskScheduler), Member = "NotifyWorkItemProgress", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static void EnsureVMInitialized()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001269")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA0228", Offset = "0x1CA0228", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern bool SetMinThreadsNative(int workerThreads, int completionPortThreads);

		[global::Cpp2ILInjected.Token(Token = "0x600126A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA0230", Offset = "0x1CA0230", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern void GetAvailableThreadsNative(out int workerThreads, out int completionPortThreads);

		[global::Cpp2ILInjected.Token(Token = "0x600126B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9F9F8", Offset = "0x1C9F9F8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal static extern bool NotifyWorkItemComplete();

		[global::Cpp2ILInjected.Token(Token = "0x600126C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA0934", Offset = "0x1CA0934", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal static extern void ReportThreadStatus(bool isWorking);

		[global::Cpp2ILInjected.Token(Token = "0x600126D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA093C", Offset = "0x1CA093C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadPool), Member = "EnsureVMInitialized", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal static void NotifyWorkItemProgress()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600126E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA094C", Offset = "0x1CA094C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal static extern void NotifyWorkItemProgressNative();

		[global::Cpp2ILInjected.Token(Token = "0x600126F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9EE34", Offset = "0x1C9EE34", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal static extern void NotifyWorkItemQueued();

		[global::Cpp2ILInjected.Token(Token = "0x6001270")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA0930", Offset = "0x1CA0930", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern void InitializeVMTp(ref bool enableWorkerTracking);

		[global::Cpp2ILInjected.Token(Token = "0x170001C0")]
		internal static bool IsThreadPoolThread
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001271")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CA0950", Offset = "0x1CA0950", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_IsThreadPoolThread", ReturnType = typeof(bool))]
			get
			{
				throw null;
			}
		}

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000208")]
		private sealed class <>c__DisplayClass17_0<TState>
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001272")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B2524", Offset = "0x15B2524", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass17_0()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6001273")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B252C", Offset = "0x15B252C", Length = "0x90")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			internal void <QueueUserWorkItem>b__0(object x)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x40009CD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public global::System.Action<TState> callBack;
		}
	}
}
