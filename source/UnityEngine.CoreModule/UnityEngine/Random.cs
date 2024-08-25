using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;

namespace UnityEngine
{
	[NativeHeader("Runtime/Export/Random/Random.bindings.h")]
	[global::Cpp2ILInjected.Token(Token = "0x2000075")]
	public static class Random
	{
		[global::Cpp2ILInjected.Token(Token = "0x60001D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F75818", Offset = "0x1F75818", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "SoundDefinition", Member = "GetRandomClip", ReturnType = "UnityEngine.AudioClip")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static int Range(int minInclusive, int maxExclusive)
		{
			throw null;
		}

		[FreeFunction]
		[global::Cpp2ILInjected.Token(Token = "0x60001D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7585C", Offset = "0x1F7585C", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern int RandomRangeInt(int minInclusive, int maxExclusive);
	}
}
