using System;
using Cpp2ILInjected;
using UnityEngine.Scripting;

namespace Unity.Collections
{
	// Token: 0x02000015 RID: 21
	[UsedByNativeCode]
	[global::Cpp2ILInjected.Token(Token = "0x2000017")]
	public enum Allocator
	{
		// Token: 0x04000040 RID: 64
		[global::Cpp2ILInjected.Token(Token = "0x4000042")]
		Invalid,
		// Token: 0x04000041 RID: 65
		[global::Cpp2ILInjected.Token(Token = "0x4000043")]
		None,
		// Token: 0x04000042 RID: 66
		[global::Cpp2ILInjected.Token(Token = "0x4000044")]
		Temp,
		// Token: 0x04000043 RID: 67
		[global::Cpp2ILInjected.Token(Token = "0x4000045")]
		TempJob,
		// Token: 0x04000044 RID: 68
		[global::Cpp2ILInjected.Token(Token = "0x4000046")]
		Persistent,
		// Token: 0x04000045 RID: 69
		[global::Cpp2ILInjected.Token(Token = "0x4000047")]
		AudioKernel
	}
}
