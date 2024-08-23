using System;
using Cpp2ILInjected;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	// Token: 0x0200001C RID: 28
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x200001C")]
	public enum Required
	{
		// Token: 0x0400003C RID: 60
		[global::Cpp2ILInjected.Token(Token = "0x400003C")]
		Default,
		// Token: 0x0400003D RID: 61
		[global::Cpp2ILInjected.Token(Token = "0x400003D")]
		AllowNull,
		// Token: 0x0400003E RID: 62
		[global::Cpp2ILInjected.Token(Token = "0x400003E")]
		Always,
		// Token: 0x0400003F RID: 63
		[global::Cpp2ILInjected.Token(Token = "0x400003F")]
		DisallowNull
	}
}
