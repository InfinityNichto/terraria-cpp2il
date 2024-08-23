using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading.Tasks
{
	// Token: 0x020001AA RID: 426
	[global::Cpp2ILInjected.Token(Token = "0x2000218")]
	public class TaskCompletionSource<TResult>
	{
		// Token: 0x06001159 RID: 4441 RVA: 0x00017591 File Offset: 0x00015791
		[global::Cpp2ILInjected.Token(Token = "0x60012D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1870404", Offset = "0x1870404", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.ServicePointScheduler.AsyncManualResetEvent", Member = "Reset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.ServicePointScheduler.AsyncManualResetEvent", Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public TaskCompletionSource()
		{
			throw null;
		}

		// Token: 0x0600115A RID: 4442 RVA: 0x00017594 File Offset: 0x00015794
		[global::Cpp2ILInjected.Token(Token = "0x60012D4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1870460", Offset = "0x1870460", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public TaskCompletionSource(TaskCreationOptions creationOptions)
		{
			throw null;
		}

		// Token: 0x0600115B RID: 4443 RVA: 0x00017597 File Offset: 0x00015797
		[global::Cpp2ILInjected.Token(Token = "0x60012D5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1870480", Offset = "0x1870480", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public TaskCompletionSource(object state)
		{
			throw null;
		}

		// Token: 0x0600115C RID: 4444 RVA: 0x0001759A File Offset: 0x0001579A
		[global::Cpp2ILInjected.Token(Token = "0x60012D6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1870498", Offset = "0x1870498", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public TaskCompletionSource(object state, TaskCreationOptions creationOptions)
		{
			throw null;
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x0600115D RID: 4445 RVA: 0x0001759D File Offset: 0x0001579D
		[global::Cpp2ILInjected.Token(Token = "0x170001C5")]
		public Task<TResult> Task
		{
			[global::Cpp2ILInjected.Token(Token = "0x60012D7")]
			[global::Cpp2ILInjected.Address(RVA = "0x187050C", Offset = "0x187050C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600115E RID: 4446 RVA: 0x000175A0 File Offset: 0x000157A0
		[global::Cpp2ILInjected.Token(Token = "0x60012D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1870514", Offset = "0x1870514", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpinWait), Member = "SpinOnce", ReturnType = typeof(void))]
		private void SpinUntilCompleted()
		{
			throw null;
		}

		// Token: 0x0600115F RID: 4447 RVA: 0x000175A3 File Offset: 0x000157A3
		[global::Cpp2ILInjected.Token(Token = "0x60012D9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1870554", Offset = "0x1870554", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "TrySetException", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
		public bool TrySetException(global::System.Exception exception)
		{
			throw null;
		}

		// Token: 0x06001160 RID: 4448 RVA: 0x000175A6 File Offset: 0x000157A6
		[global::Cpp2ILInjected.Token(Token = "0x60012DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x18705C4", Offset = "0x18705C4", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.ServicePointScheduler.AsyncManualResetEvent.<>c", Member = "<Set>b__4_0", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public bool TrySetResult(TResult result)
		{
			throw null;
		}

		// Token: 0x06001161 RID: 4449 RVA: 0x000175A9 File Offset: 0x000157A9
		[global::Cpp2ILInjected.Token(Token = "0x60012DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1870620", Offset = "0x1870620", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public bool TrySetCanceled()
		{
			throw null;
		}

		// Token: 0x06001162 RID: 4450 RVA: 0x000175AC File Offset: 0x000157AC
		[global::Cpp2ILInjected.Token(Token = "0x60012DC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1870638", Offset = "0x1870638", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "TrySetCanceled", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
		public bool TrySetCanceled(CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x040007E0 RID: 2016
		[global::Cpp2ILInjected.Token(Token = "0x4000A1C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly Task<TResult> _task;
	}
}
