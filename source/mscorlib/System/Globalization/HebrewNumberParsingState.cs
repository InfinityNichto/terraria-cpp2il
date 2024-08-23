using System;
using Cpp2ILInjected;

namespace System.Globalization
{
	// Token: 0x020004B2 RID: 1202
	[global::Cpp2ILInjected.Token(Token = "0x2000592")]
	internal enum HebrewNumberParsingState
	{
		// Token: 0x04001415 RID: 5141
		[global::Cpp2ILInjected.Token(Token = "0x4001779")]
		InvalidHebrewNumber,
		// Token: 0x04001416 RID: 5142
		[global::Cpp2ILInjected.Token(Token = "0x400177A")]
		NotHebrewDigit,
		// Token: 0x04001417 RID: 5143
		[global::Cpp2ILInjected.Token(Token = "0x400177B")]
		FoundEndOfHebrewNumber,
		// Token: 0x04001418 RID: 5144
		[global::Cpp2ILInjected.Token(Token = "0x400177C")]
		ContinueParsing
	}
}
