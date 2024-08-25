using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	[global::Cpp2ILInjected.Token(Token = "0x2000173")]
	internal static class EmptyArray<T>
	{
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000EE7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1622B18", Offset = "0x1622B18", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		static EmptyArray()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000671")]
		public static readonly T[] Value;
	}
}
