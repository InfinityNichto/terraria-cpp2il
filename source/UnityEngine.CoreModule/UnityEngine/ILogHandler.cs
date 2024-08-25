using System;
using Cpp2ILInjected;

namespace UnityEngine
{
	[global::Cpp2ILInjected.Token(Token = "0x200003F")]
	public interface ILogHandler
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000081")]
		void LogFormat(LogType logType, Object context, string format, params object[] args);

		[global::Cpp2ILInjected.Token(Token = "0x6000082")]
		void LogException(Exception exception, Object context);
	}
}
