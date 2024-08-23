using System;
using Cpp2ILInjected;

namespace Ionic.Zip
{
	// Token: 0x02000015 RID: 21
	[global::Cpp2ILInjected.Token(Token = "0x2000015")]
	public enum ExtractExistingFileAction
	{
		// Token: 0x0400002A RID: 42
		[global::Cpp2ILInjected.Token(Token = "0x400002A")]
		Throw,
		// Token: 0x0400002B RID: 43
		[global::Cpp2ILInjected.Token(Token = "0x400002B")]
		OverwriteSilently,
		// Token: 0x0400002C RID: 44
		[global::Cpp2ILInjected.Token(Token = "0x400002C")]
		DoNotOverwrite,
		// Token: 0x0400002D RID: 45
		[global::Cpp2ILInjected.Token(Token = "0x400002D")]
		InvokeExtractProgressEvent
	}
}
