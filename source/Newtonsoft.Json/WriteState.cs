using System;
using Cpp2ILInjected;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	// Token: 0x0200003A RID: 58
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x200003D")]
	public enum WriteState
	{
		// Token: 0x04000130 RID: 304
		[global::Cpp2ILInjected.Token(Token = "0x400014A")]
		Error,
		// Token: 0x04000131 RID: 305
		[global::Cpp2ILInjected.Token(Token = "0x400014B")]
		Closed,
		// Token: 0x04000132 RID: 306
		[global::Cpp2ILInjected.Token(Token = "0x400014C")]
		Object,
		// Token: 0x04000133 RID: 307
		[global::Cpp2ILInjected.Token(Token = "0x400014D")]
		Array,
		// Token: 0x04000134 RID: 308
		[global::Cpp2ILInjected.Token(Token = "0x400014E")]
		Constructor,
		// Token: 0x04000135 RID: 309
		[global::Cpp2ILInjected.Token(Token = "0x400014F")]
		Property,
		// Token: 0x04000136 RID: 310
		[global::Cpp2ILInjected.Token(Token = "0x4000150")]
		Start
	}
}
