using System;
using Cpp2ILInjected;
using UnityEngine.Bindings;

namespace UnityEngine.Rendering
{
	// Token: 0x020000EC RID: 236
	[NativeHeader("Runtime/GfxDevice/GfxDeviceTypes.h")]
	[global::Cpp2ILInjected.Token(Token = "0x200010C")]
	public enum StencilOp
	{
		// Token: 0x0400041F RID: 1055
		[global::Cpp2ILInjected.Token(Token = "0x4000465")]
		Keep,
		// Token: 0x04000420 RID: 1056
		[global::Cpp2ILInjected.Token(Token = "0x4000466")]
		Zero,
		// Token: 0x04000421 RID: 1057
		[global::Cpp2ILInjected.Token(Token = "0x4000467")]
		Replace,
		// Token: 0x04000422 RID: 1058
		[global::Cpp2ILInjected.Token(Token = "0x4000468")]
		IncrementSaturate,
		// Token: 0x04000423 RID: 1059
		[global::Cpp2ILInjected.Token(Token = "0x4000469")]
		DecrementSaturate,
		// Token: 0x04000424 RID: 1060
		[global::Cpp2ILInjected.Token(Token = "0x400046A")]
		Invert,
		// Token: 0x04000425 RID: 1061
		[global::Cpp2ILInjected.Token(Token = "0x400046B")]
		IncrementWrap,
		// Token: 0x04000426 RID: 1062
		[global::Cpp2ILInjected.Token(Token = "0x400046C")]
		DecrementWrap
	}
}
