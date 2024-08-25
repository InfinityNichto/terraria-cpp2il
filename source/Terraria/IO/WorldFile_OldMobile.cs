using System;
using System.Collections.Generic;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Social.Base;
using Terraria.Utilities;
using UnityEngine;

namespace Terraria.IO
{
	[global::Cpp2ILInjected.Token(Token = "0x2000577")]
	public class WorldFile_OldMobile
	{
		[global::Cpp2ILInjected.Token(Token = "0x60033F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x13476B8", Offset = "0x13476B8", Length = "0x3C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "LoadWorld", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryReader), Member = ".ctor", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldFile_OldMobile), Member = "loadWorldHeader", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldFile_OldMobile), Member = "loadWorldData", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		public bool LoadSaveData(byte[] srcData)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60033F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1347A78", Offset = "0x1347A78", Length = "0x2C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldMobile), Member = "LoadSaveData", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileMetadata), Member = "FromCurrentSettings", MemberParameters = new object[] { typeof(FileType) }, ReturnType = typeof(FileMetadata))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileHelpers), Member = "ReadNetString", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileHelpers), Member = "ReadOldNetString", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private int loadWorldHeader(BinaryReader fileIO)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60033F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1348888", Offset = "0x1348888", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldMobile), Member = "loadWorldData", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldMobile), Member = "loadWorldDataMeta", MemberParameters = new object[]
		{
			typeof(WorldFileData),
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BlowFish), Member = "Initialize", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BlowFish), Member = "Decode", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(byte*),
			typeof(uint)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private unsafe static void DecryptWorldData(long offset, long encryptedSize)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60033F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x13489D8", Offset = "0x13489D8", Length = "0x418")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldMobile), Member = "loadWorldData", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitConverter), Member = "GetBytes", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		private void BadMarker(BinaryReader reader, string marker)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60033F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1347D38", Offset = "0x1347D38", Length = "0xB50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldMobile), Member = "LoadSaveData", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldFile_OldMobile), Member = "DecryptWorldData", MemberParameters = new object[]
		{
			typeof(long),
			typeof(long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Guid), Member = "NewGuid", ReturnType = typeof(Guid))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_GameMode", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "clearWorld", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_spawnTileX", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_spawnTileY", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_spawnTileY", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeInfo_OldMobile), Member = "Load", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Weather_OldMobile), Member = "Load", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCInfo_OldMobile), Member = "Load", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FishingInfo_OldMobile), Member = "Load", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RandomStyleInfo_OldMobile), Member = "Load", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "setBG", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TilInfo_OldMobile), Member = "Load", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChestInfo_OldMobile), Member = "Load", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SignInfo_OldMobile), Member = "Load", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCInfo_OldMobile), Member = "LoadNPCEntries", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCInfo_OldMobile), Member = "ReadNPCNames", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldFile_OldMobile), Member = "BadMarker", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 32)]
		private void loadWorldData(BinaryReader reader, int release)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60033F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1348DF0", Offset = "0x1348DF0", Length = "0x1B4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = "CopyTo", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public static byte[] ReadAllBytes(Stream stream)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60033FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1348FA4", Offset = "0x1348FA4", Length = "0x610")]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "GetCreationTime", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CloudSocialModule), Member = "Read", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileMetadata), Member = "FromCurrentSettings", MemberParameters = new object[] { typeof(FileType) }, ReturnType = typeof(FileMetadata))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileUtilities), Member = "ReadAllBytes", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryReader), Member = ".ctor", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldFile_OldMobile), Member = "loadWorldHeaderMeta", MemberParameters = new object[]
		{
			typeof(WorldFileData),
			typeof(BinaryReader)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldFile_OldMobile), Member = "loadWorldDataMeta", MemberParameters = new object[]
		{
			typeof(WorldFileData),
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 45)]
		public static WorldFileData GetAllMetadata(string file, bool cloudSave)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60033FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x13495B4", Offset = "0x13495B4", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldMobile), Member = "GetAllMetadata", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(WorldFileData))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileHelpers), Member = "ReadNetString", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileHelpers), Member = "ReadOldNetString", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(string))]
		private static int loadWorldHeaderMeta(WorldFileData data, BinaryReader fileIO)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60033FC")]
		[global::Cpp2ILInjected.Address(RVA = "0x13496A4", Offset = "0x13496A4", Length = "0x344")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldMobile), Member = "GetAllMetadata", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(WorldFileData))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldFile_OldMobile), Member = "DecryptWorldData", MemberParameters = new object[]
		{
			typeof(long),
			typeof(long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldFileData), Member = "SetWorldSize", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeInfo_OldMobile), Member = "LoadMeta", MemberParameters = new object[]
		{
			typeof(WorldFileData),
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldFileData), Member = "set_HasCrimson", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Weather_OldMobile), Member = "LoadMeta", MemberParameters = new object[]
		{
			typeof(WorldFileData),
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCInfo_OldMobile), Member = "LoadMeta", MemberParameters = new object[]
		{
			typeof(WorldFileData),
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static void loadWorldDataMeta(WorldFileData data, BinaryReader reader, int release)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60033FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x13499E8", Offset = "0x13499E8", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "LoadWorld", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<uint>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public WorldFile_OldMobile()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60033FE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1349A64", Offset = "0x1349A64", Length = "0x240")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCInfo_OldMobile), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FishingInfo_OldMobile), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RandomStyleInfo_OldMobile), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BlowFish), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		static WorldFile_OldMobile()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4003E3A")]
		public const int VERSION_49 = 49;

		[global::Cpp2ILInjected.Token(Token = "0x4003E3B")]
		public const int VERSION_50 = 50;

		[global::Cpp2ILInjected.Token(Token = "0x4003E3C")]
		public const int VERSION_51 = 51;

		[global::Cpp2ILInjected.Token(Token = "0x4003E3D")]
		public const int VERSION_52 = 52;

		[global::Cpp2ILInjected.Token(Token = "0x4003E3E")]
		public const int VERSION_53 = 53;

		[global::Cpp2ILInjected.Token(Token = "0x4003E3F")]
		public const int VERSION_54 = 54;

		[global::Cpp2ILInjected.Token(Token = "0x4003E40")]
		public const int VERSION_55 = 55;

		[global::Cpp2ILInjected.Token(Token = "0x4003E41")]
		public const int VERSION_56 = 56;

		[global::Cpp2ILInjected.Token(Token = "0x4003E42")]
		public const int VERSION_57 = 57;

		[global::Cpp2ILInjected.Token(Token = "0x4003E43")]
		public const int VERSION_58 = 58;

		[global::Cpp2ILInjected.Token(Token = "0x4003E44")]
		public const int VERSION_59 = 59;

		[global::Cpp2ILInjected.Token(Token = "0x4003E45")]
		public const int VERSION_60 = 60;

		[global::Cpp2ILInjected.Token(Token = "0x4003E46")]
		public const int VERSION_61 = 61;

		[global::Cpp2ILInjected.Token(Token = "0x4003E47")]
		public const int VERSION_62 = 62;

		[global::Cpp2ILInjected.Token(Token = "0x4003E48")]
		public const int VERSION_63 = 63;

		[global::Cpp2ILInjected.Token(Token = "0x4003E49")]
		public const int VERSION_64 = 64;

		[global::Cpp2ILInjected.Token(Token = "0x4003E4A")]
		public const int VERSION_65 = 65;

		[global::Cpp2ILInjected.Token(Token = "0x4003E4B")]
		public const int VERSION_66 = 66;

		[global::Cpp2ILInjected.Token(Token = "0x4003E4C")]
		public const int VERSION_67 = 67;

		[global::Cpp2ILInjected.Token(Token = "0x4003E4D")]
		public const int VERSION_68 = 68;

		[global::Cpp2ILInjected.Token(Token = "0x4003E4E")]
		public const int VERSION_69 = 69;

		[global::Cpp2ILInjected.Token(Token = "0x4003E4F")]
		public const int VERSION_70 = 70;

		[global::Cpp2ILInjected.Token(Token = "0x4003E50")]
		public const int VERSION_71 = 71;

		[global::Cpp2ILInjected.Token(Token = "0x4003E51")]
		public const int VERSION_72 = 72;

		[global::Cpp2ILInjected.Token(Token = "0x4003E52")]
		public const int VERSION_73 = 73;

		[global::Cpp2ILInjected.Token(Token = "0x4003E53")]
		public const int VERSION_CURRENT = 73;

		[global::Cpp2ILInjected.Token(Token = "0x4003E54")]
		public const int NEW_WORLD_DATA_VERSION = 73;

		[global::Cpp2ILInjected.Token(Token = "0x4003E55")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private bool isCloudSave;

		[global::Cpp2ILInjected.Token(Token = "0x4003E56")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private int worldID;

		[global::Cpp2ILInjected.Token(Token = "0x4003E57")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int worldTimestamp;

		[global::Cpp2ILInjected.Token(Token = "0x4003E58")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private int hellLayer;

		[global::Cpp2ILInjected.Token(Token = "0x4003E59")]
		private static Weather_OldMobile weather;

		[global::Cpp2ILInjected.Token(Token = "0x4003E5A")]
		private static NPCInfo_OldMobile npcInfo;

		[global::Cpp2ILInjected.Token(Token = "0x4003E5B")]
		private static TimeInfo_OldMobile tempTime;

		[global::Cpp2ILInjected.Token(Token = "0x4003E5C")]
		private static FishingInfo_OldMobile fishingInfo;

		[global::Cpp2ILInjected.Token(Token = "0x4003E5D")]
		private static RandomStyleInfo_OldMobile tree;

		[global::Cpp2ILInjected.Token(Token = "0x4003E5E")]
		private static RandomStyleInfo_OldMobile caveBack;

		[global::Cpp2ILInjected.Token(Token = "0x4003E5F")]
		private static TilInfo_OldMobile tileInfo;

		[global::Cpp2ILInjected.Token(Token = "0x4003E60")]
		private static ChestInfo_OldMobile chestInfo;

		[global::Cpp2ILInjected.Token(Token = "0x4003E61")]
		private static SignInfo_OldMobile signInfo;

		[global::Cpp2ILInjected.Token(Token = "0x4003E62")]
		private static BlowFish worldDecrypter;

		[global::Cpp2ILInjected.Token(Token = "0x4003E63")]
		private static byte[] inputData;

		[global::Cpp2ILInjected.Token(Token = "0x4003E64")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int saveRelease;

		[global::Cpp2ILInjected.Token(Token = "0x4003E65")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private uint timestamp;

		[global::Cpp2ILInjected.Token(Token = "0x4003E66")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private List<uint> timestamps;
	}
}
