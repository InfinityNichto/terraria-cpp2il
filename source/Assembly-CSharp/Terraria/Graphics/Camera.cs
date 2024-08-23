using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent.Drawing;
using Terraria.GameContent.Golf;
using Terraria.Graphics.Capture;
using Terraria.Graphics.Light;
using Terraria.Graphics.Renderers;

namespace Terraria.Graphics
{
	// Token: 0x020004DC RID: 1244
	[global::Cpp2ILInjected.Token(Token = "0x2000731")]
	public class Camera
	{
		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x06003689 RID: 13961 RVA: 0x0002BBE0 File Offset: 0x00029DE0
		[global::Cpp2ILInjected.Token(Token = "0x1700076C")]
		public Vector2 UnscaledPosition
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003CEA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1498A24", Offset = "0x1498A24", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "GetAreaToLight", MemberParameters = new object[]
			{
				typeof(ref int),
				typeof(ref int),
				typeof(ref int),
				typeof(ref int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Camera), Member = "get_Center", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyPlayerRenderer), Member = "DrawPlayerStoned", MemberParameters = new object[]
			{
				typeof(Camera),
				typeof(Player),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyPlayerRenderer), Member = "DrawGhost", MemberParameters = new object[]
			{
				typeof(Camera),
				typeof(Player),
				typeof(Vector2),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.SkyEntity", Member = "CommonDraw", MemberParameters = new object[]
			{
				typeof(SpriteBatch),
				typeof(float),
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.SkyEntity", Member = "Helper_GetOpacityWithAccountingForOceanWaterLine", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "PreparePaintForTilesOnScreen", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawLiquidBehindTiles", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "Draw", MemberParameters = new object[]
			{
				typeof(bool),
				typeof(bool),
				typeof(bool),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "EnsureWindGridSize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTrees", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawGrass", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawAnyDirectionalGrass", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawMultiTileGrass", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawMultiTileVines", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawVines", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawReverseVines", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FancyGolfPredictionLine), Member = "Draw", MemberParameters = new object[]
			{
				typeof(Camera),
				typeof(SpriteBatch),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 22)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenPosition", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x0600368A RID: 13962 RVA: 0x0002BBE3 File Offset: 0x00029DE3
		[global::Cpp2ILInjected.Token(Token = "0x1700076D")]
		public Vector2 UnscaledSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003CEB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1498A74", Offset = "0x1498A74", Length = "0x7C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawInterface_GolfBallIndicator", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawCapture", MemberParameters = new object[]
			{
				typeof(Rectangle),
				typeof(CaptureSettings)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "GetAreaToLight", MemberParameters = new object[]
			{
				typeof(ref int),
				typeof(ref int),
				typeof(ref int),
				typeof(ref int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Camera), Member = "get_Center", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyLighting), Member = "Rebuild", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyLighting), Member = "ProcessArea", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WindGrid), Member = "ScanPlayer", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenWidth", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenHeight", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x0600368B RID: 13963 RVA: 0x0002BBE6 File Offset: 0x00029DE6
		[global::Cpp2ILInjected.Token(Token = "0x1700076E")]
		public Vector2 ScaledPosition
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003CEC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1498AF0", Offset = "0x1498AF0", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "snowing", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawProj", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawBackground", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "OldDrawBackground", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "GetAreaToLight", MemberParameters = new object[]
			{
				typeof(ref int),
				typeof(ref int),
				typeof(ref int),
				typeof(ref int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "PreparePaintForTilesOnScreen", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "Draw", MemberParameters = new object[]
			{
				typeof(bool),
				typeof(bool),
				typeof(bool),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenPosition", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x0600368C RID: 13964 RVA: 0x0002BBE9 File Offset: 0x00029DE9
		[global::Cpp2ILInjected.Token(Token = "0x1700076F")]
		public Vector2 ScaledSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003CED")]
			[global::Cpp2ILInjected.Address(RVA = "0x1498B40", Offset = "0x1498B40", Length = "0x7C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "snowing", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawProj", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "GetAreaToLight", MemberParameters = new object[]
			{
				typeof(ref int),
				typeof(ref int),
				typeof(ref int),
				typeof(ref int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenWidth", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenHeight", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x0600368D RID: 13965 RVA: 0x0002BBEC File Offset: 0x00029DEC
		[global::Cpp2ILInjected.Token(Token = "0x17000770")]
		public RasterizerState Rasterizer
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003CEE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1498BBC", Offset = "0x1498BBC", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x0600368E RID: 13966 RVA: 0x0002BBEF File Offset: 0x00029DEF
		[global::Cpp2ILInjected.Token(Token = "0x17000771")]
		public SamplerState Sampler
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003CEF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1498C14", Offset = "0x1498C14", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyPlayerRenderer), Member = "DrawPlayerFull", MemberParameters = new object[]
			{
				typeof(Camera),
				typeof(Player)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReturnGatePlayerRenderer), Member = "DrawReturnGateInWorld", MemberParameters = new object[]
			{
				typeof(Camera),
				typeof(Player)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_DefaultSamplerState", ReturnType = typeof(SamplerState))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x0600368F RID: 13967 RVA: 0x0002BBF2 File Offset: 0x00029DF2
		[global::Cpp2ILInjected.Token(Token = "0x17000772")]
		public SpriteViewMatrix GameViewMatrix
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003CF0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1498C64", Offset = "0x1498C64", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x06003690 RID: 13968 RVA: 0x0002BBF5 File Offset: 0x00029DF5
		[global::Cpp2ILInjected.Token(Token = "0x17000773")]
		public SpriteBatch SpriteBatch
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003CF1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1498CBC", Offset = "0x1498CBC", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x06003691 RID: 13969 RVA: 0x0002BBF8 File Offset: 0x00029DF8
		[global::Cpp2ILInjected.Token(Token = "0x17000774")]
		public Vector2 Center
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003CF2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1498D14", Offset = "0x1498D14", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.SkyEntity", Member = "SetPositionInWorldBasedOnScreenSpace", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.SkyEntity", Member = "GetDrawPositionByDepth", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WindGrid), Member = "ScanPlayer", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "get_UnscaledPosition", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "get_UnscaledSize", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(float)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06003692 RID: 13970 RVA: 0x0002BBFB File Offset: 0x00029DFB
		[global::Cpp2ILInjected.Token(Token = "0x6003CF3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1498DB0", Offset = "0x1498DB0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LocalUserGameState), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public Camera()
		{
			throw null;
		}
	}
}
