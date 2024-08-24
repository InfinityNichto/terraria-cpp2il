using System;
using System.Collections.Generic;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Ionic.Zlib;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.Events;
using Terraria.ID;
using Terraria.IO;
using Terraria.Localization;
using Terraria.ObjectData;
using Terraria.Utilities;
using UnityEngine;

// Token: 0x0200022E RID: 558
[global::Cpp2ILInjected.Token(Token = "0x20002E0")]
internal class WorldFile_OldConsole
{
	// Token: 0x06000F94 RID: 3988 RVA: 0x000249B9 File Offset: 0x00022BB9
	[global::Cpp2ILInjected.Token(Token = "0x60010DD")]
	[global::Cpp2ILInjected.Address(RVA = "0xA5266C", Offset = "0xA5266C", Length = "0xF4C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "LoadWorlds", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldFileData), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(string),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileUtilities), Member = "Exists", MemberParameters = new object[]
	{
		typeof(string),
		typeof(bool)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileUtilities), Member = "ReadAllBytes", MemberParameters = new object[]
	{
		typeof(string),
		typeof(bool)
	}, ReturnType = typeof(byte[]))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitConverter), Member = "ToInt32", MemberParameters = new object[]
	{
		typeof(byte[]),
		typeof(int)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(byte[]),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateStream), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(Stream),
		typeof(CompressionMode)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = "CopyTo", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileMetadata), Member = "FromCurrentSettings", MemberParameters = new object[] { typeof(FileType) }, ReturnType = typeof(FileMetadata))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryReader), Member = ".ctor", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileMetadata), Member = "Read", MemberParameters = new object[]
	{
		typeof(BinaryReader),
		typeof(FileType)
	}, ReturnType = typeof(FileMetadata))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Guid), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldFileData), Member = "SetWorldSize", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "FromBinary", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(DateTime))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldFileData), Member = "set_HasCrimson", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 56)]
	public static WorldFileData GetAllMetadata(string file)
	{
		throw null;
	}

	// Token: 0x06000F95 RID: 3989 RVA: 0x000249BC File Offset: 0x00022BBC
	[global::Cpp2ILInjected.Token(Token = "0x60010DE")]
	[global::Cpp2ILInjected.Address(RVA = "0xA535B8", Offset = "0xA535B8", Length = "0x374")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldConsole), Member = "LoadSaveData", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(byte[]),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateStream), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(Stream),
		typeof(CompressionMode)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = "CopyTo", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
	public static byte[] DecompressData(byte[] srcData)
	{
		throw null;
	}

	// Token: 0x06000F96 RID: 3990 RVA: 0x000249BF File Offset: 0x00022BBF
	[global::Cpp2ILInjected.Token(Token = "0x60010DF")]
	[global::Cpp2ILInjected.Address(RVA = "0xA5392C", Offset = "0xA5392C", Length = "0x3C0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "LoadWorld", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitConverter), Member = "ToInt32", MemberParameters = new object[]
	{
		typeof(byte[]),
		typeof(int)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldFile_OldConsole), Member = "DecompressData", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryReader), Member = ".ctor", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldFile_OldConsole), Member = "LoadWorld_Version2", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldFile_OldConsole), Member = "LoadWorld_Version1", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldFile_OldConsole), Member = "CleanItemsStoredInTiles", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
	public static bool LoadSaveData(byte[] srcData)
	{
		throw null;
	}

	// Token: 0x06000F97 RID: 3991 RVA: 0x000249C2 File Offset: 0x00022BC2
	[global::Cpp2ILInjected.Token(Token = "0x60010E0")]
	[global::Cpp2ILInjected.Address(RVA = "0xA56A54", Offset = "0xA56A54", Length = "0x118")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldConsole), Member = "LoadSaveData", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(Tile))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldFile_OldConsole), Member = "CheckWeaponsRack", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldFile_OldConsole), Member = "CheckMannequin", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	private static void CleanItemsStoredInTiles()
	{
		throw null;
	}

	// Token: 0x06000F98 RID: 3992 RVA: 0x000249C5 File Offset: 0x00022BC5
	[global::Cpp2ILInjected.Token(Token = "0x60010E1")]
	[global::Cpp2ILInjected.Address(RVA = "0xA56B6C", Offset = "0xA56B6C", Length = "0x3AC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldConsole), Member = "CleanItemsStoredInTiles", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(Tile))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameY", ReturnType = typeof(short))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameX", ReturnType = typeof(short))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "SetFrameX", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "SetFrameY", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemConversion_OldConsole), Member = "ModifyItem", MemberParameters = new object[]
	{
		typeof(ref short),
		typeof(ref short),
		typeof(ref byte),
		typeof(bool)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "Prefix", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldFile_OldConsole), Member = "ItemFitsWeaponRack", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldFile_OldConsole), Member = "PlaceWeapon", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(Item)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
	private static void CheckWeaponsRack(int i, int j)
	{
		throw null;
	}

	// Token: 0x06000F99 RID: 3993 RVA: 0x000249C8 File Offset: 0x00022BC8
	[global::Cpp2ILInjected.Token(Token = "0x60010E2")]
	[global::Cpp2ILInjected.Address(RVA = "0xA574B4", Offset = "0xA574B4", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldConsole), Member = "CheckWeaponsRack", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	public static bool ItemFitsWeaponRack(Item i)
	{
		throw null;
	}

	// Token: 0x06000F9A RID: 3994 RVA: 0x000249CB File Offset: 0x00022BCB
	[global::Cpp2ILInjected.Token(Token = "0x60010E3")]
	[global::Cpp2ILInjected.Address(RVA = "0xA5750C", Offset = "0xA5750C", Length = "0x330")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldConsole), Member = "CheckWeaponsRack", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(Tile))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameY", ReturnType = typeof(short))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameX", ReturnType = typeof(short))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "SetFrameX", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
	public static void PlaceWeapon(int x, int y, Item item)
	{
		throw null;
	}

	// Token: 0x06000F9B RID: 3995 RVA: 0x000249CE File Offset: 0x00022BCE
	[global::Cpp2ILInjected.Token(Token = "0x60010E4")]
	[global::Cpp2ILInjected.Address(RVA = "0xA56F18", Offset = "0xA56F18", Length = "0x59C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldConsole), Member = "CleanItemsStoredInTiles", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(Tile))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameX", ReturnType = typeof(short))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameY", ReturnType = typeof(short))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemConversion_OldConsole), Member = "ModifyBodySlot", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemConversion_OldConsole), Member = "ModifyHeadSlot", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemConversion_OldConsole), Member = "ModifyItem", MemberParameters = new object[]
	{
		typeof(ref short),
		typeof(ref short),
		typeof(ref byte),
		typeof(bool)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "SetFrameX", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "netDefaults", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "Prefix", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemConversion_OldConsole), Member = "ModifyLegSlot", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
	private static void CheckMannequin(int i, int j)
	{
		throw null;
	}

	// Token: 0x06000F9C RID: 3996 RVA: 0x000249D1 File Offset: 0x00022BD1
	[global::Cpp2ILInjected.Token(Token = "0x60010E5")]
	[global::Cpp2ILInjected.Address(RVA = "0xA5678C", Offset = "0xA5678C", Length = "0x2C8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldConsole), Member = "LoadSaveData", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldFile_OldConsole), Member = "LoadFileFormatHeader", MemberParameters = new object[]
	{
		typeof(BinaryReader),
		typeof(ref bool[]),
		typeof(ref int[])
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldFile_OldConsole), Member = "LoadHeader", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldFile_OldConsole), Member = "LoadWorldTiles", MemberParameters = new object[]
	{
		typeof(BinaryReader),
		typeof(bool[])
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldFile_OldConsole), Member = "LoadChests", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldFile_OldConsole), Member = "LoadSigns", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldFile_OldConsole), Member = "LoadNPCs", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldFile_OldConsole), Member = "LoadTileEntities", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldFile_OldConsole), Member = "LoadDummies", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldFile_OldConsole), Member = "LoadWeightedPressurePlates", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldFile_OldConsole), Member = "LoadTownManager", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BestiaryUnlocksTracker), Member = "FillBasedOnVersionBefore210", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldFile_OldConsole), Member = "LoadFooter", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	private static int LoadWorld_Version2(BinaryReader reader)
	{
		throw null;
	}

	// Token: 0x06000F9D RID: 3997 RVA: 0x000249D4 File Offset: 0x00022BD4
	[global::Cpp2ILInjected.Token(Token = "0x60010E6")]
	[global::Cpp2ILInjected.Address(RVA = "0xA5BAA4", Offset = "0xA5BAA4", Length = "0x154")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldConsole), Member = "LoadWorld_Version2", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PressurePlateHelper), Member = "Reset", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Point, object>), Member = "Add", MemberParameters = new object[]
	{
		typeof(Point),
		typeof(object)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
	private static void LoadWeightedPressurePlates(BinaryReader reader)
	{
		throw null;
	}

	// Token: 0x06000F9E RID: 3998 RVA: 0x000249D7 File Offset: 0x00022BD7
	[global::Cpp2ILInjected.Token(Token = "0x60010E7")]
	[global::Cpp2ILInjected.Address(RVA = "0xA5BBF8", Offset = "0xA5BBF8", Length = "0x64")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldConsole), Member = "LoadWorld_Version2", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TownRoomManager), Member = "Load", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	private static void LoadTownManager(BinaryReader reader)
	{
		throw null;
	}

	// Token: 0x06000F9F RID: 3999 RVA: 0x000249DA File Offset: 0x00022BDA
	[global::Cpp2ILInjected.Token(Token = "0x60010E8")]
	[global::Cpp2ILInjected.Address(RVA = "0xA5B3A8", Offset = "0xA5B3A8", Length = "0x6FC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldConsole), Member = "LoadWorld_Version2", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileEntity), Member = "Clear", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileEntity), Member = "Read", MemberParameters = new object[]
	{
		typeof(BinaryReader),
		typeof(bool)
	}, ReturnType = typeof(TileEntity))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "set_Item", MemberParameters = new object[]
	{
		typeof(int),
		typeof(object)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileEntity), Member = "get_PositionKey", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "TryGetValue", MemberParameters = new object[]
	{
		typeof(int),
		typeof(ref object)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "Remove", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Point16>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "InWorld", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileEntitiesManager), Member = "CheckValidTile", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Point16>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Point16>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileEntity), Member = "GetKey", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "ContainsKey", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Point16>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 47)]
	private static void LoadTileEntities(BinaryReader reader)
	{
		throw null;
	}

	// Token: 0x06000FA0 RID: 4000 RVA: 0x000249DD File Offset: 0x00022BDD
	[global::Cpp2ILInjected.Token(Token = "0x60010E9")]
	[global::Cpp2ILInjected.Address(RVA = "0xA5783C", Offset = "0xA5783C", Length = "0x304")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldConsole), Member = "LoadWorld_Version2", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileMetadata), Member = "FromCurrentSettings", MemberParameters = new object[] { typeof(FileType) }, ReturnType = typeof(FileMetadata))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileMetadata), Member = "Read", MemberParameters = new object[]
	{
		typeof(BinaryReader),
		typeof(FileType)
	}, ReturnType = typeof(FileMetadata))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Console), Member = "WriteLine", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Console), Member = "WriteLine", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
	private static bool LoadFileFormatHeader(BinaryReader reader, out bool[] importance, out int[] positions)
	{
		throw null;
	}

	// Token: 0x06000FA1 RID: 4001 RVA: 0x000249E0 File Offset: 0x00022BE0
	[global::Cpp2ILInjected.Token(Token = "0x60010EA")]
	[global::Cpp2ILInjected.Address(RVA = "0xA57B40", Offset = "0xA57B40", Length = "0x1BA0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldConsole), Member = "LoadWorld_Version2", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Guid), Member = "NewGuid", ReturnType = typeof(Guid))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Guid), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "clearWorld", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_GameMode", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "FromBinary", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(DateTime))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "get_genRand", ReturnType = typeof(UnifiedRandom))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_spawnTileX", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_spawnTileY", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "setBG", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
	{
		typeof(Array),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "FakeLoadInvasionStart", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "UpdateTimeRate", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "get_ShieldStrengthTowerMax", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DD2Event), Member = "Load", MemberParameters = new object[]
	{
		typeof(BinaryReader),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DD2Event), Member = "ResetProgressEntirely", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TreeTopsInfo), Member = "CopyExistingWorldInfo", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 83)]
	private static void LoadHeader(BinaryReader reader)
	{
		throw null;
	}

	// Token: 0x06000FA2 RID: 4002 RVA: 0x000249E3 File Offset: 0x00022BE3
	[global::Cpp2ILInjected.Token(Token = "0x60010EB")]
	[global::Cpp2ILInjected.Address(RVA = "0xA596E0", Offset = "0xA596E0", Length = "0x114C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldConsole), Member = "LoadWorld_Version2", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string),
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemRemapUtility), Member = "RemapENGINEMannequin", MemberParameters = new object[]
	{
		typeof(ref short),
		typeof(ref short)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "GetTileData", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(TileObjectData))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "get_CoordinateFullHeight", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "get_CoordinateHeights", ReturnType = typeof(int[]))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = "get_CoordinatePadding", ReturnType = typeof(int))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "AddUpAlignmentCounts", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "FixHearts", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 36)]
	private static void LoadWorldTiles(BinaryReader reader, bool[] importance)
	{
		throw null;
	}

	// Token: 0x06000FA3 RID: 4003 RVA: 0x000249E6 File Offset: 0x00022BE6
	[global::Cpp2ILInjected.Token(Token = "0x60010EC")]
	[global::Cpp2ILInjected.Address(RVA = "0xA5A82C", Offset = "0xA5A82C", Length = "0x500")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldConsole), Member = "LoadWorld_Version2", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Chest), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldFile_OldConsole), Member = "ReadItemID", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemConversion_OldConsole), Member = "ModifyItem", MemberParameters = new object[]
	{
		typeof(ref short),
		typeof(ref short),
		typeof(ref byte),
		typeof(bool)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "netDefaults", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "Prefix", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Point16>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point16), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Point16>), Member = "Contains", MemberParameters = new object[] { typeof(Point16) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldFile_OldConsole), Member = "FixDresserChests", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
	private static void LoadChests(BinaryReader reader)
	{
		throw null;
	}

	// Token: 0x06000FA4 RID: 4004 RVA: 0x000249E9 File Offset: 0x00022BE9
	[global::Cpp2ILInjected.Token(Token = "0x60010ED")]
	[global::Cpp2ILInjected.Address(RVA = "0xA5BDB8", Offset = "0xA5BDB8", Length = "0x1B4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldConsole), Member = "LoadChests", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(Tile))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameX", ReturnType = typeof(short))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameY", ReturnType = typeof(short))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Chest), Member = "CreateChest", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
	private static void FixDresserChests()
	{
		throw null;
	}

	// Token: 0x06000FA5 RID: 4005 RVA: 0x000249EC File Offset: 0x00022BEC
	[global::Cpp2ILInjected.Token(Token = "0x60010EE")]
	[global::Cpp2ILInjected.Address(RVA = "0xA5AD2C", Offset = "0xA5AD2C", Length = "0x368")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldConsole), Member = "LoadWorld_Version2", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(Tile))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Sign), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Point16>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point16), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Point16>), Member = "Contains", MemberParameters = new object[] { typeof(Point16) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
	private static void LoadSigns(BinaryReader reader)
	{
		throw null;
	}

	// Token: 0x06000FA6 RID: 4006 RVA: 0x000249EF File Offset: 0x00022BEF
	[global::Cpp2ILInjected.Token(Token = "0x60010EF")]
	[global::Cpp2ILInjected.Address(RVA = "0xA5B344", Offset = "0xA5B344", Length = "0x64")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldConsole), Member = "LoadWorld_Version2", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	private static void LoadDummies(BinaryReader reader)
	{
		throw null;
	}

	// Token: 0x06000FA7 RID: 4007 RVA: 0x000249F2 File Offset: 0x00022BF2
	[global::Cpp2ILInjected.Token(Token = "0x60010F0")]
	[global::Cpp2ILInjected.Address(RVA = "0xA5B094", Offset = "0xA5B094", Length = "0x2B0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldConsole), Member = "LoadWorld_Version2", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCID), Member = "FromLegacyName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "SetDefaults", MemberParameters = new object[]
	{
		typeof(int),
		typeof(NPCSpawnParams)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "set_GivenName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ReadVector2", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
	private static void LoadNPCs(BinaryReader reader)
	{
		throw null;
	}

	// Token: 0x06000FA8 RID: 4008 RVA: 0x000249F5 File Offset: 0x00022BF5
	[global::Cpp2ILInjected.Token(Token = "0x60010F1")]
	[global::Cpp2ILInjected.Address(RVA = "0xA5BC5C", Offset = "0xA5BC5C", Length = "0xE8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldConsole), Member = "LoadWorld_Version2", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	private static int LoadFooter(BinaryReader reader)
	{
		throw null;
	}

	// Token: 0x06000FA9 RID: 4009 RVA: 0x000249F8 File Offset: 0x00022BF8
	[global::Cpp2ILInjected.Token(Token = "0x60010F2")]
	[global::Cpp2ILInjected.Address(RVA = "0xA53CEC", Offset = "0xA53CEC", Length = "0x2AA0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldConsole), Member = "LoadSaveData", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileMetadata), Member = "FromCurrentSettings", MemberParameters = new object[] { typeof(FileType) }, ReturnType = typeof(FileMetadata))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_GameMode", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "get_genRand", ReturnType = typeof(UnifiedRandom))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "RandomizeMoonState", MemberParameters = new object[]
	{
		typeof(UnifiedRandom),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "clearWorld", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "RandomizeCaveBackgrounds", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_spawnTileX", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_spawnTileY", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "setBG", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "RandomizeWeather", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string),
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(Tile))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "set_type", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "set_frameX", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "set_frameY", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "set_wall", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_wall", ReturnType = typeof(ushort))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "wallColor", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "set_liquid", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "lava", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "honey", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "wire", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "wire2", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "wire3", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "halfBrick", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "slope", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "actuator", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "inActive", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "color", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "CopyFrom", MemberParameters = new object[] { typeof(Tile) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "AddUpAlignmentCounts", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "FixSunflowers", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "FixChands", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Chest), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemID), Member = "FromLegacyName", MemberParameters = new object[]
	{
		typeof(string),
		typeof(int)
	}, ReturnType = typeof(short))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldFile_OldConsole), Member = "ReadItemID", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "netDefaults", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "Prefix", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Sign), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCID), Member = "FromLegacyName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "SetDefaults", MemberParameters = new object[]
	{
		typeof(int),
		typeof(NPCSpawnParams)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "set_GivenName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "setNPCName", MemberParameters = new object[]
	{
		typeof(string),
		typeof(int),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "FakeLoadInvasionStart", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 130)]
	public static int LoadWorld_Version1(BinaryReader fileIO)
	{
		throw null;
	}

	// Token: 0x06000FAA RID: 4010 RVA: 0x000249FB File Offset: 0x00022BFB
	[global::Cpp2ILInjected.Token(Token = "0x60010F3")]
	[global::Cpp2ILInjected.Address(RVA = "0xA5BD44", Offset = "0xA5BD44", Length = "0x74")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldConsole), Member = "LoadChests", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldConsole), Member = "LoadWorld_Version1", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemRemapUtility), Member = "RemapItemID", MemberParameters = new object[]
	{
		typeof(int),
		typeof(bool)
	}, ReturnType = typeof(short))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private static int ReadItemID(BinaryReader fileIO)
	{
		throw null;
	}

	// Token: 0x06000FAB RID: 4011 RVA: 0x000249FE File Offset: 0x00022BFE
	[global::Cpp2ILInjected.Token(Token = "0x60010F4")]
	[global::Cpp2ILInjected.Address(RVA = "0xA5BF6C", Offset = "0xA5BF6C", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public WorldFile_OldConsole()
	{
		throw null;
	}

	// Token: 0x04001B36 RID: 6966
	[global::Cpp2ILInjected.Token(Token = "0x40020C3")]
	public const int WorldVersion_AddGUID = 1000;

	// Token: 0x04001B37 RID: 6967
	[global::Cpp2ILInjected.Token(Token = "0x40020C4")]
	public const int WorldVersion_CompressWorld = 1001;

	// Token: 0x04001B38 RID: 6968
	[global::Cpp2ILInjected.Token(Token = "0x40020C5")]
	public const int WorldVersion_StoreFrameAsRowsAndColumnsInsteadOfPixels = 1002;

	// Token: 0x04001B39 RID: 6969
	[global::Cpp2ILInjected.Token(Token = "0x40020C6")]
	public const int WorldVersion_1_3_2 = 1003;

	// Token: 0x04001B3A RID: 6970
	[global::Cpp2ILInjected.Token(Token = "0x40020C7")]
	public const int WorldVersion_1_3_3 = 1004;

	// Token: 0x04001B3B RID: 6971
	[global::Cpp2ILInjected.Token(Token = "0x40020C8")]
	public const int WorldVersion_1_3_4 = 1005;

	// Token: 0x04001B3C RID: 6972
	[global::Cpp2ILInjected.Token(Token = "0x40020C9")]
	public const int WorldVersion_RemapConsoleSpecificItems = 1006;

	// Token: 0x04001B3D RID: 6973
	[global::Cpp2ILInjected.Token(Token = "0x40020CA")]
	public const int WorldVersionOneMaxRelease = 87;

	// Token: 0x04001B3E RID: 6974
	[global::Cpp2ILInjected.Token(Token = "0x40020CB")]
	public const int WorldFileVersion = 1006;

	// Token: 0x04001B3F RID: 6975
	[global::Cpp2ILInjected.Token(Token = "0x40020CC")]
	public const int ApproximateWriteSize = 7000000;

	// Token: 0x04001B40 RID: 6976
	[global::Cpp2ILInjected.Token(Token = "0x40020CD")]
	public const int MaximumWriteSize = 16777216;

	// Token: 0x04001B41 RID: 6977
	[global::Cpp2ILInjected.Token(Token = "0x40020CE")]
	private static int versionNumber;
}
