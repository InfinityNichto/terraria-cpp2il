using System;
using Cpp2ILInjected;
using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Animations
{
	// Token: 0x0200001C RID: 28
	[RequiredByNativeCode]
	[MovedFrom("UnityEngine.Experimental.Animations")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationStream.bindings.h")]
	[NativeHeader("Modules/Animation/Director/AnimationStream.h")]
	[global::Cpp2ILInjected.Token(Token = "0x200001D")]
	public struct AnimationStream
	{
		// Token: 0x0400004D RID: 77
		[global::Cpp2ILInjected.Token(Token = "0x400004D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private uint m_AnimatorBindingsVersion;

		// Token: 0x0400004E RID: 78
		[global::Cpp2ILInjected.Token(Token = "0x400004E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private IntPtr constant;

		// Token: 0x0400004F RID: 79
		[global::Cpp2ILInjected.Token(Token = "0x400004F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private IntPtr input;

		// Token: 0x04000050 RID: 80
		[global::Cpp2ILInjected.Token(Token = "0x4000050")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private IntPtr output;

		// Token: 0x04000051 RID: 81
		[global::Cpp2ILInjected.Token(Token = "0x4000051")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private IntPtr workspace;

		// Token: 0x04000052 RID: 82
		[global::Cpp2ILInjected.Token(Token = "0x4000052")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private IntPtr inputStreamAccessor;

		// Token: 0x04000053 RID: 83
		[global::Cpp2ILInjected.Token(Token = "0x4000053")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private IntPtr animationHandleBinder;
	}
}
