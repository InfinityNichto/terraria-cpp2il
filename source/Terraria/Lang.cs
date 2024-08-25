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
	[global::Cpp2ILInjected.Token(Token = "0x2000436")]
	public class Lang
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x600283E")]
		[global::Cpp2ILInjected.Address(RVA = "0x10DA2F0", Offset = "0x10DA2F0", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "RebuildTooltip", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static ItemTooltip GetTooltip(int itemId)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x600285D")]
		[global::Cpp2ILInjected.Address(RVA = "0x10E7B4C", Offset = "0x10E7B4C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public Lang()
		{
			throw null;
		}

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

		[Obsolete("Lang arrays have been replaced with the new Language.GetText system.")]
		[global::Cpp2ILInjected.Token(Token = "0x400355F")]
		public static LocalizedText[] menu;

		[Obsolete("Lang arrays have been replaced with the new Language.GetText system.")]
		[global::Cpp2ILInjected.Token(Token = "0x4003560")]
		public static LocalizedText[] gen;

		[Obsolete("Lang arrays have been replaced with the new Language.GetText system.")]
		[global::Cpp2ILInjected.Token(Token = "0x4003561")]
		public static LocalizedText[] misc;

		[Obsolete("Lang arrays have been replaced with the new Language.GetText system.")]
		[global::Cpp2ILInjected.Token(Token = "0x4003562")]
		public static LocalizedText[] inter;

		[Obsolete("Lang arrays have been replaced with the new Language.GetText system.")]
		[global::Cpp2ILInjected.Token(Token = "0x4003563")]
		public static LocalizedText[] tip;

		[Obsolete("Lang arrays have been replaced with the new Language.GetText system.")]
		[global::Cpp2ILInjected.Token(Token = "0x4003564")]
		public static LocalizedText[] mp;

		[Obsolete("Lang arrays have been replaced with the new Language.GetText system.")]
		[global::Cpp2ILInjected.Token(Token = "0x4003565")]
		public static LocalizedText[] chestType;

		[Obsolete("Lang arrays have been replaced with the new Language.GetText system.")]
		[global::Cpp2ILInjected.Token(Token = "0x4003566")]
		public static LocalizedText[] dresserType;

		[Obsolete("Lang arrays have been replaced with the new Language.GetText system.")]
		[global::Cpp2ILInjected.Token(Token = "0x4003567")]
		public static LocalizedText[] chestType2;

		[global::Cpp2ILInjected.Token(Token = "0x4003568")]
		public static LocalizedText[] prefix;

		[global::Cpp2ILInjected.Token(Token = "0x4003569")]
		public static LocalizedText[] _mapLegendCache;

		[global::Cpp2ILInjected.Token(Token = "0x400356A")]
		public static LocalizedText[] mobile;

		[global::Cpp2ILInjected.Token(Token = "0x400356B")]
		private static LocalizedText[] _itemNameCache;

		[global::Cpp2ILInjected.Token(Token = "0x400356C")]
		private static LocalizedText[] _projectileNameCache;

		[global::Cpp2ILInjected.Token(Token = "0x400356D")]
		private static LocalizedText[] _npcNameCache;

		[global::Cpp2ILInjected.Token(Token = "0x400356E")]
		private static LocalizedText[] _negativeNpcNameCache;

		[global::Cpp2ILInjected.Token(Token = "0x400356F")]
		private static LocalizedText[] _buffNameCache;

		[global::Cpp2ILInjected.Token(Token = "0x4003570")]
		private static LocalizedText[] _buffDescriptionCache;

		[global::Cpp2ILInjected.Token(Token = "0x4003571")]
		private static ItemTooltip[] _itemTooltipCache;

		[global::Cpp2ILInjected.Token(Token = "0x4003572")]
		private static LocalizedText[] _emojiNameCache;

		[global::Cpp2ILInjected.Token(Token = "0x4003573")]
		private static Lang.SubstitutionsObject SubstitutionsObjectValue;

		[global::Cpp2ILInjected.Token(Token = "0x2000437")]
		public class SubstitutionsObject
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x60028CF")]
			[global::Cpp2ILInjected.Address(RVA = "0x11543A0", Offset = "0x11543A0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = ".cctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public SubstitutionsObject()
			{
				throw null;
			}

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4003574")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private string <Nurse>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4003575")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private string <Merchant>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4003576")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private string <ArmsDealer>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4003577")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private string <Dryad>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4003578")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private string <Demolitionist>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4003579")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			private string <Clothier>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x400357A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			private string <Guide>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x400357B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			private string <Wizard>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x400357C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
			private string <GoblinTinkerer>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x400357D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
			private string <Mechanic>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x400357E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
			private string <Truffle>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x400357F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
			private string <Steampunker>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4003580")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
			private string <DyeTrader>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4003581")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
			private string <PartyGirl>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4003582")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
			private string <Cyborg>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4003583")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
			private string <Painter>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4003584")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
			private string <WitchDoctor>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4003585")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
			private string <Pirate>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4003586")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
			private string <Stylist>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4003587")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
			private string <TravelingMerchant>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4003588")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
			private string <Angler>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4003589")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
			private string <Bartender>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x400358A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
			private string <WorldName>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x400358B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
			private bool <Day>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x400358C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xC9")]
			private bool <BloodMoon>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x400358D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xCA")]
			private bool <Eclipse>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x400358E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xCB")]
			private bool <MoonLordDefeated>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x400358F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xCC")]
			private bool <GolemDefeated>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4003590")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xCD")]
			private bool <DukeFishronDefeated>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4003591")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xCE")]
			private bool <FrostLegionDefeated>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4003592")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xCF")]
			private bool <MartiansDefeated>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4003593")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
			private bool <PumpkingDefeated>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4003594")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xD1")]
			private bool <IceQueenDefeated>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4003595")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xD2")]
			private bool <HardMode>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4003596")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xD3")]
			private bool <Homeless>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4003597")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
			private string <InventoryKey>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4003598")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
			private string <PlayerName>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4003599")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
			private string <GolfGuy>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x400359A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
			private string <TaxCollector>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x400359B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
			private bool <Rain>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x400359C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xF9")]
			private bool <Graveyard>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x400359D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xFC")]
			private int <AnglerCompletedQuestsCount>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x400359E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
			private int <TotalDeathsCount>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x400359F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
			private string <WorldEvilStone>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x40035A0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
			private string <InputTriggerUI_BuildFromInventory>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x40035A1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
			private string <InputTriggerUI_SellItem>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x40035A2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
			private string <InputTriggerUI_Trash>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x40035A3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
			private string <InputTriggerUI_FavoriteItem>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x40035A4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x130")]
			private string <InputTriggerUI_ZoomIn>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x40035A5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x138")]
			private string <InputTriggerUI_ZoomOut>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x40035A6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x140")]
			private string <InputTrigger_QuickEquip>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x40035A7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
			private string <InputTrigger_LockOn>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x40035A8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
			private string <InputTrigger_SmartCursor>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x40035A9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
			private string <InputTrigger_UseOrAttack>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x40035AA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x160")]
			private string <InputTrigger_InteractWithTile>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x40035AB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x168")]
			private string <InputTrigger_SmartSelect>k__BackingField;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000438")]
		private sealed class <>c__DisplayClass48_0
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x60028D1")]
			[global::Cpp2ILInjected.Address(RVA = "0x11543B0", Offset = "0x11543B0", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LocalizedText), Member = "CanFormatWith", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
			internal bool <CreateDialogFilter>b__0(string key, LocalizedText text)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x40035AC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public string startsWith;

			[global::Cpp2ILInjected.Token(Token = "0x40035AD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public object substitutions;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000439")]
		private sealed class <>c__DisplayClass49_0
		{
			[global::Cpp2ILInjected.Token(Token = "0x60028D2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1154400", Offset = "0x1154400", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "CreateDialogFilter", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(LanguageSearchFilter))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass49_0()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60028D3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1154408", Offset = "0x1154408", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			internal bool <CreateDialogFilter>b__0(string key, LocalizedText text)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x40035AE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public string startsWith;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200043A")]
		private sealed class <>c__DisplayClass52_0<IdClass, IdType> where IdType : IConvertible
		{
			[global::Cpp2ILInjected.Token(Token = "0x60028D4")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B3290", Offset = "0x15B3290", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass52_0()
			{
				throw null;
			}

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

			[global::Cpp2ILInjected.Token(Token = "0x40035AF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public LocalizedText[] nameCache;

			[global::Cpp2ILInjected.Token(Token = "0x40035B0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public bool leaveMissingEntriesBlank;

			[global::Cpp2ILInjected.Token(Token = "0x40035B1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public string category;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200043B")]
		[Serializable]
		private sealed class <>c__52<IdClass, IdType> where IdType : IConvertible
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x60028D7")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B20A4", Offset = "0x15B20A4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__52()
			{
				throw null;
			}

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

			[global::Cpp2ILInjected.Token(Token = "0x40035B2")]
			public static readonly Lang.<>c__52<IdClass, IdType> <>9;

			[global::Cpp2ILInjected.Token(Token = "0x40035B3")]
			public static Func<FieldInfo, bool> <>9__52_0;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200043C")]
		[Serializable]
		private sealed class <>c
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x60028DA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1154478", Offset = "0x1154478", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

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

			[global::Cpp2ILInjected.Token(Token = "0x40035B4")]
			public static readonly Lang.<>c <>9;

			[global::Cpp2ILInjected.Token(Token = "0x40035B5")]
			public static Func<FieldInfo, bool> <>9__54_0;

			[global::Cpp2ILInjected.Token(Token = "0x40035B6")]
			public static Action<FieldInfo> <>9__54_1;
		}
	}
}
