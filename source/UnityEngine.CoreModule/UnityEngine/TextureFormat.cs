using System;
using System.ComponentModel;
using Cpp2ILInjected;

namespace UnityEngine
{
	[global::Cpp2ILInjected.Token(Token = "0x200006A")]
	public enum TextureFormat
	{
		[global::Cpp2ILInjected.Token(Token = "0x400025E")]
		Alpha8 = 1,
		[global::Cpp2ILInjected.Token(Token = "0x400025F")]
		ARGB4444,
		[global::Cpp2ILInjected.Token(Token = "0x4000260")]
		RGB24,
		[global::Cpp2ILInjected.Token(Token = "0x4000261")]
		RGBA32,
		[global::Cpp2ILInjected.Token(Token = "0x4000262")]
		ARGB32,
		[global::Cpp2ILInjected.Token(Token = "0x4000263")]
		RGB565 = 7,
		[global::Cpp2ILInjected.Token(Token = "0x4000264")]
		R16 = 9,
		[global::Cpp2ILInjected.Token(Token = "0x4000265")]
		DXT1,
		[global::Cpp2ILInjected.Token(Token = "0x4000266")]
		DXT5 = 12,
		[global::Cpp2ILInjected.Token(Token = "0x4000267")]
		RGBA4444,
		[global::Cpp2ILInjected.Token(Token = "0x4000268")]
		BGRA32,
		[global::Cpp2ILInjected.Token(Token = "0x4000269")]
		RHalf,
		[global::Cpp2ILInjected.Token(Token = "0x400026A")]
		RGHalf,
		[global::Cpp2ILInjected.Token(Token = "0x400026B")]
		RGBAHalf,
		[global::Cpp2ILInjected.Token(Token = "0x400026C")]
		RFloat,
		[global::Cpp2ILInjected.Token(Token = "0x400026D")]
		RGFloat,
		[global::Cpp2ILInjected.Token(Token = "0x400026E")]
		RGBAFloat,
		[global::Cpp2ILInjected.Token(Token = "0x400026F")]
		YUY2,
		[global::Cpp2ILInjected.Token(Token = "0x4000270")]
		RGB9e5Float,
		[global::Cpp2ILInjected.Token(Token = "0x4000271")]
		BC4 = 26,
		[global::Cpp2ILInjected.Token(Token = "0x4000272")]
		BC5,
		[global::Cpp2ILInjected.Token(Token = "0x4000273")]
		BC6H = 24,
		[global::Cpp2ILInjected.Token(Token = "0x4000274")]
		BC7,
		[global::Cpp2ILInjected.Token(Token = "0x4000275")]
		DXT1Crunched = 28,
		[global::Cpp2ILInjected.Token(Token = "0x4000276")]
		DXT5Crunched,
		[global::Cpp2ILInjected.Token(Token = "0x4000277")]
		PVRTC_RGB2,
		[global::Cpp2ILInjected.Token(Token = "0x4000278")]
		PVRTC_RGBA2,
		[global::Cpp2ILInjected.Token(Token = "0x4000279")]
		PVRTC_RGB4,
		[global::Cpp2ILInjected.Token(Token = "0x400027A")]
		PVRTC_RGBA4,
		[global::Cpp2ILInjected.Token(Token = "0x400027B")]
		ETC_RGB4,
		[global::Cpp2ILInjected.Token(Token = "0x400027C")]
		EAC_R = 41,
		[global::Cpp2ILInjected.Token(Token = "0x400027D")]
		EAC_R_SIGNED,
		[global::Cpp2ILInjected.Token(Token = "0x400027E")]
		EAC_RG,
		[global::Cpp2ILInjected.Token(Token = "0x400027F")]
		EAC_RG_SIGNED,
		[global::Cpp2ILInjected.Token(Token = "0x4000280")]
		ETC2_RGB,
		[global::Cpp2ILInjected.Token(Token = "0x4000281")]
		ETC2_RGBA1,
		[global::Cpp2ILInjected.Token(Token = "0x4000282")]
		ETC2_RGBA8,
		[global::Cpp2ILInjected.Token(Token = "0x4000283")]
		ASTC_4x4,
		[global::Cpp2ILInjected.Token(Token = "0x4000284")]
		ASTC_5x5,
		[global::Cpp2ILInjected.Token(Token = "0x4000285")]
		ASTC_6x6,
		[global::Cpp2ILInjected.Token(Token = "0x4000286")]
		ASTC_8x8,
		[global::Cpp2ILInjected.Token(Token = "0x4000287")]
		ASTC_10x10,
		[global::Cpp2ILInjected.Token(Token = "0x4000288")]
		ASTC_12x12,
		[Obsolete("Nintendo 3DS is no longer supported.")]
		[global::Cpp2ILInjected.Token(Token = "0x4000289")]
		ETC_RGB4_3DS = 60,
		[Obsolete("Nintendo 3DS is no longer supported.")]
		[global::Cpp2ILInjected.Token(Token = "0x400028A")]
		ETC_RGBA8_3DS,
		[global::Cpp2ILInjected.Token(Token = "0x400028B")]
		RG16,
		[global::Cpp2ILInjected.Token(Token = "0x400028C")]
		R8,
		[global::Cpp2ILInjected.Token(Token = "0x400028D")]
		ETC_RGB4Crunched,
		[global::Cpp2ILInjected.Token(Token = "0x400028E")]
		ETC2_RGBA8Crunched,
		[global::Cpp2ILInjected.Token(Token = "0x400028F")]
		ASTC_HDR_4x4,
		[global::Cpp2ILInjected.Token(Token = "0x4000290")]
		ASTC_HDR_5x5,
		[global::Cpp2ILInjected.Token(Token = "0x4000291")]
		ASTC_HDR_6x6,
		[global::Cpp2ILInjected.Token(Token = "0x4000292")]
		ASTC_HDR_8x8,
		[global::Cpp2ILInjected.Token(Token = "0x4000293")]
		ASTC_HDR_10x10,
		[global::Cpp2ILInjected.Token(Token = "0x4000294")]
		ASTC_HDR_12x12,
		[global::Cpp2ILInjected.Token(Token = "0x4000295")]
		RG32,
		[global::Cpp2ILInjected.Token(Token = "0x4000296")]
		RGB48,
		[global::Cpp2ILInjected.Token(Token = "0x4000297")]
		RGBA64,
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Enum member TextureFormat.ASTC_RGB_4x4 has been deprecated. Use ASTC_4x4 instead (UnityUpgradable) -> ASTC_4x4")]
		[global::Cpp2ILInjected.Token(Token = "0x4000298")]
		ASTC_RGB_4x4 = 48,
		[Obsolete("Enum member TextureFormat.ASTC_RGB_5x5 has been deprecated. Use ASTC_5x5 instead (UnityUpgradable) -> ASTC_5x5")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x4000299")]
		ASTC_RGB_5x5,
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Enum member TextureFormat.ASTC_RGB_6x6 has been deprecated. Use ASTC_6x6 instead (UnityUpgradable) -> ASTC_6x6")]
		[global::Cpp2ILInjected.Token(Token = "0x400029A")]
		ASTC_RGB_6x6,
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Enum member TextureFormat.ASTC_RGB_8x8 has been deprecated. Use ASTC_8x8 instead (UnityUpgradable) -> ASTC_8x8")]
		[global::Cpp2ILInjected.Token(Token = "0x400029B")]
		ASTC_RGB_8x8,
		[Obsolete("Enum member TextureFormat.ASTC_RGB_10x10 has been deprecated. Use ASTC_10x10 instead (UnityUpgradable) -> ASTC_10x10")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x400029C")]
		ASTC_RGB_10x10,
		[Obsolete("Enum member TextureFormat.ASTC_RGB_12x12 has been deprecated. Use ASTC_12x12 instead (UnityUpgradable) -> ASTC_12x12")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x400029D")]
		ASTC_RGB_12x12,
		[Obsolete("Enum member TextureFormat.ASTC_RGBA_4x4 has been deprecated. Use ASTC_4x4 instead (UnityUpgradable) -> ASTC_4x4")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x400029E")]
		ASTC_RGBA_4x4,
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Enum member TextureFormat.ASTC_RGBA_5x5 has been deprecated. Use ASTC_5x5 instead (UnityUpgradable) -> ASTC_5x5")]
		[global::Cpp2ILInjected.Token(Token = "0x400029F")]
		ASTC_RGBA_5x5,
		[Obsolete("Enum member TextureFormat.ASTC_RGBA_6x6 has been deprecated. Use ASTC_6x6 instead (UnityUpgradable) -> ASTC_6x6")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x40002A0")]
		ASTC_RGBA_6x6,
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Enum member TextureFormat.ASTC_RGBA_8x8 has been deprecated. Use ASTC_8x8 instead (UnityUpgradable) -> ASTC_8x8")]
		[global::Cpp2ILInjected.Token(Token = "0x40002A1")]
		ASTC_RGBA_8x8,
		[Obsolete("Enum member TextureFormat.ASTC_RGBA_10x10 has been deprecated. Use ASTC_10x10 instead (UnityUpgradable) -> ASTC_10x10")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x40002A2")]
		ASTC_RGBA_10x10,
		[Obsolete("Enum member TextureFormat.ASTC_RGBA_12x12 has been deprecated. Use ASTC_12x12 instead (UnityUpgradable) -> ASTC_12x12")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x40002A3")]
		ASTC_RGBA_12x12
	}
}
