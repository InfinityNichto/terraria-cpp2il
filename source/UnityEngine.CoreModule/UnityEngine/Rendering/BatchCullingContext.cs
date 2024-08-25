using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Unity.Collections;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
	[NativeHeader("Runtime/Camera/BatchRendererGroup.h")]
	[UsedByNativeCode]
	[global::Cpp2ILInjected.Token(Token = "0x200011B")]
	public struct BatchCullingContext
	{
		[global::Cpp2ILInjected.Token(Token = "0x60005C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8C3B8", Offset = "0x1F8C3B8", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal BatchCullingContext(NativeArray<Plane> inCullingPlanes, NativeArray<BatchVisibility> inOutBatchVisibility, NativeArray<int> outVisibleIndices, NativeArray<int> outVisibleIndicesY, LODParameters inLodParameters, Matrix4x4 inCullingMatrix, float inNearPlane)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40004BB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public readonly NativeArray<Plane> cullingPlanes;

		[global::Cpp2ILInjected.Token(Token = "0x40004BC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public NativeArray<BatchVisibility> batchVisibility;

		[global::Cpp2ILInjected.Token(Token = "0x40004BD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public NativeArray<int> visibleIndices;

		[global::Cpp2ILInjected.Token(Token = "0x40004BE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public NativeArray<int> visibleIndicesY;

		[global::Cpp2ILInjected.Token(Token = "0x40004BF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		public readonly LODParameters lodParameters;

		[global::Cpp2ILInjected.Token(Token = "0x40004C0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
		public readonly Matrix4x4 cullingMatrix;

		[global::Cpp2ILInjected.Token(Token = "0x40004C1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x9C")]
		public readonly float nearPlane;
	}
}
