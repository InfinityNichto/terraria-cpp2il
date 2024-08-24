using System;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.Audio;
using Terraria.Localization;
using Terraria.UI;
using UnityEngine;

// Token: 0x020000DC RID: 220
[global::Cpp2ILInjected.Token(Token = "0x200013E")]
public class GUIEquipment
{
	// Token: 0x170000B6 RID: 182
	// (get) Token: 0x0600077A RID: 1914 RVA: 0x000231B3 File Offset: 0x000213B3
	[global::Cpp2ILInjected.Token(Token = "0x170000DB")]
	public bool collapsed
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000874")]
		[global::Cpp2ILInjected.Address(RVA = "0x72C360", Offset = "0x72C360", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerEquipment4Page), Member = "GetNavigationOutDirs", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerEquipment4Page), Member = "Navigate", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerEquipment4Page), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerEquipment4Page), Member = "NavigateInto", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEquipment), Member = "LoadPageRegion", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEquipment), Member = "DrawArmour", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEquipment), Member = "DrawAccesories", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEquipment), Member = "DrawQuickSlots", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEquipment), Member = "DrawArmourBonus", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "DrawOptions", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "DrawEditOptions", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "IsOverGroupRegion", MemberParameters = new object[]
		{
			typeof(GUIPageIconGrouping),
			typeof(Point)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 22)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceStyles_Layout), Member = "get_Active", ReturnType = typeof(InterfaceProfile_Layout))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceProfile_Layout), Member = "IsCollapsed", MemberParameters = new object[] { typeof(GUIPageIcons.Category) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600077B RID: 1915 RVA: 0x000231B6 File Offset: 0x000213B6
	[global::Cpp2ILInjected.Token(Token = "0x6000875")]
	[global::Cpp2ILInjected.Address(RVA = "0x72C3BC", Offset = "0x72C3BC", Length = "0x314")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEquipment), Member = "DrawArmourBonus", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "LoadPageRegion", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIEquipment), Member = "get_collapsed", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid.GetItemScaleHandler), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid), Member = "CalculateRegion", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(GUIItemGrid.GetItemScaleHandler),
		typeof(int),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D)
	}, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Union", MemberParameters = new object[]
	{
		typeof(Rectangle),
		typeof(Rectangle)
	}, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlAnchor), Member = "set_PageContentRegion", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
	public void LoadPageRegion()
	{
		throw null;
	}

	// Token: 0x0600077C RID: 1916 RVA: 0x000231B9 File Offset: 0x000213B9
	[global::Cpp2ILInjected.Token(Token = "0x6000876")]
	[global::Cpp2ILInjected.Address(RVA = "0x72C6D0", Offset = "0x72C6D0", Length = "0x48")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public float ArmourScale(int index)
	{
		throw null;
	}

	// Token: 0x0600077D RID: 1917 RVA: 0x000231BC File Offset: 0x000213BC
	[global::Cpp2ILInjected.Token(Token = "0x6000877")]
	[global::Cpp2ILInjected.Address(RVA = "0x72C718", Offset = "0x72C718", Length = "0x48")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public float ArmourDyeScale(int index)
	{
		throw null;
	}

	// Token: 0x0600077E RID: 1918 RVA: 0x000231BF File Offset: 0x000213BF
	[global::Cpp2ILInjected.Token(Token = "0x6000878")]
	[global::Cpp2ILInjected.Address(RVA = "0x72C760", Offset = "0x72C760", Length = "0x48")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public float ArmourVanityScale(int index)
	{
		throw null;
	}

	// Token: 0x0600077F RID: 1919 RVA: 0x000231C2 File Offset: 0x000213C2
	[global::Cpp2ILInjected.Token(Token = "0x6000879")]
	[global::Cpp2ILInjected.Address(RVA = "0x72C7A8", Offset = "0x72C7A8", Length = "0x10C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	private bool ShouldShowMenu(GUIEquipment.EquipmentItemType type, int i)
	{
		throw null;
	}

	// Token: 0x06000780 RID: 1920 RVA: 0x000231C5 File Offset: 0x000213C5
	[global::Cpp2ILInjected.Token(Token = "0x600087A")]
	[global::Cpp2ILInjected.Address(RVA = "0x72C8B4", Offset = "0x72C8B4", Length = "0x8A4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEquipment), Member = "ArmourOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEquipment), Member = "ArmourDyeOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEquipment), Member = "ArmourVanityOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEquipment), Member = "AccessoryOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEquipment), Member = "AccessoryDyeOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEquipment), Member = "AccessoryVanityOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEquipment), Member = "QuickSlotOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEquipment), Member = "QuickSlotDyeOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUIInputLayer), Member = "GetUICursor", ReturnType = typeof(global::Cursor))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyboardInput), Member = "GetKey", MemberParameters = new object[] { typeof(KeyCode) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyboardInput), Member = "GetKeyDown", MemberParameters = new object[] { typeof(KeyCode) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeft", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseItem", ReturnType = typeof(Item))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mouseRight", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "RightClick", MemberParameters = new object[]
	{
		typeof(Item[]),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseRight", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMouseItem), Member = "get_HoldingItem", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMouseItem), Member = "get_IsItemDropped", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_IsAir", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeftRelease", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "FindRecipes", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(SoundEffectInstance))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "set_CurrentNavigationItem", MemberParameters = new object[] { typeof(GUIControllerItem) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "UpdateCursorPosition", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "LeftClick", MemberParameters = new object[]
	{
		typeof(Item[]),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "OverrideHover", MemberParameters = new object[]
	{
		typeof(Item[]),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "MouseHover", MemberParameters = new object[]
	{
		typeof(Item[]),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_cursorOverride", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
	private void ItemOver(Item[] inv, int index, GUIEquipment.EquipmentItemType equipmentType, int itemContext, ref int itemDragStart)
	{
		throw null;
	}

	// Token: 0x06000781 RID: 1921 RVA: 0x000231C8 File Offset: 0x000213C8
	[global::Cpp2ILInjected.Token(Token = "0x600087B")]
	[global::Cpp2ILInjected.Address(RVA = "0x72D158", Offset = "0x72D158", Length = "0x90")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIEquipment), Member = "ItemOver", MemberParameters = new object[]
	{
		typeof(Item[]),
		typeof(int),
		typeof(GUIEquipment.EquipmentItemType),
		typeof(int),
		typeof(ref int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public void ArmourOver(int index)
	{
		throw null;
	}

	// Token: 0x06000782 RID: 1922 RVA: 0x000231CB File Offset: 0x000213CB
	[global::Cpp2ILInjected.Token(Token = "0x600087C")]
	[global::Cpp2ILInjected.Address(RVA = "0x72D1E8", Offset = "0x72D1E8", Length = "0x45C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIEquipment), Member = "get_HasFocus", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "get_ControllerModeLocked", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_Equipment", ReturnType = typeof(GUIControllerEquipment))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "SetSelectHighlight", MemberParameters = new object[]
	{
		typeof(bool),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "IsMouseItem", MemberParameters = new object[]
	{
		typeof(Item[]),
		typeof(int)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseItem", ReturnType = typeof(Item))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIEquipment), Member = "CanBeStored", MemberParameters = new object[]
	{
		typeof(int),
		typeof(Item),
		typeof(int)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseItemTime", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AnimationCurve), Member = "Evaluate", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_inventoryScale", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "Draw", MemberParameters = new object[]
	{
		typeof(SpriteBatch),
		typeof(Item[]),
		typeof(int),
		typeof(int),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
	public void ArmourDraw(ItemGrid_Layout gridLayout, int index, Microsoft.Xna.Framework.Vector2 position, float scale)
	{
		throw null;
	}

	// Token: 0x06000783 RID: 1923 RVA: 0x000231CE File Offset: 0x000213CE
	[global::Cpp2ILInjected.Token(Token = "0x600087D")]
	[global::Cpp2ILInjected.Address(RVA = "0x72D9C8", Offset = "0x72D9C8", Length = "0x90")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIEquipment), Member = "ItemOver", MemberParameters = new object[]
	{
		typeof(Item[]),
		typeof(int),
		typeof(GUIEquipment.EquipmentItemType),
		typeof(int),
		typeof(ref int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public void ArmourDyeOver(int index)
	{
		throw null;
	}

	// Token: 0x06000784 RID: 1924 RVA: 0x000231D1 File Offset: 0x000213D1
	[global::Cpp2ILInjected.Token(Token = "0x600087E")]
	[global::Cpp2ILInjected.Address(RVA = "0x72DA58", Offset = "0x72DA58", Length = "0x440")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIEquipment), Member = "get_HasFocus", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "get_ControllerModeLocked", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_Equipment", ReturnType = typeof(GUIControllerEquipment))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "SetSelectHighlight", MemberParameters = new object[]
	{
		typeof(bool),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "IsMouseItem", MemberParameters = new object[]
	{
		typeof(Item[]),
		typeof(int)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseItem", ReturnType = typeof(Item))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIEquipment), Member = "CanBeStored", MemberParameters = new object[]
	{
		typeof(int),
		typeof(Item),
		typeof(int)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseItemTime", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AnimationCurve), Member = "Evaluate", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_inventoryScale", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "Draw", MemberParameters = new object[]
	{
		typeof(SpriteBatch),
		typeof(Item[]),
		typeof(int),
		typeof(int),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
	public void ArmourDyeDraw(ItemGrid_Layout gridLayout, int index, Microsoft.Xna.Framework.Vector2 position, float scale)
	{
		throw null;
	}

	// Token: 0x06000785 RID: 1925 RVA: 0x000231D4 File Offset: 0x000213D4
	[global::Cpp2ILInjected.Token(Token = "0x600087F")]
	[global::Cpp2ILInjected.Address(RVA = "0x72DE98", Offset = "0x72DE98", Length = "0x90")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIEquipment), Member = "ItemOver", MemberParameters = new object[]
	{
		typeof(Item[]),
		typeof(int),
		typeof(GUIEquipment.EquipmentItemType),
		typeof(int),
		typeof(ref int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public void ArmourVanityOver(int index)
	{
		throw null;
	}

	// Token: 0x06000786 RID: 1926 RVA: 0x000231D7 File Offset: 0x000213D7
	[global::Cpp2ILInjected.Token(Token = "0x6000880")]
	[global::Cpp2ILInjected.Address(RVA = "0x72DF28", Offset = "0x72DF28", Length = "0x464")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIEquipment), Member = "get_HasFocus", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "get_ControllerModeLocked", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_Equipment", ReturnType = typeof(GUIControllerEquipment))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "SetSelectHighlight", MemberParameters = new object[]
	{
		typeof(bool),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "IsMouseItem", MemberParameters = new object[]
	{
		typeof(Item[]),
		typeof(int)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseItem", ReturnType = typeof(Item))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIEquipment), Member = "CanBeStored", MemberParameters = new object[]
	{
		typeof(int),
		typeof(Item),
		typeof(int)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseItemTime", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AnimationCurve), Member = "Evaluate", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_inventoryScale", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "Draw", MemberParameters = new object[]
	{
		typeof(SpriteBatch),
		typeof(Item[]),
		typeof(int),
		typeof(int),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
	public void ArmourVanityDraw(ItemGrid_Layout gridLayout, int index, Microsoft.Xna.Framework.Vector2 position, float scale)
	{
		throw null;
	}

	// Token: 0x06000787 RID: 1927 RVA: 0x000231DA File Offset: 0x000213DA
	[global::Cpp2ILInjected.Token(Token = "0x6000881")]
	[global::Cpp2ILInjected.Address(RVA = "0x72E38C", Offset = "0x72E38C", Length = "0x1D0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "DrawOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageOptions), Member = "DrawEquipButton", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "IsTheSameAs", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public int CanBeEquipedAccessory(Item checkItem)
	{
		throw null;
	}

	// Token: 0x06000788 RID: 1928 RVA: 0x000231DD File Offset: 0x000213DD
	[global::Cpp2ILInjected.Token(Token = "0x6000882")]
	[global::Cpp2ILInjected.Address(RVA = "0x72E55C", Offset = "0x72E55C", Length = "0x13C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "DrawOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageOptions), Member = "DrawEquipButton", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	public bool CanBeEquiped(Item checkItem)
	{
		throw null;
	}

	// Token: 0x06000789 RID: 1929 RVA: 0x000231E0 File Offset: 0x000213E0
	[global::Cpp2ILInjected.Token(Token = "0x6000883")]
	[global::Cpp2ILInjected.Address(RVA = "0x72E698", Offset = "0x72E698", Length = "0x144")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InterfaceProfile_Layout), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	public bool CanBeStored(Item checkItem)
	{
		throw null;
	}

	// Token: 0x0600078A RID: 1930 RVA: 0x000231E3 File Offset: 0x000213E3
	[global::Cpp2ILInjected.Token(Token = "0x6000884")]
	[global::Cpp2ILInjected.Address(RVA = "0x72D6D8", Offset = "0x72D6D8", Length = "0x2F0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
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
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_FitsAccessoryVanitySlot", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalPlayer", ReturnType = typeof(Player))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "AccCheck", MemberParameters = new object[]
	{
		typeof(Item[]),
		typeof(Item),
		typeof(int)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
	private bool CanBeStored(int context, Item checkItem, int slot)
	{
		throw null;
	}

	// Token: 0x0600078B RID: 1931 RVA: 0x000231E6 File Offset: 0x000213E6
	[global::Cpp2ILInjected.Token(Token = "0x6000885")]
	[global::Cpp2ILInjected.Address(RVA = "0x72E7DC", Offset = "0x72E7DC", Length = "0x6E8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEquipment), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIEquipment), Member = "get_collapsed", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid.GetItemScaleHandler), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid.CursorOver), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid.DrawItemHandler), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid), Member = "Draw", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(GUIItemGrid.GetItemScaleHandler),
		typeof(GUIItemGrid.CursorOver),
		typeof(GUIItemGrid.DrawItemHandler),
		typeof(int),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeft", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseItem", ReturnType = typeof(Item))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "LeftClick", MemberParameters = new object[]
	{
		typeof(Item[]),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 44)]
	private void DrawArmour()
	{
		throw null;
	}

	// Token: 0x0600078C RID: 1932 RVA: 0x000231E9 File Offset: 0x000213E9
	[global::Cpp2ILInjected.Token(Token = "0x6000886")]
	[global::Cpp2ILInjected.Address(RVA = "0x72EEC4", Offset = "0x72EEC4", Length = "0x48")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public float AccessoryScale(int index)
	{
		throw null;
	}

	// Token: 0x0600078D RID: 1933 RVA: 0x000231EC File Offset: 0x000213EC
	[global::Cpp2ILInjected.Token(Token = "0x6000887")]
	[global::Cpp2ILInjected.Address(RVA = "0x72EF0C", Offset = "0x72EF0C", Length = "0x48")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public float AccessoryDyeScale(int index)
	{
		throw null;
	}

	// Token: 0x0600078E RID: 1934 RVA: 0x000231EF File Offset: 0x000213EF
	[global::Cpp2ILInjected.Token(Token = "0x6000888")]
	[global::Cpp2ILInjected.Address(RVA = "0x72EF54", Offset = "0x72EF54", Length = "0x48")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public float AccessoryVanityScale(int index)
	{
		throw null;
	}

	// Token: 0x0600078F RID: 1935 RVA: 0x000231F2 File Offset: 0x000213F2
	[global::Cpp2ILInjected.Token(Token = "0x6000889")]
	[global::Cpp2ILInjected.Address(RVA = "0x72EF9C", Offset = "0x72EF9C", Length = "0x140")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "CanDemonHeartAccessoryBeShown", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIEquipment), Member = "ItemOver", MemberParameters = new object[]
	{
		typeof(Item[]),
		typeof(int),
		typeof(GUIEquipment.EquipmentItemType),
		typeof(int),
		typeof(ref int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public void AccessoryOver(int index)
	{
		throw null;
	}

	// Token: 0x06000790 RID: 1936 RVA: 0x000231F5 File Offset: 0x000213F5
	[global::Cpp2ILInjected.Token(Token = "0x600088A")]
	[global::Cpp2ILInjected.Address(RVA = "0x72F0DC", Offset = "0x72F0DC", Length = "0xB7C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "CanDemonHeartAccessoryBeShown", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIEquipment), Member = "get_HasFocus", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "get_ControllerModeLocked", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_Equipment", ReturnType = typeof(GUIControllerEquipment))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "SetSelectHighlight", MemberParameters = new object[]
	{
		typeof(bool),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "IsMouseItem", MemberParameters = new object[]
	{
		typeof(Item[]),
		typeof(int)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseItem", ReturnType = typeof(Item))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIEquipment), Member = "CanBeStored", MemberParameters = new object[]
	{
		typeof(int),
		typeof(Item),
		typeof(int)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseItemTime", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AnimationCurve), Member = "Evaluate", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_inventoryScale", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Color), Member = "ToVector4", ReturnType = typeof(Microsoft.Xna.Framework.Vector4))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "GetColorByLoadout", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Color))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Graphics.Texture2D) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Division", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float)
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle?), Member = ".ctor", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "IsItemSlotUnlockedAndUsable", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "Draw", MemberParameters = new object[]
	{
		typeof(SpriteBatch),
		typeof(Item[]),
		typeof(int),
		typeof(int),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(void))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Subtraction", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 53)]
	public void AccessoryDraw(ItemGrid_Layout gridLayout, int index, Microsoft.Xna.Framework.Vector2 position, float scale)
	{
		throw null;
	}

	// Token: 0x06000791 RID: 1937 RVA: 0x000231F8 File Offset: 0x000213F8
	[global::Cpp2ILInjected.Token(Token = "0x600088B")]
	[global::Cpp2ILInjected.Address(RVA = "0x72FC58", Offset = "0x72FC58", Length = "0x140")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "CanDemonHeartAccessoryBeShown", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIEquipment), Member = "ItemOver", MemberParameters = new object[]
	{
		typeof(Item[]),
		typeof(int),
		typeof(GUIEquipment.EquipmentItemType),
		typeof(int),
		typeof(ref int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public void AccessoryDyeOver(int index)
	{
		throw null;
	}

	// Token: 0x06000792 RID: 1938 RVA: 0x000231FB File Offset: 0x000213FB
	[global::Cpp2ILInjected.Token(Token = "0x600088C")]
	[global::Cpp2ILInjected.Address(RVA = "0x72FD98", Offset = "0x72FD98", Length = "0x998")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "CanDemonHeartAccessoryBeShown", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIEquipment), Member = "get_HasFocus", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "get_ControllerModeLocked", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_Equipment", ReturnType = typeof(GUIControllerEquipment))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "SetSelectHighlight", MemberParameters = new object[]
	{
		typeof(bool),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "IsMouseItem", MemberParameters = new object[]
	{
		typeof(Item[]),
		typeof(int)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseItem", ReturnType = typeof(Item))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIEquipment), Member = "CanBeStored", MemberParameters = new object[]
	{
		typeof(int),
		typeof(Item),
		typeof(int)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseItemTime", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AnimationCurve), Member = "Evaluate", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_inventoryScale", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Color), Member = "ToVector4", ReturnType = typeof(Microsoft.Xna.Framework.Vector4))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "GetColorByLoadout", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Color))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Graphics.Texture2D) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Division", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float)
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle?), Member = ".ctor", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "IsItemSlotUnlockedAndUsable", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "Draw", MemberParameters = new object[]
	{
		typeof(SpriteBatch),
		typeof(Item[]),
		typeof(int),
		typeof(int),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(void))]
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
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 45)]
	public void AccessoryDyeDraw(ItemGrid_Layout gridLayout, int index, Microsoft.Xna.Framework.Vector2 position, float scale)
	{
		throw null;
	}

	// Token: 0x06000793 RID: 1939 RVA: 0x000231FE File Offset: 0x000213FE
	[global::Cpp2ILInjected.Token(Token = "0x600088D")]
	[global::Cpp2ILInjected.Address(RVA = "0x730730", Offset = "0x730730", Length = "0x140")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "CanDemonHeartAccessoryBeShown", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIEquipment), Member = "ItemOver", MemberParameters = new object[]
	{
		typeof(Item[]),
		typeof(int),
		typeof(GUIEquipment.EquipmentItemType),
		typeof(int),
		typeof(ref int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public void AccessoryVanityOver(int index)
	{
		throw null;
	}

	// Token: 0x06000794 RID: 1940 RVA: 0x00023201 File Offset: 0x00021401
	[global::Cpp2ILInjected.Token(Token = "0x600088E")]
	[global::Cpp2ILInjected.Address(RVA = "0x730870", Offset = "0x730870", Length = "0x9B8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "CanDemonHeartAccessoryBeShown", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIEquipment), Member = "get_HasFocus", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "get_ControllerModeLocked", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_Equipment", ReturnType = typeof(GUIControllerEquipment))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "SetSelectHighlight", MemberParameters = new object[]
	{
		typeof(bool),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "IsMouseItem", MemberParameters = new object[]
	{
		typeof(Item[]),
		typeof(int)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseItem", ReturnType = typeof(Item))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIEquipment), Member = "CanBeStored", MemberParameters = new object[]
	{
		typeof(int),
		typeof(Item),
		typeof(int)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseItemTime", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AnimationCurve), Member = "Evaluate", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_inventoryScale", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Color), Member = "ToVector4", ReturnType = typeof(Microsoft.Xna.Framework.Vector4))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "GetColorByLoadout", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Color))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Graphics.Texture2D) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Division", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float)
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle?), Member = ".ctor", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "IsItemSlotUnlockedAndUsable", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "Draw", MemberParameters = new object[]
	{
		typeof(SpriteBatch),
		typeof(Item[]),
		typeof(int),
		typeof(int),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(void))]
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
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 46)]
	public void AccessoryVanityDraw(ItemGrid_Layout gridLayout, int index, Microsoft.Xna.Framework.Vector2 position, float scale)
	{
		throw null;
	}

	// Token: 0x06000795 RID: 1941 RVA: 0x00023204 File Offset: 0x00021404
	[global::Cpp2ILInjected.Token(Token = "0x600088F")]
	[global::Cpp2ILInjected.Address(RVA = "0x731228", Offset = "0x731228", Length = "0x990")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEquipment), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIEquipment), Member = "get_collapsed", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid.GetItemScaleHandler), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid.CursorOver), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid.DrawItemHandler), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid), Member = "Draw", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(GUIItemGrid.GetItemScaleHandler),
		typeof(GUIItemGrid.CursorOver),
		typeof(GUIItemGrid.DrawItemHandler),
		typeof(int),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeft", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseItem", ReturnType = typeof(Item))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "LeftClick", MemberParameters = new object[]
	{
		typeof(Item[]),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 55)]
	private void DrawAccesories()
	{
		throw null;
	}

	// Token: 0x06000796 RID: 1942 RVA: 0x00023207 File Offset: 0x00021407
	[global::Cpp2ILInjected.Token(Token = "0x6000890")]
	[global::Cpp2ILInjected.Address(RVA = "0x731BB8", Offset = "0x731BB8", Length = "0x48")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public float QuickSlotScale(int index)
	{
		throw null;
	}

	// Token: 0x06000797 RID: 1943 RVA: 0x0002320A File Offset: 0x0002140A
	[global::Cpp2ILInjected.Token(Token = "0x6000891")]
	[global::Cpp2ILInjected.Address(RVA = "0x731C00", Offset = "0x731C00", Length = "0x48")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public float QuickSlotScaleDye(int index)
	{
		throw null;
	}

	// Token: 0x06000798 RID: 1944 RVA: 0x0002320D File Offset: 0x0002140D
	[global::Cpp2ILInjected.Token(Token = "0x6000892")]
	[global::Cpp2ILInjected.Address(RVA = "0x731C48", Offset = "0x731C48", Length = "0xB0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIEquipment), Member = "ItemOver", MemberParameters = new object[]
	{
		typeof(Item[]),
		typeof(int),
		typeof(GUIEquipment.EquipmentItemType),
		typeof(int),
		typeof(ref int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public void QuickSlotOver(int index)
	{
		throw null;
	}

	// Token: 0x06000799 RID: 1945 RVA: 0x00023210 File Offset: 0x00021410
	[global::Cpp2ILInjected.Token(Token = "0x6000893")]
	[global::Cpp2ILInjected.Address(RVA = "0x731CF8", Offset = "0x731CF8", Length = "0x848")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIEquipment), Member = "get_HasFocus", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "get_ControllerModeLocked", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_Equipment", ReturnType = typeof(GUIControllerEquipment))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "SetSelectHighlight", MemberParameters = new object[]
	{
		typeof(bool),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "IsMouseItem", MemberParameters = new object[]
	{
		typeof(Item[]),
		typeof(int)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseItem", ReturnType = typeof(Item))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIEquipment), Member = "CanBeStored", MemberParameters = new object[]
	{
		typeof(int),
		typeof(Item),
		typeof(int)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseItemTime", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AnimationCurve), Member = "Evaluate", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_inventoryScale", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "Draw", MemberParameters = new object[]
	{
		typeof(SpriteBatch),
		typeof(Item[]),
		typeof(int),
		typeof(int),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Graphics.Texture2D) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Division", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Multiply", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Subtraction", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Addition", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitsByte), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
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
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 41)]
	public void QuickSlotDraw(ItemGrid_Layout gridLayout, int index, Microsoft.Xna.Framework.Vector2 position, float scale)
	{
		throw null;
	}

	// Token: 0x0600079A RID: 1946 RVA: 0x00023213 File Offset: 0x00021413
	[global::Cpp2ILInjected.Token(Token = "0x6000894")]
	[global::Cpp2ILInjected.Address(RVA = "0x732540", Offset = "0x732540", Length = "0x90")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIEquipment), Member = "ItemOver", MemberParameters = new object[]
	{
		typeof(Item[]),
		typeof(int),
		typeof(GUIEquipment.EquipmentItemType),
		typeof(int),
		typeof(ref int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public void QuickSlotDyeOver(int index)
	{
		throw null;
	}

	// Token: 0x0600079B RID: 1947 RVA: 0x00023216 File Offset: 0x00021416
	[global::Cpp2ILInjected.Token(Token = "0x6000895")]
	[global::Cpp2ILInjected.Address(RVA = "0x7325D0", Offset = "0x7325D0", Length = "0x440")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIEquipment), Member = "get_HasFocus", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "get_ControllerModeLocked", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_Equipment", ReturnType = typeof(GUIControllerEquipment))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "SetSelectHighlight", MemberParameters = new object[]
	{
		typeof(bool),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "IsMouseItem", MemberParameters = new object[]
	{
		typeof(Item[]),
		typeof(int)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseItem", ReturnType = typeof(Item))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIEquipment), Member = "CanBeStored", MemberParameters = new object[]
	{
		typeof(int),
		typeof(Item),
		typeof(int)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseItemTime", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AnimationCurve), Member = "Evaluate", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_inventoryScale", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "Draw", MemberParameters = new object[]
	{
		typeof(SpriteBatch),
		typeof(Item[]),
		typeof(int),
		typeof(int),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
	public void QuickSlotDyeDraw(ItemGrid_Layout gridLayout, int index, Microsoft.Xna.Framework.Vector2 position, float scale)
	{
		throw null;
	}

	// Token: 0x0600079C RID: 1948 RVA: 0x00023219 File Offset: 0x00021419
	[global::Cpp2ILInjected.Token(Token = "0x6000896")]
	[global::Cpp2ILInjected.Address(RVA = "0x732A10", Offset = "0x732A10", Length = "0x51C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEquipment), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIEquipment), Member = "get_collapsed", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid.GetItemScaleHandler), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid.CursorOver), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid.DrawItemHandler), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid), Member = "Draw", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(GUIItemGrid.GetItemScaleHandler),
		typeof(GUIItemGrid.CursorOver),
		typeof(GUIItemGrid.DrawItemHandler),
		typeof(int),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeft", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseItem", ReturnType = typeof(Item))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "LeftClick", MemberParameters = new object[]
	{
		typeof(Item[]),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 32)]
	private void DrawQuickSlots()
	{
		throw null;
	}

	// Token: 0x0600079D RID: 1949 RVA: 0x0002321C File Offset: 0x0002141C
	[global::Cpp2ILInjected.Token(Token = "0x6000897")]
	[global::Cpp2ILInjected.Address(RVA = "0x732F2C", Offset = "0x732F2C", Length = "0xF0")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEquipment), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "get_UsingTouchUI", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIString), Member = "Draw", MemberParameters = new object[]
	{
		typeof(String_Layout),
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
	private void DrawHeaders()
	{
		throw null;
	}

	// Token: 0x0600079E RID: 1950 RVA: 0x0002321F File Offset: 0x0002141F
	[global::Cpp2ILInjected.Token(Token = "0x6000898")]
	[global::Cpp2ILInjected.Address(RVA = "0x73301C", Offset = "0x73301C", Length = "0x404")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEquipment), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIEquipment), Member = "LoadPageRegion", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "get_DisplayTouchOptions", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIEquipment), Member = "get_collapsed", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Equipment_Layout), Member = "get_DisplaySetBonus", ReturnType = typeof(Button_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Equipment_Layout), Member = "get_DisplaySetBonusText", ReturnType = typeof(String_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIButton), Member = "RegisterPickingRegion", MemberParameters = new object[]
	{
		typeof(Button_Layout),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Button_Layout),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(float?)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIString), Member = "Draw", MemberParameters = new object[]
	{
		typeof(String_Layout),
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
	private void DrawArmourBonus()
	{
		throw null;
	}

	// Token: 0x0600079F RID: 1951 RVA: 0x00023222 File Offset: 0x00021422
	[global::Cpp2ILInjected.Token(Token = "0x6000899")]
	[global::Cpp2ILInjected.Address(RVA = "0x733420", Offset = "0x733420", Length = "0xC0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEquipment), Member = "DrawUnequipButton", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEquipment), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public Item GetSelectedItem()
	{
		throw null;
	}

	// Token: 0x060007A0 RID: 1952 RVA: 0x00023225 File Offset: 0x00021425
	[global::Cpp2ILInjected.Token(Token = "0x600089A")]
	[global::Cpp2ILInjected.Address(RVA = "0x7334E0", Offset = "0x7334E0", Length = "0x6B4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "DrawOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "DrawEditOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "get_PagePopupDisplayed", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIEquipment), Member = "GetSelectedItem", ReturnType = typeof(Item))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "CanStoreItem", MemberParameters = new object[]
	{
		typeof(int),
		typeof(Item)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_AnyControllerConnected", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_Equipment", ReturnType = typeof(GUIControllerEquipment))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIEquipment), Member = "get_HasFocus", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "DrawWithBanner", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(GUIControlsBanner.ActionSource),
		typeof(ControllerActionButton),
		typeof(Item),
		typeof(string),
		typeof(bool),
		typeof(ref float),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(GUITransactionButton.InputState))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "DrawWithBanner", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(GUIControlsBanner.ActionSource),
		typeof(ControllerActionButton),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(Rectangle),
		typeof(string),
		typeof(bool),
		typeof(ref float),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(GUITransactionButton.InputState))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageOptions), Member = "PopRight", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "GetItem", MemberParameters = new object[]
	{
		typeof(int),
		typeof(Item),
		typeof(GetItemSettings),
		typeof(bool)
	}, ReturnType = typeof(Item))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
	public void DrawUnequipButton()
	{
		throw null;
	}

	// Token: 0x060007A1 RID: 1953 RVA: 0x00023228 File Offset: 0x00021428
	[global::Cpp2ILInjected.Token(Token = "0x600089B")]
	[global::Cpp2ILInjected.Address(RVA = "0x733B94", Offset = "0x733B94", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public bool CanBeHiddenOrShow()
	{
		throw null;
	}

	// Token: 0x060007A2 RID: 1954 RVA: 0x0002322B File Offset: 0x0002142B
	[global::Cpp2ILInjected.Token(Token = "0x600089C")]
	[global::Cpp2ILInjected.Address(RVA = "0x733B9C", Offset = "0x733B9C", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public void DrawExpandButton()
	{
		throw null;
	}

	// Token: 0x060007A3 RID: 1955 RVA: 0x0002322E File Offset: 0x0002142E
	[global::Cpp2ILInjected.Token(Token = "0x600089D")]
	[global::Cpp2ILInjected.Address(RVA = "0x733BA0", Offset = "0x733BA0", Length = "0x88C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "DrawOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "DrawEditOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_AnyControllerConnected", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_Equipment", ReturnType = typeof(GUIControllerEquipment))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIEquipment), Member = "get_HasFocus", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "DrawWithBanner", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(GUIControlsBanner.ActionSource),
		typeof(ControllerActionButton),
		typeof(Item),
		typeof(string),
		typeof(bool),
		typeof(ref float),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(GUITransactionButton.InputState))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageOptions), Member = "PopRight", ReturnType = typeof(void))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitsByte), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "TogglePet", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "ToggleLight", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
	public void DrawHideShowButton()
	{
		throw null;
	}

	// Token: 0x170000B7 RID: 183
	// (get) Token: 0x060007A4 RID: 1956 RVA: 0x00023231 File Offset: 0x00021431
	[global::Cpp2ILInjected.Token(Token = "0x170000DC")]
	public bool HasFocus
	{
		[global::Cpp2ILInjected.Token(Token = "0x600089E")]
		[global::Cpp2ILInjected.Address(RVA = "0x72D644", Offset = "0x72D644", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIAccessoryInfoToggles), Member = "DrawToggles", ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEquipment), Member = "DrawUnequipButton", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEquipment), Member = "DrawHideShowButton", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEquipment), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEquipmentLoadout), Member = "DrawToggles", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "DrawOptions", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "DrawEditOptions", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 30)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "get_CurrentPlatform", ReturnType = typeof(DrPlatform.DrPlatformType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_Equipment", ReturnType = typeof(GUIControllerEquipment))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060007A5 RID: 1957 RVA: 0x00023234 File Offset: 0x00021434
	[global::Cpp2ILInjected.Token(Token = "0x600089F")]
	[global::Cpp2ILInjected.Address(RVA = "0x73442C", Offset = "0x73442C", Length = "0x188")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "DrawPageContent", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Time), Member = "get_deltaTime", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIEquipment), Member = "DrawArmour", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIEquipment), Member = "DrawAccesories", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIEquipment), Member = "DrawQuickSlots", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIEquipment), Member = "DrawHeaders", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIEquipment), Member = "DrawArmourBonus", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIEquipment), Member = "get_HasFocus", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_Equipment", ReturnType = typeof(GUIControllerEquipment))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMouseItem), Member = "get_HoldingItem", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIEquipment), Member = "GetSelectedItem", ReturnType = typeof(Item))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControlsBanner), Member = "AddAction", MemberParameters = new object[]
	{
		typeof(GUIControlsBanner.ActionSource),
		typeof(ControllerActionButton),
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public void Draw()
	{
		throw null;
	}

	// Token: 0x060007A6 RID: 1958 RVA: 0x00023237 File Offset: 0x00021437
	[global::Cpp2ILInjected.Token(Token = "0x60008A0")]
	[global::Cpp2ILInjected.Address(RVA = "0x7345B4", Offset = "0x7345B4", Length = "0x40")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInstance), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIEquipment()
	{
		throw null;
	}

	// Token: 0x04000507 RID: 1287
	[global::Cpp2ILInjected.Token(Token = "0x4000752")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private int cursorOver;

	// Token: 0x04000508 RID: 1288
	[global::Cpp2ILInjected.Token(Token = "0x4000753")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	private int itemOver;

	// Token: 0x04000509 RID: 1289
	[global::Cpp2ILInjected.Token(Token = "0x4000754")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private int itemDragStartArmour;

	// Token: 0x0400050A RID: 1290
	[global::Cpp2ILInjected.Token(Token = "0x4000755")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	private int itemDragStartArmourDye;

	// Token: 0x0400050B RID: 1291
	[global::Cpp2ILInjected.Token(Token = "0x4000756")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private int itemDragStartArmourVanity;

	// Token: 0x0400050C RID: 1292
	[global::Cpp2ILInjected.Token(Token = "0x4000757")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	private int itemDragStartAccessory;

	// Token: 0x0400050D RID: 1293
	[global::Cpp2ILInjected.Token(Token = "0x4000758")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private int itemDragStartAccessoryDye;

	// Token: 0x0400050E RID: 1294
	[global::Cpp2ILInjected.Token(Token = "0x4000759")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	private int itemDragStartAccessoryVanity;

	// Token: 0x0400050F RID: 1295
	[global::Cpp2ILInjected.Token(Token = "0x400075A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	private int itemDragStartQuickSlot;

	// Token: 0x04000510 RID: 1296
	[global::Cpp2ILInjected.Token(Token = "0x400075B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
	private int itemDragStartQuickSlotDye;

	// Token: 0x04000511 RID: 1297
	[global::Cpp2ILInjected.Token(Token = "0x400075C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	private float collapseAnimationTime;

	// Token: 0x04000512 RID: 1298
	[global::Cpp2ILInjected.Token(Token = "0x400075D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
	private GUIEquipment.EquipmentItemType lastItemTypeClicked;

	// Token: 0x04000513 RID: 1299
	[global::Cpp2ILInjected.Token(Token = "0x400075E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	private int lastItemClicked;

	// Token: 0x04000514 RID: 1300
	[global::Cpp2ILInjected.Token(Token = "0x400075F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
	private float doubleClickTimer;

	// Token: 0x04000515 RID: 1301
	[global::Cpp2ILInjected.Token(Token = "0x4000760")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	private bool rightClickHeld;

	// Token: 0x04000516 RID: 1302
	[global::Cpp2ILInjected.Token(Token = "0x4000761")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
	private GUIEquipment.EquipmentItemType itemType;

	// Token: 0x04000517 RID: 1303
	[global::Cpp2ILInjected.Token(Token = "0x4000762")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	private int itemPieceSelected;

	// Token: 0x04000518 RID: 1304
	[global::Cpp2ILInjected.Token(Token = "0x4000763")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
	private float UnequipButtonScale;

	// Token: 0x04000519 RID: 1305
	[global::Cpp2ILInjected.Token(Token = "0x4000764")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	private float HideShowButtonScale;

	// Token: 0x0400051A RID: 1306
	[global::Cpp2ILInjected.Token(Token = "0x4000765")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
	private float globalAnimationOffset;

	// Token: 0x0400051B RID: 1307
	[global::Cpp2ILInjected.Token(Token = "0x4000766")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	private float row1AnimationOffset;

	// Token: 0x0400051C RID: 1308
	[global::Cpp2ILInjected.Token(Token = "0x4000767")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x64")]
	private float row2AnimationOffset;

	// Token: 0x0400051D RID: 1309
	[global::Cpp2ILInjected.Token(Token = "0x4000768")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	private float row1AnimationScale;

	// Token: 0x0400051E RID: 1310
	[global::Cpp2ILInjected.Token(Token = "0x4000769")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x6C")]
	private float row2AnimationScale;

	// Token: 0x0400051F RID: 1311
	[global::Cpp2ILInjected.Token(Token = "0x400076A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	private int accOffset;

	// Token: 0x04000520 RID: 1312
	[global::Cpp2ILInjected.Token(Token = "0x400076B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x74")]
	private float ExpandButtonScale;

	// Token: 0x020007C3 RID: 1987
	[global::Cpp2ILInjected.Token(Token = "0x200013F")]
	private enum EquipmentItemType
	{
		// Token: 0x04007A16 RID: 31254
		[global::Cpp2ILInjected.Token(Token = "0x400076D")]
		Armour,
		// Token: 0x04007A17 RID: 31255
		[global::Cpp2ILInjected.Token(Token = "0x400076E")]
		ArmourDye,
		// Token: 0x04007A18 RID: 31256
		[global::Cpp2ILInjected.Token(Token = "0x400076F")]
		ArmourVanity,
		// Token: 0x04007A19 RID: 31257
		[global::Cpp2ILInjected.Token(Token = "0x4000770")]
		Accessory,
		// Token: 0x04007A1A RID: 31258
		[global::Cpp2ILInjected.Token(Token = "0x4000771")]
		AccessoryDye,
		// Token: 0x04007A1B RID: 31259
		[global::Cpp2ILInjected.Token(Token = "0x4000772")]
		AccessoryVanity,
		// Token: 0x04007A1C RID: 31260
		[global::Cpp2ILInjected.Token(Token = "0x4000773")]
		QuickSlot,
		// Token: 0x04007A1D RID: 31261
		[global::Cpp2ILInjected.Token(Token = "0x4000774")]
		QuickSlotDye
	}
}
