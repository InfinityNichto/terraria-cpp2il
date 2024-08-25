using System;
using Cpp2ILInjected;

namespace UnityEngine.Experimental.GlobalIllumination
{
	[global::Cpp2ILInjected.Token(Token = "0x2000132")]
	public struct RectangleLight
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000533")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public int instanceID;

		[global::Cpp2ILInjected.Token(Token = "0x4000534")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public bool shadow;

		[global::Cpp2ILInjected.Token(Token = "0x4000535")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5")]
		public LightMode mode;

		[global::Cpp2ILInjected.Token(Token = "0x4000536")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public Vector3 position;

		[global::Cpp2ILInjected.Token(Token = "0x4000537")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public Quaternion orientation;

		[global::Cpp2ILInjected.Token(Token = "0x4000538")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		public LinearColor color;

		[global::Cpp2ILInjected.Token(Token = "0x4000539")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		public LinearColor indirectColor;

		[global::Cpp2ILInjected.Token(Token = "0x400053A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		public float range;

		[global::Cpp2ILInjected.Token(Token = "0x400053B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		public float width;

		[global::Cpp2ILInjected.Token(Token = "0x400053C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
		public float height;

		[global::Cpp2ILInjected.Token(Token = "0x400053D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		public FalloffType falloff;
	}
}
