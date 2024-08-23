using System;
using Cpp2ILInjected;

namespace System.Xml
{
	// Token: 0x0200003E RID: 62
	[global::Cpp2ILInjected.Token(Token = "0x200005B")]
	public enum WriteState
	{
		// Token: 0x04000163 RID: 355
		[global::Cpp2ILInjected.Token(Token = "0x400025D")]
		Start,
		// Token: 0x04000164 RID: 356
		[global::Cpp2ILInjected.Token(Token = "0x400025E")]
		Prolog,
		// Token: 0x04000165 RID: 357
		[global::Cpp2ILInjected.Token(Token = "0x400025F")]
		Element,
		// Token: 0x04000166 RID: 358
		[global::Cpp2ILInjected.Token(Token = "0x4000260")]
		Attribute,
		// Token: 0x04000167 RID: 359
		[global::Cpp2ILInjected.Token(Token = "0x4000261")]
		Content,
		// Token: 0x04000168 RID: 360
		[global::Cpp2ILInjected.Token(Token = "0x4000262")]
		Closed,
		// Token: 0x04000169 RID: 361
		[global::Cpp2ILInjected.Token(Token = "0x4000263")]
		Error
	}
}
