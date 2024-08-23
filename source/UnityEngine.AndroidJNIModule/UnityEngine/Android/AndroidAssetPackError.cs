using System;
using Cpp2ILInjected;

namespace UnityEngine.Android
{
	// Token: 0x02000010 RID: 16
	[global::Cpp2ILInjected.Token(Token = "0x2000010")]
	public enum AndroidAssetPackError
	{
		// Token: 0x04000028 RID: 40
		[global::Cpp2ILInjected.Token(Token = "0x4000028")]
		NoError,
		// Token: 0x04000029 RID: 41
		[global::Cpp2ILInjected.Token(Token = "0x4000029")]
		AppUnavailable = -1,
		// Token: 0x0400002A RID: 42
		[global::Cpp2ILInjected.Token(Token = "0x400002A")]
		PackUnavailable = -2,
		// Token: 0x0400002B RID: 43
		[global::Cpp2ILInjected.Token(Token = "0x400002B")]
		InvalidRequest = -3,
		// Token: 0x0400002C RID: 44
		[global::Cpp2ILInjected.Token(Token = "0x400002C")]
		DownloadNotFound = -4,
		// Token: 0x0400002D RID: 45
		[global::Cpp2ILInjected.Token(Token = "0x400002D")]
		ApiNotAvailable = -5,
		// Token: 0x0400002E RID: 46
		[global::Cpp2ILInjected.Token(Token = "0x400002E")]
		NetworkError = -6,
		// Token: 0x0400002F RID: 47
		[global::Cpp2ILInjected.Token(Token = "0x400002F")]
		AccessDenied = -7,
		// Token: 0x04000030 RID: 48
		[global::Cpp2ILInjected.Token(Token = "0x4000030")]
		InsufficientStorage = -10,
		// Token: 0x04000031 RID: 49
		[global::Cpp2ILInjected.Token(Token = "0x4000031")]
		PlayStoreNotFound = -11,
		// Token: 0x04000032 RID: 50
		[global::Cpp2ILInjected.Token(Token = "0x4000032")]
		NetworkUnrestricted = -12,
		// Token: 0x04000033 RID: 51
		[global::Cpp2ILInjected.Token(Token = "0x4000033")]
		AppNotOwned = -13,
		// Token: 0x04000034 RID: 52
		[global::Cpp2ILInjected.Token(Token = "0x4000034")]
		InternalError = -100
	}
}
