using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.CompilerServices
{
	[global::Cpp2ILInjected.Token(Token = "0x2000468")]
	[StructLayout(3)]
	public readonly struct ConfiguredValueTaskAwaitable
	{
		[global::Cpp2ILInjected.Token(Token = "0x60021FC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B72F34", Offset = "0x1B72F34", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		internal ConfiguredValueTaskAwaitable(global::System.Threading.Tasks.ValueTask value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60021FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B72F3C", Offset = "0x1B72F3C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter GetAwaiter()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40012AA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly global::System.Threading.Tasks.ValueTask _value;

		[global::Cpp2ILInjected.Token(Token = "0x2000469")]
		[StructLayout(3)]
		public readonly struct ConfiguredValueTaskAwaiter : ICriticalNotifyCompletion
		{
			[global::Cpp2ILInjected.Token(Token = "0x60021FE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B72F48", Offset = "0x1B72F48", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[MethodImpl(256)]
			internal ConfiguredValueTaskAwaiter(global::System.Threading.Tasks.ValueTask value)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x17000463")]
			public bool IsCompleted
			{
				[global::Cpp2ILInjected.Token(Token = "0x60021FF")]
				[global::Cpp2ILInjected.Address(RVA = "0x1B72F50", Offset = "0x1B72F50", Length = "0x108")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
				[MethodImpl(256)]
				get
				{
					throw null;
				}
			}

			[global::System.Diagnostics.StackTraceHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6002200")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B73058", Offset = "0x1B73058", Length = "0x100")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskAwaiter), Member = "ValidateEnd", MemberParameters = new object[] { typeof(global::System.Threading.Tasks.Task) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			[MethodImpl(256)]
			public void GetResult()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002201")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B73158", Offset = "0x1B73158", Length = "0x1A4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.ValueTask), Member = "get_CompletedTask", ReturnType = typeof(global::System.Threading.Tasks.Task))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task), Member = "ConfigureAwait", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(ConfiguredTaskAwaitable))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskAwaiter), Member = "OnCompletedInternal", MemberParameters = new object[]
			{
				typeof(global::System.Threading.Tasks.Task),
				typeof(global::System.Action),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			public void UnsafeOnCompleted(global::System.Action continuation)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x40012AB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private readonly global::System.Threading.Tasks.ValueTask _value;
		}
	}
}
