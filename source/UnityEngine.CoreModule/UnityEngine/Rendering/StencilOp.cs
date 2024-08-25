using System;
using Cpp2ILInjected;
using UnityEngine.Bindings;

namespace UnityEngine.Rendering
{
	[NativeHeader("Runtime/GfxDevice/GfxDeviceTypes.h")]
	[global::Cpp2ILInjected.Token(Token = "0x200010C")]
	public enum StencilOp
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000465")]
		Keep,
		[global::Cpp2ILInjected.Token(Token = "0x4000466")]
		Zero,
		[global::Cpp2ILInjected.Token(Token = "0x4000467")]
		Replace,
		[global::Cpp2ILInjected.Token(Token = "0x4000468")]
		IncrementSaturate,
		[global::Cpp2ILInjected.Token(Token = "0x4000469")]
		DecrementSaturate,
		[global::Cpp2ILInjected.Token(Token = "0x400046A")]
		Invert,
		[global::Cpp2ILInjected.Token(Token = "0x400046B")]
		IncrementWrap,
		[global::Cpp2ILInjected.Token(Token = "0x400046C")]
		DecrementWrap
	}
}
