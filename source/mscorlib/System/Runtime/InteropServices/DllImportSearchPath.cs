using System;
using Cpp2ILInjected;

namespace System.Runtime.InteropServices
{
	[global::System.Flags]
	[global::Cpp2ILInjected.Token(Token = "0x2000447")]
	public enum DllImportSearchPath
	{
		[global::Cpp2ILInjected.Token(Token = "0x400125F")]
		UseDllDirectoryForDependencies = 256,
		[global::Cpp2ILInjected.Token(Token = "0x4001260")]
		ApplicationDirectory = 512,
		[global::Cpp2ILInjected.Token(Token = "0x4001261")]
		UserDirectories = 1024,
		[global::Cpp2ILInjected.Token(Token = "0x4001262")]
		System32 = 2048,
		[global::Cpp2ILInjected.Token(Token = "0x4001263")]
		SafeDirectories = 4096,
		[global::Cpp2ILInjected.Token(Token = "0x4001264")]
		AssemblyDirectory = 2,
		[global::Cpp2ILInjected.Token(Token = "0x4001265")]
		LegacyBehavior = 0
	}
}
