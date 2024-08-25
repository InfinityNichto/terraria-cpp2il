using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Bindings;
using UnityEngine.Rendering;

namespace Unity.Jobs
{
	[NativeType(Header = "Runtime/Jobs/ScriptBindings/JobsBindings.h")]
	[global::Cpp2ILInjected.Token(Token = "0x2000008")]
	public struct JobHandle
	{
		[NativeMethod("ScheduleBatchedScriptingJobs", IsFreeFunction = true, IsThreadSafe = true)]
		[global::Cpp2ILInjected.Token(Token = "0x6000008")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F69EA4", Offset = "0x1F69EA4", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BatchRendererGroup), Member = "InvokeOnPerformCulling", MemberParameters = new object[]
		{
			typeof(BatchRendererGroup),
			typeof(ref BatchRendererCullingOutput),
			typeof(ref LODParameters)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern void ScheduleBatchedJobs();

		[NativeDisableUnsafePtrRestriction]
		[global::Cpp2ILInjected.Token(Token = "0x400000A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		internal IntPtr jobGroup;

		[global::Cpp2ILInjected.Token(Token = "0x400000B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		internal int version;
	}
}
