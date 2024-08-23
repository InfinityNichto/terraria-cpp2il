using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020003D3 RID: 979
	[global::Cpp2ILInjected.Token(Token = "0x2000483")]
	public readonly struct ValueTaskAwaiter : ICriticalNotifyCompletion
	{
		// Token: 0x06001FD7 RID: 8151 RVA: 0x00019E26 File Offset: 0x00018026
		[global::Cpp2ILInjected.Token(Token = "0x600222E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B739A4", Offset = "0x1B739A4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		internal ValueTaskAwaiter(global::System.Threading.Tasks.ValueTask value)
		{
			throw null;
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06001FD8 RID: 8152 RVA: 0x00019E29 File Offset: 0x00018029
		[global::Cpp2ILInjected.Token(Token = "0x17000471")]
		public bool IsCompleted
		{
			[global::Cpp2ILInjected.Token(Token = "0x600222F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B739AC", Offset = "0x1B739AC", Length = "0x108")]
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

		// Token: 0x06001FD9 RID: 8153 RVA: 0x00019E2C File Offset: 0x0001802C
		[global::System.Diagnostics.StackTraceHidden]
		[global::Cpp2ILInjected.Token(Token = "0x6002230")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B73AB4", Offset = "0x1B73AB4", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskAwaiter), Member = "ValidateEnd", MemberParameters = new object[] { typeof(global::System.Threading.Tasks.Task) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		[MethodImpl(256)]
		public void GetResult()
		{
			throw null;
		}

		// Token: 0x06001FDA RID: 8154 RVA: 0x00019E2F File Offset: 0x0001802F
		[global::Cpp2ILInjected.Token(Token = "0x6002231")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B73BB4", Offset = "0x1B73BB4", Length = "0x188")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.ValueTask), Member = "get_CompletedTask", ReturnType = typeof(global::System.Threading.Tasks.Task))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task), Member = "GetAwaiter", ReturnType = typeof(TaskAwaiter))]
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

		// Token: 0x06001FDB RID: 8155 RVA: 0x00019E32 File Offset: 0x00018032
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6002232")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B73D4C", Offset = "0x1B73D4C", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Action<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		static ValueTaskAwaiter()
		{
			throw null;
		}

		// Token: 0x04000FBE RID: 4030
		[global::Cpp2ILInjected.Token(Token = "0x40012B9")]
		internal static readonly global::System.Action<object> s_invokeActionDelegate;

		// Token: 0x04000FBF RID: 4031
		[global::Cpp2ILInjected.Token(Token = "0x40012BA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly global::System.Threading.Tasks.ValueTask _value;

		// Token: 0x020005FB RID: 1531
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000484")]
		[global::System.Serializable]
		private sealed class <>c
		{
			// Token: 0x0600412E RID: 16686 RVA: 0x0001FE26 File Offset: 0x0001E026
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6002233")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B73E10", Offset = "0x1B73E10", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			// Token: 0x0600412F RID: 16687 RVA: 0x0001FE29 File Offset: 0x0001E029
			[global::Cpp2ILInjected.Token(Token = "0x6002234")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B73E6C", Offset = "0x1B73E6C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			// Token: 0x06004130 RID: 16688 RVA: 0x0001FE2C File Offset: 0x0001E02C
			[global::Cpp2ILInjected.Token(Token = "0x6002235")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B73E74", Offset = "0x1B73E74", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal void <.cctor>b__9_0(object state)
			{
				throw null;
			}

			// Token: 0x04001983 RID: 6531
			[global::Cpp2ILInjected.Token(Token = "0x40012BB")]
			public static readonly ValueTaskAwaiter.<>c <>9;
		}
	}
}
