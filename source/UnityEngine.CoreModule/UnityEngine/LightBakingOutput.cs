using System;
using Cpp2ILInjected;
using UnityEngine.Bindings;

namespace UnityEngine
{
	[NativeHeader("Runtime/Camera/SharedLightData.h")]
	[global::Cpp2ILInjected.Token(Token = "0x2000052")]
	public struct LightBakingOutput
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000214")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public int probeOcclusionLightIndex;

		[global::Cpp2ILInjected.Token(Token = "0x4000215")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public int occlusionMaskChannel;

		[NativeName("lightmapBakeMode.lightmapBakeType")]
		[global::Cpp2ILInjected.Token(Token = "0x4000216")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public LightmapBakeType lightmapBakeType;

		[NativeName("lightmapBakeMode.mixedLightingMode")]
		[global::Cpp2ILInjected.Token(Token = "0x4000217")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		public MixedLightingMode mixedLightingMode;

		[global::Cpp2ILInjected.Token(Token = "0x4000218")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public bool isBaked;
	}
}
