using System;
using Cpp2ILInjected;

namespace UnityEngine
{
	// Token: 0x0200003C RID: 60
	[global::Cpp2ILInjected.Token(Token = "0x200003F")]
	public interface ILogHandler
	{
		// Token: 0x06000079 RID: 121
		[global::Cpp2ILInjected.Token(Token = "0x6000081")]
		void LogFormat(LogType logType, Object context, string format, params object[] args);

		// Token: 0x0600007A RID: 122
		[global::Cpp2ILInjected.Token(Token = "0x6000082")]
		void LogException(Exception exception, Object context);
	}
}
