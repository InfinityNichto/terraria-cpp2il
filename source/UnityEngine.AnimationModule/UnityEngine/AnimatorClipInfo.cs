using System;
using Cpp2ILInjected;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200000C RID: 12
	[UsedByNativeCode]
	[NativeHeader("Modules/Animation/ScriptBindings/Animation.bindings.h")]
	[NativeHeader("Modules/Animation/AnimatorInfo.h")]
	[global::Cpp2ILInjected.Token(Token = "0x200000D")]
	public struct AnimatorClipInfo
	{
		// Token: 0x04000028 RID: 40
		[global::Cpp2ILInjected.Token(Token = "0x4000028")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int m_ClipInstanceID;

		// Token: 0x04000029 RID: 41
		[global::Cpp2ILInjected.Token(Token = "0x4000029")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		private float m_Weight;
	}
}
