using System;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading
{
	[global::Cpp2ILInjected.Token(Token = "0x20001F2")]
	public class SynchronizationContext
	{
		[global::Cpp2ILInjected.Token(Token = "0x60011C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9C240", Offset = "0x1C9C240", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.AsyncOperationManager", Member = "get_SynchronizationContext", ReturnType = typeof(SynchronizationContext))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UnitySynchronizationContext", Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UnitySynchronizationContext", Member = ".ctor", MemberParameters = new object[]
		{
			"System.Collections.Generic.List`1<WorkRequest>",
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public SynchronizationContext()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60011C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9C248", Offset = "0x1C9C248", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WaitHandle), Member = "WaitOneNative", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.InteropServices.SafeHandle),
			typeof(uint),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WaitHandle), Member = "WaitMultiple", MemberParameters = new object[]
		{
			typeof(WaitHandle[]),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public bool IsWaitNotificationRequired()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60011C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9C254", Offset = "0x1C9C254", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual void Send(SendOrPostCallback d, object state)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60011C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9C26C", Offset = "0x1C9C26C", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public virtual void Post(SendOrPostCallback d, object state)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60011C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9C2F4", Offset = "0x1C9C2F4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void OperationStarted()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60011C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9C2F8", Offset = "0x1C9C2F8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void OperationCompleted()
		{
			throw null;
		}

		[global::System.CLSCompliant(false)]
		[global::System.Runtime.ConstrainedExecution.PrePrepareMethod]
		[global::Cpp2ILInjected.Token(Token = "0x60011C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9C2FC", Offset = "0x1C9C2FC", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public virtual int Wait(global::System.IntPtr[] waitHandles, bool waitAll, int millisecondsTimeout)
		{
			throw null;
		}

		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.MayFail)]
		[global::System.CLSCompliant(false)]
		[global::System.Runtime.ConstrainedExecution.PrePrepareMethod]
		[global::Cpp2ILInjected.Token(Token = "0x60011CA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9C35C", Offset = "0x1C9C35C", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WaitHandle), Member = "Wait_internal", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr*),
			typeof(int),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected unsafe static int WaitHelper(global::System.IntPtr[] waitHandles, bool waitAll, int millisecondsTimeout)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60011CB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9C3EC", Offset = "0x1C9C3EC", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.AwaitTaskContinuation), Member = "RunCallback", MemberParameters = new object[]
		{
			typeof(ContextCallback),
			typeof(object),
			typeof(ref global::System.Threading.Tasks.Task)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.AsyncOperationManager", Member = "get_SynchronizationContext", ReturnType = typeof(SynchronizationContext))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.AsyncOperationManager", Member = "set_SynchronizationContext", MemberParameters = new object[] { typeof(SynchronizationContext) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UnitySynchronizationContext", Member = "InitializeSynchronizationContext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "GetMutableExecutionContext", ReturnType = typeof(ExecutionContext))]
		public static void SetSynchronizationContext(SynchronizationContext syncContext)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001AE")]
		public static SynchronizationContext Current
		{
			[global::Cpp2ILInjected.Token(Token = "0x60011CC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C9492C", Offset = "0x1C9492C", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CancellationToken), Member = "Register", MemberParameters = new object[]
			{
				typeof(global::System.Action<object>),
				typeof(object),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(CancellationTokenRegistration))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SynchronizationContext), Member = "get_CurrentExplicit", ReturnType = typeof(SynchronizationContext))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WaitHandle), Member = "WaitOneNative", MemberParameters = new object[]
			{
				typeof(global::System.Runtime.InteropServices.SafeHandle),
				typeof(uint),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WaitHandle), Member = "WaitMultiple", MemberParameters = new object[]
			{
				typeof(WaitHandle[]),
				typeof(int),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.Task), Member = "SetContinuationForAwait", MemberParameters = new object[]
			{
				typeof(global::System.Action),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.SynchronizationContextAwaitTaskContinuation), Member = "Run", MemberParameters = new object[]
			{
				typeof(global::System.Threading.Tasks.Task),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.AwaitTaskContinuation), Member = "get_IsValidLocationForInlining", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket.AwaitableSocketAsyncEventArgs", Member = "OnCompleted", MemberParameters = new object[]
			{
				"System.Action`1<Object>",
				typeof(object),
				typeof(short),
				typeof(global::System.Threading.Tasks.Sources.ValueTaskSourceOnCompletedFlags)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.AsyncOperationManager", Member = "get_SynchronizationContext", ReturnType = typeof(SynchronizationContext))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UnitySynchronizationContext", Member = "ExecuteTasks", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UnitySynchronizationContext", Member = "ExecutePendingTasks", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SynchronizationContext), Member = "GetThreadLocalContext", ReturnType = typeof(SynchronizationContext))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001AF")]
		internal static SynchronizationContext CurrentNoFlow
		{
			[global::System.Runtime.CompilerServices.FriendAccessAllowed]
			[global::Cpp2ILInjected.Token(Token = "0x60011CD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C9C454", Offset = "0x1C9C454", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.CompilerServices.AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(global::System.Runtime.CompilerServices.AsyncVoidMethodBuilder))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SynchronizationContext), Member = "GetThreadLocalContext", ReturnType = typeof(SynchronizationContext))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60011CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9C408", Offset = "0x1C9C408", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SynchronizationContext), Member = "get_Current", ReturnType = typeof(SynchronizationContext))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SynchronizationContext), Member = "get_CurrentNoFlow", ReturnType = typeof(SynchronizationContext))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OSSpecificSynchronizationContext), Member = "Get", ReturnType = typeof(OSSpecificSynchronizationContext))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static SynchronizationContext GetThreadLocalContext()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60011CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9C5D8", Offset = "0x1C9C5D8", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual SynchronizationContext CreateCopy()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001B0")]
		internal static SynchronizationContext CurrentExplicit
		{
			[global::Cpp2ILInjected.Token(Token = "0x60011D0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C9C62C", Offset = "0x1C9C62C", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.AwaitTaskContinuation), Member = "RunCallback", MemberParameters = new object[]
			{
				typeof(ContextCallback),
				typeof(object),
				typeof(ref global::System.Threading.Tasks.Task)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SynchronizationContext), Member = "get_Current", ReturnType = typeof(SynchronizationContext))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000990")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private SynchronizationContextProperties _props;

		[global::Cpp2ILInjected.Token(Token = "0x4000991")]
		private static global::System.Type s_cachedPreparedType1;

		[global::Cpp2ILInjected.Token(Token = "0x4000992")]
		private static global::System.Type s_cachedPreparedType2;

		[global::Cpp2ILInjected.Token(Token = "0x4000993")]
		private static global::System.Type s_cachedPreparedType3;

		[global::Cpp2ILInjected.Token(Token = "0x4000994")]
		private static global::System.Type s_cachedPreparedType4;

		[global::Cpp2ILInjected.Token(Token = "0x4000995")]
		private static global::System.Type s_cachedPreparedType5;
	}
}
