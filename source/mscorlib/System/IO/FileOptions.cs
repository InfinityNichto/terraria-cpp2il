using System;
using Cpp2ILInjected;

namespace System.IO
{
	// Token: 0x02000470 RID: 1136
	[global::System.Flags]
	[global::Cpp2ILInjected.Token(Token = "0x2000536")]
	public enum FileOptions
	{
		// Token: 0x04001255 RID: 4693
		[global::Cpp2ILInjected.Token(Token = "0x4001575")]
		None = 0,
		// Token: 0x04001256 RID: 4694
		[global::Cpp2ILInjected.Token(Token = "0x4001576")]
		WriteThrough = -2147483648,
		// Token: 0x04001257 RID: 4695
		[global::Cpp2ILInjected.Token(Token = "0x4001577")]
		Asynchronous = 1073741824,
		// Token: 0x04001258 RID: 4696
		[global::Cpp2ILInjected.Token(Token = "0x4001578")]
		RandomAccess = 268435456,
		// Token: 0x04001259 RID: 4697
		[global::Cpp2ILInjected.Token(Token = "0x4001579")]
		DeleteOnClose = 67108864,
		// Token: 0x0400125A RID: 4698
		[global::Cpp2ILInjected.Token(Token = "0x400157A")]
		SequentialScan = 134217728,
		// Token: 0x0400125B RID: 4699
		[global::Cpp2ILInjected.Token(Token = "0x400157B")]
		Encrypted = 16384
	}
}
