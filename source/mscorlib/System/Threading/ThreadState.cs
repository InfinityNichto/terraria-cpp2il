using System;
using Cpp2ILInjected;

namespace System.Threading
{
	[global::System.Flags]
	[global::Cpp2ILInjected.Token(Token = "0x20001C4")]
	public enum ThreadState
	{
		[global::Cpp2ILInjected.Token(Token = "0x400090A")]
		Running = 0,
		[global::Cpp2ILInjected.Token(Token = "0x400090B")]
		StopRequested = 1,
		[global::Cpp2ILInjected.Token(Token = "0x400090C")]
		SuspendRequested = 2,
		[global::Cpp2ILInjected.Token(Token = "0x400090D")]
		Background = 4,
		[global::Cpp2ILInjected.Token(Token = "0x400090E")]
		Unstarted = 8,
		[global::Cpp2ILInjected.Token(Token = "0x400090F")]
		Stopped = 16,
		[global::Cpp2ILInjected.Token(Token = "0x4000910")]
		WaitSleepJoin = 32,
		[global::Cpp2ILInjected.Token(Token = "0x4000911")]
		Suspended = 64,
		[global::Cpp2ILInjected.Token(Token = "0x4000912")]
		AbortRequested = 128,
		[global::Cpp2ILInjected.Token(Token = "0x4000913")]
		Aborted = 256
	}
}
