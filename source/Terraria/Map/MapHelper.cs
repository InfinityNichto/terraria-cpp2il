using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Ionic.Zlib;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Graphics.Light;
using Terraria.IO;
using Terraria.Utilities;
using UnityEngine;

namespace Terraria.Map
{
	// Token: 0x020004A5 RID: 1189
	[global::Cpp2ILInjected.Token(Token = "0x20006B3")]
	public static class MapHelper
	{
		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x060033A2 RID: 13218 RVA: 0x0002B370 File Offset: 0x00029570
		[global::Cpp2ILInjected.Token(Token = "0x170006D9")]
		private static object IOLock
		{
			[global::Cpp2ILInjected.Token(Token = "0x60038EC")]
			[global::Cpp2ILInjected.Address(RVA = "0x143F564", Offset = "0x143F564", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MapHelper), Member = "SaveMap", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060033A3 RID: 13219 RVA: 0x0002B373 File Offset: 0x00029573
		[global::Cpp2ILInjected.Token(Token = "0x60038ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x14296B0", Offset = "0x14296B0", Length = "0xAD8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "Initialize_AlmostEverything", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Color), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Microsoft.Xna.Framework.Graphics.Color),
			typeof(Microsoft.Xna.Framework.Graphics.Color)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<ushort, bool>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<ushort, bool>), Member = "Add", MemberParameters = new object[]
		{
			typeof(ushort),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lang), Member = "BuildMapAtlas", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 59)]
		public static void Initialize()
		{
			throw null;
		}

		// Token: 0x060033A4 RID: 13220 RVA: 0x0002B376 File Offset: 0x00029576
		[global::Cpp2ILInjected.Token(Token = "0x60038EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x143F5B0", Offset = "0x143F5B0", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "clearWorld", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void ResetMapData()
		{
			throw null;
		}

		// Token: 0x060033A5 RID: 13221 RVA: 0x0002B379 File Offset: 0x00029579
		[global::Cpp2ILInjected.Token(Token = "0x60038EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x143F608", Offset = "0x143F608", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool HasOption(int tileType, int option)
		{
			throw null;
		}

		// Token: 0x060033A6 RID: 13222 RVA: 0x0002B37C File Offset: 0x0002957C
		[global::Cpp2ILInjected.Token(Token = "0x60038F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x143F680", Offset = "0x143F680", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIAccessoryInfo), Member = "BuildInfoAccs", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICraftGuidePopup), Member = "UpdateText", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "BuildMapAtlas", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 412)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static int TileToLookup(int tileType, int option)
		{
			throw null;
		}

		// Token: 0x060033A7 RID: 13223 RVA: 0x0002B37F File Offset: 0x0002957F
		[global::Cpp2ILInjected.Token(Token = "0x60038F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x143F6F4", Offset = "0x143F6F4", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "BuildMapAtlas", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static int LookupCount()
		{
			throw null;
		}

		// Token: 0x060033A8 RID: 13224 RVA: 0x0002B382 File Offset: 0x00029582
		[global::Cpp2ILInjected.Token(Token = "0x60038F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x143F750", Offset = "0x143F750", Length = "0x1F8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMap), Member = "DrawToMap", ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MapHelper), Member = "GetMapTileXnaColor", MemberParameters = new object[] { typeof(ref MapTile) }, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Color))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "paintColor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Color))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static void MapColor(ushort type, ref Microsoft.Xna.Framework.Graphics.Color oldColor, byte colorType)
		{
			throw null;
		}

		// Token: 0x060033A9 RID: 13225 RVA: 0x0002B385 File Offset: 0x00029585
		[global::Cpp2ILInjected.Token(Token = "0x60038F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x143F948", Offset = "0x143F948", Length = "0x170")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMap), Member = "DrawToMap", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MapTile), Member = "get_Color", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MapHelper), Member = "MapColor", MemberParameters = new object[]
		{
			typeof(ushort),
			typeof(ref Microsoft.Xna.Framework.Graphics.Color),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static Microsoft.Xna.Framework.Graphics.Color GetMapTileXnaColor(ref MapTile tile)
		{
			throw null;
		}

		// Token: 0x060033AA RID: 13226 RVA: 0x0002B388 File Offset: 0x00029588
		[global::Cpp2ILInjected.Token(Token = "0x60038F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x143FAB8", Offset = "0x143FAB8", Length = "0x808")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldMap), Member = "Update", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(byte)
		}, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_Map", ReturnType = typeof(WorldMap))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldMap), Member = "GetChunkTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref WorldMapChunk)
		}, ReturnType = typeof(MapTile*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "invisibleBlock", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "fullbrightBlock", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "invisibleWall", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_wall", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "fullbrightWall", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_liquid", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "wallColor", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "liquidType", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_UnderworldLayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "GetScanRegion", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameY", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameX", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_SceneMetrics", ReturnType = typeof(SceneMetrics))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "IsThisAMushroomTree", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "color", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MapHelper), Member = "GetTileBaseOption", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(Tile),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MapTile), Member = "Create", MemberParameters = new object[]
		{
			typeof(ushort),
			typeof(byte),
			typeof(byte)
		}, ReturnType = typeof(MapTile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<ushort, bool>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(ushort),
			typeof(ref bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
		public unsafe static MapTile CreateMapTile(int i, int j, byte Light)
		{
			throw null;
		}

		// Token: 0x060033AB RID: 13227 RVA: 0x0002B38B File Offset: 0x0002958B
		[global::Cpp2ILInjected.Token(Token = "0x60038F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x14402C0", Offset = "0x14402C0", Length = "0x1434")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIAccessoryInfo), Member = "BuildInfoAccs", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MapHelper), Member = "CreateMapTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(byte)
		}, ReturnType = typeof(MapTile))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameX", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameY", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ZoneCorrupt", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ZoneCrimson", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ZoneHallow", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "GetBiomeInfluence", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "GetCactusType", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(ref bool),
			typeof(ref bool),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public static void GetTileBaseOption(int x, int y, int tileType, Tile tileCache, ref int baseOption)
		{
			throw null;
		}

		// Token: 0x060033AC RID: 13228 RVA: 0x0002B38E File Offset: 0x0002958E
		[global::Cpp2ILInjected.Token(Token = "0x60038F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x14416F4", Offset = "0x14416F4", Length = "0xAAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyLighting), Member = "ExportToMiniMap", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightingEngine), Member = "ExportToMiniMap", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ZoneCorrupt", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ZoneCrimson", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ZoneHallow", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static void GetTileBaseOption(int y, ushort tileType, int frameX, int frameY, ref int baseOption)
		{
			throw null;
		}

		// Token: 0x060033AD RID: 13229 RVA: 0x0002B391 File Offset: 0x00029591
		[global::Cpp2ILInjected.Token(Token = "0x60038F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x14421A0", Offset = "0x14421A0", Length = "0x364")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldMap), Member = "Save", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_ActivePlayerFileData", ReturnType = typeof(PlayerFileData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mapEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "Sleep", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MapHelper), Member = "get_IOLock", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "TryEnter", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MapHelper), Member = "InternalSaveMapCompressed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 34)]
		public static void SaveMap(bool forceSave = false)
		{
			throw null;
		}

		// Token: 0x060033AE RID: 13230 RVA: 0x0002B394 File Offset: 0x00029594
		[global::Cpp2ILInjected.Token(Token = "0x60038F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1442504", Offset = "0x1442504", Length = "0xDEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MapHelper), Member = "SaveMap", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_ActivePlayerFileData", ReturnType = typeof(PlayerFileData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_playerPathName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileUtilities), Member = "CreateDirectory", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldFileData), Member = "get_UseGuidAsMapName", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Guid), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stopwatch), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stopwatch), Member = "Start", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gameMenu", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryWriter), Member = ".ctor", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_MapFileMetadata", ReturnType = typeof(FileMetadata))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileMetadata), Member = "IncrementAndWrite", MemberParameters = new object[] { typeof(BinaryWriter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_Map", ReturnType = typeof(WorldMap))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldMapChunk), Member = "SaveCompressed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileUtilities), Member = "WriteAllBytes", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte[]),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 70)]
		private static void InternalSaveMapCompressed()
		{
			throw null;
		}

		// Token: 0x060033AF RID: 13231 RVA: 0x0002B397 File Offset: 0x00029597
		[global::Cpp2ILInjected.Token(Token = "0x60038F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x14432F0", Offset = "0x14432F0", Length = "0x15A8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_ActivePlayerFileData", ReturnType = typeof(PlayerFileData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_playerPathName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileUtilities), Member = "CreateDirectory", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldFileData), Member = "get_UseGuidAsMapName", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Guid), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stopwatch), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stopwatch), Member = "Start", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gameMenu", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryWriter), Member = ".ctor", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(CompressionMode)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_MapFileMetadata", ReturnType = typeof(FileMetadata))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileMetadata), Member = "IncrementAndWrite", MemberParameters = new object[] { typeof(BinaryWriter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_Map", ReturnType = typeof(WorldMap))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldMap), Member = "GetChunkTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(ref WorldMapChunk)
		}, ReturnType = typeof(MapTile*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileUtilities), Member = "WriteAllBytes", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte[]),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 81)]
		private unsafe static void InternalSaveMap()
		{
			throw null;
		}

		// Token: 0x060033B0 RID: 13232 RVA: 0x0002B39A File Offset: 0x0002959A
		[global::Cpp2ILInjected.Token(Token = "0x60038FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1444898", Offset = "0x1444898", Length = "0x1A4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MapHelper), Member = "LoadMapWithUltraCompression", MemberParameters = new object[]
		{
			typeof(MemoryStream),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileMetadata), Member = "Read", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(FileType)
		}, ReturnType = typeof(FileMetadata))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_MapFileMetadata", MemberParameters = new object[] { typeof(FileMetadata) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private static void LoadMapHeader(BinaryReader fileIO)
		{
			throw null;
		}

		// Token: 0x060033B1 RID: 13233 RVA: 0x0002B39D File Offset: 0x0002959D
		[global::Cpp2ILInjected.Token(Token = "0x60038FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1444A3C", Offset = "0x1444A3C", Length = "0x2D0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MapHelper), Member = "LoadMapWithUltraCompression", MemberParameters = new object[]
		{
			typeof(MemoryStream),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MapHelper.BitReader), Member = "Read", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private static void ReadRunLengthEncodingData(MapHelper.RunLengthEncodingCompressionProfile compressionProfile, DeflateStream deflateStream, Action<int, int, uint> dataRead)
		{
			throw null;
		}

		// Token: 0x060033B2 RID: 13234 RVA: 0x0002B3A0 File Offset: 0x000295A0
		[global::Cpp2ILInjected.Token(Token = "0x60038FC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1444E70", Offset = "0x1444E70", Length = "0x3F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldMap), Member = "Load", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(CompressionMode)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryReader), Member = ".ctor", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MapHelper), Member = "LoadMapHeader", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MapHelper.RunLengthEncodingCompressionProfile), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(uint),
			typeof(uint)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action<, , >), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MapHelper), Member = "ReadRunLengthEncodingData", MemberParameters = new object[]
		{
			typeof(MapHelper.RunLengthEncodingCompressionProfile),
			typeof(DeflateStream),
			typeof(Action<int, int, uint>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 28)]
		public static void LoadMapWithUltraCompression(MemoryStream wholeStream, bool isLocalMap)
		{
			throw null;
		}

		// Token: 0x060033B3 RID: 13235 RVA: 0x0002B3A3 File Offset: 0x000295A3
		[global::Cpp2ILInjected.Token(Token = "0x60038FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1445348", Offset = "0x1445348", Length = "0x900")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldMap), Member = "Load", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MapTile), Member = "Create", MemberParameters = new object[]
		{
			typeof(ushort),
			typeof(byte),
			typeof(byte)
		}, ReturnType = typeof(MapTile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_Map", ReturnType = typeof(WorldMap))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldMap), Member = "SetTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref MapTile)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_UnderworldLayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 45)]
		public static void LoadMapVersion1(BinaryReader fileIO, int release)
		{
			throw null;
		}

		// Token: 0x060033B4 RID: 13236 RVA: 0x0002B3A6 File Offset: 0x000295A6
		[global::Cpp2ILInjected.Token(Token = "0x60038FE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1445CAC", Offset = "0x1445CAC", Length = "0xD80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldMap), Member = "Load", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileMetadata), Member = "FromCurrentSettings", MemberParameters = new object[] { typeof(FileType) }, ReturnType = typeof(FileMetadata))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileMetadata), Member = "Read", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(FileType)
		}, ReturnType = typeof(FileMetadata))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_MapFileMetadata", MemberParameters = new object[] { typeof(FileMetadata) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(CompressionMode)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryReader), Member = ".ctor", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_Map", ReturnType = typeof(WorldMap))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldMap), Member = "GetChunkTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(ref WorldMapChunk)
		}, ReturnType = typeof(MapTile*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(DateTime)
		}, ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "get_TotalSeconds", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 48)]
		public unsafe static void LoadMapVersion2(BinaryReader fileIO, int release)
		{
			throw null;
		}

		// Token: 0x060033B5 RID: 13237 RVA: 0x0002B3A9 File Offset: 0x000295A9
		[global::Cpp2ILInjected.Token(Token = "0x60038FF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1446A2C", Offset = "0x1446A2C", Length = "0xB10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldMap), Member = "Load", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileMetadata), Member = "FromCurrentSettings", MemberParameters = new object[] { typeof(FileType) }, ReturnType = typeof(FileMetadata))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileMetadata), Member = "Read", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(FileType)
		}, ReturnType = typeof(FileMetadata))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_MapFileMetadata", MemberParameters = new object[] { typeof(FileMetadata) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_Map", ReturnType = typeof(WorldMap))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldMapChunk), Member = "LoadTiles", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldMapChunk), Member = "SaveCompressed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldMap), Member = "ReleaseTileStorage", MemberParameters = new object[] { typeof(WorldMapChunk) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(DateTime)
		}, ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "get_TotalSeconds", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 46)]
		public static void LoadMapVersionCompressed(BinaryReader fileIO, int release)
		{
			throw null;
		}

		// Token: 0x060033B6 RID: 13238 RVA: 0x0002B3AC File Offset: 0x000295AC
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6003900")]
		[global::Cpp2ILInjected.Address(RVA = "0x144753C", Offset = "0x144753C", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static MapHelper()
		{
			throw null;
		}

		// Token: 0x04006566 RID: 25958
		[global::Cpp2ILInjected.Token(Token = "0x4007968")]
		public static int maxUpdateTile;

		// Token: 0x04006567 RID: 25959
		[global::Cpp2ILInjected.Token(Token = "0x4007969")]
		public static int numUpdateTile;

		// Token: 0x04006568 RID: 25960
		[global::Cpp2ILInjected.Token(Token = "0x400796A")]
		public static short[] updateTileX;

		// Token: 0x04006569 RID: 25961
		[global::Cpp2ILInjected.Token(Token = "0x400796B")]
		public static short[] updateTileY;

		// Token: 0x0400656A RID: 25962
		[global::Cpp2ILInjected.Token(Token = "0x400796C")]
		public static bool noStatusText;

		// Token: 0x0400656B RID: 25963
		[global::Cpp2ILInjected.Token(Token = "0x400796D")]
		public const int drawLoopMilliseconds = 5;

		// Token: 0x0400656C RID: 25964
		[global::Cpp2ILInjected.Token(Token = "0x400796E")]
		public const int drawMapLoadingLoopMilliseconds = 30;

		// Token: 0x0400656D RID: 25965
		[global::Cpp2ILInjected.Token(Token = "0x400796F")]
		private const int HeaderEmpty = 0;

		// Token: 0x0400656E RID: 25966
		[global::Cpp2ILInjected.Token(Token = "0x4007970")]
		private const int HeaderTile = 1;

		// Token: 0x0400656F RID: 25967
		[global::Cpp2ILInjected.Token(Token = "0x4007971")]
		private const int HeaderWall = 2;

		// Token: 0x04006570 RID: 25968
		[global::Cpp2ILInjected.Token(Token = "0x4007972")]
		private const int HeaderWater = 3;

		// Token: 0x04006571 RID: 25969
		[global::Cpp2ILInjected.Token(Token = "0x4007973")]
		private const int HeaderLava = 4;

		// Token: 0x04006572 RID: 25970
		[global::Cpp2ILInjected.Token(Token = "0x4007974")]
		private const int HeaderHoney = 5;

		// Token: 0x04006573 RID: 25971
		[global::Cpp2ILInjected.Token(Token = "0x4007975")]
		private const int HeaderHeavenAndHell = 6;

		// Token: 0x04006574 RID: 25972
		[global::Cpp2ILInjected.Token(Token = "0x4007976")]
		private const int HeaderBackground = 7;

		// Token: 0x04006575 RID: 25973
		[global::Cpp2ILInjected.Token(Token = "0x4007977")]
		private const int Header2_ReadHeader3Bit = 1;

		// Token: 0x04006576 RID: 25974
		[global::Cpp2ILInjected.Token(Token = "0x4007978")]
		private const int Header2Color1 = 2;

		// Token: 0x04006577 RID: 25975
		[global::Cpp2ILInjected.Token(Token = "0x4007979")]
		private const int Header2Color2 = 4;

		// Token: 0x04006578 RID: 25976
		[global::Cpp2ILInjected.Token(Token = "0x400797A")]
		private const int Header2Color3 = 8;

		// Token: 0x04006579 RID: 25977
		[global::Cpp2ILInjected.Token(Token = "0x400797B")]
		private const int Header2Color4 = 16;

		// Token: 0x0400657A RID: 25978
		[global::Cpp2ILInjected.Token(Token = "0x400797C")]
		private const int Header2Color5 = 32;

		// Token: 0x0400657B RID: 25979
		[global::Cpp2ILInjected.Token(Token = "0x400797D")]
		private const int Header2ShimmerBit = 64;

		// Token: 0x0400657C RID: 25980
		[global::Cpp2ILInjected.Token(Token = "0x400797E")]
		private const int Header2_UnusedBit8 = 128;

		// Token: 0x0400657D RID: 25981
		[global::Cpp2ILInjected.Token(Token = "0x400797F")]
		private const int Header3_ReservedForHeader4Bit = 1;

		// Token: 0x0400657E RID: 25982
		[global::Cpp2ILInjected.Token(Token = "0x4007980")]
		private const int Header3_UnusudBit2 = 2;

		// Token: 0x0400657F RID: 25983
		[global::Cpp2ILInjected.Token(Token = "0x4007981")]
		private const int Header3_UnusudBit3 = 4;

		// Token: 0x04006580 RID: 25984
		[global::Cpp2ILInjected.Token(Token = "0x4007982")]
		private const int Header3_UnusudBit4 = 8;

		// Token: 0x04006581 RID: 25985
		[global::Cpp2ILInjected.Token(Token = "0x4007983")]
		private const int Header3_UnusudBit5 = 16;

		// Token: 0x04006582 RID: 25986
		[global::Cpp2ILInjected.Token(Token = "0x4007984")]
		private const int Header3_UnusudBit6 = 32;

		// Token: 0x04006583 RID: 25987
		[global::Cpp2ILInjected.Token(Token = "0x4007985")]
		private const int Header3_UnusudBit7 = 64;

		// Token: 0x04006584 RID: 25988
		[global::Cpp2ILInjected.Token(Token = "0x4007986")]
		private const int Header3_UnusudBit8 = 128;

		// Token: 0x04006585 RID: 25989
		[global::Cpp2ILInjected.Token(Token = "0x4007987")]
		public const int maxTileOptions = 12;

		// Token: 0x04006586 RID: 25990
		[global::Cpp2ILInjected.Token(Token = "0x4007988")]
		public const int maxWallOptions = 2;

		// Token: 0x04006587 RID: 25991
		[global::Cpp2ILInjected.Token(Token = "0x4007989")]
		public const int maxLiquidTypes = 4;

		// Token: 0x04006588 RID: 25992
		[global::Cpp2ILInjected.Token(Token = "0x400798A")]
		public const int maxSkyGradients = 256;

		// Token: 0x04006589 RID: 25993
		[global::Cpp2ILInjected.Token(Token = "0x400798B")]
		public const int maxDirtGradients = 256;

		// Token: 0x0400658A RID: 25994
		[global::Cpp2ILInjected.Token(Token = "0x400798C")]
		public const int maxRockGradients = 256;

		// Token: 0x0400658B RID: 25995
		[global::Cpp2ILInjected.Token(Token = "0x400798D")]
		public static int[] tileOptionCounts;

		// Token: 0x0400658C RID: 25996
		[global::Cpp2ILInjected.Token(Token = "0x400798E")]
		public static int[] wallOptionCounts;

		// Token: 0x0400658D RID: 25997
		[global::Cpp2ILInjected.Token(Token = "0x400798F")]
		public static ushort[] tileLookup;

		// Token: 0x0400658E RID: 25998
		[global::Cpp2ILInjected.Token(Token = "0x4007990")]
		public static ushort[] wallLookup;

		// Token: 0x0400658F RID: 25999
		[global::Cpp2ILInjected.Token(Token = "0x4007991")]
		private static ushort tilePosition;

		// Token: 0x04006590 RID: 26000
		[global::Cpp2ILInjected.Token(Token = "0x4007992")]
		public static ushort wallPosition;

		// Token: 0x04006591 RID: 26001
		[global::Cpp2ILInjected.Token(Token = "0x4007993")]
		public static ushort liquidPosition;

		// Token: 0x04006592 RID: 26002
		[global::Cpp2ILInjected.Token(Token = "0x4007994")]
		public static ushort skyPosition;

		// Token: 0x04006593 RID: 26003
		[global::Cpp2ILInjected.Token(Token = "0x4007995")]
		public static ushort dirtPosition;

		// Token: 0x04006594 RID: 26004
		[global::Cpp2ILInjected.Token(Token = "0x4007996")]
		public static ushort rockPosition;

		// Token: 0x04006595 RID: 26005
		[global::Cpp2ILInjected.Token(Token = "0x4007997")]
		public static ushort hellPosition;

		// Token: 0x04006596 RID: 26006
		[global::Cpp2ILInjected.Token(Token = "0x4007998")]
		public static Microsoft.Xna.Framework.Graphics.Color[] colorLookup;

		// Token: 0x04006597 RID: 26007
		[global::Cpp2ILInjected.Token(Token = "0x4007999")]
		public static Dictionary<ushort, bool> snowLookup;

		// Token: 0x04006598 RID: 26008
		[global::Cpp2ILInjected.Token(Token = "0x400799A")]
		private static ushort wallRangeStart;

		// Token: 0x04006599 RID: 26009
		[global::Cpp2ILInjected.Token(Token = "0x400799B")]
		private static ushort wallRangeEnd;

		// Token: 0x02000943 RID: 2371
		[global::Cpp2ILInjected.Token(Token = "0x20006B4")]
		private class RunLengthEncodingCompressionProfile
		{
			// Token: 0x06004CBF RID: 19647 RVA: 0x0002F912 File Offset: 0x0002DB12
			[global::Cpp2ILInjected.Token(Token = "0x6003901")]
			[global::Cpp2ILInjected.Address(RVA = "0x1445268", Offset = "0x1445268", Length = "0xE0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MapHelper), Member = "LoadMapWithUltraCompression", MemberParameters = new object[]
			{
				typeof(MemoryStream),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Pow", MemberParameters = new object[]
			{
				typeof(double),
				typeof(double)
			}, ReturnType = typeof(double))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public RunLengthEncodingCompressionProfile(uint numBitsPerValue, uint bitCountForRunLengths)
			{
				throw null;
			}

			// Token: 0x04008AE1 RID: 35553
			[global::Cpp2ILInjected.Token(Token = "0x400799C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public readonly uint BitCountPerValue;

			// Token: 0x04008AE2 RID: 35554
			[global::Cpp2ILInjected.Token(Token = "0x400799D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
			public readonly uint BitCountForRunLengths;

			// Token: 0x04008AE3 RID: 35555
			[global::Cpp2ILInjected.Token(Token = "0x400799E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public readonly uint MinRepeatsToUseRunLengthEncoding;

			// Token: 0x04008AE4 RID: 35556
			[global::Cpp2ILInjected.Token(Token = "0x400799F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
			public readonly uint MaxCompressedValue;

			// Token: 0x04008AE5 RID: 35557
			[global::Cpp2ILInjected.Token(Token = "0x40079A0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public readonly uint MaxRunLengthRepeatValue;
		}

		// Token: 0x02000944 RID: 2372
		[global::Cpp2ILInjected.Token(Token = "0x20006B5")]
		private struct OldMapHelper
		{
			// Token: 0x06004CC0 RID: 19648 RVA: 0x0002F915 File Offset: 0x0002DB15
			[global::Cpp2ILInjected.Token(Token = "0x6003902")]
			[global::Cpp2ILInjected.Address(RVA = "0x1445C70", Offset = "0x1445C70", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool active()
			{
				throw null;
			}

			// Token: 0x06004CC1 RID: 19649 RVA: 0x0002F918 File Offset: 0x0002DB18
			[global::Cpp2ILInjected.Token(Token = "0x6003903")]
			[global::Cpp2ILInjected.Address(RVA = "0x1445C7C", Offset = "0x1445C7C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool water()
			{
				throw null;
			}

			// Token: 0x06004CC2 RID: 19650 RVA: 0x0002F91B File Offset: 0x0002DB1B
			[global::Cpp2ILInjected.Token(Token = "0x6003904")]
			[global::Cpp2ILInjected.Address(RVA = "0x1445C88", Offset = "0x1445C88", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool lava()
			{
				throw null;
			}

			// Token: 0x06004CC3 RID: 19651 RVA: 0x0002F91E File Offset: 0x0002DB1E
			[global::Cpp2ILInjected.Token(Token = "0x6003905")]
			[global::Cpp2ILInjected.Address(RVA = "0x1445C94", Offset = "0x1445C94", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool honey()
			{
				throw null;
			}

			// Token: 0x06004CC4 RID: 19652 RVA: 0x0002F921 File Offset: 0x0002DB21
			[global::Cpp2ILInjected.Token(Token = "0x6003906")]
			[global::Cpp2ILInjected.Address(RVA = "0x14475D4", Offset = "0x14475D4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool changed()
			{
				throw null;
			}

			// Token: 0x06004CC5 RID: 19653 RVA: 0x0002F924 File Offset: 0x0002DB24
			[global::Cpp2ILInjected.Token(Token = "0x6003907")]
			[global::Cpp2ILInjected.Address(RVA = "0x1445CA0", Offset = "0x1445CA0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool wall()
			{
				throw null;
			}

			// Token: 0x06004CC6 RID: 19654 RVA: 0x0002F927 File Offset: 0x0002DB27
			[global::Cpp2ILInjected.Token(Token = "0x6003908")]
			[global::Cpp2ILInjected.Address(RVA = "0x1445C48", Offset = "0x1445C48", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public byte option()
			{
				throw null;
			}

			// Token: 0x06004CC7 RID: 19655 RVA: 0x0002F92A File Offset: 0x0002DB2A
			[global::Cpp2ILInjected.Token(Token = "0x6003909")]
			[global::Cpp2ILInjected.Address(RVA = "0x14475E0", Offset = "0x14475E0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public byte color()
			{
				throw null;
			}

			// Token: 0x04008AE6 RID: 35558
			[global::Cpp2ILInjected.Token(Token = "0x40079A1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public byte misc;

			// Token: 0x04008AE7 RID: 35559
			[global::Cpp2ILInjected.Token(Token = "0x40079A2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x1")]
			public byte misc2;
		}

		// Token: 0x02000945 RID: 2373
		[global::Cpp2ILInjected.Token(Token = "0x20006B6")]
		public class BitReader
		{
			// Token: 0x06004CC8 RID: 19656 RVA: 0x0002F92D File Offset: 0x0002DB2D
			[global::Cpp2ILInjected.Token(Token = "0x600390A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1444D0C", Offset = "0x1444D0C", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public BitReader(Stream input)
			{
				throw null;
			}

			// Token: 0x06004CC9 RID: 19657 RVA: 0x0002F930 File Offset: 0x0002DB30
			[global::Cpp2ILInjected.Token(Token = "0x600390B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1444D3C", Offset = "0x1444D3C", Length = "0x134")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MapHelper), Member = "ReadRunLengthEncodingData", MemberParameters = new object[]
			{
				"Terraria.Map.MapHelper.RunLengthEncodingCompressionProfile",
				typeof(DeflateStream),
				typeof(Action<int, int, uint>)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
			{
				typeof(uint),
				typeof(uint)
			}, ReturnType = typeof(uint))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EndOfStreamException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			public uint Read(uint bitCount)
			{
				throw null;
			}

			// Token: 0x04008AE8 RID: 35560
			[global::Cpp2ILInjected.Token(Token = "0x40079A3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private readonly Stream InnerStream;

			// Token: 0x04008AE9 RID: 35561
			[global::Cpp2ILInjected.Token(Token = "0x40079A4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private byte CurByteOfData;

			// Token: 0x04008AEA RID: 35562
			[global::Cpp2ILInjected.Token(Token = "0x40079A5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
			private uint CurBit;
		}

		// Token: 0x02000946 RID: 2374
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20006B7")]
		private sealed class <>c__DisplayClass72_0
		{
			// Token: 0x06004CCA RID: 19658 RVA: 0x0002F933 File Offset: 0x0002DB33
			[global::Cpp2ILInjected.Token(Token = "0x600390C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1445260", Offset = "0x1445260", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass72_0()
			{
				throw null;
			}

			// Token: 0x06004CCB RID: 19659 RVA: 0x0002F936 File Offset: 0x0002DB36
			[global::Cpp2ILInjected.Token(Token = "0x600390D")]
			[global::Cpp2ILInjected.Address(RVA = "0x14475EC", Offset = "0x14475EC", Length = "0x110")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_Map", ReturnType = typeof(WorldMap))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldMap), Member = "UpdateLighting", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(byte)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			internal void <LoadMapWithUltraCompression>b__0(int x, int y, uint compressedLightValue)
			{
				throw null;
			}

			// Token: 0x04008AEB RID: 35563
			[global::Cpp2ILInjected.Token(Token = "0x40079A6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public MapHelper.RunLengthEncodingCompressionProfile lightCompressionProfile;
		}
	}
}
