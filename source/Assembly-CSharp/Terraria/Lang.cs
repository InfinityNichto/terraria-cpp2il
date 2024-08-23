using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Reflection;
using Terraria.Chat.Commands;
using Terraria.DataStructures;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.Events;
using Terraria.GameContent.Golf;
using Terraria.GameInput;
using Terraria.ID;
using Terraria.Localization;
using Terraria.Map;
using Terraria.UI;
using Terraria.Utilities;

namespace Terraria
{
	// Token: 0x02000331 RID: 817
	[global::Cpp2ILInjected.Token(Token = "0x2000436")]
	public class Lang
	{
		// Token: 0x06002622 RID: 9762 RVA: 0x00028CB5 File Offset: 0x00026EB5
		[global::Cpp2ILInjected.Token(Token = "0x6002838")]
		[global::Cpp2ILInjected.Address(RVA = "0x10D8E3C", Offset = "0x10D8E3C", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIAccessoryInfo), Member = "BuildInfoAccs", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICraftGuidePopup), Member = "UpdateText", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMap), Member = "DrawMap", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static string GetMapObjectName(int id)
		{
			throw null;
		}

		// Token: 0x06002623 RID: 9763 RVA: 0x00028CB8 File Offset: 0x00026EB8
		[global::Cpp2ILInjected.Token(Token = "0x6002839")]
		[global::Cpp2ILInjected.Address(RVA = "0x10D8EE4", Offset = "0x10D8EE4", Length = "0xBA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "HelpText", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "GetChat", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "HasLuckTextForWizard", MemberParameters = new object[] { typeof(ref string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "HasSpecialEventText", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "dialog", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "DyeTraderQuestChat", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "AnglerQuestCountChat", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "BartenderHelpText", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "BartenderChat", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "GolferChat", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "BestiaryGirlChat", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "PrincessChat", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "CatChat", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "DogChat", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "BunnyChat", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "SlimeChat", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "AnglerQuestChat", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HelpCommand), Member = "GetCommandAliasesByID", ReturnType = typeof(Dictionary<string, List<LocalizedText>>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.UI.GameTipsDisplay.GameTip", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(LocalizedText),
			typeof(double)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 19)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "GetFirstNPCNameOrNull", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalPlayer", ReturnType = typeof(Player))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ZoneGraveyard", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControlsBanner), Member = "GetControlTag", MemberParameters = new object[] { typeof(ControllerActionButton) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "GetEntry", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ControllerActionButton.Entry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 38)]
		public static object CreateDialogSubstitutionObject(NPC npc = null)
		{
			throw null;
		}

		// Token: 0x06002624 RID: 9764 RVA: 0x00028CBB File Offset: 0x00026EBB
		[global::Cpp2ILInjected.Token(Token = "0x600283A")]
		[global::Cpp2ILInjected.Address(RVA = "0x10D9A8C", Offset = "0x10D9A8C", Length = "0x66C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LanguageManager), Member = "RandomFromCategories", MemberParameters = new object[]
		{
			typeof(string[]),
			typeof(ref int),
			typeof(UnifiedRandom)
		}, ReturnType = typeof(LocalizedText))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "get_PrimaryInputMode", ReturnType = typeof(XNAUnityRunner.ForcedInputMode))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(<PrivateImplementationDetails>), Member = "ComputeStringHash", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "get_HasMapping", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "GetEntry", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ControllerActionButton.Entry))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public static bool CanSubstituteBindings(string bindingKey)
		{
			throw null;
		}

		// Token: 0x06002625 RID: 9765 RVA: 0x00028CBE File Offset: 0x00026EBE
		[Obsolete("dialog is deprecated. Please use Language.GetText instead.")]
		[global::Cpp2ILInjected.Token(Token = "0x600283B")]
		[global::Cpp2ILInjected.Address(RVA = "0x10DA0F8", Offset = "0x10DA0F8", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "HelpText", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "GetChat", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lang), Member = "CreateDialogSubstitutionObject", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValueWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static string dialog(int l, bool english = false)
		{
			throw null;
		}

		// Token: 0x06002626 RID: 9766 RVA: 0x00028CC1 File Offset: 0x00026EC1
		[global::Cpp2ILInjected.Token(Token = "0x600283C")]
		[global::Cpp2ILInjected.Address(RVA = "0x10DA1A4", Offset = "0x10DA1A4", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIAccessoryInfo), Member = "BuildInfoAccs", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "MouseText_DrawBuffTooltip", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "get_TypeName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "GetFullnameByID", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "SpawnSkeletron", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Recipe.<>c", Member = "<SetupRecipeGroups>b__56_0", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Recipe.<>c", Member = "<SetupRecipeGroups>b__56_1", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Recipe.<>c", Member = "<SetupRecipeGroups>b__56_2", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Recipe.<>c", Member = "<SetupRecipeGroups>b__56_9", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnlockableNPCEntryIcon), Member = "GetHoverText", MemberParameters = new object[] { typeof(BestiaryUICollectionInfo) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lang), Member = "GetNPCName", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(LocalizedText))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static string GetNPCNameValue(int netID)
		{
			throw null;
		}

		// Token: 0x06002627 RID: 9767 RVA: 0x00028CC4 File Offset: 0x00026EC4
		[global::Cpp2ILInjected.Token(Token = "0x600283D")]
		[global::Cpp2ILInjected.Address(RVA = "0x10DA200", Offset = "0x10DA200", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "GetTypeNetName", ReturnType = typeof(NetworkText))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "CountKillForBannersAndDropThem", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "SpawnSkeletron", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "GetNPCNameValue", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "GetInvasionWaveText", MemberParameters = new object[]
		{
			typeof(int),
			typeof(short[])
		}, ReturnType = typeof(NetworkText))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryEntry), Member = "Enemy", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(BestiaryEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryEntry), Member = "TownNPC", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(BestiaryEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryEntry), Member = "Critter", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(BestiaryEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static LocalizedText GetNPCName(int netID)
		{
			throw null;
		}

		// Token: 0x06002628 RID: 9768 RVA: 0x00028CC7 File Offset: 0x00026EC7
		[global::Cpp2ILInjected.Token(Token = "0x600283E")]
		[global::Cpp2ILInjected.Address(RVA = "0x10DA2F0", Offset = "0x10DA2F0", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "RebuildTooltip", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static ItemTooltip GetTooltip(int itemId)
		{
			throw null;
		}

		// Token: 0x06002629 RID: 9769 RVA: 0x00028CCA File Offset: 0x00026ECA
		[global::Cpp2ILInjected.Token(Token = "0x600283F")]
		[global::Cpp2ILInjected.Address(RVA = "0x10DA354", Offset = "0x10DA354", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "GetItemNameValue", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemID), Member = "FromNetId", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static LocalizedText GetItemName(int id)
		{
			throw null;
		}

		// Token: 0x0600262A RID: 9770 RVA: 0x00028CCD File Offset: 0x00026ECD
		[global::Cpp2ILInjected.Token(Token = "0x6002840")]
		[global::Cpp2ILInjected.Address(RVA = "0x10DA458", Offset = "0x10DA458", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EmojiCommand), Member = "Initialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static LocalizedText GetEmojiName(int id)
		{
			throw null;
		}

		// Token: 0x0600262B RID: 9771 RVA: 0x00028CD0 File Offset: 0x00026ED0
		[global::Cpp2ILInjected.Token(Token = "0x6002841")]
		[global::Cpp2ILInjected.Address(RVA = "0x10DA520", Offset = "0x10DA520", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIChest), Member = "GetName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIChest), Member = "GetTitle", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICraftGuidePopup), Member = "MaterialItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICrafting), Member = "MaterialItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUINPCDialogue), Member = "DrawSign", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageGroupEdit), Member = "ItemDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "get_Name", ReturnType = typeof(string))]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TeleportPylonsMapLayer), Member = "Draw", MemberParameters = new object[]
		{
			typeof(ref MapOverlayDrawContext),
			typeof(ref string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IngameFancyUI), Member = "OpenVirtualKeyboard", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChestUI), Member = "DrawName", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChestUI), Member = "RenameChest", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lang), Member = "GetItemName", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(LocalizedText))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static string GetItemNameValue(int id)
		{
			throw null;
		}

		// Token: 0x0600262C RID: 9772 RVA: 0x00028CD3 File Offset: 0x00026ED3
		[global::Cpp2ILInjected.Token(Token = "0x6002842")]
		[global::Cpp2ILInjected.Address(RVA = "0x10DA57C", Offset = "0x10DA57C", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBuffs), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawInterface_Resources_Buffs", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static string GetBuffName(int id)
		{
			throw null;
		}

		// Token: 0x0600262D RID: 9773 RVA: 0x00028CD6 File Offset: 0x00026ED6
		[global::Cpp2ILInjected.Token(Token = "0x6002843")]
		[global::Cpp2ILInjected.Address(RVA = "0x10DA5E4", Offset = "0x10DA5E4", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBuffs), Member = "ChangeBuffString", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "GetBuffTooltip", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static string GetBuffDescription(int id)
		{
			throw null;
		}

		// Token: 0x0600262E RID: 9774 RVA: 0x00028CD9 File Offset: 0x00026ED9
		[global::Cpp2ILInjected.Token(Token = "0x6002844")]
		[global::Cpp2ILInjected.Address(RVA = "0x10DA64C", Offset = "0x10DA64C", Length = "0x4F8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUINPCDialogue), Member = "Option2Clicked", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 41)]
		public static string GetDryadWorldStatusDialog(out bool worldIsEntirelyPure)
		{
			throw null;
		}

		// Token: 0x0600262F RID: 9775 RVA: 0x00028CDC File Offset: 0x00026EDC
		[global::Cpp2ILInjected.Token(Token = "0x6002845")]
		[global::Cpp2ILInjected.Address(RVA = "0x10DAB44", Offset = "0x10DAB44", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "RandomFromCategory", MemberParameters = new object[]
		{
			typeof(string),
			typeof(UnifiedRandom)
		}, ReturnType = typeof(LocalizedText))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static string GetRandomGameTitle()
		{
			throw null;
		}

		// Token: 0x06002630 RID: 9776 RVA: 0x00028CDF File Offset: 0x00026EDF
		[global::Cpp2ILInjected.Token(Token = "0x6002846")]
		[global::Cpp2ILInjected.Address(RVA = "0x10DAB94", Offset = "0x10DAB94", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUINPCDialogue), Member = "Option2Clicked", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lang), Member = "CreateDialogSubstitutionObject", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lang), Member = "CreateDialogFilter", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(LanguageSearchFilter))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "FindAll", MemberParameters = new object[] { typeof(LanguageSearchFilter) }, ReturnType = typeof(LocalizedText[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LocalizedText), Member = "FormatWith", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static string DyeTraderQuestChat(bool gotDye = false)
		{
			throw null;
		}

		// Token: 0x06002631 RID: 9777 RVA: 0x00028CE2 File Offset: 0x00026EE2
		[global::Cpp2ILInjected.Token(Token = "0x6002847")]
		[global::Cpp2ILInjected.Address(RVA = "0x10DAD60", Offset = "0x10DAD60", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "GetChat", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lang), Member = "CreateDialogSubstitutionObject", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lang), Member = "CreateDialogFilter", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(LanguageSearchFilter))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "SelectRandom", MemberParameters = new object[]
		{
			typeof(LanguageSearchFilter),
			typeof(UnifiedRandom)
		}, ReturnType = typeof(LocalizedText))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LocalizedText), Member = "FormatWith", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static string AnglerQuestCountChat(NPC npc)
		{
			throw null;
		}

		// Token: 0x06002632 RID: 9778 RVA: 0x00028CE5 File Offset: 0x00026EE5
		[global::Cpp2ILInjected.Token(Token = "0x6002848")]
		[global::Cpp2ILInjected.Address(RVA = "0x10DADF4", Offset = "0x10DADF4", Length = "0x394")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUINPCDialogue), Member = "Option2Clicked", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lang), Member = "CreateDialogSubstitutionObject", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lang), Member = "CreateDialogFilter", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(LanguageSearchFilter))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "FindAll", MemberParameters = new object[] { typeof(LanguageSearchFilter) }, ReturnType = typeof(LocalizedText[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LocalizedText), Member = "FormatWith", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "GetItem", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Item),
			typeof(GetItemSettings),
			typeof(bool)
		}, ReturnType = typeof(Item))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EntitySource_Gift), Member = ".ctor", MemberParameters = new object[] { typeof(Entity) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "NewItem", MemberParameters = new object[]
		{
			typeof(IEntitySource),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetClient", ReturnType = typeof(bool))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValueWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		public static string BartenderHelpText(NPC npc)
		{
			throw null;
		}

		// Token: 0x06002633 RID: 9779 RVA: 0x00028CE8 File Offset: 0x00026EE8
		[global::Cpp2ILInjected.Token(Token = "0x6002849")]
		[global::Cpp2ILInjected.Address(RVA = "0x10DB188", Offset = "0x10DB188", Length = "0x1D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "GetChat", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lang), Member = "CreateDialogSubstitutionObject", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lang), Member = "CreateDialogFilter", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(LanguageSearchFilter))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "SelectRandom", MemberParameters = new object[]
		{
			typeof(LanguageSearchFilter),
			typeof(UnifiedRandom)
		}, ReturnType = typeof(LocalizedText))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LocalizedText), Member = "FormatWith", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValueWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public static string BartenderChat(NPC npc)
		{
			throw null;
		}

		// Token: 0x06002634 RID: 9780 RVA: 0x00028CEB File Offset: 0x00026EEB
		[global::Cpp2ILInjected.Token(Token = "0x600284A")]
		[global::Cpp2ILInjected.Address(RVA = "0x10DB35C", Offset = "0x10DB35C", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "GetChat", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lang), Member = "CreateDialogSubstitutionObject", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lang), Member = "CreateDialogFilter", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(LanguageSearchFilter))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "SelectRandom", MemberParameters = new object[]
		{
			typeof(LanguageSearchFilter),
			typeof(UnifiedRandom)
		}, ReturnType = typeof(LocalizedText))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LocalizedText), Member = "FormatWith", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static string GolferChat(NPC npc)
		{
			throw null;
		}

		// Token: 0x06002635 RID: 9781 RVA: 0x00028CEE File Offset: 0x00026EEE
		[global::Cpp2ILInjected.Token(Token = "0x600284B")]
		[global::Cpp2ILInjected.Address(RVA = "0x10DB3F0", Offset = "0x10DB3F0", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "GetChat", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lang), Member = "CreateDialogSubstitutionObject", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "ShouldBestiaryGirlBeLycantrope", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lang), Member = "CreateDialogFilter", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(LanguageSearchFilter))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "SelectRandom", MemberParameters = new object[]
		{
			typeof(LanguageSearchFilter),
			typeof(UnifiedRandom)
		}, ReturnType = typeof(LocalizedText))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LocalizedText), Member = "FormatWith", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static string BestiaryGirlChat(NPC npc)
		{
			throw null;
		}

		// Token: 0x06002636 RID: 9782 RVA: 0x00028CF1 File Offset: 0x00026EF1
		[global::Cpp2ILInjected.Token(Token = "0x600284C")]
		[global::Cpp2ILInjected.Address(RVA = "0x10DB4CC", Offset = "0x10DB4CC", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "GetChat", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lang), Member = "CreateDialogSubstitutionObject", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lang), Member = "CreateDialogFilter", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(LanguageSearchFilter))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "SelectRandom", MemberParameters = new object[]
		{
			typeof(LanguageSearchFilter),
			typeof(UnifiedRandom)
		}, ReturnType = typeof(LocalizedText))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LocalizedText), Member = "FormatWith", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static string PrincessChat(NPC npc)
		{
			throw null;
		}

		// Token: 0x06002637 RID: 9783 RVA: 0x00028CF4 File Offset: 0x00026EF4
		[global::Cpp2ILInjected.Token(Token = "0x600284D")]
		[global::Cpp2ILInjected.Address(RVA = "0x10DB560", Offset = "0x10DB560", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "GetChat", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lang), Member = "CreateDialogSubstitutionObject", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lang), Member = "CreateDialogFilter", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(LanguageSearchFilter))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "SelectRandom", MemberParameters = new object[]
		{
			typeof(LanguageSearchFilter),
			typeof(UnifiedRandom)
		}, ReturnType = typeof(LocalizedText))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LocalizedText), Member = "FormatWith", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static string CatChat(NPC npc)
		{
			throw null;
		}

		// Token: 0x06002638 RID: 9784 RVA: 0x00028CF7 File Offset: 0x00026EF7
		[global::Cpp2ILInjected.Token(Token = "0x600284E")]
		[global::Cpp2ILInjected.Address(RVA = "0x10DB5F4", Offset = "0x10DB5F4", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "GetChat", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lang), Member = "CreateDialogSubstitutionObject", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lang), Member = "CreateDialogFilter", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(LanguageSearchFilter))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "SelectRandom", MemberParameters = new object[]
		{
			typeof(LanguageSearchFilter),
			typeof(UnifiedRandom)
		}, ReturnType = typeof(LocalizedText))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LocalizedText), Member = "FormatWith", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static string DogChat(NPC npc)
		{
			throw null;
		}

		// Token: 0x06002639 RID: 9785 RVA: 0x00028CFA File Offset: 0x00026EFA
		[global::Cpp2ILInjected.Token(Token = "0x600284F")]
		[global::Cpp2ILInjected.Address(RVA = "0x10DB688", Offset = "0x10DB688", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "GetChat", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lang), Member = "CreateDialogSubstitutionObject", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lang), Member = "CreateDialogFilter", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(LanguageSearchFilter))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "SelectRandom", MemberParameters = new object[]
		{
			typeof(LanguageSearchFilter),
			typeof(UnifiedRandom)
		}, ReturnType = typeof(LocalizedText))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LocalizedText), Member = "FormatWith", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static string BunnyChat(NPC npc)
		{
			throw null;
		}

		// Token: 0x0600263A RID: 9786 RVA: 0x00028CFD File Offset: 0x00026EFD
		[global::Cpp2ILInjected.Token(Token = "0x6002850")]
		[global::Cpp2ILInjected.Address(RVA = "0x10DB71C", Offset = "0x10DB71C", Length = "0x160")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "GetChat", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lang), Member = "CreateDialogSubstitutionObject", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lang), Member = "CreateDialogFilter", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(LanguageSearchFilter))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "SelectRandom", MemberParameters = new object[]
		{
			typeof(LanguageSearchFilter),
			typeof(UnifiedRandom)
		}, ReturnType = typeof(LocalizedText))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LocalizedText), Member = "FormatWith", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public static string SlimeChat(NPC npc)
		{
			throw null;
		}

		// Token: 0x0600263B RID: 9787 RVA: 0x00028D00 File Offset: 0x00026F00
		[global::Cpp2ILInjected.Token(Token = "0x6002851")]
		[global::Cpp2ILInjected.Address(RVA = "0x10DB87C", Offset = "0x10DB87C", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawNPCHousesInWorld", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "get_FullName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static string GetNPCHouseBannerText(NPC npc, int bannerStyle)
		{
			throw null;
		}

		// Token: 0x0600263C RID: 9788 RVA: 0x00028D03 File Offset: 0x00026F03
		[global::Cpp2ILInjected.Token(Token = "0x6002852")]
		[global::Cpp2ILInjected.Address(RVA = "0x10DACAC", Offset = "0x10DACAC", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "GetChat", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "DyeTraderQuestChat", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "AnglerQuestCountChat", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "BartenderHelpText", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "BartenderChat", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "GolferChat", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "BestiaryGirlChat", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "PrincessChat", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "CatChat", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "DogChat", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "BunnyChat", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "SlimeChat", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "AnglerQuestChat", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HelpCommand), Member = "GetCommandAliasesByID", ReturnType = typeof(Dictionary<string, List<LocalizedText>>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 20)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lang.<>c__DisplayClass48_0), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LanguageSearchFilter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static LanguageSearchFilter CreateDialogFilter(string startsWith, object substitutions)
		{
			throw null;
		}

		// Token: 0x0600263D RID: 9789 RVA: 0x00028D06 File Offset: 0x00026F06
		[global::Cpp2ILInjected.Token(Token = "0x6002853")]
		[global::Cpp2ILInjected.Address(RVA = "0x10DB8F0", Offset = "0x10DB8F0", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "GetChat", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "HasLuckTextForWizard", MemberParameters = new object[] { typeof(ref string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "GetSpecialEventTextIfNotEmpty", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(ref string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lang.<>c__DisplayClass49_0), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LanguageSearchFilter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static LanguageSearchFilter CreateDialogFilter(string startsWith)
		{
			throw null;
		}

		// Token: 0x0600263E RID: 9790 RVA: 0x00028D09 File Offset: 0x00026F09
		[global::Cpp2ILInjected.Token(Token = "0x6002854")]
		[global::Cpp2ILInjected.Address(RVA = "0x10DB998", Offset = "0x10DB998", Length = "0x1B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUINPCDialogue), Member = "Option1Clicked", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lang), Member = "CreateDialogSubstitutionObject", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lang), Member = "CreateDialogFilter", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(LanguageSearchFilter))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "SelectRandom", MemberParameters = new object[]
		{
			typeof(LanguageSearchFilter),
			typeof(UnifiedRandom)
		}, ReturnType = typeof(LocalizedText))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LocalizedText), Member = "FormatWith", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_anglerQuestFinished", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_npcChatCornerItem", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IdDictionary), Member = "GetName", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValueWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public static string AnglerQuestChat(bool turnIn = false)
		{
			throw null;
		}

		// Token: 0x0600263F RID: 9791 RVA: 0x00028D0C File Offset: 0x00026F0C
		[global::Cpp2ILInjected.Token(Token = "0x6002855")]
		[global::Cpp2ILInjected.Address(RVA = "0x10DBB48", Offset = "0x10DBB48", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "get_Name", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "HandleMovement", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GolfHelper.ContactListener), Member = "PutBallInCup_TextAndEffects", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static LocalizedText GetProjectileName(int type)
		{
			throw null;
		}

		// Token: 0x06002640 RID: 9792 RVA: 0x00028D0F File Offset: 0x00026F0F
		[global::Cpp2ILInjected.Token(Token = "0x6002856")]
		[global::Cpp2ILInjected.Address(RVA = "0x158ED0C", Offset = "0x158ED0C", Length = "0x2E0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "InitializeLegacyLocalization", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToList", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = "System.Collections.Generic.List`1<TSource>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "ForEach", MemberParameters = new object[] { typeof(Action<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		private static void FillNameCacheArray<IdClass, IdType>(string category, LocalizedText[] nameCache, bool leaveMissingEntriesBlank = false) where IdType : IConvertible
		{
			throw null;
		}

		// Token: 0x06002641 RID: 9793 RVA: 0x00028D12 File Offset: 0x00026F12
		[global::Cpp2ILInjected.Token(Token = "0x6002857")]
		[global::Cpp2ILInjected.Address(RVA = "0x10DBC30", Offset = "0x10DBC30", Length = "0xF08")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Contains", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "get_PrimaryInputMode", ReturnType = typeof(XNAUnityRunner.ForcedInputMode))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(short), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Replace", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "get_UsingGamepad", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 88)]
		private static string ToopltipProcessor(short Id, string tooltip)
		{
			throw null;
		}

		// Token: 0x06002642 RID: 9794 RVA: 0x00028D15 File Offset: 0x00026F15
		[global::Cpp2ILInjected.Token(Token = "0x6002858")]
		[global::Cpp2ILInjected.Address(RVA = "0x10DCB38", Offset = "0x10DCB38", Length = "0x101C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main.<LoadContent_Deferred>d__1863", Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Program), Member = "LaunchGame", MemberParameters = new object[]
		{
			typeof(string[]),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lang[]), Member = "FillNameCacheArray", MemberTypeParameters = new object[]
		{
			typeof(object),
			typeof(int)
		}, MemberParameters = new object[]
		{
			typeof(string),
			typeof(LocalizedText[]),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(LocalizedText))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lang), Member = "FillNameCacheArray", MemberTypeParameters = new object[] { "IdClass", "IdType" }, MemberParameters = new object[]
		{
			typeof(string),
			typeof(LocalizedText[]),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCID), Member = "FromNetId", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TooltipProcessor), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemTooltip), Member = "AddGlobalProcessor", MemberParameters = new object[] { typeof(TooltipProcessor) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToList", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = "System.Collections.Generic.List`1<TSource>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "ForEach", MemberParameters = new object[] { typeof(Action<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 109)]
		public static void InitializeLegacyLocalization()
		{
			throw null;
		}

		// Token: 0x06002643 RID: 9795 RVA: 0x00028D18 File Offset: 0x00026F18
		[global::Cpp2ILInjected.Token(Token = "0x6002859")]
		[global::Cpp2ILInjected.Address(RVA = "0x10DDB54", Offset = "0x10DDB54", Length = "0x8A88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MapHelper), Member = "Initialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MapHelper), Member = "LookupCount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MapHelper), Member = "TileToLookup", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(LocalizedText))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 500)]
		public static void BuildMapAtlas()
		{
			throw null;
		}

		// Token: 0x06002644 RID: 9796 RVA: 0x00028D1B File Offset: 0x00026F1B
		[global::Cpp2ILInjected.Token(Token = "0x600285A")]
		[global::Cpp2ILInjected.Address(RVA = "0x10E65DC", Offset = "0x10E65DC", Length = "0xD00")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDeathReason), Member = "GetDeathText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(NetworkText))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lang), Member = "GetProjectileName", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(LocalizedText))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkText), Member = "FromKey", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(NetworkText))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "GetGivenOrTypeNetName", ReturnType = typeof(NetworkText))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkText), Member = "FromLiteral", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(NetworkText))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lang), Member = "GetItemName", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(LocalizedText))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "RandomFromCategory", MemberParameters = new object[]
		{
			typeof(string),
			typeof(UnifiedRandom)
		}, ReturnType = typeof(LocalizedText))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 108)]
		public static NetworkText CreateDeathMessage(string deadPlayerName, int plr = -1, int npc = -1, int proj = -1, int other = -1, int projType = 0, int plrItemType = 0)
		{
			throw null;
		}

		// Token: 0x06002645 RID: 9797 RVA: 0x00028D1E File Offset: 0x00026F1E
		[global::Cpp2ILInjected.Token(Token = "0x600285B")]
		[global::Cpp2ILInjected.Address(RVA = "0x10E72DC", Offset = "0x10E72DC", Length = "0x3A4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "startPumpkinMoon", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "startSnowMoon", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "CheckProgressFrostMoon", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "CheckProgressPumpkinMoon", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Event), Member = "UpdateTime", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lang), Member = "GetNPCName", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(LocalizedText))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkText), Member = "FromKey", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(NetworkText))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 32)]
		public static NetworkText GetInvasionWaveText(int wave, params short[] npcIds)
		{
			throw null;
		}

		// Token: 0x06002646 RID: 9798 RVA: 0x00028D21 File Offset: 0x00026F21
		[global::Cpp2ILInjected.Token(Token = "0x600285C")]
		[global::Cpp2ILInjected.Address(RVA = "0x10E7680", Offset = "0x10E7680", Length = "0x4CC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMap), Member = "DrawMap", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawBuffIcon", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameCulture), Member = "FromCultureName", MemberParameters = new object[] { typeof(GameCulture.CultureName) }, ReturnType = typeof(GameCulture))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameCulture), Member = "get_IsActive", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "get_Days", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "FromDays", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "op_GreaterThan", MemberParameters = new object[]
		{
			typeof(TimeSpan),
			typeof(TimeSpan)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "get_Hours", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "FromHours", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "get_Minutes", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "FromMinutes", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "get_Seconds", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		public static string LocalizedDuration(TimeSpan time, bool abbreviated, bool showAllAvailableUnits)
		{
			throw null;
		}

		// Token: 0x06002647 RID: 9799 RVA: 0x00028D24 File Offset: 0x00026F24
		[global::Cpp2ILInjected.Token(Token = "0x600285D")]
		[global::Cpp2ILInjected.Address(RVA = "0x10E7B4C", Offset = "0x10E7B4C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public Lang()
		{
			throw null;
		}

		// Token: 0x06002648 RID: 9800 RVA: 0x00028D27 File Offset: 0x00026F27
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600285E")]
		[global::Cpp2ILInjected.Address(RVA = "0x10E7B54", Offset = "0x10E7B54", Length = "0x294")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lang.SubstitutionsObject), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 26)]
		static Lang()
		{
			throw null;
		}

		// Token: 0x04002E3A RID: 11834
		[Obsolete("Lang arrays have been replaced with the new Language.GetText system.")]
		[global::Cpp2ILInjected.Token(Token = "0x400355F")]
		public static LocalizedText[] menu;

		// Token: 0x04002E3B RID: 11835
		[Obsolete("Lang arrays have been replaced with the new Language.GetText system.")]
		[global::Cpp2ILInjected.Token(Token = "0x4003560")]
		public static LocalizedText[] gen;

		// Token: 0x04002E3C RID: 11836
		[Obsolete("Lang arrays have been replaced with the new Language.GetText system.")]
		[global::Cpp2ILInjected.Token(Token = "0x4003561")]
		public static LocalizedText[] misc;

		// Token: 0x04002E3D RID: 11837
		[Obsolete("Lang arrays have been replaced with the new Language.GetText system.")]
		[global::Cpp2ILInjected.Token(Token = "0x4003562")]
		public static LocalizedText[] inter;

		// Token: 0x04002E3E RID: 11838
		[Obsolete("Lang arrays have been replaced with the new Language.GetText system.")]
		[global::Cpp2ILInjected.Token(Token = "0x4003563")]
		public static LocalizedText[] tip;

		// Token: 0x04002E3F RID: 11839
		[Obsolete("Lang arrays have been replaced with the new Language.GetText system.")]
		[global::Cpp2ILInjected.Token(Token = "0x4003564")]
		public static LocalizedText[] mp;

		// Token: 0x04002E40 RID: 11840
		[Obsolete("Lang arrays have been replaced with the new Language.GetText system.")]
		[global::Cpp2ILInjected.Token(Token = "0x4003565")]
		public static LocalizedText[] chestType;

		// Token: 0x04002E41 RID: 11841
		[Obsolete("Lang arrays have been replaced with the new Language.GetText system.")]
		[global::Cpp2ILInjected.Token(Token = "0x4003566")]
		public static LocalizedText[] dresserType;

		// Token: 0x04002E42 RID: 11842
		[Obsolete("Lang arrays have been replaced with the new Language.GetText system.")]
		[global::Cpp2ILInjected.Token(Token = "0x4003567")]
		public static LocalizedText[] chestType2;

		// Token: 0x04002E43 RID: 11843
		[global::Cpp2ILInjected.Token(Token = "0x4003568")]
		public static LocalizedText[] prefix;

		// Token: 0x04002E44 RID: 11844
		[global::Cpp2ILInjected.Token(Token = "0x4003569")]
		public static LocalizedText[] _mapLegendCache;

		// Token: 0x04002E45 RID: 11845
		[global::Cpp2ILInjected.Token(Token = "0x400356A")]
		public static LocalizedText[] mobile;

		// Token: 0x04002E46 RID: 11846
		[global::Cpp2ILInjected.Token(Token = "0x400356B")]
		private static LocalizedText[] _itemNameCache;

		// Token: 0x04002E47 RID: 11847
		[global::Cpp2ILInjected.Token(Token = "0x400356C")]
		private static LocalizedText[] _projectileNameCache;

		// Token: 0x04002E48 RID: 11848
		[global::Cpp2ILInjected.Token(Token = "0x400356D")]
		private static LocalizedText[] _npcNameCache;

		// Token: 0x04002E49 RID: 11849
		[global::Cpp2ILInjected.Token(Token = "0x400356E")]
		private static LocalizedText[] _negativeNpcNameCache;

		// Token: 0x04002E4A RID: 11850
		[global::Cpp2ILInjected.Token(Token = "0x400356F")]
		private static LocalizedText[] _buffNameCache;

		// Token: 0x04002E4B RID: 11851
		[global::Cpp2ILInjected.Token(Token = "0x4003570")]
		private static LocalizedText[] _buffDescriptionCache;

		// Token: 0x04002E4C RID: 11852
		[global::Cpp2ILInjected.Token(Token = "0x4003571")]
		private static ItemTooltip[] _itemTooltipCache;

		// Token: 0x04002E4D RID: 11853
		[global::Cpp2ILInjected.Token(Token = "0x4003572")]
		private static LocalizedText[] _emojiNameCache;

		// Token: 0x04002E4E RID: 11854
		[global::Cpp2ILInjected.Token(Token = "0x4003573")]
		private static Lang.SubstitutionsObject SubstitutionsObjectValue;

		// Token: 0x0200085F RID: 2143
		[global::Cpp2ILInjected.Token(Token = "0x2000437")]
		public class SubstitutionsObject
		{
			// Token: 0x17000854 RID: 2132
			// (get) Token: 0x060049E1 RID: 18913 RVA: 0x0002F174 File Offset: 0x0002D374
			// (set) Token: 0x060049E2 RID: 18914 RVA: 0x0002F177 File Offset: 0x0002D377
			[global::Cpp2ILInjected.Token(Token = "0x1700056E")]
			public string Nurse
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x600285F")]
				[global::Cpp2ILInjected.Address(RVA = "0x1153FE8", Offset = "0x1153FE8", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6002860")]
				[global::Cpp2ILInjected.Address(RVA = "0x1153FF0", Offset = "0x1153FF0", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x17000855 RID: 2133
			// (get) Token: 0x060049E3 RID: 18915 RVA: 0x0002F17A File Offset: 0x0002D37A
			// (set) Token: 0x060049E4 RID: 18916 RVA: 0x0002F17D File Offset: 0x0002D37D
			[global::Cpp2ILInjected.Token(Token = "0x1700056F")]
			public string Merchant
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6002861")]
				[global::Cpp2ILInjected.Address(RVA = "0x1153FF8", Offset = "0x1153FF8", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6002862")]
				[global::Cpp2ILInjected.Address(RVA = "0x1154000", Offset = "0x1154000", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x17000856 RID: 2134
			// (get) Token: 0x060049E5 RID: 18917 RVA: 0x0002F180 File Offset: 0x0002D380
			// (set) Token: 0x060049E6 RID: 18918 RVA: 0x0002F183 File Offset: 0x0002D383
			[global::Cpp2ILInjected.Token(Token = "0x17000570")]
			public string ArmsDealer
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6002863")]
				[global::Cpp2ILInjected.Address(RVA = "0x1154008", Offset = "0x1154008", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6002864")]
				[global::Cpp2ILInjected.Address(RVA = "0x1154010", Offset = "0x1154010", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x17000857 RID: 2135
			// (get) Token: 0x060049E7 RID: 18919 RVA: 0x0002F186 File Offset: 0x0002D386
			// (set) Token: 0x060049E8 RID: 18920 RVA: 0x0002F189 File Offset: 0x0002D389
			[global::Cpp2ILInjected.Token(Token = "0x17000571")]
			public string Dryad
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6002865")]
				[global::Cpp2ILInjected.Address(RVA = "0x1154018", Offset = "0x1154018", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6002866")]
				[global::Cpp2ILInjected.Address(RVA = "0x1154020", Offset = "0x1154020", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x17000858 RID: 2136
			// (get) Token: 0x060049E9 RID: 18921 RVA: 0x0002F18C File Offset: 0x0002D38C
			// (set) Token: 0x060049EA RID: 18922 RVA: 0x0002F18F File Offset: 0x0002D38F
			[global::Cpp2ILInjected.Token(Token = "0x17000572")]
			public string Demolitionist
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6002867")]
				[global::Cpp2ILInjected.Address(RVA = "0x1154028", Offset = "0x1154028", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6002868")]
				[global::Cpp2ILInjected.Address(RVA = "0x1154030", Offset = "0x1154030", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x17000859 RID: 2137
			// (get) Token: 0x060049EB RID: 18923 RVA: 0x0002F192 File Offset: 0x0002D392
			// (set) Token: 0x060049EC RID: 18924 RVA: 0x0002F195 File Offset: 0x0002D395
			[global::Cpp2ILInjected.Token(Token = "0x17000573")]
			public string Clothier
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6002869")]
				[global::Cpp2ILInjected.Address(RVA = "0x1154038", Offset = "0x1154038", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x600286A")]
				[global::Cpp2ILInjected.Address(RVA = "0x1154040", Offset = "0x1154040", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x1700085A RID: 2138
			// (get) Token: 0x060049ED RID: 18925 RVA: 0x0002F198 File Offset: 0x0002D398
			// (set) Token: 0x060049EE RID: 18926 RVA: 0x0002F19B File Offset: 0x0002D39B
			[global::Cpp2ILInjected.Token(Token = "0x17000574")]
			public string Guide
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x600286B")]
				[global::Cpp2ILInjected.Address(RVA = "0x1154048", Offset = "0x1154048", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x600286C")]
				[global::Cpp2ILInjected.Address(RVA = "0x1154050", Offset = "0x1154050", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x1700085B RID: 2139
			// (get) Token: 0x060049EF RID: 18927 RVA: 0x0002F19E File Offset: 0x0002D39E
			// (set) Token: 0x060049F0 RID: 18928 RVA: 0x0002F1A1 File Offset: 0x0002D3A1
			[global::Cpp2ILInjected.Token(Token = "0x17000575")]
			public string Wizard
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x600286D")]
				[global::Cpp2ILInjected.Address(RVA = "0x1154058", Offset = "0x1154058", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x600286E")]
				[global::Cpp2ILInjected.Address(RVA = "0x1154060", Offset = "0x1154060", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x1700085C RID: 2140
			// (get) Token: 0x060049F1 RID: 18929 RVA: 0x0002F1A4 File Offset: 0x0002D3A4
			// (set) Token: 0x060049F2 RID: 18930 RVA: 0x0002F1A7 File Offset: 0x0002D3A7
			[global::Cpp2ILInjected.Token(Token = "0x17000576")]
			public string GoblinTinkerer
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x600286F")]
				[global::Cpp2ILInjected.Address(RVA = "0x1154068", Offset = "0x1154068", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6002870")]
				[global::Cpp2ILInjected.Address(RVA = "0x1154070", Offset = "0x1154070", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x1700085D RID: 2141
			// (get) Token: 0x060049F3 RID: 18931 RVA: 0x0002F1AA File Offset: 0x0002D3AA
			// (set) Token: 0x060049F4 RID: 18932 RVA: 0x0002F1AD File Offset: 0x0002D3AD
			[global::Cpp2ILInjected.Token(Token = "0x17000577")]
			public string Mechanic
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6002871")]
				[global::Cpp2ILInjected.Address(RVA = "0x1154078", Offset = "0x1154078", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6002872")]
				[global::Cpp2ILInjected.Address(RVA = "0x1154080", Offset = "0x1154080", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x1700085E RID: 2142
			// (get) Token: 0x060049F5 RID: 18933 RVA: 0x0002F1B0 File Offset: 0x0002D3B0
			// (set) Token: 0x060049F6 RID: 18934 RVA: 0x0002F1B3 File Offset: 0x0002D3B3
			[global::Cpp2ILInjected.Token(Token = "0x17000578")]
			public string Truffle
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6002873")]
				[global::Cpp2ILInjected.Address(RVA = "0x1154088", Offset = "0x1154088", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6002874")]
				[global::Cpp2ILInjected.Address(RVA = "0x1154090", Offset = "0x1154090", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x1700085F RID: 2143
			// (get) Token: 0x060049F7 RID: 18935 RVA: 0x0002F1B6 File Offset: 0x0002D3B6
			// (set) Token: 0x060049F8 RID: 18936 RVA: 0x0002F1B9 File Offset: 0x0002D3B9
			[global::Cpp2ILInjected.Token(Token = "0x17000579")]
			public string Steampunker
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6002875")]
				[global::Cpp2ILInjected.Address(RVA = "0x1154098", Offset = "0x1154098", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6002876")]
				[global::Cpp2ILInjected.Address(RVA = "0x11540A0", Offset = "0x11540A0", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x17000860 RID: 2144
			// (get) Token: 0x060049F9 RID: 18937 RVA: 0x0002F1BC File Offset: 0x0002D3BC
			// (set) Token: 0x060049FA RID: 18938 RVA: 0x0002F1BF File Offset: 0x0002D3BF
			[global::Cpp2ILInjected.Token(Token = "0x1700057A")]
			public string DyeTrader
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6002877")]
				[global::Cpp2ILInjected.Address(RVA = "0x11540A8", Offset = "0x11540A8", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6002878")]
				[global::Cpp2ILInjected.Address(RVA = "0x11540B0", Offset = "0x11540B0", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x17000861 RID: 2145
			// (get) Token: 0x060049FB RID: 18939 RVA: 0x0002F1C2 File Offset: 0x0002D3C2
			// (set) Token: 0x060049FC RID: 18940 RVA: 0x0002F1C5 File Offset: 0x0002D3C5
			[global::Cpp2ILInjected.Token(Token = "0x1700057B")]
			public string PartyGirl
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6002879")]
				[global::Cpp2ILInjected.Address(RVA = "0x11540B8", Offset = "0x11540B8", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x600287A")]
				[global::Cpp2ILInjected.Address(RVA = "0x11540C0", Offset = "0x11540C0", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x17000862 RID: 2146
			// (get) Token: 0x060049FD RID: 18941 RVA: 0x0002F1C8 File Offset: 0x0002D3C8
			// (set) Token: 0x060049FE RID: 18942 RVA: 0x0002F1CB File Offset: 0x0002D3CB
			[global::Cpp2ILInjected.Token(Token = "0x1700057C")]
			public string Cyborg
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x600287B")]
				[global::Cpp2ILInjected.Address(RVA = "0x11540C8", Offset = "0x11540C8", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x600287C")]
				[global::Cpp2ILInjected.Address(RVA = "0x11540D0", Offset = "0x11540D0", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x17000863 RID: 2147
			// (get) Token: 0x060049FF RID: 18943 RVA: 0x0002F1CE File Offset: 0x0002D3CE
			// (set) Token: 0x06004A00 RID: 18944 RVA: 0x0002F1D1 File Offset: 0x0002D3D1
			[global::Cpp2ILInjected.Token(Token = "0x1700057D")]
			public string Painter
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x600287D")]
				[global::Cpp2ILInjected.Address(RVA = "0x11540D8", Offset = "0x11540D8", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x600287E")]
				[global::Cpp2ILInjected.Address(RVA = "0x11540E0", Offset = "0x11540E0", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x17000864 RID: 2148
			// (get) Token: 0x06004A01 RID: 18945 RVA: 0x0002F1D4 File Offset: 0x0002D3D4
			// (set) Token: 0x06004A02 RID: 18946 RVA: 0x0002F1D7 File Offset: 0x0002D3D7
			[global::Cpp2ILInjected.Token(Token = "0x1700057E")]
			public string WitchDoctor
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x600287F")]
				[global::Cpp2ILInjected.Address(RVA = "0x11540E8", Offset = "0x11540E8", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6002880")]
				[global::Cpp2ILInjected.Address(RVA = "0x11540F0", Offset = "0x11540F0", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x17000865 RID: 2149
			// (get) Token: 0x06004A03 RID: 18947 RVA: 0x0002F1DA File Offset: 0x0002D3DA
			// (set) Token: 0x06004A04 RID: 18948 RVA: 0x0002F1DD File Offset: 0x0002D3DD
			[global::Cpp2ILInjected.Token(Token = "0x1700057F")]
			public string Pirate
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6002881")]
				[global::Cpp2ILInjected.Address(RVA = "0x11540F8", Offset = "0x11540F8", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6002882")]
				[global::Cpp2ILInjected.Address(RVA = "0x1154100", Offset = "0x1154100", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x17000866 RID: 2150
			// (get) Token: 0x06004A05 RID: 18949 RVA: 0x0002F1E0 File Offset: 0x0002D3E0
			// (set) Token: 0x06004A06 RID: 18950 RVA: 0x0002F1E3 File Offset: 0x0002D3E3
			[global::Cpp2ILInjected.Token(Token = "0x17000580")]
			public string Stylist
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6002883")]
				[global::Cpp2ILInjected.Address(RVA = "0x1154108", Offset = "0x1154108", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6002884")]
				[global::Cpp2ILInjected.Address(RVA = "0x1154110", Offset = "0x1154110", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x17000867 RID: 2151
			// (get) Token: 0x06004A07 RID: 18951 RVA: 0x0002F1E6 File Offset: 0x0002D3E6
			// (set) Token: 0x06004A08 RID: 18952 RVA: 0x0002F1E9 File Offset: 0x0002D3E9
			[global::Cpp2ILInjected.Token(Token = "0x17000581")]
			public string TravelingMerchant
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6002885")]
				[global::Cpp2ILInjected.Address(RVA = "0x1154118", Offset = "0x1154118", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6002886")]
				[global::Cpp2ILInjected.Address(RVA = "0x1154120", Offset = "0x1154120", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x17000868 RID: 2152
			// (get) Token: 0x06004A09 RID: 18953 RVA: 0x0002F1EC File Offset: 0x0002D3EC
			// (set) Token: 0x06004A0A RID: 18954 RVA: 0x0002F1EF File Offset: 0x0002D3EF
			[global::Cpp2ILInjected.Token(Token = "0x17000582")]
			public string Angler
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6002887")]
				[global::Cpp2ILInjected.Address(RVA = "0x1154128", Offset = "0x1154128", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6002888")]
				[global::Cpp2ILInjected.Address(RVA = "0x1154130", Offset = "0x1154130", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x17000869 RID: 2153
			// (get) Token: 0x06004A0B RID: 18955 RVA: 0x0002F1F2 File Offset: 0x0002D3F2
			// (set) Token: 0x06004A0C RID: 18956 RVA: 0x0002F1F5 File Offset: 0x0002D3F5
			[global::Cpp2ILInjected.Token(Token = "0x17000583")]
			public string Bartender
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6002889")]
				[global::Cpp2ILInjected.Address(RVA = "0x1154138", Offset = "0x1154138", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x600288A")]
				[global::Cpp2ILInjected.Address(RVA = "0x1154140", Offset = "0x1154140", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x1700086A RID: 2154
			// (get) Token: 0x06004A0D RID: 18957 RVA: 0x0002F1F8 File Offset: 0x0002D3F8
			// (set) Token: 0x06004A0E RID: 18958 RVA: 0x0002F1FB File Offset: 0x0002D3FB
			[global::Cpp2ILInjected.Token(Token = "0x17000584")]
			public string WorldName
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x600288B")]
				[global::Cpp2ILInjected.Address(RVA = "0x1154148", Offset = "0x1154148", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x600288C")]
				[global::Cpp2ILInjected.Address(RVA = "0x1154150", Offset = "0x1154150", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x1700086B RID: 2155
			// (get) Token: 0x06004A0F RID: 18959 RVA: 0x0002F1FE File Offset: 0x0002D3FE
			// (set) Token: 0x06004A10 RID: 18960 RVA: 0x0002F201 File Offset: 0x0002D401
			[global::Cpp2ILInjected.Token(Token = "0x17000585")]
			public bool Day
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x600288D")]
				[global::Cpp2ILInjected.Address(RVA = "0x1154158", Offset = "0x1154158", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x600288E")]
				[global::Cpp2ILInjected.Address(RVA = "0x1154160", Offset = "0x1154160", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x1700086C RID: 2156
			// (get) Token: 0x06004A11 RID: 18961 RVA: 0x0002F204 File Offset: 0x0002D404
			// (set) Token: 0x06004A12 RID: 18962 RVA: 0x0002F207 File Offset: 0x0002D407
			[global::Cpp2ILInjected.Token(Token = "0x17000586")]
			public bool BloodMoon
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x600288F")]
				[global::Cpp2ILInjected.Address(RVA = "0x115416C", Offset = "0x115416C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6002890")]
				[global::Cpp2ILInjected.Address(RVA = "0x1154174", Offset = "0x1154174", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x1700086D RID: 2157
			// (get) Token: 0x06004A13 RID: 18963 RVA: 0x0002F20A File Offset: 0x0002D40A
			// (set) Token: 0x06004A14 RID: 18964 RVA: 0x0002F20D File Offset: 0x0002D40D
			[global::Cpp2ILInjected.Token(Token = "0x17000587")]
			public bool Eclipse
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6002891")]
				[global::Cpp2ILInjected.Address(RVA = "0x1154180", Offset = "0x1154180", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6002892")]
				[global::Cpp2ILInjected.Address(RVA = "0x1154188", Offset = "0x1154188", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x1700086E RID: 2158
			// (get) Token: 0x06004A15 RID: 18965 RVA: 0x0002F210 File Offset: 0x0002D410
			// (set) Token: 0x06004A16 RID: 18966 RVA: 0x0002F213 File Offset: 0x0002D413
			[global::Cpp2ILInjected.Token(Token = "0x17000588")]
			public bool MoonLordDefeated
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6002893")]
				[global::Cpp2ILInjected.Address(RVA = "0x1154194", Offset = "0x1154194", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6002894")]
				[global::Cpp2ILInjected.Address(RVA = "0x115419C", Offset = "0x115419C", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x1700086F RID: 2159
			// (get) Token: 0x06004A17 RID: 18967 RVA: 0x0002F216 File Offset: 0x0002D416
			// (set) Token: 0x06004A18 RID: 18968 RVA: 0x0002F219 File Offset: 0x0002D419
			[global::Cpp2ILInjected.Token(Token = "0x17000589")]
			public bool GolemDefeated
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6002895")]
				[global::Cpp2ILInjected.Address(RVA = "0x11541A8", Offset = "0x11541A8", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6002896")]
				[global::Cpp2ILInjected.Address(RVA = "0x11541B0", Offset = "0x11541B0", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x17000870 RID: 2160
			// (get) Token: 0x06004A19 RID: 18969 RVA: 0x0002F21C File Offset: 0x0002D41C
			// (set) Token: 0x06004A1A RID: 18970 RVA: 0x0002F21F File Offset: 0x0002D41F
			[global::Cpp2ILInjected.Token(Token = "0x1700058A")]
			public bool DukeFishronDefeated
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6002897")]
				[global::Cpp2ILInjected.Address(RVA = "0x11541BC", Offset = "0x11541BC", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6002898")]
				[global::Cpp2ILInjected.Address(RVA = "0x11541C4", Offset = "0x11541C4", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x17000871 RID: 2161
			// (get) Token: 0x06004A1B RID: 18971 RVA: 0x0002F222 File Offset: 0x0002D422
			// (set) Token: 0x06004A1C RID: 18972 RVA: 0x0002F225 File Offset: 0x0002D425
			[global::Cpp2ILInjected.Token(Token = "0x1700058B")]
			public bool FrostLegionDefeated
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6002899")]
				[global::Cpp2ILInjected.Address(RVA = "0x11541D0", Offset = "0x11541D0", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x600289A")]
				[global::Cpp2ILInjected.Address(RVA = "0x11541D8", Offset = "0x11541D8", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x17000872 RID: 2162
			// (get) Token: 0x06004A1D RID: 18973 RVA: 0x0002F228 File Offset: 0x0002D428
			// (set) Token: 0x06004A1E RID: 18974 RVA: 0x0002F22B File Offset: 0x0002D42B
			[global::Cpp2ILInjected.Token(Token = "0x1700058C")]
			public bool MartiansDefeated
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x600289B")]
				[global::Cpp2ILInjected.Address(RVA = "0x11541E4", Offset = "0x11541E4", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x600289C")]
				[global::Cpp2ILInjected.Address(RVA = "0x11541EC", Offset = "0x11541EC", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x17000873 RID: 2163
			// (get) Token: 0x06004A1F RID: 18975 RVA: 0x0002F22E File Offset: 0x0002D42E
			// (set) Token: 0x06004A20 RID: 18976 RVA: 0x0002F231 File Offset: 0x0002D431
			[global::Cpp2ILInjected.Token(Token = "0x1700058D")]
			public bool PumpkingDefeated
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x600289D")]
				[global::Cpp2ILInjected.Address(RVA = "0x11541F8", Offset = "0x11541F8", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x600289E")]
				[global::Cpp2ILInjected.Address(RVA = "0x1154200", Offset = "0x1154200", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x17000874 RID: 2164
			// (get) Token: 0x06004A21 RID: 18977 RVA: 0x0002F234 File Offset: 0x0002D434
			// (set) Token: 0x06004A22 RID: 18978 RVA: 0x0002F237 File Offset: 0x0002D437
			[global::Cpp2ILInjected.Token(Token = "0x1700058E")]
			public bool IceQueenDefeated
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x600289F")]
				[global::Cpp2ILInjected.Address(RVA = "0x115420C", Offset = "0x115420C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x60028A0")]
				[global::Cpp2ILInjected.Address(RVA = "0x1154214", Offset = "0x1154214", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x17000875 RID: 2165
			// (get) Token: 0x06004A23 RID: 18979 RVA: 0x0002F23A File Offset: 0x0002D43A
			// (set) Token: 0x06004A24 RID: 18980 RVA: 0x0002F23D File Offset: 0x0002D43D
			[global::Cpp2ILInjected.Token(Token = "0x1700058F")]
			public bool HardMode
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x60028A1")]
				[global::Cpp2ILInjected.Address(RVA = "0x1154220", Offset = "0x1154220", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x60028A2")]
				[global::Cpp2ILInjected.Address(RVA = "0x1154228", Offset = "0x1154228", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x17000876 RID: 2166
			// (get) Token: 0x06004A25 RID: 18981 RVA: 0x0002F240 File Offset: 0x0002D440
			// (set) Token: 0x06004A26 RID: 18982 RVA: 0x0002F243 File Offset: 0x0002D443
			[global::Cpp2ILInjected.Token(Token = "0x17000590")]
			public bool Homeless
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x60028A3")]
				[global::Cpp2ILInjected.Address(RVA = "0x1154234", Offset = "0x1154234", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x60028A4")]
				[global::Cpp2ILInjected.Address(RVA = "0x115423C", Offset = "0x115423C", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x17000877 RID: 2167
			// (get) Token: 0x06004A27 RID: 18983 RVA: 0x0002F246 File Offset: 0x0002D446
			// (set) Token: 0x06004A28 RID: 18984 RVA: 0x0002F249 File Offset: 0x0002D449
			[global::Cpp2ILInjected.Token(Token = "0x17000591")]
			public string InventoryKey
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x60028A5")]
				[global::Cpp2ILInjected.Address(RVA = "0x1154248", Offset = "0x1154248", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x60028A6")]
				[global::Cpp2ILInjected.Address(RVA = "0x1154250", Offset = "0x1154250", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x17000878 RID: 2168
			// (get) Token: 0x06004A29 RID: 18985 RVA: 0x0002F24C File Offset: 0x0002D44C
			// (set) Token: 0x06004A2A RID: 18986 RVA: 0x0002F24F File Offset: 0x0002D44F
			[global::Cpp2ILInjected.Token(Token = "0x17000592")]
			public string PlayerName
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x60028A7")]
				[global::Cpp2ILInjected.Address(RVA = "0x1154258", Offset = "0x1154258", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x60028A8")]
				[global::Cpp2ILInjected.Address(RVA = "0x1154260", Offset = "0x1154260", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x17000879 RID: 2169
			// (get) Token: 0x06004A2B RID: 18987 RVA: 0x0002F252 File Offset: 0x0002D452
			// (set) Token: 0x06004A2C RID: 18988 RVA: 0x0002F255 File Offset: 0x0002D455
			[global::Cpp2ILInjected.Token(Token = "0x17000593")]
			public string GolfGuy
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x60028A9")]
				[global::Cpp2ILInjected.Address(RVA = "0x1154268", Offset = "0x1154268", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x60028AA")]
				[global::Cpp2ILInjected.Address(RVA = "0x1154270", Offset = "0x1154270", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x1700087A RID: 2170
			// (get) Token: 0x06004A2D RID: 18989 RVA: 0x0002F258 File Offset: 0x0002D458
			// (set) Token: 0x06004A2E RID: 18990 RVA: 0x0002F25B File Offset: 0x0002D45B
			[global::Cpp2ILInjected.Token(Token = "0x17000594")]
			public string TaxCollector
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x60028AB")]
				[global::Cpp2ILInjected.Address(RVA = "0x1154278", Offset = "0x1154278", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x60028AC")]
				[global::Cpp2ILInjected.Address(RVA = "0x1154280", Offset = "0x1154280", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x1700087B RID: 2171
			// (get) Token: 0x06004A2F RID: 18991 RVA: 0x0002F25E File Offset: 0x0002D45E
			// (set) Token: 0x06004A30 RID: 18992 RVA: 0x0002F261 File Offset: 0x0002D461
			[global::Cpp2ILInjected.Token(Token = "0x17000595")]
			public bool Rain
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x60028AD")]
				[global::Cpp2ILInjected.Address(RVA = "0x1154288", Offset = "0x1154288", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x60028AE")]
				[global::Cpp2ILInjected.Address(RVA = "0x1154290", Offset = "0x1154290", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x1700087C RID: 2172
			// (get) Token: 0x06004A31 RID: 18993 RVA: 0x0002F264 File Offset: 0x0002D464
			// (set) Token: 0x06004A32 RID: 18994 RVA: 0x0002F267 File Offset: 0x0002D467
			[global::Cpp2ILInjected.Token(Token = "0x17000596")]
			public bool Graveyard
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x60028AF")]
				[global::Cpp2ILInjected.Address(RVA = "0x115429C", Offset = "0x115429C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x60028B0")]
				[global::Cpp2ILInjected.Address(RVA = "0x11542A4", Offset = "0x11542A4", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x1700087D RID: 2173
			// (get) Token: 0x06004A33 RID: 18995 RVA: 0x0002F26A File Offset: 0x0002D46A
			// (set) Token: 0x06004A34 RID: 18996 RVA: 0x0002F26D File Offset: 0x0002D46D
			[global::Cpp2ILInjected.Token(Token = "0x17000597")]
			public int AnglerCompletedQuestsCount
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x60028B1")]
				[global::Cpp2ILInjected.Address(RVA = "0x11542B0", Offset = "0x11542B0", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x60028B2")]
				[global::Cpp2ILInjected.Address(RVA = "0x11542B8", Offset = "0x11542B8", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x1700087E RID: 2174
			// (get) Token: 0x06004A35 RID: 18997 RVA: 0x0002F270 File Offset: 0x0002D470
			// (set) Token: 0x06004A36 RID: 18998 RVA: 0x0002F273 File Offset: 0x0002D473
			[global::Cpp2ILInjected.Token(Token = "0x17000598")]
			public int TotalDeathsCount
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x60028B3")]
				[global::Cpp2ILInjected.Address(RVA = "0x11542C0", Offset = "0x11542C0", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x60028B4")]
				[global::Cpp2ILInjected.Address(RVA = "0x11542C8", Offset = "0x11542C8", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x1700087F RID: 2175
			// (get) Token: 0x06004A37 RID: 18999 RVA: 0x0002F276 File Offset: 0x0002D476
			// (set) Token: 0x06004A38 RID: 19000 RVA: 0x0002F279 File Offset: 0x0002D479
			[global::Cpp2ILInjected.Token(Token = "0x17000599")]
			public string WorldEvilStone
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x60028B5")]
				[global::Cpp2ILInjected.Address(RVA = "0x11542D0", Offset = "0x11542D0", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x60028B6")]
				[global::Cpp2ILInjected.Address(RVA = "0x11542D8", Offset = "0x11542D8", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x17000880 RID: 2176
			// (get) Token: 0x06004A39 RID: 19001 RVA: 0x0002F27C File Offset: 0x0002D47C
			// (set) Token: 0x06004A3A RID: 19002 RVA: 0x0002F27F File Offset: 0x0002D47F
			[global::Cpp2ILInjected.Token(Token = "0x1700059A")]
			public string InputTriggerUI_BuildFromInventory
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x60028B7")]
				[global::Cpp2ILInjected.Address(RVA = "0x11542E0", Offset = "0x11542E0", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x60028B8")]
				[global::Cpp2ILInjected.Address(RVA = "0x11542E8", Offset = "0x11542E8", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x17000881 RID: 2177
			// (get) Token: 0x06004A3B RID: 19003 RVA: 0x0002F282 File Offset: 0x0002D482
			// (set) Token: 0x06004A3C RID: 19004 RVA: 0x0002F285 File Offset: 0x0002D485
			[global::Cpp2ILInjected.Token(Token = "0x1700059B")]
			public string InputTriggerUI_SellItem
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x60028B9")]
				[global::Cpp2ILInjected.Address(RVA = "0x11542F0", Offset = "0x11542F0", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x60028BA")]
				[global::Cpp2ILInjected.Address(RVA = "0x11542F8", Offset = "0x11542F8", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x17000882 RID: 2178
			// (get) Token: 0x06004A3D RID: 19005 RVA: 0x0002F288 File Offset: 0x0002D488
			// (set) Token: 0x06004A3E RID: 19006 RVA: 0x0002F28B File Offset: 0x0002D48B
			[global::Cpp2ILInjected.Token(Token = "0x1700059C")]
			public string InputTriggerUI_Trash
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x60028BB")]
				[global::Cpp2ILInjected.Address(RVA = "0x1154300", Offset = "0x1154300", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x60028BC")]
				[global::Cpp2ILInjected.Address(RVA = "0x1154308", Offset = "0x1154308", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x17000883 RID: 2179
			// (get) Token: 0x06004A3F RID: 19007 RVA: 0x0002F28E File Offset: 0x0002D48E
			// (set) Token: 0x06004A40 RID: 19008 RVA: 0x0002F291 File Offset: 0x0002D491
			[global::Cpp2ILInjected.Token(Token = "0x1700059D")]
			public string InputTriggerUI_FavoriteItem
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x60028BD")]
				[global::Cpp2ILInjected.Address(RVA = "0x1154310", Offset = "0x1154310", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x60028BE")]
				[global::Cpp2ILInjected.Address(RVA = "0x1154318", Offset = "0x1154318", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x17000884 RID: 2180
			// (get) Token: 0x06004A41 RID: 19009 RVA: 0x0002F294 File Offset: 0x0002D494
			// (set) Token: 0x06004A42 RID: 19010 RVA: 0x0002F297 File Offset: 0x0002D497
			[global::Cpp2ILInjected.Token(Token = "0x1700059E")]
			public string InputTriggerUI_ZoomIn
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x60028BF")]
				[global::Cpp2ILInjected.Address(RVA = "0x1154320", Offset = "0x1154320", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x60028C0")]
				[global::Cpp2ILInjected.Address(RVA = "0x1154328", Offset = "0x1154328", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x17000885 RID: 2181
			// (get) Token: 0x06004A43 RID: 19011 RVA: 0x0002F29A File Offset: 0x0002D49A
			// (set) Token: 0x06004A44 RID: 19012 RVA: 0x0002F29D File Offset: 0x0002D49D
			[global::Cpp2ILInjected.Token(Token = "0x1700059F")]
			public string InputTriggerUI_ZoomOut
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x60028C1")]
				[global::Cpp2ILInjected.Address(RVA = "0x1154330", Offset = "0x1154330", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x60028C2")]
				[global::Cpp2ILInjected.Address(RVA = "0x1154338", Offset = "0x1154338", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x17000886 RID: 2182
			// (get) Token: 0x06004A45 RID: 19013 RVA: 0x0002F2A0 File Offset: 0x0002D4A0
			// (set) Token: 0x06004A46 RID: 19014 RVA: 0x0002F2A3 File Offset: 0x0002D4A3
			[global::Cpp2ILInjected.Token(Token = "0x170005A0")]
			public string InputTrigger_QuickEquip
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x60028C3")]
				[global::Cpp2ILInjected.Address(RVA = "0x1154340", Offset = "0x1154340", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x60028C4")]
				[global::Cpp2ILInjected.Address(RVA = "0x1154348", Offset = "0x1154348", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x17000887 RID: 2183
			// (get) Token: 0x06004A47 RID: 19015 RVA: 0x0002F2A6 File Offset: 0x0002D4A6
			// (set) Token: 0x06004A48 RID: 19016 RVA: 0x0002F2A9 File Offset: 0x0002D4A9
			[global::Cpp2ILInjected.Token(Token = "0x170005A1")]
			public string InputTrigger_LockOn
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x60028C5")]
				[global::Cpp2ILInjected.Address(RVA = "0x1154350", Offset = "0x1154350", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x60028C6")]
				[global::Cpp2ILInjected.Address(RVA = "0x1154358", Offset = "0x1154358", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x17000888 RID: 2184
			// (get) Token: 0x06004A49 RID: 19017 RVA: 0x0002F2AC File Offset: 0x0002D4AC
			// (set) Token: 0x06004A4A RID: 19018 RVA: 0x0002F2AF File Offset: 0x0002D4AF
			[global::Cpp2ILInjected.Token(Token = "0x170005A2")]
			public string InputTrigger_SmartCursor
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x60028C7")]
				[global::Cpp2ILInjected.Address(RVA = "0x1154360", Offset = "0x1154360", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x60028C8")]
				[global::Cpp2ILInjected.Address(RVA = "0x1154368", Offset = "0x1154368", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x17000889 RID: 2185
			// (get) Token: 0x06004A4B RID: 19019 RVA: 0x0002F2B2 File Offset: 0x0002D4B2
			// (set) Token: 0x06004A4C RID: 19020 RVA: 0x0002F2B5 File Offset: 0x0002D4B5
			[global::Cpp2ILInjected.Token(Token = "0x170005A3")]
			public string InputTrigger_UseOrAttack
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x60028C9")]
				[global::Cpp2ILInjected.Address(RVA = "0x1154370", Offset = "0x1154370", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x60028CA")]
				[global::Cpp2ILInjected.Address(RVA = "0x1154378", Offset = "0x1154378", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x1700088A RID: 2186
			// (get) Token: 0x06004A4D RID: 19021 RVA: 0x0002F2B8 File Offset: 0x0002D4B8
			// (set) Token: 0x06004A4E RID: 19022 RVA: 0x0002F2BB File Offset: 0x0002D4BB
			[global::Cpp2ILInjected.Token(Token = "0x170005A4")]
			public string InputTrigger_InteractWithTile
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x60028CB")]
				[global::Cpp2ILInjected.Address(RVA = "0x1154380", Offset = "0x1154380", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x60028CC")]
				[global::Cpp2ILInjected.Address(RVA = "0x1154388", Offset = "0x1154388", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x1700088B RID: 2187
			// (get) Token: 0x06004A4F RID: 19023 RVA: 0x0002F2BE File Offset: 0x0002D4BE
			// (set) Token: 0x06004A50 RID: 19024 RVA: 0x0002F2C1 File Offset: 0x0002D4C1
			[global::Cpp2ILInjected.Token(Token = "0x170005A5")]
			public string InputTrigger_SmartSelect
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x60028CD")]
				[global::Cpp2ILInjected.Address(RVA = "0x1154390", Offset = "0x1154390", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x60028CE")]
				[global::Cpp2ILInjected.Address(RVA = "0x1154398", Offset = "0x1154398", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x06004A51 RID: 19025 RVA: 0x0002F2C4 File Offset: 0x0002D4C4
			[global::Cpp2ILInjected.Token(Token = "0x60028CF")]
			[global::Cpp2ILInjected.Address(RVA = "0x11543A0", Offset = "0x11543A0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = ".cctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public SubstitutionsObject()
			{
				throw null;
			}

			// Token: 0x04007EDB RID: 32475
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4003574")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private string <Nurse>k__BackingField;

			// Token: 0x04007EDC RID: 32476
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4003575")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private string <Merchant>k__BackingField;

			// Token: 0x04007EDD RID: 32477
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4003576")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private string <ArmsDealer>k__BackingField;

			// Token: 0x04007EDE RID: 32478
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4003577")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private string <Dryad>k__BackingField;

			// Token: 0x04007EDF RID: 32479
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4003578")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private string <Demolitionist>k__BackingField;

			// Token: 0x04007EE0 RID: 32480
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4003579")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			private string <Clothier>k__BackingField;

			// Token: 0x04007EE1 RID: 32481
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x400357A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			private string <Guide>k__BackingField;

			// Token: 0x04007EE2 RID: 32482
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x400357B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			private string <Wizard>k__BackingField;

			// Token: 0x04007EE3 RID: 32483
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x400357C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
			private string <GoblinTinkerer>k__BackingField;

			// Token: 0x04007EE4 RID: 32484
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x400357D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
			private string <Mechanic>k__BackingField;

			// Token: 0x04007EE5 RID: 32485
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x400357E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
			private string <Truffle>k__BackingField;

			// Token: 0x04007EE6 RID: 32486
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x400357F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
			private string <Steampunker>k__BackingField;

			// Token: 0x04007EE7 RID: 32487
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4003580")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
			private string <DyeTrader>k__BackingField;

			// Token: 0x04007EE8 RID: 32488
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4003581")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
			private string <PartyGirl>k__BackingField;

			// Token: 0x04007EE9 RID: 32489
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4003582")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
			private string <Cyborg>k__BackingField;

			// Token: 0x04007EEA RID: 32490
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4003583")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
			private string <Painter>k__BackingField;

			// Token: 0x04007EEB RID: 32491
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4003584")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
			private string <WitchDoctor>k__BackingField;

			// Token: 0x04007EEC RID: 32492
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4003585")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
			private string <Pirate>k__BackingField;

			// Token: 0x04007EED RID: 32493
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4003586")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
			private string <Stylist>k__BackingField;

			// Token: 0x04007EEE RID: 32494
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4003587")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
			private string <TravelingMerchant>k__BackingField;

			// Token: 0x04007EEF RID: 32495
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4003588")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
			private string <Angler>k__BackingField;

			// Token: 0x04007EF0 RID: 32496
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4003589")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
			private string <Bartender>k__BackingField;

			// Token: 0x04007EF1 RID: 32497
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x400358A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
			private string <WorldName>k__BackingField;

			// Token: 0x04007EF2 RID: 32498
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x400358B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
			private bool <Day>k__BackingField;

			// Token: 0x04007EF3 RID: 32499
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x400358C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xC9")]
			private bool <BloodMoon>k__BackingField;

			// Token: 0x04007EF4 RID: 32500
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x400358D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xCA")]
			private bool <Eclipse>k__BackingField;

			// Token: 0x04007EF5 RID: 32501
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x400358E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xCB")]
			private bool <MoonLordDefeated>k__BackingField;

			// Token: 0x04007EF6 RID: 32502
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x400358F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xCC")]
			private bool <GolemDefeated>k__BackingField;

			// Token: 0x04007EF7 RID: 32503
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4003590")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xCD")]
			private bool <DukeFishronDefeated>k__BackingField;

			// Token: 0x04007EF8 RID: 32504
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4003591")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xCE")]
			private bool <FrostLegionDefeated>k__BackingField;

			// Token: 0x04007EF9 RID: 32505
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4003592")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xCF")]
			private bool <MartiansDefeated>k__BackingField;

			// Token: 0x04007EFA RID: 32506
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4003593")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
			private bool <PumpkingDefeated>k__BackingField;

			// Token: 0x04007EFB RID: 32507
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4003594")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xD1")]
			private bool <IceQueenDefeated>k__BackingField;

			// Token: 0x04007EFC RID: 32508
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4003595")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xD2")]
			private bool <HardMode>k__BackingField;

			// Token: 0x04007EFD RID: 32509
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4003596")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xD3")]
			private bool <Homeless>k__BackingField;

			// Token: 0x04007EFE RID: 32510
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4003597")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
			private string <InventoryKey>k__BackingField;

			// Token: 0x04007EFF RID: 32511
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4003598")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
			private string <PlayerName>k__BackingField;

			// Token: 0x04007F00 RID: 32512
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4003599")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
			private string <GolfGuy>k__BackingField;

			// Token: 0x04007F01 RID: 32513
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x400359A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
			private string <TaxCollector>k__BackingField;

			// Token: 0x04007F02 RID: 32514
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x400359B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
			private bool <Rain>k__BackingField;

			// Token: 0x04007F03 RID: 32515
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x400359C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xF9")]
			private bool <Graveyard>k__BackingField;

			// Token: 0x04007F04 RID: 32516
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x400359D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xFC")]
			private int <AnglerCompletedQuestsCount>k__BackingField;

			// Token: 0x04007F05 RID: 32517
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x400359E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
			private int <TotalDeathsCount>k__BackingField;

			// Token: 0x04007F06 RID: 32518
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x400359F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
			private string <WorldEvilStone>k__BackingField;

			// Token: 0x04007F07 RID: 32519
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x40035A0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
			private string <InputTriggerUI_BuildFromInventory>k__BackingField;

			// Token: 0x04007F08 RID: 32520
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x40035A1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
			private string <InputTriggerUI_SellItem>k__BackingField;

			// Token: 0x04007F09 RID: 32521
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x40035A2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
			private string <InputTriggerUI_Trash>k__BackingField;

			// Token: 0x04007F0A RID: 32522
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x40035A3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
			private string <InputTriggerUI_FavoriteItem>k__BackingField;

			// Token: 0x04007F0B RID: 32523
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x40035A4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x130")]
			private string <InputTriggerUI_ZoomIn>k__BackingField;

			// Token: 0x04007F0C RID: 32524
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x40035A5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x138")]
			private string <InputTriggerUI_ZoomOut>k__BackingField;

			// Token: 0x04007F0D RID: 32525
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x40035A6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x140")]
			private string <InputTrigger_QuickEquip>k__BackingField;

			// Token: 0x04007F0E RID: 32526
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x40035A7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
			private string <InputTrigger_LockOn>k__BackingField;

			// Token: 0x04007F0F RID: 32527
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x40035A8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
			private string <InputTrigger_SmartCursor>k__BackingField;

			// Token: 0x04007F10 RID: 32528
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x40035A9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
			private string <InputTrigger_UseOrAttack>k__BackingField;

			// Token: 0x04007F11 RID: 32529
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x40035AA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x160")]
			private string <InputTrigger_InteractWithTile>k__BackingField;

			// Token: 0x04007F12 RID: 32530
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x40035AB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x168")]
			private string <InputTrigger_SmartSelect>k__BackingField;
		}

		// Token: 0x02000860 RID: 2144
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000438")]
		private sealed class <>c__DisplayClass48_0
		{
			// Token: 0x06004A52 RID: 19026 RVA: 0x0002F2C7 File Offset: 0x0002D4C7
			[global::Cpp2ILInjected.Token(Token = "0x60028D0")]
			[global::Cpp2ILInjected.Address(RVA = "0x11543A8", Offset = "0x11543A8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "CreateDialogFilter", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object)
			}, ReturnType = typeof(LanguageSearchFilter))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass48_0()
			{
				throw null;
			}

			// Token: 0x06004A53 RID: 19027 RVA: 0x0002F2CA File Offset: 0x0002D4CA
			[global::Cpp2ILInjected.Token(Token = "0x60028D1")]
			[global::Cpp2ILInjected.Address(RVA = "0x11543B0", Offset = "0x11543B0", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LocalizedText), Member = "CanFormatWith", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
			internal bool <CreateDialogFilter>b__0(string key, LocalizedText text)
			{
				throw null;
			}

			// Token: 0x04007F13 RID: 32531
			[global::Cpp2ILInjected.Token(Token = "0x40035AC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public string startsWith;

			// Token: 0x04007F14 RID: 32532
			[global::Cpp2ILInjected.Token(Token = "0x40035AD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public object substitutions;
		}

		// Token: 0x02000861 RID: 2145
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000439")]
		private sealed class <>c__DisplayClass49_0
		{
			// Token: 0x06004A54 RID: 19028 RVA: 0x0002F2CD File Offset: 0x0002D4CD
			[global::Cpp2ILInjected.Token(Token = "0x60028D2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1154400", Offset = "0x1154400", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "CreateDialogFilter", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(LanguageSearchFilter))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass49_0()
			{
				throw null;
			}

			// Token: 0x06004A55 RID: 19029 RVA: 0x0002F2D0 File Offset: 0x0002D4D0
			[global::Cpp2ILInjected.Token(Token = "0x60028D3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1154408", Offset = "0x1154408", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			internal bool <CreateDialogFilter>b__0(string key, LocalizedText text)
			{
				throw null;
			}

			// Token: 0x04007F15 RID: 32533
			[global::Cpp2ILInjected.Token(Token = "0x40035AE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public string startsWith;
		}

		// Token: 0x02000862 RID: 2146
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200043A")]
		private sealed class <>c__DisplayClass52_0<IdClass, IdType> where IdType : IConvertible
		{
			// Token: 0x06004A56 RID: 19030 RVA: 0x0002F2D3 File Offset: 0x0002D4D3
			[global::Cpp2ILInjected.Token(Token = "0x60028D4")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B3290", Offset = "0x15B3290", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass52_0()
			{
				throw null;
			}

			// Token: 0x06004A57 RID: 19031 RVA: 0x0002F2D6 File Offset: 0x0002D4D6
			[global::Cpp2ILInjected.Token(Token = "0x60028D5")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B3298", Offset = "0x15B3298", Length = "0x258")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToInt64", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(long))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "Exists", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(LocalizedText))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
			internal void <FillNameCacheArray>b__1(FieldInfo field)
			{
				throw null;
			}

			// Token: 0x04007F16 RID: 32534
			[global::Cpp2ILInjected.Token(Token = "0x40035AF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public LocalizedText[] nameCache;

			// Token: 0x04007F17 RID: 32535
			[global::Cpp2ILInjected.Token(Token = "0x40035B0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public bool leaveMissingEntriesBlank;

			// Token: 0x04007F18 RID: 32536
			[global::Cpp2ILInjected.Token(Token = "0x40035B1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public string category;
		}

		// Token: 0x02000863 RID: 2147
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200043B")]
		[Serializable]
		private sealed class <>c__52<IdClass, IdType> where IdType : IConvertible
		{
			// Token: 0x06004A58 RID: 19032 RVA: 0x0002F2D9 File Offset: 0x0002D4D9
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x60028D6")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B1FB8", Offset = "0x15B1FB8", Length = "0xEC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			static <>c__52()
			{
				throw null;
			}

			// Token: 0x06004A59 RID: 19033 RVA: 0x0002F2DC File Offset: 0x0002D4DC
			[global::Cpp2ILInjected.Token(Token = "0x60028D7")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B20A4", Offset = "0x15B20A4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__52()
			{
				throw null;
			}

			// Token: 0x06004A5A RID: 19034 RVA: 0x0002F2DF File Offset: 0x0002D4DF
			[global::Cpp2ILInjected.Token(Token = "0x60028D8")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B20AC", Offset = "0x15B20AC", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Type),
				typeof(Type)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal bool <FillNameCacheArray>b__52_0(FieldInfo f)
			{
				throw null;
			}

			// Token: 0x04007F19 RID: 32537
			[global::Cpp2ILInjected.Token(Token = "0x40035B2")]
			public static readonly Lang.<>c__52<IdClass, IdType> <>9;

			// Token: 0x04007F1A RID: 32538
			[global::Cpp2ILInjected.Token(Token = "0x40035B3")]
			public static Func<FieldInfo, bool> <>9__52_0;
		}

		// Token: 0x02000864 RID: 2148
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200043C")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004A5B RID: 19035 RVA: 0x0002F2E2 File Offset: 0x0002D4E2
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x60028D9")]
			[global::Cpp2ILInjected.Address(RVA = "0x115441C", Offset = "0x115441C", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			// Token: 0x06004A5C RID: 19036 RVA: 0x0002F2E5 File Offset: 0x0002D4E5
			[global::Cpp2ILInjected.Token(Token = "0x60028DA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1154478", Offset = "0x1154478", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			// Token: 0x06004A5D RID: 19037 RVA: 0x0002F2E8 File Offset: 0x0002D4E8
			[global::Cpp2ILInjected.Token(Token = "0x60028DB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1154480", Offset = "0x1154480", Length = "0xA4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Type),
				typeof(Type)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal bool <InitializeLegacyLocalization>b__54_0(FieldInfo f)
			{
				throw null;
			}

			// Token: 0x06004A5E RID: 19038 RVA: 0x0002F2EB File Offset: 0x0002D4EB
			[global::Cpp2ILInjected.Token(Token = "0x60028DC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1154524", Offset = "0x1154524", Length = "0x190")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemTooltip), Member = "FromLanguageKey", MemberParameters = new object[]
			{
				typeof(short),
				typeof(string)
			}, ReturnType = typeof(ItemTooltip))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
			internal void <InitializeLegacyLocalization>b__54_1(FieldInfo field)
			{
				throw null;
			}

			// Token: 0x04007F1B RID: 32539
			[global::Cpp2ILInjected.Token(Token = "0x40035B4")]
			public static readonly Lang.<>c <>9;

			// Token: 0x04007F1C RID: 32540
			[global::Cpp2ILInjected.Token(Token = "0x40035B5")]
			public static Func<FieldInfo, bool> <>9__54_0;

			// Token: 0x04007F1D RID: 32541
			[global::Cpp2ILInjected.Token(Token = "0x40035B6")]
			public static Action<FieldInfo> <>9__54_1;
		}
	}
}
