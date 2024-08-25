using System;
using Cpp2ILInjected;

namespace System.Threading.Tasks
{
	[global::Cpp2ILInjected.Token(Token = "0x200023E")]
	internal interface ITaskCompletionAction
	{
		[global::Cpp2ILInjected.Token(Token = "0x60013F2")]
		void Invoke(Task completingTask);

		[global::Cpp2ILInjected.Token(Token = "0x170001F3")]
		bool InvokeMayRunArbitraryCode
		{
			[global::Cpp2ILInjected.Token(Token = "0x60013F3")]
			get;
		}
	}
}
