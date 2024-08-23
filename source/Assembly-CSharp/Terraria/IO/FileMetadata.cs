using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Map;

namespace Terraria.IO
{
	// Token: 0x020003BC RID: 956
	[global::Cpp2ILInjected.Token(Token = "0x2000560")]
	public class FileMetadata
	{
		// Token: 0x06002F0D RID: 12045 RVA: 0x0002A671 File Offset: 0x00028871
		[global::Cpp2ILInjected.Token(Token = "0x6003372")]
		[global::Cpp2ILInjected.Address(RVA = "0x133BAA8", Offset = "0x133BAA8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		private FileMetadata()
		{
			throw null;
		}

		// Token: 0x06002F0E RID: 12046 RVA: 0x0002A674 File Offset: 0x00028874
		[global::Cpp2ILInjected.Token(Token = "0x6003373")]
		[global::Cpp2ILInjected.Address(RVA = "0x133BAB0", Offset = "0x133BAB0", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationOperation_SendFileList), Member = "SendPlayerFile", MemberParameters = new object[] { typeof(PlayerFileData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationOperation_SendFileList), Member = "SendWorldFile", MemberParameters = new object[] { typeof(WorldFileData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "InternalSavePlayerFile", MemberParameters = new object[] { typeof(PlayerFileData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileMetadata), Member = "IncrementAndWrite", MemberParameters = new object[] { typeof(BinaryWriter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToInt", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void Write(BinaryWriter writer)
		{
			throw null;
		}

		// Token: 0x06002F0F RID: 12047 RVA: 0x0002A677 File Offset: 0x00028877
		[global::Cpp2ILInjected.Token(Token = "0x6003374")]
		[global::Cpp2ILInjected.Address(RVA = "0x133BB78", Offset = "0x133BB78", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "SaveFileFormatHeader", MemberParameters = new object[] { typeof(BinaryWriter) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MapHelper), Member = "InternalSaveMapCompressed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MapHelper), Member = "InternalSaveMap", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileMetadata), Member = "Write", MemberParameters = new object[] { typeof(BinaryWriter) }, ReturnType = typeof(void))]
		public void IncrementAndWrite(BinaryWriter writer)
		{
			throw null;
		}

		// Token: 0x06002F10 RID: 12048 RVA: 0x0002A67A File Offset: 0x0002887A
		[global::Cpp2ILInjected.Token(Token = "0x6003375")]
		[global::Cpp2ILInjected.Address(RVA = "0x133BB88", Offset = "0x133BB88", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 30)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static FileMetadata FromCurrentSettings(FileType type)
		{
			throw null;
		}

		// Token: 0x06002F11 RID: 12049 RVA: 0x0002A67D File Offset: 0x0002887D
		[global::Cpp2ILInjected.Token(Token = "0x6003376")]
		[global::Cpp2ILInjected.Address(RVA = "0x133BBEC", Offset = "0x133BBEC", Length = "0x23C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationState), Member = "ReadPlayerFileData", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationState), Member = "ReadWorldFileData", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player_OldConsole), Member = "LoadPlayer", MemberParameters = new object[]
		{
			typeof(string),
			typeof(PlayerFileData)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldConsole), Member = "GetAllMetadata", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(WorldFileData))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldConsole), Member = "LoadFileFormatHeader", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(ref bool[]),
			typeof(ref int[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player_OldSwitch), Member = "LoadPlayer", MemberParameters = new object[]
		{
			typeof(string),
			typeof(PlayerFileData)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldSwitch), Member = "GetAllMetadata", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(WorldFileData))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldSwitch), Member = "LoadFileFormatHeader", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(ref bool[]),
			typeof(ref int[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "LoadTutorialPlayer", ReturnType = typeof(PlayerFileData))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "LoadPlayer", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(PlayerFileData))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "GetTutorialMetadata", ReturnType = typeof(WorldFileData))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "GetAllMetadata", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(WorldFileData))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "LoadFileFormatHeader", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(ref bool[]),
			typeof(ref int[]),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "GetFileMetadata", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(FileMetadata))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MapHelper), Member = "LoadMapHeader", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MapHelper), Member = "LoadMapVersion2", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MapHelper), Member = "LoadMapVersionCompressed", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 17)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileMetadata), Member = "Read", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "GetName", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileFormatException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
		public static FileMetadata Read(BinaryReader reader, FileType expectedType)
		{
			throw null;
		}

		// Token: 0x06002F12 RID: 12050 RVA: 0x0002A680 File Offset: 0x00028880
		[global::Cpp2ILInjected.Token(Token = "0x6003377")]
		[global::Cpp2ILInjected.Address(RVA = "0x133BE28", Offset = "0x133BE28", Length = "0x1F8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileMetadata), Member = "Read", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(FileType)
		}, ReturnType = typeof(FileMetadata))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "GetValues", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(Array))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileFormatException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private void Read(BinaryReader reader)
		{
			throw null;
		}

		// Token: 0x0400328B RID: 12939
		[global::Cpp2ILInjected.Token(Token = "0x4003C40")]
		public const ulong MAGIC_NUMBER = 27981915666277746UL;

		// Token: 0x0400328C RID: 12940
		[global::Cpp2ILInjected.Token(Token = "0x4003C41")]
		public const int SIZE = 20;

		// Token: 0x0400328D RID: 12941
		[global::Cpp2ILInjected.Token(Token = "0x4003C42")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public FileType Type;

		// Token: 0x0400328E RID: 12942
		[global::Cpp2ILInjected.Token(Token = "0x4003C43")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public uint Revision;

		// Token: 0x0400328F RID: 12943
		[global::Cpp2ILInjected.Token(Token = "0x4003C44")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public bool IsFavorite;
	}
}
