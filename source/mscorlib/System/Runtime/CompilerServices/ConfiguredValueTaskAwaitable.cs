using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020003BB RID: 955
	[global::Cpp2ILInjected.Token(Token = "0x2000468")]
	[StructLayout(3)]
	public readonly struct ConfiguredValueTaskAwaitable
	{
		// Token: 0x06001FB3 RID: 8115 RVA: 0x00019DC9 File Offset: 0x00017FC9
		[global::Cpp2ILInjected.Token(Token = "0x60021FC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B72F34", Offset = "0x1B72F34", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		internal ConfiguredValueTaskAwaitable(global::System.Threading.Tasks.ValueTask value)
		{
			throw null;
		}

		// Token: 0x06001FB4 RID: 8116 RVA: 0x00019DCC File Offset: 0x00017FCC
		[global::Cpp2ILInjected.Token(Token = "0x60021FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B72F3C", Offset = "0x1B72F3C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter GetAwaiter()
		{
			throw null;
		}

		// Token: 0x04000FB3 RID: 4019
		[global::Cpp2ILInjected.Token(Token = "0x40012AA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly global::System.Threading.Tasks.ValueTask _value;

		// Token: 0x020005F8 RID: 1528
		[global::Cpp2ILInjected.Token(Token = "0x2000469")]
		[StructLayout(3)]
		public readonly struct ConfiguredValueTaskAwaiter : ICriticalNotifyCompletion
		{
			// Token: 0x06004120 RID: 16672 RVA: 0x0001FDFC File Offset: 0x0001DFFC
			[global::Cpp2ILInjected.Token(Token = "0x60021FE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B72F48", Offset = "0x1B72F48", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[MethodImpl(256)]
			internal ConfiguredValueTaskAwaiter(global::System.Threading.Tasks.ValueTask value)
			{
				throw null;
			}

			// Token: 0x17000759 RID: 1881
			// (get) Token: 0x06004121 RID: 16673 RVA: 0x0001FDFF File Offset: 0x0001DFFF
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

			// Token: 0x06004122 RID: 16674 RVA: 0x0001FE02 File Offset: 0x0001E002
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

			// Token: 0x06004123 RID: 16675 RVA: 0x0001FE05 File Offset: 0x0001E005
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

			// Token: 0x0400197F RID: 6527
			[global::Cpp2ILInjected.Token(Token = "0x40012AB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private readonly global::System.Threading.Tasks.ValueTask _value;
		}
	}
}
