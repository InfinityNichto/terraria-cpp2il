using System;
using Cpp2ILInjected;
using UnityEngine.Bindings;

namespace Unity.IO.LowLevel.Unsafe
{
	[NativeHeader("Runtime/File/AsyncReadManagerMetrics.h")]
	[global::Cpp2ILInjected.Token(Token = "0x200000F")]
	public enum ProcessingState
	{
		[global::Cpp2ILInjected.Token(Token = "0x400001E")]
		Unknown,
		[global::Cpp2ILInjected.Token(Token = "0x400001F")]
		InQueue,
		[global::Cpp2ILInjected.Token(Token = "0x4000020")]
		Reading,
		[global::Cpp2ILInjected.Token(Token = "0x4000021")]
		Completed,
		[global::Cpp2ILInjected.Token(Token = "0x4000022")]
		Failed,
		[global::Cpp2ILInjected.Token(Token = "0x4000023")]
		Canceled
	}
}
