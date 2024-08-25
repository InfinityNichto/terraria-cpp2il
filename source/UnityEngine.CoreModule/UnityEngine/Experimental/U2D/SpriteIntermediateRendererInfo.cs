using System;
using Cpp2ILInjected;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.U2D
{
	[NativeHeader("Runtime/2D/Renderer/SpriteRendererGroup.h")]
	[RequiredByNativeCode]
	[global::Cpp2ILInjected.Token(Token = "0x2000128")]
	internal struct SpriteIntermediateRendererInfo
	{
		[global::Cpp2ILInjected.Token(Token = "0x40004EA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public int SpriteID;

		[global::Cpp2ILInjected.Token(Token = "0x40004EB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public int TextureID;

		[global::Cpp2ILInjected.Token(Token = "0x40004EC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public int MaterialID;

		[global::Cpp2ILInjected.Token(Token = "0x40004ED")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		public Color Color;

		[global::Cpp2ILInjected.Token(Token = "0x40004EE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public Matrix4x4 Transform;

		[global::Cpp2ILInjected.Token(Token = "0x40004EF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
		public Bounds Bounds;

		[global::Cpp2ILInjected.Token(Token = "0x40004F0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x74")]
		public int Layer;

		[global::Cpp2ILInjected.Token(Token = "0x40004F1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		public int SortingLayer;

		[global::Cpp2ILInjected.Token(Token = "0x40004F2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x7C")]
		public int SortingOrder;

		[global::Cpp2ILInjected.Token(Token = "0x40004F3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		public ulong SceneCullingMask;

		[global::Cpp2ILInjected.Token(Token = "0x40004F4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		public IntPtr IndexData;

		[global::Cpp2ILInjected.Token(Token = "0x40004F5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		public IntPtr VertexData;

		[global::Cpp2ILInjected.Token(Token = "0x40004F6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		public int IndexCount;

		[global::Cpp2ILInjected.Token(Token = "0x40004F7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x9C")]
		public int VertexCount;

		[global::Cpp2ILInjected.Token(Token = "0x40004F8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		public int ShaderChannelMask;
	}
}
