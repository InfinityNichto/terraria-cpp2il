using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace System.Security.Cryptography
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20002CD")]
	[global::System.Serializable]
	public enum PaddingMode
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000C86")]
		None = 1,
		[global::Cpp2ILInjected.Token(Token = "0x4000C87")]
		PKCS7,
		[global::Cpp2ILInjected.Token(Token = "0x4000C88")]
		Zeros,
		[global::Cpp2ILInjected.Token(Token = "0x4000C89")]
		ANSIX923,
		[global::Cpp2ILInjected.Token(Token = "0x4000C8A")]
		ISO10126
	}
}
