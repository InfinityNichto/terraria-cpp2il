using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;
using Terraria.GameContent.Drawing;

namespace Terraria.GameContent
{
	[global::Cpp2ILInjected.Token(Token = "0x20007D3")]
	public class TilePaintSystemV2
	{
		[global::Cpp2ILInjected.Token(Token = "0x60040BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x773760", Offset = "0x773760", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTiles", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "GetTileDrawTexture", MemberParameters = new object[]
		{
			typeof(TileDrawInfo),
			typeof(int),
			typeof(ref EffectPass)
		}, ReturnType = typeof(Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "GetTileDrawTexture", MemberParameters = new object[]
		{
			typeof(TileDrawInfo),
			typeof(int),
			typeof(int),
			typeof(ref EffectPass)
		}, ReturnType = typeof(Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "GetTileDrawTexture", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ushort),
			typeof(short),
			typeof(short),
			typeof(byte),
			typeof(ref EffectPass)
		}, ReturnType = typeof(Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "GetTileDrawTexture", MemberParameters = new object[]
		{
			typeof(Tile),
			typeof(int),
			typeof(int),
			typeof(ref EffectPass)
		}, ReturnType = typeof(Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "GetTileDrawTexture", MemberParameters = new object[]
		{
			typeof(Tile),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(ref EffectPass)
		}, ReturnType = typeof(Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TreePaintSystemData), Member = "GetTileSettings", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(TreePaintingSettings))]
		public EffectPass GetTileEffect(int tileType, int tileStyle, int paintColor)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60040BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x7737B0", Offset = "0x7737B0", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WallDrawing), Member = "DrawWalls", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public EffectPass GetWallEffect(int wallType, int paintColor)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60040BD")]
		[global::Cpp2ILInjected.Address(RVA = "0x7738A8", Offset = "0x7738A8", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "GetTreeBranchTexture", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(byte),
			typeof(ref EffectPass)
		}, ReturnType = typeof(Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TreePaintSystemData), Member = "GetTreeFoliageSettings", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(TreePaintingSettings))]
		public EffectPass GetTreeBranchEffect(int treeTopIndex, int treeTopStyle, int paintColor)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60040BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x7738E0", Offset = "0x7738E0", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "GetTreeTopTexture", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(byte),
			typeof(ref EffectPass)
		}, ReturnType = typeof(Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TreePaintSystemData), Member = "GetTreeFoliageSettings", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(TreePaintingSettings))]
		public EffectPass GetTreeTopEffect(int treeTopIndex, int treeTopStyle, int paintColor)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60040BF")]
		[global::Cpp2ILInjected.Address(RVA = "0x773918", Offset = "0x773918", Length = "0x228")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TilePaintSystemV2), Member = "CreateTileShaders", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TilePaintSystemV2), Member = "GetRealShader", MemberParameters = new object[]
		{
			typeof(int),
			typeof(TreePaintingSettings)
		}, ReturnType = typeof(EffectPass))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 19)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileShader), Member = "CreateNew", ReturnType = typeof(TileShader))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectParameterCollection), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(EffectParameter))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectParameter), Member = "SetValue", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectParameter), Member = "SetValue", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TilePaintSystemV2), Member = "GetRealShader", MemberParameters = new object[]
		{
			typeof(int),
			typeof(TreePaintingSettings)
		}, ReturnType = typeof(EffectPass))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private Effect InitShader(TreePaintingSettings settings)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60040C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x773B40", Offset = "0x773B40", Length = "0x180")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "Initialize_AlmostEverything", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_tileShader", ReturnType = typeof(Effect))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TilePaintSystemV2), Member = "InitShader", MemberParameters = new object[] { typeof(TreePaintingSettings) }, ReturnType = typeof(Effect))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void CreateTileShaders()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60040C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x7737C4", Offset = "0x7737C4", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TilePaintSystemV2), Member = "InitShader", MemberParameters = new object[] { typeof(TreePaintingSettings) }, ReturnType = typeof(Effect))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "ConvertPaintIdToTileShaderIndex", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TilePaintSystemV2), Member = "InitShader", MemberParameters = new object[] { typeof(TreePaintingSettings) }, ReturnType = typeof(Effect))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectPassCollection), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(EffectPass))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public EffectPass GetRealShader(int paintColor, TreePaintingSettings settings)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60040C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x773798", Offset = "0x773798", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public EffectPass GetShader(int paintColor, TreePaintingSettings settings)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60040C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x773CC0", Offset = "0x773CC0", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "Initialize_AlmostEverything", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TreePaintSystemData), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public TilePaintSystemV2()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4007E97")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private Effect TileShader;

		[global::Cpp2ILInjected.Token(Token = "0x4007E98")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private TreePaintSystemData PaintSystemData;

		[global::Cpp2ILInjected.Token(Token = "0x4007E99")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private TileShader[] specialShaders;

		[global::Cpp2ILInjected.Token(Token = "0x4007E9A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private EffectPass[] TileShaders;

		[global::Cpp2ILInjected.Token(Token = "0x20007D4")]
		public struct TileVariationkey
		{
			[global::Cpp2ILInjected.Token(Token = "0x60040C4")]
			[global::Cpp2ILInjected.Address(RVA = "0x773D6C", Offset = "0x773D6C", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool Equals(TilePaintSystemV2.TileVariationkey other)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60040C5")]
			[global::Cpp2ILInjected.Address(RVA = "0x773DA0", Offset = "0x773DA0", Length = "0x98")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public override bool Equals(object obj)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60040C6")]
			[global::Cpp2ILInjected.Address(RVA = "0x773E38", Offset = "0x773E38", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override int GetHashCode()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60040C7")]
			[global::Cpp2ILInjected.Address(RVA = "0x773E58", Offset = "0x773E58", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public static bool operator ==(TilePaintSystemV2.TileVariationkey left, TilePaintSystemV2.TileVariationkey right)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60040C8")]
			[global::Cpp2ILInjected.Address(RVA = "0x773E88", Offset = "0x773E88", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public static bool operator !=(TilePaintSystemV2.TileVariationkey left, TilePaintSystemV2.TileVariationkey right)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4007E9B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int TileType;

			[global::Cpp2ILInjected.Token(Token = "0x4007E9C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
			public int TileStyle;

			[global::Cpp2ILInjected.Token(Token = "0x4007E9D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public int PaintColor;
		}

		[global::Cpp2ILInjected.Token(Token = "0x20007D5")]
		public struct WallVariationKey
		{
			[global::Cpp2ILInjected.Token(Token = "0x60040C9")]
			[global::Cpp2ILInjected.Address(RVA = "0x773EB8", Offset = "0x773EB8", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool Equals(TilePaintSystemV2.WallVariationKey other)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60040CA")]
			[global::Cpp2ILInjected.Address(RVA = "0x773EE0", Offset = "0x773EE0", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public override bool Equals(object obj)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60040CB")]
			[global::Cpp2ILInjected.Address(RVA = "0x773F68", Offset = "0x773F68", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override int GetHashCode()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60040CC")]
			[global::Cpp2ILInjected.Address(RVA = "0x773F7C", Offset = "0x773F7C", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public static bool operator ==(TilePaintSystemV2.WallVariationKey left, TilePaintSystemV2.WallVariationKey right)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60040CD")]
			[global::Cpp2ILInjected.Address(RVA = "0x773F9C", Offset = "0x773F9C", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public static bool operator !=(TilePaintSystemV2.WallVariationKey left, TilePaintSystemV2.WallVariationKey right)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4007E9E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int WallType;

			[global::Cpp2ILInjected.Token(Token = "0x4007E9F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
			public int PaintColor;
		}

		[global::Cpp2ILInjected.Token(Token = "0x20007D6")]
		public struct TreeFoliageVariantKey
		{
			[global::Cpp2ILInjected.Token(Token = "0x60040CE")]
			[global::Cpp2ILInjected.Address(RVA = "0x773FBC", Offset = "0x773FBC", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool Equals(TilePaintSystemV2.TreeFoliageVariantKey other)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60040CF")]
			[global::Cpp2ILInjected.Address(RVA = "0x773FF0", Offset = "0x773FF0", Length = "0x98")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public override bool Equals(object obj)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60040D0")]
			[global::Cpp2ILInjected.Address(RVA = "0x774088", Offset = "0x774088", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override int GetHashCode()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60040D1")]
			[global::Cpp2ILInjected.Address(RVA = "0x7740A8", Offset = "0x7740A8", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public static bool operator ==(TilePaintSystemV2.TreeFoliageVariantKey left, TilePaintSystemV2.TreeFoliageVariantKey right)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60040D2")]
			[global::Cpp2ILInjected.Address(RVA = "0x7740D8", Offset = "0x7740D8", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public static bool operator !=(TilePaintSystemV2.TreeFoliageVariantKey left, TilePaintSystemV2.TreeFoliageVariantKey right)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4007EA0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int TextureIndex;

			[global::Cpp2ILInjected.Token(Token = "0x4007EA1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
			public int TextureStyle;

			[global::Cpp2ILInjected.Token(Token = "0x4007EA2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public int PaintColor;
		}
	}
}
