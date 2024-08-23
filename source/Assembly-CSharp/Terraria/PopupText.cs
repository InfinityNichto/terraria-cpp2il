using System;
using System.Diagnostics;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent;
using Terraria.Localization;

namespace Terraria
{
	// Token: 0x0200031E RID: 798
	[global::Cpp2ILInjected.Token(Token = "0x200041C")]
	public class PopupText
	{
		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x06002400 RID: 9216 RVA: 0x0002864F File Offset: 0x0002684F
		[global::Cpp2ILInjected.Token(Token = "0x17000552")]
		public bool notActuallyAnItem
		{
			[global::Cpp2ILInjected.Token(Token = "0x60025F7")]
			[global::Cpp2ILInjected.Address(RVA = "0x10C1BAC", Offset = "0x10C1BAC", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06002401 RID: 9217 RVA: 0x00028652 File Offset: 0x00026852
		[global::Cpp2ILInjected.Token(Token = "0x17000553")]
		public static float TargetScale
		{
			[global::Cpp2ILInjected.Token(Token = "0x60025F8")]
			[global::Cpp2ILInjected.Address(RVA = "0x10C1BCC", Offset = "0x10C1BCC", Length = "0x94")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PopupText), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002402 RID: 9218 RVA: 0x00028655 File Offset: 0x00026855
		[global::Cpp2ILInjected.Token(Token = "0x60025F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x10C1C60", Offset = "0x10C1C60", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "Kill", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_popupText", ReturnType = typeof(PopupText[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static void ClearSonarText()
		{
			throw null;
		}

		// Token: 0x06002403 RID: 9219 RVA: 0x00028658 File Offset: 0x00026858
		[global::Cpp2ILInjected.Token(Token = "0x60025FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x10C1D6C", Offset = "0x10C1D6C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void ResetText(PopupText text)
		{
			throw null;
		}

		// Token: 0x06002404 RID: 9220 RVA: 0x0002865B File Offset: 0x0002685B
		[global::Cpp2ILInjected.Token(Token = "0x60025FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x10C1D94", Offset = "0x10C1D94", Length = "0x218")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LucyAxeMessage), Member = "SpawnPopupText", MemberParameters = new object[]
		{
			typeof(LucyAxeMessage.MessageSource),
			typeof(int),
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_showItemText", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PopupText), Member = "FindNextItemTextSlot", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "MeasureString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_popupText", ReturnType = typeof(PopupText[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public static int NewText(AdvancedPopupRequest request, Vector2 position)
		{
			throw null;
		}

		// Token: 0x06002405 RID: 9221 RVA: 0x0002865E File Offset: 0x0002685E
		[global::Cpp2ILInjected.Token(Token = "0x60025FC")]
		[global::Cpp2ILInjected.Address(RVA = "0x10C20C4", Offset = "0x10C20C4", Length = "0x2F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "FishingCheck", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_showItemText", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetHostOnly", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PopupText), Member = "FindNextItemTextSlot", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "SetDefaults", MemberParameters = new object[]
		{
			typeof(int),
			typeof(NPCSpawnParams)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "get_TypeName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "MeasureString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_popupText", ReturnType = typeof(PopupText[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public static int NewText(PopupTextContext context, int npcNetID, Vector2 position, bool stay5TimesLonger)
		{
			throw null;
		}

		// Token: 0x06002406 RID: 9222 RVA: 0x00028661 File Offset: 0x00026861
		[global::Cpp2ILInjected.Token(Token = "0x60025FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x10C23B4", Offset = "0x10C23B4", Length = "0x994")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICrafting), Member = "CraftButtonOver", MemberParameters = new object[] { typeof(GUITransactionButton.InputState) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIReforgePopup), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIShop), Member = "PurchasePressedAndHeld", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "FillAmmo", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Item),
			typeof(GetItemSettings)
		}, ReturnType = typeof(Item))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "GetItem", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Item),
			typeof(GetItemSettings),
			typeof(bool)
		}, ReturnType = typeof(Item))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "GetItem_VoidVault", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Item[]),
			typeof(Item),
			typeof(GetItemSettings),
			typeof(Item)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "GetItem_FillIntoOccupiedSlot_VoidBag", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Item[]),
			typeof(Item),
			typeof(GetItemSettings),
			typeof(Item),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "GetItem_FillIntoOccupiedSlot", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Item),
			typeof(GetItemSettings),
			typeof(Item),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "GetItem_FillEmptyInventorySlot_VoidBag", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Item[]),
			typeof(Item),
			typeof(GetItemSettings),
			typeof(Item),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "GetItem_FillEmptyInventorySlot", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Item),
			typeof(GetItemSettings),
			typeof(Item),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "PutItemInInventoryFromItemUsage", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "FishingCheck", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_061_FishingBobber_GiveItemToPlayer", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 20)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_showItemText", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_Name", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetHostOnly", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_popupText", ReturnType = typeof(PopupText[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "AffixName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(long), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "MeasureString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PopupText), Member = "FindNextItemTextSlot", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PopupText), Member = "AddToCoinValue", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PopupText), Member = "ValueToName", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PopupText), Member = "ValueToName", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		public static int NewText(PopupTextContext context, Item newItem, int stack, bool noStack = false, bool longText = false)
		{
			throw null;
		}

		// Token: 0x06002407 RID: 9223 RVA: 0x00028664 File Offset: 0x00026864
		[global::Cpp2ILInjected.Token(Token = "0x60025FE")]
		[global::Cpp2ILInjected.Address(RVA = "0x10C2D48", Offset = "0x10C2D48", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PopupText), Member = "NewText", MemberParameters = new object[]
		{
			typeof(PopupTextContext),
			typeof(Item),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(long),
			typeof(long)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(long),
			typeof(long)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void AddToCoinValue(long addedValue)
		{
			throw null;
		}

		// Token: 0x06002408 RID: 9224 RVA: 0x00028667 File Offset: 0x00026867
		[global::Cpp2ILInjected.Token(Token = "0x60025FF")]
		[global::Cpp2ILInjected.Address(RVA = "0x10C1FAC", Offset = "0x10C1FAC", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PopupText), Member = "NewText", MemberParameters = new object[]
		{
			typeof(AdvancedPopupRequest),
			typeof(Vector2)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PopupText), Member = "NewText", MemberParameters = new object[]
		{
			typeof(PopupTextContext),
			typeof(int),
			typeof(Vector2),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PopupText), Member = "NewText", MemberParameters = new object[]
		{
			typeof(PopupTextContext),
			typeof(Item),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_popupText", ReturnType = typeof(PopupText[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static int FindNextItemTextSlot()
		{
			throw null;
		}

		// Token: 0x06002409 RID: 9225 RVA: 0x0002866A File Offset: 0x0002686A
		[global::Cpp2ILInjected.Token(Token = "0x6002600")]
		[global::Cpp2ILInjected.Address(RVA = "0x10C3398", Offset = "0x10C3398", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "FishingCheck", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_popupText", ReturnType = typeof(PopupText[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static void AssignAsSonarText(int sonarTextIndex)
		{
			throw null;
		}

		// Token: 0x0600240A RID: 9226 RVA: 0x0002866D File Offset: 0x0002686D
		[global::Cpp2ILInjected.Token(Token = "0x6002601")]
		[global::Cpp2ILInjected.Address(RVA = "0x10C2DD4", Offset = "0x10C2DD4", Length = "0x2DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PopupText), Member = "NewText", MemberParameters = new object[]
		{
			typeof(PopupTextContext),
			typeof(Item),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static string ValueToName(long coinValue)
		{
			throw null;
		}

		// Token: 0x0600240B RID: 9227 RVA: 0x00028670 File Offset: 0x00026870
		[global::Cpp2ILInjected.Token(Token = "0x6002602")]
		[global::Cpp2ILInjected.Address(RVA = "0x10C30B0", Offset = "0x10C30B0", Length = "0x2E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PopupText), Member = "NewText", MemberParameters = new object[]
		{
			typeof(PopupTextContext),
			typeof(Item),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void ValueToName()
		{
			throw null;
		}

		// Token: 0x0600240C RID: 9228 RVA: 0x00028673 File Offset: 0x00026873
		[global::Cpp2ILInjected.Token(Token = "0x6002603")]
		[global::Cpp2ILInjected.Address(RVA = "0x10C3458", Offset = "0x10C3458", Length = "0x71C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PopupText), Member = "UpdateItemText", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PopupText), Member = "get_TargetScale", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(long), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "MeasureString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_popupText", ReturnType = typeof(PopupText[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Intersects", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		public void Update(int whoAmI)
		{
			throw null;
		}

		// Token: 0x0600240D RID: 9229 RVA: 0x00028676 File Offset: 0x00026876
		[global::Cpp2ILInjected.Token(Token = "0x6002604")]
		[global::Cpp2ILInjected.Address(RVA = "0x10C3B74", Offset = "0x10C3B74", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoUpdateInWorld", MemberParameters = new object[] { typeof(Stopwatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_popupText", ReturnType = typeof(PopupText[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PopupText), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static void UpdateItemText()
		{
			throw null;
		}

		// Token: 0x0600240E RID: 9230 RVA: 0x00028679 File Offset: 0x00026879
		[global::Cpp2ILInjected.Token(Token = "0x6002605")]
		[global::Cpp2ILInjected.Address(RVA = "0x10C3C48", Offset = "0x10C3C48", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_popupText", ReturnType = typeof(PopupText[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static void ClearAll()
		{
			throw null;
		}

		// Token: 0x0600240F RID: 9231 RVA: 0x0002867C File Offset: 0x0002687C
		[global::Cpp2ILInjected.Token(Token = "0x6002606")]
		[global::Cpp2ILInjected.Address(RVA = "0x10C3D40", Offset = "0x10C3D40", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LocalUser), Member = "SetupState", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "Initialize_Entities", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public PopupText()
		{
			throw null;
		}

		// Token: 0x06002410 RID: 9232 RVA: 0x0002867F File Offset: 0x0002687F
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6002607")]
		[global::Cpp2ILInjected.Address(RVA = "0x10C3D58", Offset = "0x10C3D58", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static PopupText()
		{
			throw null;
		}

		// Token: 0x04002BE0 RID: 11232
		[global::Cpp2ILInjected.Token(Token = "0x40032F5")]
		public static int activeTime;

		// Token: 0x04002BE1 RID: 11233
		[global::Cpp2ILInjected.Token(Token = "0x40032F6")]
		public static int numActive;

		// Token: 0x04002BE2 RID: 11234
		[global::Cpp2ILInjected.Token(Token = "0x40032F7")]
		public static int sonarText;

		// Token: 0x04002BE3 RID: 11235
		[global::Cpp2ILInjected.Token(Token = "0x40032F8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public Vector2 position;

		// Token: 0x04002BE4 RID: 11236
		[global::Cpp2ILInjected.Token(Token = "0x40032F9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public Vector2 velocity;

		// Token: 0x04002BE5 RID: 11237
		[global::Cpp2ILInjected.Token(Token = "0x40032FA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public float alpha;

		// Token: 0x04002BE6 RID: 11238
		[global::Cpp2ILInjected.Token(Token = "0x40032FB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		public int alphaDir;

		// Token: 0x04002BE7 RID: 11239
		[global::Cpp2ILInjected.Token(Token = "0x40032FC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public string name;

		// Token: 0x04002BE8 RID: 11240
		[global::Cpp2ILInjected.Token(Token = "0x40032FD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public long stack;

		// Token: 0x04002BE9 RID: 11241
		[global::Cpp2ILInjected.Token(Token = "0x40032FE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public float scale;

		// Token: 0x04002BEA RID: 11242
		[global::Cpp2ILInjected.Token(Token = "0x40032FF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		public float rotation;

		// Token: 0x04002BEB RID: 11243
		[global::Cpp2ILInjected.Token(Token = "0x4003300")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		public Color color;

		// Token: 0x04002BEC RID: 11244
		[global::Cpp2ILInjected.Token(Token = "0x4003301")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		public bool active;

		// Token: 0x04002BED RID: 11245
		[global::Cpp2ILInjected.Token(Token = "0x4003302")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		public int lifeTime;

		// Token: 0x04002BEE RID: 11246
		[global::Cpp2ILInjected.Token(Token = "0x4003303")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
		public bool NoStack;

		// Token: 0x04002BEF RID: 11247
		[global::Cpp2ILInjected.Token(Token = "0x4003304")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4D")]
		public bool coinText;

		// Token: 0x04002BF0 RID: 11248
		[global::Cpp2ILInjected.Token(Token = "0x4003305")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		public long coinValue;

		// Token: 0x04002BF1 RID: 11249
		[global::Cpp2ILInjected.Token(Token = "0x4003306")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		public bool expert;

		// Token: 0x04002BF2 RID: 11250
		[global::Cpp2ILInjected.Token(Token = "0x4003307")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x59")]
		public bool master;

		// Token: 0x04002BF3 RID: 11251
		[global::Cpp2ILInjected.Token(Token = "0x4003308")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5A")]
		public bool sonar;

		// Token: 0x04002BF4 RID: 11252
		[global::Cpp2ILInjected.Token(Token = "0x4003309")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
		public PopupTextContext context;

		// Token: 0x04002BF5 RID: 11253
		[global::Cpp2ILInjected.Token(Token = "0x400330A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		public int npcNetID;

		// Token: 0x04002BF6 RID: 11254
		[global::Cpp2ILInjected.Token(Token = "0x400330B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x64")]
		public bool freeAdvanced;

		// Token: 0x04002BF7 RID: 11255
		[global::Cpp2ILInjected.Token(Token = "0x400330C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private Vector2 cachedSize;

		// Token: 0x04002BF8 RID: 11256
		[global::Cpp2ILInjected.Token(Token = "0x400330D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private string cachedName;

		// Token: 0x04002BF9 RID: 11257
		[global::Cpp2ILInjected.Token(Token = "0x400330E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private long cachedStack;
	}
}
