using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.CompilerServices
{
	[global::Cpp2ILInjected.Token(Token = "0x200048B")]
	public readonly struct ConfiguredTaskAwaitable<TResult>
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x6002251")]
		[global::Cpp2ILInjected.Address(RVA = "0x19209A8", Offset = "0x19209A8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter GetAwaiter()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40012C4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter m_configuredTaskAwaiter;

		[global::Cpp2ILInjected.Token(Token = "0x200048C")]
		public readonly struct ConfiguredTaskAwaiter : ICriticalNotifyCompletion
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002252")]
			[global::Cpp2ILInjected.Address(RVA = "0x1920D14", Offset = "0x1920D14", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal ConfiguredTaskAwaiter(global::System.Threading.Tasks.Task<TResult> task, bool continueOnCapturedContext)
			{
				throw null;
			}

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

			[global::Cpp2ILInjected.Token(Token = "0x40012C5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private readonly global::System.Threading.Tasks.Task<TResult> m_task;

			[global::Cpp2ILInjected.Token(Token = "0x40012C6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private readonly bool m_continueOnCapturedContext;
		}
	}
}
