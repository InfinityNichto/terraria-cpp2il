using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020003D7 RID: 983
	[global::Cpp2ILInjected.Token(Token = "0x2000489")]
	public readonly struct ConfiguredTaskAwaitable
	{
		// Token: 0x06001FED RID: 8173 RVA: 0x00019E68 File Offset: 0x00018068
		[global::Cpp2ILInjected.Token(Token = "0x6002249")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B74488", Offset = "0x1B74488", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.TaskToApm), Member = "InvokeCallbackWhenTaskCompletes", MemberParameters = new object[]
		{
			typeof(global::System.Threading.Tasks.Task),
			typeof(global::System.AsyncCallback),
			typeof(global::System.IAsyncResult)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.ForceAsyncAwaiter), Member = "UnsafeOnCompleted", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.Task), Member = "ConfigureAwait", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		internal ConfiguredTaskAwaitable(global::System.Threading.Tasks.Task task, bool continueOnCapturedContext)
		{
			throw null;
		}

		// Token: 0x06001FEE RID: 8174 RVA: 0x00019E6B File Offset: 0x0001806B
		[global::Cpp2ILInjected.Token(Token = "0x600224A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B744B0", Offset = "0x1B744B0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter GetAwaiter()
		{
			throw null;
		}

		// Token: 0x04000FC3 RID: 4035
		[global::Cpp2ILInjected.Token(Token = "0x40012C1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly ConfiguredTaskAwaitable.ConfiguredTaskAwaiter m_configuredTaskAwaiter;

		// Token: 0x020005FD RID: 1533
		[global::Cpp2ILInjected.Token(Token = "0x200048A")]
		public readonly struct ConfiguredTaskAwaiter : ICriticalNotifyCompletion
		{
			// Token: 0x06004133 RID: 16691 RVA: 0x0001FE35 File Offset: 0x0001E035
			[global::Cpp2ILInjected.Token(Token = "0x600224B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B744A0", Offset = "0x1B744A0", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal ConfiguredTaskAwaiter(global::System.Threading.Tasks.Task task, bool continueOnCapturedContext)
			{
				throw null;
			}

			// Token: 0x1700075D RID: 1885
			// (get) Token: 0x06004134 RID: 16692 RVA: 0x0001FE38 File Offset: 0x0001E038
			[global::Cpp2ILInjected.Token(Token = "0x17000475")]
			public bool IsCompleted
			{
				[global::Cpp2ILInjected.Token(Token = "0x600224C")]
				[global::Cpp2ILInjected.Address(RVA = "0x1B744BC", Offset = "0x1B744BC", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 27)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
				get
				{
					throw null;
				}
			}

			// Token: 0x06004135 RID: 16693 RVA: 0x0001FE3B File Offset: 0x0001E03B
			[global::Cpp2ILInjected.Token(Token = "0x600224D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B744C8", Offset = "0x1B744C8", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.TaskToApm), Member = "InvokeCallbackWhenTaskCompletes", MemberParameters = new object[]
			{
				typeof(global::System.Threading.Tasks.Task),
				typeof(global::System.AsyncCallback),
				typeof(global::System.IAsyncResult)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskAwaiter), Member = "OnCompletedInternal", MemberParameters = new object[]
			{
				typeof(global::System.Threading.Tasks.Task),
				typeof(global::System.Action),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(void))]
			public void OnCompleted(global::System.Action continuation)
			{
				throw null;
			}

			// Token: 0x06004136 RID: 16694 RVA: 0x0001FE3E File Offset: 0x0001E03E
			[global::Cpp2ILInjected.Token(Token = "0x600224E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B732FC", Offset = "0x1B732FC", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.ForceAsyncAwaiter), Member = "UnsafeOnCompleted", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConfiguredValueTaskAwaitable<>.ConfiguredValueTaskAwaiter), Member = "UnsafeOnCompleted", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
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

			// Token: 0x06004137 RID: 16695 RVA: 0x0001FE41 File Offset: 0x0001E041
			[global::System.Diagnostics.StackTraceHidden]
			[global::Cpp2ILInjected.Token(Token = "0x600224F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B744DC", Offset = "0x1B744DC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 27)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskAwaiter), Member = "ValidateEnd", MemberParameters = new object[] { typeof(global::System.Threading.Tasks.Task) }, ReturnType = typeof(void))]
			public void GetResult()
			{
				throw null;
			}

			// Token: 0x04001986 RID: 6534
			[global::Cpp2ILInjected.Token(Token = "0x40012C2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal readonly global::System.Threading.Tasks.Task m_task;

			// Token: 0x04001987 RID: 6535
			[global::Cpp2ILInjected.Token(Token = "0x40012C3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			internal readonly bool m_continueOnCapturedContext;
		}
	}
}
