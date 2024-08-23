using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
	// Token: 0x020000F7 RID: 247
	[global::Cpp2ILInjected.Token(Token = "0x2000117")]
	public class SupportedRenderingFeatures
	{
		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000582 RID: 1410 RVA: 0x00002C65 File Offset: 0x00000E65
		// (set) Token: 0x06000583 RID: 1411 RVA: 0x00002C68 File Offset: 0x00000E68
		[global::Cpp2ILInjected.Token(Token = "0x1700013A")]
		public static SupportedRenderingFeatures active
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005B1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8BC40", Offset = "0x1F8BC40", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SupportedRenderingFeatures), Member = "FallbackMixedLightingModeByRef", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SupportedRenderingFeatures), Member = "IsMixedLightingModeSupportedByRef", MemberParameters = new object[]
			{
				typeof(MixedLightingMode),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SupportedRenderingFeatures), Member = "IsLightmapBakeTypeSupportedByRef", MemberParameters = new object[]
			{
				typeof(LightmapBakeType),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SupportedRenderingFeatures), Member = "IsLightmapsModeSupportedByRef", MemberParameters = new object[]
			{
				typeof(LightmapsMode),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SupportedRenderingFeatures), Member = "IsLightmapperSupportedByRef", MemberParameters = new object[]
			{
				typeof(int),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SupportedRenderingFeatures), Member = "IsUIOverlayRenderedBySRP", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SupportedRenderingFeatures), Member = "IsAutoAmbientProbeBakingSupported", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SupportedRenderingFeatures), Member = "IsAutoDefaultReflectionProbeBakingSupported", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 16)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SupportedRenderingFeatures), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60005B2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8ABE0", Offset = "0x1F8ABE0", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RenderPipelineManager), Member = "CleanupRenderPipeline", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000584 RID: 1412 RVA: 0x00002C6B File Offset: 0x00000E6B
		[global::Cpp2ILInjected.Token(Token = "0x1700013B")]
		public SupportedRenderingFeatures.LightmapMixedBakeModes defaultMixedLightingModes
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60005B3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8BCE0", Offset = "0x1F8BCE0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000585 RID: 1413 RVA: 0x00002C6E File Offset: 0x00000E6E
		[global::Cpp2ILInjected.Token(Token = "0x1700013C")]
		public SupportedRenderingFeatures.LightmapMixedBakeModes mixedLightingModes
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60005B4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8BCE8", Offset = "0x1F8BCE8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000586 RID: 1414 RVA: 0x00002C71 File Offset: 0x00000E71
		[global::Cpp2ILInjected.Token(Token = "0x1700013D")]
		public LightmapBakeType lightmapBakeTypes
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60005B5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8BCF0", Offset = "0x1F8BCF0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000587 RID: 1415 RVA: 0x00002C74 File Offset: 0x00000E74
		[global::Cpp2ILInjected.Token(Token = "0x1700013E")]
		public LightmapsMode lightmapsModes
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60005B6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8BCF8", Offset = "0x1F8BCF8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000588 RID: 1416 RVA: 0x00002C77 File Offset: 0x00000E77
		[global::Cpp2ILInjected.Token(Token = "0x1700013F")]
		public bool enlightenLightmapper
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60005B7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8BD00", Offset = "0x1F8BD00", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000589 RID: 1417 RVA: 0x00002C7A File Offset: 0x00000E7A
		[global::Cpp2ILInjected.Token(Token = "0x17000140")]
		public bool enlighten
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60005B8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8BD08", Offset = "0x1F8BD08", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x0600058A RID: 1418 RVA: 0x00002C7D File Offset: 0x00000E7D
		[global::Cpp2ILInjected.Token(Token = "0x17000141")]
		public bool rendersUIOverlay
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60005B9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8BD10", Offset = "0x1F8BD10", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x0600058B RID: 1419 RVA: 0x00002C80 File Offset: 0x00000E80
		[global::Cpp2ILInjected.Token(Token = "0x17000142")]
		public bool autoAmbientProbeBaking
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60005BA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8BD18", Offset = "0x1F8BD18", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x0600058C RID: 1420 RVA: 0x00002C83 File Offset: 0x00000E83
		[global::Cpp2ILInjected.Token(Token = "0x17000143")]
		public bool autoDefaultReflectionProbeBaking
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60005BB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8BD20", Offset = "0x1F8BD20", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x00002C86 File Offset: 0x00000E86
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x60005BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8BD28", Offset = "0x1F8BD28", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(void*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SupportedRenderingFeatures), Member = "get_active", ReturnType = typeof(SupportedRenderingFeatures))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SupportedRenderingFeatures), Member = "IsMixedLightingModeSupported", MemberParameters = new object[] { typeof(MixedLightingMode) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal unsafe static void FallbackMixedLightingModeByRef(IntPtr fallbackModePtr)
		{
			throw null;
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x00002C89 File Offset: 0x00000E89
		[global::Cpp2ILInjected.Token(Token = "0x60005BD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8BE44", Offset = "0x1F8BE44", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SupportedRenderingFeatures), Member = "FallbackMixedLightingModeByRef", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SupportedRenderingFeatures), Member = "IsMixedLightingModeSupportedByRef", MemberParameters = new object[]
		{
			typeof(MixedLightingMode),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static bool IsMixedLightingModeSupported(MixedLightingMode mixedMode)
		{
			throw null;
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x00002C8C File Offset: 0x00000E8C
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x60005BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8BEB0", Offset = "0x1F8BEB0", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SupportedRenderingFeatures), Member = "IsMixedLightingModeSupported", MemberParameters = new object[] { typeof(MixedLightingMode) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(void*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SupportedRenderingFeatures), Member = "IsLightmapBakeTypeSupported", MemberParameters = new object[] { typeof(LightmapBakeType) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SupportedRenderingFeatures), Member = "get_active", ReturnType = typeof(SupportedRenderingFeatures))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal unsafe static void IsMixedLightingModeSupportedByRef(MixedLightingMode mixedMode, IntPtr isSupportedPtr)
		{
			throw null;
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x00002C8F File Offset: 0x00000E8F
		[global::Cpp2ILInjected.Token(Token = "0x60005BF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8BFA8", Offset = "0x1F8BFA8", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SupportedRenderingFeatures), Member = "IsMixedLightingModeSupportedByRef", MemberParameters = new object[]
		{
			typeof(MixedLightingMode),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SupportedRenderingFeatures), Member = "IsLightmapBakeTypeSupportedByRef", MemberParameters = new object[]
		{
			typeof(LightmapBakeType),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SupportedRenderingFeatures), Member = "IsLightmapBakeTypeSupportedByRef", MemberParameters = new object[]
		{
			typeof(LightmapBakeType),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static bool IsLightmapBakeTypeSupported(LightmapBakeType bakeType)
		{
			throw null;
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x00002C92 File Offset: 0x00000E92
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x60005C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8C014", Offset = "0x1F8C014", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SupportedRenderingFeatures), Member = "IsLightmapBakeTypeSupported", MemberParameters = new object[] { typeof(LightmapBakeType) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(void*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SupportedRenderingFeatures), Member = "IsLightmapBakeTypeSupported", MemberParameters = new object[] { typeof(LightmapBakeType) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SupportedRenderingFeatures), Member = "get_active", ReturnType = typeof(SupportedRenderingFeatures))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal unsafe static void IsLightmapBakeTypeSupportedByRef(LightmapBakeType bakeType, IntPtr isSupportedPtr)
		{
			throw null;
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x00002C95 File Offset: 0x00000E95
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x60005C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8C0F4", Offset = "0x1F8C0F4", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(void*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SupportedRenderingFeatures), Member = "get_active", ReturnType = typeof(SupportedRenderingFeatures))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal unsafe static void IsLightmapsModeSupportedByRef(LightmapsMode mode, IntPtr isSupportedPtr)
		{
			throw null;
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x00002C98 File Offset: 0x00000E98
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x60005C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8C178", Offset = "0x1F8C178", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(void*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SupportedRenderingFeatures), Member = "get_active", ReturnType = typeof(SupportedRenderingFeatures))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal unsafe static void IsLightmapperSupportedByRef(int lightmapper, IntPtr isSupportedPtr)
		{
			throw null;
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x00002C9B File Offset: 0x00000E9B
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x60005C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8C1F4", Offset = "0x1F8C1F4", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(void*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SupportedRenderingFeatures), Member = "get_active", ReturnType = typeof(SupportedRenderingFeatures))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal unsafe static void IsUIOverlayRenderedBySRP(IntPtr isSupportedPtr)
		{
			throw null;
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x00002C9E File Offset: 0x00000E9E
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x60005C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8C264", Offset = "0x1F8C264", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(void*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SupportedRenderingFeatures), Member = "get_active", ReturnType = typeof(SupportedRenderingFeatures))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal unsafe static void IsAutoAmbientProbeBakingSupported(IntPtr isSupportedPtr)
		{
			throw null;
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x00002CA1 File Offset: 0x00000EA1
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x60005C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8C2D4", Offset = "0x1F8C2D4", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(void*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SupportedRenderingFeatures), Member = "get_active", ReturnType = typeof(SupportedRenderingFeatures))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal unsafe static void IsAutoDefaultReflectionProbeBakingSupported(IntPtr isSupportedPtr)
		{
			throw null;
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x00002CA4 File Offset: 0x00000EA4
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x60005C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8C344", Offset = "0x1F8C344", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(void*))]
		internal unsafe static void FallbackLightmapperByRef(IntPtr lightmapperPtr)
		{
			throw null;
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x00002CA7 File Offset: 0x00000EA7
		[global::Cpp2ILInjected.Token(Token = "0x60005C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8AB50", Offset = "0x1F8AB50", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RenderPipelineManager), Member = "CleanupRenderPipeline", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SupportedRenderingFeatures), Member = "get_active", ReturnType = typeof(SupportedRenderingFeatures))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SupportedRenderingFeatures), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public SupportedRenderingFeatures()
		{
			throw null;
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x00002CAA File Offset: 0x00000EAA
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60005C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8C360", Offset = "0x1F8C360", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SupportedRenderingFeatures), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static SupportedRenderingFeatures()
		{
			throw null;
		}

		// Token: 0x0400044E RID: 1102
		[global::Cpp2ILInjected.Token(Token = "0x4000494")]
		private static SupportedRenderingFeatures s_Active;

		// Token: 0x0400044F RID: 1103
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x4000495")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private SupportedRenderingFeatures.ReflectionProbeModes <reflectionProbeModes>k__BackingField;

		// Token: 0x04000450 RID: 1104
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x4000496")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private SupportedRenderingFeatures.LightmapMixedBakeModes <defaultMixedLightingModes>k__BackingField;

		// Token: 0x04000451 RID: 1105
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000497")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private SupportedRenderingFeatures.LightmapMixedBakeModes <mixedLightingModes>k__BackingField;

		// Token: 0x04000452 RID: 1106
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000498")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private LightmapBakeType <lightmapBakeTypes>k__BackingField;

		// Token: 0x04000453 RID: 1107
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x4000499")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private LightmapsMode <lightmapsModes>k__BackingField;

		// Token: 0x04000454 RID: 1108
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400049A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private bool <enlightenLightmapper>k__BackingField;

		// Token: 0x04000455 RID: 1109
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400049B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x25")]
		private bool <enlighten>k__BackingField;

		// Token: 0x04000456 RID: 1110
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400049C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x26")]
		private bool <lightProbeProxyVolumes>k__BackingField;

		// Token: 0x04000457 RID: 1111
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400049D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x27")]
		private bool <motionVectors>k__BackingField;

		// Token: 0x04000458 RID: 1112
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400049E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private bool <receiveShadows>k__BackingField;

		// Token: 0x04000459 RID: 1113
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400049F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x29")]
		private bool <reflectionProbes>k__BackingField;

		// Token: 0x0400045A RID: 1114
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40004A0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2A")]
		private bool <reflectionProbesBlendDistance>k__BackingField;

		// Token: 0x0400045B RID: 1115
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x40004A1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2B")]
		private bool <rendererPriority>k__BackingField;

		// Token: 0x0400045C RID: 1116
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x40004A2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		private bool <rendersUIOverlay>k__BackingField;

		// Token: 0x0400045D RID: 1117
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x40004A3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2D")]
		private bool <overridesEnvironmentLighting>k__BackingField;

		// Token: 0x0400045E RID: 1118
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x40004A4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2E")]
		private bool <overridesFog>k__BackingField;

		// Token: 0x0400045F RID: 1119
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x40004A5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2F")]
		private bool <overridesRealtimeReflectionProbes>k__BackingField;

		// Token: 0x04000460 RID: 1120
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x40004A6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private bool <overridesOtherLightingSettings>k__BackingField;

		// Token: 0x04000461 RID: 1121
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40004A7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x31")]
		private bool <editableMaterialRenderQueue>k__BackingField;

		// Token: 0x04000462 RID: 1122
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x40004A8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x32")]
		private bool <overridesLODBias>k__BackingField;

		// Token: 0x04000463 RID: 1123
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x40004A9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x33")]
		private bool <overridesMaximumLODLevel>k__BackingField;

		// Token: 0x04000464 RID: 1124
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40004AA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		private bool <rendererProbes>k__BackingField;

		// Token: 0x04000465 RID: 1125
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x40004AB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x35")]
		private bool <particleSystemInstancing>k__BackingField;

		// Token: 0x04000466 RID: 1126
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x40004AC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x36")]
		private bool <autoAmbientProbeBaking>k__BackingField;

		// Token: 0x04000467 RID: 1127
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40004AD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x37")]
		private bool <autoDefaultReflectionProbeBaking>k__BackingField;

		// Token: 0x04000468 RID: 1128
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x40004AE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private bool <overridesShadowmask>k__BackingField;

		// Token: 0x04000469 RID: 1129
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x40004AF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private string <overrideShadowmaskMessage>k__BackingField;

		// Token: 0x02000180 RID: 384
		[Flags]
		[global::Cpp2ILInjected.Token(Token = "0x2000118")]
		public enum ReflectionProbeModes
		{
			// Token: 0x04000677 RID: 1655
			[global::Cpp2ILInjected.Token(Token = "0x40004B1")]
			None = 0,
			// Token: 0x04000678 RID: 1656
			[global::Cpp2ILInjected.Token(Token = "0x40004B2")]
			Rotation = 1
		}

		// Token: 0x02000181 RID: 385
		[Flags]
		[global::Cpp2ILInjected.Token(Token = "0x2000119")]
		public enum LightmapMixedBakeModes
		{
			// Token: 0x0400067A RID: 1658
			[global::Cpp2ILInjected.Token(Token = "0x40004B4")]
			None = 0,
			// Token: 0x0400067B RID: 1659
			[global::Cpp2ILInjected.Token(Token = "0x40004B5")]
			IndirectOnly = 1,
			// Token: 0x0400067C RID: 1660
			[global::Cpp2ILInjected.Token(Token = "0x40004B6")]
			Subtractive = 2,
			// Token: 0x0400067D RID: 1661
			[global::Cpp2ILInjected.Token(Token = "0x40004B7")]
			Shadowmask = 4
		}
	}
}
