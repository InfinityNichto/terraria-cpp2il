using System;
using System.Net;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x0200023E RID: 574
	[global::Cpp2ILInjected.Token(Token = "0x200032F")]
	public static class AsyncOperationManager
	{
		// Token: 0x06001301 RID: 4865 RVA: 0x00006494 File Offset: 0x00004694
		[global::Cpp2ILInjected.Token(Token = "0x600153F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3A608", Offset = "0x1E3A608", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "StartAsyncOperation", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(AsyncOperation))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncOperationManager), Member = "get_SynchronizationContext", ReturnType = typeof(SynchronizationContext))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncOperation), Member = "CreateOperation", MemberParameters = new object[]
		{
			typeof(object),
			typeof(SynchronizationContext)
		}, ReturnType = typeof(AsyncOperation))]
		public static AsyncOperation CreateOperation(object userSuppliedState)
		{
			throw null;
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06001302 RID: 4866 RVA: 0x00006497 File Offset: 0x00004697
		// (set) Token: 0x06001303 RID: 4867 RVA: 0x0000649A File Offset: 0x0000469A
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[global::Cpp2ILInjected.Token(Token = "0x170004D9")]
		public static SynchronizationContext SynchronizationContext
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001540")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E3A624", Offset = "0x1E3A624", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AsyncOperationManager), Member = "CreateOperation", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(AsyncOperation))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BackgroundWorker), Member = "RunWorkerAsync", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SynchronizationContext), Member = "get_Current", ReturnType = typeof(SynchronizationContext))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SynchronizationContext), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SynchronizationContext), Member = "SetSynchronizationContext", MemberParameters = new object[] { typeof(SynchronizationContext) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001541")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E3A688", Offset = "0x1E3A688", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SynchronizationContext), Member = "SetSynchronizationContext", MemberParameters = new object[] { typeof(SynchronizationContext) }, ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}
	}
}
