using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading
{
	[global::Cpp2ILInjected.Token(Token = "0x20001D7")]
	internal class CancellationCallbackInfo
	{
		[global::Cpp2ILInjected.Token(Token = "0x600112B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C96E8C", Offset = "0x1C96E8C", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal CancellationCallbackInfo(global::System.Action<object> callback, object stateForCallback, ExecutionContext targetExecutionContext, CancellationTokenSource cancellationTokenSource)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x400093D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal readonly global::System.Action<object> Callback;

		[global::Cpp2ILInjected.Token(Token = "0x400093E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal readonly object StateForCallback;

		[global::Cpp2ILInjected.Token(Token = "0x400093F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal readonly ExecutionContext TargetExecutionContext;

		[global::Cpp2ILInjected.Token(Token = "0x4000940")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal readonly CancellationTokenSource CancellationTokenSource;

		[global::Cpp2ILInjected.Token(Token = "0x4000941")]
		private static ContextCallback s_executionContextCallback;

		[global::Cpp2ILInjected.Token(Token = "0x20001D8")]
		internal sealed class WithSyncContext : CancellationCallbackInfo
		{
			[global::Cpp2ILInjected.Token(Token = "0x600112E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C96ECC", Offset = "0x1C96ECC", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			internal WithSyncContext(global::System.Action<object> callback, object stateForCallback, ExecutionContext targetExecutionContext, CancellationTokenSource cancellationTokenSource, SynchronizationContext targetSyncContext)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4000942")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			internal readonly SynchronizationContext TargetSyncContext;
		}
	}
}
