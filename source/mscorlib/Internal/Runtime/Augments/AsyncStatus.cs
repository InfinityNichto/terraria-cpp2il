using System;
using Cpp2ILInjected;

namespace Internal.Runtime.Augments
{
	[global::Cpp2ILInjected.Token(Token = "0x2000061")]
	internal enum AsyncStatus
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000191")]
		Started,
		[global::Cpp2ILInjected.Token(Token = "0x4000192")]
		Completed,
		[global::Cpp2ILInjected.Token(Token = "0x4000193")]
		Canceled,
		[global::Cpp2ILInjected.Token(Token = "0x4000194")]
		Error
	}
}
