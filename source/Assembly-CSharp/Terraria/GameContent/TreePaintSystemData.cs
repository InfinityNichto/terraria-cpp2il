using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent
{
	// Token: 0x02000555 RID: 1365
	[global::Cpp2ILInjected.Token(Token = "0x20007D2")]
	public class TreePaintSystemData
	{
		// Token: 0x060039E0 RID: 14816 RVA: 0x0002C561 File Offset: 0x0002A761
		[global::Cpp2ILInjected.Token(Token = "0x60040B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x772E9C", Offset = "0x772E9C", Length = "0x248")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TilePaintSystemV2), Member = "GetTileEffect", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(EffectPass))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public TreePaintingSettings GetTileSettings(int tileType, int tileStyle)
		{
			throw null;
		}

		// Token: 0x060039E1 RID: 14817 RVA: 0x0002C564 File Offset: 0x0002A764
		[global::Cpp2ILInjected.Token(Token = "0x60040B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x7730E4", Offset = "0x7730E4", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TilePaintSystemV2), Member = "GetTreeBranchEffect", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(EffectPass))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TilePaintSystemV2), Member = "GetTreeTopEffect", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(EffectPass))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public TreePaintingSettings GetTreeFoliageSettings(int foliageIndex, int foliageStyle)
		{
			throw null;
		}

		// Token: 0x060039E2 RID: 14818 RVA: 0x0002C567 File Offset: 0x0002A767
		[global::Cpp2ILInjected.Token(Token = "0x60040B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x7731D8", Offset = "0x7731D8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public TreePaintingSettings GetWallSettings(int wallType)
		{
			throw null;
		}

		// Token: 0x060039E3 RID: 14819 RVA: 0x0002C56A File Offset: 0x0002A76A
		[global::Cpp2ILInjected.Token(Token = "0x60040B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x7731E0", Offset = "0x7731E0", Length = "0x4F8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TilePaintSystemV2), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 26)]
		public TreePaintSystemData()
		{
			throw null;
		}

		// Token: 0x060039E4 RID: 14820 RVA: 0x0002C56D File Offset: 0x0002A76D
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60040BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x7736D8", Offset = "0x7736D8", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static TreePaintSystemData()
		{
			throw null;
		}

		// Token: 0x04006904 RID: 26884
		[global::Cpp2ILInjected.Token(Token = "0x4007E7D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public TreePaintingSettings DefaultNoSpecialGroups;

		// Token: 0x04006905 RID: 26885
		[global::Cpp2ILInjected.Token(Token = "0x4007E7E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public TreePaintingSettings DefaultNoSpecialGroups_ForWalls;

		// Token: 0x04006906 RID: 26886
		[global::Cpp2ILInjected.Token(Token = "0x4007E7F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public TreePaintingSettings DefaultDirt;

		// Token: 0x04006907 RID: 26887
		[global::Cpp2ILInjected.Token(Token = "0x4007E80")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public TreePaintingSettings CullMud;

		// Token: 0x04006908 RID: 26888
		[global::Cpp2ILInjected.Token(Token = "0x4007E81")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public TreePaintingSettings WoodPurity;

		// Token: 0x04006909 RID: 26889
		[global::Cpp2ILInjected.Token(Token = "0x4007E82")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public TreePaintingSettings WoodCorruption;

		// Token: 0x0400690A RID: 26890
		[global::Cpp2ILInjected.Token(Token = "0x4007E83")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		public TreePaintingSettings WoodJungle;

		// Token: 0x0400690B RID: 26891
		[global::Cpp2ILInjected.Token(Token = "0x4007E84")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		public TreePaintingSettings WoodHallow;

		// Token: 0x0400690C RID: 26892
		[global::Cpp2ILInjected.Token(Token = "0x4007E85")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		public TreePaintingSettings WoodSnow;

		// Token: 0x0400690D RID: 26893
		[global::Cpp2ILInjected.Token(Token = "0x4007E86")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		public TreePaintingSettings WoodCrimson;

		// Token: 0x0400690E RID: 26894
		[global::Cpp2ILInjected.Token(Token = "0x4007E87")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		public TreePaintingSettings WoodJungleUnderground;

		// Token: 0x0400690F RID: 26895
		[global::Cpp2ILInjected.Token(Token = "0x4007E88")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		public TreePaintingSettings WoodGlowingMushroom;

		// Token: 0x04006910 RID: 26896
		[global::Cpp2ILInjected.Token(Token = "0x4007E89")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		public TreePaintingSettings VanityCherry;

		// Token: 0x04006911 RID: 26897
		[global::Cpp2ILInjected.Token(Token = "0x4007E8A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		public TreePaintingSettings VanityYellowWillow;

		// Token: 0x04006912 RID: 26898
		[global::Cpp2ILInjected.Token(Token = "0x4007E8B")]
		private static TreePaintingSettings TreeAsh;

		// Token: 0x04006913 RID: 26899
		[global::Cpp2ILInjected.Token(Token = "0x4007E8C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		public TreePaintingSettings GemTreeRuby;

		// Token: 0x04006914 RID: 26900
		[global::Cpp2ILInjected.Token(Token = "0x4007E8D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private TreePaintingSettings GemTreeAmber;

		// Token: 0x04006915 RID: 26901
		[global::Cpp2ILInjected.Token(Token = "0x4007E8E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private TreePaintingSettings GemTreeSapphire;

		// Token: 0x04006916 RID: 26902
		[global::Cpp2ILInjected.Token(Token = "0x4007E8F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private TreePaintingSettings GemTreeEmerald;

		// Token: 0x04006917 RID: 26903
		[global::Cpp2ILInjected.Token(Token = "0x4007E90")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		private TreePaintingSettings GemTreeAmethyst;

		// Token: 0x04006918 RID: 26904
		[global::Cpp2ILInjected.Token(Token = "0x4007E91")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		private TreePaintingSettings GemTreeTopaz;

		// Token: 0x04006919 RID: 26905
		[global::Cpp2ILInjected.Token(Token = "0x4007E92")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		private TreePaintingSettings GemTreeDiamond;

		// Token: 0x0400691A RID: 26906
		[global::Cpp2ILInjected.Token(Token = "0x4007E93")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		public TreePaintingSettings PalmTreePurity;

		// Token: 0x0400691B RID: 26907
		[global::Cpp2ILInjected.Token(Token = "0x4007E94")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
		public TreePaintingSettings PalmTreeCorruption;

		// Token: 0x0400691C RID: 26908
		[global::Cpp2ILInjected.Token(Token = "0x4007E95")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
		public TreePaintingSettings PalmTreeCrimson;

		// Token: 0x0400691D RID: 26909
		[global::Cpp2ILInjected.Token(Token = "0x4007E96")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
		public TreePaintingSettings PalmTreeHallow;
	}
}
