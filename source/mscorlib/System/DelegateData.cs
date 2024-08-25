using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	[global::Cpp2ILInjected.Token(Token = "0x200016F")]
	internal sealed class DelegateData
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000EC0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7BBC0", Offset = "0x1C7BBC0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public DelegateData()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000659")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public global::System.Type target_type;

		[global::Cpp2ILInjected.Token(Token = "0x400065A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public string method_name;

		[global::Cpp2ILInjected.Token(Token = "0x400065B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public bool curried_first_arg;
	}
}
