using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Chat;
using Terraria.Chat.Commands;
using Terraria.DataStructures;
using Terraria.GameContent;
using Terraria.GameContent.Animations;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.Skies.CreditsRoll;
using Terraria.GameContent.UI.Elements;
using Terraria.GameContent.UI.States;
using Terraria.Social.Base;
using Terraria.UI;
using Terraria.Utilities;

namespace Terraria.Localization
{
	// Token: 0x020003B5 RID: 949
	[global::Cpp2ILInjected.Token(Token = "0x2000556")]
	public static class Language
	{
		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x06002EA7 RID: 11943 RVA: 0x0002A548 File Offset: 0x00028748
		[global::Cpp2ILInjected.Token(Token = "0x17000669")]
		public static GameCulture ActiveCulture
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003308")]
			[global::Cpp2ILInjected.Address(RVA = "0x133540C", Offset = "0x133540C", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIChest), Member = "RefreshLangStrings", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageOptions), Member = "RefreshLangStrings", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPulldownSetting), Member = "GetValue", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "GetArmourSetId", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GameCulture), Member = "get_IsActive", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIAchievementListItem), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002EA8 RID: 11944 RVA: 0x0002A54B File Offset: 0x0002874B
		[global::Cpp2ILInjected.Token(Token = "0x6003309")]
		[global::Cpp2ILInjected.Address(RVA = "0x13360B0", Offset = "0x13360B0", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 193)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static LocalizedText GetText(string key)
		{
			throw null;
		}

		// Token: 0x06002EA9 RID: 11945 RVA: 0x0002A54E File Offset: 0x0002874E
		[global::Cpp2ILInjected.Token(Token = "0x600330A")]
		[global::Cpp2ILInjected.Address(RVA = "0x132A7DC", Offset = "0x132A7DC", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 675)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LanguageManager), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static string GetTextValue(string key)
		{
			throw null;
		}

		// Token: 0x06002EAA RID: 11946 RVA: 0x0002A551 File Offset: 0x00028751
		[global::Cpp2ILInjected.Token(Token = "0x600330B")]
		[global::Cpp2ILInjected.Address(RVA = "0x133627C", Offset = "0x133627C", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 73)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static string GetTextValue(string key, object arg0)
		{
			throw null;
		}

		// Token: 0x06002EAB RID: 11947 RVA: 0x0002A554 File Offset: 0x00028754
		[global::Cpp2ILInjected.Token(Token = "0x600330C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1336394", Offset = "0x1336394", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMap), Member = "DrawMap", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "MouseText_DrawItemTooltip_GetLinesInfo", MemberParameters = new object[]
		{
			typeof(Item),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(float),
			typeof(ref int),
			typeof(string[]),
			typeof(bool[]),
			typeof(bool[]),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawInvasionProgress", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "get_FullName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "FishingCheck", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "GetDryadWorldStatusDialog", MemberParameters = new object[] { typeof(ref bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static string GetTextValue(string key, object arg0, object arg1)
		{
			throw null;
		}

		// Token: 0x06002EAC RID: 11948 RVA: 0x0002A557 File Offset: 0x00028757
		[global::Cpp2ILInjected.Token(Token = "0x600330D")]
		[global::Cpp2ILInjected.Address(RVA = "0x13364C8", Offset = "0x13364C8", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "GetDryadWorldStatusDialog", MemberParameters = new object[] { typeof(ref bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static string GetTextValue(string key, object arg0, object arg1, object arg2)
		{
			throw null;
		}

		// Token: 0x06002EAD RID: 11949 RVA: 0x0002A55A File Offset: 0x0002875A
		[global::Cpp2ILInjected.Token(Token = "0x600330E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1336614", Offset = "0x1336614", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "GetDryadWorldStatusDialog", MemberParameters = new object[] { typeof(ref bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "MoveTownNPC", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetworkText), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static string GetTextValue(string key, params object[] args)
		{
			throw null;
		}

		// Token: 0x06002EAE RID: 11950 RVA: 0x0002A55D File Offset: 0x0002875D
		[global::Cpp2ILInjected.Token(Token = "0x600330F")]
		[global::Cpp2ILInjected.Address(RVA = "0x132BB68", Offset = "0x132BB68", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "HelpText", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "GetChat", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "dialog", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "BartenderHelpText", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "BartenderChat", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "AnglerQuestChat", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorkshopIssueReporter), Member = "ReportDelayedUploadProblemWithoutKnownReason", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorkshopIssueReporter), Member = "ReportDownloadProblem", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorkshopIssueReporter), Member = "ReportManifestCreationProblem", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EntryFilterer<, >), Member = "GetDisplayName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ShopHelper), Member = "AddHappinessReportText", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContentRejectionFromSize), Member = "GetReason", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "GetCompletionPercentText", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LanguageManager), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(LocalizedText))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LocalizedText), Member = "FormatWith", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static string GetTextValueWith(string key, object obj)
		{
			throw null;
		}

		// Token: 0x06002EAF RID: 11951 RVA: 0x0002A560 File Offset: 0x00028760
		[global::Cpp2ILInjected.Token(Token = "0x6003310")]
		[global::Cpp2ILInjected.Address(RVA = "0x1336854", Offset = "0x1336854", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "DrawLootDrops", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "DrawFilters", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LanguageManager), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(LocalizedText))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static StringBuilder GetTextValueWith(string key, object obj, StringBuilder sb)
		{
			throw null;
		}

		// Token: 0x06002EB0 RID: 11952 RVA: 0x0002A563 File Offset: 0x00028763
		[global::Cpp2ILInjected.Token(Token = "0x6003311")]
		[global::Cpp2ILInjected.Address(RVA = "0x1336C80", Offset = "0x1336C80", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "startDedInputCallBack", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "HelpText", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Lang.<>c__DisplayClass52_0`2", Member = "<FillNameCacheArray>b__1", MemberParameters = new object[] { typeof(FieldInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemTooltip), Member = "FromLanguageKey", MemberParameters = new object[]
		{
			typeof(short),
			typeof(string)
		}, ReturnType = typeof(ItemTooltip))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChatCommandProcessor), Member = "AddCommand", MemberTypeParameters = new object[] { "T" }, ReturnType = typeof(ChatCommandProcessor))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryEntry), Member = "Enemy", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(BestiaryEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryEntry), Member = "TownNPC", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(BestiaryEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryEntry), Member = "Critter", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(BestiaryEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool Exists(string key)
		{
			throw null;
		}

		// Token: 0x06002EB1 RID: 11953 RVA: 0x0002A566 File Offset: 0x00028766
		[global::Cpp2ILInjected.Token(Token = "0x6003312")]
		[global::Cpp2ILInjected.Address(RVA = "0x1336D38", Offset = "0x1336D38", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static int GetCategorySize(string key)
		{
			throw null;
		}

		// Token: 0x06002EB2 RID: 11954 RVA: 0x0002A569 File Offset: 0x00028769
		[global::Cpp2ILInjected.Token(Token = "0x6003313")]
		[global::Cpp2ILInjected.Address(RVA = "0x1336E34", Offset = "0x1336E34", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static LocalizedText[] FindAll(Regex regex)
		{
			throw null;
		}

		// Token: 0x06002EB3 RID: 11955 RVA: 0x0002A56C File Offset: 0x0002876C
		[global::Cpp2ILInjected.Token(Token = "0x6003314")]
		[global::Cpp2ILInjected.Address(RVA = "0x1337134", Offset = "0x1337134", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "GetChat", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "DyeTraderQuestChat", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "BartenderHelpText", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HelpCommand), Member = "GetCommandAliasesByID", ReturnType = typeof(Dictionary<string, List<LocalizedText>>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static LocalizedText[] FindAll(LanguageSearchFilter filter)
		{
			throw null;
		}

		// Token: 0x06002EB4 RID: 11956 RVA: 0x0002A56F File Offset: 0x0002876F
		[global::Cpp2ILInjected.Token(Token = "0x6003315")]
		[global::Cpp2ILInjected.Address(RVA = "0x1337388", Offset = "0x1337388", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_TextRoll", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(Vector2)
		}, ReturnType = typeof(SegmentInforReport))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static LocalizedText[] FindAll(string categoryName)
		{
			throw null;
		}

		// Token: 0x06002EB5 RID: 11957 RVA: 0x0002A572 File Offset: 0x00028772
		[global::Cpp2ILInjected.Token(Token = "0x6003316")]
		[global::Cpp2ILInjected.Address(RVA = "0x13375C4", Offset = "0x13375C4", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "GetChat", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "HasLuckTextForWizard", MemberParameters = new object[] { typeof(ref string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "GetSpecialEventTextIfNotEmpty", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(ref string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "AnglerQuestCountChat", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "BartenderChat", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "GolferChat", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "BestiaryGirlChat", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "PrincessChat", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "CatChat", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "DogChat", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "BunnyChat", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "SlimeChat", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "AnglerQuestChat", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static LocalizedText SelectRandom(LanguageSearchFilter filter, UnifiedRandom random = null)
		{
			throw null;
		}

		// Token: 0x06002EB6 RID: 11958 RVA: 0x0002A575 File Offset: 0x00028775
		[global::Cpp2ILInjected.Token(Token = "0x6003317")]
		[global::Cpp2ILInjected.Address(RVA = "0x133791C", Offset = "0x133791C", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldCreateMenu), Member = "GenerateName", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "getNewNPCNameInner", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "GetRandomGameTitle", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "CreateDeathMessage", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(NetworkText))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Profiles.VariantNPCProfile), Member = "GetNameForVariant", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static LocalizedText RandomFromCategory(string categoryName, UnifiedRandom random = null)
		{
			throw null;
		}

		// Token: 0x0400326B RID: 12907
		[global::Cpp2ILInjected.Token(Token = "0x4003C19")]
		public const char NodeKeySeperator = '*';
	}
}
