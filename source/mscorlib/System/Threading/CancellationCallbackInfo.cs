using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading
{
	// Token: 0x02000180 RID: 384
	[global::Cpp2ILInjected.Token(Token = "0x20001D7")]
	internal class CancellationCallbackInfo
	{
		// Token: 0x06000FEE RID: 4078 RVA: 0x0001721F File Offset: 0x0001541F
		[global::Cpp2ILInjected.Token(Token = "0x600112B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C96E8C", Offset = "0x1C96E8C", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal CancellationCallbackInfo(global::System.Action<object> callback, object stateForCallback, ExecutionContext targetExecutionContext, CancellationTokenSource cancellationTokenSource)
		{
			throw null;
		}

		// Token: 0x06000FEF RID: 4079 RVA: 0x00017222 File Offset: 0x00015422
		[global::Cpp2ILInjected.Token(Token = "0x600112C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C974DC", Offset = "0x1C974DC", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CancellationTokenSource), Member = "CancellationCallbackCoreWork", MemberParameters = new object[] { typeof(CancellationCallbackCoreWorkArguments) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContextCallback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecutionContext), Member = "Run", MemberParameters = new object[]
		{
			typeof(ExecutionContext),
			typeof(ContextCallback),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationCallbackInfo), Member = "ExecutionContextCallback", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal void ExecuteCallback()
		{
			throw null;
		}

		// Token: 0x06000FF0 RID: 4080 RVA: 0x00017225 File Offset: 0x00015425
		[global::Cpp2ILInjected.Token(Token = "0x600112D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C97EB4", Offset = "0x1C97EB4", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CancellationCallbackInfo), Member = "ExecuteCallback", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static void ExecutionContextCallback(object obj)
		{
			throw null;
		}

		// Token: 0x04000737 RID: 1847
		[global::Cpp2ILInjected.Token(Token = "0x400093D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal readonly global::System.Action<object> Callback;

		// Token: 0x04000738 RID: 1848
		[global::Cpp2ILInjected.Token(Token = "0x400093E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal readonly object StateForCallback;

		// Token: 0x04000739 RID: 1849
		[global::Cpp2ILInjected.Token(Token = "0x400093F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal readonly ExecutionContext TargetExecutionContext;

		// Token: 0x0400073A RID: 1850
		[global::Cpp2ILInjected.Token(Token = "0x4000940")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal readonly CancellationTokenSource CancellationTokenSource;

		// Token: 0x0400073B RID: 1851
		[global::Cpp2ILInjected.Token(Token = "0x4000941")]
		private static ContextCallback s_executionContextCallback;

		// Token: 0x020005A4 RID: 1444
		[global::Cpp2ILInjected.Token(Token = "0x20001D8")]
		internal sealed class WithSyncContext : CancellationCallbackInfo
		{
			// Token: 0x0600401A RID: 16410 RVA: 0x0001FB05 File Offset: 0x0001DD05
			[global::Cpp2ILInjected.Token(Token = "0x600112E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C96ECC", Offset = "0x1C96ECC", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			internal WithSyncContext(global::System.Action<object> callback, object stateForCallback, ExecutionContext targetExecutionContext, CancellationTokenSource cancellationTokenSource, SynchronizationContext targetSyncContext)
			{
				throw null;
			}

			// Token: 0x04001890 RID: 6288
			[global::Cpp2ILInjected.Token(Token = "0x4000942")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			internal readonly SynchronizationContext TargetSyncContext;
		}
	}
}
