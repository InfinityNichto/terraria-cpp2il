using System;
using Cpp2ILInjected;

namespace System.Net
{
	[Flags]
	[global::Cpp2ILInjected.Token(Token = "0x20001F2")]
	internal enum ThreadKinds
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000A91")]
		Unknown = 0,
		[global::Cpp2ILInjected.Token(Token = "0x4000A92")]
		User = 1,
		[global::Cpp2ILInjected.Token(Token = "0x4000A93")]
		System = 2,
		[global::Cpp2ILInjected.Token(Token = "0x4000A94")]
		Sync = 4,
		[global::Cpp2ILInjected.Token(Token = "0x4000A95")]
		Async = 8,
		[global::Cpp2ILInjected.Token(Token = "0x4000A96")]
		Timer = 16,
		[global::Cpp2ILInjected.Token(Token = "0x4000A97")]
		CompletionPort = 32,
		[global::Cpp2ILInjected.Token(Token = "0x4000A98")]
		Worker = 64,
		[global::Cpp2ILInjected.Token(Token = "0x4000A99")]
		Finalization = 128,
		[global::Cpp2ILInjected.Token(Token = "0x4000A9A")]
		Other = 256,
		[global::Cpp2ILInjected.Token(Token = "0x4000A9B")]
		OwnerMask = 3,
		[global::Cpp2ILInjected.Token(Token = "0x4000A9C")]
		SyncMask = 12,
		[global::Cpp2ILInjected.Token(Token = "0x4000A9D")]
		SourceMask = 496,
		[global::Cpp2ILInjected.Token(Token = "0x4000A9E")]
		SafeSources = 352,
		[global::Cpp2ILInjected.Token(Token = "0x4000A9F")]
		ThreadPool = 96
	}
}
