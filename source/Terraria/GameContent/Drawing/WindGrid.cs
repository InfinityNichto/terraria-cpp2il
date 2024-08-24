using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.Graphics;

namespace Terraria.GameContent.Drawing
{
	// Token: 0x0200066B RID: 1643
	[global::Cpp2ILInjected.Token(Token = "0x20009EE")]
	public class WindGrid
	{
		// Token: 0x060040D1 RID: 16593 RVA: 0x0002D950 File Offset: 0x0002BB50
		[global::Cpp2ILInjected.Token(Token = "0x6004B52")]
		[global::Cpp2ILInjected.Address(RVA = "0x8A6228", Offset = "0x8A6228", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "EnsureWindGridSize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void SetSize(int targetWidth, int targetHeight)
		{
			throw null;
		}

		// Token: 0x060040D2 RID: 16594 RVA: 0x0002D953 File Offset: 0x0002BB53
		[global::Cpp2ILInjected.Token(Token = "0x6004B53")]
		[global::Cpp2ILInjected.Address(RVA = "0x8A6358", Offset = "0x8A6358", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_SettingsEnabled_TilesSwayInWind", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Update()
		{
			throw null;
		}

		// Token: 0x060040D3 RID: 16595 RVA: 0x0002D956 File Offset: 0x0002BB56
		[global::Cpp2ILInjected.Token(Token = "0x6004B54")]
		[global::Cpp2ILInjected.Address(RVA = "0x8A6514", Offset = "0x8A6514", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "GetWindGridPush", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "GetWindGridPush2Axis", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(ref float),
			typeof(ref float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "GetWindGridPushComplex", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "GetHighestWindGridPushComplex", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		public void GetWindTime(int tileX, int tileY, int timeThreshold, out int windTimeLeft, out int directionX, out int directionY)
		{
			throw null;
		}

		// Token: 0x060040D4 RID: 16596 RVA: 0x0002D959 File Offset: 0x0002BB59
		[global::Cpp2ILInjected.Token(Token = "0x6004B55")]
		[global::Cpp2ILInjected.Address(RVA = "0x8A62BC", Offset = "0x8A62BC", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "GetLength", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void ResizeGrid()
		{
			throw null;
		}

		// Token: 0x060040D5 RID: 16597 RVA: 0x0002D95C File Offset: 0x0002BB5C
		[global::Cpp2ILInjected.Token(Token = "0x6004B56")]
		[global::Cpp2ILInjected.Address(RVA = "0x8A6578", Offset = "0x8A6578", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void SetWindTime(int tileX, int tileY, int directionX, int directionY)
		{
			throw null;
		}

		// Token: 0x060040D6 RID: 16598 RVA: 0x0002D95F File Offset: 0x0002BB5F
		[global::Cpp2ILInjected.Token(Token = "0x6004B57")]
		[global::Cpp2ILInjected.Address(RVA = "0x8A63D0", Offset = "0x8A63D0", Length = "0x144")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetClient", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WindGrid), Member = "ScanPlayer", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private void ScanPlayers()
		{
			throw null;
		}

		// Token: 0x060040D7 RID: 16599 RVA: 0x0002D962 File Offset: 0x0002BB62
		[global::Cpp2ILInjected.Token(Token = "0x6004B58")]
		[global::Cpp2ILInjected.Address(RVA = "0x8A65BC", Offset = "0x8A65BC", Length = "0x3B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WindGrid), Member = "ScanPlayers", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_Camera", ReturnType = typeof(Camera))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "get_UnscaledSize", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "CenteredRectangle", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Hitbox", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Intersects", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "HasNaNs", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Sign", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_BottomRight", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Collision), Member = "GetTilesIn", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(List<Point>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Point>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Point>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Point>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		private void ScanPlayer(int i)
		{
			throw null;
		}

		// Token: 0x060040D8 RID: 16600 RVA: 0x0002D965 File Offset: 0x0002BB65
		[global::Cpp2ILInjected.Token(Token = "0x6004B59")]
		[global::Cpp2ILInjected.Address(RVA = "0x8A696C", Offset = "0x8A696C", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LocalUserGameState), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public WindGrid()
		{
			throw null;
		}

		// Token: 0x060040D9 RID: 16601 RVA: 0x0002D968 File Offset: 0x0002BB68
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6004B5A")]
		[global::Cpp2ILInjected.Address(RVA = "0x8A69E8", Offset = "0x8A69E8", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Point>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static WindGrid()
		{
			throw null;
		}

		// Token: 0x04006D7C RID: 28028
		[global::Cpp2ILInjected.Token(Token = "0x40085A3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private WindGrid.WindCoord[,] _grid;

		// Token: 0x04006D7D RID: 28029
		[global::Cpp2ILInjected.Token(Token = "0x40085A4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int _width;

		// Token: 0x04006D7E RID: 28030
		[global::Cpp2ILInjected.Token(Token = "0x40085A5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private int _height;

		// Token: 0x04006D7F RID: 28031
		[global::Cpp2ILInjected.Token(Token = "0x40085A6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int _gameTime;

		// Token: 0x04006D80 RID: 28032
		[global::Cpp2ILInjected.Token(Token = "0x40085A7")]
		private static List<Point> points;

		// Token: 0x02000A62 RID: 2658
		[global::Cpp2ILInjected.Token(Token = "0x20009EF")]
		private struct WindCoord
		{
			// Token: 0x04008E40 RID: 36416
			[global::Cpp2ILInjected.Token(Token = "0x40085A8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int Time;

			// Token: 0x04008E41 RID: 36417
			[global::Cpp2ILInjected.Token(Token = "0x40085A9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
			public int DirectionX;

			// Token: 0x04008E42 RID: 36418
			[global::Cpp2ILInjected.Token(Token = "0x40085AA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public int DirectionY;
		}
	}
}
