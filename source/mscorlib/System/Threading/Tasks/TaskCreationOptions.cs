using System;
using Cpp2ILInjected;

namespace System.Threading.Tasks
{
	[global::System.Flags]
	[global::Cpp2ILInjected.Token(Token = "0x2000239")]
	public enum TaskCreationOptions
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000A80")]
		None = 0,
		[global::Cpp2ILInjected.Token(Token = "0x4000A81")]
		PreferFairness = 1,
		[global::Cpp2ILInjected.Token(Token = "0x4000A82")]
		LongRunning = 2,
		[global::Cpp2ILInjected.Token(Token = "0x4000A83")]
		AttachedToParent = 4,
		[global::Cpp2ILInjected.Token(Token = "0x4000A84")]
		DenyChildAttach = 8,
		[global::Cpp2ILInjected.Token(Token = "0x4000A85")]
		HideScheduler = 16,
		[global::Cpp2ILInjected.Token(Token = "0x4000A86")]
		RunContinuationsAsynchronously = 64
	}
}
