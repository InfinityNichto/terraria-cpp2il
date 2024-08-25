using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	[global::Cpp2ILInjected.Token(Token = "0x2000183")]
	internal sealed class MonoListItem
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000F25")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C81960", Offset = "0x1C81960", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public MonoListItem()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000688")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private global::System.MonoListItem next;

		[global::Cpp2ILInjected.Token(Token = "0x4000689")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private object data;
	}
}
