using System;
using Cpp2ILInjected;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200000E RID: 14
	[NativeHeader("Modules/Animation/AnimatorInfo.h")]
	[RequiredByNativeCode]
	[global::Cpp2ILInjected.Token(Token = "0x200000F")]
	public struct AnimatorTransitionInfo
	{
		// Token: 0x04000033 RID: 51
		[NativeName("fullPathHash")]
		[global::Cpp2ILInjected.Token(Token = "0x4000033")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int m_FullPath;

		// Token: 0x04000034 RID: 52
		[NativeName("userNameHash")]
		[global::Cpp2ILInjected.Token(Token = "0x4000034")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		private int m_UserName;

		// Token: 0x04000035 RID: 53
		[NativeName("nameHash")]
		[global::Cpp2ILInjected.Token(Token = "0x4000035")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private int m_Name;

		// Token: 0x04000036 RID: 54
		[NativeName("hasFixedDuration")]
		[global::Cpp2ILInjected.Token(Token = "0x4000036")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		private bool m_HasFixedDuration;

		// Token: 0x04000037 RID: 55
		[NativeName("duration")]
		[global::Cpp2ILInjected.Token(Token = "0x4000037")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private float m_Duration;

		// Token: 0x04000038 RID: 56
		[NativeName("normalizedTime")]
		[global::Cpp2ILInjected.Token(Token = "0x4000038")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private float m_NormalizedTime;

		// Token: 0x04000039 RID: 57
		[NativeName("anyState")]
		[global::Cpp2ILInjected.Token(Token = "0x4000039")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private bool m_AnyState;

		// Token: 0x0400003A RID: 58
		[NativeName("transitionType")]
		[global::Cpp2ILInjected.Token(Token = "0x400003A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private int m_TransitionType;
	}
}
