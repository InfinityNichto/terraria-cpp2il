using System;
using Cpp2ILInjected;

namespace InControl
{
	[global::Cpp2ILInjected.Token(Token = "0x2000020")]
	public enum InputControlSourceType
	{
		[global::Cpp2ILInjected.Token(Token = "0x400013C")]
		Button,
		[global::Cpp2ILInjected.Token(Token = "0x400013D")]
		Analog,
		[global::Cpp2ILInjected.Token(Token = "0x400013E")]
		KeyCode
	}
}
