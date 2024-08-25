using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace System.Runtime.Serialization
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::System.Flags]
	[global::Cpp2ILInjected.Token(Token = "0x20003EF")]
	[global::System.Serializable]
	public enum StreamingContextStates
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000FDD")]
		CrossProcess = 1,
		[global::Cpp2ILInjected.Token(Token = "0x4000FDE")]
		CrossMachine = 2,
		[global::Cpp2ILInjected.Token(Token = "0x4000FDF")]
		File = 4,
		[global::Cpp2ILInjected.Token(Token = "0x4000FE0")]
		Persistence = 8,
		[global::Cpp2ILInjected.Token(Token = "0x4000FE1")]
		Remoting = 16,
		[global::Cpp2ILInjected.Token(Token = "0x4000FE2")]
		Other = 32,
		[global::Cpp2ILInjected.Token(Token = "0x4000FE3")]
		Clone = 64,
		[global::Cpp2ILInjected.Token(Token = "0x4000FE4")]
		CrossAppDomain = 128,
		[global::Cpp2ILInjected.Token(Token = "0x4000FE5")]
		All = 255
	}
}
