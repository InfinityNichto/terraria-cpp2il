using System;
using Cpp2ILInjected;
using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Animations
{
	[RequiredByNativeCode]
	[MovedFrom("UnityEngine.Experimental.Animations")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationStream.bindings.h")]
	[NativeHeader("Modules/Animation/Director/AnimationStream.h")]
	[global::Cpp2ILInjected.Token(Token = "0x200001D")]
	public struct AnimationStream
	{
		[global::Cpp2ILInjected.Token(Token = "0x400004D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private uint m_AnimatorBindingsVersion;

		[global::Cpp2ILInjected.Token(Token = "0x400004E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private IntPtr constant;

		[global::Cpp2ILInjected.Token(Token = "0x400004F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private IntPtr input;

		[global::Cpp2ILInjected.Token(Token = "0x4000050")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private IntPtr output;

		[global::Cpp2ILInjected.Token(Token = "0x4000051")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private IntPtr workspace;

		[global::Cpp2ILInjected.Token(Token = "0x4000052")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private IntPtr inputStreamAccessor;

		[global::Cpp2ILInjected.Token(Token = "0x4000053")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private IntPtr animationHandleBinder;
	}
}
