using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.Graphics.Capture;
using Terraria.Graphics.Light;
using Terraria.IO;
using Terraria.Utilities;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

namespace Terraria.Map
{
	// Token: 0x020004AD RID: 1197
	[global::Cpp2ILInjected.Token(Token = "0x20006C1")]
	public class WorldMap
	{
		// Token: 0x060033D0 RID: 13264 RVA: 0x0002B3F7 File Offset: 0x000295F7
		[global::Cpp2ILInjected.Token(Token = "0x600392A")]
		[global::Cpp2ILInjected.Address(RVA = "0x14490F8", Offset = "0x14490F8", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMap), Member = "DrawToMap", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMap), Member = "DrawMap", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "UpdateMapTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MapHelper), Member = "CreateMapTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(byte)
		}, ReturnType = typeof(MapTile))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldMap), Member = "Update", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldMap), Member = "SetTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref MapTile)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldMap), Member = "IsRevealed", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldMap), Member = "UpdateLighting", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(byte)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldMap), Member = "UpdateType", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldMap), Member = "ClearEdges", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyLighting), Member = "ExportToMiniMap", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightingEngine), Member = "ExportToMiniMap", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 20)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldMapChunk), Member = "LoadTiles", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		public unsafe MapTile* GetChunkTile(int mapX, int mapY, out WorldMapChunk chunk)
		{
			throw null;
		}

		// Token: 0x060033D1 RID: 13265 RVA: 0x0002B3FA File Offset: 0x000295FA
		[global::Cpp2ILInjected.Token(Token = "0x600392B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1449324", Offset = "0x1449324", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMap), Member = "ApplySection", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMap), Member = "DrawToMap_Section", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MapHelper), Member = "InternalSaveMap", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MapHelper), Member = "LoadMapVersion2", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldMap), Member = "ConsumeUpdate", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 16)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldMapChunk), Member = "LoadTiles", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		public unsafe MapTile* GetChunkTile(int mapX, int mapY, bool utilLoad, out WorldMapChunk chunk)
		{
			throw null;
		}

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x060033D2 RID: 13266 RVA: 0x0002B3FD File Offset: 0x000295FD
		[global::Cpp2ILInjected.Token(Token = "0x170006DC")]
		public int NumChunksAvailable
		{
			[global::Cpp2ILInjected.Token(Token = "0x600392C")]
			[global::Cpp2ILInjected.Address(RVA = "0x14493BC", Offset = "0x14493BC", Length = "0xE8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060033D3 RID: 13267 RVA: 0x0002B400 File Offset: 0x00029600
		[global::Cpp2ILInjected.Token(Token = "0x600392D")]
		[global::Cpp2ILInjected.Address(RVA = "0x14494A4", Offset = "0x14494A4", Length = "0x2C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldMap), Member = "UpdateChunks", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldMapChunk), Member = "SaveCompressed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(void*) }, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public unsafe void UnloadChunk()
		{
			throw null;
		}

		// Token: 0x060033D4 RID: 13268 RVA: 0x0002B403 File Offset: 0x00029603
		[global::Cpp2ILInjected.Token(Token = "0x600392E")]
		[global::Cpp2ILInjected.Address(RVA = "0x14497E4", Offset = "0x14497E4", Length = "0x51C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldMapChunk), Member = "LoadTiles", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<IntPtr>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(void*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<IntPtr>), Member = "RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Insert", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldMapChunk), Member = "SaveCompressed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(void*) }, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public unsafe MapTile* GetTileStorage(WorldMapChunk chunk, bool utilLoad = false)
		{
			throw null;
		}

		// Token: 0x060033D5 RID: 13269 RVA: 0x0002B406 File Offset: 0x00029606
		[global::Cpp2ILInjected.Token(Token = "0x600392F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1449D00", Offset = "0x1449D00", Length = "0x178")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MapHelper), Member = "LoadMapVersionCompressed", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldMapChunk), Member = "Reset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(void*) }, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public unsafe void ReleaseTileStorage(WorldMapChunk chunk)
		{
			throw null;
		}

		// Token: 0x060033D6 RID: 13270 RVA: 0x0002B409 File Offset: 0x00029609
		[global::Cpp2ILInjected.Token(Token = "0x6003930")]
		[global::Cpp2ILInjected.Address(RVA = "0x1449E78", Offset = "0x1449E78", Length = "0x264")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMap), Member = "DrawToMap", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "PerformCachedMapTileUpdates", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldMap), Member = "UnloadChunk", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public void UpdateChunks()
		{
			throw null;
		}

		// Token: 0x060033D7 RID: 13271 RVA: 0x0002B40C File Offset: 0x0002960C
		[global::Cpp2ILInjected.Token(Token = "0x6003931")]
		[global::Cpp2ILInjected.Address(RVA = "0x144A0DC", Offset = "0x144A0DC", Length = "0x414")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageBuffer), Member = "ProcessData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "joinLocalWorldCallBack", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "SetWorldSizeOnMainThread", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mapMinX", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mapMaxX", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mapMinY", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mapMaxY", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mapEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnsafeUtility), Member = "Free", MemberParameters = new object[]
		{
			typeof(void*),
			typeof(Allocator)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnsafeUtility[]), Member = "AlignOf", MemberTypeParameters = new object[] { typeof(MapTile) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnsafeUtility), Member = "Malloc", MemberParameters = new object[]
		{
			typeof(long),
			typeof(int),
			typeof(Allocator)
		}, ReturnType = typeof(void*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldMapChunk), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(WorldMap),
			typeof(byte*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(void*) }, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldMap), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		public unsafe void Allocate(int maxWidth, int maxHeight)
		{
			throw null;
		}

		// Token: 0x060033D8 RID: 13272 RVA: 0x0002B40F File Offset: 0x0002960F
		[global::Cpp2ILInjected.Token(Token = "0x6003932")]
		[global::Cpp2ILInjected.Address(RVA = "0x144A5C8", Offset = "0x144A5C8", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldMap), Member = "GetChunkTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(ref WorldMapChunk)
		}, ReturnType = typeof(MapTile*))]
		public unsafe void ConsumeUpdate(int x, int y)
		{
			throw null;
		}

		// Token: 0x060033D9 RID: 13273 RVA: 0x0002B412 File Offset: 0x00029612
		[global::Cpp2ILInjected.Token(Token = "0x6003933")]
		[global::Cpp2ILInjected.Address(RVA = "0x144A604", Offset = "0x144A604", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldMap), Member = "GetChunkTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref WorldMapChunk)
		}, ReturnType = typeof(MapTile*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MapHelper), Member = "CreateMapTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(byte)
		}, ReturnType = typeof(MapTile))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public unsafe void Update(int x, int y, byte light)
		{
			throw null;
		}

		// Token: 0x060033DA RID: 13274 RVA: 0x0002B415 File Offset: 0x00029615
		[global::Cpp2ILInjected.Token(Token = "0x6003934")]
		[global::Cpp2ILInjected.Address(RVA = "0x144A6B4", Offset = "0x144A6B4", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MapHelper), Member = "LoadMapVersion1", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldMap), Member = "GetChunkTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref WorldMapChunk)
		}, ReturnType = typeof(MapTile*))]
		public unsafe void SetTile(int x, int y, ref MapTile tile)
		{
			throw null;
		}

		// Token: 0x060033DB RID: 13275 RVA: 0x0002B418 File Offset: 0x00029618
		[global::Cpp2ILInjected.Token(Token = "0x6003935")]
		[global::Cpp2ILInjected.Address(RVA = "0x144A6EC", Offset = "0x144A6EC", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawCapture", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(CaptureSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldMap), Member = "GetChunkTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref WorldMapChunk)
		}, ReturnType = typeof(MapTile*))]
		public unsafe bool IsRevealed(int x, int y)
		{
			throw null;
		}

		// Token: 0x060033DC RID: 13276 RVA: 0x0002B41B File Offset: 0x0002961B
		[global::Cpp2ILInjected.Token(Token = "0x6003936")]
		[global::Cpp2ILInjected.Address(RVA = "0x144A710", Offset = "0x144A710", Length = "0x12C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Map.MapHelper.<>c__DisplayClass72_0", Member = "<LoadMapWithUltraCompression>b__0", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(uint)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldMap), Member = "GetChunkTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref WorldMapChunk)
		}, ReturnType = typeof(MapTile*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(byte),
			typeof(byte)
		}, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MapHelper), Member = "CreateMapTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(byte)
		}, ReturnType = typeof(MapTile))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public unsafe bool UpdateLighting(int x, int y, byte light)
		{
			throw null;
		}

		// Token: 0x060033DD RID: 13277 RVA: 0x0002B41E File Offset: 0x0002961E
		[global::Cpp2ILInjected.Token(Token = "0x6003937")]
		[global::Cpp2ILInjected.Address(RVA = "0x144A83C", Offset = "0x144A83C", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "UpdateMapTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldMap), Member = "GetChunkTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref WorldMapChunk)
		}, ReturnType = typeof(MapTile*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MapHelper), Member = "CreateMapTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(byte)
		}, ReturnType = typeof(MapTile))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public unsafe bool UpdateType(int x, int y)
		{
			throw null;
		}

		// Token: 0x060033DE RID: 13278 RVA: 0x0002B421 File Offset: 0x00029621
		[global::Cpp2ILInjected.Token(Token = "0x6003938")]
		[global::Cpp2ILInjected.Address(RVA = "0x144A91C", Offset = "0x144A91C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void UnlockMapSection(int sectionX, int sectionY)
		{
			throw null;
		}

		// Token: 0x060033DF RID: 13279 RVA: 0x0002B424 File Offset: 0x00029624
		[global::Cpp2ILInjected.Token(Token = "0x6003939")]
		[global::Cpp2ILInjected.Address(RVA = "0x144A920", Offset = "0x144A920", Length = "0x9B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DedServ", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Netplay), Member = "ClientLoopFrameUpdate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "playWorldCallBack", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "joinLocalWorldCallBack", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileMetadata), Member = "FromCurrentSettings", MemberParameters = new object[] { typeof(FileType) }, ReturnType = typeof(FileMetadata))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_MapFileMetadata", MemberParameters = new object[] { typeof(FileMetadata) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_clearMap", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_loadMap", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_loadMapLock", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_refreshMap", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_ActivePlayerFileData", ReturnType = typeof(PlayerFileData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mapEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_playerPathName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldFileData), Member = "get_UseGuidAsMapName", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Guid), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileUtilities), Member = "Exists", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileUtilities), Member = "ReadAllBytes", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryReader), Member = ".ctor", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "get_CurrentPlatform", ReturnType = typeof(DrPlatform.DrPlatformType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MapHelper), Member = "LoadMapWithUltraCompression", MemberParameters = new object[]
		{
			typeof(MemoryStream),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldMap), Member = "ClearEdges", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MapHelper), Member = "LoadMapVersion2", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldMap), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MapHelper), Member = "LoadMapVersionCompressed", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MapHelper), Member = "LoadMapVersion1", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileUtilities), Member = "Copy", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 60)]
		public void Load()
		{
			throw null;
		}

		// Token: 0x060033E0 RID: 13280 RVA: 0x0002B427 File Offset: 0x00029627
		[global::Cpp2ILInjected.Token(Token = "0x600393A")]
		[global::Cpp2ILInjected.Address(RVA = "0x144B488", Offset = "0x144B488", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "InternalSaveMap", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MapHelper), Member = "SaveMap", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void Save(bool forceSave = false)
		{
			throw null;
		}

		// Token: 0x060033E1 RID: 13281 RVA: 0x0002B42A File Offset: 0x0002962A
		[global::Cpp2ILInjected.Token(Token = "0x600393B")]
		[global::Cpp2ILInjected.Address(RVA = "0x144A55C", Offset = "0x144A55C", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "clearWorld", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldMap), Member = "Allocate", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldMap), Member = "Load", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldMapChunk), Member = "Reset", ReturnType = typeof(void))]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x060033E2 RID: 13282 RVA: 0x0002B42D File Offset: 0x0002962D
		[global::Cpp2ILInjected.Token(Token = "0x600393C")]
		[global::Cpp2ILInjected.Address(RVA = "0x144B2D8", Offset = "0x144B2D8", Length = "0x1B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldMap), Member = "Load", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldMap), Member = "GetChunkTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref WorldMapChunk)
		}, ReturnType = typeof(MapTile*))]
		public unsafe void ClearEdges()
		{
			throw null;
		}

		// Token: 0x060033E3 RID: 13283 RVA: 0x0002B430 File Offset: 0x00029630
		[global::Cpp2ILInjected.Token(Token = "0x600393D")]
		[global::Cpp2ILInjected.Address(RVA = "0x144B630", Offset = "0x144B630", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LocalUserGameState), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<IntPtr>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public WorldMap()
		{
			throw null;
		}

		// Token: 0x040065A6 RID: 26022
		[global::Cpp2ILInjected.Token(Token = "0x40079B7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public int MaxWidth;

		// Token: 0x040065A7 RID: 26023
		[global::Cpp2ILInjected.Token(Token = "0x40079B8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public int MaxHeight;

		// Token: 0x040065A8 RID: 26024
		[global::Cpp2ILInjected.Token(Token = "0x40079B9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public int MaxChunkWidth;

		// Token: 0x040065A9 RID: 26025
		[global::Cpp2ILInjected.Token(Token = "0x40079BA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public int MaxChunkHeight;

		// Token: 0x040065AA RID: 26026
		[global::Cpp2ILInjected.Token(Token = "0x40079BB")]
		public const int BlackEdgeWidth = 40;

		// Token: 0x040065AB RID: 26027
		[global::Cpp2ILInjected.Token(Token = "0x40079BC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public WorldMapChunk[] _chunks;

		// Token: 0x040065AC RID: 26028
		[global::Cpp2ILInjected.Token(Token = "0x40079BD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public int MaxChunkMapped;

		// Token: 0x040065AD RID: 26029
		[global::Cpp2ILInjected.Token(Token = "0x40079BE")]
		public const int ReservedForPlayer = 64;

		// Token: 0x040065AE RID: 26030
		[global::Cpp2ILInjected.Token(Token = "0x40079BF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private unsafe MapTile* TileData;

		// Token: 0x040065AF RID: 26031
		[global::Cpp2ILInjected.Token(Token = "0x40079C0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private unsafe byte* TileCompressedData;

		// Token: 0x040065B0 RID: 26032
		[global::Cpp2ILInjected.Token(Token = "0x40079C1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		public object LockObject;

		// Token: 0x040065B1 RID: 26033
		[global::Cpp2ILInjected.Token(Token = "0x40079C2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private List<IntPtr> TileChunksAvailable;

		// Token: 0x040065B2 RID: 26034
		[global::Cpp2ILInjected.Token(Token = "0x40079C3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private List<WorldMapChunk> TileChunksInUse;
	}
}
