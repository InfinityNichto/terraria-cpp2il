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
	// Token: 0x020000FB RID: 251
	[RequiredByNativeCode]
	[NativeHeader("Runtime/Math/Matrix4x4.h")]
	[NativeHeader("Runtime/Camera/BatchRendererGroup.h")]
	[global::Cpp2ILInjected.Token(Token = "0x200011D")]
	[StructLayout(0)]
	public class BatchRendererGroup
	{
		// Token: 0x0600059B RID: 1435 RVA: 0x00002CB0 File Offset: 0x00000EB0
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

		// Token: 0x0400047E RID: 1150
		[global::Cpp2ILInjected.Token(Token = "0x40004CC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private IntPtr m_GroupHandle;

		// Token: 0x0400047F RID: 1151
		[global::Cpp2ILInjected.Token(Token = "0x40004CD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private BatchRendererGroup.OnPerformCulling m_PerformCulling;

		// Token: 0x02000182 RID: 386
		// (Invoke) Token: 0x060006E4 RID: 1764
		[global::Cpp2ILInjected.Token(Token = "0x200011E")]
		public delegate JobHandle OnPerformCulling(BatchRendererGroup rendererGroup, BatchCullingContext cullingContext);
	}
}
