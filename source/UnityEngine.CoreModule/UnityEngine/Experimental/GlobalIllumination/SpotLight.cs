using System;
using Cpp2ILInjected;

namespace UnityEngine.Experimental.GlobalIllumination
{
	[global::Cpp2ILInjected.Token(Token = "0x2000131")]
	public struct SpotLight
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000526")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public int instanceID;

		[global::Cpp2ILInjected.Token(Token = "0x4000527")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public bool shadow;

		[global::Cpp2ILInjected.Token(Token = "0x4000528")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5")]
		public LightMode mode;

		[global::Cpp2ILInjected.Token(Token = "0x4000529")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public Vector3 position;

		[global::Cpp2ILInjected.Token(Token = "0x400052A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public Quaternion orientation;

		[global::Cpp2ILInjected.Token(Token = "0x400052B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		public LinearColor color;

		[global::Cpp2ILInjected.Token(Token = "0x400052C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		public LinearColor indirectColor;

		[global::Cpp2ILInjected.Token(Token = "0x400052D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		public float range;

		[global::Cpp2ILInjected.Token(Token = "0x400052E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		public float sphereRadius;

		[global::Cpp2ILInjected.Token(Token = "0x400052F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
		public float coneAngle;

		[global::Cpp2ILInjected.Token(Token = "0x4000530")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		public float innerConeAngle;

		[global::Cpp2ILInjected.Token(Token = "0x4000531")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
		public FalloffType falloff;

		[global::Cpp2ILInjected.Token(Token = "0x4000532")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x55")]
		public AngularFalloffType angularFalloff;
	}
}
