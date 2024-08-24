using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.GameContent;
using Terraria.GameContent.Achievements;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.Biomes;
using Terraria.GameContent.Drawing;
using Terraria.GameContent.Events;
using Terraria.IO;
using Terraria.Localization;
using Terraria.ObjectData;
using Terraria.UI;
using Terraria.Utilities;
using Terraria.WorldBuilding;

namespace Terraria
{
	// Token: 0x02000311 RID: 785
	[global::Cpp2ILInjected.Token(Token = "0x20003EB")]
	public class Chest : IFixLoadedData
	{
		// Token: 0x0600191A RID: 6426 RVA: 0x000265AC File Offset: 0x000247AC
		[global::Cpp2ILInjected.Token(Token = "0x6001AAB")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC9C6C", Offset = "0xAC9C6C", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIChest), Member = "GetName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIChest), Member = "GetTitle", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LocalUser), Member = "SetupState", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldConsole), Member = "LoadChests", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldConsole), Member = "LoadWorld_Version1", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldSwitch), Member = "LoadChests", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldSwitch), Member = "LoadWorld_Version1", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Chest), Member = "AfterPlacement_Hook", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Chest), Member = "CreateChest", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "Initialize_AlmostEverything", ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChestInfo_OldMobile), Member = "Load", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "LoadChests", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "LoadWorld_Version1_Old_BeforeRelease88", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChestUI), Member = "DrawName", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 23)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public Chest(bool bank = false)
		{
			throw null;
		}

		// Token: 0x0600191B RID: 6427 RVA: 0x000265AF File Offset: 0x000247AF
		[global::Cpp2ILInjected.Token(Token = "0x6001AAC")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC9CFC", Offset = "0xAC9CFC", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x0600191C RID: 6428 RVA: 0x000265B2 File Offset: 0x000247B2
		[global::Cpp2ILInjected.Token(Token = "0x6001AAD")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC9E00", Offset = "0xAC9E00", Length = "0x5C4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "Initialize_AlmostEverything", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void Initialize()
		{
			throw null;
		}

		// Token: 0x0600191D RID: 6429 RVA: 0x000265B5 File Offset: 0x000247B5
		[global::Cpp2ILInjected.Token(Token = "0x6001AAE")]
		[global::Cpp2ILInjected.Address(RVA = "0xACA3C4", Offset = "0xACA3C4", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Chest), Member = "PutItemInNearbyChest", MemberParameters = new object[]
		{
			typeof(Item),
			typeof(Vector2)
		}, ReturnType = typeof(Item))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static bool IsPlayerInChest(int i)
		{
			throw null;
		}

		// Token: 0x0600191E RID: 6430 RVA: 0x000265B8 File Offset: 0x000247B8
		[global::Cpp2ILInjected.Token(Token = "0x6001AAF")]
		[global::Cpp2ILInjected.Address(RVA = "0xACA46C", Offset = "0xACA46C", Length = "0x160")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Event), Member = "ClearAllDD2EnergyCrystalsInChests", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static List<int> GetCurrentlyOpenChests()
		{
			throw null;
		}

		// Token: 0x0600191F RID: 6431 RVA: 0x000265BB File Offset: 0x000247BB
		[global::Cpp2ILInjected.Token(Token = "0x6001AB0")]
		[global::Cpp2ILInjected.Address(RVA = "0xACA5CC", Offset = "0xACA5CC", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Chest), Member = "PutItemInNearbyChest", MemberParameters = new object[]
		{
			typeof(Item),
			typeof(Vector2)
		}, ReturnType = typeof(Item))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "TileInteractionsUse", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static bool IsLocked(int x, int y)
		{
			throw null;
		}

		// Token: 0x06001920 RID: 6432 RVA: 0x000265BE File Offset: 0x000247BE
		[global::Cpp2ILInjected.Token(Token = "0x6001AB1")]
		[global::Cpp2ILInjected.Address(RVA = "0xACA674", Offset = "0xACA674", Length = "0x18C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "TileInteractionsUse", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "WouldTileReplacementWork", MemberParameters = new object[]
		{
			typeof(ushort),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameX", ReturnType = typeof(short))]
		public static bool IsLocked(Tile t)
		{
			throw null;
		}

		// Token: 0x06001921 RID: 6433 RVA: 0x000265C1 File Offset: 0x000247C1
		[global::Cpp2ILInjected.Token(Token = "0x6001AB2")]
		[global::Cpp2ILInjected.Address(RVA = "0xACA800", Offset = "0xACA800", Length = "0x2B4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageBuffer), Member = "ProcessData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Chest), Member = "PutItemInNearbyChest", MemberParameters = new object[]
		{
			typeof(Item),
			typeof(Vector2)
		}, ReturnType = typeof(Item))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public static void ServerPlaceItem(int plr, int slot)
		{
			throw null;
		}

		// Token: 0x06001922 RID: 6434 RVA: 0x000265C4 File Offset: 0x000247C4
		[global::Cpp2ILInjected.Token(Token = "0x6001AB3")]
		[global::Cpp2ILInjected.Address(RVA = "0xACAAB4", Offset = "0xACAAB4", Length = "0x4E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Chest), Member = "ServerPlaceItem", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "QuickStackAllChests", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetClientOnly", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Chest), Member = "IsPlayerInChest", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Chest), Member = "IsLocked", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Length", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_IsAir", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "IsTheSameAs", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Chest), Member = "VisualizeChestTransfer", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(Item),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "Clone", ReturnType = typeof(Item))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		public static Item PutItemInNearbyChest(Item item, Vector2 position)
		{
			throw null;
		}

		// Token: 0x06001923 RID: 6435 RVA: 0x000265C7 File Offset: 0x000247C7
		[global::Cpp2ILInjected.Token(Token = "0x6001AB4")]
		[global::Cpp2ILInjected.Address(RVA = "0xACAF9C", Offset = "0xACAF9C", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Chest), Member = "PutItemInNearbyChest", MemberParameters = new object[]
		{
			typeof(Item),
			typeof(Vector2)
		}, ReturnType = typeof(Item))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChestUI), Member = "QuickStack", MemberParameters = new object[]
		{
			typeof(ContainerTransferContext),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleOrchestrator), Member = "BroadcastOrRequestParticleSpawn", MemberParameters = new object[]
		{
			typeof(ParticleOrchestraType),
			typeof(ParticleOrchestraSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static void VisualizeChestTransfer(Vector2 position, Vector2 chestPosition, Item item, int amountMoved)
		{
			throw null;
		}

		// Token: 0x06001924 RID: 6436 RVA: 0x000265CA File Offset: 0x000247CA
		[global::Cpp2ILInjected.Token(Token = "0x6001AB5")]
		[global::Cpp2ILInjected.Address(RVA = "0xACB078", Offset = "0xACB078", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChestUI), Member = "QuickStack", MemberParameters = new object[]
		{
			typeof(ContainerTransferContext),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "CoinsSplit", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(int[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleOrchestrator), Member = "BroadcastOrRequestParticleSpawn", MemberParameters = new object[]
		{
			typeof(ParticleOrchestraType),
			typeof(ParticleOrchestraSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static void VisualizeChestTransfer_CoinsBatch(Vector2 position, Vector2 chestPosition, long coinsMoved)
		{
			throw null;
		}

		// Token: 0x06001925 RID: 6437 RVA: 0x000265CD File Offset: 0x000247CD
		[global::Cpp2ILInjected.Token(Token = "0x6001AB6")]
		[global::Cpp2ILInjected.Address(RVA = "0xACB1C8", Offset = "0xACB1C8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "MemberwiseClone", ReturnType = typeof(object))]
		public object Clone()
		{
			throw null;
		}

		// Token: 0x06001926 RID: 6438 RVA: 0x000265D0 File Offset: 0x000247D0
		[global::Cpp2ILInjected.Token(Token = "0x6001AB7")]
		[global::Cpp2ILInjected.Address(RVA = "0xACB1D0", Offset = "0xACB1D0", Length = "0x39C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageBuffer), Member = "ProcessData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "TileInteractionsUse", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Framing), Member = "GetTileSafely", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameX", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementsHelper), Member = "NotifyProgressionEvent", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "set_frameX", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "NewDust", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static bool Unlock(int X, int Y)
		{
			throw null;
		}

		// Token: 0x06001927 RID: 6439 RVA: 0x000265D3 File Offset: 0x000247D3
		[global::Cpp2ILInjected.Token(Token = "0x6001AB8")]
		[global::Cpp2ILInjected.Address(RVA = "0xACB56C", Offset = "0xACB56C", Length = "0x2E0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageBuffer), Member = "ProcessData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "PlaceThing_LockChest", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Framing), Member = "GetTileSafely", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameX", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementsHelper), Member = "NotifyProgressionEvent", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "set_frameX", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static bool Lock(int X, int Y)
		{
			throw null;
		}

		// Token: 0x06001928 RID: 6440 RVA: 0x000265D6 File Offset: 0x000247D6
		[global::Cpp2ILInjected.Token(Token = "0x6001AB9")]
		[global::Cpp2ILInjected.Address(RVA = "0xACB84C", Offset = "0xACB84C", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageBuffer), Member = "ProcessData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "TileInteractionsUse", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static int UsingChest(int i)
		{
			throw null;
		}

		// Token: 0x06001929 RID: 6441 RVA: 0x000265D9 File Offset: 0x000247D9
		[global::Cpp2ILInjected.Token(Token = "0x6001ABA")]
		[global::Cpp2ILInjected.Address(RVA = "0xACB93C", Offset = "0xACB93C", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIClothesWindow), Member = "GetTitle", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIClothesWindow), Member = "GetName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMap), Member = "DrawMap", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Chest), Member = "AskForChestToEatItem", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageBuffer), Member = "ProcessData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetMessage), Member = "CompressTileBlock_Inner", MemberParameters = new object[]
		{
			typeof(BinaryWriter),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "BigMimicSummonCheck", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(Player)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "TileInteractionsCheckLongDistance", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "TileInteractionsUse", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "TileInteractionsMouseOver", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "TileInteractionsMouseOver_Containers", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "GasTrapCheck", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(Player)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen.<>c", Member = "<GenerateWorld>b__277_98", MemberParameters = new object[]
		{
			typeof(GenerationProgress),
			typeof(GameConfiguration)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeadMansChestBiome), Member = "TurnGoldChestIntoDeadMansChest", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 22)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static int FindChest(int X, int Y)
		{
			throw null;
		}

		// Token: 0x0600192A RID: 6442 RVA: 0x000265DC File Offset: 0x000247DC
		[global::Cpp2ILInjected.Token(Token = "0x6001ABB")]
		[global::Cpp2ILInjected.Address(RVA = "0xACBA1C", Offset = "0xACBA1C", Length = "0x140")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawMap_FindChestName", MemberParameters = new object[]
		{
			typeof(LocalizedText[]),
			typeof(Tile),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static int FindChestByGuessing(int X, int Y)
		{
			throw null;
		}

		// Token: 0x0600192B RID: 6443 RVA: 0x000265DF File Offset: 0x000247DF
		[global::Cpp2ILInjected.Token(Token = "0x6001ABC")]
		[global::Cpp2ILInjected.Address(RVA = "0xACBB5C", Offset = "0xACBB5C", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Chest), Member = "AfterPlacement_Hook", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Chest), Member = "CreateChest", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static int FindEmptyChest(int x, int y, int type = 21, int style = 0, int direction = 1, int alternate = 0)
		{
			throw null;
		}

		// Token: 0x0600192C RID: 6444 RVA: 0x000265E2 File Offset: 0x000247E2
		[global::Cpp2ILInjected.Token(Token = "0x6001ABD")]
		[global::Cpp2ILInjected.Address(RVA = "0xACBC20", Offset = "0xACBC20", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "PlaceChest", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ushort),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Framing), Member = "GetTileSafely", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool NearOtherChests(int x, int y)
		{
			throw null;
		}

		// Token: 0x0600192D RID: 6445 RVA: 0x000265E5 File Offset: 0x000247E5
		[global::Cpp2ILInjected.Token(Token = "0x6001ABE")]
		[global::Cpp2ILInjected.Address(RVA = "0xACBD24", Offset = "0xACBD24", Length = "0x260")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point16), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "OriginToTopLeft", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref Point16)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Chest), Member = "FindEmptyChest", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetClientOnly", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Chest), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = ".ctor", ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public static int AfterPlacement_Hook(int x, int y, int type = 21, int style = 0, int direction = 1, int alternate = 0)
		{
			throw null;
		}

		// Token: 0x0600192E RID: 6446 RVA: 0x000265E8 File Offset: 0x000247E8
		[global::Cpp2ILInjected.Token(Token = "0x6001ABF")]
		[global::Cpp2ILInjected.Address(RVA = "0xACBF84", Offset = "0xACBF84", Length = "0x1BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldConsole), Member = "FixDresserChests", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldSwitch), Member = "FixDresserChests", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "Place3x2", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ushort),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "PlaceChest", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ushort),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "PlaceChestDirect", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ushort),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "PlaceDresserDirect", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ushort),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChestInfo_OldMobile), Member = "FixDresserChests", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "FixDresserChests", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Chest), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Chest), Member = "FindEmptyChest", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetClientOnly", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public static int CreateChest(int X, int Y, int id = -1)
		{
			throw null;
		}

		// Token: 0x0600192F RID: 6447 RVA: 0x000265EB File Offset: 0x000247EB
		[global::Cpp2ILInjected.Token(Token = "0x6001AC0")]
		[global::Cpp2ILInjected.Address(RVA = "0xACC140", Offset = "0xACC140", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "CheckChest", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "CanKillTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool CanDestroyChest(int X, int Y)
		{
			throw null;
		}

		// Token: 0x06001930 RID: 6448 RVA: 0x000265EE File Offset: 0x000247EE
		[global::Cpp2ILInjected.Token(Token = "0x6001AC1")]
		[global::Cpp2ILInjected.Address(RVA = "0xACC224", Offset = "0xACC224", Length = "0x198")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "BigMimicSummonCheck", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(Player)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "CheckChest", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "CheckTileBreakability2_ShouldTileSurvive", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "FindRecipes", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static bool DestroyChest(int X, int Y)
		{
			throw null;
		}

		// Token: 0x06001931 RID: 6449 RVA: 0x000265F1 File Offset: 0x000247F1
		[global::Cpp2ILInjected.Token(Token = "0x6001AC2")]
		[global::Cpp2ILInjected.Address(RVA = "0xACC3BC", Offset = "0xACC3BC", Length = "0x1F4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageBuffer), Member = "ProcessData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "FindRecipes", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public static void DestroyChestDirect(int X, int Y, int id)
		{
			throw null;
		}

		// Token: 0x06001932 RID: 6450 RVA: 0x000265F4 File Offset: 0x000247F4
		[global::Cpp2ILInjected.Token(Token = "0x6001AC3")]
		[global::Cpp2ILInjected.Address(RVA = "0xACC5B0", Offset = "0xACC5B0", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInventoryTransactions), Member = "SellItem", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "LeftClick", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "SellOrTrash", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_shopSellbackHelper", ReturnType = typeof(ItemShopSellbackHelper))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemShopSellbackHelper), Member = "Remove", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "Clone", ReturnType = typeof(Item))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void AddItemToShop(Item newItem)
		{
			throw null;
		}

		// Token: 0x06001933 RID: 6451 RVA: 0x000265F7 File Offset: 0x000247F7
		[global::Cpp2ILInjected.Token(Token = "0x6001AC4")]
		[global::Cpp2ILInjected.Address(RVA = "0xACC6B4", Offset = "0xACC6B4", Length = "0x414")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Chest), Member = "SetupTravelShop", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public static void SetupTravelShop_AddToShop(int it, ref int added, ref int count)
		{
			throw null;
		}

		// Token: 0x06001934 RID: 6452 RVA: 0x000265FA File Offset: 0x000247FA
		[global::Cpp2ILInjected.Token(Token = "0x6001AC5")]
		[global::Cpp2ILInjected.Address(RVA = "0xACCAC8", Offset = "0xACCAC8", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Chest), Member = "SetupTravelShop", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static bool SetupTravelShop_CanAddItemToShop(int it)
		{
			throw null;
		}

		// Token: 0x06001935 RID: 6453 RVA: 0x000265FD File Offset: 0x000247FD
		[global::Cpp2ILInjected.Token(Token = "0x6001AC6")]
		[global::Cpp2ILInjected.Address(RVA = "0xACCB94", Offset = "0xACCB94", Length = "0x64C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Chest), Member = "SetupTravelShop", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "RollLuck", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		public static void SetupTravelShop_GetPainting(Player playerWithHighestLuck, int[] rarity, ref int it, int minimumRarity = 0)
		{
			throw null;
		}

		// Token: 0x06001936 RID: 6454 RVA: 0x00026600 File Offset: 0x00024800
		[global::Cpp2ILInjected.Token(Token = "0x6001AC7")]
		[global::Cpp2ILInjected.Address(RVA = "0xACD1E0", Offset = "0xACD1E0", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Chest), Member = "SetupTravelShop", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public static void SetupTravelShop_AdjustSlotRarities(int slotItemAttempts, ref int[] rarity)
		{
			throw null;
		}

		// Token: 0x06001937 RID: 6455 RVA: 0x00026603 File Offset: 0x00024803
		[global::Cpp2ILInjected.Token(Token = "0x6001AC8")]
		[global::Cpp2ILInjected.Address(RVA = "0xACD2A8", Offset = "0xACD2A8", Length = "0xA30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Chest), Member = "SetupTravelShop", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "RollLuck", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		public static void SetupTravelShop_GetItem(Player playerWithHighestLuck, int[] rarity, ref int it, int minimumRarity = 0)
		{
			throw null;
		}

		// Token: 0x06001938 RID: 6456 RVA: 0x00026606 File Offset: 0x00024806
		[global::Cpp2ILInjected.Token(Token = "0x6001AC9")]
		[global::Cpp2ILInjected.Address(RVA = "0xACDCD8", Offset = "0xACDCD8", Length = "0x428")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "Initialize_AlmostEverything", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "SpawnTravelNPC", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "RollLuck", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_expertMode", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Chest), Member = "SetupTravelShop_AdjustSlotRarities", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Chest), Member = "SetupTravelShop_GetItem", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(int[]),
			typeof(ref int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Chest), Member = "SetupTravelShop_CanAddItemToShop", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Chest), Member = "SetupTravelShop_AddToShop", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Chest), Member = "SetupTravelShop_GetPainting", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(int[]),
			typeof(ref int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		public static void SetupTravelShop()
		{
			throw null;
		}

		// Token: 0x06001939 RID: 6457 RVA: 0x00026609 File Offset: 0x00024809
		[global::Cpp2ILInjected.Token(Token = "0x6001ACA")]
		[global::Cpp2ILInjected.Address(RVA = "0xACE100", Offset = "0xACE100", Length = "0x8060")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUINPCDialogue), Member = "Option1Clicked", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUINPCDialogue), Member = "Option2Clicked", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "Initialize_AlmostEverything", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "OpenShop", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalPlayer", ReturnType = typeof(Player))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ZoneGraveyard", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "HasItem", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "AnyNPCs", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetClient", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenWidth", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "netDefaults", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "GetBestiaryProgressReport", ReturnType = typeof(BestiaryUnlockProgressReport))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Chest), Member = "BestiaryGirl_IsFairyTorchAvailable", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LanternNight), Member = "get_LanternsUp", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BirthdayParty), Member = "get_PartyIsUp", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ZoneJungle", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BestiaryUnlockProgressReport), Member = "get_CompletionPercent", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ZoneSnow", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ZoneDesert", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "buyPrice", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int?), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ZoneUnderworldHeight", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ZoneGlowshroom", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ShoppingZone_Forest", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ZoneCrimson", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ZoneCorrupt", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ZoneHallow", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToTileCoordinates16", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Point16))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TeleportPylonsSystem), Member = "DoesPositionHaveEnoughNPCs", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Point16)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "get_UseHorizontalPages", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ZoneBeach", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 409)]
		public void SetupShop(int type)
		{
			throw null;
		}

		// Token: 0x0600193A RID: 6458 RVA: 0x0002660C File Offset: 0x0002480C
		[global::Cpp2ILInjected.Token(Token = "0x6001ACB")]
		[global::Cpp2ILInjected.Address(RVA = "0xAD6160", Offset = "0xAD6160", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Chest), Member = "SetupShop", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Chest), Member = "DidDiscoverBestiaryEntry", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static bool BestiaryGirl_IsFairyTorchAvailable()
		{
			throw null;
		}

		// Token: 0x0600193B RID: 6459 RVA: 0x0002660F File Offset: 0x0002480F
		[global::Cpp2ILInjected.Token(Token = "0x6001ACC")]
		[global::Cpp2ILInjected.Address(RVA = "0xAD61F8", Offset = "0xAD61F8", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Chest), Member = "BestiaryGirl_IsFairyTorchAvailable", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BestiaryDatabase), Member = "FindEntryByNPCID", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(BestiaryEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static bool DidDiscoverBestiaryEntry(int npcId)
		{
			throw null;
		}

		// Token: 0x0600193C RID: 6460 RVA: 0x00026612 File Offset: 0x00024812
		[global::Cpp2ILInjected.Token(Token = "0x6001ACD")]
		[global::Cpp2ILInjected.Address(RVA = "0xAD62D8", Offset = "0xAD62D8", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleOrchestrator), Member = "Spawn_ItemTransfer", MemberParameters = new object[] { typeof(ParticleOrchestraSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToTileCoordinates", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Point))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Chest), Member = "FindChest", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static void AskForChestToEatItem(Vector2 worldPosition, int duration)
		{
			throw null;
		}

		// Token: 0x0600193D RID: 6461 RVA: 0x00026615 File Offset: 0x00024815
		[global::Cpp2ILInjected.Token(Token = "0x6001ACE")]
		[global::Cpp2ILInjected.Address(RVA = "0xAD63CC", Offset = "0xAD63CC", Length = "0x310")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoUpdateInWorld", MemberParameters = new object[] { typeof(Stopwatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<int>), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<int>), Member = "Add", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<int>), Member = "Contains", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Vector2),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public static void UpdateChestFrames()
		{
			throw null;
		}

		// Token: 0x0600193E RID: 6462 RVA: 0x00026618 File Offset: 0x00024818
		[global::Cpp2ILInjected.Token(Token = "0x6001ACF")]
		[global::Cpp2ILInjected.Address(RVA = "0xAD66DC", Offset = "0xAD66DC", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "FixAgainstExploits", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "FixAgainstExploit", ReturnType = typeof(void))]
		public void FixLoadedData()
		{
			throw null;
		}

		// Token: 0x0600193F RID: 6463 RVA: 0x0002661B File Offset: 0x0002481B
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001AD0")]
		[global::Cpp2ILInjected.Address(RVA = "0xAD6724", Offset = "0xAD6724", Length = "0x116C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<int>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		static Chest()
		{
			throw null;
		}

		// Token: 0x0400217D RID: 8573
		[global::Cpp2ILInjected.Token(Token = "0x40027EF")]
		private static HashSet<int> _chestInUse;

		// Token: 0x0400217E RID: 8574
		[global::Cpp2ILInjected.Token(Token = "0x40027F0")]
		public const float chestStackRange = 600f;

		// Token: 0x0400217F RID: 8575
		[global::Cpp2ILInjected.Token(Token = "0x40027F1")]
		public const int maxChestTypes = 52;

		// Token: 0x04002180 RID: 8576
		[global::Cpp2ILInjected.Token(Token = "0x40027F2")]
		public static int[] chestTypeToIcon;

		// Token: 0x04002181 RID: 8577
		[global::Cpp2ILInjected.Token(Token = "0x40027F3")]
		public static int[] chestItemSpawn;

		// Token: 0x04002182 RID: 8578
		[global::Cpp2ILInjected.Token(Token = "0x40027F4")]
		public const int maxChestTypes2 = 17;

		// Token: 0x04002183 RID: 8579
		[global::Cpp2ILInjected.Token(Token = "0x40027F5")]
		public static int[] chestTypeToIcon2;

		// Token: 0x04002184 RID: 8580
		[global::Cpp2ILInjected.Token(Token = "0x40027F6")]
		public static int[] chestItemSpawn2;

		// Token: 0x04002185 RID: 8581
		[global::Cpp2ILInjected.Token(Token = "0x40027F7")]
		public const int maxDresserTypes = 43;

		// Token: 0x04002186 RID: 8582
		[global::Cpp2ILInjected.Token(Token = "0x40027F8")]
		public static int[] dresserTypeToIcon;

		// Token: 0x04002187 RID: 8583
		[global::Cpp2ILInjected.Token(Token = "0x40027F9")]
		public static int[] dresserItemSpawn;

		// Token: 0x04002188 RID: 8584
		[global::Cpp2ILInjected.Token(Token = "0x40027FA")]
		public const int maxItems = 40;

		// Token: 0x04002189 RID: 8585
		[global::Cpp2ILInjected.Token(Token = "0x40027FB")]
		public const int MaxNameLength = 29;

		// Token: 0x0400218A RID: 8586
		[global::Cpp2ILInjected.Token(Token = "0x40027FC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public Item[] item;

		// Token: 0x0400218B RID: 8587
		[global::Cpp2ILInjected.Token(Token = "0x40027FD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public int x;

		// Token: 0x0400218C RID: 8588
		[global::Cpp2ILInjected.Token(Token = "0x40027FE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public int y;

		// Token: 0x0400218D RID: 8589
		[global::Cpp2ILInjected.Token(Token = "0x40027FF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public bool bankChest;

		// Token: 0x0400218E RID: 8590
		[global::Cpp2ILInjected.Token(Token = "0x4002800")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public string name;

		// Token: 0x0400218F RID: 8591
		[global::Cpp2ILInjected.Token(Token = "0x4002801")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public int frameCounter;

		// Token: 0x04002190 RID: 8592
		[global::Cpp2ILInjected.Token(Token = "0x4002802")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		public int frame;

		// Token: 0x04002191 RID: 8593
		[global::Cpp2ILInjected.Token(Token = "0x4002803")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public int eatingAnimationTime;

		// Token: 0x04002192 RID: 8594
		[global::Cpp2ILInjected.Token(Token = "0x4002804")]
		private static Item[] bartenderResort;

		// Token: 0x04002193 RID: 8595
		[global::Cpp2ILInjected.Token(Token = "0x4002805")]
		private static int forcedDDTier;
	}
}
