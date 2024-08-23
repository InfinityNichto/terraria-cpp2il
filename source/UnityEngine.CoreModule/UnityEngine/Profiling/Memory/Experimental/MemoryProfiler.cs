using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Bindings;
using UnityEngine.Profiling.Experimental;
using UnityEngine.Scripting;

namespace UnityEngine.Profiling.Memory.Experimental
{
	// Token: 0x020000DA RID: 218
	[NativeHeader("Modules/Profiler/Runtime/MemorySnapshotManager.h")]
	[global::Cpp2ILInjected.Token(Token = "0x20000F1")]
	public sealed class MemoryProfiler
	{
		// Token: 0x060004FE RID: 1278 RVA: 0x00002AE5 File Offset: 0x00000CE5
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x600051C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F87E64", Offset = "0x1F87E64", Length = "0x19C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryProfiler), Member = "WriteStringToByteArray", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private static byte[] PrepareMetadata()
		{
			throw null;
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x00002AE8 File Offset: 0x00000CE8
		[global::Cpp2ILInjected.Token(Token = "0x600051D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F88000", Offset = "0x1F88000", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal static int WriteIntToByteArray(byte[] array, int offset, int value)
		{
			throw null;
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x00002AEB File Offset: 0x00000CEB
		[global::Cpp2ILInjected.Token(Token = "0x600051E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F88040", Offset = "0x1F88040", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MemoryProfiler), Member = "PrepareMetadata", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		internal static int WriteStringToByteArray(byte[] array, int offset, string value)
		{
			throw null;
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x00002AEE File Offset: 0x00000CEE
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x600051F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F880BC", Offset = "0x1F880BC", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static void FinalizeSnapshot(string path, bool result)
		{
			throw null;
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x00002AF1 File Offset: 0x00000CF1
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x6000520")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F88140", Offset = "0x1F88140", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NativeArrayUnsafeUtility[]), Member = "ConvertExistingDataToNativeArray", MemberTypeParameters = new object[] { typeof(byte) }, MemberParameters = new object[]
		{
			typeof(void*),
			typeof(int),
			typeof(Allocator)
		}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private unsafe static void SaveScreenshotToDisk(string path, bool result, IntPtr pixelsPtr, int pixelsCount, TextureFormat format, int width, int height)
		{
			throw null;
		}

		// Token: 0x040003CE RID: 974
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400040B")]
		private static Action<string, bool> m_SnapshotFinished;

		// Token: 0x040003CF RID: 975
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400040C")]
		private static Action<string, bool, DebugScreenCapture> m_SaveScreenshotToDisk;

		// Token: 0x040003D0 RID: 976
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400040D")]
		private static Action<MetaData> createMetaData;
	}
}
