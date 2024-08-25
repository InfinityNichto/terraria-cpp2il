using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace Unity.Collections
{
	[global::Cpp2ILInjected.Token(Token = "0x2000013")]
	public static class NativeLeakDetection
	{
		[RuntimeInitializeOnLoadMethod]
		[global::Cpp2ILInjected.Token(Token = "0x600000D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6A008", Offset = "0x1F6A008", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private static void Initialize()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400003B")]
		private static int s_NativeLeakDetectionMode;
	}
}
