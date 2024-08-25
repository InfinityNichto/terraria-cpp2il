using System;
using Cpp2ILInjected;

namespace UnityEngine
{
	[global::Cpp2ILInjected.Token(Token = "0x200003E")]
	public interface ILogger : ILogHandler
	{
		[global::Cpp2ILInjected.Token(Token = "0x1700000F")]
		ILogHandler logHandler
		{
			[global::Cpp2ILInjected.Token(Token = "0x600007C")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000010")]
		bool logEnabled
		{
			[global::Cpp2ILInjected.Token(Token = "0x600007D")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600007E")]
		void Log(LogType logType, object message);

		[global::Cpp2ILInjected.Token(Token = "0x600007F")]
		void Log(LogType logType, object message, Object context);

		[global::Cpp2ILInjected.Token(Token = "0x6000080")]
		void LogError(string tag, object message);
	}
}
