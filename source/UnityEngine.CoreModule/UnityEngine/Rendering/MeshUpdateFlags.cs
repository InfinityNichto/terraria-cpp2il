using System;
using Cpp2ILInjected;

namespace UnityEngine.Rendering
{
	// Token: 0x020000E7 RID: 231
	[Flags]
	[global::Cpp2ILInjected.Token(Token = "0x2000107")]
	public enum MeshUpdateFlags
	{
		// Token: 0x040003ED RID: 1005
		[global::Cpp2ILInjected.Token(Token = "0x4000433")]
		Default = 0,
		// Token: 0x040003EE RID: 1006
		[global::Cpp2ILInjected.Token(Token = "0x4000434")]
		DontValidateIndices = 1,
		// Token: 0x040003EF RID: 1007
		[global::Cpp2ILInjected.Token(Token = "0x4000435")]
		DontResetBoneBounds = 2,
		// Token: 0x040003F0 RID: 1008
		[global::Cpp2ILInjected.Token(Token = "0x4000436")]
		DontNotifyMeshUsers = 4,
		// Token: 0x040003F1 RID: 1009
		[global::Cpp2ILInjected.Token(Token = "0x4000437")]
		DontRecalculateBounds = 8
	}
}
