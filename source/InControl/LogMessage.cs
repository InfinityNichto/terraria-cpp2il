using System;
using Cpp2ILInjected;

namespace InControl
{
	// Token: 0x02000029 RID: 41
	[global::Cpp2ILInjected.Token(Token = "0x200002A")]
	public struct LogMessage
	{
		// Token: 0x040001F9 RID: 505
		[global::Cpp2ILInjected.Token(Token = "0x40001FD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public string text;

		// Token: 0x040001FA RID: 506
		[global::Cpp2ILInjected.Token(Token = "0x40001FE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public LogMessageType type;
	}
}
