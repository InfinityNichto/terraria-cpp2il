using System;
using Cpp2ILInjected;

namespace System.Threading
{
	[global::Cpp2ILInjected.Token(Token = "0x20001FC")]
	internal interface IThreadPoolWorkItem
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001232")]
		void ExecuteWorkItem();

		[global::Cpp2ILInjected.Token(Token = "0x6001233")]
		void MarkAborted(ThreadAbortException tae);
	}
}
