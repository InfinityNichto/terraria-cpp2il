using System;
using Cpp2ILInjected;

namespace UnityEngine.Experimental.GlobalIllumination
{
	// Token: 0x0200010D RID: 269
	[global::Cpp2ILInjected.Token(Token = "0x2000130")]
	public struct PointLight
	{
		// Token: 0x040004CE RID: 1230
		[global::Cpp2ILInjected.Token(Token = "0x400051C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public int instanceID;

		// Token: 0x040004CF RID: 1231
		[global::Cpp2ILInjected.Token(Token = "0x400051D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public bool shadow;

		// Token: 0x040004D0 RID: 1232
		[global::Cpp2ILInjected.Token(Token = "0x400051E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5")]
		public LightMode mode;

		// Token: 0x040004D1 RID: 1233
		[global::Cpp2ILInjected.Token(Token = "0x400051F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public Vector3 position;

		// Token: 0x040004D2 RID: 1234
		[global::Cpp2ILInjected.Token(Token = "0x4000520")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public Quaternion orientation;

		// Token: 0x040004D3 RID: 1235
		[global::Cpp2ILInjected.Token(Token = "0x4000521")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		public LinearColor color;

		// Token: 0x040004D4 RID: 1236
		[global::Cpp2ILInjected.Token(Token = "0x4000522")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		public LinearColor indirectColor;

		// Token: 0x040004D5 RID: 1237
		[global::Cpp2ILInjected.Token(Token = "0x4000523")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		public float range;

		// Token: 0x040004D6 RID: 1238
		[global::Cpp2ILInjected.Token(Token = "0x4000524")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		public float sphereRadius;

		// Token: 0x040004D7 RID: 1239
		[global::Cpp2ILInjected.Token(Token = "0x4000525")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
		public FalloffType falloff;
	}
}
