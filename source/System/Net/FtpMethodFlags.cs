using System;
using Cpp2ILInjected;

namespace System.Net
{
	// Token: 0x020000E3 RID: 227
	[Flags]
	[global::Cpp2ILInjected.Token(Token = "0x200014F")]
	internal enum FtpMethodFlags
	{
		// Token: 0x04000515 RID: 1301
		[global::Cpp2ILInjected.Token(Token = "0x40006AE")]
		None = 0,
		// Token: 0x04000516 RID: 1302
		[global::Cpp2ILInjected.Token(Token = "0x40006AF")]
		IsDownload = 1,
		// Token: 0x04000517 RID: 1303
		[global::Cpp2ILInjected.Token(Token = "0x40006B0")]
		IsUpload = 2,
		// Token: 0x04000518 RID: 1304
		[global::Cpp2ILInjected.Token(Token = "0x40006B1")]
		TakesParameter = 4,
		// Token: 0x04000519 RID: 1305
		[global::Cpp2ILInjected.Token(Token = "0x40006B2")]
		MayTakeParameter = 8,
		// Token: 0x0400051A RID: 1306
		[global::Cpp2ILInjected.Token(Token = "0x40006B3")]
		DoesNotTakeParameter = 16,
		// Token: 0x0400051B RID: 1307
		[global::Cpp2ILInjected.Token(Token = "0x40006B4")]
		ParameterIsDirectory = 32,
		// Token: 0x0400051C RID: 1308
		[global::Cpp2ILInjected.Token(Token = "0x40006B5")]
		ShouldParseForResponseUri = 64,
		// Token: 0x0400051D RID: 1309
		[global::Cpp2ILInjected.Token(Token = "0x40006B6")]
		HasHttpCommand = 128,
		// Token: 0x0400051E RID: 1310
		[global::Cpp2ILInjected.Token(Token = "0x40006B7")]
		MustChangeWorkingDirectoryToPath = 256
	}
}
