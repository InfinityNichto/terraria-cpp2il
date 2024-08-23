using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading
{
	// Token: 0x0200019E RID: 414
	[global::Cpp2ILInjected.Token(Token = "0x2000206")]
	internal sealed class QueueUserWorkItemCallback : IThreadPoolWorkItem
	{
		// Token: 0x060010ED RID: 4333 RVA: 0x000174B3 File Offset: 0x000156B3
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

		// Token: 0x060010EE RID: 4334 RVA: 0x000174B6 File Offset: 0x000156B6
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

		// Token: 0x060010EF RID: 4335 RVA: 0x000174B9 File Offset: 0x000156B9
		[global::Cpp2ILInjected.Token(Token = "0x6001258")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA011C", Offset = "0x1CA011C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae)
		{
			throw null;
		}

		// Token: 0x060010F0 RID: 4336 RVA: 0x000174BC File Offset: 0x000156BC
		[global::Cpp2ILInjected.Token(Token = "0x6001259")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA0120", Offset = "0x1CA0120", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static void WaitCallback_Context(object state)
		{
			throw null;
		}

		// Token: 0x060010F1 RID: 4337 RVA: 0x000174BF File Offset: 0x000156BF
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

		// Token: 0x04000796 RID: 1942
		[global::Cpp2ILInjected.Token(Token = "0x40009C9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private WaitCallback callback;

		// Token: 0x04000797 RID: 1943
		[global::Cpp2ILInjected.Token(Token = "0x40009CA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private ExecutionContext context;

		// Token: 0x04000798 RID: 1944
		[global::Cpp2ILInjected.Token(Token = "0x40009CB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private object state;

		// Token: 0x04000799 RID: 1945
		[global::Cpp2ILInjected.Token(Token = "0x40009CC")]
		internal static ContextCallback ccb;
	}
}
