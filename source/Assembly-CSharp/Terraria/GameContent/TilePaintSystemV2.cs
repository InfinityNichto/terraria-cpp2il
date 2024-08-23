using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;
using Terraria.GameContent.Drawing;

namespace Terraria.GameContent
{
	// Token: 0x02000556 RID: 1366
	[global::Cpp2ILInjected.Token(Token = "0x20007D3")]
	public class TilePaintSystemV2
	{
		// Token: 0x060039E5 RID: 14821 RVA: 0x0002C570 File Offset: 0x0002A770
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

		// Token: 0x060039E6 RID: 14822 RVA: 0x0002C573 File Offset: 0x0002A773
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

		// Token: 0x060039E7 RID: 14823 RVA: 0x0002C576 File Offset: 0x0002A776
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

		// Token: 0x060039E8 RID: 14824 RVA: 0x0002C579 File Offset: 0x0002A779
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

		// Token: 0x060039E9 RID: 14825 RVA: 0x0002C57C File Offset: 0x0002A77C
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

		// Token: 0x060039EA RID: 14826 RVA: 0x0002C57F File Offset: 0x0002A77F
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

		// Token: 0x060039EB RID: 14827 RVA: 0x0002C582 File Offset: 0x0002A782
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

		// Token: 0x060039EC RID: 14828 RVA: 0x0002C585 File Offset: 0x0002A785
		[global::Cpp2ILInjected.Token(Token = "0x60040C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x773798", Offset = "0x773798", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public EffectPass GetShader(int paintColor, TreePaintingSettings settings)
		{
			throw null;
		}

		// Token: 0x060039ED RID: 14829 RVA: 0x0002C588 File Offset: 0x0002A788
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

		// Token: 0x0400691E RID: 26910
		[global::Cpp2ILInjected.Token(Token = "0x4007E97")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private Effect TileShader;

		// Token: 0x0400691F RID: 26911
		[global::Cpp2ILInjected.Token(Token = "0x4007E98")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private TreePaintSystemData PaintSystemData;

		// Token: 0x04006920 RID: 26912
		[global::Cpp2ILInjected.Token(Token = "0x4007E99")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private TileShader[] specialShaders;

		// Token: 0x04006921 RID: 26913
		[global::Cpp2ILInjected.Token(Token = "0x4007E9A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private EffectPass[] TileShaders;

		// Token: 0x02000988 RID: 2440
		[global::Cpp2ILInjected.Token(Token = "0x20007D4")]
		public struct TileVariationkey
		{
			// Token: 0x06004DAB RID: 19883 RVA: 0x0002FB49 File Offset: 0x0002DD49
			[global::Cpp2ILInjected.Token(Token = "0x60040C4")]
			[global::Cpp2ILInjected.Address(RVA = "0x773D6C", Offset = "0x773D6C", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool Equals(TilePaintSystemV2.TileVariationkey other)
			{
				throw null;
			}

			// Token: 0x06004DAC RID: 19884 RVA: 0x0002FB4C File Offset: 0x0002DD4C
			[global::Cpp2ILInjected.Token(Token = "0x60040C5")]
			[global::Cpp2ILInjected.Address(RVA = "0x773DA0", Offset = "0x773DA0", Length = "0x98")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public override bool Equals(object obj)
			{
				throw null;
			}

			// Token: 0x06004DAD RID: 19885 RVA: 0x0002FB4F File Offset: 0x0002DD4F
			[global::Cpp2ILInjected.Token(Token = "0x60040C6")]
			[global::Cpp2ILInjected.Address(RVA = "0x773E38", Offset = "0x773E38", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override int GetHashCode()
			{
				throw null;
			}

			// Token: 0x06004DAE RID: 19886 RVA: 0x0002FB52 File Offset: 0x0002DD52
			[global::Cpp2ILInjected.Token(Token = "0x60040C7")]
			[global::Cpp2ILInjected.Address(RVA = "0x773E58", Offset = "0x773E58", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public static bool operator ==(TilePaintSystemV2.TileVariationkey left, TilePaintSystemV2.TileVariationkey right)
			{
				throw null;
			}

			// Token: 0x06004DAF RID: 19887 RVA: 0x0002FB55 File Offset: 0x0002DD55
			[global::Cpp2ILInjected.Token(Token = "0x60040C8")]
			[global::Cpp2ILInjected.Address(RVA = "0x773E88", Offset = "0x773E88", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public static bool operator !=(TilePaintSystemV2.TileVariationkey left, TilePaintSystemV2.TileVariationkey right)
			{
				throw null;
			}

			// Token: 0x04008C2E RID: 35886
			[global::Cpp2ILInjected.Token(Token = "0x4007E9B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int TileType;

			// Token: 0x04008C2F RID: 35887
			[global::Cpp2ILInjected.Token(Token = "0x4007E9C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
			public int TileStyle;

			// Token: 0x04008C30 RID: 35888
			[global::Cpp2ILInjected.Token(Token = "0x4007E9D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public int PaintColor;
		}

		// Token: 0x02000989 RID: 2441
		[global::Cpp2ILInjected.Token(Token = "0x20007D5")]
		public struct WallVariationKey
		{
			// Token: 0x06004DB0 RID: 19888 RVA: 0x0002FB58 File Offset: 0x0002DD58
			[global::Cpp2ILInjected.Token(Token = "0x60040C9")]
			[global::Cpp2ILInjected.Address(RVA = "0x773EB8", Offset = "0x773EB8", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool Equals(TilePaintSystemV2.WallVariationKey other)
			{
				throw null;
			}

			// Token: 0x06004DB1 RID: 19889 RVA: 0x0002FB5B File Offset: 0x0002DD5B
			[global::Cpp2ILInjected.Token(Token = "0x60040CA")]
			[global::Cpp2ILInjected.Address(RVA = "0x773EE0", Offset = "0x773EE0", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public override bool Equals(object obj)
			{
				throw null;
			}

			// Token: 0x06004DB2 RID: 19890 RVA: 0x0002FB5E File Offset: 0x0002DD5E
			[global::Cpp2ILInjected.Token(Token = "0x60040CB")]
			[global::Cpp2ILInjected.Address(RVA = "0x773F68", Offset = "0x773F68", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override int GetHashCode()
			{
				throw null;
			}

			// Token: 0x06004DB3 RID: 19891 RVA: 0x0002FB61 File Offset: 0x0002DD61
			[global::Cpp2ILInjected.Token(Token = "0x60040CC")]
			[global::Cpp2ILInjected.Address(RVA = "0x773F7C", Offset = "0x773F7C", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public static bool operator ==(TilePaintSystemV2.WallVariationKey left, TilePaintSystemV2.WallVariationKey right)
			{
				throw null;
			}

			// Token: 0x06004DB4 RID: 19892 RVA: 0x0002FB64 File Offset: 0x0002DD64
			[global::Cpp2ILInjected.Token(Token = "0x60040CD")]
			[global::Cpp2ILInjected.Address(RVA = "0x773F9C", Offset = "0x773F9C", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public static bool operator !=(TilePaintSystemV2.WallVariationKey left, TilePaintSystemV2.WallVariationKey right)
			{
				throw null;
			}

			// Token: 0x04008C31 RID: 35889
			[global::Cpp2ILInjected.Token(Token = "0x4007E9E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int WallType;

			// Token: 0x04008C32 RID: 35890
			[global::Cpp2ILInjected.Token(Token = "0x4007E9F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
			public int PaintColor;
		}

		// Token: 0x0200098A RID: 2442
		[global::Cpp2ILInjected.Token(Token = "0x20007D6")]
		public struct TreeFoliageVariantKey
		{
			// Token: 0x06004DB5 RID: 19893 RVA: 0x0002FB67 File Offset: 0x0002DD67
			[global::Cpp2ILInjected.Token(Token = "0x60040CE")]
			[global::Cpp2ILInjected.Address(RVA = "0x773FBC", Offset = "0x773FBC", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool Equals(TilePaintSystemV2.TreeFoliageVariantKey other)
			{
				throw null;
			}

			// Token: 0x06004DB6 RID: 19894 RVA: 0x0002FB6A File Offset: 0x0002DD6A
			[global::Cpp2ILInjected.Token(Token = "0x60040CF")]
			[global::Cpp2ILInjected.Address(RVA = "0x773FF0", Offset = "0x773FF0", Length = "0x98")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public override bool Equals(object obj)
			{
				throw null;
			}

			// Token: 0x06004DB7 RID: 19895 RVA: 0x0002FB6D File Offset: 0x0002DD6D
			[global::Cpp2ILInjected.Token(Token = "0x60040D0")]
			[global::Cpp2ILInjected.Address(RVA = "0x774088", Offset = "0x774088", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override int GetHashCode()
			{
				throw null;
			}

			// Token: 0x06004DB8 RID: 19896 RVA: 0x0002FB70 File Offset: 0x0002DD70
			[global::Cpp2ILInjected.Token(Token = "0x60040D1")]
			[global::Cpp2ILInjected.Address(RVA = "0x7740A8", Offset = "0x7740A8", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public static bool operator ==(TilePaintSystemV2.TreeFoliageVariantKey left, TilePaintSystemV2.TreeFoliageVariantKey right)
			{
				throw null;
			}

			// Token: 0x06004DB9 RID: 19897 RVA: 0x0002FB73 File Offset: 0x0002DD73
			[global::Cpp2ILInjected.Token(Token = "0x60040D2")]
			[global::Cpp2ILInjected.Address(RVA = "0x7740D8", Offset = "0x7740D8", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public static bool operator !=(TilePaintSystemV2.TreeFoliageVariantKey left, TilePaintSystemV2.TreeFoliageVariantKey right)
			{
				throw null;
			}

			// Token: 0x04008C33 RID: 35891
			[global::Cpp2ILInjected.Token(Token = "0x4007EA0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int TextureIndex;

			// Token: 0x04008C34 RID: 35892
			[global::Cpp2ILInjected.Token(Token = "0x4007EA1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
			public int TextureStyle;

			// Token: 0x04008C35 RID: 35893
			[global::Cpp2ILInjected.Token(Token = "0x4007EA2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public int PaintColor;
		}
	}
}
