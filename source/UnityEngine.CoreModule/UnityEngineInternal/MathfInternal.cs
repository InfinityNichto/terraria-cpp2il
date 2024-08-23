using System;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Unity.IL2CPP.CompilerServices;

namespace UnityEngineInternal
{
	// Token: 0x02000007 RID: 7
	[Il2CppEagerStaticClassConstruction]
	[global::Cpp2ILInjected.Token(Token = "0x2000007")]
	public struct MathfInternal
	{
		// Token: 0x06000007 RID: 7 RVA: 0x00002062 File Offset: 0x00000262
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

		// Token: 0x04000007 RID: 7
		[global::Cpp2ILInjected.Token(Token = "0x4000007")]
		public static float FloatMinNormal;

		// Token: 0x04000008 RID: 8
		[global::Cpp2ILInjected.Token(Token = "0x4000008")]
		public static float FloatMinDenormal;

		// Token: 0x04000009 RID: 9
		[global::Cpp2ILInjected.Token(Token = "0x4000009")]
		public static bool IsFlushToZeroEnabled;
	}
}
