using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Internal.Threading.Tasks.Tracing;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020003D5 RID: 981
	[global::Cpp2ILInjected.Token(Token = "0x2000486")]
	public readonly struct TaskAwaiter : ICriticalNotifyCompletion
	{
		// Token: 0x06001FE0 RID: 8160 RVA: 0x00019E41 File Offset: 0x00018041
		[global::Cpp2ILInjected.Token(Token = "0x600223A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B73EE8", Offset = "0x1B73EE8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal TaskAwaiter(global::System.Threading.Tasks.Task task)
		{
			throw null;
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06001FE1 RID: 8161 RVA: 0x00019E44 File Offset: 0x00018044
		[global::Cpp2ILInjected.Token(Token = "0x17000473")]
		public bool IsCompleted
		{
			[global::Cpp2ILInjected.Token(Token = "0x600223B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B73EF0", Offset = "0x1B73EF0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.CryptoStream.<WriteAsyncInternal>d__46", Member = "MoveNext", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebRequestStream.<WriteAsyncInner>d__33", Member = "MoveNext", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebRequestStream.<Initialize>d__36", Member = "MoveNext", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebRequestStream.<WriteRequestAsync>d__38", Member = "MoveNext", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001FE2 RID: 8162 RVA: 0x00019E47 File Offset: 0x00018047
		[global::Cpp2ILInjected.Token(Token = "0x600223C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B73D3C", Offset = "0x1B73D3C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ValueTaskAwaiter<>), Member = "UnsafeOnCompleted", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskAwaiter), Member = "OnCompletedInternal", MemberParameters = new object[]
		{
			typeof(global::System.Threading.Tasks.Task),
			typeof(global::System.Action),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public void UnsafeOnCompleted(global::System.Action continuation)
		{
			throw null;
		}

		// Token: 0x06001FE3 RID: 8163 RVA: 0x00019E4A File Offset: 0x0001804A
		[global::System.Diagnostics.StackTraceHidden]
		[global::Cpp2ILInjected.Token(Token = "0x600223D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B73FA4", Offset = "0x1B73FA4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.TaskToApm), Member = "End", MemberParameters = new object[] { typeof(global::System.IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.ForceAsyncAwaiter), Member = "GetResult", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.CryptoStream.<WriteAsyncInternal>d__46", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.CryptoStream), Member = "Write", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebRequestStream.<WriteAsyncInner>d__33", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebRequestStream.<Initialize>d__36", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebRequestStream.<WriteRequestAsync>d__38", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		public void GetResult()
		{
			throw null;
		}

		// Token: 0x06001FE4 RID: 8164 RVA: 0x00019E4D File Offset: 0x0001804D
		[global::System.Diagnostics.StackTraceHidden]
		[global::Cpp2ILInjected.Token(Token = "0x600223E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B73FAC", Offset = "0x1B73FAC", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.ValueTask), Member = "ThrowIfCompletedUnsuccessfully", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.ValueTask<>), Member = "get_Result", ReturnType = "TResult")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.CryptoStream.<WriteAsyncCore>d__49", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter), Member = "GetResult", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ValueTaskAwaiter), Member = "GetResult", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TaskAwaiter<>), Member = "GetResult", ReturnType = "TResult")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter), Member = "GetResult", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConfiguredTaskAwaitable<>.ConfiguredTaskAwaiter), Member = "GetResult", ReturnType = "TResult")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebClient.<DownloadBitsAsync>d__150", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebClient.<UploadBitsAsync>d__152", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 16)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal static void ValidateEnd(global::System.Threading.Tasks.Task task)
		{
			throw null;
		}

		// Token: 0x06001FE5 RID: 8165 RVA: 0x00019E50 File Offset: 0x00018050
		[global::System.Diagnostics.StackTraceHidden]
		[global::Cpp2ILInjected.Token(Token = "0x600223F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B73FF0", Offset = "0x1B73FF0", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task), Member = "InternalWait", MemberParameters = new object[]
		{
			typeof(int),
			typeof(global::System.Threading.CancellationToken)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task), Member = "NotifyDebuggerOfWaitCompletionIfNecessary", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task), Member = "get_IsCompletedSuccessfully", ReturnType = typeof(bool))]
		private static void HandleNonSuccessAndDebuggerNotification(global::System.Threading.Tasks.Task task)
		{
			throw null;
		}

		// Token: 0x06001FE6 RID: 8166 RVA: 0x00019E53 File Offset: 0x00018053
		[global::System.Diagnostics.StackTraceHidden]
		[global::Cpp2ILInjected.Token(Token = "0x6002240")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B74048", Offset = "0x1B74048", Length = "0x114")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task), Member = "get_Status", ReturnType = typeof(global::System.Threading.Tasks.TaskStatus))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task), Member = "GetExceptionDispatchInfos", ReturnType = typeof(global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Runtime.ExceptionServices.ExceptionDispatchInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.ObjectModel.ReadOnlyCollection<object>), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task), Member = "get_Exception", ReturnType = typeof(global::System.AggregateException))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task), Member = "GetCancellationExceptionDispatchInfo", ReturnType = typeof(global::System.Runtime.ExceptionServices.ExceptionDispatchInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.TaskCanceledException), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Threading.Tasks.Task) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.ExceptionServices.ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private static void ThrowForNonSuccess(global::System.Threading.Tasks.Task task)
		{
			throw null;
		}

		// Token: 0x06001FE7 RID: 8167 RVA: 0x00019E56 File Offset: 0x00018056
		[global::Cpp2ILInjected.Token(Token = "0x6002241")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B73EFC", Offset = "0x1B73EFC", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter), Member = "UnsafeOnCompleted", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConfiguredValueTaskAwaitable<>.ConfiguredValueTaskAwaiter), Member = "UnsafeOnCompleted", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ValueTaskAwaiter), Member = "UnsafeOnCompleted", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TaskAwaiter), Member = "UnsafeOnCompleted", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TaskAwaiter<>), Member = "UnsafeOnCompleted", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter), Member = "OnCompleted", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter), Member = "UnsafeOnCompleted", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConfiguredTaskAwaitable<>.ConfiguredTaskAwaiter), Member = "UnsafeOnCompleted", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Internal.Threading.Tasks.Tracing.TaskTrace), Member = "get_Enabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskAwaiter), Member = "OutputWaitEtwEvents", MemberParameters = new object[]
		{
			typeof(global::System.Threading.Tasks.Task),
			typeof(global::System.Action)
		}, ReturnType = typeof(global::System.Action))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task), Member = "SetContinuationForAwait", MemberParameters = new object[]
		{
			typeof(global::System.Action),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal static void OnCompletedInternal(global::System.Threading.Tasks.Task task, global::System.Action continuation, bool continueOnCapturedContext, bool flowExecutionContext)
		{
			throw null;
		}

		// Token: 0x06001FE8 RID: 8168 RVA: 0x00019E59 File Offset: 0x00018059
		[global::Cpp2ILInjected.Token(Token = "0x6002242")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B7415C", Offset = "0x1B7415C", Length = "0x1C4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TaskAwaiter), Member = "OnCompletedInternal", MemberParameters = new object[]
		{
			typeof(global::System.Threading.Tasks.Task),
			typeof(global::System.Action),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.TaskScheduler), Member = "get_Id", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task), Member = "get_Id", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Internal.Threading.Tasks.Tracing.TaskTrace), Member = "TaskWaitBegin_Asynchronous", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Action), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		private static global::System.Action OutputWaitEtwEvents(global::System.Threading.Tasks.Task task, global::System.Action continuation)
		{
			throw null;
		}

		// Token: 0x04000FC1 RID: 4033
		[global::Cpp2ILInjected.Token(Token = "0x40012BD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		internal readonly global::System.Threading.Tasks.Task m_task;

		// Token: 0x020005FC RID: 1532
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000487")]
		private sealed class <>c__DisplayClass11_0
		{
			// Token: 0x06004131 RID: 16689 RVA: 0x0001FE2F File Offset: 0x0001E02F
			[global::Cpp2ILInjected.Token(Token = "0x6002243")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B74320", Offset = "0x1B74320", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass11_0()
			{
				throw null;
			}

			// Token: 0x06004132 RID: 16690 RVA: 0x0001FE32 File Offset: 0x0001E032
			[global::Cpp2ILInjected.Token(Token = "0x6002244")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B74328", Offset = "0x1B74328", Length = "0x160")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Internal.Threading.Tasks.Tracing.TaskTrace), Member = "get_Enabled", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.TaskScheduler), Member = "get_Id", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task), Member = "get_Id", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Internal.Threading.Tasks.Tracing.TaskTrace), Member = "TaskWaitEnd", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
			internal void <OutputWaitEtwEvents>b__0()
			{
				throw null;
			}

			// Token: 0x04001984 RID: 6532
			[global::Cpp2ILInjected.Token(Token = "0x40012BE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public global::System.Threading.Tasks.Task task;

			// Token: 0x04001985 RID: 6533
			[global::Cpp2ILInjected.Token(Token = "0x40012BF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public global::System.Action continuation;
		}
	}
}
