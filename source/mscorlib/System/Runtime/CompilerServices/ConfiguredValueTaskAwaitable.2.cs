using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.CompilerServices
{
	[global::Cpp2ILInjected.Token(Token = "0x200046A")]
	[StructLayout(3)]
	public readonly struct ConfiguredValueTaskAwaitable<TResult>
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002202")]
		[global::Cpp2ILInjected.Address(RVA = "0x1921398", Offset = "0x1921398", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		internal ConfiguredValueTaskAwaitable(global::System.Threading.Tasks.ValueTask<TResult> value)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x40012AC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly global::System.Threading.Tasks.ValueTask<TResult> _value;

		[global::Cpp2ILInjected.Token(Token = "0x200046B")]
		[StructLayout(3)]
		public readonly struct ConfiguredValueTaskAwaiter : ICriticalNotifyCompletion
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002204")]
			[global::Cpp2ILInjected.Address(RVA = "0x1921438", Offset = "0x1921438", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[MethodImpl(256)]
			internal ConfiguredValueTaskAwaiter(global::System.Threading.Tasks.ValueTask<TResult> value)
			{
				throw null;
			}

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

			[global::Cpp2ILInjected.Token(Token = "0x40012AD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private readonly global::System.Threading.Tasks.ValueTask<TResult> _value;
		}
	}
}
