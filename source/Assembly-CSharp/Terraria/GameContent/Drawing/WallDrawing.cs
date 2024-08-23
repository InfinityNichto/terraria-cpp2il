using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Graphics;
using Terraria.Graphics.Capture;
using Terraria.Graphics.Light;
using Unity.IL2CPP.CompilerServices;

namespace Terraria.GameContent.Drawing
{
	// Token: 0x0200066A RID: 1642
	[global::Cpp2ILInjected.Token(Token = "0x20009EB")]
	public class WallDrawing
	{
		// Token: 0x060040C7 RID: 16583 RVA: 0x0002D932 File Offset: 0x0002BB32
		[global::Cpp2ILInjected.Token(Token = "0x6004B44")]
		[global::Cpp2ILInjected.Address(RVA = "0x8A3A18", Offset = "0x8A3A18", Length = "0x25C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "Initialize_AlmostEverything", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexColors), Member = ".ctor", MemberParameters = new object[] { typeof(Color) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadLocal<>), Member = ".ctor", MemberParameters = new object[] { "System.Func`1<T>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public WallDrawing(TilePaintSystemV2 paintSystem)
		{
			throw null;
		}

		// Token: 0x060040C8 RID: 16584 RVA: 0x0002D935 File Offset: 0x0002BB35
		[global::Cpp2ILInjected.Token(Token = "0x6004B45")]
		[global::Cpp2ILInjected.Address(RVA = "0x8A3C74", Offset = "0x8A3C74", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoUpdateInWorld", MemberParameters = new object[] { typeof(Stopwatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "ShouldShowInvisibleWalls", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void Update()
		{
			throw null;
		}

		// Token: 0x060040C9 RID: 16585 RVA: 0x0002D938 File Offset: 0x0002BB38
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6004B46")]
		[global::Cpp2ILInjected.Address(RVA = "0x8A3CF0", Offset = "0x8A3CF0", Length = "0x13CC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadedRenderManager.RenderThreadInstance), Member = "DrawThread", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WallDrawing), Member = "DrawWalls", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WallDrawing), Member = "DrawWallsThreaded", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TilePaintSystemV2), Member = "GetWallEffect", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(EffectPass))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_UnderworldLayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadLocal<>), Member = "get_Value", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "get_NotRetro", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gfxQuality", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "GetLightMap", MemberParameters = new object[] { typeof(ref Rectangle) }, ReturnType = typeof(LightMap))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Right", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Bottom", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WallDrawing), Member = "GetWallDrawTexture", MemberParameters = new object[]
		{
			typeof(ushort),
			typeof(byte),
			typeof(ref Texture2D),
			typeof(ref EffectPass)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(ref Vector2),
			typeof(ref Rectangle),
			typeof(ref Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(ref Vector2),
			typeof(ref Rectangle),
			typeof(ref VertexColors)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 32)]
		public void DrawWalls(Vector2 screenPosition, Vector2 offSet, int firstTileX, int firstTileY, int lastTileX, int lastTileY)
		{
			throw null;
		}

		// Token: 0x060040CA RID: 16586 RVA: 0x0002D93B File Offset: 0x0002BB3B
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6004B47")]
		[global::Cpp2ILInjected.Address(RVA = "0x8A5164", Offset = "0x8A5164", Length = "0x3F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawCapture", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(CaptureSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawWalls", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "RenderWalls", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw_WallsAndBlacks", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenWidth", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenHeight", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gfxQuality", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stopwatch), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stopwatch), Member = "Start", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadLocal<>), Member = "get_Value", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WallDrawing), Member = "DrawWallsThreaded", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WallDrawing), Member = "WaitDrawThreads", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WallDrawing), Member = "DrawWalls", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalPlayer", ReturnType = typeof(Player))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "DrawTileCracks", MemberParameters = new object[]
		{
			typeof(int),
			typeof(HitTile)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stopwatch), Member = "get_Elapsed", ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "get_TotalMilliseconds", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeLogger), Member = "DrawTime", MemberParameters = new object[]
		{
			typeof(int),
			typeof(double)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public void DrawWalls()
		{
			throw null;
		}

		// Token: 0x060040CB RID: 16587 RVA: 0x0002D93E File Offset: 0x0002BB3E
		[global::Cpp2ILInjected.Token(Token = "0x6004B48")]
		[global::Cpp2ILInjected.Address(RVA = "0x8A5554", Offset = "0x8A5554", Length = "0x524")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WallDrawing), Member = "DrawWalls", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "FlushBatches", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_Transform", ReturnType = typeof(Matrix))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Matrix?), Member = ".ctor", MemberParameters = new object[] { typeof(Matrix) }, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadedRenderManager), Member = "GetTilePartition", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadedRenderManager.RenderThreadInstance), Member = "DrawWalls", MemberParameters = new object[]
		{
			typeof(WallDrawing),
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WallDrawing), Member = "DrawWalls", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		private int DrawWallsThreaded(Vector2 screenPosition, Vector2 offSet, int firstTileX, int firstTileY, int lastTileX, int lastTileY)
		{
			throw null;
		}

		// Token: 0x060040CC RID: 16588 RVA: 0x0002D941 File Offset: 0x0002BB41
		[global::Cpp2ILInjected.Token(Token = "0x6004B49")]
		[global::Cpp2ILInjected.Address(RVA = "0x8A5DD8", Offset = "0x8A5DD8", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "End", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Flush", ReturnType = typeof(void))]
		private void ProcessBatchFinished(int index)
		{
			throw null;
		}

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x060040CD RID: 16589 RVA: 0x0002D944 File Offset: 0x0002BB44
		[global::Cpp2ILInjected.Token(Token = "0x1700086B")]
		private ThreadedRenderManager.BatchProcessCallback ProcessBatchFinishedCallback
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004B4A")]
			[global::Cpp2ILInjected.Address(RVA = "0x8A5E38", Offset = "0x8A5E38", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WallDrawing), Member = "WaitDrawThreads", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadedRenderManager.BatchProcessCallback), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060040CE RID: 16590 RVA: 0x0002D947 File Offset: 0x0002BB47
		[global::Cpp2ILInjected.Token(Token = "0x6004B4B")]
		[global::Cpp2ILInjected.Address(RVA = "0x8A5A78", Offset = "0x8A5A78", Length = "0x360")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WallDrawing), Member = "DrawWalls", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "End", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Flush", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WallDrawing), Member = "get_ProcessBatchFinishedCallback", ReturnType = typeof(ThreadedRenderManager.BatchProcessCallback))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadedRenderManager), Member = "WaitAndProcessInOrder", MemberParameters = new object[]
		{
			typeof(ThreadedRenderManager.BatchProcessCallback),
			typeof(int)
		}, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_Transform", ReturnType = typeof(Matrix))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Matrix?), Member = ".ctor", MemberParameters = new object[] { typeof(Matrix) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private void WaitDrawThreads(int numThreads)
		{
			throw null;
		}

		// Token: 0x060040CF RID: 16591 RVA: 0x0002D94A File Offset: 0x0002BB4A
		[global::Cpp2ILInjected.Token(Token = "0x6004B4C")]
		[global::Cpp2ILInjected.Address(RVA = "0x8A50BC", Offset = "0x8A50BC", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WallDrawing), Member = "DrawWalls", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void GetWallDrawTexture(ushort wallType, byte wallColor, out Texture2D drawTexture, out EffectPass pass)
		{
			throw null;
		}

		// Token: 0x060040D0 RID: 16592 RVA: 0x0002D94D File Offset: 0x0002BB4D
		[global::Cpp2ILInjected.Token(Token = "0x6004B4D")]
		[global::Cpp2ILInjected.Address(RVA = "0x8A5EB8", Offset = "0x8A5EB8", Length = "0x2B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "invisibleBlock", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_IsLoaded", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "blockType", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameX", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameY", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		protected bool FullTile(Tile tileCache, int x, int y)
		{
			throw null;
		}

		// Token: 0x04006D6F RID: 28015
		[global::Cpp2ILInjected.Token(Token = "0x4008591")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private TileData _tileArray;

		// Token: 0x04006D70 RID: 28016
		[global::Cpp2ILInjected.Token(Token = "0x4008592")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private TilePaintSystemV2 _paintSystem;

		// Token: 0x04006D71 RID: 28017
		[global::Cpp2ILInjected.Token(Token = "0x4008593")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private VertexColors _glowPaintColors;

		// Token: 0x04006D72 RID: 28018
		[global::Cpp2ILInjected.Token(Token = "0x4008594")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private Rectangle outlineLeftRect;

		// Token: 0x04006D73 RID: 28019
		[global::Cpp2ILInjected.Token(Token = "0x4008595")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private Rectangle outlineRightRect;

		// Token: 0x04006D74 RID: 28020
		[global::Cpp2ILInjected.Token(Token = "0x4008596")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private Rectangle outlineUpRect;

		// Token: 0x04006D75 RID: 28021
		[global::Cpp2ILInjected.Token(Token = "0x4008597")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private Rectangle outlineDownRect;

		// Token: 0x04006D76 RID: 28022
		[global::Cpp2ILInjected.Token(Token = "0x4008598")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private bool _shouldShowInvisibleWalls;

		// Token: 0x04006D77 RID: 28023
		[global::Cpp2ILInjected.Token(Token = "0x4008599")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private EffectPass[] WallEffects;

		// Token: 0x04006D78 RID: 28024
		[global::Cpp2ILInjected.Token(Token = "0x400859A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private ThreadedRenderManager _threadManager;

		// Token: 0x04006D79 RID: 28025
		[global::Cpp2ILInjected.Token(Token = "0x400859B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		public ThreadLocal<WallDrawing.WallDrawInfo> _currentWallDrawInfo;

		// Token: 0x04006D7A RID: 28026
		[global::Cpp2ILInjected.Token(Token = "0x400859C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private int drawThreadTest;

		// Token: 0x04006D7B RID: 28027
		[global::Cpp2ILInjected.Token(Token = "0x400859D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private ThreadedRenderManager.BatchProcessCallback _processBatchFinishedCallback;

		// Token: 0x02000A60 RID: 2656
		[global::Cpp2ILInjected.Token(Token = "0x20009EC")]
		public class WallDrawInfo
		{
			// Token: 0x060050A9 RID: 20649 RVA: 0x00030398 File Offset: 0x0002E598
			[global::Cpp2ILInjected.Token(Token = "0x6004B4E")]
			[global::Cpp2ILInjected.Address(RVA = "0x8A6168", Offset = "0x8A6168", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public WallDrawInfo()
			{
				throw null;
			}

			// Token: 0x04008E3B RID: 36411
			[global::Cpp2ILInjected.Token(Token = "0x400859E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public SpriteBatch wallSpriteBatch;

			// Token: 0x04008E3C RID: 36412
			[global::Cpp2ILInjected.Token(Token = "0x400859F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public SpriteBatch wallSpriteBatch2;

			// Token: 0x04008E3D RID: 36413
			[global::Cpp2ILInjected.Token(Token = "0x40085A0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public TileBatch wallTileBatch;
		}

		// Token: 0x02000A61 RID: 2657
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20009ED")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060050AA RID: 20650 RVA: 0x0003039B File Offset: 0x0002E59B
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6004B4F")]
			[global::Cpp2ILInjected.Address(RVA = "0x8A6170", Offset = "0x8A6170", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			// Token: 0x060050AB RID: 20651 RVA: 0x0003039E File Offset: 0x0002E59E
			[global::Cpp2ILInjected.Token(Token = "0x6004B50")]
			[global::Cpp2ILInjected.Address(RVA = "0x8A61CC", Offset = "0x8A61CC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			// Token: 0x060050AC RID: 20652 RVA: 0x000303A1 File Offset: 0x0002E5A1
			[global::Cpp2ILInjected.Token(Token = "0x6004B51")]
			[global::Cpp2ILInjected.Address(RVA = "0x8A61D4", Offset = "0x8A61D4", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal WallDrawing.WallDrawInfo <.ctor>b__0_0()
			{
				throw null;
			}

			// Token: 0x04008E3E RID: 36414
			[global::Cpp2ILInjected.Token(Token = "0x40085A1")]
			public static readonly WallDrawing.<>c <>9;

			// Token: 0x04008E3F RID: 36415
			[global::Cpp2ILInjected.Token(Token = "0x40085A2")]
			public static Func<WallDrawing.WallDrawInfo> <>9__0_0;
		}
	}
}
