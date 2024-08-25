using System;
using Cpp2ILInjected;

namespace System.Threading.Tasks
{
	[global::System.Flags]
	[global::Cpp2ILInjected.Token(Token = "0x200023B")]
	public enum TaskContinuationOptions
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000A90")]
		None = 0,
		[global::Cpp2ILInjected.Token(Token = "0x4000A91")]
		PreferFairness = 1,
		[global::Cpp2ILInjected.Token(Token = "0x4000A92")]
		LongRunning = 2,
		[global::Cpp2ILInjected.Token(Token = "0x4000A93")]
		AttachedToParent = 4,
		[global::Cpp2ILInjected.Token(Token = "0x4000A94")]
		DenyChildAttach = 8,
		[global::Cpp2ILInjected.Token(Token = "0x4000A95")]
		HideScheduler = 16,
		[global::Cpp2ILInjected.Token(Token = "0x4000A96")]
		LazyCancellation = 32,
		[global::Cpp2ILInjected.Token(Token = "0x4000A97")]
		RunContinuationsAsynchronously = 64,
		[global::Cpp2ILInjected.Token(Token = "0x4000A98")]
		NotOnRanToCompletion = 65536,
		[global::Cpp2ILInjected.Token(Token = "0x4000A99")]
		NotOnFaulted = 131072,
		[global::Cpp2ILInjected.Token(Token = "0x4000A9A")]
		NotOnCanceled = 262144,
		[global::Cpp2ILInjected.Token(Token = "0x4000A9B")]
		OnlyOnRanToCompletion = 393216,
		[global::Cpp2ILInjected.Token(Token = "0x4000A9C")]
		OnlyOnFaulted = 327680,
		[global::Cpp2ILInjected.Token(Token = "0x4000A9D")]
		OnlyOnCanceled = 196608,
		[global::Cpp2ILInjected.Token(Token = "0x4000A9E")]
		ExecuteSynchronously = 524288
	}
}
