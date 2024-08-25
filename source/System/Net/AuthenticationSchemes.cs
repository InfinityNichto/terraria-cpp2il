using System;
using Cpp2ILInjected;

namespace System.Net
{
	[Flags]
	[global::Cpp2ILInjected.Token(Token = "0x2000185")]
	public enum AuthenticationSchemes
	{
		[global::Cpp2ILInjected.Token(Token = "0x40007A9")]
		None = 0,
		[global::Cpp2ILInjected.Token(Token = "0x40007AA")]
		Digest = 1,
		[global::Cpp2ILInjected.Token(Token = "0x40007AB")]
		Negotiate = 2,
		[global::Cpp2ILInjected.Token(Token = "0x40007AC")]
		Ntlm = 4,
		[global::Cpp2ILInjected.Token(Token = "0x40007AD")]
		Basic = 8,
		[global::Cpp2ILInjected.Token(Token = "0x40007AE")]
		Anonymous = 32768,
		[global::Cpp2ILInjected.Token(Token = "0x40007AF")]
		IntegratedWindowsAuthentication = 6
	}
}
