using System;
using Cpp2ILInjected;

namespace System.Threading.Tasks
{
	[global::System.Flags]
	[global::Cpp2ILInjected.Token(Token = "0x200023A")]
	internal enum InternalTaskOptions
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000A88")]
		None = 0,
		[global::Cpp2ILInjected.Token(Token = "0x4000A89")]
		InternalOptionsMask = 65280,
		[global::Cpp2ILInjected.Token(Token = "0x4000A8A")]
		ContinuationTask = 512,
		[global::Cpp2ILInjected.Token(Token = "0x4000A8B")]
		PromiseTask = 1024,
		[global::Cpp2ILInjected.Token(Token = "0x4000A8C")]
		LazyCancellation = 4096,
		[global::Cpp2ILInjected.Token(Token = "0x4000A8D")]
		QueuedByRuntime = 8192,
		[global::Cpp2ILInjected.Token(Token = "0x4000A8E")]
		DoNotDispose = 16384
	}
}
