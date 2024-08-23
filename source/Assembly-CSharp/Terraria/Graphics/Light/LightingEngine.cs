using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.Map;
using Terraria.Utilities;
using Unity.IL2CPP.CompilerServices;

namespace Terraria.Graphics.Light
{
	// Token: 0x0200050F RID: 1295
	[global::Cpp2ILInjected.Token(Token = "0x2000776")]
	public class LightingEngine : ILightingEngine
	{
		// Token: 0x060037F3 RID: 14323 RVA: 0x0002BFE2 File Offset: 0x0002A1E2
		[global::Cpp2ILInjected.Token(Token = "0x6003E91")]
		[global::Cpp2ILInjected.Address(RVA = "0x73DADC", Offset = "0x73DADC", Length = "0x154")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LocalUserGameState), Member = "get_NewEngine", ReturnType = typeof(LightingEngine))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<LightingEngine.PerFrameLight>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileLightScanner), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LightMap), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stopwatch), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public LightingEngine()
		{
			throw null;
		}

		// Token: 0x060037F4 RID: 14324 RVA: 0x0002BFE5 File Offset: 0x0002A1E5
		[global::Cpp2ILInjected.Token(Token = "0x6003E92")]
		[global::Cpp2ILInjected.Address(RVA = "0x73DE4C", Offset = "0x73DE4C", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void AddLight(int x, int y, Vector3 color)
		{
			throw null;
		}

		// Token: 0x060037F5 RID: 14325 RVA: 0x0002BFE8 File Offset: 0x0002A1E8
		[global::Cpp2ILInjected.Token(Token = "0x6003E93")]
		[global::Cpp2ILInjected.Address(RVA = "0x73DF60", Offset = "0x73DF60", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LightMap), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x060037F6 RID: 14326 RVA: 0x0002BFEB File Offset: 0x0002A1EB
		[global::Cpp2ILInjected.Token(Token = "0x6003E94")]
		[global::Cpp2ILInjected.Address(RVA = "0x73DFEC", Offset = "0x73DFEC", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public LightMap GetLightMap(out Rectangle lightMapRegion)
		{
			throw null;
		}

		// Token: 0x060037F7 RID: 14327 RVA: 0x0002BFEE File Offset: 0x0002A1EE
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6003E95")]
		[global::Cpp2ILInjected.Address(RVA = "0x73DFFC", Offset = "0x73DFFC", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Contains", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public Vector3 GetColor(int x, int y)
		{
			throw null;
		}

		// Token: 0x060037F8 RID: 14328 RVA: 0x0002BFF1 File Offset: 0x0002A1F1
		[global::Cpp2ILInjected.Token(Token = "0x6003E96")]
		[global::Cpp2ILInjected.Address(RVA = "0x73E114", Offset = "0x73E114", Length = "0x30C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_renderCount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_renderCount", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LightingEngine), Member = "SetState", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stopwatch), Member = "Start", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeLogger), Member = "LightingTime", MemberParameters = new object[]
		{
			typeof(int),
			typeof(double)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mapDelay", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mapDelay", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Inflate", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_SceneMetrics", ReturnType = typeof(SceneMetrics))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle?), Member = ".ctor", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalPlayer", ReturnType = typeof(Player))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2?), Member = ".ctor", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SceneMetrics), Member = "ScanAndExportToMain", MemberParameters = new object[] { typeof(SceneMetricsScanSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stopwatch), Member = "get_Elapsed", ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "get_TotalMilliseconds", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LightingEngine), Member = "ProcessScan", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LightingEngine), Member = "ProcessBlur", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LightMap), Member = "BlurPass", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "NextSeed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LightingEngine), Member = "Present", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LightingEngine), Member = "ExportToMiniMap", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stopwatch), Member = "Reset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public void ProcessArea(Rectangle area)
		{
			throw null;
		}

		// Token: 0x060037F9 RID: 14329 RVA: 0x0002BFF4 File Offset: 0x0002A1F4
		[global::Cpp2ILInjected.Token(Token = "0x6003E97")]
		[global::Cpp2ILInjected.Address(RVA = "0x73E420", Offset = "0x73E420", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightingEngine), Member = "ProcessArea", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_renderCount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void SetState()
		{
			throw null;
		}

		// Token: 0x060037FA RID: 14330 RVA: 0x0002BFF7 File Offset: 0x0002A1F7
		[global::Cpp2ILInjected.Token(Token = "0x6003E98")]
		[global::Cpp2ILInjected.Address(RVA = "0x73E684", Offset = "0x73E684", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightingEngine), Member = "ProcessArea", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Inflate", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LightMap), Member = "SetSize", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileLightScanner), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileLightScanner), Member = "ExportTo", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(LightMap)
		}, ReturnType = typeof(void))]
		private void ProcessScan(Rectangle area)
		{
			throw null;
		}

		// Token: 0x060037FB RID: 14331 RVA: 0x0002BFFA File Offset: 0x0002A1FA
		[global::Cpp2ILInjected.Token(Token = "0x6003E99")]
		[global::Cpp2ILInjected.Address(RVA = "0x73E6F4", Offset = "0x73E6F4", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightingEngine), Member = "ProcessArea", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LightingEngine), Member = "UpdateLightDecay", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LightingEngine), Member = "ApplyPerFrameLights", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LightMap), Member = "BlurPass", ReturnType = typeof(void))]
		private void ProcessBlur()
		{
			throw null;
		}

		// Token: 0x060037FC RID: 14332 RVA: 0x0002BFFD File Offset: 0x0002A1FD
		[global::Cpp2ILInjected.Token(Token = "0x6003E9A")]
		[global::Cpp2ILInjected.Address(RVA = "0x73E714", Offset = "0x73E714", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LightMap), Member = "BlurPass", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "NextSeed", ReturnType = typeof(void))]
		private void ProcessBlur2()
		{
			throw null;
		}

		// Token: 0x060037FD RID: 14333 RVA: 0x0002C000 File Offset: 0x0002A200
		[global::Cpp2ILInjected.Token(Token = "0x6003E9B")]
		[global::Cpp2ILInjected.Address(RVA = "0x73E734", Offset = "0x73E734", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightingEngine), Member = "ProcessArea", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils[]), Member = "Swap", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
		{
			typeof(ref object),
			typeof(ref object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils[]), Member = "Swap", MemberTypeParameters = new object[] { typeof(Rectangle) }, MemberParameters = new object[]
		{
			typeof(ref Rectangle),
			typeof(ref Rectangle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void Present()
		{
			throw null;
		}

		// Token: 0x060037FE RID: 14334 RVA: 0x0002C003 File Offset: 0x0002A203
		[global::Cpp2ILInjected.Token(Token = "0x6003E9C")]
		[global::Cpp2ILInjected.Address(RVA = "0x73E874", Offset = "0x73E874", Length = "0x650")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightingEngine), Member = "ProcessBlur", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(float)
		}, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_waterStyle", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private void UpdateLightDecay()
		{
			throw null;
		}

		// Token: 0x060037FF RID: 14335 RVA: 0x0002C006 File Offset: 0x0002A206
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6003E9D")]
		[global::Cpp2ILInjected.Address(RVA = "0x73EEC4", Offset = "0x73EEC4", Length = "0x160")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightingEngine), Member = "ProcessBlur", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<LightingEngine.PerFrameLight>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Contains", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void ApplyPerFrameLights()
		{
			throw null;
		}

		// Token: 0x06003800 RID: 14336 RVA: 0x0002C009 File Offset: 0x0002A209
		[global::Cpp2ILInjected.Token(Token = "0x6003E9E")]
		[global::Cpp2ILInjected.Address(RVA = "0x73F104", Offset = "0x73F104", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lighting), Member = "Initialize", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LightMap), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public void Rebuild()
		{
			throw null;
		}

		// Token: 0x06003801 RID: 14337 RVA: 0x0002C00C File Offset: 0x0002A20C
		[global::Cpp2ILInjected.Token(Token = "0x6003E9F")]
		[global::Cpp2ILInjected.Address(RVA = "0x73F21C", Offset = "0x73F21C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void ExportBatchFinished(int index)
		{
			throw null;
		}

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x06003802 RID: 14338 RVA: 0x0002C00F File Offset: 0x0002A20F
		[global::Cpp2ILInjected.Token(Token = "0x17000798")]
		private ThreadedRenderManager.BatchProcessCallback ExportBatchFinishedCallback
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003EA0")]
			[global::Cpp2ILInjected.Address(RVA = "0x73F220", Offset = "0x73F220", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightingEngine), Member = "ExportToMiniMapThreaded", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
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

		// Token: 0x06003803 RID: 14339 RVA: 0x0002C012 File Offset: 0x0002A212
		[global::Cpp2ILInjected.Token(Token = "0x6003EA1")]
		[global::Cpp2ILInjected.Address(RVA = "0x73F2A0", Offset = "0x73F2A0", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightingEngine), Member = "ExportToMiniMap", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadedRenderManager.RenderThreadInstance), Member = "ExportToMinimap", MemberParameters = new object[]
		{
			typeof(LightingEngine),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LightingEngine), Member = "ExportToMiniMap", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LightingEngine), Member = "get_ExportBatchFinishedCallback", ReturnType = typeof(ThreadedRenderManager.BatchProcessCallback))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadedRenderManager), Member = "WaitAndProcess", MemberParameters = new object[]
		{
			typeof(ThreadedRenderManager.BatchProcessCallback),
			typeof(int)
		}, ReturnType = typeof(void))]
		private void ExportToMiniMapThreaded(int firstTileX, int firstTileY, int lastTileX, int lastTileY)
		{
			throw null;
		}

		// Token: 0x06003804 RID: 14340 RVA: 0x0002C015 File Offset: 0x0002A215
		[global::Cpp2ILInjected.Token(Token = "0x6003EA2")]
		[global::Cpp2ILInjected.Address(RVA = "0x73FE2C", Offset = "0x73FE2C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public Rectangle GetScanRegion()
		{
			throw null;
		}

		// Token: 0x06003805 RID: 14341 RVA: 0x0002C018 File Offset: 0x0002A218
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6003EA3")]
		[global::Cpp2ILInjected.Address(RVA = "0x73F3A4", Offset = "0x73F3A4", Length = "0xA88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadedRenderManager.RenderThreadInstance), Member = "DrawThread", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightingEngine), Member = "ExportToMiniMapThreaded", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightingEngine), Member = "ExportToMiniMap", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_Map", ReturnType = typeof(WorldMap))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_SceneMetrics", ReturnType = typeof(SceneMetrics))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_UnderworldLayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldMap), Member = "GetChunkTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref WorldMapChunk)
		}, ReturnType = typeof(MapTile*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MapHelper), Member = "GetTileBaseOption", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ushort),
			typeof(int),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<ushort, bool>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(ushort),
			typeof(ref bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 28)]
		public unsafe void ExportToMiniMap(int left, int top, int right, int bottom)
		{
			throw null;
		}

		// Token: 0x06003806 RID: 14342 RVA: 0x0002C01B File Offset: 0x0002A21B
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6003EA4")]
		[global::Cpp2ILInjected.Address(RVA = "0x73E47C", Offset = "0x73E47C", Length = "0x208")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightingEngine), Member = "ProcessArea", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mapEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mapReady", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Inflate", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Intersect", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(Rectangle)
		}, ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mapMinX", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mapMinY", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Right", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mapMaxX", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Bottom", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mapMaxY", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LightingEngine), Member = "ExportToMiniMapThreaded", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LightingEngine), Member = "ExportToMiniMap", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_updateMap", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private void ExportToMiniMap()
		{
			throw null;
		}

		// Token: 0x04006823 RID: 26659
		[global::Cpp2ILInjected.Token(Token = "0x4007D41")]
		public const int AREA_PADDING = 20;

		// Token: 0x04006824 RID: 26660
		[global::Cpp2ILInjected.Token(Token = "0x4007D42")]
		private const int NON_VISIBLE_PADDING = 10;

		// Token: 0x04006825 RID: 26661
		[global::Cpp2ILInjected.Token(Token = "0x4007D43")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly List<LightingEngine.PerFrameLight> _perFrameLights;

		// Token: 0x04006826 RID: 26662
		[global::Cpp2ILInjected.Token(Token = "0x4007D44")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private TileLightScanner _tileScanner;

		// Token: 0x04006827 RID: 26663
		[global::Cpp2ILInjected.Token(Token = "0x4007D45")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private LightMap _activeLightMap;

		// Token: 0x04006828 RID: 26664
		[global::Cpp2ILInjected.Token(Token = "0x4007D46")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private Rectangle _activeProcessedArea;

		// Token: 0x04006829 RID: 26665
		[global::Cpp2ILInjected.Token(Token = "0x4007D47")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private LightMap _workingLightMap;

		// Token: 0x0400682A RID: 26666
		[global::Cpp2ILInjected.Token(Token = "0x4007D48")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private Rectangle _workingProcessedArea;

		// Token: 0x0400682B RID: 26667
		[global::Cpp2ILInjected.Token(Token = "0x4007D49")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private readonly Stopwatch _timer;

		// Token: 0x0400682C RID: 26668
		[global::Cpp2ILInjected.Token(Token = "0x4007D4A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private LightingEngine.EngineState _state;

		// Token: 0x0400682D RID: 26669
		[global::Cpp2ILInjected.Token(Token = "0x4007D4B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private ThreadedRenderManager _threadManager;

		// Token: 0x0400682E RID: 26670
		[global::Cpp2ILInjected.Token(Token = "0x4007D4C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private Rectangle screenRegionScan;

		// Token: 0x0400682F RID: 26671
		[global::Cpp2ILInjected.Token(Token = "0x4007D4D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private ThreadedRenderManager.BatchProcessCallback _processBatchFinishedCallback;

		// Token: 0x02000973 RID: 2419
		[global::Cpp2ILInjected.Token(Token = "0x2000777")]
		private enum EngineState
		{
			// Token: 0x04008BD4 RID: 35796
			[global::Cpp2ILInjected.Token(Token = "0x4007D4F")]
			MinimapUpdate,
			// Token: 0x04008BD5 RID: 35797
			[global::Cpp2ILInjected.Token(Token = "0x4007D50")]
			ExportMetrics,
			// Token: 0x04008BD6 RID: 35798
			[global::Cpp2ILInjected.Token(Token = "0x4007D51")]
			Scan,
			// Token: 0x04008BD7 RID: 35799
			[global::Cpp2ILInjected.Token(Token = "0x4007D52")]
			Blur,
			// Token: 0x04008BD8 RID: 35800
			[global::Cpp2ILInjected.Token(Token = "0x4007D53")]
			Blur2
		}

		// Token: 0x02000974 RID: 2420
		[global::Cpp2ILInjected.Token(Token = "0x2000778")]
		private struct PerFrameLight
		{
			// Token: 0x06004D77 RID: 19831 RVA: 0x0002FAB6 File Offset: 0x0002DCB6
			[global::Cpp2ILInjected.Token(Token = "0x6003EA5")]
			[global::Cpp2ILInjected.Address(RVA = "0x73DF50", Offset = "0x73DF50", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public PerFrameLight(Point position, Vector3 color)
			{
				throw null;
			}

			// Token: 0x04008BD9 RID: 35801
			[global::Cpp2ILInjected.Token(Token = "0x4007D54")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public Point Position;

			// Token: 0x04008BDA RID: 35802
			[global::Cpp2ILInjected.Token(Token = "0x4007D55")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public Vector3 Color;
		}
	}
}
