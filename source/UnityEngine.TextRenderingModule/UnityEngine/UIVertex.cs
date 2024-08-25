using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[UsedByNativeCode]
	[global::Cpp2ILInjected.Token(Token = "0x200000B")]
	public struct UIVertex
	{
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000023")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA5938", Offset = "0x1FA5938", Length = "0x170")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static UIVertex()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400003E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public Vector3 position;

		[global::Cpp2ILInjected.Token(Token = "0x400003F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		public Vector3 normal;

		[global::Cpp2ILInjected.Token(Token = "0x4000040")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public Vector4 tangent;

		[global::Cpp2ILInjected.Token(Token = "0x4000041")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public Color32 color;

		[global::Cpp2ILInjected.Token(Token = "0x4000042")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		public Vector4 uv0;

		[global::Cpp2ILInjected.Token(Token = "0x4000043")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		public Vector4 uv1;

		[global::Cpp2ILInjected.Token(Token = "0x4000044")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
		public Vector4 uv2;

		[global::Cpp2ILInjected.Token(Token = "0x4000045")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
		public Vector4 uv3;

		[global::Cpp2ILInjected.Token(Token = "0x4000046")]
		private static readonly Color32 s_DefaultColor;

		[global::Cpp2ILInjected.Token(Token = "0x4000047")]
		private static readonly Vector4 s_DefaultTangent;

		[global::Cpp2ILInjected.Token(Token = "0x4000048")]
		public static UIVertex simpleVert;
	}
}
