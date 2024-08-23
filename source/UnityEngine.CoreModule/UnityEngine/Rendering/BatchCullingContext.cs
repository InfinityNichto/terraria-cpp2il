using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Unity.Collections;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
	// Token: 0x020000F9 RID: 249
	[NativeHeader("Runtime/Camera/BatchRendererGroup.h")]
	[UsedByNativeCode]
	[global::Cpp2ILInjected.Token(Token = "0x200011B")]
	public struct BatchCullingContext
	{
		// Token: 0x0600059A RID: 1434 RVA: 0x00002CAD File Offset: 0x00000EAD
		[global::Cpp2ILInjected.Token(Token = "0x60005C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8C3B8", Offset = "0x1F8C3B8", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal BatchCullingContext(NativeArray<Plane> inCullingPlanes, NativeArray<BatchVisibility> inOutBatchVisibility, NativeArray<int> outVisibleIndices, NativeArray<int> outVisibleIndicesY, LODParameters inLodParameters, Matrix4x4 inCullingMatrix, float inNearPlane)
		{
			throw null;
		}

		// Token: 0x0400046D RID: 1133
		[global::Cpp2ILInjected.Token(Token = "0x40004BB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public readonly NativeArray<Plane> cullingPlanes;

		// Token: 0x0400046E RID: 1134
		[global::Cpp2ILInjected.Token(Token = "0x40004BC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public NativeArray<BatchVisibility> batchVisibility;

		// Token: 0x0400046F RID: 1135
		[global::Cpp2ILInjected.Token(Token = "0x40004BD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public NativeArray<int> visibleIndices;

		// Token: 0x04000470 RID: 1136
		[global::Cpp2ILInjected.Token(Token = "0x40004BE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public NativeArray<int> visibleIndicesY;

		// Token: 0x04000471 RID: 1137
		[global::Cpp2ILInjected.Token(Token = "0x40004BF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		public readonly LODParameters lodParameters;

		// Token: 0x04000472 RID: 1138
		[global::Cpp2ILInjected.Token(Token = "0x40004C0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
		public readonly Matrix4x4 cullingMatrix;

		// Token: 0x04000473 RID: 1139
		[global::Cpp2ILInjected.Token(Token = "0x40004C1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x9C")]
		public readonly float nearPlane;
	}
}
