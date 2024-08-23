using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.GameContent
{
	// Token: 0x02000554 RID: 1364
	[global::Cpp2ILInjected.Token(Token = "0x20007D0")]
	public class TreePaintingSettings
	{
		// Token: 0x060039DF RID: 14815 RVA: 0x0002C55E File Offset: 0x0002A75E
		[global::Cpp2ILInjected.Token(Token = "0x60040B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x772E94", Offset = "0x772E94", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public TreePaintingSettings()
		{
			throw null;
		}

		// Token: 0x040068FB RID: 26875
		[global::Cpp2ILInjected.Token(Token = "0x4007E60")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public TreePaintingSettings.TreePaintingSettingsId Id;

		// Token: 0x040068FC RID: 26876
		[global::Cpp2ILInjected.Token(Token = "0x4007E61")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public float SpecialGroupMinimalHueValue;

		// Token: 0x040068FD RID: 26877
		[global::Cpp2ILInjected.Token(Token = "0x4007E62")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public float SpecialGroupMaximumHueValue;

		// Token: 0x040068FE RID: 26878
		[global::Cpp2ILInjected.Token(Token = "0x4007E63")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public float SpecialGroupMinimumSaturationValue;

		// Token: 0x040068FF RID: 26879
		[global::Cpp2ILInjected.Token(Token = "0x4007E64")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public float SpecialGroupMaximumSaturationValue;

		// Token: 0x04006900 RID: 26880
		[global::Cpp2ILInjected.Token(Token = "0x4007E65")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		public float HueTestOffset;

		// Token: 0x04006901 RID: 26881
		[global::Cpp2ILInjected.Token(Token = "0x4007E66")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public bool UseSpecialGroups;

		// Token: 0x04006902 RID: 26882
		[global::Cpp2ILInjected.Token(Token = "0x4007E67")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x29")]
		public bool UseWallShaderHacks;

		// Token: 0x04006903 RID: 26883
		[global::Cpp2ILInjected.Token(Token = "0x4007E68")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2A")]
		public bool InvertSpecialGroupResult;

		// Token: 0x02000987 RID: 2439
		[global::Cpp2ILInjected.Token(Token = "0x20007D1")]
		public enum TreePaintingSettingsId
		{
			// Token: 0x04008C1B RID: 35867
			[global::Cpp2ILInjected.Token(Token = "0x4007E6A")]
			None,
			// Token: 0x04008C1C RID: 35868
			[global::Cpp2ILInjected.Token(Token = "0x4007E6B")]
			DefaultDirt,
			// Token: 0x04008C1D RID: 35869
			[global::Cpp2ILInjected.Token(Token = "0x4007E6C")]
			CullMud,
			// Token: 0x04008C1E RID: 35870
			[global::Cpp2ILInjected.Token(Token = "0x4007E6D")]
			WoodPurity,
			// Token: 0x04008C1F RID: 35871
			[global::Cpp2ILInjected.Token(Token = "0x4007E6E")]
			WoodCorruption,
			// Token: 0x04008C20 RID: 35872
			[global::Cpp2ILInjected.Token(Token = "0x4007E6F")]
			WoodJungle,
			// Token: 0x04008C21 RID: 35873
			[global::Cpp2ILInjected.Token(Token = "0x4007E70")]
			WoodHallow,
			// Token: 0x04008C22 RID: 35874
			[global::Cpp2ILInjected.Token(Token = "0x4007E71")]
			WoodSnow,
			// Token: 0x04008C23 RID: 35875
			[global::Cpp2ILInjected.Token(Token = "0x4007E72")]
			WoodCrimson,
			// Token: 0x04008C24 RID: 35876
			[global::Cpp2ILInjected.Token(Token = "0x4007E73")]
			WoodJungleUnderground,
			// Token: 0x04008C25 RID: 35877
			[global::Cpp2ILInjected.Token(Token = "0x4007E74")]
			WoodGlowingMushroom,
			// Token: 0x04008C26 RID: 35878
			[global::Cpp2ILInjected.Token(Token = "0x4007E75")]
			VanityCherry,
			// Token: 0x04008C27 RID: 35879
			[global::Cpp2ILInjected.Token(Token = "0x4007E76")]
			VanityYellowWillow,
			// Token: 0x04008C28 RID: 35880
			[global::Cpp2ILInjected.Token(Token = "0x4007E77")]
			GemTree,
			// Token: 0x04008C29 RID: 35881
			[global::Cpp2ILInjected.Token(Token = "0x4007E78")]
			PalmTreePurity,
			// Token: 0x04008C2A RID: 35882
			[global::Cpp2ILInjected.Token(Token = "0x4007E79")]
			PalmTreeCorruption,
			// Token: 0x04008C2B RID: 35883
			[global::Cpp2ILInjected.Token(Token = "0x4007E7A")]
			PalmTreeCrimson,
			// Token: 0x04008C2C RID: 35884
			[global::Cpp2ILInjected.Token(Token = "0x4007E7B")]
			PalmTreeHallow,
			// Token: 0x04008C2D RID: 35885
			[global::Cpp2ILInjected.Token(Token = "0x4007E7C")]
			Count
		}
	}
}
