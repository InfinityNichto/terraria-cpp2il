using System;
using Cpp2ILInjected;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200000D RID: 13
	[NativeHeader("Modules/Animation/AnimatorInfo.h")]
	[RequiredByNativeCode]
	[global::Cpp2ILInjected.Token(Token = "0x200000E")]
	public struct AnimatorStateInfo
	{
		// Token: 0x0400002A RID: 42
		[global::Cpp2ILInjected.Token(Token = "0x400002A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int m_Name;

		// Token: 0x0400002B RID: 43
		[global::Cpp2ILInjected.Token(Token = "0x400002B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		private int m_Path;

		// Token: 0x0400002C RID: 44
		[global::Cpp2ILInjected.Token(Token = "0x400002C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private int m_FullPath;

		// Token: 0x0400002D RID: 45
		[global::Cpp2ILInjected.Token(Token = "0x400002D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		private float m_NormalizedTime;

		// Token: 0x0400002E RID: 46
		[global::Cpp2ILInjected.Token(Token = "0x400002E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private float m_Length;

		// Token: 0x0400002F RID: 47
		[global::Cpp2ILInjected.Token(Token = "0x400002F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private float m_Speed;

		// Token: 0x04000030 RID: 48
		[global::Cpp2ILInjected.Token(Token = "0x4000030")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private float m_SpeedMultiplier;

		// Token: 0x04000031 RID: 49
		[global::Cpp2ILInjected.Token(Token = "0x4000031")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private int m_Tag;

		// Token: 0x04000032 RID: 50
		[global::Cpp2ILInjected.Token(Token = "0x4000032")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int m_Loop;
	}
}
