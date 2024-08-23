using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading
{
	// Token: 0x02000178 RID: 376
	[global::System.Diagnostics.DebuggerDisplay("Set = {IsSet}")]
	[global::Cpp2ILInjected.Token(Token = "0x20001CB")]
	public class ManualResetEventSlim : global::System.IDisposable
	{
		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000FAC RID: 4012 RVA: 0x00017159 File Offset: 0x00015359
		[global::Cpp2ILInjected.Token(Token = "0x1700018A")]
		public WaitHandle WaitHandle
		{
			[global::Cpp2ILInjected.Token(Token = "0x60010E1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C94F54", Offset = "0x1C94F54", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.Task), Member = "System.IAsyncResult.get_AsyncWaitHandle", ReturnType = typeof(WaitHandle))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ManualResetEventSlim), Member = "ThrowIfDisposed", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ManualResetEventSlim), Member = "LazyInitializeEvent", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000FAD RID: 4013 RVA: 0x0001715C File Offset: 0x0001535C
		// (set) Token: 0x06000FAE RID: 4014 RVA: 0x0001715F File Offset: 0x0001535F
		[global::Cpp2ILInjected.Token(Token = "0x1700018B")]
		public bool IsSet
		{
			[global::Cpp2ILInjected.Token(Token = "0x60010E2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C95150", Offset = "0x1C95150", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ManualResetEventSlim), Member = "LazyInitializeEvent", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ManualResetEventSlim), Member = "Wait", MemberParameters = new object[]
			{
				typeof(int),
				typeof(CancellationToken)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.Task), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60010E3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C951B4", Offset = "0x1C951B4", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000FAF RID: 4015 RVA: 0x00017162 File Offset: 0x00015362
		// (set) Token: 0x06000FB0 RID: 4016 RVA: 0x00017165 File Offset: 0x00015365
		[global::Cpp2ILInjected.Token(Token = "0x1700018C")]
		public int SpinCount
		{
			[global::Cpp2ILInjected.Token(Token = "0x60010E4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C9526C", Offset = "0x1C9526C", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ManualResetEventSlim), Member = "Wait", MemberParameters = new object[]
			{
				typeof(int),
				typeof(CancellationToken)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60010E5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C952D4", Offset = "0x1C952D4", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000FB1 RID: 4017 RVA: 0x00017168 File Offset: 0x00015368
		// (set) Token: 0x06000FB2 RID: 4018 RVA: 0x0001716B File Offset: 0x0001536B
		[global::Cpp2ILInjected.Token(Token = "0x1700018D")]
		private int Waiters
		{
			[global::Cpp2ILInjected.Token(Token = "0x60010E6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C95308", Offset = "0x1C95308", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ManualResetEventSlim), Member = "Set", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ManualResetEventSlim), Member = "Wait", MemberParameters = new object[]
			{
				typeof(int),
				typeof(CancellationToken)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60010E7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C95364", Offset = "0x1C95364", Length = "0x8C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ManualResetEventSlim), Member = "Wait", MemberParameters = new object[]
			{
				typeof(int),
				typeof(CancellationToken)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ManualResetEventSlim), Member = "UpdateStateAtomically", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000FB3 RID: 4019 RVA: 0x0001716E File Offset: 0x0001536E
		[global::Cpp2ILInjected.Token(Token = "0x60010E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C953F0", Offset = "0x1C953F0", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.Task), Member = "get_CompletedEvent", ReturnType = typeof(ManualResetEventSlim))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public ManualResetEventSlim(bool initialState)
		{
			throw null;
		}

		// Token: 0x06000FB4 RID: 4020 RVA: 0x00017171 File Offset: 0x00015371
		[global::Cpp2ILInjected.Token(Token = "0x60010E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C95514", Offset = "0x1C95514", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Threading.Tasks.Task.SetOnInvokeMres", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ManualResetEventSlim), Member = "Initialize", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public ManualResetEventSlim(bool initialState, int spinCount)
		{
			throw null;
		}

		// Token: 0x06000FB5 RID: 4021 RVA: 0x00017174 File Offset: 0x00015374
		[global::Cpp2ILInjected.Token(Token = "0x60010EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9546C", Offset = "0x1C9546C", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ManualResetEventSlim), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void Initialize(bool initialState, int spinCount)
		{
			throw null;
		}

		// Token: 0x06000FB6 RID: 4022 RVA: 0x00017177 File Offset: 0x00015377
		[global::Cpp2ILInjected.Token(Token = "0x60010EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9562C", Offset = "0x1C9562C", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ManualResetEventSlim), Member = "Wait", MemberParameters = new object[]
		{
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new object[]
		{
			typeof(ref object),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void EnsureLockObjectCreated()
		{
			throw null;
		}

		// Token: 0x06000FB7 RID: 4023 RVA: 0x0001717A File Offset: 0x0001537A
		[global::Cpp2ILInjected.Token(Token = "0x60010EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C94FF0", Offset = "0x1C94FF0", Length = "0x160")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ManualResetEventSlim), Member = "get_WaitHandle", ReturnType = typeof(WaitHandle))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ManualResetEventSlim), Member = "get_IsSet", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventWaitHandle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(EventResetMode),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WaitHandle), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private bool LazyInitializeEvent()
		{
			throw null;
		}

		// Token: 0x06000FB8 RID: 4024 RVA: 0x0001717D File Offset: 0x0001537D
		[global::Cpp2ILInjected.Token(Token = "0x60010ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C945FC", Offset = "0x1C945FC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.Task.ContingentProperties), Member = "SetCompleted", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Threading.Tasks.Task.SetOnInvokeMres", Member = "Invoke", MemberParameters = new object[] { typeof(global::System.Threading.Tasks.Task) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.Task), Member = "get_CompletedEvent", ReturnType = typeof(ManualResetEventSlim))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.Task), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.Task), Member = "FinishStageTwo", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.Task), Member = "CancellationCleanupLogic", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ManualResetEventSlim), Member = "Set", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		public void Set()
		{
			throw null;
		}

		// Token: 0x06000FB9 RID: 4025 RVA: 0x00017180 File Offset: 0x00015380
		[global::Cpp2ILInjected.Token(Token = "0x60010EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C95728", Offset = "0x1C95728", Length = "0x19C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CountdownEvent), Member = "Signal", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ManualResetEventSlim), Member = "Set", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ManualResetEventSlim), Member = "UpdateStateAtomically", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ManualResetEventSlim), Member = "get_Waiters", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "PulseAll", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		private void Set(bool duringCancellation)
		{
			throw null;
		}

		// Token: 0x06000FBA RID: 4026 RVA: 0x00017183 File Offset: 0x00015383
		[global::Cpp2ILInjected.Token(Token = "0x60010EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C95918", Offset = "0x1C95918", Length = "0x44C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.Task), Member = "SpinThenBlockingWait", MemberParameters = new object[]
		{
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ManualResetEventSlim), Member = "ThrowIfDisposed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = "ThrowIfCancellationRequested", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ManualResetEventSlim), Member = "get_IsSet", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "get_TickCount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ManualResetEventSlim), Member = "get_SpinCount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpinWait), Member = "SpinOnceCore", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ManualResetEventSlim), Member = "EnsureLockObjectCreated", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = "Register", MemberParameters = new object[]
		{
			typeof(global::System.Action<object>),
			typeof(object),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(CancellationTokenRegistration))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ManualResetEventSlim), Member = "get_Waiters", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ManualResetEventSlim), Member = "set_Waiters", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Wait", MemberParameters = new object[]
		{
			typeof(object),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationTokenRegistration), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x06000FBB RID: 4027 RVA: 0x00017186 File Offset: 0x00015386
		[global::Cpp2ILInjected.Token(Token = "0x60010F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C95E58", Offset = "0x1C95E58", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.Task), Member = "get_CompletedEvent", ReturnType = typeof(ManualResetEventSlim))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.Task), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.GC), Member = "SuppressFinalize", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x06000FBC RID: 4028 RVA: 0x00017189 File Offset: 0x00015389
		[global::Cpp2ILInjected.Token(Token = "0x60010F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C95EC4", Offset = "0x1C95EC4", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WaitHandle), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		protected virtual void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x06000FBD RID: 4029 RVA: 0x0001718C File Offset: 0x0001538C
		[global::Cpp2ILInjected.Token(Token = "0x60010F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C94F90", Offset = "0x1C94F90", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ManualResetEventSlim), Member = "get_WaitHandle", ReturnType = typeof(WaitHandle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ManualResetEventSlim), Member = "Wait", MemberParameters = new object[]
		{
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void ThrowIfDisposed()
		{
			throw null;
		}

		// Token: 0x06000FBE RID: 4030 RVA: 0x0001718F File Offset: 0x0001538F
		[global::Cpp2ILInjected.Token(Token = "0x60010F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C95FB8", Offset = "0x1C95FB8", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "PulseAll", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private static void CancellationTokenCallback(object obj)
		{
			throw null;
		}

		// Token: 0x06000FBF RID: 4031 RVA: 0x00017192 File Offset: 0x00015392
		[global::Cpp2ILInjected.Token(Token = "0x60010F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C951C8", Offset = "0x1C951C8", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ManualResetEventSlim), Member = "set_Waiters", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ManualResetEventSlim), Member = "Set", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpinWait), Member = "SpinOnceCore", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void UpdateStateAtomically(int newBits, int updateBitsMask)
		{
			throw null;
		}

		// Token: 0x06000FC0 RID: 4032 RVA: 0x00017195 File Offset: 0x00015395
		[global::Cpp2ILInjected.Token(Token = "0x60010F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C952C8", Offset = "0x1C952C8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static int ExtractStatePortionAndShiftRight(int state, int mask, int rightBitShiftCount)
		{
			throw null;
		}

		// Token: 0x06000FC1 RID: 4033 RVA: 0x00017198 File Offset: 0x00015398
		[global::Cpp2ILInjected.Token(Token = "0x60010F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C951AC", Offset = "0x1C951AC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static int ExtractStatePortion(int state, int mask)
		{
			throw null;
		}

		// Token: 0x06000FC2 RID: 4034 RVA: 0x0001719B File Offset: 0x0001539B
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60010F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C960C8", Offset = "0x1C960C8", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Action<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static ManualResetEventSlim()
		{
			throw null;
		}

		// Token: 0x0400071A RID: 1818
		[global::Cpp2ILInjected.Token(Token = "0x400091B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private object m_lock;

		// Token: 0x0400071B RID: 1819
		[global::Cpp2ILInjected.Token(Token = "0x400091C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private ManualResetEvent m_eventObj;

		// Token: 0x0400071C RID: 1820
		[global::Cpp2ILInjected.Token(Token = "0x400091D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int m_combinedState;

		// Token: 0x0400071D RID: 1821
		[global::Cpp2ILInjected.Token(Token = "0x400091E")]
		private static global::System.Action<object> s_cancellationTokenCallback;
	}
}
