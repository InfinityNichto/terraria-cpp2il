using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.Map;
using Unity.IL2CPP.CompilerServices;

namespace Terraria.Graphics.Light
{
	// Token: 0x0200050D RID: 1293
	[global::Cpp2ILInjected.Token(Token = "0x2000773")]
	public class LegacyLighting : ILightingEngine
	{
		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x060037DA RID: 14298 RVA: 0x0002BFAC File Offset: 0x0002A1AC
		// (set) Token: 0x060037DB RID: 14299 RVA: 0x0002BFAF File Offset: 0x0002A1AF
		[global::Cpp2ILInjected.Token(Token = "0x17000796")]
		public int Mode
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003E76")]
			[global::Cpp2ILInjected.Address(RVA = "0x14B6E18", Offset = "0x14B6E18", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003E77")]
			[global::Cpp2ILInjected.Address(RVA = "0x14B6E20", Offset = "0x14B6E20", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x060037DC RID: 14300 RVA: 0x0002BFB2 File Offset: 0x0002A1B2
		[global::Cpp2ILInjected.Token(Token = "0x17000797")]
		public bool IsColorOrWhiteMode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003E78")]
			[global::Cpp2ILInjected.Address(RVA = "0x14B6E28", Offset = "0x14B6E28", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060037DD RID: 14301 RVA: 0x0002BFB5 File Offset: 0x0002A1B5
		[global::Cpp2ILInjected.Token(Token = "0x6003E79")]
		[global::Cpp2ILInjected.Address(RVA = "0x14B6E38", Offset = "0x14B6E38", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LocalUserGameState), Member = "get_LegacyEngine", ReturnType = typeof(LegacyLighting))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LightMap), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileLightScanner), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public LegacyLighting(Camera camera)
		{
			throw null;
		}

		// Token: 0x060037DE RID: 14302 RVA: 0x0002BFB8 File Offset: 0x0002A1B8
		[global::Cpp2ILInjected.Token(Token = "0x6003E7A")]
		[global::Cpp2ILInjected.Address(RVA = "0x14B6F08", Offset = "0x14B6F08", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public LightMap GetLightMap(out Rectangle lightMapRegion)
		{
			throw null;
		}

		// Token: 0x060037DF RID: 14303 RVA: 0x0002BFBB File Offset: 0x0002A1BB
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6003E7B")]
		[global::Cpp2ILInjected.Address(RVA = "0x14B6F18", Offset = "0x14B6F18", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Contains", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LightMap), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public Vector3 GetColor(int x, int y)
		{
			throw null;
		}

		// Token: 0x060037E0 RID: 14304 RVA: 0x0002BFBE File Offset: 0x0002A1BE
		[global::Cpp2ILInjected.Token(Token = "0x6003E7C")]
		[global::Cpp2ILInjected.Address(RVA = "0x14B6FEC", Offset = "0x14B6FEC", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lighting), Member = "Initialize", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, short>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "get_UnscaledSize", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LightMap), Member = "SetSize", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void Rebuild()
		{
			throw null;
		}

		// Token: 0x060037E1 RID: 14305 RVA: 0x0002BFC1 File Offset: 0x0002A1C1
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6003E7D")]
		[global::Cpp2ILInjected.Address(RVA = "0x14B7120", Offset = "0x14B7120", Length = "0x2F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Contains", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, short>), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, short>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref short)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LegacyLighting.ColorTriplet), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, short>), Member = "Add", MemberParameters = new object[]
		{
			typeof(int),
			typeof(short)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public void AddLight(int x, int y, Vector3 color)
		{
			throw null;
		}

		// Token: 0x060037E2 RID: 14306 RVA: 0x0002BFC4 File Offset: 0x0002A1C4
		[global::Cpp2ILInjected.Token(Token = "0x6003E7E")]
		[global::Cpp2ILInjected.Address(RVA = "0x14B7410", Offset = "0x14B7410", Length = "0x390")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_renderCount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_renderCount", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "get_UnscaledSize", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenLastPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LegacyLighting), Member = "DoColors", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LegacyLighting), Member = "Present", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_renderNow", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mapTime", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mapDelay", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mapDelay", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mapTime", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mapEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LegacyLighting), Member = "ExportToMiniMap", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LegacyLighting), Member = "UpdateLightToSkyColor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LegacyLighting), Member = "PreRenderPhase", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		public void ProcessArea(Rectangle area)
		{
			throw null;
		}

		// Token: 0x060037E3 RID: 14307 RVA: 0x0002BFC7 File Offset: 0x0002A1C7
		[global::Cpp2ILInjected.Token(Token = "0x6003E7F")]
		[global::Cpp2ILInjected.Address(RVA = "0x14B8C50", Offset = "0x14B8C50", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public Rectangle GetScanRegion()
		{
			throw null;
		}

		// Token: 0x060037E4 RID: 14308 RVA: 0x0002BFCA File Offset: 0x0002A1CA
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6003E80")]
		[global::Cpp2ILInjected.Address(RVA = "0x14B78E0", Offset = "0x14B78E0", Length = "0xA84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyLighting), Member = "ProcessArea", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_Map", ReturnType = typeof(WorldMap))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldMap), Member = "GetChunkTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref WorldMapChunk)
		}, ReturnType = typeof(MapTile*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "IsThisAMushroomTree", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_UnderworldLayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MapHelper), Member = "GetTileBaseOption", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ushort),
			typeof(int),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_SceneMetrics", ReturnType = typeof(SceneMetrics))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<ushort, bool>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(ushort),
			typeof(ref bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_updateMap", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 33)]
		private unsafe void ExportToMiniMap()
		{
			throw null;
		}

		// Token: 0x060037E5 RID: 14309 RVA: 0x0002BFCD File Offset: 0x0002A1CD
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6003E81")]
		[global::Cpp2ILInjected.Address(RVA = "0x14B8364", Offset = "0x14B8364", Length = "0x3C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyLighting), Member = "ProcessArea", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils[]), Member = "Clamp", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Right", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Bottom", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private void UpdateLightToSkyColor(float tileR, float tileG, float tileB)
		{
			throw null;
		}

		// Token: 0x060037E6 RID: 14310 RVA: 0x0002BFD0 File Offset: 0x0002A1D0
		[global::Cpp2ILInjected.Token(Token = "0x6003E82")]
		[global::Cpp2ILInjected.Address(RVA = "0x14B783C", Offset = "0x14B783C", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyLighting), Member = "ProcessArea", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
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

		// Token: 0x060037E7 RID: 14311 RVA: 0x0002BFD3 File Offset: 0x0002A1D3
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6003E83")]
		[global::Cpp2ILInjected.Address(RVA = "0x14B8C60", Offset = "0x14B8C60", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LightMap), Member = "Clear", ReturnType = typeof(void))]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x060037E8 RID: 14312 RVA: 0x0002BFD6 File Offset: 0x0002A1D6
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6003E84")]
		[global::Cpp2ILInjected.Address(RVA = "0x14B8728", Offset = "0x14B8728", Length = "0x528")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyLighting), Member = "ProcessArea", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stopwatch), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stopwatch), Member = "Start", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LightMap), Member = "Clear", ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_SceneMetrics", ReturnType = typeof(SceneMetrics))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle?), Member = ".ctor", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalPlayer", ReturnType = typeof(Player))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2?), Member = ".ctor", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SceneMetrics), Member = "ScanAndExportToMain", MemberParameters = new object[] { typeof(SceneMetricsScanSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileLightScanner), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileLightScanner), Member = "ExportTo", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(LightMap)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, short>), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, short>), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, short>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Contains", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, short>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, short>), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_renderCount", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stopwatch), Member = "get_Elapsed", ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "get_TotalMilliseconds", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeLogger), Member = "LightingTime", MemberParameters = new object[]
		{
			typeof(int),
			typeof(double)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LegacyLighting), Member = "DoColors", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 28)]
		private void PreRenderPhase(Rectangle area)
		{
			throw null;
		}

		// Token: 0x060037E9 RID: 14313 RVA: 0x0002BFD9 File Offset: 0x0002A1D9
		[global::Cpp2ILInjected.Token(Token = "0x6003E85")]
		[global::Cpp2ILInjected.Address(RVA = "0x14B8C84", Offset = "0x14B8C84", Length = "0x2F4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyLighting), Member = "DoColors", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LightMap), Member = "set_LightDecayThroughAir", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LightMap), Member = "set_LightDecayThroughSolid", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LightMap), Member = "get_LightDecayThroughAir", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LightMap), Member = "get_LightDecayThroughSolid", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LightMap), Member = "set_LightDecayThroughWater", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LightMap), Member = "get_LightDecayThroughWater", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LightMap), Member = "set_LightDecayThroughHoney", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void UpdateLightDecay()
		{
			throw null;
		}

		// Token: 0x060037EA RID: 14314 RVA: 0x0002BFDC File Offset: 0x0002A1DC
		[global::Cpp2ILInjected.Token(Token = "0x6003E86")]
		[global::Cpp2ILInjected.Address(RVA = "0x14B77A0", Offset = "0x14B77A0", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyLighting), Member = "ProcessArea", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyLighting), Member = "PreRenderPhase", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LegacyLighting), Member = "UpdateLightDecay", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_renderCount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LightMap), Member = "ExecutePartialBlur", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void DoColors()
		{
			throw null;
		}

		// Token: 0x060037EB RID: 14315 RVA: 0x0002BFDF File Offset: 0x0002A1DF
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6003E87")]
		[global::Cpp2ILInjected.Address(RVA = "0x14B8F78", Offset = "0x14B8F78", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static LegacyLighting()
		{
			throw null;
		}

		// Token: 0x04006812 RID: 26642
		[global::Cpp2ILInjected.Token(Token = "0x4007D2D")]
		public static int RenderPhases;

		// Token: 0x04006813 RID: 26643
		[global::Cpp2ILInjected.Token(Token = "0x4007D2E")]
		private static short tempLightOffset;

		// Token: 0x04006814 RID: 26644
		[global::Cpp2ILInjected.Token(Token = "0x4007D2F")]
		private static List<LegacyLighting.ColorTriplet> tempLightData;

		// Token: 0x04006815 RID: 26645
		[global::Cpp2ILInjected.Token(Token = "0x4007D30")]
		private static Dictionary<int, short> tempLights;

		// Token: 0x04006816 RID: 26646
		[global::Cpp2ILInjected.Token(Token = "0x4007D31")]
		private const int AREA_PADDING = 20;

		// Token: 0x04006817 RID: 26647
		[global::Cpp2ILInjected.Token(Token = "0x4007D32")]
		private const int NON_VISIBLE_PADDING = 0;

		// Token: 0x04006818 RID: 26648
		[global::Cpp2ILInjected.Token(Token = "0x4007D33")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private float _oldSkyColor;

		// Token: 0x04006819 RID: 26649
		[global::Cpp2ILInjected.Token(Token = "0x4007D34")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private float _skyColor;

		// Token: 0x0400681A RID: 26650
		[global::Cpp2ILInjected.Token(Token = "0x4007D35")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private LightMap _activeLightMap;

		// Token: 0x0400681B RID: 26651
		[global::Cpp2ILInjected.Token(Token = "0x4007D36")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private Rectangle _activeProcessedArea;

		// Token: 0x0400681C RID: 26652
		[global::Cpp2ILInjected.Token(Token = "0x4007D37")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private LightMap _workingLightMap;

		// Token: 0x0400681D RID: 26653
		[global::Cpp2ILInjected.Token(Token = "0x4007D38")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private Rectangle _workingProcessedArea;

		// Token: 0x0400681E RID: 26654
		[global::Cpp2ILInjected.Token(Token = "0x4007D39")]
		private const int MAX_TEMP_LIGHTS = 2000;

		// Token: 0x0400681F RID: 26655
		[global::Cpp2ILInjected.Token(Token = "0x4007D3A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private TileLightScanner _tileScanner;

		// Token: 0x04006820 RID: 26656
		[global::Cpp2ILInjected.Token(Token = "0x4007D3B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private readonly Camera _camera;

		// Token: 0x04006821 RID: 26657
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4007D3C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private int <Mode>k__BackingField;

		// Token: 0x04006822 RID: 26658
		[global::Cpp2ILInjected.Token(Token = "0x4007D3D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
		private Rectangle screenRegionScan;

		// Token: 0x02000972 RID: 2418
		[global::Cpp2ILInjected.Token(Token = "0x2000774")]
		private class ColorTriplet
		{
			// Token: 0x06004D75 RID: 19829 RVA: 0x0002FAB0 File Offset: 0x0002DCB0
			[global::Cpp2ILInjected.Token(Token = "0x6003E88")]
			[global::Cpp2ILInjected.Address(RVA = "0x73DA74", Offset = "0x73DA74", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public ColorTriplet(float R, float G, float B)
			{
				throw null;
			}

			// Token: 0x06004D76 RID: 19830 RVA: 0x0002FAB3 File Offset: 0x0002DCB3
			[global::Cpp2ILInjected.Token(Token = "0x6003E89")]
			[global::Cpp2ILInjected.Address(RVA = "0x73DAB0", Offset = "0x73DAB0", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyLighting), Member = "AddLight", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(Vector3)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public ColorTriplet(float averageColor)
			{
				throw null;
			}

			// Token: 0x04008BD0 RID: 35792
			[global::Cpp2ILInjected.Token(Token = "0x4007D3E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public float R;

			// Token: 0x04008BD1 RID: 35793
			[global::Cpp2ILInjected.Token(Token = "0x4007D3F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
			public float G;

			// Token: 0x04008BD2 RID: 35794
			[global::Cpp2ILInjected.Token(Token = "0x4007D40")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public float B;
		}
	}
}
