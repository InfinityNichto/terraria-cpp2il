using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.Utilities;

namespace Terraria.IO
{
	// Token: 0x020003BE RID: 958
	[global::Cpp2ILInjected.Token(Token = "0x2000562")]
	public class PlayerFileData : FileData
	{
		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x06002F15 RID: 12053 RVA: 0x0002A689 File Offset: 0x00028889
		// (set) Token: 0x06002F16 RID: 12054 RVA: 0x0002A68C File Offset: 0x0002888C
		[global::Cpp2ILInjected.Token(Token = "0x1700066F")]
		public Player Player
		{
			[global::Cpp2ILInjected.Token(Token = "0x600337A")]
			[global::Cpp2ILInjected.Address(RVA = "0x133C048", Offset = "0x133C048", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600337B")]
			[global::Cpp2ILInjected.Address(RVA = "0x133C050", Offset = "0x133C050", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationState), Member = "ReadPlayerFileData", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player_OldConsole), Member = "LoadPlayer", MemberParameters = new object[]
			{
				typeof(string),
				typeof(PlayerFileData)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player_OldSwitch), Member = "LoadPlayer", MemberParameters = new object[]
			{
				typeof(string),
				typeof(PlayerFileData)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "LoadTutorialPlayer", ReturnType = typeof(PlayerFileData))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "LoadPlayer", MemberParameters = new object[]
			{
				typeof(string),
				typeof(bool)
			}, ReturnType = typeof(PlayerFileData))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06002F17 RID: 12055 RVA: 0x0002A68F File Offset: 0x0002888F
		[global::Cpp2ILInjected.Token(Token = "0x600337C")]
		[global::Cpp2ILInjected.Address(RVA = "0x133C064", Offset = "0x133C064", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerSelectMenu), Member = "SortPlayers", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitsByte), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_IsAir", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Projectile), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Projectile), Member = "SetDefaults", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void PreparePetProjectiles()
		{
			throw null;
		}

		// Token: 0x06002F18 RID: 12056 RVA: 0x0002A692 File Offset: 0x00028892
		[global::Cpp2ILInjected.Token(Token = "0x600337D")]
		[global::Cpp2ILInjected.Address(RVA = "0x133C114", Offset = "0x133C114", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LocalUserGameState), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationState), Member = "ReadPlayerFileData", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "KillMeForGood", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "LoadTutorialPlayer", ReturnType = typeof(PlayerFileData))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerFileData), Member = "CreateAndSave", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(PlayerFileData))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stopwatch), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public PlayerFileData()
		{
			throw null;
		}

		// Token: 0x06002F19 RID: 12057 RVA: 0x0002A695 File Offset: 0x00028895
		[global::Cpp2ILInjected.Token(Token = "0x600337E")]
		[global::Cpp2ILInjected.Address(RVA = "0x133C1D0", Offset = "0x133C1D0", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "LoadPlayer", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(PlayerFileData))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stopwatch), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileData), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public PlayerFileData(string path, bool cloudSave)
		{
			throw null;
		}

		// Token: 0x06002F1A RID: 12058 RVA: 0x0002A698 File Offset: 0x00028898
		[global::Cpp2ILInjected.Token(Token = "0x600337F")]
		[global::Cpp2ILInjected.Address(RVA = "0x133C298", Offset = "0x133C298", Length = "0x17C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerCreateMenu), Member = "CreateAndSave", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "OnCharacterNamed", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerFileData), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileMetadata), Member = "FromCurrentSettings", MemberParameters = new object[] { typeof(FileType) }, ReturnType = typeof(FileMetadata))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "GetPlayerPathFromName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalFavoriteData", ReturnType = typeof(FavoritesFile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FavoritesFile), Member = "ClearEntry", MemberParameters = new object[] { typeof(FileData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_ActivePlayerFileData", MemberParameters = new object[] { typeof(PlayerFileData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "SavePlayer", MemberParameters = new object[]
		{
			typeof(PlayerFileData),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static PlayerFileData CreateAndSave(Player player)
		{
			throw null;
		}

		// Token: 0x06002F1B RID: 12059 RVA: 0x0002A69B File Offset: 0x0002889B
		[global::Cpp2ILInjected.Token(Token = "0x6003380")]
		[global::Cpp2ILInjected.Address(RVA = "0x133C414", Offset = "0x133C414", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_ActivePlayerFileData", MemberParameters = new object[] { typeof(PlayerFileData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override void SetAsActive()
		{
			throw null;
		}

		// Token: 0x06002F1C RID: 12060 RVA: 0x0002A69E File Offset: 0x0002889E
		[global::Cpp2ILInjected.Token(Token = "0x6003381")]
		[global::Cpp2ILInjected.Address(RVA = "0x133C524", Offset = "0x133C524", Length = "0x37C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "GetPlayerPathFromName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileUtilities), Member = "MoveToCloud", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileData), Member = "GetFileName", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_PlayerPath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Directory), Member = "Exists", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Directory), Member = "GetFiles", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileUtilities), Member = "GetFileName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalFavoriteData", ReturnType = typeof(FavoritesFile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FavoritesFile), Member = "ClearEntry", MemberParameters = new object[] { typeof(FileData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FavoritesFile), Member = "SaveFavorite", MemberParameters = new object[] { typeof(FileData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		public override void MoveToCloud()
		{
			throw null;
		}

		// Token: 0x06002F1D RID: 12061 RVA: 0x0002A6A1 File Offset: 0x000288A1
		[global::Cpp2ILInjected.Token(Token = "0x6003382")]
		[global::Cpp2ILInjected.Address(RVA = "0x133C8A0", Offset = "0x133C8A0", Length = "0x59C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "GetPlayerPathFromName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileUtilities), Member = "MoveToLocal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerFileData.<>c__DisplayClass14_0), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileData), Member = "GetFileName", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, bool>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Where", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
		{
			typeof(IEnumerable<object>),
			typeof(Func<object, bool>)
		}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_PlayerPath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileUtilities), Member = "GetFileName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FavoritesFile), Member = "ClearEntry", MemberParameters = new object[] { typeof(FileData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalFavoriteData", ReturnType = typeof(FavoritesFile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FavoritesFile), Member = "SaveFavorite", MemberParameters = new object[] { typeof(FileData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 33)]
		public override void MoveToLocal()
		{
			throw null;
		}

		// Token: 0x06002F1E RID: 12062 RVA: 0x0002A6A4 File Offset: 0x000288A4
		[global::Cpp2ILInjected.Token(Token = "0x6003383")]
		[global::Cpp2ILInjected.Address(RVA = "0x133CE3C", Offset = "0x133CE3C", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Replace", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private bool MapBelongsToPath(string mapPath, string filePath)
		{
			throw null;
		}

		// Token: 0x06002F1F RID: 12063 RVA: 0x0002A6A7 File Offset: 0x000288A7
		[global::Cpp2ILInjected.Token(Token = "0x6003384")]
		[global::Cpp2ILInjected.Address(RVA = "0x133CED8", Offset = "0x133CED8", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoUpdate", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gameMenu", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerFileData), Member = "StopPlayTimer", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stopwatch), Member = "Start", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void UpdatePlayTimer()
		{
			throw null;
		}

		// Token: 0x06002F20 RID: 12064 RVA: 0x0002A6AA File Offset: 0x000288AA
		[global::Cpp2ILInjected.Token(Token = "0x6003385")]
		[global::Cpp2ILInjected.Address(RVA = "0x133D014", Offset = "0x133D014", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "OnApplicationPause", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void OnLostFocus()
		{
			throw null;
		}

		// Token: 0x06002F21 RID: 12065 RVA: 0x0002A6AD File Offset: 0x000288AD
		[global::Cpp2ILInjected.Token(Token = "0x6003386")]
		[global::Cpp2ILInjected.Address(RVA = "0x133CFE4", Offset = "0x133CFE4", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DedServ", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Spawn", MemberParameters = new object[] { typeof(PlayerSpawnContext) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stopwatch), Member = "Start", ReturnType = typeof(void))]
		public void StartPlayTimer()
		{
			throw null;
		}

		// Token: 0x06002F22 RID: 12066 RVA: 0x0002A6B0 File Offset: 0x000288B0
		[global::Cpp2ILInjected.Token(Token = "0x6003387")]
		[global::Cpp2ILInjected.Address(RVA = "0x133D010", Offset = "0x133D010", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerFileData), Member = "StopPlayTimer", ReturnType = typeof(void))]
		public void PausePlayTimer()
		{
			throw null;
		}

		// Token: 0x06002F23 RID: 12067 RVA: 0x0002A6B3 File Offset: 0x000288B3
		[global::Cpp2ILInjected.Token(Token = "0x6003388")]
		[global::Cpp2ILInjected.Address(RVA = "0x133D0C0", Offset = "0x133D0C0", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerSelectMenu), Member = "PlayerDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISaveSynchronisation_FileList), Member = "PlayerDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationOperation_SendFileList), Member = "SendPlayerFile", MemberParameters = new object[] { typeof(PlayerFileData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "InternalSavePlayerFile", MemberParameters = new object[] { typeof(PlayerFileData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stopwatch), Member = "get_Elapsed", ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(TimeSpan),
			typeof(TimeSpan)
		}, ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public TimeSpan GetPlayTime()
		{
			throw null;
		}

		// Token: 0x06002F24 RID: 12068 RVA: 0x0002A6B6 File Offset: 0x000288B6
		[global::Cpp2ILInjected.Token(Token = "0x6003389")]
		[global::Cpp2ILInjected.Address(RVA = "0x133D148", Offset = "0x133D148", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stopwatch), Member = "get_Elapsed", ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(TimeSpan),
			typeof(TimeSpan)
		}, ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stopwatch), Member = "Reset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stopwatch), Member = "Start", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void UpdatePlayTimerAndKeepState()
		{
			throw null;
		}

		// Token: 0x06002F25 RID: 12069 RVA: 0x0002A6B9 File Offset: 0x000288B9
		[global::Cpp2ILInjected.Token(Token = "0x600338A")]
		[global::Cpp2ILInjected.Address(RVA = "0x133D018", Offset = "0x133D018", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "JustQuit", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "SaveAndQuitCallBack", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerFileData), Member = "UpdatePlayTimer", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerFileData), Member = "PausePlayTimer", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stopwatch), Member = "get_Elapsed", ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(TimeSpan),
			typeof(TimeSpan)
		}, ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stopwatch), Member = "Reset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void StopPlayTimer()
		{
			throw null;
		}

		// Token: 0x06002F26 RID: 12070 RVA: 0x0002A6BC File Offset: 0x000288BC
		[global::Cpp2ILInjected.Token(Token = "0x600338B")]
		[global::Cpp2ILInjected.Address(RVA = "0x133D1F8", Offset = "0x133D1F8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SetPlayTime(TimeSpan time)
		{
			throw null;
		}

		// Token: 0x06002F27 RID: 12071 RVA: 0x0002A6BF File Offset: 0x000288BF
		[global::Cpp2ILInjected.Token(Token = "0x600338C")]
		[global::Cpp2ILInjected.Address(RVA = "0x133D200", Offset = "0x133D200", Length = "0x1084")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "SavePlayer", MemberParameters = new object[]
		{
			typeof(PlayerFileData),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void Rename(string newName)
		{
			throw null;
		}

		// Token: 0x04003291 RID: 12945
		[global::Cpp2ILInjected.Token(Token = "0x4003C46")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private Player _player;

		// Token: 0x04003292 RID: 12946
		[global::Cpp2ILInjected.Token(Token = "0x4003C47")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private TimeSpan _playTime;

		// Token: 0x04003293 RID: 12947
		[global::Cpp2ILInjected.Token(Token = "0x4003C48")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private readonly Stopwatch _timer;

		// Token: 0x04003294 RID: 12948
		[global::Cpp2ILInjected.Token(Token = "0x4003C49")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private bool _isTimerActive;

		// Token: 0x04003295 RID: 12949
		[global::Cpp2ILInjected.Token(Token = "0x4003C4A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		public Projectile UIPetProjectile;

		// Token: 0x020008F4 RID: 2292
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000563")]
		private sealed class <>c__DisplayClass14_0
		{
			// Token: 0x06004C10 RID: 19472 RVA: 0x0002F765 File Offset: 0x0002D965
			[global::Cpp2ILInjected.Token(Token = "0x600338D")]
			[global::Cpp2ILInjected.Address(RVA = "0x133E284", Offset = "0x133E284", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerFileData), Member = "MoveToLocal", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass14_0()
			{
				throw null;
			}

			// Token: 0x06004C11 RID: 19473 RVA: 0x0002F768 File Offset: 0x0002D968
			[global::Cpp2ILInjected.Token(Token = "0x600338E")]
			[global::Cpp2ILInjected.Address(RVA = "0x133E28C", Offset = "0x133E28C", Length = "0x7C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new object[]
			{
				typeof(string),
				typeof(StringComparison)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new object[]
			{
				typeof(string),
				typeof(StringComparison)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal bool <MoveToLocal>b__0(string path)
			{
				throw null;
			}

			// Token: 0x04008158 RID: 33112
			[global::Cpp2ILInjected.Token(Token = "0x4003C4B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public string mapPath;
		}
	}
}
