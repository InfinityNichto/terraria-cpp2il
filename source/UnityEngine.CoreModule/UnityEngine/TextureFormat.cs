using System;
using System.ComponentModel;
using Cpp2ILInjected;

namespace UnityEngine
{
	// Token: 0x02000065 RID: 101
	[global::Cpp2ILInjected.Token(Token = "0x200006A")]
	public enum TextureFormat
	{
		// Token: 0x04000257 RID: 599
		[global::Cpp2ILInjected.Token(Token = "0x400025E")]
		Alpha8 = 1,
		// Token: 0x04000258 RID: 600
		[global::Cpp2ILInjected.Token(Token = "0x400025F")]
		ARGB4444,
		// Token: 0x04000259 RID: 601
		[global::Cpp2ILInjected.Token(Token = "0x4000260")]
		RGB24,
		// Token: 0x0400025A RID: 602
		[global::Cpp2ILInjected.Token(Token = "0x4000261")]
		RGBA32,
		// Token: 0x0400025B RID: 603
		[global::Cpp2ILInjected.Token(Token = "0x4000262")]
		ARGB32,
		// Token: 0x0400025C RID: 604
		[global::Cpp2ILInjected.Token(Token = "0x4000263")]
		RGB565 = 7,
		// Token: 0x0400025D RID: 605
		[global::Cpp2ILInjected.Token(Token = "0x4000264")]
		R16 = 9,
		// Token: 0x0400025E RID: 606
		[global::Cpp2ILInjected.Token(Token = "0x4000265")]
		DXT1,
		// Token: 0x0400025F RID: 607
		[global::Cpp2ILInjected.Token(Token = "0x4000266")]
		DXT5 = 12,
		// Token: 0x04000260 RID: 608
		[global::Cpp2ILInjected.Token(Token = "0x4000267")]
		RGBA4444,
		// Token: 0x04000261 RID: 609
		[global::Cpp2ILInjected.Token(Token = "0x4000268")]
		BGRA32,
		// Token: 0x04000262 RID: 610
		[global::Cpp2ILInjected.Token(Token = "0x4000269")]
		RHalf,
		// Token: 0x04000263 RID: 611
		[global::Cpp2ILInjected.Token(Token = "0x400026A")]
		RGHalf,
		// Token: 0x04000264 RID: 612
		[global::Cpp2ILInjected.Token(Token = "0x400026B")]
		RGBAHalf,
		// Token: 0x04000265 RID: 613
		[global::Cpp2ILInjected.Token(Token = "0x400026C")]
		RFloat,
		// Token: 0x04000266 RID: 614
		[global::Cpp2ILInjected.Token(Token = "0x400026D")]
		RGFloat,
		// Token: 0x04000267 RID: 615
		[global::Cpp2ILInjected.Token(Token = "0x400026E")]
		RGBAFloat,
		// Token: 0x04000268 RID: 616
		[global::Cpp2ILInjected.Token(Token = "0x400026F")]
		YUY2,
		// Token: 0x04000269 RID: 617
		[global::Cpp2ILInjected.Token(Token = "0x4000270")]
		RGB9e5Float,
		// Token: 0x0400026A RID: 618
		[global::Cpp2ILInjected.Token(Token = "0x4000271")]
		BC4 = 26,
		// Token: 0x0400026B RID: 619
		[global::Cpp2ILInjected.Token(Token = "0x4000272")]
		BC5,
		// Token: 0x0400026C RID: 620
		[global::Cpp2ILInjected.Token(Token = "0x4000273")]
		BC6H = 24,
		// Token: 0x0400026D RID: 621
		[global::Cpp2ILInjected.Token(Token = "0x4000274")]
		BC7,
		// Token: 0x0400026E RID: 622
		[global::Cpp2ILInjected.Token(Token = "0x4000275")]
		DXT1Crunched = 28,
		// Token: 0x0400026F RID: 623
		[global::Cpp2ILInjected.Token(Token = "0x4000276")]
		DXT5Crunched,
		// Token: 0x04000270 RID: 624
		[global::Cpp2ILInjected.Token(Token = "0x4000277")]
		PVRTC_RGB2,
		// Token: 0x04000271 RID: 625
		[global::Cpp2ILInjected.Token(Token = "0x4000278")]
		PVRTC_RGBA2,
		// Token: 0x04000272 RID: 626
		[global::Cpp2ILInjected.Token(Token = "0x4000279")]
		PVRTC_RGB4,
		// Token: 0x04000273 RID: 627
		[global::Cpp2ILInjected.Token(Token = "0x400027A")]
		PVRTC_RGBA4,
		// Token: 0x04000274 RID: 628
		[global::Cpp2ILInjected.Token(Token = "0x400027B")]
		ETC_RGB4,
		// Token: 0x04000275 RID: 629
		[global::Cpp2ILInjected.Token(Token = "0x400027C")]
		EAC_R = 41,
		// Token: 0x04000276 RID: 630
		[global::Cpp2ILInjected.Token(Token = "0x400027D")]
		EAC_R_SIGNED,
		// Token: 0x04000277 RID: 631
		[global::Cpp2ILInjected.Token(Token = "0x400027E")]
		EAC_RG,
		// Token: 0x04000278 RID: 632
		[global::Cpp2ILInjected.Token(Token = "0x400027F")]
		EAC_RG_SIGNED,
		// Token: 0x04000279 RID: 633
		[global::Cpp2ILInjected.Token(Token = "0x4000280")]
		ETC2_RGB,
		// Token: 0x0400027A RID: 634
		[global::Cpp2ILInjected.Token(Token = "0x4000281")]
		ETC2_RGBA1,
		// Token: 0x0400027B RID: 635
		[global::Cpp2ILInjected.Token(Token = "0x4000282")]
		ETC2_RGBA8,
		// Token: 0x0400027C RID: 636
		[global::Cpp2ILInjected.Token(Token = "0x4000283")]
		ASTC_4x4,
		// Token: 0x0400027D RID: 637
		[global::Cpp2ILInjected.Token(Token = "0x4000284")]
		ASTC_5x5,
		// Token: 0x0400027E RID: 638
		[global::Cpp2ILInjected.Token(Token = "0x4000285")]
		ASTC_6x6,
		// Token: 0x0400027F RID: 639
		[global::Cpp2ILInjected.Token(Token = "0x4000286")]
		ASTC_8x8,
		// Token: 0x04000280 RID: 640
		[global::Cpp2ILInjected.Token(Token = "0x4000287")]
		ASTC_10x10,
		// Token: 0x04000281 RID: 641
		[global::Cpp2ILInjected.Token(Token = "0x4000288")]
		ASTC_12x12,
		// Token: 0x04000282 RID: 642
		[Obsolete("Nintendo 3DS is no longer supported.")]
		[global::Cpp2ILInjected.Token(Token = "0x4000289")]
		ETC_RGB4_3DS = 60,
		// Token: 0x04000283 RID: 643
		[Obsolete("Nintendo 3DS is no longer supported.")]
		[global::Cpp2ILInjected.Token(Token = "0x400028A")]
		ETC_RGBA8_3DS,
		// Token: 0x04000284 RID: 644
		[global::Cpp2ILInjected.Token(Token = "0x400028B")]
		RG16,
		// Token: 0x04000285 RID: 645
		[global::Cpp2ILInjected.Token(Token = "0x400028C")]
		R8,
		// Token: 0x04000286 RID: 646
		[global::Cpp2ILInjected.Token(Token = "0x400028D")]
		ETC_RGB4Crunched,
		// Token: 0x04000287 RID: 647
		[global::Cpp2ILInjected.Token(Token = "0x400028E")]
		ETC2_RGBA8Crunched,
		// Token: 0x04000288 RID: 648
		[global::Cpp2ILInjected.Token(Token = "0x400028F")]
		ASTC_HDR_4x4,
		// Token: 0x04000289 RID: 649
		[global::Cpp2ILInjected.Token(Token = "0x4000290")]
		ASTC_HDR_5x5,
		// Token: 0x0400028A RID: 650
		[global::Cpp2ILInjected.Token(Token = "0x4000291")]
		ASTC_HDR_6x6,
		// Token: 0x0400028B RID: 651
		[global::Cpp2ILInjected.Token(Token = "0x4000292")]
		ASTC_HDR_8x8,
		// Token: 0x0400028C RID: 652
		[global::Cpp2ILInjected.Token(Token = "0x4000293")]
		ASTC_HDR_10x10,
		// Token: 0x0400028D RID: 653
		[global::Cpp2ILInjected.Token(Token = "0x4000294")]
		ASTC_HDR_12x12,
		// Token: 0x0400028E RID: 654
		[global::Cpp2ILInjected.Token(Token = "0x4000295")]
		RG32,
		// Token: 0x0400028F RID: 655
		[global::Cpp2ILInjected.Token(Token = "0x4000296")]
		RGB48,
		// Token: 0x04000290 RID: 656
		[global::Cpp2ILInjected.Token(Token = "0x4000297")]
		RGBA64,
		// Token: 0x04000291 RID: 657
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Enum member TextureFormat.ASTC_RGB_4x4 has been deprecated. Use ASTC_4x4 instead (UnityUpgradable) -> ASTC_4x4")]
		[global::Cpp2ILInjected.Token(Token = "0x4000298")]
		ASTC_RGB_4x4 = 48,
		// Token: 0x04000292 RID: 658
		[Obsolete("Enum member TextureFormat.ASTC_RGB_5x5 has been deprecated. Use ASTC_5x5 instead (UnityUpgradable) -> ASTC_5x5")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x4000299")]
		ASTC_RGB_5x5,
		// Token: 0x04000293 RID: 659
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Enum member TextureFormat.ASTC_RGB_6x6 has been deprecated. Use ASTC_6x6 instead (UnityUpgradable) -> ASTC_6x6")]
		[global::Cpp2ILInjected.Token(Token = "0x400029A")]
		ASTC_RGB_6x6,
		// Token: 0x04000294 RID: 660
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Enum member TextureFormat.ASTC_RGB_8x8 has been deprecated. Use ASTC_8x8 instead (UnityUpgradable) -> ASTC_8x8")]
		[global::Cpp2ILInjected.Token(Token = "0x400029B")]
		ASTC_RGB_8x8,
		// Token: 0x04000295 RID: 661
		[Obsolete("Enum member TextureFormat.ASTC_RGB_10x10 has been deprecated. Use ASTC_10x10 instead (UnityUpgradable) -> ASTC_10x10")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x400029C")]
		ASTC_RGB_10x10,
		// Token: 0x04000296 RID: 662
		[Obsolete("Enum member TextureFormat.ASTC_RGB_12x12 has been deprecated. Use ASTC_12x12 instead (UnityUpgradable) -> ASTC_12x12")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x400029D")]
		ASTC_RGB_12x12,
		// Token: 0x04000297 RID: 663
		[Obsolete("Enum member TextureFormat.ASTC_RGBA_4x4 has been deprecated. Use ASTC_4x4 instead (UnityUpgradable) -> ASTC_4x4")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x400029E")]
		ASTC_RGBA_4x4,
		// Token: 0x04000298 RID: 664
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Enum member TextureFormat.ASTC_RGBA_5x5 has been deprecated. Use ASTC_5x5 instead (UnityUpgradable) -> ASTC_5x5")]
		[global::Cpp2ILInjected.Token(Token = "0x400029F")]
		ASTC_RGBA_5x5,
		// Token: 0x04000299 RID: 665
		[Obsolete("Enum member TextureFormat.ASTC_RGBA_6x6 has been deprecated. Use ASTC_6x6 instead (UnityUpgradable) -> ASTC_6x6")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x40002A0")]
		ASTC_RGBA_6x6,
		// Token: 0x0400029A RID: 666
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Enum member TextureFormat.ASTC_RGBA_8x8 has been deprecated. Use ASTC_8x8 instead (UnityUpgradable) -> ASTC_8x8")]
		[global::Cpp2ILInjected.Token(Token = "0x40002A1")]
		ASTC_RGBA_8x8,
		// Token: 0x0400029B RID: 667
		[Obsolete("Enum member TextureFormat.ASTC_RGBA_10x10 has been deprecated. Use ASTC_10x10 instead (UnityUpgradable) -> ASTC_10x10")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x40002A2")]
		ASTC_RGBA_10x10,
		// Token: 0x0400029C RID: 668
		[Obsolete("Enum member TextureFormat.ASTC_RGBA_12x12 has been deprecated. Use ASTC_12x12 instead (UnityUpgradable) -> ASTC_12x12")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x40002A3")]
		ASTC_RGBA_12x12
	}
}
