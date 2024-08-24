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
	// Token: 0x020003CD RID: 973
	[global::Cpp2ILInjected.Token(Token = "0x2000577")]
	public class WorldFile_OldMobile
	{
		// Token: 0x06002F88 RID: 12168 RVA: 0x0002A7E2 File Offset: 0x000289E2
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

		// Token: 0x06002F89 RID: 12169 RVA: 0x0002A7E5 File Offset: 0x000289E5
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

		// Token: 0x06002F8A RID: 12170 RVA: 0x0002A7E8 File Offset: 0x000289E8
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

		// Token: 0x06002F8B RID: 12171 RVA: 0x0002A7EB File Offset: 0x000289EB
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

		// Token: 0x06002F8C RID: 12172 RVA: 0x0002A7EE File Offset: 0x000289EE
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

		// Token: 0x06002F8D RID: 12173 RVA: 0x0002A7F1 File Offset: 0x000289F1
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

		// Token: 0x06002F8E RID: 12174 RVA: 0x0002A7F4 File Offset: 0x000289F4
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

		// Token: 0x06002F8F RID: 12175 RVA: 0x0002A7F7 File Offset: 0x000289F7
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

		// Token: 0x06002F90 RID: 12176 RVA: 0x0002A7FA File Offset: 0x000289FA
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

		// Token: 0x06002F91 RID: 12177 RVA: 0x0002A7FD File Offset: 0x000289FD
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

		// Token: 0x06002F92 RID: 12178 RVA: 0x0002A800 File Offset: 0x00028A00
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

		// Token: 0x040032DA RID: 13018
		[global::Cpp2ILInjected.Token(Token = "0x4003E3A")]
		public const int VERSION_49 = 49;

		// Token: 0x040032DB RID: 13019
		[global::Cpp2ILInjected.Token(Token = "0x4003E3B")]
		public const int VERSION_50 = 50;

		// Token: 0x040032DC RID: 13020
		[global::Cpp2ILInjected.Token(Token = "0x4003E3C")]
		public const int VERSION_51 = 51;

		// Token: 0x040032DD RID: 13021
		[global::Cpp2ILInjected.Token(Token = "0x4003E3D")]
		public const int VERSION_52 = 52;

		// Token: 0x040032DE RID: 13022
		[global::Cpp2ILInjected.Token(Token = "0x4003E3E")]
		public const int VERSION_53 = 53;

		// Token: 0x040032DF RID: 13023
		[global::Cpp2ILInjected.Token(Token = "0x4003E3F")]
		public const int VERSION_54 = 54;

		// Token: 0x040032E0 RID: 13024
		[global::Cpp2ILInjected.Token(Token = "0x4003E40")]
		public const int VERSION_55 = 55;

		// Token: 0x040032E1 RID: 13025
		[global::Cpp2ILInjected.Token(Token = "0x4003E41")]
		public const int VERSION_56 = 56;

		// Token: 0x040032E2 RID: 13026
		[global::Cpp2ILInjected.Token(Token = "0x4003E42")]
		public const int VERSION_57 = 57;

		// Token: 0x040032E3 RID: 13027
		[global::Cpp2ILInjected.Token(Token = "0x4003E43")]
		public const int VERSION_58 = 58;

		// Token: 0x040032E4 RID: 13028
		[global::Cpp2ILInjected.Token(Token = "0x4003E44")]
		public const int VERSION_59 = 59;

		// Token: 0x040032E5 RID: 13029
		[global::Cpp2ILInjected.Token(Token = "0x4003E45")]
		public const int VERSION_60 = 60;

		// Token: 0x040032E6 RID: 13030
		[global::Cpp2ILInjected.Token(Token = "0x4003E46")]
		public const int VERSION_61 = 61;

		// Token: 0x040032E7 RID: 13031
		[global::Cpp2ILInjected.Token(Token = "0x4003E47")]
		public const int VERSION_62 = 62;

		// Token: 0x040032E8 RID: 13032
		[global::Cpp2ILInjected.Token(Token = "0x4003E48")]
		public const int VERSION_63 = 63;

		// Token: 0x040032E9 RID: 13033
		[global::Cpp2ILInjected.Token(Token = "0x4003E49")]
		public const int VERSION_64 = 64;

		// Token: 0x040032EA RID: 13034
		[global::Cpp2ILInjected.Token(Token = "0x4003E4A")]
		public const int VERSION_65 = 65;

		// Token: 0x040032EB RID: 13035
		[global::Cpp2ILInjected.Token(Token = "0x4003E4B")]
		public const int VERSION_66 = 66;

		// Token: 0x040032EC RID: 13036
		[global::Cpp2ILInjected.Token(Token = "0x4003E4C")]
		public const int VERSION_67 = 67;

		// Token: 0x040032ED RID: 13037
		[global::Cpp2ILInjected.Token(Token = "0x4003E4D")]
		public const int VERSION_68 = 68;

		// Token: 0x040032EE RID: 13038
		[global::Cpp2ILInjected.Token(Token = "0x4003E4E")]
		public const int VERSION_69 = 69;

		// Token: 0x040032EF RID: 13039
		[global::Cpp2ILInjected.Token(Token = "0x4003E4F")]
		public const int VERSION_70 = 70;

		// Token: 0x040032F0 RID: 13040
		[global::Cpp2ILInjected.Token(Token = "0x4003E50")]
		public const int VERSION_71 = 71;

		// Token: 0x040032F1 RID: 13041
		[global::Cpp2ILInjected.Token(Token = "0x4003E51")]
		public const int VERSION_72 = 72;

		// Token: 0x040032F2 RID: 13042
		[global::Cpp2ILInjected.Token(Token = "0x4003E52")]
		public const int VERSION_73 = 73;

		// Token: 0x040032F3 RID: 13043
		[global::Cpp2ILInjected.Token(Token = "0x4003E53")]
		public const int VERSION_CURRENT = 73;

		// Token: 0x040032F4 RID: 13044
		[global::Cpp2ILInjected.Token(Token = "0x4003E54")]
		public const int NEW_WORLD_DATA_VERSION = 73;

		// Token: 0x040032F5 RID: 13045
		[global::Cpp2ILInjected.Token(Token = "0x4003E55")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private bool isCloudSave;

		// Token: 0x040032F6 RID: 13046
		[global::Cpp2ILInjected.Token(Token = "0x4003E56")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private int worldID;

		// Token: 0x040032F7 RID: 13047
		[global::Cpp2ILInjected.Token(Token = "0x4003E57")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int worldTimestamp;

		// Token: 0x040032F8 RID: 13048
		[global::Cpp2ILInjected.Token(Token = "0x4003E58")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private int hellLayer;

		// Token: 0x040032F9 RID: 13049
		[global::Cpp2ILInjected.Token(Token = "0x4003E59")]
		private static Weather_OldMobile weather;

		// Token: 0x040032FA RID: 13050
		[global::Cpp2ILInjected.Token(Token = "0x4003E5A")]
		private static NPCInfo_OldMobile npcInfo;

		// Token: 0x040032FB RID: 13051
		[global::Cpp2ILInjected.Token(Token = "0x4003E5B")]
		private static TimeInfo_OldMobile tempTime;

		// Token: 0x040032FC RID: 13052
		[global::Cpp2ILInjected.Token(Token = "0x4003E5C")]
		private static FishingInfo_OldMobile fishingInfo;

		// Token: 0x040032FD RID: 13053
		[global::Cpp2ILInjected.Token(Token = "0x4003E5D")]
		private static RandomStyleInfo_OldMobile tree;

		// Token: 0x040032FE RID: 13054
		[global::Cpp2ILInjected.Token(Token = "0x4003E5E")]
		private static RandomStyleInfo_OldMobile caveBack;

		// Token: 0x040032FF RID: 13055
		[global::Cpp2ILInjected.Token(Token = "0x4003E5F")]
		private static TilInfo_OldMobile tileInfo;

		// Token: 0x04003300 RID: 13056
		[global::Cpp2ILInjected.Token(Token = "0x4003E60")]
		private static ChestInfo_OldMobile chestInfo;

		// Token: 0x04003301 RID: 13057
		[global::Cpp2ILInjected.Token(Token = "0x4003E61")]
		private static SignInfo_OldMobile signInfo;

		// Token: 0x04003302 RID: 13058
		[global::Cpp2ILInjected.Token(Token = "0x4003E62")]
		private static BlowFish worldDecrypter;

		// Token: 0x04003303 RID: 13059
		[global::Cpp2ILInjected.Token(Token = "0x4003E63")]
		private static byte[] inputData;

		// Token: 0x04003304 RID: 13060
		[global::Cpp2ILInjected.Token(Token = "0x4003E64")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int saveRelease;

		// Token: 0x04003305 RID: 13061
		[global::Cpp2ILInjected.Token(Token = "0x4003E65")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private uint timestamp;

		// Token: 0x04003306 RID: 13062
		[global::Cpp2ILInjected.Token(Token = "0x4003E66")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private List<uint> timestamps;
	}
}
