using System;
using Cpp2ILInjected;

namespace System.Xml
{
	// Token: 0x0200002D RID: 45
	[global::Cpp2ILInjected.Token(Token = "0x200002E")]
	public enum ValidationType
	{
		// Token: 0x04000076 RID: 118
		[global::Cpp2ILInjected.Token(Token = "0x4000076")]
		None,
		// Token: 0x04000077 RID: 119
		[Obsolete("Validation type should be specified as DTD or Schema.")]
		[global::Cpp2ILInjected.Token(Token = "0x4000077")]
		Auto,
		// Token: 0x04000078 RID: 120
		[global::Cpp2ILInjected.Token(Token = "0x4000078")]
		DTD,
		// Token: 0x04000079 RID: 121
		[Obsolete("XDR Validation through XmlValidatingReader is obsoleted")]
		[global::Cpp2ILInjected.Token(Token = "0x4000079")]
		XDR,
		// Token: 0x0400007A RID: 122
		[global::Cpp2ILInjected.Token(Token = "0x400007A")]
		Schema
	}
}
