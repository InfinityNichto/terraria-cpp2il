using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.DataStructures;
using Terraria.GameContent.Drawing;
using Terraria.GameContent.Liquid;
using Terraria.Graphics;
using Terraria.Graphics.Capture;
using Terraria.Initializers;
using Terraria.IO;
using Terraria.Utilities;

namespace Terraria
{
	// Token: 0x02000350 RID: 848
	[global::Cpp2ILInjected.Token(Token = "0x200046E")]
	public class WaterfallManager
	{
		// Token: 0x06002940 RID: 10560 RVA: 0x000295F7 File Offset: 0x000277F7
		[global::Cpp2ILInjected.Token(Token = "0x6002C08")]
		[global::Cpp2ILInjected.Address(RVA = "0x1189444", Offset = "0x1189444", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LocalUserGameState), Member = "get_waterfallManager", ReturnType = typeof(WaterfallManager))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "Initialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_Configuration", ReturnType = typeof(Preferences))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Preferences), Member = "add_OnLoad", MemberParameters = new object[] { typeof(Action<Preferences>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public WaterfallManager()
		{
			throw null;
		}

		// Token: 0x06002941 RID: 10561 RVA: 0x000295FA File Offset: 0x000277FA
		[global::Cpp2ILInjected.Token(Token = "0x6002C09")]
		[global::Cpp2ILInjected.Address(RVA = "0x118953C", Offset = "0x118953C", Length = "0x1C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Initializers.AssetInitializer.<LoadTextures_InSteps>d__11", Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssetInitializer), Member = "LoadTextures", MemberParameters = new object[] { typeof(AssetRequestMode) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public void LoadContent()
		{
			throw null;
		}

		// Token: 0x06002942 RID: 10562 RVA: 0x000295FD File Offset: 0x000277FD
		[global::Cpp2ILInjected.Token(Token = "0x6002C0A")]
		[global::Cpp2ILInjected.Address(RVA = "0x11896FC", Offset = "0x11896FC", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTile_LiquidBehindTile", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool),
			typeof(int),
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(TileDrawInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public bool CheckForWaterfall(int i, int j)
		{
			throw null;
		}

		// Token: 0x06002943 RID: 10563 RVA: 0x00029600 File Offset: 0x00027800
		[global::Cpp2ILInjected.Token(Token = "0x6002C0B")]
		[global::Cpp2ILInjected.Address(RVA = "0x118974C", Offset = "0x118974C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "FinaliseOnMainThread", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void Reset()
		{
			throw null;
		}

		// Token: 0x06002944 RID: 10564 RVA: 0x00029603 File Offset: 0x00027803
		[global::Cpp2ILInjected.Token(Token = "0x6002C0C")]
		[global::Cpp2ILInjected.Address(RVA = "0x118975C", Offset = "0x118975C", Length = "0x804")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawCapture", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(CaptureSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gfxQuality", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gameMenu", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenWidth", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenHeight", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "SolidTile", MemberParameters = new object[]
		{
			typeof(short),
			typeof(ushort)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "SolidTile", MemberParameters = new object[] { typeof(Tile) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "slope", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "lava", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "honey", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "shimmer", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public void FindWaterfalls(bool forced = false)
		{
			throw null;
		}

		// Token: 0x06002945 RID: 10565 RVA: 0x00029606 File Offset: 0x00027806
		[global::Cpp2ILInjected.Token(Token = "0x6002C0D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1189F60", Offset = "0x1189F60", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoUpdate_AnimateWaterfalls", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void UpdateFrame()
		{
			throw null;
		}

		// Token: 0x06002946 RID: 10566 RVA: 0x00029609 File Offset: 0x00027809
		[global::Cpp2ILInjected.Token(Token = "0x6002C0E")]
		[global::Cpp2ILInjected.Address(RVA = "0x118A02C", Offset = "0x118A02C", Length = "0x3BF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WaterfallManager), Member = "Draw", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gfxQuality", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenWidth", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenHeight", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_drewLava", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "AddLight", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "GetColor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WaterfallManager), Member = "TrySparkling", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LiquidRenderer), Member = "SetShimmerVertexColors", MemberParameters = new object[]
		{
			typeof(ref VertexColors),
			typeof(float),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(ref Rectangle),
			typeof(ref VertexColors),
			typeof(float),
			typeof(Vector2),
			typeof(float),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LiquidRenderer), Member = "SetShimmerVertexColors_Sparkle", MemberParameters = new object[]
		{
			typeof(ref VertexColors),
			typeof(float),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(ref Vector2),
			typeof(ref Rectangle),
			typeof(ref Color),
			typeof(float),
			typeof(Vector2),
			typeof(float),
			typeof(SpriteEffects)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle?), Member = ".ctor", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle?),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(float),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 95)]
		private void DrawWaterfall(SpriteBatch spriteBatch, int Style = 0, float Alpha = 1f)
		{
			throw null;
		}

		// Token: 0x06002947 RID: 10567 RVA: 0x0002960C File Offset: 0x0002780C
		[global::Cpp2ILInjected.Token(Token = "0x6002C0F")]
		[global::Cpp2ILInjected.Address(RVA = "0x118DE1C", Offset = "0x118DE1C", Length = "0x24C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LiquidRenderer), Member = "SetShimmerVertexColors", MemberParameters = new object[]
		{
			typeof(ref VertexColors),
			typeof(float),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(ref Rectangle),
			typeof(ref VertexColors),
			typeof(float),
			typeof(Vector2),
			typeof(float),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LiquidRenderer), Member = "SetShimmerVertexColors_Sparkle", MemberParameters = new object[]
		{
			typeof(ref VertexColors),
			typeof(float),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(ref Vector2),
			typeof(ref Rectangle),
			typeof(ref Color),
			typeof(float),
			typeof(Vector2),
			typeof(float),
			typeof(SpriteEffects)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private void DrawWaterfall(int waterfallType, int x, int y, float opacity, Vector2 position, ref Rectangle sourceRect, ref Color color, SpriteEffects effects)
		{
			throw null;
		}

		// Token: 0x06002948 RID: 10568 RVA: 0x0002960F File Offset: 0x0002780F
		[global::Cpp2ILInjected.Token(Token = "0x6002C10")]
		[global::Cpp2ILInjected.Address(RVA = "0x118DC1C", Offset = "0x118DC1C", Length = "0x200")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WaterfallManager), Member = "DrawWaterfall", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(int),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "NewDust", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private static void TrySparkling(int x, int y, int direction, Color aColor2)
		{
			throw null;
		}

		// Token: 0x06002949 RID: 10569 RVA: 0x00029612 File Offset: 0x00027812
		[global::Cpp2ILInjected.Token(Token = "0x6002C11")]
		[global::Cpp2ILInjected.Address(RVA = "0x118E068", Offset = "0x118E068", Length = "0x474")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawCapture", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(CaptureSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw_Waterfalls", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gameMenu", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_drewLava", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_liquidAlpha", ReturnType = typeof(float[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WaterfallManager), Member = "DrawWaterfall", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(int),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 26)]
		public void Draw(SpriteBatch spriteBatch)
		{
			throw null;
		}

		// Token: 0x0600294A RID: 10570 RVA: 0x00029615 File Offset: 0x00027815
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6002C12")]
		[global::Cpp2ILInjected.Address(RVA = "0x118E4DC", Offset = "0x118E4DC", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static WaterfallManager()
		{
			throw null;
		}

		// Token: 0x0600294B RID: 10571 RVA: 0x00029618 File Offset: 0x00027818
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x6002C13")]
		[global::Cpp2ILInjected.Address(RVA = "0x118E544", Offset = "0x118E544", Length = "0x10E0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Preferences[]), Member = "Get", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private void <.ctor>b__21_0(Preferences preferences)
		{
			throw null;
		}

		// Token: 0x04002FC7 RID: 12231
		[global::Cpp2ILInjected.Token(Token = "0x40037C1")]
		private const int minWet = 160;

		// Token: 0x04002FC8 RID: 12232
		[global::Cpp2ILInjected.Token(Token = "0x40037C2")]
		private const int maxWaterfallCountDefault = 1000;

		// Token: 0x04002FC9 RID: 12233
		[global::Cpp2ILInjected.Token(Token = "0x40037C3")]
		private const int maxLength = 100;

		// Token: 0x04002FCA RID: 12234
		[global::Cpp2ILInjected.Token(Token = "0x40037C4")]
		private const int maxTypes = 26;

		// Token: 0x04002FCB RID: 12235
		[global::Cpp2ILInjected.Token(Token = "0x40037C5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public int maxWaterfallCount;

		// Token: 0x04002FCC RID: 12236
		[global::Cpp2ILInjected.Token(Token = "0x40037C6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private int qualityMax;

		// Token: 0x04002FCD RID: 12237
		[global::Cpp2ILInjected.Token(Token = "0x40037C7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int currentMax;

		// Token: 0x04002FCE RID: 12238
		[global::Cpp2ILInjected.Token(Token = "0x40037C8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private WaterfallManager.WaterfallData[] waterfalls;

		// Token: 0x04002FCF RID: 12239
		[global::Cpp2ILInjected.Token(Token = "0x40037C9")]
		private static Asset<Texture2D>[] waterfallTexture;

		// Token: 0x04002FD0 RID: 12240
		[global::Cpp2ILInjected.Token(Token = "0x40037CA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private int wFallFrCounter;

		// Token: 0x04002FD1 RID: 12241
		[global::Cpp2ILInjected.Token(Token = "0x40037CB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		private int regularFrame;

		// Token: 0x04002FD2 RID: 12242
		[global::Cpp2ILInjected.Token(Token = "0x40037CC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private int wFallFrCounter2;

		// Token: 0x04002FD3 RID: 12243
		[global::Cpp2ILInjected.Token(Token = "0x40037CD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		private int slowFrame;

		// Token: 0x04002FD4 RID: 12244
		[global::Cpp2ILInjected.Token(Token = "0x40037CE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private int rainFrameCounter;

		// Token: 0x04002FD5 RID: 12245
		[global::Cpp2ILInjected.Token(Token = "0x40037CF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		private int rainFrameForeground;

		// Token: 0x04002FD6 RID: 12246
		[global::Cpp2ILInjected.Token(Token = "0x40037D0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private int rainFrameBackground;

		// Token: 0x04002FD7 RID: 12247
		[global::Cpp2ILInjected.Token(Token = "0x40037D1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		private int snowFrameCounter;

		// Token: 0x04002FD8 RID: 12248
		[global::Cpp2ILInjected.Token(Token = "0x40037D2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private int snowFrameForeground;

		// Token: 0x04002FD9 RID: 12249
		[global::Cpp2ILInjected.Token(Token = "0x40037D3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
		private int findWaterfallCount;

		// Token: 0x04002FDA RID: 12250
		[global::Cpp2ILInjected.Token(Token = "0x40037D4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private int waterfallDist;

		// Token: 0x04002FDB RID: 12251
		[global::Cpp2ILInjected.Token(Token = "0x40037D5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
		private VertexColors shimmerWaterFallColours;

		// Token: 0x02000877 RID: 2167
		[global::Cpp2ILInjected.Token(Token = "0x200046F")]
		public struct WaterfallData
		{
			// Token: 0x04007FB0 RID: 32688
			[global::Cpp2ILInjected.Token(Token = "0x40037D6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int x;

			// Token: 0x04007FB1 RID: 32689
			[global::Cpp2ILInjected.Token(Token = "0x40037D7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
			public int y;

			// Token: 0x04007FB2 RID: 32690
			[global::Cpp2ILInjected.Token(Token = "0x40037D8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public int type;

			// Token: 0x04007FB3 RID: 32691
			[global::Cpp2ILInjected.Token(Token = "0x40037D9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
			public int stopAtStep;
		}
	}
}
