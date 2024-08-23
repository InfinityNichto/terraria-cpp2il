using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono.Net.Security
{
	// Token: 0x02000015 RID: 21
	[global::Cpp2ILInjected.Token(Token = "0x200004D")]
	internal abstract class AsyncProtocolRequest
	{
		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000068 RID: 104 RVA: 0x00002F66 File Offset: 0x00001166
		[global::Cpp2ILInjected.Token(Token = "0x1700001C")]
		public MobileAuthenticatedStream Parent
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60000C7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D47BEC", Offset = "0x1D47BEC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000069 RID: 105 RVA: 0x00002F69 File Offset: 0x00001169
		[global::Cpp2ILInjected.Token(Token = "0x1700001D")]
		public bool RunSynchronously
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60000C8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D47BF4", Offset = "0x1D47BF4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600006A RID: 106 RVA: 0x00002F6C File Offset: 0x0000116C
		[global::Cpp2ILInjected.Token(Token = "0x1700001E")]
		public string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000C9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D47BFC", Offset = "0x1D47BFC", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600006B RID: 107 RVA: 0x00002F6F File Offset: 0x0000116F
		// (set) Token: 0x0600006C RID: 108 RVA: 0x00002F72 File Offset: 0x00001172
		[global::Cpp2ILInjected.Token(Token = "0x1700001F")]
		public int UserResult
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60000CA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D47C18", Offset = "0x1D47C18", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60000CB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D47C20", Offset = "0x1D47C20", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002F75 File Offset: 0x00001175
		[global::Cpp2ILInjected.Token(Token = "0x60000CC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D47C28", Offset = "0x1D47C28", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AsyncHandshakeRequest), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(MobileAuthenticatedStream),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AsyncReadOrWriteRequest), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(MobileAuthenticatedStream),
			typeof(bool),
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Net.Security.MobileAuthenticatedStream.<ProcessAuthentication>d__48", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public AsyncProtocolRequest(MobileAuthenticatedStream parent, bool sync)
		{
			throw null;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00002F78 File Offset: 0x00001178
		[global::Cpp2ILInjected.Token(Token = "0x60000CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D47CA4", Offset = "0x1D47CA4", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MobileAuthenticatedStream), Member = "InternalRead", MemberParameters = new object[]
		{
			typeof(AsyncProtocolRequest),
			typeof(BufferOffsetSize),
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(ValueTuple<int, bool>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal void RequestRead(int size)
		{
			throw null;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002F7B File Offset: 0x0000117B
		[global::Cpp2ILInjected.Token(Token = "0x60000CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D47D68", Offset = "0x1D47D68", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void RequestWrite()
		{
			throw null;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002F7E File Offset: 0x0000117E
		[global::Cpp2ILInjected.Token(Token = "0x60000CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D47D74", Offset = "0x1D47D74", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Net.Security.MobileAuthenticatedStream.<ProcessAuthentication>d__48", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Net.Security.MobileAuthenticatedStream.<StartOperation>d__57", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<object>), Member = "Create", ReturnType = "System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<object>), Member = "Start", MemberTypeParameters = new object[] { typeof(AsyncProtocolRequest.<StartOperation>d__23) }, MemberParameters = new object[] { typeof(ref AsyncProtocolRequest.<StartOperation>d__23) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<object>), Member = "get_Task", ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal Task<AsyncProtocolResult> StartOperation(CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00002F81 File Offset: 0x00001181
		[global::Cpp2ILInjected.Token(Token = "0x60000D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D47E6C", Offset = "0x1D47E6C", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AsyncProtocolRequest.<StartOperation>d__23), Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Create", ReturnType = typeof(AsyncTaskMethodBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder[]), Member = "Start", MemberTypeParameters = new object[] { typeof(AsyncProtocolRequest.<ProcessOperation>d__24) }, MemberParameters = new object[] { typeof(ref AsyncProtocolRequest.<ProcessOperation>d__24) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private Task ProcessOperation(CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00002F84 File Offset: 0x00001184
		[global::Cpp2ILInjected.Token(Token = "0x60000D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D47F4C", Offset = "0x1D47F4C", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AsyncProtocolRequest.<ProcessOperation>d__24), Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<>), Member = "Create", ReturnType = "System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<>), Member = "Start", MemberTypeParameters = new object[] { "TStateMachine" }, MemberParameters = new object[] { "TStateMachine&" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<>), Member = "get_Task", ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private Task<int?> InnerRead(CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x06000073 RID: 115
		[global::Cpp2ILInjected.Token(Token = "0x60000D2")]
		protected abstract AsyncOperationStatus Run(AsyncOperationStatus status);

		// Token: 0x06000074 RID: 116 RVA: 0x00002F87 File Offset: 0x00001187
		[global::Cpp2ILInjected.Token(Token = "0x60000D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D48050", Offset = "0x1D48050", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x0400002C RID: 44
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40000A8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly MobileAuthenticatedStream <Parent>k__BackingField;

		// Token: 0x0400002D RID: 45
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40000A9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly bool <RunSynchronously>k__BackingField;

		// Token: 0x0400002E RID: 46
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40000AA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private int <UserResult>k__BackingField;

		// Token: 0x0400002F RID: 47
		[global::Cpp2ILInjected.Token(Token = "0x40000AB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int Started;

		// Token: 0x04000030 RID: 48
		[global::Cpp2ILInjected.Token(Token = "0x40000AC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private int RequestedSize;

		// Token: 0x04000031 RID: 49
		[global::Cpp2ILInjected.Token(Token = "0x40000AD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private int WriteRequested;

		// Token: 0x04000032 RID: 50
		[global::Cpp2ILInjected.Token(Token = "0x40000AE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private readonly object locker;

		// Token: 0x020003A0 RID: 928
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200004E")]
		[StructLayout(3)]
		private struct <StartOperation>d__23 : IAsyncStateMachine
		{
			// Token: 0x06001D03 RID: 7427 RVA: 0x00007FFD File Offset: 0x000061FD
			[global::Cpp2ILInjected.Token(Token = "0x60000D4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D480B8", Offset = "0x1D480B8", Length = "0x2FC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new object[]
			{
				typeof(ref int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncProtocolRequest), Member = "ProcessOperation", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(Task))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(ConfiguredTaskAwaitable))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<object>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[]
			{
				typeof(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter),
				typeof(AsyncProtocolRequest.<StartOperation>d__23)
			}, MemberParameters = new object[]
			{
				typeof(ref ConfiguredTaskAwaitable.ConfiguredTaskAwaiter),
				typeof(ref AsyncProtocolRequest.<StartOperation>d__23)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter), Member = "GetResult", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<object>), Member = "SetResult", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(ExceptionDispatchInfo))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<object>), Member = "SetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 28)]
			private void MoveNext()
			{
				throw null;
			}

			// Token: 0x06001D04 RID: 7428 RVA: 0x00008000 File Offset: 0x00006200
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60000D5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D483F4", Offset = "0x1D483F4", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<object>), Member = "SetStateMachine", MemberParameters = new object[] { typeof(IAsyncStateMachine) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				throw null;
			}

			// Token: 0x0400102D RID: 4141
			[global::Cpp2ILInjected.Token(Token = "0x40000AF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x0400102E RID: 4142
			[global::Cpp2ILInjected.Token(Token = "0x40000B0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<AsyncProtocolResult> <>t__builder;

			// Token: 0x0400102F RID: 4143
			[global::Cpp2ILInjected.Token(Token = "0x40000B1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public AsyncProtocolRequest <>4__this;

			// Token: 0x04001030 RID: 4144
			[global::Cpp2ILInjected.Token(Token = "0x40000B2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public CancellationToken cancellationToken;

			// Token: 0x04001031 RID: 4145
			[global::Cpp2ILInjected.Token(Token = "0x40000B3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x020003A1 RID: 929
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200004F")]
		[StructLayout(3)]
		private struct <ProcessOperation>d__24 : IAsyncStateMachine
		{
			// Token: 0x06001D05 RID: 7429 RVA: 0x00008003 File Offset: 0x00006203
			[global::Cpp2ILInjected.Token(Token = "0x60000D6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4844C", Offset = "0x1D4844C", Length = "0x454")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = "ThrowIfCancellationRequested", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncProtocolRequest), Member = "InnerRead", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(Task<int?>))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task<>), Member = "ConfigureAwait", MemberParameters = new object[] { typeof(bool) }, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable<>.ConfiguredTaskAwaiter), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable<>.ConfiguredTaskAwaiter), Member = "GetResult", ReturnType = "TResult")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "Exchange", MemberParameters = new object[]
			{
				typeof(ref int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MobileAuthenticatedStream), Member = "InnerWrite", MemberParameters = new object[]
			{
				typeof(bool),
				typeof(CancellationToken)
			}, ReturnType = typeof(Task))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(ConfiguredTaskAwaitable))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter), Member = "GetResult", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[] { "TAwaiter", "TStateMachine" }, MemberParameters = new object[] { "TAwaiter&", "TStateMachine&" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder[]), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[]
			{
				typeof(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter),
				typeof(AsyncProtocolRequest.<ProcessOperation>d__24)
			}, MemberParameters = new object[]
			{
				typeof(ref ConfiguredTaskAwaitable.ConfiguredTaskAwaiter),
				typeof(ref AsyncProtocolRequest.<ProcessOperation>d__24)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MobileAuthenticatedStream), Member = "GetSSPIException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(Exception))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 37)]
			private void MoveNext()
			{
				throw null;
			}

			// Token: 0x06001D06 RID: 7430 RVA: 0x00008006 File Offset: 0x00006206
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60000D7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D48B10", Offset = "0x1D48B10", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new object[] { typeof(IAsyncStateMachine) }, ReturnType = typeof(void))]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				throw null;
			}

			// Token: 0x04001032 RID: 4146
			[global::Cpp2ILInjected.Token(Token = "0x40000B4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x04001033 RID: 4147
			[global::Cpp2ILInjected.Token(Token = "0x40000B5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04001034 RID: 4148
			[global::Cpp2ILInjected.Token(Token = "0x40000B6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public CancellationToken cancellationToken;

			// Token: 0x04001035 RID: 4149
			[global::Cpp2ILInjected.Token(Token = "0x40000B7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public AsyncProtocolRequest <>4__this;

			// Token: 0x04001036 RID: 4150
			[global::Cpp2ILInjected.Token(Token = "0x40000B8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private AsyncOperationStatus <status>5__2;

			// Token: 0x04001037 RID: 4151
			[global::Cpp2ILInjected.Token(Token = "0x40000B9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
			private AsyncOperationStatus <newStatus>5__3;

			// Token: 0x04001038 RID: 4152
			[global::Cpp2ILInjected.Token(Token = "0x40000BA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			private ConfiguredTaskAwaitable<int?>.ConfiguredTaskAwaiter <>u__1;

			// Token: 0x04001039 RID: 4153
			[global::Cpp2ILInjected.Token(Token = "0x40000BB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2;
		}

		// Token: 0x020003A2 RID: 930
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000050")]
		[StructLayout(3)]
		private struct <InnerRead>d__25 : IAsyncStateMachine
		{
			// Token: 0x06001D07 RID: 7431 RVA: 0x00008009 File Offset: 0x00006209
			[global::Cpp2ILInjected.Token(Token = "0x60000D8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D48B1C", Offset = "0x1D48B1C", Length = "0x318")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AsyncTaskMethodBuilder<>), Member = "Start", MemberTypeParameters = new object[] { "TStateMachine" }, MemberParameters = new object[] { "TStateMachine&" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "Exchange", MemberParameters = new object[]
			{
				typeof(ref int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MobileAuthenticatedStream), Member = "InnerRead", MemberParameters = new object[]
			{
				typeof(bool),
				typeof(int),
				typeof(CancellationToken)
			}, ReturnType = typeof(Task<int>))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task<int>), Member = "ConfigureAwait", MemberParameters = new object[] { typeof(bool) }, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter), Member = "GetResult", ReturnType = "TResult")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int?), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<>), Member = "SetResult", MemberParameters = new object[] { "TResult" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[] { "TAwaiter", "TStateMachine" }, MemberParameters = new object[] { "TAwaiter&", "TStateMachine&" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<>), Member = "SetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
			private void MoveNext()
			{
				throw null;
			}

			// Token: 0x06001D08 RID: 7432 RVA: 0x0000800C File Offset: 0x0000620C
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60000D9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D48F50", Offset = "0x1D48F50", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<>), Member = "SetStateMachine", MemberParameters = new object[] { typeof(IAsyncStateMachine) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				throw null;
			}

			// Token: 0x0400103A RID: 4154
			[global::Cpp2ILInjected.Token(Token = "0x40000BC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x0400103B RID: 4155
			[global::Cpp2ILInjected.Token(Token = "0x40000BD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<int?> <>t__builder;

			// Token: 0x0400103C RID: 4156
			[global::Cpp2ILInjected.Token(Token = "0x40000BE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public AsyncProtocolRequest <>4__this;

			// Token: 0x0400103D RID: 4157
			[global::Cpp2ILInjected.Token(Token = "0x40000BF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public CancellationToken cancellationToken;

			// Token: 0x0400103E RID: 4158
			[global::Cpp2ILInjected.Token(Token = "0x40000C0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private int? <totalRead>5__2;

			// Token: 0x0400103F RID: 4159
			[global::Cpp2ILInjected.Token(Token = "0x40000C1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			private int <requestedSize>5__3;

			// Token: 0x04001040 RID: 4160
			[global::Cpp2ILInjected.Token(Token = "0x40000C2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter <>u__1;
		}
	}
}
