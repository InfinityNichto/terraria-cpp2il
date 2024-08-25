using System;
using Cpp2ILInjected;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x200027F")]
	internal enum ReadState
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000D95")]
		None,
		[global::Cpp2ILInjected.Token(Token = "0x4000D96")]
		Status,
		[global::Cpp2ILInjected.Token(Token = "0x4000D97")]
		Headers,
		[global::Cpp2ILInjected.Token(Token = "0x4000D98")]
		Content,
		[global::Cpp2ILInjected.Token(Token = "0x4000D99")]
		Aborted
	}
}
