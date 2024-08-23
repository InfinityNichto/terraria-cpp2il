using System;
using Cpp2ILInjected;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x0200004E RID: 78
	[NativeHeader("Runtime/Camera/SharedLightData.h")]
	[global::Cpp2ILInjected.Token(Token = "0x2000052")]
	public struct LightBakingOutput
	{
		// Token: 0x0400020F RID: 527
		[global::Cpp2ILInjected.Token(Token = "0x4000214")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public int probeOcclusionLightIndex;

		// Token: 0x04000210 RID: 528
		[global::Cpp2ILInjected.Token(Token = "0x4000215")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public int occlusionMaskChannel;

		// Token: 0x04000211 RID: 529
		[NativeName("lightmapBakeMode.lightmapBakeType")]
		[global::Cpp2ILInjected.Token(Token = "0x4000216")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public LightmapBakeType lightmapBakeType;

		// Token: 0x04000212 RID: 530
		[NativeName("lightmapBakeMode.mixedLightingMode")]
		[global::Cpp2ILInjected.Token(Token = "0x4000217")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		public MixedLightingMode mixedLightingMode;

		// Token: 0x04000213 RID: 531
		[global::Cpp2ILInjected.Token(Token = "0x4000218")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public bool isBaked;
	}
}
