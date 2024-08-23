using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading.Tasks
{
	// Token: 0x020001CD RID: 461
	[global::Cpp2ILInjected.Token(Token = "0x2000250")]
	public class UnobservedTaskExceptionEventArgs : global::System.EventArgs
	{
		// Token: 0x06001297 RID: 4759 RVA: 0x0001793C File Offset: 0x00015B3C
		[global::Cpp2ILInjected.Token(Token = "0x600144D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CADEAC", Offset = "0x1CADEAC", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TaskExceptionHolder), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.EventArgs), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public UnobservedTaskExceptionEventArgs(global::System.AggregateException exception)
		{
			throw null;
		}

		// Token: 0x04000858 RID: 2136
		[global::Cpp2ILInjected.Token(Token = "0x4000AC3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private global::System.AggregateException m_exception;

		// Token: 0x04000859 RID: 2137
		[global::Cpp2ILInjected.Token(Token = "0x4000AC4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal bool m_observed;
	}
}
