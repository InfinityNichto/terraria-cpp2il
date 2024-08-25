using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace System.Runtime.Remoting.Lifetime
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000363")]
	[global::System.Serializable]
	public enum LeaseState
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000E97")]
		Null,
		[global::Cpp2ILInjected.Token(Token = "0x4000E98")]
		Initial,
		[global::Cpp2ILInjected.Token(Token = "0x4000E99")]
		Active,
		[global::Cpp2ILInjected.Token(Token = "0x4000E9A")]
		Renewing,
		[global::Cpp2ILInjected.Token(Token = "0x4000E9B")]
		Expired
	}
}
