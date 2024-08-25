using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace System.Security.Principal
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x200032A")]
	[global::System.Serializable]
	public enum WindowsAccountType
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000DEA")]
		Normal,
		[global::Cpp2ILInjected.Token(Token = "0x4000DEB")]
		Guest,
		[global::Cpp2ILInjected.Token(Token = "0x4000DEC")]
		System,
		[global::Cpp2ILInjected.Token(Token = "0x4000DED")]
		Anonymous
	}
}
