using System;
using Cpp2ILInjected;

namespace InControl
{
	[global::Cpp2ILInjected.Token(Token = "0x200002A")]
	public struct LogMessage
	{
		[global::Cpp2ILInjected.Token(Token = "0x40001FD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public string text;

		[global::Cpp2ILInjected.Token(Token = "0x40001FE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public LogMessageType type;
	}
}
