using System;
using System.Reflection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000002 RID: 2
	[DefaultMember("Item")]
	[NativeHeader("Modules/Animation/AnimatorOverrideController.h")]
	[UsedByNativeCode]
	[NativeHeader("Modules/Animation/ScriptBindings/Animation.bindings.h")]
	[global::Cpp2ILInjected.Token(Token = "0x2000002")]
	public class AnimatorOverrideController : RuntimeAnimatorController
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		[RequiredByNativeCode]
		[NativeConditional("UNITY_EDITOR")]
		[global::Cpp2ILInjected.Token(Token = "0x6000001")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F66818", Offset = "0x1F66818", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal static void OnInvalidateOverrideController(AnimatorOverrideController controller)
		{
			throw null;
		}

		// Token: 0x04000001 RID: 1
		[global::Cpp2ILInjected.Token(Token = "0x4000001")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal AnimatorOverrideController.OnOverrideControllerDirtyCallback OnOverrideControllerDirty;

		// Token: 0x0200002C RID: 44
		// (Invoke) Token: 0x06000050 RID: 80
		[global::Cpp2ILInjected.Token(Token = "0x2000003")]
		internal delegate void OnOverrideControllerDirtyCallback();
	}
}
