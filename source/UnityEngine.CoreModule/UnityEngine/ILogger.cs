using System;
using Cpp2ILInjected;

namespace UnityEngine
{
	// Token: 0x0200003B RID: 59
	[global::Cpp2ILInjected.Token(Token = "0x200003E")]
	public interface ILogger : ILogHandler
	{
		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000074 RID: 116
		[global::Cpp2ILInjected.Token(Token = "0x1700000F")]
		ILogHandler logHandler
		{
			[global::Cpp2ILInjected.Token(Token = "0x600007C")]
			get;
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000075 RID: 117
		[global::Cpp2ILInjected.Token(Token = "0x17000010")]
		bool logEnabled
		{
			[global::Cpp2ILInjected.Token(Token = "0x600007D")]
			get;
		}

		// Token: 0x06000076 RID: 118
		[global::Cpp2ILInjected.Token(Token = "0x600007E")]
		void Log(LogType logType, object message);

		// Token: 0x06000077 RID: 119
		[global::Cpp2ILInjected.Token(Token = "0x600007F")]
		void Log(LogType logType, object message, Object context);

		// Token: 0x06000078 RID: 120
		[global::Cpp2ILInjected.Token(Token = "0x6000080")]
		void LogError(string tag, object message);
	}
}
