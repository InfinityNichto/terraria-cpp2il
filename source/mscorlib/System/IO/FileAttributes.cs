using System;
using Cpp2ILInjected;

namespace System.IO
{
	[global::System.Flags]
	[global::Cpp2ILInjected.Token(Token = "0x2000556")]
	public enum FileAttributes
	{
		[global::Cpp2ILInjected.Token(Token = "0x40015E2")]
		ReadOnly = 1,
		[global::Cpp2ILInjected.Token(Token = "0x40015E3")]
		Hidden = 2,
		[global::Cpp2ILInjected.Token(Token = "0x40015E4")]
		System = 4,
		[global::Cpp2ILInjected.Token(Token = "0x40015E5")]
		Directory = 16,
		[global::Cpp2ILInjected.Token(Token = "0x40015E6")]
		Archive = 32,
		[global::Cpp2ILInjected.Token(Token = "0x40015E7")]
		Device = 64,
		[global::Cpp2ILInjected.Token(Token = "0x40015E8")]
		Normal = 128,
		[global::Cpp2ILInjected.Token(Token = "0x40015E9")]
		Temporary = 256,
		[global::Cpp2ILInjected.Token(Token = "0x40015EA")]
		SparseFile = 512,
		[global::Cpp2ILInjected.Token(Token = "0x40015EB")]
		ReparsePoint = 1024,
		[global::Cpp2ILInjected.Token(Token = "0x40015EC")]
		Compressed = 2048,
		[global::Cpp2ILInjected.Token(Token = "0x40015ED")]
		Offline = 4096,
		[global::Cpp2ILInjected.Token(Token = "0x40015EE")]
		NotContentIndexed = 8192,
		[global::Cpp2ILInjected.Token(Token = "0x40015EF")]
		Encrypted = 16384,
		[global::Cpp2ILInjected.Token(Token = "0x40015F0")]
		IntegrityStream = 32768,
		[global::Cpp2ILInjected.Token(Token = "0x40015F1")]
		NoScrubData = 131072
	}
}
