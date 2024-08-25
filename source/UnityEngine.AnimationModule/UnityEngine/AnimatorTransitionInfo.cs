using System;
using Cpp2ILInjected;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[NativeHeader("Modules/Animation/AnimatorInfo.h")]
	[RequiredByNativeCode]
	[global::Cpp2ILInjected.Token(Token = "0x200000F")]
	public struct AnimatorTransitionInfo
	{
		[NativeName("fullPathHash")]
		[global::Cpp2ILInjected.Token(Token = "0x4000033")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int m_FullPath;

		[NativeName("userNameHash")]
		[global::Cpp2ILInjected.Token(Token = "0x4000034")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		private int m_UserName;

		[NativeName("nameHash")]
		[global::Cpp2ILInjected.Token(Token = "0x4000035")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private int m_Name;

		[NativeName("hasFixedDuration")]
		[global::Cpp2ILInjected.Token(Token = "0x4000036")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		private bool m_HasFixedDuration;

		[NativeName("duration")]
		[global::Cpp2ILInjected.Token(Token = "0x4000037")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private float m_Duration;

		[NativeName("normalizedTime")]
		[global::Cpp2ILInjected.Token(Token = "0x4000038")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private float m_NormalizedTime;

		[NativeName("anyState")]
		[global::Cpp2ILInjected.Token(Token = "0x4000039")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private bool m_AnyState;

		[NativeName("transitionType")]
		[global::Cpp2ILInjected.Token(Token = "0x400003A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private int m_TransitionType;
	}
}
