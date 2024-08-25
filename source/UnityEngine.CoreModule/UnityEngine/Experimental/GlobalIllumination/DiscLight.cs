using System;
using Cpp2ILInjected;

namespace UnityEngine.Experimental.GlobalIllumination
{
	[global::Cpp2ILInjected.Token(Token = "0x2000133")]
	public struct DiscLight
	{
		[global::Cpp2ILInjected.Token(Token = "0x400053E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public int instanceID;

		[global::Cpp2ILInjected.Token(Token = "0x400053F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public bool shadow;

		[global::Cpp2ILInjected.Token(Token = "0x4000540")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5")]
		public LightMode mode;

		[global::Cpp2ILInjected.Token(Token = "0x4000541")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public Vector3 position;

		[global::Cpp2ILInjected.Token(Token = "0x4000542")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public Quaternion orientation;

		[global::Cpp2ILInjected.Token(Token = "0x4000543")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		public LinearColor color;

		[global::Cpp2ILInjected.Token(Token = "0x4000544")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		public LinearColor indirectColor;

		[global::Cpp2ILInjected.Token(Token = "0x4000545")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		public float range;

		[global::Cpp2ILInjected.Token(Token = "0x4000546")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		public float radius;

		[global::Cpp2ILInjected.Token(Token = "0x4000547")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
		public FalloffType falloff;
	}
}
