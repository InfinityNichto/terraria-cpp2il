using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading.Tasks
{
	[global::Cpp2ILInjected.Token(Token = "0x2000250")]
	public class UnobservedTaskExceptionEventArgs : global::System.EventArgs
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x4000AC3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private global::System.AggregateException m_exception;

		[global::Cpp2ILInjected.Token(Token = "0x4000AC4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal bool m_observed;
	}
}
