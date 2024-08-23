using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.GameContent;
using Terraria.GameContent.Achievements;
using Terraria.GameContent.Creative;
using Terraria.GameContent.Drawing;
using Terraria.GameContent.Tile_Entities;
using Terraria.GameContent.UI;
using Terraria.GameContent.UI.Chat;
using Terraria.GameContent.UI.Elements;
using Terraria.GameInput;
using Terraria.Graphics.Renderers;
using Terraria.Localization;
using Terraria.UI.Chat;
using UnityEngine;

namespace Terraria.UI
{
	// Token: 0x020004BA RID: 1210
	[global::Cpp2ILInjected.Token(Token = "0x20006D2")]
	public class ItemSlot
	{
		// Token: 0x06003510 RID: 13584 RVA: 0x0002B7B7 File Offset: 0x000299B7
		[global::Cpp2ILInjected.Token(Token = "0x6003A7E")]
		[global::Cpp2ILInjected.Address(RVA = "0x145B4B0", Offset = "0x145B4B0", Length = "0x5B4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		static ItemSlot()
		{
			throw null;
		}

		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x06003511 RID: 13585 RVA: 0x0002B7BA File Offset: 0x000299BA
		[global::Cpp2ILInjected.Token(Token = "0x1700074F")]
		public static bool AltInUse
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003A7F")]
			[global::Cpp2ILInjected.Address(RVA = "0x145BA64", Offset = "0x145BA64", Length = "0x10C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "OverrideHover", MemberParameters = new object[]
			{
				typeof(Item[]),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMouseItem), Member = "get_HoldingItem", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUIInputLayer), Member = "GetUICursor", ReturnType = typeof(global::Cursor))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyboardInput), Member = "GetKey", MemberParameters = new object[] { typeof(KeyCode) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x06003512 RID: 13586 RVA: 0x0002B7BD File Offset: 0x000299BD
		[global::Cpp2ILInjected.Token(Token = "0x17000750")]
		public static bool ShiftInUse
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003A80")]
			[global::Cpp2ILInjected.Address(RVA = "0x145BB70", Offset = "0x145BB70", Length = "0x10C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "OverrideHover", MemberParameters = new object[]
			{
				typeof(Item[]),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "LeftClick_SellOrTrash", MemberParameters = new object[]
			{
				typeof(Item[]),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TEDisplayDoll), Member = "OverrideItemSlotLeftClick", MemberParameters = new object[]
			{
				typeof(Item[]),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TEHatRack), Member = "OverrideItemSlotLeftClick", MemberParameters = new object[]
			{
				typeof(Item[]),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMouseItem), Member = "get_HoldingItem", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUIInputLayer), Member = "GetUICursor", ReturnType = typeof(global::Cursor))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyboardInput), Member = "GetKey", MemberParameters = new object[] { typeof(KeyCode) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x06003513 RID: 13587 RVA: 0x0002B7C0 File Offset: 0x000299C0
		[global::Cpp2ILInjected.Token(Token = "0x17000751")]
		public static bool ControlInUse
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003A81")]
			[global::Cpp2ILInjected.Address(RVA = "0x145BC7C", Offset = "0x145BC7C", Length = "0x10C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "OverrideHover", MemberParameters = new object[]
			{
				typeof(Item[]),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "LeftClick_SellOrTrash", MemberParameters = new object[]
			{
				typeof(Item[]),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMouseItem), Member = "get_HoldingItem", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUIInputLayer), Member = "GetUICursor", ReturnType = typeof(global::Cursor))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyboardInput), Member = "GetKey", MemberParameters = new object[] { typeof(KeyCode) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x06003514 RID: 13588 RVA: 0x0002B7C3 File Offset: 0x000299C3
		[global::Cpp2ILInjected.Token(Token = "0x17000752")]
		public static bool NotUsingGamepad
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003A82")]
			[global::Cpp2ILInjected.Address(RVA = "0x145BD88", Offset = "0x145BD88", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "OverrideHover", MemberParameters = new object[]
			{
				typeof(Item[]),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "LeftClick_SellOrTrash", MemberParameters = new object[]
			{
				typeof(Item[]),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "get_UsingGamepad", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x14000040 RID: 64
		// (add) Token: 0x06003515 RID: 13589 RVA: 0x0002B7C6 File Offset: 0x000299C6
		// (remove) Token: 0x06003516 RID: 13590 RVA: 0x0002B7C9 File Offset: 0x000299C9
		[global::Cpp2ILInjected.Token(Token = "0x14000046")]
		public static event ItemSlot.ItemTransferEvent OnItemTransferred
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003A83")]
			[global::Cpp2ILInjected.Address(RVA = "0x145BDE4", Offset = "0x145BDE4", Length = "0xDC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LucyAxeMessage), Member = "Initialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003A84")]
			[global::Cpp2ILInjected.Address(RVA = "0x145BEC0", Offset = "0x145BEC0", Length = "0xDC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x06003517 RID: 13591 RVA: 0x0002B7CC File Offset: 0x000299CC
		[global::Cpp2ILInjected.Token(Token = "0x6003A85")]
		[global::Cpp2ILInjected.Address(RVA = "0x145BF9C", Offset = "0x145BF9C", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "LeftClick", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "SellOrTrash", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "PickupItemIntoMouse", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			typeof(int),
			typeof(Player)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "HandleShopSlot", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChestUI), Member = "TryPlacingInChest", MemberParameters = new object[]
		{
			typeof(Item),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void AnnounceTransfer(ItemSlot.ItemTransferInfo info)
		{
			throw null;
		}

		// Token: 0x06003518 RID: 13592 RVA: 0x0002B7CF File Offset: 0x000299CF
		[global::Cpp2ILInjected.Token(Token = "0x6003A86")]
		[global::Cpp2ILInjected.Address(RVA = "0x145C044", Offset = "0x145C044", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "TryInteractingWithVoidLens", MemberParameters = new object[] { typeof(Projectile) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "TryInteractingWithMoneyTrough", MemberParameters = new object[] { typeof(Projectile) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "OpenChest", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSorting), Member = "Sort", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(bool),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSorting), Member = "FillAmmoFromInventory", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void SetGlow(int index, float hue, bool chest)
		{
			throw null;
		}

		// Token: 0x06003519 RID: 13593 RVA: 0x0002B7D2 File Offset: 0x000299D2
		[global::Cpp2ILInjected.Token(Token = "0x6003A87")]
		[global::Cpp2ILInjected.Address(RVA = "0x145C124", Offset = "0x145C124", Length = "0x22C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoUpdate", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_playerInventory", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public static void UpdateInterface()
		{
			throw null;
		}

		// Token: 0x0600351A RID: 13594 RVA: 0x0002B7D5 File Offset: 0x000299D5
		[global::Cpp2ILInjected.Token(Token = "0x6003A88")]
		[global::Cpp2ILInjected.Address(RVA = "0x145C350", Offset = "0x145C350", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "Handle", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "FindRecipes", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static void Handle(ref Item inv, int context = 0)
		{
			throw null;
		}

		// Token: 0x0600351B RID: 13595 RVA: 0x0002B7D8 File Offset: 0x000299D8
		[global::Cpp2ILInjected.Token(Token = "0x6003A89")]
		[global::Cpp2ILInjected.Address(RVA = "0x145C43C", Offset = "0x145C43C", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEquipmentUtility), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "Handle", MemberParameters = new object[]
		{
			typeof(ref Item),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChestUI), Member = "DrawSlots", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TEDisplayDoll), Member = "DrawSlotPairSet", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(SpriteBatch),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TEHatRack), Member = "DrawSlotPairSet", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(SpriteBatch),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "OverrideHover", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "LeftClick", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "RightClick", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeftRelease", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeft", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "FindRecipes", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "MouseHover", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static void Handle(Item[] inv, int context = 0, int slot = 0)
		{
			throw null;
		}

		// Token: 0x0600351C RID: 13596 RVA: 0x0002B7DB File Offset: 0x000299DB
		[global::Cpp2ILInjected.Token(Token = "0x6003A8A")]
		[global::Cpp2ILInjected.Address(RVA = "0x145FE90", Offset = "0x145FE90", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIDynamicItemCollection), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIItemSlot), Member = "HandleItemSlotLogic", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "OverrideHover", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static void OverrideHover(ref Item inv, int context = 0)
		{
			throw null;
		}

		// Token: 0x0600351D RID: 13597 RVA: 0x0002B7DE File Offset: 0x000299DE
		[global::Cpp2ILInjected.Token(Token = "0x6003A8B")]
		[global::Cpp2ILInjected.Address(RVA = "0x145FF50", Offset = "0x145FF50", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool isEquipLocked(int type)
		{
			throw null;
		}

		// Token: 0x0600351E RID: 13598 RVA: 0x0002B7E1 File Offset: 0x000299E1
		[global::Cpp2ILInjected.Token(Token = "0x6003A8C")]
		[global::Cpp2ILInjected.Address(RVA = "0x145C564", Offset = "0x145C564", Length = "0x7C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIAmmo), Member = "ItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIChest), Member = "ItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICoins), Member = "ItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIDisplayDoll), Member = "ItemOver", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			"GUIDisplayDoll.EquipmentItemType",
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEquipment), Member = "ItemOver", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			"GUIEquipment.EquipmentItemType",
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHatRack), Member = "ItemOver", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			"GUIHatRack.EquipmentItemType",
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInventory), Member = "ItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "Handle", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "OverrideHover", MemberParameters = new object[]
		{
			typeof(ref Item),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "get_NotUsingGamepad", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot.Options), Member = "get_DisableLeftShiftTrashCan", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "get_ControlInUse", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot.Options), Member = "get_DisableQuickTrash", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "get_ShiftInUse", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalPlayer", ReturnType = typeof(Player))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInteractionAnchor), Member = "IsInValidUseTileEntity", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInteractionAnchor), Member = "GetTileEntity", ReturnType = typeof(TileEntity))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "ItemSpace", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(Player.ItemSpaceStatus))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player.ItemSpaceStatus), Member = "get_CanTakeItemToPersonalInventory", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_cursorOverride", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_npcShop", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChestUI), Member = "TryPlacingInChest", MemberParameters = new object[]
		{
			typeof(Item),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativeUI), Member = "IsShowingResearchMenu", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_InReforgeMenu", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_InGuideCraftMenu", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "Prefix", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "get_AltInUse", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 39)]
		public static void OverrideHover(Item[] inv, int context = 0, int slot = 0)
		{
			throw null;
		}

		// Token: 0x0600351F RID: 13599 RVA: 0x0002B7E4 File Offset: 0x000299E4
		[global::Cpp2ILInjected.Token(Token = "0x6003A8D")]
		[global::Cpp2ILInjected.Address(RVA = "0x145FF58", Offset = "0x145FF58", Length = "0x8D0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "LeftClick", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalPlayer", ReturnType = typeof(Player))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInteractionAnchor), Member = "IsInValidUseTileEntity", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInteractionAnchor), Member = "GetTileEntity", ReturnType = typeof(TileEntity))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_cursorOverride", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemTagHandler), Member = "GenerateTag", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatManager), Member = "AddChatText", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(string),
			typeof(Microsoft.Xna.Framework.Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JourneyDuplicationItemCreationContext), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "OnCreated", MemberParameters = new object[] { typeof(ItemCreationContext) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "GetItem", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Item),
			typeof(GetItemSettings),
			typeof(bool)
		}, ReturnType = typeof(Item))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativeUI), Member = "IsShowingResearchMenu", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativeUI), Member = "SwapItem", MemberParameters = new object[] { typeof(ref Item) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativeUI), Member = "SacrificeItemInSacrificeSlot", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChestUI), Member = "TryPlacingInChest", MemberParameters = new object[]
		{
			typeof(Item),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "TogglePet", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "ToggleLight", ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 51)]
		private static bool OverrideLeftClick(Item[] inv, int context = 0, int slot = 0)
		{
			throw null;
		}

		// Token: 0x06003520 RID: 13600 RVA: 0x0002B7E7 File Offset: 0x000299E7
		[global::Cpp2ILInjected.Token(Token = "0x6003A8E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1460828", Offset = "0x1460828", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIAmmo), Member = "ItemDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIChest), Member = "ItemDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICoins), Member = "ItemDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIDisplayDoll), Member = "ArmourDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIDisplayDoll), Member = "ArmourDyeDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIDisplayDoll), Member = "AccessoryDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIDisplayDoll), Member = "AccessoryDyeDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEquipment), Member = "ArmourDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEquipment), Member = "ArmourDyeDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEquipment), Member = "ArmourVanityDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEquipment), Member = "AccessoryDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEquipment), Member = "AccessoryDyeDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEquipment), Member = "AccessoryVanityDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEquipment), Member = "QuickSlotDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEquipment), Member = "QuickSlotDyeDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHatRack), Member = "HatDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHatRack), Member = "HatDyeDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInventory), Member = "DrawItem", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(ItemGrid_Layout),
			typeof(Item[]),
			typeof(int),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(Microsoft.Xna.Framework.Graphics.Color),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 18)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseItem", ReturnType = typeof(Item))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseItemSource", ReturnType = typeof(Item[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseItemSourceIndex", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static bool IsMouseItem(Item[] slots, int index)
		{
			throw null;
		}

		// Token: 0x06003521 RID: 13601 RVA: 0x0002B7EA File Offset: 0x000299EA
		[global::Cpp2ILInjected.Token(Token = "0x6003A8F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1460918", Offset = "0x1460918", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIItemDuplication), Member = "DrawCraftButton", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUITrashCan), Member = "ItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUITrashCan), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageOptions), Member = "DrawLeftTrash", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageOptions), Member = "DrawRightTrash", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIDynamicItemCollection), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIItemSlot), Member = "HandleItemSlotLogic", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "LeftClick", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static void LeftClick(ref Item inv, int context = 0)
		{
			throw null;
		}

		// Token: 0x06003522 RID: 13602 RVA: 0x0002B7ED File Offset: 0x000299ED
		[global::Cpp2ILInjected.Token(Token = "0x6003A90")]
		[global::Cpp2ILInjected.Address(RVA = "0x145CD24", Offset = "0x145CD24", Length = "0x2548")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 39)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "OverrideLeftClick", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "LeftClick_SellOrTrash", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseItem", ReturnType = typeof(Item))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "PickItemMovementAction", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			typeof(int),
			typeof(Item),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils[]), Member = "Swap", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
		{
			typeof(ref object),
			typeof(ref object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_shop", ReturnType = typeof(Chest[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_npcShop", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "SellItem", MemberParameters = new object[]
		{
			typeof(Item),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Chest), Member = "AddItemToShop", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mouseItemSource", MemberParameters = new object[] { typeof(Item[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mouseItemSourceIndex", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mouseItemSourceContext", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot.ItemTransferInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Item),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "AnnounceTransfer", MemberParameters = new object[] { typeof(ItemSlot.ItemTransferInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseItemSource", ReturnType = typeof(Item[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseItemSourceContext", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "HandleShopSlot", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_IsAir", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JourneyDuplicationItemCreationContext), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "OnCreated", MemberParameters = new object[] { typeof(ItemCreationContext) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMouseItem), Member = "BeginDrag", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mouseItem", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "FindRecipes", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_stackSplit", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "IsTheSameAs", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Swap", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T&", "T&" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseItemSourceIndex", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "PlaceItem", MemberParameters = new object[]
		{
			typeof(ref Item[]),
			typeof(ref Item),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementsHelper), Member = "HandleOnEquip", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(Item),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetClient", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "IsNotTheSameAs", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_FitsAccessoryVanitySlot", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementsHelper), Member = "NotifyItemPickup", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(Item)
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMouseItem), Member = "DisableDrag", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 187)]
		public static void LeftClick(Item[] inv, int context = 0, int slot = 0)
		{
			throw null;
		}

		// Token: 0x06003523 RID: 13603 RVA: 0x0002B7F0 File Offset: 0x000299F0
		[global::Cpp2ILInjected.Token(Token = "0x6003A91")]
		[global::Cpp2ILInjected.Address(RVA = "0x1461D60", Offset = "0x1461D60", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot.Options), Member = "get_DisableLeftShiftTrashCan", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static bool DisableTrashing()
		{
			throw null;
		}

		// Token: 0x06003524 RID: 13604 RVA: 0x0002B7F3 File Offset: 0x000299F3
		[global::Cpp2ILInjected.Token(Token = "0x6003A92")]
		[global::Cpp2ILInjected.Address(RVA = "0x14609D8", Offset = "0x14609D8", Length = "0x194")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "LeftClick", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "get_NotUsingGamepad", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot.Options), Member = "get_DisableLeftShiftTrashCan", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot.Options), Member = "get_DisableQuickTrash", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "get_ControlInUse", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "get_ShiftInUse", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "SellOrTrash", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private static bool LeftClick_SellOrTrash(Item[] inv, int context, int slot)
		{
			throw null;
		}

		// Token: 0x06003525 RID: 13605 RVA: 0x0002B7F6 File Offset: 0x000299F6
		[global::Cpp2ILInjected.Token(Token = "0x6003A93")]
		[global::Cpp2ILInjected.Address(RVA = "0x1461E04", Offset = "0x1461E04", Length = "0x354")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "LeftClick_SellOrTrash", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_npcShop", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_shop", ReturnType = typeof(Chest[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "SellItem", MemberParameters = new object[]
		{
			typeof(Item),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Chest), Member = "AddItemToShop", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot.ItemTransferInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Item),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "AnnounceTransfer", MemberParameters = new object[] { typeof(ItemSlot.ItemTransferInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "TurnToAir", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "Clone", ReturnType = typeof(Item))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "FindRecipes", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private static void SellOrTrash(Item[] inv, int context, int slot)
		{
			throw null;
		}

		// Token: 0x06003526 RID: 13606 RVA: 0x0002B7F9 File Offset: 0x000299F9
		[global::Cpp2ILInjected.Token(Token = "0x6003A94")]
		[global::Cpp2ILInjected.Address(RVA = "0x1462158", Offset = "0x1462158", Length = "0x400")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInteractionAnchor), Member = "GetTileEntity", ReturnType = typeof(TileEntity))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_npcShop", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_shop", ReturnType = typeof(Chest[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "ItemSpace", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(Player.ItemSpaceStatus))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player.ItemSpaceStatus), Member = "get_CanTakeItemToPersonalInventory", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChestUI), Member = "TryPlacingInChest", MemberParameters = new object[]
		{
			typeof(Item),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseItem", ReturnType = typeof(Item))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		private static string GetOverrideInstructions(Item[] inv, int context, int slot)
		{
			throw null;
		}

		// Token: 0x06003527 RID: 13607 RVA: 0x0002B7FC File Offset: 0x000299FC
		[global::Cpp2ILInjected.Token(Token = "0x6003A95")]
		[global::Cpp2ILInjected.Address(RVA = "0x1462558", Offset = "0x1462558", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "PlaceItem", MemberParameters = new object[]
		{
			typeof(ref Item[]),
			typeof(ref Item),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetClientOnly", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
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
		private static void UpdateChestOnServer(int context, int slot)
		{
			throw null;
		}

		// Token: 0x06003528 RID: 13608 RVA: 0x0002B7FF File Offset: 0x000299FF
		[global::Cpp2ILInjected.Token(Token = "0x6003A96")]
		[global::Cpp2ILInjected.Address(RVA = "0x1461418", Offset = "0x1461418", Length = "0x528")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "LeftClick", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils[]), Member = "Swap", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
		{
			typeof(ref object),
			typeof(ref object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "UpdateChestOnServer", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseItemSource", ReturnType = typeof(Item[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseItem", ReturnType = typeof(Item))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseItemSourceIndex", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mouseItem", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageOptions), Member = "ThrowItem", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mouseItemSource", MemberParameters = new object[] { typeof(Item[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mouseItemSourceIndex", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		private static void PlaceItem(ref Item[] inv, ref Item item, int context = 0, int slot = -1, int keepStack = 0)
		{
			throw null;
		}

		// Token: 0x06003529 RID: 13609 RVA: 0x0002B802 File Offset: 0x00029A02
		[global::Cpp2ILInjected.Token(Token = "0x6003A97")]
		[global::Cpp2ILInjected.Address(RVA = "0x1460B6C", Offset = "0x1460B6C", Length = "0x8AC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "LeftClick", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "PickItemMovementAction", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			typeof(int),
			typeof(Item),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChestUI), Member = "Restock", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseItem", ReturnType = typeof(Item))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChestUI), Member = "GetContainerUsageInfo", MemberParameters = new object[]
		{
			typeof(ref bool),
			typeof(ref Item[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChestUI), Member = "IsBlockedFromTransferIntoChest", MemberParameters = new object[]
		{
			typeof(Item),
			typeof(Item[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseItemSource", ReturnType = typeof(Item[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseItemSourceContext", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseItemSourceIndex", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "PickItemMovementAction", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			typeof(int),
			typeof(Item),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_FitsAccessoryVanitySlot", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalPlayer", ReturnType = typeof(Player))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "FitsAmmoSlot", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "Prefix", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "AccCheck", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(Item),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_expertMode", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 37)]
		public static int PickItemMovementAction(Item[] inv, int context, int slot, Item checkItem, bool backwardCheck = false, int initialSlot = -1)
		{
			throw null;
		}

		// Token: 0x0600352A RID: 13610 RVA: 0x0002B805 File Offset: 0x00029A05
		[global::Cpp2ILInjected.Token(Token = "0x6003A98")]
		[global::Cpp2ILInjected.Address(RVA = "0x14627F4", Offset = "0x14627F4", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIItemDuplication), Member = "DrawCraftButton", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIItemSlot), Member = "HandleItemSlotLogic", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "RightClick", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static void RightClick(ref Item inv, int context = 0)
		{
			throw null;
		}

		// Token: 0x0600352B RID: 13611 RVA: 0x0002B808 File Offset: 0x00029A08
		[global::Cpp2ILInjected.Token(Token = "0x6003A99")]
		[global::Cpp2ILInjected.Address(RVA = "0x145F26C", Offset = "0x145F26C", Length = "0x55C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIAmmo), Member = "ItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIChest), Member = "EquipChestItem", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIChest), Member = "ItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICoins), Member = "ItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEquipment), Member = "ItemOver", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			"GUIEquipment.EquipmentItemType",
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInventory), Member = "ItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInventoryTransactions), Member = "EquipItem", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "Handle", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "RightClick", MemberParameters = new object[]
		{
			typeof(ref Item),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseRight", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseRightRelease", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "SwapVanityEquip", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			typeof(int),
			typeof(Player)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "TryPickupDyeToCursor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Item[]),
			typeof(int),
			typeof(Player)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "SwapEquip", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_stackSplit", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_superFastStack", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseItem", ReturnType = typeof(Item))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "IsTheSameAs", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "PickupItemIntoMouse", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			typeof(int),
			typeof(Player)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "RefreshStackSplitCooldown", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "TryItemSwap", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "HandleShopSlot", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "TryOpenContainer", MemberParameters = new object[]
		{
			typeof(Item),
			typeof(Player)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 30)]
		public static bool RightClick(Item[] inv, int context = 0, int slot = 0)
		{
			throw null;
		}

		// Token: 0x0600352C RID: 13612 RVA: 0x0002B80B File Offset: 0x00029A0B
		[global::Cpp2ILInjected.Token(Token = "0x6003A9A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1463EFC", Offset = "0x1463EFC", Length = "0x180")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIAmmo), Member = "ItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIChest), Member = "ItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICoins), Member = "ItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInventory), Member = "ItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseItem", ReturnType = typeof(Item))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "IsTheSameAs", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "PickupItemIntoMouse", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			typeof(int),
			typeof(Player)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static void TakeOne(Item[] inv, int context, int slot)
		{
			throw null;
		}

		// Token: 0x0600352D RID: 13613 RVA: 0x0002B80E File Offset: 0x00029A0E
		[global::Cpp2ILInjected.Token(Token = "0x6003A9B")]
		[global::Cpp2ILInjected.Address(RVA = "0x14638A4", Offset = "0x14638A4", Length = "0x5D0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameInput.PlayerInput.FastUseItemMemory", Member = "TryStartForItemSlot", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "RightClick", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "TakeOne", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseItem", ReturnType = typeof(Item))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "Clone", ReturnType = typeof(Item))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mouseItem", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JourneyDuplicationItemCreationContext), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "OnCreated", MemberParameters = new object[] { typeof(ItemCreationContext) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot.ItemTransferInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Item),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "AnnounceTransfer", MemberParameters = new object[] { typeof(ItemSlot.ItemTransferInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMouseItem), Member = "BeginDrag", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInventorySplitStack), Member = "RightClickSplit", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIChestSplitStack), Member = "RightClickSplit", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mouseItemSourceContext", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mouseItemSourceIndex", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "FindRecipes", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 37)]
		public static void PickupItemIntoMouse(Item[] inv, int context, int slot, Player player)
		{
			throw null;
		}

		// Token: 0x0600352E RID: 13614 RVA: 0x0002B811 File Offset: 0x00029A11
		[global::Cpp2ILInjected.Token(Token = "0x6003A9C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1463E74", Offset = "0x1463E74", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIShop), Member = "PurchasePressedAndHeld", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "RightClick", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "HandleShopSlot", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_stackSplit", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_stackDelay", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_stackSplit", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void RefreshStackSplitCooldown()
		{
			throw null;
		}

		// Token: 0x0600352F RID: 13615 RVA: 0x0002B814 File Offset: 0x00029A14
		[global::Cpp2ILInjected.Token(Token = "0x6003A9D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1462AFC", Offset = "0x1462AFC", Length = "0x2A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "RightClick", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "OpenBossBag", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "OpenFishingCrate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_stackSplit", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mouseRightRelease", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "FindRecipes", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "OpenLegacyPresent", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "HasItemInInventoryOrOpenVoidBag", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "OpenShadowLockbox", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "OpenPresent", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "OpenHerbBag", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "OpenCanofWorms", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "OpenOyster", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "ConsumeItem", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "OpenLockBox", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "OpenGoodieBag", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private static bool TryOpenContainer(Item item, Player player)
		{
			throw null;
		}

		// Token: 0x06003530 RID: 13616 RVA: 0x0002B817 File Offset: 0x00029A17
		[global::Cpp2ILInjected.Token(Token = "0x6003A9E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1462D9C", Offset = "0x1462D9C", Length = "0x274")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "RightClick", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_npcShop", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_FitsAccessoryVanitySlot", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_IsAir", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils[]), Member = "Swap", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
		{
			typeof(ref object),
			typeof(ref object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "FindRecipes", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementsHelper), Member = "HandleOnEquip", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(Item),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementsHelper), Member = "NotifyItemPickup", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(Item)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private static bool SwapVanityEquip(Item[] inv, int context, int slot, Player player)
		{
			throw null;
		}

		// Token: 0x06003531 RID: 13617 RVA: 0x0002B81A File Offset: 0x00029A1A
		[global::Cpp2ILInjected.Token(Token = "0x6003A9F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1463010", Offset = "0x1463010", Length = "0x30C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "RightClick", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseItem", ReturnType = typeof(Item))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_IsAir", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "Clone", ReturnType = typeof(Item))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mouseItem", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetClient", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		private static bool TryPickupDyeToCursor(int context, Item[] inv, int slot, Player player)
		{
			throw null;
		}

		// Token: 0x06003532 RID: 13618 RVA: 0x0002B81D File Offset: 0x00029A1D
		[global::Cpp2ILInjected.Token(Token = "0x6003AA0")]
		[global::Cpp2ILInjected.Address(RVA = "0x14628B4", Offset = "0x14628B4", Length = "0x248")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "RightClick", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIRubbleMaker), Member = "PlayerMenuDisplayToggle", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "ChangeItemType", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "AfterItemSwap", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static bool TryItemSwap(Item item)
		{
			throw null;
		}

		// Token: 0x06003533 RID: 13619 RVA: 0x0002B820 File Offset: 0x00029A20
		[global::Cpp2ILInjected.Token(Token = "0x6003AA1")]
		[global::Cpp2ILInjected.Address(RVA = "0x146407C", Offset = "0x146407C", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIRubbleMaker), Member = "DrawOverlay", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "TryItemSwap", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUIInputLayer), Member = "ResetTimeWithoutCursor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_stackSplit", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mouseRightRelease", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "FindRecipes", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static void AfterItemSwap(int oldType, int newType)
		{
			throw null;
		}

		// Token: 0x06003534 RID: 13620 RVA: 0x0002B823 File Offset: 0x00029A23
		[global::Cpp2ILInjected.Token(Token = "0x6003AA2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1461940", Offset = "0x1461940", Length = "0x420")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "LeftClick", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "RightClick", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_cursorOverride", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_shop", ReturnType = typeof(Chest[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_npcShop", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseRight", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeft", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_stackSplit", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseItem", ReturnType = typeof(Item))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "IsTheSameAs", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_superFastStack", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalPlayer", ReturnType = typeof(Player))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "GetItemExpectedPrice", MemberParameters = new object[]
		{
			typeof(Item),
			typeof(ref long),
			typeof(ref long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "BuyItem", MemberParameters = new object[]
		{
			typeof(long),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "netDefaults", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "Prefix", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_shopSellbackHelper", ReturnType = typeof(ItemShopSellbackHelper))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemShopSellbackHelper), Member = "Add", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "RefreshStackSplitCooldown", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot.ItemTransferInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Item),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "AnnounceTransfer", MemberParameters = new object[] { typeof(ItemSlot.ItemTransferInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		private static void HandleShopSlot(Item[] inv, int slot, bool rightClickIsValid, bool leftClickIsValid)
		{
			throw null;
		}

		// Token: 0x06003535 RID: 13621 RVA: 0x0002B826 File Offset: 0x00029A26
		[global::Cpp2ILInjected.Token(Token = "0x6003AA3")]
		[global::Cpp2ILInjected.Address(RVA = "0x14641A4", Offset = "0x14641A4", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICraftGuide), Member = "GuideItemDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICraftGuidePopup), Member = "MaterialItemDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICraftGuidePopup), Member = "CraftItemDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICrafting), Member = "CraftItemDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIItemDuplication), Member = "CraftItemDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIReforge), Member = "ReforgeItemDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIResearchPage), Member = "ResearchItemDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIRubbleMaker), Member = "MaterialItemDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIRubbleMaker), Member = "RubbleItemDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUITrashCan), Member = "ItemDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawInterface_38_MouseCarriedObject", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIDynamicItemCollection), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIItemSlot), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void Draw(SpriteBatch spriteBatch, ref Item inv, int context, Microsoft.Xna.Framework.Vector2 position)
		{
			throw null;
		}

		// Token: 0x06003536 RID: 13622 RVA: 0x0002B829 File Offset: 0x00029A29
		[global::Cpp2ILInjected.Token(Token = "0x6003AA4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1464260", Offset = "0x1464260", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "DrawRadialQuicks", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Microsoft.Xna.Framework.Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.UI.Chat.ItemTagHandler.ItemSnippet", Member = "UniqueDraw", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(ref Microsoft.Xna.Framework.Vector2),
			typeof(SpriteBatch),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(Microsoft.Xna.Framework.Graphics.Color),
			typeof(float)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemTagHandler), Member = "PrintInline", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(Microsoft.Xna.Framework.Graphics.Color),
			typeof(float),
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Microsoft.Xna.Framework.Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "Draw", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Item[]),
			typeof(int),
			typeof(int),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(Microsoft.Xna.Framework.Graphics.Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static void Draw(SpriteBatch spriteBatch, ref Item inv, int context, Microsoft.Xna.Framework.Vector2 position, Microsoft.Xna.Framework.Graphics.Color lightColor)
		{
			throw null;
		}

		// Token: 0x06003537 RID: 13623 RVA: 0x0002B82C File Offset: 0x00029A2C
		[global::Cpp2ILInjected.Token(Token = "0x6003AA5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1464424", Offset = "0x1464424", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void SetCursorHighlight(bool hasFocus)
		{
			throw null;
		}

		// Token: 0x06003538 RID: 13624 RVA: 0x0002B82F File Offset: 0x00029A2F
		[global::Cpp2ILInjected.Token(Token = "0x6003AA6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1464480", Offset = "0x1464480", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 27)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void SetSelectHighlight(bool hasFocus, float highlightScale = -1f)
		{
			throw null;
		}

		// Token: 0x06003539 RID: 13625 RVA: 0x0002B832 File Offset: 0x00029A32
		[global::Cpp2ILInjected.Token(Token = "0x6003AA7")]
		[global::Cpp2ILInjected.Address(RVA = "0x14644EC", Offset = "0x14644EC", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void SetOverridenScale(float highlightScale)
		{
			throw null;
		}

		// Token: 0x0600353A RID: 13626 RVA: 0x0002B835 File Offset: 0x00029A35
		[global::Cpp2ILInjected.Token(Token = "0x6003AA8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1464550", Offset = "0x1464550", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 24)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "Draw", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Item[]),
			typeof(int),
			typeof(int),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(Microsoft.Xna.Framework.Graphics.Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void Draw(SpriteBatch spriteBatch, Item[] inv, int context, int slot, Microsoft.Xna.Framework.Vector2 position)
		{
			throw null;
		}

		// Token: 0x0600353B RID: 13627 RVA: 0x0002B838 File Offset: 0x00029A38
		[global::Cpp2ILInjected.Token(Token = "0x6003AA9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1464350", Offset = "0x1464350", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "GUIHotbarDrawInner", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "Draw", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(ref Item),
			typeof(int),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(Microsoft.Xna.Framework.Graphics.Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "Draw", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Item[]),
			typeof(int),
			typeof(int),
			typeof(Microsoft.Xna.Framework.Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "DrawRadialCircular", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(Player.SelectionRadial),
			typeof(Item[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "DrawRadialDpad", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Microsoft.Xna.Framework.Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "Draw", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Item[]),
			typeof(int),
			typeof(int),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(Microsoft.Xna.Framework.Graphics.Color),
			typeof(Microsoft.Xna.Framework.Graphics.Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void Draw(SpriteBatch spriteBatch, Item[] inv, int context, int slot, Microsoft.Xna.Framework.Vector2 position, Microsoft.Xna.Framework.Graphics.Color lightColor)
		{
			throw null;
		}

		// Token: 0x0600353C RID: 13628 RVA: 0x0002B83B File Offset: 0x00029A3B
		[global::Cpp2ILInjected.Token(Token = "0x6003AAA")]
		[global::Cpp2ILInjected.Address(RVA = "0x146461C", Offset = "0x146461C", Length = "0x36E0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEquipment), Member = "AccessoryDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEquipment), Member = "AccessoryDyeDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEquipment), Member = "AccessoryVanityDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "Draw", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Item[]),
			typeof(int),
			typeof(int),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(Microsoft.Xna.Framework.Graphics.Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_inventoryScale", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Color), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Microsoft.Xna.Framework.Graphics.Color),
			typeof(Microsoft.Xna.Framework.Graphics.Color)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput.SettingsForUI), Member = "get_HighlightThingsForMouse", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot.Options), Member = "get_HighlightNewItems", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "MultiplyRGBA", MemberParameters = new object[]
		{
			typeof(Microsoft.Xna.Framework.Graphics.Color),
			typeof(Microsoft.Xna.Framework.Graphics.Color)
		}, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_MouseScreen", ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Graphics.Texture2D) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(float)
		}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(Microsoft.Xna.Framework.Vector2)
		}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Between", MemberParameters = new object[]
		{
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(Microsoft.Xna.Framework.Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(float)
		}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(Microsoft.Xna.Framework.Vector2)
		}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUIInputLayer), Member = "GetUICursor", ReturnType = typeof(global::Cursor))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Asset<Microsoft.Xna.Framework.Graphics.Texture2D>) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatchItem), Member = "PushExpandedClippingRegion", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(Rectangle?),
			typeof(Microsoft.Xna.Framework.Graphics.Color),
			typeof(float),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(float),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatchItem), Member = "PopExpandedClippingRegion", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_IsAir", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Microsoft.Xna.Framework.Graphics.Color),
			typeof(float)
		}, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "hslToRgb", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(byte)
		}, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Color), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(Microsoft.Xna.Framework.Graphics.Color),
			typeof(Microsoft.Xna.Framework.Graphics.Color),
			typeof(float)
		}, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Color), Member = "ToVector4", ReturnType = typeof(Microsoft.Xna.Framework.Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "GetColorByLoadout", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "GetHighlightColorByLoadout", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Frame", MemberParameters = new object[]
		{
			typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle?), Member = ".ctor", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(Rectangle?),
			typeof(Microsoft.Xna.Framework.Graphics.Color),
			typeof(float),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "DrawItemIcon", MemberParameters = new object[]
		{
			typeof(Item),
			typeof(int),
			typeof(SpriteBatch),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(float),
			typeof(float),
			typeof(Microsoft.Xna.Framework.Graphics.Color)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Clear", ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilderExtensions), Member = "AppendInt", MemberParameters = new object[]
		{
			typeof(StringBuilder),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatManager), Member = "DrawStringWithShadow", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(SpriteFont),
			typeof(StringBuilder),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(Microsoft.Xna.Framework.Graphics.Color),
			typeof(float),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_expertMode", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatManager), Member = "DrawColorCodedStringWithShadow", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(SpriteFont),
			typeof(string),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(Microsoft.Xna.Framework.Graphics.Color),
			typeof(float),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "GetAlpha", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Graphics.Color) }, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "GetLerpValue", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 219)]
		public static void Draw(SpriteBatch spriteBatch, Item[] inv, int context, int slot, Microsoft.Xna.Framework.Vector2 position, Microsoft.Xna.Framework.Graphics.Color lightColor, Microsoft.Xna.Framework.Graphics.Color backColor)
		{
			throw null;
		}

		// Token: 0x0600353D RID: 13629 RVA: 0x0002B83E File Offset: 0x00029A3E
		[global::Cpp2ILInjected.Token(Token = "0x6003AAB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1467CFC", Offset = "0x1467CFC", Length = "0x260")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEquipment), Member = "AccessoryDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEquipment), Member = "AccessoryDyeDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEquipment), Member = "AccessoryVanityDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "Draw", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Item[]),
			typeof(int),
			typeof(int),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(Microsoft.Xna.Framework.Graphics.Color),
			typeof(Microsoft.Xna.Framework.Graphics.Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalPlayer", ReturnType = typeof(Player))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "TryGetSlotColor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref Microsoft.Xna.Framework.Graphics.Color)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Color), Member = "ToVector4", ReturnType = typeof(Microsoft.Xna.Framework.Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector4), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Microsoft.Xna.Framework.Vector4),
			typeof(Microsoft.Xna.Framework.Vector4)
		}, ReturnType = typeof(Microsoft.Xna.Framework.Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Color), Member = ".ctor", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector4) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Remap", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Color), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(Microsoft.Xna.Framework.Graphics.Color),
			typeof(Microsoft.Xna.Framework.Graphics.Color),
			typeof(float)
		}, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Color))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public static Microsoft.Xna.Framework.Graphics.Color GetColorByLoadout(int slot, int context)
		{
			throw null;
		}

		// Token: 0x0600353E RID: 13630 RVA: 0x0002B841 File Offset: 0x00029A41
		[global::Cpp2ILInjected.Token(Token = "0x6003AAC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1467F5C", Offset = "0x1467F5C", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "Draw", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Item[]),
			typeof(int),
			typeof(int),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(Microsoft.Xna.Framework.Graphics.Color),
			typeof(Microsoft.Xna.Framework.Graphics.Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalPlayer", ReturnType = typeof(Player))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "TryGetHighlightedSlotColor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref Microsoft.Xna.Framework.Graphics.Color)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static Microsoft.Xna.Framework.Graphics.Color GetHighlightColorByLoadout(int slot, int context)
		{
			throw null;
		}

		// Token: 0x0600353F RID: 13631 RVA: 0x0002B844 File Offset: 0x00029A44
		[global::Cpp2ILInjected.Token(Token = "0x6003AAD")]
		[global::Cpp2ILInjected.Address(RVA = "0x146872C", Offset = "0x146872C", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "TrySwitchingLoadout", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void RecordLoadoutChange()
		{
			throw null;
		}

		// Token: 0x06003540 RID: 13632 RVA: 0x0002B847 File Offset: 0x00029A47
		[global::Cpp2ILInjected.Token(Token = "0x6003AAE")]
		[global::Cpp2ILInjected.Address(RVA = "0x14685AC", Offset = "0x14685AC", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "GetColorByLoadout", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Color))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool TryGetSlotColor(int loadoutIndex, int context, out Microsoft.Xna.Framework.Graphics.Color color)
		{
			throw null;
		}

		// Token: 0x06003541 RID: 13633 RVA: 0x0002B84A File Offset: 0x00029A4A
		[global::Cpp2ILInjected.Token(Token = "0x6003AAF")]
		[global::Cpp2ILInjected.Address(RVA = "0x146866C", Offset = "0x146866C", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "GetHighlightColorByLoadout", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Color))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool TryGetHighlightedSlotColor(int loadoutIndex, int context, out Microsoft.Xna.Framework.Graphics.Color color)
		{
			throw null;
		}

		// Token: 0x06003542 RID: 13634 RVA: 0x0002B84D File Offset: 0x00029A4D
		[global::Cpp2ILInjected.Token(Token = "0x6003AB0")]
		[global::Cpp2ILInjected.Address(RVA = "0x14687B8", Offset = "0x14687B8", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static float ShiftHueByLoadout(float hue, int loadoutIndex)
		{
			throw null;
		}

		// Token: 0x06003543 RID: 13635 RVA: 0x0002B850 File Offset: 0x00029A50
		[global::Cpp2ILInjected.Token(Token = "0x6003AB1")]
		[global::Cpp2ILInjected.Address(RVA = "0x14687D0", Offset = "0x14687D0", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "hslToRgb", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(byte)
		}, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Color))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static Microsoft.Xna.Framework.Graphics.Color GetLoadoutColor(int loadoutIndex)
		{
			throw null;
		}

		// Token: 0x06003544 RID: 13636 RVA: 0x0002B853 File Offset: 0x00029A53
		[global::Cpp2ILInjected.Token(Token = "0x6003AB2")]
		[global::Cpp2ILInjected.Address(RVA = "0x146803C", Offset = "0x146803C", Length = "0x570")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "Draw", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Item[]),
			typeof(int),
			typeof(int),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(Microsoft.Xna.Framework.Graphics.Color),
			typeof(Microsoft.Xna.Framework.Graphics.Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemTransferParticle), Member = "Draw", MemberParameters = new object[]
		{
			typeof(ref ParticleRendererSettings),
			typeof(SpriteBatch)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawSpecialTilesLegacy", MemberParameters = new object[]
		{
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(Microsoft.Xna.Framework.Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIItemIcon), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "LoadItem", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Frame", MemberParameters = new object[]
		{
			typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "DrawItem_GetColorAndScale", MemberParameters = new object[]
		{
			typeof(Item),
			typeof(float),
			typeof(ref Microsoft.Xna.Framework.Graphics.Color),
			typeof(float),
			typeof(ref Rectangle),
			typeof(ref Microsoft.Xna.Framework.Graphics.Color),
			typeof(ref float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(float)
		}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle?), Member = ".ctor", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "GetAlpha", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Graphics.Color) }, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(Rectangle?),
			typeof(Microsoft.Xna.Framework.Graphics.Color),
			typeof(float),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(float),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Color), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Microsoft.Xna.Framework.Graphics.Color),
			typeof(Microsoft.Xna.Framework.Graphics.Color)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "GetColor", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Graphics.Color) }, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		public static float DrawItemIcon(Item item, int context, SpriteBatch spriteBatch, Microsoft.Xna.Framework.Vector2 screenPositionForItemCenter, float scale, float sizeLimit, Microsoft.Xna.Framework.Graphics.Color environmentColor)
		{
			throw null;
		}

		// Token: 0x06003545 RID: 13637 RVA: 0x0002B856 File Offset: 0x00029A56
		[global::Cpp2ILInjected.Token(Token = "0x6003AB3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1468890", Offset = "0x1468890", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawItemIcon", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Item),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(Microsoft.Xna.Framework.Graphics.Color),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "DrawItemIcon", MemberParameters = new object[]
		{
			typeof(Item),
			typeof(int),
			typeof(SpriteBatch),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(float),
			typeof(float),
			typeof(Microsoft.Xna.Framework.Graphics.Color)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "GetItemLight", MemberParameters = new object[]
		{
			typeof(ref Microsoft.Xna.Framework.Graphics.Color),
			typeof(ref float),
			typeof(Item),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void DrawItem_GetColorAndScale(Item item, float scale, ref Microsoft.Xna.Framework.Graphics.Color currentWhite, float sizeLimit, ref Rectangle frame, out Microsoft.Xna.Framework.Graphics.Color itemLight, out float finalDrawScale)
		{
			throw null;
		}

		// Token: 0x06003546 RID: 13638 RVA: 0x0002B859 File Offset: 0x00029A59
		[global::Cpp2ILInjected.Token(Token = "0x6003AB4")]
		[global::Cpp2ILInjected.Address(RVA = "0x14689F8", Offset = "0x14689F8", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "MouseHover", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static void MouseHover(int context = 0)
		{
			throw null;
		}

		// Token: 0x06003547 RID: 13639 RVA: 0x0002B85C File Offset: 0x00029A5C
		[global::Cpp2ILInjected.Token(Token = "0x6003AB5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1468ACC", Offset = "0x1468ACC", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICraftGuide), Member = "GuideItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIReforge), Member = "ReforgeItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIResearchPage), Member = "ResearchItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUITrashCan), Member = "ItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIDynamicItemCollection), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIItemSlot), Member = "HandleItemSlotLogic", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "MouseHover", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static void MouseHover(ref Item inv, int context = 0)
		{
			throw null;
		}

		// Token: 0x06003548 RID: 13640 RVA: 0x0002B85F File Offset: 0x00029A5F
		[global::Cpp2ILInjected.Token(Token = "0x6003AB6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1468B8C", Offset = "0x1468B8C", Length = "0x1B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUITransactionButton), Member = "Draw", MemberParameters = new object[]
		{
			typeof(TransactionButton_Layout),
			typeof(GUITransactionButton.DrawItemHandler),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(string),
			typeof(bool),
			typeof(ref float),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(GUITransactionButton.InputState))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUITransactionButton), Member = "Draw", MemberParameters = new object[]
		{
			typeof(TransactionButton_Layout),
			typeof(Item),
			typeof(string),
			typeof(bool),
			typeof(ref float),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(GUITransactionButton.InputState))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUITransactionButton), Member = "Draw", MemberParameters = new object[]
		{
			typeof(TransactionButton_Layout),
			typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
			typeof(Rectangle),
			typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
			typeof(Rectangle),
			typeof(string),
			typeof(bool),
			typeof(ref float),
			typeof(Microsoft.Xna.Framework.Graphics.Color?),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(GUITransactionButton.InputState))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUIInputLayer), Member = "GetUICursor", ReturnType = typeof(global::Cursor))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUIInputLayer), Member = "ResetTimeWithoutCursor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public static void UpdateTooltipButton(TransactionButton_Layout button)
		{
			throw null;
		}

		// Token: 0x06003549 RID: 13641 RVA: 0x0002B862 File Offset: 0x00029A62
		[global::Cpp2ILInjected.Token(Token = "0x6003AB7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1468D3C", Offset = "0x1468D3C", Length = "0x1BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIAccessoryInfoToggles), Member = "InfoAccOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "DropDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBuffs), Member = "ItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBuilderAccToggles), Member = "ItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICraftGuide), Member = "GuideItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICraftGuidePopup), Member = "MaterialItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICraftGuidePopup), Member = "CraftItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICrafting), Member = "CraftItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICrafting), Member = "MaterialItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEquipment), Member = "DrawArmourBonus", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEquipmentLoadout), Member = "LoadoutOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHotbar), Member = "ItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHousingMenu), Member = "NPCOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIItemDuplication), Member = "CraftItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPVPIcons), Member = "TeamOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPVPIcons), Member = "PlayerOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIReforge), Member = "ReforgeItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIRubbleMaker), Member = "MaterialItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "MouseHover", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 19)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUIInputLayer), Member = "GetUICursor", ReturnType = typeof(global::Cursor))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUIInputLayer), Member = "ResetTimeWithoutCursor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public static void UpdateTooltipContext(int context, int slot)
		{
			throw null;
		}

		// Token: 0x0600354A RID: 13642 RVA: 0x0002B865 File Offset: 0x00029A65
		[global::Cpp2ILInjected.Token(Token = "0x6003AB8")]
		[global::Cpp2ILInjected.Address(RVA = "0x145F7C8", Offset = "0x145F7C8", Length = "0x6C8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIAmmo), Member = "ItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIChest), Member = "ItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICoins), Member = "ItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIDisplayDoll), Member = "ItemOver", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			"GUIDisplayDoll.EquipmentItemType",
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEquipment), Member = "ItemOver", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			"GUIEquipment.EquipmentItemType",
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHatRack), Member = "ItemOver", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			"GUIHatRack.EquipmentItemType",
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInventory), Member = "ItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIShop), Member = "ItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "Handle", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "MouseHover", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "MouseHover", MemberParameters = new object[]
		{
			typeof(ref Item),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_Name", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "Clone", ReturnType = typeof(Item))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "UpdateTooltipContext", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 41)]
		public static void MouseHover(Item[] inv, int context = 0, int slot = 0)
		{
			throw null;
		}

		// Token: 0x0600354B RID: 13643 RVA: 0x0002B868 File Offset: 0x00029A68
		[global::Cpp2ILInjected.Token(Token = "0x6003AB9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1468EF8", Offset = "0x1468EF8", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "SwapEquip", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static void SwapEquip(ref Item inv, int context = 0)
		{
			throw null;
		}

		// Token: 0x0600354C RID: 13644 RVA: 0x0002B86B File Offset: 0x00029A6B
		[global::Cpp2ILInjected.Token(Token = "0x6003ABA")]
		[global::Cpp2ILInjected.Address(RVA = "0x146331C", Offset = "0x146331C", Length = "0x588")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInventoryTransactions), Member = "EquipItem", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "RightClick", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "SwapEquip", MemberParameters = new object[]
		{
			typeof(ref Item),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_IsAir", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "DyeSwap", MemberParameters = new object[]
		{
			typeof(Item),
			typeof(ref bool)
		}, ReturnType = typeof(Item))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "EquipSwap", MemberParameters = new object[]
		{
			typeof(Item),
			typeof(Item[]),
			typeof(int),
			typeof(ref bool)
		}, ReturnType = typeof(Item))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementsHelper), Member = "HandleOnEquip", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(Item),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "ArmorSwap", MemberParameters = new object[]
		{
			typeof(Item),
			typeof(ref bool)
		}, ReturnType = typeof(Item))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "FindRecipes", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 34)]
		public static bool SwapEquip(Item[] inv, int context, int slot)
		{
			throw null;
		}

		// Token: 0x0600354D RID: 13645 RVA: 0x0002B86E File Offset: 0x00029A6E
		[global::Cpp2ILInjected.Token(Token = "0x6003ABB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1469770", Offset = "0x1469770", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "Equippable", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static bool Equippable(ref Item inv, int context = 0)
		{
			throw null;
		}

		// Token: 0x0600354E RID: 13646 RVA: 0x0002B871 File Offset: 0x00029A71
		[global::Cpp2ILInjected.Token(Token = "0x6003ABC")]
		[global::Cpp2ILInjected.Address(RVA = "0x146982C", Offset = "0x146982C", Length = "0x140")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "Equippable", MemberParameters = new object[]
		{
			typeof(ref Item),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static bool Equippable(Item[] inv, int context, int slot)
		{
			throw null;
		}

		// Token: 0x0600354F RID: 13647 RVA: 0x0002B874 File Offset: 0x00029A74
		[global::Cpp2ILInjected.Token(Token = "0x6003ABD")]
		[global::Cpp2ILInjected.Address(RVA = "0x146996C", Offset = "0x146996C", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemFilters.AAccessories), Member = "IsAnAccessoryOfType", MemberParameters = new object[]
		{
			typeof(Item),
			typeof(ItemFilters.AAccessories.AccessoriesCategory)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static bool IsMiscEquipment(Item item)
		{
			throw null;
		}

		// Token: 0x06003550 RID: 13648 RVA: 0x0002B877 File Offset: 0x00029A77
		[global::Cpp2ILInjected.Token(Token = "0x6003ABE")]
		[global::Cpp2ILInjected.Address(RVA = "0x14626DC", Offset = "0x14626DC", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIDisplayDoll), Member = "CanBeStored", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Item),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEquipment), Member = "CanBeStored", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Item),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "PickItemMovementAction", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			typeof(int),
			typeof(Item),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TEDisplayDoll), Member = "TryFitting", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "IsTheSameAs", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool AccCheck(Item[] itemCollection, Item item, int slot)
		{
			throw null;
		}

		// Token: 0x06003551 RID: 13649 RVA: 0x0002B87A File Offset: 0x00029A7A
		[global::Cpp2ILInjected.Token(Token = "0x6003ABF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1468FB8", Offset = "0x1468FB8", Length = "0x268")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "SwapEquip", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "Clone", ReturnType = typeof(Item))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "FindRecipes", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private static Item DyeSwap(Item item, out bool success)
		{
			throw null;
		}

		// Token: 0x06003552 RID: 13650 RVA: 0x0002B87D File Offset: 0x00029A7D
		[global::Cpp2ILInjected.Token(Token = "0x6003AC0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1469344", Offset = "0x1469344", Length = "0x42C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "SwapEquip", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "Clone", ReturnType = typeof(Item))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "FindRecipes", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "IsItemSlotUnlockedAndUsable", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "IsTheSameAs", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		private static Item ArmorSwap(Item item, out bool success)
		{
			throw null;
		}

		// Token: 0x06003553 RID: 13651 RVA: 0x0002B880 File Offset: 0x00029A80
		[global::Cpp2ILInjected.Token(Token = "0x6003AC1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1469220", Offset = "0x1469220", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "SwapEquip", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "Clone", ReturnType = typeof(Item))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "FindRecipes", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private static Item EquipSwap(Item item, Item[] inv, int slot, out bool success)
		{
			throw null;
		}

		// Token: 0x06003554 RID: 13652 RVA: 0x0002B883 File Offset: 0x00029A83
		[global::Cpp2ILInjected.Token(Token = "0x6003AC2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1469A60", Offset = "0x1469A60", Length = "0x7AC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "DrawCost", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(float),
			typeof(float),
			typeof(long),
			typeof(SpriteBatch)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "DrawSavings", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Panel_Layout),
			typeof(float),
			typeof(float),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(bool),
			typeof(SpriteBatch)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "DrawSavings", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(float),
			typeof(float),
			typeof(bool),
			typeof(SpriteBatch)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CoinLossRevengeSystem.RevengeMarker), Member = "UseMouseOver", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(ref string),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Microsoft.Xna.Framework.Graphics.Color),
			typeof(float)
		}, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "DrawBorderStringFourWay", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(SpriteFont),
			typeof(string),
			typeof(float),
			typeof(float),
			typeof(Microsoft.Xna.Framework.Graphics.Color),
			typeof(Microsoft.Xna.Framework.Graphics.Color),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatManager), Member = "GetStringSize", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(string),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(float)
		}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Graphics.Texture2D) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(float)
		}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(Rectangle?),
			typeof(Microsoft.Xna.Framework.Graphics.Color),
			typeof(float),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(float),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
		public static void DrawMoney(SpriteBatch sb, string text, float shopx, float shopy, int[] coinsArray, bool horizontal = false, SpriteBatch textSb = null)
		{
			throw null;
		}

		// Token: 0x06003555 RID: 13653 RVA: 0x0002B886 File Offset: 0x00029A86
		[global::Cpp2ILInjected.Token(Token = "0x6003AC3")]
		[global::Cpp2ILInjected.Address(RVA = "0x146A20C", Offset = "0x146A20C", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHairWindow), Member = "DrawBuyButton", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUINPCDialogue), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIReforgePopup), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIShop), Member = "DrawPurchaseButton", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageOptions), Member = "DrawSellButton", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "CoinsSplit", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(int[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "DrawMoney", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(string),
			typeof(float),
			typeof(float),
			typeof(int[]),
			typeof(bool),
			typeof(SpriteBatch)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static void DrawCost(SpriteBatch sb, float shopx, float shopy, long cost, SpriteBatch textSb = null)
		{
			throw null;
		}

		// Token: 0x06003556 RID: 13654 RVA: 0x0002B889 File Offset: 0x00029A89
		[global::Cpp2ILInjected.Token(Token = "0x6003AC4")]
		[global::Cpp2ILInjected.Address(RVA = "0x146A2F8", Offset = "0x146A2F8", Length = "0x924")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHairWindow), Member = "DrawButtons", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIReforge), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIReforgePopup), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIShop), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "CoinsCount", MemberParameters = new object[]
		{
			typeof(ref bool),
			typeof(Item[]),
			typeof(int[])
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "CoinsCombineStacks", MemberParameters = new object[]
		{
			typeof(ref bool),
			typeof(long[])
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_npcShop", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomCurrencyManager), Member = "GetCurrencyCount", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Panel_Layout),
			typeof(bool),
			typeof(Microsoft.Xna.Framework.Graphics.Color?),
			typeof(Microsoft.Xna.Framework.Graphics.Color?),
			typeof(Microsoft.Xna.Framework.Graphics.Color?)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(Microsoft.Xna.Framework.Vector2)
		}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Graphics.Texture2D) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(float)
		}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "CenteredRectangle", MemberParameters = new object[]
		{
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(Microsoft.Xna.Framework.Vector2)
		}, ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
			typeof(Rectangle),
			typeof(Rectangle?),
			typeof(Microsoft.Xna.Framework.Graphics.Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(long), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "DrawBorderStringFourWay", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(SpriteFont),
			typeof(string),
			typeof(float),
			typeof(float),
			typeof(Microsoft.Xna.Framework.Graphics.Color),
			typeof(Microsoft.Xna.Framework.Graphics.Color),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "CoinsSplit", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(int[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "DrawMoney", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(string),
			typeof(float),
			typeof(float),
			typeof(int[]),
			typeof(bool),
			typeof(SpriteBatch)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 49)]
		public static void DrawSavings(SpriteBatch sb, Panel_Layout savingsBacking, float shopx, float shopy, Microsoft.Xna.Framework.Vector2 savings1IconOffset, Microsoft.Xna.Framework.Vector2 savings2Offset, Microsoft.Xna.Framework.Vector2 savings3Offset, Microsoft.Xna.Framework.Vector2 savings4Offset, bool horizontal = false, SpriteBatch textSb = null)
		{
			throw null;
		}

		// Token: 0x06003557 RID: 13655 RVA: 0x0002B88C File Offset: 0x00029A8C
		[global::Cpp2ILInjected.Token(Token = "0x6003AC5")]
		[global::Cpp2ILInjected.Address(RVA = "0x146AC1C", Offset = "0x146AC1C", Length = "0x5C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomCurrencyManager), Member = "DrawSavings", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "CoinsCount", MemberParameters = new object[]
		{
			typeof(ref bool),
			typeof(Item[]),
			typeof(int[])
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "CoinsCombineStacks", MemberParameters = new object[]
		{
			typeof(ref bool),
			typeof(long[])
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "LoadItem", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Graphics.Texture2D) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(float)
		}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "CenteredRectangle", MemberParameters = new object[]
		{
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(Microsoft.Xna.Framework.Vector2)
		}, ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
			typeof(Rectangle),
			typeof(Rectangle?),
			typeof(Microsoft.Xna.Framework.Graphics.Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "CoinsSplit", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(int[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "DrawMoney", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(string),
			typeof(float),
			typeof(float),
			typeof(int[]),
			typeof(bool),
			typeof(SpriteBatch)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 36)]
		public static void DrawSavings(SpriteBatch sb, float shopx, float shopy, bool horizontal = false, SpriteBatch textSb = null)
		{
			throw null;
		}

		// Token: 0x06003558 RID: 13656 RVA: 0x0002B88F File Offset: 0x00029A8F
		[global::Cpp2ILInjected.Token(Token = "0x6003AC6")]
		[global::Cpp2ILInjected.Address(RVA = "0x146B1E0", Offset = "0x146B1E0", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_27_HeldItem", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "GetItemLight", MemberParameters = new object[]
		{
			typeof(ref Microsoft.Xna.Framework.Graphics.Color),
			typeof(ref float),
			typeof(Item),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void GetItemLight(ref Microsoft.Xna.Framework.Graphics.Color currentColor, Item item, bool outInTheWorld = false)
		{
			throw null;
		}

		// Token: 0x06003559 RID: 13657 RVA: 0x0002B892 File Offset: 0x00029A92
		[global::Cpp2ILInjected.Token(Token = "0x6003AC7")]
		[global::Cpp2ILInjected.Address(RVA = "0x146B264", Offset = "0x146B264", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIQuickActionButton), Member = "CanInteract", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(Item),
			typeof(ref Microsoft.Xna.Framework.Graphics.Texture2D),
			typeof(ref Rectangle),
			typeof(ref bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawInterface_40_InteractItemIcon", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "GetItemLight", MemberParameters = new object[]
		{
			typeof(ref Microsoft.Xna.Framework.Graphics.Color),
			typeof(ref float),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Color))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void GetItemLight(ref Microsoft.Xna.Framework.Graphics.Color currentColor, int type, bool outInTheWorld = false)
		{
			throw null;
		}

		// Token: 0x0600355A RID: 13658 RVA: 0x0002B895 File Offset: 0x00029A95
		[global::Cpp2ILInjected.Token(Token = "0x6003AC8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1468984", Offset = "0x1468984", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUITransactionButton), Member = "Draw", MemberParameters = new object[]
		{
			typeof(TransactionButton_Layout),
			typeof(Item),
			typeof(string),
			typeof(bool),
			typeof(ref float),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(GUITransactionButton.InputState))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICraftGuidePopup), Member = "DrawItem", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICrafting), Member = "MaterialItemTooltipDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICrafting), Member = "MaterialItemDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInventory), Member = "DrawItem", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(ItemGrid_Layout),
			typeof(Item[]),
			typeof(int),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(Microsoft.Xna.Framework.Graphics.Color),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIReforgePopup), Member = "DrawItem", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIResearch), Member = "DrawResearchItem", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawItem", MemberParameters = new object[]
		{
			typeof(Item),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "DrawItem_GetColorAndScale", MemberParameters = new object[]
		{
			typeof(Item),
			typeof(float),
			typeof(ref Microsoft.Xna.Framework.Graphics.Color),
			typeof(float),
			typeof(ref Rectangle),
			typeof(ref Microsoft.Xna.Framework.Graphics.Color),
			typeof(ref float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "GetItemLight", MemberParameters = new object[]
		{
			typeof(ref Microsoft.Xna.Framework.Graphics.Color),
			typeof(Item),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawSpecialTilesLegacy", MemberParameters = new object[]
		{
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(Microsoft.Xna.Framework.Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "GetItemLight", MemberParameters = new object[]
		{
			typeof(ref Microsoft.Xna.Framework.Graphics.Color),
			typeof(ref float),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Color))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void GetItemLight(ref Microsoft.Xna.Framework.Graphics.Color currentColor, ref float scale, Item item, bool outInTheWorld = false)
		{
			throw null;
		}

		// Token: 0x0600355B RID: 13659 RVA: 0x0002B898 File Offset: 0x00029A98
		[global::Cpp2ILInjected.Token(Token = "0x6003AC9")]
		[global::Cpp2ILInjected.Address(RVA = "0x146B2DC", Offset = "0x146B2DC", Length = "0x238")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIQuickActionButton), Member = "Draw", MemberParameters = new object[]
		{
			typeof(QuickActionButton_Layout.QuickActionControl),
			typeof(QuickActionButton_Layout),
			typeof(bool),
			typeof(ref float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHotbar), Member = "DrawHotbarItem", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(ItemGrid_Layout),
			typeof(Item[]),
			typeof(int),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(Microsoft.Xna.Framework.Graphics.Color),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "GetItemLight", MemberParameters = new object[]
		{
			typeof(ref Microsoft.Xna.Framework.Graphics.Color),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "GetItemLight", MemberParameters = new object[]
		{
			typeof(ref Microsoft.Xna.Framework.Graphics.Color),
			typeof(ref float),
			typeof(Item),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static Microsoft.Xna.Framework.Graphics.Color GetItemLight(ref Microsoft.Xna.Framework.Graphics.Color currentColor, ref float scale, int type, bool outInTheWorld = false)
		{
			throw null;
		}

		// Token: 0x0600355C RID: 13660 RVA: 0x0002B89B File Offset: 0x00029A9B
		[global::Cpp2ILInjected.Token(Token = "0x6003ACA")]
		[global::Cpp2ILInjected.Address(RVA = "0x146B514", Offset = "0x146B514", Length = "0x590")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "get_UsingGamepad", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "get_Triggers", ReturnType = typeof(TriggersPack))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TriggersSet), Member = "get_RadialHotbar", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Clamp", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Microsoft.Xna.Framework.Graphics.Color),
			typeof(float)
		}, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "RotatedBy", MemberParameters = new object[]
		{
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(double),
			typeof(Microsoft.Xna.Framework.Vector2)
		}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(float)
		}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(Microsoft.Xna.Framework.Vector2)
		}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Graphics.Texture2D) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(float)
		}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(Rectangle?),
			typeof(Microsoft.Xna.Framework.Graphics.Color),
			typeof(float),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(float),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_inventoryScale", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_inventoryScale", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "Draw", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Item[]),
			typeof(int),
			typeof(int),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(Microsoft.Xna.Framework.Graphics.Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		public static void DrawRadialCircular(SpriteBatch sb, Microsoft.Xna.Framework.Vector2 position, Player.SelectionRadial radial, Item[] items)
		{
			throw null;
		}

		// Token: 0x0600355D RID: 13661 RVA: 0x0002B89E File Offset: 0x00029A9E
		[global::Cpp2ILInjected.Token(Token = "0x6003ACB")]
		[global::Cpp2ILInjected.Address(RVA = "0x146BAA4", Offset = "0x146BAA4", Length = "0x820")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "get_UsingGamepad", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "get_Triggers", ReturnType = typeof(TriggersPack))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TriggersSet), Member = "get_RadialQuickbar", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Clamp", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Microsoft.Xna.Framework.Graphics.Color),
			typeof(float)
		}, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "QuickHeal_GetItemToUse", ReturnType = typeof(Item))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "QuickMana_GetItemToUse", ReturnType = typeof(Item))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "RotatedBy", MemberParameters = new object[]
		{
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(double),
			typeof(Microsoft.Xna.Framework.Vector2)
		}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(float)
		}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(Microsoft.Xna.Framework.Vector2)
		}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Graphics.Texture2D) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(float)
		}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(Rectangle?),
			typeof(Microsoft.Xna.Framework.Graphics.Color),
			typeof(float),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(float),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_inventoryScale", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_inventoryScale", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "Draw", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(ref Item),
			typeof(int),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(Microsoft.Xna.Framework.Graphics.Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 28)]
		public static void DrawRadialQuicks(SpriteBatch sb, Microsoft.Xna.Framework.Vector2 position)
		{
			throw null;
		}

		// Token: 0x0600355E RID: 13662 RVA: 0x0002B8A1 File Offset: 0x00029AA1
		[global::Cpp2ILInjected.Token(Token = "0x6003ACC")]
		[global::Cpp2ILInjected.Address(RVA = "0x146C2C4", Offset = "0x146C2C4", Length = "0x49C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "get_UsingGamepad", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInputProfile), Member = "UsingDpadHotbar", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Microsoft.Xna.Framework.Graphics.Color),
			typeof(float)
		}, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Graphics.Texture2D) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(float)
		}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_inventoryScale", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(Rectangle?),
			typeof(Microsoft.Xna.Framework.Graphics.Color),
			typeof(float),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(float),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "RotatedBy", MemberParameters = new object[]
		{
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(double),
			typeof(Microsoft.Xna.Framework.Vector2)
		}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(Microsoft.Xna.Framework.Vector2)
		}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "Draw", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Item[]),
			typeof(int),
			typeof(int),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(Microsoft.Xna.Framework.Graphics.Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		public static void DrawRadialDpad(SpriteBatch sb, Microsoft.Xna.Framework.Vector2 position)
		{
			throw null;
		}

		// Token: 0x0600355F RID: 13663 RVA: 0x0002B8A4 File Offset: 0x00029AA4
		[global::Cpp2ILInjected.Token(Token = "0x6003ACD")]
		[global::Cpp2ILInjected.Address(RVA = "0x146C760", Offset = "0x146C760", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = "HandleDpadSnap", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static bool IsABuildingItem(Item item)
		{
			throw null;
		}

		// Token: 0x06003560 RID: 13664 RVA: 0x0002B8A7 File Offset: 0x00029AA7
		[global::Cpp2ILInjected.Token(Token = "0x6003ACE")]
		[global::Cpp2ILInjected.Address(RVA = "0x146C798", Offset = "0x146C798", Length = "0x1B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_IsAir", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static void SelectEquipPage(Item item)
		{
			throw null;
		}

		// Token: 0x06003561 RID: 13665 RVA: 0x0002B8AA File Offset: 0x00029AAA
		[global::Cpp2ILInjected.Token(Token = "0x6003ACF")]
		[global::Cpp2ILInjected.Address(RVA = "0x146C948", Offset = "0x146C948", Length = "0x1008")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public ItemSlot()
		{
			throw null;
		}

		// Token: 0x04006657 RID: 26199
		[global::Cpp2ILInjected.Token(Token = "0x4007A74")]
		public static bool DrawGoldBGForCraftingMaterial;

		// Token: 0x04006658 RID: 26200
		[global::Cpp2ILInjected.Token(Token = "0x4007A75")]
		public static bool ShiftForcedOn;

		// Token: 0x04006659 RID: 26201
		[global::Cpp2ILInjected.Token(Token = "0x4007A76")]
		public static float[] inventoryGlowHue;

		// Token: 0x0400665A RID: 26202
		[global::Cpp2ILInjected.Token(Token = "0x4007A77")]
		public static int[] inventoryGlowTime;

		// Token: 0x0400665B RID: 26203
		[global::Cpp2ILInjected.Token(Token = "0x4007A78")]
		private static float[] inventoryGlowHueChest;

		// Token: 0x0400665C RID: 26204
		[global::Cpp2ILInjected.Token(Token = "0x4007A79")]
		private static int[] inventoryGlowTimeChest;

		// Token: 0x0400665D RID: 26205
		[global::Cpp2ILInjected.Token(Token = "0x4007A7A")]
		private static int _customCurrencyForSavings;

		// Token: 0x0400665E RID: 26206
		[global::Cpp2ILInjected.Token(Token = "0x4007A7B")]
		private static int additionalThrowVelocity;

		// Token: 0x0400665F RID: 26207
		[global::Cpp2ILInjected.Token(Token = "0x4007A7C")]
		public static bool DuplicationMode;

		// Token: 0x04006660 RID: 26208
		[global::Cpp2ILInjected.Token(Token = "0x4007A7D")]
		private static int dyeSlotCount;

		// Token: 0x04006661 RID: 26209
		[global::Cpp2ILInjected.Token(Token = "0x4007A7E")]
		private static int accSlotToSwapTo;

		// Token: 0x04006662 RID: 26210
		[global::Cpp2ILInjected.Token(Token = "0x4007A7F")]
		public static float CircularRadialOpacity;

		// Token: 0x04006663 RID: 26211
		[global::Cpp2ILInjected.Token(Token = "0x4007A80")]
		public static float QuicksRadialOpacity;

		// Token: 0x04006664 RID: 26212
		[global::Cpp2ILInjected.Token(Token = "0x4007A81")]
		private static Item[] singleSlotArray;

		// Token: 0x04006665 RID: 26213
		[global::Cpp2ILInjected.Token(Token = "0x4007A82")]
		private static bool[] canFavoriteAt;

		// Token: 0x04006666 RID: 26214
		[global::Cpp2ILInjected.Token(Token = "0x4007A83")]
		private static bool[] canShareAt;

		// Token: 0x04006667 RID: 26215
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4007A84")]
		private static ItemSlot.ItemTransferEvent OnItemTransferred;

		// Token: 0x04006668 RID: 26216
		[global::Cpp2ILInjected.Token(Token = "0x4007A85")]
		public static bool forceClearGlowsOnChest;

		// Token: 0x04006669 RID: 26217
		[global::Cpp2ILInjected.Token(Token = "0x4007A86")]
		private static Item dummyItem;

		// Token: 0x0400666A RID: 26218
		[global::Cpp2ILInjected.Token(Token = "0x4007A87")]
		private static bool CursorHighlight;

		// Token: 0x0400666B RID: 26219
		[global::Cpp2ILInjected.Token(Token = "0x4007A88")]
		private static bool SelectHighlight;

		// Token: 0x0400666C RID: 26220
		[global::Cpp2ILInjected.Token(Token = "0x4007A89")]
		private static float HighlightScale;

		// Token: 0x0400666D RID: 26221
		[global::Cpp2ILInjected.Token(Token = "0x4007A8A")]
		private static float ForceRenderScale;

		// Token: 0x0400666E RID: 26222
		[global::Cpp2ILInjected.Token(Token = "0x4007A8B")]
		private static double _lastTimeForVisualEffectsThatLoadoutWasChanged;

		// Token: 0x0400666F RID: 26223
		[global::Cpp2ILInjected.Token(Token = "0x4007A8C")]
		private static Microsoft.Xna.Framework.Graphics.Color[,] LoadoutSlotColors;

		// Token: 0x04006670 RID: 26224
		[global::Cpp2ILInjected.Token(Token = "0x4007A8D")]
		private static Microsoft.Xna.Framework.Graphics.Color[,] LoadoutHighlightSlotColors;

		// Token: 0x04006671 RID: 26225
		[global::Cpp2ILInjected.Token(Token = "0x4007A8E")]
		private static int LastHoverContext;

		// Token: 0x04006672 RID: 26226
		[global::Cpp2ILInjected.Token(Token = "0x4007A8F")]
		private static int LastHoverSlot;

		// Token: 0x04006673 RID: 26227
		[global::Cpp2ILInjected.Token(Token = "0x4007A90")]
		private static TransactionButton_Layout LastHoverButton;

		// Token: 0x04006674 RID: 26228
		[global::Cpp2ILInjected.Token(Token = "0x4007A91")]
		private static int LastButtonFrame;

		// Token: 0x04006675 RID: 26229
		[global::Cpp2ILInjected.Token(Token = "0x4007A92")]
		private static Microsoft.Xna.Framework.Vector2 defenderTextOffset;

		// Token: 0x04006676 RID: 26230
		[global::Cpp2ILInjected.Token(Token = "0x4007A93")]
		private static Microsoft.Xna.Framework.Vector2 defenderPigOffset;

		// Token: 0x0200094D RID: 2381
		[global::Cpp2ILInjected.Token(Token = "0x20006D3")]
		public class Options
		{
			// Token: 0x170008AF RID: 2223
			// (get) Token: 0x06004CE3 RID: 19683 RVA: 0x0002F97E File Offset: 0x0002DB7E
			// (set) Token: 0x06004CE4 RID: 19684 RVA: 0x0002F981 File Offset: 0x0002DB81
			[global::Cpp2ILInjected.Token(Token = "0x17000753")]
			public static bool DisableLeftShiftTrashCan
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003AD0")]
				[global::Cpp2ILInjected.Address(RVA = "0x14716EC", Offset = "0x14716EC", Length = "0x4C")]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPulldownSetting), Member = "GetValue", ReturnType = typeof(string))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIToggleSetting), Member = "GetSelected", ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIToggleSetting), Member = "Toggle", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "SaveSettings", ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "OverrideHover", MemberParameters = new object[]
				{
					typeof(Item[]),
					typeof(int),
					typeof(int)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "DisableTrashing", ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "LeftClick_SellOrTrash", MemberParameters = new object[]
				{
					typeof(Item[]),
					typeof(int),
					typeof(int)
				}, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				get
				{
					throw null;
				}
				[global::Cpp2ILInjected.Token(Token = "0x6003AD1")]
				[global::Cpp2ILInjected.Address(RVA = "0x1471738", Offset = "0x1471738", Length = "0x50")]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsOverlay), Member = "ResetSetting", MemberParameters = new object[] { typeof(GUISettingID) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPulldownSetting), Member = "SetOption", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIToggleSetting), Member = "Toggle", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "LoadSettings", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				set
				{
					throw null;
				}
			}

			// Token: 0x170008B0 RID: 2224
			// (get) Token: 0x06004CE5 RID: 19685 RVA: 0x0002F984 File Offset: 0x0002DB84
			// (set) Token: 0x06004CE6 RID: 19686 RVA: 0x0002F987 File Offset: 0x0002DB87
			[global::Cpp2ILInjected.Token(Token = "0x17000754")]
			public static bool HighlightNewItems
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003AD2")]
				[global::Cpp2ILInjected.Address(RVA = "0x1471788", Offset = "0x1471788", Length = "0x4C")]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInventory), Member = "DrawItem", MemberParameters = new object[]
				{
					typeof(SpriteBatch),
					typeof(ItemGrid_Layout),
					typeof(Item[]),
					typeof(int),
					typeof(Microsoft.Xna.Framework.Vector2),
					typeof(Microsoft.Xna.Framework.Graphics.Color),
					typeof(float)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIToggleSetting), Member = "GetSelected", ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIToggleSetting), Member = "Toggle", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "NewItem", MemberParameters = new object[]
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
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "SaveSettings", ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageBuffer), Member = "ProcessData", MemberParameters = new object[]
				{
					typeof(byte[]),
					typeof(int),
					typeof(ref int)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ToggleInv", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "Draw", MemberParameters = new object[]
				{
					typeof(SpriteBatch),
					typeof(Item[]),
					typeof(int),
					typeof(int),
					typeof(Microsoft.Xna.Framework.Vector2),
					typeof(Microsoft.Xna.Framework.Graphics.Color),
					typeof(Microsoft.Xna.Framework.Graphics.Color)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				get
				{
					throw null;
				}
				[global::Cpp2ILInjected.Token(Token = "0x6003AD3")]
				[global::Cpp2ILInjected.Address(RVA = "0x14717D4", Offset = "0x14717D4", Length = "0x50")]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsOverlay), Member = "ResetSetting", MemberParameters = new object[] { typeof(GUISettingID) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIToggleSetting), Member = "Toggle", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "LoadSettings", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				set
				{
					throw null;
				}
			}

			// Token: 0x170008B1 RID: 2225
			// (get) Token: 0x06004CE7 RID: 19687 RVA: 0x0002F98A File Offset: 0x0002DB8A
			// (set) Token: 0x06004CE8 RID: 19688 RVA: 0x0002F98D File Offset: 0x0002DB8D
			[global::Cpp2ILInjected.Token(Token = "0x17000755")]
			public static bool DisableQuickTrash
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003AD4")]
				[global::Cpp2ILInjected.Address(RVA = "0x1471824", Offset = "0x1471824", Length = "0x4C")]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "OverrideHover", MemberParameters = new object[]
				{
					typeof(Item[]),
					typeof(int),
					typeof(int)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "LeftClick_SellOrTrash", MemberParameters = new object[]
				{
					typeof(Item[]),
					typeof(int),
					typeof(int)
				}, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				get
				{
					throw null;
				}
				[global::Cpp2ILInjected.Token(Token = "0x6003AD5")]
				[global::Cpp2ILInjected.Address(RVA = "0x1471870", Offset = "0x1471870", Length = "0x50")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				set
				{
					throw null;
				}
			}

			// Token: 0x06004CE9 RID: 19689 RVA: 0x0002F990 File Offset: 0x0002DB90
			[global::Cpp2ILInjected.Token(Token = "0x6003AD6")]
			[global::Cpp2ILInjected.Address(RVA = "0x14718C0", Offset = "0x14718C0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public Options()
			{
				throw null;
			}
		}

		// Token: 0x0200094E RID: 2382
		[global::Cpp2ILInjected.Token(Token = "0x20006D4")]
		public enum GUIFakeTooltipContext
		{
			// Token: 0x04008AFD RID: 35581
			[global::Cpp2ILInjected.Token(Token = "0x4007A95")]
			DefenseIcon = 36,
			// Token: 0x04008AFE RID: 35582
			[global::Cpp2ILInjected.Token(Token = "0x4007A96")]
			HousingMenu,
			// Token: 0x04008AFF RID: 35583
			[global::Cpp2ILInjected.Token(Token = "0x4007A97")]
			PVPMenu,
			// Token: 0x04008B00 RID: 35584
			[global::Cpp2ILInjected.Token(Token = "0x4007A98")]
			ItemDuplication,
			// Token: 0x04008B01 RID: 35585
			[global::Cpp2ILInjected.Token(Token = "0x4007A99")]
			CraftGuide,
			// Token: 0x04008B02 RID: 35586
			[global::Cpp2ILInjected.Token(Token = "0x4007A9A")]
			BestiaryDrop,
			// Token: 0x04008B03 RID: 35587
			[global::Cpp2ILInjected.Token(Token = "0x4007A9B")]
			Reforge,
			// Token: 0x04008B04 RID: 35588
			[global::Cpp2ILInjected.Token(Token = "0x4007A9C")]
			Team,
			// Token: 0x04008B05 RID: 35589
			[global::Cpp2ILInjected.Token(Token = "0x4007A9D")]
			AccessoryInfo,
			// Token: 0x04008B06 RID: 35590
			[global::Cpp2ILInjected.Token(Token = "0x4007A9E")]
			BuilderAccessories,
			// Token: 0x04008B07 RID: 35591
			[global::Cpp2ILInjected.Token(Token = "0x4007A9F")]
			Hotbar,
			// Token: 0x04008B08 RID: 35592
			[global::Cpp2ILInjected.Token(Token = "0x4007AA0")]
			Buffs,
			// Token: 0x04008B09 RID: 35593
			[global::Cpp2ILInjected.Token(Token = "0x4007AA1")]
			Loadout
		}

		// Token: 0x0200094F RID: 2383
		[global::Cpp2ILInjected.Token(Token = "0x20006D5")]
		public class Context
		{
			// Token: 0x06004CEA RID: 19690 RVA: 0x0002F993 File Offset: 0x0002DB93
			[global::Cpp2ILInjected.Token(Token = "0x6003AD7")]
			[global::Cpp2ILInjected.Address(RVA = "0x14718C8", Offset = "0x14718C8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public Context()
			{
				throw null;
			}

			// Token: 0x04008B0A RID: 35594
			[global::Cpp2ILInjected.Token(Token = "0x4007AA2")]
			public const int InventoryItem = 0;

			// Token: 0x04008B0B RID: 35595
			[global::Cpp2ILInjected.Token(Token = "0x4007AA3")]
			public const int InventoryCoin = 1;

			// Token: 0x04008B0C RID: 35596
			[global::Cpp2ILInjected.Token(Token = "0x4007AA4")]
			public const int InventoryAmmo = 2;

			// Token: 0x04008B0D RID: 35597
			[global::Cpp2ILInjected.Token(Token = "0x4007AA5")]
			public const int ChestItem = 3;

			// Token: 0x04008B0E RID: 35598
			[global::Cpp2ILInjected.Token(Token = "0x4007AA6")]
			public const int BankItem = 4;

			// Token: 0x04008B0F RID: 35599
			[global::Cpp2ILInjected.Token(Token = "0x4007AA7")]
			public const int PrefixItem = 5;

			// Token: 0x04008B10 RID: 35600
			[global::Cpp2ILInjected.Token(Token = "0x4007AA8")]
			public const int TrashItem = 6;

			// Token: 0x04008B11 RID: 35601
			[global::Cpp2ILInjected.Token(Token = "0x4007AA9")]
			public const int GuideItem = 7;

			// Token: 0x04008B12 RID: 35602
			[global::Cpp2ILInjected.Token(Token = "0x4007AAA")]
			public const int EquipArmor = 8;

			// Token: 0x04008B13 RID: 35603
			[global::Cpp2ILInjected.Token(Token = "0x4007AAB")]
			public const int EquipArmorVanity = 9;

			// Token: 0x04008B14 RID: 35604
			[global::Cpp2ILInjected.Token(Token = "0x4007AAC")]
			public const int EquipAccessory = 10;

			// Token: 0x04008B15 RID: 35605
			[global::Cpp2ILInjected.Token(Token = "0x4007AAD")]
			public const int EquipAccessoryVanity = 11;

			// Token: 0x04008B16 RID: 35606
			[global::Cpp2ILInjected.Token(Token = "0x4007AAE")]
			public const int EquipDye = 12;

			// Token: 0x04008B17 RID: 35607
			[global::Cpp2ILInjected.Token(Token = "0x4007AAF")]
			public const int HotbarItem = 13;

			// Token: 0x04008B18 RID: 35608
			[global::Cpp2ILInjected.Token(Token = "0x4007AB0")]
			public const int ChatItem = 14;

			// Token: 0x04008B19 RID: 35609
			[global::Cpp2ILInjected.Token(Token = "0x4007AB1")]
			public const int ShopItem = 15;

			// Token: 0x04008B1A RID: 35610
			[global::Cpp2ILInjected.Token(Token = "0x4007AB2")]
			public const int EquipGrapple = 16;

			// Token: 0x04008B1B RID: 35611
			[global::Cpp2ILInjected.Token(Token = "0x4007AB3")]
			public const int EquipMount = 17;

			// Token: 0x04008B1C RID: 35612
			[global::Cpp2ILInjected.Token(Token = "0x4007AB4")]
			public const int EquipMinecart = 18;

			// Token: 0x04008B1D RID: 35613
			[global::Cpp2ILInjected.Token(Token = "0x4007AB5")]
			public const int EquipPet = 19;

			// Token: 0x04008B1E RID: 35614
			[global::Cpp2ILInjected.Token(Token = "0x4007AB6")]
			public const int EquipLight = 20;

			// Token: 0x04008B1F RID: 35615
			[global::Cpp2ILInjected.Token(Token = "0x4007AB7")]
			public const int MouseItem = 21;

			// Token: 0x04008B20 RID: 35616
			[global::Cpp2ILInjected.Token(Token = "0x4007AB8")]
			public const int CraftingMaterial = 22;

			// Token: 0x04008B21 RID: 35617
			[global::Cpp2ILInjected.Token(Token = "0x4007AB9")]
			public const int DisplayDollArmor = 23;

			// Token: 0x04008B22 RID: 35618
			[global::Cpp2ILInjected.Token(Token = "0x4007ABA")]
			public const int DisplayDollAccessory = 24;

			// Token: 0x04008B23 RID: 35619
			[global::Cpp2ILInjected.Token(Token = "0x4007ABB")]
			public const int DisplayDollDye = 25;

			// Token: 0x04008B24 RID: 35620
			[global::Cpp2ILInjected.Token(Token = "0x4007ABC")]
			public const int HatRackHat = 26;

			// Token: 0x04008B25 RID: 35621
			[global::Cpp2ILInjected.Token(Token = "0x4007ABD")]
			public const int HatRackDye = 27;

			// Token: 0x04008B26 RID: 35622
			[global::Cpp2ILInjected.Token(Token = "0x4007ABE")]
			public const int GoldDebug = 28;

			// Token: 0x04008B27 RID: 35623
			[global::Cpp2ILInjected.Token(Token = "0x4007ABF")]
			public const int CreativeInfinite = 29;

			// Token: 0x04008B28 RID: 35624
			[global::Cpp2ILInjected.Token(Token = "0x4007AC0")]
			public const int CreativeSacrifice = 30;

			// Token: 0x04008B29 RID: 35625
			[global::Cpp2ILInjected.Token(Token = "0x4007AC1")]
			public const int InWorld = 31;

			// Token: 0x04008B2A RID: 35626
			[global::Cpp2ILInjected.Token(Token = "0x4007AC2")]
			public const int VoidItem = 32;

			// Token: 0x04008B2B RID: 35627
			[global::Cpp2ILInjected.Token(Token = "0x4007AC3")]
			public const int EquipMiscDye = 33;

			// Token: 0x04008B2C RID: 35628
			[global::Cpp2ILInjected.Token(Token = "0x4007AC4")]
			public const int CreativeResearch = 34;

			// Token: 0x04008B2D RID: 35629
			[global::Cpp2ILInjected.Token(Token = "0x4007AC5")]
			public const int RubbleMaker = 35;

			// Token: 0x04008B2E RID: 35630
			[global::Cpp2ILInjected.Token(Token = "0x4007AC6")]
			public const int Count = 36;
		}

		// Token: 0x02000950 RID: 2384
		[global::Cpp2ILInjected.Token(Token = "0x20006D6")]
		public struct ItemTransferInfo
		{
			// Token: 0x06004CEB RID: 19691 RVA: 0x0002F996 File Offset: 0x0002DB96
			[global::Cpp2ILInjected.Token(Token = "0x6003AD8")]
			[global::Cpp2ILInjected.Address(RVA = "0x14718D0", Offset = "0x14718D0", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "LeftClick", MemberParameters = new object[]
			{
				typeof(Item[]),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "SellOrTrash", MemberParameters = new object[]
			{
				typeof(Item[]),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "PickupItemIntoMouse", MemberParameters = new object[]
			{
				typeof(Item[]),
				typeof(int),
				typeof(int),
				typeof(Player)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "HandleShopSlot", MemberParameters = new object[]
			{
				typeof(Item[]),
				typeof(int),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
			public ItemTransferInfo(Item itemAfter, int fromContext, int toContext, int transferAmount = 0)
			{
				throw null;
			}

			// Token: 0x04008B2F RID: 35631
			[global::Cpp2ILInjected.Token(Token = "0x4007AC7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int ItemType;

			// Token: 0x04008B30 RID: 35632
			[global::Cpp2ILInjected.Token(Token = "0x4007AC8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
			public int TransferAmount;

			// Token: 0x04008B31 RID: 35633
			[global::Cpp2ILInjected.Token(Token = "0x4007AC9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public int FromContenxt;

			// Token: 0x04008B32 RID: 35634
			[global::Cpp2ILInjected.Token(Token = "0x4007ACA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
			public int ToContext;
		}

		// Token: 0x02000951 RID: 2385
		// (Invoke) Token: 0x06004CED RID: 19693
		[global::Cpp2ILInjected.Token(Token = "0x20006D7")]
		public delegate void ItemTransferEvent(ItemSlot.ItemTransferInfo info);
	}
}
