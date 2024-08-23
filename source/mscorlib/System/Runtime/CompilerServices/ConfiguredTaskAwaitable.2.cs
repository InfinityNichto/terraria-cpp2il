using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020003D8 RID: 984
	[global::Cpp2ILInjected.Token(Token = "0x200048B")]
	public readonly struct ConfiguredTaskAwaitable<TResult>
	{
		// Token: 0x06001FEF RID: 8175 RVA: 0x00019E6E File Offset: 0x0001806E
		[global::Cpp2ILInjected.Token(Token = "0x6002250")]
		[global::Cpp2ILInjected.Address(RVA = "0x1920948", Offset = "0x1920948", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.Task<>), Member = "ConfigureAwait", MemberParameters = new object[] { typeof(bool) }, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal ConfiguredTaskAwaitable(global::System.Threading.Tasks.Task<TResult> task, bool continueOnCapturedContext)
		{
			throw null;
		}

		// Token: 0x06001FF0 RID: 8176 RVA: 0x00019E71 File Offset: 0x00018071
		[global::Cpp2ILInjected.Token(Token = "0x6002251")]
		[global::Cpp2ILInjected.Address(RVA = "0x19209A8", Offset = "0x19209A8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter GetAwaiter()
		{
			throw null;
		}

		// Token: 0x04000FC4 RID: 4036
		[global::Cpp2ILInjected.Token(Token = "0x40012C4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter m_configuredTaskAwaiter;

		// Token: 0x020005FE RID: 1534
		[global::Cpp2ILInjected.Token(Token = "0x200048C")]
		public readonly struct ConfiguredTaskAwaiter : ICriticalNotifyCompletion
		{
			// Token: 0x06004138 RID: 16696 RVA: 0x0001FE44 File Offset: 0x0001E044
			[global::Cpp2ILInjected.Token(Token = "0x6002252")]
			[global::Cpp2ILInjected.Address(RVA = "0x1920D14", Offset = "0x1920D14", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal ConfiguredTaskAwaiter(global::System.Threading.Tasks.Task<TResult> task, bool continueOnCapturedContext)
			{
				throw null;
			}

			// Token: 0x1700075E RID: 1886
			// (get) Token: 0x06004139 RID: 16697 RVA: 0x0001FE47 File Offset: 0x0001E047
			[global::Cpp2ILInjected.Token(Token = "0x17000476")]
			public bool IsCompleted
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002253")]
				[global::Cpp2ILInjected.Address(RVA = "0x1920D24", Offset = "0x1920D24", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Net.Security.AsyncProtocolRequest.<ProcessOperation>d__24", Member = "MoveNext", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
				get
				{
					throw null;
				}
			}

			// Token: 0x0600413A RID: 16698 RVA: 0x0001FE4A File Offset: 0x0001E04A
			[global::Cpp2ILInjected.Token(Token = "0x6002254")]
			[global::Cpp2ILInjected.Address(RVA = "0x1920D30", Offset = "0x1920D30", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
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

			// Token: 0x0600413B RID: 16699 RVA: 0x0001FE4D File Offset: 0x0001E04D
			[global::System.Diagnostics.StackTraceHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6002255")]
			[global::Cpp2ILInjected.Address(RVA = "0x1920D48", Offset = "0x1920D48", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Net.Security.AsyncProtocolRequest.<ProcessOperation>d__24", Member = "MoveNext", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskAwaiter), Member = "ValidateEnd", MemberParameters = new object[] { typeof(global::System.Threading.Tasks.Task) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public TResult GetResult()
			{
				throw null;
			}

			// Token: 0x04001988 RID: 6536
			[global::Cpp2ILInjected.Token(Token = "0x40012C5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private readonly global::System.Threading.Tasks.Task<TResult> m_task;

			// Token: 0x04001989 RID: 6537
			[global::Cpp2ILInjected.Token(Token = "0x40012C6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private readonly bool m_continueOnCapturedContext;
		}
	}
}
