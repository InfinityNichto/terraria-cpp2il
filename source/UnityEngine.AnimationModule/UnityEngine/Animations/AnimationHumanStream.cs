using System;
using Cpp2ILInjected;
using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Animations
{
	[NativeHeader("Modules/Animation/Director/AnimationHumanStream.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationHumanStream.bindings.h")]
	[MovedFrom("UnityEngine.Experimental.Animations")]
	[RequiredByNativeCode]
	[global::Cpp2ILInjected.Token(Token = "0x2000019")]
	public struct AnimationHumanStream
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000046")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private IntPtr stream;
	}
}
