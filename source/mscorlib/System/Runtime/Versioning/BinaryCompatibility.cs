using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Versioning
{
	[global::Cpp2ILInjected.Token(Token = "0x20003C3")]
	internal static class BinaryCompatibility
	{
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001EBC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B50944", Offset = "0x1B50944", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static BinaryCompatibility()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000F73")]
		public static readonly bool TargetsAtLeast_Desktop_V4_5;

		[global::Cpp2ILInjected.Token(Token = "0x4000F74")]
		public static readonly bool TargetsAtLeast_Desktop_V4_5_1;
	}
}
