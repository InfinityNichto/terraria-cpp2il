using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.GameContent.Drawing;
using Terraria.Graphics.Light;
using UnityEngine;

namespace Terraria
{
	// Token: 0x0200034D RID: 845
	[global::Cpp2ILInjected.Token(Token = "0x2000463")]
	public static class TimeLogger
	{
		// Token: 0x06002870 RID: 10352 RVA: 0x00029387 File Offset: 0x00027587
		[global::Cpp2ILInjected.Token(Token = "0x6002B2A")]
		[global::Cpp2ILInjected.Address(RVA = "0x117BB78", Offset = "0x117BB78", Length = "0x8A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "Initialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stopwatch), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 59)]
		public static void Initialize()
		{
			throw null;
		}

		// Token: 0x06002871 RID: 10353 RVA: 0x0002938A File Offset: 0x0002758A
		[global::Cpp2ILInjected.Token(Token = "0x6002B2B")]
		[global::Cpp2ILInjected.Address(RVA = "0x117C418", Offset = "0x117C418", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "NewText", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte),
			typeof(byte),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void Start()
		{
			throw null;
		}

		// Token: 0x06002872 RID: 10354 RVA: 0x0002938D File Offset: 0x0002758D
		[global::Cpp2ILInjected.Token(Token = "0x6002B2C")]
		[global::Cpp2ILInjected.Address(RVA = "0x117C4CC", Offset = "0x117C4CC", Length = "0x40C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_SavePath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(FileMode)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GZipStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(CompressionMode)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamWriter), Member = ".ctor", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "AppendLine", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stopwatch), Member = "Restart", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stopwatch), Member = "get_Elapsed", ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "get_TotalMilliseconds", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "NewText", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte),
			typeof(byte),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 31)]
		public static void NewDrawFrame()
		{
			throw null;
		}

		// Token: 0x06002873 RID: 10355 RVA: 0x00029390 File Offset: 0x00027590
		[global::Cpp2ILInjected.Token(Token = "0x6002B2D")]
		[global::Cpp2ILInjected.Address(RVA = "0x117C8D8", Offset = "0x117C8D8", Length = "0x27C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "AppendLine", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "AppendLine", ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Clear", ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "NewText", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte),
			typeof(byte),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stopwatch), Member = "Stop", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static void EndDrawFrame()
		{
			throw null;
		}

		// Token: 0x06002874 RID: 10356 RVA: 0x00029393 File Offset: 0x00027593
		[global::Cpp2ILInjected.Token(Token = "0x6002B2E")]
		[global::Cpp2ILInjected.Address(RVA = "0x117CB54", Offset = "0x117CB54", Length = "0x1A4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeLogger), Member = "RenderTime", MemberParameters = new object[]
		{
			typeof(int),
			typeof(double)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeLogger), Member = "DrawTime", MemberParameters = new object[]
		{
			typeof(int),
			typeof(double)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeLogger), Member = "LightingTime", MemberParameters = new object[]
		{
			typeof(int),
			typeof(double)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeLogger), Member = "DetailedDrawTime", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "AppendLine", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static void UpdateTime(TimeLogger.TimeLogData[] times, int type, double time)
		{
			throw null;
		}

		// Token: 0x06002875 RID: 10357 RVA: 0x00029396 File Offset: 0x00027596
		[global::Cpp2ILInjected.Token(Token = "0x6002B2F")]
		[global::Cpp2ILInjected.Address(RVA = "0x117CCF8", Offset = "0x117CCF8", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeLogger), Member = "UpdateTime", MemberParameters = new object[]
		{
			typeof(TimeLogger.TimeLogData[]),
			typeof(int),
			typeof(double)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static void RenderTime(int renderType, double timeElapsed)
		{
			throw null;
		}

		// Token: 0x06002876 RID: 10358 RVA: 0x00029399 File Offset: 0x00027599
		[global::Cpp2ILInjected.Token(Token = "0x6002B30")]
		[global::Cpp2ILInjected.Address(RVA = "0x117CD78", Offset = "0x117CD78", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawInterface_18_DiagnoseVideo", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static float GetRenderTime(int renderType)
		{
			throw null;
		}

		// Token: 0x06002877 RID: 10359 RVA: 0x0002939C File Offset: 0x0002759C
		[global::Cpp2ILInjected.Token(Token = "0x6002B31")]
		[global::Cpp2ILInjected.Address(RVA = "0x117CDD4", Offset = "0x117CDD4", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawInterface_18_DiagnoseVideo", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static float GetRenderMax(int renderType)
		{
			throw null;
		}

		// Token: 0x06002878 RID: 10360 RVA: 0x0002939F File Offset: 0x0002759F
		[global::Cpp2ILInjected.Token(Token = "0x6002B32")]
		[global::Cpp2ILInjected.Address(RVA = "0x117CE30", Offset = "0x117CE30", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawBackground", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "OldDrawBackground", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawLiquid", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(int),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawBlack", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "Draw", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WallDrawing), Member = "DrawWalls", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeLogger), Member = "UpdateTime", MemberParameters = new object[]
		{
			typeof(TimeLogger.TimeLogData[]),
			typeof(int),
			typeof(double)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static void DrawTime(int drawType, double timeElapsed)
		{
			throw null;
		}

		// Token: 0x06002879 RID: 10361 RVA: 0x000293A2 File Offset: 0x000275A2
		[global::Cpp2ILInjected.Token(Token = "0x6002B33")]
		[global::Cpp2ILInjected.Address(RVA = "0x117CEB0", Offset = "0x117CEB0", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawInterface_18_DiagnoseVideo", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static float GetDrawTime(int drawType)
		{
			throw null;
		}

		// Token: 0x0600287A RID: 10362 RVA: 0x000293A5 File Offset: 0x000275A5
		[global::Cpp2ILInjected.Token(Token = "0x6002B34")]
		[global::Cpp2ILInjected.Address(RVA = "0x117CF0C", Offset = "0x117CF0C", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawInterface_18_DiagnoseVideo", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static float GetDrawTotal()
		{
			throw null;
		}

		// Token: 0x0600287B RID: 10363 RVA: 0x000293A8 File Offset: 0x000275A8
		[global::Cpp2ILInjected.Token(Token = "0x6002B35")]
		[global::Cpp2ILInjected.Address(RVA = "0x117CF8C", Offset = "0x117CF8C", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyLighting), Member = "PreRenderPhase", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightingEngine), Member = "ProcessArea", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeLogger), Member = "UpdateTime", MemberParameters = new object[]
		{
			typeof(TimeLogger.TimeLogData[]),
			typeof(int),
			typeof(double)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static void LightingTime(int lightingType, double timeElapsed)
		{
			throw null;
		}

		// Token: 0x0600287C RID: 10364 RVA: 0x000293AB File Offset: 0x000275AB
		[global::Cpp2ILInjected.Token(Token = "0x6002B36")]
		[global::Cpp2ILInjected.Address(RVA = "0x117D00C", Offset = "0x117D00C", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawInterface_18_DiagnoseVideo", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static float GetLightingTime(int lightingType)
		{
			throw null;
		}

		// Token: 0x0600287D RID: 10365 RVA: 0x000293AE File Offset: 0x000275AE
		[global::Cpp2ILInjected.Token(Token = "0x6002B37")]
		[global::Cpp2ILInjected.Address(RVA = "0x117D068", Offset = "0x117D068", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawInterface_18_DiagnoseVideo", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static float GetLightingTotal()
		{
			throw null;
		}

		// Token: 0x0600287E RID: 10366 RVA: 0x000293B1 File Offset: 0x000275B1
		[global::Cpp2ILInjected.Token(Token = "0x6002B38")]
		[global::Cpp2ILInjected.Address(RVA = "0x117D0E8", Offset = "0x117D0E8", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "RenderBackground", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "RenderTiles", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "RenderTiles2", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "RenderWater", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "RenderBlack", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "RenderWalls", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw_WallsTilesNPCs", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw_Tiles_NonSolid", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "GetScreenDrawArea", MemberParameters = new object[]
		{
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 16)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stopwatch), Member = "get_Elapsed", ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "get_TotalMilliseconds", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static void DetailedDrawReset()
		{
			throw null;
		}

		// Token: 0x0600287F RID: 10367 RVA: 0x000293B4 File Offset: 0x000275B4
		[global::Cpp2ILInjected.Token(Token = "0x6002B39")]
		[global::Cpp2ILInjected.Address(RVA = "0x117D154", Offset = "0x117D154", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 37)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stopwatch), Member = "get_Elapsed", ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "get_TotalMilliseconds", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeLogger), Member = "UpdateTime", MemberParameters = new object[]
		{
			typeof(TimeLogger.TimeLogData[]),
			typeof(int),
			typeof(double)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static void DetailedDrawTime(int detailedDrawType)
		{
			throw null;
		}

		// Token: 0x06002880 RID: 10368 RVA: 0x000293B7 File Offset: 0x000275B7
		[global::Cpp2ILInjected.Token(Token = "0x6002B3A")]
		[global::Cpp2ILInjected.Address(RVA = "0x117D1F4", Offset = "0x117D1F4", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static float GetDetailedDrawTime(int detailedDrawType)
		{
			throw null;
		}

		// Token: 0x06002881 RID: 10369 RVA: 0x000293BA File Offset: 0x000275BA
		[global::Cpp2ILInjected.Token(Token = "0x6002B3B")]
		[global::Cpp2ILInjected.Address(RVA = "0x117D250", Offset = "0x117D250", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static float GetDetailedDrawTotal()
		{
			throw null;
		}

		// Token: 0x06002882 RID: 10370 RVA: 0x000293BD File Offset: 0x000275BD
		[global::Cpp2ILInjected.Token(Token = "0x6002B3C")]
		[global::Cpp2ILInjected.Address(RVA = "0x117D2DC", Offset = "0x117D2DC", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "AppendLine", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void MenuDrawTime(double timeElapsed)
		{
			throw null;
		}

		// Token: 0x06002883 RID: 10371 RVA: 0x000293C0 File Offset: 0x000275C0
		[global::Cpp2ILInjected.Token(Token = "0x6002B3D")]
		[global::Cpp2ILInjected.Address(RVA = "0x117D39C", Offset = "0x117D39C", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "AppendLine", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void SplashDrawTime(double timeElapsed)
		{
			throw null;
		}

		// Token: 0x06002884 RID: 10372 RVA: 0x000293C3 File Offset: 0x000275C3
		[global::Cpp2ILInjected.Token(Token = "0x6002B3E")]
		[global::Cpp2ILInjected.Address(RVA = "0x117D45C", Offset = "0x117D45C", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "AppendLine", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void MapDrawTime(double timeElapsed)
		{
			throw null;
		}

		// Token: 0x06002885 RID: 10373 RVA: 0x000293C6 File Offset: 0x000275C6
		[global::Cpp2ILInjected.Token(Token = "0x6002B3F")]
		[global::Cpp2ILInjected.Address(RVA = "0x117D51C", Offset = "0x117D51C", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 25)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "AppendLine", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void DrawException(Exception e)
		{
			throw null;
		}

		// Token: 0x04002FAC RID: 12204
		[global::Cpp2ILInjected.Token(Token = "0x400378C")]
		private static StreamWriter logWriter;

		// Token: 0x04002FAD RID: 12205
		[global::Cpp2ILInjected.Token(Token = "0x400378D")]
		private static StringBuilder logBuilder;

		// Token: 0x04002FAE RID: 12206
		[global::Cpp2ILInjected.Token(Token = "0x400378E")]
		private static int framesToLog;

		// Token: 0x04002FAF RID: 12207
		[global::Cpp2ILInjected.Token(Token = "0x400378F")]
		private static int currentFrame;

		// Token: 0x04002FB0 RID: 12208
		[global::Cpp2ILInjected.Token(Token = "0x4003790")]
		private static bool startLoggingNextFrame;

		// Token: 0x04002FB1 RID: 12209
		[global::Cpp2ILInjected.Token(Token = "0x4003791")]
		private static bool endLoggingThisFrame;

		// Token: 0x04002FB2 RID: 12210
		[global::Cpp2ILInjected.Token(Token = "0x4003792")]
		private static bool currentlyLogging;

		// Token: 0x04002FB3 RID: 12211
		[global::Cpp2ILInjected.Token(Token = "0x4003793")]
		private static Stopwatch detailedDrawTimer;

		// Token: 0x04002FB4 RID: 12212
		[global::Cpp2ILInjected.Token(Token = "0x4003794")]
		private static double lastDetailedDrawTime;

		// Token: 0x04002FB5 RID: 12213
		[global::Cpp2ILInjected.Token(Token = "0x4003795")]
		private static TimeLogger.TimeLogData[] renderTimes;

		// Token: 0x04002FB6 RID: 12214
		[global::Cpp2ILInjected.Token(Token = "0x4003796")]
		private static TimeLogger.TimeLogData[] drawTimes;

		// Token: 0x04002FB7 RID: 12215
		[global::Cpp2ILInjected.Token(Token = "0x4003797")]
		private static TimeLogger.TimeLogData[] lightingTimes;

		// Token: 0x04002FB8 RID: 12216
		[global::Cpp2ILInjected.Token(Token = "0x4003798")]
		private static TimeLogger.TimeLogData[] detailedDrawTimes;

		// Token: 0x04002FB9 RID: 12217
		[global::Cpp2ILInjected.Token(Token = "0x4003799")]
		private const int maxTimeDelay = 100;

		// Token: 0x0200086F RID: 2159
		[global::Cpp2ILInjected.Token(Token = "0x2000464")]
		private struct TimeLogData
		{
			// Token: 0x04007F96 RID: 32662
			[global::Cpp2ILInjected.Token(Token = "0x400379A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public float time;

			// Token: 0x04007F97 RID: 32663
			[global::Cpp2ILInjected.Token(Token = "0x400379B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
			public float timeMax;

			// Token: 0x04007F98 RID: 32664
			[global::Cpp2ILInjected.Token(Token = "0x400379C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public int resetMaxTime;

			// Token: 0x04007F99 RID: 32665
			[global::Cpp2ILInjected.Token(Token = "0x400379D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
			public bool usedLastDraw;

			// Token: 0x04007F9A RID: 32666
			[global::Cpp2ILInjected.Token(Token = "0x400379E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public string logText;
		}
	}
}
