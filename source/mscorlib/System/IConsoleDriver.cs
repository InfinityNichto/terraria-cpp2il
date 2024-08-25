using System;
using Cpp2ILInjected;

namespace System
{
	[global::Cpp2ILInjected.Token(Token = "0x200017C")]
	internal interface IConsoleDriver
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000EE8")]
		void Clear();

		[global::Cpp2ILInjected.Token(Token = "0x6000EE9")]
		global::System.ConsoleKeyInfo ReadKey(bool intercept);

		[global::Cpp2ILInjected.Token(Token = "0x6000EEA")]
		string ReadLine();
	}
}
