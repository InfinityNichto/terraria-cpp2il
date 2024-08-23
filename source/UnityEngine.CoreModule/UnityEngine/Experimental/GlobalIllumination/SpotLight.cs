using System;
using Cpp2ILInjected;

namespace UnityEngine.Experimental.GlobalIllumination
{
	// Token: 0x0200010E RID: 270
	[global::Cpp2ILInjected.Token(Token = "0x2000131")]
	public struct SpotLight
	{
		// Token: 0x040004D8 RID: 1240
		[global::Cpp2ILInjected.Token(Token = "0x4000526")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public int instanceID;

		// Token: 0x040004D9 RID: 1241
		[global::Cpp2ILInjected.Token(Token = "0x4000527")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public bool shadow;

		// Token: 0x040004DA RID: 1242
		[global::Cpp2ILInjected.Token(Token = "0x4000528")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5")]
		public LightMode mode;

		// Token: 0x040004DB RID: 1243
		[global::Cpp2ILInjected.Token(Token = "0x4000529")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public Vector3 position;

		// Token: 0x040004DC RID: 1244
		[global::Cpp2ILInjected.Token(Token = "0x400052A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public Quaternion orientation;

		// Token: 0x040004DD RID: 1245
		[global::Cpp2ILInjected.Token(Token = "0x400052B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		public LinearColor color;

		// Token: 0x040004DE RID: 1246
		[global::Cpp2ILInjected.Token(Token = "0x400052C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		public LinearColor indirectColor;

		// Token: 0x040004DF RID: 1247
		[global::Cpp2ILInjected.Token(Token = "0x400052D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		public float range;

		// Token: 0x040004E0 RID: 1248
		[global::Cpp2ILInjected.Token(Token = "0x400052E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		public float sphereRadius;

		// Token: 0x040004E1 RID: 1249
		[global::Cpp2ILInjected.Token(Token = "0x400052F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
		public float coneAngle;

		// Token: 0x040004E2 RID: 1250
		[global::Cpp2ILInjected.Token(Token = "0x4000530")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		public float innerConeAngle;

		// Token: 0x040004E3 RID: 1251
		[global::Cpp2ILInjected.Token(Token = "0x4000531")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
		public FalloffType falloff;

		// Token: 0x040004E4 RID: 1252
		[global::Cpp2ILInjected.Token(Token = "0x4000532")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x55")]
		public AngularFalloffType angularFalloff;
	}
}
