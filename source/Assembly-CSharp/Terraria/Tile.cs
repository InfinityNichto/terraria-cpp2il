using System;
using System.Collections.Generic;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Utilities;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.GameContent;
using Terraria.GameContent.Biomes;
using Terraria.GameContent.Biomes.Desert;
using Terraria.GameContent.Drawing;
using Terraria.GameContent.Generation;
using Terraria.GameContent.NetModules;
using Terraria.GameContent.Tile_Entities;
using Terraria.GameContent.UI;
using Terraria.Graphics.Light;
using Terraria.IO;
using Terraria.Localization;
using Terraria.Map;
using Terraria.Utilities;
using Terraria.WorldBuilding;
using Unity.IL2CPP.CompilerServices;

namespace Terraria
{
	// Token: 0x02000348 RID: 840
	[global::Cpp2ILInjected.Token(Token = "0x200045E")]
	public struct Tile
	{
		// Token: 0x06002786 RID: 10118 RVA: 0x000290C9 File Offset: 0x000272C9
		[global::Cpp2ILInjected.Token(Token = "0x6002A40")]
		[global::Cpp2ILInjected.Address(RVA = "0x11718F8", Offset = "0x11718F8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "GetFloorTileType", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "SolidTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "SolidTile", MemberParameters = new object[]
		{
			typeof(Tile),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		public static bool operator ==(Tile a, Tile b)
		{
			throw null;
		}

		// Token: 0x06002787 RID: 10119 RVA: 0x000290CC File Offset: 0x000272CC
		[global::Cpp2ILInjected.Token(Token = "0x6002A41")]
		[global::Cpp2ILInjected.Address(RVA = "0x1171904", Offset = "0x1171904", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIcons), Member = "GetCategoryTexture", MemberParameters = new object[]
		{
			typeof(GUIPageIcons.Category),
			typeof(bool)
		}, ReturnType = typeof(Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "AddInteractBanner", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(Item)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetMessage), Member = "CompressTileBlock_Inner", MemberParameters = new object[]
		{
			typeof(BinaryWriter),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "Collision_MoveSlopesAndStairFall", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "FloorVisuals", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "KillTile_MakeTileDust", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(Tile)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		public static bool operator !=(Tile a, Tile b)
		{
			throw null;
		}

		// Token: 0x06002788 RID: 10120 RVA: 0x000290CF File Offset: 0x000272CF
		[global::Cpp2ILInjected.Token(Token = "0x6002A42")]
		[global::Cpp2ILInjected.Address(RVA = "0x1171910", Offset = "0x1171910", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public Tile(int tileOffset)
		{
			throw null;
		}

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x06002789 RID: 10121 RVA: 0x000290D2 File Offset: 0x000272D2
		[global::Cpp2ILInjected.Token(Token = "0x170005EB")]
		public bool IsLoaded
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002A43")]
			[global::Cpp2ILInjected.Address(RVA = "0x1171918", Offset = "0x1171918", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 145)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600278A RID: 10122 RVA: 0x000290D5 File Offset: 0x000272D5
		[global::Cpp2ILInjected.Token(Token = "0x6002A44")]
		[global::Cpp2ILInjected.Address(RVA = "0x1171A4C", Offset = "0x1171A4C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "ReregisterTiles", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void ReregisterTile()
		{
			throw null;
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x0600278B RID: 10123 RVA: 0x000290D8 File Offset: 0x000272D8
		// (set) Token: 0x0600278C RID: 10124 RVA: 0x000290DB File Offset: 0x000272DB
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x170005EC")]
		public ushort type
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002A45")]
			[global::Cpp2ILInjected.Address(RVA = "0x116F7E8", Offset = "0x116F7E8", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4312)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6002A46")]
			[global::Cpp2ILInjected.Address(RVA = "0x1171B44", Offset = "0x1171B44", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 656)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600278D RID: 10125 RVA: 0x000290DE File Offset: 0x000272DE
		[global::Cpp2ILInjected.Token(Token = "0x6002A47")]
		[global::Cpp2ILInjected.Address(RVA = "0x1171D18", Offset = "0x1171D18", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "ResetToType", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TilInfo_OldMobile), Member = "Load", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "SetType", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ushort)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void SetType(ushort type)
		{
			throw null;
		}

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x0600278E RID: 10126 RVA: 0x000290E1 File Offset: 0x000272E1
		// (set) Token: 0x0600278F RID: 10127 RVA: 0x000290E4 File Offset: 0x000272E4
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x170005ED")]
		public ushort wall
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002A48")]
			[global::Cpp2ILInjected.Address(RVA = "0x1171D80", Offset = "0x1171D80", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1195)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6002A49")]
			[global::Cpp2ILInjected.Address(RVA = "0x1171DE4", Offset = "0x1171DE4", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 192)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06002790 RID: 10128 RVA: 0x000290E7 File Offset: 0x000272E7
		[global::Cpp2ILInjected.Token(Token = "0x6002A4A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1171EB8", Offset = "0x1171EB8", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "MudWallRunner", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TilInfo_OldMobile), Member = "Load", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_wall", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "SetWall", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ushort)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void SetWall(ushort wall)
		{
			throw null;
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x06002791 RID: 10129 RVA: 0x000290EA File Offset: 0x000272EA
		// (set) Token: 0x06002792 RID: 10130 RVA: 0x000290ED File Offset: 0x000272ED
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x170005EE")]
		public byte liquid
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002A4B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1171F38", Offset = "0x1171F38", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 376)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6002A4C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1171F9C", Offset = "0x1171F9C", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 148)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06002793 RID: 10131 RVA: 0x000290F0 File Offset: 0x000272F0
		[global::Cpp2ILInjected.Token(Token = "0x6002A4D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1172070", Offset = "0x1172070", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "ResetToType", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "ClearMetadata", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen.<>c", Member = "<GenerateWorld>b__277_98", MemberParameters = new object[]
		{
			typeof(GenerationProgress),
			typeof(GameConfiguration)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TilInfo_OldMobile), Member = "Load", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "SetLiquid", MemberParameters = new object[]
		{
			typeof(int),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void SetLiquid(byte liquid)
		{
			throw null;
		}

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x06002794 RID: 10132 RVA: 0x000290F3 File Offset: 0x000272F3
		// (set) Token: 0x06002795 RID: 10133 RVA: 0x000290F6 File Offset: 0x000272F6
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x170005EF")]
		public short sTileHeader
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002A4E")]
			[global::Cpp2ILInjected.Address(RVA = "0x11720D8", Offset = "0x11720D8", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 107)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6002A4F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1172158", Offset = "0x1172158", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "SmoothSlope", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "TileFrameDoWork", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(bool),
				typeof(bool),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06002796 RID: 10134 RVA: 0x000290F9 File Offset: 0x000272F9
		[global::Cpp2ILInjected.Token(Token = "0x6002A50")]
		[global::Cpp2ILInjected.Address(RVA = "0x1172334", Offset = "0x1172334", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "ClearTile", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "slope", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "color", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "ResetToType", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "Clear", MemberParameters = new object[] { typeof(TileDataType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "CopyPaintAndCoating", MemberParameters = new object[] { typeof(Tile) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "ClearBlockPaintAndCoating", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "ClearMetadata", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileColorCache), Member = "ApplyToBlock", MemberParameters = new object[] { typeof(Tile) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile_PC), Member = "SmoothSlope", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "SetSHeader", MemberParameters = new object[]
		{
			typeof(int),
			typeof(short)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void SetSTileHeader(short value)
		{
			throw null;
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x06002797 RID: 10135 RVA: 0x000290FC File Offset: 0x000272FC
		// (set) Token: 0x06002798 RID: 10136 RVA: 0x000290FF File Offset: 0x000272FF
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x170005F0")]
		public byte bTileHeader
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002A51")]
			[global::Cpp2ILInjected.Address(RVA = "0x117239C", Offset = "0x117239C", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "isTheSameAs", MemberParameters = new object[] { typeof(Tile) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "wallColor", ReturnType = typeof(byte))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "wallColor", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "lava", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "lava", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "honey", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "honey", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "shimmer", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "shimmer", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "liquidType", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "liquidType", ReturnType = typeof(byte))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "WallColorAndCoating", ReturnType = typeof(TileColorCache))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile_PC), Member = "CopyFrom", MemberParameters = new object[] { typeof(Tile) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile_PC), Member = "isTheSameAs", MemberParameters = new object[] { typeof(Tile) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 16)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6002A52")]
			[global::Cpp2ILInjected.Address(RVA = "0x1172408", Offset = "0x1172408", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "shimmer", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "liquidType", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06002799 RID: 10137 RVA: 0x00029102 File Offset: 0x00027302
		[global::Cpp2ILInjected.Token(Token = "0x6002A53")]
		[global::Cpp2ILInjected.Address(RVA = "0x1172584", Offset = "0x1172584", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "ResetToType", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "ClearMetadata", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "SetBHeader", MemberParameters = new object[]
		{
			typeof(int),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void SetBTileHeader(byte value)
		{
			throw null;
		}

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x0600279A RID: 10138 RVA: 0x00029105 File Offset: 0x00027305
		// (set) Token: 0x0600279B RID: 10139 RVA: 0x00029108 File Offset: 0x00027308
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x170005F1")]
		public byte bTileHeader2
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002A54")]
			[global::Cpp2ILInjected.Address(RVA = "0x11725EC", Offset = "0x11725EC", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "wallFrameX", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "wallFrameX", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "frameNumber", ReturnType = typeof(byte))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "frameNumber", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "wallFrameNumber", ReturnType = typeof(byte))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "wallFrameNumber", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "Clear", MemberParameters = new object[] { typeof(TileDataType) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile_PC), Member = "CopyFrom", MemberParameters = new object[] { typeof(Tile) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6002A55")]
			[global::Cpp2ILInjected.Address(RVA = "0x1172658", Offset = "0x1172658", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600279C RID: 10140 RVA: 0x0002910B File Offset: 0x0002730B
		[global::Cpp2ILInjected.Token(Token = "0x6002A56")]
		[global::Cpp2ILInjected.Address(RVA = "0x11727D8", Offset = "0x11727D8", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "wallFrameX", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "frameNumber", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "wallFrameNumber", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "ResetToType", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "Clear", MemberParameters = new object[] { typeof(TileDataType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "ClearMetadata", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "SetBHeader2", MemberParameters = new object[]
		{
			typeof(int),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void SetBTileHeader2(byte value)
		{
			throw null;
		}

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x0600279D RID: 10141 RVA: 0x0002910E File Offset: 0x0002730E
		// (set) Token: 0x0600279E RID: 10142 RVA: 0x00029111 File Offset: 0x00027311
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x170005F2")]
		public byte bTileHeader3
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002A57")]
			[global::Cpp2ILInjected.Address(RVA = "0x1172840", Offset = "0x1172840", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "isTheSameAs", MemberParameters = new object[] { typeof(Tile) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "wallFrameY", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "wallFrameY", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "invisibleBlock", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "invisibleBlock", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "invisibleWall", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "invisibleWall", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "fullbrightBlock", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "fullbrightBlock", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "fullbrightWall", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "fullbrightWall", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "Clear", MemberParameters = new object[] { typeof(TileDataType) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "CopyPaintAndCoating", MemberParameters = new object[] { typeof(Tile) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "BlockColorAndCoating", ReturnType = typeof(TileColorCache))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "WallColorAndCoating", ReturnType = typeof(TileColorCache))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "ClearBlockPaintAndCoating", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "ClearWallPaintAndCoating", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile_PC), Member = "CopyFrom", MemberParameters = new object[] { typeof(Tile) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "TileFrameDoWork", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(bool),
				typeof(bool),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 31)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6002A58")]
			[global::Cpp2ILInjected.Address(RVA = "0x11728AC", Offset = "0x11728AC", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "invisibleBlock", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "invisibleWall", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "fullbrightBlock", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "fullbrightWall", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "ClearBlockPaintAndCoating", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "ClearWallPaintAndCoating", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "TileFrameDoWork", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(bool),
				typeof(bool),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600279F RID: 10143 RVA: 0x00029114 File Offset: 0x00027314
		[global::Cpp2ILInjected.Token(Token = "0x6002A59")]
		[global::Cpp2ILInjected.Address(RVA = "0x1172A28", Offset = "0x1172A28", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "wallFrameY", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "ResetToType", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "Clear", MemberParameters = new object[] { typeof(TileDataType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "ClearMetadata", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "SetBHeader3", MemberParameters = new object[]
		{
			typeof(int),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void SetBTileHeader3(byte value)
		{
			throw null;
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x060027A0 RID: 10144 RVA: 0x00029117 File Offset: 0x00027317
		// (set) Token: 0x060027A1 RID: 10145 RVA: 0x0002911A File Offset: 0x0002731A
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x170005F3")]
		public short frameX
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002A5A")]
			[global::Cpp2ILInjected.Address(RVA = "0x116F854", Offset = "0x116F854", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 985)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6002A5B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1172A90", Offset = "0x1172A90", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 697)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060027A2 RID: 10146 RVA: 0x0002911D File Offset: 0x0002731D
		[global::Cpp2ILInjected.Token(Token = "0x6002A5C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1172C10", Offset = "0x1172C10", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldConsole), Member = "CheckWeaponsRack", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldConsole), Member = "PlaceWeapon", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(Item)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldConsole), Member = "CheckMannequin", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldSwitch), Member = "CheckWeaponsRack", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldSwitch), Member = "PlaceWeapon", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(Item)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldSwitch), Member = "CheckMannequin", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldSwitch), Member = "LoadWorld_Version2", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "ResetToType", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "ClearMetadata", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TilInfo_OldMobile), Member = "CheckWeaponsRack", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TilInfo_OldMobile), Member = "PlaceWeapon", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(Item)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TilInfo_OldMobile), Member = "CheckMannequin", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 18)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "SetFrameX", MemberParameters = new object[]
		{
			typeof(int),
			typeof(short)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void SetFrameX(short value)
		{
			throw null;
		}

		// Token: 0x060027A3 RID: 10147 RVA: 0x00029120 File Offset: 0x00027320
		[global::Cpp2ILInjected.Token(Token = "0x6002A5D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1172C78", Offset = "0x1172C78", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "TileFrameDoWork", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TilInfo_OldMobile), Member = "Load", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "LoadWorld_Version2", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void SetFrameXY(short xValue, short yValue)
		{
			throw null;
		}

		// Token: 0x060027A4 RID: 10148 RVA: 0x00029123 File Offset: 0x00027323
		[global::Cpp2ILInjected.Token(Token = "0x6002A5E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1172E30", Offset = "0x1172E30", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameX", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "SetFrameX", MemberParameters = new object[]
		{
			typeof(int),
			typeof(short)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void OffsetFrameX(short value)
		{
			throw null;
		}

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x060027A5 RID: 10149 RVA: 0x00029126 File Offset: 0x00027326
		// (set) Token: 0x060027A6 RID: 10150 RVA: 0x00029129 File Offset: 0x00027329
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x170005F4")]
		public short frameY
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002A5F")]
			[global::Cpp2ILInjected.Address(RVA = "0x116FCE8", Offset = "0x116FCE8", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 698)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6002A60")]
			[global::Cpp2ILInjected.Address(RVA = "0x1172EA8", Offset = "0x1172EA8", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 406)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060027A7 RID: 10151 RVA: 0x0002912C File Offset: 0x0002732C
		[global::Cpp2ILInjected.Token(Token = "0x6002A61")]
		[global::Cpp2ILInjected.Address(RVA = "0x1173028", Offset = "0x1173028", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldConsole), Member = "CheckWeaponsRack", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldSwitch), Member = "CheckWeaponsRack", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldSwitch), Member = "LoadWorld_Version2", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "ResetToType", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "ClearMetadata", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TilInfo_OldMobile), Member = "FixChairFrame", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TilInfo_OldMobile), Member = "CheckWeaponsRack", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "SetFrameY", MemberParameters = new object[]
		{
			typeof(int),
			typeof(short)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void SetFrameY(short value)
		{
			throw null;
		}

		// Token: 0x060027A8 RID: 10152 RVA: 0x0002912F File Offset: 0x0002732F
		[global::Cpp2ILInjected.Token(Token = "0x6002A62")]
		[global::Cpp2ILInjected.Address(RVA = "0x1173090", Offset = "0x1173090", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameY", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "SetFrameY", MemberParameters = new object[]
		{
			typeof(int),
			typeof(short)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void OffsetFrameY(short value)
		{
			throw null;
		}

		// Token: 0x060027A9 RID: 10153 RVA: 0x00029132 File Offset: 0x00027332
		[global::Cpp2ILInjected.Token(Token = "0x6002A63")]
		[global::Cpp2ILInjected.Address(RVA = "0x1173108", Offset = "0x1173108", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameY", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "SetFrameY", MemberParameters = new object[]
		{
			typeof(int),
			typeof(short)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void BitWiseOrFrameY(short value)
		{
			throw null;
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x060027AA RID: 10154 RVA: 0x00029135 File Offset: 0x00027335
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x170005F5")]
		public ushort TileSeachUID
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002A64")]
			[global::Cpp2ILInjected.Address(RVA = "0x1173180", Offset = "0x1173180", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "PlotTileArea", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(Utils.TileActionAttempt)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen.Spread), Member = "Wall", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen.Spread), Member = "Wall2", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "nextDirtCount", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
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
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 40)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060027AB RID: 10155 RVA: 0x00029138 File Offset: 0x00027338
		[global::Cpp2ILInjected.Token(Token = "0x6002A65")]
		[global::Cpp2ILInjected.Address(RVA = "0x117323C", Offset = "0x117323C", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "PlotTileArea", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(Utils.TileActionAttempt)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen.Spread), Member = "Wall", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen.Spread), Member = "Wall2", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "nextDirtCount", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void SetTileSeachUID(ushort value)
		{
			throw null;
		}

		// Token: 0x060027AC RID: 10156 RVA: 0x0002913B File Offset: 0x0002733B
		[global::Cpp2ILInjected.Token(Token = "0x6002A66")]
		[global::Cpp2ILInjected.Address(RVA = "0x117331C", Offset = "0x117331C", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "PlotTileArea", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(Utils.TileActionAttempt)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen.Spread), Member = "Wall", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen.Spread), Member = "Wall2", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen.Spread), Member = "Spider", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "StartRoomCheck", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "nextCount", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "nextDirtCount", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "tileCounter", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "ShimmeratorNext", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ShapeFloodFill), Member = "Perform", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(GenAction)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void StartNewSearch()
		{
			throw null;
		}

		// Token: 0x060027AD RID: 10157 RVA: 0x0002913E File Offset: 0x0002733E
		[global::Cpp2ILInjected.Token(Token = "0x6002A67")]
		[global::Cpp2ILInjected.Address(RVA = "0x11733C0", Offset = "0x11733C0", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetMessage), Member = "DecompressTileBlock_Inner", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen.<>c", Member = "<GenerateWorld>b__277_104", MemberParameters = new object[]
		{
			typeof(GenerationProgress),
			typeof(GameConfiguration)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "makeTemple", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "MakeDungeon", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Actions.Clear), Member = "Apply", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int),
			typeof(int),
			typeof(object[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Passes.Clear), Member = "ApplyPass", MemberParameters = new object[]
		{
			typeof(GenerationProgress),
			typeof(GameConfiguration)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TrackGenerator), Member = "PlacePath", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DunesBiome), Member = "PlaceCurvedLine", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(Point),
			typeof(Point),
			"Terraria.GameContent.Biomes.DunesBiome.DunesDescription"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DesertHive), Member = "PlaceClustersArea", MemberParameters = new object[]
		{
			typeof(DesertDescription),
			"Terraria.GameContent.Biomes.Desert.DesertHive.ClusterGroup",
			typeof(Rectangle),
			typeof(DesertHive.PostPlacementEffect[,,]),
			typeof(Point)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PitEntrance), Member = "PlaceAt", MemberParameters = new object[]
		{
			typeof(DesertDescription),
			typeof(Point),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 22)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void ClearEverything()
		{
			throw null;
		}

		// Token: 0x060027AE RID: 10158 RVA: 0x00029141 File Offset: 0x00027341
		[global::Cpp2ILInjected.Token(Token = "0x6002A68")]
		[global::Cpp2ILInjected.Address(RVA = "0x11734E0", Offset = "0x11734E0", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void SetEverything(ushort tileType, short tileSHeader, short frameX, short frameY, byte tileBHeader, byte tileBHeader2, byte tileBHeader3, byte wall, byte liquid)
		{
			throw null;
		}

		// Token: 0x060027AF RID: 10159 RVA: 0x00029144 File Offset: 0x00027344
		[global::Cpp2ILInjected.Token(Token = "0x6002A69")]
		[global::Cpp2ILInjected.Address(RVA = "0x11736CC", Offset = "0x11736CC", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "BigMimicSummonCheck", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(Player)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen.<>c", Member = "<GenerateWorld>b__277_104", MemberParameters = new object[]
		{
			typeof(GenerationProgress),
			typeof(GameConfiguration)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "PlaceSandTrap", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "ShiftTrapdoor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "AttemptToGeneratePlanteraBulbAt", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "SpawnFallingBlockProjectile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(Tile),
			typeof(Tile),
			typeof(Tile),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldUtils), Member = "ClearTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeadMansChestBiome), Member = "ActuallyPlaceBoulderTrap", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_sTileHeader", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "SetSTileHeader", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(void))]
		public void ClearTile()
		{
			throw null;
		}

		// Token: 0x060027B0 RID: 10160 RVA: 0x00029147 File Offset: 0x00027347
		[global::Cpp2ILInjected.Token(Token = "0x6002A6A")]
		[global::Cpp2ILInjected.Address(RVA = "0x11736EC", Offset = "0x11736EC", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldConsole), Member = "LoadWorld_Version1", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldSwitch), Member = "LoadWorld_Version1", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetMessage), Member = "DecompressTileBlock_Inner", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TilInfo_OldMobile), Member = "Load", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "LoadWorld_Version1_Old_BeforeRelease88", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void CopyFrom(Tile from)
		{
			throw null;
		}

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x060027B1 RID: 10161 RVA: 0x0002914A File Offset: 0x0002734A
		[global::Cpp2ILInjected.Token(Token = "0x170005F6")]
		public int collisionType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002A6B")]
			[global::Cpp2ILInjected.Address(RVA = "0x11737F8", Offset = "0x11737F8", Length = "0x104")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_sTileHeader", ReturnType = typeof(short))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060027B2 RID: 10162 RVA: 0x0002914D File Offset: 0x0002734D
		[global::Cpp2ILInjected.Token(Token = "0x6002A6C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1173924", Offset = "0x1173924", Length = "0x254")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetMessage), Member = "CompressTileBlock_Inner", MemberParameters = new object[]
		{
			typeof(BinaryWriter),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "SaveWorldTiles", MemberParameters = new object[] { typeof(BinaryWriter) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_sTileHeader", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_wall", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_liquid", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_bTileHeader", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameX", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameY", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_bTileHeader3", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public bool isTheSameAs(Tile compTile)
		{
			throw null;
		}

		// Token: 0x060027B3 RID: 10163 RVA: 0x00029150 File Offset: 0x00027350
		[global::Cpp2ILInjected.Token(Token = "0x6002A6D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1173BE4", Offset = "0x1173BE4", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Actions.SetTileKeepWall), Member = "Apply", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int),
			typeof(int),
			typeof(object[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_bTileHeader2", ReturnType = typeof(byte))]
		public int wallFrameX()
		{
			throw null;
		}

		// Token: 0x060027B4 RID: 10164 RVA: 0x00029153 File Offset: 0x00027353
		[global::Cpp2ILInjected.Token(Token = "0x6002A6E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1173C00", Offset = "0x1173C00", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Actions.SetTileKeepWall), Member = "Apply", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int),
			typeof(int),
			typeof(object[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_bTileHeader2", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "SetBTileHeader2", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		public void wallFrameX(int wallFrameX)
		{
			throw null;
		}

		// Token: 0x060027B5 RID: 10165 RVA: 0x00029156 File Offset: 0x00027356
		[global::Cpp2ILInjected.Token(Token = "0x6002A6F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1173C44", Offset = "0x1173C44", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Actions.SetTileKeepWall), Member = "Apply", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int),
			typeof(int),
			typeof(object[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_bTileHeader3", ReturnType = typeof(byte))]
		public int wallFrameY()
		{
			throw null;
		}

		// Token: 0x060027B6 RID: 10166 RVA: 0x00029159 File Offset: 0x00027359
		[global::Cpp2ILInjected.Token(Token = "0x6002A70")]
		[global::Cpp2ILInjected.Address(RVA = "0x1173C60", Offset = "0x1173C60", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Actions.SetTileKeepWall), Member = "Apply", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int),
			typeof(int),
			typeof(object[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_bTileHeader3", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "SetBTileHeader3", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		public void wallFrameY(int wallFrameY)
		{
			throw null;
		}

		// Token: 0x060027B7 RID: 10167 RVA: 0x0002915C File Offset: 0x0002735C
		[global::Cpp2ILInjected.Token(Token = "0x6002A71")]
		[global::Cpp2ILInjected.Address(RVA = "0x1173B8C", Offset = "0x1173B8C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HitTile), Member = "DrawFreshAnimations", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawTileCracks", MemberParameters = new object[]
		{
			typeof(int),
			typeof(HitTile)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetMessage), Member = "SendData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(NetworkText),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetMessage), Member = "CompressTileBlock_Inner", MemberParameters = new object[]
		{
			typeof(BinaryWriter),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "PlaceThing_PaintScrapper_TryScrapping", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "coatingColors", MemberParameters = new object[]
		{
			typeof(Tile),
			typeof(bool)
		}, ReturnType = typeof(List<Color>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "paintCoatTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(byte),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "RefreshStrip", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "TileFrameDoWork", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "StopMergingByInvsibility", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(Tile),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "SaveWorldTiles", MemberParameters = new object[] { typeof(BinaryWriter) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MapHelper), Member = "CreateMapTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(byte)
		}, ReturnType = typeof(MapTile))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileLightScanner), Member = "LightIsBlocked", MemberParameters = new object[] { typeof(Tile) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileLightScanner), Member = "ApplyTileLight", MemberParameters = new object[]
		{
			typeof(Tile),
			typeof(int),
			typeof(int),
			typeof(ref FastRandom),
			typeof(ref Vector3)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileLightScanner), Member = "ApplySurfaceLight", MemberParameters = new object[]
		{
			typeof(Tile),
			typeof(int),
			typeof(int),
			typeof(ref Vector3)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmartCursorHelper), Member = "Step_PaintScrapper", MemberParameters = new object[]
		{
			"Terraria.GameContent.SmartCursorHelper.SmartCursorUsageInfo",
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmartCursorHelper), Member = "Step_PaintBrush", MemberParameters = new object[]
		{
			"Terraria.GameContent.SmartCursorHelper.SmartCursorUsageInfo",
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "IsVisible", MemberParameters = new object[] { typeof(Tile) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WallDrawing), Member = "FullTile", MemberParameters = new object[]
		{
			typeof(Tile),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 28)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_bTileHeader3", ReturnType = typeof(byte))]
		public bool invisibleBlock()
		{
			throw null;
		}

		// Token: 0x060027B8 RID: 10168 RVA: 0x0002915F File Offset: 0x0002735F
		[global::Cpp2ILInjected.Token(Token = "0x6002A72")]
		[global::Cpp2ILInjected.Address(RVA = "0x1173CA4", Offset = "0x1173CA4", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageBuffer), Member = "ProcessData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetMessage), Member = "DecompressTileBlock_Inner", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "CopyPaintAndCoating", MemberParameters = new object[] { typeof(Tile) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileColorCache), Member = "ApplyToBlock", MemberParameters = new object[] { typeof(Tile) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "paintCoatTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(byte),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_bTileHeader3", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "set_bTileHeader3", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		public void invisibleBlock(bool invisibleBlock)
		{
			throw null;
		}

		// Token: 0x060027B9 RID: 10169 RVA: 0x00029162 File Offset: 0x00027362
		[global::Cpp2ILInjected.Token(Token = "0x6002A73")]
		[global::Cpp2ILInjected.Address(RVA = "0x1173BA0", Offset = "0x1173BA0", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "WallLightAt", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawTileCracks", MemberParameters = new object[]
		{
			typeof(int),
			typeof(HitTile)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetMessage), Member = "SendData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(NetworkText),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetMessage), Member = "CompressTileBlock_Inner", MemberParameters = new object[]
		{
			typeof(BinaryWriter),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "PlaceThing_PaintScrapper_TryScrapping", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "coatingColors", MemberParameters = new object[]
		{
			typeof(Tile),
			typeof(bool)
		}, ReturnType = typeof(List<Color>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "paintCoatWall", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(byte),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "RefreshStrip", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "SaveWorldTiles", MemberParameters = new object[] { typeof(BinaryWriter) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MapHelper), Member = "CreateMapTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(byte)
		}, ReturnType = typeof(MapTile))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileLightScanner), Member = "ApplySurfaceLight", MemberParameters = new object[]
		{
			typeof(Tile),
			typeof(int),
			typeof(int),
			typeof(ref Vector3)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileLightScanner), Member = "ApplyHellLight", MemberParameters = new object[]
		{
			typeof(Tile),
			typeof(int),
			typeof(int),
			typeof(ref Vector3)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmartCursorHelper), Member = "Step_PaintScrapper", MemberParameters = new object[]
		{
			"Terraria.GameContent.SmartCursorHelper.SmartCursorUsageInfo",
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmartCursorHelper), Member = "Step_PaintRoller", MemberParameters = new object[]
		{
			"Terraria.GameContent.SmartCursorHelper.SmartCursorUsageInfo",
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 17)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_bTileHeader3", ReturnType = typeof(byte))]
		public bool invisibleWall()
		{
			throw null;
		}

		// Token: 0x060027BA RID: 10170 RVA: 0x00029165 File Offset: 0x00027365
		[global::Cpp2ILInjected.Token(Token = "0x6002A74")]
		[global::Cpp2ILInjected.Address(RVA = "0x1173CD8", Offset = "0x1173CD8", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageBuffer), Member = "ProcessData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetMessage), Member = "DecompressTileBlock_Inner", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileColorCache), Member = "ApplyToWall", MemberParameters = new object[] { typeof(Tile) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "paintCoatWall", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(byte),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_bTileHeader3", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "set_bTileHeader3", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		public void invisibleWall(bool invisibleWall)
		{
			throw null;
		}

		// Token: 0x060027BB RID: 10171 RVA: 0x00029168 File Offset: 0x00027368
		[global::Cpp2ILInjected.Token(Token = "0x6002A75")]
		[global::Cpp2ILInjected.Address(RVA = "0x1173BB4", Offset = "0x1173BB4", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetMessage), Member = "SendData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(NetworkText),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetMessage), Member = "CompressTileBlock_Inner", MemberParameters = new object[]
		{
			typeof(BinaryWriter),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "PlaceThing_PaintScrapper_TryScrapping", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "coatingColors", MemberParameters = new object[]
		{
			typeof(Tile),
			typeof(bool)
		}, ReturnType = typeof(List<Color>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "paintCoatTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(byte),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "SaveWorldTiles", MemberParameters = new object[] { typeof(BinaryWriter) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MapHelper), Member = "CreateMapTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(byte)
		}, ReturnType = typeof(MapTile))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmartCursorHelper), Member = "Step_PaintScrapper", MemberParameters = new object[]
		{
			"Terraria.GameContent.SmartCursorHelper.SmartCursorUsageInfo",
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmartCursorHelper), Member = "Step_PaintBrush", MemberParameters = new object[]
		{
			"Terraria.GameContent.SmartCursorHelper.SmartCursorUsageInfo",
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TEDisplayDoll), Member = "Draw", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTrees", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawGrass", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawAnyDirectionalGrass", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawMultiTileGrassInWind", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawMultiTileVinesInWind", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 19)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_bTileHeader3", ReturnType = typeof(byte))]
		public bool fullbrightBlock()
		{
			throw null;
		}

		// Token: 0x060027BC RID: 10172 RVA: 0x0002916B File Offset: 0x0002736B
		[global::Cpp2ILInjected.Token(Token = "0x6002A76")]
		[global::Cpp2ILInjected.Address(RVA = "0x1173D0C", Offset = "0x1173D0C", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageBuffer), Member = "ProcessData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetMessage), Member = "DecompressTileBlock_Inner", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "CopyPaintAndCoating", MemberParameters = new object[] { typeof(Tile) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileColorCache), Member = "ApplyToBlock", MemberParameters = new object[] { typeof(Tile) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "paintCoatTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(byte),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "ConvertIlluminantPaintToNewField", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_bTileHeader3", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "set_bTileHeader3", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		public void fullbrightBlock(bool fullbrightBlock)
		{
			throw null;
		}

		// Token: 0x060027BD RID: 10173 RVA: 0x0002916E File Offset: 0x0002736E
		[global::Cpp2ILInjected.Token(Token = "0x6002A77")]
		[global::Cpp2ILInjected.Address(RVA = "0x1173BC8", Offset = "0x1173BC8", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetMessage), Member = "SendData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(NetworkText),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetMessage), Member = "CompressTileBlock_Inner", MemberParameters = new object[]
		{
			typeof(BinaryWriter),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "PlaceThing_PaintScrapper_TryScrapping", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "coatingColors", MemberParameters = new object[]
		{
			typeof(Tile),
			typeof(bool)
		}, ReturnType = typeof(List<Color>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "paintCoatWall", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(byte),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "SaveWorldTiles", MemberParameters = new object[] { typeof(BinaryWriter) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MapHelper), Member = "CreateMapTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(byte)
		}, ReturnType = typeof(MapTile))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmartCursorHelper), Member = "Step_PaintScrapper", MemberParameters = new object[]
		{
			"Terraria.GameContent.SmartCursorHelper.SmartCursorUsageInfo",
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmartCursorHelper), Member = "Step_PaintRoller", MemberParameters = new object[]
		{
			"Terraria.GameContent.SmartCursorHelper.SmartCursorUsageInfo",
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_bTileHeader3", ReturnType = typeof(byte))]
		public bool fullbrightWall()
		{
			throw null;
		}

		// Token: 0x060027BE RID: 10174 RVA: 0x00029171 File Offset: 0x00027371
		[global::Cpp2ILInjected.Token(Token = "0x6002A78")]
		[global::Cpp2ILInjected.Address(RVA = "0x1173D40", Offset = "0x1173D40", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageBuffer), Member = "ProcessData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetMessage), Member = "DecompressTileBlock_Inner", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileColorCache), Member = "ApplyToWall", MemberParameters = new object[] { typeof(Tile) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "paintCoatWall", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(byte),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "ConvertIlluminantPaintToNewField", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_bTileHeader3", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "set_bTileHeader3", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		public void fullbrightWall(bool fullbrightWall)
		{
			throw null;
		}

		// Token: 0x060027BF RID: 10175 RVA: 0x00029174 File Offset: 0x00027374
		[global::Cpp2ILInjected.Token(Token = "0x6002A79")]
		[global::Cpp2ILInjected.Address(RVA = "0x1173D74", Offset = "0x1173D74", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Framing), Member = "SelfFrame8Way", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(Tile),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "CheckTreeWithSettings", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(WorldGen.CheckTreeSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "CheckTree", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "TileFrameDoWork", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTile_MinecartTrack", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(TileDrawInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 84)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_bTileHeader2", ReturnType = typeof(byte))]
		public byte frameNumber()
		{
			throw null;
		}

		// Token: 0x060027C0 RID: 10176 RVA: 0x00029177 File Offset: 0x00027377
		[global::Cpp2ILInjected.Token(Token = "0x6002A7A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1173D88", Offset = "0x1173D88", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Framing), Member = "SelfFrame8Way", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(Tile),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "GrowEpicTree", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "GrowTree", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "GrowTreeWithSettings", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(WorldGen.GrowTreeSettings)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "GrowUndergroundTree", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "GrowShroom", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "KillTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "TileFrameDoWork", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_bTileHeader2", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "SetBTileHeader2", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		public void frameNumber(byte frameNumber)
		{
			throw null;
		}

		// Token: 0x060027C1 RID: 10177 RVA: 0x0002917A File Offset: 0x0002737A
		[global::Cpp2ILInjected.Token(Token = "0x6002A7B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1173DB4", Offset = "0x1173DB4", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_bTileHeader2", ReturnType = typeof(byte))]
		public byte wallFrameNumber()
		{
			throw null;
		}

		// Token: 0x060027C2 RID: 10178 RVA: 0x0002917D File Offset: 0x0002737D
		[global::Cpp2ILInjected.Token(Token = "0x6002A7C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1173DC8", Offset = "0x1173DC8", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_bTileHeader2", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "SetBTileHeader2", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		public void wallFrameNumber(byte wallFrameNumber)
		{
			throw null;
		}

		// Token: 0x060027C3 RID: 10179 RVA: 0x00029180 File Offset: 0x00027380
		[global::Cpp2ILInjected.Token(Token = "0x6002A7D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1173DF4", Offset = "0x1173DF4", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 52)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_sTileHeader", ReturnType = typeof(short))]
		public bool topSlope()
		{
			throw null;
		}

		// Token: 0x060027C4 RID: 10180 RVA: 0x00029183 File Offset: 0x00027383
		[global::Cpp2ILInjected.Token(Token = "0x6002A7E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1173E18", Offset = "0x1173E18", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 69)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_sTileHeader", ReturnType = typeof(short))]
		public bool bottomSlope()
		{
			throw null;
		}

		// Token: 0x060027C5 RID: 10181 RVA: 0x00029186 File Offset: 0x00027386
		[global::Cpp2ILInjected.Token(Token = "0x6002A7F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1173E3C", Offset = "0x1173E3C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ItemCheck_UseMiningTools_TryPoundingTile", MemberParameters = new object[]
		{
			typeof(Item),
			typeof(int),
			typeof(ref bool),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Collision), Member = "HurtTiles", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(Player)
		}, ReturnType = typeof(Collision.HurtTile))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "SolidTileAllowRightSlope", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "LeftEdgeCanBeAttachedTo", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "TileFrameDoWork", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "CheckProjectilePressurePad_GetPossiblePlacementDirections", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref bool),
			typeof(ref bool),
			typeof(ref bool),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_sTileHeader", ReturnType = typeof(short))]
		public bool leftSlope()
		{
			throw null;
		}

		// Token: 0x060027C6 RID: 10182 RVA: 0x00029189 File Offset: 0x00027389
		[global::Cpp2ILInjected.Token(Token = "0x6002A80")]
		[global::Cpp2ILInjected.Address(RVA = "0x1173E64", Offset = "0x1173E64", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ItemCheck_UseMiningTools_TryPoundingTile", MemberParameters = new object[]
		{
			typeof(Item),
			typeof(int),
			typeof(ref bool),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Collision), Member = "HurtTiles", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(Player)
		}, ReturnType = typeof(Collision.HurtTile))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "SolidTileAllowLeftSlope", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "RightEdgeCanBeAttachedTo", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "TileFrameDoWork", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "CheckProjectilePressurePad_GetPossiblePlacementDirections", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref bool),
			typeof(ref bool),
			typeof(ref bool),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_sTileHeader", ReturnType = typeof(short))]
		public bool rightSlope()
		{
			throw null;
		}

		// Token: 0x060027C7 RID: 10183 RVA: 0x0002918C File Offset: 0x0002738C
		[global::Cpp2ILInjected.Token(Token = "0x6002A81")]
		[global::Cpp2ILInjected.Address(RVA = "0x1173910", Offset = "0x1173910", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 247)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_sTileHeader", ReturnType = typeof(short))]
		public byte slope()
		{
			throw null;
		}

		// Token: 0x060027C8 RID: 10184 RVA: 0x0002918F File Offset: 0x0002738F
		[global::Cpp2ILInjected.Token(Token = "0x6002A82")]
		[global::Cpp2ILInjected.Address(RVA = "0x1173E88", Offset = "0x1173E88", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PortalHelper), Member = "IsValidLine", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_sTileHeader", ReturnType = typeof(short))]
		public bool HasSameSlope(Tile tile)
		{
			throw null;
		}

		// Token: 0x060027C9 RID: 10185 RVA: 0x00029192 File Offset: 0x00027392
		[global::Cpp2ILInjected.Token(Token = "0x6002A83")]
		[global::Cpp2ILInjected.Address(RVA = "0x1173EC0", Offset = "0x1173EC0", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 109)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_sTileHeader", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "SetSTileHeader", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(void))]
		public void slope(byte slope)
		{
			throw null;
		}

		// Token: 0x060027CA RID: 10186 RVA: 0x00029195 File Offset: 0x00027395
		[global::Cpp2ILInjected.Token(Token = "0x6002A84")]
		[global::Cpp2ILInjected.Address(RVA = "0x1173EF0", Offset = "0x1173EF0", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "FullTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "TouchBlockSurfaceCenter", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(Tile),
			typeof(ref int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_137_LightningAura", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Collision), Member = "DrownCollision", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Collision), Member = "IsWorldPointSolid", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Collision), Member = "GetTileRotation", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Framing), Member = "FindBlockStyle", MemberParameters = new object[] { typeof(Tile) }, ReturnType = "Terraria.Framing.BlockStyle")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObject), Member = "Place", MemberParameters = new object[] { typeof(TileObject) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObject), Member = "CanPlace", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(ref TileObject),
			typeof(bool),
			typeof(int?)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "AddLifeCrystal", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "CheckOnTable1x1", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "AnchorValid", MemberParameters = new object[]
		{
			typeof(Tile),
			typeof(AnchorType)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "FixHeart", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "TileFrameDoWork", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTiles", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "GetTileDrawData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(TileDrawInfo),
			typeof(ushort),
			typeof(ref short),
			typeof(ref short),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref SpriteEffects),
			typeof(ref Texture2D),
			typeof(ref Rectangle),
			typeof(ref Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "GetTileDrawData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(ushort),
			typeof(ref short),
			typeof(ref short),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref SpriteEffects),
			typeof(ref Texture2D),
			typeof(ref Rectangle),
			typeof(ref Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "GetTileDrawData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(Tile),
			typeof(ushort),
			typeof(ref short),
			typeof(ref short),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref SpriteEffects),
			typeof(ref Texture2D),
			typeof(ref Rectangle),
			typeof(ref Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WallDrawing), Member = "FullTile", MemberParameters = new object[]
		{
			typeof(Tile),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 42)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_sTileHeader", ReturnType = typeof(short))]
		public int blockType()
		{
			throw null;
		}

		// Token: 0x060027CB RID: 10187 RVA: 0x00029198 File Offset: 0x00027398
		[global::Cpp2ILInjected.Token(Token = "0x6002A85")]
		[global::Cpp2ILInjected.Address(RVA = "0x1173F24", Offset = "0x1173F24", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 36)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_sTileHeader", ReturnType = typeof(short))]
		public byte color()
		{
			throw null;
		}

		// Token: 0x060027CC RID: 10188 RVA: 0x0002919B File Offset: 0x0002739B
		[global::Cpp2ILInjected.Token(Token = "0x6002A86")]
		[global::Cpp2ILInjected.Address(RVA = "0x1173F38", Offset = "0x1173F38", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 51)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_sTileHeader", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "SetSTileHeader", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(void))]
		public void color(byte color)
		{
			throw null;
		}

		// Token: 0x060027CD RID: 10189 RVA: 0x0002919E File Offset: 0x0002739E
		[global::Cpp2ILInjected.Token(Token = "0x6002A87")]
		[global::Cpp2ILInjected.Address(RVA = "0x1173B78", Offset = "0x1173B78", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetMessage), Member = "SendData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(NetworkText),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetMessage), Member = "CompressTileBlock_Inner", MemberParameters = new object[]
		{
			typeof(BinaryWriter),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "PlaceThing_PaintScrapper_TryScrapping", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ApplyPaint", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(Item)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "paintWall", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(byte),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "SaveWorldTiles", MemberParameters = new object[] { typeof(BinaryWriter) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "ConvertIlluminantPaintToNewField", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MapHelper), Member = "CreateMapTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(byte)
		}, ReturnType = typeof(MapTile))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmartCursorHelper), Member = "Step_PaintScrapper", MemberParameters = new object[]
		{
			"Terraria.GameContent.SmartCursorHelper.SmartCursorUsageInfo",
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmartCursorHelper), Member = "Step_PaintRoller", MemberParameters = new object[]
		{
			"Terraria.GameContent.SmartCursorHelper.SmartCursorUsageInfo",
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_bTileHeader", ReturnType = typeof(byte))]
		public byte wallColor()
		{
			throw null;
		}

		// Token: 0x060027CE RID: 10190 RVA: 0x000291A1 File Offset: 0x000273A1
		[global::Cpp2ILInjected.Token(Token = "0x6002A88")]
		[global::Cpp2ILInjected.Address(RVA = "0x1173F68", Offset = "0x1173F68", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 31)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_bTileHeader", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "SetBHeader", MemberParameters = new object[]
		{
			typeof(int),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void wallColor(byte wallColor)
		{
			throw null;
		}

		// Token: 0x060027CF RID: 10191 RVA: 0x000291A4 File Offset: 0x000273A4
		[global::Cpp2ILInjected.Token(Token = "0x6002A89")]
		[global::Cpp2ILInjected.Address(RVA = "0x1173FE4", Offset = "0x1173FE4", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 83)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_bTileHeader", ReturnType = typeof(byte))]
		public bool lava()
		{
			throw null;
		}

		// Token: 0x060027D0 RID: 10192 RVA: 0x000291A7 File Offset: 0x000273A7
		[global::Cpp2ILInjected.Token(Token = "0x6002A8A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1174000", Offset = "0x1174000", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 61)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_bTileHeader", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "SetBHeader", MemberParameters = new object[]
		{
			typeof(int),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void lava(bool lava)
		{
			throw null;
		}

		// Token: 0x060027D1 RID: 10193 RVA: 0x000291AA File Offset: 0x000273AA
		[global::Cpp2ILInjected.Token(Token = "0x6002A8B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1174088", Offset = "0x1174088", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetMessage), Member = "CompressTileBlock_Inner", MemberParameters = new object[]
		{
			typeof(BinaryWriter),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "SpawnNPC", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "CheckCuteFishron", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ItemCheck_UseBuckets", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "GetFishingPondState", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref bool),
			typeof(ref bool),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Gore), Member = "Gore_UpdateLeaf", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WaterfallManager), Member = "FindWaterfalls", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "FinishRemixWorld", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "PlaceDye", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "plantDye", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "SaveWorldTiles", MemberParameters = new object[] { typeof(BinaryWriter) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileLightScanner), Member = "GetTileMask", MemberParameters = new object[] { typeof(Tile) }, ReturnType = typeof(LightMaskMode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TELogicSensor), Member = "GetState", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(TELogicSensor.LogicCheckType),
			typeof(TELogicSensor)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 17)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_bTileHeader", ReturnType = typeof(byte))]
		public bool honey()
		{
			throw null;
		}

		// Token: 0x060027D2 RID: 10194 RVA: 0x000291AD File Offset: 0x000273AD
		[global::Cpp2ILInjected.Token(Token = "0x6002A8C")]
		[global::Cpp2ILInjected.Address(RVA = "0x11740A4", Offset = "0x11740A4", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldConsole), Member = "LoadWorld_Version1", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldSwitch), Member = "LoadWorld_Version1", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Liquid), Member = "LiquidCheck", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(uint*),
			typeof(byte*),
			typeof(byte*),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetMessage), Member = "DecompressTileBlock_Inner", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "HitEffect", MemberParameters = new object[]
		{
			typeof(int),
			typeof(double)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ItemCheck_UseBuckets", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "liquidType", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen.<>c", Member = "<GenerateWorld>b__277_84", MemberParameters = new object[]
		{
			typeof(GenerationProgress),
			typeof(GameConfiguration)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "NotTheBees", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "FinishNotTheBees", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "KillTile_GetItemDrops", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(Tile),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "CloudLake", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "LoadWorld_Version1_Old_BeforeRelease88", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HiveBiome), Member = "CreateHiveTunnel", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(UnifiedRandom)
		}, ReturnType = typeof(Vector2D))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HiveBiome), Member = "CreateBlockedHoneyCube", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 20)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_bTileHeader", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "SetBHeader", MemberParameters = new object[]
		{
			typeof(int),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public unsafe void honey(bool honey)
		{
			throw null;
		}

		// Token: 0x060027D3 RID: 10195 RVA: 0x000291B0 File Offset: 0x000273B0
		[global::Cpp2ILInjected.Token(Token = "0x6002A8D")]
		[global::Cpp2ILInjected.Address(RVA = "0x117412C", Offset = "0x117412C", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 41)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_bTileHeader", ReturnType = typeof(byte))]
		public bool shimmer()
		{
			throw null;
		}

		// Token: 0x060027D4 RID: 10196 RVA: 0x000291B3 File Offset: 0x000273B3
		[global::Cpp2ILInjected.Token(Token = "0x6002A8E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1174148", Offset = "0x1174148", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Liquid), Member = "LiquidCheck", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(uint*),
			typeof(byte*),
			typeof(byte*),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetMessage), Member = "DecompressTileBlock_Inner", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "ShimmerCleanUp", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "ShimmerMakeBiome", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "Shimminate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_bTileHeader", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "set_bTileHeader", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		public unsafe void shimmer(bool shimmer)
		{
			throw null;
		}

		// Token: 0x060027D5 RID: 10197 RVA: 0x000291B6 File Offset: 0x000273B6
		[global::Cpp2ILInjected.Token(Token = "0x6002A8F")]
		[global::Cpp2ILInjected.Address(RVA = "0x117417C", Offset = "0x117417C", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Liquid), Member = "QuickWater", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Liquid), Member = "LiquidCheck", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(uint*),
			typeof(byte*),
			typeof(byte*),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Liquid), Member = "DelWater", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageBuffer), Member = "ProcessData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ItemCheck_UseBuckets", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "Clear", MemberParameters = new object[] { typeof(TileDataType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Wiring), Member = "XferWater", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "PlaceLiquid", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(byte),
			typeof(byte)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Actions.SetLiquid), Member = "Apply", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int),
			typeof(int),
			typeof(object[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TilInfo_OldMobile), Member = "Load", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraniteBiome), Member = "PlaceGranite", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(Rectangle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetLiquidModule), Member = "Deserialize", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 19)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_bTileHeader", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "SetBHeader", MemberParameters = new object[]
		{
			typeof(int),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "lava", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "honey", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "set_bTileHeader", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public unsafe void liquidType(int liquidType)
		{
			throw null;
		}

		// Token: 0x060027D6 RID: 10198 RVA: 0x000291B9 File Offset: 0x000273B9
		[global::Cpp2ILInjected.Token(Token = "0x6002A90")]
		[global::Cpp2ILInjected.Address(RVA = "0x1174260", Offset = "0x1174260", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 41)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_bTileHeader", ReturnType = typeof(byte))]
		public byte liquidType()
		{
			throw null;
		}

		// Token: 0x060027D7 RID: 10199 RVA: 0x000291BC File Offset: 0x000273BC
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6002A91")]
		[global::Cpp2ILInjected.Address(RVA = "0x1174274", Offset = "0x1174274", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LiquidBuffer), Member = "AddBuffer", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "PlaceTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public bool checkingLiquid()
		{
			throw null;
		}

		// Token: 0x060027D8 RID: 10200 RVA: 0x000291BF File Offset: 0x000273BF
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6002A92")]
		[global::Cpp2ILInjected.Address(RVA = "0x1174334", Offset = "0x1174334", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Liquid), Member = "AddWater", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LiquidBuffer), Member = "AddBuffer", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "Clear", MemberParameters = new object[] { typeof(TileDataType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void checkingLiquid(bool checkingLiquid)
		{
			throw null;
		}

		// Token: 0x060027D9 RID: 10201 RVA: 0x000291C2 File Offset: 0x000273C2
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6002A93")]
		[global::Cpp2ILInjected.Address(RVA = "0x117441C", Offset = "0x117441C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public bool skipLiquid()
		{
			throw null;
		}

		// Token: 0x060027DA RID: 10202 RVA: 0x000291C5 File Offset: 0x000273C5
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6002A94")]
		[global::Cpp2ILInjected.Address(RVA = "0x11744D8", Offset = "0x11744D8", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Liquid), Member = "AddWater", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void skipLiquid(bool skipLiquid)
		{
			throw null;
		}

		// Token: 0x060027DB RID: 10203 RVA: 0x000291C8 File Offset: 0x000273C8
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6002A95")]
		[global::Cpp2ILInjected.Address(RVA = "0x11745C0", Offset = "0x11745C0", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public bool TileFramed()
		{
			throw null;
		}

		// Token: 0x060027DC RID: 10204 RVA: 0x000291CB File Offset: 0x000273CB
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6002A96")]
		[global::Cpp2ILInjected.Address(RVA = "0x117467C", Offset = "0x117467C", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void TileFramed(bool framed)
		{
			throw null;
		}

		// Token: 0x060027DD RID: 10205 RVA: 0x000291CE File Offset: 0x000273CE
		[global::Cpp2ILInjected.Token(Token = "0x6002A97")]
		[global::Cpp2ILInjected.Address(RVA = "0x1174788", Offset = "0x1174788", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 36)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_sTileHeader", ReturnType = typeof(short))]
		public bool wire()
		{
			throw null;
		}

		// Token: 0x060027DE RID: 10206 RVA: 0x000291D1 File Offset: 0x000273D1
		[global::Cpp2ILInjected.Token(Token = "0x6002A98")]
		[global::Cpp2ILInjected.Address(RVA = "0x117479C", Offset = "0x117479C", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldConsole), Member = "LoadWorld_Version1", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldSwitch), Member = "LoadWorld_Version1", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageBuffer), Member = "ProcessData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetMessage), Member = "DecompressTileBlock_Inner", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "Clear", MemberParameters = new object[] { typeof(TileDataType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "mayanTrap", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "placeLavaTrap", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "placeTrap", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "FinishNoTraps", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "ClearBrokenTraps", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(List<Point>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "MakeDungeon_Lights", MemberParameters = new object[]
		{
			typeof(ushort),
			typeof(ref int),
			typeof(int),
			typeof(ref int),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "PlaceSandTrap", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "PlaceWire", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "KillWire", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TilInfo_OldMobile), Member = "Load", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "LoadWorld_Version1_Old_BeforeRelease88", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TrackGenerator), Member = "PlacePath", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeadMansChestBiome), Member = "PlaceWireLine", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeadMansChestBiome), Member = "ActuallyPlaceBoulderTrap", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 54)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_sTileHeader", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "SetSHeader", MemberParameters = new object[]
		{
			typeof(int),
			typeof(short)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void wire(bool wire)
		{
			throw null;
		}

		// Token: 0x060027DF RID: 10207 RVA: 0x000291D4 File Offset: 0x000273D4
		[global::Cpp2ILInjected.Token(Token = "0x6002A99")]
		[global::Cpp2ILInjected.Address(RVA = "0x1174820", Offset = "0x1174820", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetMessage), Member = "SendData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(NetworkText),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetMessage), Member = "CompressTileBlock_Inner", MemberParameters = new object[]
		{
			typeof(BinaryWriter),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Wiring), Member = "TripWire", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Wiring), Member = "HitWire", MemberParameters = new object[]
		{
			typeof(DoubleStack<Point16>),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Wiring), Member = "MassWireOperationStep", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(Point),
			typeof(WiresUI.Settings.MultiToolMode),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(bool?))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "mayanTrap", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "countWires", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "PlaceWire2", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "KillWire2", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "HasAnyWireNearby", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "SaveWorldTiles", MemberParameters = new object[] { typeof(BinaryWriter) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmartCursorHelper), Member = "Step_Actuators", MemberParameters = new object[]
		{
			"Terraria.GameContent.SmartCursorHelper.SmartCursorUsageInfo",
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmartCursorHelper), Member = "Step_WireCutter", MemberParameters = new object[]
		{
			"Terraria.GameContent.SmartCursorHelper.SmartCursorUsageInfo",
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmartCursorHelper), Member = "Step_MulticolorWrench", MemberParameters = new object[]
		{
			"Terraria.GameContent.SmartCursorHelper.SmartCursorUsageInfo",
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmartCursorHelper), Member = "Step_ColoredWrenches", MemberParameters = new object[]
		{
			"Terraria.GameContent.SmartCursorHelper.SmartCursorUsageInfo",
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 28)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_sTileHeader", ReturnType = typeof(short))]
		public bool wire2()
		{
			throw null;
		}

		// Token: 0x060027E0 RID: 10208 RVA: 0x000291D7 File Offset: 0x000273D7
		[global::Cpp2ILInjected.Token(Token = "0x6002A9A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1174834", Offset = "0x1174834", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldConsole), Member = "LoadWorld_Version1", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldSwitch), Member = "LoadWorld_Version1", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageBuffer), Member = "ProcessData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetMessage), Member = "DecompressTileBlock_Inner", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "Clear", MemberParameters = new object[] { typeof(TileDataType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "mayanTrap", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "PlaceWire2", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "KillWire2", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TilInfo_OldMobile), Member = "Load", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "LoadWorld_Version1_Old_BeforeRelease88", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 17)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_sTileHeader", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "SetSHeader", MemberParameters = new object[]
		{
			typeof(int),
			typeof(short)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void wire2(bool wire2)
		{
			throw null;
		}

		// Token: 0x060027E1 RID: 10209 RVA: 0x000291DA File Offset: 0x000273DA
		[global::Cpp2ILInjected.Token(Token = "0x6002A9B")]
		[global::Cpp2ILInjected.Address(RVA = "0x11748B8", Offset = "0x11748B8", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetMessage), Member = "SendData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(NetworkText),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetMessage), Member = "CompressTileBlock_Inner", MemberParameters = new object[]
		{
			typeof(BinaryWriter),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Wiring), Member = "TripWire", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Wiring), Member = "HitWire", MemberParameters = new object[]
		{
			typeof(DoubleStack<Point16>),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Wiring), Member = "MassWireOperationStep", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(Point),
			typeof(WiresUI.Settings.MultiToolMode),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(bool?))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "mayanTrap", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "countWires", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "PlaceWire3", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "KillWire3", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "HasAnyWireNearby", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "SaveWorldTiles", MemberParameters = new object[] { typeof(BinaryWriter) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmartCursorHelper), Member = "Step_Actuators", MemberParameters = new object[]
		{
			"Terraria.GameContent.SmartCursorHelper.SmartCursorUsageInfo",
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmartCursorHelper), Member = "Step_WireCutter", MemberParameters = new object[]
		{
			"Terraria.GameContent.SmartCursorHelper.SmartCursorUsageInfo",
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmartCursorHelper), Member = "Step_MulticolorWrench", MemberParameters = new object[]
		{
			"Terraria.GameContent.SmartCursorHelper.SmartCursorUsageInfo",
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmartCursorHelper), Member = "Step_ColoredWrenches", MemberParameters = new object[]
		{
			"Terraria.GameContent.SmartCursorHelper.SmartCursorUsageInfo",
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 28)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_sTileHeader", ReturnType = typeof(short))]
		public bool wire3()
		{
			throw null;
		}

		// Token: 0x060027E2 RID: 10210 RVA: 0x000291DD File Offset: 0x000273DD
		[global::Cpp2ILInjected.Token(Token = "0x6002A9C")]
		[global::Cpp2ILInjected.Address(RVA = "0x11748CC", Offset = "0x11748CC", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldConsole), Member = "LoadWorld_Version1", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldSwitch), Member = "LoadWorld_Version1", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageBuffer), Member = "ProcessData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetMessage), Member = "DecompressTileBlock_Inner", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "Clear", MemberParameters = new object[] { typeof(TileDataType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "mayanTrap", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "PlaceWire3", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "KillWire3", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TilInfo_OldMobile), Member = "Load", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "LoadWorld_Version1_Old_BeforeRelease88", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 17)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_sTileHeader", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "SetSHeader", MemberParameters = new object[]
		{
			typeof(int),
			typeof(short)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void wire3(bool wire3)
		{
			throw null;
		}

		// Token: 0x060027E3 RID: 10211 RVA: 0x000291E0 File Offset: 0x000273E0
		[global::Cpp2ILInjected.Token(Token = "0x6002A9D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1174950", Offset = "0x1174950", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetMessage), Member = "SendData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(NetworkText),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetMessage), Member = "CompressTileBlock_Inner", MemberParameters = new object[]
		{
			typeof(BinaryWriter),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Wiring), Member = "TripWire", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Wiring), Member = "HitWire", MemberParameters = new object[]
		{
			typeof(DoubleStack<Point16>),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Wiring), Member = "MassWireOperationStep", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(Point),
			typeof(WiresUI.Settings.MultiToolMode),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(bool?))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "countWires", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "PlaceWire4", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "KillWire4", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "HasAnyWireNearby", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "SaveWorldTiles", MemberParameters = new object[] { typeof(BinaryWriter) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmartCursorHelper), Member = "Step_Actuators", MemberParameters = new object[]
		{
			"Terraria.GameContent.SmartCursorHelper.SmartCursorUsageInfo",
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmartCursorHelper), Member = "Step_WireCutter", MemberParameters = new object[]
		{
			"Terraria.GameContent.SmartCursorHelper.SmartCursorUsageInfo",
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmartCursorHelper), Member = "Step_MulticolorWrench", MemberParameters = new object[]
		{
			"Terraria.GameContent.SmartCursorHelper.SmartCursorUsageInfo",
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmartCursorHelper), Member = "Step_ColoredWrenches", MemberParameters = new object[]
		{
			"Terraria.GameContent.SmartCursorHelper.SmartCursorUsageInfo",
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 26)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_sTileHeader", ReturnType = typeof(short))]
		public bool wire4()
		{
			throw null;
		}

		// Token: 0x060027E4 RID: 10212 RVA: 0x000291E3 File Offset: 0x000273E3
		[global::Cpp2ILInjected.Token(Token = "0x6002A9E")]
		[global::Cpp2ILInjected.Address(RVA = "0x117496C", Offset = "0x117496C", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageBuffer), Member = "ProcessData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetMessage), Member = "DecompressTileBlock_Inner", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "Clear", MemberParameters = new object[] { typeof(TileDataType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "PlaceWire4", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "KillWire4", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_sTileHeader", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "SetSHeader", MemberParameters = new object[]
		{
			typeof(int),
			typeof(short)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void wire4(bool wire4)
		{
			throw null;
		}

		// Token: 0x060027E5 RID: 10213 RVA: 0x000291E6 File Offset: 0x000273E6
		[global::Cpp2ILInjected.Token(Token = "0x6002A9F")]
		[global::Cpp2ILInjected.Address(RVA = "0x11738FC", Offset = "0x11738FC", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 191)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_sTileHeader", ReturnType = typeof(short))]
		public bool halfBrick()
		{
			throw null;
		}

		// Token: 0x060027E6 RID: 10214 RVA: 0x000291E9 File Offset: 0x000273E9
		[global::Cpp2ILInjected.Token(Token = "0x6002AA0")]
		[global::Cpp2ILInjected.Address(RVA = "0x11749F0", Offset = "0x11749F0", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 143)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_sTileHeader", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "SetSHeader", MemberParameters = new object[]
		{
			typeof(int),
			typeof(short)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void halfBrick(bool halfBrick)
		{
			throw null;
		}

		// Token: 0x060027E7 RID: 10215 RVA: 0x000291EC File Offset: 0x000273EC
		[global::Cpp2ILInjected.Token(Token = "0x6002AA1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1174A74", Offset = "0x1174A74", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetMessage), Member = "SendData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(NetworkText),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetMessage), Member = "CompressTileBlock_Inner", MemberParameters = new object[]
		{
			typeof(BinaryWriter),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ItemCheck_UseWiringTools", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Wiring), Member = "Actuate", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Wiring), Member = "HitWireSingle", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Wiring), Member = "MassWireOperationStep", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(Point),
			typeof(WiresUI.Settings.MultiToolMode),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(bool?))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "IsItATrap", MemberParameters = new object[] { typeof(Tile) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "ClearBrokenTraps", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(List<Point>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "PlaceActuator", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "KillActuator", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "SaveWorldTiles", MemberParameters = new object[] { typeof(BinaryWriter) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmartCursorHelper), Member = "Step_Actuators", MemberParameters = new object[]
		{
			"Terraria.GameContent.SmartCursorHelper.SmartCursorUsageInfo",
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmartCursorHelper), Member = "Step_WireCutter", MemberParameters = new object[]
		{
			"Terraria.GameContent.SmartCursorHelper.SmartCursorUsageInfo",
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmartCursorHelper), Member = "Step_ActuationRod", MemberParameters = new object[]
		{
			"Terraria.GameContent.SmartCursorHelper.SmartCursorUsageInfo",
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeadMansChestBiome), Member = "FindDartTrapSpotSingle", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 19)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_sTileHeader", ReturnType = typeof(short))]
		public bool actuator()
		{
			throw null;
		}

		// Token: 0x060027E8 RID: 10216 RVA: 0x000291EF File Offset: 0x000273EF
		[global::Cpp2ILInjected.Token(Token = "0x6002AA2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1174A88", Offset = "0x1174A88", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldConsole), Member = "LoadWorld_Version1", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldSwitch), Member = "LoadWorld_Version1", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageBuffer), Member = "ProcessData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetMessage), Member = "DecompressTileBlock_Inner", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "Clear", MemberParameters = new object[] { typeof(TileDataType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "placeLavaTrap", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "ClearBrokenTraps", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(List<Point>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "PlaceSandTrap", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "PlaceActuator", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "KillActuator", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TilInfo_OldMobile), Member = "Load", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "LoadWorld_Version1_Old_BeforeRelease88", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeadMansChestBiome), Member = "ActuallyPlaceBoulderTrap", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_sTileHeader", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "SetSHeader", MemberParameters = new object[]
		{
			typeof(int),
			typeof(short)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void actuator(bool actuator)
		{
			throw null;
		}

		// Token: 0x060027E9 RID: 10217 RVA: 0x000291F2 File Offset: 0x000273F2
		[global::Cpp2ILInjected.Token(Token = "0x6002AA3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1174B0C", Offset = "0x1174B0C", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 315)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_sTileHeader", ReturnType = typeof(short))]
		public bool nactive()
		{
			throw null;
		}

		// Token: 0x060027EA RID: 10218 RVA: 0x000291F5 File Offset: 0x000273F5
		[global::Cpp2ILInjected.Token(Token = "0x6002AA4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1174B40", Offset = "0x1174B40", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 64)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_sTileHeader", ReturnType = typeof(short))]
		public bool inActive()
		{
			throw null;
		}

		// Token: 0x060027EB RID: 10219 RVA: 0x000291F8 File Offset: 0x000273F8
		[global::Cpp2ILInjected.Token(Token = "0x6002AA5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1174B54", Offset = "0x1174B54", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldConsole), Member = "LoadWorld_Version1", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldSwitch), Member = "LoadWorld_Version1", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageBuffer), Member = "ProcessData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetMessage), Member = "DecompressTileBlock_Inner", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "Clear", MemberParameters = new object[] { typeof(TileDataType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Wiring), Member = "DeActive", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Wiring), Member = "ReActive", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "KillTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TilInfo_OldMobile), Member = "Load", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "LoadWorld_Version1_Old_BeforeRelease88", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_sTileHeader", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "SetSHeader", MemberParameters = new object[]
		{
			typeof(int),
			typeof(short)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void inActive(bool inActive)
		{
			throw null;
		}

		// Token: 0x060027EC RID: 10220 RVA: 0x000291FB File Offset: 0x000273FB
		[global::Cpp2ILInjected.Token(Token = "0x6002AA6")]
		[global::Cpp2ILInjected.Address(RVA = "0x116FEB4", Offset = "0x116FEB4", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1924)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_sTileHeader", ReturnType = typeof(short))]
		public bool active()
		{
			throw null;
		}

		// Token: 0x060027ED RID: 10221 RVA: 0x000291FE File Offset: 0x000273FE
		[global::Cpp2ILInjected.Token(Token = "0x6002AA7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1174BD8", Offset = "0x1174BD8", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_sTileHeader", ReturnType = typeof(short))]
		public bool activeSafe()
		{
			throw null;
		}

		// Token: 0x060027EE RID: 10222 RVA: 0x00029201 File Offset: 0x00027401
		[global::Cpp2ILInjected.Token(Token = "0x6002AA8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1174BEC", Offset = "0x1174BEC", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 648)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_sTileHeader", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "SetSHeader", MemberParameters = new object[]
		{
			typeof(int),
			typeof(short)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void active(bool active)
		{
			throw null;
		}

		// Token: 0x060027EF RID: 10223 RVA: 0x00029204 File Offset: 0x00027404
		[global::Cpp2ILInjected.Token(Token = "0x6002AA9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1174C98", Offset = "0x1174C98", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen.<>c", Member = "<GenerateWorld>b__277_27", MemberParameters = new object[]
		{
			typeof(GenerationProgress),
			typeof(GameConfiguration)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen.<>c", Member = "<GenerateWorld>b__277_35", MemberParameters = new object[]
		{
			typeof(GenerationProgress),
			typeof(GameConfiguration)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Actions.SwapSolidTile), Member = "Apply", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int),
			typeof(int),
			typeof(object[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileFont), Member = "DrawChar", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(byte[]),
			typeof(TileFont.DrawMode)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileFont), Member = "HLineLabel", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int),
			typeof(string),
			typeof(TileFont.DrawMode),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileFont), Member = "VLineLabel", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int),
			typeof(string),
			typeof(TileFont.DrawMode),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TrackGenerator), Member = "PlacePath", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DunesBiome), Member = "PlaceCurvedLine", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(Point),
			typeof(Point),
			"Terraria.GameContent.Biomes.DunesBiome.DunesDescription"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraniteBiome), Member = "PlaceGranite", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(Rectangle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MarbleBiome), Member = "PlaceSlab", MemberParameters = new object[]
		{
			"Terraria.GameContent.Biomes.MarbleBiome.Slab",
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MiningExplosivesBiome), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DesertHive), Member = "PlaceClustersArea", MemberParameters = new object[]
		{
			typeof(DesertDescription),
			"Terraria.GameContent.Biomes.Desert.DesertHive.ClusterGroup",
			typeof(Rectangle),
			typeof(DesertHive.PostPlacementEffect[,,]),
			typeof(Point)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PitEntrance), Member = "PlaceAt", MemberParameters = new object[]
		{
			typeof(DesertDescription),
			typeof(Point),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "SetLiquid", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "SetSTileHeader", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "SetBTileHeader", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "SetBTileHeader2", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "SetBTileHeader3", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "SetFrameX", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "SetFrameY", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "SetType", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(void))]
		public void ResetToType(ushort type)
		{
			throw null;
		}

		// Token: 0x060027F0 RID: 10224 RVA: 0x00029207 File Offset: 0x00027407
		[global::Cpp2ILInjected.Token(Token = "0x6002AAA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1174D0C", Offset = "0x1174D0C", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_sTileHeader", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public Color actColor(Color oldColor)
		{
			throw null;
		}

		// Token: 0x060027F1 RID: 10225 RVA: 0x0002920A File Offset: 0x0002740A
		[global::Cpp2ILInjected.Token(Token = "0x6002AAB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1174D98", Offset = "0x1174D98", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_sTileHeader", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(float)
		}, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void actColor(ref Vector3 oldColor)
		{
			throw null;
		}

		// Token: 0x060027F2 RID: 10226 RVA: 0x0002920D File Offset: 0x0002740D
		[global::Cpp2ILInjected.Token(Token = "0x6002AAC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1174E34", Offset = "0x1174E34", Length = "0x160")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "EmptyLiquid", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "MakeDungeon", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "DungeonPitTrap", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ushort),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "DungeonHalls", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ushort),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "DungeonRoom", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ushort),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "DungeonEnt", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ushort),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Actions.SetTile), Member = "Apply", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int),
			typeof(int),
			typeof(object[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Actions.SetTileKeepWall), Member = "Apply", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int),
			typeof(int),
			typeof(object[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 40)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "set_type", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "set_frameX", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "set_frameY", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "set_wall", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_bTileHeader2", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "SetBTileHeader2", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_bTileHeader3", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "SetBTileHeader3", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "ClearBlockPaintAndCoating", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "ClearWallPaintAndCoating", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "set_liquid", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "liquidType", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "checkingLiquid", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_sTileHeader", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "SetSTileHeader", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "halfBrick", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "wire", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "wire2", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "wire3", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "wire4", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "actuator", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "inActive", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		public void Clear(TileDataType types)
		{
			throw null;
		}

		// Token: 0x060027F3 RID: 10227 RVA: 0x00029210 File Offset: 0x00027410
		[global::Cpp2ILInjected.Token(Token = "0x6002AAD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1175014", Offset = "0x1175014", Length = "0x3EC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mount), Member = "UseDrill", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "SmoothSlope", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Actions.Smooth), Member = "Apply", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int),
			typeof(int),
			typeof(object[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TrackGenerator), Member = "PlacePath", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DunesBiome), Member = "PlaceCurvedLine", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(Point),
			typeof(Point),
			"Terraria.GameContent.Biomes.DunesBiome.DunesDescription"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraniteBiome), Member = "PlaceDecorations", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(Rectangle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MarbleBiome), Member = "PlaceSlab", MemberParameters = new object[]
		{
			"Terraria.GameContent.Biomes.MarbleBiome.Slab",
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DesertHive), Member = "PlaceClusters", MemberParameters = new object[]
		{
			typeof(DesertDescription),
			"Terraria.GameContent.Biomes.Desert.DesertHive.ClusterGroup"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "SmoothSlope", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "SolidOrSlopedTile", MemberParameters = new object[] { typeof(Tile) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "TileEmpty", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "SolidOrSlopedTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_sTileHeader", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "set_sTileHeader", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetMessage), Member = "SendData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(NetworkText),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public static void SmoothSlope(int x, int y, bool applyToNeighbors = true, bool sync = false)
		{
			throw null;
		}

		// Token: 0x060027F4 RID: 10228 RVA: 0x00029213 File Offset: 0x00027413
		[global::Cpp2ILInjected.Token(Token = "0x6002AAE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1175400", Offset = "0x1175400", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "DoBootsEffect_PlaceFlowersOnTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen.<>c", Member = "<GenerateWorld>b__277_85", MemberParameters = new object[]
		{
			typeof(GenerationProgress),
			typeof(GameConfiguration)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen.<>c", Member = "<GenerateWorld>b__277_88", MemberParameters = new object[]
		{
			typeof(GenerationProgress),
			typeof(GameConfiguration)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "GrowSpike", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ushort),
			typeof(ushort)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "PlaceCatTail", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Point))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "GrowCatTail", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "UpdateWorld_GrassGrowth", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 24)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_sTileHeader", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "SetSTileHeader", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_bTileHeader3", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "invisibleBlock", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "fullbrightBlock", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		public void CopyPaintAndCoating(Tile other)
		{
			throw null;
		}

		// Token: 0x060027F5 RID: 10229 RVA: 0x00029216 File Offset: 0x00027416
		[global::Cpp2ILInjected.Token(Token = "0x6002AAF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1175464", Offset = "0x1175464", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "GrowTree", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "GrowTreeWithSettings", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(WorldGen.GrowTreeSettings)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "OpenDoor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "ShiftTrapdoor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(bool))]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "UpdateWorld_GrassGrowth", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_sTileHeader", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_bTileHeader3", ReturnType = typeof(byte))]
		public TileColorCache BlockColorAndCoating()
		{
			throw null;
		}

		// Token: 0x060027F6 RID: 10230 RVA: 0x00029219 File Offset: 0x00027419
		[global::Cpp2ILInjected.Token(Token = "0x6002AB0")]
		[global::Cpp2ILInjected.Address(RVA = "0x11754A8", Offset = "0x11754A8", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_bTileHeader", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_bTileHeader3", ReturnType = typeof(byte))]
		public TileColorCache WallColorAndCoating()
		{
			throw null;
		}

		// Token: 0x060027F7 RID: 10231 RVA: 0x0002921C File Offset: 0x0002741C
		[global::Cpp2ILInjected.Token(Token = "0x6002AB1")]
		[global::Cpp2ILInjected.Address(RVA = "0x11754EC", Offset = "0x11754EC", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "GrowTree", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "GrowTreeWithSettings", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(WorldGen.GrowTreeSettings)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "OpenDoor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "ShiftTrapdoor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "SpreadGrass", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(TileColorCache)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 18)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileColorCache), Member = "ApplyToBlock", MemberParameters = new object[] { typeof(Tile) }, ReturnType = typeof(void))]
		public void UseBlockColors(TileColorCache cache)
		{
			throw null;
		}

		// Token: 0x060027F8 RID: 10232 RVA: 0x0002921F File Offset: 0x0002741F
		[global::Cpp2ILInjected.Token(Token = "0x6002AB2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1175560", Offset = "0x1175560", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileColorCache), Member = "ApplyToWall", MemberParameters = new object[] { typeof(Tile) }, ReturnType = typeof(void))]
		public void UseWallColors(TileColorCache cache)
		{
			throw null;
		}

		// Token: 0x060027F9 RID: 10233 RVA: 0x00029222 File Offset: 0x00027422
		[global::Cpp2ILInjected.Token(Token = "0x6002AB3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1174F94", Offset = "0x1174F94", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "Clear", MemberParameters = new object[] { typeof(TileDataType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "OreRunner", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(double),
			typeof(int),
			typeof(ushort)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "ReplaceTile_DoActualReplacement_Single", MemberParameters = new object[]
		{
			typeof(ushort),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(Tile)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "ReplaceTile_DoActualReplacement_Area", MemberParameters = new object[]
		{
			typeof(ushort),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "KillTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_sTileHeader", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "SetSTileHeader", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_bTileHeader3", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "set_bTileHeader3", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		public void ClearBlockPaintAndCoating()
		{
			throw null;
		}

		// Token: 0x060027FA RID: 10234 RVA: 0x00029225 File Offset: 0x00027425
		[global::Cpp2ILInjected.Token(Token = "0x6002AB4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1174FD8", Offset = "0x1174FD8", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "Clear", MemberParameters = new object[] { typeof(TileDataType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "KillWall", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "ReplaceWall", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ushort)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "wallColor", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_bTileHeader3", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "set_bTileHeader3", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		public void ClearWallPaintAndCoating()
		{
			throw null;
		}

		// Token: 0x060027FB RID: 10235 RVA: 0x00029228 File Offset: 0x00027428
		[global::Cpp2ILInjected.Token(Token = "0x6002AB5")]
		[global::Cpp2ILInjected.Address(RVA = "0x11755C4", Offset = "0x11755C4", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Actions.ClearMetadata), Member = "Apply", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int),
			typeof(int),
			typeof(object[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "SetLiquid", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "SetSTileHeader", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "SetBTileHeader", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "SetBTileHeader2", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "SetBTileHeader3", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "SetFrameX", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "SetFrameY", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(void))]
		internal void ClearMetadata()
		{
			throw null;
		}

		// Token: 0x060027FC RID: 10236 RVA: 0x0002922B File Offset: 0x0002742B
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6002AB6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1175620", Offset = "0x1175620", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static Tile()
		{
			throw null;
		}

		// Token: 0x04002F61 RID: 12129
		[global::Cpp2ILInjected.Token(Token = "0x4003741")]
		public static Tile s_Null;

		// Token: 0x04002F62 RID: 12130
		[global::Cpp2ILInjected.Token(Token = "0x4003742")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int _tileOffset;

		// Token: 0x04002F63 RID: 12131
		[global::Cpp2ILInjected.Token(Token = "0x4003743")]
		public static ushort CurrentSearchUID;

		// Token: 0x04002F64 RID: 12132
		[global::Cpp2ILInjected.Token(Token = "0x4003744")]
		public static ushort MaxSearchUID;

		// Token: 0x04002F65 RID: 12133
		[global::Cpp2ILInjected.Token(Token = "0x4003745")]
		public const int Type_Solid = 0;

		// Token: 0x04002F66 RID: 12134
		[global::Cpp2ILInjected.Token(Token = "0x4003746")]
		public const int Type_Halfbrick = 1;

		// Token: 0x04002F67 RID: 12135
		[global::Cpp2ILInjected.Token(Token = "0x4003747")]
		public const int Type_SlopeDownRight = 2;

		// Token: 0x04002F68 RID: 12136
		[global::Cpp2ILInjected.Token(Token = "0x4003748")]
		public const int Type_SlopeDownLeft = 3;

		// Token: 0x04002F69 RID: 12137
		[global::Cpp2ILInjected.Token(Token = "0x4003749")]
		public const int Type_SlopeUpRight = 4;

		// Token: 0x04002F6A RID: 12138
		[global::Cpp2ILInjected.Token(Token = "0x400374A")]
		public const int Type_SlopeUpLeft = 5;

		// Token: 0x04002F6B RID: 12139
		[global::Cpp2ILInjected.Token(Token = "0x400374B")]
		public const int Liquid_Water = 0;

		// Token: 0x04002F6C RID: 12140
		[global::Cpp2ILInjected.Token(Token = "0x400374C")]
		public const int Liquid_Lava = 1;

		// Token: 0x04002F6D RID: 12141
		[global::Cpp2ILInjected.Token(Token = "0x400374D")]
		public const int Liquid_Honey = 2;

		// Token: 0x04002F6E RID: 12142
		[global::Cpp2ILInjected.Token(Token = "0x400374E")]
		public const int Liquid_Shimmer = 3;
	}
}
