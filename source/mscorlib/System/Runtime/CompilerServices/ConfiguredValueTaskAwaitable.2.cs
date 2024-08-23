using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020003BC RID: 956
	[global::Cpp2ILInjected.Token(Token = "0x200046A")]
	[StructLayout(3)]
	public readonly struct ConfiguredValueTaskAwaitable<TResult>
	{
		// Token: 0x06001FB5 RID: 8117 RVA: 0x00019DCF File Offset: 0x00017FCF
		[global::Cpp2ILInjected.Token(Token = "0x6002202")]
		[global::Cpp2ILInjected.Address(RVA = "0x1921398", Offset = "0x1921398", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		internal ConfiguredValueTaskAwaitable(global::System.Threading.Tasks.ValueTask<TResult> value)
		{
			throw null;
		}

		// Token: 0x06001FB6 RID: 8118 RVA: 0x00019DD2 File Offset: 0x00017FD2
		[global::Cpp2ILInjected.Token(Token = "0x6002203")]
		[global::Cpp2ILInjected.Address(RVA = "0x19213A0", Offset = "0x19213A0", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(256)]
		public ConfiguredValueTaskAwaitable<TResult>.ConfiguredValueTaskAwaiter GetAwaiter()
		{
			throw null;
		}

		// Token: 0x04000FB4 RID: 4020
		[global::Cpp2ILInjected.Token(Token = "0x40012AC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly global::System.Threading.Tasks.ValueTask<TResult> _value;

		// Token: 0x020005F9 RID: 1529
		[global::Cpp2ILInjected.Token(Token = "0x200046B")]
		[StructLayout(3)]
		public readonly struct ConfiguredValueTaskAwaiter : ICriticalNotifyCompletion
		{
			// Token: 0x06004124 RID: 16676 RVA: 0x0001FE08 File Offset: 0x0001E008
			[global::Cpp2ILInjected.Token(Token = "0x6002204")]
			[global::Cpp2ILInjected.Address(RVA = "0x1921438", Offset = "0x1921438", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[MethodImpl(256)]
			internal ConfiguredValueTaskAwaiter(global::System.Threading.Tasks.ValueTask<TResult> value)
			{
				throw null;
			}

			// Token: 0x1700075A RID: 1882
			// (get) Token: 0x06004125 RID: 16677 RVA: 0x0001FE0B File Offset: 0x0001E00B
			[global::Cpp2ILInjected.Token(Token = "0x17000464")]
			public bool IsCompleted
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002205")]
				[global::Cpp2ILInjected.Address(RVA = "0x1921440", Offset = "0x1921440", Length = "0x34")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				[MethodImpl(256)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06004126 RID: 16678 RVA: 0x0001FE0E File Offset: 0x0001E00E
			[global::System.Diagnostics.StackTraceHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6002206")]
			[global::Cpp2ILInjected.Address(RVA = "0x1921474", Offset = "0x1921474", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(256)]
			public TResult GetResult()
			{
				throw null;
			}

			// Token: 0x06004127 RID: 16679 RVA: 0x0001FE11 File Offset: 0x0001E011
			[global::Cpp2ILInjected.Token(Token = "0x6002207")]
			[global::Cpp2ILInjected.Address(RVA = "0x19214A8", Offset = "0x19214A8", Length = "0x25C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.ValueTask), Member = "get_CompletedTask", ReturnType = typeof(global::System.Threading.Tasks.Task))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task), Member = "ConfigureAwait", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(ConfiguredTaskAwaitable))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter), Member = "UnsafeOnCompleted", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskAwaiter), Member = "OnCompletedInternal", MemberParameters = new object[]
			{
				typeof(global::System.Threading.Tasks.Task),
				typeof(global::System.Action),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
			public void UnsafeOnCompleted(global::System.Action continuation)
			{
				throw null;
			}

			// Token: 0x04001980 RID: 6528
			[global::Cpp2ILInjected.Token(Token = "0x40012AD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private readonly global::System.Threading.Tasks.ValueTask<TResult> _value;
		}
	}
}
