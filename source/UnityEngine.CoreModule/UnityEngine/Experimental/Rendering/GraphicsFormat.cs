using System;
using System.ComponentModel;
using Cpp2ILInjected;

namespace UnityEngine.Experimental.Rendering
{
	[global::Cpp2ILInjected.Token(Token = "0x200013E")]
	public enum GraphicsFormat
	{
		[global::Cpp2ILInjected.Token(Token = "0x400057A")]
		None,
		[global::Cpp2ILInjected.Token(Token = "0x400057B")]
		R8_SRGB,
		[global::Cpp2ILInjected.Token(Token = "0x400057C")]
		R8G8_SRGB,
		[global::Cpp2ILInjected.Token(Token = "0x400057D")]
		R8G8B8_SRGB,
		[global::Cpp2ILInjected.Token(Token = "0x400057E")]
		R8G8B8A8_SRGB,
		[global::Cpp2ILInjected.Token(Token = "0x400057F")]
		R8_UNorm,
		[global::Cpp2ILInjected.Token(Token = "0x4000580")]
		R8G8_UNorm,
		[global::Cpp2ILInjected.Token(Token = "0x4000581")]
		R8G8B8_UNorm,
		[global::Cpp2ILInjected.Token(Token = "0x4000582")]
		R8G8B8A8_UNorm,
		[global::Cpp2ILInjected.Token(Token = "0x4000583")]
		R8_SNorm,
		[global::Cpp2ILInjected.Token(Token = "0x4000584")]
		R8G8_SNorm,
		[global::Cpp2ILInjected.Token(Token = "0x4000585")]
		R8G8B8_SNorm,
		[global::Cpp2ILInjected.Token(Token = "0x4000586")]
		R8G8B8A8_SNorm,
		[global::Cpp2ILInjected.Token(Token = "0x4000587")]
		R8_UInt,
		[global::Cpp2ILInjected.Token(Token = "0x4000588")]
		R8G8_UInt,
		[global::Cpp2ILInjected.Token(Token = "0x4000589")]
		R8G8B8_UInt,
		[global::Cpp2ILInjected.Token(Token = "0x400058A")]
		R8G8B8A8_UInt,
		[global::Cpp2ILInjected.Token(Token = "0x400058B")]
		R8_SInt,
		[global::Cpp2ILInjected.Token(Token = "0x400058C")]
		R8G8_SInt,
		[global::Cpp2ILInjected.Token(Token = "0x400058D")]
		R8G8B8_SInt,
		[global::Cpp2ILInjected.Token(Token = "0x400058E")]
		R8G8B8A8_SInt,
		[global::Cpp2ILInjected.Token(Token = "0x400058F")]
		R16_UNorm,
		[global::Cpp2ILInjected.Token(Token = "0x4000590")]
		R16G16_UNorm,
		[global::Cpp2ILInjected.Token(Token = "0x4000591")]
		R16G16B16_UNorm,
		[global::Cpp2ILInjected.Token(Token = "0x4000592")]
		R16G16B16A16_UNorm,
		[global::Cpp2ILInjected.Token(Token = "0x4000593")]
		R16_SNorm,
		[global::Cpp2ILInjected.Token(Token = "0x4000594")]
		R16G16_SNorm,
		[global::Cpp2ILInjected.Token(Token = "0x4000595")]
		R16G16B16_SNorm,
		[global::Cpp2ILInjected.Token(Token = "0x4000596")]
		R16G16B16A16_SNorm,
		[global::Cpp2ILInjected.Token(Token = "0x4000597")]
		R16_UInt,
		[global::Cpp2ILInjected.Token(Token = "0x4000598")]
		R16G16_UInt,
		[global::Cpp2ILInjected.Token(Token = "0x4000599")]
		R16G16B16_UInt,
		[global::Cpp2ILInjected.Token(Token = "0x400059A")]
		R16G16B16A16_UInt,
		[global::Cpp2ILInjected.Token(Token = "0x400059B")]
		R16_SInt,
		[global::Cpp2ILInjected.Token(Token = "0x400059C")]
		R16G16_SInt,
		[global::Cpp2ILInjected.Token(Token = "0x400059D")]
		R16G16B16_SInt,
		[global::Cpp2ILInjected.Token(Token = "0x400059E")]
		R16G16B16A16_SInt,
		[global::Cpp2ILInjected.Token(Token = "0x400059F")]
		R32_UInt,
		[global::Cpp2ILInjected.Token(Token = "0x40005A0")]
		R32G32_UInt,
		[global::Cpp2ILInjected.Token(Token = "0x40005A1")]
		R32G32B32_UInt,
		[global::Cpp2ILInjected.Token(Token = "0x40005A2")]
		R32G32B32A32_UInt,
		[global::Cpp2ILInjected.Token(Token = "0x40005A3")]
		R32_SInt,
		[global::Cpp2ILInjected.Token(Token = "0x40005A4")]
		R32G32_SInt,
		[global::Cpp2ILInjected.Token(Token = "0x40005A5")]
		R32G32B32_SInt,
		[global::Cpp2ILInjected.Token(Token = "0x40005A6")]
		R32G32B32A32_SInt,
		[global::Cpp2ILInjected.Token(Token = "0x40005A7")]
		R16_SFloat,
		[global::Cpp2ILInjected.Token(Token = "0x40005A8")]
		R16G16_SFloat,
		[global::Cpp2ILInjected.Token(Token = "0x40005A9")]
		R16G16B16_SFloat,
		[global::Cpp2ILInjected.Token(Token = "0x40005AA")]
		R16G16B16A16_SFloat,
		[global::Cpp2ILInjected.Token(Token = "0x40005AB")]
		R32_SFloat,
		[global::Cpp2ILInjected.Token(Token = "0x40005AC")]
		R32G32_SFloat,
		[global::Cpp2ILInjected.Token(Token = "0x40005AD")]
		R32G32B32_SFloat,
		[global::Cpp2ILInjected.Token(Token = "0x40005AE")]
		R32G32B32A32_SFloat,
		[global::Cpp2ILInjected.Token(Token = "0x40005AF")]
		B8G8R8_SRGB = 56,
		[global::Cpp2ILInjected.Token(Token = "0x40005B0")]
		B8G8R8A8_SRGB,
		[global::Cpp2ILInjected.Token(Token = "0x40005B1")]
		B8G8R8_UNorm,
		[global::Cpp2ILInjected.Token(Token = "0x40005B2")]
		B8G8R8A8_UNorm,
		[global::Cpp2ILInjected.Token(Token = "0x40005B3")]
		B8G8R8_SNorm,
		[global::Cpp2ILInjected.Token(Token = "0x40005B4")]
		B8G8R8A8_SNorm,
		[global::Cpp2ILInjected.Token(Token = "0x40005B5")]
		B8G8R8_UInt,
		[global::Cpp2ILInjected.Token(Token = "0x40005B6")]
		B8G8R8A8_UInt,
		[global::Cpp2ILInjected.Token(Token = "0x40005B7")]
		B8G8R8_SInt,
		[global::Cpp2ILInjected.Token(Token = "0x40005B8")]
		B8G8R8A8_SInt,
		[global::Cpp2ILInjected.Token(Token = "0x40005B9")]
		R4G4B4A4_UNormPack16,
		[global::Cpp2ILInjected.Token(Token = "0x40005BA")]
		B4G4R4A4_UNormPack16,
		[global::Cpp2ILInjected.Token(Token = "0x40005BB")]
		R5G6B5_UNormPack16,
		[global::Cpp2ILInjected.Token(Token = "0x40005BC")]
		B5G6R5_UNormPack16,
		[global::Cpp2ILInjected.Token(Token = "0x40005BD")]
		R5G5B5A1_UNormPack16,
		[global::Cpp2ILInjected.Token(Token = "0x40005BE")]
		B5G5R5A1_UNormPack16,
		[global::Cpp2ILInjected.Token(Token = "0x40005BF")]
		A1R5G5B5_UNormPack16,
		[global::Cpp2ILInjected.Token(Token = "0x40005C0")]
		E5B9G9R9_UFloatPack32,
		[global::Cpp2ILInjected.Token(Token = "0x40005C1")]
		B10G11R11_UFloatPack32,
		[global::Cpp2ILInjected.Token(Token = "0x40005C2")]
		A2B10G10R10_UNormPack32,
		[global::Cpp2ILInjected.Token(Token = "0x40005C3")]
		A2B10G10R10_UIntPack32,
		[global::Cpp2ILInjected.Token(Token = "0x40005C4")]
		A2B10G10R10_SIntPack32,
		[global::Cpp2ILInjected.Token(Token = "0x40005C5")]
		A2R10G10B10_UNormPack32,
		[global::Cpp2ILInjected.Token(Token = "0x40005C6")]
		A2R10G10B10_UIntPack32,
		[global::Cpp2ILInjected.Token(Token = "0x40005C7")]
		A2R10G10B10_SIntPack32,
		[global::Cpp2ILInjected.Token(Token = "0x40005C8")]
		A2R10G10B10_XRSRGBPack32,
		[global::Cpp2ILInjected.Token(Token = "0x40005C9")]
		A2R10G10B10_XRUNormPack32,
		[global::Cpp2ILInjected.Token(Token = "0x40005CA")]
		R10G10B10_XRSRGBPack32,
		[global::Cpp2ILInjected.Token(Token = "0x40005CB")]
		R10G10B10_XRUNormPack32,
		[global::Cpp2ILInjected.Token(Token = "0x40005CC")]
		A10R10G10B10_XRSRGBPack32,
		[global::Cpp2ILInjected.Token(Token = "0x40005CD")]
		A10R10G10B10_XRUNormPack32,
		[global::Cpp2ILInjected.Token(Token = "0x40005CE")]
		D16_UNorm = 90,
		[global::Cpp2ILInjected.Token(Token = "0x40005CF")]
		D24_UNorm,
		[global::Cpp2ILInjected.Token(Token = "0x40005D0")]
		D24_UNorm_S8_UInt,
		[global::Cpp2ILInjected.Token(Token = "0x40005D1")]
		D32_SFloat,
		[global::Cpp2ILInjected.Token(Token = "0x40005D2")]
		D32_SFloat_S8_UInt,
		[global::Cpp2ILInjected.Token(Token = "0x40005D3")]
		S8_UInt,
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Enum member GraphicsFormat.RGB_DXT1_SRGB has been deprecated. Use GraphicsFormat.RGBA_DXT1_SRGB instead (UnityUpgradable) -> RGBA_DXT1_SRGB", true)]
		[global::Cpp2ILInjected.Token(Token = "0x40005D4")]
		RGB_DXT1_SRGB,
		[global::Cpp2ILInjected.Token(Token = "0x40005D5")]
		RGBA_DXT1_SRGB = 96,
		[Obsolete("Enum member GraphicsFormat.RGB_DXT1_UNorm has been deprecated. Use GraphicsFormat.RGBA_DXT1_UNorm instead (UnityUpgradable) -> RGBA_DXT1_UNorm", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x40005D6")]
		RGB_DXT1_UNorm,
		[global::Cpp2ILInjected.Token(Token = "0x40005D7")]
		RGBA_DXT1_UNorm = 97,
		[global::Cpp2ILInjected.Token(Token = "0x40005D8")]
		RGBA_DXT3_SRGB,
		[global::Cpp2ILInjected.Token(Token = "0x40005D9")]
		RGBA_DXT3_UNorm,
		[global::Cpp2ILInjected.Token(Token = "0x40005DA")]
		RGBA_DXT5_SRGB,
		[global::Cpp2ILInjected.Token(Token = "0x40005DB")]
		RGBA_DXT5_UNorm,
		[global::Cpp2ILInjected.Token(Token = "0x40005DC")]
		R_BC4_UNorm,
		[global::Cpp2ILInjected.Token(Token = "0x40005DD")]
		R_BC4_SNorm,
		[global::Cpp2ILInjected.Token(Token = "0x40005DE")]
		RG_BC5_UNorm,
		[global::Cpp2ILInjected.Token(Token = "0x40005DF")]
		RG_BC5_SNorm,
		[global::Cpp2ILInjected.Token(Token = "0x40005E0")]
		RGB_BC6H_UFloat,
		[global::Cpp2ILInjected.Token(Token = "0x40005E1")]
		RGB_BC6H_SFloat,
		[global::Cpp2ILInjected.Token(Token = "0x40005E2")]
		RGBA_BC7_SRGB,
		[global::Cpp2ILInjected.Token(Token = "0x40005E3")]
		RGBA_BC7_UNorm,
		[global::Cpp2ILInjected.Token(Token = "0x40005E4")]
		RGB_PVRTC_2Bpp_SRGB,
		[global::Cpp2ILInjected.Token(Token = "0x40005E5")]
		RGB_PVRTC_2Bpp_UNorm,
		[global::Cpp2ILInjected.Token(Token = "0x40005E6")]
		RGB_PVRTC_4Bpp_SRGB,
		[global::Cpp2ILInjected.Token(Token = "0x40005E7")]
		RGB_PVRTC_4Bpp_UNorm,
		[global::Cpp2ILInjected.Token(Token = "0x40005E8")]
		RGBA_PVRTC_2Bpp_SRGB,
		[global::Cpp2ILInjected.Token(Token = "0x40005E9")]
		RGBA_PVRTC_2Bpp_UNorm,
		[global::Cpp2ILInjected.Token(Token = "0x40005EA")]
		RGBA_PVRTC_4Bpp_SRGB,
		[global::Cpp2ILInjected.Token(Token = "0x40005EB")]
		RGBA_PVRTC_4Bpp_UNorm,
		[global::Cpp2ILInjected.Token(Token = "0x40005EC")]
		RGB_ETC_UNorm,
		[global::Cpp2ILInjected.Token(Token = "0x40005ED")]
		RGB_ETC2_SRGB,
		[global::Cpp2ILInjected.Token(Token = "0x40005EE")]
		RGB_ETC2_UNorm,
		[global::Cpp2ILInjected.Token(Token = "0x40005EF")]
		RGB_A1_ETC2_SRGB,
		[global::Cpp2ILInjected.Token(Token = "0x40005F0")]
		RGB_A1_ETC2_UNorm,
		[global::Cpp2ILInjected.Token(Token = "0x40005F1")]
		RGBA_ETC2_SRGB,
		[global::Cpp2ILInjected.Token(Token = "0x40005F2")]
		RGBA_ETC2_UNorm,
		[global::Cpp2ILInjected.Token(Token = "0x40005F3")]
		R_EAC_UNorm,
		[global::Cpp2ILInjected.Token(Token = "0x40005F4")]
		R_EAC_SNorm,
		[global::Cpp2ILInjected.Token(Token = "0x40005F5")]
		RG_EAC_UNorm,
		[global::Cpp2ILInjected.Token(Token = "0x40005F6")]
		RG_EAC_SNorm,
		[global::Cpp2ILInjected.Token(Token = "0x40005F7")]
		RGBA_ASTC4X4_SRGB,
		[global::Cpp2ILInjected.Token(Token = "0x40005F8")]
		RGBA_ASTC4X4_UNorm,
		[global::Cpp2ILInjected.Token(Token = "0x40005F9")]
		RGBA_ASTC5X5_SRGB,
		[global::Cpp2ILInjected.Token(Token = "0x40005FA")]
		RGBA_ASTC5X5_UNorm,
		[global::Cpp2ILInjected.Token(Token = "0x40005FB")]
		RGBA_ASTC6X6_SRGB,
		[global::Cpp2ILInjected.Token(Token = "0x40005FC")]
		RGBA_ASTC6X6_UNorm,
		[global::Cpp2ILInjected.Token(Token = "0x40005FD")]
		RGBA_ASTC8X8_SRGB,
		[global::Cpp2ILInjected.Token(Token = "0x40005FE")]
		RGBA_ASTC8X8_UNorm,
		[global::Cpp2ILInjected.Token(Token = "0x40005FF")]
		RGBA_ASTC10X10_SRGB,
		[global::Cpp2ILInjected.Token(Token = "0x4000600")]
		RGBA_ASTC10X10_UNorm,
		[global::Cpp2ILInjected.Token(Token = "0x4000601")]
		RGBA_ASTC12X12_SRGB,
		[global::Cpp2ILInjected.Token(Token = "0x4000602")]
		RGBA_ASTC12X12_UNorm,
		[global::Cpp2ILInjected.Token(Token = "0x4000603")]
		YUV2,
		[Obsolete("Enum member GraphicsFormat.DepthAuto has been deprecated. Use GraphicsFormat.None as a color format to indicate depth only rendering and DefaultFormat to get the default depth buffer format.", false)]
		[global::Cpp2ILInjected.Token(Token = "0x4000604")]
		DepthAuto,
		[Obsolete("Enum member GraphicsFormat.ShadowAuto has been deprecated. Use GraphicsFormat.None as a color format to indicate depth only rendering and DefaultFormat to get the default shadow buffer format.", false)]
		[global::Cpp2ILInjected.Token(Token = "0x4000605")]
		ShadowAuto,
		[Obsolete("Enum member GraphicsFormat.VideoAuto has been deprecated. Use DefaultFormat instead.", false)]
		[global::Cpp2ILInjected.Token(Token = "0x4000606")]
		VideoAuto,
		[global::Cpp2ILInjected.Token(Token = "0x4000607")]
		RGBA_ASTC4X4_UFloat,
		[global::Cpp2ILInjected.Token(Token = "0x4000608")]
		RGBA_ASTC5X5_UFloat,
		[global::Cpp2ILInjected.Token(Token = "0x4000609")]
		RGBA_ASTC6X6_UFloat,
		[global::Cpp2ILInjected.Token(Token = "0x400060A")]
		RGBA_ASTC8X8_UFloat,
		[global::Cpp2ILInjected.Token(Token = "0x400060B")]
		RGBA_ASTC10X10_UFloat,
		[global::Cpp2ILInjected.Token(Token = "0x400060C")]
		RGBA_ASTC12X12_UFloat
	}
}
