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
	[global::Cpp2ILInjected.Token(Token = "0x20006B3")]
	public static class MapHelper
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x60038EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x143F5B0", Offset = "0x143F5B0", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "clearWorld", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void ResetMapData()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60038EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x143F608", Offset = "0x143F608", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool HasOption(int tileType, int option)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x60038F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x143F6F4", Offset = "0x143F6F4", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "BuildMapAtlas", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static int LookupCount()
		{
			throw null;
		}

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

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6003900")]
		[global::Cpp2ILInjected.Address(RVA = "0x144753C", Offset = "0x144753C", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static MapHelper()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4007968")]
		public static int maxUpdateTile;

		[global::Cpp2ILInjected.Token(Token = "0x4007969")]
		public static int numUpdateTile;

		[global::Cpp2ILInjected.Token(Token = "0x400796A")]
		public static short[] updateTileX;

		[global::Cpp2ILInjected.Token(Token = "0x400796B")]
		public static short[] updateTileY;

		[global::Cpp2ILInjected.Token(Token = "0x400796C")]
		public static bool noStatusText;

		[global::Cpp2ILInjected.Token(Token = "0x400796D")]
		public const int drawLoopMilliseconds = 5;

		[global::Cpp2ILInjected.Token(Token = "0x400796E")]
		public const int drawMapLoadingLoopMilliseconds = 30;

		[global::Cpp2ILInjected.Token(Token = "0x400796F")]
		private const int HeaderEmpty = 0;

		[global::Cpp2ILInjected.Token(Token = "0x4007970")]
		private const int HeaderTile = 1;

		[global::Cpp2ILInjected.Token(Token = "0x4007971")]
		private const int HeaderWall = 2;

		[global::Cpp2ILInjected.Token(Token = "0x4007972")]
		private const int HeaderWater = 3;

		[global::Cpp2ILInjected.Token(Token = "0x4007973")]
		private const int HeaderLava = 4;

		[global::Cpp2ILInjected.Token(Token = "0x4007974")]
		private const int HeaderHoney = 5;

		[global::Cpp2ILInjected.Token(Token = "0x4007975")]
		private const int HeaderHeavenAndHell = 6;

		[global::Cpp2ILInjected.Token(Token = "0x4007976")]
		private const int HeaderBackground = 7;

		[global::Cpp2ILInjected.Token(Token = "0x4007977")]
		private const int Header2_ReadHeader3Bit = 1;

		[global::Cpp2ILInjected.Token(Token = "0x4007978")]
		private const int Header2Color1 = 2;

		[global::Cpp2ILInjected.Token(Token = "0x4007979")]
		private const int Header2Color2 = 4;

		[global::Cpp2ILInjected.Token(Token = "0x400797A")]
		private const int Header2Color3 = 8;

		[global::Cpp2ILInjected.Token(Token = "0x400797B")]
		private const int Header2Color4 = 16;

		[global::Cpp2ILInjected.Token(Token = "0x400797C")]
		private const int Header2Color5 = 32;

		[global::Cpp2ILInjected.Token(Token = "0x400797D")]
		private const int Header2ShimmerBit = 64;

		[global::Cpp2ILInjected.Token(Token = "0x400797E")]
		private const int Header2_UnusedBit8 = 128;

		[global::Cpp2ILInjected.Token(Token = "0x400797F")]
		private const int Header3_ReservedForHeader4Bit = 1;

		[global::Cpp2ILInjected.Token(Token = "0x4007980")]
		private const int Header3_UnusudBit2 = 2;

		[global::Cpp2ILInjected.Token(Token = "0x4007981")]
		private const int Header3_UnusudBit3 = 4;

		[global::Cpp2ILInjected.Token(Token = "0x4007982")]
		private const int Header3_UnusudBit4 = 8;

		[global::Cpp2ILInjected.Token(Token = "0x4007983")]
		private const int Header3_UnusudBit5 = 16;

		[global::Cpp2ILInjected.Token(Token = "0x4007984")]
		private const int Header3_UnusudBit6 = 32;

		[global::Cpp2ILInjected.Token(Token = "0x4007985")]
		private const int Header3_UnusudBit7 = 64;

		[global::Cpp2ILInjected.Token(Token = "0x4007986")]
		private const int Header3_UnusudBit8 = 128;

		[global::Cpp2ILInjected.Token(Token = "0x4007987")]
		public const int maxTileOptions = 12;

		[global::Cpp2ILInjected.Token(Token = "0x4007988")]
		public const int maxWallOptions = 2;

		[global::Cpp2ILInjected.Token(Token = "0x4007989")]
		public const int maxLiquidTypes = 4;

		[global::Cpp2ILInjected.Token(Token = "0x400798A")]
		public const int maxSkyGradients = 256;

		[global::Cpp2ILInjected.Token(Token = "0x400798B")]
		public const int maxDirtGradients = 256;

		[global::Cpp2ILInjected.Token(Token = "0x400798C")]
		public const int maxRockGradients = 256;

		[global::Cpp2ILInjected.Token(Token = "0x400798D")]
		public static int[] tileOptionCounts;

		[global::Cpp2ILInjected.Token(Token = "0x400798E")]
		public static int[] wallOptionCounts;

		[global::Cpp2ILInjected.Token(Token = "0x400798F")]
		public static ushort[] tileLookup;

		[global::Cpp2ILInjected.Token(Token = "0x4007990")]
		public static ushort[] wallLookup;

		[global::Cpp2ILInjected.Token(Token = "0x4007991")]
		private static ushort tilePosition;

		[global::Cpp2ILInjected.Token(Token = "0x4007992")]
		public static ushort wallPosition;

		[global::Cpp2ILInjected.Token(Token = "0x4007993")]
		public static ushort liquidPosition;

		[global::Cpp2ILInjected.Token(Token = "0x4007994")]
		public static ushort skyPosition;

		[global::Cpp2ILInjected.Token(Token = "0x4007995")]
		public static ushort dirtPosition;

		[global::Cpp2ILInjected.Token(Token = "0x4007996")]
		public static ushort rockPosition;

		[global::Cpp2ILInjected.Token(Token = "0x4007997")]
		public static ushort hellPosition;

		[global::Cpp2ILInjected.Token(Token = "0x4007998")]
		public static Microsoft.Xna.Framework.Graphics.Color[] colorLookup;

		[global::Cpp2ILInjected.Token(Token = "0x4007999")]
		public static Dictionary<ushort, bool> snowLookup;

		[global::Cpp2ILInjected.Token(Token = "0x400799A")]
		private static ushort wallRangeStart;

		[global::Cpp2ILInjected.Token(Token = "0x400799B")]
		private static ushort wallRangeEnd;

		[global::Cpp2ILInjected.Token(Token = "0x20006B4")]
		private class RunLengthEncodingCompressionProfile
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x400799C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public readonly uint BitCountPerValue;

			[global::Cpp2ILInjected.Token(Token = "0x400799D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
			public readonly uint BitCountForRunLengths;

			[global::Cpp2ILInjected.Token(Token = "0x400799E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public readonly uint MinRepeatsToUseRunLengthEncoding;

			[global::Cpp2ILInjected.Token(Token = "0x400799F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
			public readonly uint MaxCompressedValue;

			[global::Cpp2ILInjected.Token(Token = "0x40079A0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public readonly uint MaxRunLengthRepeatValue;
		}

		[global::Cpp2ILInjected.Token(Token = "0x20006B5")]
		private struct OldMapHelper
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003902")]
			[global::Cpp2ILInjected.Address(RVA = "0x1445C70", Offset = "0x1445C70", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool active()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6003903")]
			[global::Cpp2ILInjected.Address(RVA = "0x1445C7C", Offset = "0x1445C7C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool water()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6003904")]
			[global::Cpp2ILInjected.Address(RVA = "0x1445C88", Offset = "0x1445C88", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool lava()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6003905")]
			[global::Cpp2ILInjected.Address(RVA = "0x1445C94", Offset = "0x1445C94", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool honey()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6003906")]
			[global::Cpp2ILInjected.Address(RVA = "0x14475D4", Offset = "0x14475D4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool changed()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6003907")]
			[global::Cpp2ILInjected.Address(RVA = "0x1445CA0", Offset = "0x1445CA0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool wall()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6003908")]
			[global::Cpp2ILInjected.Address(RVA = "0x1445C48", Offset = "0x1445C48", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public byte option()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6003909")]
			[global::Cpp2ILInjected.Address(RVA = "0x14475E0", Offset = "0x14475E0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public byte color()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x40079A1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public byte misc;

			[global::Cpp2ILInjected.Token(Token = "0x40079A2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x1")]
			public byte misc2;
		}

		[global::Cpp2ILInjected.Token(Token = "0x20006B6")]
		public class BitReader
		{
			[global::Cpp2ILInjected.Token(Token = "0x600390A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1444D0C", Offset = "0x1444D0C", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public BitReader(Stream input)
			{
				throw null;
			}

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

			[global::Cpp2ILInjected.Token(Token = "0x40079A3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private readonly Stream InnerStream;

			[global::Cpp2ILInjected.Token(Token = "0x40079A4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private byte CurByteOfData;

			[global::Cpp2ILInjected.Token(Token = "0x40079A5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
			private uint CurBit;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20006B7")]
		private sealed class <>c__DisplayClass72_0
		{
			[global::Cpp2ILInjected.Token(Token = "0x600390C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1445260", Offset = "0x1445260", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass72_0()
			{
				throw null;
			}

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

			[global::Cpp2ILInjected.Token(Token = "0x40079A6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public MapHelper.RunLengthEncodingCompressionProfile lightCompressionProfile;
		}
	}
}
