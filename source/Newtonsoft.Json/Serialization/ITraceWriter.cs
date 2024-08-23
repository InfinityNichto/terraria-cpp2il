using System;
using System.Diagnostics;
using Cpp2ILInjected;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000062 RID: 98
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x200007B")]
	public interface ITraceWriter
	{
		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x0600040F RID: 1039
		[global::Cpp2ILInjected.Token(Token = "0x170000BA")]
		TraceLevel LevelFilter
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000452")]
			get;
		}

		// Token: 0x06000410 RID: 1040
		[global::Cpp2ILInjected.Token(Token = "0x6000453")]
		void Trace(TraceLevel level, string message, Exception ex);
	}
}
