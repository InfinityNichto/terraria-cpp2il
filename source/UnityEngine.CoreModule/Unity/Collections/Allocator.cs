using System;
using Cpp2ILInjected;
using UnityEngine.Scripting;

namespace Unity.Collections
{
	[UsedByNativeCode]
	[global::Cpp2ILInjected.Token(Token = "0x2000017")]
	public enum Allocator
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000042")]
		Invalid,
		[global::Cpp2ILInjected.Token(Token = "0x4000043")]
		None,
		[global::Cpp2ILInjected.Token(Token = "0x4000044")]
		Temp,
		[global::Cpp2ILInjected.Token(Token = "0x4000045")]
		TempJob,
		[global::Cpp2ILInjected.Token(Token = "0x4000046")]
		Persistent,
		[global::Cpp2ILInjected.Token(Token = "0x4000047")]
		AudioKernel
	}
}
