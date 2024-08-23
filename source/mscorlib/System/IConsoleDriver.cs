using System;
using Cpp2ILInjected;

namespace System
{
	// Token: 0x02000136 RID: 310
	[global::Cpp2ILInjected.Token(Token = "0x200017C")]
	internal interface IConsoleDriver
	{
		// Token: 0x06000E00 RID: 3584
		[global::Cpp2ILInjected.Token(Token = "0x6000EE8")]
		void Clear();

		// Token: 0x06000E01 RID: 3585
		[global::Cpp2ILInjected.Token(Token = "0x6000EE9")]
		global::System.ConsoleKeyInfo ReadKey(bool intercept);

		// Token: 0x06000E02 RID: 3586
		[global::Cpp2ILInjected.Token(Token = "0x6000EEA")]
		string ReadLine();
	}
}
