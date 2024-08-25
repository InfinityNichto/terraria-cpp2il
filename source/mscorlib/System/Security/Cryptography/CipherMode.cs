using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace System.Security.Cryptography
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20002CC")]
	[global::System.Serializable]
	public enum CipherMode
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000C80")]
		CBC = 1,
		[global::Cpp2ILInjected.Token(Token = "0x4000C81")]
		ECB,
		[global::Cpp2ILInjected.Token(Token = "0x4000C82")]
		OFB,
		[global::Cpp2ILInjected.Token(Token = "0x4000C83")]
		CFB,
		[global::Cpp2ILInjected.Token(Token = "0x4000C84")]
		CTS
	}
}
