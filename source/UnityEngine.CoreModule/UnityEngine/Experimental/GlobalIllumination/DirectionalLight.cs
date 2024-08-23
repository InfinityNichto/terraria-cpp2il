using System;
using Cpp2ILInjected;

namespace UnityEngine.Experimental.GlobalIllumination
{
	// Token: 0x0200010C RID: 268
	[global::Cpp2ILInjected.Token(Token = "0x200012F")]
	public struct DirectionalLight
	{
		// Token: 0x040004C5 RID: 1221
		[global::Cpp2ILInjected.Token(Token = "0x4000513")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public int instanceID;

		// Token: 0x040004C6 RID: 1222
		[global::Cpp2ILInjected.Token(Token = "0x4000514")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public bool shadow;

		// Token: 0x040004C7 RID: 1223
		[global::Cpp2ILInjected.Token(Token = "0x4000515")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5")]
		public LightMode mode;

		// Token: 0x040004C8 RID: 1224
		[global::Cpp2ILInjected.Token(Token = "0x4000516")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public Vector3 position;

		// Token: 0x040004C9 RID: 1225
		[global::Cpp2ILInjected.Token(Token = "0x4000517")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public Quaternion orientation;

		// Token: 0x040004CA RID: 1226
		[global::Cpp2ILInjected.Token(Token = "0x4000518")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		public LinearColor color;

		// Token: 0x040004CB RID: 1227
		[global::Cpp2ILInjected.Token(Token = "0x4000519")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		public LinearColor indirectColor;

		// Token: 0x040004CC RID: 1228
		[global::Cpp2ILInjected.Token(Token = "0x400051A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		public float penumbraWidthRadian;

		// Token: 0x040004CD RID: 1229
		[Obsolete("Directional lights support cookies now. In order to position the cookie projection in the world, a position and full orientation are necessary. Use the position and orientation members instead of the direction parameter.", true)]
		[global::Cpp2ILInjected.Token(Token = "0x400051B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		public Vector3 direction;
	}
}
