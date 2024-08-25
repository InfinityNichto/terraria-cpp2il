using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
	[global::Cpp2ILInjected.Token(Token = "0x2000117")]
	public class SupportedRenderingFeatures
	{
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

		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x60005C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8C344", Offset = "0x1F8C344", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(void*))]
		internal unsafe static void FallbackLightmapperByRef(IntPtr lightmapperPtr)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x4000494")]
		private static SupportedRenderingFeatures s_Active;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x4000495")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private SupportedRenderingFeatures.ReflectionProbeModes <reflectionProbeModes>k__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x4000496")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private SupportedRenderingFeatures.LightmapMixedBakeModes <defaultMixedLightingModes>k__BackingField;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000497")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private SupportedRenderingFeatures.LightmapMixedBakeModes <mixedLightingModes>k__BackingField;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000498")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private LightmapBakeType <lightmapBakeTypes>k__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x4000499")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private LightmapsMode <lightmapsModes>k__BackingField;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400049A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private bool <enlightenLightmapper>k__BackingField;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400049B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x25")]
		private bool <enlighten>k__BackingField;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400049C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x26")]
		private bool <lightProbeProxyVolumes>k__BackingField;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400049D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x27")]
		private bool <motionVectors>k__BackingField;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400049E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private bool <receiveShadows>k__BackingField;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400049F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x29")]
		private bool <reflectionProbes>k__BackingField;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40004A0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2A")]
		private bool <reflectionProbesBlendDistance>k__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x40004A1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2B")]
		private bool <rendererPriority>k__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x40004A2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		private bool <rendersUIOverlay>k__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x40004A3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2D")]
		private bool <overridesEnvironmentLighting>k__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x40004A4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2E")]
		private bool <overridesFog>k__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x40004A5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2F")]
		private bool <overridesRealtimeReflectionProbes>k__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x40004A6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private bool <overridesOtherLightingSettings>k__BackingField;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40004A7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x31")]
		private bool <editableMaterialRenderQueue>k__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x40004A8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x32")]
		private bool <overridesLODBias>k__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x40004A9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x33")]
		private bool <overridesMaximumLODLevel>k__BackingField;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40004AA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		private bool <rendererProbes>k__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x40004AB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x35")]
		private bool <particleSystemInstancing>k__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x40004AC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x36")]
		private bool <autoAmbientProbeBaking>k__BackingField;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40004AD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x37")]
		private bool <autoDefaultReflectionProbeBaking>k__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x40004AE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private bool <overridesShadowmask>k__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x40004AF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private string <overrideShadowmaskMessage>k__BackingField;

		[Flags]
		[global::Cpp2ILInjected.Token(Token = "0x2000118")]
		public enum ReflectionProbeModes
		{
			[global::Cpp2ILInjected.Token(Token = "0x40004B1")]
			None = 0,
			[global::Cpp2ILInjected.Token(Token = "0x40004B2")]
			Rotation = 1
		}

		[Flags]
		[global::Cpp2ILInjected.Token(Token = "0x2000119")]
		public enum LightmapMixedBakeModes
		{
			[global::Cpp2ILInjected.Token(Token = "0x40004B4")]
			None = 0,
			[global::Cpp2ILInjected.Token(Token = "0x40004B5")]
			IndirectOnly = 1,
			[global::Cpp2ILInjected.Token(Token = "0x40004B6")]
			Subtractive = 2,
			[global::Cpp2ILInjected.Token(Token = "0x40004B7")]
			Shadowmask = 4
		}
	}
}
