using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x020002E0 RID: 736
	[global::Cpp2ILInjected.Token(Token = "0x20003E0")]
	public class DoWorkEventArgs : CancelEventArgs
	{
		// Token: 0x060017D0 RID: 6096 RVA: 0x0000712A File Offset: 0x0000532A
		[global::Cpp2ILInjected.Token(Token = "0x6001A39")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E65460", Offset = "0x1E65460", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BackgroundWorker), Member = "WorkerThreadStart", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancelEventArgs), Member = ".ctor", ReturnType = typeof(void))]
		public DoWorkEventArgs(object argument)
		{
			throw null;
		}

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x060017D1 RID: 6097 RVA: 0x0000712D File Offset: 0x0000532D
		[SRDescription("Argument passed into the worker handler from BackgroundWorker.RunWorkerAsync.")]
		[global::Cpp2ILInjected.Token(Token = "0x17000605")]
		public object Argument
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A3A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E65488", Offset = "0x1E65488", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x060017D2 RID: 6098 RVA: 0x00007130 File Offset: 0x00005330
		// (set) Token: 0x060017D3 RID: 6099 RVA: 0x00007133 File Offset: 0x00005333
		[SRDescription("Result from the worker function.")]
		[global::Cpp2ILInjected.Token(Token = "0x17000606")]
		public object Result
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A3B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E65490", Offset = "0x1E65490", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001A3C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E65498", Offset = "0x1E65498", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x04000EE6 RID: 3814
		[global::Cpp2ILInjected.Token(Token = "0x4001307")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private object result;

		// Token: 0x04000EE7 RID: 3815
		[global::Cpp2ILInjected.Token(Token = "0x4001308")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private object argument;
	}
}
