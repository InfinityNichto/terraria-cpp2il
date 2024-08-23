using System;
using Cpp2ILInjected;

namespace UnityEngine.Experimental.GlobalIllumination
{
	// Token: 0x02000110 RID: 272
	[global::Cpp2ILInjected.Token(Token = "0x2000133")]
	public struct DiscLight
	{
		// Token: 0x040004F0 RID: 1264
		[global::Cpp2ILInjected.Token(Token = "0x400053E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public int instanceID;

		// Token: 0x040004F1 RID: 1265
		[global::Cpp2ILInjected.Token(Token = "0x400053F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public bool shadow;

		// Token: 0x040004F2 RID: 1266
		[global::Cpp2ILInjected.Token(Token = "0x4000540")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5")]
		public LightMode mode;

		// Token: 0x040004F3 RID: 1267
		[global::Cpp2ILInjected.Token(Token = "0x4000541")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public Vector3 position;

		// Token: 0x040004F4 RID: 1268
		[global::Cpp2ILInjected.Token(Token = "0x4000542")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public Quaternion orientation;

		// Token: 0x040004F5 RID: 1269
		[global::Cpp2ILInjected.Token(Token = "0x4000543")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		public LinearColor color;

		// Token: 0x040004F6 RID: 1270
		[global::Cpp2ILInjected.Token(Token = "0x4000544")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		public LinearColor indirectColor;

		// Token: 0x040004F7 RID: 1271
		[global::Cpp2ILInjected.Token(Token = "0x4000545")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		public float range;

		// Token: 0x040004F8 RID: 1272
		[global::Cpp2ILInjected.Token(Token = "0x4000546")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		public float radius;

		// Token: 0x040004F9 RID: 1273
		[global::Cpp2ILInjected.Token(Token = "0x4000547")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
		public FalloffType falloff;
	}
}
