using System;
using Cpp2ILInjected;

namespace System.ComponentModel
{
	// Token: 0x020002AB RID: 683
	[global::Cpp2ILInjected.Token(Token = "0x20003A6")]
	public enum MaskedTextResultHint
	{
		// Token: 0x04000E6F RID: 3695
		[global::Cpp2ILInjected.Token(Token = "0x4001287")]
		Unknown,
		// Token: 0x04000E70 RID: 3696
		[global::Cpp2ILInjected.Token(Token = "0x4001288")]
		CharacterEscaped,
		// Token: 0x04000E71 RID: 3697
		[global::Cpp2ILInjected.Token(Token = "0x4001289")]
		NoEffect,
		// Token: 0x04000E72 RID: 3698
		[global::Cpp2ILInjected.Token(Token = "0x400128A")]
		SideEffect,
		// Token: 0x04000E73 RID: 3699
		[global::Cpp2ILInjected.Token(Token = "0x400128B")]
		Success,
		// Token: 0x04000E74 RID: 3700
		[global::Cpp2ILInjected.Token(Token = "0x400128C")]
		AsciiCharacterExpected = -1,
		// Token: 0x04000E75 RID: 3701
		[global::Cpp2ILInjected.Token(Token = "0x400128D")]
		AlphanumericCharacterExpected = -2,
		// Token: 0x04000E76 RID: 3702
		[global::Cpp2ILInjected.Token(Token = "0x400128E")]
		DigitExpected = -3,
		// Token: 0x04000E77 RID: 3703
		[global::Cpp2ILInjected.Token(Token = "0x400128F")]
		LetterExpected = -4,
		// Token: 0x04000E78 RID: 3704
		[global::Cpp2ILInjected.Token(Token = "0x4001290")]
		SignedDigitExpected = -5,
		// Token: 0x04000E79 RID: 3705
		[global::Cpp2ILInjected.Token(Token = "0x4001291")]
		InvalidInput = -51,
		// Token: 0x04000E7A RID: 3706
		[global::Cpp2ILInjected.Token(Token = "0x4001292")]
		PromptCharNotAllowed = -52,
		// Token: 0x04000E7B RID: 3707
		[global::Cpp2ILInjected.Token(Token = "0x4001293")]
		UnavailableEditPosition = -53,
		// Token: 0x04000E7C RID: 3708
		[global::Cpp2ILInjected.Token(Token = "0x4001294")]
		NonEditPosition = -54,
		// Token: 0x04000E7D RID: 3709
		[global::Cpp2ILInjected.Token(Token = "0x4001295")]
		PositionOutOfRange = -55
	}
}
