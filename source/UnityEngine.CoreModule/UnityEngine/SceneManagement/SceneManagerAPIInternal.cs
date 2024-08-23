using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;

namespace UnityEngine.SceneManagement
{
	// Token: 0x02000102 RID: 258
	[NativeHeader("Runtime/Export/SceneManager/SceneManager.bindings.h")]
	[NativeHeader("Runtime/SceneManager/SceneManager.h")]
	[StaticAccessor("SceneManagerBindings", StaticAccessorType.DoubleColon)]
	[global::Cpp2ILInjected.Token(Token = "0x2000125")]
	internal static class SceneManagerAPIInternal
	{
		// Token: 0x060005AD RID: 1453 RVA: 0x00002CE0 File Offset: 0x00000EE0
		[NativeThrows]
		[global::Cpp2ILInjected.Token(Token = "0x60005DE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8CFFC", Offset = "0x1F8CFFC", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static AsyncOperation LoadSceneAsyncNameIndexInternal(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame)
		{
			throw null;
		}

		// Token: 0x060005AE RID: 1454
		[global::Cpp2ILInjected.Token(Token = "0x60005DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8D05C", Offset = "0x1F8D05C", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern AsyncOperation LoadSceneAsyncNameIndexInternal_Injected(string sceneName, int sceneBuildIndex, ref LoadSceneParameters parameters, bool mustCompleteNextFrame);
	}
}
