using System;
using System.Diagnostics;
using Cpp2ILInjected;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x200007B")]
	public interface ITraceWriter
	{
		[global::Cpp2ILInjected.Token(Token = "0x170000BA")]
		TraceLevel LevelFilter
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000452")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000453")]
		void Trace(TraceLevel level, string message, Exception ex);
	}
}
