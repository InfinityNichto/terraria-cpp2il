using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading
{
	[global::System.Diagnostics.DebuggerDisplay("Current Count = {m_currentCount}")]
	[global::System.Runtime.InteropServices.ComVisible(false)]
	[global::Cpp2ILInjected.Token(Token = "0x20001DE")]
	public class SemaphoreSlim : global::System.IDisposable
	{
		[global::Cpp2ILInjected.Token(Token = "0x1700019D")]
		public int CurrentCount
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001140")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C97FC4", Offset = "0x1C97FC4", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Concurrent.BlockingCollection`1", Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Concurrent.BlockingCollection`1", Member = "get_Count", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001141")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C97FDC", Offset = "0x1C97FDC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Concurrent.BlockingCollection`1", Member = "Initialize", MemberParameters = new object[]
		{
			"System.Collections.Concurrent.IProducerConsumerCollection`1<T>",
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public SemaphoreSlim(int initialCount)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001142")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C97FE4", Offset = "0x1C97FE4", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.CryptoStream.<>c", Member = "<get_AsyncActiveSemaphore>b__54_0", ReturnType = typeof(SemaphoreSlim))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IO.Stream.<>c", Member = "<EnsureAsyncActiveSemaphoreInitialized>b__4_0", ReturnType = typeof(SemaphoreSlim))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket", Member = ".ctor", MemberParameters = new object[] { "System.Net.Sockets.AddressFamily", "System.Net.Sockets.SocketType", "System.Net.Sockets.ProtocolType" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket", Member = ".ctor", MemberParameters = new object[] { "System.Net.Sockets.AddressFamily", "System.Net.Sockets.SocketType", "System.Net.Sockets.ProtocolType", "System.Net.Sockets.SafeSocketHandle" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SemaphoreSlim), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		public SemaphoreSlim(int initialCount, int maxCount)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001143")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C98170", Offset = "0x1C98170", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Stream), Member = "BeginReadInternal", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(global::System.AsyncCallback),
			typeof(object),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(global::System.IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Stream), Member = "BeginWriteInternal", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(global::System.AsyncCallback),
			typeof(object),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(global::System.IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public void Wait()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001144")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C98648", Offset = "0x1C98648", Length = "0x8")]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SemaphoreSlim), Member = "Wait", MemberParameters = new object[]
		{
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(bool))]
		public bool Wait(int millisecondsTimeout)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001145")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9817C", Offset = "0x1C9817C", Length = "0x4CC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SemaphoreSlim), Member = "Wait", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SemaphoreSlim), Member = "CheckDispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = "ThrowIfCancellationRequested", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "get_TickCount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = "Register", MemberParameters = new object[]
		{
			typeof(global::System.Action<object>),
			typeof(object),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(CancellationTokenRegistration))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpinWait), Member = "get_NextSpinWillYield", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpinWait), Member = "SpinOnceCore", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SemaphoreSlim), Member = "WaitAsync", MemberParameters = new object[]
		{
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(global::System.Threading.Tasks.Task<bool>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SemaphoreSlim), Member = "WaitUntilCountOrTimeout", MemberParameters = new object[]
		{
			typeof(int),
			typeof(uint),
			typeof(CancellationToken)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventWaitHandle), Member = "Reset", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationTokenRegistration), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task<bool>), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.TaskAwaiter<bool>), Member = "GetResult", ReturnType = "TResult")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SemaphoreSlim), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 46)]
		public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001146")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C989A4", Offset = "0x1C989A4", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SemaphoreSlim), Member = "Wait", MemberParameters = new object[]
		{
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = "ThrowIfCancellationRequested", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "get_TickCount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Wait", MemberParameters = new object[]
		{
			typeof(object),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private bool WaitUntilCountOrTimeout(int millisecondsTimeout, uint startTime, CancellationToken cancellationToken)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001147")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C98A90", Offset = "0x1C98A90", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.CryptoStream.<ReadAsyncInternal>d__37", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.CryptoStream.<WriteAsyncInternal>d__46", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Stream), Member = "BeginReadInternal", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(global::System.AsyncCallback),
			typeof(object),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(global::System.IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Stream), Member = "BeginWriteInternal", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(global::System.AsyncCallback),
			typeof(object),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(global::System.IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket", Member = "QueueIOSelectorJob", MemberParameters = new object[]
		{
			typeof(SemaphoreSlim),
			typeof(global::System.IntPtr),
			"System.IOSelectorJob"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SemaphoreSlim), Member = "WaitAsync", MemberParameters = new object[]
		{
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(global::System.Threading.Tasks.Task<bool>))]
		public global::System.Threading.Tasks.Task WaitAsync()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001148")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C986CC", Offset = "0x1C986CC", Length = "0x2D8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SemaphoreSlim), Member = "Wait", MemberParameters = new object[]
		{
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SemaphoreSlim), Member = "WaitAsync", ReturnType = typeof(global::System.Threading.Tasks.Task))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SemaphoreSlim), Member = "CheckDispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task), Member = "FromCancellation", MemberTypeParameters = new object[] { "TResult" }, MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventWaitHandle), Member = "Reset", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SemaphoreSlim), Member = "CreateAndAddAsyncWaiter", ReturnType = typeof(SemaphoreSlim.TaskNode))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SemaphoreSlim), Member = "WaitUntilCountOrTimeoutAsync", MemberParameters = new object[]
		{
			typeof(SemaphoreSlim.TaskNode),
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(global::System.Threading.Tasks.Task<bool>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SemaphoreSlim), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 31)]
		public global::System.Threading.Tasks.Task<bool> WaitAsync(int millisecondsTimeout, CancellationToken cancellationToken)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001149")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C98A9C", Offset = "0x1C98A9C", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SemaphoreSlim), Member = "WaitAsync", MemberParameters = new object[]
		{
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(global::System.Threading.Tasks.Task<bool>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SemaphoreSlim.TaskNode), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private SemaphoreSlim.TaskNode CreateAndAddAsyncWaiter()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600114A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C98C80", Offset = "0x1C98C80", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SemaphoreSlim.<WaitUntilCountOrTimeoutAsync>d__32), Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SemaphoreSlim), Member = "Release", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		private bool RemoveAsyncWaiter(SemaphoreSlim.TaskNode task)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600114B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C98B14", Offset = "0x1C98B14", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SemaphoreSlim), Member = "WaitAsync", MemberParameters = new object[]
		{
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(global::System.Threading.Tasks.Task<bool>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<bool>), Member = "Create", ReturnType = "System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<bool>), Member = "Start", MemberTypeParameters = new object[] { typeof(SemaphoreSlim.<WaitUntilCountOrTimeoutAsync>d__32) }, MemberParameters = new object[] { typeof(ref SemaphoreSlim.<WaitUntilCountOrTimeoutAsync>d__32) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<bool>), Member = "get_Task", ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private global::System.Threading.Tasks.Task<bool> WaitUntilCountOrTimeoutAsync(SemaphoreSlim.TaskNode asyncWaiter, int millisecondsTimeout, CancellationToken cancellationToken)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600114C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C98CEC", Offset = "0x1C98CEC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.CryptoStream.<ReadAsyncInternal>d__37", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.CryptoStream.<WriteAsyncInternal>d__46", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Stream), Member = "EndRead", MemberParameters = new object[] { typeof(global::System.IAsyncResult) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Stream), Member = "FinishTrackingAsyncOperation", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Stream), Member = "EndWrite", MemberParameters = new object[] { typeof(global::System.IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.SocketAsyncResult", Member = "Complete", ReturnType = typeof(void))]
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
		public int Release()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600114D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C98CF4", Offset = "0x1C98CF4", Length = "0x2C8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SemaphoreSlim), Member = "CheckDispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "PulseAll", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Pulse", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SemaphoreSlim), Member = "RemoveAsyncWaiter", MemberParameters = new object[] { typeof(SemaphoreSlim.TaskNode) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadPool), Member = "UnsafeQueueCustomWorkItem", MemberParameters = new object[]
		{
			typeof(IThreadPoolWorkItem),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SemaphoreSlim), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SemaphoreFullException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
		public int Release(int releaseCount)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600114E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C99010", Offset = "0x1C99010", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadPool), Member = "UnsafeQueueCustomWorkItem", MemberParameters = new object[]
		{
			typeof(IThreadPoolWorkItem),
			typeof(bool)
		}, ReturnType = typeof(void))]
		private static void QueueWaiterTask(SemaphoreSlim.TaskNode waiterTask)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600114F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9901C", Offset = "0x1C9901C", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Concurrent.BlockingCollection`1", Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.GC), Member = "SuppressFinalize", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Dispose()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001150")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C99088", Offset = "0x1C99088", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		protected virtual void Dispose(bool disposing)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001151")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C990D8", Offset = "0x1C990D8", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "PulseAll", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private static void CancellationTokenCanceledEventHandler(object obj)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001152")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C98650", Offset = "0x1C98650", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SemaphoreSlim), Member = "Wait", MemberParameters = new object[]
		{
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SemaphoreSlim), Member = "WaitAsync", MemberParameters = new object[]
		{
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(global::System.Threading.Tasks.Task<bool>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SemaphoreSlim), Member = "Release", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SemaphoreSlim), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ObjectDisposedException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private void CheckDispose()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001153")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C98168", Offset = "0x1C98168", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SemaphoreSlim), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SemaphoreSlim), Member = "Wait", MemberParameters = new object[]
		{
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SemaphoreSlim), Member = "WaitAsync", MemberParameters = new object[]
		{
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(global::System.Threading.Tasks.Task<bool>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SemaphoreSlim), Member = "Release", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SemaphoreSlim), Member = "CheckDispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		private static string GetResourceString(string str)
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001154")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C991D4", Offset = "0x1C991D4", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task<bool>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool),
			typeof(global::System.Threading.Tasks.TaskCreationOptions),
			typeof(CancellationToken)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Action<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		static SemaphoreSlim()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400094D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int m_currentCount;

		[global::Cpp2ILInjected.Token(Token = "0x400094E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private readonly int m_maxCount;

		[global::Cpp2ILInjected.Token(Token = "0x400094F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int m_waitCount;

		[global::Cpp2ILInjected.Token(Token = "0x4000950")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private object m_lockObj;

		[global::Cpp2ILInjected.Token(Token = "0x4000951")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private ManualResetEvent m_waitHandle;

		[global::Cpp2ILInjected.Token(Token = "0x4000952")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private SemaphoreSlim.TaskNode m_asyncHead;

		[global::Cpp2ILInjected.Token(Token = "0x4000953")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private SemaphoreSlim.TaskNode m_asyncTail;

		[global::Cpp2ILInjected.Token(Token = "0x4000954")]
		private static readonly global::System.Threading.Tasks.Task<bool> s_trueTask;

		[global::Cpp2ILInjected.Token(Token = "0x4000955")]
		private static readonly global::System.Threading.Tasks.Task<bool> s_falseTask;

		[global::Cpp2ILInjected.Token(Token = "0x4000956")]
		private static global::System.Action<object> s_cancellationTokenCanceledEventHandler;

		[global::Cpp2ILInjected.Token(Token = "0x20001DF")]
		private sealed class TaskNode : global::System.Threading.Tasks.Task<bool>, IThreadPoolWorkItem
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001155")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C98C38", Offset = "0x1C98C38", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SemaphoreSlim), Member = "CreateAndAddAsyncWaiter", ReturnType = typeof(SemaphoreSlim.TaskNode))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task<bool>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal TaskNode()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6001156")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C992F8", Offset = "0x1C992F8", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task<bool>), Member = "TrySetResult", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6001157")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C99344", Offset = "0x1C99344", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4000957")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
			internal SemaphoreSlim.TaskNode Prev;

			[global::Cpp2ILInjected.Token(Token = "0x4000958")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
			internal SemaphoreSlim.TaskNode Next;
		}

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20001E0")]
		[StructLayout(3)]
		private struct <WaitUntilCountOrTimeoutAsync>d__32 : global::System.Runtime.CompilerServices.IAsyncStateMachine
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001158")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C99348", Offset = "0x1C99348", Length = "0x6FC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter), Member = "GetResult", ReturnType = "TResult")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationTokenSource), Member = "CreateLinkedTokenSource", MemberParameters = new object[]
			{
				typeof(CancellationToken),
				typeof(CancellationToken)
			}, ReturnType = typeof(CancellationTokenSource))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationTokenSource), Member = "ThrowIfDisposed", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task), Member = "Delay", MemberParameters = new object[]
			{
				typeof(int),
				typeof(CancellationToken)
			}, ReturnType = typeof(global::System.Threading.Tasks.Task))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task), Member = "WhenAny", MemberParameters = new object[] { typeof(global::System.Threading.Tasks.Task[]) }, ReturnType = typeof(global::System.Threading.Tasks.Task<global::System.Threading.Tasks.Task>))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task<object>), Member = "ConfigureAwait", MemberParameters = new object[] { typeof(bool) }, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter), Member = "GetResult", ReturnType = "TResult")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SemaphoreSlim), Member = "RemoveAsyncWaiter", MemberParameters = new object[] { "System.Threading.SemaphoreSlim.TaskNode" }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = "ThrowIfCancellationRequested", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationTokenSource), Member = "NotifyCancellation", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<bool>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[]
			{
				typeof(global::System.Runtime.CompilerServices.ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter),
				typeof(SemaphoreSlim.<WaitUntilCountOrTimeoutAsync>d__32)
			}, MemberParameters = new object[]
			{
				typeof(ref global::System.Runtime.CompilerServices.ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter),
				typeof(ref SemaphoreSlim.<WaitUntilCountOrTimeoutAsync>d__32)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task<bool>), Member = "ConfigureAwait", MemberParameters = new object[] { typeof(bool) }, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<bool>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[]
			{
				typeof(global::System.Runtime.CompilerServices.ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter),
				typeof(SemaphoreSlim.<WaitUntilCountOrTimeoutAsync>d__32)
			}, MemberParameters = new object[]
			{
				typeof(ref global::System.Runtime.CompilerServices.ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter),
				typeof(ref SemaphoreSlim.<WaitUntilCountOrTimeoutAsync>d__32)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<bool>), Member = "SetResult", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<bool>), Member = "SetException", MemberParameters = new object[] { typeof(global::System.Exception) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 49)]
			private void MoveNext()
			{
				throw null;
			}

			[global::System.Diagnostics.DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6001159")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C99A44", Offset = "0x1C99A44", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<bool>), Member = "SetStateMachine", MemberParameters = new object[] { typeof(global::System.Runtime.CompilerServices.IAsyncStateMachine) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private void SetStateMachine(global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4000959")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[global::Cpp2ILInjected.Token(Token = "0x400095A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<bool> <>t__builder;

			[global::Cpp2ILInjected.Token(Token = "0x400095B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public CancellationToken cancellationToken;

			[global::Cpp2ILInjected.Token(Token = "0x400095C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public SemaphoreSlim.TaskNode asyncWaiter;

			[global::Cpp2ILInjected.Token(Token = "0x400095D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public int millisecondsTimeout;

			[global::Cpp2ILInjected.Token(Token = "0x400095E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			public SemaphoreSlim <>4__this;

			[global::Cpp2ILInjected.Token(Token = "0x400095F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			private CancellationTokenSource <cts>5__2;

			[global::Cpp2ILInjected.Token(Token = "0x4000960")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			private object <>7__wrap2;

			[global::Cpp2ILInjected.Token(Token = "0x4000961")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
			private global::System.Runtime.CompilerServices.ConfiguredTaskAwaitable<global::System.Threading.Tasks.Task>.ConfiguredTaskAwaiter <>u__1;

			[global::Cpp2ILInjected.Token(Token = "0x4000962")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
			private global::System.Runtime.CompilerServices.ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter <>u__2;
		}
	}
}
