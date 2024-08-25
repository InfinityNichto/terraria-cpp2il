using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Ionic.Zlib
{
	[global::Cpp2ILInjected.Token(Token = "0x2000047")]
	internal static class InternalInflateConstants
	{
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000382")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A71DF4", Offset = "0x1A71DF4", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static InternalInflateConstants()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400025A")]
		internal static readonly int[] InflateMask;
	}
}
