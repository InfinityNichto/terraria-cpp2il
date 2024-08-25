using System;
using Cpp2ILInjected;

namespace Ionic.Zip
{
	[global::Cpp2ILInjected.Token(Token = "0x2000026")]
	public enum ZipErrorAction
	{
		[global::Cpp2ILInjected.Token(Token = "0x40000B9")]
		Throw,
		[global::Cpp2ILInjected.Token(Token = "0x40000BA")]
		Skip,
		[global::Cpp2ILInjected.Token(Token = "0x40000BB")]
		Retry,
		[global::Cpp2ILInjected.Token(Token = "0x40000BC")]
		InvokeErrorEvent
	}
}
