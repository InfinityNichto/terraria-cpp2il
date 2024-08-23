using System;
using Cpp2ILInjected;

namespace UnityEngine
{
	// Token: 0x02000009 RID: 9
	[Flags]
	[global::Cpp2ILInjected.Token(Token = "0x200000A")]
	public enum EventModifiers
	{
		// Token: 0x04000048 RID: 72
		[global::Cpp2ILInjected.Token(Token = "0x4000048")]
		None = 0,
		// Token: 0x04000049 RID: 73
		[global::Cpp2ILInjected.Token(Token = "0x4000049")]
		Shift = 1,
		// Token: 0x0400004A RID: 74
		[global::Cpp2ILInjected.Token(Token = "0x400004A")]
		Control = 2,
		// Token: 0x0400004B RID: 75
		[global::Cpp2ILInjected.Token(Token = "0x400004B")]
		Alt = 4,
		// Token: 0x0400004C RID: 76
		[global::Cpp2ILInjected.Token(Token = "0x400004C")]
		Command = 8,
		// Token: 0x0400004D RID: 77
		[global::Cpp2ILInjected.Token(Token = "0x400004D")]
		Numeric = 16,
		// Token: 0x0400004E RID: 78
		[global::Cpp2ILInjected.Token(Token = "0x400004E")]
		CapsLock = 32,
		// Token: 0x0400004F RID: 79
		[global::Cpp2ILInjected.Token(Token = "0x400004F")]
		FunctionKey = 64
	}
}
