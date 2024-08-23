using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020003DA RID: 986
	[global::Cpp2ILInjected.Token(Token = "0x200048E")]
	public struct AsyncVoidMethodBuilder
	{
		// Token: 0x06001FF2 RID: 8178 RVA: 0x00019E77 File Offset: 0x00018077
		[global::Cpp2ILInjected.Token(Token = "0x6002257")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B744EC", Offset = "0x1B744EC", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FtpWebRequest", Member = "CreateConnectionAsync", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebClient", Member = "DownloadBitsAsync", MemberParameters = new object[]
		{
			"System.Net.WebRequest",
			typeof(global::System.IO.Stream),
			"System.ComponentModel.AsyncOperation",
			"System.Action`3<Byte[], Exception, AsyncOperation>"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebClient", Member = "UploadBitsAsync", MemberParameters = new object[]
		{
			"System.Net.WebRequest",
			typeof(global::System.IO.Stream),
			"System.Byte[]",
			typeof(int),
			"System.Byte[]",
			"System.Byte[]",
			"System.ComponentModel.AsyncOperation",
			"System.Action`3<Byte[], Exception, AsyncOperation>"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebOperation", Member = "Run", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.SynchronizationContext), Member = "get_CurrentNoFlow", ReturnType = typeof(global::System.Threading.SynchronizationContext))]
		public static AsyncVoidMethodBuilder Create()
		{
			throw null;
		}

		// Token: 0x06001FF3 RID: 8179 RVA: 0x00019E7A File Offset: 0x0001807A
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::Cpp2ILInjected.Token(Token = "0x6002258")]
		[global::Cpp2ILInjected.Address(RVA = "0x15752E8", Offset = "0x15752E8", Length = "0x1AC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "PrepareConstrainedRegions", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.ExecutionContext), Member = "EstablishCopyOnWriteScope", MemberParameters = new object[] { typeof(ref global::System.Threading.ExecutionContextSwitcher) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.ExecutionContextSwitcher), Member = "Undo", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public void Start<TStateMachine>(ref TStateMachine stateMachine) where TStateMachine : IAsyncStateMachine
		{
			throw null;
		}

		// Token: 0x06001FF4 RID: 8180 RVA: 0x00019E7D File Offset: 0x0001807D
		[global::Cpp2ILInjected.Token(Token = "0x6002259")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B7452C", Offset = "0x1B7452C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FtpWebRequest.<CreateConnectionAsync>d__86", Member = "SetStateMachine", MemberParameters = new object[] { typeof(IAsyncStateMachine) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebClient.<DownloadBitsAsync>d__150", Member = "SetStateMachine", MemberParameters = new object[] { typeof(IAsyncStateMachine) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebClient.<UploadBitsAsync>d__152", Member = "SetStateMachine", MemberParameters = new object[] { typeof(IAsyncStateMachine) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebOperation.<Run>d__58", Member = "SetStateMachine", MemberParameters = new object[] { typeof(IAsyncStateMachine) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			throw null;
		}

		// Token: 0x06001FF5 RID: 8181 RVA: 0x00019E80 File Offset: 0x00018080
		[global::Cpp2ILInjected.Token(Token = "0x600225A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1573BD4", Offset = "0x1573BD4", Length = "0x250")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebClient.<DownloadBitsAsync>d__150", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.AsyncCausalityTracer), Member = "get_LoggingOn", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "get_Task", ReturnType = typeof(global::System.Threading.Tasks.Task))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncMethodBuilderCore), Member = "GetCompletionAction", MemberParameters = new object[]
		{
			typeof(global::System.Threading.Tasks.Task),
			typeof(ref AsyncMethodBuilderCore.MoveNextRunner)
		}, ReturnType = typeof(global::System.Action))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task), Member = "get_Id", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.AsyncCausalityTracer), Member = "TraceOperationCreation", MemberParameters = new object[]
		{
			typeof(global::System.Threading.Tasks.CausalityTraceLevel),
			typeof(int),
			typeof(string),
			typeof(ulong)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncMethodBuilderCore), Member = "PostBoxInitialization", MemberParameters = new object[]
		{
			typeof(IAsyncStateMachine),
			typeof(AsyncMethodBuilderCore.MoveNextRunner),
			typeof(global::System.Threading.Tasks.Task)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter), Member = "UnsafeOnCompleted", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncMethodBuilderCore), Member = "ThrowAsync", MemberParameters = new object[]
		{
			typeof(global::System.Exception),
			typeof(global::System.Threading.SynchronizationContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : ICriticalNotifyCompletion where TStateMachine : IAsyncStateMachine
		{
			throw null;
		}

		// Token: 0x06001FF6 RID: 8182 RVA: 0x00019E83 File Offset: 0x00018083
		[global::Cpp2ILInjected.Token(Token = "0x600225B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B745F0", Offset = "0x1B745F0", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FtpWebRequest.<CreateConnectionAsync>d__86", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebClient.<DownloadBitsAsync>d__150", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebClient.<UploadBitsAsync>d__152", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebOperation.<Run>d__58", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.AsyncCausalityTracer), Member = "get_LoggingOn", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "get_Task", ReturnType = typeof(global::System.Threading.Tasks.Task))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task), Member = "get_Id", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.AsyncCausalityTracer), Member = "TraceOperationCompletion", MemberParameters = new object[]
		{
			typeof(global::System.Threading.Tasks.CausalityTraceLevel),
			typeof(int),
			typeof(global::System.Threading.Tasks.AsyncCausalityStatus)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "NotifySynchronizationContextOfCompletion", ReturnType = typeof(void))]
		public void SetResult()
		{
			throw null;
		}

		// Token: 0x06001FF7 RID: 8183 RVA: 0x00019E86 File Offset: 0x00018086
		[global::Cpp2ILInjected.Token(Token = "0x600225C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B74744", Offset = "0x1B74744", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FtpWebRequest.<CreateConnectionAsync>d__86", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebClient.<DownloadBitsAsync>d__150", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebClient.<UploadBitsAsync>d__152", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebOperation.<Run>d__58", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.AsyncCausalityTracer), Member = "get_LoggingOn", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "get_Task", ReturnType = typeof(global::System.Threading.Tasks.Task))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task), Member = "get_Id", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.AsyncCausalityTracer), Member = "TraceOperationCompletion", MemberParameters = new object[]
		{
			typeof(global::System.Threading.Tasks.CausalityTraceLevel),
			typeof(int),
			typeof(global::System.Threading.Tasks.AsyncCausalityStatus)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncMethodBuilderCore), Member = "ThrowAsync", MemberParameters = new object[]
		{
			typeof(global::System.Exception),
			typeof(global::System.Threading.SynchronizationContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "NotifySynchronizationContextOfCompletion", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public void SetException(global::System.Exception exception)
		{
			throw null;
		}

		// Token: 0x06001FF8 RID: 8184 RVA: 0x00019E89 File Offset: 0x00018089
		[global::Cpp2ILInjected.Token(Token = "0x600225D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B746A8", Offset = "0x1B746A8", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new object[] { typeof(global::System.Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncMethodBuilderCore), Member = "ThrowAsync", MemberParameters = new object[]
		{
			typeof(global::System.Exception),
			typeof(global::System.Threading.SynchronizationContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private void NotifySynchronizationContextOfCompletion()
		{
			throw null;
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06001FF9 RID: 8185 RVA: 0x00019E8C File Offset: 0x0001808C
		[global::Cpp2ILInjected.Token(Token = "0x17000477")]
		internal global::System.Threading.Tasks.Task Task
		{
			[global::Cpp2ILInjected.Token(Token = "0x600225E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B74644", Offset = "0x1B74644", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[] { "TAwaiter", "TStateMachine" }, MemberParameters = new object[] { "TAwaiter&", "TStateMachine&" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new object[] { typeof(global::System.Exception) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04000FC5 RID: 4037
		[global::Cpp2ILInjected.Token(Token = "0x40012C7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private global::System.Threading.SynchronizationContext m_synchronizationContext;

		// Token: 0x04000FC6 RID: 4038
		[global::Cpp2ILInjected.Token(Token = "0x40012C8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private AsyncMethodBuilderCore m_coreState;

		// Token: 0x04000FC7 RID: 4039
		[global::Cpp2ILInjected.Token(Token = "0x40012C9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private global::System.Threading.Tasks.Task m_task;
	}
}
