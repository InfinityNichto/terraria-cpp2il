using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Audio;
using Terraria.Chat;
using Terraria.DataStructures;
using Terraria.GameContent.Achievements;
using Terraria.GameContent.UI;
using Terraria.GameContent.UI.States;
using Terraria.Graphics.Effects;
using Terraria.IO;
using Terraria.Localization;
using Terraria.Utilities;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Events
{
	// Token: 0x0200068F RID: 1679
	[global::Cpp2ILInjected.Token(Token = "0x2000A4F")]
	public class DD2Event
	{
		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x060041CA RID: 16842 RVA: 0x0002DC14 File Offset: 0x0002BE14
		[global::Cpp2ILInjected.Token(Token = "0x17000894")]
		public static bool ReadyToFindBartender
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004DB6")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C60CC", Offset = "0x8C60CC", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x060041CB RID: 16843 RVA: 0x0002DC17 File Offset: 0x0002BE17
		[global::Cpp2ILInjected.Token(Token = "0x17000895")]
		public static bool DownedInvasionAnyDifficulty
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004DB7")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C6124", Offset = "0x8C6124", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEmotesWindow), Member = "GetEmotesBosses", MemberParameters = new object[] { typeof(List<int>) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EmoteBubble), Member = "ProbeEvents", MemberParameters = new object[] { typeof(List<int>) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIEmotesMenu), Member = "GetEmotesBosses", ReturnType = typeof(List<int>))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x060041CC RID: 16844 RVA: 0x0002DC1A File Offset: 0x0002BE1A
		// (set) Token: 0x060041CD RID: 16845 RVA: 0x0002DC1D File Offset: 0x0002BE1D
		[global::Cpp2ILInjected.Token(Token = "0x17000896")]
		public static int TimeLeftBetweenWaves
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004DB8")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C61C4", Offset = "0x8C61C4", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6004DB9")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C621C", Offset = "0x8C621C", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x060041CE RID: 16846 RVA: 0x0002DC20 File Offset: 0x0002BE20
		[global::Cpp2ILInjected.Token(Token = "0x17000897")]
		public static bool EnemySpawningIsOnHold
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004DBA")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C6278", Offset = "0x8C6278", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Event), Member = "CheckProgress", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x060041CF RID: 16847 RVA: 0x0002DC23 File Offset: 0x0002BE23
		[global::Cpp2ILInjected.Token(Token = "0x17000898")]
		public static bool EnemiesShouldChasePlayers
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004DBB")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C62D8", Offset = "0x8C62D8", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_107_ImprovedWalkers", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060041D0 RID: 16848 RVA: 0x0002DC26 File Offset: 0x0002BE26
		[global::Cpp2ILInjected.Token(Token = "0x6004DBC")]
		[global::Cpp2ILInjected.Address(RVA = "0x8C6328", Offset = "0x8C6328", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "SaveWorldHeader", MemberParameters = new object[] { typeof(BinaryWriter) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void Save(BinaryWriter writer)
		{
			throw null;
		}

		// Token: 0x060041D1 RID: 16849 RVA: 0x0002DC29 File Offset: 0x0002BE29
		[global::Cpp2ILInjected.Token(Token = "0x6004DBD")]
		[global::Cpp2ILInjected.Address(RVA = "0x8C63C8", Offset = "0x8C63C8", Length = "0x14C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldConsole), Member = "LoadHeader", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldSwitch), Member = "LoadHeader", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "LoadHeader", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static void Load(BinaryReader reader, int gameVersionNumber)
		{
			throw null;
		}

		// Token: 0x060041D2 RID: 16850 RVA: 0x0002DC2C File Offset: 0x0002BE2C
		[global::Cpp2ILInjected.Token(Token = "0x6004DBE")]
		[global::Cpp2ILInjected.Address(RVA = "0x8C6514", Offset = "0x8C6514", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldConsole), Member = "LoadHeader", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldSwitch), Member = "LoadHeader", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "clearWorld", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void ResetProgressEntirely()
		{
			throw null;
		}

		// Token: 0x060041D3 RID: 16851 RVA: 0x0002DC2F File Offset: 0x0002BE2F
		[global::Cpp2ILInjected.Token(Token = "0x6004DBF")]
		[global::Cpp2ILInjected.Address(RVA = "0x8C6588", Offset = "0x8C6588", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "CheckInvasionProgressDisplay", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DD2Event), Member = "GetInvasionStatus", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "ReportInvasionProgress", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void ReportEventProgress()
		{
			throw null;
		}

		// Token: 0x060041D4 RID: 16852 RVA: 0x0002DC32 File Offset: 0x0002BE32
		[global::Cpp2ILInjected.Token(Token = "0x6004DC0")]
		[global::Cpp2ILInjected.Address(RVA = "0x8C677C", Offset = "0x8C677C", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "SyncAnInvasion", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DD2Event), Member = "GetInvasionStatus", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void SyncInvasionProgress(int toWho)
		{
			throw null;
		}

		// Token: 0x060041D5 RID: 16853 RVA: 0x0002DC35 File Offset: 0x0002BE35
		[global::Cpp2ILInjected.Token(Token = "0x6004DC1")]
		[global::Cpp2ILInjected.Address(RVA = "0x8C6858", Offset = "0x8C6858", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "SpawnNPC", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static void SpawnNPC(ref int newNPC)
		{
			throw null;
		}

		// Token: 0x060041D6 RID: 16854 RVA: 0x0002DC38 File Offset: 0x0002BE38
		[global::Cpp2ILInjected.Token(Token = "0x6004DC2")]
		[global::Cpp2ILInjected.Address(RVA = "0x8C685C", Offset = "0x8C685C", Length = "0x5C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsInvalidInstructions]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "UpdateTime", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LogicHost", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "AnyNPCs", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DD2Event), Member = "StopInvasion", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetClientOnly", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DD2Event), Member = "GetInvasionStatus", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DD2Event), Member = "LoseInvasionMessage", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectManager<>), Member = "Deactivate", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DD2Event), Member = "GetEnemiesForWave", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(short[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lang), Member = "GetInvasionWaveText", MemberParameters = new object[]
		{
			typeof(int),
			typeof(short[])
		}, ReturnType = typeof(NetworkText))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "BroadcastText", MemberParameters = new object[]
		{
			typeof(NetworkText),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DD2Event), Member = "SummonBetsy", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "ReportInvasionProgress", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetHost", ReturnType = typeof(bool))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 47)]
		public static void UpdateTime()
		{
			throw null;
		}

		// Token: 0x060041D7 RID: 16855 RVA: 0x0002DC3B File Offset: 0x0002BE3B
		[global::Cpp2ILInjected.Token(Token = "0x6004DC3")]
		[global::Cpp2ILInjected.Address(RVA = "0x8C7348", Offset = "0x8C7348", Length = "0x35C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Event), Member = "SummonCrystalDirect", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LogicHost", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DD2Event), Member = "FindProperDifficulty", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DD2Event), Member = "ClearAllTowersInGame", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkText), Member = "FromKey", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(NetworkText))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "BroadcastText", MemberParameters = new object[]
		{
			typeof(NetworkText),
			typeof(Color)
		}, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetClientOnly", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "ReportInvasionProgress", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetHost", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DD2Event), Member = "SetEnemySpawningOnHold", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DD2Event), Member = "WipeEntities", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		public static void StartInvasion(int difficultyOverride = -1)
		{
			throw null;
		}

		// Token: 0x060041D8 RID: 16856 RVA: 0x0002DC3E File Offset: 0x0002BE3E
		[global::Cpp2ILInjected.Token(Token = "0x6004DC4")]
		[global::Cpp2ILInjected.Address(RVA = "0x8C6E20", Offset = "0x8C6E20", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Event), Member = "UpdateTime", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DD2Event), Member = "WinInvasionInternal", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LogicHost", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DD2Event), Member = "WipeEntities", ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public static void StopInvasion(bool win = false)
		{
			throw null;
		}

		// Token: 0x060041D9 RID: 16857 RVA: 0x0002DC41 File Offset: 0x0002BE41
		[global::Cpp2ILInjected.Token(Token = "0x6004DC5")]
		[global::Cpp2ILInjected.Address(RVA = "0x8C7A60", Offset = "0x8C7A60", Length = "0x29C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Event), Member = "StopInvasion", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DD2Event), Member = "DropMedals", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementsHelper), Member = "NotifyProgressionEvent", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkText), Member = "FromKey", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(NetworkText))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "BroadcastText", MemberParameters = new object[]
		{
			typeof(NetworkText),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		private static void WinInvasionInternal()
		{
			throw null;
		}

		// Token: 0x060041DA RID: 16858 RVA: 0x0002DC44 File Offset: 0x0002BE44
		[global::Cpp2ILInjected.Token(Token = "0x6004DC6")]
		[global::Cpp2ILInjected.Address(RVA = "0x8C7218", Offset = "0x8C7218", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Event), Member = "UpdateTime", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkText), Member = "FromKey", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(NetworkText))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "BroadcastText", MemberParameters = new object[]
		{
			typeof(NetworkText),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public static void LoseInvasionMessage()
		{
			throw null;
		}

		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x060041DB RID: 16859 RVA: 0x0002DC47 File Offset: 0x0002BE47
		[global::Cpp2ILInjected.Token(Token = "0x17000899")]
		public static bool ReadyForTier2
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004DC7")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C7E00", Offset = "0x8C7E00", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Event), Member = "FindProperDifficulty", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x060041DC RID: 16860 RVA: 0x0002DC4A File Offset: 0x0002BE4A
		[global::Cpp2ILInjected.Token(Token = "0x1700089A")]
		public static bool ReadyForTier3
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004DC8")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C7E9C", Offset = "0x8C7E9C", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Event), Member = "FindProperDifficulty", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060041DD RID: 16861 RVA: 0x0002DC4D File Offset: 0x0002BE4D
		[global::Cpp2ILInjected.Token(Token = "0x6004DC9")]
		[global::Cpp2ILInjected.Address(RVA = "0x8C76A4", Offset = "0x8C76A4", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Event), Member = "StartInvasion", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DD2Event), Member = "get_ReadyForTier2", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DD2Event), Member = "get_ReadyForTier3", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static void FindProperDifficulty()
		{
			throw null;
		}

		// Token: 0x060041DE RID: 16862 RVA: 0x0002DC50 File Offset: 0x0002BE50
		[global::Cpp2ILInjected.Token(Token = "0x6004DCA")]
		[global::Cpp2ILInjected.Address(RVA = "0x8C7F38", Offset = "0x8C7F38", Length = "0x6DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "checkDead", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "HitEffect", MemberParameters = new object[]
		{
			typeof(int),
			typeof(double)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetClientOnly", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DD2Event), Member = "get_EnemySpawningIsOnHold", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DD2Event), Member = "GetInvasionStatus", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DD2Event), Member = "GetMonsterPointsWorth", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LogicHost", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "ReportInvasionProgress", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetHost", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkText), Member = "FromKey", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(NetworkText))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "BroadcastText", MemberParameters = new object[]
		{
			typeof(NetworkText),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DD2Event), Member = "SetEnemySpawningOnHold", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DD2Event), Member = "DropMedals", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 48)]
		public static void CheckProgress(int slainMonsterID)
		{
			throw null;
		}

		// Token: 0x060041DF RID: 16863 RVA: 0x0002DC53 File Offset: 0x0002BE53
		[global::Cpp2ILInjected.Token(Token = "0x6004DCB")]
		[global::Cpp2ILInjected.Address(RVA = "0x8C86C8", Offset = "0x8C86C8", Length = "0x198")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Event), Member = "Difficulty_1_GetRequiredWaveKills", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Event), Member = "Difficulty_2_GetRequiredWaveKills", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Event), Member = "Difficulty_3_GetRequiredWaveKills", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "FindFirstNPC", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static void StartVictoryScene()
		{
			throw null;
		}

		// Token: 0x060041E0 RID: 16864 RVA: 0x0002DC56 File Offset: 0x0002BE56
		[global::Cpp2ILInjected.Token(Token = "0x6004DCC")]
		[global::Cpp2ILInjected.Address(RVA = "0x8C8860", Offset = "0x8C8860", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DD2Event), Member = "SetEnemySpawningOnHold", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void ReportLoss()
		{
			throw null;
		}

		// Token: 0x060041E1 RID: 16865 RVA: 0x0002DC59 File Offset: 0x0002BE59
		[global::Cpp2ILInjected.Token(Token = "0x6004DCD")]
		[global::Cpp2ILInjected.Address(RVA = "0x8C6638", Offset = "0x8C6638", Length = "0x144")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Event), Member = "ReportEventProgress", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Event), Member = "SyncInvasionProgress", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Event), Member = "UpdateTime", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Event), Member = "CheckProgress", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Event), Member = "ShouldDropCrystals", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Event), Member = "Difficulty_1_SpawnMonsterFromGate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Event), Member = "Difficulty_2_SpawnMonsterFromGate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DD2Event), Member = "Difficulty_3_GetRequiredWaveKills", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DD2Event), Member = "Difficulty_2_GetRequiredWaveKills", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DD2Event), Member = "Difficulty_1_GetRequiredWaveKills", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private static void GetInvasionStatus(out int currentWave, out int requiredKillCount, out int currentKillCount, bool currentlyInCheckProgress = false)
		{
			throw null;
		}

		// Token: 0x060041E2 RID: 16866 RVA: 0x0002DC5C File Offset: 0x0002BE5C
		[global::Cpp2ILInjected.Token(Token = "0x6004DCE")]
		[global::Cpp2ILInjected.Address(RVA = "0x8C6FA4", Offset = "0x8C6FA4", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Event), Member = "UpdateTime", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DD2Event), Member = "Difficulty_3_GetEnemiesForWave", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(short[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DD2Event), Member = "Difficulty_2_GetEnemiesForWave", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(short[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DD2Event), Member = "Difficulty_1_GetEnemiesForWave", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(short[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static short[] GetEnemiesForWave(int wave)
		{
			throw null;
		}

		// Token: 0x060041E3 RID: 16867 RVA: 0x0002DC5F File Offset: 0x0002BE5F
		[global::Cpp2ILInjected.Token(Token = "0x6004DCF")]
		[global::Cpp2ILInjected.Address(RVA = "0x8C8614", Offset = "0x8C8614", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Event), Member = "CheckProgress", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DD2Event), Member = "Difficulty_3_GetMonsterPointsWorth", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DD2Event), Member = "Difficulty_2_GetMonsterPointsWorth", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DD2Event), Member = "Difficulty_1_GetMonsterPointsWorth", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static int GetMonsterPointsWorth(int slainMonsterID)
		{
			throw null;
		}

		// Token: 0x060041E4 RID: 16868 RVA: 0x0002DC62 File Offset: 0x0002BE62
		[global::Cpp2ILInjected.Token(Token = "0x6004DD0")]
		[global::Cpp2ILInjected.Address(RVA = "0x8C96C0", Offset = "0x8C96C0", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DD2Event), Member = "Difficulty_2_SpawnMonsterFromGate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DD2Event), Member = "Difficulty_1_SpawnMonsterFromGate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static void SpawnMonsterFromGate(Vector2 gateBottom)
		{
			throw null;
		}

		// Token: 0x060041E5 RID: 16869 RVA: 0x0002DC65 File Offset: 0x0002BE65
		[global::Cpp2ILInjected.Token(Token = "0x6004DD1")]
		[global::Cpp2ILInjected.Address(RVA = "0x8CC478", Offset = "0x8CC478", Length = "0x110")]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetClientOnly", ReturnType = typeof(bool))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static void SummonCrystal(int x, int y, int whoAsks)
		{
			throw null;
		}

		// Token: 0x060041E6 RID: 16870 RVA: 0x0002DC68 File Offset: 0x0002BE68
		[global::Cpp2ILInjected.Token(Token = "0x6004DD2")]
		[global::Cpp2ILInjected.Address(RVA = "0x8CC588", Offset = "0x8CC588", Length = "0x210")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "AnyNPCs", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Framing), Member = "GetTileSafely", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameX", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameY", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DD2Event), Member = "StartInvasion", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "GetNPCSource_TileInteraction", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IEntitySource))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "NewNPC", MemberParameters = new object[]
		{
			typeof(IEntitySource),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DD2Event), Member = "DropStarterCrystals", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static void SummonCrystalDirect(int x, int y, int whoAsks)
		{
			throw null;
		}

		// Token: 0x060041E7 RID: 16871 RVA: 0x0002DC6B File Offset: 0x0002BE6B
		[global::Cpp2ILInjected.Token(Token = "0x6004DD3")]
		[global::Cpp2ILInjected.Address(RVA = "0x8CC914", Offset = "0x8CC914", Length = "0xD0")]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToWorldCoordinates", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StrayMethods), Member = "CheckArenaScore", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(ref Point),
			typeof(ref Point),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool WouldFailSpawningHere(int x, int y)
		{
			throw null;
		}

		// Token: 0x060041E8 RID: 16872 RVA: 0x0002DC6E File Offset: 0x0002BE6E
		[global::Cpp2ILInjected.Token(Token = "0x6004DD4")]
		[global::Cpp2ILInjected.Address(RVA = "0x8CC9E4", Offset = "0x8CC9E4", Length = "0x1B4")]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(LocalizedText))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetHost", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkText), Member = "FromKey", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(NetworkText))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatHelper), Member = "SendChatMessageToClient", MemberParameters = new object[]
		{
			typeof(NetworkText),
			typeof(Color),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "NewText", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte),
			typeof(byte),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public static void FailureMessage(int client)
		{
			throw null;
		}

		// Token: 0x060041E9 RID: 16873 RVA: 0x0002DC71 File Offset: 0x0002BE71
		[global::Cpp2ILInjected.Token(Token = "0x6004DD5")]
		[global::Cpp2ILInjected.Address(RVA = "0x8C7978", Offset = "0x8C7978", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageBuffer), Member = "ProcessData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Event), Member = "StartInvasion", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Event), Member = "StopInvasion", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DD2Event), Member = "ClearAllTowersInGame", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DD2Event), Member = "ClearAllDD2HostilesInGame", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DD2Event), Member = "ClearAllDD2EnergyCrystalsInChests", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetHost", ReturnType = typeof(bool))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static void WipeEntities()
		{
			throw null;
		}

		// Token: 0x060041EA RID: 16874 RVA: 0x0002DC74 File Offset: 0x0002BE74
		[global::Cpp2ILInjected.Token(Token = "0x6004DD6")]
		[global::Cpp2ILInjected.Address(RVA = "0x8C7764", Offset = "0x8C7764", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Event), Member = "StartInvasion", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Event), Member = "WipeEntities", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Projectile), Member = "Kill", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static void ClearAllTowersInGame()
		{
			throw null;
		}

		// Token: 0x060041EB RID: 16875 RVA: 0x0002DC77 File Offset: 0x0002BE77
		[global::Cpp2ILInjected.Token(Token = "0x6004DD7")]
		[global::Cpp2ILInjected.Address(RVA = "0x8CCB98", Offset = "0x8CCB98", Length = "0x16C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Event), Member = "WipeEntities", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetHost", ReturnType = typeof(bool))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static void ClearAllDD2HostilesInGame()
		{
			throw null;
		}

		// Token: 0x060041EC RID: 16876 RVA: 0x0002DC7A File Offset: 0x0002BE7A
		[global::Cpp2ILInjected.Token(Token = "0x6004DD8")]
		[global::Cpp2ILInjected.Address(RVA = "0x8CCEC8", Offset = "0x8CCEC8", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetHost", ReturnType = typeof(bool))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static void ClearAllDD2EnergyCrystalsInGame()
		{
			throw null;
		}

		// Token: 0x060041ED RID: 16877 RVA: 0x0002DC7D File Offset: 0x0002BE7D
		[global::Cpp2ILInjected.Token(Token = "0x6004DD9")]
		[global::Cpp2ILInjected.Address(RVA = "0x8CCD04", Offset = "0x8CCD04", Length = "0x1C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Event), Member = "WipeEntities", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetClientOnly", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Chest), Member = "GetCurrentlyOpenChests", ReturnType = typeof(List<int>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Contains", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "TurnToAir", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static void ClearAllDD2EnergyCrystalsInChests()
		{
			throw null;
		}

		// Token: 0x060041EE RID: 16878 RVA: 0x0002DC80 File Offset: 0x0002BE80
		[global::Cpp2ILInjected.Token(Token = "0x6004DDA")]
		[global::Cpp2ILInjected.Address(RVA = "0x8CCFC4", Offset = "0x8CCFC4", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "DoDeathEvents", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Bottom", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void AnnounceGoblinDeath(NPC n)
		{
			throw null;
		}

		// Token: 0x060041EF RID: 16879 RVA: 0x0002DC83 File Offset: 0x0002BE83
		[global::Cpp2ILInjected.Token(Token = "0x6004DDB")]
		[global::Cpp2ILInjected.Address(RVA = "0x8CD094", Offset = "0x8CD094", Length = "0x208")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_109_DarkMage", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Vector2>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Vector2>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "DistanceSquared", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Vector2>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public static bool CanRaiseGoblinsHere(Vector2 spot)
		{
			throw null;
		}

		// Token: 0x060041F0 RID: 16880 RVA: 0x0002DC86 File Offset: 0x0002BE86
		[global::Cpp2ILInjected.Token(Token = "0x6004DDC")]
		[global::Cpp2ILInjected.Address(RVA = "0x8CD29C", Offset = "0x8CD29C", Length = "0x6F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_109_DarkMage", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Vector2>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Vector2>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Vector2>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "DistanceSquared", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Vector2>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Vector2>), Member = "Remove", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToTileCoordinates", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Point))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Searches.Down), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Conditions.IsSolid), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Searches), Member = "Chain", MemberParameters = new object[]
		{
			typeof(GenSearch),
			typeof(GenCondition[])
		}, ReturnType = typeof(GenSearch))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldUtils), Member = "Find", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(GenSearch),
			typeof(ref Point)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "GetSpawnSourceForNPCFromNPCAI", ReturnType = typeof(IEntitySource))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "NewNPC", MemberParameters = new object[]
		{
			typeof(IEntitySource),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 45)]
		public static void RaiseGoblins(NPC caller, Vector2 spot)
		{
			throw null;
		}

		// Token: 0x060041F1 RID: 16881 RVA: 0x0002DC89 File Offset: 0x0002BE89
		[global::Cpp2ILInjected.Token(Token = "0x6004DDD")]
		[global::Cpp2ILInjected.Address(RVA = "0x8CD98C", Offset = "0x8CD98C", Length = "0x298")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_BottomRight", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static void FindArenaHitbox()
		{
			throw null;
		}

		// Token: 0x060041F2 RID: 16882 RVA: 0x0002DC8C File Offset: 0x0002BE8C
		[global::Cpp2ILInjected.Token(Token = "0x6004DDE")]
		[global::Cpp2ILInjected.Address(RVA = "0x8CDC24", Offset = "0x8CDC24", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToPoint", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Point))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Contains", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static bool ShouldBlockBuilding(Vector2 worldPosition)
		{
			throw null;
		}

		// Token: 0x060041F3 RID: 16883 RVA: 0x0002DC8F File Offset: 0x0002BE8F
		[global::Cpp2ILInjected.Token(Token = "0x6004DDF")]
		[global::Cpp2ILInjected.Address(RVA = "0x8C7CFC", Offset = "0x8C7CFC", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Event), Member = "WinInvasionInternal", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Event), Member = "CheckProgress", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Size", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "DropItemInstanced", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void DropMedals(int numberOfMedals)
		{
			throw null;
		}

		// Token: 0x060041F4 RID: 16884 RVA: 0x0002DC92 File Offset: 0x0002BE92
		[global::Cpp2ILInjected.Token(Token = "0x6004DE0")]
		[global::Cpp2ILInjected.Address(RVA = "0x8CDCCC", Offset = "0x8CDCCC", Length = "0x338")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "DoDeathEvents", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DD2Event), Member = "GetInvasionStatus", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_expertMode", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "GetBalance", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		public static bool ShouldDropCrystals()
		{
			throw null;
		}

		// Token: 0x060041F5 RID: 16885 RVA: 0x0002DC95 File Offset: 0x0002BE95
		[global::Cpp2ILInjected.Token(Token = "0x6004DE1")]
		[global::Cpp2ILInjected.Address(RVA = "0x8C7058", Offset = "0x8C7058", Length = "0x1C0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Event), Member = "UpdateTime", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "AnyNPCs", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "FindFirstNPC", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "FindClosest", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "SpawnOnPlayer", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private static void SummonBetsy()
		{
			throw null;
		}

		// Token: 0x060041F6 RID: 16886 RVA: 0x0002DC98 File Offset: 0x0002BE98
		[global::Cpp2ILInjected.Token(Token = "0x6004DE2")]
		[global::Cpp2ILInjected.Address(RVA = "0x8CC798", Offset = "0x8CC798", Length = "0x17C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Event), Member = "SummonCrystalDirect", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EntitySource_WorldEvent), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "NewItem", MemberParameters = new object[]
		{
			typeof(IEntitySource),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private static void DropStarterCrystals()
		{
			throw null;
		}

		// Token: 0x060041F7 RID: 16887 RVA: 0x0002DC9B File Offset: 0x0002BE9B
		[global::Cpp2ILInjected.Token(Token = "0x6004DE3")]
		[global::Cpp2ILInjected.Address(RVA = "0x8C786C", Offset = "0x8C786C", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Event), Member = "StartInvasion", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Event), Member = "CheckProgress", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Event), Member = "ReportLoss", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Event), Member = "AttemptToSkipWaitTime", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetHost", ReturnType = typeof(bool))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private static void SetEnemySpawningOnHold(int forHowLong)
		{
			throw null;
		}

		// Token: 0x060041F8 RID: 16888 RVA: 0x0002DC9E File Offset: 0x0002BE9E
		[global::Cpp2ILInjected.Token(Token = "0x6004DE4")]
		[global::Cpp2ILInjected.Address(RVA = "0x8C9150", Offset = "0x8C9150", Length = "0x1B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Event), Member = "GetEnemiesForWave", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(short[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		private static short[] Difficulty_1_GetEnemiesForWave(int wave)
		{
			throw null;
		}

		// Token: 0x060041F9 RID: 16889 RVA: 0x0002DCA1 File Offset: 0x0002BEA1
		[global::Cpp2ILInjected.Token(Token = "0x6004DE5")]
		[global::Cpp2ILInjected.Address(RVA = "0x8C8B7C", Offset = "0x8C8B7C", Length = "0x140")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Event), Member = "GetInvasionStatus", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DD2Event), Member = "StartVictoryScene", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static int Difficulty_1_GetRequiredWaveKills(ref int waveNumber, ref int currentKillCount, bool currentlyInCheckProgress)
		{
			throw null;
		}

		// Token: 0x060041FA RID: 16890 RVA: 0x0002DCA4 File Offset: 0x0002BEA4
		[global::Cpp2ILInjected.Token(Token = "0x6004DE6")]
		[global::Cpp2ILInjected.Address(RVA = "0x8CBD34", Offset = "0x8CBD34", Length = "0x744")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Event), Member = "SpawnMonsterFromGate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "CountNPCS", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DD2Event), Member = "GetSpawnSource_OldOnesArmy", ReturnType = typeof(IEntitySource))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DD2Event), Member = "GetInvasionStatus", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "AnyNPCs", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "NewNPC", MemberParameters = new object[]
		{
			typeof(IEntitySource),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetHost", ReturnType = typeof(bool))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 48)]
		private static void Difficulty_1_SpawnMonsterFromGate(Vector2 gateBottom)
		{
			throw null;
		}

		// Token: 0x060041FB RID: 16891 RVA: 0x0002DCA7 File Offset: 0x0002BEA7
		[global::Cpp2ILInjected.Token(Token = "0x6004DE7")]
		[global::Cpp2ILInjected.Address(RVA = "0x8C9548", Offset = "0x8C9548", Length = "0x178")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Event), Member = "GetMonsterPointsWorth", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_expertMode", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private static int Difficulty_1_GetMonsterPointsWorth(int slainMonsterID)
		{
			throw null;
		}

		// Token: 0x060041FC RID: 16892 RVA: 0x0002DCAA File Offset: 0x0002BEAA
		[global::Cpp2ILInjected.Token(Token = "0x6004DE8")]
		[global::Cpp2ILInjected.Address(RVA = "0x8C8F10", Offset = "0x8C8F10", Length = "0x240")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Event), Member = "GetEnemiesForWave", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(short[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		private static short[] Difficulty_2_GetEnemiesForWave(int wave)
		{
			throw null;
		}

		// Token: 0x060041FD RID: 16893 RVA: 0x0002DCAD File Offset: 0x0002BEAD
		[global::Cpp2ILInjected.Token(Token = "0x6004DE9")]
		[global::Cpp2ILInjected.Address(RVA = "0x8C8A60", Offset = "0x8C8A60", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Event), Member = "GetInvasionStatus", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DD2Event), Member = "StartVictoryScene", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static int Difficulty_2_GetRequiredWaveKills(ref int waveNumber, ref int currentKillCount, bool currentlyInCheckProgress)
		{
			throw null;
		}

		// Token: 0x060041FE RID: 16894 RVA: 0x0002DCB0 File Offset: 0x0002BEB0
		[global::Cpp2ILInjected.Token(Token = "0x6004DEA")]
		[global::Cpp2ILInjected.Address(RVA = "0x8C93D0", Offset = "0x8C93D0", Length = "0x178")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Event), Member = "GetMonsterPointsWorth", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_expertMode", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private static int Difficulty_2_GetMonsterPointsWorth(int slainMonsterID)
		{
			throw null;
		}

		// Token: 0x060041FF RID: 16895 RVA: 0x0002DCB3 File Offset: 0x0002BEB3
		[global::Cpp2ILInjected.Token(Token = "0x6004DEB")]
		[global::Cpp2ILInjected.Address(RVA = "0x8CAC94", Offset = "0x8CAC94", Length = "0x10A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Event), Member = "SpawnMonsterFromGate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "CountNPCS", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DD2Event), Member = "GetSpawnSource_OldOnesArmy", ReturnType = typeof(IEntitySource))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DD2Event), Member = "GetInvasionStatus", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "AnyNPCs", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "NewNPC", MemberParameters = new object[]
		{
			typeof(IEntitySource),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetHost", ReturnType = typeof(bool))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 125)]
		private static void Difficulty_2_SpawnMonsterFromGate(Vector2 gateBottom)
		{
			throw null;
		}

		// Token: 0x06004200 RID: 16896 RVA: 0x0002DCB6 File Offset: 0x0002BEB6
		[global::Cpp2ILInjected.Token(Token = "0x6004DEC")]
		[global::Cpp2ILInjected.Address(RVA = "0x8C8CBC", Offset = "0x8C8CBC", Length = "0x254")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Event), Member = "GetEnemiesForWave", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(short[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		private static short[] Difficulty_3_GetEnemiesForWave(int wave)
		{
			throw null;
		}

		// Token: 0x06004201 RID: 16897 RVA: 0x0002DCB9 File Offset: 0x0002BEB9
		[global::Cpp2ILInjected.Token(Token = "0x6004DED")]
		[global::Cpp2ILInjected.Address(RVA = "0x8C88C0", Offset = "0x8C88C0", Length = "0x1A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Event), Member = "GetInvasionStatus", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "FindFirstNPC", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DD2Event), Member = "StartVictoryScene", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private static int Difficulty_3_GetRequiredWaveKills(ref int waveNumber, ref int currentKillCount, bool currentlyInCheckProgress)
		{
			throw null;
		}

		// Token: 0x06004202 RID: 16898 RVA: 0x0002DCBC File Offset: 0x0002BEBC
		[global::Cpp2ILInjected.Token(Token = "0x6004DEE")]
		[global::Cpp2ILInjected.Address(RVA = "0x8C9308", Offset = "0x8C9308", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Event), Member = "GetMonsterPointsWorth", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_expertMode", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static int Difficulty_3_GetMonsterPointsWorth(int slainMonsterID)
		{
			throw null;
		}

		// Token: 0x06004203 RID: 16899 RVA: 0x0002DCBF File Offset: 0x0002BEBF
		[global::Cpp2ILInjected.Token(Token = "0x6004DEF")]
		[global::Cpp2ILInjected.Address(RVA = "0x8C9794", Offset = "0x8C9794", Length = "0x1500")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "CountNPCS", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DD2Event), Member = "GetSpawnSource_OldOnesArmy", ReturnType = typeof(IEntitySource))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "AnyNPCs", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "NewNPC", MemberParameters = new object[]
		{
			typeof(IEntitySource),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetHost", ReturnType = typeof(bool))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 156)]
		private static void Difficulty_3_SpawnMonsterFromGate(Vector2 gateBottom)
		{
			throw null;
		}

		// Token: 0x06004204 RID: 16900 RVA: 0x0002DCC2 File Offset: 0x0002BEC2
		[global::Cpp2ILInjected.Token(Token = "0x6004DF0")]
		[global::Cpp2ILInjected.Address(RVA = "0x8CE058", Offset = "0x8CE058", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Event), Member = "RequestToSkipWaitTime", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Bottom", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Distance", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static bool IsStandActive(int x, int y)
		{
			throw null;
		}

		// Token: 0x06004205 RID: 16901 RVA: 0x0002DCC5 File Offset: 0x0002BEC5
		[global::Cpp2ILInjected.Token(Token = "0x6004DF1")]
		[global::Cpp2ILInjected.Address(RVA = "0x8CE190", Offset = "0x8CE190", Length = "0x1D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "TileInteractionsUse", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DD2Event), Member = "IsStandActive", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(LegacySoundStyle),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LogicHost", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetHost", ReturnType = typeof(bool))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public static void RequestToSkipWaitTime(int x, int y)
		{
			throw null;
		}

		// Token: 0x06004206 RID: 16902 RVA: 0x0002DCC8 File Offset: 0x0002BEC8
		[global::Cpp2ILInjected.Token(Token = "0x6004DF2")]
		[global::Cpp2ILInjected.Address(RVA = "0x8CE364", Offset = "0x8CE364", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageBuffer), Member = "ProcessData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DD2Event), Member = "SetEnemySpawningOnHold", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static void AttemptToSkipWaitTime()
		{
			throw null;
		}

		// Token: 0x06004207 RID: 16903 RVA: 0x0002DCCB File Offset: 0x0002BECB
		[global::Cpp2ILInjected.Token(Token = "0x6004DF3")]
		[global::Cpp2ILInjected.Address(RVA = "0x8CE004", Offset = "0x8CE004", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Event), Member = "Difficulty_1_SpawnMonsterFromGate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Event), Member = "Difficulty_2_SpawnMonsterFromGate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Event), Member = "Difficulty_3_SpawnMonsterFromGate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 33)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EntitySource_OldOnesArmy), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static IEntitySource GetSpawnSource_OldOnesArmy()
		{
			throw null;
		}

		// Token: 0x06004208 RID: 16904 RVA: 0x0002DCCE File Offset: 0x0002BECE
		[global::Cpp2ILInjected.Token(Token = "0x6004DF4")]
		[global::Cpp2ILInjected.Address(RVA = "0x8CE448", Offset = "0x8CE448", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public DD2Event()
		{
			throw null;
		}

		// Token: 0x06004209 RID: 16905 RVA: 0x0002DCD1 File Offset: 0x0002BED1
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6004DF5")]
		[global::Cpp2ILInjected.Address(RVA = "0x8CE450", Offset = "0x8CE450", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Vector2>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static DD2Event()
		{
			throw null;
		}

		// Token: 0x04006DE2 RID: 28130
		[global::Cpp2ILInjected.Token(Token = "0x40086A8")]
		public static bool DownedInvasionT1;

		// Token: 0x04006DE3 RID: 28131
		[global::Cpp2ILInjected.Token(Token = "0x40086A9")]
		public static bool DownedInvasionT2;

		// Token: 0x04006DE4 RID: 28132
		[global::Cpp2ILInjected.Token(Token = "0x40086AA")]
		public static bool DownedInvasionT3;

		// Token: 0x04006DE5 RID: 28133
		[global::Cpp2ILInjected.Token(Token = "0x40086AB")]
		public static bool LostThisRun;

		// Token: 0x04006DE6 RID: 28134
		[global::Cpp2ILInjected.Token(Token = "0x40086AC")]
		public static bool WonThisRun;

		// Token: 0x04006DE7 RID: 28135
		[global::Cpp2ILInjected.Token(Token = "0x40086AD")]
		public static int LaneSpawnRate;

		// Token: 0x04006DE8 RID: 28136
		[global::Cpp2ILInjected.Token(Token = "0x40086AE")]
		private static bool _downedDarkMageT1;

		// Token: 0x04006DE9 RID: 28137
		[global::Cpp2ILInjected.Token(Token = "0x40086AF")]
		private static bool _downedOgreT2;

		// Token: 0x04006DEA RID: 28138
		[global::Cpp2ILInjected.Token(Token = "0x40086B0")]
		private static bool _spawnedBetsyT3;

		// Token: 0x04006DEB RID: 28139
		[global::Cpp2ILInjected.Token(Token = "0x40086B1")]
		public static bool Ongoing;

		// Token: 0x04006DEC RID: 28140
		[global::Cpp2ILInjected.Token(Token = "0x40086B2")]
		public static Rectangle ArenaHitbox;

		// Token: 0x04006DED RID: 28141
		[global::Cpp2ILInjected.Token(Token = "0x40086B3")]
		private static int _arenaHitboxingCooldown;

		// Token: 0x04006DEE RID: 28142
		[global::Cpp2ILInjected.Token(Token = "0x40086B4")]
		public static int OngoingDifficulty;

		// Token: 0x04006DEF RID: 28143
		[global::Cpp2ILInjected.Token(Token = "0x40086B5")]
		private static List<Vector2> _deadGoblinSpots;

		// Token: 0x04006DF0 RID: 28144
		[global::Cpp2ILInjected.Token(Token = "0x40086B6")]
		private static int _crystalsDropping_lastWave;

		// Token: 0x04006DF1 RID: 28145
		[global::Cpp2ILInjected.Token(Token = "0x40086B7")]
		private static int _crystalsDropping_toDrop;

		// Token: 0x04006DF2 RID: 28146
		[global::Cpp2ILInjected.Token(Token = "0x40086B8")]
		private static int _crystalsDropping_alreadyDropped;

		// Token: 0x04006DF3 RID: 28147
		[global::Cpp2ILInjected.Token(Token = "0x40086B9")]
		private static readonly Color INFO_NEW_WAVE_COLOR;

		// Token: 0x04006DF4 RID: 28148
		[global::Cpp2ILInjected.Token(Token = "0x40086BA")]
		private static readonly Color INFO_START_INVASION_COLOR;

		// Token: 0x04006DF5 RID: 28149
		[global::Cpp2ILInjected.Token(Token = "0x40086BB")]
		private static readonly Color INFO_FAILURE_INVASION_COLOR;

		// Token: 0x04006DF6 RID: 28150
		[global::Cpp2ILInjected.Token(Token = "0x40086BC")]
		private const int INVASION_ID = 3;

		// Token: 0x04006DF7 RID: 28151
		[global::Cpp2ILInjected.Token(Token = "0x40086BD")]
		private static int _timeLeftUntilSpawningBegins;
	}
}
