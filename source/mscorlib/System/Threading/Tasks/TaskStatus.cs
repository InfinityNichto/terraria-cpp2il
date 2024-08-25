using System;
using Cpp2ILInjected;

namespace System.Threading.Tasks
{
	[global::Cpp2ILInjected.Token(Token = "0x2000231")]
	public enum TaskStatus
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000A51")]
		Created,
		[global::Cpp2ILInjected.Token(Token = "0x4000A52")]
		WaitingForActivation,
		[global::Cpp2ILInjected.Token(Token = "0x4000A53")]
		WaitingToRun,
		[global::Cpp2ILInjected.Token(Token = "0x4000A54")]
		Running,
		[global::Cpp2ILInjected.Token(Token = "0x4000A55")]
		WaitingForChildrenToComplete,
		[global::Cpp2ILInjected.Token(Token = "0x4000A56")]
		RanToCompletion,
		[global::Cpp2ILInjected.Token(Token = "0x4000A57")]
		Canceled,
		[global::Cpp2ILInjected.Token(Token = "0x4000A58")]
		Faulted
	}
}
