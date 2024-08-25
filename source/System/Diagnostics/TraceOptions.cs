using System;
using Cpp2ILInjected;

namespace System.Diagnostics
{
	[Flags]
	[global::Cpp2ILInjected.Token(Token = "0x20000D3")]
	public enum TraceOptions
	{
		[global::Cpp2ILInjected.Token(Token = "0x40003B9")]
		None = 0,
		[global::Cpp2ILInjected.Token(Token = "0x40003BA")]
		LogicalOperationStack = 1,
		[global::Cpp2ILInjected.Token(Token = "0x40003BB")]
		DateTime = 2,
		[global::Cpp2ILInjected.Token(Token = "0x40003BC")]
		Timestamp = 4,
		[global::Cpp2ILInjected.Token(Token = "0x40003BD")]
		ProcessId = 8,
		[global::Cpp2ILInjected.Token(Token = "0x40003BE")]
		ThreadId = 16,
		[global::Cpp2ILInjected.Token(Token = "0x40003BF")]
		Callstack = 32
	}
}
