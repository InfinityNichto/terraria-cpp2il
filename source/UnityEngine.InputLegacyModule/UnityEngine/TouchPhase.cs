using System;
using Cpp2ILInjected;

namespace UnityEngine
{
	[global::Cpp2ILInjected.Token(Token = "0x2000002")]
	public enum TouchPhase
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000002")]
		Began,
		[global::Cpp2ILInjected.Token(Token = "0x4000003")]
		Moved,
		[global::Cpp2ILInjected.Token(Token = "0x4000004")]
		Stationary,
		[global::Cpp2ILInjected.Token(Token = "0x4000005")]
		Ended,
		[global::Cpp2ILInjected.Token(Token = "0x4000006")]
		Canceled
	}
}
