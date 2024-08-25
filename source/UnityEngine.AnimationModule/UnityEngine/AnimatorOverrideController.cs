using System;
using System.Reflection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[DefaultMember("Item")]
	[NativeHeader("Modules/Animation/AnimatorOverrideController.h")]
	[UsedByNativeCode]
	[NativeHeader("Modules/Animation/ScriptBindings/Animation.bindings.h")]
	[global::Cpp2ILInjected.Token(Token = "0x2000002")]
	public class AnimatorOverrideController : RuntimeAnimatorController
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x4000001")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal AnimatorOverrideController.OnOverrideControllerDirtyCallback OnOverrideControllerDirty;

		[global::Cpp2ILInjected.Token(Token = "0x2000003")]
		internal delegate void OnOverrideControllerDirtyCallback();
	}
}
