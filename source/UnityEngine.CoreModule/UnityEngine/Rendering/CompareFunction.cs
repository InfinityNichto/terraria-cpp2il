using System;
using Cpp2ILInjected;
using UnityEngine.Bindings;

namespace UnityEngine.Rendering
{
	// Token: 0x020000EA RID: 234
	[NativeHeader("Runtime/GfxDevice/GfxDeviceTypes.h")]
	[global::Cpp2ILInjected.Token(Token = "0x200010A")]
	public enum CompareFunction
	{
		// Token: 0x0400040F RID: 1039
		[global::Cpp2ILInjected.Token(Token = "0x4000455")]
		Disabled,
		// Token: 0x04000410 RID: 1040
		[global::Cpp2ILInjected.Token(Token = "0x4000456")]
		Never,
		// Token: 0x04000411 RID: 1041
		[global::Cpp2ILInjected.Token(Token = "0x4000457")]
		Less,
		// Token: 0x04000412 RID: 1042
		[global::Cpp2ILInjected.Token(Token = "0x4000458")]
		Equal,
		// Token: 0x04000413 RID: 1043
		[global::Cpp2ILInjected.Token(Token = "0x4000459")]
		LessEqual,
		// Token: 0x04000414 RID: 1044
		[global::Cpp2ILInjected.Token(Token = "0x400045A")]
		Greater,
		// Token: 0x04000415 RID: 1045
		[global::Cpp2ILInjected.Token(Token = "0x400045B")]
		NotEqual,
		// Token: 0x04000416 RID: 1046
		[global::Cpp2ILInjected.Token(Token = "0x400045C")]
		GreaterEqual,
		// Token: 0x04000417 RID: 1047
		[global::Cpp2ILInjected.Token(Token = "0x400045D")]
		Always
	}
}
