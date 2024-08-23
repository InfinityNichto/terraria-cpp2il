using System;
using Cpp2ILInjected;
using Unity.Jobs;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
	// Token: 0x020000FA RID: 250
	[NativeHeader("Runtime/Camera/BatchRendererGroup.h")]
	[UsedByNativeCode]
	[global::Cpp2ILInjected.Token(Token = "0x200011C")]
	internal struct BatchRendererCullingOutput
	{
		// Token: 0x04000474 RID: 1140
		[global::Cpp2ILInjected.Token(Token = "0x40004C2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public JobHandle cullingJobsFence;

		// Token: 0x04000475 RID: 1141
		[global::Cpp2ILInjected.Token(Token = "0x40004C3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public Matrix4x4 cullingMatrix;

		// Token: 0x04000476 RID: 1142
		[global::Cpp2ILInjected.Token(Token = "0x40004C4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		public unsafe Plane* cullingPlanes;

		// Token: 0x04000477 RID: 1143
		[global::Cpp2ILInjected.Token(Token = "0x40004C5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		public unsafe BatchVisibility* batchVisibility;

		// Token: 0x04000478 RID: 1144
		[global::Cpp2ILInjected.Token(Token = "0x40004C6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		public unsafe int* visibleIndices;

		// Token: 0x04000479 RID: 1145
		[global::Cpp2ILInjected.Token(Token = "0x40004C7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		public unsafe int* visibleIndicesY;

		// Token: 0x0400047A RID: 1146
		[global::Cpp2ILInjected.Token(Token = "0x40004C8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		public int cullingPlanesCount;

		// Token: 0x0400047B RID: 1147
		[global::Cpp2ILInjected.Token(Token = "0x40004C9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x74")]
		public int batchVisibilityCount;

		// Token: 0x0400047C RID: 1148
		[global::Cpp2ILInjected.Token(Token = "0x40004CA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		public int visibleIndicesCount;

		// Token: 0x0400047D RID: 1149
		[global::Cpp2ILInjected.Token(Token = "0x40004CB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x7C")]
		public float nearPlane;
	}
}
