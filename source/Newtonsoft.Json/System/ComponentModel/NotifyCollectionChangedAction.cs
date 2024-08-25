using System;
using Cpp2ILInjected;
using Newtonsoft.Json.Shims;

namespace System.ComponentModel
{
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000006")]
	public enum NotifyCollectionChangedAction
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000003")]
		Add,
		[global::Cpp2ILInjected.Token(Token = "0x4000004")]
		Remove,
		[global::Cpp2ILInjected.Token(Token = "0x4000005")]
		Replace,
		[global::Cpp2ILInjected.Token(Token = "0x4000006")]
		Move,
		[global::Cpp2ILInjected.Token(Token = "0x4000007")]
		Reset
	}
}
