using System;
using Cpp2ILInjected;

namespace System.Runtime.InteropServices
{
	[ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x200044C")]
	[global::System.Serializable]
	public enum CallingConvention
	{
		[global::Cpp2ILInjected.Token(Token = "0x4001276")]
		Winapi = 1,
		[global::Cpp2ILInjected.Token(Token = "0x4001277")]
		Cdecl,
		[global::Cpp2ILInjected.Token(Token = "0x4001278")]
		StdCall,
		[global::Cpp2ILInjected.Token(Token = "0x4001279")]
		ThisCall,
		[global::Cpp2ILInjected.Token(Token = "0x400127A")]
		FastCall
	}
}
