using System;
using Cpp2ILInjected;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x2000149")]
	internal enum FtpLoginState : byte
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000678")]
		NotLoggedIn,
		[global::Cpp2ILInjected.Token(Token = "0x4000679")]
		LoggedIn,
		[global::Cpp2ILInjected.Token(Token = "0x400067A")]
		LoggedInButNeedsRelogin,
		[global::Cpp2ILInjected.Token(Token = "0x400067B")]
		ReloginFailed
	}
}
