using System;
using Cpp2ILInjected;

namespace UnityEngine.Android
{
	// Token: 0x0200000F RID: 15
	[global::Cpp2ILInjected.Token(Token = "0x200000F")]
	public enum AndroidAssetPackStatus
	{
		// Token: 0x0400001E RID: 30
		[global::Cpp2ILInjected.Token(Token = "0x400001E")]
		Unknown,
		// Token: 0x0400001F RID: 31
		[global::Cpp2ILInjected.Token(Token = "0x400001F")]
		Pending,
		// Token: 0x04000020 RID: 32
		[global::Cpp2ILInjected.Token(Token = "0x4000020")]
		Downloading,
		// Token: 0x04000021 RID: 33
		[global::Cpp2ILInjected.Token(Token = "0x4000021")]
		Transferring,
		// Token: 0x04000022 RID: 34
		[global::Cpp2ILInjected.Token(Token = "0x4000022")]
		Completed,
		// Token: 0x04000023 RID: 35
		[global::Cpp2ILInjected.Token(Token = "0x4000023")]
		Failed,
		// Token: 0x04000024 RID: 36
		[global::Cpp2ILInjected.Token(Token = "0x4000024")]
		Canceled,
		// Token: 0x04000025 RID: 37
		[global::Cpp2ILInjected.Token(Token = "0x4000025")]
		WaitingForWifi,
		// Token: 0x04000026 RID: 38
		[global::Cpp2ILInjected.Token(Token = "0x4000026")]
		NotInstalled
	}
}
