using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000054 RID: 84
	[NativeHeader("Runtime/Graphics/CustomRenderTextureManager.h")]
	[global::Cpp2ILInjected.Token(Token = "0x2000058")]
	public static class CustomRenderTextureManager
	{
		// Token: 0x06000178 RID: 376 RVA: 0x00002356 File Offset: 0x00000556
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x6000180")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F73C00", Offset = "0x1F73C00", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static void InvokeOnTextureLoaded_Internal(CustomRenderTexture source)
		{
			throw null;
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00002359 File Offset: 0x00000559
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x6000181")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F73C6C", Offset = "0x1F73C6C", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static void InvokeOnTextureUnloaded_Internal(CustomRenderTexture source)
		{
			throw null;
		}

		// Token: 0x04000218 RID: 536
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400021D")]
		private static Action<CustomRenderTexture> textureLoaded;

		// Token: 0x04000219 RID: 537
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400021E")]
		private static Action<CustomRenderTexture> textureUnloaded;
	}
}
