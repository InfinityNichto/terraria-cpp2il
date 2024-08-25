using System;
using Cpp2ILInjected;
using Unity.Jobs;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
	[NativeHeader("Runtime/Camera/BatchRendererGroup.h")]
	[UsedByNativeCode]
	[global::Cpp2ILInjected.Token(Token = "0x200011C")]
	internal struct BatchRendererCullingOutput
	{
		[global::Cpp2ILInjected.Token(Token = "0x40004C2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public JobHandle cullingJobsFence;

		[global::Cpp2ILInjected.Token(Token = "0x40004C3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public Matrix4x4 cullingMatrix;

		[global::Cpp2ILInjected.Token(Token = "0x40004C4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		public unsafe Plane* cullingPlanes;

		[global::Cpp2ILInjected.Token(Token = "0x40004C5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		public unsafe BatchVisibility* batchVisibility;

		[global::Cpp2ILInjected.Token(Token = "0x40004C6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		public unsafe int* visibleIndices;

		[global::Cpp2ILInjected.Token(Token = "0x40004C7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		public unsafe int* visibleIndicesY;

		[global::Cpp2ILInjected.Token(Token = "0x40004C8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		public int cullingPlanesCount;

		[global::Cpp2ILInjected.Token(Token = "0x40004C9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x74")]
		public int batchVisibilityCount;

		[global::Cpp2ILInjected.Token(Token = "0x40004CA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		public int visibleIndicesCount;

		[global::Cpp2ILInjected.Token(Token = "0x40004CB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x7C")]
		public float nearPlane;
	}
}
