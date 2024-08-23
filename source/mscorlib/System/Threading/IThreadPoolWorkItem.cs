using System;
using Cpp2ILInjected;

namespace System.Threading
{
	// Token: 0x02000197 RID: 407
	[global::Cpp2ILInjected.Token(Token = "0x20001FC")]
	internal interface IThreadPoolWorkItem
	{
		// Token: 0x060010D9 RID: 4313
		[global::Cpp2ILInjected.Token(Token = "0x6001232")]
		void ExecuteWorkItem();

		// Token: 0x060010DA RID: 4314
		[global::Cpp2ILInjected.Token(Token = "0x6001233")]
		void MarkAborted(ThreadAbortException tae);
	}
}
