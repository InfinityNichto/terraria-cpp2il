using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Localization;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x0200061D RID: 1565
	[global::Cpp2ILInjected.Token(Token = "0x2000940")]
	public class BestiaryEntry
	{
		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x06003E7A RID: 15994 RVA: 0x0002D29C File Offset: 0x0002B49C
		// (set) Token: 0x06003E7B RID: 15995 RVA: 0x0002D29F File Offset: 0x0002B49F
		[global::Cpp2ILInjected.Token(Token = "0x17000821")]
		public List<IBestiaryInfoElement> Info
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600478E")]
			[global::Cpp2ILInjected.Address(RVA = "0x819254", Offset = "0x819254", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600478F")]
			[global::Cpp2ILInjected.Address(RVA = "0x81925C", Offset = "0x81925C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x06003E7C RID: 15996 RVA: 0x0002D2A2 File Offset: 0x0002B4A2
		[global::Cpp2ILInjected.Token(Token = "0x6004790")]
		[global::Cpp2ILInjected.Address(RVA = "0x810384", Offset = "0x810384", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryDatabase), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryEntry), Member = "Enemy", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(BestiaryEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryEntry), Member = "TownNPC", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(BestiaryEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryEntry), Member = "Critter", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(BestiaryEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryEntry), Member = "Biome", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(Func<bool>)
		}, ReturnType = typeof(BestiaryEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCPortraitInfoElement), Member = "ProvideUIElement", MemberParameters = new object[] { typeof(BestiaryUICollectionInfo) }, ReturnType = typeof(UIElement))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public BestiaryEntry()
		{
			throw null;
		}

		// Token: 0x06003E7D RID: 15997 RVA: 0x0002D2A5 File Offset: 0x0002B4A5
		[global::Cpp2ILInjected.Token(Token = "0x6004791")]
		[global::Cpp2ILInjected.Address(RVA = "0x819264", Offset = "0x819264", Length = "0x72C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "AddMultiEntryNPCS_Manual", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "AddEmptyEntries_CrittersAndEnemies_Automated", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lang), Member = "GetNPCName", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(LocalizedText))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int?), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCKillCounterInfoElement), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCStatsReportInfoElement), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "GetBestiaryCreditId", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CommonEnemyUICollectionInfoProvider), Member = "GetKillCountNeeded", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Replace", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "Exists", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BestiaryEntry), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnlockableNPCEntryIcon), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 39)]
		public static BestiaryEntry Enemy(int npcNetId)
		{
			throw null;
		}

		// Token: 0x06003E7E RID: 15998 RVA: 0x0002D2A8 File Offset: 0x0002B4A8
		[global::Cpp2ILInjected.Token(Token = "0x6004792")]
		[global::Cpp2ILInjected.Address(RVA = "0x819D2C", Offset = "0x819D2C", Length = "0x534")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "AddTownNPCs_Manual", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 40)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lang), Member = "GetNPCName", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(LocalizedText))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int?), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCKillCounterInfoElement), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Replace", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "Exists", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BestiaryEntry), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnlockableNPCEntryIcon), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "GetBestiaryCreditId", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 30)]
		public static BestiaryEntry TownNPC(int npcNetId)
		{
			throw null;
		}

		// Token: 0x06003E7F RID: 15999 RVA: 0x0002D2AB File Offset: 0x0002B4AB
		[global::Cpp2ILInjected.Token(Token = "0x6004793")]
		[global::Cpp2ILInjected.Address(RVA = "0x81A288", Offset = "0x81A288", Length = "0x534")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "AddEmptyEntries_CrittersAndEnemies_Automated", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lang), Member = "GetNPCName", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(LocalizedText))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int?), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCKillCounterInfoElement), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Replace", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "Exists", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BestiaryEntry), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnlockableNPCEntryIcon), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "GetBestiaryCreditId", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 30)]
		public static BestiaryEntry Critter(int npcNetId)
		{
			throw null;
		}

		// Token: 0x06003E80 RID: 16000 RVA: 0x0002D2AE File Offset: 0x0002B4AE
		[global::Cpp2ILInjected.Token(Token = "0x6004794")]
		[global::Cpp2ILInjected.Address(RVA = "0x81A7E4", Offset = "0x81A7E4", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "RegisterTestEntries", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BestiaryEntry), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomEntryIcon), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(Func<bool>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static BestiaryEntry Biome(string nameLanguageKey, string texturePath, Func<bool> unlockCondition)
		{
			throw null;
		}

		// Token: 0x06003E81 RID: 16001 RVA: 0x0002D2B1 File Offset: 0x0002B4B1
		[global::Cpp2ILInjected.Token(Token = "0x6004795")]
		[global::Cpp2ILInjected.Address(RVA = "0x81AA08", Offset = "0x81AA08", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "ModifyEntriesThatNeedIt", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "AddNPCBiomeRelationships_AddDecorations_Automated", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 62)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "AddRange", MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void AddTags(params IBestiaryInfoElement[] elements)
		{
			throw null;
		}

		// Token: 0x04006C49 RID: 27721
		[global::Cpp2ILInjected.Token(Token = "0x4008368")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public IEntryIcon Icon;

		// Token: 0x04006C4A RID: 27722
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4008369")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private List<IBestiaryInfoElement> <Info>k__BackingField;

		// Token: 0x04006C4B RID: 27723
		[global::Cpp2ILInjected.Token(Token = "0x400836A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public IBestiaryUICollectionInfoProvider UIInfoProvider;
	}
}
