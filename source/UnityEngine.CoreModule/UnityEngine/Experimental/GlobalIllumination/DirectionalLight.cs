using System;
using Cpp2ILInjected;

namespace UnityEngine.Experimental.GlobalIllumination
{
	[global::Cpp2ILInjected.Token(Token = "0x200012F")]
	public struct DirectionalLight
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000513")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public int instanceID;

		[global::Cpp2ILInjected.Token(Token = "0x4000514")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public bool shadow;

		[global::Cpp2ILInjected.Token(Token = "0x4000515")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5")]
		public LightMode mode;

		[global::Cpp2ILInjected.Token(Token = "0x4000516")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public Vector3 position;

		[global::Cpp2ILInjected.Token(Token = "0x4000517")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public Quaternion orientation;

		[global::Cpp2ILInjected.Token(Token = "0x4000518")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		public LinearColor color;

		[global::Cpp2ILInjected.Token(Token = "0x4000519")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		public LinearColor indirectColor;

		[global::Cpp2ILInjected.Token(Token = "0x400051A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		public float penumbraWidthRadian;

		[Obsolete("Directional lights support cookies now. In order to position the cookie projection in the world, a position and full orientation are necessary. Use the position and orientation members instead of the direction parameter.", true)]
		[global::Cpp2ILInjected.Token(Token = "0x400051B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		public Vector3 direction;
	}
}
