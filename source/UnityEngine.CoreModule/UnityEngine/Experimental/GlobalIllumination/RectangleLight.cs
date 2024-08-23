using System;
using Cpp2ILInjected;

namespace UnityEngine.Experimental.GlobalIllumination
{
	// Token: 0x0200010F RID: 271
	[global::Cpp2ILInjected.Token(Token = "0x2000132")]
	public struct RectangleLight
	{
		// Token: 0x040004E5 RID: 1253
		[global::Cpp2ILInjected.Token(Token = "0x4000533")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public int instanceID;

		// Token: 0x040004E6 RID: 1254
		[global::Cpp2ILInjected.Token(Token = "0x4000534")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public bool shadow;

		// Token: 0x040004E7 RID: 1255
		[global::Cpp2ILInjected.Token(Token = "0x4000535")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5")]
		public LightMode mode;

		// Token: 0x040004E8 RID: 1256
		[global::Cpp2ILInjected.Token(Token = "0x4000536")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public Vector3 position;

		// Token: 0x040004E9 RID: 1257
		[global::Cpp2ILInjected.Token(Token = "0x4000537")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public Quaternion orientation;

		// Token: 0x040004EA RID: 1258
		[global::Cpp2ILInjected.Token(Token = "0x4000538")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		public LinearColor color;

		// Token: 0x040004EB RID: 1259
		[global::Cpp2ILInjected.Token(Token = "0x4000539")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		public LinearColor indirectColor;

		// Token: 0x040004EC RID: 1260
		[global::Cpp2ILInjected.Token(Token = "0x400053A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		public float range;

		// Token: 0x040004ED RID: 1261
		[global::Cpp2ILInjected.Token(Token = "0x400053B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		public float width;

		// Token: 0x040004EE RID: 1262
		[global::Cpp2ILInjected.Token(Token = "0x400053C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
		public float height;

		// Token: 0x040004EF RID: 1263
		[global::Cpp2ILInjected.Token(Token = "0x400053D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		public FalloffType falloff;
	}
}
