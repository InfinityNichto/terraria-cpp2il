using System;
using Cpp2ILInjected;

namespace System.Configuration
{
	[global::Cpp2ILInjected.Token(Token = "0x2000006")]
	public enum ConfigurationSaveMode
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000002")]
		Full = 2,
		[global::Cpp2ILInjected.Token(Token = "0x4000003")]
		Minimal = 1,
		[global::Cpp2ILInjected.Token(Token = "0x4000004")]
		Modified = 0
	}
}
