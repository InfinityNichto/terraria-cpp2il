using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace System
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000188")]
	[global::System.Serializable]
	public enum PlatformID
	{
		[global::Cpp2ILInjected.Token(Token = "0x400068D")]
		Win32S,
		[global::Cpp2ILInjected.Token(Token = "0x400068E")]
		Win32Windows,
		[global::Cpp2ILInjected.Token(Token = "0x400068F")]
		Win32NT,
		[global::Cpp2ILInjected.Token(Token = "0x4000690")]
		WinCE,
		[global::Cpp2ILInjected.Token(Token = "0x4000691")]
		Unix,
		[global::Cpp2ILInjected.Token(Token = "0x4000692")]
		Xbox,
		[global::Cpp2ILInjected.Token(Token = "0x4000693")]
		MacOSX
	}
}
