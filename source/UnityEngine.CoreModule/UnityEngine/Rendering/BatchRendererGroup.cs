using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
	[RequiredByNativeCode]
	[NativeHeader("Runtime/Math/Matrix4x4.h")]
	[NativeHeader("Runtime/Camera/BatchRendererGroup.h")]
	[global::Cpp2ILInjected.Token(Token = "0x200011D")]
	[StructLayout(0)]
	public class BatchRendererGroup
	{
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x60005CA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8C40C", Offset = "0x1F8C40C", Length = "0x1F8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NativeArrayUnsafeUtility[]), Member = "ConvertExistingDataToNativeArray", MemberTypeParameters = new object[] { typeof(Plane) }, MemberParameters = new object[]
		{
			typeof(void*),
			typeof(int),
			typeof(Allocator)
		}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NativeArrayUnsafeUtility), Member = "ConvertExistingDataToNativeArray", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(void*),
			typeof(int),
			typeof(Allocator)
		}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NativeArrayUnsafeUtility[]), Member = "ConvertExistingDataToNativeArray", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
		{
			typeof(void*),
			typeof(int),
			typeof(Allocator)
		}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JobHandle), Member = "ScheduleBatchedJobs", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private unsafe static void InvokeOnPerformCulling(BatchRendererGroup group, ref BatchRendererCullingOutput context, ref LODParameters lodParameters)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40004CC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private IntPtr m_GroupHandle;

		[global::Cpp2ILInjected.Token(Token = "0x40004CD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private BatchRendererGroup.OnPerformCulling m_PerformCulling;

		[global::Cpp2ILInjected.Token(Token = "0x200011E")]
		public delegate JobHandle OnPerformCulling(BatchRendererGroup rendererGroup, BatchCullingContext cullingContext);
	}
}
