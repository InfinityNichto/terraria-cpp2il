using System;
using Cpp2ILInjected;

namespace System
{
	// Token: 0x02000067 RID: 103
	[global::System.Flags]
	[global::Cpp2ILInjected.Token(Token = "0x200008D")]
	public enum AttributeTargets
	{
		// Token: 0x04000102 RID: 258
		[global::Cpp2ILInjected.Token(Token = "0x40001E7")]
		Assembly = 1,
		// Token: 0x04000103 RID: 259
		[global::Cpp2ILInjected.Token(Token = "0x40001E8")]
		Module = 2,
		// Token: 0x04000104 RID: 260
		[global::Cpp2ILInjected.Token(Token = "0x40001E9")]
		Class = 4,
		// Token: 0x04000105 RID: 261
		[global::Cpp2ILInjected.Token(Token = "0x40001EA")]
		Struct = 8,
		// Token: 0x04000106 RID: 262
		[global::Cpp2ILInjected.Token(Token = "0x40001EB")]
		Enum = 16,
		// Token: 0x04000107 RID: 263
		[global::Cpp2ILInjected.Token(Token = "0x40001EC")]
		Constructor = 32,
		// Token: 0x04000108 RID: 264
		[global::Cpp2ILInjected.Token(Token = "0x40001ED")]
		Method = 64,
		// Token: 0x04000109 RID: 265
		[global::Cpp2ILInjected.Token(Token = "0x40001EE")]
		Property = 128,
		// Token: 0x0400010A RID: 266
		[global::Cpp2ILInjected.Token(Token = "0x40001EF")]
		Field = 256,
		// Token: 0x0400010B RID: 267
		[global::Cpp2ILInjected.Token(Token = "0x40001F0")]
		Event = 512,
		// Token: 0x0400010C RID: 268
		[global::Cpp2ILInjected.Token(Token = "0x40001F1")]
		Interface = 1024,
		// Token: 0x0400010D RID: 269
		[global::Cpp2ILInjected.Token(Token = "0x40001F2")]
		Parameter = 2048,
		// Token: 0x0400010E RID: 270
		[global::Cpp2ILInjected.Token(Token = "0x40001F3")]
		Delegate = 4096,
		// Token: 0x0400010F RID: 271
		[global::Cpp2ILInjected.Token(Token = "0x40001F4")]
		ReturnValue = 8192,
		// Token: 0x04000110 RID: 272
		[global::Cpp2ILInjected.Token(Token = "0x40001F5")]
		GenericParameter = 16384,
		// Token: 0x04000111 RID: 273
		[global::Cpp2ILInjected.Token(Token = "0x40001F6")]
		All = 32767
	}
}
