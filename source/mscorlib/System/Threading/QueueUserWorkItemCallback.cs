using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading
{
	[global::Cpp2ILInjected.Token(Token = "0x2000206")]
	internal sealed class QueueUserWorkItemCallback : IThreadPoolWorkItem
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001256")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9FF94", Offset = "0x1C9FF94", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadPool), Member = "QueueUserWorkItemHelper", MemberParameters = new object[]
		{
			typeof(WaitCallback),
			typeof(object),
			typeof(ref StackCrawlMark),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecutionContext), Member = "IsFlowSuppressed", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecutionContext), Member = "Capture", MemberParameters = new object[]
		{
			typeof(ref StackCrawlMark),
			typeof(ExecutionContext.CaptureOptions)
		}, ReturnType = typeof(ExecutionContext))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal QueueUserWorkItemCallback(WaitCallback waitCallback, object stateObj, bool compressStack, ref StackCrawlMark stackMark)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001257")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA004C", Offset = "0x1CA004C", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecutionContext), Member = "Run", MemberParameters = new object[]
		{
			typeof(ExecutionContext),
			typeof(ContextCallback),
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001258")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA011C", Offset = "0x1CA011C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001259")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA0120", Offset = "0x1CA0120", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static void WaitCallback_Context(object state)
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600125A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA0190", Offset = "0x1CA0190", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContextCallback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static QueueUserWorkItemCallback()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40009C9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private WaitCallback callback;

		[global::Cpp2ILInjected.Token(Token = "0x40009CA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private ExecutionContext context;

		[global::Cpp2ILInjected.Token(Token = "0x40009CB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private object state;

		[global::Cpp2ILInjected.Token(Token = "0x40009CC")]
		internal static ContextCallback ccb;
	}
}
