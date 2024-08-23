using System;
using System.Net;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x0200023D RID: 573
	[global::Cpp2ILInjected.Token(Token = "0x200032E")]
	public sealed class AsyncOperation
	{
		// Token: 0x060012F4 RID: 4852 RVA: 0x0000646D File Offset: 0x0000466D
		[global::Cpp2ILInjected.Token(Token = "0x6001532")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3A214", Offset = "0x1E3A214", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private AsyncOperation(object userSuppliedState, SynchronizationContext syncContext)
		{
			throw null;
		}

		// Token: 0x060012F5 RID: 4853 RVA: 0x00006470 File Offset: 0x00004670
		[global::Cpp2ILInjected.Token(Token = "0x6001533")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3A250", Offset = "0x1E3A250", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected override void Finalize()
		{
			throw null;
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x060012F6 RID: 4854 RVA: 0x00006473 File Offset: 0x00004673
		[global::Cpp2ILInjected.Token(Token = "0x170004D7")]
		public object UserSuppliedState
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001534")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E3A2FC", Offset = "0x1E3A2FC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x060012F7 RID: 4855 RVA: 0x00006476 File Offset: 0x00004676
		[global::Cpp2ILInjected.Token(Token = "0x170004D8")]
		public SynchronizationContext SynchronizationContext
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001535")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E3A304", Offset = "0x1E3A304", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060012F8 RID: 4856 RVA: 0x00006479 File Offset: 0x00004679
		[global::Cpp2ILInjected.Token(Token = "0x6001536")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3A30C", Offset = "0x1E3A30C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "PostProgressChanged", MemberParameters = new object[]
		{
			typeof(AsyncOperation),
			"System.Net.WebClient.ProgressData"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void Post(SendOrPostCallback d, object arg)
		{
			throw null;
		}

		// Token: 0x060012F9 RID: 4857 RVA: 0x0000647C File Offset: 0x0000467C
		[global::Cpp2ILInjected.Token(Token = "0x6001537")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3A36C", Offset = "0x1E3A36C", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "InvokeOperationCompleted", MemberParameters = new object[]
		{
			typeof(AsyncOperation),
			typeof(SendOrPostCallback),
			typeof(AsyncCompletedEventArgs)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncOperation), Member = "PostCore", MemberParameters = new object[]
		{
			typeof(SendOrPostCallback),
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public void PostOperationCompleted(SendOrPostCallback d, object arg)
		{
			throw null;
		}

		// Token: 0x060012FA RID: 4858 RVA: 0x0000647F File Offset: 0x0000467F
		[global::Cpp2ILInjected.Token(Token = "0x6001538")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3A46C", Offset = "0x1E3A46C", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncOperation), Member = "VerifyNotCompleted", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncOperation), Member = "OperationCompletedCore", ReturnType = typeof(void))]
		public void OperationCompleted()
		{
			throw null;
		}

		// Token: 0x060012FB RID: 4859 RVA: 0x00006482 File Offset: 0x00004682
		[global::Cpp2ILInjected.Token(Token = "0x6001539")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3A314", Offset = "0x1E3A314", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AsyncOperation), Member = "PostOperationCompleted", MemberParameters = new object[]
		{
			typeof(SendOrPostCallback),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BackgroundWorker), Member = "ReportProgress", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BackgroundWorker), Member = "WorkerThreadStart", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncOperation), Member = "VerifyNotCompleted", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncOperation), Member = "VerifyDelegateNotNull", MemberParameters = new object[] { typeof(SendOrPostCallback) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void PostCore(SendOrPostCallback d, object arg, bool markCompleted)
		{
			throw null;
		}

		// Token: 0x060012FC RID: 4860 RVA: 0x00006485 File Offset: 0x00004685
		[global::Cpp2ILInjected.Token(Token = "0x600153A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3A388", Offset = "0x1E3A388", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AsyncOperation), Member = "OperationCompleted", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BackgroundWorker), Member = "WorkerThreadStart", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private void OperationCompletedCore()
		{
			throw null;
		}

		// Token: 0x060012FD RID: 4861 RVA: 0x00006488 File Offset: 0x00004688
		[global::Cpp2ILInjected.Token(Token = "0x600153B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3A48C", Offset = "0x1E3A48C", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AsyncOperation), Member = "OperationCompleted", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AsyncOperation), Member = "PostCore", MemberParameters = new object[]
		{
			typeof(SendOrPostCallback),
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void VerifyNotCompleted()
		{
			throw null;
		}

		// Token: 0x060012FE RID: 4862 RVA: 0x0000648B File Offset: 0x0000468B
		[global::Cpp2ILInjected.Token(Token = "0x600153C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3A4E8", Offset = "0x1E3A4E8", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AsyncOperation), Member = "PostCore", MemberParameters = new object[]
		{
			typeof(SendOrPostCallback),
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void VerifyDelegateNotNull(SendOrPostCallback d)
		{
			throw null;
		}

		// Token: 0x060012FF RID: 4863 RVA: 0x0000648E File Offset: 0x0000468E
		[global::Cpp2ILInjected.Token(Token = "0x600153D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3A554", Offset = "0x1E3A554", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AsyncOperationManager), Member = "CreateOperation", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(AsyncOperation))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BackgroundWorker), Member = "RunWorkerAsync", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static AsyncOperation CreateOperation(object userSuppliedState, SynchronizationContext syncContext)
		{
			throw null;
		}

		// Token: 0x06001300 RID: 4864 RVA: 0x00006491 File Offset: 0x00004691
		[global::Cpp2ILInjected.Token(Token = "0x600153E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3A5D0", Offset = "0x1E3A5D0", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal AsyncOperation()
		{
			throw null;
		}

		// Token: 0x04000D76 RID: 3446
		[global::Cpp2ILInjected.Token(Token = "0x4001173")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly SynchronizationContext _syncContext;

		// Token: 0x04000D77 RID: 3447
		[global::Cpp2ILInjected.Token(Token = "0x4001174")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly object _userSuppliedState;

		// Token: 0x04000D78 RID: 3448
		[global::Cpp2ILInjected.Token(Token = "0x4001175")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private bool _alreadyCompleted;
	}
}
