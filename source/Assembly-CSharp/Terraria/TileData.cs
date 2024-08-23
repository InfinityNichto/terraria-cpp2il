using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent.Biomes;
using Terraria.GameContent.Biomes.Desert;
using Terraria.GameContent.Drawing;
using Terraria.GameContent.Generation;
using Terraria.IO;
using Terraria.WorldBuilding;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;

namespace Terraria
{
	// Token: 0x0200034A RID: 842
	[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
	[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
	[global::Cpp2ILInjected.Token(Token = "0x2000460")]
	public class TileData
	{
		// Token: 0x060027FF RID: 10239 RVA: 0x00029234 File Offset: 0x00027434
		[global::Cpp2ILInjected.Token(Token = "0x6002AB9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1175670", Offset = "0x1175670", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoUpdate", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "WaterCheck", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGenerator), Member = "GenerateWorld", MemberParameters = new object[] { typeof(GenerationProgress) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void ReleasePointers()
		{
			throw null;
		}

		// Token: 0x06002800 RID: 10240 RVA: 0x00029237 File Offset: 0x00027437
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6002ABA")]
		[global::Cpp2ILInjected.Address(RVA = "0x11756E4", Offset = "0x11756E4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "tileCountAndDestroy", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "tileCounter", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "tileCounterNext", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ShapeFloodFill), Member = "Perform", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(GenAction)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		public Tile Safe(int x, int y)
		{
			throw null;
		}

		// Token: 0x06002801 RID: 10241 RVA: 0x0002923A File Offset: 0x0002743A
		[global::Cpp2ILInjected.Token(Token = "0x6002ABB")]
		[global::Cpp2ILInjected.Address(RVA = "0x11756F0", Offset = "0x11756F0", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "SaveWorldTilesFast", MemberParameters = new object[] { typeof(BinaryWriter) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public bool ConfirmWidthHeight(int width, int height)
		{
			throw null;
		}

		// Token: 0x1700058B RID: 1419
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x170005F7")]
		public Tile this[int x, int y]
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002ABC")]
			[global::Cpp2ILInjected.Address(RVA = "0x116F670", Offset = "0x116F670", Length = "0x98")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7920)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002803 RID: 10243 RVA: 0x00029240 File Offset: 0x00027440
		[global::Cpp2ILInjected.Token(Token = "0x6002ABD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1175714", Offset = "0x1175714", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static long CalculateWorldTileSize(int x, int y)
		{
			throw null;
		}

		// Token: 0x06002804 RID: 10244 RVA: 0x00029243 File Offset: 0x00027443
		[global::Cpp2ILInjected.Token(Token = "0x6002ABE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1175794", Offset = "0x1175794", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static long CalculateStorageSize(int size)
		{
			throw null;
		}

		// Token: 0x06002805 RID: 10245 RVA: 0x00029246 File Offset: 0x00027446
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6002ABF")]
		[global::Cpp2ILInjected.Address(RVA = "0x11757B8", Offset = "0x11757B8", Length = "0x31C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageBuffer), Member = "ProcessData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "SetWorldSizeOnMainThread", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUILowMemoryPopup), Member = "get_DeviceMemory", ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnsafeUtility), Member = "Free", MemberParameters = new object[]
		{
			typeof(void*),
			typeof(Allocator)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnsafeUtility), Member = "AlignOf", MemberTypeParameters = new object[] { "T" }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnsafeUtility), Member = "Malloc", MemberParameters = new object[]
		{
			typeof(long),
			typeof(int),
			typeof(Allocator)
		}, ReturnType = typeof(void*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnsafeUtility), Member = "MemClear", MemberParameters = new object[]
		{
			typeof(void*),
			typeof(long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public unsafe void Allocate(int x, int y)
		{
			throw null;
		}

		// Token: 0x06002806 RID: 10246 RVA: 0x00029249 File Offset: 0x00027449
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6002AC0")]
		[global::Cpp2ILInjected.Address(RVA = "0x117342C", Offset = "0x117342C", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "GetTileDefinition", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ushort),
			typeof(short),
			typeof(short),
			typeof(short),
			typeof(byte),
			typeof(byte),
			typeof(byte)
		}, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "ReleaseTileDefinition", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void ClearEverything(int tileIndex)
		{
			throw null;
		}

		// Token: 0x06002807 RID: 10247 RVA: 0x0002924C File Offset: 0x0002744C
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6002AC1")]
		[global::Cpp2ILInjected.Address(RVA = "0x11735A8", Offset = "0x11735A8", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "GetTileDefinition", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ushort),
			typeof(short),
			typeof(short),
			typeof(short),
			typeof(byte),
			typeof(byte),
			typeof(byte)
		}, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "ReleaseTileDefinition", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void SetEverything(int tileIndex, ushort tileType, short tileSHeader, short frameX, short frameY, byte tileBHeader, byte tileBHeader2, byte tileBHeader3, byte wall, byte liquid)
		{
			throw null;
		}

		// Token: 0x06002808 RID: 10248 RVA: 0x0002924F File Offset: 0x0002744F
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6002AC2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1171AA4", Offset = "0x1171AA4", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "GetTileDefinition", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ushort),
			typeof(short),
			typeof(short),
			typeof(short),
			typeof(byte),
			typeof(byte),
			typeof(byte)
		}, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "ReleaseTileDefinition", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void ReregisterTile(int tileIndex)
		{
			throw null;
		}

		// Token: 0x06002809 RID: 10249 RVA: 0x00029252 File Offset: 0x00027452
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6002AC3")]
		[global::Cpp2ILInjected.Address(RVA = "0x11719B8", Offset = "0x11719B8", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static bool HasBeenLoaded(int tileIndex)
		{
			throw null;
		}

		// Token: 0x0600280A RID: 10250 RVA: 0x00029255 File Offset: 0x00027455
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6002AC4")]
		[global::Cpp2ILInjected.Address(RVA = "0x117604C", Offset = "0x117604C", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static ushort GetType(int tileIndex)
		{
			throw null;
		}

		// Token: 0x0600280B RID: 10251 RVA: 0x00029258 File Offset: 0x00027458
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6002AC5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1171BAC", Offset = "0x1171BAC", Length = "0x16C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Liquid), Member = "DelWater", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "SetType", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen.<>c", Member = "<GenerateWorld>b__277_98", MemberParameters = new object[]
		{
			typeof(GenerationProgress),
			typeof(GameConfiguration)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "UpdateWorld_OvergroundTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "UpdateWorld_UndergroundTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "TileRunner", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(double),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(double),
			typeof(double),
			typeof(bool),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SandMound), Member = "<Place>g__PlaceSandColumn|0_0", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(ref SandMound.<>c__DisplayClass0_0)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 22)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "GetTileDefinition", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ushort),
			typeof(short),
			typeof(short),
			typeof(short),
			typeof(byte),
			typeof(byte),
			typeof(byte)
		}, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "ReleaseTileDefinition", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static void SetType(int tileIndex, ushort newType)
		{
			throw null;
		}

		// Token: 0x0600280C RID: 10252 RVA: 0x0002925B File Offset: 0x0002745B
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6002AC6")]
		[global::Cpp2ILInjected.Address(RVA = "0x11760B4", Offset = "0x11760B4", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static short GetSHeader(int tileIndex)
		{
			throw null;
		}

		// Token: 0x0600280D RID: 10253 RVA: 0x0002925E File Offset: 0x0002745E
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6002AC7")]
		[global::Cpp2ILInjected.Address(RVA = "0x11721C0", Offset = "0x11721C0", Length = "0x174")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "SetSTileHeader", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "wire", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "wire2", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "wire3", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "wire4", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "halfBrick", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "actuator", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "inActive", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "active", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen.<>c", Member = "<GenerateWorld>b__277_52", MemberParameters = new object[]
		{
			typeof(GenerationProgress),
			typeof(GameConfiguration)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen.<>c", Member = "<GenerateWorld>b__277_98", MemberParameters = new object[]
		{
			typeof(GenerationProgress),
			typeof(GameConfiguration)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "TileRunner", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(double),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(double),
			typeof(double),
			typeof(bool),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "<GenerateWorld>g__TileActiveSet|277_113", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool),
			typeof(ref WorldGen.<>c__DisplayClass277_2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "<GenerateWorld>g__Main_tile_slope_set|277_117", MemberParameters = new object[]
		{
			typeof(int),
			typeof(short),
			typeof(ref WorldGen.<>c__DisplayClass277_2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "<GenerateWorld>g__Main_tile_halfBrick_set|277_119", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool),
			typeof(ref WorldGen.<>c__DisplayClass277_2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SandMound), Member = "Place", MemberParameters = new object[] { typeof(DesertDescription) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SandMound), Member = "<Place>g__PlaceSandColumn|0_0", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(ref SandMound.<>c__DisplayClass0_0)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 28)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "GetTileDefinition", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ushort),
			typeof(short),
			typeof(short),
			typeof(short),
			typeof(byte),
			typeof(byte),
			typeof(byte)
		}, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "ReleaseTileDefinition", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static void SetSHeader(int tileIndex, short sHeader)
		{
			throw null;
		}

		// Token: 0x0600280E RID: 10254 RVA: 0x00029261 File Offset: 0x00027461
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6002AC8")]
		[global::Cpp2ILInjected.Address(RVA = "0x117612C", Offset = "0x117612C", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static short GetFrameX(int tileIndex)
		{
			throw null;
		}

		// Token: 0x0600280F RID: 10255 RVA: 0x00029264 File Offset: 0x00027464
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6002AC9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1172CE8", Offset = "0x1172CE8", Length = "0x148")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen.<>c", Member = "<GenerateWorld>b__277_98", MemberParameters = new object[]
		{
			typeof(GenerationProgress),
			typeof(GameConfiguration)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "GetTileDefinition", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ushort),
			typeof(short),
			typeof(short),
			typeof(short),
			typeof(byte),
			typeof(byte),
			typeof(byte)
		}, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "ReleaseTileDefinition", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static void SetFrameXY(int tileIndex, short frameX, short frameY)
		{
			throw null;
		}

		// Token: 0x06002810 RID: 10256 RVA: 0x00029267 File Offset: 0x00027467
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6002ACA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1172AF8", Offset = "0x1172AF8", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "SetFrameX", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "OffsetFrameX", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "UpdateWorld_OvergroundTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "UpdateWorld_UndergroundTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "GetTileDefinition", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ushort),
			typeof(short),
			typeof(short),
			typeof(short),
			typeof(byte),
			typeof(byte),
			typeof(byte)
		}, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "ReleaseTileDefinition", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void SetFrameX(int tileIndex, short frameX)
		{
			throw null;
		}

		// Token: 0x06002811 RID: 10257 RVA: 0x0002926A File Offset: 0x0002746A
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6002ACB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1176194", Offset = "0x1176194", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static short GetFrameY(int tileIndex)
		{
			throw null;
		}

		// Token: 0x06002812 RID: 10258 RVA: 0x0002926D File Offset: 0x0002746D
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6002ACC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1172F10", Offset = "0x1172F10", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "SetFrameY", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "OffsetFrameY", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "BitWiseOrFrameY", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "GetTileDefinition", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ushort),
			typeof(short),
			typeof(short),
			typeof(short),
			typeof(byte),
			typeof(byte),
			typeof(byte)
		}, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "ReleaseTileDefinition", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void SetFrameY(int tileIndex, short frameY)
		{
			throw null;
		}

		// Token: 0x06002813 RID: 10259 RVA: 0x00029270 File Offset: 0x00027470
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6002ACD")]
		[global::Cpp2ILInjected.Address(RVA = "0x11731D8", Offset = "0x11731D8", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static ushort GetSearchUID(int tileIndex)
		{
			throw null;
		}

		// Token: 0x06002814 RID: 10260 RVA: 0x00029273 File Offset: 0x00027473
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6002ACE")]
		[global::Cpp2ILInjected.Address(RVA = "0x11732A4", Offset = "0x11732A4", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void SetSearchUID(int tileIndex, ushort value)
		{
			throw null;
		}

		// Token: 0x06002815 RID: 10261 RVA: 0x00029276 File Offset: 0x00027476
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6002ACF")]
		[global::Cpp2ILInjected.Address(RVA = "0x11742CC", Offset = "0x11742CC", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool GetCheckingLiquid(int tileIndex)
		{
			throw null;
		}

		// Token: 0x06002816 RID: 10262 RVA: 0x00029279 File Offset: 0x00027479
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6002AD0")]
		[global::Cpp2ILInjected.Address(RVA = "0x117439C", Offset = "0x117439C", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Liquid), Member = "DelWater", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void SetCheckingLiquid(int tileIndex, bool checkingLiquid)
		{
			throw null;
		}

		// Token: 0x06002817 RID: 10263 RVA: 0x0002927C File Offset: 0x0002747C
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6002AD1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1174474", Offset = "0x1174474", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool GetSkipLiquid(int tileIndex)
		{
			throw null;
		}

		// Token: 0x06002818 RID: 10264 RVA: 0x0002927F File Offset: 0x0002747F
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6002AD2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1174540", Offset = "0x1174540", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void SetSkipLiquid(int tileIndex, bool skipLiquid)
		{
			throw null;
		}

		// Token: 0x06002819 RID: 10265 RVA: 0x00029282 File Offset: 0x00027482
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6002AD3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1174618", Offset = "0x1174618", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool GetTileFramed(int tileIndex)
		{
			throw null;
		}

		// Token: 0x0600281A RID: 10266 RVA: 0x00029285 File Offset: 0x00027485
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6002AD4")]
		[global::Cpp2ILInjected.Address(RVA = "0x11746E4", Offset = "0x11746E4", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void SetTileFramed(int tileIndex, bool framed)
		{
			throw null;
		}

		// Token: 0x0600281B RID: 10267 RVA: 0x00029288 File Offset: 0x00027488
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6002AD5")]
		[global::Cpp2ILInjected.Address(RVA = "0x11761FC", Offset = "0x11761FC", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static ushort GetWall(int tileIndex)
		{
			throw null;
		}

		// Token: 0x0600281C RID: 10268 RVA: 0x0002928B File Offset: 0x0002748B
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6002AD6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1171E4C", Offset = "0x1171E4C", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "SetWall", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "TileRunner", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(double),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(double),
			typeof(double),
			typeof(bool),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void SetWall(int tileIndex, ushort wall)
		{
			throw null;
		}

		// Token: 0x0600281D RID: 10269 RVA: 0x0002928E File Offset: 0x0002748E
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6002AD7")]
		[global::Cpp2ILInjected.Address(RVA = "0x117625C", Offset = "0x117625C", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static byte GetLiquid(int tileIndex)
		{
			throw null;
		}

		// Token: 0x0600281E RID: 10270 RVA: 0x00029291 File Offset: 0x00027491
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6002AD8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1172004", Offset = "0x1172004", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "SetLiquid", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void SetLiquid(int tileIndex, byte liquid)
		{
			throw null;
		}

		// Token: 0x0600281F RID: 10271 RVA: 0x00029294 File Offset: 0x00027494
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6002AD9")]
		[global::Cpp2ILInjected.Address(RVA = "0x11762BC", Offset = "0x11762BC", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static byte GetBHeader(int tileIndex)
		{
			throw null;
		}

		// Token: 0x06002820 RID: 10272 RVA: 0x00029297 File Offset: 0x00027497
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6002ADA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1172470", Offset = "0x1172470", Length = "0x114")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Liquid), Member = "Update", MemberParameters = new object[]
		{
			typeof(int),
			typeof(uint*),
			typeof(ushort*),
			typeof(short*),
			typeof(byte*),
			typeof(byte*),
			typeof(ushort*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Framing), Member = "WallFrame", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "SetBTileHeader", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "wallColor", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "lava", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "honey", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "liquidType", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 27)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "GetTileDefinition", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ushort),
			typeof(short),
			typeof(short),
			typeof(short),
			typeof(byte),
			typeof(byte),
			typeof(byte)
		}, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "ReleaseTileDefinition", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public unsafe static void SetBHeader(int tileIndex, byte bHeader)
		{
			throw null;
		}

		// Token: 0x06002821 RID: 10273 RVA: 0x0002929A File Offset: 0x0002749A
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6002ADB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1176324", Offset = "0x1176324", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static byte GetBHeader2(int tileIndex)
		{
			throw null;
		}

		// Token: 0x06002822 RID: 10274 RVA: 0x0002929D File Offset: 0x0002749D
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6002ADC")]
		[global::Cpp2ILInjected.Address(RVA = "0x11726C0", Offset = "0x11726C0", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Framing), Member = "WallFrame", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "SetBTileHeader2", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "GetTileDefinition", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ushort),
			typeof(short),
			typeof(short),
			typeof(short),
			typeof(byte),
			typeof(byte),
			typeof(byte)
		}, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "ReleaseTileDefinition", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void SetBHeader2(int tileIndex, byte bHeader2)
		{
			throw null;
		}

		// Token: 0x06002823 RID: 10275 RVA: 0x000292A0 File Offset: 0x000274A0
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6002ADD")]
		[global::Cpp2ILInjected.Address(RVA = "0x117638C", Offset = "0x117638C", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "ReleaseTileDefinition", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void CopyTileBasic(int tileIndex, int srcTile)
		{
			throw null;
		}

		// Token: 0x06002824 RID: 10276 RVA: 0x000292A3 File Offset: 0x000274A3
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6002ADE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1173754", Offset = "0x1173754", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "ReleaseTileDefinition", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void CopyTile(int tileIndex, int srcTile)
		{
			throw null;
		}

		// Token: 0x06002825 RID: 10277 RVA: 0x000292A6 File Offset: 0x000274A6
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6002ADF")]
		[global::Cpp2ILInjected.Address(RVA = "0x117640C", Offset = "0x117640C", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTiles_EmitParticles", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ushort),
			typeof(short),
			typeof(short),
			typeof(Microsoft.Xna.Framework.Graphics.Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static byte GetBHeader3(int tileIndex)
		{
			throw null;
		}

		// Token: 0x06002826 RID: 10278 RVA: 0x000292A9 File Offset: 0x000274A9
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6002AE0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1172914", Offset = "0x1172914", Length = "0x114")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Framing), Member = "WallFrame", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "SetBTileHeader3", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "GetTileDefinition", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ushort),
			typeof(short),
			typeof(short),
			typeof(short),
			typeof(byte),
			typeof(byte),
			typeof(byte)
		}, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "ReleaseTileDefinition", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void SetBHeader3(int tileIndex, byte bHeader3)
		{
			throw null;
		}

		// Token: 0x06002827 RID: 10279 RVA: 0x000292AC File Offset: 0x000274AC
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6002AE1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1176474", Offset = "0x1176474", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileData), Member = "GetTileDefinition", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ushort),
			typeof(short),
			typeof(short),
			typeof(short),
			typeof(byte),
			typeof(byte),
			typeof(byte)
		}, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static uint GetFreeListEntry()
		{
			throw null;
		}

		// Token: 0x06002828 RID: 10280 RVA: 0x000292AF File Offset: 0x000274AF
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6002AE2")]
		[global::Cpp2ILInjected.Address(RVA = "0x11764E8", Offset = "0x11764E8", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileData), Member = "ReleaseTileDefinition", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static void AddFreeEntry(uint tileDefinition)
		{
			throw null;
		}

		// Token: 0x06002829 RID: 10281 RVA: 0x000292B2 File Offset: 0x000274B2
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6002AE3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1175AD4", Offset = "0x1175AD4", Length = "0x3B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldConsole), Member = "LoadWorldTiles", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(bool[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldSwitch), Member = "LoadWorldTiles", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(bool[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileData), Member = "ClearEverything", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileData), Member = "SetEverything", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ushort),
			typeof(short),
			typeof(short),
			typeof(short),
			typeof(byte),
			typeof(byte),
			typeof(byte),
			typeof(byte),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileData), Member = "ReregisterTile", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileData), Member = "SetType", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ushort)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileData), Member = "SetSHeader", MemberParameters = new object[]
		{
			typeof(int),
			typeof(short)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileData), Member = "SetFrameXY", MemberParameters = new object[]
		{
			typeof(int),
			typeof(short),
			typeof(short)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileData), Member = "SetFrameX", MemberParameters = new object[]
		{
			typeof(int),
			typeof(short)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileData), Member = "SetFrameY", MemberParameters = new object[]
		{
			typeof(int),
			typeof(short)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileData), Member = "SetBHeader", MemberParameters = new object[]
		{
			typeof(int),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileData), Member = "SetBHeader2", MemberParameters = new object[]
		{
			typeof(int),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileData), Member = "SetBHeader3", MemberParameters = new object[]
		{
			typeof(int),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "LoadWorldTiles", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(bool[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TerrainPass), Member = "ApplyPass", MemberParameters = new object[]
		{
			typeof(GenerationProgress),
			typeof(GameConfiguration)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 17)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "GetFreeListEntry", ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public static uint GetTileDefinition(int tileIndex, ushort tileType, short tileSHeader, short frameX, short frameY, byte tileBHeader, byte tileBHeader2, byte tileBHeader3)
		{
			throw null;
		}

		// Token: 0x0600282A RID: 10282 RVA: 0x000292B5 File Offset: 0x000274B5
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6002AE4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1175E8C", Offset = "0x1175E8C", Length = "0x1C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileData), Member = "ClearEverything", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileData), Member = "SetEverything", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ushort),
			typeof(short),
			typeof(short),
			typeof(short),
			typeof(byte),
			typeof(byte),
			typeof(byte),
			typeof(byte),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileData), Member = "ReregisterTile", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileData), Member = "SetType", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ushort)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileData), Member = "SetSHeader", MemberParameters = new object[]
		{
			typeof(int),
			typeof(short)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileData), Member = "SetFrameXY", MemberParameters = new object[]
		{
			typeof(int),
			typeof(short),
			typeof(short)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileData), Member = "SetFrameX", MemberParameters = new object[]
		{
			typeof(int),
			typeof(short)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileData), Member = "SetFrameY", MemberParameters = new object[]
		{
			typeof(int),
			typeof(short)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileData), Member = "SetBHeader", MemberParameters = new object[]
		{
			typeof(int),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileData), Member = "SetBHeader2", MemberParameters = new object[]
		{
			typeof(int),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileData), Member = "CopyTileBasic", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileData), Member = "CopyTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileData), Member = "SetBHeader3", MemberParameters = new object[]
		{
			typeof(int),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "AddFreeEntry", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static void ReleaseTileDefinition(uint tileDefinition)
		{
			throw null;
		}

		// Token: 0x0600282B RID: 10283 RVA: 0x000292B8 File Offset: 0x000274B8
		[global::Cpp2ILInjected.Token(Token = "0x6002AE5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1176564", Offset = "0x1176564", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public TileData()
		{
			throw null;
		}

		// Token: 0x0600282C RID: 10284 RVA: 0x000292BB File Offset: 0x000274BB
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6002AE6")]
		[global::Cpp2ILInjected.Address(RVA = "0x117656C", Offset = "0x117656C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static TileData()
		{
			throw null;
		}

		// Token: 0x04002F72 RID: 12146
		[global::Cpp2ILInjected.Token(Token = "0x4003752")]
		public unsafe static uint* tileLookupPtr;

		// Token: 0x04002F73 RID: 12147
		[global::Cpp2ILInjected.Token(Token = "0x4003753")]
		public unsafe static ushort* tileTypeDataPtr;

		// Token: 0x04002F74 RID: 12148
		[global::Cpp2ILInjected.Token(Token = "0x4003754")]
		public unsafe static short* tileTypeSHeaderPtr;

		// Token: 0x04002F75 RID: 12149
		[global::Cpp2ILInjected.Token(Token = "0x4003755")]
		public unsafe static byte* tileTypeBHeaderPtr;

		// Token: 0x04002F76 RID: 12150
		[global::Cpp2ILInjected.Token(Token = "0x4003756")]
		public unsafe static byte* tileTypeLiquidPtr;

		// Token: 0x04002F77 RID: 12151
		[global::Cpp2ILInjected.Token(Token = "0x4003757")]
		public unsafe static short* tileTypeFrameXPtr;

		// Token: 0x04002F78 RID: 12152
		[global::Cpp2ILInjected.Token(Token = "0x4003758")]
		public unsafe static short* tileTypeFrameYPtr;

		// Token: 0x04002F79 RID: 12153
		[global::Cpp2ILInjected.Token(Token = "0x4003759")]
		public unsafe static ushort* tileWallDataPtr;

		// Token: 0x04002F7A RID: 12154
		[global::Cpp2ILInjected.Token(Token = "0x400375A")]
		public static long NPCState;

		// Token: 0x04002F7B RID: 12155
		[global::Cpp2ILInjected.Token(Token = "0x400375B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int _width;

		// Token: 0x04002F7C RID: 12156
		[global::Cpp2ILInjected.Token(Token = "0x400375C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private int _height;

		// Token: 0x04002F7D RID: 12157
		[global::Cpp2ILInjected.Token(Token = "0x400375D")]
		private const int TileBufferSize = 200000;

		// Token: 0x04002F7E RID: 12158
		[global::Cpp2ILInjected.Token(Token = "0x400375E")]
		private const uint TileBufferNoEntry = 4294967295U;

		// Token: 0x04002F7F RID: 12159
		[global::Cpp2ILInjected.Token(Token = "0x400375F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int bufferSize;

		// Token: 0x04002F80 RID: 12160
		[global::Cpp2ILInjected.Token(Token = "0x4003760")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private unsafe byte* memorybuffer;

		// Token: 0x04002F81 RID: 12161
		[global::Cpp2ILInjected.Token(Token = "0x4003761")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private long actualBufferSize;

		// Token: 0x04002F82 RID: 12162
		[global::Cpp2ILInjected.Token(Token = "0x4003762")]
		public unsafe static uint* TileLookup;

		// Token: 0x04002F83 RID: 12163
		[global::Cpp2ILInjected.Token(Token = "0x4003763")]
		public unsafe static int* TileReferenceCount;

		// Token: 0x04002F84 RID: 12164
		[global::Cpp2ILInjected.Token(Token = "0x4003764")]
		private static uint FreeTiles;

		// Token: 0x04002F85 RID: 12165
		[global::Cpp2ILInjected.Token(Token = "0x4003765")]
		public unsafe static ushort* TileSeachUID;

		// Token: 0x04002F86 RID: 12166
		[global::Cpp2ILInjected.Token(Token = "0x4003766")]
		private static int TotalTileCount;

		// Token: 0x04002F87 RID: 12167
		[global::Cpp2ILInjected.Token(Token = "0x4003767")]
		private unsafe static uint* TileLists;

		// Token: 0x04002F88 RID: 12168
		[global::Cpp2ILInjected.Token(Token = "0x4003768")]
		private unsafe static uint* TileListNext;

		// Token: 0x04002F89 RID: 12169
		[global::Cpp2ILInjected.Token(Token = "0x4003769")]
		private unsafe static uint* TileListPrevious;

		// Token: 0x04002F8A RID: 12170
		[global::Cpp2ILInjected.Token(Token = "0x400376A")]
		public unsafe static ushort* TileType;

		// Token: 0x04002F8B RID: 12171
		[global::Cpp2ILInjected.Token(Token = "0x400376B")]
		public unsafe static short* TileSHeader;

		// Token: 0x04002F8C RID: 12172
		[global::Cpp2ILInjected.Token(Token = "0x400376C")]
		public unsafe static short* TileFrameX;

		// Token: 0x04002F8D RID: 12173
		[global::Cpp2ILInjected.Token(Token = "0x400376D")]
		public unsafe static short* TileFrameY;

		// Token: 0x04002F8E RID: 12174
		[global::Cpp2ILInjected.Token(Token = "0x400376E")]
		public unsafe static ushort* TileWall;

		// Token: 0x04002F8F RID: 12175
		[global::Cpp2ILInjected.Token(Token = "0x400376F")]
		public unsafe static byte* TileLiquid;

		// Token: 0x04002F90 RID: 12176
		[global::Cpp2ILInjected.Token(Token = "0x4003770")]
		public unsafe static byte* TileBHeader;

		// Token: 0x04002F91 RID: 12177
		[global::Cpp2ILInjected.Token(Token = "0x4003771")]
		public unsafe static byte* TileBHeader2;

		// Token: 0x04002F92 RID: 12178
		[global::Cpp2ILInjected.Token(Token = "0x4003772")]
		public unsafe static byte* TileBHeader3;
	}
}
