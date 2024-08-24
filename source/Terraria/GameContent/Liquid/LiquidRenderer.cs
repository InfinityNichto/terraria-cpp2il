using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.DataStructures;
using Terraria.GameContent.Drawing;
using Terraria.Graphics;
using Terraria.Graphics.Capture;
using Terraria.Graphics.Light;
using Terraria.Utilities;
using Unity.Collections;
using UnityEngine;

namespace Terraria.GameContent.Liquid
{
	// Token: 0x02000677 RID: 1655
	[global::Cpp2ILInjected.Token(Token = "0x20009FF")]
	public class LiquidRenderer
	{
		// Token: 0x14000055 RID: 85
		// (add) Token: 0x0600410C RID: 16652 RVA: 0x0002DA01 File Offset: 0x0002BC01
		// (remove) Token: 0x0600410D RID: 16653 RVA: 0x0002DA04 File Offset: 0x0002BC04
		[global::Cpp2ILInjected.Token(Token = "0x1400005B")]
		public event Action<Microsoft.Xna.Framework.Graphics.Color[], Rectangle> WaveFilters
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6004B91")]
			[global::Cpp2ILInjected.Address(RVA = "0x8A9D04", Offset = "0x8A9D04", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6004B92")]
			[global::Cpp2ILInjected.Address(RVA = "0x8A9DB4", Offset = "0x8A9DB4", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x0600410E RID: 16654 RVA: 0x0002DA07 File Offset: 0x0002BC07
		[global::Cpp2ILInjected.Token(Token = "0x1700086C")]
		private static TileData Tiles
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004B93")]
			[global::Cpp2ILInjected.Address(RVA = "0x8A9E64", Offset = "0x8A9E64", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600410F RID: 16655 RVA: 0x0002DA0A File Offset: 0x0002BC0A
		[global::Cpp2ILInjected.Token(Token = "0x6004B94")]
		[global::Cpp2ILInjected.Address(RVA = "0x8A9EBC", Offset = "0x8A9EBC", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "PostContentLoadInitialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LiquidRenderer), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LiquidRenderer), Member = "PrepareAssets", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void LoadContent()
		{
			throw null;
		}

		// Token: 0x06004110 RID: 16656 RVA: 0x0002DA0D File Offset: 0x0002BC0D
		[global::Cpp2ILInjected.Token(Token = "0x6004B95")]
		[global::Cpp2ILInjected.Address(RVA = "0x8A9F24", Offset = "0x8A9F24", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LocalUser), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(PlatformUser)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LiquidRenderer), Member = "LoadContent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public LiquidRenderer()
		{
			throw null;
		}

		// Token: 0x06004111 RID: 16657 RVA: 0x0002DA10 File Offset: 0x0002BC10
		[global::Cpp2ILInjected.Token(Token = "0x6004B96")]
		[global::Cpp2ILInjected.Address(RVA = "0x8AA058", Offset = "0x8AA058", Length = "0x1FC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LiquidRenderer), Member = "LoadContent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public void PrepareAssets()
		{
			throw null;
		}

		// Token: 0x06004112 RID: 16658 RVA: 0x0002DA13 File Offset: 0x0002BC13
		[global::Cpp2ILInjected.Token(Token = "0x6004B97")]
		[global::Cpp2ILInjected.Address(RVA = "0x8AA254", Offset = "0x8AA254", Length = "0x1308")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LiquidRenderer), Member = "PrepareDraw", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "NewDust", MemberParameters = new object[]
		{
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(Microsoft.Xna.Framework.Graphics.Color),
			typeof(float)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(float)
		}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 30)]
		private void InternalPrepareDraw(Rectangle drawArea)
		{
			throw null;
		}

		// Token: 0x06004113 RID: 16659 RVA: 0x0002DA16 File Offset: 0x0002BC16
		[global::Cpp2ILInjected.Token(Token = "0x6004B98")]
		[global::Cpp2ILInjected.Address(RVA = "0x8AB55C", Offset = "0x8AB55C", Length = "0xB64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawLiquid", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(int),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "GetLightMap", MemberParameters = new object[] { typeof(ref Rectangle) }, ReturnType = typeof(LightMap))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Right", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Bottom", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "DrawTileInWater", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(int),
			typeof(int),
			typeof(byte),
			typeof(short),
			typeof(short)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
			typeof(ref Microsoft.Xna.Framework.Vector2),
			typeof(ref Rectangle),
			typeof(ref VertexColors)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "End", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Flush", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Begin", MemberParameters = new object[]
		{
			typeof(SpriteSortMode),
			typeof(BlendState),
			typeof(SamplerState),
			typeof(DepthStencilState),
			typeof(RasterizerState),
			typeof(Effect),
			typeof(Matrix?),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		public void DrawNormalLiquids(SpriteBatch spriteBatch, Microsoft.Xna.Framework.Vector2 drawOffset, int waterStyle, float globalAlpha, bool isBackgroundDraw)
		{
			throw null;
		}

		// Token: 0x06004114 RID: 16660 RVA: 0x0002DA19 File Offset: 0x0002BC19
		[global::Cpp2ILInjected.Token(Token = "0x6004B99")]
		[global::Cpp2ILInjected.Address(RVA = "0x8AC0C0", Offset = "0x8AC0C0", Length = "0x568")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawLiquid", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(int),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "End", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Flush", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Begin", MemberParameters = new object[]
		{
			typeof(SpriteSortMode),
			typeof(BlendState),
			typeof(SamplerState),
			typeof(DepthStencilState),
			typeof(RasterizerState),
			typeof(Effect),
			typeof(Matrix?),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LiquidRenderer), Member = "SetShimmerVertexColors", MemberParameters = new object[]
		{
			typeof(ref VertexColors),
			typeof(float),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "DrawTileInWater", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(int),
			typeof(int),
			typeof(byte),
			typeof(short),
			typeof(short)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(ref Rectangle),
			typeof(ref VertexColors),
			typeof(float),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(float),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LiquidRenderer), Member = "GetShimmerFrame", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LiquidRenderer), Member = "SetShimmerVertexColors_Sparkle", MemberParameters = new object[]
		{
			typeof(ref VertexColors),
			typeof(float),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public void DrawShimmer(SpriteBatch spriteBatch, Microsoft.Xna.Framework.Vector2 drawOffset, bool isBackgroundDraw)
		{
			throw null;
		}

		// Token: 0x06004115 RID: 16661 RVA: 0x0002DA1C File Offset: 0x0002BC1C
		[global::Cpp2ILInjected.Token(Token = "0x6004B9A")]
		[global::Cpp2ILInjected.Address(RVA = "0x8AC7F4", Offset = "0x8AC7F4", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WaterfallManager), Member = "DrawWaterfall", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(int),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WaterfallManager), Member = "DrawWaterfall", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(ref Rectangle),
			typeof(ref Microsoft.Xna.Framework.Graphics.Color),
			typeof(SpriteEffects)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LiquidRenderer), Member = "DrawShimmer", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 16)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LiquidRenderer), Member = "GetShimmerGlitterColor", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(float),
			typeof(float),
			typeof(ref Microsoft.Xna.Framework.Graphics.Color),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void SetShimmerVertexColors_Sparkle(ref VertexColors colors, float opacity, int x, int y, bool top)
		{
			throw null;
		}

		// Token: 0x06004116 RID: 16662 RVA: 0x0002DA1F File Offset: 0x0002BC1F
		[global::Cpp2ILInjected.Token(Token = "0x6004B9B")]
		[global::Cpp2ILInjected.Address(RVA = "0x8AC628", Offset = "0x8AC628", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WaterfallManager), Member = "DrawWaterfall", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(int),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WaterfallManager), Member = "DrawWaterfall", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(ref Rectangle),
			typeof(ref Microsoft.Xna.Framework.Graphics.Color),
			typeof(SpriteEffects)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTile_LiquidBehindTile", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool),
			typeof(int),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(int),
			typeof(int),
			typeof(TileDrawInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LiquidRenderer), Member = "DrawShimmer", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 19)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LiquidRenderer), Member = "GetShimmerColor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(ref Microsoft.Xna.Framework.Graphics.Color),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void SetShimmerVertexColors(ref VertexColors colors, float opacity, int x, int y)
		{
			throw null;
		}

		// Token: 0x06004117 RID: 16663 RVA: 0x0002DA22 File Offset: 0x0002BC22
		[global::Cpp2ILInjected.Token(Token = "0x6004B9C")]
		[global::Cpp2ILInjected.Address(RVA = "0x8ACD60", Offset = "0x8ACD60", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LiquidRenderer), Member = "GetShimmerBaseColor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(Microsoft.Xna.Framework.Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LiquidRenderer), Member = "GetShimmerColor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(ref Microsoft.Xna.Framework.Graphics.Color),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static float GetShimmerWave(ref float worldPositionX, ref float worldPositionY)
		{
			throw null;
		}

		// Token: 0x06004118 RID: 16664 RVA: 0x0002DA25 File Offset: 0x0002BC25
		[global::Cpp2ILInjected.Token(Token = "0x6004B9D")]
		[global::Cpp2ILInjected.Address(RVA = "0x8ACE44", Offset = "0x8ACE44", Length = "0x17C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "oldDrawWater", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(int),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_10_BackAcc", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_32_FrontAcc_FrontPart", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_32_FrontAcc_BackPart", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "hslToRgb", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(byte)
		}, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Color), Member = "ToVector4", ReturnType = typeof(Microsoft.Xna.Framework.Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LiquidRenderer), Member = "GetShimmerGlitterOpacity", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector4), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Microsoft.Xna.Framework.Vector4),
			typeof(float)
		}, ReturnType = typeof(Microsoft.Xna.Framework.Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Color), Member = ".ctor", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector4) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static Microsoft.Xna.Framework.Graphics.Color GetShimmerGlitterColor(bool top, float worldPositionX, float worldPositionY)
		{
			throw null;
		}

		// Token: 0x06004119 RID: 16665 RVA: 0x0002DA28 File Offset: 0x0002BC28
		[global::Cpp2ILInjected.Token(Token = "0x6004B9E")]
		[global::Cpp2ILInjected.Address(RVA = "0x8AC8F0", Offset = "0x8AC8F0", Length = "0x350")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LiquidRenderer), Member = "SetShimmerVertexColors_Sparkle", MemberParameters = new object[]
		{
			typeof(ref VertexColors),
			typeof(float),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "hue2rgb", MemberParameters = new object[]
		{
			typeof(double),
			typeof(double),
			typeof(double)
		}, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LiquidRenderer), Member = "GetShimmerGlitterOpacity", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Microsoft.Xna.Framework.Graphics.Color),
			typeof(float)
		}, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Color))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public static void GetShimmerGlitterColor(bool top, float worldPositionX, float worldPositionY, ref Microsoft.Xna.Framework.Graphics.Color color, float opacity)
		{
			throw null;
		}

		// Token: 0x0600411A RID: 16666 RVA: 0x0002DA2B File Offset: 0x0002BC2B
		[global::Cpp2ILInjected.Token(Token = "0x6004B9F")]
		[global::Cpp2ILInjected.Address(RVA = "0x8ACFC0", Offset = "0x8ACFC0", Length = "0x194")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LiquidRenderer), Member = "GetShimmerGlitterColor", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Color))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LiquidRenderer), Member = "GetShimmerGlitterColor", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(float),
			typeof(float),
			typeof(ref Microsoft.Xna.Framework.Graphics.Color),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static float GetShimmerGlitterOpacity(bool top, float worldPositionX, float worldPositionY)
		{
			throw null;
		}

		// Token: 0x0600411B RID: 16667 RVA: 0x0002DA2E File Offset: 0x0002BC2E
		[global::Cpp2ILInjected.Token(Token = "0x6004BA0")]
		[global::Cpp2ILInjected.Address(RVA = "0x8AD154", Offset = "0x8AD154", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static uint SimpleWhiteNoise(uint x, uint y)
		{
			throw null;
		}

		// Token: 0x0600411C RID: 16668 RVA: 0x0002DA31 File Offset: 0x0002BC31
		[global::Cpp2ILInjected.Token(Token = "0x6004BA1")]
		[global::Cpp2ILInjected.Address(RVA = "0x8AC704", Offset = "0x8AC704", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LiquidRenderer), Member = "DrawShimmer", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public int GetShimmerFrame(bool top, float worldPositionX, float worldPositionY)
		{
			throw null;
		}

		// Token: 0x0600411D RID: 16669 RVA: 0x0002DA34 File Offset: 0x0002BC34
		[global::Cpp2ILInjected.Token(Token = "0x6004BA2")]
		[global::Cpp2ILInjected.Address(RVA = "0x8AD17C", Offset = "0x8AD17C", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "oldDrawWater", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(int),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileLightScanner), Member = "ExportTo", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(LightMap)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileLightScanner), Member = "ApplyTileLight", MemberParameters = new object[]
		{
			typeof(Tile),
			typeof(int),
			typeof(int),
			typeof(ref FastRandom),
			typeof(ref Microsoft.Xna.Framework.Vector3)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LiquidRenderer), Member = "GetShimmerWave", MemberParameters = new object[]
		{
			typeof(ref float),
			typeof(ref float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector4), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector4), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(Microsoft.Xna.Framework.Vector4),
			typeof(Microsoft.Xna.Framework.Vector4),
			typeof(float)
		}, ReturnType = typeof(Microsoft.Xna.Framework.Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static Microsoft.Xna.Framework.Vector4 GetShimmerBaseColor(float worldPositionX, float worldPositionY)
		{
			throw null;
		}

		// Token: 0x0600411E RID: 16670 RVA: 0x0002DA37 File Offset: 0x0002BC37
		[global::Cpp2ILInjected.Token(Token = "0x6004BA3")]
		[global::Cpp2ILInjected.Address(RVA = "0x8ACC40", Offset = "0x8ACC40", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LiquidRenderer), Member = "SetShimmerVertexColors", MemberParameters = new object[]
		{
			typeof(ref VertexColors),
			typeof(float),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LiquidRenderer), Member = "GetShimmerWave", MemberParameters = new object[]
		{
			typeof(ref float),
			typeof(ref float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void GetShimmerColor(float worldPositionX, float worldPositionY, ref Microsoft.Xna.Framework.Graphics.Color baseColor, float opcacity)
		{
			throw null;
		}

		// Token: 0x0600411F RID: 16671 RVA: 0x0002DA3A File Offset: 0x0002BC3A
		[global::Cpp2ILInjected.Token(Token = "0x6004BA4")]
		[global::Cpp2ILInjected.Address(RVA = "0x8AD298", Offset = "0x8AD298", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool HasFullWater(int x, int y)
		{
			throw null;
		}

		// Token: 0x06004120 RID: 16672 RVA: 0x0002DA3D File Offset: 0x0002BC3D
		[global::Cpp2ILInjected.Token(Token = "0x6004BA5")]
		[global::Cpp2ILInjected.Address(RVA = "0x8AD2FC", Offset = "0x8AD2FC", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public float GetVisibleLiquid(int x, int y)
		{
			throw null;
		}

		// Token: 0x06004121 RID: 16673 RVA: 0x0002DA40 File Offset: 0x0002BC40
		[global::Cpp2ILInjected.Token(Token = "0x6004BA6")]
		[global::Cpp2ILInjected.Address(RVA = "0x8AD368", Offset = "0x8AD368", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoUpdate", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "get_TotalSeconds", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void Update(GameTime gameTime)
		{
			throw null;
		}

		// Token: 0x06004122 RID: 16674 RVA: 0x0002DA43 File Offset: 0x0002BC43
		[global::Cpp2ILInjected.Token(Token = "0x6004BA7")]
		[global::Cpp2ILInjected.Address(RVA = "0x8AD488", Offset = "0x8AD488", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawCapture", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(CaptureSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawWaters", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LiquidRenderer), Member = "InternalPrepareDraw", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		public void PrepareDraw(Rectangle drawArea)
		{
			throw null;
		}

		// Token: 0x06004123 RID: 16675 RVA: 0x0002DA46 File Offset: 0x0002BC46
		[global::Cpp2ILInjected.Token(Token = "0x6004BA8")]
		[global::Cpp2ILInjected.Address(RVA = "0x8AD48C", Offset = "0x8AD48C", Length = "0x314")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Console), Member = "WriteLine", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Texture2D), Member = "get_UnityTexture", ReturnType = typeof(global::UnityEngine.Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "DestroyImmediate", MemberParameters = new object[] { typeof(global::UnityEngine.Object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Texture2D), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(TextureFormat),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Texture2D), Member = ".ctor", MemberParameters = new object[] { typeof(global::UnityEngine.Texture2D) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Texture2D), Member = "GetRawTextureData", MemberTypeParameters = new object[] { "T" }, ReturnType = "Unity.Collections.NativeArray`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NativeArray<Microsoft.Xna.Framework.Graphics.Color>), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Microsoft.Xna.Framework.Graphics.Color[]),
			typeof(int),
			typeof(NativeArray<Microsoft.Xna.Framework.Graphics.Color>),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Texture2D), Member = "Apply", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		public void SetWaveMaskData(ref Microsoft.Xna.Framework.Graphics.Texture2D texture)
		{
			throw null;
		}

		// Token: 0x06004124 RID: 16676 RVA: 0x0002DA49 File Offset: 0x0002BC49
		[global::Cpp2ILInjected.Token(Token = "0x6004BA9")]
		[global::Cpp2ILInjected.Address(RVA = "0x8AD7A0", Offset = "0x8AD7A0", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public Rectangle GetCachedDrawArea()
		{
			throw null;
		}

		// Token: 0x06004125 RID: 16677 RVA: 0x0002DA4C File Offset: 0x0002BC4C
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6004BAA")]
		[global::Cpp2ILInjected.Address(RVA = "0x8AD7B0", Offset = "0x8AD7B0", Length = "0x174")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		static LiquidRenderer()
		{
			throw null;
		}

		// Token: 0x04006D87 RID: 28039
		[global::Cpp2ILInjected.Token(Token = "0x40085BF")]
		public static LiquidRenderer Instance;

		// Token: 0x04006D88 RID: 28040
		[global::Cpp2ILInjected.Token(Token = "0x40085C0")]
		private const int ANIMATION_FRAME_COUNT = 16;

		// Token: 0x04006D89 RID: 28041
		[global::Cpp2ILInjected.Token(Token = "0x40085C1")]
		private const int CACHE_PADDING = 2;

		// Token: 0x04006D8A RID: 28042
		[global::Cpp2ILInjected.Token(Token = "0x40085C2")]
		private const int CACHE_PADDING_2 = 4;

		// Token: 0x04006D8B RID: 28043
		[global::Cpp2ILInjected.Token(Token = "0x40085C3")]
		private static readonly int[] WATERFALL_LENGTH;

		// Token: 0x04006D8C RID: 28044
		[global::Cpp2ILInjected.Token(Token = "0x40085C4")]
		private static readonly float[] DEFAULT_OPACITY;

		// Token: 0x04006D8D RID: 28045
		[global::Cpp2ILInjected.Token(Token = "0x40085C5")]
		private static readonly byte[] WAVE_MASK_STRENGTH;

		// Token: 0x04006D8E RID: 28046
		[global::Cpp2ILInjected.Token(Token = "0x40085C6")]
		private static readonly byte[] VISCOSITY_MASK;

		// Token: 0x04006D8F RID: 28047
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40085C7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private Action<Microsoft.Xna.Framework.Graphics.Color[], Rectangle> WaveFilters;

		// Token: 0x04006D90 RID: 28048
		[global::Cpp2ILInjected.Token(Token = "0x40085C8")]
		public const float MIN_LIQUID_SIZE = 0.25f;

		// Token: 0x04006D91 RID: 28049
		[global::Cpp2ILInjected.Token(Token = "0x40085C9")]
		private static readonly Asset<Microsoft.Xna.Framework.Graphics.Texture2D>[] _liquidTextures;

		// Token: 0x04006D92 RID: 28050
		[global::Cpp2ILInjected.Token(Token = "0x40085CA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private LiquidRenderer.LiquidCache[] _cache;

		// Token: 0x04006D93 RID: 28051
		[global::Cpp2ILInjected.Token(Token = "0x40085CB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private LiquidRenderer.LiquidDrawCache[] _drawCache;

		// Token: 0x04006D94 RID: 28052
		[global::Cpp2ILInjected.Token(Token = "0x40085CC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private LiquidRenderer.SpecialLiquidDrawCache[] _drawCacheForShimmer;

		// Token: 0x04006D95 RID: 28053
		[global::Cpp2ILInjected.Token(Token = "0x40085CD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private int _animationFrame;

		// Token: 0x04006D96 RID: 28054
		[global::Cpp2ILInjected.Token(Token = "0x40085CE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		private Rectangle _drawArea;

		// Token: 0x04006D97 RID: 28055
		[global::Cpp2ILInjected.Token(Token = "0x40085CF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private readonly UnifiedRandom _random;

		// Token: 0x04006D98 RID: 28056
		[global::Cpp2ILInjected.Token(Token = "0x40085D0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private Microsoft.Xna.Framework.Graphics.Color[] _waveMask;

		// Token: 0x04006D99 RID: 28057
		[global::Cpp2ILInjected.Token(Token = "0x40085D1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private float _frameState;

		// Token: 0x02000A67 RID: 2663
		[global::Cpp2ILInjected.Token(Token = "0x2000A00")]
		private struct LiquidCache
		{
			// Token: 0x04008E51 RID: 36433
			[global::Cpp2ILInjected.Token(Token = "0x40085D2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public float LiquidLevel;

			// Token: 0x04008E52 RID: 36434
			[global::Cpp2ILInjected.Token(Token = "0x40085D3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
			public float VisibleLiquidLevel;

			// Token: 0x04008E53 RID: 36435
			[global::Cpp2ILInjected.Token(Token = "0x40085D4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public float Opacity;

			// Token: 0x04008E54 RID: 36436
			[global::Cpp2ILInjected.Token(Token = "0x40085D5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
			public bool IsSolid;

			// Token: 0x04008E55 RID: 36437
			[global::Cpp2ILInjected.Token(Token = "0x40085D6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xD")]
			public bool IsHalfBrick;

			// Token: 0x04008E56 RID: 36438
			[global::Cpp2ILInjected.Token(Token = "0x40085D7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xE")]
			public bool HasLiquid;

			// Token: 0x04008E57 RID: 36439
			[global::Cpp2ILInjected.Token(Token = "0x40085D8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xF")]
			public bool HasVisibleLiquid;

			// Token: 0x04008E58 RID: 36440
			[global::Cpp2ILInjected.Token(Token = "0x40085D9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public bool HasWall;

			// Token: 0x04008E59 RID: 36441
			[global::Cpp2ILInjected.Token(Token = "0x40085DA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
			public Point FrameOffset;

			// Token: 0x04008E5A RID: 36442
			[global::Cpp2ILInjected.Token(Token = "0x40085DB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
			public bool HasLeftEdge;

			// Token: 0x04008E5B RID: 36443
			[global::Cpp2ILInjected.Token(Token = "0x40085DC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x1D")]
			public bool HasRightEdge;

			// Token: 0x04008E5C RID: 36444
			[global::Cpp2ILInjected.Token(Token = "0x40085DD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x1E")]
			public bool HasTopEdge;

			// Token: 0x04008E5D RID: 36445
			[global::Cpp2ILInjected.Token(Token = "0x40085DE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x1F")]
			public bool HasBottomEdge;

			// Token: 0x04008E5E RID: 36446
			[global::Cpp2ILInjected.Token(Token = "0x40085DF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public float LeftWall;

			// Token: 0x04008E5F RID: 36447
			[global::Cpp2ILInjected.Token(Token = "0x40085E0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
			public float RightWall;

			// Token: 0x04008E60 RID: 36448
			[global::Cpp2ILInjected.Token(Token = "0x40085E1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public float BottomWall;

			// Token: 0x04008E61 RID: 36449
			[global::Cpp2ILInjected.Token(Token = "0x40085E2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
			public float TopWall;

			// Token: 0x04008E62 RID: 36450
			[global::Cpp2ILInjected.Token(Token = "0x40085E3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public float VisibleLeftWall;

			// Token: 0x04008E63 RID: 36451
			[global::Cpp2ILInjected.Token(Token = "0x40085E4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
			public float VisibleRightWall;

			// Token: 0x04008E64 RID: 36452
			[global::Cpp2ILInjected.Token(Token = "0x40085E5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			public float VisibleBottomWall;

			// Token: 0x04008E65 RID: 36453
			[global::Cpp2ILInjected.Token(Token = "0x40085E6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
			public float VisibleTopWall;

			// Token: 0x04008E66 RID: 36454
			[global::Cpp2ILInjected.Token(Token = "0x40085E7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			public byte Type;

			// Token: 0x04008E67 RID: 36455
			[global::Cpp2ILInjected.Token(Token = "0x40085E8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x41")]
			public byte VisibleType;
		}

		// Token: 0x02000A68 RID: 2664
		[global::Cpp2ILInjected.Token(Token = "0x2000A01")]
		private struct LiquidDrawCache
		{
			// Token: 0x04008E68 RID: 36456
			[global::Cpp2ILInjected.Token(Token = "0x40085E9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public Rectangle SourceRectangle;

			// Token: 0x04008E69 RID: 36457
			[global::Cpp2ILInjected.Token(Token = "0x40085EA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public Microsoft.Xna.Framework.Vector2 LiquidOffset;

			// Token: 0x04008E6A RID: 36458
			[global::Cpp2ILInjected.Token(Token = "0x40085EB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public bool IsVisible;

			// Token: 0x04008E6B RID: 36459
			[global::Cpp2ILInjected.Token(Token = "0x40085EC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
			public float Opacity;

			// Token: 0x04008E6C RID: 36460
			[global::Cpp2ILInjected.Token(Token = "0x40085ED")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public byte Type;

			// Token: 0x04008E6D RID: 36461
			[global::Cpp2ILInjected.Token(Token = "0x40085EE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x21")]
			public bool IsSurfaceLiquid;

			// Token: 0x04008E6E RID: 36462
			[global::Cpp2ILInjected.Token(Token = "0x40085EF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x22")]
			public bool HasWall;
		}

		// Token: 0x02000A69 RID: 2665
		[global::Cpp2ILInjected.Token(Token = "0x2000A02")]
		private struct SpecialLiquidDrawCache
		{
			// Token: 0x04008E6F RID: 36463
			[global::Cpp2ILInjected.Token(Token = "0x40085F0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int X;

			// Token: 0x04008E70 RID: 36464
			[global::Cpp2ILInjected.Token(Token = "0x40085F1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
			public int Y;

			// Token: 0x04008E71 RID: 36465
			[global::Cpp2ILInjected.Token(Token = "0x40085F2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public Rectangle SourceRectangle;

			// Token: 0x04008E72 RID: 36466
			[global::Cpp2ILInjected.Token(Token = "0x40085F3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public Microsoft.Xna.Framework.Vector2 LiquidOffset;

			// Token: 0x04008E73 RID: 36467
			[global::Cpp2ILInjected.Token(Token = "0x40085F4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public bool IsVisible;

			// Token: 0x04008E74 RID: 36468
			[global::Cpp2ILInjected.Token(Token = "0x40085F5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
			public float Opacity;

			// Token: 0x04008E75 RID: 36469
			[global::Cpp2ILInjected.Token(Token = "0x40085F6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public byte Type;

			// Token: 0x04008E76 RID: 36470
			[global::Cpp2ILInjected.Token(Token = "0x40085F7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x29")]
			public bool IsSurfaceLiquid;

			// Token: 0x04008E77 RID: 36471
			[global::Cpp2ILInjected.Token(Token = "0x40085F8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x2A")]
			public bool HasWall;
		}
	}
}
