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
	[global::Cpp2ILInjected.Token(Token = "0x20009FF")]
	public class LiquidRenderer
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x6004BA0")]
		[global::Cpp2ILInjected.Address(RVA = "0x8AD154", Offset = "0x8AD154", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static uint SimpleWhiteNoise(uint x, uint y)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6004BA4")]
		[global::Cpp2ILInjected.Address(RVA = "0x8AD298", Offset = "0x8AD298", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool HasFullWater(int x, int y)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004BA5")]
		[global::Cpp2ILInjected.Address(RVA = "0x8AD2FC", Offset = "0x8AD2FC", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public float GetVisibleLiquid(int x, int y)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6004BA9")]
		[global::Cpp2ILInjected.Address(RVA = "0x8AD7A0", Offset = "0x8AD7A0", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public Rectangle GetCachedDrawArea()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x40085BF")]
		public static LiquidRenderer Instance;

		[global::Cpp2ILInjected.Token(Token = "0x40085C0")]
		private const int ANIMATION_FRAME_COUNT = 16;

		[global::Cpp2ILInjected.Token(Token = "0x40085C1")]
		private const int CACHE_PADDING = 2;

		[global::Cpp2ILInjected.Token(Token = "0x40085C2")]
		private const int CACHE_PADDING_2 = 4;

		[global::Cpp2ILInjected.Token(Token = "0x40085C3")]
		private static readonly int[] WATERFALL_LENGTH;

		[global::Cpp2ILInjected.Token(Token = "0x40085C4")]
		private static readonly float[] DEFAULT_OPACITY;

		[global::Cpp2ILInjected.Token(Token = "0x40085C5")]
		private static readonly byte[] WAVE_MASK_STRENGTH;

		[global::Cpp2ILInjected.Token(Token = "0x40085C6")]
		private static readonly byte[] VISCOSITY_MASK;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40085C7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private Action<Microsoft.Xna.Framework.Graphics.Color[], Rectangle> WaveFilters;

		[global::Cpp2ILInjected.Token(Token = "0x40085C8")]
		public const float MIN_LIQUID_SIZE = 0.25f;

		[global::Cpp2ILInjected.Token(Token = "0x40085C9")]
		private static readonly Asset<Microsoft.Xna.Framework.Graphics.Texture2D>[] _liquidTextures;

		[global::Cpp2ILInjected.Token(Token = "0x40085CA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private LiquidRenderer.LiquidCache[] _cache;

		[global::Cpp2ILInjected.Token(Token = "0x40085CB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private LiquidRenderer.LiquidDrawCache[] _drawCache;

		[global::Cpp2ILInjected.Token(Token = "0x40085CC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private LiquidRenderer.SpecialLiquidDrawCache[] _drawCacheForShimmer;

		[global::Cpp2ILInjected.Token(Token = "0x40085CD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private int _animationFrame;

		[global::Cpp2ILInjected.Token(Token = "0x40085CE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		private Rectangle _drawArea;

		[global::Cpp2ILInjected.Token(Token = "0x40085CF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private readonly UnifiedRandom _random;

		[global::Cpp2ILInjected.Token(Token = "0x40085D0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private Microsoft.Xna.Framework.Graphics.Color[] _waveMask;

		[global::Cpp2ILInjected.Token(Token = "0x40085D1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private float _frameState;

		[global::Cpp2ILInjected.Token(Token = "0x2000A00")]
		private struct LiquidCache
		{
			[global::Cpp2ILInjected.Token(Token = "0x40085D2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public float LiquidLevel;

			[global::Cpp2ILInjected.Token(Token = "0x40085D3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
			public float VisibleLiquidLevel;

			[global::Cpp2ILInjected.Token(Token = "0x40085D4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public float Opacity;

			[global::Cpp2ILInjected.Token(Token = "0x40085D5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
			public bool IsSolid;

			[global::Cpp2ILInjected.Token(Token = "0x40085D6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xD")]
			public bool IsHalfBrick;

			[global::Cpp2ILInjected.Token(Token = "0x40085D7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xE")]
			public bool HasLiquid;

			[global::Cpp2ILInjected.Token(Token = "0x40085D8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xF")]
			public bool HasVisibleLiquid;

			[global::Cpp2ILInjected.Token(Token = "0x40085D9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public bool HasWall;

			[global::Cpp2ILInjected.Token(Token = "0x40085DA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
			public Point FrameOffset;

			[global::Cpp2ILInjected.Token(Token = "0x40085DB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
			public bool HasLeftEdge;

			[global::Cpp2ILInjected.Token(Token = "0x40085DC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x1D")]
			public bool HasRightEdge;

			[global::Cpp2ILInjected.Token(Token = "0x40085DD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x1E")]
			public bool HasTopEdge;

			[global::Cpp2ILInjected.Token(Token = "0x40085DE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x1F")]
			public bool HasBottomEdge;

			[global::Cpp2ILInjected.Token(Token = "0x40085DF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public float LeftWall;

			[global::Cpp2ILInjected.Token(Token = "0x40085E0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
			public float RightWall;

			[global::Cpp2ILInjected.Token(Token = "0x40085E1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public float BottomWall;

			[global::Cpp2ILInjected.Token(Token = "0x40085E2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
			public float TopWall;

			[global::Cpp2ILInjected.Token(Token = "0x40085E3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public float VisibleLeftWall;

			[global::Cpp2ILInjected.Token(Token = "0x40085E4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
			public float VisibleRightWall;

			[global::Cpp2ILInjected.Token(Token = "0x40085E5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			public float VisibleBottomWall;

			[global::Cpp2ILInjected.Token(Token = "0x40085E6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
			public float VisibleTopWall;

			[global::Cpp2ILInjected.Token(Token = "0x40085E7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			public byte Type;

			[global::Cpp2ILInjected.Token(Token = "0x40085E8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x41")]
			public byte VisibleType;
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000A01")]
		private struct LiquidDrawCache
		{
			[global::Cpp2ILInjected.Token(Token = "0x40085E9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public Rectangle SourceRectangle;

			[global::Cpp2ILInjected.Token(Token = "0x40085EA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public Microsoft.Xna.Framework.Vector2 LiquidOffset;

			[global::Cpp2ILInjected.Token(Token = "0x40085EB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public bool IsVisible;

			[global::Cpp2ILInjected.Token(Token = "0x40085EC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
			public float Opacity;

			[global::Cpp2ILInjected.Token(Token = "0x40085ED")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public byte Type;

			[global::Cpp2ILInjected.Token(Token = "0x40085EE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x21")]
			public bool IsSurfaceLiquid;

			[global::Cpp2ILInjected.Token(Token = "0x40085EF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x22")]
			public bool HasWall;
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000A02")]
		private struct SpecialLiquidDrawCache
		{
			[global::Cpp2ILInjected.Token(Token = "0x40085F0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int X;

			[global::Cpp2ILInjected.Token(Token = "0x40085F1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
			public int Y;

			[global::Cpp2ILInjected.Token(Token = "0x40085F2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public Rectangle SourceRectangle;

			[global::Cpp2ILInjected.Token(Token = "0x40085F3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public Microsoft.Xna.Framework.Vector2 LiquidOffset;

			[global::Cpp2ILInjected.Token(Token = "0x40085F4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public bool IsVisible;

			[global::Cpp2ILInjected.Token(Token = "0x40085F5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
			public float Opacity;

			[global::Cpp2ILInjected.Token(Token = "0x40085F6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public byte Type;

			[global::Cpp2ILInjected.Token(Token = "0x40085F7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x29")]
			public bool IsSurfaceLiquid;

			[global::Cpp2ILInjected.Token(Token = "0x40085F8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x2A")]
			public bool HasWall;
		}
	}
}
