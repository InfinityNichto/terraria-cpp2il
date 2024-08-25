using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent
{
	[global::Cpp2ILInjected.Token(Token = "0x20007D2")]
	public class TreePaintSystemData
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x60040B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x7731D8", Offset = "0x7731D8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public TreePaintingSettings GetWallSettings(int wallType)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x4007E7D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public TreePaintingSettings DefaultNoSpecialGroups;

		[global::Cpp2ILInjected.Token(Token = "0x4007E7E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public TreePaintingSettings DefaultNoSpecialGroups_ForWalls;

		[global::Cpp2ILInjected.Token(Token = "0x4007E7F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public TreePaintingSettings DefaultDirt;

		[global::Cpp2ILInjected.Token(Token = "0x4007E80")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public TreePaintingSettings CullMud;

		[global::Cpp2ILInjected.Token(Token = "0x4007E81")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public TreePaintingSettings WoodPurity;

		[global::Cpp2ILInjected.Token(Token = "0x4007E82")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public TreePaintingSettings WoodCorruption;

		[global::Cpp2ILInjected.Token(Token = "0x4007E83")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		public TreePaintingSettings WoodJungle;

		[global::Cpp2ILInjected.Token(Token = "0x4007E84")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		public TreePaintingSettings WoodHallow;

		[global::Cpp2ILInjected.Token(Token = "0x4007E85")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		public TreePaintingSettings WoodSnow;

		[global::Cpp2ILInjected.Token(Token = "0x4007E86")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		public TreePaintingSettings WoodCrimson;

		[global::Cpp2ILInjected.Token(Token = "0x4007E87")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		public TreePaintingSettings WoodJungleUnderground;

		[global::Cpp2ILInjected.Token(Token = "0x4007E88")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		public TreePaintingSettings WoodGlowingMushroom;

		[global::Cpp2ILInjected.Token(Token = "0x4007E89")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		public TreePaintingSettings VanityCherry;

		[global::Cpp2ILInjected.Token(Token = "0x4007E8A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		public TreePaintingSettings VanityYellowWillow;

		[global::Cpp2ILInjected.Token(Token = "0x4007E8B")]
		private static TreePaintingSettings TreeAsh;

		[global::Cpp2ILInjected.Token(Token = "0x4007E8C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		public TreePaintingSettings GemTreeRuby;

		[global::Cpp2ILInjected.Token(Token = "0x4007E8D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private TreePaintingSettings GemTreeAmber;

		[global::Cpp2ILInjected.Token(Token = "0x4007E8E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private TreePaintingSettings GemTreeSapphire;

		[global::Cpp2ILInjected.Token(Token = "0x4007E8F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private TreePaintingSettings GemTreeEmerald;

		[global::Cpp2ILInjected.Token(Token = "0x4007E90")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		private TreePaintingSettings GemTreeAmethyst;

		[global::Cpp2ILInjected.Token(Token = "0x4007E91")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		private TreePaintingSettings GemTreeTopaz;

		[global::Cpp2ILInjected.Token(Token = "0x4007E92")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		private TreePaintingSettings GemTreeDiamond;

		[global::Cpp2ILInjected.Token(Token = "0x4007E93")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		public TreePaintingSettings PalmTreePurity;

		[global::Cpp2ILInjected.Token(Token = "0x4007E94")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
		public TreePaintingSettings PalmTreeCorruption;

		[global::Cpp2ILInjected.Token(Token = "0x4007E95")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
		public TreePaintingSettings PalmTreeCrimson;

		[global::Cpp2ILInjected.Token(Token = "0x4007E96")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
		public TreePaintingSettings PalmTreeHallow;
	}
}
