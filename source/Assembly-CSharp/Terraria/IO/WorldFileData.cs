using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using ReLogic.Utilities;
using Terraria.Localization;
using Terraria.Map;
using Terraria.Utilities;

namespace Terraria.IO
{
	// Token: 0x020003D1 RID: 977
	[global::Cpp2ILInjected.Token(Token = "0x2000580")]
	public class WorldFileData : FileData
	{
		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x06002FE5 RID: 12261 RVA: 0x0002A8F9 File Offset: 0x00028AF9
		[global::Cpp2ILInjected.Token(Token = "0x1700067A")]
		public string SeedText
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003451")]
			[global::Cpp2ILInjected.Address(RVA = "0x135F660", Offset = "0x135F660", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x06002FE6 RID: 12262 RVA: 0x0002A8FC File Offset: 0x00028AFC
		[global::Cpp2ILInjected.Token(Token = "0x1700067B")]
		public int Seed
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003452")]
			[global::Cpp2ILInjected.Address(RVA = "0x135F668", Offset = "0x135F668", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x06002FE7 RID: 12263 RVA: 0x0002A8FF File Offset: 0x00028AFF
		[global::Cpp2ILInjected.Token(Token = "0x1700067C")]
		public string WorldSizeName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003453")]
			[global::Cpp2ILInjected.Address(RVA = "0x135F670", Offset = "0x135F670", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerHost), Member = "WorldDraw", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldSelectMenu), Member = "WorldDraw", MemberParameters = new object[]
			{
				typeof(ItemGrid_Layout),
				typeof(int),
				typeof(Vector2),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISaveSynchronisation_FileList), Member = "WorldDraw", MemberParameters = new object[]
			{
				typeof(ItemGrid_Layout),
				typeof(int),
				typeof(Vector2),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x06002FE8 RID: 12264 RVA: 0x0002A902 File Offset: 0x00028B02
		// (set) Token: 0x06002FE9 RID: 12265 RVA: 0x0002A905 File Offset: 0x00028B05
		[global::Cpp2ILInjected.Token(Token = "0x1700067D")]
		public bool HasCrimson
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003454")]
			[global::Cpp2ILInjected.Address(RVA = "0x135F67C", Offset = "0x135F67C", Length = "0x10")]
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
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Netplay), Member = "BroadcastThread", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Netplay), Member = "StartBroadCasting", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003455")]
			[global::Cpp2ILInjected.Address(RVA = "0x135F68C", Offset = "0x135F68C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldConsole), Member = "GetAllMetadata", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(WorldFileData))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldSwitch), Member = "GetAllMetadata", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(WorldFileData))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldMobile), Member = "loadWorldDataMeta", MemberParameters = new object[]
			{
				typeof(WorldFileData),
				typeof(BinaryReader),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "GetTutorialMetadata", ReturnType = typeof(WorldFileData))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "GetAllMetadata", MemberParameters = new object[]
			{
				typeof(string),
				typeof(bool)
			}, ReturnType = typeof(WorldFileData))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x06002FEA RID: 12266 RVA: 0x0002A908 File Offset: 0x00028B08
		[global::Cpp2ILInjected.Token(Token = "0x1700067E")]
		public bool HasValidSeed
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003456")]
			[global::Cpp2ILInjected.Address(RVA = "0x135F69C", Offset = "0x135F69C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldSelectMenu), Member = "Draw", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldSelectMenu), Member = "WorldDraw", MemberParameters = new object[]
			{
				typeof(ItemGrid_Layout),
				typeof(int),
				typeof(Vector2),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "startDedInputCallBack", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x06002FEB RID: 12267 RVA: 0x0002A90B File Offset: 0x00028B0B
		[global::Cpp2ILInjected.Token(Token = "0x1700067F")]
		public bool UseGuidAsMapName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003457")]
			[global::Cpp2ILInjected.Address(RVA = "0x135F6AC", Offset = "0x135F6AC", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MapHelper), Member = "InternalSaveMapCompressed", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MapHelper), Member = "InternalSaveMap", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldMap), Member = "Load", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002FEC RID: 12268 RVA: 0x0002A90E File Offset: 0x00028B0E
		[global::Cpp2ILInjected.Token(Token = "0x6003458")]
		[global::Cpp2ILInjected.Address(RVA = "0x135F6C0", Offset = "0x135F6C0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public string GetWorldName(bool allowCropping = false)
		{
			throw null;
		}

		// Token: 0x06002FED RID: 12269 RVA: 0x0002A911 File Offset: 0x00028B11
		[global::Cpp2ILInjected.Token(Token = "0x6003459")]
		[global::Cpp2ILInjected.Address(RVA = "0x135F6C8", Offset = "0x135F6C8", Length = "0x1D8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldSelectMenu), Member = "WorldDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "startDedInputCallBack", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public string GetFullSeedText(bool allowCropping = false)
		{
			throw null;
		}

		// Token: 0x06002FEE RID: 12270 RVA: 0x0002A914 File Offset: 0x00028B14
		[global::Cpp2ILInjected.Token(Token = "0x600345A")]
		[global::Cpp2ILInjected.Address(RVA = "0x135F8A0", Offset = "0x135F8A0", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldSelectMenu), Member = "SelectAndHighlight", MemberParameters = new object[] { typeof(WorldFileData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationState), Member = "ReadWorldFileData", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "GetTutorialMetadata", ReturnType = typeof(WorldFileData))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileData), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public WorldFileData()
		{
			throw null;
		}

		// Token: 0x06002FEF RID: 12271 RVA: 0x0002A917 File Offset: 0x00028B17
		[global::Cpp2ILInjected.Token(Token = "0x600345B")]
		[global::Cpp2ILInjected.Address(RVA = "0x135F91C", Offset = "0x135F91C", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldConsole), Member = "GetAllMetadata", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(WorldFileData))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldSwitch), Member = "GetAllMetadata", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(WorldFileData))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldMobile), Member = "GetAllMetadata", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(WorldFileData))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "GetAllMetadata", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(WorldFileData))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "CreateMetadata", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(WorldFileData))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFileData), Member = "FromInvalidWorld", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(WorldFileData))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileData), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(LocalizedText))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public WorldFileData(string path, bool cloudSave)
		{
			throw null;
		}

		// Token: 0x06002FF0 RID: 12272 RVA: 0x0002A91A File Offset: 0x00028B1A
		[global::Cpp2ILInjected.Token(Token = "0x600345C")]
		[global::Cpp2ILInjected.Address(RVA = "0x135F9D8", Offset = "0x135F9D8", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void SetAsActive()
		{
			throw null;
		}

		// Token: 0x06002FF1 RID: 12273 RVA: 0x0002A91D File Offset: 0x00028B1D
		[global::Cpp2ILInjected.Token(Token = "0x600345D")]
		[global::Cpp2ILInjected.Address(RVA = "0x135FA34", Offset = "0x135FA34", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerHost), Member = "WorldDraw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationState), Member = "ReadWorldFileData", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldConsole), Member = "GetAllMetadata", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(WorldFileData))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldSwitch), Member = "GetAllMetadata", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(WorldFileData))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldMobile), Member = "loadWorldDataMeta", MemberParameters = new object[]
		{
			typeof(WorldFileData),
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "GetTutorialMetadata", ReturnType = typeof(WorldFileData))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "GetAllMetadata", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(WorldFileData))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFileData), Member = "FromInvalidWorld", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(WorldFileData))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(LocalizedText))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void SetWorldSize(int x, int y)
		{
			throw null;
		}

		// Token: 0x06002FF2 RID: 12274 RVA: 0x0002A920 File Offset: 0x00028B20
		[global::Cpp2ILInjected.Token(Token = "0x600345E")]
		[global::Cpp2ILInjected.Address(RVA = "0x135FB30", Offset = "0x135FB30", Length = "0x14C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "LoadWorlds", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "RunDedServ", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "GetAllMetadata", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(WorldFileData))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldFileData), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldFileData), Member = "SetSeedToEmpty", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileMetadata), Member = "FromCurrentSettings", MemberParameters = new object[] { typeof(FileType) }, ReturnType = typeof(FileMetadata))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldFileData), Member = "SetWorldSize", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileUtilities), Member = "GetFileName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "GetCreationTime", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static WorldFileData FromInvalidWorld(string path, bool cloudSave)
		{
			throw null;
		}

		// Token: 0x06002FF3 RID: 12275 RVA: 0x0002A923 File Offset: 0x00028B23
		[global::Cpp2ILInjected.Token(Token = "0x600345F")]
		[global::Cpp2ILInjected.Address(RVA = "0x135FC7C", Offset = "0x135FC7C", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "GetTutorialMetadata", ReturnType = typeof(WorldFileData))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "GetAllMetadata", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(WorldFileData))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFileData), Member = "FromInvalidWorld", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(WorldFileData))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void SetSeedToEmpty()
		{
			throw null;
		}

		// Token: 0x06002FF4 RID: 12276 RVA: 0x0002A926 File Offset: 0x00028B26
		[global::Cpp2ILInjected.Token(Token = "0x6003460")]
		[global::Cpp2ILInjected.Address(RVA = "0x135FCC4", Offset = "0x135FCC4", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldCreateMenu), Member = "CreateWorld", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "OnSeedSelected", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "GetTutorialMetadata", ReturnType = typeof(WorldFileData))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "GetAllMetadata", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(WorldFileData))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "CreateMetadata", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(WorldFileData))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "LoadWorld", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "LoadHeader", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFileData), Member = "SetSeedToRandom", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Crc32), Member = "Calculate", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public void SetSeed(string seedText)
		{
			throw null;
		}

		// Token: 0x06002FF5 RID: 12277 RVA: 0x0002A929 File Offset: 0x00028B29
		[global::Cpp2ILInjected.Token(Token = "0x6003461")]
		[global::Cpp2ILInjected.Address(RVA = "0x135FDCC", Offset = "0x135FDCC", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldCreateMenu), Member = "CreateWorld", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "OnSeedSelected", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "CreateMetadata", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(WorldFileData))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "LoadWorld", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldFileData), Member = "SetSeed", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void SetSeedToRandom()
		{
			throw null;
		}

		// Token: 0x06002FF6 RID: 12278 RVA: 0x0002A92C File Offset: 0x00028B2C
		[global::Cpp2ILInjected.Token(Token = "0x6003462")]
		[global::Cpp2ILInjected.Address(RVA = "0x135FE50", Offset = "0x135FE50", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "GetWorldPathFromName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileUtilities), Member = "MoveToCloud", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalFavoriteData", ReturnType = typeof(FavoritesFile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FavoritesFile), Member = "ClearEntry", MemberParameters = new object[] { typeof(FileData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FavoritesFile), Member = "SaveFavorite", MemberParameters = new object[] { typeof(FileData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override void MoveToCloud()
		{
			throw null;
		}

		// Token: 0x06002FF7 RID: 12279 RVA: 0x0002A92F File Offset: 0x00028B2F
		[global::Cpp2ILInjected.Token(Token = "0x6003463")]
		[global::Cpp2ILInjected.Address(RVA = "0x135FF5C", Offset = "0x135FF5C", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "GetWorldPathFromName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileUtilities), Member = "MoveToLocal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FavoritesFile), Member = "ClearEntry", MemberParameters = new object[] { typeof(FileData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalFavoriteData", ReturnType = typeof(FavoritesFile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FavoritesFile), Member = "SaveFavorite", MemberParameters = new object[] { typeof(FileData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override void MoveToLocal()
		{
			throw null;
		}

		// Token: 0x0400338A RID: 13194
		[global::Cpp2ILInjected.Token(Token = "0x4004131")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		public int _glitchFrameCounter;

		// Token: 0x0400338B RID: 13195
		[global::Cpp2ILInjected.Token(Token = "0x4004132")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		public int _glitchFrame;

		// Token: 0x0400338C RID: 13196
		[global::Cpp2ILInjected.Token(Token = "0x4004133")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		public int _glitchVariation;

		// Token: 0x0400338D RID: 13197
		[global::Cpp2ILInjected.Token(Token = "0x4004134")]
		private const ulong GUID_IN_WORLD_FILE_VERSION = 777389080577UL;

		// Token: 0x0400338E RID: 13198
		[global::Cpp2ILInjected.Token(Token = "0x4004135")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		public bool CurrentSaveFormat;

		// Token: 0x0400338F RID: 13199
		[global::Cpp2ILInjected.Token(Token = "0x4004136")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		public DateTime CreationTime;

		// Token: 0x04003390 RID: 13200
		[global::Cpp2ILInjected.Token(Token = "0x4004137")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		public int WorldSizeX;

		// Token: 0x04003391 RID: 13201
		[global::Cpp2ILInjected.Token(Token = "0x4004138")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
		public int WorldSizeY;

		// Token: 0x04003392 RID: 13202
		[global::Cpp2ILInjected.Token(Token = "0x4004139")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		public ulong WorldGeneratorVersion;

		// Token: 0x04003393 RID: 13203
		[global::Cpp2ILInjected.Token(Token = "0x400413A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private string _seedText;

		// Token: 0x04003394 RID: 13204
		[global::Cpp2ILInjected.Token(Token = "0x400413B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private int _seed;

		// Token: 0x04003395 RID: 13205
		[global::Cpp2ILInjected.Token(Token = "0x400413C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x74")]
		public bool IsValid;

		// Token: 0x04003396 RID: 13206
		[global::Cpp2ILInjected.Token(Token = "0x400413D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		public Guid UniqueId;

		// Token: 0x04003397 RID: 13207
		[global::Cpp2ILInjected.Token(Token = "0x400413E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		public LocalizedText _worldSizeName;

		// Token: 0x04003398 RID: 13208
		[global::Cpp2ILInjected.Token(Token = "0x400413F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		public int GameMode;

		// Token: 0x04003399 RID: 13209
		[global::Cpp2ILInjected.Token(Token = "0x4004140")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x94")]
		public bool DrunkWorld;

		// Token: 0x0400339A RID: 13210
		[global::Cpp2ILInjected.Token(Token = "0x4004141")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x95")]
		public bool NotTheBees;

		// Token: 0x0400339B RID: 13211
		[global::Cpp2ILInjected.Token(Token = "0x4004142")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x96")]
		public bool ForTheWorthy;

		// Token: 0x0400339C RID: 13212
		[global::Cpp2ILInjected.Token(Token = "0x4004143")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x97")]
		public bool Anniversary;

		// Token: 0x0400339D RID: 13213
		[global::Cpp2ILInjected.Token(Token = "0x4004144")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		public bool DontStarve;

		// Token: 0x0400339E RID: 13214
		[global::Cpp2ILInjected.Token(Token = "0x4004145")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x99")]
		public bool RemixWorld;

		// Token: 0x0400339F RID: 13215
		[global::Cpp2ILInjected.Token(Token = "0x4004146")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x9A")]
		public bool NoTrapsWorld;

		// Token: 0x040033A0 RID: 13216
		[global::Cpp2ILInjected.Token(Token = "0x4004147")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x9B")]
		public bool ZenithWorld;

		// Token: 0x040033A1 RID: 13217
		[global::Cpp2ILInjected.Token(Token = "0x4004148")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x9C")]
		public bool HasCorruption;

		// Token: 0x040033A2 RID: 13218
		[global::Cpp2ILInjected.Token(Token = "0x4004149")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x9D")]
		public bool IsHardMode;

		// Token: 0x040033A3 RID: 13219
		[global::Cpp2ILInjected.Token(Token = "0x400414A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x9E")]
		public bool DefeatedMoonlord;
	}
}
