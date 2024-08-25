using System;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Unity.IL2CPP.CompilerServices;

namespace UnityEngineInternal
{
	[Il2CppEagerStaticClassConstruction]
	[global::Cpp2ILInjected.Token(Token = "0x2000007")]
	public struct MathfInternal
	{
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000007")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F69E0C", Offset = "0x1F69E0C", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new object[]
		{
			typeof(ref float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static MathfInternal()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000007")]
		public static float FloatMinNormal;

		[global::Cpp2ILInjected.Token(Token = "0x4000008")]
		public static float FloatMinDenormal;

		[global::Cpp2ILInjected.Token(Token = "0x4000009")]
		public static bool IsFlushToZeroEnabled;
	}
}
