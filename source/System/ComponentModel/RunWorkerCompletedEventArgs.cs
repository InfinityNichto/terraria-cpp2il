using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x020002EB RID: 747
	[global::Cpp2ILInjected.Token(Token = "0x20003EC")]
	public class RunWorkerCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06001863 RID: 6243 RVA: 0x000072BF File Offset: 0x000054BF
		[global::Cpp2ILInjected.Token(Token = "0x6001ADA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E777B8", Offset = "0x1E777B8", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BackgroundWorker), Member = "WorkerThreadStart", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncCompletedEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Exception),
			typeof(bool),
			typeof(object)
		}, ReturnType = typeof(void))]
		public RunWorkerCompletedEventArgs(object result, Exception error, bool cancelled)
		{
			throw null;
		}

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x06001864 RID: 6244 RVA: 0x000072C2 File Offset: 0x000054C2
		[global::Cpp2ILInjected.Token(Token = "0x17000627")]
		public object Result
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001ADB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E777F0", Offset = "0x1E777F0", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncCompletedEventArgs), Member = "RaiseExceptionIfNecessary", ReturnType = typeof(void))]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x06001865 RID: 6245 RVA: 0x000072C5 File Offset: 0x000054C5
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		[global::Cpp2ILInjected.Token(Token = "0x17000628")]
		public new object UserState
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001ADC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E7780C", Offset = "0x1E7780C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04000F25 RID: 3877
		[global::Cpp2ILInjected.Token(Token = "0x400134E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private object result;
	}
}
