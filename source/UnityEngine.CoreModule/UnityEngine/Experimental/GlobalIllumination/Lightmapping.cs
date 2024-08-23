using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.GlobalIllumination
{
	// Token: 0x02000114 RID: 276
	[global::Cpp2ILInjected.Token(Token = "0x2000137")]
	public static class Lightmapping
	{
		// Token: 0x060005CF RID: 1487 RVA: 0x00002D43 File Offset: 0x00000F43
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x6000600")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8E480", Offset = "0x1F8E480", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void SetDelegate(Lightmapping.RequestLightsDelegate del)
		{
			throw null;
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x00002D46 File Offset: 0x00000F46
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x6000601")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8E4F8", Offset = "0x1F8E4F8", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static Lightmapping.RequestLightsDelegate GetDelegate()
		{
			throw null;
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x00002D49 File Offset: 0x00000F49
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x6000602")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8E550", Offset = "0x1F8E550", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void ResetDelegate()
		{
			throw null;
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x00002D4C File Offset: 0x00000F4C
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x6000603")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8E5AC", Offset = "0x1F8E5AC", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(void*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NativeArrayUnsafeUtility[]), Member = "ConvertExistingDataToNativeArray", MemberTypeParameters = new object[] { typeof(LightDataGI) }, MemberParameters = new object[]
		{
			typeof(void*),
			typeof(int),
			typeof(Allocator)
		}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal unsafe static void RequestLights(Light[] lights, IntPtr outLightsPtr, int outLightsCount)
		{
			throw null;
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x00002D4F File Offset: 0x00000F4F
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000604")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8E670", Offset = "0x1F8E670", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lightmapping.RequestLightsDelegate), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		static Lightmapping()
		{
			throw null;
		}

		// Token: 0x0400050D RID: 1293
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x400055B")]
		private static readonly Lightmapping.RequestLightsDelegate s_DefaultDelegate;

		// Token: 0x0400050E RID: 1294
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x400055C")]
		private static Lightmapping.RequestLightsDelegate s_RequestLightsDelegate;

		// Token: 0x02000183 RID: 387
		// (Invoke) Token: 0x060006E6 RID: 1766
		[global::Cpp2ILInjected.Token(Token = "0x2000138")]
		public delegate void RequestLightsDelegate(Light[] requests, NativeArray<LightDataGI> lightsOutput);

		// Token: 0x02000184 RID: 388
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000139")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060006E7 RID: 1767 RVA: 0x00002FE3 File Offset: 0x000011E3
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6000607")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8E82C", Offset = "0x1F8E82C", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			// Token: 0x060006E8 RID: 1768 RVA: 0x00002FE6 File Offset: 0x000011E6
			[global::Cpp2ILInjected.Token(Token = "0x6000608")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8E888", Offset = "0x1F8E888", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			// Token: 0x060006E9 RID: 1769 RVA: 0x00002FE9 File Offset: 0x000011E9
			[global::Cpp2ILInjected.Token(Token = "0x6000609")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8E890", Offset = "0x1F8E890", Length = "0x49C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Light), Member = "get_type", ReturnType = typeof(LightType))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new object[]
			{
				typeof(Light),
				typeof(ref SpotLight)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new object[]
			{
				typeof(Light),
				typeof(ref Cookie)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new object[]
			{
				typeof(Light),
				typeof(ref DirectionalLight)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new object[]
			{
				typeof(Light),
				typeof(ref PointLight)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new object[]
			{
				typeof(Light),
				typeof(ref RectangleLight)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new object[]
			{
				typeof(Light),
				typeof(ref DiscLight)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal void <.cctor>b__7_0(Light[] requests, NativeArray<LightDataGI> lightsOutput)
			{
				throw null;
			}

			// Token: 0x0400067E RID: 1662
			[global::Cpp2ILInjected.Token(Token = "0x400055D")]
			public static readonly Lightmapping.<>c <>9;
		}
	}
}
