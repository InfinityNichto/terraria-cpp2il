using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading
{
	// Token: 0x02000177 RID: 375
	[global::System.Diagnostics.DebuggerDisplay("IsCancellationRequested = {IsCancellationRequested}")]
	[global::Cpp2ILInjected.Token(Token = "0x20001C9")]
	public readonly struct CancellationToken
	{
		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06000F9C RID: 3996 RVA: 0x00017129 File Offset: 0x00015329
		[global::Cpp2ILInjected.Token(Token = "0x17000187")]
		public static CancellationToken None
		{
			[global::Cpp2ILInjected.Token(Token = "0x60010CE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C94604", Offset = "0x1C94604", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 23)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000F9D RID: 3997 RVA: 0x0001712C File Offset: 0x0001532C
		[global::Cpp2ILInjected.Token(Token = "0x17000188")]
		public bool IsCancellationRequested
		{
			[global::Cpp2ILInjected.Token(Token = "0x60010CF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C9460C", Offset = "0x1C9460C", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 39)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000F9E RID: 3998 RVA: 0x0001712F File Offset: 0x0001532F
		[global::Cpp2ILInjected.Token(Token = "0x17000189")]
		public bool CanBeCanceled
		{
			[global::Cpp2ILInjected.Token(Token = "0x60010D0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C94654", Offset = "0x1C94654", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.Task), Member = "TaskConstructorCore", MemberParameters = new object[]
			{
				typeof(global::System.Delegate),
				typeof(object),
				typeof(CancellationToken),
				typeof(global::System.Threading.Tasks.TaskCreationOptions),
				typeof(global::System.Threading.Tasks.InternalTaskOptions),
				typeof(global::System.Threading.Tasks.TaskScheduler)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.Task), Member = "InternalWait", MemberParameters = new object[]
			{
				typeof(int),
				typeof(CancellationToken)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.Task), Member = "ContinueWithCore", MemberParameters = new object[]
			{
				typeof(global::System.Threading.Tasks.Task),
				typeof(global::System.Threading.Tasks.TaskScheduler),
				typeof(CancellationToken),
				typeof(global::System.Threading.Tasks.TaskContinuationOptions)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.Task), Member = "Delay", MemberParameters = new object[]
			{
				typeof(int),
				typeof(CancellationToken)
			}, ReturnType = typeof(global::System.Threading.Tasks.Task))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000F9F RID: 3999 RVA: 0x00017132 File Offset: 0x00015332
		[global::Cpp2ILInjected.Token(Token = "0x60010D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C94664", Offset = "0x1C94664", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal CancellationToken(CancellationTokenSource source)
		{
			throw null;
		}

		// Token: 0x06000FA0 RID: 4000 RVA: 0x00017135 File Offset: 0x00015335
		[global::Cpp2ILInjected.Token(Token = "0x60010D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9466C", Offset = "0x1C9466C", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Threading.Tasks.ValueTask.ValueTaskSourceAsTask.<>c", Member = "<.cctor>b__4_0", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.ValueTask), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Threading.Tasks.ValueTask`1.ValueTaskSourceAsTask.<>c", Member = "<.cctor>b__4_0", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.ValueTask<>), Member = "GetTaskForValueTaskSource", MemberParameters = new object[] { "System.Threading.Tasks.Sources.IValueTaskSource`1<TResult>" }, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public CancellationToken(bool canceled)
		{
			throw null;
		}

		// Token: 0x06000FA1 RID: 4001 RVA: 0x00017138 File Offset: 0x00015338
		[global::Cpp2ILInjected.Token(Token = "0x60010D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C946E0", Offset = "0x1C946E0", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebOperation", Member = "RegisterRequest", MemberParameters = new object[] { "System.Net.ServicePoint", "System.Net.WebConnection" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = "Register", MemberParameters = new object[]
		{
			typeof(global::System.Action<object>),
			typeof(object),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(CancellationTokenRegistration))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public CancellationTokenRegistration Register(global::System.Action callback)
		{
			throw null;
		}

		// Token: 0x06000FA2 RID: 4002 RVA: 0x0001713B File Offset: 0x0001533B
		[global::Cpp2ILInjected.Token(Token = "0x60010D4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C948F4", Offset = "0x1C948F4", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.Task), Member = "AssignCancellationToken", MemberParameters = new object[]
		{
			typeof(CancellationToken),
			typeof(global::System.Threading.Tasks.Task),
			typeof(global::System.Threading.Tasks.TaskContinuation)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.Task), Member = "Delay", MemberParameters = new object[]
		{
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(global::System.Threading.Tasks.Task))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = "Register", MemberParameters = new object[]
		{
			typeof(global::System.Action<object>),
			typeof(object),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(CancellationTokenRegistration))]
		internal CancellationTokenRegistration InternalRegisterWithoutEC(global::System.Action<object> callback, object state)
		{
			throw null;
		}

		// Token: 0x06000FA3 RID: 4003 RVA: 0x0001713E File Offset: 0x0001533E
		[global::Cpp2ILInjected.Token(Token = "0x60010D5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C947C8", Offset = "0x1C947C8", Length = "0x12C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CancellationToken), Member = "Register", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(CancellationTokenRegistration))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CancellationToken), Member = "InternalRegisterWithoutEC", MemberParameters = new object[]
		{
			typeof(global::System.Action<object>),
			typeof(object)
		}, ReturnType = typeof(CancellationTokenRegistration))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ManualResetEventSlim), Member = "Wait", MemberParameters = new object[]
		{
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Threading.CancellationTokenSource.Linked1CancellationTokenSource", Member = ".ctor", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Threading.CancellationTokenSource.Linked2CancellationTokenSource", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(CancellationToken),
			typeof(CancellationToken)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SemaphoreSlim), Member = "Wait", MemberParameters = new object[]
		{
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SynchronizationContext), Member = "get_Current", ReturnType = typeof(SynchronizationContext))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecutionContext), Member = "Capture", ReturnType = typeof(ExecutionContext))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationTokenSource), Member = "InternalRegister", MemberParameters = new object[]
		{
			typeof(global::System.Action<object>),
			typeof(object),
			typeof(SynchronizationContext),
			typeof(ExecutionContext)
		}, ReturnType = typeof(CancellationTokenRegistration))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		[MethodImpl(8)]
		public CancellationTokenRegistration Register(global::System.Action<object> callback, object state, bool useSynchronizationContext, bool useExecutionContext)
		{
			throw null;
		}

		// Token: 0x06000FA4 RID: 4004 RVA: 0x00017141 File Offset: 0x00015341
		[global::Cpp2ILInjected.Token(Token = "0x60010D6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C94C28", Offset = "0x1C94C28", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool Equals(CancellationToken other)
		{
			throw null;
		}

		// Token: 0x06000FA5 RID: 4005 RVA: 0x00017144 File Offset: 0x00015344
		[global::Cpp2ILInjected.Token(Token = "0x60010D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C94C38", Offset = "0x1C94C38", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object other)
		{
			throw null;
		}

		// Token: 0x06000FA6 RID: 4006 RVA: 0x00017147 File Offset: 0x00015347
		[global::Cpp2ILInjected.Token(Token = "0x60010D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C94CB0", Offset = "0x1C94CB0", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06000FA7 RID: 4007 RVA: 0x0001714A File Offset: 0x0001534A
		[global::Cpp2ILInjected.Token(Token = "0x60010D9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C94D1C", Offset = "0x1C94D1C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.Task), Member = "HandleException", MemberParameters = new object[] { typeof(global::System.Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static bool operator ==(CancellationToken left, CancellationToken right)
		{
			throw null;
		}

		// Token: 0x06000FA8 RID: 4008 RVA: 0x0001714D File Offset: 0x0001534D
		[global::Cpp2ILInjected.Token(Token = "0x60010DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C94D28", Offset = "0x1C94D28", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.Task), Member = "RecordInternalCancellationRequest", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static bool operator !=(CancellationToken left, CancellationToken right)
		{
			throw null;
		}

		// Token: 0x06000FA9 RID: 4009 RVA: 0x00017150 File Offset: 0x00015350
		[global::Cpp2ILInjected.Token(Token = "0x60010DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C94D34", Offset = "0x1C94D34", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ManualResetEventSlim), Member = "Wait", MemberParameters = new object[]
		{
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Threading.SemaphoreSlim.<WaitUntilCountOrTimeoutAsync>d__32", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SemaphoreSlim), Member = "Wait", MemberParameters = new object[]
		{
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SemaphoreSlim), Member = "WaitUntilCountOrTimeout", MemberParameters = new object[]
		{
			typeof(int),
			typeof(uint),
			typeof(CancellationToken)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.Task), Member = "Wait", MemberParameters = new object[]
		{
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Net.Security.AsyncProtocolRequest.<ProcessOperation>d__24", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Net.Security.MobileAuthenticatedStream.<InnerRead>d__66", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Net.Security.MobileAuthenticatedStream.<InnerWrite>d__67", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.BufferedReadStream.<ProcessReadAsync>d__2", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FixedSizeReadStream.<ProcessReadAsync>d__5", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpWebRequest.<MyGetResponseAsync>d__243", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.MonoChunkStream.<ProcessReadAsync>d__7", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.MonoChunkStream.<FinishReading>d__8", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebConnectionTunnel.<ReadHeaders>d__43", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebResponseStream.<ReadAsync>d__40", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebResponseStream.<ReadAllAsyncInner>d__47", Member = "MoveNext", ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 22)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = "ThrowOperationCanceledException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void ThrowIfCancellationRequested()
		{
			throw null;
		}

		// Token: 0x06000FAA RID: 4010 RVA: 0x00017153 File Offset: 0x00015353
		[global::Cpp2ILInjected.Token(Token = "0x60010DC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C94D6C", Offset = "0x1C94D6C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CancellationToken), Member = "ThrowIfCancellationRequested", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.OperationCanceledException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(CancellationToken)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void ThrowOperationCanceledException()
		{
			throw null;
		}

		// Token: 0x06000FAB RID: 4011 RVA: 0x00017156 File Offset: 0x00015356
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60010DD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C94DC4", Offset = "0x1C94DC4", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Action<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		static CancellationToken()
		{
			throw null;
		}

		// Token: 0x04000718 RID: 1816
		[global::Cpp2ILInjected.Token(Token = "0x4000918")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly CancellationTokenSource _source;

		// Token: 0x04000719 RID: 1817
		[global::Cpp2ILInjected.Token(Token = "0x4000919")]
		private static readonly global::System.Action<object> s_actionToActionObjShunt;

		// Token: 0x020005A0 RID: 1440
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20001CA")]
		[global::System.Serializable]
		private sealed class <>c
		{
			// Token: 0x06004012 RID: 16402 RVA: 0x0001FAED File Offset: 0x0001DCED
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x60010DE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C94E88", Offset = "0x1C94E88", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			// Token: 0x06004013 RID: 16403 RVA: 0x0001FAF0 File Offset: 0x0001DCF0
			[global::Cpp2ILInjected.Token(Token = "0x60010DF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C94EE4", Offset = "0x1C94EE4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			// Token: 0x06004014 RID: 16404 RVA: 0x0001FAF3 File Offset: 0x0001DCF3
			[global::Cpp2ILInjected.Token(Token = "0x60010E0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C94EEC", Offset = "0x1C94EEC", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal void <.cctor>b__26_0(object obj)
			{
				throw null;
			}

			// Token: 0x0400188B RID: 6283
			[global::Cpp2ILInjected.Token(Token = "0x400091A")]
			public static readonly CancellationToken.<>c <>9;
		}
	}
}
