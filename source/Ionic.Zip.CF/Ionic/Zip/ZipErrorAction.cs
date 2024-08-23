using System;
using Cpp2ILInjected;

namespace Ionic.Zip
{
	// Token: 0x02000022 RID: 34
	[global::Cpp2ILInjected.Token(Token = "0x2000026")]
	public enum ZipErrorAction
	{
		// Token: 0x040000AF RID: 175
		[global::Cpp2ILInjected.Token(Token = "0x40000B9")]
		Throw,
		// Token: 0x040000B0 RID: 176
		[global::Cpp2ILInjected.Token(Token = "0x40000BA")]
		Skip,
		// Token: 0x040000B1 RID: 177
		[global::Cpp2ILInjected.Token(Token = "0x40000BB")]
		Retry,
		// Token: 0x040000B2 RID: 178
		[global::Cpp2ILInjected.Token(Token = "0x40000BC")]
		InvokeErrorEvent
	}
}
