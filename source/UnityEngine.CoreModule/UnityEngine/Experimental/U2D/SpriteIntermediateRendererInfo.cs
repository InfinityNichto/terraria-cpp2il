using System;
using Cpp2ILInjected;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.U2D
{
	// Token: 0x02000105 RID: 261
	[NativeHeader("Runtime/2D/Renderer/SpriteRendererGroup.h")]
	[RequiredByNativeCode]
	[global::Cpp2ILInjected.Token(Token = "0x2000128")]
	internal struct SpriteIntermediateRendererInfo
	{
		// Token: 0x0400049C RID: 1180
		[global::Cpp2ILInjected.Token(Token = "0x40004EA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public int SpriteID;

		// Token: 0x0400049D RID: 1181
		[global::Cpp2ILInjected.Token(Token = "0x40004EB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public int TextureID;

		// Token: 0x0400049E RID: 1182
		[global::Cpp2ILInjected.Token(Token = "0x40004EC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public int MaterialID;

		// Token: 0x0400049F RID: 1183
		[global::Cpp2ILInjected.Token(Token = "0x40004ED")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		public Color Color;

		// Token: 0x040004A0 RID: 1184
		[global::Cpp2ILInjected.Token(Token = "0x40004EE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public Matrix4x4 Transform;

		// Token: 0x040004A1 RID: 1185
		[global::Cpp2ILInjected.Token(Token = "0x40004EF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
		public Bounds Bounds;

		// Token: 0x040004A2 RID: 1186
		[global::Cpp2ILInjected.Token(Token = "0x40004F0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x74")]
		public int Layer;

		// Token: 0x040004A3 RID: 1187
		[global::Cpp2ILInjected.Token(Token = "0x40004F1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		public int SortingLayer;

		// Token: 0x040004A4 RID: 1188
		[global::Cpp2ILInjected.Token(Token = "0x40004F2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x7C")]
		public int SortingOrder;

		// Token: 0x040004A5 RID: 1189
		[global::Cpp2ILInjected.Token(Token = "0x40004F3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		public ulong SceneCullingMask;

		// Token: 0x040004A6 RID: 1190
		[global::Cpp2ILInjected.Token(Token = "0x40004F4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		public IntPtr IndexData;

		// Token: 0x040004A7 RID: 1191
		[global::Cpp2ILInjected.Token(Token = "0x40004F5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		public IntPtr VertexData;

		// Token: 0x040004A8 RID: 1192
		[global::Cpp2ILInjected.Token(Token = "0x40004F6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		public int IndexCount;

		// Token: 0x040004A9 RID: 1193
		[global::Cpp2ILInjected.Token(Token = "0x40004F7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x9C")]
		public int VertexCount;

		// Token: 0x040004AA RID: 1194
		[global::Cpp2ILInjected.Token(Token = "0x40004F8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		public int ShaderChannelMask;
	}
}
